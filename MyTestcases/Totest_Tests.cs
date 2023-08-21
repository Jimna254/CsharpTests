using LearningC_.Classes_to_Test;
using Assert = NUnit.Framework.Assert;

namespace MyTestcases
{
    [TestFixture]
    public class HelloTest_Tests
    {
        [Test]
        public void Greet_WhenCalled_ReturnHelloTest()
        {

            //Triple AAA

            //Arrange -create instances , set input 
            var helloTest = new Totest();

            //Act- call the relevant methods
            var result = helloTest.Greet(); 

            //Assert - confirm if the results are what you expected 

            Assert.IsTrue(result == "myFirst Tests");
        }
    }
}