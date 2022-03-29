/*John Fade IV 2307363
I worked alone on this assignment
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_and_Customer_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {//variables that hold the inputs
                string name, address, phone;
                bool mailing = false;
                int customerNumber = 0;


                name = nameTextBox.Text;
                address = addressTextBox.Text;
                phone = phoneTextBox.Text;
                Random rand = new Random();
                Customer mCustomer = new Customer(name, address, phone, mailing, customerNumber);

                if (mailingCheckBox.Checked)
                {
                    mailing = true; //sets mailing to true
                   // customerNumber = rand.Next(); //just randomly generates a customer number 

                    MessageBox.Show("Thank you for signing up with us " + mCustomer.Name + "!" + " your customer number is: " + mCustomer.CustomerNumber);
                    MessageBox.Show(" Mailing list application accepted, " + "please expect mail from us soon to: " + mCustomer.Address + "!");



                }
                else
                {
                    
                    MessageBox.Show("Mailing list application declined," + " no mail will be sent to " + (mCustomer.Address) + "!");
                    mailing = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
            

            
           
        }
        //exits
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
