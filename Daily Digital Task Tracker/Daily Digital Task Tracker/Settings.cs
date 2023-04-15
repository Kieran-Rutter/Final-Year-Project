using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Daily_Digital_Task_Tracker
{//This reads an ini file to get the current theme.
    class Settings
    {
        public string iniPath = Application.StartupPath + @"\config.ini";
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(String sectionName, string KeyName, String defaultValue, 
            StringBuilder returnedString, int size, string fileName);
        [DllImport("Kernel32")]
        private static extern int WritePrivateProfileString(String section, String keyname, string value, string path );

        //Declair all string builders
        public StringBuilder sbThemeColour;
        public StringBuilder sbCoinCount;
        public string themeColour { get; set; }
        public string coinCount { get; set; }

        public void readIni()
        {
            int resaultSize;
            //Creates string builders

            sbThemeColour = new StringBuilder(10);

            sbCoinCount = new StringBuilder(10);

            //Gets values from ini
            resaultSize = GetPrivateProfileString("SECTION", "themeColour", "", sbThemeColour, sbThemeColour.Capacity, iniPath);

            resaultSize = GetPrivateProfileString("SECTION", "coinCount", "", sbCoinCount, sbCoinCount.Capacity, iniPath);

            //Make variables a valid hex string to be used to theme the app
            this.themeColour = "#" + sbThemeColour.ToString();

            this.coinCount = sbCoinCount.ToString();

        }
        public void writeini(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
