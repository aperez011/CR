using System;
using System.Windows.Forms;
using CR.Entities;
using CR.Utilities;
using CR.Utilities.Infraestructure;

namespace CR.UI.Categorias
{
    public partial class ucAddCategory : UserControl
    {
        internal Category Category { get; set; }

        private readonly UserControlBase _ucBase;
        private readonly ICategoryServices _categoryServices;

        public ucAddCategory(UserControlBase ucBase, ICategoryServices categoryServices)
        {
            InitializeComponent();
            _ucBase = ucBase;
            _categoryServices = categoryServices;
        }

        private void ucAddCategory_Load(object sender, EventArgs e)
        {
            Category = new Category();
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            var subCategory = new NewSubCategory();

            if (subCategory.ShowDialog() != DialogResult.OK) return;

            var subCat = subCategory.SubCategory;
            Category.SubCategories.Add(subCat);

            bsSubCategory.DataSource = Category.SubCategories;
            bsSubCategory.ResetBindings(true);
        }

        private void dgvSubCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var columnIndex = dgvSubCategories.CurrentCell.ColumnIndex;

            switch (columnIndex)
            {
                case 4: //Edit
                    this.EditSubCategory();
                    break;
                case 5: //Remove
                    this.RemoveSubCategory();
                    break;
                default:
                    break;
            }
        }

        private void EditSubCategory()
        {
            var subCategory = new NewSubCategory((Category)bsSubCategory.Current);

            if (subCategory.ShowDialog() != DialogResult.OK) return;
        }

        private void RemoveSubCategory()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _categoryServices.Create(Category);

            _ucBase.OnClickReset();
        }
    }
}
