using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public interface IValidate
    {
        void Validate();
    }
}
//Fordi metoden ikke skal returnere noget – den skal enten gå godt eller kaste en exception.