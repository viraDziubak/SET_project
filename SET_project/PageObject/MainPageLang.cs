using System;
using System.Linq;
using SET_project.Frameworks;
using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public class Lang : PageObjectBase
    {
        private static readonly By LangButton = By.XPath("/html/body/main/header/nav/div/div/div[1]/div[2]/div[1]/div/div/button");
        private static readonly By EngLangButton = By.XPath("/html/body/main/header/nav/div/div/div[1]/div[2]/div[1]/div/div/ul/li[1]/a");
        private static readonly By UkrLangButton = By.XPath("/html/body/main/header/nav/div/div/div[1]/div[2]/div[1]/div/div/ul/li[2]/a");
        private static readonly By EngLang = By.XPath("/html/body/main/header/nav/div/div/div[1]/div[2]/div[1]/div/div/select/option[1]");
        private static readonly By UkrLang = By.XPath("/html/body/main/header/nav/div/div/div[1]/div[2]/div[1]/div/div/select/option[2]");
       
        public Lang(IWebDriver driver) : base(driver)
        {
                 
        }
     
        
     
        public Lang LangButtonClick(bool selectEngLang)
        {
            
            Driver.FindElement(LangButton).Click();
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            if (selectEngLang == true)
            {
                Driver.FindElement( EngLangButton).Click();
            }
            else
            {
                Driver.FindElement(UkrLangButton).Click();
            }
           
            return this;
        }
     
        public bool IsLangChange(bool selectEngLang)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk;
            if (selectEngLang == true)
            {
                 isOk = Wait.WaitFor(() => Driver.FindElements(EngLang).Any());
            }
            else
            {
                 isOk = Wait.WaitFor(() => Driver.FindElements(UkrLang).Any());
            }
           
          
            return isOk;
        }
        
            
    }
}