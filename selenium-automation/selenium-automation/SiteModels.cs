using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace selenium_automation
{
    class SiteModels
    {
        // This class is used to store elements.

        protected static IWebDriver driver = null;

        // This one uses XPath to find the element.
        public static IWebElement LoginBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver.FindElement(By.XPath(".//*[@id='tsf']/div[2]/div[3]/center/input[1]"));
        }

        // This one CssSelector.
        public static IWebElement UsernameText()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver.FindElement(By.CssSelector("input[id='username']"));
        }
    }
}
