using AutomationModulFr.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GuiTest.Pages
{
    class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver):
            base(driver){ }


        [FindsBy(How = How.CssSelector, Using = "div.gmail-nav__nav-links-wrap a.gmail-nav__nav-link__sign-in")]
        public IWebElement lnkEnter { get; set; }






        public void PressEnterLandingPage()
        {
           lnkEnter.Click();
        }

    }
}
