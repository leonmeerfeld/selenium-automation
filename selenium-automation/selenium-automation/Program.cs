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
    /// Main class that runs the Program.
    /// </summary>
    class Program : SiteModels
    {
        static void Main(string[] args)
        {
            string baseURL = "http://www.google.com/";

            Interactions i = new Interactions();
            Writer w = new Writer();

            w.WriteL("Starting test...", null);

            try
            {
                i.startWebdriver();
                i.gotoBaseURL(baseURL);
                googleTextbox().SendKeys("Selenium");
                googleSubmit().Click();

                // ~ Write tests here ~

                /*
                //If elements need more time to load or the waiting time in the SiteModels class doesn't work,
                //use this to let the webdriver wait:
                 
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                or System.Threading.Thread.Sleep(500);

                //You can use this condition to verify that the test has reached an element(using XPath) 
                //that the determines the outcome of the test.
                 
                if (i.elementPresentByXpath(".//*[@id='tsf']/div[2]/div[3]/center/input[1]"))
                {
                    w.WriteL("Test completed.", "green");
                }else
                {
                    w.WriteL("Test not completed.", "red");
                }

                //Or this one if you want to search for a string.
                 
                if(LoginBtn().Text == "This is the string im searching for in the prior element.")
                {
                    w.WriteL("Test completed.", "green");
                }else
                {
                    w.WriteL("Test not completed.", "red");
                }
                */

                //Saves a screenshot in the location of the executable:
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string screenshot_name = System.AppDomain.CurrentDomain.BaseDirectory + "Screenshot " + DateTime.Now.ToString().Replace(":", ".") + ".png";
                ss.SaveAsFile(screenshot_name, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                w.WriteL(ex.ToString(), "red");
            }

            Console.ReadKey();
            driver.Close();
        }
    }
}

