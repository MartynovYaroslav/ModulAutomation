using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using GuiTest.Pages;
using EAAutoFramework.Helpers;
using AutomationModulFr.Helpers;
using NUnit.Framework;
using System.IO;


namespace GuiTest
{

    [TestFixture]
    public class UnitTest1 
    {

        private IWebDriver _driver;


        [SetUp]
        public void BeaforTest()
        {

            _driver = new ChromeDriver();
            string url = "https://www.google.com/intl/ru/gmail/about/";
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
            _driver.Navigate().GoToUrl(url);

            string path = Directory.GetCurrentDirectory();

            string fileName = Path.Combine("d:\\automation\\epam project\\Stability\\Data\\", "Login.xlsx");
            ExcelHelpers.PopulateInCollection(fileName);
        }



        [TestCase(1), Repeat(2)]
        //[Retry(Times = 3, RequiredPassCount = 2)]
        public void AuthorisationByUser(int numm)
        {


            LandingPage landingPage = new LandingPage(_driver);
            SignInGmail signInGmail = new SignInGmail(_driver);
            SignInPassword signInPassword = new SignInPassword(_driver);


            landingPage.PressEnterLandingPage();
           
            signInGmail.LoginTxt(numm);
            
            signInPassword.PasswordTxt(numm);
           
        }

        [TearDown]
        public void AfterTest()
        {
            _driver.Quit();
        }
    }
}
