namespace CR.UI.Categorias
{
    partial class ucCategories
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
            this.scCategories = new System.Windows.Forms.SplitContainer();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scCategories)).BeginInit();
            this.scCategories.Panel1.SuspendLayout();
            this.scCategories.Panel2.SuspendLayout();
            this.scCategories.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // scCategories
            // 
            this.scCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCategories.Location = new System.Drawing.Point(0, 0);
            this.scCategories.Name = "scCategories";
            this.scCategories.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCategories.Panel1
            // 
            this.scCategories.Panel1.Controls.Add(this.gbButtons);
            // 
            // scCategories.Panel2
            // 
            this.scCategories.Panel2.AccessibleName = "pnMain";
            this.scCategories.Panel2.Controls.Add(this.pnMain);
            this.scCategories.Size = new System.Drawing.Size(719, 519);
            this.scCategories.SplitterDistance = 110;
            this.scCategories.TabIndex = 0;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnSalir);
            this.gbButtons.Controls.Add(this.btnNewCategory);
            this.gbButtons.Location = new System.Drawing.Point(3, 2);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(709, 101);
            this.gbButtons.TabIndex = 3;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(206, 28);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(178, 47);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(6, 28);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(178, 47);
            this.btnNewCategory.TabIndex = 0;
            this.btnNewCategory.Text = "Nueva Categoria";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(719, 405);
            this.pnMain.TabIndex = 0;
            // 
            // ucCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scCategories);
            this.Name = "ucCategories";
            this.Size = new System.Drawing.Size(719, 519);
            this.Load += new System.EventHandler(this.ucCategories_Load);
            this.scCategories.Panel1.ResumeLayout(false);
            this.scCategories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCategories)).EndInit();
            this.scCategories.ResumeLayout(false);
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scCategories;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnSalir;
    }
}
