Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraCharts.Wizard

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits System.Windows.Forms.Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim wizard As New ChartWizard(chartControl1)
			Dim customChartTypePage As WizardPage = wizard.ConstructionGroup.RegisterPage(GetType(CustomChartTypeUserControl), "Chart Type", "CustomChartTypePage", "CustomChartTypePage", System.Drawing.SystemIcons.Information.ToBitmap())
			Dim pages As New List(Of WizardPage)(wizard.ConstructionGroup.Pages)

			pages.Remove(customChartTypePage)
			pages.Insert(0, customChartTypePage)
			wizard.ConstructionGroup.Pages = pages.ToArray()

			'wizard.ConstructionGroup.UnregisterPage(wizard.ChartTypePage);

			wizard.ShowDialog()
		End Sub
	End Class
End Namespace