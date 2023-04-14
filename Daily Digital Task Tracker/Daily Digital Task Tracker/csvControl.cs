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
                    "buttonBorderColour = ADB5BD" + "\n" +
                    "coinCount = 0" + "\n" );
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
            try
            {
                StreamWriter sw = new StreamWriter(File.Open("Temp2.csv", System.IO.FileMode.CreateNew));
                Console.WriteLine("Temp2 file created");
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Temp2 file already exists");
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
            File.WriteAllLines("Temp2.csv", File.ReadAllLines(file).Where(line => (!dateSearch.Equals(line.Split(',')[0]))));
            //Gets all tasks that are in the selected date but not = to the task name
            File.AppendAllLines("Temp2.csv", File.ReadAllLines(file).Where(line => !search.Equals(line.Split(',')[1])).Where(line => (dateSearch.Equals(line.Split(',')[0]))));
            //Writes both statements above to the events file
            File.WriteAllLines(file, File.ReadAllLines("Temp2.csv"));
        }

        public static void Read(string File)
        {

        }
        public static int task_count;
        public static string[] task;
        public static void plusOneStat(string statName, string day)
        {
            task_count = 0;

            //Gets all tasks that are in the selected date and = to the task name
            File.WriteAllLines("Temp.csv", File.ReadAllLines("Stats.csv").Where(line => statName.Equals(line.Split(',')[1])).Where(line => (day.Equals(line.Split(',')[0]))));

            using (StreamReader tempRead = new StreamReader("Temp.csv"))
            {
                String line;
                while ((line = tempRead.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    task = parts;
                    task_count = Int32.Parse(task[2]);
                    task_count++;
                }
                if (task_count == 0)
                {
                    task_count = 1;
                }
            }
            //Deletes existing line in csv
            csvControl.Delete("Stats.csv", day, statName);
            //Writes to csv
            csvControl.Append("Stats.csv", (day + "," + statName + "," + task_count));
        }
    }
}
