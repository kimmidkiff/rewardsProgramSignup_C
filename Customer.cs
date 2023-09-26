using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer
{
    class Customer : Person
    {
        public string phoneNumber;
        public bool mailList;

        // constructor
        public Customer(string name, string address, int number, string phoneNumber, bool mailList)
            : base(name, address, number)
        {
            this.phoneNumber = phoneNumber;
            this.mailList = mailList;
        }
        public string PhoneNumber { get; set; }
        public bool MailList { get; set; }

        
    }
}
