using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSystem
{
    public class KunderList 
    {
        private List<Kunder> kundersList = new List<Kunder>();

        public void AddKunde(Kunder kunde)
        {
            kundersList.Add(kunde);
        }
        public void RemoveKunde(Kunder kunde)
        {
            kundersList.Remove(kunde);
        }

        public List<Kunder> GetAllKunder()
        {
            return kundersList;
        }
        public void PrintMenu(Kunder Kunder)
        {
            foreach (Kunder k in kundersList)
            {
                Console.WriteLine(k.ToString());
            }
        }
    }
}


