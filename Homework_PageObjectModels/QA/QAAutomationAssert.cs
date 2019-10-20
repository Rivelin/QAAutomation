using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;


namespace QAAutomation
{
    [TestFixture]
    public class QAAutomationAssert
    {
        private ChromeDriver _driver;
        private SUMainPage _suMainPage;
        private QACursPage _qACursPage;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();

            _suMainPage = new SUMainPage(_driver);
            _qACursPage = new QACursPage(_driver);
        }

        [Test]
        public void QAAutomationCurs()
        {
            _suMainPage.Navigate();

            Assert.AreEqual(_qACursPage.Result(), "QA Automation - септември 2019");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
