namespace Daily_Digital_Task_Tracker
{
    partial class DayExpanded
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventDate_txt = new System.Windows.Forms.TextBox();
            this.CreateEvent_btn = new System.Windows.Forms.Button();
            this.time_btn = new System.Windows.Forms.Button();
            this.seconds_cmb = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mins_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hours_cmb = new System.Windows.Forms.ComboBox();
            this.task_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // eventDate_txt
            // 
            this.eventDate_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventDate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate_txt.Location = new System.Drawing.Point(12, 12);
            this.eventDate_txt.Name = "eventDate_txt";
            this.eventDate_txt.Size = new System.Drawing.Size(126, 35);
            this.eventDate_txt.TabIndex = 1;
            this.eventDate_txt.Text = "44/44/4444";
            // 
            // CreateEvent_btn
            // 
            this.CreateEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEvent_btn.Location = new System.Drawing.Point(12, 372);
            this.CreateEvent_btn.Name = "CreateEvent_btn";
            this.CreateEvent_btn.Size = new System.Drawing.Size(101, 66);
            this.CreateEvent_btn.TabIndex = 2;
            this.CreateEvent_btn.Text = "Create";
            this.CreateEvent_btn.UseVisualStyleBackColor = true;
            this.CreateEvent_btn.Click += new System.EventHandler(this.CreateEvent_btn_Click);
            // 
            // time_btn
            // 
            this.time_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time_btn.Location = new System.Drawing.Point(453, 372);
            this.time_btn.Name = "time_btn";
            this.time_btn.Size = new System.Drawing.Size(101, 66);
            this.time_btn.TabIndex = 4;
            this.time_btn.Text = "Time";
            this.time_btn.UseVisualStyleBackColor = true;
            this.time_btn.Click += new System.EventHandler(this.time_btn_Click);
            // 
            // seconds_cmb
            // 
            this.seconds_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seconds_cmb.FormattingEnabled = true;
            this.seconds_cmb.Location = new System.Drawing.Point(665, 215);
            this.seconds_cmb.Name = "seconds_cmb";
            this.seconds_cmb.Size = new System.Drawing.Size(123, 28);
            this.seconds_cmb.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_btn
            // 
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Location = new System.Drawing.Point(574, 372);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(101, 66);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(455, 326);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 40);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // mins_cmb
            // 
            this.mins_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mins_cmb.FormattingEnabled = true;
            this.mins_cmb.Location = new System.Drawing.Point(665, 181);
            this.mins_cmb.Name = "mins_cmb";
            this.mins_cmb.Size = new System.Drawing.Size(123, 28);
            this.mins_cmb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "00:00:00";
            // 
            // hours_cmb
            // 
            this.hours_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hours_cmb.FormattingEnabled = true;
            this.hours_cmb.Location = new System.Drawing.Point(665, 147);
            this.hours_cmb.Name = "hours_cmb";
            this.hours_cmb.Size = new System.Drawing.Size(123, 28);
            this.hours_cmb.TabIndex = 12;
            // 
            // task_cmb
            // 
            this.task_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_cmb.FormattingEnabled = true;
            this.task_cmb.Location = new System.Drawing.Point(12, 53);
            this.task_cmb.Name = "task_cmb";
            this.task_cmb.Size = new System.Drawing.Size(437, 28);
            this.task_cmb.TabIndex = 13;
            this.task_cmb.SelectedIndexChanged += new System.EventHandler(this.task_cmb_SelectedIndexChanged);
            // 
            // DayExpanded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task_cmb);
            this.Controls.Add(this.hours_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mins_cmb);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.seconds_cmb);
            this.Controls.Add(this.time_btn);
            this.Controls.Add(this.CreateEvent_btn);
            this.Controls.Add(this.eventDate_txt);
            this.Name = "DayExpanded";
            this.Text = "DayExpanded";
            this.Load += new System.EventHandler(this.DayExpanded_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eventDate_txt;
        private System.Windows.Forms.Button CreateEvent_btn;
        private System.Windows.Forms.Button time_btn;
        private System.Windows.Forms.ComboBox seconds_cmb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox mins_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hours_cmb;
        private System.Windows.Forms.ComboBox task_cmb;
    }
}