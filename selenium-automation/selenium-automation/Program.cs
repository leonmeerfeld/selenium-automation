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
        static void Main(string[] args)
        {
            string BaseURL = "http://lhk.uni-trier.de/";

            Actions a = new Actions();
            Writer w = new Writer();

            w.WriteL("Starting test...", null);

            a.startWebdriver();

            Console.ReadKey();
        }
    }
}

