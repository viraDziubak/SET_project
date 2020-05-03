using OpenQA.Selenium;


namespace SET_project.PageObject
{
    public class ProductsPage : PageObjectBase
    {
        private static readonly By ChoosePricesDrop = By.Id("link-product-page-prices-drop-1");
        private static readonly By ChooseNewProducts = By.Id("link-product-page-new-products-1");
        private static readonly By ChooseBestSales = By.Id("link-product-page-best-sales-1");


        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductsPage Choose_Prices_Drop()
        {
            Driver.FindElement(by: ChoosePricesDrop).Click();

            return this;
        }
        public ProductsPage Choose_New_Products()
        {
            Driver.FindElement(by: ChooseNewProducts).Click();

            return this;
        }
        public ProductsPage Choose_Best_Sales()
        {
            Driver.FindElement(by: ChooseBestSales).Click();

            return this;
        }

    }
}
