using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CR.Utilities.Infraestructure;
using CR.Utilities;
using CR.Entities;
using CR.Utilities.Enums;
using System.Drawing;
using System.Linq;
using CR.Entities.DTO;

namespace CR.UI.Gastos
{
    public partial class ucExpenses : UserControl
    {
        private readonly ICashExpenseServices _cashExpenseServices;
        private readonly IExpenseTypesServices _expenseTypesServices;
        private readonly ILoginServices _loginServices;
        private FormBase _frm;

        public ucExpenses(FormBase frm,
                          ICashExpenseServices cashExpenseServices,
                          ILoginServices loginServices,
                          IExpenseTypesServices expenseTypesServices)
        {
            InitializeComponent();
            _cashExpenseServices = cashExpenseServices;
            _expenseTypesServices = expenseTypesServices;
            _loginServices = loginServices;
            _frm = frm;
        }

        private void ucExpenses_Load(object sender, EventArgs e)
        {

            lbTextFil.Visible = (StaticProperties.User.Rol == UserRoles.Admin.ToString());
            cbFiltarPor.Visible = (StaticProperties.User.Rol == UserRoles.Admin.ToString());

            this.Refesh();
            this.LoadInfo();
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


            var addExpense = new RegisterExpense(cashExpense, _expenseTypesServices);
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
            var location = new Point(358, 3);

            switch (selected)
            {
                case "Fecha":
                    pnPorUsuario.Visible = false;
                    pnTipoGasto.Visible = false;

                    pnPorFecha.Location = location;
                    pnPorFecha.Visible = true;
                    break;
                case "Usuario":
                    pnPorFecha.Visible = false;
                    pnTipoGasto.Visible = false;

                    pnPorUsuario.Location = location;
                    pnPorUsuario.Visible = true;
                    break;
                case "Tipo de Gasto":
                    pnPorFecha.Visible = false;
                    pnPorUsuario.Visible = false;

                    pnTipoGasto.Location = location;
                    pnTipoGasto.Visible = true;
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

        private void LoadInfo()
        {
            //Load Users
            var userResult = _loginServices.GetUsers();
            if (userResult.Success)
            {

                if (StaticProperties.User.Rol != UserRoles.Admin.ToString())
                {
                    cbUsers.DataSource = userResult.Data.ToList().Where(c => c.Id == StaticProperties.User.Id);
                    cbUsers.DisplayMember = "UserName";
                }
                else
                {
                    cbUsers.DataSource = userResult.Data.ToList();
                    cbUsers.DisplayMember = "UserName";
                }
            }

            //Load Expense Types
            var expenses = _expenseTypesServices.FindBy(exp => exp.IsActive);
            if (expenses.Success)
            {
                cbExpenseTypes.DataSource = expenses.Data.ToList();
                cbExpenseTypes.DisplayMember = "Name";
            }
        }

        private void btnSearchByExpenseType_Click(object sender, EventArgs e)
        {
            var expenseType = (ExpenseType)cbExpenseTypes.SelectedItem;

            var expenses = _cashExpenseServices.FindBy(ce => ce.ExpenseTypeId == expenseType.Id);
            bsCashExpenses.DataSource = expenses;
            bsCashExpenses.ResetBindings(true);
        }

        private void btnSearchByUser_Click(object sender, EventArgs e)
        {
            var user = (UserDTO)cbUsers.SelectedItem;

            var expenses = _cashExpenseServices.FindBy(ce => ce.UserId == user.Id);
            bsCashExpenses.DataSource = expenses;
            bsCashExpenses.ResetBindings(true);
        }
    }
}
