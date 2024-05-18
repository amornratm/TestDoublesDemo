using System;

namespace MemberSpy
{
    public class Member
    {
        Boolean authorized;

        public Member(IAuthorize authorize) {
            this.authorized = authorize.CheckAuthorize("amornrat", "1234");
        }

        public string Profile() {
            if(this.authorized)
                return "Welcome to member area";

            return "This not member area";
        }
    }
}