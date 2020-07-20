using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CR.Utilities;

namespace CR.UI.Reporte
{
    public partial class ucCashierReport : UserControl
    {
        private readonly FormBase _frm;

        public ucCashierReport(FormBase frm)
        {
            InitializeComponent();
            _frm = frm;
        }
    }
}
