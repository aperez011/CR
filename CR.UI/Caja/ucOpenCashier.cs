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

namespace CR.UI.Caja
{
    public partial class ucOpenCashier : UserControl
    {
        private readonly ICoinServices _coinServices;
        private readonly FormBase _frm;

        public ucOpenCashier(FormBase frm, ICoinServices coinServices)
        {
            InitializeComponent();
            _frm = frm;
            _coinServices = coinServices;
        }

        private void ucOpenCashier_Load(object sender, EventArgs e)
        {
            //gbCoins.Location = new Point(pnCenter.Width / 2 - gbCoins.Size.Width / 2,
            //                             pnCenter.Height / 2 - gbCoins.Size.Height / 2);
            //gbCoins.Anchor = AnchorStyles.None;

            this.LoadCoins();
        }

        private void LoadCoins()
        {
            var coins = _coinServices.GetAll();
        }
    }
}
