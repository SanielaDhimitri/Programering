
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøbCykle
{
    public class Program

    {
        public static void Main(string[] args)
        {


            Butik butik = new Butik("Frank", "125678", "sad004@ede.dk", "Jægersborgvej");
            Console.WriteLine(" Butik Informationer");
            Console.Write(butik.ToString());

       


            Kunder kunde = new Kunder("Anna", 87654321, "11111111", "das004@edu.dk", "Cedervænger");
            Console.WriteLine(" Kunde Profil");
            Console.WriteLine(kunde.ToString());
            Console.ReadKey();

        }
    }

}