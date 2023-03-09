using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Digital_Task_Tracker
{
    class csvControl
    {
        //Creates file in bin/debug
        public static void Create()
        {
            try
            {
                StreamWriter sw = new StreamWriter(File.Open("config.ini", System.IO.FileMode.CreateNew));

                Console.WriteLine("Config file created");

                sw.Close();
                File.AppendAllText("config.ini", "[SECTION]" + "\n" + 
                    "key = light" + "\n" +
                    "backColour = F8F9FA" + "\n" +
                    "textColour = 000000" + "\n" +
                    "buttonBackColour = CED4DA" + "\n" +
                    "buttonBorderColour = ADB5BD" + "\n" );
            }
            catch (IOException)
            {
                Console.WriteLine("Config file already exists");
            }
            //Makes sure that the files exist if not they are made.
            try
            {
                StreamWriter sw = new StreamWriter(File.Open("Events.csv", System.IO.FileMode.CreateNew));
                Console.WriteLine("Events file created");
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Events file already exists");
            }

            try
            {
                StreamWriter sw = new StreamWriter(File.Open("Temp.csv", System.IO.FileMode.CreateNew));
                Console.WriteLine("Temp file created");
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Temp file already exists");
            }
        }
    }
}
