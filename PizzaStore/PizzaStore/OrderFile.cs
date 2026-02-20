using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaStore
{
    public class OrderFile
    {
        private List<Order> ordrer = new List<Order>();

        // CREATE
        public void AddOrder(Order ordre)
        {
            ordrer.Add(ordre);
            Console.WriteLine($" Ordre {ordre.BestillingsID} tilføjet.");
        }

        // READ
        public Order GetOrder(int id)
        {
            foreach (Order o in ordrer)
            {
                if (o.BestillingsID == id)
                    return o;
            }
            Console.WriteLine("Ordre ikke fundet.");
            return null;
        }

        // UPDATE
        public bool UpdateOrder(int id, Order nyOrdre)
        {
            for (int i = 0; i < ordrer.Count; i++)
            {
                if (ordrer[i].BestillingsID == id)
                {
                    ordrer[i] = nyOrdre;
                    Console.WriteLine($" Ordre {id} opdateret.");
                    return true;
                }
            }
            Console.WriteLine(" Ordre ikke fundet.");
            return false;
        }

        // DELETE
        public bool DeleteOrder(int id)
        {
            Order o = GetOrder(id);
            if (o != null)
            {
                ordrer.Remove(o);
                Console.WriteLine($" Ordre {id} slettet.");
                return true;
            }
            return false;
        }

        // PRINT
        public void PrintOrders()
        {
            Console.WriteLine("\n Ordreliste");
            if (ordrer.Count == 0)
            {
                Console.WriteLine("Ingen ordrer fundet.");
                return;
            }

            foreach (Order o in ordrer)
            {
                Console.WriteLine(o);
                
            }
        }
    }
}