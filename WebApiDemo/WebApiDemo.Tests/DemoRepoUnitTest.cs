using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiDemo.Tests
{
    [TestClass]
    public class DemoRepoUnitTest
    {
        [TestMethod]
        public void Test_Get()
        {
            const int ID_RESULT = 1;

            // Arrange
            var _Repo = new Repositories.DemoRepository();
            // Act
            var expected = new DataModels.EmpDataModel { ID = ID_RESULT, NAME = "詹竣皓" };
            var actual = _Repo.Get(ID_RESULT);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
