using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CR.Entities;
using CR.Utilities.Infraestructure;
using CR.Utilities;
using CR.Utilities.Enums;
using System.Collections.Generic;

namespace CR.UI.Caja
{
    public partial class ucCloseCashier : UserControl
    {
        private readonly ICoinServices _coinServices;
        private readonly ICashRegisterServices _cashRegisterServices;
        private readonly FormBase _frm;
        private CashRegister _cashRegister;
        private List<Label> _lbList;

        public ucCloseCashier(FormBase frm, ICoinServices coinServices, ICashRegisterServices cashRegisterServices)
        {
            InitializeComponent();
            _frm = frm;
            _coinServices = coinServices;
            _cashRegisterServices = cashRegisterServices;
        }

        private void ucCloseCashier_Load(object sender, EventArgs e)
        {
            _lbList = new List<Label>();

            _cashRegister = new CashRegister
            {
                CashierId = StaticProperties.User.Id,
                DateRegister = DateTime.Now.Date,
                RegisterType = Guid.Parse(CashRegisterTypes.Cierre.GetDescription()),
                LogDate = DateTime.Now,
                IsActive = true
            };

            this.LoadCashCoins();
            this.LoadOthersCoins();
        }

        private void btnCashCoin_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            int id = int.Parse(btn.Name);
            var validate = _cashRegister.Details.Where(c => c.CoinId == id);

            if (validate.Any())
            {
                MessageBox.Show("Este denominacion ya ha sido incluida, favor eliminar el detalle para modificar la cantidad.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var coin = _coinServices.FindBy(c => c.Id == id);
            if (!coin.Success || !coin.Data.Any()) return;

            var cashCoin = new CashCoinAmount(coin.Data.FirstOrDefault());
            if (cashCoin.ShowDialog() == DialogResult.Cancel) return;

            var detail = cashCoin._detail;

            _cashRegister.TotalAmount += detail.TotalAmount;
            _cashRegister.Details.Add(detail);

            this.AddDetailToList(coin.Data.FirstOrDefault().Name, detail.CoinAmount);

            this.AddLabelToGroupBox();
        }

        private void btnOthersCoin_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            //int id = int.Parse(btn.Name);
            //var validate = _cashRegister.Details.Where(c => c.CoinId == id);

            //if (validate.Any())
            //{
            //    MessageBox.Show("Este denominacion ya ha sido incluida, favor eliminar el detalle para modificar la cantidad.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //var coin = _coinServices.FindBy(c => c.Id == id);
            //if (!coin.Success || !coin.Data.Any()) return;

            //var cashCoin = new CashCoinAmount(coin.Data.FirstOrDefault());
            //if (cashCoin.ShowDialog() == DialogResult.Cancel) return;

            //var detail = cashCoin._detail;

            //_cashRegister.TotalAmount += detail.TotalAmount;
            //_cashRegister.Details.Add(detail);

            //this.AddDetailToList(coin.Data.FirstOrDefault().Name, detail.CoinAmount);

            //this.AddLabelToGroupBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _frm.CloseControl();
        }

        private void LoadCashCoins()
        {
            var coinType = Guid.Parse(CoinsType.Efectivo.GetDescription());
            var coins = _coinServices.FindBy(c => c.Type == coinType);

            if (!coins.Success || !coins.Data.Any()) return;

            int sumX = 0,
                sumY = 0;

            var dim = gbCashCoins.Size;

            foreach (var coin in coins.Data)
            {
                var btn = new Button
                {
                    Location = new Point((10 + sumX), (20 + sumY)),
                    Width = 80,
                    Height = 35,
                    Text = string.Concat("RD$ ", coin.Name),
                    Name = coin.Id.ToString(),
                    BackColor = Color.LightBlue,
                    Padding = new Padding(6)
                };

                btn.Click += new EventHandler(btnCashCoin_Click);

                gbCashCoins.Controls.Add(btn);

                sumX += 85;
                if (sumX >= dim.Width)
                {
                    sumX = 0;
                    sumY += 40;
                }
            }

        }
        
        private void LoadOthersCoins()
        {
            var coinType = Guid.Parse(CoinsType.Efectivo.GetDescription());
            var coins = _coinServices.FindBy(c => c.Type != coinType);

            if (!coins.Success || !coins.Data.Any()) return;

            int sumX = 0,
                sumY = 0;

            var dim = gbCardsAndCredits.Size;

            foreach (var coin in coins.Data)
            {
                var ctrls = gbCardsAndCredits.Controls.Count;

                if (ctrls > 0)
                {
                    sumX += 185;

                    var widthControlActual = 180;

                    if ((sumX + widthControlActual) >= dim.Width)
                    {
                        sumX = 0;
                        sumY += 40;
                    }
                }

                var btn = new Button
                {
                    Location = new Point((10 + sumX), (20 + sumY)),
                    Width = 180,
                    Height = 35,
                    Text = coin.Name,
                    Name = coin.Id.ToString(),
                    BackColor = Color.LightBlue,
                    Padding = new Padding(6)
                };

                //btn.Click += new EventHandler(btnCoin_Click);

                gbCardsAndCredits.Controls.Add(btn);


            }

        }

        private void AddDetailToList(string coinName, int coinAmount)
        {
            var lb = new Label
            {
                Width = 190,
                Height = 30,
                Text = string.Concat($"RD$ {coinName} => Cant.: {coinAmount.ToString()}"),
                Name = coinName,
                BackColor = Color.LightGreen,
                Padding = new Padding(6),
                Font = new Font("Microsoft Sans Serif", 11)
            };

            _lbList.Add(lb);

            lbMontoTotal.Text = _cashRegister.TotalAmount.ToString("C");
        }

        private void AddLabelToGroupBox()
        {
            gbDetails.Controls.Clear();

            for (int i = 0; i < _lbList.Count; i++)
            {
                var lb = _lbList[i];

                var ctrls = gbDetails.Controls.Count;

                int pointY = 20;

                if (ctrls > 0)
                {
                    pointY = gbDetails.Controls[ctrls - 1].Location.Y;
                    pointY += 35;
                }

                lb.Location = new Point(10, pointY);

                gbDetails.Controls.Add(lb);

                var btn = new Button
                {
                    Location = new Point(lb.Width + 10, lb.Location.Y - 2),
                    Width = 25,
                    Height = lb.Height + 3,
                    Text = "X",
                    Name = i.ToString(),
                    BackColor = Color.OrangeRed,
                    Padding = new Padding(4)
                };

                //btn.Click += new EventHandler(btnRemoveCoin_Click);

                gbDetails.Controls.Add(btn);

            }

            lbMontoTotal.Text = _cashRegister.TotalAmount.ToString("C");
        }
    }
}
