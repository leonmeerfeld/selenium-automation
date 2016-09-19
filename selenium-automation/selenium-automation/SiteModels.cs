using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace selenium_automation
{
    /// <summary>
    /// Stores elements from websites as WebElements.
    /// </summary>
    class SiteModels
    {
        protected static IWebDriver driver = null;

        /// <summary>
        /// Returns element as soon as it's present.
        /// </summary>
        /// <param name="by"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static IWebElement WaitForElementToBePresent(By by, int seconds)
        {
            IWebElement Element = null;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            for (int i = 0; i < 3; i++)
            {
                Element = wait.Until(x => x.FindElement(by));
            }
            return Element;
        }

        //This one uses XPath to find the element.
        public static IWebElement LoginBtn()
        {
            return WaitForElementToBePresent(By.XPath("html/body/div[3]/h1"), 20);
        }

        //This one uses CssSelector to find the element.
        public static IWebElement UsernameText()
        {
            return WaitForElementToBePresent(By.CssSelector("input[id='username']"), 20);
        }

        public static IWebElement googleTextbox()
        {
            return WaitForElementToBePresent(By.CssSelector("input[id='lst-ib'][name='q'][dir='ltr']"), 10);
        }

        public static IWebElement googleSubmit()
        {
            return WaitForElementToBePresent(By.XPath(".//*[@id='sblsbb']/button"), 10);
        }
    }
}
