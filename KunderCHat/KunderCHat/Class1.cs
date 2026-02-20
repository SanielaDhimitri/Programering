using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class Kunde
    {
        public int Id { get; }
        public string Name { get; set; }

        public Kunde(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"Id: {Id}, Name: {Name}";
    }


