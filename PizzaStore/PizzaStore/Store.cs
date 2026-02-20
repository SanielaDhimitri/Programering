using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;






using System;
using System.Collections.Generic;

namespace PizzaStore
{
    public class Store
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Telefon { get; set; }
        public int CVR { get; set; }

        public Store(string navn, string adresse, string telefon, int cvr)
        {
            Navn = navn;
            Adresse = adresse;
            Telefon = telefon;
            CVR = cvr;
        }

        public override string ToString()
        {
            return $"{Navn}, {Adresse}, Tlf: {Telefon}, CVR: {CVR}";
        }

        public void Start()
        {
            Console.WriteLine($"Velkommen til {Navn}!");
            Console.WriteLine($"Adresse: {Adresse}, Tlf: {Telefon}, CVR: {CVR}");
            Console.WriteLine("\nTEST AF SYSTEM\n");

            // TEST AF CUSTOMERFILE
            Console.WriteLine("TEST AF CUSTOMERFILE\n");
            CustomerFile customerFile = new CustomerFile();

            Customer c1 = new Customer(1001, "Anna", "Vej 1", "11111111");
            Customer c2 = new Customer(1002, "Bo", "Vej 2", "22222222");
            Customer c3 = new Customer(1003, "Clara", "Vej 3", "33333333");

            Console.WriteLine("\nTilføjer kunder...");
            customerFile.AddCustomer(c1);
            customerFile.AddCustomer(c2);
            customerFile.AddCustomer(c3);

            Console.WriteLine("\nUdskriver kundeliste:");
            customerFile.PrintMenu();

            Console.WriteLine("\nAdd  kunde");
            customerFile.AddCustomer(new Customer(1004, "Dorte", "Vej 4", "44444444"));
          

            Console.WriteLine("\nOpdaterer kunde...");
            customerFile.UpdateCustomer(1002, new Customer(1002, "Bo Andersen", "Vej 22", "22222333"));

            Console.WriteLine("\nSletter kunde...");
            customerFile.DeleteCustomer(1001);

            Console.WriteLine("\nKundeliste efter ændringer:");
            customerFile.PrintMenu();

            // TEST AF PIZZAMENU
            Console.WriteLine("\nTEST AF PIZZAMENU");

            PizzaMenu menu = new PizzaMenu();

            Pizza p1 = new Pizza(11, "Margherita", 70, "Lille");
            Pizza p2 = new Pizza(23, "Pepperoni", 85, "Medium");
            Pizza p3 = new Pizza(111, "Hawaii", 95, "Stor");

            Console.WriteLine("\nTilføjer pizzaer...");
            menu.AddPizza(p1);
            menu.AddPizza(p2);
            menu.AddPizza(p3);

            Console.WriteLine("\nUdskriver pizzamenu:");
            menu.PrintMenu();//printing out the menu 

            Console.WriteLine("\nAdd  pizza");
            menu.AddPizza(new Pizza(45, "Vegetariana", 80, "Mellem"));

            Console.WriteLine("\nOpdaterer pizza...");
            menu.UpdatePizza(23, new Pizza(23, "Pepperoni Deluxe", 95, "Medium"));

            Console.WriteLine("\nSletter pizza...");
            menu.DeletePizza(11);

            Console.WriteLine("\nPizzamenu efter ændringer:");
            menu.PrintMenu();//printing out the menu (calls the PrintMenu)

            // SearchPizza (You do not need to read input from the screen)
            Console.WriteLine("\nSøger efter pizza med 'Hawaii':");//searching for pizza with the name Hawaii

            Pizza found = menu.SearchPizza("Hawaii");
            if (found != null)
                Console.WriteLine($"Fundet: {found}");
            else
                Console.WriteLine("Ingen pizza fundet.");

            Console.WriteLine("\nTEST FÆRDIG");






            //  TEST AF ORDREFILE (her kommer den nye del)
            Console.WriteLine("\nTEST AF ORDREFILE");

            Customer kunde = new Customer(2001, "Lars", "Hovedvej 5", "55555555");
            Pizza pizza1 = new Pizza(1, "Pepperoni", 85, "Medium");
            Pizza pizza2 = new Pizza(2, "Hawaii", 95, "Stor");

            OrderFile orderFile = new OrderFile();

            Order o1 = new Order(kunde, pizza1);
            Order o2 = new Order(kunde, pizza2);

            o1.AddTopping("Ekstra ost");
            o1.AddTopping("Bacon");

            orderFile.AddOrder(o1);
            orderFile.AddOrder(o2);

            orderFile.PrintOrders();

            orderFile.UpdateOrder(o2.BestillingsID, new Order(kunde, new Pizza(3, "Margherita", 70, "Lille")));
            orderFile.DeleteOrder(o1.BestillingsID);

            orderFile.PrintOrders();

            Console.WriteLine("\nTEST FÆRDIG ");
        }


