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
    class Program : SiteModels
    {
        static void Main(string[] args)
        {
            string baseURL = "http://lhk.uni-trier.de/";

            Interactions i = new Interactions();
            Writer w = new Writer();

            w.WriteL("Starting test...", null);

            try
            {
                i.startWebdriver();
                i.gotoBaseURL(baseURL);
                // ~ Write tests here ~



                // Use this condition to verify that the test has reached an element(or XPath).
                if (i.elementPresentByXpath(".//*[@id='tsf']/div[2]/div[3]/center/input[1]"))
                {
                    w.WriteL("Test completed.", "green");
                }else
                {
                    w.WriteL("Test not completed.", "red");
                }
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

