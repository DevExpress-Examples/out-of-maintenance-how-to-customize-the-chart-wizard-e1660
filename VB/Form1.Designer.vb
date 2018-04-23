Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim bar3DSeriesLabel1 As New DevExpress.XtraCharts.Bar3DSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1, New Object() { (CObj(5))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2, New Object() { (CObj(4))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(3, New Object() { (CObj(6))})
			Dim sideBySideBar3DSeriesView1 As New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram3D1.AxisX.GridSpacingAuto = False
			xyDiagram3D1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram3D1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram3D1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram3D1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram3D1.RotationMatrixSerializable = "0.762718050960083;-0.159474027422391;0.626760886875797;0;0.0714804714829593;0.983" & "970774998647;0.16337703677426;0;-0.642768789640743;-0.0798094513591377;0.7618915" & "50378089;0;0;0;0;1"
			Me.chartControl1.Diagram = xyDiagram3D1
			Me.chartControl1.Location = New System.Drawing.Point(40, 12)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
			bar3DSeriesLabel1.LineVisible = True
			bar3DSeriesLabel1.Visible = True
			series1.Label = bar3DSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3})
			series1.View = sideBySideBar3DSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartControl1.Size = New System.Drawing.Size(697, 388)
			Me.chartControl1.TabIndex = 2
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(297, 407)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(183, 23)
			Me.button1.TabIndex = 3
			Me.button1.Text = "Wizard"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(777, 442)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents button1 As System.Windows.Forms.Button

	End Class
End Namespace

