using boatTest.Models;
using boatTest.Pages.Boats;
using boatTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace boatTest.Pages.Boats
{

    public class EditBoatModel : PageModel
    {
        private InterfaceBoat _boatService;

        public EditBoatModel(InterfaceBoat boatService)
        {
            _boatService = boatService;
        }
        [BindProperty]
        public Models.Boat Boat { get; set; }

    

        public IActionResult OnGet(int id)
        {
            Boat = _boatService.GetBoatById(id);
            if (Boat == null)
            {
                return NotFound();
            }

            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _boatService.UpdateBoat(Boat);
            return RedirectToPage("/Boats/GetAllBoats");
        }
    }
}