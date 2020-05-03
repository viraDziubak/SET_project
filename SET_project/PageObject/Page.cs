using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public class Page : PageObjectBase
    {

        private static readonly By ChangeClothes = By.Id("category-3");

        private static readonly By ChangeAccessories = By.Id("category-6");
       
        private static readonly By ChangeArt = By.Id("category-9");
        private static readonly By ChangeMyStore = By.Id("_desktop_logo");
     

        public Page(IWebDriver driver) : base(driver)
        {
        }
   
        public Page Change_Clothes()
        {
            Driver.FindElement(by: ChangeClothes).Click();
     
            return this;
        }
        public Page Change_Accessories()
        {
            Driver.FindElement(by: ChangeAccessories).Click();

            return this;
        }
        public Page Change_Art()
        {
            Driver.FindElement(by: ChangeArt).Click();

            return this;
        }
        public Page Change_MyStore()
        {
            Driver.FindElement(by: ChangeMyStore).Click();

            return this;
        }

    }
}
