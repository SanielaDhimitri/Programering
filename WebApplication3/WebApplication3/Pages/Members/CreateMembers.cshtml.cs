using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;
using WebApplication3.Models.Repositories;

namespace WebApplication3.Pages.Members
{
    public class CreateMembersModel : PageModel
    {
        public Member Member { get; set; } = new Member();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            MemberRepo.AddMember(Member);
        }
    }
}
