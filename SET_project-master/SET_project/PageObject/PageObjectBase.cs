using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public abstract class PageObjectBase
    {
        protected readonly IWebDriver Driver;
        public PageObjectBase(IWebDriver driver) => Driver = driver;
    }
}