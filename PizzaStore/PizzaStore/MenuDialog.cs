using System;
using System.Collections.Generic;

namespace PizzaStore
{
    public class MenuDialog
    {
        public int MenuChoice(List<string> menuItems)
        {
            int choice = 0;
            bool validChoice = false;

            while (!validChoice)
            {
                Console.Clear();
                Console.WriteLine("PIZZA MENU SYSTEM");

                // Vis menuen
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + menuItems[i]);
                }

                Console.Write("\nIndtast dit valg (1-" + menuItems.Count + "): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    
                    if (choice < 1)
                    {
                        Console.WriteLine("Tallet er for lille. Du skal vælge mindst 1.");
                        Console.ReadKey();
                    }
                    else if (choice > menuItems.Count)
                    {
                        Console.WriteLine("Tallet er for stort. Der er kun " + menuItems.Count + " valgmuligheder.");
                        Console.ReadKey();
                    }
                    else
                    {
                        // valget er gyldigt
                        validChoice = true;
                    }
                }
                else
                {
                    Console.WriteLine("Fejl: Du skal indtaste et tal.");
                    Console.ReadKey();
                }
            }

            return choice;
        }
    }
}