using System.Windows.Forms;
using CR.Utilities;
using CR.Utilities.Infraestructure;

namespace CR.UI.Config
{
    public partial class ucCoinType : UserControl
    {
        private readonly ICoinServices _coinServices;
        private readonly FormBase _frm;
        public ucCoinType(FormBase frm,ICoinServices coinServices)
        {
            InitializeComponent();
            _coinServices = coinServices;
            _frm = frm;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            _frm.CloseControl();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }
    }
}
