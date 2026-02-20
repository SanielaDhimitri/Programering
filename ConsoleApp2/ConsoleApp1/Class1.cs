using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMægleren
{
    internal class KøberEmne 
    {
        public int Id { get; set; }
        public string Navn { get; set; }    
        public string Adresse { get; set; } 
        public string Email { get; set; }   
        public string Telefon { get; set; } 

        public int MaxPris { get; set; }
        public int MinimumVærelser { get; set; }

        public KøberEmne(int id, string navn, string adresse, string email, string telefon, int maxPris, int minVærelser)
          
        {
            Id = id;
            Navn = navn;
            Adresse = adresse;
            Email = email;
            Telefon = telefon;

            MaxPris = maxPris;
            MinimumVærelser = minVærelser;
        }

        public override string ToString()
        {
            return base.ToString() + $", Ønsker maks pris: {MaxPris} DKK, Minimum værelser: {MinimumVærelser}";
        }
        private List<KøberEmne> købere = new List<KøberEmne>();

        // Tilføj køber
        public void Add(KøberEmne køber)
        {
            købere.Add(køber);
        }

        // Fjern køber (via ID)
        public KøberEmne? Remove(int id)
        {
            foreach (var k in købere)
            {
                if (k.ID == id)
                {
                    købere.Remove(k);   // fjern køberen
                    return k;           // returnér den fjernede køber
                }
            }
            return null; // fandt ikke en køber med det ID
        }

        // Hent alle købere
        public List<KøberEmne> GetAll()
        {
            return købere.ToList();
        }

        // Udskriv alle
        public void Udskriv()
        {
            Console.WriteLine($"KøberEmneRegister ({købere.Count} købere):");
            foreach (var k in købere)
                Console.WriteLine(k);
        }
    }
}
    


