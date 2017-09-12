using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationModulFr.Helpers
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
    }
}
