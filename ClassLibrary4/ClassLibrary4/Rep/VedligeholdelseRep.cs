using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using ClassLibrary4;

namespace ClassLibrary4.Rep
{
    public class VedligeholdRep
    {
        private List<Vedligeholdelse> _service = new List<Vedligeholdelse>();

        // CASE = 5
        public void Add(Vedligeholdelse v)
        {
            v.Validate();
            _service.Add(v);
        }

        // CASE = 6
        public List<Vedligeholdelse> GetAll()
        {
            if (_service.Count == 0)
                throw new Exception("Der er ingen vedligeholdelser i systemet.");

            return new List<Vedligeholdelse>(_service);
        }

        // CASE = 19
        public Vedligeholdelse GetLatestServiceForBoat(int bådId)
        {
            Vedligeholdelse latest = null;

            foreach (Vedligeholdelse s in _service)
            {
                if (s.Båd != null && s.Båd.BådId == bådId)
                {
                    if (latest == null || s.SidsteService > latest.SidsteService)
                        latest = s;
                }
            }

            return latest;
        }
    }
}
