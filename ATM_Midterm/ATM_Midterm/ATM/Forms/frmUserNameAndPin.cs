/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 2: ATM
 * Form: frmUserNameAndPin
 * Written by: Zachary Goncalves
 */
using System;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmUserNameAndPin : Form
    {
        // This form verifies that the customer is the customer and tracks login attempts. 
        int loginAttempts = 1;
        public frmUserNameAndPin()
        {
            InitializeComponent();
        }
        // Validates inputs are valid and checks if the user input matches what is on record.
        // Closes form if number of login attempts exceeds 3. 
        private void btnVerifyAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtVerifyName.Text;
                decimal customerPin = Convert.ToDecimal(txtVerifyPin.Text);
                if(GlobalData.ATMBank.maxAttemptsYet(loginAttempts))
                {
                    if (customerName.Equals(GlobalData.customer.getCustomerName()) && customerPin == Convert.ToInt32(GlobalData.customer.getCustomerPin()))
                    {
                        Form frmTransactionEntry = new frmTransactionEntry();
                        frmTransactionEntry.Show();
                        Close();
                    }
                    else
                    {
                        if (!customerName.Equals(GlobalData.customer.getCustomerName()))
                        {
                            MessageBox.Show("Please enter the correct name.", "Error");
                            txtVerifyName.Text = "";
                            customerName = "";
                            txtVerifyName.Focus();
                            loginAttempts++;
                        }
                        else if (!customerPin.Equals(GlobalData.customer.getCustomerPin()))
                        {
                            MessageBox.Show("Please enter the correct PIN number.", "Error");
                            txtVerifyPin.Text = "";
                            customerPin = 0;
                            txtVerifyPin.Focus();
                            loginAttempts++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have reached the maximum login attempts.", "Account Locked");
                    Application.Exit();
                }

            }
            catch
            {
                MessageBox.Show("Please enter valid verification information.", "Error");
                txtVerifyPin.Text = "";
                txtVerifyName.Text = "";
                txtVerifyName.Focus();
            }
        }
    }
}
