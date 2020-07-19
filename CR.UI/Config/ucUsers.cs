using System;
using System.Windows.Forms;
using CR.Utilities;
using CR.Utilities.Infraestructure;
using CR.Utilities.Enums;
using CR.Entities;
using System.Linq;
using CR.Entities.DTO;
using System.Collections.Generic;

namespace CR.UI.Config
{
    public partial class ucUsers : UserControl
    {
        private readonly FormBase _frm;
        private readonly ILoginServices _loginServices;

        public ucUsers(FormBase frm, ILoginServices loginServices)
        {
            InitializeComponent();
            _frm = frm;
            _loginServices = loginServices;
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInfo()) return;

            var rolIndex = cbUserType.SelectedIndex;

            var gid = Guid.Parse(((UserRoles)rolIndex).GetDescription());

            var user = new User
            {
                UserName = txtUser.Text.Trim(),
                Password = txtPassword.Text.Trim().EncryptText(),
                UserRol = gid,
                LogDate = DateTime.Now,
                IsActive = true
            };

            var result = _loginServices.Create(user);
            if (!result.Success)
            {
                MessageBox.Show($"He ocurrido un error al intentar crear el usuario. Error '{result.Message}'", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"El Usuario '{user.UserName}' ha sido creado exitosamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.RefreshFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _frm.CloseControl();
        }

        #region [Internal Methods]
        private bool ValidateInfo()
        {
            if (cbUserType.SelectedValue.Equals("NONE"))
            {
                MessageBox.Show("El campo 'Rol de Usuario' es requerido", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtUser.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El campo 'Usuario' es requerido", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El campo 'Contraseña' es requerido", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPassword.Text.Trim() != txtConfPassword.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no son iguales", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void RefreshFields()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtConfPassword.Clear();

            var values = Enum.GetNames(typeof(UserRoles));
            cbUserType.DataSource = values;

            //Load Users
            var users = _loginServices.GetAll();

            if(users.Success && users.Data.Any())
            {
                List<UserDTO> _us = new List<UserDTO>();

                foreach (var item in users.Data)
                {
                    _us.Add(new UserDTO
                    {
                        Id = item.Id,
                        UserName = item.UserName,
                        Rol = ExtentionMethods.GetValueFromDescription<UserRoles>(item.UserRol.ToString()).ToString()
                    });
                }

                bsUsuarios.DataSource = _us;
            }

        }
        #endregion
    }
}
