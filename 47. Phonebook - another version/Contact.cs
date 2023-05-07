using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Contact
    {
        public Contact(string name, string number) 
        {
            Name = name;
            Number = number;

        }
        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Invalid contact name(minimum letters 4)");
                }
                else
                {
                    Name = value;
                }

            }
        }

        public string Number
        {
            get { return Number; }
            set
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact name(minimum 9 numbers)");
                }
                else
                {
                    Number = value;
                }

            }
        }
    }
}
