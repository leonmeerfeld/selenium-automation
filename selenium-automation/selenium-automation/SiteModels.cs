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
        protected static IWebDriver driver = null;

        //Login
        public static IWebElement LoginBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("a[id='loginLink']"));
        }

        public static IWebElement UsernameText()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("input[id='username']"));
        }

        public static IWebElement passwordText()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("input[id='password']"));
        }

        public static IWebElement ConfirmLoginBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("input[type='submit']"));
        }

        public static IWebElement UploadBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("a[href='/Upload']"));
        }

        public static IWebElement EinzeldatenBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("label[id='radiobutton1']"));
        }

        public static IWebElement BelastungenBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("label[id='radiobutton2']"));
        }

        public static IWebElement DateiUploadBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("input[type='file']"));
        }

        public static IWebElement FinishUploadBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("button[class='btn btn-default'][type='submit']"));
        }

        public static IWebElement UploadFeedback()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("div[role='alert']"));
        }

        public static IWebElement FilterBtn()
        {
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(6));
            return driver.FindElement(By.CssSelector("button[class='btn btn-default'][type='submit']"));
        }
    }
}
