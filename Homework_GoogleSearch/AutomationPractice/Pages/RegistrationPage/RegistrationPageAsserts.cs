using System.Text;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AutomationPractice.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expected)
        {

            Assert.AreEqual(expected, ErrorMessage.Text);
        }
    }
}