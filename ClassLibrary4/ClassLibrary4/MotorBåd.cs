using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class MotorBåd : Båd
    {
        public int MotorHP { get; private set; }

        public MotorBåd(int bådId, string bådNavn, int byggeÅr, int motorHP)
                : base(bådId, bådNavn,"MotorBåd", byggeÅr)
        {
            MotorHP = motorHP;
            Validate();
        }
        public override void Validate()
        {
            if (MotorHP <= 0)
                throw new Exception("MotorHP skal være > 0");
        }
        public override string ToString()
        { return $"{base.ToString()} \n{MotorHP}";
        }
    }
}
