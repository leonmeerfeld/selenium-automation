using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace selenium_automation
{
    class SiteModels
    {
        protected static IWebDriver driver = null;

        public static IWebElement WaitForElementToBePresent(By byParam, int seconds)
        {
            IWebElement element = null;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            for (int i = 0; i < 3; i++)
            {
                wait.Until(x => x.FindElement(byParam));
                wait.Until(ExpectedConditions.ElementToBeClickable(byParam));
                wait.Until(ExpectedConditions.ElementIsVisible(byParam));
                element = driver.FindElement(byParam);
            }
            return element;
        }

        /// <summary>
        /// Gibt IList<IWebElement> zurück wenn die Elemente Sichtbar, Klickbar und present sind.
        /// </summary>
        /// <param name="byParam"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static IList<IWebElement> WaitForElementsToBePresent(By byParam, int seconds)
        {
            IList<IWebElement> elements = null;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            for (int i = 0; i < 3; i++)
            {
                wait.Until(ExpectedConditions.ElementIsVisible(byParam));
                wait.Until(ExpectedConditions.ElementToBeClickable(byParam));
                wait.Until(x => x.FindElements(byParam));
                elements = driver.FindElements(byParam);
            }

            return elements;
        }

        //Login
        public static IWebElement UsernameInput()
        {
            return WaitForElementToBePresent(By.CssSelector("input[class='input_login_hisinone'][title='Benutzerkennung']"), 20);
        }

        public static IWebElement PasswordInput()
        {
            return WaitForElementToBePresent(By.CssSelector("input[class='input_login_hisinone'][title='Passwort']"), 20);
        }

        public static IWebElement LoginButton()
        {
            return WaitForElementToBePresent(By.CssSelector("button[class='submit_login'][alt='Anmelden']"), 20);
        }

        public static IWebElement confirmLoginInput()
        {
            return WaitForElementToBePresent(By.XPath(".//*[@id='collapsibleHeaderActionFrom:rolesInput']"), 20);
        }
    }
}
