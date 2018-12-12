namespace MyWinformControl
{
    partial class frmChartEx1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.myChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.myChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChart3)).BeginInit();
            this.SuspendLayout();
            // 
            // myChart
            // 
            chartArea1.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.myChart.Legends.Add(legend1);
            this.myChart.Location = new System.Drawing.Point(13, 13);
            this.myChart.Name = "myChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "First";
            this.myChart.Series.Add(series1);
            this.myChart.Size = new System.Drawing.Size(346, 425);
            this.myChart.TabIndex = 0;
            this.myChart.Text = "chart1";
            // 
            // myChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.myChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.myChart2.Legends.Add(legend2);
            this.myChart2.Location = new System.Drawing.Point(365, 12);
            this.myChart2.Name = "myChart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.myChart2.Series.Add(series2);
            this.myChart2.Size = new System.Drawing.Size(327, 425);
            this.myChart2.TabIndex = 1;
            this.myChart2.Text = "chart1";
            // 
            // myChart3
            // 
            chartArea3.Name = "ChartArea1";
            this.myChart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.myChart3.Legends.Add(legend3);
            this.myChart3.Location = new System.Drawing.Point(698, 12);
            this.myChart3.Name = "myChart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.myChart3.Series.Add(series3);
            this.myChart3.Size = new System.Drawing.Size(354, 427);
            this.myChart3.TabIndex = 2;
            this.myChart3.Text = "chart1";
            this.myChart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myChart3_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmChartEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myChart3);
            this.Controls.Add(this.myChart2);
            this.Controls.Add(this.myChart);
            this.Name = "frmChartEx1";
            this.Text = "frmChartEx1";
            this.Load += new System.EventHandler(this.frmChartEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart3;
        private System.Windows.Forms.Label label1;
    }
}