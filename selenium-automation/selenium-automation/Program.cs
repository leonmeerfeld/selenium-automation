using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Diagnostics;
using System.Configuration;

/*
 * 
 * Buglist:
 * 
 */

/*
 * 
 * Probleme:
 * 
 */

namespace selenium_automation
{
    class Program : SiteModels
    {
        static void Main(string[] args)
        {
            //Objekte von Hilfsklassen
            Interactions i = new Interactions();
            Writer w = new Writer();

            Stopwatch stopwatch = new Stopwatch();

            int exitCode = 1;

            //Wahr wenn erfolgreich eingeloggt
            bool milestone1 = false;

            //Der erste FQDN der Aufgerufen wird
            string baseURL = i.readConfig("URL");

            w.WriteL("Tests werden gestartet...", null);

            try
            {
                i.startWebdriver();

                stopwatch.Start();

                i.gotoBaseURL(baseURL);
                // ~ Write tests here ~

                //Login:
                UsernameInput().SendKeys("hinzmann");
                PasswordInput().SendKeys(":-)");
                LoginButton().Click();
                System.Threading.Thread.Sleep(500);


                if (confirmLoginInput().GetAttribute("value") == "Department-Admin_UTR Anglistik")
                    milestone1 = true;

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string screenshot_name = System.AppDomain.CurrentDomain.BaseDirectory + "Screenshot " + DateTime.Now.ToString().Replace(":", ".") + ".png";
                ss.SaveAsFile(screenshot_name, System.Drawing.Imaging.ImageFormat.Png);

                //If all milestones are true, the test is complete.
                if (milestone1)
                {
                    w.WriteL("Test erfolgreich abgeschlossen.", "green");
                    exitCode = 0;
                }
                else
                {
                    w.WriteL("Test nicht erfolgreich abgeschlossen.", "red");
                    exitCode = 1;
                }

            }
            catch (Exception ex)
            {
                w.WriteL("Ein Fehler ist während des Ausführen des Tests aufgetreten. " + ex.ToString(), "red");
                driver.Close();
                Environment.Exit(exitCode);
            }

            //Zeitauswertung:
            stopwatch.Stop();
            string hours = (stopwatch.Elapsed.Hours.ToString().Length > 1) ? stopwatch.Elapsed.Hours.ToString() : "0" + stopwatch.Elapsed.Hours.ToString();
            string minutes = (stopwatch.Elapsed.Minutes.ToString().Length > 1) ? stopwatch.Elapsed.Minutes.ToString() : "0" + stopwatch.Elapsed.Minutes.ToString();
            string seconds = (stopwatch.Elapsed.Seconds.ToString().Length > 1) ? stopwatch.Elapsed.Seconds.ToString() : "0" + stopwatch.Elapsed.Seconds.ToString();
            w.WriteL(string.Format("Zeit: {0}:{1}:{2}", hours, minutes, seconds), null);

            driver.Close();
            Environment.Exit(exitCode);
        }
    }
}

