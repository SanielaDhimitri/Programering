
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {
        private static int NextBestillingID = 1;
        public int BestillingsID { get; private set;  }
        public Customer Kunde { get; set; }
        public Pizza Pizza { get; set; }
        public DateTime OrderDate { get; set; }
        //  NYT: Ekstra toppings
        public List<string> ExtraToppings { get; private set; }

        private const double Tax = 0.25;
        private const int Delivery = 40;
        private const int ToppingPrice = 5; // kr pr topping

        public Order ( Customer kunde, Pizza pizza)
        {

           BestillingsID = NextBestillingID++;
            Kunde = kunde;
            Pizza = pizza;
            OrderDate = DateTime.Now;
            ExtraToppings = new List<string>();

        }
        //  NYT: Tilføj ekstra topping
        public void AddTopping(string topping)
        {
            ExtraToppings.Add(topping);
            Console.WriteLine($"Tilføjet topping: {topping}");
        }

        public double CalculateTotalPrice()
        {
            double basePrice = Pizza.Pris * (1 + Tax) + Delivery;
            double toppings = ExtraToppings.Count * ToppingPrice;
            return basePrice + toppings;

        }


        public override string ToString()
        {
            string toppings = ExtraToppings.Count > 0
                ? string.Join(", ", ExtraToppings)
                : "Ingen ekstra toppings";

            return $"ORDRE: {BestillingsID}\n" +
                   $"Dato: {OrderDate:g}\n" +
                   $"Kunde: {Kunde.Navn}\n" +
                   $"Pizza: {Pizza.Navn} ({Pizza.Størrelse})\n" +
                   $"Toppings: {toppings}\n" +
                   $"Totalpris: {CalculateTotalPrice():F2} kr\n";
        }
    }
}