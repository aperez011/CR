using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CR.Utilities.Infraestructure;
using CR.Utilities;
using CR.Entities;
using CR.Utilities.Enums;
using System.Drawing;

namespace CR.UI.Gastos
{
    public partial class ucExpenses : UserControl
    {
        private readonly ICashExpenseServices _cashExpenseServices;
        private FormBase _frm;
        public ucExpenses(FormBase frm, ICashExpenseServices cashExpenseServices)
        {
            InitializeComponent();
            _cashExpenseServices = cashExpenseServices;
            _frm = frm;
        }

        private void ucExpenses_Load(object sender, EventArgs e)
        {

            lbTextFil.Visible = (StaticProperties.User.Rol == UserRoles.Admin.ToString());
            cbFiltarPor.Visible = (StaticProperties.User.Rol == UserRoles.Admin.ToString());

            this.Refesh();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            var cashExpense = new CashExpense
            {
                RegisterDate = DateTime.Now.Date,
                LogDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                UserId = StaticProperties.User.Id,
                IsActive = true
            };


            var addExpense = new RegisterExpense(cashExpense);
            if (addExpense.ShowDialog() != DialogResult.OK) return;


            var result = _cashExpenseServices.Create(cashExpense);

            if (!result.Success)
            {
                MessageBox.Show($"Ha ocurrido un error al registrar el gasto. Error '{result.Message}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("El gasto ha sido registrado exitosamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Refesh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _frm.CloseControl();
        }

        private void Refesh()
        {
            IEnumerable<CashExpense> expenses = null;

            if (StaticProperties.User.Rol == UserRoles.Admin.ToString())
            {
                var result = _cashExpenseServices.GetAll();
                if (result.Success) expenses = result.Data;
            }
            else
            {
                var result = _cashExpenseServices.FindBy(c => c.UserId == StaticProperties.User.Id);
                if (result.Success) expenses = result.Data;
            }

            bsCashExpenses.DataSource = expenses;
        }

        private void cbFiltarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = cbFiltarPor.SelectedItem;

            switch (selected)
            {
                case "Por Fecha":
                    pnPorUsuario.Visible = false;

                    pnPorFecha.Location = new Point(358, 3);
                    pnPorFecha.Visible = true;
                    break;
                case "Por Usuario":
                    pnPorFecha.Visible = false;

                    pnPorUsuario.Location = new Point(358, 3);
                    pnPorUsuario.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Refesh();
        }
    }
}
