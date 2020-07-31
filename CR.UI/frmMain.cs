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
        private readonly IReportServices _reportServices;

        public frmMain(ILoginServices loginServices
                     , ICoinServices coinServices
                     , ICashRegisterServices cashRegisterServices
                     , ICashExpenseServices cashExpenseServices
                     , IReportServices reportServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _coinServices = coinServices;
            _cashRegisterServices = cashRegisterServices;
            _cashExpenseServices = cashExpenseServices;
            _reportServices = reportServices;
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
            if (_cashRegisterServices.ValidateOpenTurn(StaticProperties.User.Id))
            {
                MessageBox.Show("Este usuario ya posee un turno abierto, favor cerrar antes de proseguir.", "Notficación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.CloseControl();

            var openCashier = new ucOpenCashier(this, _coinServices, _cashRegisterServices);
            pnMain.Controls.Add(openCashier);
        }

        private void btnCloseCashier_Click(object sender, EventArgs e)
        {
            var turnOpen = _cashRegisterServices.ValidateOpenTurn(StaticProperties.User.Id);

            if (!turnOpen)
            {
                MessageBox.Show("Debe tener un turno abierto antes de cerrar la caja.", "Notficación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.CloseControl();

            var openCashier = new ucCloseCashier(this, _coinServices, _cashRegisterServices);
            pnMain.Controls.Add(openCashier);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.CloseControl();

            var ucReport = new ucCashierReport(this, _reportServices);
            ucReport.Size = pnMain.Size;

            pnMain.Controls.Add(ucReport);
        }

        private void tsbReports_Click(object sender, EventArgs e)
        {
            var report = new frmReporteCaja();

            report.ShowDialog();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            this.CloseControl();

            var expense = new ucExpenses(this, _cashExpenseServices, _loginServices);
            pnMain.Controls.Add(expense);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea salir?", "Motificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel) return;

            Application.Restart();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea salir?", "Motificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel) e.Cancel = true;

        }
    }
}
