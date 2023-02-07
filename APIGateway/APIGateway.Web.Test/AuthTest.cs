using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APIGateway.Web.Test
{
    [TestClass]
    public class AuthTest
    {
        [TestMethod]
        public void Login()
        {
            int a = 2;
            int b = 3;
            int expectedResult = 5;
            int actualResult = a + b;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}