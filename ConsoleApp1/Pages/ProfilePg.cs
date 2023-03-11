using Competition_task.Utilities;
using OpenQA.Selenium;
using NUnit;

namespace Competition_task.Pages
{
    public class ProfilePg : CommonDriver
    {

        public void ShareSkills()
        {
            //click on Shareskill
           IWebElement ShareskillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));

            Wait.WaitForElementTobeExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a", 10);
            ShareskillButton.Click();
            

        }
        public void ManageListings()
        {
            //click on ManageListing
            IWebElement managelistingButton = driver.FindElement(By.XPath("//a[text()='Manage Listings']"));
             Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]", 10);
            managelistingButton.Click();
            
        }
    }
}
