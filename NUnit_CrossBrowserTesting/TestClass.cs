// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using NUnit_CrossBrowserTesting.Enumerations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace NUnit_CrossBrowserTesting
{
    [TestFixture(BrowserType.Chrome)]
    public class TestWithMultipleBrowsers : BaseTest
    {
        public TestWithMultipleBrowsers(BrowserType type) : base(type) { }

        

        [Test]
        public void GoogleTest()
        {
            BaseDriver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement query = BaseDriver.FindElement(By.Name("q"));
            query.SendKeys("Bread" + Keys.Enter);
            Thread.Sleep(2000);
            Assert.AreEqual("Bread - Google Search", BaseDriver.Title);
            BaseDriver.Quit();

        }
    }
}
