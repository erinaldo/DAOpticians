Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Module CommonOperations

    Public UserName, UserType As String
    Public UserID, EmployerID As Int64

#Region "Form operations"
    Public Sub ShowDAForm(ByVal frm As DevExpress.XtraEditors.XtraForm)
        frm.MdiParent = frmMain
        frm.Show()
        frm.BringToFront()
    End Sub
#End Region

#Region "Startup form Bar button settings"
    Public Sub SetDAStartUpBarButton(ByVal bbSave As DevExpress.XtraBars.BarButtonItem, ByVal bbNew As DevExpress.XtraBars.BarButtonItem, ByVal bbDelete As DevExpress.XtraBars.BarButtonItem, ByVal bbClose As DevExpress.XtraBars.BarButtonItem, ByVal bbDisplaySelected As DevExpress.XtraBars.BarButtonItem, ByVal bbRefresh As DevExpress.XtraBars.BarButtonItem, ByVal bbPrint As DevExpress.XtraBars.BarButtonItem)

       

        bbSave.Caption = "Save"
        bbNew.Caption = "New"
        bbDelete.Caption = "Delete"
        bbClose.Caption = "Close"
        bbDisplaySelected.Caption = "Display"
        bbRefresh.Caption = "Reset"
        bbPrint.Caption = "Print"

        bbSave.Hint = DA_SAVE_HINT
        bbNew.Hint = DA_NEW_HINT
        bbDelete.Hint = DA_DELETE_HINT
        bbClose.Hint = DA_CLOSE_HINT
        bbDisplaySelected.Hint = DA_DISPLAYSELECTED_HINT
        bbRefresh.Hint = DA_REFRESH_HINT
        bbPrint.Hint = DA_PRINT_HINT

        bbSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        bbNew.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        bbDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        bbClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W))
        bbDisplaySelected.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        bbRefresh.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        bbPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))


        bbSave.Glyph = DA.WinForms.My.Resources.Resources.save
        bbNew.Glyph = DA.WinForms.My.Resources.Resources._New
        bbDelete.Glyph = DA.WinForms.My.Resources.Resources.delete
        bbClose.Glyph = DA.WinForms.My.Resources.Resources.Close
        bbDisplaySelected.Glyph = DA.WinForms.My.Resources.Resources.Refresh
        bbPrint.Glyph = DA.WinForms.My.Resources.Resources.print
        bbRefresh.Glyph = DA.WinForms.My.Resources.Resources.Reconcile


        bbSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbDisplaySelected.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph



    End Sub
#End Region

#Region "Purchases / Sales form Bar button settings"
    Public Sub SetDAPurchaseSalesBarButton(ByVal bbSave As DevExpress.XtraBars.BarButtonItem, ByVal bbNew As DevExpress.XtraBars.BarButtonItem, ByVal bbClose As DevExpress.XtraBars.BarButtonItem, ByVal bbDisplaySelected As DevExpress.XtraBars.BarButtonItem, ByVal bbRefresh As DevExpress.XtraBars.BarButtonItem, ByVal bbPrint As DevExpress.XtraBars.BarButtonItem)



        bbSave.Caption = "Save"
        bbNew.Caption = "New"
        bbClose.Caption = "Close"
        bbDisplaySelected.Caption = "Display Selected"
        bbRefresh.Caption = "Refresh"
        bbPrint.Caption = "Print"


        bbSave.Hint = DA_SAVE_HINT
        bbNew.Hint = DA_NEW_HINT
        bbClose.Hint = DA_CLOSE_HINT
        bbDisplaySelected.Hint = DA_DISPLAYSELECTED_HINT
        bbRefresh.Hint = DA_REFRESH_HINT
        bbPrint.Hint = DA_PRINT_HINT


        bbSave.Glyph = DA.WinForms.My.Resources.Resources.save
        bbNew.Glyph = DA.WinForms.My.Resources.Resources._New
        bbClose.Glyph = DA.WinForms.My.Resources.Resources.Close
        bbDisplaySelected.Glyph = DA.WinForms.My.Resources.Resources.ShowBy
        bbRefresh.Glyph = DA.WinForms.My.Resources.Resources.Reconcile
        bbPrint.Glyph = DA.WinForms.My.Resources.Resources.print


        bbSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbDisplaySelected.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph





    End Sub
