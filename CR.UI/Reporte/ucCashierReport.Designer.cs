namespace CR.UI.Reporte
{
    partial class ucCashierReport
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbOpenAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpBalances = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.llbCard = new System.Windows.Forms.LinkLabel();
            this.llbDeposit = new System.Windows.Forms.LinkLabel();
            this.llbTransfer = new System.Windows.Forms.LinkLabel();
            this.llbCredits = new System.Windows.Forms.LinkLabel();
            this.dbDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.bsCashRegisterDetails = new System.Windows.Forms.BindingSource(this.components);
            this.refNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llbCash = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlpBalances.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.dbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashRegisterDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 519);
            this.panel1.TabIndex = 0;
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
            this.scMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dbDetalles);
            this.scMain.Panel2.Controls.Add(this.tlpBalances);
            this.scMain.Panel2.Controls.Add(this.lbUsuario);
            this.scMain.Panel2.Controls.Add(this.lbDate);
            this.scMain.Size = new System.Drawing.Size(719, 519);
            this.scMain.SplitterDistance = 121;
            this.scMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbOpenAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(13, 8);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(17, 17);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "_";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(627, 6);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(17, 17);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "_";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Balance de Cierre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Moton Total de Gastos del dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Moton Total de Cierre:";
            // 
            // lbOpenAmount
            // 
            this.lbOpenAmount.AutoSize = true;
            this.lbOpenAmount.Location = new System.Drawing.Point(6, 32);
            this.lbOpenAmount.Name = "lbOpenAmount";
            this.lbOpenAmount.Size = new System.Drawing.Size(13, 13);
            this.lbOpenAmount.TabIndex = 13;
            this.lbOpenAmount.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Moton Total de Apertura:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrint.Location = new System.Drawing.Point(487, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(213, 45);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "IMPRIMIR";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(487, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tlpBalances
            // 
            this.tlpBalances.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tlpBalances.ColumnCount = 5;
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBalances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBalances.Controls.Add(this.llbCredits, 4, 1);
            this.tlpBalances.Controls.Add(this.llbTransfer, 3, 1);
            this.tlpBalances.Controls.Add(this.llbDeposit, 2, 1);
            this.tlpBalances.Controls.Add(this.llbCard, 1, 1);
            this.tlpBalances.Controls.Add(this.panel6, 4, 0);
            this.tlpBalances.Controls.Add(this.panel5, 3, 0);
            this.tlpBalances.Controls.Add(this.panel4, 2, 0);
            this.tlpBalances.Controls.Add(this.panel3, 1, 0);
            this.tlpBalances.Controls.Add(this.panel2, 0, 0);
            this.tlpBalances.Controls.Add(this.llbCash, 0, 1);
            this.tlpBalances.Location = new System.Drawing.Point(7, 44);
            this.tlpBalances.Name = "tlpBalances";
            this.tlpBalances.RowCount = 2;
            this.tlpBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBalances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBalances.Size = new System.Drawing.Size(706, 66);
            this.tlpBalances.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 22);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(146, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 22);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarjetas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(286, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 22);
            this.panel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Depositos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(426, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(131, 22);
            this.panel5.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Transferancias";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(566, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 22);
            this.panel6.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "A Credito";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbCard
            // 
            this.llbCard.AutoSize = true;
            this.llbCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCard.Location = new System.Drawing.Point(146, 34);
            this.llbCard.Name = "llbCard";
            this.llbCard.Size = new System.Drawing.Size(131, 29);
            this.llbCard.TabIndex = 6;
            this.llbCard.TabStop = true;
            this.llbCard.Text = "_";
            this.llbCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbDeposit
            // 
            this.llbDeposit.AutoSize = true;
            this.llbDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbDeposit.Location = new System.Drawing.Point(286, 34);
            this.llbDeposit.Name = "llbDeposit";
            this.llbDeposit.Size = new System.Drawing.Size(131, 29);
            this.llbDeposit.TabIndex = 7;
            this.llbDeposit.TabStop = true;
            this.llbDeposit.Text = "_";
            this.llbDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbTransfer
            // 
            this.llbTransfer.AutoSize = true;
            this.llbTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbTransfer.Location = new System.Drawing.Point(426, 34);
            this.llbTransfer.Name = "llbTransfer";
            this.llbTransfer.Size = new System.Drawing.Size(131, 29);
            this.llbTransfer.TabIndex = 8;
            this.llbTransfer.TabStop = true;
            this.llbTransfer.Text = "_";
            this.llbTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbCredits
            // 
            this.llbCredits.AutoSize = true;
            this.llbCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCredits.Location = new System.Drawing.Point(566, 34);
            this.llbCredits.Name = "llbCredits";
            this.llbCredits.Size = new System.Drawing.Size(134, 29);
            this.llbCredits.TabIndex = 9;
            this.llbCredits.TabStop = true;
            this.llbCredits.Text = "_";
            this.llbCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dbDetalles
            // 
            this.dbDetalles.Controls.Add(this.dgvDetails);
            this.dbDetalles.Location = new System.Drawing.Point(7, 116);
            this.dbDetalles.Name = "dbDetalles";
            this.dbDetalles.Size = new System.Drawing.Size(706, 257);
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
            this.refNumberDataGridViewTextBoxColumn,
            this.coinAmountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.logDateDataGridViewTextBoxColumn});
            this.dgvDetails.DataSource = this.bsCashRegisterDetails;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.Size = new System.Drawing.Size(700, 238);
            this.dgvDetails.TabIndex = 0;
            // 
            // bsCashRegisterDetails
            // 
            this.bsCashRegisterDetails.DataSource = typeof(CR.Entities.CashRegisterDetails);
            // 
            // refNumberDataGridViewTextBoxColumn
            // 
            this.refNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.refNumberDataGridViewTextBoxColumn.DataPropertyName = "RefNumber";
            this.refNumberDataGridViewTextBoxColumn.HeaderText = "Numero de Referencia";
            this.refNumberDataGridViewTextBoxColumn.Name = "refNumberDataGridViewTextBoxColumn";
            this.refNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coinAmountDataGridViewTextBoxColumn
            // 
            this.coinAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coinAmountDataGridViewTextBoxColumn.DataPropertyName = "CoinAmount";
            this.coinAmountDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.coinAmountDataGridViewTextBoxColumn.Name = "coinAmountDataGridViewTextBoxColumn";
            this.coinAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // llbCash
            // 
            this.llbCash.AutoSize = true;
            this.llbCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbCash.Location = new System.Drawing.Point(6, 34);
            this.llbCash.Name = "llbCash";
            this.llbCash.Size = new System.Drawing.Size(131, 29);
            this.llbCash.TabIndex = 5;
            this.llbCash.TabStop = true;
            this.llbCash.Text = "_";
            this.llbCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucCashierReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucCashierReport";
            this.Size = new System.Drawing.Size(719, 519);
            this.panel1.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlpBalances.ResumeLayout(false);
            this.tlpBalances.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.dbDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCashRegisterDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbOpenAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tlpBalances;
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
        private System.Windows.Forms.LinkLabel llbCredits;
        private System.Windows.Forms.LinkLabel llbTransfer;
        private System.Windows.Forms.LinkLabel llbDeposit;
        private System.Windows.Forms.LinkLabel llbCard;
        private System.Windows.Forms.GroupBox dbDetalles;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn refNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsCashRegisterDetails;
        private System.Windows.Forms.LinkLabel llbCash;
    }
}
