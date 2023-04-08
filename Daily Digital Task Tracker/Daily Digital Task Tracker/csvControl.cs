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
                StreamWriter sw = new StreamWriter(File.Open("Stats.csv", System.IO.FileMode.CreateNew));
                Console.WriteLine("Stats file created");
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Stats file already exists");
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
        public static void Append(string file, string addition)
        {
            File.AppendAllText(file, addition);
        }
        public static void Delete(string file, string date, string searchItem)
        {
            string search = searchItem;
            string dateSearch = date;
            Console.WriteLine(search);
            Console.WriteLine(dateSearch);
            //Gets all tasks not in the selected date
            File.WriteAllLines("Temp.csv", File.ReadAllLines(file).Where(line => (!dateSearch.Equals(line.Split(',')[0]))));
            //Gets all tasks that are in the selected date but not = to the task name
            File.AppendAllLines("Temp.csv", File.ReadAllLines(file).Where(line => !search.Equals(line.Split(',')[1])).Where(line => (dateSearch.Equals(line.Split(',')[0]))));
            //Writes both statements above to the events file
            File.WriteAllLines(file, File.ReadAllLines("Temp.csv"));
        }

        public static void Read(string File)
        {

        }
    }
}
