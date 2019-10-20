using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace QAAutomation
{
    public abstract class QABasePage
    {
        private IWebDriver _driver;

        public QABasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public virtual void Navigate(string url)
        {
            Driver.Url = url;
        }

    }
}