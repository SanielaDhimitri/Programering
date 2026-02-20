using ClassLibrary4;
using System;
using System.Collections.Generic;//Nemt at bruges list,dictionary
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary4.Rep
{
    public class BådRep//kun i repository valideres både(båd kun  definere validate regler)
    {

        private Dictionary<int, Båd> _både = new Dictionary<int, Båd>();// Dictionary: Key = BådId, Value = Båd     // Nøgler skal være unikke, rækkefølge er ikke vigtig

        public BådRep()//konstruktør repository= samling af objekter.
        {
            Add(new SejlBåd(11, "Svanen", 1999, 45.0));//new objekt= kalder add metoden til at tilføje både til repository
            Add(new MotorBåd(12, "Havhesten", 2010, 250));//= 4 varieble ikke 5=BådType bliver sat automatisk(subklas).
            Add(new SejlBåd(13, "Stormfuglen", 2005, 38.5));
            Add(new MotorBåd(14, "Søulven", 2012, 320));
            Add(new MotorBåd(15, "SommerFugl", 2012, 100));

        }
        // ===== 1Add =case 15=====
        public void Add(Båd boat)
        {

            foreach (Båd b in _både.Values)//// .Values sepse Dictionary përmban KeyValuePair,
                                           // ne na duhen vetëm objektet Båd (Value)// id e panevojshme
            {
                if (b.BådId == boat.BådId)
                    throw new Exception("This Id er allerede");
            }
            boat.Validate();//repository kalder validate  //Klassen beder et andet objekt båd,medlem mm om at validere sig selv
            _både.Add(boat.BådId, boat);
        }


        //public void Add(Båd boat)
        //{
        //    if (_både.ContainsKey(boat.BådId))
        //        throw new ArgumentException("Båd med dette ID findes allerede");

        //    boat.Validate();
        //    _både.Add(boat.BådId, boat);
        //}


        // ===== 2Get all =case 1=====
        public List<Båd> GetAll()
        {
            List<Båd> _list = new List<Båd>();
            foreach (Båd _bb in _både.Values)
            {
                _list.Add(_bb); //_bb=+ bb object ne list=ikke dictionary
            }
            return _list;
        }

        //public List<Båd> GetAll()
        //{
        //    return _både.Values.ToList();
        //}

        // 333REMOVE

        public void Remove(int bådId)
        {
            bool found = false;

            foreach (Båd boat in _både.Values)
            {
                if (boat.BådId == bådId)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                throw new Exception("Den båd eksisterer ikke");

            _både.Remove(bådId);
        }


        // ===== 4Find by ID=case 5 =====
        public Båd FindById(int bådId)
        {
            foreach (Båd b in _både.Values)
            {
                if (b.BådId == bådId)
                    return b;
            }

            return null;
        }


        // ===== 6Search by bådtype =15 = Filter=====
        public List<Båd> SearchByBådType(string bådType)
        {
            List<Båd> _båd = new List<Båd>();

            foreach (Båd b in _både.Values)
            {
                if (b.BådType == bådType)
                {
                    _båd.Add(b);
                }
            }

            return _båd;
        }

        // ===== 8Exists=case2 =====
        public bool Exist(int bådId)
        {
            foreach (Båd b2 in _både.Values)
            {
                if (b2.BådId == bådId)
                    return true;
            }
            return false;
        }


        // ===== 9Filter by byggeår=case 11 =====
        public List<Båd> FilterByByggeÅr(int byggeÅr)
        {
            List<Båd> _båd1 = new List<Båd>();

            foreach (Båd båd in _både.Values)
            {
                if (båd.ByggeÅr == byggeÅr)
                {
                    _båd1.Add(båd);
                }
            }
            return _båd1;
        }
    }
}
//Reglerne ligger i klasserne Båd, SejlBåd og MotorBåd
//Repository’et kalder Va