using OpenQA.Selenium;

namespace SET_project.PageObject
{
    public class LoginPage
    {
         IWebDriver driver;

         public LoginPage(IWebDriver driver)
         {
             this.driver = driver;
         }
         
         private By emailField = By.XPath("//*[@id='login-form']/section/div[1]/div[1]/input");
         private By passwordField = By.XPath("//*[@id='login-form']/section/div[2]/div[1]/div/input");
         private By signIn = By.XPath("//*[@id='submit-login']");

         public LoginPage TypeEmail(string email)
         {
             driver.FindElement(emailField).SendKeys(email);
             return this;
         }
         
         public LoginPage TypePassword(string password)
         {
             driver.FindElement(passwordField).SendKeys(password);
             return this;
         }
         
         
         
         public LoginPage ClickSignIn(string email, string password)
         {
             this.TypeEmail(email);
             this.TypePassword(password);
            //driver.FindElement(emailField).SendKeys(email);
            //driver.FindElement(passwordField).SendKeys(password);
             driver.FindElement(signIn).Click();
             //driver.FindElement(signIn).Text;
             return new LoginPage(driver);
         }

         public string ErorField()
         {
             return driver.FindElement(signIn).Text;
         }

        
    }
}