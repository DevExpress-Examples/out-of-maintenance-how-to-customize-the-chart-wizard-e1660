# How to customize the Chart Wizard


<p>This example demonstrates how to create a custom Chart Wizard.</p><p>The custom ChartTypePage is added to the ConstructionGroup of the ChartWizard. This page is represented by a WizardControlBase class descendant. To access the ChartControl designed from the methods of the WizardControlBase descendant, the WizardControlBase.CurrentChartControl property is used.</p><p>Also, the HyperLinkEdit is added to the title panel of the ChartWizard form. However, you have to use reflection to accomplish this task because there is no direct access to the title panel. Therefore it may stop working with further XtraCharts updates. This approach only demonstrates the main idea of how this can be done. In a real application, please add all necessary controls to the custom wizard page.</p><p>See also:<br />
- <a href="http://help.devexpress.com/XtraCharts/CustomDocument3331.aspx">How to: Add a New Page to a Wizard</a>;<br />
- <a href="http://help.devexpress.com/XtraCharts/CustomDocument3330.aspx">How to: Change the Page Order in a Wizard</a>;<br />
- <a href="http://help.devexpress.com/XtraCharts/CustomDocument3329.aspx">How to: Invoke the Chart Wizard at Runtime</a>;<br />
- <a href="http://help.devexpress.com/XtraCharts/CustomDocument3332.aspx">How to: Hide Certain Tabs on a Wizard's Page</a>.</p>

<br/>


