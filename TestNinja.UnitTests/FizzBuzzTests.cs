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
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy3_ReturnFizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetOutput(9);

            // Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy5_ReturnBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetOutput(35);

            // Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetOutput(15);

            // Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_WhenNumberIsNotDivisibleBy3And5_ReturnNumber()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetOutput(2);

            // Assert
            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
