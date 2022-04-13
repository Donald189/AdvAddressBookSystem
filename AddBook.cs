using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvAddressBookDB
{
    public class AddBook
    {
        public int EmpId { get; set; }
        public string empName { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string Zip { get; set; }
        public string email { get; set; }
        public double contact { get; set; }

        public AddBook(int empid, string EmpName, string address, string City, string State, string zip, string Email, double Contact)
        {
            this.EmpId = empid;
            this.empName = EmpName;
            this.Address = address;
            this.city = City;
            this.state = State;
            this.Zip = zip;
            this.email = Email;
            this.contact = Contact;
        }
    }
}
