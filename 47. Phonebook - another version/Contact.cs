using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Contact
    {
        private string name;
        private string number;
        public Contact(string name, string number) 
        {
            Name = name;
            Number = number;

        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Invalid contact name(minimum letters 4)");
                    
                    
                }
                else
                {
                    name = value;
                }

            }
        }

        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number(minimum 9 numbers)");
                    
                }
                else
                {
                    number = value;
                }

            }
        }
    }
}
