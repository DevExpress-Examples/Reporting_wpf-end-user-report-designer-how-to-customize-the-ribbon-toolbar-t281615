using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfReportDesigner.Reports;

namespace WpfReportDesigner {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static readonly DependencyProperty CustomRibbonCommandsProperty = DependencyProperty.Register(
                "CustomRibbonCommands",
                typeof(CustomizedRibbonCommands),
                typeof(MainWindow),
                new PropertyMetadata(null)
        );

        public CustomizedRibbonCommands CustomRibbonCommands {
            get { return (CustomizedRibbonCommands) GetValue(CustomRibbonCommandsProperty); }
            set { SetValue(CustomRibbonCommandsProperty, value); }
        }        

        public MainWindow() {
            InitializeComponent();
            CustomRibbonCommands = new CustomizedRibbonCommands(reportDesigner);
            reportDesigner.OpenDocument(new CategoriesReport());            
        }
    }
}
