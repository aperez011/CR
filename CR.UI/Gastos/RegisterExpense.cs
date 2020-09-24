using CR.Entities;
using CR.Services;
using CR.Utilities.Infraestructure;
using System;
using System.Windows.Forms;

namespace CR.UI.Gastos
{
    public partial class RegisterExpense : Form
    {
        private CashExpense _cashExpense;
        private readonly IExpenseTypesServices _expenseTypesServices;

        public RegisterExpense(CashExpense cashExpense, IExpenseTypesServices expenseTypesServices)
        {
            InitializeComponent();
            _cashExpense = cashExpense;
            _expenseTypesServices = expenseTypesServices;
        }

        private void RegisterExpense_Load(object sender, EventArgs e)
        {
            this.LoadInf();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var expenseType = (ExpenseType)cbExpenseTypes.SelectedItem;

            _cashExpense.ExpenseTypeId = expenseType.Id;
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

        private void LoadInf()
        {
            var expensesResult = _expenseTypesServices.FindBy(exp => exp.IsActive);
            if (expensesResult.Success)
            {
                cbExpenseTypes.DataSource = expensesResult.Data;
                cbExpenseTypes.DisplayMember = "Name";
                cbExpenseTypes.ValueMember = "Id";
            }
        }
    }
}
