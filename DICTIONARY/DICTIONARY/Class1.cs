using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICTIONARY
{
    using System;
    using System.Collections.Generic;

    public class Kunde
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Kunde(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Kjo bën që kur ta printosh objektin Kunde, të shfaqet bukur
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

}
