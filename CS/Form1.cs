using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ChartEmptyPie {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            // Remove all Series from chart 
            chartControl1.Series.Clear();

            // Simulate "No data" state
            Series series = new Series("Empty Series", ViewType.Pie);

            series.Label.PointOptions.PointView = PointView.Argument;
            ((PieSeriesLabel)series.Label).Position = PieSeriesLabelPosition.Inside;
            ((PieSeriesLabel)series.Label).Font = new Font("Arial", 40);
            series.Points.Add(new SeriesPoint("No data", new object[] { 0.2 }));

            chartControl1.Series.Add(series);
            ((SimpleDiagram)chartControl1.Diagram).EqualPieSize = true;
            chartControl1.Legend.Visible = false;
        }
    }
}