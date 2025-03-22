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
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formater = new HtmlFormatter();

            var result = formater.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
        }
    }
}
