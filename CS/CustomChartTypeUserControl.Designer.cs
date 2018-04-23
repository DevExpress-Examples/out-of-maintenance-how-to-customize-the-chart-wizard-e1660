namespace WindowsApplication1 {
    partial class CustomChartTypeUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel5 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel6 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomChartTypeUserControl));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Location = new System.Drawing.Point(198, 15);
            this.chartControl1.Name = "chartControl1";
            sideBySideBarSeriesLabel4.LineVisible = true;
            series3.Label = sideBySideBarSeriesLabel4;
            series3.Name = "Series 1";
            sideBySideBarSeriesLabel5.LineVisible = true;
            series4.Label = sideBySideBarSeriesLabel5;
            series4.Name = "Series 2";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            sideBySideBarSeriesLabel6.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel6;
            this.chartControl1.Size = new System.Drawing.Size(461, 258);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.chartControl1_ObjectSelected);
            this.chartControl1.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chartControl1_ObjectHotTracked);
            // 
            // imageListBoxControl1
            // 
            this.imageListBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.imageListBoxControl1.Location = new System.Drawing.Point(3, 15);
            this.imageListBoxControl1.Name = "imageListBoxControl1";
            this.imageListBoxControl1.Size = new System.Drawing.Size(189, 258);
            this.imageListBoxControl1.TabIndex = 2;
            this.imageListBoxControl1.SelectedIndexChanged += new System.EventHandler(this.imageListBoxControl1_SelectedIndexChanged);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // CustomChartTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageListBoxControl1);
            this.Controls.Add(this.chartControl1);
            this.Name = "CustomChartTypeUserControl";
            this.Size = new System.Drawing.Size(662, 287);
            this.Load += new System.EventHandler(this.CustomChartTypeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;


    }
}
