using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;







namespace PizzaStore
{
    public class CustomerFile
    {
        // Her gemmes alle kunder i en List
        private List<Customer> customers = new List<Customer>();

        // CREATE
        public bool AddCustomer(Customer customer)
        {
            foreach (Customer c in customers)
            {
                if (c.ID == customer.ID)
                {
                    Console.WriteLine("Fejl: Kunde med dette ID findes allerede.");
                    return false; // ID ekzister — tilføres ikke
                }
            }

            customers.Add(customer);
            Console.WriteLine("Kunde oprettet.");
            return true;
        }

        // READ
        public Customer? GetCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.ID == id)
                {
                    Console.WriteLine("Kunde fundet.");
                    return c; // return den fundne kunde    
                }
            }

            Console.WriteLine("Kunde ikke fundet.");
            return null;
        }

        // UPDATE
        public bool UpdateCustomer(int id, Customer newCustomer)
        {
            foreach (Customer c in customers)
            {
                if (c.ID == id)
                {
                    c.Navn = newCustomer.Navn;
                    c.Adresse = newCustomer.Adresse;
                    c.Telefon = newCustomer.Telefon;

                    Console.WriteLine("Kunde opdateret.");
                    return true;
                }
            }

            Console.WriteLine("Kunde ikke fundet.");
            return false;
        }

        // DELETE
        public bool DeleteCustomer(int id)
            // prøv med forech
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == id)
                {
                    customers.RemoveAt(i);
                    Console.WriteLine("Kunde slettet.");
                    return true;
                }
            }

            Console.WriteLine("Kunde ikke fundet.");
            return false;
        }

        // PRINT ALL
        public void PrintMenu()
        {
            Console.WriteLine("\n Customer List");

            if (customers.Count == 0)
            {
                Console.WriteLine("Ingen kunder fundet.");
                return;
            }

            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }
        }
    }
}