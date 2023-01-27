namespace Daily_Digital_Task_Tracker
{
    partial class TaskUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.task_lbl = new System.Windows.Forms.Label();
            this.hours_lbl = new System.Windows.Forms.Label();
            this.mins_lbl = new System.Windows.Forms.Label();
            this.seconds_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task_lbl
            // 
            this.task_lbl.AutoSize = true;
            this.task_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.task_lbl.Location = new System.Drawing.Point(3, 3);
            this.task_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.task_lbl.Name = "task_lbl";
            this.task_lbl.Size = new System.Drawing.Size(99, 29);
            this.task_lbl.TabIndex = 0;
            this.task_lbl.Text = "task text";
            // 
            // hours_lbl
            // 
            this.hours_lbl.AutoSize = true;
            this.hours_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.hours_lbl.Location = new System.Drawing.Point(3, 32);
            this.hours_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hours_lbl.Name = "hours_lbl";
            this.hours_lbl.Size = new System.Drawing.Size(30, 29);
            this.hours_lbl.TabIndex = 1;
            this.hours_lbl.Text = "H";
            // 
            // mins_lbl
            // 
            this.mins_lbl.AutoSize = true;
            this.mins_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mins_lbl.Location = new System.Drawing.Point(3, 61);
            this.mins_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mins_lbl.Name = "mins_lbl";
            this.mins_lbl.Size = new System.Drawing.Size(33, 29);
            this.mins_lbl.TabIndex = 2;
            this.mins_lbl.Text = "M";
            // 
            // seconds_lbl
            // 
            this.seconds_lbl.AutoSize = true;
            this.seconds_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.seconds_lbl.Location = new System.Drawing.Point(4, 90);
            this.seconds_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seconds_lbl.Name = "seconds_lbl";
            this.seconds_lbl.Size = new System.Drawing.Size(29, 29);
            this.seconds_lbl.TabIndex = 3;
            this.seconds_lbl.Text = "S";
            // 
            // TaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.seconds_lbl);
            this.Controls.Add(this.mins_lbl);
            this.Controls.Add(this.hours_lbl);
            this.Controls.Add(this.task_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskUserControl";
            this.Size = new System.Drawing.Size(136, 130);
            this.Load += new System.EventHandler(this.TaskUserControl_Load);
            this.Click += new System.EventHandler(this.TaskUserControl_Click);
            this.Resize += new System.EventHandler(this.TaskUserControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task_lbl;
        private System.Windows.Forms.Label hours_lbl;
        private System.Windows.Forms.Label mins_lbl;
        private System.Windows.Forms.Label seconds_lbl;
    }
}
