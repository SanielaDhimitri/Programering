using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSystem
{
    public class Butik
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Telefon { get; set; }
        public int CVR { get; set; }
        public Butik(string navn, string adresse, string telefon, int cvr)
        {
            Navn = navn;
            Adresse = adresse;
            Telefon = telefon;
            CVR = cvr;
        }
        public override string ToString()
        {
            return $"{Navn} - Adresse: {Adresse}, Telefon: {Telefon}, CVR: {CVR}";
        }

        public void Start()
        {
              // Opret nogle nye objekter, på pizzaer, kunder og bestillinger
            
            Pizza pizza =new Pizza(1, "Margherita", 59.99, "Classic pizza with tomato sauce and mozzarella cheese.");
            Pizza pizza2 = new Pizza(2, "Pepperoni", 69.99, "Spicy pepperoni with tomato sauce and mozzarella cheese.");
            Pizza pizza3 = new Pizza(3, "Hawaiian", 79.99, "Ham and pineapple with tomato sauce and mozzarella cheese.");

            Kunder kunder = new Kunder(1, "John Doe", "12345678", "Main Street 1");     
            Kunder kunder2 = new Kunder(2, "Jane Smith", "87654321", "Second Street 2");
            Kunder kunder3 = new Kunder(3, "Bob Johnson", "11223344", "Third Street 3");

           Bestilling bestilling = new Bestilling( kunder, pizza);
            Bestilling bestilling2 = new Bestilling( kunder2, pizza2);
            Bestilling bestilling3 = new Bestilling( kunder3, pizza3);

           
            Console.WriteLine("----- Butik Information 1-----");
            Console.WriteLine();
            Console.WriteLine(bestilling);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine(bestilling2);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(bestilling3); 
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("--------Butik Information 2----");
            Console.WriteLine();
            Console.WriteLine($"BestillingsNo: {bestilling.BestillingNo}");
            Console.WriteLine($"Navn på kunde: {bestilling.Kunder.Name}");
            Console.WriteLine($"Pizza: {bestilling.Pizza.Name}");
            Console.WriteLine($"Tidspunkt: {bestilling.BestillingsTid}");
            Console.WriteLine($"Totalpris: {bestilling.CalculateTotalPrice():F2} kr.");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine();
            Console.WriteLine($"BestillingsNo: {bestilling2.BestillingNo}");
            Console.WriteLine($"Navn på kunde: {bestilling2.Kunder.Name}");
            Console.WriteLine($"Pizza: {bestilling2.Pizza.Name}");
            Console.WriteLine($"Tidspunkt: {bestilling2.BestillingsTid}");
            Console.WriteLine($"Totalpris: {bestilling2.CalculateTotalPrice():F2} kr.");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine();
            Console.WriteLine($"BestillingsNo: {bestilling3.BestillingNo}");
            Console.WriteLine($"Navn på kunde: {bestilling3.Kunder.Name}");
            Console.WriteLine($"Pizza: {bestilling3.Pizza.Name}");
            Console.WriteLine($"Tidspunkt: {bestilling3.BestillingsTid}");
            Console.WriteLine($"Totalpris: {bestilling3.CalculateTotalPrice():F2} kr.");
            Console.WriteLine("--------------------------------------");


            // ===== Test KunderList og PizzaMenu =====
            KunderList kunderList = new KunderList();
            PizzaMenu pizzaMenu = new PizzaMenu();

            // Tilføj kunder
            kunderList.AddKunde(kunder);
            kunderList.AddKunde(kunder2);
            kunderList.AddKunde(kunder3);

            Console.WriteLine("----- Kunder før ændringer -----");
            kunderList.PrintMenu( kunder);

            Console.WriteLine("\nOpdaterer kunde...");
            kunderList.RemoveKunde(kunder2);
            kunderList.AddKunde(new Kunder(1002, "Bo Andersen", "Vej 22", "22222333"));

            Console.WriteLine("\nSletter kunde...");
            kunderList.RemoveKunde(kunder);

            Console.WriteLine("\n----- Kunder efter ændringer -----");
            kunderList.PrintMenu(kunder);

            

            pizzaMenu.AddPizza(pizza);
            pizzaMenu.AddPizza(pizza2);
            pizzaMenu.AddPizza(pizza3);

            Console.WriteLine("\nUdskriver pizzamenu:");
            pizzaMenu.PrintMenu();

            Console.WriteLine("\nOpdaterer pizza...");
            pizzaMenu.UpdatePizza(23, new Pizza(23, "Pepperoni Deluxe", 95, "Medium"));

            Console.WriteLine("\nSletter pizza...");
            pizzaMenu.DeletePizza(11);

            Console.WriteLine("\nPizzamenu efter ændringer:");
            pizzaMenu.PrintMenu();

            Console.WriteLine("\nSøger efter pizza med 'Hawaiian:");
            Pizza found = pizzaMenu.SearchPizza("Hawaiian");
            if (found != null)
                Console.WriteLine($"Fundet: {found}");
            else
                Console.WriteLine("Ingen pizza fundet.");

            Console.WriteLine("\nTEST FÆRDIG");

        }
    }
}
