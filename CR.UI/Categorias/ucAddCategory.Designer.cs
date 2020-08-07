namespace CR.UI.Categorias
{
    partial class ucAddCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddSubCategory = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSubCategory = new System.Windows.Forms.GroupBox();
            this.dgvSubCategories = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsSubCategory = new System.Windows.Forms.BindingSource(this.components);
            this.gbCategory.SuspendLayout();
            this.gbSubCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategory
            // 
            this.gbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategory.Controls.Add(this.btnSave);
            this.gbCategory.Controls.Add(this.btnAddSubCategory);
            this.gbCategory.Controls.Add(this.txtDescription);
            this.gbCategory.Controls.Add(this.txtName);
            this.gbCategory.Controls.Add(this.txtCode);
            this.gbCategory.Controls.Add(this.label3);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Location = new System.Drawing.Point(3, 3);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(723, 113);
            this.gbCategory.TabIndex = 1;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Categoria";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(457, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 42);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "GUARDAR CATEGORIA";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSubCategory.Location = new System.Drawing.Point(457, 19);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(260, 42);
            this.btnAddSubCategory.TabIndex = 6;
            this.btnAddSubCategory.Text = "AGREGAR SUB-CATEGORIA";
            this.btnAddSubCategory.UseVisualStyleBackColor = false;
            this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(179, 35);
            this.txtDescription.MaxLength = 150;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 70);
            this.txtDescription.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 82);
            this.txtName.MaxLength = 15;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(6, 35);
            this.txtCode.MaxLength = 10;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(148, 23);
            this.txtCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // gbSubCategory
            // 
            this.gbSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSubCategory.Controls.Add(this.dgvSubCategories);
            this.gbSubCategory.Location = new System.Drawing.Point(3, 129);
            this.gbSubCategory.Name = "gbSubCategory";
            this.gbSubCategory.Size = new System.Drawing.Size(723, 258);
            this.gbSubCategory.TabIndex = 2;
            this.gbSubCategory.TabStop = false;
            this.gbSubCategory.Text = "Sub Categorias";
            // 
            // dgvSubCategories
            // 
            this.dgvSubCategories.AllowUserToAddRows = false;
            this.dgvSubCategories.AllowUserToDeleteRows = false;
            this.dgvSubCategories.AutoGenerateColumns = false;
            this.dgvSubCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.logDateDataGridViewTextBoxColumn,
            this.edit,
            this.remove});
            this.dgvSubCategories.DataSource = this.bsSubCategory;
            this.dgvSubCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategories.Location = new System.Drawing.Point(3, 16);
            this.dgvSubCategories.Name = "dgvSubCategories";
            this.dgvSubCategories.ReadOnly = true;
            this.dgvSubCategories.RowHeadersVisible = false;
            this.dgvSubCategories.Size = new System.Drawing.Size(717, 239);
            this.dgvSubCategories.TabIndex = 0;
            this.dgvSubCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubCategories_CellClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle1.NullValue = "NONE";
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.logDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.logDateDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Editar";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Editar";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // remove
            // 
            this.remove.HeaderText = "Eliminar";
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Text = "Eliminar";
            this.remove.UseColumnTextForButtonValue = true;
            // 
            // bsSubCategory
            // 
            this.bsSubCategory.DataSource = typeof(CR.Entities.Category);
            // 
            // ucAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSubCategory);
            this.Controls.Add(this.gbCategory);
            this.Name = "ucAddCategory";
            this.Size = new System.Drawing.Size(732, 398);
            this.Load += new System.EventHandler(this.ucAddCategory_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.gbSubCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.GroupBox gbSubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSubCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvSubCategories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}
