using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace GoogleSearch
{
    public class GoogleResultsPage : BasePage
    {
        public GoogleResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FoundResult => Driver.FindElement(By.ClassName("LC20lb"));

        public void Navigate(GoogleSearchPage googleSearchPage)
        {
            googleSearchPage.Navigate("http://www.google.com");

            googleSearchPage.GoogleSearchBar.SendKeys("Selenium");
            googleSearchPage.GoogleSearchBar.Submit();
            FoundResult.Click();
            
            
        }
    }
}