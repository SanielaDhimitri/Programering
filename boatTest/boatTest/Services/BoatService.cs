using boatTest.Models;
using boatTest.Pages.Boats;

namespace boatTest.Services
{
    public class BoatService: InterfaceBoat
    {
        private List<Boat> _boats;

        public BoatService()
        {
            _boats = MockData.MockBoat.GetMockBoats();
        }

        public List<Boat> GetAllBoats()
        {
            return _boats;
        }

        public void AddBoat(Boat boat)
        {
            _boats.Add(boat);
        }

        public void UpdateBoat(Boat updatedBoat)
        {
            foreach (var boat in _boats)
            {
                if (boat.BoatId == updatedBoat.BoatId)
                {
                    boat.Name = updatedBoat.Name;
                    boat.Type = updatedBoat.Type;
                    boat.Year = updatedBoat.Year;
                    boat.Price = updatedBoat.Price;
                    return;
                }
            }
        }
        public void RemoveBoat(int boatId)                        //  JO static
        {
            for (int i = 0; i < _boats.Count; i++)
            {
                if (_boats[i].BoatId == boatId)
                {
                    _boats.RemoveAt(i);
                    return; // ndalon këtu
                }
            }
        }

        public Boat GetBoatById(int id)
        {
            foreach (var boat in _boats)
            {
                if (boat.BoatId == id)
                {
                    return boat;
                }
            }

            return null;
        }
        public IEnumerable<Boat> SearchBoat(string searchString)
        {
            List<Boat> searchBoat = new List<Boat>();

            foreach (Boat boat in _boats)
            {
                if (boat.Name.ToLower().Contains(searchString.ToLower()))
                    searchBoat.Add(boat);
            }

            return searchBoat;
        }

        public IEnumerable<Boat> SearchPrice(double maxPrice, double minPrice = 0)
        {
            List<Boat> searchPrice = new List<Boat>();
            foreach(Boat boat in _boats)
            {
                if(minPrice==0 && boat.Price<=maxPrice)
                    searchPrice.Add(boat);   
            }
            return searchPrice;
        }
    }

}
