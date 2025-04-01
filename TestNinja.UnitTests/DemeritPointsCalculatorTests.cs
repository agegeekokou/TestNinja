using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {         
            var demeritPoint = new DemeritPointsCalculator();

            Assert.That(() => demeritPoint.CalculateDemeritPoints(speed), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenSpeedLessSpeedLimit_ReturnZero(int speed, int expectedResult)
        {
            // Arrange
            var demeritPoint = new DemeritPointsCalculator();

            //Act
            var points = demeritPoint.CalculateDemeritPoints(speed);

            // Assert
            Assert.That(points, Is.EqualTo(expectedResult));
        }
    }
}
