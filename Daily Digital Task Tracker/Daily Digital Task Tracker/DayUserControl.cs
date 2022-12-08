using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    public partial class DayUserControl : UserControl
    {
        public static string day_stc;
        public DayUserControl()
        {
            InitializeComponent();
        }

        public void day(int day)
        {
            date_lbl.Text = day + "";
        }

        private void DayUserControl_Click(object sender, EventArgs e)
        {
            day_stc = date_lbl.Text;
            DayExpanded dayExpanded = new DayExpanded();
            dayExpanded.Show();
        }
    }
}
