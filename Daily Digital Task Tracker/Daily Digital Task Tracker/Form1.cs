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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateDisplay();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dateDisplay();
        }

        private void dateDisplay()
        {
            //gets date
            DateTime currentTime = DateTime.Now;

            //GetScaledBounds the first day of the moth
            DateTime monthStart = new DateTime(currentTime.Year, currentTime.Month, 1);

            //Gets the total days in the month
            int days = DateTime.DaysInMonth(currentTime.Year, currentTime.Month);

            //Converts monthstart to an ineger
            int daysInWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d"));
            
            //Blank user control for last months
            for(int i = 1;i < daysInWeek; i++)
            {
                EmptyUserControl euc = new EmptyUserControl();
                month_container.Controls.Add(euc);
            }

            //This months user control
            for(int i = 1;i <= days; i++)
            {
                DayUserControl duc = new DayUserControl();
                duc.day(i);
                month_container.Controls.Add(duc);
            }
        }
    }
}
