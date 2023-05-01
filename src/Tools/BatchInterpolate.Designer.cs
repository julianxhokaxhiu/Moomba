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

namespace Moomba.Tools
{
    partial class BatchInterpolate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lstProgress = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInPath = new System.Windows.Forms.TextBox();
            this.btnPickInPath = new System.Windows.Forms.Button();
            this.btnPickOutPath = new System.Windows.Forms.Button();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 0;
            // 
            // lstProgress
            // 
            this.lstProgress.FormattingEnabled = true;
            this.lstProgress.Location = new System.Drawing.Point(12, 87);
            this.lstProgress.Name = "lstProgress";
            this.lstProgress.Size = new System.Drawing.Size(776, 316);
            this.lstProgress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IN Cam Files";
            // 
            // txtInPath
            // 
            this.txtInPath.Location = new System.Drawing.Point(93, 26);
            this.txtInPath.Name = "txtInPath";
            this.txtInPath.ReadOnly = true;
            this.txtInPath.Size = new System.Drawing.Size(651, 20);
            this.txtInPath.TabIndex = 3;
            // 
            // btnPickInPath
            // 
            this.btnPickInPath.Location = new System.Drawing.Point(750, 23);
            this.btnPickInPath.Name = "btnPickInPath";
            this.btnPickInPath.Size = new System.Drawing.Size(38, 23);
            this.btnPickInPath.TabIndex = 4;
            this.btnPickInPath.Text = "...";
            this.btnPickInPath.UseVisualStyleBackColor = true;
            this.btnPickInPath.Click += new System.EventHandler(this.btnPickInPath_Click);
            // 
            // btnPickOutPath
            // 
            this.btnPickOutPath.Location = new System.Drawing.Point(750, 49);
            this.btnPickOutPath.Name = "btnPickOutPath";
            this.btnPickOutPath.Size = new System.Drawing.Size(38, 23);
            this.btnPickOutPath.TabIndex = 7;
            this.btnPickOutPath.Text = "...";
            this.btnPickOutPath.UseVisualStyleBackColor = true;
            this.btnPickOutPath.Click += new System.EventHandler(this.btnPickOutPath_Click);
            // 
            // txtOutPath
            // 
            this.txtOutPath.Location = new System.Drawing.Point(93, 52);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.ReadOnly = true;
            this.txtOutPath.Size = new System.Drawing.Size(651, 20);
            this.txtOutPath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "OUT Cam Files";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(713, 444);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // BatchInterpolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPickOutPath);
            this.Controls.Add(this.txtOutPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPickInPath);
            this.Controls.Add(this.txtInPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProgress);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BatchInterpolate";
            this.Text = "BatchInterpolate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatchInterpolate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox lstProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInPath;
        private System.Windows.Forms.Button btnPickInPath;
        private System.Windows.Forms.Button btnPickOutPath;
        private System.Windows.Forms.TextBox txtOutPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRun;
    }
}