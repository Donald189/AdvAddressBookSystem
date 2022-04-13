using System;

namespace AdvAddressBookDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Advance AddressBook problem");

            //AddressBookRepo addressBookRepo = new AddressBookRepo();
            //AddressBookModel addressBookModel = new AddressBookModel();
            //addressBookModel.FirstName = "Donald";
            //addressBookModel.LastName = "JK";
            //addressBookModel.Address = "Muthammal Colony";
            //addressBookModel.City = "Thoothukudi";
            //addressBookModel.State = "TamilNadu";
            //addressBookModel.Zip = 628002;
            //addressBookModel.PhoneNumber = 8056446118;
            //addressBookModel.Email = "donaldkarey@gmail.com";
            //addressBookModel.AddressBookName = "Self address book";
            //addressBookModel.AddressBookType = "Self";
            //addressBookRepo.DataBaseConnection();
            //addressBookRepo.addNewContactToDataBase(addressBookModel);
            //addressBookRepo.EditExitContactToDataBase(addressBookModel, "Dhoni");
            //addressBookRepo.deleteExitContactInDataBase("Donald");
            //addressBookRepo.personBelongingCityOrState();
            //addressBookRepo.CountByCityAndState();
            //addressBookRepo.sortedAlphabeticallyByFirstName();
            //addressBookRepo.identifyAddressBookWithNameAndType("Donald","Self","Self addressbook");
            //addressBookRepo.getNumberOfPersonCountByType();
            //addressBookRepo.addPersonToBothFriendAndFamily(addressBookModel);
            
            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

        Parallel.Invoke(() =>
        {
            Console.WriteLine("Begin first task.....");
            GetLongestWord(words);
        },

        () =>
        {
            Console.WriteLine("Begin second task....");
            GetMostCommonWords(words);
        },
        () =>
        {
            Console.WriteLine("Begin third task....");
            GetCountForWords(words, "sleep");
        }
    );

        static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving from {uri}");
            string s = new System.Net.WebClient().DownloadString(uri);

            return s.Split(
                new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
    }

    private static string GetLongestWord(string[] words)
    {
        var longestWord = (from w in words
                           orderby w.Length descending
                           select w).First();
        Console.WriteLine($"Task 1 -- The LONGEST WORD is {longestWord}");
        return longestWord;
    }

    private static void GetCountForWords(string[] words, string term)
    {
        var findwords = from word in words
                        where word.ToUpper().Contains(term.ToUpper())
                        select word;
        Console.WriteLine($@"Task 3 ---- the word ""{term}"" occurs {findwords.Count()} times.");

    }

    private static void GetMostCommonWords(string[] words)
    {
        var frequencyorder = from word in words
                             where word.Length > 6
                             group word by word into g
                             orderby g.Count() descending
                             select g.Key;

        var commanwords = frequencyorder.Take(10);
        System.Text.StringBuilder sb = new StringBuilder();
        sb.AppendLine("Task 2 -- the most common words are :");
        foreach (var v in commanwords)
        {
            sb.AppendLine(" " + v);
        }
        }
    }
}
