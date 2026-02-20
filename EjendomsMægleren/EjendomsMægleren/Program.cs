
using System;
using System.Collections.Generic;

namespace EjendomsMægleren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejendom
            Ejendom e1 = new Ejendom(12345, EjendomType.Villa, "Solvej 10", 3500000, 120);
            Ejendom e2 = new Ejendom(54321, EjendomType.Villa, "Solsikkevej 10", 3000000, 150);
            Console.WriteLine($"{e1}\n{e2}\n");

            // Sælgere
            Sælger s1 = new Sælger(45434511, "Ols Isen", "Jægersborgvej 108", "12345699", "ols@mail.com");
            Sælger s2 = new Sælger(45434566, "Hans Hansen", "Jægersborgvej 104", "12345678", "hans@mail.com");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            // Køber
            KøberEmne k = new KøberEmne(23454356, "Maria Jensen", "Cedervanger 12", "44563417", "maria@mail.com",
                                        124, 2600000, EjendomType.Lejlighed);
            Console.WriteLine(k);
            Console.WriteLine();

            // EjendomsRegister
            EjendomsRegister ejendomsRegister = new EjendomsRegister();
            Ejendom hus1 = new Ejendom(10001, EjendomType.Villa, "Solvej 160", 3500000, 120);
            Ejendom hus2 = new Ejendom(10002, EjendomType.Lejlighed, "Nørregade 25", 1800000, 85);

            ejendomsRegister.Add(hus1);
            ejendomsRegister.Add(hus2);
            ejendomsRegister.Add(e1);
            ejendomsRegister.Add(e2);

            Console.WriteLine("\nAlle ejendomme:");
            ejendomsRegister.Udskriv();

            // KøberEmneRegister
            KøberEmneRegister køberRegister = new KøberEmneRegister();
            KøberEmne køber1 = new KøberEmne(20001, "Lars Larsen", "Birkegade 5", "22334455", "san@icloud.com",
                                             80, 2000000, EjendomType.Villa);

            køberRegister.Add(køber1);
            køberRegister.Add(k);

            Console.WriteLine("\nAlle købere:");
            køberRegister.Udskriv();

            // STEP 6: Registrer fremvisning
            køber1.RegistrerFremvisning(hus1);
            køber1.RegistrerFremvisning(hus2);
            køber1.RegistrerFremvisning(hus2); // prøv igen -> "allerede vist"

            Console.WriteLine("\nFremviste ejendomme til Lars:");
            foreach (var ejendom in køber1.HentFremvisteEjendomme())
            {
                Console.WriteLine(ejendom);
            }

            Console.WriteLine("\nTryk Enter for at afslutte...");
            Console.ReadLine();



            // Antag at vi har et EjendomsRegister og en KøberEmne køber1

            // Køber1 søger en lejlighed, min 80 kvm, max 2.000.000 kr.
            Console.WriteLine("\nMatchende ejendomme (ikke fremvist endnu):");
            List<Ejendom> nyeMatches = ejendomsRegister.MatchIkkeFremvist(køber1);

            if (nyeMatches.Count > 0)
            {
                foreach (var e in nyeMatches)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Ingen nye ejendomme fundet til denne køber.");
            }
        }
    }
}