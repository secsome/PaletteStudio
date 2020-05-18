using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaletteStudio.Common;
using PaletteStudio.Utils;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Sort : Form
    {
        SortPrerferances Preferance;
        bool IsIncrease, IsAll;

        #region Radio Buttons
        private bool isUpdatingRadioButtons = false;
        private void rbtnPerferances(object sender, EventArgs e)
        {
            if (rbtnRed.Checked) Preferance = SortPrerferances.Red;
            else if (rbtnGreen.Checked) Preferance = SortPrerferances.Green;
            else if (rbtnBlue.Checked) Preferance = SortPrerferances.Blue;
            else if (rbtnHue.Checked) Preferance = SortPrerferances.Hue;
            else if (rbtnSaturation.Checked) Preferance = SortPrerferances.Saturation;
            else if (rbtnBrightness.Checked) Preferance = SortPrerferances.Brightness;
            else if (rbtnGray.Checked) Preferance = SortPrerferances.Gray;
            else if (rbtnArgb.Checked) Preferance = SortPrerferances.Argb;
            else if (rbtnComprehensive.Checked) Preferance = SortPrerferances.Comprehensive;
            else rbtnRed.Checked = true;
            if (!isUpdatingRadioButtons) DoSort();
        }
        private void rbtnOrder(object sender, EventArgs e)
        {
            if (rbtnIncrease.Checked) IsIncrease = true;
            else if (rbtnDecrease.Checked) IsIncrease = false;
            else rbtnIncrease.Checked = true; // For Debug
            if (!isUpdatingRadioButtons) DoSort();
        }
        private void rbtnRange(object sender, EventArgs e)
        {
            if (rbtnAll.Checked) IsAll = true;
            else if (rbtnSelected.Checked) IsAll = false;
            else rbtnAll.Checked = true; // For Debug
            if (!isUpdatingRadioButtons) DoSort();
        }
        #endregion

        #region Sort Method
        private bool DoSort(List<int> data)
        {
            switch (Preferance)
            {
                case SortPrerferances.Red:
                    data.Sort((a, b) => Color.FromArgb(a).R.CompareTo(Color.FromArgb(b).R));
                    return true;
                case SortPrerferances.Green:
                    data.Sort((a, b) => Color.FromArgb(a).G.CompareTo(Color.FromArgb(b).G));
                    return true;
                case SortPrerferances.Blue:
                    data.Sort((a, b) => Color.FromArgb(a).B.CompareTo(Color.FromArgb(b).B));
                    return true;
                case SortPrerferances.Hue:
                    data.Sort((a, b) => Color.FromArgb(a).GetHue().CompareTo(Color.FromArgb(b).GetHue()));
                    return true;
                case SortPrerferances.Saturation:
                    data.Sort((a, b) => Color.FromArgb(a).GetSaturation().CompareTo(Color.FromArgb(b).GetSaturation()));
                    return true;
                case SortPrerferances.Brightness:
                    data.Sort((a, b) => Color.FromArgb(a).GetBrightness().CompareTo(Color.FromArgb(b).GetBrightness()));
                    return true;
                case SortPrerferances.Gray:
                    data.Sort((a, b) => Misc.ColorToGray(Color.FromArgb(a)).CompareTo(Misc.ColorToGray(Color.FromArgb(b))));
                    return true;
                case SortPrerferances.Argb:
                    data.Sort((a, b) => a.CompareTo(b));
                    return true;
                case SortPrerferances.Comprehensive:
                    data.Sort(
                        (a, b) => 
                        (Color.FromArgb(a).R+ Color.FromArgb(a).G+ Color.FromArgb(a).B).
                        CompareTo(
                        Color.FromArgb(b).R + Color.FromArgb(b).G + Color.FromArgb(b).B
                        ));
                    return true;
                default:
                    return false;
            }
        }
        private void DoSort()
        {
            for(int i = 0; i < 256; i++)
                PreviewPanel.PalSource[(byte)i] = OrigionPal[(byte)i];
            PreviewPanel.Selections = OriginSelections;
            List<byte> sortSelections = new List<byte>();
            List<int> sortValues = new List<int>();
            if (IsAll)
            {
                for (int i = 0; i < 256; i++)
                {
                    sortSelections.Add((byte)i);
                    sortValues.Add(OrigionPal[(byte)i]);
                }
            }
            else
            {
                foreach(byte j in PreviewPanel.Selections)
                {
                    sortSelections.Add(j);
                    sortValues.Add(OrigionPal[j]);
                }
            }
            DoSort(sortValues);
            for (int i = 0; i < sortSelections.Count; i++)
                PreviewPanel.PalSource[sortSelections[i]] = sortValues[IsIncrease ? i : sortSelections.Count - 1 - i];
            PreviewPanel.Refresh();
        }
        #endregion
    }
}
