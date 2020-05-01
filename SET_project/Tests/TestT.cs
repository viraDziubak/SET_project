using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SET_project
{
    [TestFixture]
    public class TestT
    {
        private readonly IWebDriver driver;
        
        private static readonly string url = "http://52.177.12.77:8080";

        public TestT()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Navigate().GoToUrl(url);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
            
        }
        
        [Test]

        public void Test()
        {
            driver.FindElement(By.XPath("/html/body/main/header/div[2]/div/div[1]/div[2]/div[1]/ul/li[3]")).Click();
            driver.FindElement(By.
                XPath("/html/body/main/section/div/div[2]/section/section/div[1]/div/div[2]/div/div[1]/button")).Click();
            driver.FindElement(By.
                XPath("/html/body/main/section/div/div[2]/section/section/div[1]/div/div[2]/div/div[1]/div/a[4]")).Click();

        }
        
    }
}