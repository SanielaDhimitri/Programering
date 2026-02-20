using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSystem
{
    public class Bestilling
    {
        public static int BestillingNext = 1;
        public int BestillingNo { get; set; }

        public Kunder Kunder { get; set; }
        public Pizza Pizza { get; set; }

        public DateTime BestillingsTid { get; set; }  

            private const double moms = 0.25;
        private const int deliveryFee = 40;

        public Bestilling( Kunder kunder, Pizza pizza)
        {
            BestillingNo = BestillingNext++;
            Kunder = kunder;
            Pizza = pizza;
            BestillingsTid = DateTime.Now;
        }

        public double CalculateTotalPrice()
        {
            double priceWithMoms = Pizza.Price * (1 + moms);
            return priceWithMoms + deliveryFee;
        }
        public override string ToString()
        {
            return $"Bestilling No: {BestillingNo}\n"  +
                $"Customer: {Kunder.Name} \n" +
                $"\nPizza: {Pizza.Name}\n " +
                $"\nOrder Time: {BestillingsTid:g}\n" +
                $"\nTotal Price (incl. moms and delivery): ${CalculateTotalPrice():F2}";
        }
}
}
