using System;
using Xunit;

namespace MemberDummy
{
    public class MemberTest
    {
        [Fact(DisplayName ="เมื่อผู้ใช้ล็อกอินเข้าสู่ระบบให้แสดงประเภทผู้ใช้งานว่าเป็นสมาชิกหรือไม่")]
        public void Member_WhenCalled_ShoudReturnIsMemberType() {

            //AAA Pattern
            //1. Arrange
            Member member = new Member(new DummyAuthorize());

            //2. Action

            //3. Assert
            Assert.IsType<Member>(member);
        }
    }
}