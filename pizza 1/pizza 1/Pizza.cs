using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaAPP
{
    internal class Pizza
    {

        public string ID { get; set; }
        public string Navn { get; set; }
        public int Pris { get; set; }
        public string Størrelse { get; set; }
        public Pizza(string id, string navn, int pris, string størrelse)
        {
            ID = id;
            Navn = navn;
            Pris = pris;
            Størrelse = størrelse;
        }
        public override string ToString()
        { return $"{ID}, {Navn} ({Størrelse}) - {Pris} kr"; }
    }
}
