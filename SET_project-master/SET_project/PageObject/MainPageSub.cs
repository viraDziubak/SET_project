using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public class MainPageSub : PageObjectBase
    {
        public MainPageSub(IWebDriver driver) : base(driver)
        {
        }

        private static readonly By EmailField = By.Name("email");

        public MainPageSub ClickOnMailField()
        {
            Driver.FindElement(EmailField).Clear();
            Driver.FindElement(EmailField).Click();
            Driver.FindElement(EmailField).SendKeys(text);
            
        }
    }
}