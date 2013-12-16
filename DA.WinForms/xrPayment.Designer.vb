<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrPayment
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrDetials = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrA = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrB = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrC = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrD = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrPeriod = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCompany = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCompanyName = New DevExpress.XtraReports.UI.XRLabel
        Me.xrSupplier = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrAmount = New DevExpress.XtraReports.UI.XRLabel
        Me.xrBank = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCheckDate = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrCheckNo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPayDate = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrType = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.xrDetials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrDetials})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrDetials
        '
        Me.xrDetials.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrDetials.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.xrDetials.Location = New System.Drawing.Point(33, 0)
        Me.xrDetials.Name = "xrDetials"
        Me.xrDetials.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.xrDetials.Size = New System.Drawing.Size(700, 25)
        Me.xrDetials.StylePriority.UseBorders = False
        Me.xrDetials.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrA, Me.xrB, Me.xrC, Me.xrD})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(700, 25)
        '
        'xrA
        '
        Me.xrA.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrA.Location = New System.Drawing.Point(0, 0)
        Me.xrA.Name = "xrA"
        Me.xrA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrA.Size = New System.Drawing.Size(160, 25)
        Me.xrA.StylePriority.UseBorders = False
        Me.xrA.StylePriority.UseTextAlignment = False
        Me.xrA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrB
        '
        Me.xrB.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrB.Location = New System.Drawing.Point(160, 0)
        Me.xrB.Name = "xrB"
        Me.xrB.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrB.Size = New System.Drawing.Size(169, 25)
        Me.xrB.StylePriority.UseBorders = False
        Me.xrB.StylePriority.UseTextAlignment = False
        Me.xrB.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrC
        '
        Me.xrC.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrC.Location = New System.Drawing.Point(329, 0)
        Me.xrC.Name = "xrC"
        Me.xrC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrC.Size = New System.Drawing.Size(185, 25)
        Me.xrC.StylePriority.UseBorders = False
        Me.xrC.StylePriority.UseTextAlignment = False
        Me.xrC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrD
        '
        Me.xrD.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrD.Location = New System.Drawing.Point(514, 0)
        Me.xrD.Name = "xrD"
        Me.xrD.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrD.Size = New System.Drawing.Size(186, 25)
        Me.xrD.StylePriority.UseBorders = False
        Me.xrD.StylePriority.UseTextAlignment = False
        Me.xrD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.Location = New System.Drawing.Point(33, 158)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(700, 25)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(700, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(160, 25)
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "System No"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(160, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(169, 25)
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Reference"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(329, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.Size = New System.Drawing.Size(185, 25)
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Bill Date"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(514, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.Size = New System.Drawing.Size(186, 25)
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Bill Total"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.xrPeriod, Me.xrCompany, Me.xrCompanyName, Me.xrSupplier})
        Me.PageHeader.Height = 183
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrPeriod
        '
        Me.xrPeriod.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPeriod.Location = New System.Drawing.Point(58, 109)
        Me.xrPeriod.Name = "xrPeriod"
        Me.xrPeriod.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPeriod.Size = New System.Drawing.Size(308, 25)
        Me.xrPeriod.StylePriority.UseFont = False
        Me.xrPeriod.StylePriority.UseTextAlignment = False
        Me.xrPeriod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCompany
        '
        Me.xrCompany.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrCompany.Location = New System.Drawing.Point(417, 17)
        Me.xrCompany.Name = "xrCompany"
        Me.xrCompany.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCompany.Size = New System.Drawing.Size(300, 25)
        Me.xrCompany.StylePriority.UseFont = False
        Me.xrCompany.StylePriority.UseTextAlignment = False
        Me.xrCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrCompanyName
        '
        Me.xrCompanyName.Location = New System.Drawing.Point(417, 43)
        Me.xrCompanyName.Multiline = True
        Me.xrCompanyName.Name = "xrCompanyName"
        Me.xrCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCompanyName.Size = New System.Drawing.Size(300, 91)
        '
        'xrSupplier
        '
        Me.xrSupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrSupplier.Location = New System.Drawing.Point(58, 83)
        Me.xrSupplier.Name = "xrSupplier"
        Me.xrSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrSupplier.Size = New System.Drawing.Size(308, 25)
        Me.xrSupplier.StylePriority.UseFont = False
        Me.xrSupplier.StylePriority.UseTextAlignment = False
        Me.xrSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrAmount, Me.xrBank, Me.XrLabel10, Me.XrLabel9, Me.xrCheckDate, Me.XrLabel7, Me.xrCheckNo, Me.XrLabel5, Me.xrPayDate, Me.XrLabel3, Me.xrType, Me.XrLabel1})
        Me.PageFooter.Height = 143
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrAmount
        '
        Me.xrAmount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrAmount.Location = New System.Drawing.Point(508, 83)
        Me.xrAmount.Name = "xrAmount"
        Me.xrAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrAmount.Size = New System.Drawing.Size(225, 25)
        Me.xrAmount.StylePriority.UseFont = False
        '
        'xrBank
        '
        Me.xrBank.Location = New System.Drawing.Point(508, 50)
        Me.xrBank.Name = "xrBank"
        Me.xrBank.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrBank.Size = New System.Drawing.Size(225, 25)
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.Location = New System.Drawing.Point(400, 83)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Amount"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(400, 50)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Bank"
        '
        'xrCheckDate
        '
        Me.xrCheckDate.Location = New System.Drawing.Point(508, 17)
        Me.xrCheckDate.Name = "xrCheckDate"
        Me.xrCheckDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCheckDate.Size = New System.Drawing.Size(225, 25)
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(400, 17)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Check Date"
        '
        'xrCheckNo
        '
        Me.xrCheckNo.Location = New System.Drawing.Point(142, 83)
        Me.xrCheckNo.Name = "xrCheckNo"
        Me.xrCheckNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCheckNo.Size = New System.Drawing.Size(225, 25)
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(33, 83)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Check No"
        '
        'xrPayDate
        '
        Me.xrPayDate.Location = New System.Drawing.Point(142, 50)
        Me.xrPayDate.Name = "xrPayDate"
        Me.xrPayDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPayDate.Size = New System.Drawing.Size(225, 25)
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(33, 50)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Pay Date"
        '
        'xrType
        '
        Me.xrType.Location = New System.Drawing.Point(142, 17)
        Me.xrType.Name = "xrType"
        Me.xrType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrType.Size = New System.Drawing.Size(225, 25)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(33, 17)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Type"
        '
        'xrPayment
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "8.2"
        CType(Me.xrDetials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents xrSupplier As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrCompanyName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrType As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrPayDate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrCheckNo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrCheckDate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrBank As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrCompany As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrPeriod As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrDetials As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Public WithEvents xrA As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents xrB As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents xrC As DevExpress.XtraReports.UI.XRTableCell
    Public WithEvents xrD As DevExpress.XtraReports.UI.XRTableCell
End Class
