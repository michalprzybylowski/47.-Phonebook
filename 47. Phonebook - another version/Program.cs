using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to phonebook application(choose a number):");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("5 Delete contact");
            Console.WriteLine("To exit insert q");

            var userInput = Console.ReadLine();

            var phoneBook = new Phonebook();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                            
                        phoneBook.AddContact();     
                        
                        break;
                    case "2":
                        Console.WriteLine("Insert number");

                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();

                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);

                        break;
                    case "5":
                        Console.WriteLine("Insert contact number to delete");
                        var deleteContact = Console.ReadLine();
                        phoneBook.DeleteContact(deleteContact);
                        break;
                   case "q":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }

        }
    }
}