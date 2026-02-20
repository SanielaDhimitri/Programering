using boatTest.Models;
using boatTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace boatTest.Pages.Boats
{
    public class DeleteBoatModel : PageModel
    {
        private readonly InterfaceBoat _boatService;

        public DeleteBoatModel(InterfaceBoat boatService)
        {
            _boatService = boatService;
        }

        [BindProperty]
        public Boat? Boat { get; set; }

        public IActionResult OnGet(int id)
        {
            Boat = _boatService.GetBoatById(id);
            if (Boat == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var existing = _boatService.GetBoatById(id);
            if (existing == null)
                return NotFound();

            _boatService.RemoveBoat(id);
            return RedirectToPage("/Boats/GetAllBoats");
        }
    }
}