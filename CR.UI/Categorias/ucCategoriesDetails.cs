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
using CR.Entities;

namespace CR.UI.Categorias
{
    public partial class ucCategoriesDetails : UserControl
    {
        private readonly IEnumerable<Category> _categories;

        public ucCategoriesDetails(IEnumerable<Category> categories)
        {
            InitializeComponent();
            _categories = categories;
        }

        private void ucCategoriesDetails_Load(object sender, EventArgs e)
        {
            bsCategories.DataSource = _categories;
            bsCategories.ResetBindings(true);
        }
    }
}
