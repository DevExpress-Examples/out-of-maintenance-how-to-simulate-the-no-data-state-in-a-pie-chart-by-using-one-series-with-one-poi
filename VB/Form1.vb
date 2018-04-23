Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ChartEmptyPie
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			' Remove all Series from chart 
			chartControl1.Series.Clear()

			' Simulate "No data" state
			Dim series As New Series("Empty Series", ViewType.Pie)

			series.PointOptions.PointView = PointView.Argument
			CType(series.View, PieSeriesView).SizeAsPercentage = 80
			CType(series.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.Inside
			CType(series.Label, PieSeriesLabel).Font = New Font("Arial", 40)
			series.Points.Add(New SeriesPoint("No data", New Object() {0.2}))

			chartControl1.Series.Add(series)
			chartControl1.Legend.Visible = False
		End Sub
	End Class
End Namespace