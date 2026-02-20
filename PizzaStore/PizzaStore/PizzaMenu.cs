using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaStore
{
    public class PizzaMenu
    {
        private Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>();

        // CREATE
        public bool AddPizza(Pizza pizza)
        {
            if (pizzas.ContainsKey(pizza.PizzaID))
            {
                Console.WriteLine("Fejl: Pizza med dette ID findes allerede.");
                return false;
            }

            pizzas.Add(pizza.PizzaID, pizza);
            Console.WriteLine("Pizza tilføjet.");
            return true;
        }

        // READ
        public Pizza GetPizza(int id)
        {
            if (pizzas.ContainsKey(id))
            {
                return pizzas[id];
            }
            Console.WriteLine("Pizza ikke fundet.");
            return null;
        }

        // UPDATE
        public bool UpdatePizza(int pizzaId, Pizza newPizza)
        {
            if (pizzas.TryGetValue(pizzaId, out Pizza existing))
            {
                existing.Navn = newPizza.Navn;
                existing.Størrelse = newPizza.Størrelse;
                existing.Pris = newPizza.Pris;

                Console.WriteLine($"Pizza '{existing.Navn}' opdateret.");
                return true;
            }

            Console.WriteLine("Pizza ikke fundet. Ingen opdatering udført.");
            return false;
        }

        // DELETE
        public bool DeletePizza(int pizzaId)
        {
            if (pizzas.ContainsKey(pizzaId))
            {
                pizzas.Remove(pizzaId);
                Console.WriteLine("Pizza slettet.");
                return true;
            }

            Console.WriteLine("Pizza ikke fundet.");
            return false;
        }

        // PRINT MENU
        public void PrintMenu()
        {
            Console.WriteLine("\nPizza Menu ");

            if (pizzas.Count == 0)
            {
                Console.WriteLine("Ingen pizzaer på menuen.");
                return;
            }

            foreach (var pair in pizzas)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        // SEARCH PIZZA BY kriterier
        public Pizza SearchPizza(string criteria)
        {
            foreach (Pizza pizza in pizzas.Values)
            {
                if (pizza.Navn.ToLower().Contains(criteria.ToLower()))
                {
                    return pizza;
                }
            }

            Console.WriteLine($"Ingen pizza matcher søgekriteriet '{criteria}'.");
            return null;
        }
    }
}

