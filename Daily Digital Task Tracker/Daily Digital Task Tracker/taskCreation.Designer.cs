namespace Daily_Digital_Task_Tracker
{
    partial class taskCreation
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
            this.CreateEvent_btn = new System.Windows.Forms.Button();
            this.seconds_cmb = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mins_cmb = new System.Windows.Forms.ComboBox();
            this.hours_cmb = new System.Windows.Forms.ComboBox();
            this.task_cmb = new System.Windows.Forms.ComboBox();
            this.date_lbl = new System.Windows.Forms.Label();
            this.taskName_lbl = new System.Windows.Forms.Label();
            this.seconds_lbl = new System.Windows.Forms.Label();
            this.mins_lbl = new System.Windows.Forms.Label();
            this.hours_lbl = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateEvent_btn
            // 
            this.CreateEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEvent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEvent_btn.Location = new System.Drawing.Point(8, 276);
            this.CreateEvent_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateEvent_btn.Name = "CreateEvent_btn";
            this.CreateEvent_btn.Size = new System.Drawing.Size(73, 36);
            this.CreateEvent_btn.TabIndex = 2;
            this.CreateEvent_btn.Text = "Create";
            this.CreateEvent_btn.UseVisualStyleBackColor = true;
            this.CreateEvent_btn.Click += new System.EventHandler(this.CreateEvent_btn_Click);
            // 
            // seconds_cmb
            // 
            this.seconds_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seconds_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_cmb.FormattingEnabled = true;
            this.seconds_cmb.Location = new System.Drawing.Point(7, 244);
            this.seconds_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seconds_cmb.Name = "seconds_cmb";
            this.seconds_cmb.Size = new System.Drawing.Size(227, 28);
            this.seconds_cmb.TabIndex = 5;
            // 
            // mins_cmb
            // 
            this.mins_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mins_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins_cmb.FormattingEnabled = true;
            this.mins_cmb.Location = new System.Drawing.Point(8, 186);
            this.mins_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mins_cmb.Name = "mins_cmb";
            this.mins_cmb.Size = new System.Drawing.Size(227, 28);
            this.mins_cmb.TabIndex = 10;
            // 
            // hours_cmb
            // 
            this.hours_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hours_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_cmb.FormattingEnabled = true;
            this.hours_cmb.Location = new System.Drawing.Point(8, 122);
            this.hours_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hours_cmb.Name = "hours_cmb";
            this.hours_cmb.Size = new System.Drawing.Size(227, 28);
            this.hours_cmb.TabIndex = 12;
            // 
            // task_cmb
            // 
            this.task_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_cmb.FormattingEnabled = true;
            this.task_cmb.Location = new System.Drawing.Point(8, 64);
            this.task_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task_cmb.Name = "task_cmb";
            this.task_cmb.Size = new System.Drawing.Size(227, 28);
            this.task_cmb.TabIndex = 13;
            this.task_cmb.SelectedIndexChanged += new System.EventHandler(this.task_cmb_SelectedIndexChanged);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(8, 6);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(120, 26);
            this.date_lbl.TabIndex = 14;
            this.date_lbl.Text = "44/44/4444";
            // 
            // taskName_lbl
            // 
            this.taskName_lbl.AutoSize = true;
            this.taskName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.taskName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName_lbl.Location = new System.Drawing.Point(8, 38);
            this.taskName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskName_lbl.Name = "taskName_lbl";
            this.taskName_lbl.Size = new System.Drawing.Size(129, 26);
            this.taskName_lbl.TabIndex = 15;
            this.taskName_lbl.Text = "Task Name:";
            // 
            // seconds_lbl
            // 
            this.seconds_lbl.AutoSize = true;
            this.seconds_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_lbl.Location = new System.Drawing.Point(8, 216);
            this.seconds_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seconds_lbl.Name = "seconds_lbl";
            this.seconds_lbl.Size = new System.Drawing.Size(103, 26);
            this.seconds_lbl.TabIndex = 16;
            this.seconds_lbl.Text = "Seconds:";
            // 
            // mins_lbl
            // 
            this.mins_lbl.AutoSize = true;
            this.mins_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins_lbl.Location = new System.Drawing.Point(8, 158);
            this.mins_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mins_lbl.Name = "mins_lbl";
            this.mins_lbl.Size = new System.Drawing.Size(94, 26);
            this.mins_lbl.TabIndex = 17;
            this.mins_lbl.Text = "Minutes:";
            // 
            // hours_lbl
            // 
            this.hours_lbl.AutoSize = true;
            this.hours_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_lbl.Location = new System.Drawing.Point(8, 94);
            this.hours_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hours_lbl.Name = "hours_lbl";
            this.hours_lbl.Size = new System.Drawing.Size(76, 26);
            this.hours_lbl.TabIndex = 18;
            this.hours_lbl.Text = "Hours:";
            // 
            // delete_btn
            // 
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(162, 276);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(73, 36);
            this.delete_btn.TabIndex = 19;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(85, 276);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(73, 36);
            this.edit_btn.TabIndex = 20;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // taskCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 323);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.hours_lbl);
            this.Controls.Add(this.mins_lbl);
            this.Controls.Add(this.seconds_lbl);
            this.Controls.Add(this.taskName_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.task_cmb);
            this.Controls.Add(this.hours_cmb);
            this.Controls.Add(this.mins_cmb);
            this.Controls.Add(this.seconds_cmb);
            this.Controls.Add(this.CreateEvent_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(261, 343);
            this.Name = "taskCreation";
            this.Text = "Task Create";
            this.Load += new System.EventHandler(this.DayExpanded_Load);
            this.Shown += new System.EventHandler(this.DayExpanded_Shown);
            this.Resize += new System.EventHandler(this.DayExpanded_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateEvent_btn;
        private System.Windows.Forms.ComboBox seconds_cmb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox mins_cmb;
        private System.Windows.Forms.ComboBox hours_cmb;
        private System.Windows.Forms.ComboBox task_cmb;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label taskName_lbl;
        private System.Windows.Forms.Label seconds_lbl;
        private System.Windows.Forms.Label mins_lbl;
        private System.Windows.Forms.Label hours_lbl;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
    }
}