using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace GoogleSearch
{
    public partial class GoogleSerach
    {
        public void FoundResult(string foundResult)
        {
            Assert.AreEqual(foundResult, "Selenium - Web Browser Automation");
        }
    }
}
