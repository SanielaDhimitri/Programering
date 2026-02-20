using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using WebApplication3.Models;
using WebApplication3.Models.Repositories;


namespace WebApplication3.Pages.Members
{
    public class GetAllMembersModel : PageModel
    {
        public List <Member>? _members;
        public void OnGet()
        {
            _members = MemberRepo._member.Values.ToList(); 
        }
    }
}
