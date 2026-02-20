using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    public class Burger
    {
        public int BurgerID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Burger(int burgerID, string name, double price, string description)
        {
            BurgerID = burgerID;
            Name = name;
            Price = price;
            Description = description;
        }
        public override string ToString()
        {
            return $"BurgerID: {BurgerID}\n Name: {Name}\n Price: {Price}\n Description: {Description}";
        }
}
}
