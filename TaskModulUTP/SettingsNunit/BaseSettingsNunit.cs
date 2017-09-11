using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationModulFr.SettingsNunit
{
   [SetUpFixture]
   public class BaseSettingsNunit
    {
        public IWebDriver driver = new ChromeDriver();

        //string url = "https://www.google.com/intl/ru/gmail/about/";



       // [OneTimeSetUp]
        [SetUp]
        public void BeaforTest()
        {
            string url = "https://www.google.com/intl/ru/gmail/about/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
            driver.Navigate().GoToUrl(url);
        }


        //[OneTimeTearDown]
        [TearDown]
        public void AfterTest()
        {

            driver.Quit();
        }





    }
}
