namespace CR.UI.Categorias
{
    partial class ucCategoriesDetails
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
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.dgvMainCategiries = new System.Windows.Forms.DataGridView();
            this.gbCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCategiries)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.dgvMainCategiries);
            this.gbCategories.Location = new System.Drawing.Point(3, 3);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(713, 303);
            this.gbCategories.TabIndex = 4;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "groupBox2";
            // 
            // dgvMainCategiries
            // 
            this.dgvMainCategiries.AllowUserToAddRows = false;
            this.dgvMainCategiries.AllowUserToDeleteRows = false;
            this.dgvMainCategiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCategiries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCategiries.Location = new System.Drawing.Point(3, 16);
            this.dgvMainCategiries.Name = "dgvMainCategiries";
            this.dgvMainCategiries.ReadOnly = true;
            this.dgvMainCategiries.Size = new System.Drawing.Size(707, 284);
            this.dgvMainCategiries.TabIndex = 0;
            // 
            // ucCategoriesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCategories);
            this.Name = "ucCategoriesDetails";
            this.Size = new System.Drawing.Size(721, 312);
            this.gbCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCategiries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.DataGridView dgvMainCategiries;
    }
}
