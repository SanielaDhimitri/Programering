namespace ClassLibrary8
{
    public class Båd
    {
        public int Id { get; set; }

        public Båd(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"Båd ID: {Id}";
        }
    }
}
