using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LearningC_.Classes_to_Test;
using Assert = NUnit.Framework.Assert;

namespace MyTestcases
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz? fb;
        [SetUp]
        public void SetUp()
        {
            fb = new FizzBuzz();
        }
        [Test]
        public void Print_IfDivisible_ByBoth5and3_ReturnFizzBuzzz()
        {

            var result = fb.Print(15);

            Assert.That(result == "FizzBuzz");
        }
        [Test]

        public void Print_IfDivisible_By5_ReturnBuzz()
        {
            var result = fb.Print(10);

            Assert.That(result == "Buzz");
        }

        [Test]
        public void Print_IfDivisible_By3_ReturnFizz()
        {
            var result = fb.Print(9);

            Assert.That(result == "Fizz");
        }
        [Test]
        public void Print_IfNotDivisible_ByBoth3and5_ReturnTheNumber()
        {
            var result = fb.Print(11);

            Assert.That(result == "11");
        }

        //parameterized Test

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(50, "Buzz")]
        [TestCase(60, "FizzBuzz")]
        [TestCase(13, "13")]
        public void Print_WhenCalledWithDifferentInputs_ReturnTheReleveantString
            (int input, string outcome)
        {
            var result = fb.Print(input);
            Assert.That(result == outcome);
        }
    }
}
