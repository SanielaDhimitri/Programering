using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSystem
{
    public class Kunder

    {
        public int KunderID { get; set; }
        public string Name { get; set; }

        public string Telefon { get; set; }
        public string Address { get; set; }


        public Kunder(int kunderID, string name, string tel, string address)
        {
            KunderID = kunderID;
            Name = name;
            Telefon = tel;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {KunderID})\n" +
                $" - Tel: {Telefon}" +
                $" Address: {Address}";
        }
    }
    }
