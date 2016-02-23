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
    class Actions : SiteModels
    {
        Writer w = new Writer();

        public void startWebdriver()
        {
            try
            {
                w.WriteL("Starting Webdriver...", null);

                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                w.WriteL("Failed at starting Webdriver", "red");
                w.WriteL(ex.ToString(), "red");
            }
        }
    }
}
