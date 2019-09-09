using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTute1.POM
{
	class homePage
	{

        private IWebDriver _driver;
        public IWebElement searchField => _driver.FindElement(By.Name("q"));
        //public IWebElement searchBtn => _driver.FindElement(By.ClassName("gNO89b"));

        //lamdda operator
        public IWebElement searchBtn => _driver.FindElement(By.Name("btnk"));

        public void searchItem(IWebDriver driver, string searchCriteria)
        {
            _driver = driver;
            _driver.Url = "http://www.google.com";
            searchField.SendKeys(searchCriteria);
            searchField.SendKeys("{ ENTER}");
            //searchField.SendKeys("\t\t");
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            //searchBtn.Click();

        }
            
        //driver.Url = "http://www.google.com";

        //    title = driver.Title;
        //    Console.WriteLine(title);
        //    driver.FindElement(By.Name("q")).SendKeys("mp3");
        //driver.FindElement(By.ClassName("gNO89b")).Click();
    }
}
