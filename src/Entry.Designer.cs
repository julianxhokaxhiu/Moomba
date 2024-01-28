/***************************************************************************
*    Copyright (C) 2024 Julian Xhokaxhiu                                   *
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

namespace Moomba
{
    partial class Entry
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            interpolateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            batchInterpolateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTotalFrames = new System.Windows.Forms.ToolStripMenuItem();
            lstView = new System.Windows.Forms.ListView();
            chID = new System.Windows.Forms.ColumnHeader();
            chEye = new System.Windows.Forms.ColumnHeader();
            chTarget = new System.Windows.Forms.ColumnHeader();
            chUp = new System.Windows.Forms.ColumnHeader();
            chPosition = new System.Windows.Forms.ColumnHeader();
            chPan = new System.Windows.Forms.ColumnHeader();
            chZoom = new System.Windows.Forms.ColumnHeader();
            chZoom2 = new System.Windows.Forms.ColumnHeader();
            chRenderMode = new System.Windows.Forms.ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, toolStripMenuItem1, lblTotalFrames });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(720, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { interpolateToolStripMenuItem, toolStripSeparator1, batchInterpolateToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // interpolateToolStripMenuItem
            // 
            interpolateToolStripMenuItem.Enabled = false;
            interpolateToolStripMenuItem.Name = "interpolateToolStripMenuItem";
            interpolateToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            interpolateToolStripMenuItem.Text = "Interpolate";
            interpolateToolStripMenuItem.Click += interpolateToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // batchInterpolateToolStripMenuItem
            // 
            batchInterpolateToolStripMenuItem.Name = "batchInterpolateToolStripMenuItem";
            batchInterpolateToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            batchInterpolateToolStripMenuItem.Text = "Batch Interpolate";
            batchInterpolateToolStripMenuItem.Click += batchInterpolateToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lblTotalFrames
            // 
            lblTotalFrames.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            lblTotalFrames.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            lblTotalFrames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            lblTotalFrames.Enabled = false;
            lblTotalFrames.Name = "lblTotalFrames";
            lblTotalFrames.ShowShortcutKeys = false;
            lblTotalFrames.Size = new System.Drawing.Size(97, 20);
            lblTotalFrames.Text = "Total Frames: 0";
            // 
            // lstView
            // 
            lstView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chID, chEye, chTarget, chUp, chPosition, chPan, chZoom, chZoom2, chRenderMode });
            lstView.FullRowSelect = true;
            lstView.GridLines = true;
            lstView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lstView.Location = new System.Drawing.Point(14, 31);
            lstView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstView.Name = "lstView";
            lstView.Size = new System.Drawing.Size(691, 376);
            lstView.TabIndex = 6;
            lstView.UseCompatibleStateImageBehavior = false;
            lstView.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            chID.Text = "ID";
            // 
            // chEye
            // 
            chEye.Text = "Eye";
            chEye.Width = 72;
            // 
            // chTarget
            // 
            chTarget.Text = "Target";
            // 
            // chUp
            // 
            chUp.Text = "Up";
            // 
            // chPosition
            // 
            chPosition.Text = "Position";
            // 
            // chPan
            // 
            chPan.Text = "Pan";
            // 
            // chZoom
            // 
            chZoom.Text = "Zoom";
            // 
            // chZoom2
            // 
            chZoom2.Text = "Zoom2";
            // 
            // chRenderMode
            // 
            chRenderMode.Text = "Render Mode";
            // 
            // Entry
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(720, 421);
            Controls.Add(lstView);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Entry";
            Text = "Moomba";
            KeyUp += Entry_KeyUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader chEye;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chTarget;
        private System.Windows.Forms.ColumnHeader chUp;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.ColumnHeader chPan;
        private System.Windows.Forms.ColumnHeader chZoom;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ToolStripMenuItem lblTotalFrames;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchInterpolateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader chZoom2;
        private System.Windows.Forms.ColumnHeader chRenderMode;
    }
}

