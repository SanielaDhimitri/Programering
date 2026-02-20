using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary8.Repo
{
    public class BådRepo
    {
        private List<Båd> båder = new List<Båd>();
        public BådRepo()

        {
            AddBåd(new Båd(11));//new objekt= kalder add metoden til at tilføje både til repository
            AddBåd(new Båd(1));//= 4 varieble ikke 5=BådType bliver sat automatisk(subklas).
            AddBåd(new Båd(13));
            AddBåd(new Båd(14));
            AddBåd(new Båd(15));

        }
        public void AddBåd(Båd båd)
        {
            båder.Add(båd);
        }
        public List<Båd> GetAllBåder()
        {
            return båder;
        }
    }
}
