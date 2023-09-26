using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Kimberly Midkiff
// COP2360
// SPC ID 2319889


namespace Person_and_Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // create variables
            string name, address, phoneNumber;
            int number;
            bool mailList;

            // get input from the textboxes
            name = nameTextBox.Text;
            address = addressTextBox.Text;
            phoneNumber = phoneTextBox.Text;

            // determine if customer wants to be on mailing list
            if(yesRadioButton.Checked )
            {
                mailList = true;
            }
            else
            {
                mailList = false;
            }

            // use a random number as the customer number
            Random rand = new Random();
            number = rand.Next(1000);

            // create a new customer object with the info provided and the customer number generated
            Customer newCustomer = new Customer(name, address, number, phoneNumber, mailList);
            string numberString = number.ToString();

            MessageBox.Show("Thanks for signing up " + name + "! "+ "Your new customer ID is " + numberString);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
