namespace WebApplication3.Models.Repositories
{
    public class MemberRepo
    {
        public static Dictionary<int, Member> _member = new Dictionary<int, Member>()
        {
            { 1, new Member(1,"Anna","Jægersborgvej","123456")},
        { 2,new Member(2,"Emy","Cædervanger","123412")}
        };
        public static void AddMember(Member member)
        {
            _member.Add(member.MemberId, member);
        }
        public static void RemoveMember (int memberId)
            {
            _member.Remove(memberId);
            }
    }
}
