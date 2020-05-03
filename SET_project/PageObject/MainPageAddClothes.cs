using System;
using System.Data.SqlTypes;
using System.Linq;
using OpenQA.Selenium;
using SET_project.Frameworks;

namespace SET_project.PageObject
{
    public class MainPageAddClothes : PageObjectBase 
    {
        public MainPageAddClothes(IWebDriver driver) : base(driver)
        {
        }

        private static readonly By ClothesButton = By.XPath("//*[@id='content']/section/div/article[1]/div/a/img");
        private static readonly By AddToCardButton = By.XPath("//*[@id='add-to-cart-or-refresh']/div[2]/div/div[2]/button");
        private static readonly By AcceptButton = By.XPath("//*[@id='blockcart-modal']/div/div/div[2]/div/div[2]/div/div/a");
        private static readonly By OurClothes = By.XPath("//*[@id='main']/div/div[1]/div/div[2]/ul/li/div/div[4]");
        private static readonly By DeleteButton = By.XPath("//*[@id='main']/div/div[1]/div/div[2]/ul/li/div/div[3]/div/div[3]/div/a/i");
        private static readonly By HomeButton = By.XPath("//*[@id='_desktop_logo']/a/img");
        
        public  MainPageAddClothes ClickToClothesButton()
        {
            Driver.FindElement(ClothesButton).Click();
            return this;
        }

        public MainPageAddClothes  ClickAddToCard()
        {
            Driver.FindElement(AddToCardButton).Click();
            return this;
        }

        public MainPageAddClothes ClickToAcceptAdding()
        {
            Driver.FindElement(AcceptButton).Click();
            return this;
        }

        public bool IsCardNoEmpty()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(OurClothes).Any());
            if (isOk == true)
            {
                Driver.FindElement(DeleteButton).Click();
            }
            else
            {
                Driver.FindElement(HomeButton).Click();
            }

            return isOk;
        }
    }
}