using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutomationPractice
{
    [TestFixture]
    public class BaseTest
    { 
        public IWebDriver Driver { get; private set; }
    
        [OneTimeSetUp]
        public void ArrangeTests()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }

}
