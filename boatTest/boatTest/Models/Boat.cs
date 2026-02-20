using System.ComponentModel.DataAnnotations;

namespace boatTest.Models
{
    public class Boat
    {
        [Display(Name = "Boat ID")]
        [Required(ErrorMessage = "Der skal angives et ID til Item")]
        [Range(typeof(int), minimum: "0", maximum: "10000", ErrorMessage = "Id skal være mellem{1} og {2}")]
        public int? BoatId { get; set; }

        [Display(Name = "Boat Navn")]
        [Required(ErrorMessage = "Boat skal have et navn"), MaxLength(20)]
        public string? Name { get; set; }

        [Display(Name = "Boat Type")]
        [Required(ErrorMessage = "Boat skal have et type"), MaxLength(20)]
        public string? Type { get; set; }

        [Display(Name = "Boat Year")]
        [Required(ErrorMessage = "Der skal angives et Year")]
        [Range(typeof(int), minimum: "0", maximum: "10000", ErrorMessage = "Year skal være mellem{1} og {2}")]
        public int? Year { get; set; }

        [Display(Name = "Boat Price")]
        [Required(ErrorMessage = "Der skal angives Price ")]
        [Range(typeof(double), minimum: "0", maximum: "10000", ErrorMessage = "Price skal være mellem{1} og {2}")]
        public double? Price { get; set; }

        public Boat() { }

        public Boat(int boatId, string name, string type, int year, double price)
        {
            BoatId = boatId;
            Name = name;
            Type = type;
            Year = year;
            Price = price;
        }

    }
}

  