using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeakTest
{
   public class Dog : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
