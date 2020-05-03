using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SET_project.PageObject;

namespace SET_project.Tests
{
    
    public class MainBase 
    {
        static IWebDriver driver;
        
        public static void main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://52.177.12.77:8080/en/login?back=my-account");
            
            MainPresta mainPresta = new MainPresta(driver);

            //mainPresta.ClickSignIn("email", "passworf");
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickSignIn("email", "pass");
        }
    }
}