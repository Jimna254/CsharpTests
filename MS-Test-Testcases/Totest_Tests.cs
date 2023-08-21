using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearningC_.Classes_to_Test;

namespace MS_Test_Testcases
{
    [TestClass]
    public class Totest_Tests
    {
        [TestMethod]
        public void Greet_WhenCalled_Return_myFirstTest()
        {
            // Arrange
            Totest totest = new Totest();

            // Act
            string result = totest.Greet();

            // Assert
            Assert.AreEqual("myFirstTest", result);
        }
    }
}