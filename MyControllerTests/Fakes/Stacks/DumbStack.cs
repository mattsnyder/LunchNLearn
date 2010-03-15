using System;
using System.Collections.Generic;
using System.Text;
using MyController;

namespace MyControllerTests.Fakes.Stacks
{
    public class DumbStack : IMyStack
    {
        public void Push(int value)
        {
            
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }
    }
}
