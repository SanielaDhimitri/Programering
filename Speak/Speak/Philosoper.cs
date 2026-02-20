using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeakTest
{
    public class Philosoper : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Hello World.");
        }
        public void Think()
        {
            Console.WriteLine("I think, there for I am. ");
        }
       
    }
}
