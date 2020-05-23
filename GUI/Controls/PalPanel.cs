using PaletteStudio.FileSystem;
using PaletteStudio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace PaletteStudio.GUI
{
    public class PalPanel :Panel
    {
        private int cellWidth, cellHeight;

        #region Ctor - PalPanel
        public PalPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
        }
        #endregion

        #region Custom Events - PalPanel
        public delegate void SelectedIndexChangedHandle(object sender, EventArgs e);
        public delegate void BackColorChangedHandle(object sender, EventArgs e);
        public delegate void PalSourceChangingHandle(object sender, EventArgs e);
        public delegate void PalSourceChangedHandle(object sender, EventArgs e);

        public event SelectedIndexChangedHandle SelectedIndexChanged;
        public new event BackColorChangedHandle BackColorChanged;
        public event PalSourceChangingHandle PalSourceChanging;
        public event PalSourceChangedHandle PalSourceChanged;
        #endregion

        #region Protected Overrides - PalPanel
        protected override bool IsInputKey(Keys keyData)
        {
            if (PalSource == null) return false;
            Cursor = Cursors.Default;
            byte idx = Selections.LastOrDefault();
            int curX = idx / 32;
            int curY = idx % 32;
            switch (keyData)
            {
                // Functional Keys
                case Keys.Control:
                case Keys.Shift:
                case Keys.Alt:
                    return true;

                // Move Idx
                case Keys.Up:
                    if (curY > 0)
                        UpdateSelection((byte)(idx - 1));
                    else if (curX > 0) UpdateSelection((byte)(idx - 1));
                    return true;
                case Keys.Down:
                    if (curY < 31)
                        UpdateSelection((byte)(idx + 1));
                    else if (curX < 7) UpdateSelection((byte)(idx + 1));
                    return true;
                case Keys.Left:
                    if (curX > 0)
                        UpdateSelection((byte)(idx - 32));
                    return true;
                case Keys.Right:
                    if (curX < 7)
                        UpdateSelection((byte)(idx + 32));
                    return true;

                case Keys.Delete:
                    if (IsEditable)
                    {
                        PalSourceChanging?.Invoke(this, new EventArgs());
                        if (!Selections.Contains(idx)) Selections.Add(idx);
                        foreach (byte i in Selections) PalSource[i] = BackColor;
                        PalSourceChanged?.Invoke(this, new EventArgs());
                    }
                    return true;
            }
            return false;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            Focus();
            if (PalSource == null) return;
            byte idx = FromPoint(e.X / cellWidth, e.Y / cellHeight);
            UpdateSelection(idx);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (PalSource != null)
            {
                Bitmap map = new Bitmap(Width, Height);
                Graphics g = Graphics.FromImage(map);
                g.PageUnit = GraphicsUnit.Pixel;
                for (int i = 0, idx = 0; i < 8; i++)
                    for (int j = 0; j < 32; j++)
                        g.FillRectangle(new SolidBrush(Color.FromArgb(PalSource[(byte)(idx++)])), new Rectangle(i * cellWidth, j * cellHeight, cellWidth, cellHeight));
                if (IsSelectable)
                    if (Selections.Count == 0) 
                        Selections.Add(0);
                if (IsSelectVisible)
                {
                    foreach (byte selected in Selections)
                    {
                        Color crossColor = Color.FromArgb(PalSource[(byte)(GetPoint(selected).X * 32 + GetPoint(selected).Y)]);
                        Pen crossPen = new Pen(GetCrossColor(crossColor), 1.2F);
                        int stX = GetPoint(selected).X * cellWidth, stY = GetPoint(selected).Y * cellHeight;
                        g.DrawRectangle(crossPen, stX, stY, cellWidth, cellHeight);
                        g.DrawLine(crossPen, stX, stY, stX + (float)0.25*cellWidth, stY + (float)0.25 * cellHeight); // Left Up
                        g.DrawLine(crossPen, stX + (float)0.75 * cellWidth, stY + (float)0.75 * cellHeight, stX + cellWidth, stY + cellHeight); // Right Down
                        g.DrawLine(crossPen, stX + cellWidth, stY, stX + (float)0.75 * cellWidth, stY + (float)0.25 * cellHeight); // Right Up
                        g.DrawLine(crossPen, stX + (float)0.25 * cellWidth, stY+ (float)0.75 * cellHeight, stX, stY + cellHeight); // Left Down
                        crossPen.Dispose();
                    }
                }
                e.Graphics.DrawImage(map, new Rectangle(0, 0, Width, Height), new Rectangle(0, 0, Width, Height), GraphicsUnit.Pixel);
                IsInitialized = true;
                g.Dispose();
            }
            else
            {
                IsInitialized = false;
                base.OnPaint(e);
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            cellWidth = Width / 8;
            cellHeight = Height / 32;
            Refresh();
        }
        #endregion

        #region Private Methods - PalPanel
        private void UpdateSelection(byte idx)
        {
            if (PalSource == null) return;
            if (ModifierKeys == Keys.Alt)
            {
                BackColor = PalSource[idx];
                BackColorChanged?.Invoke(this, new EventArgs());
                return;
            }
            if (!IsSelectable) return;
            if (IsMultiSelect)
            {
                switch (ModifierKeys)
                {
                    case Keys.Control:
                        if (Selections.Contains(idx)) Selections.Remove(idx);
                        else Selections.Add(idx);
                        break;
                    case Keys.Shift:
                        if (Selections.Count == 0)
                        {
                            Selections.Add(idx);
                            break;
                        }
                        if (Selections.Last() == idx)
                        {
                            Selections.Remove(idx);
                        }
                        else
                        {
                            if (Selections.Last() < idx)
                            {
                                for (int i = Selections.Last() + 1; i <= idx; i++)
                                    if (!Selections.Contains((byte)i)) Selections.Add((byte)i);
                            }
                            else
                            {
                                for (int i = Selections.Last() - 1; i >= idx; i--)
                                    if (!Selections.Contains((byte)i)) Selections.Add((byte)i);
                            }
                        }
                        break;
                    default:
                        Selections.Clear();
                        Selections.Add(idx);
                        break;
                }
            }
            else
            {
                Selections.Clear();
                Selections.Add(idx);
            }
            if (PalSource != null)
                SelectedIndexChanged?.Invoke(this, new EventArgs());
            if (IsSelectVisible) Refresh();
        }
        private Point GetPoint(byte idx)
        {
            return new Point(idx / 32, idx % 32);
        }
        private byte FromPoint(int x, int y)
        {
            return (byte)(x * 32 + y);
        }
        private byte FromPoint(Point pnt)
        {
            return FromPoint(pnt.X, pnt.Y);
        }
        private Color GetCrossColor(Color src)
        {
            return Color.FromArgb(
                GetCrossColor(src.R),
                GetCrossColor(src.G),
                GetCrossColor(src.B)
                );
        }
        private int GetCrossColor(int val)
        {
            if (val < 64) return 255 - val;
            if (val < 128) return 255 - val + 64;
            if (val < 192) return 255 - val - 64;
            return 255 - val;
        }
        #endregion

        #region Public Methods - PalPanel
        public void Close()
        {
            PalSource = null;
            Selections.Clear();
            Refresh();
        }
        #endregion

        #region Public Calls - PalPanel
        public PalFile PalSource { get; set; } = null;
        public List<byte> Selections { get; set; } = new List<byte>();
        public bool IsInitialized { get; private set; } = false;
        public bool IsSelectVisible { get; set; } = true;
        public bool IsSelectable { get; set; } = true;
        public bool IsEditable { get; set; } = false;
        public bool IsMultiSelect { get; set; } = true;
        public bool AllowDropOpen { get; set; } = false;
        public new int BackColor { get; set; } = Constant.Colors.PaletteBlack; // 252, 0, 0, 0
        #endregion
    }
}
