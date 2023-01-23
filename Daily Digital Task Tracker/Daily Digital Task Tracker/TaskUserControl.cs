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
    public partial class TaskUserControl : UserControl
    {
        public TaskUserControl()
        {
            InitializeComponent();
        }

        public void taskDisplay()
        {
            task_lbl.Text = expandedDay.task[1];
        }
    }
}
