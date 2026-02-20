using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pizzaAPP;

namespace PizzaAPP
{ 
       internal class Program
        {
          
            static void Main(string[] args)
            {
             
                Store store = new Store("Big Mamma Pizzeria", "Jægersborgvej 12", "87654321", "12345678");
                Console.WriteLine(store);
                store.Start();
            }
        }
    
}

//Big Mamma Pizzeria, Jægersborgvej 12, Tlf: 87654321, CVR: 12345678
//Ordre #1 (25-10-2025 23:53): Ema har bestilt Peperoni. Totalpris: 152,5 kr
//Ordre #2 (25-10-2025 23:53): Enzo har bestilt Calcone. Totalpris: 158,75 kr
//Ordre #3 (25-10-2025 23:53): Sara har bestilt Putaneska. Totalpris: 171,25 kr