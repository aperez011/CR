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
        private readonly ILoginServices _loginServices;
        private FormBase _frm;

        public ucExpenses(FormBase frm, ICashExpenseServices cashExpenseServices, ILoginServices loginServices)
        {
            InitializeComponent();
            _cashExpenseServices = cashExpenseServices;
            _loginServices = loginServices;
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

                    this.LoadUser();
                    break;
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Refesh();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha Desde no puede ser mayor a la fecha Hasta.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;

            var result = _cashExpenseServices.FindBy(c => c.RegisterDate >= desde && c.RegisterDate <= hasta);

            if (!result.Success)
            {
                MessageBox.Show($"Ha ocurrido un error al realizar la busqueda de los gastos. Error '{result.Message}'", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bsCashExpenses.DataSource = result.Data;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpHasta.MinDate = dtpDesde.Value.Date;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde.MaxDate = dtpHasta.Value.Date;
        }

        private void LoadUser()
        {
            var users = _loginServices.GetUsers();

            if (users.Success) bsUsers.DataSource = users.Data;
        }
    }
}
