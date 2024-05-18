using System.Reflection.Metadata;

namespace MemberFake
{
    public interface IMemberRepository
    {
        Member GetMemberById(string id);
        IEnumerable<Member> GetAllMembers();

        void AddMember(Member member);

        void SaveChanges();
    }
}