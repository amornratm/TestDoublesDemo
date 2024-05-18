using System;
using Xunit;

namespace MemberSpy
{
    public class MemberTest
    {
        [Fact(DisplayName = "เมื่อผู้ใช้งานล็อกอินเข้าสู่ระบบถ้ามีการ CheckAuthorize 2 ครั้ง ให้ checkAuthorizeWasCalled=2")]
        public void Member_WhenCalledCheckAuthorizeTwice_ShouldReturnCheckAuthorizeWasCalledEqual2()
        {
            //AAA Pattern
            //1. Arrange
            SpyAuthorize spy = new SpyAuthorize();
            Member member1 = new Member(spy);
            Member member2 = new Member(spy);

            //2. Action
            string is_authorized = member1.Profile();

            //3. Assert
            Assert.Equal(2, spy.checkAuthorizeWasCalled);
        }

    }
}