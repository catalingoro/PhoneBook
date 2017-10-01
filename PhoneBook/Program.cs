using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            phoneBook.Add("Catalin", 004512345678);
            phoneBook.Add("John", 003312345678);
            phoneBook.Add("Janine", 0013123456789987);
            Console.WriteLine("What are you looking for?");
            var searchTerm = Console.ReadLine();
            Console.WriteLine(string.Format("The phone number for {0} is not in our book", searchTerm));
            //foreach (KeyValuePair<string, long> item in phoneBook)
            //{
            //if (searchTerm.ToLower() == item.Key.ToLower())
           //Console.WriteLine(item.Key + "'s phone number is " + item.Value);
           // else
          // Console.WriteLine(string.Format("The phone number for {0} is not in our book", searchTerm));
           // }
            Console.ReadLine();
        }

    }
}
