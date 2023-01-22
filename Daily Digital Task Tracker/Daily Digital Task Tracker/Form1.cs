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
        //gets date
        static DateTime currentTime = DateTime.Now;
        public static int month = currentTime.Month;
        public static int year = currentTime.Year;
        public Form1()
        {
            InitializeComponent();
            CreateCSV();
            getIni();
            dateDisplay();
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

        //Creates file in bin/debug
        private void CreateCSV()
        {
            try
            {
                StreamWriter sw = new StreamWriter(File.Open("config.ini", System.IO.FileMode.CreateNew));
                Console.WriteLine("File created");
                sw.Close();
                File.AppendAllText("config.ini", "[SECTION]" + "\n");
                File.AppendAllText("config.ini", "key = light" + "\n");
                File.AppendAllText("config.ini", "backColour = F8F9FA" + "\n");
                File.AppendAllText("config.ini", "textColour = 000000" + "\n");
                File.AppendAllText("config.ini", "buttonBackColour = CED4DA" + "\n");
                File.AppendAllText("config.ini", "buttonBorderColour = ADB5BD" + "\n");
            }
            catch (IOException)
            {
                Console.WriteLine("File already exists");
            }
            //Makes sure that the files exist if not they are made.
            try
            {
                StreamWriter sw = new StreamWriter(File.Open("Events.csv", System.IO.FileMode.CreateNew));
                Console.WriteLine("File created");
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("File already exists");
            }

            try
            {
                StreamWriter sw = new StreamWriter(File.Open("Temp.csv", System.IO.FileMode.CreateNew));
                Console.WriteLine("File created");
                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("File already exists");
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
            for (int i = 1;i < daysInWeek; i++)
            {
                EmptyUserControl euc = new EmptyUserControl();
                month_container.Controls.Add(euc);
            }
            int row = 0;
            //This months user control
            for(int i = 1;i <= days; i++)
            {
                DayUserControl duc = new DayUserControl();
                duc.day(i);

                if (i % 7 == 0) { row++;}

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
            month_container.Controls.Clear();
            dateDisplay();
        }

        //Will be moved to another form later
        private void Themebtn_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.readIni();
            if (set.theme == "light")
            {
                set.writeini("SECTION", "key", "dark");
                set.writeini("SECTION", "backColour", "F8F9FA");
                set.writeini("SECTION", "textColour", "000000");
                set.writeini("SECTION", "buttonBackColour", "CED4DA");
                set.writeini("SECTION", "buttonBorderColour", "ADB5BD");
            }
            else if (set.theme == "dark")
            {
                Console.WriteLine("dark");
                set.writeini("SECTION", "key", "light");
                set.writeini("SECTION", "backColour", "1C1C21");
                set.writeini("SECTION", "textColour", "FFF1F1F1");
                set.writeini("SECTION", "buttonBackColour", "393A41");
                set.writeini("SECTION", "buttonBorderColour", "4B4C52");
            }
            getIni();
            month_container.Controls.Clear();
            dateDisplay();
        }

        /*
         * Functions for theme and auto sizing
         */

        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
        public static String buttonBorderColour;

        //https://learn.microsoft.com/en-us/visualstudio/extensibility/ux-guidelines/color-value-reference-for-visual-studio?view=vs-2022
        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();
            //https://coolors.co/palettes/trending
            //https://coolors.co/palette/131316-1c1c21-26262c-2f3037-393a41-4b4c52-5b5c62-6a6b70

            backColour = settings.backColour;
            textColour = settings.textColour;
            buttonBackColour = settings.buttonBackColour;
            buttonBorderColour = settings.buttonBorderColour;


            this.BackColor = ColorTranslator.FromHtml(backColour);
            month_container.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            //Button colours
            this.nextBtn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.nextBtn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
            this.nextBtn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);

            this.prevBtn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.prevBtn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
            this.prevBtn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);

            this.Themebtn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.Themebtn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
            this.Themebtn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);
            //Label colours
            this.month_year_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.monday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.tuesday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.wednesday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.thursday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.friday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.saturday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.sunday_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
        }

        //Dynamic scale
        private Rectangle originalFormSize;
        private Rectangle ThemebtnOriginalRectangle;
        private Rectangle nextBtnOriginalRectangle;
        private Rectangle prevBtnOriginalRectangle;
        private Rectangle Dates_lbl_ContainerOriginalRectangle;
        private Rectangle month_containerOriginalRectangle;

        private float lblOriginalFontSize;
        private float buttonlOriginalFontSize;

        private float fontScale = 1f;

        //Rectangles created when the for is loaded to save original sizes.
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            ThemebtnOriginalRectangle = new Rectangle(Themebtn.Location.X, Themebtn.Location.Y, Themebtn.Width, Themebtn.Height);
            nextBtnOriginalRectangle = new Rectangle(nextBtn.Location.X, nextBtn.Location.Y, nextBtn.Width, nextBtn.Height);
            prevBtnOriginalRectangle = new Rectangle(prevBtn.Location.X, prevBtn.Location.Y, prevBtn.Width, prevBtn.Height);
            Dates_lbl_ContainerOriginalRectangle = new Rectangle(Dates_lbl_Container.Location.X,
                Dates_lbl_Container.Location.Y, Dates_lbl_Container.Width, Dates_lbl_Container.Height);
            month_containerOriginalRectangle = new Rectangle(month_container.Location.X, month_container.Location.Y, month_container.Width, month_container.Height);


            //Text
            lblOriginalFontSize = sunday_lbl.Font.Size;
            buttonlOriginalFontSize = nextBtn.Font.Size;

            largeFont = sunday_lbl.Font;
            smallFont = nextBtn.Font;
        }
        public static Font largeFont;
        public static Font smallFont;
        //When for is being reszied the resize control function is called to calculate new sizes
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(ThemebtnOriginalRectangle, Themebtn, buttonlOriginalFontSize);
            resizeControl(nextBtnOriginalRectangle, nextBtn, buttonlOriginalFontSize);
            resizeControl(prevBtnOriginalRectangle, prevBtn, buttonlOriginalFontSize);
            resizeControl(Dates_lbl_ContainerOriginalRectangle, Dates_lbl_Container, lblOriginalFontSize);
            //Need to redo text size.
            resizeControl(month_containerOriginalRectangle, month_container, lblOriginalFontSize);

            resizeControl(month_containerOriginalRectangle, month_year_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, sunday_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, monday_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, tuesday_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, wednesday_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, thursday_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, friday_lbl, lblOriginalFontSize);
            resizeControl(month_containerOriginalRectangle, saturday_lbl, lblOriginalFontSize);

            largeFont = sunday_lbl.Font;
            smallFont = nextBtn.Font;
        }
        //Resize control function to calculate new sizes
        public void resizeControl(Rectangle r, Control c, float originalFontSize)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width );
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if(xRatio >= yRatio)
            {
                ratio = yRatio;
            }

            float newFontSize = originalFontSize * ratio * fontScale;
            Font newFont = new Font(c.Font.FontFamily, newFontSize);
            c.Font = newFont;
        }
    }
}

/* Refrences
 * https://stackoverflow.com/questions/3184121/get-month-name-from-month-number
 * https://github.com/cccu-uk/autorentals-Kieran-Rutter/tree/master/FormAutoRentals
 * 
 * 
 */