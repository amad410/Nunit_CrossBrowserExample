using NUnit.Framework;
using NUnit_CrossBrowserTesting.Enumerations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_CrossBrowserTesting
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected BrowserType _type;

        public BaseTest(BrowserType type)
        {
            _type = type;

        }
        public BaseTest()
        {
            

        }
        [SetUp]
        public void Initialize()
        {
            
            switch (_type)
            {
                case BrowserType.Chrome:
                    _driver = new ChromeDriver();
                    break;
                default:
                    _driver = new InternetExplorerDriver();
                    break;



            }
        }
        protected IWebDriver BaseDriver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
    }
}
