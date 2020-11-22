using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
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
        public void CalculateDemeritPointsTest_SpeedIsLessThanZeroAndGreaterThanMaxSpeed_ReturnsArgumentOutOfRangeException(int speed)
        {
                Assert.That(() => 
                 _demeritsPointsCalculator.CalculateDemeritPoints(speed),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(35)]
        [TestCase(65)]
        public void CalculateDemeritPointsTest_SpeedIsLessThanAndEqualToSpeedLimit_ReturnsZero(int speed)
        {
            var result = _demeritsPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(100)]
        public void CalculateDemeritPointsTest_SpeedWithinRange_ReturnsDemerits(int speed)
        {
            var result = _demeritsPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(7));
        }

    }
}
