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
            this.SuspendLayout();
            // 
            // eventName_txt
            // 
            this.eventName_txt.Location = new System.Drawing.Point(12, 391);
            this.eventName_txt.Name = "eventName_txt";
            this.eventName_txt.Size = new System.Drawing.Size(437, 26);
            this.eventName_txt.TabIndex = 0;
            // 
            // eventDate_txt
            // 
            this.eventDate_txt.Location = new System.Drawing.Point(12, 350);
            this.eventDate_txt.Name = "eventDate_txt";
            this.eventDate_txt.Size = new System.Drawing.Size(437, 26);
            this.eventDate_txt.TabIndex = 1;
            // 
            // CreateEvent_btn
            // 
            this.CreateEvent_btn.Location = new System.Drawing.Point(465, 350);
            this.CreateEvent_btn.Name = "CreateEvent_btn";
            this.CreateEvent_btn.Size = new System.Drawing.Size(101, 66);
            this.CreateEvent_btn.TabIndex = 2;
            this.CreateEvent_btn.Text = "Create";
            this.CreateEvent_btn.UseVisualStyleBackColor = true;
            this.CreateEvent_btn.Click += new System.EventHandler(this.CreateEvent_btn_Click);
            // 
            // DayExpanded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateEvent_btn);
            this.Controls.Add(this.eventDate_txt);
            this.Controls.Add(this.eventName_txt);
            this.Name = "DayExpanded";
            this.Text = "DayExpanded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventName_txt;
        private System.Windows.Forms.TextBox eventDate_txt;
        private System.Windows.Forms.Button CreateEvent_btn;
    }
}