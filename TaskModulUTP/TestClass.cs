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


        IWebDriver driver = new ChromeDriver();

        string url = "https://www.google.com/intl/ru/gmail/about/";


        [SetUp]
        public void BeaforTest()
        {


            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
            driver.Navigate().GoToUrl(url);

            string fileName = Path.Combine("D:\\1\\ModulAutomation\\TaskModulUTP\\Data", "Login.xlsx");
            ExcelHelpers.PopulateInCollection(fileName);
        }



        [TestCase(1)]
        [Retry(3)]
        //[Retry(Times = 3, RequiredPassCount = 2)]
        public void AuthorisationByUser(int numm)
        {


            LandingPage landingPage = new LandingPage(driver);
            SignInGmail signInGmail = new SignInGmail(driver);
            SignInPassword signInPassword = new SignInPassword(driver);


            landingPage.PressEnterLandingPage();
           
            signInGmail.LoginTxt(numm);
            
            signInPassword.PasswordTxt(numm);
           
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
