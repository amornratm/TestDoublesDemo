using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using Xunit;
using Moq;

namespace MemberFake
{
    public class MemberTest
    {
        [Fact(DisplayName = "เมื่อผู้ใช้งานล็อกอินเข้าสู่ระบบรหัสสมาชิก 1 ให้แสดงชื่อสมาชิก amornrat โดย GetMemberById จากฐานข้อมูล")]
        public void Member_WhenCalledThenGetMemberByIdEqual1_ShouldReturnMemberNameEqualAmornrat()
        {
            //AAA Pattern
            //1. Arrange
            var repositoryMock = new Mock<IMemberRepository>();
            repositoryMock
                .Setup(r => r.GetMemberById("1"))
                .Returns(new Member { Fullname = "amornrat", Card_no = "123456789", Birthday= new DateTime(1980, 01, 01),Mobilephone= "0812345678" });

            var controller = new MemberControllerWithRepository(repositoryMock.Object);

            //2. Action
            var member = controller.GetMemberById("1");

            //3. Assert
            repositoryMock.Verify(r => r.GetMemberById("1"));
            Assert.Equal("amornrat", member.Fullname);

        }
    }
}