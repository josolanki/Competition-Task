using Competition_task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_task.Pages 
{
    
    public class ListingPg : CommonDriver
    {
   
        
        public void UpdateSkill()
        {
            Thread.Sleep(1000);
            //click on Update button
            IWebElement updtaeButton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"));
           //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]", 10 );
            updtaeButton.Click();

            
            //Update Description box
            IWebElement UpdateDescription = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            UpdateDescription.Clear();
            UpdateDescription.SendKeys("marketing involves marketing to consumers through any number of digital channels, including websites, mobile devices, and social media platforms.");

            //Click on save button
            IWebElement newSaveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            newSaveButton.Click();
        }
        
        public void DeleteSkill()
        {
            Thread.Sleep(2000);
            //click on Delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
            deleteButton.Click();
            

        }
       
    }
}
