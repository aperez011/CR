using CR.Entities.DTO;
using CR.Utilities.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.UI.Reporte
{
    public partial class frmReporteCaja : Form
    {
        private readonly IReportServices _reportServices;
        public frmReporteCaja(IReportServices reportServices)
        {
            InitializeComponent();
            _reportServices = reportServices;
        }

        private void frmReporteCaja_Load(object sender, EventArgs e)
        {
            this.LoadFilterInf();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpHasta.MinDate = dtpDesde.Value;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde.MaxDate = dtpHasta.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea cerrar este moduló?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadFilterInf()
        {

            var minDate = DateTime.Now.Date.AddDays(-30);
            var currentDate = DateTime.Now.Date;

            var inf = _reportServices.GetFilterInfoByDate(minDate, currentDate);

            //ComboBox Cashier
            List<UserDTO> cashier = new List<UserDTO>();

            if (inf.Success)
            {
                cashier.Add(new UserDTO
                {
                    Id = 0,
                    UserName = "NONE"

                });
                cashier.AddRange(inf.Data.Select(c => c.User).ToList());
            }

            cbCashiers.DataSource = cashier;
            cbCashiers.DisplayMember = "UserName";
            cbCashiers.ValueMember = "Id";
            cbCashiers.SelectedIndex = 0;
        }

        private void chbDate_Click(object sender, EventArgs e)
        {
            chbOther.Checked = !chbDate.Checked;
            gbDate.Enabled = chbDate.Checked;
            gbOthers.Enabled = !chbDate.Checked;
        }

        private void chbOther_Click(object sender, EventArgs e)
        {
            chbDate.Checked = !chbOther.Checked;
            gbOthers.Enabled = chbOther.Checked;
            gbDate.Enabled = !chbOther.Checked;
        }
    }
}
