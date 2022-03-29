/*John Fade IV 2307363
I worked alone on this assignment
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Classes
{
    class Customer : Person
    {
        Random rand = new Random();
        //constructor
        public Customer(string name, string address, string phone , bool mailing, int customerNum) : base(name, address, phone)
        {
            MailingList = mailing;
           // CustomerNumber = customerNum;
        }

        public Boolean MailingList { get; set; }
        public int CustomerNumber //returns the random number
        {
            get { return rand.Next(); }
        }
    }
}
