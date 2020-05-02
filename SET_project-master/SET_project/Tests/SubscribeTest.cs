using NUnit.Framework;
using SET_project.PageObject;

namespace SET_project.Tests
{
    public class SubscribeTest : BaseTest
    {
        private MainPageSub _mainPageTwo;
        [OneTimeSetUp]
        public void OneTimeSetUp() => _mainPageTwo = new MainPageSub(Driver);
        
    }
}