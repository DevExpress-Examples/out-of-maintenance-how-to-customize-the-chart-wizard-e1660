Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Drawing

Namespace WindowsApplication1
    Partial Public Class CustomChartTypeUserControl
        Inherits DevExpress.XtraCharts.Wizard.WizardControlBase

        Public Sub New()
            InitializeComponent()

            For Each imagePath As String In Directory.GetFiles(Application.StartupPath & "\..\..\Images")
                imageCollection1.AddImage(Image.FromFile(imagePath))
                Dim viewType As ViewType = DirectCast(System.Enum.Parse(GetType(ViewType), Path.GetFileNameWithoutExtension(imagePath)), ViewType)
                imageListBoxControl1.Items.Add(viewType, imageCollection1.Images.Count - 1)
            Next imagePath
            imageListBoxControl1.ImageList = imageCollection1
        End Sub

        Private Sub CustomChartTypeUserControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim chart As ChartControl = CType(Me.CurrentChartControl, ChartControl)

            imageListBoxControl1.SelectedValue = SeriesViewFactory.GetViewType(chart.Series(0).View)
        End Sub

        Private Sub imageListBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imageListBoxControl1.SelectedIndexChanged
            Try
                CType(CurrentChartControl, ChartControl).Series(0).ChangeView(CType(imageListBoxControl1.SelectedValue, ViewType))
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Chart Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
            e.Cancel = True
        End Sub

        Private Sub chartControl1_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartControl1.ObjectSelected
            e.Cancel = True
        End Sub

    End Class
End Namespace
