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
            this.expand_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(4, 4);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(121, 29);
            this.date_lbl.TabIndex = 0;
            this.date_lbl.Text = "blankDate";
            // 
            // eventsDisplay_txt
            // 
            this.eventsDisplay_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsDisplay_txt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventsDisplay_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsDisplay_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsDisplay_txt.Location = new System.Drawing.Point(3, 36);
            this.eventsDisplay_txt.Multiline = true;
            this.eventsDisplay_txt.Name = "eventsDisplay_txt";
            this.eventsDisplay_txt.ReadOnly = true;
            this.eventsDisplay_txt.Size = new System.Drawing.Size(194, 96);
            this.eventsDisplay_txt.TabIndex = 1;
            this.eventsDisplay_txt.WordWrap = false;
            // 
            // expand_btn
            // 
            this.expand_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expand_btn.Location = new System.Drawing.Point(0, 138);
            this.expand_btn.Name = "expand_btn";
            this.expand_btn.Size = new System.Drawing.Size(200, 37);
            this.expand_btn.TabIndex = 2;
            this.expand_btn.Text = "+";
            this.expand_btn.UseVisualStyleBackColor = true;
            this.expand_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.expand_btn);
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
        private System.Windows.Forms.Button expand_btn;
    }
}
