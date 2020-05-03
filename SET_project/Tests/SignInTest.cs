using NUnit.Framework;
using SET_project.PageObject;
 
namespace SET_project.Tests
{
    [TestFixture]
    public class SignInTest : BaseTest
    {
        private SignInPage _header;
            [OneTimeSetUp]
            public void OneTimeSetUp() => _header = new SignInPage(Driver);

            [TestCase(true, "test@gmail.com", "12345")]
            [TestCase(false, "test1@gmail.com", "12345")]
            public void AuthorizedTest(bool isPositive, string email, string password)
            {
                bool isSignInOk = _header.ClickToSignIn().EnterMail(email).EnterPassword(password).IsUserAuthorized();
                Assert.That(isSignInOk, Is.EqualTo(isPositive), $"Sign in was {(isSignInOk ? "successfully" : "unsuccessfully")}"
                                                               + " but were expected opposite");
            }
        
    }
}