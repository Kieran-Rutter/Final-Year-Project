using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Daily_Digital_Task_Tracker
{
    class Settings
    {
        public string iniPath = Application.StartupPath + @"\config.ini";
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(String sectionName, string KeyName, String defaultValue, 
            StringBuilder returnedString, int size, string fileName);
        [DllImport("Kernel32")]
        private static extern int WritePrivateProfileString(String section, String keyname, string value, string path );


        public StringBuilder sbTheme;
        public string theme { get; set; }

        public void readIni()
        {
            int resaultSize;
            sbTheme = new StringBuilder(10);
            resaultSize = GetPrivateProfileString("SECTION", "key", "", sbTheme, sbTheme.Capacity, iniPath);
        
            this.theme = sbTheme.ToString();
            Console.WriteLine("Reading");

        }
        public void writeini(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
            Console.WriteLine("Writing");
        }
    }
}
