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

            switch (llbBTN.Name)
            {
                case "llbCardOpen":
                    var test = 1;
                    break;
                case "llbCardClose":
                    var test1 = 2;
                    break;
                default:
                    break;
            }
        }

        private void llbTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;

            switch (llbBTN.Name)
            {
                case "llbTransferOpen":
                    var test = 1;
                    break;
                case "llbTransferClose":
                    var test1 = 2;
                    break;
                default:
                    break;
            }
        }

        private void llbDeposit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;

            switch (llbBTN.Name)
            {
                case "llbDepositOpen":
                    var test = 1;
                    break;
                case "llbDepositClose":
                    var test1 = 2;
                    break;
                default:
                    break;
            }
        }

        private void llbCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llbBTN = (LinkLabel)sender;

            switch (llbBTN.Name)
            {
                case "llbCreditOpen":
                    var test = 1;
                    break;
                case "llbCreditClose":
                    var test1 = 2;
                    break;
                default:
                    break;
            }
        }

        private void Details(string coinType, string resgisterType)
        {

        }

        private void LoadReport()
        {
            bsReportHeader.DataSource = new CashierReportDTO();
            bsReportDetail.DataSource = new BalanceDetails();
        }
    }
}
