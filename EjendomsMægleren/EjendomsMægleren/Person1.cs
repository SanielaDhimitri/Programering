using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
namespace EjendomsMægleren
    {
        internal class Person
        {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
            public string Telefon { get; set; }

            public Person( int id, string navn, string adresse, string email, string telefon)
            {
                Navn = navn;
            ID = id;
            Adresse = adresse;
                Email = email;
                Telefon = telefon;
            }

            public override string ToString()
        {
            return $" ID: {ID}, Navn: {Navn}, Adresse: {Adresse},Email: {Email}, Telefon: {Telefon}";
            }
        }
    }
