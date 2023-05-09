using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phonebook
{
    internal class Phonebook
    {
        string Number = null;
        string Name = null;
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact()
        {
            Console.WriteLine("Insert number:");
            string valNumber = Console.ReadLine();
            Console.WriteLine("Insert name:");
            string valName = Console.ReadLine();
            if (valNumber.Length < 9)
            {
                Console.WriteLine("Can't set because phone number must be at least 9 numbers ");
                valNumber = null;
                Number = string.Empty;
                
            }
            else
            {
                Number = valNumber;
            }
            if (valName.Length < 4)
            {
                Console.WriteLine("Can't set because name must be at least 4 letters");
                valNumber = null;
                Name = string.Empty;


            }
            else
            {
                Name = valName;
            }
            bool validation = string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Number);
            if (validation == true)
            {
                Console.WriteLine("Contact can't be added");


            }
            else
            {
                var newContact = new Contact(Name, Number);
                Contacts.Add(newContact);
            }
            
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null) 
            {
                Console.WriteLine("Contact not found");

            }
            else 
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContacts()
        {
           DisplayContactDetails(Contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactDetails(matchingContacts);
        }
    }
}
