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
    public partial class DayExpanded : Form
    {
        public DayExpanded()
        {
            InitializeComponent();
            onLoad();
        }

        private void onLoad()
        {
            eventDate_txt.Text = DayUserControl.day_stc + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();
            getIni();
        }

        private void CreateEvent_btn_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Events.csv", eventDate_txt.Text + "," + eventName_txt.Text + "\n");
            MessageBox.Show("Created");
        }
        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            backColour = Form1.backColour;
            textColour = Form1.textColour;

            //User control colours
            this.BackColor = ColorTranslator.FromHtml(backColour);


            //Expand button

        }
        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
    }
}
