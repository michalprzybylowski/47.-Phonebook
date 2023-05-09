using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to phonebook application");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("To exit insert q");

            string Number = null;
            string Name = null;
            var userInput = Console.ReadLine();

            var phoneBook = new Phonebook();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number:");
                        string valNumber = Console.ReadLine();
                        Console.WriteLine("Insert name:");
                        string valName = Console.ReadLine();
                        if (valNumber.Length < 9)
                        {
                            Console.WriteLine("Cant set");
                            valNumber = null;
                        }
                        else
                        {
                            Number = valNumber;
                        }
                        if (valName.Length < 4)
                        {
                            Console.WriteLine("Cant set");
                            valNumber = null;
                        }
                        else
                        {
                            Name = valName;
                        }
                        bool validation = !string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(Number);
                        if (validation == false)
                        {
                            Console.WriteLine("Contact can't be added");
                            
                        }
                        else
                        {
                            var newContact = new Contact(Name, Number);
                            phoneBook.AddContact(newContact);
                        }

                       

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