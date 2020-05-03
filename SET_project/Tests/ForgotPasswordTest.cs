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

        [TestCase(false, "test@gmail.com")]
        [TestCase(true, "testmail")]
        public void Test2(bool isPositive, string email)
        {
            bool isEmailOk = _mainPageTwo.ClickToSignIn().ClickForgotButton().EnterMail(email).IsMailOk();
            Assert.That(isEmailOk, Is.EqualTo(isPositive), $"Email was validated {(isEmailOk ? "successfully" : "unsuccessfully")}"
                                                           + " but were expected opposite");
        }
    }
}