#End Region

#Region "Pay Bills Bar Button Settings"
    Public Sub SetDAPayBillsBarButton(ByVal bbSave As DevExpress.XtraBars.BarButtonItem, ByVal bbPrint As DevExpress.XtraBars.BarButtonItem, ByVal bbShowBy As DevExpress.XtraBars.BarButtonItem, ByVal bbRefresh As DevExpress.XtraBars.BarButtonItem, ByVal bbClose As DevExpress.XtraBars.BarButtonItem)
        bbSave.Hint = DA_SAVE_HINT
        bbPrint.Hint = DA_PRINT_HINT
        bbShowBy.Hint = DA_CE_HINT
        bbRefresh.Hint = DA_REFRESH_HINT
        bbClose.Hint = DA_CLOSE_HINT


        bbSave.Caption = "Save"
        bbPrint.Caption = "Print"
        bbShowBy.Caption = "Group By Supplier"
        bbRefresh.Caption = "Refresh"
        bbClose.Caption = "Close"

        bbSave.Glyph = DA.WinForms.My.Resources.Resources.save
        bbPrint.Glyph = DA.WinForms.My.Resources.Resources.print
        bbShowBy.Glyph = DA.WinForms.My.Resources.Resources.ShowBy
        bbRefresh.Glyph = DA.WinForms.My.Resources.Resources.Refresh
        bbClose.Glyph = DA.WinForms.My.Resources.Resources.Close

        bbSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbShowBy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbShowBy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph

    End Sub
#End Region

#Region "Receive Payments Bar Button Settings"
    Public Sub SetDAReceivePaymentsBarButton(ByVal bbSave As DevExpress.XtraBars.BarButtonItem, ByVal bbPrint As DevExpress.XtraBars.BarButtonItem, ByVal bbShowBy As DevExpress.XtraBars.BarButtonItem, ByVal bbRefresh As DevExpress.XtraBars.BarButtonItem, ByVal bbClose As DevExpress.XtraBars.BarButtonItem)
        bbSave.Hint = DA_SAVE_HINT
        bbPrint.Hint = DA_PRINT_HINT
        bbShowBy.Hint = DA_CE_HINT
        bbRefresh.Hint = DA_REFRESH_HINT
        bbClose.Hint = DA_CLOSE_HINT

        bbSave.Caption = "Save"
        bbPrint.Caption = "Print"
        bbShowBy.Caption = "Group By Customer"
        bbRefresh.Caption = "Refresh"
        bbClose.Caption = "Close"

        bbSave.Glyph = DA.WinForms.My.Resources.Resources.save
        bbPrint.Glyph = DA.WinForms.My.Resources.Resources.print
        bbShowBy.Glyph = DA.WinForms.My.Resources.Resources.ShowBy
        bbRefresh.Glyph = DA.WinForms.My.Resources.Resources.Refresh
        bbClose.Glyph = DA.WinForms.My.Resources.Resources.Close

        bbSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbShowBy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbShowBy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph

    End Sub
#End Region

#Region "Expenses Bar Button Setting"
    Public Sub SetDAExpenseBarButton(ByVal bbSave As DevExpress.XtraBars.BarButtonItem, ByVal bbNew As DevExpress.XtraBars.BarButtonItem, ByVal bbDelete As DevExpress.XtraBars.BarButtonItem, ByVal bbClose As DevExpress.XtraBars.BarButtonItem, ByVal bbDisplaySelected As DevExpress.XtraBars.BarButtonItem, ByVal bbRefresh As DevExpress.XtraBars.BarButtonItem)

        bbSave.Caption = "Save"
        bbNew.Caption = "New"
        bbDelete.Caption = "Delete"
        bbClose.Caption = "Close"
        bbDisplaySelected.Caption = "Display Selected"
        bbRefresh.Caption = "Refresh"


        bbSave.Hint = DA_SAVE_HINT
        bbNew.Hint = DA_NEW_HINT
        bbDelete.Hint = DA_DELETE_HINT
        bbClose.Hint = DA_CLOSE_HINT
        bbDisplaySelected.Hint = DA_DISPLAYSELECTED_HINT
        bbRefresh.Hint = DA_REFRESH_HINT


        bbSave.Glyph = DA.WinForms.My.Resources.Resources.save
        bbNew.Glyph = DA.WinForms.My.Resources.Resources._New
        bbDelete.Glyph = DA.WinForms.My.Resources.Resources.delete
        bbClose.Glyph = DA.WinForms.My.Resources.Resources.Close
        bbDisplaySelected.Glyph = DA.WinForms.My.Resources.Resources.ShowBy
        bbRefresh.Glyph = DA.WinForms.My.Resources.Resources.Reconcile


        bbSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbDisplaySelected.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph


    End Sub
