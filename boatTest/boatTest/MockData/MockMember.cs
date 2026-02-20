using boatTest.Models;

namespace boatTest.MockData
{
    public class MockMember
    {
        public static List<Member> _member = new List<Member>()
    {
         new Member(1, "Anna", "Jægersborgvej", "123456",22) ,      //ne dictionary fillojme me 1, 2, 3, 4, 5, mm
         new Member(2, "Peter", "Nørrebrogade", "234567",33) ,
         new Member(3, "Maria", "Østerbrogade", "345678",44) ,
         new Member(4, "Ali", "Vesterbrogade", "456789",55) ,
         new Member(5, "Sara", "Amagerbrogade", "567890",66)
    };
     
        public static List<Member> GetMockMembers()
        {
            return new List<Member>(_member);
        }
    }
}
