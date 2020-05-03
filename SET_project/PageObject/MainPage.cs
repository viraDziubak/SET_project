
using System;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public class Header :PageObjectBase
    {
        private static readonly By ChangeClothes = By.Id("category-3");
        private static readonly By ChangeAccessories = By.Id("category-6");
        private static readonly By ChangeArt = By.Id("category-9");
        private static readonly By ChangeMyStore = By.Id("_desktop_logo");

        internal ProductsPage Choose_Prices_Drop()
        {
            throw new NotImplementedException();
        }

        internal ProductsPage Choose_Best_Sales()
        {
            throw new NotImplementedException();
        }

        internal ProductsPage Choose_New_Products()
        {
            throw new NotImplementedException();
        }

        private static readonly By ChoosePricesDrop = By.Id("category-9");
        private static readonly By ChooseNewProducts = By.Id("link-product-page-new-products-1");
        private static readonly By ChooseBestSales = By.Id("link-product-page-best-sales-1");

        public Header(IWebDriver driver): base(driver)
        { }

        public Page Change_Clothes()
        {
            Driver.FindElement(ChangeClothes).Click();
            Driver.FindElement(ChangeAccessories).Click();
            Driver.FindElement(ChangeArt).Click();
            Driver.FindElement(ChangeMyStore).Click();

            return new Page(Driver);
        }

        public ProductsPage Choose_Product()
        {
            Driver.FindElement(ChoosePricesDrop).Click();
            Driver.FindElement(ChooseNewProducts).Click();
            Driver.FindElement(ChooseBestSales).Click();


            return new ProductsPage(Driver);
        }
        internal Page Change_MyStore()
        {
            throw new NotImplementedException();
        }

        internal Page Change_Art()
        {
            throw new NotImplementedException();
        }

        internal Page Change_Accessories()
        {
            throw new NotImplementedException();
        }
    }
}
