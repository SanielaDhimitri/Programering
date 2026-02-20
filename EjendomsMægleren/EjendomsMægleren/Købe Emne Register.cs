using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace EjendomsMægleren
{
    internal class KøberEmneRegister
    {

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
        // Hent en køber via ID
        public KøberEmne? Get(int id)
        {
            foreach (var k in købere)
            {
                if (k.ID == id)
                    return k;
            }
            return null; // fandt ingen med det ID
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





