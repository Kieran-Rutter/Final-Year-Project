
namespace Daily_Digital_Task_Tracker
{
    partial class themes
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.test_btn = new System.Windows.Forms.Button();
            this.try_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buyColour_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // test_btn
            // 
            this.test_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test_btn.Location = new System.Drawing.Point(3, 273);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(207, 78);
            this.test_btn.TabIndex = 1;
            this.test_btn.Text = "Dark/Light";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // try_btn
            // 
            this.try_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.try_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.try_btn.Location = new System.Drawing.Point(3, 408);
            this.try_btn.Name = "try_btn";
            this.try_btn.Size = new System.Drawing.Size(220, 129);
            this.try_btn.TabIndex = 3;
            this.try_btn.Text = "Select Colour";
            this.try_btn.UseVisualStyleBackColor = true;
            this.try_btn.Click += new System.EventHandler(this.try_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Location = new System.Drawing.Point(3, 678);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(220, 132);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Apply Colours";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.88306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.11694F));
            this.tableLayoutPanel1.Controls.Add(this.save_btn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buyColour_btn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.try_btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.test_btn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 813);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buyColour_btn
            // 
            this.buyColour_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyColour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyColour_btn.Location = new System.Drawing.Point(3, 543);
            this.buyColour_btn.Name = "buyColour_btn";
            this.buyColour_btn.Size = new System.Drawing.Size(220, 129);
            this.buyColour_btn.TabIndex = 5;
            this.buyColour_btn.Text = "Buy Colour";
            this.buyColour_btn.UseVisualStyleBackColor = true;
            this.buyColour_btn.Click += new System.EventHandler(this.buyColour_btn_Click);
            // 
            // themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 813);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1008, 852);
            this.MinimumSize = new System.Drawing.Size(1008, 852);
            this.Name = "themes";
            this.Activated += new System.EventHandler(this.themes_Activated);
            this.Load += new System.EventHandler(this.themes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button try_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buyColour_btn;
    }
}