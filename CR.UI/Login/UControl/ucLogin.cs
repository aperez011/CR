using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CR.Utilities.Infraestructure;
using CR.Utilities;
using CR.Entities.DTO;
using CR.Utilities.Enums;

namespace CR.UI.Login.UControl
{
    public partial class ucLogin : UserControl
    {
        private readonly ILoginServices _loginServices;
        private readonly Form _frm;

        public ucLogin(Form frm, ILoginServices loginServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _frm = frm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _frm.DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInformation()) return;

            var validUser = _loginServices.Login(txtUser.Text, txtPassword.Text);

            if (validUser.Success)
            {
                var user = validUser.Data;
                StatisProperties.User = new UserDTO
                                            {
                                                Id = user.Id,
                                                UserName = user.UserName,
                                                Rol = ExtentionMethods.GetValueFromDescription<UserRoles>(user.UserRol.ToString()).ToString()
                                            };

                _frm.DialogResult = DialogResult.OK;
                return;
            }

            MessageBox.Show(validUser.Message, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateInformation()
        {

            if (txtUser.Text.Trim() == string.Empty)
            {

                MessageBox.Show($"El nombre de usuario es requerido", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPassword.Text.Trim() == string.Empty)
            {

                MessageBox.Show($"El password es requerido", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }
    }
}
