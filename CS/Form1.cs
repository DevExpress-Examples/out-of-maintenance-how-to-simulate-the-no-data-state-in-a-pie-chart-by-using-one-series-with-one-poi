using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ChartEmptyPie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Remove all Series from chart 
            chartControl1.Series.Clear();

            // Simulate "No data" state
            Series series = new Series("Empty Series", ViewType.Pie);

            series.PointOptions.PointView = PointView.Argument;
            ((PieSeriesView)series.View).SizeAsPercentage = 80;
            ((PieSeriesLabel)series.Label).Position = PieSeriesLabelPosition.Inside;
            ((PieSeriesLabel)series.Label).Font = new Font("Arial", 40);
            series.Points.Add(new SeriesPoint("No data", new object[] {0.2}));
         
            chartControl1.Series.Add(series);
            chartControl1.Legend.Visible = false;
        }
    }
}