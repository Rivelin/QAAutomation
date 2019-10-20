using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace GoogleSearch
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GoogleSearchBar => Driver.FindElement(By.Name("q"));
        
    }
}
