
using System;
using System.Collections.Generic;

namespace HillerodSejlklub
{
    public class Medlem
    {
        public int MedlemsNr { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public List<BådBooking> BookingHistorik { get; set; } = new();
    }

    public class Båd
    {
        public int BådNr { get; set; }
        public string Navn { get; set; }
        public string Type { get; set; }
        public string Plads { get; set; }
        public string Status { get; set; }  // OK / SkalRepareres / UdeAfDrift

        public List<Vedligehold> VedligeholdLog { get; set; } = new();
    }

    public class Vedligehold
    {
        public DateTime Dato { get; set; }
        public string Beskrivelse { get; set; }
        public string UdførtAf { get; set; }
    }

    public class BådBooking
    {
        public int BookingId { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
        public string Destination { get; set; }

        public Medlem Medlem { get; set; }
        public Båd Båd { get; set; }
    }

    public class Begivenhed
    {
        public string Titel { get; set; }
        public DateTime Dato { get; set; }
        public string Beskrivelse { get; set; }
    }

    public class BlogIndlæg
    {
        public int BlogId { get; set; }
        public string Titel { get; set; }
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }
        public string Forfatter { get; set; }

        public List<Kommentar> Kommentarer { get; set; } = new();
    }

    public class Kommentar
    {
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }
        public string Forfatter { get; set; }
    }

    public class MedlemsListe
    {
        public List<Medlem> Medlemmer { get; set; } = new();
    }

    public class BådListe
    {
        public List<Båd> Både { get; set; } = new();
    }
}