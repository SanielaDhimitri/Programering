//using boatTest.Pages.Boats;

//namespace boatTest.Models.Repositories
//{
//    public class BoatRepo
//    {
//        public static List<Boat> _boat = new List<Boat>()
//        {
//            new Boat(1, "Sea Breeze", "Sailboat", 2010),
//            new Boat(2, "Wave Rider", "Motorboat", 2015),
//            new Boat(3, "Ocean King", "Yacht", 2020)
//        };

//        public static void AddBoat(Boat boat)
//        {
//            _boat.Add(boat);
//        }
//        public static List<Boat> GetAllBoats()
//        {
//            return new List<Boat>(_boat);
//        }
//        public static void RemoveBoat(int boatId)
//        {
//            for (int i = 0; i < _boat.Count; i++)
//            {
//                if (_boat[i].BoatId == boatId)
//                {
//                    _boat.RemoveAt(i);
//                    return;


//                }

//            }

//        }
//        public static Boat? GetBoatById(int boatId)
//        {
//            foreach (var boat in _boat)
//            {
//                if (boat.BoatId == boatId)
//                {
//                    return boat;
//                }
//            }
//            return null;
//        }
//    }
//}
