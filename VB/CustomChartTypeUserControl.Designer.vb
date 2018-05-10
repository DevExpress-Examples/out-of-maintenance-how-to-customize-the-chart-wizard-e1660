Namespace WindowsApplication1
    Partial Public Class CustomChartTypeUserControl
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
            Dim series3 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel4 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim series4 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel5 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesLabel6 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomChartTypeUserControl))
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.imageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(sideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(sideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram2
            Me.chartControl1.Location = New System.Drawing.Point(198, 15)
            Me.chartControl1.Name = "chartControl1"
            sideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series3.Label = sideBySideBarSeriesLabel4
            series3.Name = "Series 1"
            sideBySideBarSeriesLabel5.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series4.Label = sideBySideBarSeriesLabel5
            series4.Name = "Series 2"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3, series4}
            sideBySideBarSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel6
            Me.chartControl1.Size = New System.Drawing.Size(461, 258)
            Me.chartControl1.TabIndex = 0
            ' 
            ' imageListBoxControl1
            ' 
            Me.imageListBoxControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.imageListBoxControl1.Location = New System.Drawing.Point(3, 15)
            Me.imageListBoxControl1.Name = "imageListBoxControl1"
            Me.imageListBoxControl1.Size = New System.Drawing.Size(189, 258)
            Me.imageListBoxControl1.TabIndex = 2
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' CustomChartTypeUserControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.imageListBoxControl1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "CustomChartTypeUserControl"
            Me.Size = New System.Drawing.Size(662, 287)
            CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(sideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(sideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
        Private WithEvents imageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl
        Private imageCollection1 As DevExpress.Utils.ImageCollection


    End Class
End Namespace
