using boatTest.Models;

namespace boatTest.Services
{
    public interface InterfaceMember
    {
        List<Member> GetAllMembers();
        void AddMember(Member member);
        void UpdateMember(Member updateMember);
        void RemoveMember(int id);
        Member GetMemberById(int id);
        IEnumerable<Member> SearchMember(string searchString);
        IEnumerable<Member> SearchByAge (int maxAge, int minAge);


    }
}
