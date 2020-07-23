namespace CR.UI.Caja
{
    partial class ucCloseCashier
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
            this.pnCenter = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbMontoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCardsAndCredits = new System.Windows.Forms.GroupBox();
            this.gbCashCoins = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pnCenter);
            this.scMain.Size = new System.Drawing.Size(712, 520);
            this.scMain.SplitterDistance = 26;
            this.scMain.TabIndex = 1;
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.btnExit);
            this.pnCenter.Controls.Add(this.lbMontoTotal);
            this.pnCenter.Controls.Add(this.label1);
            this.pnCenter.Controls.Add(this.gbDetails);
            this.pnCenter.Controls.Add(this.btnSave);
            this.pnCenter.Controls.Add(this.gbCardsAndCredits);
            this.pnCenter.Controls.Add(this.gbCashCoins);
            this.pnCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(712, 490);
            this.pnCenter.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(469, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 52);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbMontoTotal
            // 
            this.lbMontoTotal.AutoSize = true;
            this.lbMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTotal.Location = new System.Drawing.Point(574, 254);
            this.lbMontoTotal.Name = "lbMontoTotal";
            this.lbMontoTotal.Size = new System.Drawing.Size(20, 24);
            this.lbMontoTotal.TabIndex = 5;
            this.lbMontoTotal.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monto Total:";
            // 
            // gbDetails
            // 
            this.gbDetails.Location = new System.Drawing.Point(13, 247);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(450, 224);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Detalles";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(469, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 52);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCardsAndCredits
            // 
            this.gbCardsAndCredits.Location = new System.Drawing.Point(13, 115);
            this.gbCardsAndCredits.Name = "gbCardsAndCredits";
            this.gbCardsAndCredits.Size = new System.Drawing.Size(691, 130);
            this.gbCardsAndCredits.TabIndex = 1;
            this.gbCardsAndCredits.TabStop = false;
            this.gbCardsAndCredits.Text = "Tarjetas y Creditos";
            // 
            // gbCashCoins
            // 
            this.gbCashCoins.Location = new System.Drawing.Point(13, 2);
            this.gbCashCoins.Name = "gbCashCoins";
            this.gbCashCoins.Size = new System.Drawing.Size(691, 113);
            this.gbCashCoins.TabIndex = 0;
            this.gbCashCoins.TabStop = false;
            this.gbCashCoins.Text = "Billetes";
            // 
            // ucCloseCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "ucCloseCashier";
            this.Size = new System.Drawing.Size(712, 520);
            this.Load += new System.EventHandler(this.ucCloseCashier_Load);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.pnCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.GroupBox gbCashCoins;
        private System.Windows.Forms.GroupBox gbCardsAndCredits;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lbMontoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}
