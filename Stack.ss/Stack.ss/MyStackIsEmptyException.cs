using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.ss
{
  public class MyStackIsEmptyException:Exception
    {
        public MyStackIsEmptyException(string message)
            : base(message) { }
    }
}
