using System;

namespace MemberSpy
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

    //spy จะตรวจสอบว่าเมธอดถูกเรียกใช้งานหรือไม่ และจะเก็บข้อมูลเกี่ยวกับการเรียกใช้งานเมธอด
    public class SpyAuthorize : IAuthorize
    {
        public int checkAuthorizeWasCalled = 0;

        public Boolean CheckAuthorize(string username, string password)
        {
            checkAuthorizeWasCalled++;
            return true;
        }
    }
}