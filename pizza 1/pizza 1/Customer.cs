using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaAPP
{
    internal class Customer
    
        {
            public string Navn { get; set; }
            public string Adresse { get; set; }
            public string Telefon { get; set; }
            public Customer(string navn, string adresse, string telefon)
            {
                Navn = navn;
                Adresse = adresse;
                Telefon = telefon;
            }
            public override string ToString()
            { return $"{Navn}, {Adresse}, {Telefon}"; }
        }
    
}
