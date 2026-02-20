using System.ComponentModel.DataAnnotations;

namespace boatTest.Models
{
    public class Member
    {
        [Display(Name = "Medlem ID")]
        [Required(ErrorMessage = "Der skal angives et ID til Medlem")]
        [Range(typeof(int), minimum: "0", maximum: "100000", ErrorMessage = "Id skal være mellem{1} og {2}")]
        public int Id { get; set; }

        [Display(Name = "Medlem Navn")]
        [Required(ErrorMessage = "Medlem skal have et navn"), MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Medlem skal have et Adresse"), MaxLength(20)]
        public string Adresse { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Der skal angives TelefonNummer")]
        
        public string Phone { get; set; }

        [Display(Name = "Medlem Alder")]
        [Required(ErrorMessage = "Der skal angives Aldrene")]
        [Range(typeof(int), minimum: "0", maximum: "100", ErrorMessage = "Aldrene skal være mellem{1} og {2}")]
        public int Age { get; set; }

        public Member() { }
        public Member(int id, string name, string adresse, string phone, int age)
        {
            Id = id;
            Name = name;
            Adresse = adresse;
            Phone = phone;
            Age = age;
        }


    }
}
