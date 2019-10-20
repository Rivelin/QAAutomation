using AutomationPractice;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Framework
{
    [TestFixture]
    public class AutomationPractice
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;
        private RegistrationUser _user;


        [SetUp]
        public void ClassInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void NegativeFirstName()
        {
            _user.FirstName = "";
            
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");

            var emailInput = _driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(_user.Email);

            var createAccountButton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccountButton.Click();

            var radioButton = _wait.Until(r => r.FindElements(By.XPath(@"//*[@class=""radio-inline""]/label//input")));
            radioButton[0].Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(_user.FirstName);

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(_user.LastName);

            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys(_user.Password);

            var dateDD = _wait.Until(d => d.FindElement(By.Id("days")));
            SelectElement date = new SelectElement(dateDD);
            date.SelectByValue(_user.Date);

            var monthDD = _driver.FindElement(By.Id("months"));
            SelectElement months = new SelectElement(monthDD);
            months.SelectByValue(_user.Month);

            var yearDD = _driver.FindElement(By.Id("years"));
            SelectElement years = new SelectElement(yearDD);
            years.SelectByValue(_user.Year);

            var realFirstName = _driver.FindElement(By.Id("firstname"));
            realFirstName.SendKeys(_user.RealFirstName);

            var realLastName = _driver.FindElement(By.Id("lastname"));
            realLastName.SendKeys(_user.RealLastName);

            var address = _driver.FindElement(By.Id("address1"));
            address.SendKeys(_user.Address);

            var city = _driver.FindElement(By.Id("city"));
            city.SendKeys(_user.City);

            var stateDD = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(_user.State);

            var postcode = _driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(_user.PostCode);

            var phone = _driver.FindElement(By.Id("phone_mobile"));
            phone.SendKeys(_user.Phone);

            var alias = _driver.FindElement(By.Id("alias"));
            Type(alias, _user.Alias);

            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

            var validationMessageEllement = _driver.FindElement(By.TagName("ol"));
            var errorList = validationMessageEllement.FindElements(By.TagName("li"));

            //var message = _driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li"));
            //var actualMessage = message.Text;

            //var message = _driver.FindElement(By.XPath(@"//*[@id=""center_column""]/comment()"));
            //var actualMessage = message.Text;

            Assert.AreEqual("firstname is required.", errorList[0].Text);
        }


        [Test]
        public void NegativeLastName()
        {
            _user.LastName = "";

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");

            var emailInput = _driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(_user.Email);

            var createAccountButton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccountButton.Click();

            var radioButton = _wait.Until(r => r.FindElements(By.XPath(@"//*[@class=""radio-inline""]/label//input")));
            radioButton[0].Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(_user.FirstName);

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(_user.LastName);

            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys(_user.Password);

            var dateDD = _wait.Until(d => d.FindElement(By.Id("days")));
            SelectElement date = new SelectElement(dateDD);
            date.SelectByValue(_user.Date);

            var monthDD = _driver.FindElement(By.Id("months"));
            SelectElement months = new SelectElement(monthDD);
            months.SelectByValue(_user.Month);

            var yearDD = _driver.FindElement(By.Id("years"));
            SelectElement years = new SelectElement(yearDD);
            years.SelectByValue(_user.Year);

            var realFirstName = _driver.FindElement(By.Id("firstname"));
            realFirstName.SendKeys(_user.RealFirstName);

            var realLastName = _driver.FindElement(By.Id("lastname"));
            realLastName.SendKeys(_user.RealLastName);

            var address = _driver.FindElement(By.Id("address1"));
            address.SendKeys(_user.Address);

            var city = _driver.FindElement(By.Id("city"));
            city.SendKeys(_user.City);

            var stateDD = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(_user.State);

            var postcode = _driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(_user.PostCode);

            var phone = _driver.FindElement(By.Id("phone_mobile"));
            phone.SendKeys(_user.Phone);

            var alias = _driver.FindElement(By.Id("alias"));
            Type(alias, _user.Alias);

            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

            var validationMessageEllement = _driver.FindElement(By.TagName("ol"));
            var errorList = validationMessageEllement.FindElements(By.TagName("li"));

            //var message = _driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li"));
            //var actualMessage = message.Text;

            //var message = _driver.FindElement(By.XPath(@"//*[@id=""center_column""]/comment()"));
            //var actualMessage = message.Text;

            Assert.AreEqual("lastname is required.", errorList[0].Text);
        }


        [Test]
        public void NegativePassword()
        {
            _user.Password = "";

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");

            var emailInput = _driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(_user.Email);

            var createAccountButton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccountButton.Click();

            var radioButton = _wait.Until(r => r.FindElements(By.XPath(@"//*[@class=""radio-inline""]/label//input")));
            radioButton[0].Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(_user.FirstName);

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(_user.LastName);

            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys(_user.Password);

            var dateDD = _wait.Until(d => d.FindElement(By.Id("days")));
            SelectElement date = new SelectElement(dateDD);
            date.SelectByValue(_user.Date);

            var monthDD = _driver.FindElement(By.Id("months"));
            SelectElement months = new SelectElement(monthDD);
            months.SelectByValue(_user.Month);

            var yearDD = _driver.FindElement(By.Id("years"));
            SelectElement years = new SelectElement(yearDD);
            years.SelectByValue(_user.Year);

            var realFirstName = _driver.FindElement(By.Id("firstname"));
            realFirstName.SendKeys(_user.RealFirstName);

            var realLastName = _driver.FindElement(By.Id("lastname"));
            realLastName.SendKeys(_user.RealLastName);

            var address = _driver.FindElement(By.Id("address1"));
            address.SendKeys(_user.Address);

            var city = _driver.FindElement(By.Id("city"));
            city.SendKeys(_user.City);

            var stateDD = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(_user.State);

            var postcode = _driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(_user.PostCode);

            var phone = _driver.FindElement(By.Id("phone_mobile"));
            phone.SendKeys(_user.Phone);

            var alias = _driver.FindElement(By.Id("alias"));
            Type(alias, _user.Alias);

            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

            var validationMessageEllement = _driver.FindElement(By.TagName("ol"));
            var errorList = validationMessageEllement.FindElements(By.TagName("li"));

            //var message = _driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li"));
            //var actualMessage = message.Text;

            //var message = _driver.FindElement(By.XPath(@"//*[@id=""center_column""]/comment()"));
            //var actualMessage = message.Text;

            Assert.AreEqual("passwd is required.", errorList[0].Text);
        }


        [Test]
        public void NegativePh0ne()
        {
            _user.Phone = "";

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");

            var emailInput = _driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(_user.Email);

            var createAccountButton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccountButton.Click();

            var radioButton = _wait.Until(r => r.FindElements(By.XPath(@"//*[@class=""radio-inline""]/label//input")));
            radioButton[0].Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(_user.FirstName);

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(_user.LastName);

            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys(_user.Password);

            var dateDD = _wait.Until(d => d.FindElement(By.Id("days")));
            SelectElement date = new SelectElement(dateDD);
            date.SelectByValue(_user.Date);

            var monthDD = _driver.FindElement(By.Id("months"));
            SelectElement months = new SelectElement(monthDD);
            months.SelectByValue(_user.Month);

            var yearDD = _driver.FindElement(By.Id("years"));
            SelectElement years = new SelectElement(yearDD);
            years.SelectByValue(_user.Year);

            var realFirstName = _driver.FindElement(By.Id("firstname"));
            realFirstName.SendKeys(_user.RealFirstName);

            var realLastName = _driver.FindElement(By.Id("lastname"));
            realLastName.SendKeys(_user.RealLastName);

            var address = _driver.FindElement(By.Id("address1"));
            address.SendKeys(_user.Address);

            var city = _driver.FindElement(By.Id("city"));
            city.SendKeys(_user.City);

            var stateDD = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(_user.State);

            var postcode = _driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(_user.PostCode);

            var phone = _driver.FindElement(By.Id("phone_mobile"));
            phone.SendKeys(_user.Phone);

            var alias = _driver.FindElement(By.Id("alias"));
            Type(alias, _user.Alias);

            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

            var validationMessageEllement = _driver.FindElement(By.TagName("ol"));
            var errorList = validationMessageEllement.FindElements(By.TagName("li"));


            Assert.AreEqual("You must register at least one phone number.", errorList[0].Text);
        }


        [Test]
        public void NegativeCity()
        {
            _user.City = "";

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");

            var emailInput = _driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(_user.Email);

            var createAccountButton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccountButton.Click();

            var radioButton = _wait.Until(r => r.FindElements(By.XPath(@"//*[@class=""radio-inline""]/label//input")));
            radioButton[0].Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(_user.FirstName);

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(_user.LastName);

            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys(_user.Password);

            var dateDD = _wait.Until(d => d.FindElement(By.Id("days")));
            SelectElement date = new SelectElement(dateDD);
            date.SelectByValue(_user.Date);

            var monthDD = _driver.FindElement(By.Id("months"));
            SelectElement months = new SelectElement(monthDD);
            months.SelectByValue(_user.Month);

            var yearDD = _driver.FindElement(By.Id("years"));
            SelectElement years = new SelectElement(yearDD);
            years.SelectByValue(_user.Year);

            var realFirstName = _driver.FindElement(By.Id("firstname"));
            realFirstName.SendKeys(_user.RealFirstName);

            var realLastName = _driver.FindElement(By.Id("lastname"));
            realLastName.SendKeys(_user.RealLastName);

            var address = _driver.FindElement(By.Id("address1"));
            address.SendKeys(_user.Address);

            var city = _driver.FindElement(By.Id("city"));
            city.SendKeys(_user.City);

            var stateDD = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(_user.State);

            var postcode = _driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(_user.PostCode);

            var phone = _driver.FindElement(By.Id("phone_mobile"));
            phone.SendKeys(_user.Phone);

            var alias = _driver.FindElement(By.Id("alias"));
            Type(alias, _user.Alias);

            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

            var validationMessageEllement = _driver.FindElement(By.TagName("ol"));
            var errorList = validationMessageEllement.FindElements(By.TagName("li"));


            Assert.AreEqual("city is required.", errorList[0].Text);
        }

        [Test]
        public void NegativeAddressAndCityAndZipCode()
        {
            _user.Address = "";
            _user.City = "";
            _user.PostCode = "";

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");

            var emailInput = _driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(_user.Email);

            var createAccountButton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccountButton.Click();

            var radioButton = _wait.Until(r => r.FindElements(By.XPath(@"//*[@class=""radio-inline""]/label//input")));
            radioButton[0].Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys(_user.FirstName);

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys(_user.LastName);

            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys(_user.Password);

            var dateDD = _wait.Until(d => d.FindElement(By.Id("days")));
            SelectElement date = new SelectElement(dateDD);
            date.SelectByValue(_user.Date);

            var monthDD = _driver.FindElement(By.Id("months"));
            SelectElement months = new SelectElement(monthDD);
            months.SelectByValue(_user.Month);

            var yearDD = _driver.FindElement(By.Id("years"));
            SelectElement years = new SelectElement(yearDD);
            years.SelectByValue(_user.Year);

            var realFirstName = _driver.FindElement(By.Id("firstname"));
            realFirstName.SendKeys(_user.RealFirstName);

            var realLastName = _driver.FindElement(By.Id("lastname"));
            realLastName.SendKeys(_user.RealLastName);

            var address = _driver.FindElement(By.Id("address1"));
            address.SendKeys(_user.Address);

            var city = _driver.FindElement(By.Id("city"));
            city.SendKeys(_user.City);

            var stateDD = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(_user.State);

            var postcode = _driver.FindElement(By.Id("postcode"));
            postcode.SendKeys(_user.PostCode);

            var phone = _driver.FindElement(By.Id("phone_mobile"));
            phone.SendKeys(_user.Phone);

            var alias = _driver.FindElement(By.Id("alias"));
            Type(alias, _user.Alias);

            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

            var validationMessageEllement = _driver.FindElement(By.TagName("ol"));
            var errorList = validationMessageEllement.FindElements(By.TagName("li"));


            Assert.AreEqual("address1 is required.", errorList[0].Text);
            Assert.AreEqual("city is required.", errorList[1].Text);
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", errorList[2].Text);
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

    public enum Gender
    {
        Male,
        Female
    }
}

