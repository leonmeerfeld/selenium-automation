using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_automation
{
    class Writer
    {
        public void WriteL(string text, string color)
        {
            //Appends every text that gets parsed through this class to a logfile.
            Log l = new Log();
            l.AppendToLogFile(text);

            if( ! String.IsNullOrEmpty(color))
            {
                switch (color.ToLower())
                {
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(text);
                        Console.ResetColor();
                        break;

                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(text);
                        Console.ResetColor();
                        break;

                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(text);
                        Console.ResetColor();
                        break;
                }
            }else
            {
                Console.WriteLine(text);
            }
        }
    }
}
