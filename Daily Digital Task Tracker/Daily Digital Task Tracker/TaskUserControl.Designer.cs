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
            this.SuspendLayout();
            // 
            // task_lbl
            // 
            this.task_lbl.AutoSize = true;
            this.task_lbl.Location = new System.Drawing.Point(4, 4);
            this.task_lbl.Name = "task_lbl";
            this.task_lbl.Size = new System.Drawing.Size(51, 20);
            this.task_lbl.TabIndex = 0;
            this.task_lbl.Text = "label1";
            // 
            // TaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.task_lbl);
            this.Name = "TaskUserControl";
            this.Size = new System.Drawing.Size(204, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task_lbl;
    }
}
