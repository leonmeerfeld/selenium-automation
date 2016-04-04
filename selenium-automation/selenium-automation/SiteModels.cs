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
    /// <summary>
    /// Stores elements from websites as WebElements.
    /// </summary>
    class SiteModels
    {
        //This class is used to store elements.

        protected static IWebDriver driver = null;

        //This one uses XPath to find the element.
        public static IWebElement LoginBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver.FindElement(By.XPath("html/body/div[3]/h1"));
        }

        //This one uses CssSelector to find the element.
        public static IWebElement UsernameText()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver.FindElement(By.CssSelector("input[id='username']"));
        }
    }
}
