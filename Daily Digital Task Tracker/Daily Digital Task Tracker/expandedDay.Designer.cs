namespace Daily_Digital_Task_Tracker
{
    partial class expandedDay
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
            this.task_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.taskTBL_pnl = new System.Windows.Forms.Panel();
            this.taskTBL_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // task_pnl
            // 
            this.task_pnl.AutoSize = true;
            this.task_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.task_pnl.ColumnCount = 1;
            this.task_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.task_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.task_pnl.Location = new System.Drawing.Point(0, 0);
            this.task_pnl.Name = "task_pnl";
            this.task_pnl.RowCount = 3;
            this.task_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.task_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.task_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.task_pnl.Size = new System.Drawing.Size(207, 0);
            this.task_pnl.TabIndex = 0;
            // 
            // taskTBL_pnl
            // 
            this.taskTBL_pnl.AutoScroll = true;
            this.taskTBL_pnl.Controls.Add(this.task_pnl);
            this.taskTBL_pnl.Location = new System.Drawing.Point(12, 12);
            this.taskTBL_pnl.Name = "taskTBL_pnl";
            this.taskTBL_pnl.Size = new System.Drawing.Size(207, 839);
            this.taskTBL_pnl.TabIndex = 1;
            // 
            // expandedDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 863);
            this.Controls.Add(this.taskTBL_pnl);
            this.Name = "expandedDay";
            this.Text = "expandedDay";
            this.Load += new System.EventHandler(this.expandedDay_Load);
            this.taskTBL_pnl.ResumeLayout(false);
            this.taskTBL_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel task_pnl;
        private System.Windows.Forms.Panel taskTBL_pnl;
    }
}