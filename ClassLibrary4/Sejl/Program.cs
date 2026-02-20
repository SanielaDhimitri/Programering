using System;
using ClassLibrary4;
using ClassLibrary4.Rep;

namespace Sejl
{
    public class Program
    {
        static void Main()
        {
            SejlApp sejlApp = new SejlApp();
            sejlApp.Run();
        }
    }
}



///start program
//kalder SejlKlubApp klassen og dens Run metode
//static= uden at bygge new objekt(program p = new program
//main=start programmet

// static = tilhører klassen
// ikke -static = tilhører objektet
//ike Validate i PROG forUI må ikke kende forretningsregler Regler skal ligge i domæneklassen