using System;
using System.Linq;
using SET_project.Frameworks;
using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public class Header : PageObjectBase
         {
             private static readonly By searchInput = By.ClassName("ui-autocomplete-input");
             private static readonly By searchButton = By.XPath("/html/body/main/header/div[2]/div/div[1]/div[2]/div[2]/form/button");
             private static readonly By IsSearchCorrectClass = By.XPath("/html/body/main/section/div/div/section/section/div[1]/div/div[1]");
             public Header(IWebDriver driver) : base(driver)
             {
                 
             }
     
             public Header InputSerachText(string searchText)
             {
                 Driver.FindElement(searchInput).Click();
                 Driver.FindElement(searchInput).Clear();
                 Driver.FindElement(searchInput).SendKeys(searchText);
     
                 return this;
             }
     
             public Header SearchButtonClick()
             {
                 Driver.FindElement(searchButton).Click();
                 return this;
             }
     
             public bool IsSearchOk()
             {
                 Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
                 //bool isOk = false;
                 bool isOk = Wait.WaitFor(() => Driver.FindElements(IsSearchCorrectClass).Any());
                 Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
                 return isOk;
             }

            
         }
}