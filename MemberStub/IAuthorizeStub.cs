using System;

namespace MemberStub
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

    //Stub ถูกกำหนดให้คืนค่าต้องการมาตั้งแต่แรก โดยไม่คำนึงถึงองค์ประกอบหรือพฤติกรรมอื่นๆ
    public class StubAuthorize : IAuthorize
    {
        public Boolean CheckAuthorize(string username, string password)
        {
            return true;
        }
    }
}