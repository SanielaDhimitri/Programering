using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Vedligeholdelse:IValidate
    {
        private static int NextVedligeholdelseId=1;
        public int VedligeholdelseId { get; set; }
        public Båd Båd { get; set; }
        public DateTime SidsteService { get; set; } = DateTime.Now;
        public string Beskrivelse { get; set; }
        public bool ErOK { get; set; }
      

      

        public Vedligeholdelse( DateTime sidsteService, string beskrivelse, bool erOk)
        {
          VedligeholdelseId = NextVedligeholdelseId++;
           SidsteService =sidsteService;
            Beskrivelse = beskrivelse;
            ErOK = erOk;

            Validate();
        }
        public void Validate()
        {
            if (Båd == null)
                throw new Exception("Vedligeholdelse skal være knytet til en båd");
            if (string.IsNullOrWhiteSpace(Beskrivelse))
                throw new Exception("Beskrivelsen må ikke være tomt");
        }


        public override string ToString()
        {//præsentations-logik=Vises i ToString(IF EROK)
            string sidsteService = "";//""= tom string=tilføje tekst senere – kun hvis det er nødvendigt.
            if (ErOK)
            { sidsteService = $"{SidsteService:dd-MM-yyyy}"; }

            return $"{VedligeholdelseId}\n{Båd}\n{SidsteService}\n{Beskrivelse}\n{ErOK}";

        }
    }

}



//Implementerer IValidate

// Klassen validerer sig selv

//Repository kan kalde Validate()

// private set beskytter data