using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSearch
{
    public abstract class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
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