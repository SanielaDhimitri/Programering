using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaAPP
{
  
        internal class Store
        {
            public string Navn { get; private set; }
            public string Adresse { get; set; }
            public string Telefon { get; set; }
            public string CVR { get; private set; }

            public Store(string navn, string adresse, string telefon, string cvr)
            {
                Navn = navn;
                Adresse = adresse;
                Telefon = telefon;
                CVR = cvr;
            }
            public override string ToString()
            { return $"{Navn}, {Adresse}, Tlf: {Telefon}, CVR: {CVR}"; }


            public void Start()
            {
                Pizza pizza1 = new Pizza("P1", "Peperoni", 90, "Lille");
                Pizza pizza2 = new Pizza("P2", "Calcone", 95, "Medium");
                Pizza pizza3 = new Pizza("P3", "Putaneska", 105, "Stor");

                Customer customer1 = new Customer("Ema", "Vej 111", "12312312");
                Customer customer2 = new Customer("Enzo", "Vej 132", "23331234");
                Customer customer3 = new Customer("Sara", "Vej 233", "11113333");

                Order order1 = new Order(customer1, pizza1);
                Order order2 = new Order(customer2, pizza2);
                Order order3 = new Order(customer3, pizza3);

                Console.WriteLine(order1);
                Console.WriteLine(order2);
                Console.WriteLine(order3);
            }
        }
}
