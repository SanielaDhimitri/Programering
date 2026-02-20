using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KøbCykle
{
    public class Tel
    {
        public int TelID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }



        public Tel(int TelID, string Name, int price)
        { TelID = TelID;
            Name = Name;
            Price = price;
        }

        public override string ToString ()
        { return ($"TelID:{TelID} \nNavn:{Name}\nPrice:{Price}kr\n"); }





    }
}
