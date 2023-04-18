
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
            this.resetTheme_btn = new System.Windows.Forms.Button();
            this.try_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentThemeGrid = new System.Windows.Forms.TableLayoutPanel();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hex_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.CurrentThemeGrid.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetTheme_btn
            // 
            this.resetTheme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTheme_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resetTheme_btn.Location = new System.Drawing.Point(3, 3);
            this.resetTheme_btn.Name = "resetTheme_btn";
            this.resetTheme_btn.Size = new System.Drawing.Size(191, 126);
            this.resetTheme_btn.TabIndex = 1;
            this.resetTheme_btn.Text = "Reset Theme";
            this.resetTheme_btn.UseVisualStyleBackColor = true;
            this.resetTheme_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // try_btn
            // 
            this.try_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.try_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.try_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.try_btn.Location = new System.Drawing.Point(3, 66);
            this.try_btn.Name = "try_btn";
            this.try_btn.Size = new System.Drawing.Size(185, 57);
            this.try_btn.TabIndex = 3;
            this.try_btn.Text = "Select Colour";
            this.try_btn.UseVisualStyleBackColor = true;
            this.try_btn.Click += new System.EventHandler(this.try_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.save_btn.Location = new System.Drawing.Point(791, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(192, 126);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Apply Colour";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.CurrentThemeGrid, 0, 5);
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
            // CurrentThemeGrid
            // 
            this.CurrentThemeGrid.ColumnCount = 5;
            this.CurrentThemeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentThemeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentThemeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentThemeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentThemeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentThemeGrid.Controls.Add(this.save_btn, 4, 0);
            this.CurrentThemeGrid.Controls.Add(this.resetTheme_btn, 0, 0);
            this.CurrentThemeGrid.Controls.Add(this.prev_btn, 1, 0);
            this.CurrentThemeGrid.Controls.Add(this.next_btn, 3, 0);
            this.CurrentThemeGrid.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.CurrentThemeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentThemeGrid.Location = new System.Drawing.Point(3, 678);
            this.CurrentThemeGrid.Name = "CurrentThemeGrid";
            this.CurrentThemeGrid.RowCount = 1;
            this.CurrentThemeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentThemeGrid.Size = new System.Drawing.Size(986, 132);
            this.CurrentThemeGrid.TabIndex = 5;
            // 
            // prev_btn
            // 
            this.prev_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.prev_btn.Location = new System.Drawing.Point(200, 3);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(191, 126);
            this.prev_btn.TabIndex = 6;
            this.prev_btn.Text = "< Prev";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.next_btn.Location = new System.Drawing.Point(594, 3);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(191, 126);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = "Next >";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.try_btn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.hex_lbl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 126);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // hex_lbl
            // 
            this.hex_lbl.AutoSize = true;
            this.hex_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hex_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.hex_lbl.Location = new System.Drawing.Point(3, 0);
            this.hex_lbl.Name = "hex_lbl";
            this.hex_lbl.Size = new System.Drawing.Size(185, 63);
            this.hex_lbl.TabIndex = 8;
            this.hex_lbl.Text = "HEX";
            this.hex_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Text = "Themes";
            this.Activated += new System.EventHandler(this.themes_Activated);
            this.Load += new System.EventHandler(this.themes_Load);
            this.Leave += new System.EventHandler(this.themes_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CurrentThemeGrid.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button resetTheme_btn;
        private System.Windows.Forms.Button try_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel CurrentThemeGrid;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label hex_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}