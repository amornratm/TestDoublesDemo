using System;
using Xunit;

namespace MemberStub
{
    public class MemberTest
    {
        [Fact(DisplayName ="เมื่อผู้ใช้งานล็อกอินเข้าสู่ระบบถ้าเป็นสมาชิกให้แสดงข้อความ Welcome to member area")]
        public void Member_WhenCalledAndBeMember_ShouldReturnWelcomeToMemberArea()
        {
            //AAA Pattern
            //1. Arrange
            Member member = new Member(new StubAuthorize());

            //2. Action
            string is_authorized = member.Profile();

            //3. Assert
            Assert.Equal("Welcome to member area", is_authorized);
        }
    }
}