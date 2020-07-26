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
using CR.Entities.DTO;
using CR.Utilities.Enums;
using CR.Utilities.Infraestructure;
using System.Globalization;

namespace CR.UI.Reporte
{
    public partial class ucCashierReport : UserControl
    {
        private readonly FormBase _frm;
        private readonly IReportServices _reportServices;
        private ReportDTO reportData;

        public ucCashierReport(FormBase frm, IReportServices reportServices)
        {
            InitializeComponent();
            _frm = frm;
            _reportServices = reportServices;
        }

        private void ucCashierReport_Load(object sender, EventArgs e)
        {
            this.LoadReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _frm.CloseControl();
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

        private void Details(string coinType, string resgisterType)
        {
            var cType = Guid.Parse(coinType);
            var rType = Guid.Parse(resgisterType);

            var result = reportData.DetailResume.Details.Where(c => c.RegisterType == rType && c.CoinType == cType);

            bsCashRegisterDetails.DataSource = result;
        }

        private void LoadReport()
        {

            var result = _reportServices.GetReportBy(StaticProperties.User.Id, DateTime.Now.Date);

            if (result.Success)
            {
                reportData = result.Data;
                bsReportHeader.DataSource = result.Data.Header;
                bsReportDetail.DataSource = result.Data.DetailResume;
            }
            else
            {
                bsReportHeader.DataSource = new CashierReportDTO();
                bsReportDetail.DataSource = new BalanceDetails();
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
    }
}
