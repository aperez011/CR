using CR.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.UI.Categorias
{
    public partial class NewSubCategory : Form
    {
        public Category SubCategory { get { return (Category)bsSubCat.Current; } }

        public NewSubCategory(Category subCategory = null)
        {
            InitializeComponent();
            bsSubCat.DataSource = subCategory == null ? new Category() : subCategory;
            bsSubCat.ResetBindings(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFields()) return;

            //SubCategory.Code = txtCode.Text.Trim();
            //SubCategory.Name = txtName.Text.Trim();
            //SubCategory.Description = string.IsNullOrEmpty(txtDescription.Text.Trim()) ? null : txtDescription.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidateFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("El campo Codigo no puede estar en blanco.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("El campo Nombre no puede estar en blanco", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }
    }
}
