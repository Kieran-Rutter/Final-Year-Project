
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
            this.colour_btn = new System.Windows.Forms.Button();
            this.test_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colour_btn
            // 
            this.colour_btn.Location = new System.Drawing.Point(12, 723);
            this.colour_btn.Name = "colour_btn";
            this.colour_btn.Size = new System.Drawing.Size(206, 78);
            this.colour_btn.TabIndex = 0;
            this.colour_btn.Text = "Colour Select";
            this.colour_btn.UseVisualStyleBackColor = true;
            this.colour_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(824, 723);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(156, 78);
            this.test_btn.TabIndex = 1;
            this.test_btn.Text = "Test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 813);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.colour_btn);
            this.MaximumSize = new System.Drawing.Size(1008, 852);
            this.MinimumSize = new System.Drawing.Size(1008, 852);
            this.Name = "themes";
            this.Text = "themes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colour_btn;
        private System.Windows.Forms.Button test_btn;
    }
}