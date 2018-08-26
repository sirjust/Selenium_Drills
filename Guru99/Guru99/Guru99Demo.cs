using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Guru99
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
            public void startBrowser()
        {
            driver = new ChromeDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\Guru99\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32");
        }

        [Test]
            public void test()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]
            public void closeBrowser()
        {
            driver.Close();
        }
    }

    class CSS
    {
        IWebDriver m_driver;

        [Test]
            public void cssDemo()
        {
            m_driver = new ChromeDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\Guru99\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            IWebElement link = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
            m_driver.Close();
        }

        [Test]
            public void cssDemo1()
        {
            m_driver = new ChromeDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\Guru99\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();

            // store locator values of email text box and sign up button

            IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement signUpButton = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();
            m_driver.Close();
        }

        [Test]
            public void cssDemo2()
        {
            m_driver = new ChromeDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\Guru99\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();

            IWebElement course = m_driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new SelectElement(course);
            // Select a value from the dropdown

            selectTest.SelectByValue("sap-abap");
            m_driver.Close();
        }

        [Test]
            public void myDemo1()
        {
            m_driver = new ChromeDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\Guru99\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32");
            m_driver.Url = "https://google.com/";
            m_driver.Manage().Window.Maximize();

            IWebElement searchBox = m_driver.FindElement(By.Name("q"));
            searchBox.SendKeys("secret of mana pixel art");
            searchBox.SendKeys(Keys.Return);
        }

        [Test]
            public void myDemo2()
        {
            m_driver = new ChromeDriver(@"C:\Users\SirJUST\source\repos\Selenium_Drills\Guru99\packages\Selenium.WebDriver.ChromeDriver.2.41.0\driver\win32");
            m_driver.Url = "https://www.youtube.com/";
            m_driver.Manage().Window.Maximize();

            IWebElement searchBox = m_driver.FindElement(By.Id("search"));
            searchBox.SendKeys("relaxing music");
            searchBox.SendKeys(Keys.Return);

            Thread.Sleep(3000);
            //searchBox.SendKeys(Keys.Control + "a");
            //searchBox.SendKeys("hello");

            IWebElement element = m_driver.FindElement(By.XPath("/html[1]/body[1]/ytd-app[1]/div[1]/ytd-page-manager[1]/ytd-search[1]/div[1]/ytd-two-column-search-results-renderer[1]/div[1]/ytd-section-list-renderer[1]/div[2]/ytd-item-section-renderer[1]/div[2]/ytd-search-pyv-renderer[1]/div[1]/ytd-promoted-video-renderer[1]/div[1]/a[1]/div[1]/div[1]/h3[1]"));
            element.Click();
        }
    }
}

