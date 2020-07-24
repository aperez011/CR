using CR.UI.Caja;
using CR.UI.Config;
using CR.UI.Gastos;
using CR.UI.Login;
using CR.UI.Reporte;
using CR.Utilities;
using CR.Utilities.Enums;
using CR.Utilities.Infraestructure;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CR.UI
{
    public partial class frmMain : FormBase
    {
        private readonly ILoginServices _loginServices;
        private readonly ICoinServices _coinServices;
        private readonly ICashRegisterServices _cashRegisterServices;
        private readonly ICashExpenseServices _cashExpenseServices;

        public frmMain(ILoginServices loginServices
                     , ICoinServices coinServices
                     , ICashRegisterServices cashRegisterServices
                     , ICashExpenseServices cashExpenseServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _coinServices = coinServices;
            _cashRegisterServices = cashRegisterServices;
            _cashExpenseServices = cashExpenseServices;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var login = new frmLogin(_loginServices);
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }

            var userDto = StaticProperties.User;
            bsUser.DataSource = userDto;

            if (userDto.Rol != UserRoles.Admin.ToString()) tsMenu.Visible = false;
        }

        private void tsmiMonedas_Click(object sender, EventArgs e)
        {
            this.CloseControl();
            var ucCoins = new ucCoinType(this, _coinServices);
            pnMain.Controls.Add(ucCoins);
        }

        public override void CloseControl()
        {
            pnMain.Controls.Clear();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseControl();
            var ucCoins = new ucUsers(this, _loginServices);
            pnMain.Controls.Add(ucCoins);
        }

        private void btnOpenCashier_Click(object sender, EventArgs e)
        {

            var date = DateTime.Now.Date;
            var cajaEstado = _cashRegisterServices.FindBy(c => c.CashierId == StaticProperties.User.Id && c.DateRegister == date);

            if (cajaEstado.Success)
            {
                var data = cajaEstado.Data;

                var open = data.Count(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Apertura.GetDescription()));
                var close = data.Count(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Cierre.GetDescription()));


                if (open != close)
                {
                    MessageBox.Show("La caja ya ha sido aperturada", "Notficación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            this.CloseControl();

            var openCashier = new ucOpenCashier(this, _coinServices, _cashRegisterServices);
            pnMain.Controls.Add(openCashier);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.CloseControl();

            var ucReport = new ucCashierReport(this);
            pnMain.Controls.Add(ucReport);
        }

        private void btnCloseCashier_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.Date;
            var cajaEstado = _cashRegisterServices.FindBy(c => c.CashierId == StaticProperties.User.Id && c.DateRegister == date);

            if (cajaEstado.Success)
            {
                var data = cajaEstado.Data;

                var open = data.Count(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Apertura.GetDescription()));
                var close = data.Count(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Cierre.GetDescription()));

                if (open == 0)
                {
                    MessageBox.Show("Debe aperturada la caja", "Notficación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (open == close)
                {
                    MessageBox.Show("La caja ya ha sido cerrada", "Notficación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            this.CloseControl();

            var openCashier = new ucCloseCashier(this, _coinServices, _cashRegisterServices);
            pnMain.Controls.Add(openCashier);
        }

        private void tsbReports_Click(object sender, EventArgs e)
        {
            var report = new frmReporteCaja();

            report.ShowDialog();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            var expense = new ucExpenses(this, _cashExpenseServices);
            pnMain.Controls.Add(expense);
        }
    }
}
