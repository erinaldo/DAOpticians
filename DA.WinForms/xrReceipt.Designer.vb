<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrReceipt
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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrRefractBy = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlDate = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlBalance = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAdvance = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFullAmount = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlReceiptNo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlPrescriptionNo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCustomAmount = New DevExpress.XtraReports.UI.XRLabel
        Me.xrltinTin = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTesting = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFrameChangeAmount = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlLenseAmount = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFrameAmount = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCustomText = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNoOfFrameChanges = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNoofLenses = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNoOfFrames = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAddress3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAddress2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAddress1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCustomerName = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Height = 0
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PrintOnEmptyDataSource = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRefractBy, Me.xrlDate, Me.xrlTotal, Me.xrlBalance, Me.xrlAdvance, Me.xrlFullAmount, Me.xrlReceiptNo, Me.xrlPrescriptionNo, Me.xrlCustomAmount, Me.xrltinTin, Me.xrlTesting, Me.xrlFrameChangeAmount, Me.xrlLenseAmount, Me.xrlFrameAmount, Me.xrlCustomText, Me.xrlNoOfFrameChanges, Me.xrlNoofLenses, Me.xrlNoOfFrames, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.xrlAddress3, Me.xrlAddress2, Me.xrlAddress1, Me.xrlCustomerName})
        Me.PageHeader.Height = 399
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrRefractBy
        '
        Me.xrRefractBy.Location = New System.Drawing.Point(592, 175)
        Me.xrRefractBy.Name = "xrRefractBy"
        Me.xrRefractBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrRefractBy.Size = New System.Drawing.Size(167, 17)
        Me.xrRefractBy.StylePriority.UseTextAlignment = False
        '
        'xrlDate
        '
        Me.xrlDate.Location = New System.Drawing.Point(592, 50)
        Me.xrlDate.Name = "xrlDate"
        Me.xrlDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlDate.Size = New System.Drawing.Size(150, 17)
        Me.xrlDate.StylePriority.UseTextAlignment = False
        '
        'xrlTotal
        '
        Me.xrlTotal.Location = New System.Drawing.Point(592, 350)
        Me.xrlTotal.Name = "xrlTotal"
        Me.xrlTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotal.Size = New System.Drawing.Size(125, 17)
        Me.xrlTotal.StylePriority.UseTextAlignment = False
        Me.xrlTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlBalance
        '
        Me.xrlBalance.Location = New System.Drawing.Point(592, 150)
        Me.xrlBalance.Name = "xrlBalance"
        Me.xrlBalance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlBalance.Size = New System.Drawing.Size(125, 17)
        Me.xrlBalance.StylePriority.UseTextAlignment = False
        Me.xrlBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlAdvance
        '
        Me.xrlAdvance.Location = New System.Drawing.Point(400, 150)
        Me.xrlAdvance.Name = "xrlAdvance"
        Me.xrlAdvance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAdvance.Size = New System.Drawing.Size(133, 17)
        Me.xrlAdvance.StylePriority.UseTextAlignment = False
        Me.xrlAdvance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlFullAmount
        '
        Me.xrlFullAmount.Location = New System.Drawing.Point(133, 150)
        Me.xrlFullAmount.Name = "xrlFullAmount"
        Me.xrlFullAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFullAmount.Size = New System.Drawing.Size(133, 17)
        Me.xrlFullAmount.StylePriority.UseTextAlignment = False
        Me.xrlFullAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlReceiptNo
        '
        Me.xrlReceiptNo.Location = New System.Drawing.Point(592, 67)
        Me.xrlReceiptNo.Name = "xrlReceiptNo"
        Me.xrlReceiptNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlReceiptNo.Size = New System.Drawing.Size(150, 17)
        Me.xrlReceiptNo.StylePriority.UseTextAlignment = False
        '
        'xrlPrescriptionNo
        '
        Me.xrlPrescriptionNo.Location = New System.Drawing.Point(50, 113)
        Me.xrlPrescriptionNo.Name = "xrlPrescriptionNo"
        Me.xrlPrescriptionNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlPrescriptionNo.Size = New System.Drawing.Size(133, 17)
        Me.xrlPrescriptionNo.StylePriority.UseTextAlignment = False
        '
        'xrlCustomAmount
        '
        Me.xrlCustomAmount.Location = New System.Drawing.Point(592, 310)
        Me.xrlCustomAmount.Name = "xrlCustomAmount"
        Me.xrlCustomAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCustomAmount.Size = New System.Drawing.Size(125, 17)
        Me.xrlCustomAmount.StylePriority.UseTextAlignment = False
        Me.xrlCustomAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrltinTin
        '
        Me.xrltinTin.Location = New System.Drawing.Point(592, 293)
        Me.xrltinTin.Name = "xrltinTin"
        Me.xrltinTin.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrltinTin.Size = New System.Drawing.Size(125, 17)
        Me.xrltinTin.StylePriority.UseTextAlignment = False
        Me.xrltinTin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlTesting
        '
        Me.xrlTesting.Location = New System.Drawing.Point(592, 276)
        Me.xrlTesting.Name = "xrlTesting"
        Me.xrlTesting.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTesting.Size = New System.Drawing.Size(125, 17)
        Me.xrlTesting.StylePriority.UseTextAlignment = False
        Me.xrlTesting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlFrameChangeAmount
        '
        Me.xrlFrameChangeAmount.Location = New System.Drawing.Point(592, 259)
        Me.xrlFrameChangeAmount.Name = "xrlFrameChangeAmount"
        Me.xrlFrameChangeAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFrameChangeAmount.Size = New System.Drawing.Size(125, 17)
        Me.xrlFrameChangeAmount.StylePriority.UseTextAlignment = False
        Me.xrlFrameChangeAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlLenseAmount
        '
        Me.xrlLenseAmount.Location = New System.Drawing.Point(592, 242)
        Me.xrlLenseAmount.Name = "xrlLenseAmount"
        Me.xrlLenseAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlLenseAmount.Size = New System.Drawing.Size(125, 17)
        Me.xrlLenseAmount.StylePriority.UseTextAlignment = False
        Me.xrlLenseAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlFrameAmount
        '
        Me.xrlFrameAmount.Location = New System.Drawing.Point(592, 225)
        Me.xrlFrameAmount.Name = "xrlFrameAmount"
        Me.xrlFrameAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFrameAmount.Size = New System.Drawing.Size(125, 17)
        Me.xrlFrameAmount.StylePriority.UseTextAlignment = False
        Me.xrlFrameAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlCustomText
        '
        Me.xrlCustomText.Location = New System.Drawing.Point(134, 310)
        Me.xrlCustomText.Name = "xrlCustomText"
        Me.xrlCustomText.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCustomText.Size = New System.Drawing.Size(425, 17)
        Me.xrlCustomText.StylePriority.UseTextAlignment = False
        '
        'xrlNoOfFrameChanges
        '
        Me.xrlNoOfFrameChanges.Location = New System.Drawing.Point(83, 259)
        Me.xrlNoOfFrameChanges.Name = "xrlNoOfFrameChanges"
        Me.xrlNoOfFrameChanges.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNoOfFrameChanges.Size = New System.Drawing.Size(42, 17)
        Me.xrlNoOfFrameChanges.StylePriority.UseTextAlignment = False
        Me.xrlNoOfFrameChanges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrlNoofLenses
        '
        Me.xrlNoofLenses.Location = New System.Drawing.Point(83, 242)
        Me.xrlNoofLenses.Name = "xrlNoofLenses"
        Me.xrlNoofLenses.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNoofLenses.Size = New System.Drawing.Size(42, 17)
        Me.xrlNoofLenses.StylePriority.UseTextAlignment = False
        Me.xrlNoofLenses.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrlNoOfFrames
        '
        Me.xrlNoOfFrames.Location = New System.Drawing.Point(83, 225)
        Me.xrlNoOfFrames.Name = "xrlNoOfFrames"
        Me.xrlNoOfFrames.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNoOfFrames.Size = New System.Drawing.Size(42, 17)
        Me.xrlNoOfFrames.StylePriority.UseTextAlignment = False
        Me.xrlNoOfFrames.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Location = New System.Drawing.Point(133, 293)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(425, 17)
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Tinting / Fitting"
        '
        'XrLabel5
        '
        Me.XrLabel5.Location = New System.Drawing.Point(133, 276)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(425, 17)
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Refraction/ Eye Pressure Testing"
        '
        'XrLabel4
        '
        Me.XrLabel4.Location = New System.Drawing.Point(133, 259)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(425, 17)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Frame Change/s"
        '
        'XrLabel3
        '
        Me.XrLabel3.Location = New System.Drawing.Point(133, 242)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(425, 17)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Paire of Lense/s"
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(133, 225)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(425, 17)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Paire of Frame/s"
        '
        'XrLabel1
        '
        Me.XrLabel1.Location = New System.Drawing.Point(533, 8)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(150, 17)
        Me.XrLabel1.Text = "Ratnapura"
        '
        'xrlAddress3
        '
        Me.xrlAddress3.Location = New System.Drawing.Point(50, 95)
        Me.xrlAddress3.Name = "xrlAddress3"
        Me.xrlAddress3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAddress3.Size = New System.Drawing.Size(425, 17)
        Me.xrlAddress3.StylePriority.UseTextAlignment = False
        '
        'xrlAddress2
        '
        Me.xrlAddress2.Location = New System.Drawing.Point(50, 77)
        Me.xrlAddress2.Name = "xrlAddress2"
        Me.xrlAddress2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAddress2.Size = New System.Drawing.Size(425, 17)
        Me.xrlAddress2.StylePriority.UseTextAlignment = False
        '
        'xrlAddress1
        '
        Me.xrlAddress1.Location = New System.Drawing.Point(50, 59)
        Me.xrlAddress1.Name = "xrlAddress1"
        Me.xrlAddress1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAddress1.Size = New System.Drawing.Size(425, 17)
        Me.xrlAddress1.StylePriority.UseTextAlignment = False
        '
        'xrlCustomerName
        '
        Me.xrlCustomerName.Location = New System.Drawing.Point(50, 42)
        Me.xrlCustomerName.Name = "xrlCustomerName"
        Me.xrlCustomerName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCustomerName.Size = New System.Drawing.Size(425, 17)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrReceipt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 550
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Version = "8.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Public WithEvents xrlCustomerName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlAddress1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlAddress3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlAddress2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlNoOfFrameChanges As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlNoofLenses As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlNoOfFrames As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlCustomText As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlTesting As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlFrameChangeAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlLenseAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlFrameAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlCustomAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrltinTin As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlPrescriptionNo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlReceiptNo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlBalance As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlAdvance As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlFullAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlTotal As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlDate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrRefractBy As DevExpress.XtraReports.UI.XRLabel
End Class
