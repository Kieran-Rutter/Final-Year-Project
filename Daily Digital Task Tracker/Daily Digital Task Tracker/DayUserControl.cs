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
    public partial class DayUserControl : UserControl
    {
        private int num = 0;
        public static string day_stc;
        public DayUserControl()
        {
            InitializeComponent();
        }

        public void day(int day)
        {
            date_lbl.Text = day + "";
        }

        public void eventsDisplay(int day)
        {
            getIni();
            string search = day.ToString() + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();
            Console.WriteLine(search);
            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => search.Equals(line.Split(',')[0])));

            using (StreamReader tempRead = new StreamReader("Temp.csv"))
            {
                String line;

                while ((line = tempRead.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    Console.WriteLine(parts[1]);

                    num++;

                    eventsDisplay_txt.AppendText(num +". "+ parts[1] + "\r\n");
                }
            }
        }

        private void DayUserControl_Click(object sender, EventArgs e)
        {
            day_stc = date_lbl.Text;
            DayExpanded dayExpanded = new DayExpanded();
            dayExpanded.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            day_stc = date_lbl.Text;
            DayExpanded dayExpanded = new DayExpanded();
            dayExpanded.Show();
        }

        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();

                backColour = Form1.buttonBackColour;
                textColour = Form1.textColour;

            //User control colours
            this.BackColor = ColorTranslator.FromHtml(backColour);
            this.eventsDisplay_txt.BackColor = ColorTranslator.FromHtml(backColour);
            this.eventsDisplay_txt.ForeColor = ColorTranslator.FromHtml(textColour);
            this.date_lbl.ForeColor = ColorTranslator.FromHtml(textColour);

            //Expand button
            this.expand_btn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.expand_btn.BackColor = ColorTranslator.FromHtml(backColour);
            this.expand_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(textColour);
        }
        public static String backColour;
        public static String textColour;
    }
    //https://stackoverflow.com/questions/2189376/how-to-change-row-color-in-datagridview
}
