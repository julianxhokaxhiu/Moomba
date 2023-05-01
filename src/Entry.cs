/***************************************************************************
*    Copyright (C) 2023 Julian Xhokaxhiu                                   *
*                                                                          *
*    This file is part of Moomba                                           *
*                                                                          *
*    Moomba is free software: you can redistribute it and/or modify        *
*    it under the terms of the GNU General Public License as published by  *
*    the Free Software Foundation, either version 3 of the License         *
*                                                                          *
*    Moomba is distributed in the hope that it will be useful,             *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of        *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
*    GNU General Public License for more details.                          *
***************************************************************************/

using Moomba.Core;
using Moomba.Tools;
using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Moomba
{
    public partial class Entry : Form
    {
        private CamData[] camData;
        private FileInfo fileInfo;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Entry()
        {
            InitializeComponent();
        }

        private bool parseCamFile(string camFile)
        {
            fileInfo = new FileInfo(camFile);

            camData = new CamData[DataManipulation.getNumberOfFrames(fileInfo)];

            return DataManipulation.parse(fileInfo, ref camData);
        }

        private bool dumpCamFile(string camFile)
        {
            return DataManipulation.dump(camFile, ref camData);
        }

        private void renderList()
        {
            lstView.Items.Clear();

            lblTotalFrames.Text = "Total Frames: " + camData.Length;

            for (int idx = 0; idx < camData.Length; ++idx)
            {
                string[] item =
                {
                    (idx + 1).ToString(),
                    "( " + camData[idx].eye_x + ", " + camData[idx].eye_y + ", " + camData[idx].eye_z + " )",
                    "( " + camData[idx].target_x + ", " + camData[idx].target_y + ", " + camData[idx].target_z + " )",
                    "( " + camData[idx].up_x + ", " + camData[idx].up_y + ", " + camData[idx].up_z + " )",
                    "( " + camData[idx].pos_x + ", " + camData[idx].pos_y + ", " + camData[idx].pos_z + " )",
                    "( " + camData[idx].pan_x + ", " + camData[idx].pan_y + " )",
                    camData[idx].zoom.ToString(),
                    camData[idx].zoom2.ToString(),
                    "0x" + Convert.ToByte(camData[idx].render_mode).ToString("x2")
                };

                lstView.Items.Add(new ListViewItem(item));
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "FF8 CAM file|*.cam|All files (*.*)|*.*";
            openFileDialog.DefaultExt = "cam";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                parseCamFile(openFileDialog.FileName);
                renderList();

                saveAsToolStripMenuItem.Enabled = true;
                interpolateToolStripMenuItem.Enabled = true;

                this.Text = "Moomba (" + openFileDialog.FileName + ")";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/julianxhokaxhiu/Moomba");
        }

        private void Entry_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        lstView.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Selected = true);
                        break;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "FF8 CAM file|*.cam|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "cam";
            saveFileDialog.FileName = fileInfo.Name;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string camFile = saveFileDialog.FileName;

                if (dumpCamFile(camFile))
                    MessageBox.Show("Cam file was successfully saved in:\n\n" + camFile, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void batchInterpolateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchInterpolate batchInterpolate = new BatchInterpolate();

            batchInterpolate.ShowDialog();
        }

        private void interpolateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataManipulation.interpolate(ref camData);

            renderList();
        }
    }
}
