using System;

namespace AdvAddressBookDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Advance AddressBook problem");

            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addressBookModel = new AddressBookModel();
            addressBookModel.FirstName = "Donald";
            addressBookModel.LastName = "JK";
            addressBookModel.Address = "Muthammal Colony";
            addressBookModel.City = "Thoothukudi";
            addressBookModel.State = "TamilNadu";
            addressBookModel.Zip = 628002;
            addressBookModel.PhoneNumber = 8056446118;
            addressBookModel.Email = "donaldkarey@gmail.com";
            addressBookModel.AddressBookName = "Self address book";
            addressBookModel.AddressBookType = "Self";
            addressBookRepo.DataBaseConnection();
            addressBookRepo.addNewContactToDataBase(addressBookModel);
            addressBookRepo.EditExitContactToDataBase(addressBookModel, "Dhoni");
            addressBookRepo.deleteExitContactInDataBase("Donald");
            addressBookRepo.personBelongingCityOrState();
            addressBookRepo.CountByCityAndState();
        }
    }
}