using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Medlem
    {
     
        public int MedlemId { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string MedlemsType { get; set; }
        public int BetaltBeløb { get; set; }
        public DateTime BetaltDato { get; set; }



        public Medlem(int medlemId, string navn, string adresse,string email, string telefon,  string medlemsType, int betaltBeløb, DateTime betaltDato)
        {
            MedlemId = medlemId;
            Navn = navn;
            Adresse = adresse;
            Email = email;
            Telefon = telefon;
            MedlemsType = medlemsType;
            BetaltBeløb = betaltBeløb; 
            BetaltDato = betaltDato;
            
        }
        public void Validate()
        {
            if (MedlemId <= 0)
                throw new Exception("ID skal være >0");
            if (string.IsNullOrWhiteSpace(Navn))
                throw new Exception("Navn må ikke være tomt");
            if (string.IsNullOrWhiteSpace(Email))
                throw new ArgumentException("Email må ikke være tom");
            if (!Email.Contains("@"))
                throw new Exception("Email skal indholde @");
            if (BetaltDato > DateTime.Now)
                throw new Exception("Data må ikke være i fremtiden");

        }
        public override string ToString()
        {
            return $" {MedlemId}\n " +
                $"{Navn}\n " +
                $"{Adresse}" +
                $"{Email}" +
                $" {Telefon}" +
                $" {MedlemsType}\n" +
                $"{BetaltBeløb}\n" +
                $"{BetaltDato}";

        }


    }
}
