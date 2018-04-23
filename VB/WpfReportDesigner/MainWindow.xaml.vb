Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports WpfReportDesigner.Reports

Namespace WpfReportDesigner
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Shared ReadOnly CustomRibbonCommandsProperty As DependencyProperty = DependencyProperty.Register("CustomRibbonCommands", GetType(CustomizedRibbonCommands), GetType(MainWindow), New PropertyMetadata(Nothing))

		Public Property CustomRibbonCommands() As CustomizedRibbonCommands
			Get
				Return DirectCast(GetValue(CustomRibbonCommandsProperty), CustomizedRibbonCommands)
			End Get
			Set(ByVal value As CustomizedRibbonCommands)
				SetValue(CustomRibbonCommandsProperty, value)
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
			CustomRibbonCommands = New CustomizedRibbonCommands(reportDesigner)
			reportDesigner.OpenDocument(New CategoriesReport())
		End Sub
	End Class
End Namespace
