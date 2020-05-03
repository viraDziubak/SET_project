using System;
using System.Linq;
using System.Net.Configuration;
using OpenQA.Selenium;
using SET_project.Frameworks;

namespace SET_project.PageObject
{
    public class MainPage : PageObjectBase
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        private static readonly By SingInButon = By.XPath("//*[@id='_desktop_user_info']/div/a/span");
        private static readonly By ForgotPasswordButton =  By.CssSelector("#login-form > section > div.forgot-password > a");
        private static readonly By EmailField = By.Id("email");
        private static readonly By GoodMailField = By.XPath("//*[@id='content']/ul/li/i/svg/path");
        public MainPage ClickToSignIn()
        {
            Driver.FindElement(SingInButon).Click();
            return this;
        }

        public MainPage ClickForgotButton()
        {
            Driver.FindElement(ForgotPasswordButton).Click();
            return this;
        }

        public MainPage EnterMail(string email)
        {
            Driver.FindElement(EmailField).Clear();
            Driver.FindElement(EmailField).Click();
            Driver.FindElement(EmailField).SendKeys(email);
            Driver.FindElement(EmailField).SendKeys(Keys.Enter);
            return this;
        }

        public bool IsMailOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(GoodMailField).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }
    }
}