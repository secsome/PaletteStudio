﻿using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Paste : Form
    {
        private PalFile OriginPal = new PalFile();
        private List<Tuple<byte, int>> OriginDatas = new List<Tuple<byte, int>>();
        private byte OriginSelecting = 0;
        private bool IsOrigin = false;

        public Paste(PalFile palFile, List<Tuple<byte, int>> data, byte nowSelectOn)
        {
            InitializeComponent();
            Misc.SetLanguage(this);
            OriginDatas = data;
            OriginPal = palFile;
            OriginSelecting = nowSelectOn;
            PreviewPanel.PalSource = new PalFile();
            for (int i = 0; i < 256; i++) PreviewPanel.PalSource[(byte)i] = OriginPal[(byte)i];
            PreviewPanel.Selections.Add(OriginSelecting);
            rbtnPasteTo_CheckedChanged(null, new EventArgs());
            UpdatePreview();
        }

        public void UpdatePreview()
        {
            for (int i = 0; i < 256; i++) PreviewPanel.PalSource[(byte)i] = OriginPal[(byte)i];
            if (IsOrigin)
            {
                foreach(Tuple<byte,int> val in OriginDatas)
                {
                    PreviewPanel.PalSource[val.Item1] = val.Item2;
                }
            }
            else
            {
                byte startingIdx = OriginDatas[0].Item1;
                byte newStartingIdx = (byte)nudStarting.Value;
                for (int i = 0; i < OriginDatas.Count; i++) 
                {
                    int myi = ckbReserved.Checked ? (OriginDatas.Count - 1 - i) : i;
                    Tuple<byte, int> val = OriginDatas[myi];
                    int colorArgb = val.Item2;
                    int delta = val.Item1 - startingIdx;
                    int myDelta = ckbIgnoreSpace.Checked ? i : delta;
                    if (ckbBack2Front.Checked) myDelta = -myDelta;
                    int newidx = newStartingIdx + myDelta;
                    if (newidx > 255 || newidx < 0) 
                    {
                        if (rbtnToTheEnd.Checked) break;
                        else newidx -= ckbBack2Front.Checked ? -256 : 256;
                    }
                    PreviewPanel.PalSource[(byte)newidx] = colorArgb;
                }
            }
            Refresh();
        }

        private void rbtnPasteTo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOrigin.Checked)
            {
                foreach (Control c in groupBox2.Controls) c.Enabled = false;
                IsOrigin = true;
            }
            else
            {
                foreach (Control c in groupBox2.Controls) c.Enabled = true;
                ckbReserved.Enabled = false;
                nudStarting.Value = PreviewPanel.Selections.LastOrDefault();
                IsOrigin = false;
            }
            UpdatePreview();
        }

        private void ckbBack2Front_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBack2Front.Checked)
            {
                rbtnToTheEnd.Text = Language.DICT["PasterdbPaste2Begin"];
                rbtnJumpToStart.Text = Language.DICT["PasterdbCycle2End"];
            }
            else
            {
                rbtnToTheEnd.Text = Language.DICT["PasterdbPaste2End"];
                rbtnJumpToStart.Text = Language.DICT["PasterdbCycle2Start"];
            }
            UpdatePreview();
        }

        private void nudStarting_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void ckbIgnoreSpace_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePreview();
            if (!ckbIgnoreSpace.Checked)
            {
                ckbReserved.Enabled = false;
                ckbReserved.Checked = false;
            }
            else ckbReserved.Enabled = true;
        }

        private void ckbReserved_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void rbtnCustoms_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++) OriginPal[(byte)i] = PreviewPanel.PalSource[(byte)i];
            Close();
        }

        private void PreviewPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
