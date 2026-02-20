using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Booking:IValidate
    {
        private static int NextBookingId = 1;
        public int BookingId { get; set; }

        public Båd Båd { get; set; }
        public Medlem Medlem { get; set; }
        public Begivenhed Begivenhed { get; set; }  
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }
        public string Destinacion { get; set; }
        public Vedligeholdelse Vedligeholdelse { get; set; }
        public Booking (Båd båd, Medlem medlem, Begivenhed begivenhed, DateTime startTid, DateTime slutTid,string destinacion, Vedligeholdelse vedligeholdelse) 
            {
            BookingId = NextBookingId++;
            Båd = båd;
            Medlem = medlem;
            Begivenhed = begivenhed;
            StartTid = startTid;
            SlutTid = slutTid;
            Destinacion = destinacion; ;
            Vedligeholdelse = vedligeholdelse;
           
        }
            public void Validate()
        {
            if (BookingId <= 0)
                throw new Exception("BookingId skal være større end 0 ");
            if (Båd == null)
                throw new Exception("Båd må ikke være null");
            if (SlutTid < DateTime.Now)
                throw new Exception("SlutTid må ikke være i fortiden");
            if (SlutTid < StartTid)
                throw new Exception("SlutTid skal være efter StartTid");
            if (Destinacion == "")
                throw new Exception("Destination må ikke være tomt");
            if (Vedligeholdelse == null|| !Vedligeholdelse.ErOK)
                throw new InvalidOperationException("Båden er ikke vedligeholdt");

        }
        public override string ToString()
        {
            return $"{BookingId}\n" +
                $"{Båd}\n" +
                $"{Medlem}\n" +
                $"{StartTid}\n" +
                $"{SlutTid}\n" +
                $"{Destinacion}\n" +
                $"{Vedligeholdelse}";
        }

    }
}
//Validate()-metoden ligger i Booking-klassen, men kaldes fra BookingRepository, så repository styrer oprettelse og validering.