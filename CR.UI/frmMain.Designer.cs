﻿namespace CR.UI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsConfig = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiMonedas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lbId = new System.Windows.Forms.Label();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnCloseCashier = new System.Windows.Forms.Button();
            this.btnOpenCashier = new System.Windows.Forms.Button();
            this.lbRola = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConfig});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(965, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsConfig
            // 
            this.tsConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMonedas,
            this.tsmiUsuarios});
            this.tsConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsConfig.Image")));
            this.tsConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsConfig.Name = "tsConfig";
            this.tsConfig.Size = new System.Drawing.Size(112, 22);
            this.tsConfig.Text = "Configuracion";
            // 
            // tsmiMonedas
            // 
            this.tsmiMonedas.Name = "tsmiMonedas";
            this.tsmiMonedas.Size = new System.Drawing.Size(123, 22);
            this.tsmiMonedas.Text = "Monedas";
            this.tsmiMonedas.Click += new System.EventHandler(this.tsmiMonedas_Click);
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(123, 22);
            this.tsmiUsuarios.Text = "Usuarios";
            this.tsmiUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 25);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.pnMenu);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pnMain);
            this.scMain.Size = new System.Drawing.Size(965, 466);
            this.scMain.SplitterDistance = 208;
            this.scMain.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnMenu.Controls.Add(this.gbUserInfo);
            this.pnMenu.Controls.Add(this.userPicture);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(208, 466);
            this.pnMenu.TabIndex = 0;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lbId);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Controls.Add(this.btnCloseCashier);
            this.gbUserInfo.Controls.Add(this.btnOpenCashier);
            this.gbUserInfo.Controls.Add(this.lbRola);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.lbUser);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Location = new System.Drawing.Point(9, 149);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(185, 314);
            this.gbUserInfo.TabIndex = 1;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Informacion de Usuario";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Id", true));
            this.lbId.Location = new System.Drawing.Point(76, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(10, 13);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "-";
            // 
            // bsUser
            // 
            this.bsUser.DataSource = typeof(CR.Entities.DTO.UserDTO);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "# Empleado:";
            // 
            // btnCloseCashier
            // 
            this.btnCloseCashier.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCloseCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCashier.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseCashier.Location = new System.Drawing.Point(9, 178);
            this.btnCloseCashier.Name = "btnCloseCashier";
            this.btnCloseCashier.Size = new System.Drawing.Size(166, 50);
            this.btnCloseCashier.TabIndex = 5;
            this.btnCloseCashier.Text = "CERRAR CAJA";
            this.btnCloseCashier.UseVisualStyleBackColor = false;
            // 
            // btnOpenCashier
            // 
            this.btnOpenCashier.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOpenCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCashier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenCashier.Location = new System.Drawing.Point(9, 108);
            this.btnOpenCashier.Name = "btnOpenCashier";
            this.btnOpenCashier.Size = new System.Drawing.Size(166, 50);
            this.btnOpenCashier.TabIndex = 6;
            this.btnOpenCashier.Text = "ABRIR CAJA";
            this.btnOpenCashier.UseVisualStyleBackColor = false;
            this.btnOpenCashier.Click += new System.EventHandler(this.btnOpenCashier_Click);
            // 
            // lbRola
            // 
            this.lbRola.AutoSize = true;
            this.lbRola.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Rol", true));
            this.lbRola.Location = new System.Drawing.Point(76, 61);
            this.lbRola.Name = "lbRola";
            this.lbRola.Size = new System.Drawing.Size(10, 13);
            this.lbRola.TabIndex = 3;
            this.lbRola.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "UserName", true));
            this.lbUser.Location = new System.Drawing.Point(76, 40);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(10, 13);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPicture.BackgroundImage")));
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPicture.Location = new System.Drawing.Point(9, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(185, 144);
            this.userPicture.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(753, 466);
            this.pnMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(965, 491);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadre de caja";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripDropDownButton tsConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonedas;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel userPicture;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Button btnCloseCashier;
        private System.Windows.Forms.Label lbRola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenCashier;
        private System.Windows.Forms.BindingSource bsUser;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label4;
    }
}