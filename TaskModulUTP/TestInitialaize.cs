using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiTest
{
    //[TestFixture]
     class TestInitialaize
    {

            IWebDriver driver = new ChromeDriver();

            string url = "https://www.google.com/intl/ru/gmail/about/";

            [SetUp]
            public void BeaforTest()
            {
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
                driver.Navigate().GoToUrl(url);
            }


            [TearDown]
            public void AfterTest()
            {
                driver.Quit();
            }


        }
    }

