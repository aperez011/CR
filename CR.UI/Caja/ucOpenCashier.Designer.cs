﻿namespace CR.UI.Caja
{
    partial class ucOpenCashier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.gbCoins = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btnSave);
            this.scMain.Panel1.Controls.Add(this.btnPreview);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pnCenter);
            this.scMain.Size = new System.Drawing.Size(712, 341);
            this.scMain.SplitterDistance = 56;
            this.scMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(13, 8);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(91, 31);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Vista Previa";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.gbCoins);
            this.pnCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(712, 281);
            this.pnCenter.TabIndex = 1;
            // 
            // gbCoins
            // 
            this.gbCoins.Location = new System.Drawing.Point(13, 5);
            this.gbCoins.Name = "gbCoins";
            this.gbCoins.Size = new System.Drawing.Size(685, 150);
            this.gbCoins.TabIndex = 0;
            this.gbCoins.TabStop = false;
            this.gbCoins.Text = "Billetes";
            // 
            // ucOpenCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "ucOpenCashier";
            this.Size = new System.Drawing.Size(712, 341);
            this.Load += new System.EventHandler(this.ucOpenCashier_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.GroupBox gbCoins;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreview;
    }
}
