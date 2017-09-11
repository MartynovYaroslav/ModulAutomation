using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TaskModulUTP.Pages;
using EAAutoFramework.Helpers;
using AutomationModulFr.Helpers;
using NUnit.Framework;
using AutomationModulFr.SettingsNunit;

namespace TaskModulUTP
{
    [TestFixture]
    public class UnitTest1 //: BaseSettingsNunit
    {
  
        [Test]
        public void Hurma()
        {

        }

        //[TestCase(1)]
        //public void AuthorisationByUser(int row)
        //{
        //    LandingPage landingPage = new LandingPage(driver);
        //    SignInGmail signInGmail = new SignInGmail(driver);
        //    SignInPassword signInPassword = new SignInPassword(driver);

            

        //    string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
        //    ExcelHelpers.PopulateInCollection(fileName);


        //    landingPage.PressEnterLandingPage();

        //    signInGmail.LoginTxt(row);

        //    signInPassword.PasswordTxt(row);

        //}
    }
}
