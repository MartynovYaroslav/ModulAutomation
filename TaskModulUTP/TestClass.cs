using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TaskModulUTP.Pages;
using EAAutoFramework.Helpers;
using AutomationModulFr.Helpers;


namespace TaskModulUTP
{
    [TestClass]
    public class UnitTest1 
    {


        IWebDriver driver = new ChromeDriver();
     
        string url = "https://www.google.com/intl/ru/gmail/about/";





        [TestInitialize]
        public void BeaforTest()
        {

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
            driver.Navigate().GoToUrl(url);
        }



        [TestMethod]
        public void AuthorisationByUser()
        {
            LandingPage landingPage = new LandingPage(driver);
            SignInGmail signInGmail = new SignInGmail(driver);
            SignInPassword signInPassword = new SignInPassword(driver);

            

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);
            Thread.Sleep(3000);


            landingPage.PressEnterLandingPage();
            Thread.Sleep(3000);
            signInGmail.LoginTxt(1);
            Thread.Sleep(3000);
            signInPassword.PasswordTxt(1);
            Thread.Sleep(3000);
        }

        [TestCleanup]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
