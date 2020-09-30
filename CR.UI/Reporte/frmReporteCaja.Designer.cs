namespace CR.UI.Reporte
{
    partial class frmReporteCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.bsReportHeader = new System.Windows.Forms.BindingSource(this.components);
            this.lbDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOpenAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbExpenses = new System.Windows.Forms.Label();
            this.lbCloseAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dbDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.CoinName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCashRegisterDetails = new System.Windows.Forms.BindingSource(this.components);
            this.tlpBalances = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.llbCashClose = new System.Windows.Forms.LinkLabel();
            this.bsReportDetail = new System.Windows.Forms.BindingSource(this.components);
            this.llbCreditOpen = new System.Windows.Forms.LinkLabel();
            this.llbTransferOpen = new System.Windows.Forms.LinkLabel();
            this.llbDepositOpen = new System.Windows.Forms.LinkLabel();
            this.llbCardOpen = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.llbCashOpen = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.llbCardClose = new System.Windows.Forms.LinkLabel();
            this.llbDepositClose = new System.Windows.Forms.LinkLabel();
            this.llbTransferClose = new System.Windows.Forms.LinkLabel();
            this.llbCreditClose = new System.Windows.Forms.LinkLabel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.chbOther = new System.Windows.Forms.CheckBox();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.gbOthers = new System.Windows.Forms.GroupBox();
            this.cbShifts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCashiers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportHeader)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.dbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashRegisterDetails)).BeginInit();
            this.tlpBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportDetail)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.gbOthers.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDetails);
            this.panel1.Controls.Add(this.gbFiltros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 635);
            this.panel1.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.panel7);
            this.gbDetails.Location = new System.Drawing.Point(3, 110);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(728, 525);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.scMain);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(722, 506);
            this.panel7.TabIndex = 1;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lbUsuario);
            this.scMain.Panel1.Controls.Add(this.lbDate);
            this.scMain.Panel1.Controls.Add(this.groupBox2);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dbDetalles);
            this.scMain.Panel2.Controls.Add(this.tlpBalances);
            this.scMain.Size = new System.Drawing.Size(722, 506);
            this.scMain.SplitterDistance = 141;
            this.scMain.TabIndex = 0;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportHeader, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "N/A"));
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbUsuario.Location = new System.Drawing.Point(9, 6);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(17, 17);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "_";
            // 
            // bsReportHeader
            // 
            this.bsReportHeader.DataSource = typeof(CR.Entities.DTO.CashierReportDTO);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportHeader, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "N/A"));
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDate.Location = new System.Drawing.Point(619, 6);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(17, 17);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "_";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBalance);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbOpenAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbExpenses);
            this.groupBox2.Controls.Add(this.lbCloseAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion General";
            // 
            // lbBalance
            // 
            this.lbBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportHeader, "CashBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(196, 77);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(126, 21);
            this.lbBalance.TabIndex = 19;
            this.lbBalance.Text = "_";
            this.lbBalance.TextChanged += new System.EventHandler(this.lbBalance_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Balance de Cierre:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(488, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(215, 76);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "IMPRIMIR";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Moton Total de Apertura:";
            // 
            // lbOpenAmount
            // 
            this.lbOpenAmount.AutoSize = true;
            this.lbOpenAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportHeader, "OpenAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.lbOpenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpenAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbOpenAmount.Location = new System.Drawing.Point(6, 32);
            this.lbOpenAmount.Name = "lbOpenAmount";
            this.lbOpenAmount.Size = new System.Drawing.Size(15, 15);
            this.lbOpenAmount.TabIndex = 13;
            this.lbOpenAmount.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Moton Total de Cierre:";
            // 
            // lbExpenses
            // 
            this.lbExpenses.AutoSize = true;
            this.lbExpenses.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsReportHeader, "ExpensesAmount", true));
            this.lbExpenses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportHeader, "ExpensesAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.lbExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpenses.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbExpenses.Location = new System.Drawing.Point(196, 32);
            this.lbExpenses.Name = "lbExpenses";
            this.lbExpenses.Size = new System.Drawing.Size(15, 15);
            this.lbExpenses.TabIndex = 17;
            this.lbExpenses.Text = "_";
            // 
            // lbCloseAmount
            // 
            this.lbCloseAmount.AutoSize = true;
            this.lbCloseAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportHeader, "CloseAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.lbCloseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCloseAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCloseAmount.Location = new System.Drawing.Point(6, 77);
            this.lbCloseAmount.Name = "lbCloseAmount";
            this.lbCloseAmount.Size = new System.Drawing.Size(15, 15);
            this.lbCloseAmount.TabIndex = 15;
            this.lbCloseAmount.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Moton Total de Gastos del dia:";
            // 
            // dbDetalles
            // 
            this.dbDetalles.Controls.Add(this.dgvDetails);
            this.dbDetalles.Location = new System.Drawing.Point(7, 106);
            this.dbDetalles.Name = "dbDetalles";
            this.dbDetalles.Size = new System.Drawing.Size(706, 242);
            this.dbDetalles.TabIndex = 5;
            this.dbDetalles.TabStop = false;
            this.dbDetalles.Text = "Detalles";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoinName,
            this.RefNum,
            this.totalAmountDataGridViewTextBoxColumn,
            this.coinAmountDataGridViewTextBoxColumn,
            this.RegisterDate});
            this.dgvDetails.DataSource = this.bsCashRegisterDetails;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.Size = new System.Drawing.Size(700, 223);
            this.dgvDetails.TabIndex = 0;
            // 
            // CoinName
            // 
            this.CoinName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CoinName.DataPropertyName = "CoinName";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "N/A";
            this.CoinName.DefaultCellStyle = dataGridViewCellStyle1;
            this.CoinName.HeaderText = "Moneda";
            this.CoinName.Name = "CoinName";
            this.CoinName.ReadOnly = true;
            // 
            // RefNum
            // 
            this.RefNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RefNum.DataPropertyName = "RefNum";
            dataGridViewCellStyle2.NullValue = "NONE";
            this.RefNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.RefNum.HeaderText = "Numero de Referencia";
            this.RefNum.Name = "RefNum";
            this.RefNum.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "-";
            this.totalAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coinAmountDataGridViewTextBoxColumn
            // 
            this.coinAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coinAmountDataGridViewTextBoxColumn.DataPropertyName = "CoinAmount";
            this.coinAmountDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.coinAmountDataGridViewTextBoxColumn.Name = "coinAmountDataGridViewTextBoxColumn";
            this.coinAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegisterDate.DataPropertyName = "RegisterDate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy h:MM:ss tt";
            dataGridViewCellStyle4.NullValue = "N/A";
            this.RegisterDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.RegisterDate.HeaderText = "Fecha de Registro";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // bsCashRegisterDetails
            // 
            this.bsCashRegisterDetails.DataSource = typeof(CR.Entities.DTO.DetailDTO);
            // 
            // tlpBalances
            // 
            this.tlpBalances.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpBalances.ColumnCount = 6;
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpBalances.Controls.Add(this.label14, 0, 2);
            this.tlpBalances.Controls.Add(this.llbCashClose, 1, 2);
            this.tlpBalances.Controls.Add(this.llbCreditOpen, 5, 1);
            this.tlpBalances.Controls.Add(this.llbTransferOpen, 4, 1);
            this.tlpBalances.Controls.Add(this.llbDepositOpen, 3, 1);
            this.tlpBalances.Controls.Add(this.llbCardOpen, 2, 1);
            this.tlpBalances.Controls.Add(this.panel6, 5, 0);
            this.tlpBalances.Controls.Add(this.panel5, 4, 0);
            this.tlpBalances.Controls.Add(this.panel4, 3, 0);
            this.tlpBalances.Controls.Add(this.panel3, 2, 0);
            this.tlpBalances.Controls.Add(this.panel2, 1, 0);
            this.tlpBalances.Controls.Add(this.llbCashOpen, 1, 1);
            this.tlpBalances.Controls.Add(this.label13, 0, 1);
            this.tlpBalances.Controls.Add(this.llbCardClose, 2, 2);
            this.tlpBalances.Controls.Add(this.llbDepositClose, 3, 2);
            this.tlpBalances.Controls.Add(this.llbTransferClose, 4, 2);
            this.tlpBalances.Controls.Add(this.llbCreditClose, 5, 2);
            this.tlpBalances.Location = new System.Drawing.Point(7, 5);
            this.tlpBalances.Name = "tlpBalances";
            this.tlpBalances.RowCount = 3;
            this.tlpBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBalances.Size = new System.Drawing.Size(706, 91);
            this.tlpBalances.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cierre";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbCashClose
            // 
            this.llbCashClose.AutoSize = true;
            this.llbCashClose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "CloseCash", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbCashClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCashClose.Location = new System.Drawing.Point(96, 64);
            this.llbCashClose.Name = "llbCashClose";
            this.llbCashClose.Size = new System.Drawing.Size(111, 25);
            this.llbCashClose.TabIndex = 10;
            this.llbCashClose.TabStop = true;
            this.llbCashClose.Text = "_";
            this.llbCashClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCashClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCash_LinkClicked);
            // 
            // bsReportDetail
            // 
            this.bsReportDetail.DataSource = typeof(CR.Entities.DTO.BalanceDetails);
            // 
            // llbCreditOpen
            // 
            this.llbCreditOpen.AutoSize = true;
            this.llbCreditOpen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "OpenCredit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbCreditOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCreditOpen.Location = new System.Drawing.Point(593, 33);
            this.llbCreditOpen.Name = "llbCreditOpen";
            this.llbCreditOpen.Size = new System.Drawing.Size(108, 29);
            this.llbCreditOpen.TabIndex = 9;
            this.llbCreditOpen.TabStop = true;
            this.llbCreditOpen.Text = "_";
            this.llbCreditOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCreditOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCredits_LinkClicked);
            // 
            // llbTransferOpen
            // 
            this.llbTransferOpen.AutoSize = true;
            this.llbTransferOpen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "OpenTransfer", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbTransferOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbTransferOpen.Location = new System.Drawing.Point(453, 33);
            this.llbTransferOpen.Name = "llbTransferOpen";
            this.llbTransferOpen.Size = new System.Drawing.Size(132, 29);
            this.llbTransferOpen.TabIndex = 8;
            this.llbTransferOpen.TabStop = true;
            this.llbTransferOpen.Text = "_";
            this.llbTransferOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTransferOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTransfer_LinkClicked);
            // 
            // llbDepositOpen
            // 
            this.llbDepositOpen.AutoSize = true;
            this.llbDepositOpen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "OpenDeposit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbDepositOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbDepositOpen.Location = new System.Drawing.Point(334, 33);
            this.llbDepositOpen.Name = "llbDepositOpen";
            this.llbDepositOpen.Size = new System.Drawing.Size(111, 29);
            this.llbDepositOpen.TabIndex = 7;
            this.llbDepositOpen.TabStop = true;
            this.llbDepositOpen.Text = "_";
            this.llbDepositOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbDepositOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDeposit_LinkClicked);
            // 
            // llbCardOpen
            // 
            this.llbCardOpen.AutoSize = true;
            this.llbCardOpen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "OpenCards", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbCardOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCardOpen.Location = new System.Drawing.Point(215, 33);
            this.llbCardOpen.Name = "llbCardOpen";
            this.llbCardOpen.Size = new System.Drawing.Size(111, 29);
            this.llbCardOpen.TabIndex = 6;
            this.llbCardOpen.TabStop = true;
            this.llbCardOpen.Text = "_";
            this.llbCardOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCardOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCards_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(593, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(108, 23);
            this.panel6.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "A Credito";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(453, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 23);
            this.panel5.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Transferancias";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(334, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 23);
            this.panel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Depositos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(215, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 23);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarjetas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(96, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 23);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbCashOpen
            // 
            this.llbCashOpen.AutoSize = true;
            this.llbCashOpen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "OpenCash", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbCashOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCashOpen.Location = new System.Drawing.Point(96, 33);
            this.llbCashOpen.Name = "llbCashOpen";
            this.llbCashOpen.Size = new System.Drawing.Size(111, 29);
            this.llbCashOpen.TabIndex = 5;
            this.llbCashOpen.TabStop = true;
            this.llbCashOpen.Text = "_";
            this.llbCashOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCashOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCash_LinkClicked);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 29);
            this.label13.TabIndex = 11;
            this.label13.Text = "Apertura";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbCardClose
            // 
            this.llbCardClose.AutoSize = true;
            this.llbCardClose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "CloseCards", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbCardClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCardClose.Location = new System.Drawing.Point(215, 64);
            this.llbCardClose.Name = "llbCardClose";
            this.llbCardClose.Size = new System.Drawing.Size(111, 25);
            this.llbCardClose.TabIndex = 13;
            this.llbCardClose.TabStop = true;
            this.llbCardClose.Text = "_";
            this.llbCardClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCardClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCards_LinkClicked);
            // 
            // llbDepositClose
            // 
            this.llbDepositClose.AutoSize = true;
            this.llbDepositClose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "CloseDeposit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbDepositClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbDepositClose.Location = new System.Drawing.Point(334, 64);
            this.llbDepositClose.Name = "llbDepositClose";
            this.llbDepositClose.Size = new System.Drawing.Size(111, 25);
            this.llbDepositClose.TabIndex = 14;
            this.llbDepositClose.TabStop = true;
            this.llbDepositClose.Text = "_";
            this.llbDepositClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbDepositClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDeposit_LinkClicked);
            // 
            // llbTransferClose
            // 
            this.llbTransferClose.AutoSize = true;
            this.llbTransferClose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "CloseTransfer", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbTransferClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbTransferClose.Location = new System.Drawing.Point(453, 64);
            this.llbTransferClose.Name = "llbTransferClose";
            this.llbTransferClose.Size = new System.Drawing.Size(132, 25);
            this.llbTransferClose.TabIndex = 15;
            this.llbTransferClose.TabStop = true;
            this.llbTransferClose.Text = "_";
            this.llbTransferClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTransferClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTransfer_LinkClicked);
            // 
            // llbCreditClose
            // 
            this.llbCreditClose.AutoSize = true;
            this.llbCreditClose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReportDetail, "CloseCredit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "$ 0.00", "C2"));
            this.llbCreditClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCreditClose.Location = new System.Drawing.Point(593, 64);
            this.llbCreditClose.Name = "llbCreditClose";
            this.llbCreditClose.Size = new System.Drawing.Size(108, 25);
            this.llbCreditClose.TabIndex = 16;
            this.llbCreditClose.TabStop = true;
            this.llbCreditClose.Text = "_";
            this.llbCreditClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCreditClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCredits_LinkClicked);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chbOther);
            this.gbFiltros.Controls.Add(this.chbDate);
            this.gbFiltros.Controls.Add(this.gbOthers);
            this.gbFiltros.Controls.Add(this.btnCancel);
            this.gbFiltros.Controls.Add(this.btnSearch);
            this.gbFiltros.Controls.Add(this.gbDate);
            this.gbFiltros.Location = new System.Drawing.Point(3, 3);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(728, 104);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // chbOther
            // 
            this.chbOther.AutoSize = true;
            this.chbOther.Checked = true;
            this.chbOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOther.Location = new System.Drawing.Point(209, 16);
            this.chbOther.Name = "chbOther";
            this.chbOther.Size = new System.Drawing.Size(101, 17);
            this.chbOther.TabIndex = 9;
            this.chbOther.Text = "Usar otros filtros";
            this.chbOther.UseVisualStyleBackColor = true;
            this.chbOther.Click += new System.EventHandler(this.chbOther_Click);
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(10, 16);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(81, 17);
            this.chbDate.TabIndex = 8;
            this.chbDate.Text = "Usar Fecha";
            this.chbDate.UseVisualStyleBackColor = true;
            this.chbDate.Click += new System.EventHandler(this.chbDate_Click);
            // 
            // gbOthers
            // 
            this.gbOthers.Controls.Add(this.cbShifts);
            this.gbOthers.Controls.Add(this.label6);
            this.gbOthers.Controls.Add(this.cbCashiers);
            this.gbOthers.Controls.Add(this.label4);
            this.gbOthers.Location = new System.Drawing.Point(208, 35);
            this.gbOthers.Name = "gbOthers";
            this.gbOthers.Size = new System.Drawing.Size(302, 60);
            this.gbOthers.TabIndex = 7;
            this.gbOthers.TabStop = false;
            this.gbOthers.Text = "Otros";
            // 
            // cbShifts
            // 
            this.cbShifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShifts.FormattingEnabled = true;
            this.cbShifts.Location = new System.Drawing.Point(160, 32);
            this.cbShifts.Name = "cbShifts";
            this.cbShifts.Size = new System.Drawing.Size(134, 21);
            this.cbShifts.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Por Turno";
            // 
            // cbCashiers
            // 
            this.cbCashiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCashiers.FormattingEnabled = true;
            this.cbCashiers.Location = new System.Drawing.Point(8, 32);
            this.cbCashiers.Name = "cbCashiers";
            this.cbCashiers.Size = new System.Drawing.Size(134, 21);
            this.cbCashiers.TabIndex = 5;
            this.cbCashiers.SelectedIndexChanged += new System.EventHandler(this.cbCashiers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Por Cajeros";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(608, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 60);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(516, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 60);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.dtpHasta);
            this.gbDate.Controls.Add(this.label8);
            this.gbDate.Controls.Add(this.dtpDesde);
            this.gbDate.Controls.Add(this.label15);
            this.gbDate.Enabled = false;
            this.gbDate.Location = new System.Drawing.Point(10, 35);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(192, 60);
            this.gbDate.TabIndex = 4;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Por Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(105, 32);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(81, 20);
            this.dtpHasta.TabIndex = 7;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(9, 32);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(81, 20);
            this.dtpDesde.TabIndex = 5;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Desde";
            // 
            // frmReporteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 635);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmReporteCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Caja";
            this.Load += new System.EventHandler(this.frmReporteCaja_Load);
            this.panel1.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsReportHeader)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dbDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashRegisterDetails)).EndInit();
            this.tlpBalances.ResumeLayout(false);
            this.tlpBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportDetail)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbOthers.ResumeLayout(false);
            this.gbOthers.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.BindingSource bsReportHeader;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOpenAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbExpenses;
        private System.Windows.Forms.Label lbCloseAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox dbDetalles;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoinName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.BindingSource bsCashRegisterDetails;
        private System.Windows.Forms.TableLayoutPanel tlpBalances;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel llbCashClose;
        private System.Windows.Forms.BindingSource bsReportDetail;
        private System.Windows.Forms.LinkLabel llbCreditOpen;
        private System.Windows.Forms.LinkLabel llbTransferOpen;
        private System.Windows.Forms.LinkLabel llbDepositOpen;
        private System.Windows.Forms.LinkLabel llbCardOpen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbCashOpen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel llbCardClose;
        private System.Windows.Forms.LinkLabel llbDepositClose;
        private System.Windows.Forms.LinkLabel llbTransferClose;
        private System.Windows.Forms.LinkLabel llbCreditClose;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbOther;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.GroupBox gbOthers;
        private System.Windows.Forms.ComboBox cbShifts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCashiers;
        private System.Windows.Forms.Label label4;
    }
}