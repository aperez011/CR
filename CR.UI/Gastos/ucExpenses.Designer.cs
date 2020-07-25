namespace CR.UI.Gastos
{
    partial class ucExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnPorUsuario = new System.Windows.Forms.Panel();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnSearchByUser = new System.Windows.Forms.Button();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pnPorFecha = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltarPor = new System.Windows.Forms.ComboBox();
            this.lbTextFil = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgbExpenses = new System.Windows.Forms.DataGridView();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCashExpenses = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.pnPorUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.pnPorFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnPorUsuario);
            this.panel1.Controls.Add(this.pnPorFecha);
            this.panel1.Controls.Add(this.cbFiltarPor);
            this.panel1.Controls.Add(this.lbTextFil);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddExpense);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 518);
            this.panel1.TabIndex = 0;
            // 
            // pnPorUsuario
            // 
            this.pnPorUsuario.Controls.Add(this.btnReset2);
            this.pnPorUsuario.Controls.Add(this.btnSearchByUser);
            this.pnPorUsuario.Controls.Add(this.cbUsers);
            this.pnPorUsuario.Controls.Add(this.label4);
            this.pnPorUsuario.Location = new System.Drawing.Point(358, 412);
            this.pnPorUsuario.Name = "pnPorUsuario";
            this.pnPorUsuario.Size = new System.Drawing.Size(334, 55);
            this.pnPorUsuario.TabIndex = 11;
            this.pnPorUsuario.Visible = false;
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.Cyan;
            this.btnReset2.BackgroundImage = global::CR.UI.Properties.Resources.refresh_1782307_1514157;
            this.btnReset2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset2.Location = new System.Drawing.Point(265, 2);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(66, 50);
            this.btnReset2.TabIndex = 15;
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchByUser
            // 
            this.btnSearchByUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchByUser.Location = new System.Drawing.Point(193, 2);
            this.btnSearchByUser.Name = "btnSearchByUser";
            this.btnSearchByUser.Size = new System.Drawing.Size(66, 50);
            this.btnSearchByUser.TabIndex = 14;
            this.btnSearchByUser.Text = "Buscar";
            this.btnSearchByUser.UseVisualStyleBackColor = false;
            // 
            // cbUsers
            // 
            this.cbUsers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsUsers, "UserName", true));
            this.cbUsers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUsers, "Id", true));
            this.cbUsers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-"));
            this.cbUsers.DataSource = this.bsUsers;
            this.cbUsers.DisplayMember = "UserName";
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(6, 22);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(177, 21);
            this.cbUsers.TabIndex = 1;
            this.cbUsers.ValueMember = "Id";
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = typeof(CR.Entities.DTO.UserDTO);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario";
            // 
            // pnPorFecha
            // 
            this.pnPorFecha.Controls.Add(this.btnReset);
            this.pnPorFecha.Controls.Add(this.btnSearchByDate);
            this.pnPorFecha.Controls.Add(this.dtpHasta);
            this.pnPorFecha.Controls.Add(this.label2);
            this.pnPorFecha.Controls.Add(this.dtpDesde);
            this.pnPorFecha.Controls.Add(this.label1);
            this.pnPorFecha.Location = new System.Drawing.Point(5, 412);
            this.pnPorFecha.Name = "pnPorFecha";
            this.pnPorFecha.Size = new System.Drawing.Size(334, 55);
            this.pnPorFecha.TabIndex = 10;
            this.pnPorFecha.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Cyan;
            this.btnReset.BackgroundImage = global::CR.UI.Properties.Resources.refresh_1782307_1514157;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(265, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 50);
            this.btnReset.TabIndex = 14;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchByDate.Location = new System.Drawing.Point(193, 2);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(66, 50);
            this.btnSearchByDate.TabIndex = 13;
            this.btnSearchByDate.Text = "Buscar";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(102, 23);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(81, 20);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(6, 23);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(81, 20);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // cbFiltarPor
            // 
            this.cbFiltarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltarPor.FormattingEnabled = true;
            this.cbFiltarPor.Items.AddRange(new object[] {
            "Por Fecha",
            "Por Usuario"});
            this.cbFiltarPor.Location = new System.Drawing.Point(273, 25);
            this.cbFiltarPor.Name = "cbFiltarPor";
            this.cbFiltarPor.Size = new System.Drawing.Size(82, 21);
            this.cbFiltarPor.TabIndex = 9;
            this.cbFiltarPor.SelectedValueChanged += new System.EventHandler(this.cbFiltarPor_SelectedValueChanged);
            // 
            // lbTextFil
            // 
            this.lbTextFil.AutoSize = true;
            this.lbTextFil.Location = new System.Drawing.Point(270, 9);
            this.lbTextFil.Name = "lbTextFil";
            this.lbTextFil.Size = new System.Drawing.Size(51, 13);
            this.lbTextFil.TabIndex = 8;
            this.lbTextFil.Text = "Filtar Por:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(118, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "CERRAR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddExpense.Location = new System.Drawing.Point(11, 4);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(98, 50);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "AGREGAR GASTO";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgbExpenses);
            this.groupBox1.Location = new System.Drawing.Point(8, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos";
            // 
            // dgbExpenses
            // 
            this.dgbExpenses.AllowUserToAddRows = false;
            this.dgbExpenses.AllowUserToDeleteRows = false;
            this.dgbExpenses.AutoGenerateColumns = false;
            this.dgbExpenses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgbExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerDateDataGridViewTextBoxColumn,
            this.billNumDataGridViewTextBoxColumn,
            this.billAmountDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dgbExpenses.DataSource = this.bsCashExpenses;
            this.dgbExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbExpenses.Location = new System.Drawing.Point(3, 16);
            this.dgbExpenses.Name = "dgbExpenses";
            this.dgbExpenses.ReadOnly = true;
            this.dgbExpenses.RowHeadersVisible = false;
            this.dgbExpenses.Size = new System.Drawing.Size(681, 327);
            this.dgbExpenses.TabIndex = 0;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            dataGridViewCellStyle9.NullValue = "-";
            this.registerDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billNumDataGridViewTextBoxColumn
            // 
            this.billNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billNumDataGridViewTextBoxColumn.DataPropertyName = "BillNum";
            this.billNumDataGridViewTextBoxColumn.HeaderText = "Numero de Factura";
            this.billNumDataGridViewTextBoxColumn.Name = "billNumDataGridViewTextBoxColumn";
            this.billNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billAmountDataGridViewTextBoxColumn
            // 
            this.billAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billAmountDataGridViewTextBoxColumn.DataPropertyName = "BillAmount";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "-";
            this.billAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.billAmountDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.billAmountDataGridViewTextBoxColumn.Name = "billAmountDataGridViewTextBoxColumn";
            this.billAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsCashExpenses
            // 
            this.bsCashExpenses.DataSource = typeof(CR.Entities.CashExpense);
            // 
            // ucExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucExpenses";
            this.Size = new System.Drawing.Size(711, 518);
            this.Load += new System.EventHandler(this.ucExpenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnPorUsuario.ResumeLayout(false);
            this.pnPorUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.pnPorFecha.ResumeLayout(false);
            this.pnPorFecha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgbExpenses;
        private System.Windows.Forms.BindingSource bsCashExpenses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbFiltarPor;
        private System.Windows.Forms.Label lbTextFil;
        private System.Windows.Forms.Panel pnPorUsuario;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnPorFecha;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchByUser;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
    }
}
