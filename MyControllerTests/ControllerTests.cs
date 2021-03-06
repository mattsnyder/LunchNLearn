
using ControllerTests.Fakes.Stacks;
using MyController;
using MyControllerTests.Fakes.Stacks;
using NUnit.Framework;
using Rhino.Mocks;

namespace ControllerTests
{
    [TestFixture]
    public class ControllerTests
    {
        [Test]
        public void attempt_to_save_a_value_when_stack_is_full()
        {
            MockRepository mocks = new MockRepository();
            IView mockedView = mocks.CreateMock<IView>();

            using (mocks.Record())
            {
                mockedView.WriteLine("Stack is full.");
            }

            using (mocks.Playback())
            {
                Controller controller = new Controller(new FullStack(), mockedView);
                controller.Save(5);
            }
        }

        [Test]
        public void next_test()
        {
            MockRepository mocks = new MockRepository();
            IView mockedView = mocks.CreateMock<IView>();

            using (mocks.Record())
            {
                mockedView.WriteLine("value was pushed");
            }
            using (mocks.Playback())
            {
                Controller controller = new Controller(new DumbStack(), mockedView);
                controller.Save(5);
            }
            
        }
    }

   
}
