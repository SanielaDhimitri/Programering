using boatTest.Models;

using boatTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace boatTest.Pages.Members
{
    public class CreateMembersModel : PageModel
    {
        private InterfaceMember _memberService;
        public CreateMembersModel(InterfaceMember memberService)
        {
            _memberService = memberService;
        }

        [BindProperty]                                     //bind med  property fra  class
        public Models.Member Member { get; set; } 
      
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _memberService.AddMember(Member);
            return RedirectToPage("/Members/GetAllMembers");

        }
    }
}
