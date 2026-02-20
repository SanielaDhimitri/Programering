
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary4
{
                                                   // abstract: Klassen kan ikke oprettes som objekt (Båd båd=new Båd())

    public abstract class Båd : IValidate          //public :acsses modifier// ( : )Båd lover, at alle både kan valideres// abstract(IKKE Båd båd=new Båd)
    {
                                                   // static: fælles tæller for alle både= unikke sejlnumre
        private static int _nextSejlNummer = 1;

                                                   // Instance fields: gemmer objektets data (interne værdier)
        private int _sejlNummer;
        private int _bådId;
        private string _bådNavn;
        private string _bådType;
        private int _byggeÅr;

                                                     // Property: giver read-only adgang til sejlnummer
        public int SejlNummer
        {
            get { return _sejlNummer; }
          
        }

                                                                // Property: id for båden
        public int BådId
        {
            get { return _bådId; }
            set { _bådId = value; }
        }

                                                              // Property: navn på båden
        public string BådNavn
        {
            get { return _bådNavn; }
            set { _bådNavn = value; }
        }

                                                              // Property: type af båd (fx SejlBåd eller MotorBåd)
        public string BådType
        {
            get { return _bådType; }
            set { _bådType = value; }
        }

                                                                 // Property: byggeår for båden
        public int ByggeÅr
        {
            get { return _byggeÅr; }
            set { _byggeÅr = value; }
        }

                                                                     // Constructor: initialiserer fælles data for alle både= kaldes af subklasser
        protected Båd (int bådId, string bådNavn, string bådType, int byggeÅr)
        {

            _sejlNummer = _nextSejlNummer++;                                       //unikt sejlnummer

            BådId = bådId;
            BådNavn = bådNavn;
            BådType = bådType;
            ByggeÅr = byggeÅr;

                                                              // kach det fejl= Add(new MotorBåd(-5, "ISommerFugl", 2012, 100));TJEKKER BASE REGLER i konstuktor
        }
        protected void ValidateBoat()                                           //fælles regler (baseklasse)
        {
            if (BådId <= 0)
                throw new ArgumentException ("BådId skal være stærre end 0");
            if (string.IsNullOrWhiteSpace(BådNavn))
                throw new ArgumentException("Navn skal ikke være tomt");
            if (ByggeÅr > DateTime.Now.Year)
                throw new ArgumentException("Fejl:ByggeAr kan ikke være i fremtiden");
        }

        public abstract void Validate();                                                  //abstract Tvinger implementeres i (sub klasser)
        public override string ToString()
        { 
            return $"SejlNummer:{SejlNummer}\n" +
                $"BådId:{BådId}\n" +
                $"BådNavn:{BådNavn}\n" +
                $"ByggeÅr:{ByggeÅr}\n" +
                $"Bådtype: {BådType}";
        }

    }
}
