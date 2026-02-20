using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Rep
{
    public class BookingRep
    {
        private List<Booking> _bookings = new List<Booking>();

        private BådRep _boatRepository;
        private VedligeholdRep _maintenanceRepository;
        private MedlemRep _memberRepository;
        private BegivenhedRep _eventRepository;

        //  CONSTRUCTOR
        public BookingRep( BådRep boatRepository, VedligeholdRep maintenanceRepository,MedlemRep memberRepository,BegivenhedRep eventRepository)
        {
            _boatRepository = boatRepository;
            _maintenanceRepository = maintenanceRepository;
            _memberRepository = memberRepository;
            _eventRepository = eventRepository;
        }

        // 1111 BOOK EN BÅD  // CASE = 2
        public Booking BookBåd(int bådId, int medlemId, DateTime start, DateTime slut, string destination ) //bestemmer selv ,Hvilke parametra kræves til at booke en båd.
        {
            Medlem medlem = _memberRepository.FindById(medlemId);                                         //tjekker hvis eksister til at book
            if (medlem == null)
                throw new Exception("Medlem findes ikke");

            Båd båd = _boatRepository.FindById(bådId);
            if (båd == null)
                throw new Exception("Båd findes ikke");

            Vedligeholdelse service = _maintenanceRepository.GetLatestServiceForBoat(bådId);
            if (service != null && service.ErOK == false)
                throw new Exception("Båden er til reparation");

            if (start >= slut)
                throw new Exception("Starttid skal være før sluttid");


            foreach (Booking b in _bookings)
            {
                if (b.Båd.BådId == bådId)
                {
                    if (start < b.SlutTid && slut > b.StartTid)
                        throw new Exception("Båden er allerede booket");
                }
            }

            Booking booking = new Booking(båd, medlem, null, start, slut, destination, service);
            _bookings.Add(booking);
            return booking;
        }

        // 222 AFSLUT BOOKING  CASE=4
        public void AfslutBooking(int bookingId)
        {
            Booking fundet = null;

            foreach (Booking b in _bookings)
            {
                if (b.BookingId == bookingId)
                {
                    fundet = b;
                    break;
                }
            }

            if (fundet == null)
                throw new Exception("Booking findes ikke!");

            _bookings.Remove(fundet);
        }

        // 333 VIS ALLE BOOKINGER  CASE=3
        public List<Booking> GetAll()
        {
            return new List<Booking>(_bookings);
        }


        // 444 Er båd booket nu?
        public bool ErBådBooketNu(int bådId)
        {
            DateTime nu = DateTime.Now;

            foreach (Booking b in _bookings)
            {
                if (b.Båd != null &&
                     b.Båd.BådId == bådId &&
                    nu >= b.StartTid &&
                    nu <= b.SlutTid)
                {
                    return true;
                }
            }
            return false;
        }

        // 555 Hvem er på tur nu?  CASE=14
        public List<Booking> HvemErPåTurNu()
        {

            List<Booking> resultat = new List<Booking>();
            DateTime nu = DateTime.Now;
            foreach (Booking b in _bookings)
            {
                if (nu >= b.StartTid && nu <= b.SlutTid)
                {
                    resultat.Add(b);
                }
            }

            return resultat;
        }

        // 666 BOOK EN BÅD TIL EN BEGIVENHED=CASE=21
        public Booking BookBegivenhed(int begivenhedId, int bådId, int medlemId)
        {
            Begivenhed begivenhed = _eventRepository.FindById(begivenhedId);
            if (begivenhed == null)
                throw new Exception("Begivenhed findes ikke");

            Båd båd = _boatRepository.FindById(bådId);
            if (båd == null)
                throw new Exception("Båd findes ikke");

            Medlem medlem = _memberRepository.FindById(medlemId);
            if (medlem == null)
                throw new Exception("Medlem findes ikke");

            Vedligeholdelse service = _maintenanceRepository.GetLatestServiceForBoat(bådId);
            if (service != null && service.ErOK == false)
                throw new Exception("Båden er til reparation");

            DateTime start = begivenhed.DatoStart;
            DateTime slut = start.AddHours(4);

            foreach (Booking b in _bookings)
            {
                if (b.Båd.BådId == bådId)
                {
                    if (start < b.SlutTid && slut > b.StartTid)
                        throw new Exception("Båden er allerede booket");
                }
            }

            Booking booking = new Booking(båd, medlem, begivenhed, start, slut, begivenhed.Sted, service
     );


            _bookings.Add(booking);
            return booking;
        }




        // 777 Hvor mange har booket en begivenhed case=23
        public int CountBookingsForBegivenhed(int begivenhedId)
        {
            int count = 0;

            foreach (Booking b in _bookings)
            {
                if (b.Begivenhed != null &&
                    b.Begivenhed.BegivenhedId == begivenhedId)
                {
                    count++;
                }
            }

            return count;
        }


    }
}

    

