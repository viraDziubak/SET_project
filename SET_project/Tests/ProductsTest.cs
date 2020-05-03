
using SET_project.PageObject;
using NUnit.Framework;

namespace SET_project.Tests
{
    [TestFixture]
    public class ProductsTest : BaseTest
    {

        private Header header;

        [OneTimeSetUp]
        public void OneTimeSetUp() => header = new Header(Driver);
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void Test_Choose_Prices_Drop()
        {
            ProductsPage changePageTest = header.Choose_Prices_Drop();

        }
        public void Test_Choose_New_Products()
        {
            ProductsPage changePageTest = header.Choose_New_Products();

        }
        public void Test_Choose_Best_Sales()
        {
            ProductsPage changePageTest = header.Choose_Best_Sales();

        }

    }
}
