using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjendomsMægleren
{
    public enum EjendomType
    {
        Villa,
        Lejlighed,
        Ejerlejlighed,
        Rækkehus,
        Sommerhus
    }
    internal class Ejendom
    {
        public int ID { get; set; }
        public EjendomType Type { get; set; }
        public string Adresse { get; set; }
        public int Pris { get; set; }
        public double Størrelse { get; set; }



        public Ejendom(int id, EjendomType type, string adresse, int pris, double størrelse)
      
            {
                ID = id;
                Type = type;
                Adresse = adresse;
                Pris = pris;
                Størrelse = størrelse;
            }
        
        public override string ToString()
        {
            return $"ID: {ID}, Type: {Type}, Adresse: {Adresse}, Pris: {Pris} DKK, "+
                $" Størrelse: {Størrelse} m².";


        }
    }
}
