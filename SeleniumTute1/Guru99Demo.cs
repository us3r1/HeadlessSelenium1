using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumTute1
{
    class Guru99Demo
    {
        IWebDriver driver;
        string title;
        static void Main(string[] args)
        {
            IWebDriver driver;// = new ChromeDriver();


        }

        [SetUp]
        public void startBrowser()
        {
            //driver = new ChromeDriver("D:\\3rdparty\\chrome");

            //chrome options to run in headless mode
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--window-size=1400,900");
            //options.AddArguments("--start-maximized");
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            //driver.Manage().Window.Maximize();
        }

        //This uses the main class to process all the requests
        [Test]
        public void test()
        {
            driver.Url = "http://www.google.com";

            title = driver.Title;
            Console.WriteLine(title);
            driver.FindElement(By.Name("q")).SendKeys("mp3");
            driver.FindElement(By.ClassName("gNO89b")).Click();


        }


        [Test]
        public void pomTest()
        {
            //this works
            POM.homePage homepageSearch = new POM.homePage();
            homepageSearch.searchItem(driver, "burger");

            //navigating to news.com.au website
            POM.newsHome newsNav = new POM.newsHome();
            newsNav.navigateToNews(driver);
            newsNav.userLogin();


        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }    
    
}
