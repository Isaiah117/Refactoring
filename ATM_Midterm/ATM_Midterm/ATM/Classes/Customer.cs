
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Classes
{
    // Represents customer using ATM
    public class Customer
    {
        string customer;
        string customerAccNumber;
        string customerName;
        int customerPin;
        decimal customerCheckingBalance;
        decimal customerSavingBalance;
        // Takes and sanitizes record, then compares user input with record, 
        // returns its its a match, and updates class attributes.
        public Boolean customerMatch(string accNumber, string record)
        {
            record = record.Replace(",", "");
            record = record.Replace("$", "");
            string[] recordBreakdown = record.Split('*');

            if (recordBreakdown[0].Trim().Equals(accNumber))
            {
                customerAccNumber = accNumber;
                customerName = recordBreakdown[1].Trim();
                customerPin = Convert.ToInt32(recordBreakdown[2]);
                customerSavingBalance = Convert.ToDecimal(recordBreakdown[3]);
                customerCheckingBalance = Convert.ToDecimal(recordBreakdown[4]);
                return true;
            }
            else
            {
                return false;
            }   
        }
        // Gets the customer name
        public string getCustomerName()
        {
            return customerName;
        }
        // Gets the customer PIN
        public int getCustomerPin()
        {
            return customerPin;
        }
        // Gets Savings Account Balance
        public decimal getRecordSavingsBalance()
        {
            return customerSavingBalance;
        }
        // Gets Checking Account Balance
        public decimal getRecordCheckingBalance()
        {
            return customerCheckingBalance;
        }
        // Updates account balances 
        public void updateSavingsCheckings(decimal savingsBalance, decimal checkingBalance)
        {
            customerCheckingBalance = checkingBalance;
            customerSavingBalance = savingsBalance;
        }
        // Generates updated customer record for export
        public string generateRecord()
        {
            customer = customerAccNumber + " * " + customerName + " * " + customerPin + " * " + customerSavingBalance.ToString("C") + " * " + customerCheckingBalance.ToString("C");
            return customer;
        }
    }
}
