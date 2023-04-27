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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.task_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.taskTBL_pnl = new System.Windows.Forms.Panel();
            this.tasks_lbl = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.graphsTitle_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statisticsGridView = new System.Windows.Forms.DataGridView();
            this.stats_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.completionRation_lbl = new System.Windows.Forms.Label();
            this.CompletionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.taskTBL_pnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGridView)).BeginInit();
            this.stats_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompletionChart)).BeginInit();
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
            this.task_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.task_pnl.Name = "task_pnl";
            this.task_pnl.RowCount = 1;
            this.task_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.task_pnl.Size = new System.Drawing.Size(126, 0);
            this.task_pnl.TabIndex = 0;
            // 
            // taskTBL_pnl
            // 
            this.taskTBL_pnl.AutoScroll = true;
            this.taskTBL_pnl.Controls.Add(this.task_pnl);
            this.taskTBL_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTBL_pnl.Location = new System.Drawing.Point(2, 34);
            this.taskTBL_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.taskTBL_pnl.Name = "taskTBL_pnl";
            this.taskTBL_pnl.Size = new System.Drawing.Size(126, 471);
            this.taskTBL_pnl.TabIndex = 1;
            // 
            // tasks_lbl
            // 
            this.tasks_lbl.AutoSize = true;
            this.tasks_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasks_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_lbl.Location = new System.Drawing.Point(2, 0);
            this.tasks_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tasks_lbl.Name = "tasks_lbl";
            this.tasks_lbl.Size = new System.Drawing.Size(126, 32);
            this.tasks_lbl.TabIndex = 2;
            this.tasks_lbl.Text = "Tasks";
            this.tasks_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // create_btn
            // 
            this.create_btn.AutoSize = true;
            this.create_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(2, 509);
            this.create_btn.Margin = new System.Windows.Forms.Padding(2);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(126, 50);
            this.create_btn.TabIndex = 12;
            this.create_btn.Text = "Create / Edit";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // graphsTitle_lbl
            // 
            this.graphsTitle_lbl.AutoSize = true;
            this.graphsTitle_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphsTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphsTitle_lbl.Location = new System.Drawing.Point(132, 0);
            this.graphsTitle_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.graphsTitle_lbl.Name = "graphsTitle_lbl";
            this.graphsTitle_lbl.Size = new System.Drawing.Size(399, 32);
            this.graphsTitle_lbl.TabIndex = 13;
            this.graphsTitle_lbl.Text = "Statistics";
            this.graphsTitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.57786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.42214F));
            this.tableLayoutPanel1.Controls.Add(this.create_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.taskTBL_pnl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tasks_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.graphsTitle_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stats_pnl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.completionRation_lbl, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.772812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.9162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.497207F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 561);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // statisticsGridView
            // 
            this.statisticsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statisticsGridView.Location = new System.Drawing.Point(3, 3);
            this.statisticsGridView.Name = "statisticsGridView";
            this.statisticsGridView.Size = new System.Drawing.Size(391, 228);
            this.statisticsGridView.TabIndex = 14;
            // 
            // stats_pnl
            // 
            this.stats_pnl.ColumnCount = 1;
            this.stats_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stats_pnl.Controls.Add(this.statisticsGridView, 0, 0);
            this.stats_pnl.Controls.Add(this.CompletionChart, 0, 1);
            this.stats_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stats_pnl.Location = new System.Drawing.Point(133, 35);
            this.stats_pnl.Name = "stats_pnl";
            this.stats_pnl.RowCount = 2;
            this.stats_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stats_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.stats_pnl.Size = new System.Drawing.Size(397, 469);
            this.stats_pnl.TabIndex = 15;
            // 
            // completionRation_lbl
            // 
            this.completionRation_lbl.AutoSize = true;
            this.completionRation_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completionRation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.completionRation_lbl.Location = new System.Drawing.Point(133, 507);
            this.completionRation_lbl.Name = "completionRation_lbl";
            this.completionRation_lbl.Size = new System.Drawing.Size(397, 54);
            this.completionRation_lbl.TabIndex = 16;
            this.completionRation_lbl.Text = "label1";
            this.completionRation_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletionChart
            // 
            this.CompletionChart.BackColor = System.Drawing.Color.Transparent;
            this.CompletionChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.CompletionChart.ChartAreas.Add(chartArea1);
            this.CompletionChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.CompletionChart.Legends.Add(legend1);
            this.CompletionChart.Location = new System.Drawing.Point(3, 237);
            this.CompletionChart.Name = "CompletionChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Transparent;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "Completed";
            dataPoint2.AxisLabel = "Created";
            dataPoint2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.CompletionChart.Series.Add(series1);
            this.CompletionChart.Size = new System.Drawing.Size(391, 229);
            this.CompletionChart.TabIndex = 15;
            this.CompletionChart.Text = "chart1";
            // 
            // expandedDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(549, 600);
            this.MinimumSize = new System.Drawing.Size(549, 600);
            this.Name = "expandedDay";
            this.Text = "expandedDay";
            this.Load += new System.EventHandler(this.expandedDay_Load);
            this.Shown += new System.EventHandler(this.expandedDay_Shown);
            this.Resize += new System.EventHandler(this.expandedDay_Resize);
            this.taskTBL_pnl.ResumeLayout(false);
            this.taskTBL_pnl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGridView)).EndInit();
            this.stats_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompletionChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel task_pnl;
        private System.Windows.Forms.Panel taskTBL_pnl;
        private System.Windows.Forms.Label tasks_lbl;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label graphsTitle_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView statisticsGridView;
        private System.Windows.Forms.TableLayoutPanel stats_pnl;
        private System.Windows.Forms.Label completionRation_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart CompletionChart;
    }
}