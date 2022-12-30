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
        public StringBuilder sbTheme;
        public StringBuilder sbBackColour;
        public StringBuilder sbTextColour;
        public StringBuilder sbButtonBackColour;
        public StringBuilder sbButtonBorderColour;
        public string theme { get; set; }
        public string backColour { get; set; }
        public string textColour { get; set; }
        public string buttonBackColour { get; set; }
        public string buttonBorderColour { get; set; }

        public void readIni()
        {
            int resaultSize;
            //Creates string builders
            sbTheme = new StringBuilder(10);
            sbBackColour = new StringBuilder(10);
            sbTextColour = new StringBuilder(10);
            sbButtonBackColour = new StringBuilder(10);
            sbButtonBorderColour = new StringBuilder(10);

            //Gets values from ini
            resaultSize = GetPrivateProfileString("SECTION", "key", "", sbTheme, sbTheme.Capacity, iniPath);
            resaultSize = GetPrivateProfileString("SECTION", "backColour", "", sbBackColour, sbBackColour.Capacity, iniPath);
            resaultSize = GetPrivateProfileString("SECTION", "textColour", "", sbTextColour, sbTextColour.Capacity, iniPath);
            resaultSize = GetPrivateProfileString("SECTION", "buttonBackColour", "", sbButtonBackColour, sbButtonBackColour.Capacity, iniPath);
            resaultSize = GetPrivateProfileString("SECTION", "buttonBorderColour", "", sbButtonBorderColour, sbButtonBorderColour.Capacity, iniPath);

            this.theme = sbTheme.ToString();
            //Make variables a valid hex string to be used to theme the app
            this.backColour = "#" + sbBackColour.ToString();
            this.textColour = "#" + sbTextColour.ToString();
            this.buttonBackColour = "#" + sbButtonBackColour.ToString();
            this.buttonBorderColour = "#" + sbButtonBorderColour.ToString();

        }
        public void writeini(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
