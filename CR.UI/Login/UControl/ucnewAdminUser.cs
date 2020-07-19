using System;
using System.Windows.Forms;
using CR.Utilities.Infraestructure;
using CR.Entities;
using CR.Utilities;
using CR.Utilities.Enums;
using System.Linq;

namespace CR.UI.Login.UControl
{
    public partial class ucNewAdminUser : UserControl
    {
        private readonly ILoginServices _loginServices;
        public ucNewAdminUser(ILoginServices loginServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateUser()) return;

            string password = txtPassword.Text.Trim();

            var user = new User
            {
                UserName = txtUser.Text.Trim(),
                Password = password.EncryptText(),
                UserRol = Guid.Parse(UserRoles.Admin.GetDescription()),
                LogDate = DateTime.Now,
                IsActive = true
            };

            var result = _loginServices.Create(user);

            if(result.Success) Application.Restart();

            MessageBox.Show($"Ha ocurrido un error al intentar crear el usuario, Error '{result.Message}'", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region [Internal Methods]

        public bool ValidateUser()
        {
            try
            {
                if (txtUser.Text.Trim() == string.Empty)
                {
                    MessageBox.Show($"El campo usuario estar en blanco", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show($"El campo contraseña estar en blanco","Notificación",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtPassword.Text != txtConfPassword.Text)
                {
                    MessageBox.Show($"Las contraseñas no coinciden", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
