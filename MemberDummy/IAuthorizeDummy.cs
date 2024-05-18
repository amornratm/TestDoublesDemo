using System;

namespace MemberDummy
{
    public interface IAuthorize
    {
        Boolean CheckAuthorize(string username, string password);
    }

    public class Authorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            if(username == "amornrat" && password == "1234")
                return true;

            return false;
        }
    }

    //Dummy ไม่สนใจว่ามันทำงานอย่างไร สนใจแค่ว่าสามารถเรียกแล้วทำงานได้
    public class DummyAuthorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            return new bool();
        }
    }
}