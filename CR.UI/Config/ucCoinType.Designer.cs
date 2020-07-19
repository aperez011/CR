namespace CR.UI.Config
{
    partial class ucCoinType
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbCoinType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCoins = new System.Windows.Forms.GroupBox();
            this.dgvCoins = new System.Windows.Forms.DataGridView();
            this.bsCoins = new System.Windows.Forms.BindingSource(this.components);
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.denominacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbCoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbCoinType);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gbCoins);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 410);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbCoinType
            // 
            this.cbCoinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoinType.FormattingEnabled = true;
            this.cbCoinType.Items.AddRange(new object[] {
            "NONE"});
            this.cbCoinType.Location = new System.Drawing.Point(112, 26);
            this.cbCoinType.Name = "cbCoinType";
            this.cbCoinType.Size = new System.Drawing.Size(127, 21);
            this.cbCoinType.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(91, 20);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Denominacion";
            // 
            // gbCoins
            // 
            this.gbCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCoins.Controls.Add(this.dgvCoins);
            this.gbCoins.Location = new System.Drawing.Point(3, 109);
            this.gbCoins.Name = "gbCoins";
            this.gbCoins.Size = new System.Drawing.Size(639, 299);
            this.gbCoins.TabIndex = 1;
            this.gbCoins.TabStop = false;
            this.gbCoins.Text = "Monedas";
            // 
            // dgvCoins
            // 
            this.dgvCoins.AllowUserToAddRows = false;
            this.dgvCoins.AllowUserToDeleteRows = false;
            this.dgvCoins.AutoGenerateColumns = false;
            this.dgvCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.denominacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvCoins.DataSource = this.bsCoins;
            this.dgvCoins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoins.Location = new System.Drawing.Point(3, 16);
            this.dgvCoins.Name = "dgvCoins";
            this.dgvCoins.ReadOnly = true;
            this.dgvCoins.RowHeadersVisible = false;
            this.dgvCoins.Size = new System.Drawing.Size(633, 280);
            this.dgvCoins.TabIndex = 0;
            // 
            // bsCoins
            // 
            this.bsCoins.DataSource = typeof(CR.Entities.DTO.CoinsDTO);
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Id";
            this.Editar.HeaderText = "-";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // denominacionDataGridViewTextBoxColumn
            // 
            this.denominacionDataGridViewTextBoxColumn.DataPropertyName = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.HeaderText = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.Name = "denominacionDataGridViewTextBoxColumn";
            this.denominacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucCoinType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "ucCoinType";
            this.Size = new System.Drawing.Size(645, 410);
            this.Load += new System.EventHandler(this.ucCoinType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsCoins;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCoins;
        private System.Windows.Forms.DataGridView dgvCoins;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbCoinType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}