        //  INTERAKTIV MENU 
        public void RunInteractiveMenu()
        {
            PizzaMenu pizzaMenu = new PizzaMenu();
            MenuDialog dialog = new MenuDialog();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("====================================");
                Console.WriteLine("         PIZZA MENU SYSTEM       ");
                Console.WriteLine("====================================");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Tilføj ny pizza til menuen");
                Console.WriteLine("2. Slet pizza");
                Console.WriteLine("3. Opdater pizza");
                Console.WriteLine("4. Søg efter pizza");
                Console.WriteLine("5. Vis pizzamenu");
                Console.WriteLine("6. Afslut");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Indtast dit valg (1-6): ");


                string input = Console.ReadLine();// Programmet stopper og venter, til brugeren skriver noget og trykker Enter.
                if (!int.TryParse(input, out int choice))//TRYPARSE:En metode, der prøver at konvertere tekst til et tal
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ugyldigt input! Indtast et tal mellem 1 og 6.");
                    Console.ResetColor();
                    Console.WriteLine("\nTryk på en tast for at fortsætte...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        AddPizzaDialog(pizzaMenu);
                        break;
                    case 2:
                        DeletePizzaDialog(pizzaMenu);
                        break;
                    case 3:
                        UpdatePizzaDialog(pizzaMenu);
                        break;
                    case 4:
                        SearchPizzaDialog(pizzaMenu);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nAktuel pizzamenu \n");
                        Console.ResetColor();
                        pizzaMenu.PrintMenu();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nProgrammet afsluttes. Tak og på gensyn! ");
                        Console.ResetColor();
                        running = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        Console.ResetColor();
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nTryk på en tast for at vende tilbage til menuen...");
                    Console.ReadKey();
                }
            }
        }

        // Hjælpemetoder til dialoger

        private void AddPizzaDialog(PizzaMenu menu)
        {
            int id;
            string navn;
            string størrelse;
            double pris;

            // === ID ===
            while (true)
            {
                Console.Write("Indtast pizza ID: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    if (id > 0) break; // gyldigt ID
                    else Console.WriteLine("Fejl: ID skal være et positivt tal.");
                }
                else
                {
                    Console.WriteLine("Fejl: Du skal indtaste et gyldigt tal for ID (ingen bogstaver).");
                }
            }

            // === NAVN ===
            while (true)
            {
                Console.Write("Indtast navn: ");
                navn = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(navn))
                    break;
                else
                    Console.WriteLine("Fejl: Navnet må ikke være tomt.");
            }

            // === STØRRELSE ===
            while (true)
            {
                Console.Write("Indtast størrelse (lille/mellem/store): ");
                størrelse = Console.ReadLine().ToLower();

                if (størrelse == "lille" || størrelse == "mellem" || størrelse == "store")
                {
                    pris = BeregnPris(størrelse);
                    break;
                }
                else
                {
                    Console.WriteLine("Fejl: Ugyldig størrelse. Vælg 'lille', 'mellem' eller 'store'.");
                }
            }

            // === Opret pizza ===
            Pizza nyPizza = new Pizza(id, navn, pris, størrelse);
            menu.AddPizza(nyPizza);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nPizza tilføjet: {nyPizza.Navn} ({nyPizza.Størrelse}) - Pris: {nyPizza.Pris} kr");
            Console.ResetColor();
        }

        private void DeletePizzaDialog(PizzaMenu menu)
        {
            Console.Write("Indtast ID på pizza der skal slettes: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int id))
            {
                menu.DeletePizza(id);
                Console.WriteLine($"Pizza med ID {id} er slettet.");
            }
            else
            {
                Console.WriteLine("Fejl: Du skal indtaste et gyldigt tal.");
            }
        }

        private void UpdatePizzaDialog(PizzaMenu menu)
        {
            Console.Write("Indtast ID på pizza der skal opdateres: ");
            string input = Console.ReadLine();

            // Sikrer at ID er et gyldigt tal
            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Fejl: Du skal indtaste et gyldigt tal for ID.");
                return;
            }

            // Tjekker om pizza med det ID findes
            Pizza pizza = menu.GetPizza(id);
            if (pizza == null)
            {
                Console.WriteLine($"Ingen pizza fundet med ID {id}.");
                return;
            }

            Console.Write("Indtast nyt navn: ");
            string navn = Console.ReadLine();

            Console.Write("Indtast ny størrelse (lille/mellem/store): ");
            string størrelse = Console.ReadLine().ToLower();

            // Tjek for gyldig størrelse
            double pris;
            if (størrelse == "lille" || størrelse == "mellem" || størrelse == "store")
            {
                pris = BeregnPris(størrelse);
            }
            else
            {
                Console.WriteLine("Fejl: Du skal vælge 'lille', 'mellem' eller 'store'.");
                return;
            }

            // Udfør opdatering
            Pizza nyPizza = new Pizza(id, navn, pris, størrelse);
            menu.UpdatePizza(id, nyPizza);

            Console.WriteLine($"Pizza med ID {id} er nu opdateret til: {navn} ({størrelse}) - {pris} kr.");
        }

        private void SearchPizzaDialog(PizzaMenu menu)
        {
            Console.Write("Indtast søgekriterium: ");
            string kriterium = Console.ReadLine();
            Pizza fundet = menu.SearchPizza(kriterium);

            if (fundet != null)
                Console.WriteLine($" Fundet: {fundet}");
            else
                Console.WriteLine(" Ingen pizza fundet.");
        }

        private double BeregnPris(string størrelse)
        {
            double grundpris = 40;
            switch (størrelse)
            {
                case "lille": return grundpris;
                case "mellem": return grundpris + 10;
                case "stor":
                case "store": return grundpris + 20;
                default:
                    Console.WriteLine("Ukendt størrelse — standardpris bruges.");
                    return grundpris;
            }
        }
    }
}


