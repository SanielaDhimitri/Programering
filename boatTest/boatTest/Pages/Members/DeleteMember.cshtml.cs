using boatTest.Models;
using boatTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace boatTest.Pages.Members
{
    public class DeleteMemberModel : PageModel
    {
        private  readonly InterfaceMember _memberService;

        public DeleteMemberModel(InterfaceMember memberService)
        {
            _memberService = memberService;
        }

        [BindProperty]
        public Member? Member { get; set; }

        public IActionResult OnGet(int id)
        {
            Member = _memberService.GetMemberById(id);

            if (Member == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var existing = _memberService.GetMemberById(id);

            if (existing == null)
                return NotFound();

            _memberService.RemoveMember(id);

            return RedirectToPage("/Members/GetAllMembers");
        }
    }
}







