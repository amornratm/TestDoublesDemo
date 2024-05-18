using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MemberFake
{
    public class MemberRepository : IMemberRepository
    {
        private readonly MemberContext _context;

        public IEnumerable<Member> GetAllMembers() { return _context.Members; }

        public Member GetMemberById(string id)
            => _context.Members.FirstOrDefault(e => e.Id.ToString() == id);

        public void AddMember(Member member)
        {
            _context.Members.Add(member);
        }

        public void SaveChanges() { }

    }
}
