using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMægleren
{
    internal class KøberEmne : Person
    {
        public int MaxPris { get; set; }
        public int MinStørrelse { get; set; }
        public EjendomType ØnsketType { get; set; }
        // Liste over fremviste ejendomme
        private List<Ejendom> fremvisteEjendomme = new List<Ejendom>();
        public KøberEmne(int id, string navn,string adresse, string email, string telefon, int maxPris, int minStørrelse,EjendomType øsketType)
            : base( id, navn, adresse, telefon, email)
        {
            MaxPris = maxPris;
            MinStørrelse = minStørrelse;
            ØnsketType = ØnsketType;
        }
        //public override string ToString()
        //{
        //    return base.ToString() + $", Ønsker maks pris: {MaxPris} DKK, Minimum værelser: {MinStørrelse}";
        //}



        // Registrer at en ejendom er blevet vist
        public void RegistrerFremvisning(Ejendom ejendom)
        {
            if (!fremvisteEjendomme.Contains(ejendom))
            {
                fremvisteEjendomme.Add(ejendom);
                Console.WriteLine($"Ejendom {ejendom.ID} er nu registreret som fremvist til {Navn}.");
            }
            else
            {
                Console.WriteLine($"Ejendom {ejendom.ID} er allerede vist til {Navn}.");
            }
        }

        // Hent alle fremviste ejendomme
        public List<Ejendom> HentFremvisteEjendomme()
        {
            return fremvisteEjendomme.ToList();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Søger {ØnsketType}, min {MinStørrelse} kvm, max {MaxPris} kr., Fremviste ejendomme: {fremvisteEjendomme.Count}";
        }

        
    }
}
