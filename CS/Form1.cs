using System;
using System.Collections.Generic;
using DevExpress.XtraCharts.Wizard;

namespace WindowsApplication1 {
    public partial class Form1 : System.Windows.Forms.Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ChartWizard wizard = new ChartWizard(chartControl1);
            WizardPage customChartTypePage = wizard.ConstructionGroup.RegisterPage(typeof(CustomChartTypeUserControl),
                "Chart Type", "CustomChartTypePage", "CustomChartTypePage", System.Drawing.SystemIcons.Information.ToBitmap());
            List<WizardPage> pages = new List<WizardPage>(wizard.ConstructionGroup.Pages);

            pages.Remove(customChartTypePage);
            pages.Insert(0, customChartTypePage);
            wizard.ConstructionGroup.Pages = pages.ToArray();

            //wizard.ConstructionGroup.UnregisterPage(wizard.ChartTypePage);

            wizard.ShowDialog();
        }
    }
}