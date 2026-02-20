using EjendomsMægleren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;





namespace EjendomsMægleren
{


    internal class EjendomsRegister
    {

        // Dictionary: key = Ejendoms-ID, value = Ejendom
        private Dictionary<int, Ejendom> _ejendomme = new Dictionary<int, Ejendom>();//Ejedom=classe som jeg har selv bygget

        public void Add(Ejendom e )
            
     

        {
            if (!_ejendomme.ContainsKey(e.ID))
            {
                _ejendomme.Add(e.ID, e);
            }
            else
            {
                Console.WriteLine($"Ejendom med ID {e.ID} findes allerede.");
            }
        }

        // Fjern ejendom
        public Ejendom Remove(int id)
        {
            if (_ejendomme.ContainsKey(id))
            {
                Ejendom fjernet = _ejendomme[id];
                _ejendomme.Remove(id);
                return fjernet;
            }
            return null;
        }

        // Hent ejendom ud fra ID
        public Ejendom Get(int id)
        {
            if (_ejendomme.ContainsKey(id))
                return _ejendomme[id];
            return null;
        }

        // Hent alle ejendomme
        public List<Ejendom> GetAll()
        {
            return new List<Ejendom>(_ejendomme.Values);
        }

        // Udskriv alle ejendomme
        public void Udskriv()
        {
            foreach (Ejendom e in _ejendomme.Values)
            {
                Console.WriteLine(e);
            }
        }


        // Ny metode: Match ejendomme på type, min størrelse og max pris
        public List<Ejendom> Match(EjendomType type, double minStørrelse, double maxPris)
        {
            List<Ejendom> matches = new List<Ejendom>();

            foreach (Ejendom e in _ejendomme.Values)
            {
                if (e.Type == type && e.Størrelse >= minStørrelse && e.Pris <= maxPris)
                {
                    matches.Add(e);
                }
            }

            return matches;
        }

        // Match med parametre
     

        // Overload: Match direkte på KøberEmne
        public List<Ejendom> Match(KøberEmne køber)
        {
            return Match(køber.ØnsketType, køber.MinStørrelse, køber.MaxPris);
        }
        // Find matchende ejendomme som IKKE er fremvist til en given køber
        public List<Ejendom> MatchIkkeFremvist(KøberEmne køber)
        {
            // Find alle matchende ejendomme
            var matches = Match(køber.ØnsketType, køber.MinStørrelse, køber.MaxPris);

            // Fjern dem som allerede er fremvist
            var fremvist = køber.HentFremvisteEjendomme();
            return matches.Where(e => !fremvist.Contains(e)).ToList();
        }

    }
    }



