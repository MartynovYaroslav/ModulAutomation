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
    //[TestClass]
    [TestFixture]
    public class UnitTest1 
    {


        IWebDriver driver = new ChromeDriver();

        string url = "https://www.google.com/intl/ru/gmail/about/";





        [SetUp]
        public void BeaforTest()
        {


            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
            driver.Navigate().GoToUrl(url);
        }



        [Test]
        [Retry(4)]
        public void AuthorisationByUser()
        {
            //string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            string fileName = Path.Combine("D:\\1\\ModulAutomation\\TaskModulUTP\\Data", "Login.xlsx");
            ExcelHelpers.PopulateInCollection(fileName);


            LandingPage landingPage = new LandingPage(driver);
            SignInGmail signInGmail = new SignInGmail(driver);
            SignInPassword signInPassword = new SignInPassword(driver);


            landingPage.PressEnterLandingPage();
           
            signInGmail.LoginTxt(1);
            
            signInPassword.PasswordTxt(1);
           
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
