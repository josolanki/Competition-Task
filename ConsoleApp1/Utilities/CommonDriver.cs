using Competition_task.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Competition_task.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        [OneTimeSetUp]
        public void SignInPage()
        {
            driver = new ChromeDriver();

            //Login page 
            LoginPg loginPgObj = new LoginPg();
            loginPgObj.SigninActions();
        }
    
        [OneTimeTearDown]
        public void CloseTestrun()
        {
            driver.Quit();
        }
    }
}
