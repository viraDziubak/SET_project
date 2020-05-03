
using SET_project.PageObject;
using NUnit.Framework;


namespace SET_project.Tests

{
    [TestFixture]
    public class ChangePageTest : BaseTest
    {
        private Header header;

        [OneTimeSetUp]
        public void OneTimeSetUp() => header = new Header(Driver);
        [TestCase()]

        public void Test_Change_Clothes()
        {
           Page changePageTest = header.Change_Clothes();

        }
        public void Test_Change_Accessories()
        {
            Page changePageTest= header.Change_Accessories();

        }

        public void Test_Change_Art()
        {
            Page changePageTest = header.Change_Art();

        }
        public void Test_Change_MyStore()
        {
            Page changePageTest = header.Change_MyStore();

        }

    }

}