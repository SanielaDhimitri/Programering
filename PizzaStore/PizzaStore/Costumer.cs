using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore

{
    public class Customer
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Telefon { get; set; }

        public Customer(int id, string navn, string adresse, string telefon)
        {   ID = id;
            Navn = navn;
            Adresse = adresse;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"{ID},{Navn}, {Adresse}, Tlf: {Telefon}";
        }
    }
}