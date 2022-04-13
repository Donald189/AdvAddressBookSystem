using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvAddressBookDB
{
    public class AddressBookOperation
    {
        List<AddBook> listperson = new List<AddBook>();
        public void addressRoll(List<AddBook> ad)
        {
            ad.ForEach(addressData =>
            {
                Console.WriteLine("Employee being added:" + addressData.empName);
                this.addressRoll(addressData);
                Console.WriteLine("Employee added: " + addressData.empName);
            });
            Console.WriteLine(this.listperson.ToString());
        }
        private void addressRoll(AddBook address)
        {
            listperson.Add(address);

        }
        public void addressRollThread(List<AddBook> ad)
        {
            ad.ForEach(addressData =>
            {

                Task tread = new Task(() =>
                {

                    Console.WriteLine("Employee being added:" + addressData.empName);
                    this.addressRoll(addressData);
                    Console.WriteLine("Employee added: " + addressData.empName);
                });
                tread.Start();
            });
            Console.WriteLine(this.listperson.ToString());
        }
    }
}
