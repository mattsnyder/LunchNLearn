
namespace MyController
{
    public class Controller
    {
        private readonly IMyStack _stack;
        private readonly IView _view;

        public Controller(IMyStack stack, IView view)
        {
            _stack = stack;
            _view = view;
        }

        public void Save(int value)
        {
            try
            {
                _stack.Push(0);
                _view.WriteLine("value was pushed");
            }
            catch (MyStackIsFullExcpetion)
            {
                
                _view.WriteLine("Stack is full.");
            }
        }
    }
}
