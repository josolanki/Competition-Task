using Competition_task.Utilities;
using ExcelDataReader;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_task.Tests
{
    [TestFixture]
    public class ExcelDataTest
    {
        [Test]  
        public void ExcelReadDataForLoginCredentials()
        {
            //Path to the excel file with login credentials
           var filePath = @"C:\Users\solan\Desktop\ProjMars\general\compotition task.exl.xlsx";
          
            //Encoding excel file stream
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
           
            //Reading login credentials from excel file to be used in login page
            var fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
           var reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
           
            //Getting the excel file as a dataset
            var dataSet = reader.AsDataSet();

            //Since only 1 sheet is in the excel file, index 0 is taken

            // for above give strings value
           // dataTable = dataSet.Tables[0];

           // userName = dataTable.Rows[6][0].ToString();
           // password = dataTable.Rows[6][1].ToString();
        }

    }
}
