using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøbCykle
{
    public class Butik
    {
        public string Name { get; set; }    
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Adresse { get; set; }

        public Butik( string name, string tel, string mail, string adresse)
        { Name = name;
            Tel = tel;  
            Mail = mail;  
            Adresse = adresse;  
        }
        public override string ToString ()
        { return ($"Navn:{Name}\nTel:{Tel} \nMail:{Mail}\nAdresse:{Adresse}\n"); }
    }
}
