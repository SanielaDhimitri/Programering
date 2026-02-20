using boatTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;


namespace boatTest.Services
{
    public class MemberService : InterfaceMember
    {
        private List<Member> _members;

        public MemberService()
        {
            _members = MockData.MockMember.GetMockMembers();
        }

        public List<Member> GetAllMembers()
        {
            return _members;
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
        }
        public void RemoveMember(int Id)
        {
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].Id == Id)
                {
                    _members.RemoveAt(i);
                    return;
                }
            }

        }

        public Member GetMemberById(int Id)
        {
            foreach (Member member in _members)
            {
                if (member.Id == Id)
                {
                    return member;
                }
            }

            return null;
        }
        public void UpdateMember(Member updatedMember)
        {
            foreach (var member in _members)
            {
                if (member.Id == updatedMember.Id)
                {
                    member.Name = updatedMember.Name;
                    member.Adresse = updatedMember.Adresse;
                    member.Phone = updatedMember.Phone;
                    member.Age = updatedMember.Age;
                    return;
                }
            }
        }
        public IEnumerable<Member> SearchMember(string searchString)
        {
            List<Member> searchResults = new List<Member>();
            foreach (var member in _members)
            {
                if (member.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    searchResults.Add(member);
                }
            }
            return searchResults;
        }
        public IEnumerable<Member> SearchByAge(int maxAge, int minAge)
        {
            List<Member> searchResults = new List<Member>();
            foreach (var member in _members)
            {
                if (member.Age >= minAge && member.Age <= maxAge)
                {
                    searchResults.Add(member);
                }
            }
            return searchResults;
        }
    }
}

