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
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                button1.Text = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            }
        }
    }
}
