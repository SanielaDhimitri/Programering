using boatTest.Models;

namespace boatTest.MockData
{
    public class MockBoat
    {
        public static List<Boat> _boat = new List<Boat>()
       {
            new Boat(1, "Sea Breeze", "Sailboat", 2010,222),
            new Boat(2, "Wave Rider", "Motorboat", 2015, 1299),
            new Boat(3, "Ocean King", "Yacht", 2020,2000)
        };
        public static List <Boat> GetMockBoats()
        {
            return _boat;
        }
    }
}

//Fake klase=Nuk po e ruan, po e rikrijon