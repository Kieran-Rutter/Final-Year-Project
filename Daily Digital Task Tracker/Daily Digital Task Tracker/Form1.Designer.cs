namespace Daily_Digital_Task_Tracker
{
    partial class Form1
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
            this.month_container = new System.Windows.Forms.FlowLayoutPanel();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.sunday_lbl = new System.Windows.Forms.Label();
            this.monday_lbl = new System.Windows.Forms.Label();
            this.tuesday_lbl = new System.Windows.Forms.Label();
            this.wednesday_lbl = new System.Windows.Forms.Label();
            this.thursday_lbl = new System.Windows.Forms.Label();
            this.friday_lbl = new System.Windows.Forms.Label();
            this.saturday_lbl = new System.Windows.Forms.Label();
            this.month_year_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // month_container
            // 
            this.month_container.Location = new System.Drawing.Point(12, 90);
            this.month_container.Name = "month_container";
            this.month_container.Size = new System.Drawing.Size(1445, 944);
            this.month_container.TabIndex = 0;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(12, 1040);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(136, 118);
            this.prevBtn.TabIndex = 1;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(154, 1040);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(139, 118);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // sunday_lbl
            // 
            this.sunday_lbl.AutoSize = true;
            this.sunday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday_lbl.Location = new System.Drawing.Point(44, 39);
            this.sunday_lbl.Name = "sunday_lbl";
            this.sunday_lbl.Size = new System.Drawing.Size(135, 48);
            this.sunday_lbl.TabIndex = 3;
            this.sunday_lbl.Text = "Sunday";
            // 
            // monday_lbl
            // 
            this.monday_lbl.AutoSize = true;
            this.monday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday_lbl.Location = new System.Drawing.Point(246, 42);
            this.monday_lbl.Name = "monday_lbl";
            this.monday_lbl.Size = new System.Drawing.Size(149, 48);
            this.monday_lbl.TabIndex = 4;
            this.monday_lbl.Text = "Monday";
            // 
            // tuesday_lbl
            // 
            this.tuesday_lbl.AutoSize = true;
            this.tuesday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday_lbl.Location = new System.Drawing.Point(454, 39);
            this.tuesday_lbl.Name = "tuesday_lbl";
            this.tuesday_lbl.Size = new System.Drawing.Size(149, 48);
            this.tuesday_lbl.TabIndex = 5;
            this.tuesday_lbl.Text = "Tuesday";
            // 
            // wednesday_lbl
            // 
            this.wednesday_lbl.AutoSize = true;
            this.wednesday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday_lbl.Location = new System.Drawing.Point(629, 39);
            this.wednesday_lbl.Name = "wednesday_lbl";
            this.wednesday_lbl.Size = new System.Drawing.Size(204, 48);
            this.wednesday_lbl.TabIndex = 6;
            this.wednesday_lbl.Text = "Wednesday";
            // 
            // thursday_lbl
            // 
            this.thursday_lbl.AutoSize = true;
            this.thursday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday_lbl.Location = new System.Drawing.Point(855, 39);
            this.thursday_lbl.Name = "thursday_lbl";
            this.thursday_lbl.Size = new System.Drawing.Size(163, 48);
            this.thursday_lbl.TabIndex = 7;
            this.thursday_lbl.Text = "Thursday";
            // 
            // friday_lbl
            // 
            this.friday_lbl.AutoSize = true;
            this.friday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday_lbl.Location = new System.Drawing.Point(1087, 39);
            this.friday_lbl.Name = "friday_lbl";
            this.friday_lbl.Size = new System.Drawing.Size(116, 48);
            this.friday_lbl.TabIndex = 8;
            this.friday_lbl.Text = "Friday";
            // 
            // saturday_lbl
            // 
            this.saturday_lbl.AutoSize = true;
            this.saturday_lbl.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday_lbl.Location = new System.Drawing.Point(1272, 39);
            this.saturday_lbl.Name = "saturday_lbl";
            this.saturday_lbl.Size = new System.Drawing.Size(158, 48);
            this.saturday_lbl.TabIndex = 9;
            this.saturday_lbl.Text = "Saturday";
            // 
            // month_year_lbl
            // 
            this.month_year_lbl.AutoSize = true;
            this.month_year_lbl.Location = new System.Drawing.Point(52, 13);
            this.month_year_lbl.Name = "month_year_lbl";
            this.month_year_lbl.Size = new System.Drawing.Size(171, 20);
            this.month_year_lbl.TabIndex = 10;
            this.month_year_lbl.Text = "MonthYearPlaceholder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 1170);
            this.Controls.Add(this.month_year_lbl);
            this.Controls.Add(this.saturday_lbl);
            this.Controls.Add(this.friday_lbl);
            this.Controls.Add(this.thursday_lbl);
            this.Controls.Add(this.wednesday_lbl);
            this.Controls.Add(this.tuesday_lbl);
            this.Controls.Add(this.monday_lbl);
            this.Controls.Add(this.sunday_lbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.month_container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel month_container;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label sunday_lbl;
        private System.Windows.Forms.Label monday_lbl;
        private System.Windows.Forms.Label tuesday_lbl;
        private System.Windows.Forms.Label wednesday_lbl;
        private System.Windows.Forms.Label thursday_lbl;
        private System.Windows.Forms.Label friday_lbl;
        private System.Windows.Forms.Label saturday_lbl;
        private System.Windows.Forms.Label month_year_lbl;
    }
}

