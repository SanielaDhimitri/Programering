using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Begivenhed:IValidate
    {
        public string Navn { get; set; }
        public int BegivenhedId { get; set; }
        public string Sted { get; set; }
        public DateTime DatoStart { get; set; }

        public Begivenhed(string navn, int begivenhedId, string sted, DateTime datoStart)
        {
            Navn = navn;
            BegivenhedId = begivenhedId;
            Sted = sted;
            DatoStart = datoStart;
        }
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Navn))
                    throw new Exception ( "Navn må ikke være tomt" );
            if (BegivenhedId <= 0)
                throw new Exception("BegivenhedId skal være større end 0");
            if (string.IsNullOrWhiteSpace(Sted))
                throw new Exception("Sted må ikke være tomt");
            if (DatoStart < DateTime.Now)
                throw new Exception("DatoStart må ikke være i fortiden");
        }
        public override string ToString()
        {
            return $"{Navn}\n{BegivenhedId}\n{Sted}\n{DatoStart}";
        }

    }
}
