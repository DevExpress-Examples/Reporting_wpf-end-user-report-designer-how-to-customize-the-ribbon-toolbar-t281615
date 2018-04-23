Namespace WpfReportDesigner.Reports
	Partial Public Class CategoriesReport
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
			Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
			Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CategoriesReport))
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
			Me.lbDescription = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.HeightF = 100F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' pbPicture
			' 
			Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.pbPicture.Name = "pbPicture"
			Me.pbPicture.SizeF = New System.Drawing.SizeF(200F, 100F)
			Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbCategoryName
			' 
			Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold)
			Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(220F, 10.00001F)
			Me.lbCategoryName.Name = "lbCategoryName"
			Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbCategoryName.SizeF = New System.Drawing.SizeF(430F, 32F)
			Me.lbCategoryName.StylePriority.UseFont = False
			Me.lbCategoryName.Text = "lbCategoryName"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwindConnection"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			tableQuery1.Name = "Categories"
			tableInfo1.Name = "Categories"
			columnInfo1.Name = "CategoryID"
			columnInfo2.Name = "CategoryName"
			columnInfo3.Name = "Description"
			columnInfo4.Name = "Picture"
			tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4})
			tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' lbDescription
			' 
			Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(220F, 53.08332F)
			Me.lbDescription.Multiline = True
			Me.lbDescription.Name = "lbDescription"
			Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDescription.SizeF = New System.Drawing.SizeF(430F, 56.91668F)
			Me.lbDescription.StylePriority.UseFont = False
			Me.lbDescription.Text = "lbDescription"
			' 
			' lbHeader
			' 
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Categories Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDescription, Me.pbPicture, Me.lbCategoryName})
			Me.Detail.HeightF = 110F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' CategoriesReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.Version = "15.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private lbHeader As DevExpress.XtraReports.UI.XRLabel
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private Detail As DevExpress.XtraReports.UI.DetailBand

	End Class
End Namespace
