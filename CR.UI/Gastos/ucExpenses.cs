using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.UI.Gastos
{
    public partial class ucExpenses : UserControl
    {
        public ucExpenses()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            var addExpense = new RegisterExpense();
            addExpense.ShowDialog();
        }
    }
}
