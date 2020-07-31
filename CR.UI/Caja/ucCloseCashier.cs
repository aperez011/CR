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
                ShiftId = _cashRegisterServices.GetNumberToCloseTurn(StaticProperties.User.Id),
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

            this.AddCashDetailToList(coin.Data.FirstOrDefault().Name, detail.CoinAmount);

            this.AddLabelToGroupBox();
        }

        private void btnOthersCoin_Click(object sender, EventArgs e)
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

            var othersCoin = new OthersAmount(coin.Data.FirstOrDefault());
            if (othersCoin.ShowDialog() == DialogResult.Cancel) return;

            var detail = othersCoin._detail;

            _cashRegister.TotalAmount += detail.TotalAmount;
            _cashRegister.Details.Add(detail);

            this.AddOtherDetailToList(coin.Data.FirstOrDefault().Name, detail.TotalAmount);

            this.AddLabelToGroupBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInfo()) return;

            var resul = _cashRegisterServices.Create(_cashRegister);

            if (!resul.Success)
            {
                MessageBox.Show($"Ha ocurrido un error al intentar guardar el cierre de la caja. Error '{resul.Message}.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"El cierre de caja ha sido creada exitosamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frm.CloseControl();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _frm.CloseControl();
        }

        private void btnRemoveCoin_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            var indx = int.Parse(btn.Name);

            var det = _cashRegister.Details.ToList()[indx];
            var lb = _lbList[indx];

            _lbList.Remove(lb);
            _cashRegister.Details.Remove(det);

            _cashRegister.TotalAmount = _cashRegister.Details.Sum(c => c.TotalAmount);

            this.AddLabelToGroupBox();
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

                btn.Click += new EventHandler(btnOthersCoin_Click);

                gbCardsAndCredits.Controls.Add(btn);


            }

        }

        private void AddCashDetailToList(string coinName, int coinAmount)
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

        private void AddOtherDetailToList(string coinName, decimal totalAmount)
        {
            var lb = new Label
            {
                Width = 190,
                Height = 30,
                Text = string.Concat($"{coinName} => ${totalAmount.ToString("##,###")}"),
                Name = coinName,
                BackColor = Color.LightGreen,
                Padding = new Padding(6),
                Font = new Font("Microsoft Sans Serif", 7)
            };

            _lbList.Add(lb);

            lbMontoTotal.Text = _cashRegister.TotalAmount.ToString("C");
        }

        private void AddLabelToGroupBox()
        {
            gbDetails.Controls.Clear();

            //GroupBox Height
            var gbDimH = gbDetails.Height;
            int labelWidt = 10;

            for (int i = 0; i < _lbList.Count; i++)
            {
                var lb = _lbList[i];

                var ctrls = gbDetails.Controls.Count;

                int pointY = 20;

                if (ctrls > 0)
                {
                    pointY = gbDetails.Controls[ctrls - 1].Location.Y + 35;

                    if ((pointY + lb.Height) > gbDimH)
                    {
                        pointY = 20;
                        labelWidt = lb.Width + 40;
                    }
                }

                lb.Location = new Point(labelWidt, pointY);

                gbDetails.Controls.Add(lb);

                var btn = new Button
                {
                    Location = new Point(lb.Width + labelWidt, lb.Location.Y - 2),
                    Width = 25,
                    Height = lb.Height + 3,
                    Text = "X",
                    Name = i.ToString(),
                    BackColor = Color.OrangeRed,
                    Padding = new Padding(4)
                };

                btn.Click += new EventHandler(btnRemoveCoin_Click);

                gbDetails.Controls.Add(btn);

            }

            lbMontoTotal.Text = _cashRegister.TotalAmount.ToString("C");
        }

        private bool ValidateInfo()
        {
            if (!_cashRegister.Details.Any())
            {
                MessageBox.Show("Debe agregar las denominaciones antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
