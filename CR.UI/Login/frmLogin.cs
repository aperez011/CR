using CR.UI.Login.UControl;
using CR.Utilities;
using CR.Utilities.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.UI.Login
{
    public partial class frmLogin : Form
    {
        private readonly ILoginServices _loginServices;

        public frmLogin(ILoginServices loginServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            var resultUsers = _loginServices.GetAll();

            UserControl control;

            if (resultUsers.Success && resultUsers.Data.Any())
                control = new ucLogin(this, _loginServices);
            else
                control = new ucNewAdminUser(_loginServices);

            control.Size = pnMain.Size;
            pnMain.Controls.Add(control);
        }
    }
}
