using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationPractice.Pages
{
    public class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public new string Url => "http://automationpractice.com/index.php?controller=my-account";

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));

    }
}
