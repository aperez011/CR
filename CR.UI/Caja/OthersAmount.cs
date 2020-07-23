using CR.Entities;
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
    public partial class OthersAmount : Form
    {
        public CashRegisterDetails _detail;
        private readonly Coin _coinDenomination;

        public OthersAmount(Coin coin)
        {
            InitializeComponent();
            _coinDenomination = coin;
        }

        private void OthersAmount_Load(object sender, EventArgs e)
        {
            lbCoinName.Text = _coinDenomination.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidatedInfo()) return;

            var detail = new CashRegisterDetails
            {
                CoinId = _coinDenomination.Id,
                RefNumber = txtRefNum.Text.Trim(),
                TotalAmount = decimal.Parse(txtCoinAmount.Text.Trim()),
                LogDate = DateTime.Now,
                IsActive = true
            };

            _detail = detail;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidatedInfo()
        {
            if (txtCoinAmount.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El campo monto es requerido.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtCoinAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
    }
}
