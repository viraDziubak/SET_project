using NUnit.Framework;
using SET_project.PageObject;

namespace SET_project.Tests
{
    public class FilterTest : BaseTest
    {
        private MainPageForFilters _mainPageThree;
        [OneTimeSetUp]
        public void OneTimeSetUp() => _mainPageThree = new MainPageForFilters(Driver);

        [TestCase()]
        public void Test3()
        {
            bool end2 = _mainPageThree.ClickToAllProduct().ClickFirstFilter().IsFilterEmpty();

        }
    }
}