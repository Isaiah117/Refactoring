/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 2: ATM
 * Form: frmTransactionComplete
 * Written by: Zachary Goncalves
 */
using System;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmTransactionComplete : Form
    {
        // This form allows the user to view their balance and start a new transaction or close the program.
        public frmTransactionComplete()
        {
            InitializeComponent();
        }
        // Shows acocunt balances 
        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            pnlBalancesView.Visible = true;
            txtSavingsBalance.Text = GlobalData.customer.getRecordSavingsBalance().ToString();
            txtCheckingBalance.Text = GlobalData.customer.getRecordCheckingBalance().ToString();
        }
        // Writes out updatedFile and closes program.
        private void btnNoNewTransaction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for being a MazeBank Customer!");
            GlobalData.ATMBank.writeOut(GlobalData.customer.generateRecord());
            GlobalData.ATMBank.CopyRemainingRecords();
            GlobalData.ATMBank.generateUpdatedFile();
            Application.Exit();
        }
        // Loads new transaction entry form for a new transaction, and closes transaction complete form.
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            Form frmTransactionEntry = new frmTransactionEntry();
            frmTransactionEntry.Show();
            Close();
        }
    }
}
