using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;
using WebApplication3.Models.Repositories;

namespace WebApplication3.Pages.Boats
{
    public class CreateBoatsModel : PageModel
    {
        [BindProperty]
        public Boat Boat { get; set; } = new Boat();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            BoatRepo.AddBoat(Boat);
        }
    }
}
