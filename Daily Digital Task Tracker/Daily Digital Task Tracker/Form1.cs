using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://icon-icons.com/icon/schedule-calendar-day-month/68904
//https://icon-icons.com/license
namespace Daily_Digital_Task_Tracker
{
    public partial class Form1 : Form
    {
        //Shown used to make sure the form has fully loaded, used to make sure form does not try to resize before loaded.
        private static bool shown = false;
        //gets date
        static DateTime currentTime = DateTime.Now;
        public static int month = currentTime.Month;
        public static int year = currentTime.Year;
        public Form1()
        {
            InitializeComponent();
        }
        //Enables double buffering to stop page flicker on update
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        public void dateDisplay()
        {
            /*
             * Sets variables to current time
             */

            //changes month label to selected month
            String monthText = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            month_year_lbl.Text = monthText +" - "+ year;

            //GetScaledBounds the first day of the moth
            DateTime monthStart = new DateTime(year, month, 1);

            //Gets the total days in the month
            int days = DateTime.DaysInMonth(year, month);

            //Converts monthstart to an ineger
            int daysInWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d"));

            /*
             * Loops for user control
             */
            //Blank user control for last months
            for (int i = 0;i < daysInWeek; i++)
            {
                EmptyUserControl euc = new EmptyUserControl();
                month_container.Controls.Add(euc);
            }
            //This months user control
            for(int i = 1;i <= days; i++)
            {
                DayUserControl duc = new DayUserControl();
                duc.day(i);

                duc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                    | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left) 
                    | System.Windows.Forms.AnchorStyles.Right)));

                month_container.Controls.Add(duc);
                duc.eventsDisplay(i);
            }
        }

        /*
         * Buttons to switch selected month
         */

        //Used to go to next month
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //Clears the container
            month_container.Controls.Clear();
            //Checks to see if next changes year
            if (month == 12)
            {
                year += 1;
                month = 1;
            }
            else
            {
                month += 1;
            }
            dateDisplay();
        }

        //Used to go tothe previous month
        private void prevBtn_Click(object sender, EventArgs e)
        {
            month_container.Controls.Clear();
            //Checks to see if previous changes year
            if (month == 1)
            {
                year -= 1;
                month = 12;
            }
            else
            {
                month -= 1;
            }
            dateDisplay();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ColourControl.callColours(this);

            month_container.Controls.Clear();
            dateDisplay();
            coinDisplay();
        }
        /*
         * Functions for theme and auto sizing
         */

        //Dynamic scale
        private Rectangle originalFormSize;

        private float lblOriginalFontSize;
        private float buttonlOriginalFontSize;

        //Rectangles created when the for is loaded to save original sizes.
        private void Form1_Load(object sender, EventArgs e)
        {
            csvControl.Create();
            ColourControl.callColours(this);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);

            //Text
            lblOriginalFontSize = sunday_lbl.Font.Size;
            buttonlOriginalFontSize = nextBtn.Font.Size;

            largeFont = sunday_lbl.Font;
            smallFont = nextBtn.Font;

            shown = true;

            month_container.Controls.Clear();
            dateDisplay();
            coinDisplay();
        }
        private void coinDisplay()
        {
            string coinCount = coinControl.readCoins();
            themePage_btn.Text = ("Theme (" + coinCount + ")" );
        }

        public static Font largeFont;
        public static Font smallFont;
        //When for is being reszied the resize control function is called to calculate new sizes
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (shown)
            {
                //Loads the resize control class for each controll in the form.
                foreach (Control textc in this.Controls)
                {
                    resizeTest(textc);
                }

                largeFont = sunday_lbl.Font;
                smallFont = nextBtn.Font;
            }
        }

        public void resizeTest(Control textc)
        {
            if (textc is TableLayoutPanel)
            {
                foreach (Control c in textc.Controls)
                {
                    resizeTest(c);
                }
            }
            if (textc is Label)
            {
                ResizeControl.resizeTextControl(textc, lblOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
            if (textc is Button)
            {
                ResizeControl.resizeTextControl(textc, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
        }

        private void themePage_btn_Click(object sender, EventArgs e)
        {
            themes Themes = new themes();
            Themes.Show();
        }
    }
}

/* Refrences
 * https://stackoverflow.com/questions/3184121/get-month-name-from-month-number
 * https://github.com/cccu-uk/autorentals-Kieran-Rutter/tree/master/FormAutoRentals
 * 
 * 
 */