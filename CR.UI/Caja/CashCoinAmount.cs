using CR.Entities;
using CR.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.UI.Caja
{
    public partial class CashCoinAmount : Form
    {
        public CashRegisterDetails _detail;
        private readonly Coin _coinDenomination;

        public CashCoinAmount(Coin coin)
        {
            InitializeComponent();
            _coinDenomination = coin;
        }

        private void CashCoinAmount_Load(object sender, EventArgs e)
        {
            lbCoin.Text = _coinDenomination.Name;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAmount.Text, out int val)) return;
            lbMonto.Text = (int.Parse(_coinDenomination.Name) * val).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text.Trim())) return;

            _detail = new CashRegisterDetails
            {
                CoinId = _coinDenomination.Id,
                CoinAmount = int.Parse(txtAmount.Text),
                TotalAmount = decimal.Parse(lbMonto.Text),
                LogDate = DateTime.Now,
                IsActive = true
            };

            DialogResult = DialogResult.OK;
        }
    }
}