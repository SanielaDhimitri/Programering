using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSystem
{
    public class Pizza
    {
       public int PizzaId { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }  
        public string Description { get; set; }


        public Pizza(int pizzaId, string name, double price, string description)
        {
            PizzaId = pizzaId;
            Name = name;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {PizzaId})\n" +
                   $"Price:{Price:F2}\n"+
                   $"Description: {Description}";
        }
    }
}
