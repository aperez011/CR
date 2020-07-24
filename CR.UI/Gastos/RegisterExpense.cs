using CR.Entities;
using CR.Services;
using System;
using System.Windows.Forms;

namespace CR.UI.Gastos
{
    public partial class RegisterExpense : Form
    {
        private CashExpense _cashExpense;
        public RegisterExpense(CashExpense cashExpense)
        {
            InitializeComponent();
            _cashExpense = cashExpense;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cashExpense.BillNum = txtBillNum.Text.Trim();
            _cashExpense.BillAmount = decimal.Parse(txtBillAmount.Text.Trim());
            _cashExpense.Reason = txtReason.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtBillAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
    }
}
