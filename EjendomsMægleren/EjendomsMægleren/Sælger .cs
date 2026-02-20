using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Så laver du Sælger som arver fra Person:
namespace EjendomsMægleren
{
    internal class Sælger : Person
    {


        public Sælger(int id, string navn, string adresse, string email, string telefon)

        : base( id, navn, adresse, email, telefon)

        { }

        public override string ToString()
        {
            return $" ID: {ID}, Navn: {Navn}, Adresse: {Adresse},Email: {Email}, Telefon: {Telefon}";

        }
    }
}