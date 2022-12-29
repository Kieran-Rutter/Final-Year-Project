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
            this.eventName_txt = new System.Windows.Forms.TextBox();
            this.eventDate_txt = new System.Windows.Forms.TextBox();
            this.CreateEvent_btn = new System.Windows.Forms.Button();
            this.eventTime_txt = new System.Windows.Forms.TextBox();
            this.time_btn = new System.Windows.Forms.Button();
            this.task_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // eventName_txt
            // 
            this.eventName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_txt.Location = new System.Drawing.Point(12, 53);
            this.eventName_txt.Name = "eventName_txt";
            this.eventName_txt.Size = new System.Drawing.Size(437, 35);
            this.eventName_txt.TabIndex = 0;
            // 
            // eventDate_txt
            // 
            this.eventDate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate_txt.Location = new System.Drawing.Point(12, 12);
            this.eventDate_txt.Name = "eventDate_txt";
            this.eventDate_txt.Size = new System.Drawing.Size(437, 35);
            this.eventDate_txt.TabIndex = 1;
            // 
            // CreateEvent_btn
            // 
            this.CreateEvent_btn.Location = new System.Drawing.Point(12, 372);
            this.CreateEvent_btn.Name = "CreateEvent_btn";
            this.CreateEvent_btn.Size = new System.Drawing.Size(101, 66);
            this.CreateEvent_btn.TabIndex = 2;
            this.CreateEvent_btn.Text = "Create";
            this.CreateEvent_btn.UseVisualStyleBackColor = true;
            this.CreateEvent_btn.Click += new System.EventHandler(this.CreateEvent_btn_Click);
            // 
            // eventTime_txt
            // 
            this.eventTime_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTime_txt.Location = new System.Drawing.Point(12, 94);
            this.eventTime_txt.Name = "eventTime_txt";
            this.eventTime_txt.Size = new System.Drawing.Size(437, 35);
            this.eventTime_txt.TabIndex = 3;
            // 
            // time_btn
            // 
            this.time_btn.Location = new System.Drawing.Point(453, 372);
            this.time_btn.Name = "time_btn";
            this.time_btn.Size = new System.Drawing.Size(101, 66);
            this.time_btn.TabIndex = 4;
            this.time_btn.Text = "Time";
            this.time_btn.UseVisualStyleBackColor = true;
            this.time_btn.Click += new System.EventHandler(this.time_btn_Click);
            // 
            // task_cmb
            // 
            this.task_cmb.FormattingEnabled = true;
            this.task_cmb.Location = new System.Drawing.Point(12, 136);
            this.task_cmb.Name = "task_cmb";
            this.task_cmb.Size = new System.Drawing.Size(437, 28);
            this.task_cmb.TabIndex = 5;
            // 
            // DayExpanded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task_cmb);
            this.Controls.Add(this.time_btn);
            this.Controls.Add(this.eventTime_txt);
            this.Controls.Add(this.CreateEvent_btn);
            this.Controls.Add(this.eventDate_txt);
            this.Controls.Add(this.eventName_txt);
            this.Name = "DayExpanded";
            this.Text = "DayExpanded";
            this.Load += new System.EventHandler(this.DayExpanded_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventName_txt;
        private System.Windows.Forms.TextBox eventDate_txt;
        private System.Windows.Forms.Button CreateEvent_btn;
        private System.Windows.Forms.TextBox eventTime_txt;
        private System.Windows.Forms.Button time_btn;
        private System.Windows.Forms.ComboBox task_cmb;
    }
}