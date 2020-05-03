using SET_project.PageObject;
using NUnit.Framework;

namespace SET_project.Tests
{
    [TestFixture]
    public class SearchTest : BaseTest
    {
        private Header _header;
            
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _header = new Header(Driver);
            
        }

        [TestCase(true,"mug")]
        [TestCase(false,"qwe134")]
        public void SearchCorrect(bool isCorrect, string searchString)
        {
            bool isSearchCorrect = _header.InputSerachText(searchString).SearchButtonClick().IsSearchOk();
            
            Assert.That(isSearchCorrect, Is.EqualTo(isCorrect), 
                $"Searching works {(isSearchCorrect ? "successfully" : "unsuccessfully")}"+$", but we expected opposite");

        } 
        
    }
    
}