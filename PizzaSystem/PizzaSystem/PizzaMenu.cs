using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSystem
{
    public class PizzaMenu
    {
        private Dictionary<int, Pizza> pizzaMenu = new Dictionary<int, Pizza>();
        public void AddPizza(Pizza pizza)
        {
            pizzaMenu[pizza.PizzaId] = pizza;
        }
        public void RemovePizza(int pizzaId)
        {
            pizzaMenu.Remove(pizzaId);
        }
        public Pizza GetPizza(int pizzaId)
        {
            return pizzaMenu.TryGetValue(pizzaId, out var pizza) ? pizza : null;
        }
        public List<Pizza> GetAllPizzas()
        {
            return pizzaMenu.Values.ToList();
        }

        public void PrintMenu()
        {
            Console.WriteLine("----- Pizza Menu -----");
            foreach (var pizza in pizzaMenu.Values)
            {
                Console.WriteLine(pizza.ToString());
                Console.WriteLine("----------------------");
            }
        }
        public Pizza SearcPizza(string criteria)

        {
            foreach (Pizza pizza in pizzaMenu.Values)
            {
                if (pizza.Name.ToLower().Contains(criteria.ToLower()))
                {
                    return pizza;
                }
            }

            Console.WriteLine($"Ingen pizza matcher søgekriteriet '{criteria}'.");
            return null;
        }


    }
}
 