using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace SeleniumGridTesting
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
        //Testing
        //Testing1
        //Testing2
        //Testing3_Feature3_Task3


        [TestInitialize]
        public void TestSetUp()
        {
            try
            {
                var tt = System.Diagnostics.Process.GetProcesses();
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("chrome"))
                {
                    proc.Kill();
                }
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("chromedriver"))
                {
                    proc.Kill();
                }
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("firefox"))
                {
                    proc.Kill();
                }
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("geckodriver.exe"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        [TestMethod]
        public void ChromeTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }

        [TestMethod]
        public void FireFoxTest()
        {
            //var allProfiles = new FirefoxProfileManager();
            //var profile = allProfiles.GetProfile("SeleniumUser");
            //FirefoxOptions cap = new FirefoxOptions();
            //cap.AcceptInsecureCertificates = true;
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }

        [TestMethod]
        public void EdgeTest()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }

        [TestMethod]
        public void NodeChromeTest()
        {
            var options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;

            driver = new RemoteWebDriver(new Uri("http://141.73.215.98:4444/wd/hub"), options);
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }

        [TestMethod]
        public void NodeFireFoxTest()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AcceptInsecureCertificates = true;

            driver = new RemoteWebDriver(new Uri("http://141.73.215.98:4444/wd/hub"), options);
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }

    }
}
