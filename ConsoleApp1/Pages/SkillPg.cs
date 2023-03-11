
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
    public class SkillPg : CommonDriver
    {
        public void ShareSkill()
        {
            Thread.Sleep(1000); 
            //Add title
            IWebElement titleBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleBox.SendKeys("Digital Marketing");

            //Add Description
            IWebElement descriptionBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionBox.SendKeys("Creating new webdesigns, music");

            //Select Category
            IWebElement categoryBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
            categoryBox.Click();

            //Select Category Option
            IWebElement categoryOption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[3]"));
            categoryOption.Click();


            //Click subcategory
            IWebElement subCategoryBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subCategoryBox.Click();

            // Select Subcategory
            IWebElement subcategoryOption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
            subcategoryOption.Click();

            //click on Tag TextBox
            IWebElement tagTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagTextBox.Click();
            Thread.Sleep(500);

            //Enter tag name
            IWebElement tagName = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagName.SendKeys(("Marketing") + Keys.Enter);

            Thread.Sleep(1000);
            tagName.Click();
            Thread.Sleep(1000);

            //Click on service type
            IWebElement hourlyBase = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            hourlyBase.Click();

            //click on One off service
            IWebElement oneOffService = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            oneOffService.Click();

            //Select location type(on site)
            IWebElement onSite = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            onSite.Click();

            //Select online
            IWebElement online = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            online.Click();

            // Enter date
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDate.Click();

            //Enter End date
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.Click();

            //Find Sunday box
            IWebElement sundayBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));
            sundayBox.Click();

            //Enter start Time in Sunday box
            IWebElement sundayStartTime = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
            sundayBox.Click();

            //Enter end time in sunday box
            IWebElement sundayEndTime = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
            sundayEndTime.Click();

            //Enter Skill Trade
            IWebElement skillTrade = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillTrade.Click();
            Thread.Sleep(1500);


            //CLick Skill exchange
            IWebElement skillExchangeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div"));
            skillExchangeBox.Click();
            Thread.Sleep(2000);

            //Enter skill exchange
            IWebElement skillExchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillExchange.SendKeys(("Trading") + Keys.Enter);
            Thread.Sleep(1000);

            //Upload work sample
            //IWebElement workSample = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            //workSample.Click();

            //Click Active option
            IWebElement clickActive = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            clickActive.Click();

            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]", 15);

            // click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();
            Thread.Sleep(500);

            //check if record has been created successfully
           // IWebElement newListing = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[2]"));

        }
    
    }
}
