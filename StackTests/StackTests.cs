using System;
using NUnit.Framework;
using Stack;

/*
 * Supports push
 * Pop returns last object pushed
 * Can ask if empty
 * Limit to ten items (throw ex if push when full)
 * throw ex if pop and is empty
 * 
 */

namespace StackTests
{
    [TestFixture]
    public class StackTests
    {
        private MyStack _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new MyStack();
        }

        [Test, ExpectedException(typeof(Exception))]
        public void pop_an_empty_stack_throws_exception()
        {
            _stack = new MyStack();

            _stack.pop();
        }

        [Test]
        public void push_and_pop_returns_pushed_object()
        {
            _stack.push(1);
            int result = (int) _stack.pop();
            Assert.That(result, Is.EqualTo(1));
        }




        [Test]
        public void push_two_values_pop_returns_last_pushed_value()
        {
            _stack.push(1);
            _stack.push(2);
            int result = (int) _stack.pop();
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void push_twice_and_popping_twice_returns_first_push()
        {
            _stack.push(1);
            _stack.push(2);
            _stack.pop();
            int result = (int)_stack.pop();
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
