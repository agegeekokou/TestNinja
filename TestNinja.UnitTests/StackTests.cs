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
    public class StackTests
    {

        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddObjToStack()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithObjects_ReturnObjectOnTheTop()
        {
            // Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("yellow");
            stack.Push("black");
            stack.Push("cyan");

            // Act
            var result = stack.Pop();

            // Assert
            Assert.That(result, Is.EqualTo("cyan")); 
        }

        [Test]
        public void Pop_StackWithObjects_RemoveObjectFromTheTop()
        {
            // Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("yellow");
            stack.Push("black");
            stack.Push("cyan");

            // Act
            stack.Pop();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTheTopOfTheStack()
        {
            // Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("yellow");
            stack.Push("black");
            stack.Push("cyan");

            // Act
            var result = stack.Peek();

            // Assert
            Assert.That(result, Is.EqualTo("cyan"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveObjectFromTheTopOfTheStack()
        {
            // Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("yellow");
            stack.Push("black");
            stack.Push("cyan");

            // Act
            stack.Peek();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
