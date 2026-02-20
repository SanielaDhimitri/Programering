using boatTest.Models;
using boatTest.Pages.Boats;
using boatTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;




namespace boatTest.Pages.Members
{
    public class GetAllMembersModel : PageModel
    {
        private InterfaceMember _memberService;
        public GetAllMembersModel(InterfaceMember memberService)   //konstruktori=inicializuar objektin kur krijohet
        {
            _memberService = memberService;
        }

        public List<Models.Member>? _members { get; private set; }               //=property=?=member mund te jete null=ikke eror
       
        public void OnGet()                                           // on get mer data nga repository dhe i View
        {
            _members = _memberService.GetAllMembers();               //_members shfaq te gjitha anetaret nga repository ose mock dhe i dergon ne view
        }

        [BindProperty]
        public string SearchString { get; set; }
        public IActionResult OnPostSearchMember()
        {
            _members = _memberService.SearchMember(SearchString).ToList();
            return Page();
        }


        [BindProperty]
        public int MinAge { get; set; }
        [BindProperty]
        public int MaxAge { get; set; }
        public IActionResult OnPostSearchByAge()
        {
            _members = _memberService.SearchByAge(MaxAge, MinAge).ToList();
            return Page();
        }

    }
}

//Sa herë bën:

//Refresh

//RedirectToPage()

//POST request

//👉 krijohet një PageModel i ri
//👉 property fillon prapë null
//👉 duhet ta mbushësh përsëri në OnGet() ose OnPost()