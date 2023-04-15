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

        private void try_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string search = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");

                File.WriteAllLines("Temp.csv", File.ReadAllLines("Theme.csv").Where(line => search.Equals(line.Split(',')[0])));

                using (StreamReader tempRead = new StreamReader("Temp.csv"))
                {

                    if ((tempRead.ReadLine()) == null)
                    {
                        save_btn.Text = "Buy Colour \n" +
                                        "-1 Coin";
                    }
                    else
                    {
                        save_btn.Text = "Apply Colour";
                    }
                }

                try_btn.BackColor = colorDialog1.Color;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            int coinCount = Int32.Parse(coinControl.readCoins());

            string newHex = (try_btn.BackColor.ToArgb() & 0x00FFFFFF).ToString("X6");

            if (save_btn.Text == "Apply Colour")
            {
                MessageBox.Show(newHex);
                set.writeini("SECTION", "themeColour", (newHex + "\n"));
                ColourControl.callColours(this);
            }
            else
            {
                if (coinCount <= 0)
                {
                    MessageBox.Show("Not enough coins \n" +
                                    "Complete more tasks to earn coins");
                }
                else
                {
                    save_btn.Text = "Apply Colour";
                    csvControl.Append("Theme.csv", newHex);
                }
            }
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            ColourControl.callColours(this);

            Settings set = new Settings();
            set.readIni();
            set.writeini("SECTION", "themeColour", "1C1C21");
            //https://stackoverflow.com/questions/22935285/change-color-of-all-controls-inside-the-form-in-c-sharp
            ColourControl.callColours(this);
        }

        private void buyColour_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
