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
    //Blank user control to be placed at start of the month is the 1st is not a sunday.
    public partial class EmptyUserControl : UserControl
    {
        public EmptyUserControl()
        {
            InitializeComponent();
        }
    }
}
