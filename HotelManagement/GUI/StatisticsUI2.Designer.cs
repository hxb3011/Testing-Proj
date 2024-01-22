namespace HotelManagement.GUI
{
    partial class StatisticsUI2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(333D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 60F;
            chartArea1.InnerPlotPosition.Width = 65F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.InnerPlotPosition.Y = 20F;
            chartArea1.Name = "arMonth";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 50F;
            chartArea1.Position.Width = 100F;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 60F;
            chartArea2.InnerPlotPosition.Width = 60F;
            chartArea2.InnerPlotPosition.X = 10F;
            chartArea2.InnerPlotPosition.Y = 20F;
            chartArea2.Name = "arRoom";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 50F;
            chartArea2.Position.Width = 50F;
            chartArea2.Position.Y = 50F;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 60F;
            chartArea3.InnerPlotPosition.Width = 60F;
            chartArea3.InnerPlotPosition.X = 10F;
            chartArea3.InnerPlotPosition.Y = 20F;
            chartArea3.Name = "arService";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 50F;
            chartArea3.Position.Width = 50F;
            chartArea3.Position.X = 50F;
            chartArea3.Position.Y = 50F;
            chart1.ChartAreas.Add(chartArea1);
            chart1.ChartAreas.Add(chartArea2);
            chart1.ChartAreas.Add(chartArea3);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "leMonth";
            legend1.Position.Auto = false;
            legend1.Position.Height = 10F;
            legend1.Position.Width = 20F;
            legend1.Position.X = 80F;
            legend1.Position.Y = 10F;
            legend2.DockedToChartArea = "arRoom";
            legend2.MaximumAutoSize = 40F;
            legend2.Name = "leRoom";
            legend2.Position.Auto = false;
            legend2.Position.Height = 30F;
            legend2.Position.Width = 20F;
            legend2.Position.X = 30F;
            legend2.Position.Y = 60F;
            legend3.DockedToChartArea = "arService";
            legend3.MaximumAutoSize = 40F;
            legend3.Name = "leService";
            legend3.Position.Auto = false;
            legend3.Position.Height = 30F;
            legend3.Position.Width = 20F;
            legend3.Position.X = 80F;
            legend3.Position.Y = 60F;
            chart1.Legends.Add(legend1);
            chart1.Legends.Add(legend2);
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(0, 0);
            chart1.Margin = new Padding(5);
            chart1.Name = "chart1";
            series1.ChartArea = "arMonth";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "leMonth";
            series1.Name = "seMonth";
            dataPoint1.AxisLabel = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "arRoom";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#PERCENT";
            series2.Legend = "leRoom";
            series2.LegendText = "#VALX";
            series2.Name = "seRoom";
            dataPoint3.IsValueShownAsLabel = true;
            dataPoint3.Label = "";
            dataPoint4.AxisLabel = "";
            dataPoint4.IsValueShownAsLabel = true;
            dataPoint4.Label = "";
            dataPoint5.IsValueShownAsLabel = true;
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "arService";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Label = "#PERCENT";
            series3.Legend = "leService";
            series3.LegendText = "#VALX";
            series3.Name = "seService";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(1300, 720);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            title1.DockedToChartArea = "arMonth";
            title1.DockingOffset = -6;
            title1.Name = "tiMonth";
            title1.Text = "Doanh thu theo tháng";
            title2.Alignment = ContentAlignment.TopCenter;
            title2.DockedToChartArea = "arRoom";
            title2.DockingOffset = 8;
            title2.IsDockedInsideChartArea = false;
            title2.Name = "tiRoom";
            title2.Text = "Doanh thu phòng";
            title3.DockedToChartArea = "arService";
            title3.DockingOffset = 8;
            title3.IsDockedInsideChartArea = false;
            title3.Name = "tiService";
            title3.Text = "Doanh thu dịch vụ";
            chart1.Titles.Add(title1);
            chart1.Titles.Add(title2);
            chart1.Titles.Add(title3);
            // 
            // StatisticsUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(chart1);
            Margin = new Padding(5);
            Name = "StatisticsUI";
            Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}