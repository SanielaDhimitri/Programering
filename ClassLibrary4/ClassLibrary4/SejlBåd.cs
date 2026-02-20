using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class SejlBåd: Båd
    {
        public double Areal { get; private set; }

        public SejlBåd(int bådId,string bådNavn, int byggeÅr, double areal)
            : base(bådId,bådNavn,"SejlBåd", byggeÅr)
        {
            Areal = areal;
            Validate();
        }
        public override void Validate()
        {
            if (Areal <= 0)
                throw new Exception("Areal skal ikke være <= 0");
        }
        public override string ToString()


        {
            return $" {base.ToString()},{Areal}m^2";
        }
    }
}
