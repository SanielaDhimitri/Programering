using boatTest.Models;

namespace boatTest.Services
{
    public interface InterfaceBoat
    {
        List<Boat> GetAllBoats();
            void AddBoat(Boat boat);
            void UpdateBoat(Boat updatedBoat);
            void RemoveBoat(int boatId);
            Boat GetBoatById(int boatId);
        IEnumerable<Boat>SearchBoat(string searchstring);
        IEnumerable<Boat> SearchPrice(double maxPrice, double minPrice = 0);
    }
}
