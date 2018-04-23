using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing;

namespace WindowsApplication1 {
    public partial class CustomChartTypeUserControl : DevExpress.XtraCharts.Wizard.WizardControlBase {
        public CustomChartTypeUserControl() {
            InitializeComponent();

            foreach (string imagePath in Directory.GetFiles(Application.StartupPath + "\\..\\..\\Images")) {
                imageCollection1.AddImage(Image.FromFile(imagePath));
                ViewType viewType = (ViewType)Enum.Parse(typeof(ViewType), Path.GetFileNameWithoutExtension(imagePath));
                imageListBoxControl1.Items.Add(viewType, imageCollection1.Images.Count - 1);
            }
            imageListBoxControl1.ImageList = imageCollection1;
        }

        private void CustomChartTypeUserControl_Load(object sender, EventArgs e) {
            ChartControl chart = (ChartControl)this.CurrentChartControl;

            imageListBoxControl1.SelectedValue = SeriesViewFactory.GetViewType(chart.Series[0].View);
        }

        private void imageListBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                ((ChartControl)CurrentChartControl).Series[0].ChangeView((ViewType)imageListBoxControl1.SelectedValue);
            }
            catch(Exception ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Chart Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartControl1_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            e.Cancel = true;
        }

        private void chartControl1_ObjectSelected(object sender, HotTrackEventArgs e) {
            e.Cancel = true;
        }

    }
}
