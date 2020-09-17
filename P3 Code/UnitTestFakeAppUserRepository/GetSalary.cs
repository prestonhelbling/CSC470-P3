using System;
using System.Deployment.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3_Code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class GetSalary
    {
        [TestMethod]
        public void GetSalaryWhenGoodIdCorrect()
        {
            //Arrange
            const int ID = 1;
            FakeAppUserRepository IAppUser = new FakeAppUserRepository();

            //Act

            //Assert
        }
    }
}
