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
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            // Act
            var result = controller.GetCustomer(0);

            // Assert
            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            // Act
            var result = controller.GetCustomer(1);

            // Assert
            // NotFound
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
