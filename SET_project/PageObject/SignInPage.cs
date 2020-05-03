using System;
using System.Linq;
using System.Net.Configuration;
using OpenQA.Selenium;
using SET_project.Frameworks;

namespace SET_project.PageObject
{
    public class SignInPage : PageObjectBase
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        private static readonly By SingInButton = By.XPath("//*[@id='_desktop_user_info']/div/a/span");
        private static readonly By EmailField = By.XPath("//*[@id='login-form']/section/div[1]/div[1]/input");
        private static readonly By PasswordField = By.XPath("//*[@id='login-form']/section/div[2]/div[1]/div/input");
        private static readonly By SuccessSignInClass = By.XPath("//*[@id='_desktop_user_info']/div/a[2]");
        private static readonly By SingOutButton = By.XPath("//*[@id='_desktop_user_info']/div/a[1]");
        public SignInPage ClickToSignIn()
        {
            Driver.FindElement(SingInButton).Click();
            return this;
        }
        
        public SignInPage ClickToSignOut()
        {
            Driver.FindElement(SingOutButton).Click();
            return this;
        }

        public SignInPage EnterMail(string email)
        {
            Driver.FindElement(EmailField).Clear();
            Driver.FindElement(EmailField).Click();
            Driver.FindElement(EmailField).SendKeys(email);
            Driver.FindElement(EmailField).SendKeys(Keys.Enter);
            return this;
        }
        public SignInPage EnterPassword(string password)
        {
            Driver.FindElement(PasswordField).Clear();
            Driver.FindElement(PasswordField).Click();
            Driver.FindElement(PasswordField).SendKeys(password);
            Driver.FindElement(PasswordField).SendKeys(Keys.Enter);
            return this;
        }
        

        public bool IsUserAuthorized()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(SuccessSignInClass).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            if (isOk == true)
            {
                ClickToSignOut();
            }
            return isOk;
        }
    }
}