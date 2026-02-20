namespace WebApplication3.Models.Repositories
{
    public class BoatRepo
    {
        public static List<Boat> _boat = new List<Boat>()
        {
        new Boat(1,"Anna","MotorBoat"),
        new Boat (2,"Emi","SejlBoat")

        };
        public static void AddBoat(Boat boat)
        {
            _boat.Add(boat);
        }
        public static void RemoveBoat(int boatId)
        {
            for (int i = 0; i < _boat.Count; i++)
            {
                if (_boat[i].BoatId == boatId)
                {
                    _boat.RemoveAt(i);
                    return;
                }
            }
        }
        
    }
}
