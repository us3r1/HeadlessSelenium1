using System;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTute1.Library
{
    class commonLib
    {
        IWebDriver _driver;

        public void verifyElementNameExists(IWebDriver driver, string webElementName)
        {
            _driver = driver;

            try
            {
                Assert.IsTrue(_driver.FindElement(By.Name(webElementName)).Displayed);
                Console.WriteLine("Element with name - " + webElementName + " found on page");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //return false;
            }
            //return true;
            
        }

    }
}
