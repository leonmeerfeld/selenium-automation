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
    class Program
    {
<<<<<<< HEAD
        //tsest
=======
        //swag gggggg
>>>>>>> origin/master
        static void Main(string[] args)
        {
            string baseURL = "http://lhk.uni-trier.de/";

            Actions a = new Actions();
            Writer w = new Writer();

            w.WriteL("Starting test...", null);

            a.startWebdriver();

            a.gotoBaseURL(baseURL);

            Console.ReadKey();
        }
    }
}

