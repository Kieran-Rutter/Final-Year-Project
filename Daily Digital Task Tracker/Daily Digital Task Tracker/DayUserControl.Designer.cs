namespace Daily_Digital_Task_Tracker
{
    partial class DayUserControl
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
            this.date_lbl = new System.Windows.Forms.Label();
            this.eventsDisplay_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(4, 4);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(82, 20);
            this.date_lbl.TabIndex = 0;
            this.date_lbl.Text = "blankDate";
            // 
            // eventsDisplay_txt
            // 
            this.eventsDisplay_txt.Location = new System.Drawing.Point(4, 28);
            this.eventsDisplay_txt.Multiline = true;
            this.eventsDisplay_txt.Name = "eventsDisplay_txt";
            this.eventsDisplay_txt.Size = new System.Drawing.Size(193, 144);
            this.eventsDisplay_txt.TabIndex = 1;
            // 
            // DayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.eventsDisplay_txt);
            this.Controls.Add(this.date_lbl);
            this.Name = "DayUserControl";
            this.Size = new System.Drawing.Size(200, 175);
            this.Click += new System.EventHandler(this.DayUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.TextBox eventsDisplay_txt;
    }
}
