using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack
    {
        private List<int> _values= new List<int>();

        public object pop()
        {
            if (_values.Count == 0) throw new Exception();

            int result = _values[_values.Count - 1];
            _values.RemoveAt(_values.Count - 1);
            return result;
        }

        public void push(int value)
        {
            _values.Add(value);
        }
    }
}
