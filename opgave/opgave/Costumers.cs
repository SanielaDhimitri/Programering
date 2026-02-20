using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    public class Costumers
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        public Costumers(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n Address: {Address}\n Phone Number: {PhoneNumber}";
        }
    }

}
