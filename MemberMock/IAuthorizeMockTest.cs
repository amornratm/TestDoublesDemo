using System;
using Xunit;
using Moq;

namespace MemberMock
{
    public class MemberTest
    {
        [Fact(DisplayName = "เมื่อผู้ใช้งานล็อกอินเข้าสู่ระบบถ้ามีการ CheckAuthorize แล้วให้ VerifyCheckAuthorize=True และแสดงข้อความ Welcome to member area")]
        public void Member_WhenCalledCheckAuthorize_ShouldReturnVerifyCheckAuthorizeIsTrueAndWelcomeToMemberArea()
        {
            //AAA Pattern
            //1. Arrange
            MockAuthorize mock = new MockAuthorize();
            Member member = new Member(mock);

            //2. Action
            string is_authorized = member.Profile();

            //3. Assert
            Assert.True(mock.VerifyCheckAuthorize());
            Assert.Equal("Welcome to member area", is_authorized);
        }

        [Fact(DisplayName = "เมื่อผู้ใช้งานล็อกอินเข้าสู่ระบบถ้ามีการ CheckAuthorize แล้วให้ VerifyCheckAuthorize=True และแสดงข้อความ Welcome to member area โดยใช้ Moq")]
        public void Member_WhenCalledCheckAuthorize_ShouldReturnVerifyCheckAuthorizeIsTrueAndWelcomeToMemberArea_UsingMoq()
        {
            //AAA Pattern
            //1. Arrange
            var mock = new Mock<IAuthorize>();
            mock.Setup(auth => auth.CheckAuthorize(It.IsAny<string>(), It.IsAny<string>())).Returns(true).Verifiable();

            //2. Action
            Member member = new Member(mock.Object);

            //3. Assert
            mock.Verify(auth => auth.CheckAuthorize(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}