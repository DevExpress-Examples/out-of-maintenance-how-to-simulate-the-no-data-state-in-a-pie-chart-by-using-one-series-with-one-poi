Imports Microsoft.VisualBasic
Imports System
Namespace ChartEmptyPie
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("a", New Object() { (CObj(0.2))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("b", New Object() { (CObj(0.3))}, 2)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("c", New Object() { (CObj(0.5))}, 4)
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel2 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("d", New Object() { (CObj(0.2))}, 0)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("e", New Object() { (CObj(0.8))}, 1)
			Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieSeriesLabel3 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView3 As New DevExpress.XtraCharts.PieSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			simpleDiagram1.LayoutDirection = DevExpress.XtraCharts.LayoutDirection.Vertical
			Me.chartControl1.Diagram = simpleDiagram1
			Me.chartControl1.Location = New System.Drawing.Point(12, 12)
			Me.chartControl1.Name = "chartControl1"
			pieSeriesLabel1.LineVisible = True
			series1.Label = pieSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3})
			pieSeriesView1.RuntimeExploding = False
			series1.View = pieSeriesView1
			pieSeriesLabel2.BackColor = System.Drawing.Color.White
			pieSeriesLabel2.LineVisible = True
			series2.Label = pieSeriesLabel2
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint4, seriesPoint5})
			pieSeriesView2.RuntimeExploding = False
			series2.View = pieSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			pieSeriesLabel3.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = pieSeriesLabel3
			pieSeriesView3.RuntimeExploding = False
			Me.chartControl1.SeriesTemplate.View = pieSeriesView3
			Me.chartControl1.Size = New System.Drawing.Size(817, 457)
			Me.chartControl1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(383, 507)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Clear"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(841, 552)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

