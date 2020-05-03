using System;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SET_project.PageObject;

namespace SET_project.Tests
{
    [TestFixture]
    public class LoginTest
    {

        private IWebDriver driver;
        private LoginPage loginPage;
        private string url = "http://52.177.12.77:8080/en/login?back=my-account";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            
            loginPage  = new LoginPage(driver);
        }

        [Test]
        public void LoginWithEmptyField()
        {
           LoginPage newLoginPage = loginPage.ClickSignIn("", "");
           string error = newLoginPage.ErorField();
           //Assert.Throws() 
           Console.WriteLine(error);


        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}