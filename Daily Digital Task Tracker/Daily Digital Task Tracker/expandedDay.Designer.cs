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
            this.label1 = new System.Windows.Forms.Label();
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
            this.task_pnl.RowCount = 1;
            this.task_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.task_pnl.Size = new System.Drawing.Size(207, 0);
            this.task_pnl.TabIndex = 0;
            // 
            // taskTBL_pnl
            // 
            this.taskTBL_pnl.AutoScroll = true;
            this.taskTBL_pnl.Controls.Add(this.task_pnl);
            this.taskTBL_pnl.Location = new System.Drawing.Point(12, 55);
            this.taskTBL_pnl.Name = "taskTBL_pnl";
            this.taskTBL_pnl.Size = new System.Drawing.Size(207, 796);
            this.taskTBL_pnl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // expandedDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 863);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskTBL_pnl);
            this.MaximumSize = new System.Drawing.Size(822, 919);
            this.Name = "expandedDay";
            this.Text = "expandedDay";
            this.Load += new System.EventHandler(this.expandedDay_Load);
            this.Shown += new System.EventHandler(this.expandedDay_Shown);
            this.Resize += new System.EventHandler(this.expandedDay_Resize);
            this.taskTBL_pnl.ResumeLayout(false);
            this.taskTBL_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel task_pnl;
        private System.Windows.Forms.Panel taskTBL_pnl;
        private System.Windows.Forms.Label label1;
    }
}