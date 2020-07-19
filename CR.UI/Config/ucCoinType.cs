using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CR.Entities;
using CR.Entities.DTO;
using CR.Utilities;
using CR.Utilities.Enums;
using CR.Utilities.Infraestructure;

namespace CR.UI.Config
{
    public partial class ucCoinType : UserControl
    {
        private readonly ICoinServices _coinServices;
        private readonly FormBase _frm;
        public ucCoinType(FormBase frm, ICoinServices coinServices)
        {
            InitializeComponent();
            _coinServices = coinServices;
            _frm = frm;
        }

        private void ucCoinType_Load(object sender, System.EventArgs e)
        {
            this.LoadDefaultValues();
            this.LoadCoins();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            _frm.CloseControl();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateInfo()) return;

            var enumValue = cbCoinType.SelectedIndex;
            var gid = Guid.Parse(((CoinsType)(enumValue)).GetDescription());

            var coin = new Coin
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Type = gid,
                LogDate = DateTime.Now,
                IsActive = true
            };

            var result = _coinServices.Create(coin);

            if (!result.Success)
            {
                MessageBox.Show($"Ha ocurrido un error al cargar guardar la moneda. Error '{result.Message}.'", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.LoadCoins();

        }

        #region [Custom Methods]

        private void LoadCoins()
        {
            var coins = _coinServices.GetAll();
            if (coins.Success && coins.Data.Any())
            {
                List<CoinsDTO> data = new List<CoinsDTO>();
                coins.Data.ToList().ForEach(c =>
                {
                    data.Add(new CoinsDTO
                    {
                        Id = c.Id,
                        Denominacion = c.Name,
                        Descripcion = (string.IsNullOrEmpty(c.Description) ? "N/A" : c.Description),
                        Tipo = ExtentionMethods.GetValueFromDescription<CoinsType>(c.Type.ToString()).ToString(),
                        Estado = (c.IsActive ? "Activo" : "Inactivo")
                    });
                });

                bsCoins.DataSource = data;
            }
        }

        private void LoadDefaultValues()
        {
            List<string> values = new List<string>();
            values.AddRange(Enum.GetNames(typeof(CoinsType)));
            cbCoinType.DataSource = values;
        }

        private bool ValidateInfo()
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show($"El campo Denominacion no puede estar en blanco", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbCoinType.SelectedValue.ToString() == "NONE")
            {
                MessageBox.Show($"Debe seleccioner un tipo de moneda", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion
    }
}
