using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Størrelse { get; set; }

        public Pizza(int pizzaID, string navn, double pris, string størrelse)
        {
            PizzaID = pizzaID;
            Navn = navn;
            Pris = pris;
            Størrelse = størrelse;
        }

        public override string ToString()
        {
            return $"ID: {PizzaID} | Navn: {Navn} | Størrelse: {Størrelse} | Pris: {Pris} kr";
        }
    }
}
