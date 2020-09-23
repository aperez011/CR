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

namespace CR.UI.Config
{
    public partial class ucExpenseType : UserControl
    {
        private readonly IExpenseTypesServices _expenseTypeServices;
        private readonly FormBase _frm;
        public ucExpenseType(FormBase frm, IExpenseTypesServices expenseTypesServices)
        {
            InitializeComponent();
            _frm = frm;
            _expenseTypeServices = expenseTypesServices;
        }

        private void ucExpenseType_Load(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Validate()) return;

            var expenseType = new ExpenseType
            {
                Code = txtCode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
            };

            _expenseTypeServices.Create(expenseType);

            this.Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _frm.CloseControl();
        }

        private void Reset()
        {
            ICollection<ExpenseType> expenseTypes;

            var result = _expenseTypeServices.FindBy(x => x.IsActive);
            if (result.Success)
            {
                expenseTypes = result.Data.ToList();
            }
            else
            {
                expenseTypes = new List<ExpenseType>();
            }

            bsExpeseTypes.DataSource = expenseTypes;

            //Clear components
            txtCode.Clear();
            txtName.Clear();
            txtDescription.Clear();

        }

        private bool Validate()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("Debe indicar un Codigo para el tipo de gasto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = true;
            }
            else
            {
                //Validate Code
                var codeExist = _expenseTypeServices.FindBy(x => x.Code == txtCode.Text.Trim());
                if (codeExist.Data.Any())
                {
                    MessageBox.Show($"El codigo '{txtCode.Text.Trim()}' ya se encuentra registrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = true;
                }
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Debe indicar un Nombre para el tipo de gasto.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = true;
            }


            return result;
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;

            var cell = dgv.CurrentCell;

            if (cell.OwningColumn.HeaderText == "Borrar")
            {
                var row = (ExpenseType)bsExpeseTypes.Current;

                if (MessageBox.Show($"Esta seguro que desea eliminar el tipo de gasto '{row.Name}'.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) return;

                var result = _expenseTypeServices.Delete(row.Id);

                if (!result.Success)
                {
                    MessageBox.Show($"Ha ocurrido un error a eliminar el registro. Error:'{result.Message}'.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Reset();
            }
        }
    }
}
