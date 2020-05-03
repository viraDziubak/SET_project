using OpenQA.Selenium;
using SET_project.PageObject;

namespace SET_project.Tests
{
    public class MainPresta
    {
        private IWebDriver driver;

        public MainPresta(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        private By signInButton = By.XPath("//*[@id='_desktop_user_info']/div/a");
        

        public LoginPage clickSignIn()
        {
            driver.FindElement(signInButton).Click();
            return new LoginPage(driver);
        }
    }
}