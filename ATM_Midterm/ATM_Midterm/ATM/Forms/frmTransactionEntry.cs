/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 2: ATM
 * Form: frmTransactionEntry
 * Written by: Zachary Goncalves
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmTransactionEntry : Form
    {
        // This form handles selecting and processing a transaction.
        int selectedTransaction = 0;
        decimal transactionAmount = 0;
        decimal checkingBalance = GlobalData.customer.getRecordCheckingBalance();
        decimal savingsBalance = GlobalData.customer.getRecordSavingsBalance();
        // Constructor
        public frmTransactionEntry()
        {
            InitializeComponent();
        }
        // Disables all unselected controls 
        public void lockUnusedControls(object control)
        {
            foreach (Control c in pnlTransactionList.Controls)
            {
                if (c == control) {
                    c.Enabled = true;
                } else
                {
                    c.Enabled = false;
                }
            }
        }
        // Sets selected transaction value to value representing button. Updates btn background color
        // and unlocks inputs for value of transaction.
        private void transaction_Click(object sender, EventArgs e)
        {
            lockUnusedControls(sender);
            if (sender == btnSavingsDeposit)
            {
                selectedTransaction = 1;
                btnSavingsDeposit.BackColor = Color.LightBlue;
            }
            if (sender == btnSavingsWithdraw)
            {
                selectedTransaction = 2;
                btnSavingsWithdraw.BackColor = Color.LightBlue;
            }
            if (sender == btnSavingsBalance)
            {
                selectedTransaction = 3;
                btnSavingsBalance.BackColor = Color.LightBlue;
            }
            if (sender == btnSavingsToChecking)
            {
                selectedTransaction = 4;
                btnSavingsToChecking.BackColor = Color.LightBlue;
            }
            if (sender == btnCheckingDeposit)
            {
                selectedTransaction = 5;
                btnCheckingDeposit.BackColor = Color.LightBlue;
            }
            if (sender == btnCheckingWithdraw)
            {
                selectedTransaction = 6;
                btnCheckingWithdraw.BackColor = Color.LightBlue;
            }
            if (sender == btnCheckingBalance)
            {
                selectedTransaction = 7;
                btnCheckingBalance.BackColor = Color.LightBlue;
            }
            if (sender == btnCheckingToSavings)
            {
                selectedTransaction = 8;
                btnCheckingToSavings.BackColor = Color.LightBlue;
            }
            if (selectedTransaction == 3 || selectedTransaction == 7)
            {
                if(selectedTransaction == 3)
                {
                    btnSavingsBalance.BackColor = Color.LightBlue;
                }
                else
                {
                    btnCheckingBalance.BackColor = Color.LightBlue;
                }
                btnTransactionGo.Enabled = true;
                btnTransactionNo.Enabled = true;
            }
            else
            {
                pnlValueInput.Enabled = true;
                txtTransactionAmount.Focus();
            }

        }
        // Validates amount (ensures non-negative) and shows transaction review information. 
        private void btnTransactionAmountOK_Click(object sender, EventArgs e)
        {
            try
            {
                transactionAmount = Convert.ToDecimal(txtTransactionAmount.Text);
                if (transactionAmount < 0)
                {
                    MessageBox.Show("Please enter a non-negative amount.", "Error");
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    pnlVerifyAmount.Visible = true;
                    txtTransactionInput.Text = transactionAmount.ToString();
                    btnTransactionGo.Enabled = true;
                    btnTransactionNo.Enabled = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer amount.", "Error");
                txtTransactionAmount.Text = "";
                txtTransactionAmount.Focus();
            }
        }
        // Calculates changes to accounts based on transaction information. Validates some transaction rules.
        // Updates customer object with new information and opens frmTransactionComplete.
        // Closes transaction entry form.
        private void btnTransactionGo_Click(object sender, EventArgs e)
        {
            bool transactionHappened = false; 
            if (selectedTransaction == 1)
            {
                savingsBalance += transactionAmount;
                transactionHappened = true;
            }
            if (selectedTransaction == 2)
            {
                if(GlobalData.ATMBank.meetsLimit(transactionAmount))
                {
                    if (transactionAmount > savingsBalance)
                    {
                        MessageBox.Show("You are withdrawing more money than you have in your account. Please widthdraw less.", "Overdraft Warning");
                        transactionAmount = 0;
                        txtTransactionAmount.Text = "";
                        txtTransactionAmount.Focus();
                    }
                    else
                    {
                        savingsBalance -= transactionAmount;
                        transactionHappened = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a withdrawal amount less than 300.", "Error");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
            }
            if (selectedTransaction == 4)
            {
                if (transactionAmount > savingsBalance)
                {
                    MessageBox.Show("You are transfering more money than you have in your account. Please transfer less.", "Overdraft Warning");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    savingsBalance -= transactionAmount;
                    checkingBalance += transactionAmount;
                    transactionHappened = true;
                }
            }
            if (selectedTransaction == 5)
            {
                checkingBalance += transactionAmount;
                transactionHappened = true;
            }
            if (selectedTransaction == 6)
            {
                if (transactionAmount > 300)
                {
                    MessageBox.Show("Please enter a withdrawal amount less than 300.", "Error");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    if (transactionAmount > checkingBalance)
                    {
                        MessageBox.Show("You are withdrawing more money than you have in your account. Please widthdraw less.", "Overdraft Warning");
                        transactionAmount = 0;
                        txtTransactionAmount.Text = "";
                        txtTransactionAmount.Focus();
                    }
                    else
                    {
                        checkingBalance += transactionAmount;
                        transactionHappened = true;
                    }
                }
            }
            if (selectedTransaction == 8)
            {
                if (transactionAmount > savingsBalance)
                {
                    MessageBox.Show("You are transfering more money than you have in your account. Please transfer less.", "Overdraft Warning");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    checkingBalance -= transactionAmount;
                    savingsBalance += transactionAmount;
                    transactionHappened = true;
                }
            }
            if (selectedTransaction == 3 || selectedTransaction == 7)
            {
                transactionHappened = true;
            }
            if (transactionHappened)
            {
                GlobalData.customer.updateSavingsCheckings(savingsBalance, checkingBalance);
                Form frmTransactionComplete = new frmTransactionComplete();
                frmTransactionComplete.Show();
                Close();
            }

        }
        // Resets form and values.
        private void btnTransactionNo_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlTransactionList.Controls)
            {
                c.Enabled = true;
                c.BackColor = Button.DefaultBackColor;
            }
            transactionAmount = 0;
            selectedTransaction = 0;
            txtTransactionAmount.Text = "";
            pnlVerifyAmount.Visible = false;
            pnlValueInput.Enabled = false;
            btnTransactionGo.Enabled = false;
            btnTransactionNo.Enabled = false;
        }
    }
}
