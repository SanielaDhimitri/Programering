using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøbCykle
{
    public class Kunder
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Adresse { get; set; }

        public Kunder(string name, int id, string tel, string mail, string adresse)
        { Name = name;
            ID = id;
            Tel = tel;
            Mail = mail;
            Adresse = adresse;

        }
        public override string ToString() {
            {
                return $"Name:{Name}\nID:{ID} \nTel:{Tel}\nMail:{Mail}\nAdresse:{Adresse}\n";
            }


        }
    }
}
