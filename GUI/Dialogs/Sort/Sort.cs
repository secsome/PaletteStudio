﻿using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Sort : Form
    {
        private PalFile OrigionPal { get; set; } = new PalFile();
        private List<byte> OriginSelections { get; set; } = new List<byte>();
        public Sort(PalFile pal,List<byte> selects)
        {
            InitializeComponent();
            Misc.SetLanguage(this);
            OrigionPal = pal;
            OriginSelections = selects;
            PreviewPanel.PalSource = new PalFile();
            for (int i = 0; i < 256; i++)
                PreviewPanel.PalSource[(byte)i] = OrigionPal[(byte)i];
            PreviewPanel.Selections = OriginSelections;
            PreviewPanel.Refresh();
            InitializeRadioButtons();
        }

        private void InitializeRadioButtons()
        {
            isUpdatingRadioButtons = true;
            rbtnPerferances(null, new EventArgs());
            rbtnOrder(null, new EventArgs());
            rbtnRange(null, new EventArgs());
            if (PreviewPanel.Selections.Count > 1) DoSort();
            isUpdatingRadioButtons = false;
        }

        private void ckbVisible_CheckedChanged(object sender, EventArgs e)
        {
            PreviewPanel.IsSelectVisible = ckbVisible.Checked;
            PreviewPanel.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
                OrigionPal[(byte)i] = PreviewPanel.PalSource[(byte)i];
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Sort_Paint(object sender, PaintEventArgs e)
        {
            Misc.SetLanguage(this);
        }
    }
}
