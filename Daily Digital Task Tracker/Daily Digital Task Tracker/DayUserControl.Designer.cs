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
            this.eventsDisplay_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.date_lbl = new System.Windows.Forms.Label();
            this.taskCount_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsDisplay_txt
            // 
            this.eventsDisplay_txt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventsDisplay_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.eventsDisplay_txt, 2);
            this.eventsDisplay_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsDisplay_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsDisplay_txt.Location = new System.Drawing.Point(2, 31);
            this.eventsDisplay_txt.Margin = new System.Windows.Forms.Padding(2);
            this.eventsDisplay_txt.Multiline = true;
            this.eventsDisplay_txt.Name = "eventsDisplay_txt";
            this.eventsDisplay_txt.ReadOnly = true;
            this.eventsDisplay_txt.Size = new System.Drawing.Size(129, 81);
            this.eventsDisplay_txt.TabIndex = 1;
            this.eventsDisplay_txt.WordWrap = false;
            this.eventsDisplay_txt.Click += new System.EventHandler(this.eventsDisplay_txt_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.date_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventsDisplay_txt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taskCount_lbl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 114);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.date_lbl.Location = new System.Drawing.Point(2, 0);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(39, 29);
            this.date_lbl.TabIndex = 0;
            this.date_lbl.Text = "44";
            // 
            // taskCount_lbl
            // 
            this.taskCount_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskCount_lbl.AutoSize = true;
            this.taskCount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCount_lbl.Location = new System.Drawing.Point(130, 0);
            this.taskCount_lbl.Name = "taskCount_lbl";
            this.taskCount_lbl.Size = new System.Drawing.Size(0, 16);
            this.taskCount_lbl.TabIndex = 2;
            // 
            // DayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DayUserControl";
            this.Size = new System.Drawing.Size(133, 114);
            this.Load += new System.EventHandler(this.DayUserControl_Load);
            this.Click += new System.EventHandler(this.DayUserControl_Click);
            this.Resize += new System.EventHandler(this.DayUserControl_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox eventsDisplay_txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label taskCount_lbl;
    }
}
