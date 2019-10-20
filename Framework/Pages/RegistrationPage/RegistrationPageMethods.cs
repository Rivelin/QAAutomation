﻿using Framework.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AutomationPractice.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {

        public void FillForm(RegistrationUser user)
        {
            RadioButtons[0].Click();
            CustomerFirstName.SendKeys(user.FirstName);
            CustomerLastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Days.SelectByValue(user.Date);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            FirstName.Clear();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            PostCode.SendKeys(user.PostCode);
            Phone.SendKeys(user.Phone);
            Alias.SendKeys(user.Alias);

            RegisterButton.Click();

        }

        public void Navigate(LoginPage loginPage)
        {


            //loginPage.Navigate(RandomGenerator.GenerateMail());
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");
            
            loginPage.Email.SendKeys(RandomGenerator.GenerateMail());
            
            Debug.WriteLine(loginPage.Email.Text);

            loginPage.Submit.Click();
        }
    }
}