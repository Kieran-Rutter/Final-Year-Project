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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(3, 0);
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
            this.eventsDisplay_txt.Location = new System.Drawing.Point(3, 32);
            this.eventsDisplay_txt.Multiline = true;
            this.eventsDisplay_txt.Name = "eventsDisplay_txt";
            this.eventsDisplay_txt.ReadOnly = true;
            this.eventsDisplay_txt.Size = new System.Drawing.Size(188, 134);
            this.eventsDisplay_txt.TabIndex = 1;
            this.eventsDisplay_txt.WordWrap = false;
            this.eventsDisplay_txt.Click += new System.EventHandler(this.eventsDisplay_txt_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.date_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventsDisplay_txt, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 169);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DayUserControl";
            this.Size = new System.Drawing.Size(200, 175);
            this.Load += new System.EventHandler(this.DayUserControl_Load);
            this.Click += new System.EventHandler(this.DayUserControl_Click);
            this.Resize += new System.EventHandler(this.DayUserControl_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.TextBox eventsDisplay_txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
