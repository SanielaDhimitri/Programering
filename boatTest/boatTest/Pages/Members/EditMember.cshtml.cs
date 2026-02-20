using boatTest.Models;
using boatTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace boatTest.Pages.Members
{
    public class EditMemberModel : PageModel
    {
        private InterfaceMember _memberService;   //field qe ta perdorim ne metoder
        public EditMemberModel(InterfaceMember memberService)
        {
            _memberService = memberService;
        }

        [BindProperty]
        public Models.Member Member { get; set; }   //objekt=member qe do te mbushet me te dhenat e anetarit qe duam te editonim dhe do te perdoret ne view per te shfaqur te dhenat e vjetra dhe per ti marre te dhenat e reja nga forma



        public IActionResult OnGet(int id) //metoda qe zgjedh medlem per editim, merr id e anetarit qe duam te editonim dhe e mbush objektin member me te dhenat e tij per ti shfaqur ne view
        {
            Member = _memberService.GetMemberById(id);
            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost() // metoda qe do te thirret pas editimit te anetarit
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _memberService.UpdateMember(Member);
            return RedirectToPage("/Members/GetAllMembers");
        }
    }
}
