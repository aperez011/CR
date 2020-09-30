using CR.Entities.DTO;
using CR.Utilities;
using CR.Utilities.Enums;
using CR.Utilities.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.UI.Reporte
{
    public partial class frmReporteCaja : Form
    {
        private readonly IReportServices _reportServices;
        private IEnumerable<FilterInformation> filterInformation;
        private ReportDTO reportData;
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
            if (chbOther.Checked)
            {
                this.SearchByShift();
            }
            else if (chbDate.Checked)
            {
                this.SearchByDate();
            }
        }

        private void LoadFilterInf()
        {

            var minDate = DateTime.Now.Date.AddDays(-30);
            var currentDate = DateTime.Now.Date;

            var inf = _reportServices.GetFilterInfoByDate(minDate, currentDate);

            //ComboBox Cashier
            List<UserDTO> cashier = new List<UserDTO>();

            if (inf.Success)
            {
                filterInformation = inf.Data;

                cashier.Add(new UserDTO
                {
                    Id = 0,
                    UserName = "Seleccione un Cajero"

                });
                cashier.AddRange(filterInformation.Select(c => c.User).ToList());
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

        private void cbCashiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shifts = new List<ShiftsInf>();

            var cashier = (UserDTO)cbCashiers.SelectedItem;
            var inf = filterInformation.FirstOrDefault(c => c.User.Id == cashier.Id);

            //Set shifts information
            shifts.Add(new ShiftsInf
            {
                ShiftCode = "Seleccione un Turno",
                ShiftId = 0,
            });

            if (inf != null) shifts.AddRange(inf.Shifts);

            cbShifts.DataSource = shifts;
            cbShifts.DisplayMember = "ShiftCode";
            cbShifts.ValueMember = "ShiftId";
            cbShifts.SelectedIndex = 0;
        }

        private void llbCash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;

            string coinType = CoinsType.Efectivo.GetDescription();
            string registerType = string.Empty;

            switch (llbBTN.Name)
            {
                case "llbCashOpen":
                    registerType = CashRegisterTypes.Apertura.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                case "llbCashClose":
                    registerType = CashRegisterTypes.Cierre.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                default:
                    break;
            }
        }

        private void llbCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;
            string coinType = CoinsType.Tarjeta.GetDescription();
            string registerType = string.Empty;

            switch (llbBTN.Name)
            {
                case "llbCardOpen":
                    registerType = CashRegisterTypes.Apertura.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                case "llbCardClose":
                    registerType = CashRegisterTypes.Cierre.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                default:
                    break;
            }
        }

        private void llbTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;
            string coinType = CoinsType.Transferencia.GetDescription();
            string registerType = string.Empty;

            switch (llbBTN.Name)
            {
                case "llbTransferOpen":
                    registerType = CashRegisterTypes.Apertura.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                case "llbTransferClose":
                    registerType = CashRegisterTypes.Cierre.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                default:
                    break;
            }
        }

        private void llbDeposit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;
            string coinType = CoinsType.Deposito.GetDescription();
            string registerType = string.Empty;

            switch (llbBTN.Name)
            {
                case "llbDepositOpen":
                    registerType = CashRegisterTypes.Apertura.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                case "llbDepositClose":
                    registerType = CashRegisterTypes.Cierre.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                default:
                    break;
            }
        }

        private void llbCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;
            string coinType = CoinsType.Credito.GetDescription();
            string registerType = string.Empty;

            switch (llbBTN.Name)
            {
                case "llbCreditOpen":
                    registerType = CashRegisterTypes.Apertura.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                case "llbCreditClose":
                    registerType = CashRegisterTypes.Cierre.GetDescription();
                    this.Details(coinType, registerType);
                    break;
                default:
                    break;
            }
        }

        private void lbBalance_TextChanged(object sender, EventArgs e)
        {
            var value = lbBalance.Text;
            if (value != string.Empty)
            {
                if (decimal.Parse(value, NumberStyles.Currency) < 0)
                {
                    lbBalance.BackColor = Color.OrangeRed;
                }
                else if (decimal.Parse(value, NumberStyles.Currency) > 0)
                {
                    lbBalance.BackColor = Color.LimeGreen;
                }
            }
        }

        private void Details(string coinType, string resgisterType)
        {
            var cType = Guid.Parse(coinType);
            var rType = Guid.Parse(resgisterType);

            var result = reportData.DetailResume.Details.Where(c => c.RegisterType == rType && c.CoinType == cType);

            bsCashRegisterDetails.DataSource = result;
        }

        private void SearchByDate()
        {

        }

        private void SearchByShift()
        {
            //Validate info
            var shift = (ShiftsInf)cbShifts.SelectedItem;
            if(shift.ShiftId == 0)
            {
                MessageBox.Show("Debe seleccionar un turno para buscar","Notificación",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var report = _reportServices.GetReportByShift(shift.ShiftId);

            if (report.Success)
            {
                reportData = report.Data;

                bsReportHeader.DataSource = reportData.Header;
                bsReportDetail.DataSource = reportData.DetailResume;
            }
            else
            {
                bsReportHeader.DataSource = new CashierReportDTO();
                bsReportDetail.DataSource = new BalanceDetails();
            }
        }
    }
}
