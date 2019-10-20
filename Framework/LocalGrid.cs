using AutomationPractice;
using AutomationPractice.Pages;
using AutomationPractice.Pages.RegistrationPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{ 
    [TestFixture]

    public class LocalGrid
    {
        private IWebDriver _driver;
        

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();

            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri("http://192.168.8.100:19777/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }
    
    

    [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }

}

