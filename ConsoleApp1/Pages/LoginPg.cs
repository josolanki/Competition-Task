

using Competition_task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Competition_task.Pages
{
    public class LoginPg : CommonDriver
    {
        
    public void SigninActions() 
        {
            driver.Manage().Window.Maximize();

            //launch localhost portal           
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //click on sign in
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signIn.Click();
            Thread.Sleep(500);

            //Enter valid Email Id
            IWebElement emailId = driver.FindElement(By.XPath("//input[@name ='email']"));
            emailId.SendKeys("solankijo@yahoo.com");
            Thread.Sleep(500);

            //Enter valid Password
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//input[@name='password']"));
            passwordTextBox.SendKeys("Jyoti09");
            Thread.Sleep(500);

            //Click on Login
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(1500);
        }
    }
    }
    
    

