using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Rep
{
    public class MedlemRep
    {
        private List<Medlem> _medlemmer = new List<Medlem>();

        public MedlemRep()   //konstruktion
        {
            Add(new Medlem(1, "Kristian Møller", "Skovvej 12, Hillerød",
                "kristianmoller@gmail.com", "12349876", "Senior", 1100, new DateTime(2026, 1, 1)));

            Add(new Medlem(2, "Sille Kristensen", "Blomstervænget 4, Fredensborg",
                "sille.kristensen@gmail.com", "87651234", "Junior", 750, new DateTime(2026, 1, 2)));

            Add(new Medlem(3, "Filip Sørensen", "Park Allé 22, Hillerød",
                "filip.sorensen@gmail.com", "45671239", "Familie", 1500, new DateTime(2026, 1, 3)));

            Add(new Medlem(4, "Nanna Bæk", "Bymidten 8, Hillerød",
                "nanna.baek@gmail.com", "90817263", "Junior", 1100, new DateTime(2026, 1, 2)));

            Add(new Medlem(5, "Valdemar Junker", "Søvej 19, Farum",
                "valdemar.junkerg@mail.com", "56781239", "Bådplads", 400, new DateTime(2026, 1, 3)));
        }

        // =====11 Add =case 9=====
        public void Add(Medlem medlem)
        {

            foreach (Medlem mm in _medlemmer)
            {
                if (mm.MedlemId == medlem.MedlemId)
                    throw new Exception("det id er allerede ");
            }
            medlem.Validate();
            _medlemmer.Add(medlem);

        }

        // ===== 22GetAll=case10 =====
        public List<Medlem> GetAll()
        {
            List<Medlem> _medlem1 = new List<Medlem>();
            {
                foreach (Medlem m1 in _medlemmer)
                    _medlem1.Add(m1);
            }
            return _medlem1;
        }
        //public List<Medlem> GetAll()
        //{
        //    return new List<Medlem>(_medlemmer);
        //}



        // ===== 33Find by ID =case2=====
        public Medlem FindById(int medlemId)
        {
            foreach (Medlem m in _medlemmer)
            {
                if (m.MedlemId == medlemId)
                    return m;
            }
            return null;
        }

        // ===== 44Exists=case2 =====
        public bool Exists(int medlemId)
        {
            foreach (Medlem m3 in _medlemmer)
            {
                if (m3.MedlemId == medlemId)
                    return true;
            }
            return false;
        }


        // AAAA===== 55Search (navn )=case16 =====
        public List<Medlem> SearchByNavn(string navn)
        {
            List<Medlem> _med3 = new List<Medlem>();
            foreach (Medlem m3 in _medlemmer)
            {
                if (m3.Navn == navn)
                {
                    _med3.Add(m3);
                }

            }
            return _med3;

        }
        //66Search ( email)=case17 =====
        public List<Medlem> SearchByEmail(string email)
        {
            List<Medlem> _med4 = new List<Medlem>();
            foreach (Medlem m4 in _medlemmer)
            {
                if (m4.Email == email)


                {
                    _med4.Add(m4);
                }
            }
            return _med4;
        }

        // ===== 77Remove =case 18=====
        public void Remove(int medlemId)
        {
            Medlem found = null;

            foreach (Medlem m in _medlemmer)
            {
                if (m.MedlemId == medlemId)
                {
                    found = m;
                    break;
                }
            }

            if (found == null)
                throw new Exception("Medlem med det angivne ID findes ikke.");

            _medlemmer.Remove(found);
        }



        // ===== 88Filter by medlemstype=case12 =====
        public List<Medlem> FilterByMedlemType(string medlemType)
        {
            List<Medlem> _m5 = new List<Medlem>();
            foreach (Medlem mm in _medlemmer)
            {
                if (mm.MedlemsType == medlemType)
                {
                    _m5.Add(mm);
                }
            }
            return _m5;

        }

        // ===== 99Årlig indtægt pr. medlemstype =case13=====
        //hver År.Efter 2025 slettes og starter med 2026
        public double GetTotalÅrligIndtægt(int år)
        {
            double total = 0;

            foreach (Medlem m in _medlemmer)
            {
                if (m.BetaltDato.Year == år)
                {
                    total += m.BetaltBeløb;//betaltbeløb=ved medlem klasse
                }
            }

            return total;
        }

    }
}

