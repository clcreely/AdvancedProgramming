using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamQ1
{
    public partial class Form1 : Form
    {

        List<Meters> GasMeterRecords;
        List<Accounts> AccountRecords;

        public Form1()
        {
            InitializeComponent();

           GasMeterRecords = new List<Meters>() {
                new Meters
                {
                    MetreID = 100,
                    VolumeUsed = 6805,
                    HasBeenServiced = true,
                    OwnerAccountID = 50001
                },
                new Meters
                {
                    MetreID = 101,
                    VolumeUsed = 13609,
                    HasBeenServiced = true,
                    OwnerAccountID = 50002
                },
                new Meters
                {
                    MetreID = 102,
                    VolumeUsed = 28115,
                    HasBeenServiced = false,
                    OwnerAccountID = 50003
                },
                new Meters
                {
                    MetreID = 103,
                    VolumeUsed = 32191,
                    HasBeenServiced = false,
                    OwnerAccountID = 50004
                },
                new Meters
                {
                    MetreID = 104,
                    VolumeUsed = 19100,
                    HasBeenServiced = false,
                    OwnerAccountID = 50005
                }
            };

            AccountRecords = new List<Accounts>()
            {
                new Accounts {AccountID = 50001, EirCode = "DV4R102", PaymentPeriod = PaymentPeriod.BiAnnual, ArrearsCount = 2 },
                new Accounts {AccountID = 50002, EirCode = "DV4R103", PaymentPeriod = PaymentPeriod.Annual, ArrearsCount = 2},
                new Accounts {AccountID = 50003, EirCode = "DV4R104", PaymentPeriod = PaymentPeriod.Monthly, ArrearsCount = 1},
                new Accounts {AccountID = 50004, EirCode = "DV4S101", PaymentPeriod = PaymentPeriod.Quarterly, ArrearsCount = 0},
                new Accounts {AccountID = 50005, EirCode = "DV4S102", PaymentPeriod = PaymentPeriod.Annual, ArrearsCount = 0},
                new Accounts {AccountID = 50006, EirCode = "DV4S103", PaymentPeriod = PaymentPeriod.BiAnnual, ArrearsCount = 0}
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           dgvGasMeterRecords.DataSource = (from meter in GasMeterRecords
                                            select meter).ToList();

            dgvAccountRecords.DataSource = null;
        }

        private void dgvGasMeterRecords_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedAccountID = Convert.ToInt32(dgvGasMeterRecords.Rows[e.RowIndex].Cells[3].Value);

                dgvAccountRecords.DataSource = (from account in AccountRecords
                                         where account.AccountID == selectedAccountID
                                         select account).ToList();
            }
        }

        private void rdoMeterId_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMeterId.Checked)
            {
                dgvGasMeterRecords.DataSource = (from gasMeter in GasMeterRecords
                                           orderby gasMeter.MetreID
                                           select gasMeter).ToList();

                dgvAccountRecords.DataSource = null;
            }
        }

        private void rdoVolumeUsed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVolumeUsed.Checked)
            {
                dgvGasMeterRecords.DataSource = (from gasMeter in GasMeterRecords
                                                 orderby gasMeter.VolumeUsed
                                                 select gasMeter).ToList();
            }
                                            
        }

        private void btnCustArrears_Click(object sender, EventArgs e)
        {

            using (CustomerArrearsReport custAr = new CustomerArrearsReport(AccountRecords))
            {
                custAr.ShowDialog();
            }
        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {
            int totalVolGasUsed = (from gasMeter in GasMeterRecords
                                   select gasMeter.VolumeUsed).Sum();

            int totalAccountsInArrears = (from account in AccountRecords
                                          where account.ArrearsCount > 0
                                          select account.ArrearsCount).Count();

            string summaryReport = $"Total volume gas used = {totalVolGasUsed} \nTotal number of accounts in arrears = {totalAccountsInArrears}";
            MessageBox.Show(summaryReport);
                                    
        }

    }
}
