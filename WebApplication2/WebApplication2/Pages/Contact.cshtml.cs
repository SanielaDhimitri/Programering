using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;


namespace WebApplication2.Pages
{
    public class ContactModel : PageModel
    {
        public Contact Contact { get; set; }= new Contact();
        public void OnGet()
        {
        }
    }
}
