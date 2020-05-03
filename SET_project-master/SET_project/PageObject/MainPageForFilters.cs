using System;
using System.Linq;
using OpenQA.Selenium;
using SET_project.Frameworks;

namespace SET_project.PageObject
{
    public class MainPageForFilters : PageObjectBase
    {
        public MainPageForFilters(IWebDriver driver) : base(driver)
        {
        }

        private static readonly By AllProductsButton = By.XPath("//*[@id='content']/section/a");
        private static readonly By FilterFirstBrand = By.XPath("//*[@id='facet_17738']/li[2]/label/a");
        private static readonly By FilterSecondColor = By.XPath("//*[@id='facet_95373']/li[1]/label/a");
        private static readonly By FilterThirdSize = By.XPath("//*[@id='facet_17597']/li[2]/label/a");
        private static readonly By DeleteFiltersButton = By.XPath("//*[@id='_desktop_search_filters_clear_all']/button");
        private static readonly By GoHome = By.XPath("//*[@id='_desktop_logo']/a/img");
        private static readonly By Trouble = By.Name("s");
        public string troubleText = "Huston! We have troubles!";
        public MainPageForFilters ClickToAllProduct()
        {
            Driver.FindElement(AllProductsButton).Click();
            return this;
        }

        public MainPageForFilters ClickFirstFilter()
        {
            Driver.FindElement(FilterFirstBrand).Click();
            return this;
        }
        public MainPageForFilters ClickSecondFilter()
        {
            Driver.FindElement(FilterSecondColor).Click();
            return this;
        }
        public MainPageForFilters ClickThirdFilter()
        {
            Driver.FindElement(FilterThirdSize).Click();
            return this;
        }

        public MainPageForFilters DeleteFilters()
        {
            Driver.FindElement(DeleteFiltersButton).Click();
            return this;
        }

        public bool IsFilterEmpty()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isFilterOk = Wait.WaitFor(() => Driver.FindElements(FilterFirstBrand).Any());
            if (isFilterOk == true)
            {
                Driver.FindElement(GoHome).Click();
            }
            else
            {
                Driver.FindElement(Trouble).Clear();
                Driver.FindElement(Trouble).Click();
                Driver.FindElement(Trouble).SendKeys(troubleText);
                Driver.FindElement(Trouble).SendKeys(Keys.Enter);
            }

            return isFilterOk;
        }


        
        
    }
}
