using boatTest.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

using boatTest.Services;


namespace boatTest.Pages.Boats
{
    public class GetAllBoatsModel : PageModel  //PageModel=er en base class fra ASP.NET Core:Razor Pages base class
    {
        private InterfaceBoat _boatService;
      
        public GetAllBoatsModel(InterfaceBoat boatService)
        {
            _boatService = boatService;
        }

        public List<Models.Boat>? _boats { get; private set; }  // Kjo është një pronë =Përdoret për: ruajtjen e një liste Item+ shfaqjen e saj në UI(.cshtml)
        public void OnGet()                    //Når siden åbnes
        {
           _boats= _boatService.GetAllBoats();
        }


        [BindProperty]
        public string SearchString { get; set; }

        public IActionResult OnPostSearchBoat()
        {
            _boats = _boatService.SearchBoat(SearchString).ToList();
            return Page();
        }



        [BindProperty]
        public double MaxPrice { get; set; }  


        [BindProperty]


        public double MinPrice { get; set; }
        public IActionResult OnPostSearchPrice()
        {
            _boats = _boatService.SearchPrice( MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}

         