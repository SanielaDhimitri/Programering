using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeakTest
{
    public class Cow : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Muuh!");
        }
    
    }
}
