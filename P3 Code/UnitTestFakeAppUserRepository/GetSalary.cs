using System;
using System.Deployment.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3_Code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Save
    {
        [TestMethod]
        public void SaveUserWorks()
        {
            //Arrange
            const string First_Name = "Test";
            const string Last_Name = "Case";
            const string Email_Address = "Test@testcase.com";
            FakeAppUserRepository AppUser = new FakeAppUserRepository();

            //Act
            AppUser user = new AppUser();
            user.FirstName = First_Name;
            user.LastName = Last_Name;
            user.EmailAddress = Email_Address;
            int id = FakeAppUserRepository.Save(user);
            AppUser newUser = FakeAppUserRepository.GetByUserName(id);

            //Assert
            Assert.IsTrue(user.FirstName == newUser.FirstName && user.LastName == newUser.LastName && user.EmailAddress == newUser.EmailAddress);
        }

    }
    public class GetEmail
    {
        public void GetEmailWhenIdIsCorrect()
        {
            //Arrange
            const int id = 1;
            const string Expected_Email = "Test@testcase.com";
            FakeAppUserRepository newUser = new FakeAppUserRepository();

            //Act
            string Actual_Email = FakeAppUserRepository.GetEmail(id);

            //Assert
            Assert.AreEqual(Expected_Email, Actual_Email);
        }
    }
}
