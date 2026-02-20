using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using boatTest.Models;

using boatTest.Services;
namespace boatTest.Pages.Boats
{
    public class CreateBoatsModel : PageModel
    {
        private InterfaceBoat _boatService;            /* një fushë private (private field) që mban një instancë të BoatService*/
        public CreateBoatsModel(InterfaceBoat boatService)
        {
            _boatService = boatService;

        }

        [BindProperty]
        public Models.Boat Boat { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)//kontroller
            {
                return Page();
            }
            _boatService.AddBoat(Boat);
            return RedirectToPage("/Boats/GetAllBoats");
        }
    }
}
