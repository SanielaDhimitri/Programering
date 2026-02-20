namespace WebApplication3.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string Adresse { get; set; }
        public string Phone { get; set; }

        public Member() { }
        public Member(int memberId, string memberName, string adresse, string phone)
        {
            MemberId = memberId;
            MemberName = memberName;
            Adresse = adresse;
            Phone = phone;
        }
    }
}