#End Region

#Region "Pop Dialog boxes"

    Public Sub MessageOK(ByVal Title As String, ByVal LabelTitle As String, ByVal LabelDes As String)
        Dim f As New frmOk
        f.Text = Title
        f.lblTitle.Text = LabelTitle
        f.lblDescription.Text = LabelDes
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
    End Sub

    Public Function MessageYesNo(ByVal Title As String, ByVal Label As String, ByVal textbox As String) As DialogResult

        Dim f As New frmYesNo
        f.Text = Title
        f.LabelControl1.Text = Label
        f.LabelControl2.Text = textbox
        f.ShowDialog()
        If f.DialogResult = DialogResult.No Then
            Exit Function
        End If


    End Function

    Public Function MessageError(ByVal strMessage As String) As DialogResult

        Dim f As New frmError
        f.meErrorMessage.Text = strMessage
        f.ShowDialog()
        If f.DialogResult = DialogResult.No Then
            Exit Function
        End If


    End Function

#End Region

#Region "Prescription Bar Button"
    Public Sub SetDAPrescriptionBarButton(ByVal bbSave As DevExpress.XtraBars.BarButtonItem, ByVal bbNew As DevExpress.XtraBars.BarButtonItem, ByVal bbFind As DevExpress.XtraBars.BarButtonItem, ByVal bbClose As DevExpress.XtraBars.BarButtonItem)

        bbSave.Hint = DA_SAVE_HINT
        bbNew.Hint = DA_NEW_HINT
        bbClose.Hint = DA_CLOSE_HINT
        bbSave.Caption = "Save"
        bbNew.Caption = "New"
        bbFind.Caption = "Find"
        bbClose.Caption = "Close"

        bbSave.Glyph = DA.WinForms.My.Resources.Resources.save
        bbNew.Glyph = DA.WinForms.My.Resources.Resources._New
        bbClose.Glyph = DA.WinForms.My.Resources.Resources.Close
        bbFind.Glyph = DA.WinForms.My.Resources.Resources.zoom

        bbSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        bbFind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph








    End Sub
#End Region

#Region "Print Preview"
    Public Sub PrintPreview(ByVal grid As DevExpress.XtraGrid.GridControl, ByVal reportheadername As String)
        Try
         

            Dim _DACompany As New DA.StartUp.DACompany
            _DACompany.GetCompany()

            Dim Link As New PrintableComponentLink()

            Link.PrintingSystem = New PrintingSystem
            Link.Component = grid

            Dim a As PageHeaderFooter
            a = Link.PageHeaderFooter
            a.Header.LineAlignment = BrickAlignment.Center
            a.Header.Content.Add(" ")
            a.Header.Content.Add("" + _DACompany.CompanyName + vbCrLf + reportheadername + vbCrLf + "Printed On -" + Date.Now.ToString("dd-MMM-yy hh:mm:tt"))

            frmPrintPreview.PrintControl1.PrintingSystem = Link.PrintingSystem

            Link.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 50)
            Link.CreateDocument()
            frmPrintPreview.MdiParent = frmMain
            frmPrintPreview.Show()
            frmPrintPreview.BringToFront()



        Catch ex As Exception
            MessageError(ex.ToString)
        End Try


    End Sub
#End Region

End Module
