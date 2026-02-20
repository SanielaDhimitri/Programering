using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebApplication3.Models;
using WebApplication3.Models.Repositories;

namespace WebApplication3.Pages.Boats
{
    public class GetAllMMembersModel : PageModel
    {
        public List<Boat>?_boats;
        public void OnGet()
        {
            _boats = BoatRepo._boat;

        }
    }
}
