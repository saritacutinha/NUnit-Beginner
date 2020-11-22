using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class FizzBuzzTests
    {   [Test]
        [TestCase(15)]
        public void GetOutput_DivisibleByBoth_ReturnsFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);
        }

        [Test]
        [TestCase(3)]
        public void GetOutput_DivisibleByThree_ReturnsFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);
        }
        
        [Test]
        [TestCase(5)]
        public void GetOutput_DivisibleByFive_ReturnsBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("Buzz").IgnoreCase);
        }
         
        [Test]
        [TestCase(8)]
        public void GetOutput_NotDivisibleByBoth_ReturnsNumberInString(int number)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(number.ToString()));
        }

    }
}
