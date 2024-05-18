using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoubleDemo
{
    public class Member
    {
        Boolean authorized;

        public Member(IAuthorize authorize)
        {
            this.authorized = authorize.CheckAuthorize("ifew", "1234");
        }

        public string Profile()
        {
            if (this.authorized)
                return "Welcome to member area";

            return "This not member area";
        }
    }
}
