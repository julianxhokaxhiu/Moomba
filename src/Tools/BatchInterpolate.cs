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
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moomba.Tools
{
    public partial class BatchInterpolate : Form
    {
        private FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        private bool isRunning = false;

        public BatchInterpolate()
        {
            InitializeComponent();
        }

        private void toggleUserInteraction()
        {
            isRunning = !isRunning;

            btnCancel.Enabled = !isRunning;
            btnRun.Enabled = !isRunning;
        }

        private async Task runBatchConversion()
        {
            string[] inFiles = Directory.GetFiles(txtInPath.Text);

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = inFiles.Length;

            foreach (string filePath in inFiles)
            {
                FileInfo inFile = new FileInfo(filePath);

                if (inFile.Exists)
                {
                    if (inFile.Extension == ".cam")
                    {
                        CamData[] data = new CamData[DataManipulation.getNumberOfFrames(inFile)];

                        lstProgress.Items.Add("Processing " + inFile.Name + ": Frames: " + data.Length + " => " + data.Length * 2);
                        lstProgress.TopIndex = lstProgress.Items.Count - 1;
                        lstProgress.Refresh();

                        await Task.Run(() =>
                        {
                            DataManipulation.parse(inFile, ref data);
                            DataManipulation.interpolate(ref data);
                            DataManipulation.dump(txtOutPath.Text + "\\" + inFile.Name, ref data);
                        });

                        data = null;
                    }
                    else
                    {
                        lstProgress.Items.Add("Skipping " + inFile.Name);
                        lstProgress.TopIndex = lstProgress.Items.Count - 1;
                        lstProgress.Refresh();
                    }
                }
                else
                {
                    lstProgress.Items.Add("Could not find " + inFile.Name);
                    lstProgress.TopIndex = lstProgress.Items.Count - 1;
                    lstProgress.Refresh();
                }

                progressBar.Value++;
            }
        }

        private void btnPickInPath_Click(object sender, System.EventArgs e)
        {
            if ( folderBrowser.ShowDialog() == DialogResult.OK )
            {
                txtInPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnPickOutPath_Click(object sender, System.EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtOutPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async void btnRun_Click(object sender, System.EventArgs e)
        {
            toggleUserInteraction();
            await runBatchConversion();
            toggleUserInteraction();
        }

        private void BatchInterpolate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isRunning;
        }
    }
}
