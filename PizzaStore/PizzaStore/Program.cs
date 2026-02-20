using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PizzaStore;


namespace PizzaStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Opret butikken
            Store store = new Store("Big Mamma Pizzeria", "Jægersborgvej 106", "12345678", 87654321);
            Console.WriteLine();

            // Vælg testmetode
            Console.WriteLine("Vælg testmetode:");
            Console.WriteLine("1. Automatisk test (ingen brugerinput)");
            Console.WriteLine("2. Interaktiv menu (med brugerinput)");
            Console.Write("\nIndtast dit valg (1 eller 2): ");

            string valg = Console.ReadLine();//Programmet stopper og venter, til brugeren skriver noget og trykker Enter.

            Console.WriteLine();

            if (valg == "1")
            {
                // Kører din eksisterende automatiske test
                store.Start();
                Console.WriteLine("\nSlut på testkørsel (ingen brugerinput krævet)");
            }
            else if (valg == "2")
            {
                // Kører den interaktive menu (ny funktion)
                store.RunInteractiveMenu();
                Console.WriteLine("\nSlut på interaktiv kørsel");
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Programmet afsluttes.");
            }

            Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
            Console.ReadKey();
        }
    }
}