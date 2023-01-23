using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    public partial class expandedDay : Form
    {
        public static string[] task;
        public expandedDay()
        {
            InitializeComponent();
        }

        public void day(int day)
        {

        }

        public void taskDisplay(string day)
        {
            string search = day + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();

            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => search.Equals(line.Split(',')[0])));

            using (StreamReader tempRead = new StreamReader("Temp.csv"))
            {

                String line;
                while ((line = tempRead.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    task = parts;
                    TaskUserControl tuc = new TaskUserControl();

                    tuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                        | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));

                    task_pnl.Controls.Add(tuc);
                    tuc.taskDisplay();
                }
            }
        }

        private void expandedDay_Load(object sender, EventArgs e)
        {
            getIni();
            string day = DayUserControl.day_stc;
            taskDisplay(day);
        }










        /*
 * Functions for theme and auto sizing
*/
        //Dynamic scale

        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
        public static String buttonBorderColour;
        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            backColour = settings.backColour;
            textColour = settings.textColour;
            buttonBackColour = settings.buttonBackColour;
            buttonBorderColour = settings.buttonBorderColour;

            //User control colours
            this.BackColor = ColorTranslator.FromHtml(backColour);

            //Buttons

            //Labels
        }

        private Rectangle originalFormSize;
        private Rectangle taskTBL_pnlOriginalRectangle;

        private float buttonlOriginalFontSize;
        private void expandedDay_Resize(object sender, EventArgs e)
        {
            if (shown)
            {
                Daily_Digital_Task_Tracker.Resize.resizeControl(taskTBL_pnlOriginalRectangle, taskTBL_pnl, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);


 
            }
        }

        private static bool shown = false;
        private void expandedDay_Shown(object sender, EventArgs e)
        {
            //Variables for resize
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            taskTBL_pnlOriginalRectangle = new Rectangle(taskTBL_pnl.Location.X, taskTBL_pnl.Location.Y, taskTBL_pnl.Width, taskTBL_pnl.Height);


            //Text
            buttonlOriginalFontSize = label1.Font.Size;

            shown = true;
        }
    }
}
