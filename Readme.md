<!-- default file list -->
*Files to look at*:

* [CustomizedRibbonCommands.cs](./CS/CustomizedRibbonCommands.cs) (VB: [CustomizedRibbonCommands.vb](./VB/CustomizedRibbonCommands.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [ReportDesignerClassicViewTemplate.xaml](./CS/ReportDesignerClassicViewTemplate.xaml) (VB: [ReportDesignerClassicViewTemplate.xaml](./VB/ReportDesignerClassicViewTemplate.xaml))
<!-- default file list end -->
# WPF End-User Report Designer - How to customize the Ribbon toolbar


<p>This example demonstrates how you can customize the Report Designer control's toolbar. In particular, it shows how to remove standard toolbar controls and add custom ones. <br><br>To accomplish this, use the Designer's <strong>RibbonCustomizationActions</strong> property, which specifies a collection of actions used to customize the Designer's ribbon toolbar.  These actions allow you to remove existing items or add new items both in the designer and preview pages.</p>


<h3>Description</h3>

<p>This example demonstrates how add two custom items to the&nbsp;Ribbon toolbar of the&nbsp;Banded End-User Report Designer. These custom items allows you to manage the designer's side panel's and toolbox's visibility.</p>
<p>&nbsp;</p>
<p>To customize the WPF&nbsp;Banded End-User Report Designer's Ribbon toolbar, use its RibbonTemplate. Get the original&nbsp;RibbonTemplate XAML code from our source files,&nbsp;add it to your application, customize it according to your requirements, and assign it to the ReportDesigner.RibbonTemplate property.&nbsp;<strong>Note</strong>&nbsp;that&nbsp;not all the&nbsp;<a href="https://www.devexpress.com/Subscriptions/">Subscriptions</a>&nbsp;include&nbsp;our&nbsp;source code files. So, if you have no access to our source code, you can get the original&nbsp;RibbonTemplate XAML code from this code example.</p>
<p><br>In this example, I have added the&nbsp;RibbonPageGroup with two&nbsp;BarCheckItems to the&nbsp;Report Designer's RibbonTemplate and bound these items&nbsp;to the&nbsp;CustomizedRibbonCommands class properties. This class object (CustomRibbonCommands) is assigned to the MainWindow and realizes the side panel and toolbox showing/hiding logic:</p>
<code lang="xaml">&lt;DataTemplate x:Key="CustomizedRibbonTemplate"&gt;
    &lt;dxr:RibbonControl ... &gt;
        &lt;dxr:RibbonDefaultPageCategory&gt;
            &lt;dxr:RibbonPage Caption="Report Designer" &gt;
                ...
                &lt;dxr:RibbonPageGroup Caption="View"&gt;
                    &lt;dxb:BarCheckItem Content="Toolbox" IsChecked="{Binding CustomRibbonCommands.IsToolboxVisible, RelativeSource={RelativeSource FindAncestor, AncestorType=local:MainWindow}}" LargeGlyph="{dx:DXImage Image=IDE_32x32.png}" Glyph="{dx:DXImage Image=IDE_16x16.png}" /&gt;
                    &lt;dxb:BarCheckItem Content="Side Panel" IsChecked="{Binding CustomRibbonCommands.IsSidePanelVisible, RelativeSource={RelativeSource FindAncestor, AncestorType=local:MainWindow}}" LargeGlyph="{dx:DXImage Image=Technology_32x32.png}" Glyph="{dx:DXImage Image=Technology_16x16.png}" /&gt;
                &lt;/dxr:RibbonPageGroup&gt;
            &lt;/dxr:RibbonPage&gt;
        &lt;/dxr:RibbonDefaultPageCategory&gt;
        ...
    &lt;/dxr:RibbonControl&gt;
&lt;/DataTemplate&gt;</code>

<br/>


