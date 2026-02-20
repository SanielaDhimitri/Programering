using KøbCykle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøbTel
{
    public class Ordrer
    {
        public static int NextID = 1;
        public int BestillingsID { get; set; }
        public Kunder Kunder { get; set; }
        public Tel Tel { get; set; }
        public  DateTime DateTime { get; set; }
        public  List<string>ExtraAcessores { get; private set; }
        private const double Tax = 0.25;
        private const int Aflevering = 40;
        private const int AcessoresPrice = 10;
        public Ordrer(Kunder kunder, Tel tel)
        { 
            Kunder = kunder;
            Tel = tel;
            BestillingsID = NextID++;
           DateTime = DateTime.Now;
           ExtraAcessores = new List<string>();


        }
        public void AddAcessore(string Acessore)
        {
            ExtraAcessores.Add(Acessore);
            Console.WriteLine(Acessore);
        }

        public double CalculatePrice()
        {
            double TelPrice = Tel.Price * (1 + Tax)+Aflevering;
            double ExtraAcessoresPrice=ExtraAcessores.Count*AcessoresPrice;
            return TelPrice+ExtraAcessoresPrice;
        }
        public override string ToString()
        {
            return $"ORDRE: {BestillingsID}\n" +
                   $"Dato: {DateTime:g}\n" +
                   $"Kunde: {Kunder.Name}\n" +
                   $"Pizza: {Tel.Name} \n" +
                   $"Totalpris: {CalculatePrice():F2} kr\n";
        }



    }
}
