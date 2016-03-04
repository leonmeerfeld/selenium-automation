using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.IO;

namespace selenium_automation
{
    class Interactions : SiteModels
    {
        Writer w = new Writer();

        //Checks if an element is displayed on the current page.
        public bool elementPresentByXpath(string xpath)
        {
            if(driver.FindElements(By.XPath(xpath)).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Starts the webdriver, Firefox and maximizes the browser window.
        public void startWebdriver()
        {
            try
            {
                w.WriteL("Starting webdriver...", null);

                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                w.WriteL("Failed at starting Webdriver.", "red");
                w.WriteL(ex.ToString(), "red");
            }
        }

        //Goes to a Domain.
        //Needs FQDN (like http://www.example.org/) in order to work.
        public void gotoBaseURL(string baseURL)
        {
            try
            {
                if(driver != null)
                {
                    driver.Navigate().GoToUrl(baseURL);
                    driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
                }else
                {
                    w.WriteL("Webdriver is not initiated.","red");
                }
            }
            catch (Exception ex)
            {
                w.WriteL("Failed at going to base URL.", "red");
            }
        }
    }
}
