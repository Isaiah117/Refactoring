/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 2: ATM
 * Form: frmUserAccountEntry
 * Written by: Zachary Goncalves
 */
using System;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmUserAccountEntry : Form
    {
        // This form handels the initial entry of the user's account.
        int loginAttempts = 1;
        public frmUserAccountEntry()
        {
            InitializeComponent();
        }
        // Validates user input and opens next form if they account matches
        private void btnAccStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(GlobalData.ATMBank.maxAttemptsYet(loginAttempts))
                {
                    int accNumber = Convert.ToInt32(txtAccNum.Text);
                    if (GlobalData.ATMBank.isNotAccountLength(accNumber.ToString().Length))
                    {
                        accNumber = 0;
                        txtAccNum.Text = "";
                        MessageBox.Show("Please enter an account number of 5 digits." + "\n" + "Login Attempts: " + loginAttempts, "Error");
                        txtAccNum.Focus();
                        loginAttempts++;
                    }
                    else
                    {
                        string strAccNumber = accNumber.ToString();
                        bool foundRecord = false;
                        string record = GlobalData.ATMBank.findCustomerRecord(strAccNumber, ref foundRecord);
                        loginAttempts++;

                        if (foundRecord)
                        {
                            Form UserNamePinForm = new frmUserNameAndPin();
                            UserNamePinForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please enter an account number that exists in our system.", "Error");
                            txtAccNum.Text = "";
                            accNumber = 0;
                            record = "";
                            txtAccNum.Focus();
                            GlobalData.ATMBank.rewindFiles();
                        }
                    }
                } else
                {
                    MessageBox.Show("Login attempts exceeded.", "Security Alert");
                    Application.Exit();
                }
            }
            catch
            {
                txtAccNum.Text = "";
                MessageBox.Show("Please enter a valid account number of 5 digits.", "Error");
                txtAccNum.Focus();
            }
        }

    }
}
