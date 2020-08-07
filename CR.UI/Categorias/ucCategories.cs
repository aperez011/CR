using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CR.Utilities;
using CR.Utilities.Infraestructure;
using CR.Entities;

namespace CR.UI.Categorias
{
    public partial class ucCategories : UserControlBase
    {
        private readonly FormBase _frm;
        private readonly ICategoryServices _categoryServices;

        public ucCategories(FormBase frm, ICategoryServices categoryServices)
        {
            InitializeComponent();
            _frm = frm;
            _categoryServices = categoryServices;
        }

        private void ucCategories_Load(object sender, EventArgs e)
        {
            this.LoadDetailControl();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            this.ControlClear();

            var addCategory = new ucAddCategory(this, _categoryServices);
            addCategory.Size = pnMain.Size;
            pnMain.Controls.Add(addCategory);
        }

        private void ControlClear()
        {
            pnMain.Controls.Clear();
        }

        public void LoadDetailControl()
        {
            this.ControlClear();
            IEnumerable<Category> categories = new List<Category>();

            var result = _categoryServices.FindBy(c => c.OwnerId == null);

            if (result.Success) categories = result.Data;

            var details = new ucCategoriesDetails(categories);
            details.Size = pnMain.Size;
            pnMain.Controls.Add(details);

        }

        public override void OnClickReset()
        {
            this.LoadDetailControl();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.LoadDetailControl();
        }
    }
}
