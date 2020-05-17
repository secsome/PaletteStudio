using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using PaletteStudio.FileSystem;

namespace PaletteStudio.GUI
{
    public class PalPanel :Panel
    {
        private int cellWidth, cellHeight;

        #region Ctor - PalPanel
        public PalPanel()
        {
            //DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
        }
        #endregion

        #region Custom Events - PalPanel
        public delegate void SelectedIndexChangedHandle(object sender, EventArgs e);
        public event SelectedIndexChangedHandle SelectedIndexChanged;
        #endregion

        #region Protected Overrides - PalPanel

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (IsSelectable)
            {
                byte idx = FromPoint(e.X / cellWidth, e.Y / cellHeight);
                int tmp = Selections.IndexOf(idx);
                switch (ModifierKeys)
                {
                    case Keys.Control:
                        if (tmp == -1) Selections.Add(idx);
                        else Selections.RemoveAt(tmp);
                        break;
                    case Keys.Shift:
                        if (Selections.Count > 0)
                        {
                            if (Selections.Last() == idx)
                            {
                                Selections.RemoveAt(Selections.Count - 1);
                            }
                            else
                            {
                                if (Selections.Last() < idx)
                                {
                                    for (int i = Selections.Last() + 1; i <= idx; i++)
                                        if (tmp == -1) Selections.Add((byte)i);
                                }
                                else
                                {
                                    for (int i = Selections.Last() - 1; i >= idx; i--)
                                        if (tmp == -1) Selections.Add((byte)i);
                                }
                            }


                        }
                        break;
                    default:
                        Selections.Clear();
                        Selections.Add(idx);
                        break;
                }
                Focus();
                if (PalSource != null)
                    SelectedIndexChanged(this, new EventArgs());
                Refresh();
            }
            
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
                {
                    if (Selections.Count == 0) Selections.Add(0);
                    foreach (byte selected in Selections)
                    {
                        Color crossColor = Color.FromArgb(PalSource[(byte)(GetPoint(selected).X * 32 + GetPoint(selected).Y)]);
                        Pen crossPen = new Pen(GetCrossColor(crossColor), 1.2F);
                        int stX = GetPoint(selected).X * cellWidth, stY = GetPoint(selected).Y * cellHeight;
                        g.DrawRectangle(crossPen, stX, stY, cellWidth, cellHeight);
                        g.DrawLine(crossPen, stX, stY, stX + cellWidth, stY + cellHeight);
                        g.DrawLine(crossPen, stX + cellWidth, stY, stX, stY + cellHeight);
                        crossPen.Dispose();
                    }
                }
                e.Graphics.DrawImage(map, new Rectangle(0, 0, Width, Height), new Rectangle(0, 0, Width, Height), GraphicsUnit.Pixel);
                if (IsSelectable)   SelectedIndexChanged(this, new EventArgs());
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
            Refresh();
        }
        #endregion

        #region Public Calls - PalPanel
        public PalFile PalSource { get; set; }
        public List<byte> Selections { get; private set; } = new List<byte>();
        public bool IsInitialized { get; private set; } = false;
        public bool IsSelectable { get; set; } = true;
        #endregion
    }
}
