using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDrills1
{
    class SeleniumDrill1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            // relative paths don't seem to work
            driver = new FirefoxDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\SeleniumDrills1\packages\Selenium.Firefox.WebDriver.0.21.0\driver\");
        }

        [Test]
        public void test1()
        {
            driver.Url = "https://google.com";
        }

        [TearDown]
        public void closeBrowser()
        {
            Thread.Sleep(3000);
            driver.Close();
        }

        class SeleniumDrill2
        {
            IWebDriver driver;

            [SetUp]
            public void startBrowser()
            {
                // relative paths don't seem to work
                driver = new FirefoxDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\SeleniumDrills1\packages\Selenium.Firefox.WebDriver.0.21.0\driver\");
            }

            [Test]
            public void test2()
            {
                driver.Url = "https://Store.DemoQA.com";
                string title = driver.Title;
                int titleLength = title.Length;
                Console.WriteLine("Title: {0}, TitleLength: {1}", title, titleLength);
                string url = driver.Url;
                int urlLength = url.Length;
                Console.WriteLine("Url: {0}, UrlLength: {1}", url, urlLength);
                string pageSource = driver.PageSource;
                int pageSourceLength = pageSource.Length;
                Console.WriteLine("PageSourceLength: {0}", pageSourceLength);
            }

            [TearDown]

            public void closeBrowser()
            {
                driver.Close();
            }


        }

        class SeleniumDrill3
        {
            IWebDriver driver;
            [SetUp]
            public void startBrowser()
            {
                // relative paths don't seem to work
                driver = new FirefoxDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\SeleniumDrills1\packages\Selenium.Firefox.WebDriver.0.21.0\driver\");
            }

            [Test]
            public void test3()
            {
                driver.Url = "http://demoqa.com/frames-and-windows/";
                driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            }

            [TearDown]
            public void closeBrowser()
            {
                Thread.Sleep(3000);
                driver.Quit();
            }
        }
    }
}
