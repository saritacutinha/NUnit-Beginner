using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritsPointsCalculator;

        [SetUp]
        public void SetUp()
        {
            this._demeritsPointsCalculator = new DemeritPointsCalculator();
        }
        [Test]
        [TestCase(-10)]
        [TestCase(380)]
        public void CalculateDemeritPointsTest_SpeedIsOutOfRange_ReturnsArgumentOutOfRangeException(int speed)
        {
                Assert.That(() => 
                 _demeritsPointsCalculator.CalculateDemeritPoints(speed),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(35, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPointsTest_GetsDemerits_ReturnsZero(int speed, int expected)
        {
            var result = _demeritsPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expected));
        }       

    }
}
