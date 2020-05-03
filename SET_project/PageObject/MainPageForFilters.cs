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
        private static readonly By FilterFirstBrand = By.XPath("/html/body/main/section/div/div[1]/div[2]/div[2]/section[6]/ul/li[2]/label/a");
        private static readonly By DeleteFiltersButton = By.XPath("//*[@id='_desktop_search_filters_clear_all']/button");
        private static readonly By Trouble = By.Name("s");
        public string troubleText = "Huston! We have troubles!";
        public string OkText = "Its Ok";
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
                Driver.FindElement(Trouble).Clear();
                Driver.FindElement(Trouble).SendKeys(OkText);
                Driver.FindElement(Trouble).SendKeys(Keys.Enter);
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
