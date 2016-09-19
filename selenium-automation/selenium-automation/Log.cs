using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace selenium_automation
{
    class Log
    {
        static bool file_created = false;

        static string file_name = "porta-test-2 " + DateTime.Now.ToString().Replace(":", ".") + ".autolog";
        static string directory = System.AppDomain.CurrentDomain.BaseDirectory;

        public void AppendToLogFile(string text_to_append)
        {
            if (!file_created)
            {
                file_created = true;
                File.WriteAllText(directory + file_name, "Test Fortschritt:" + Environment.NewLine);
            }

            using (StreamWriter file = new StreamWriter(directory + file_name, true))
            {
                file.WriteLine(" - " + text_to_append);
            }
        }
    }
}
