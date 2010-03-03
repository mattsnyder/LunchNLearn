using System;
using MyController;

namespace ControllerTests.Fakes.Stacks
{
    class FullStack : IMyStack
    {
        public void Push(int value)
        {
            throw new MyStackIsFullExcpetion();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }
    }
}
