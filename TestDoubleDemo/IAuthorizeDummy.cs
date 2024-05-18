using System;

namespace member_dummy
{
    public interface IAuthorize
    {
        Boolean CheckAuthorize(string username, string password);
    }

    public class Authorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            if(username == "ifew" && password == "1234")
                return true;

            return false;
        }
    }

    public class DummyAuthorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            return new bool();
        }
    }
}