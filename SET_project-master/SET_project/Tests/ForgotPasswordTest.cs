using NUnit.Framework;
using SET_project.PageObject;

namespace SET_project.Tests
{
    [TestFixture]
    public class ForgotPasswordTest : BaseTest
    {
        private MainPage _mainPageTwo;
        [OneTimeSetUp]
        public void OneTimeSetUp() => _mainPageTwo = new MainPage(Driver);

        [TestCase(true, "test@gmail.com")]
        [TestCase(false, "testmail")]
        public void Test2(string email)
        {
            bool isEmailOk = _mainPageTwo.ClickToSignIn().ClickForgotButton().EnterMail(email).IsMailOk();
            Assert.That(isEmailOk, Is.EqualTo(null), $"Email was validated {(isEmailOk ? "successfully" : "unsuccessfully")}"
                                                     + " but were expected opposite");
        }
    }
}