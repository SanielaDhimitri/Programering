namespace WebApplication3.Models
{
    public class Boat
    {
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public string Type { get; set; }
        public Boat() {  }
        public Boat(int boatId, string boatName, string type)
        {
            BoatId = boatId;
            BoatName = boatName;
            Type = type;

        }
    }
}

