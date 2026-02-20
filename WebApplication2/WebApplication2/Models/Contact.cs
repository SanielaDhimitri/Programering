namespace WebApplication2.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact()
        {
        }
        public Contact(string name,string adresse, string email, string phone)
        {
            Name = name;
            Adresse = adresse;
            Email = email;
            Phone = phone;
        }
    }
}
