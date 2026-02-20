using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Rep
{
    public class BegivenhedRep
    {
        private List<Begivenhed> _events = new List<Begivenhed>();// rækkefølge vigtigt

        public BegivenhedRep()          //konstruktion
        {
            Add(new Begivenhed("Forårskapsejlads", 1, "Hillerød Sø", new DateTime(2026, 4, 15, 10, 00, 00)));
            Add(new Begivenhed("Sankt Hans Bål", 2, "Foreningens klubhus", new DateTime(2026, 6, 23, 19, 00, 00)));
            Add(new Begivenhed("Sommerfest", 3, "Hillerød Marina", new DateTime(2026, 7, 12, 17, 00, 00)));
            Add(new Begivenhed("Sejlerskole Introdag", 4, "Klubhus undervisningssal", new DateTime(2026, 3, 10, 18, 30, 00)));
            Add(new Begivenhed("Efterårstur", 5, "Frederiksværk Havn", new DateTime(2026, 9, 20, 09, 00, 00)));
            Add(new Begivenhed("Julehygge i klubben", 6, "Klubhus lounge", new DateTime(2026, 12, 14, 15, 00, 00)));
        }
        // ADD  CASE=7
        public void Add(Begivenhed e)
        {
            // tjek om ID allerede findes
            foreach (Begivenhed _begiv in _events)
            {
                if (_begiv.BegivenhedId == e.BegivenhedId)
                    throw new Exception("En begivenhed med dette ID findes allerede.");
            }

            e.Validate();      // valider først
            _events.Add(e);   // tilføj til listen
        }

        // GET ALL=VIS   CASE=8
        public List<Begivenhed> GetAll()
        {
            return _events.ToList();
        }

        // FIND BY ID   CASE=20
        public Begivenhed FindById(int begivenhedId)
        {
            foreach (Begivenhed e in _events)
            {
                if (e.BegivenhedId == begivenhedId)
                    return e;
            }

            return null;
        }
    }
}


//søgning, filtrering og lagring.