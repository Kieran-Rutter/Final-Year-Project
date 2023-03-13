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
    public partial class themes : Form
    {
        public themes()
        {
            InitializeComponent();
        }
        //https://stackoverflow.com/questions/38185178/how-to-get-the-hex-color-code-from-a-color-dialog-in-visual-studio

        private void themes_Load(object sender, EventArgs e)
        {
            ColourControl.callColours(this);
        }
        private void themes_Activated(object sender, EventArgs e)
        {
            ColourControl.callColours(this);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                test_btn.BackColor = colorDialog1.Color;
                //colour_btn.Text = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            }
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            ColourControl.callColours(this);

            Settings set = new Settings();
            set.readIni();
            if (set.theme == "light")
            {
                Console.WriteLine("set to light");
                set.writeini("SECTION", "key", "dark");
                set.writeini("SECTION", "backColour", "F8F9FA");
                set.writeini("SECTION", "textColour", "000000");
                set.writeini("SECTION", "buttonBackColour", "CED4DA");
                set.writeini("SECTION", "buttonBorderColour", "ADB5BD");
            }
            else if (set.theme == "dark")
            {
                Console.WriteLine("set to dark");
                set.writeini("SECTION", "key", "light");
                set.writeini("SECTION", "backColour", "1C1C21");
                set.writeini("SECTION", "textColour", "FFF1F1F1");
                set.writeini("SECTION", "buttonBackColour", "393A41");
                set.writeini("SECTION", "buttonBorderColour", "4B4C52");
            }//https://stackoverflow.com/questions/22935285/change-color-of-all-controls-inside-the-form-in-c-sharp
        }

    }
}
