using CR.UI.Config;
using CR.UI.Login;
using CR.Utilities;
using CR.Utilities.Infraestructure;
using System;
using System.Windows.Forms;

namespace CR.UI
{
    public partial class frmMain : FormBase
    {
        private readonly ILoginServices _loginServices;
        private readonly ICoinServices _coinServices;

        public frmMain(ILoginServices loginServices, ICoinServices coinServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _coinServices = coinServices;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //var login = new frmLogin(_loginServices);
            //if (login.ShowDialog() != DialogResult.OK) this.Close();
        }

        private void tsmiMonedas_Click(object sender, EventArgs e)
        {
            var ucCoins = new ucCoinType(this, _coinServices);
            pnMain.Controls.Add(ucCoins);
        }

        public override void CloseControl()
        {
            pnMain.Controls.Clear();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ucCoins = new ucUsers(this, _loginServices);
            pnMain.Controls.Add(ucCoins);
        }
    }
}
