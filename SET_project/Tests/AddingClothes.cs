using NUnit.Framework;
using SET_project.PageObject;

namespace SET_project.Tests
{
    
    public class AddingClothes : BaseTest
    {
        private MainPageAddClothes _mainPage;
        [OneTimeSetUp]
        public void OneTimeSetUp() => _mainPage = new MainPageAddClothes(Driver);
        
        [TestCase()]
        public void Test()
        {
            bool end = _mainPage.ClickToClothesButton().ClickAddToCard().ClickToAcceptAdding().IsCardNoEmpty();
        }
    }
}