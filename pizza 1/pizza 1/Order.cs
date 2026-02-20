using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace pizzaAPP
{
    internal class Order
    {
        private static int nextID = 1;  

        public int BestillingsID { get; private set; }
        public Customer Kunde { get; set; }
        public Pizza Pizza { get; set; }
        public DateTime Dato { get;  set; }
        public double Tax { get; set; }
        public double Delivery { get; set; }






        public Order(  Customer kunde, Pizza pizza, double tax, int delivery)
        {
            BestillingsID = nextID++;
            Kunde = kunde;
            Pizza = pizza;
            Dato = DateTime.Now;
            Tax = 0.25;
            Delivery = 40.0;
        }
        public double CalculateTotalPrice()
        {
            double moms = Pizza.Pris * Tax;
            return Pizza.Pris + moms + Delivery;
        }
        public override string ToString()
        {
            return $"Ordre #{BestillingsID} ({Dato:g}): {Kunde.Navn} har bestilt {Pizza.Navn}. Totalpris: {CalculateTotalPrice()} kr";
        }
    }
}
