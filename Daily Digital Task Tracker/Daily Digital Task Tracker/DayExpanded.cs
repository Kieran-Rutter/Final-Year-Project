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
        }

        private void CreateEvent_btn_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Events.csv", eventDate_txt.Text + "," + eventName_txt.Text + "\n");
            MessageBox.Show("Created");

        }
    }
}
