using System.Reflection.Metadata;
using System.Web.Http;

namespace MemberFake
{
    internal class MemberControllerWithRepository
    {
        private readonly IMemberRepository _repository;

        public MemberControllerWithRepository(IMemberRepository repository)
            => _repository = repository;

        [HttpGet]
        public Member GetMemberById(string id)
            => _repository.GetMemberById(id);
    }
}