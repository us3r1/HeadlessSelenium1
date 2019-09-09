using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTute1.POM
{
    class newsHome
    {
        private IWebDriver _driver;
        //public IWebElement loginBtn => _driver.FindElement(By.ClassName("nca-signin-btn"));
        public IWebElement loginBtn => _driver.FindElement(By.LinkText("Log in"));

        public void navigateToNews(IWebDriver driver)
        {
            _driver = driver;
            _driver.Url = "http://news.com.au";

        }


        public void userLogin()
        {
            var actualTitle = _driver.Title;
            var expectedTitle = "news.com.au — Australia’s #1 news site";
            Console.WriteLine(actualTitle);
            Console.WriteLine("Logging into the age page");
            Console.WriteLine(loginBtn.Displayed);
            loginBtn.Click();
            Assert.AreEqual(expectedTitle, actualTitle);
            Library.commonLib comFunct = new Library.commonLib();
            comFunct.verifyElementNameExists(_driver,"email");
        }
    }
}
