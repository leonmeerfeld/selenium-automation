using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Linq;

namespace selenium_automation {
    /// <summary>
    /// Stores methods for more complicated interactions with a site.
    /// </summary>
    class Interactions : SiteModels {
        Writer w = new Writer();

        /// <summary>
        /// Check in Config if line is a Header
        /// Returns true if Lines start with #
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private bool isHeader(string line) {
            return line.Substring(0, 1) == "#";
            }

        /// <summary>
        /// Change Configuration
        /// </summary>
        /// <param name="configitem"></param>
        /// <returns></returns>
        public string readConfig(String configitem) {
            //Directorypath
            string path = Directory.GetCurrentDirectory() + "\\config.txt";
            string configItemvalue = "";
            configitem = "#" + configitem;

            //Exception if config file is missing
            if (!File.Exists(path)) {
                w.WriteL("Konfigurationsdatei wurde nicht gefunden.", "red");
                }

            //Read Document
            string[] configLines = File.ReadAllLines(path);

            for (int i = 0; i < configLines.Length; i++) {
                if ((configLines[i] == configitem)) {
                    i++;
                    int m = i;
                    while ((configLines.Length != m) && !isHeader(configLines[m])) {
                        configItemvalue += configLines[m];
                        m++;
                        }
                    }
                }
            //Option not in configuration file
            if (configItemvalue == "") {
                w.WriteL("Die Option '" + configitem + "' wurde in der Konfigurationsdatei nicht gefunden.", "red");
                }
            return configItemvalue;
            }

        //Checks if an element is displayed on the current page.
        public bool elementPresentByXpath(string xpath) {
            if (driver.FindElements(By.XPath(xpath)).Count > 0) {
                return true;
                }
            else {
                return false;
                }
            }

        /// <summary>
        /// Starts the webdriver, Firefox and maximizes the browser window.
        /// </summary>
        public void startWebdriver() {
            try {
                w.WriteL("Webdriver wird geladen...", null);

                driver = new ChromeDriver(@"C:\\");
                driver.Manage().Window.Maximize();
                }
            catch (Exception ex) {
                w.WriteL("Webdriver konnte nicht geladen werden.", "red");
                w.WriteL(ex.ToString(), "red");
                }
            }

        /// <summary>
        /// Goes to a Domain. Needs FQDN in order to work.
        /// </summary>
        /// <param name="baseURL"></param>
        public void gotoBaseURL(string baseURL) {
            try {
                if (driver != null) {
                    driver.Navigate().GoToUrl(baseURL);
                    driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
                    }
                else {
                    w.WriteL("Webdriver konnte nicht gestartet werden.", "red");
                    }
                }
            catch (Exception ex) {
                w.WriteL("Die Webseite wurde nicht gefunden.", "red");
                }
            }
        }
    }
