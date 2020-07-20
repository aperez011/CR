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
using CR.Utilities.Enums;
using CR.Entities;

namespace CR.UI.Caja
{
    public partial class ucOpenCashier : UserControl
    {
        private readonly ICoinServices _coinServices;
        private readonly ICashRegisterServices _cashRegisterServices;
        private readonly FormBase _frm;
        private CashRegister _cashRegister;

        public ucOpenCashier(FormBase frm, ICoinServices coinServices, ICashRegisterServices cashRegisterServices)
        {
            InitializeComponent();
            _frm = frm;
            _coinServices = coinServices;
            _cashRegisterServices = cashRegisterServices;
        }

        private void ucOpenCashier_Load(object sender, EventArgs e)
        {            
            _cashRegister = new CashRegister
            {
                CashierId = StaticProperties.User.Id,
                DateRegister = DateTime.Now.Date,
                RegisterType = Guid.Parse(CashRegisterTypes.Apertura.GetDescription()),
                LogDate = DateTime.Now,
                IsActive = true
            };

            this.LoadCoins();
        }

        private void LoadCoins()
        {
            var coinType = Guid.Parse(CoinsType.Efectivo.GetDescription());
            var coins = _coinServices.FindBy(c => c.Type == coinType);

            if (!coins.Success || !coins.Data.Any()) return;

            int sumX = 0,
                sumY = 0;

            var dim = gbCoins.Size;

            foreach (var coin in coins.Data)
            {
                var btn = new Button
                {
                    Location = new Point((10 + sumX), (20 + sumY)),
                    Width = 60,
                    Height = 35,
                    Text = string.Concat("RD$ ", coin.Name),
                    Name = coin.Id.ToString(),
                    BackColor = Color.LightBlue,
                    Padding = new Padding(6)
                };

                btn.Click += new EventHandler(btnCoin_Click);

                gbCoins.Controls.Add(btn);

                sumX += 65;
                if (sumX >= dim.Width)
                {
                    sumX = 0;
                    sumY += 40;
                }
            }

        }

        private void btnCoin_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            int id = int.Parse(btn.Name);

            var coin = _coinServices.FindBy(c => c.Id == id);
            if (!coin.Success || !coin.Data.Any()) return;

            var cashCoin = new CashCoinAmount(coin.Data.FirstOrDefault());
            if (cashCoin.ShowDialog() == DialogResult.Cancel) return;

            var detail = cashCoin._detail;

            _cashRegister.TotalAmount += detail.TotalAmount;
            _cashRegister.Details.Add(detail);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var resul = _cashRegisterServices.Create(_cashRegister);

            if (!resul.Success)
            {
                MessageBox.Show($"Ha ocurrido un error al intentar guardar la apertura de la caja. Error '{resul.Message}.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"La apertura de caja ha sido creada exitosamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frm.CloseControl();
        }
    }
}
