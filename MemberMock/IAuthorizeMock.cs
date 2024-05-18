using System;

namespace MemberMock
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

    //Mock ไม่ได้สนใจผลลัพธ์ปลายทาง แต่สนใจการทำงานของสิ่งที่ต้องการทดสอบ 
    public class MockAuthorize : IAuthorize
    {
        public Boolean checkAuthorizeWasCalled = false;

        public Boolean CheckAuthorize(string username, string password)
        {
            checkAuthorizeWasCalled = true;
            return true;
        }

        public Boolean VerifyCheckAuthorize()
        {
            return checkAuthorizeWasCalled;
        }
    }
}