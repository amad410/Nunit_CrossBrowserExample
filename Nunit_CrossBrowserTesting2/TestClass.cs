// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Nunit_CrossBrowserTesting2
{
    [TestFixture(BrowserType.Chrome)]
    public class TestClass
    {
        BrowserType _type;
        private IWebDriver _driver;
        public TestClass(BrowserType type)
        {
            _type = type;
        }

        [SetUp]
        public void Initialize()
        {
            if (_type.Equals(BrowserType.Chrome))
            {
                _driver = new ChromeDriver();

            }
        }
        [Test]
        public void TestMethod()
        {
            _driver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement query = _driver.FindElement(By.Name("q"));
            query.SendKeys("Bread" + Keys.Enter);
            Thread.Sleep(2000);
            Assert.AreEqual("Bread - Google Search", _driver.Title);
            _driver.Quit();


        }
    }
}
