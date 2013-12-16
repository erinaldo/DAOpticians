Imports DA.Stock.DAPurchasing
Imports DA.Collections
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraReports.UI

Public Class frmPayBillsAll

#Region "Variables"

    Dim _DAPurchasing As DA.Stock.DAPurchasing
    Dim _DACollections As DA.Collections.DACollections
    Dim _DAEnums As DA.Common.DAEnums
    Dim _DASuppliers As DA.StartUp.DASuppliers
#End Region

#Region "Constructor"

    Public ReadOnly Property DAPurchasing() As DA.Stock.DAPurchasing
        Get

            If _DAPurchasing Is Nothing Then
                _DAPurchasing = New DA.Stock.DAPurchasing()
            End If

            Return _DAPurchasing
        End Get
    End Property

    Public ReadOnly Property DASuppliers() As DA.StartUp.DASuppliers
        Get

            If _DASuppliers Is Nothing Then
                _DASuppliers = New DA.StartUp.DASuppliers()
            End If

            Return _DASuppliers
        End Get
    End Property

    Public ReadOnly Property DACollections() As DA.Collections.DACollections
        Get

            If _DACollections Is Nothing Then
                _DACollections = New DA.Collections.DACollections()
            End If

            Return _DACollections
        End Get
    End Property


    Public ReadOnly Property DAEnums() As DA.Common.DAEnums
        Get

            If _DAEnums Is Nothing Then
                _DAEnums = New DA.Common.DAEnums()
            End If

            Return _DAEnums
        End Get
    End Property
#End Region

#Region "Form Events"

    Private Sub frmPayBills_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        PopulateSupplierLookup()


    End Sub

    Private Sub frmPayBills_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetDAPayBillsBarButton(bbSave, bbPrint, bbShowBy, bbRefresh, bbClose)
        bbShowBy.Caption = "Delete"
        Me.dePaymentDate.EditValue = Date.Today
        Me.cbeType.Text = "CHECK"

        bbShowBy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        deFromDate.EditValue = Today
        deToDate.EditValue = Today


    End Sub

    Private Sub frmPayBills_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Bar Button Events"

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If DxValidationProvider2.Validate Then
            Me.PopulateUnsettleGrid()
        End If
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        ShowPrintPreview(Me.gvPayments.GetFocusedRowCellValue(ColCollectionID))
    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        If DxValidationProvider1.Validate Then


            Dim f As New frmYesNo
            f.Text = "Save the record?"
            f.LabelControl1.Text = "Do you want to pay following bills?"
            f.LabelControl2.Text = "Click YES to save the record"
            f.ShowDialog()
            If f.DialogResult = Windows.Forms.DialogResult.Yes Then


                Dim _Connection As DbConnection = Nothing
                Dim _Transaction As DbTransaction = Nothing
                Try
                    Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
                    _Connection = _DB.CreateConnection
                    _Connection.Open()
                    _Transaction = _Connection.BeginTransaction()

                    With DACollections
                        .SystemID = -1
                        .TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE

                        Select Case cbeType.Text

                            Case "CASH"
                                .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                            Case "CHECK"
                                .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                            Case "CR CARD"
                                .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD

                        End Select

                        .Date = Date.Parse(dePaymentDate.EditValue)
                        .Reference = teCheckNo.Text.Trim()
                        .ReferenceDate = deCheckdate.EditValue

                        .Bank = Me.cbeBank.Text

                        .Amount = Val(seAmount.EditValue)
                        .Remarks = Convert.ToDateTime(deFromDate.EditValue).ToString("dd-MMM-yy") + " - " + Convert.ToDateTime(deToDate.EditValue).ToString("dd-MMM-yy")
                        .InsertCollectionNew(_DB, _Transaction)

                    End With

                    For i As Integer = 0 To Me.gvUnsettledBills.RowCount - 1

                        With DAPurchasing
                            .PurchaseID = Me.gvUnsettledBills.GetRowCellDisplayText(i, GridColumn1)
                            .SetAsPaid(_DB, _Transaction)
                        End With

                        With DACollections
                            .PurchaseID = Me.gvUnsettledBills.GetRowCellDisplayText(i, GridColumn1)
                            .InsertInvoiceCollection(_DB, _Transaction)
                        End With

                    Next

                    _Transaction.Commit()

                    Dim frmx As New frmSavedOk
                    frmx.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                    frmx.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                    frmx.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                    frmx.ShowDialog()

                    Me.ShowPrintPreview(DACollections.CollectionID)

                    Me.PopulateUnsettleGrid()
                    Me.ClearFormData()

                Catch ex As Exception
                    _Transaction.Rollback()
                Finally
                    If _Connection.State = ConnectionState.Open Then
                        _Connection.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub bbShowBy_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbShowBy.ItemClick

        Dim frm As New frmYesNo

        frm.LabelControl1.Text = "It is not recormended to delete the selected record?"
        frm.LabelControl2.ForeColor = Color.Red
        frm.LabelControl2.Text = "Click Yes to Delete..."
        frm.Text = "Delete The Current Record ?"

        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            DACollections.CollectionID = Me.gvPayments.GetFocusedRowCellValue(ColCollectionID)
            DACollections.CollectionDeleteID()
            Me.PopulateSettleGrid()
        End If

    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick

        Select Case xTab1.SelectedTabPageIndex
            Case 0
                With gvUnsettledBills
                    .ClearColumnsFilter()
                    .ClearGrouping()
                    .ClearSelection()
                    .ClearSorting()
                End With

            Case 1
                With gvPayments
                    .ClearColumnsFilter()
                    .ClearGrouping()
                    .ClearSelection()
                    .ClearSorting()
                End With


        End Select


    End Sub
#End Region

#Region "Populate Unsettle Purchase Bills"
    Private Sub PopulateUnsettleGrid()
        Try
            DAPurchasing.Supplier_ID = Convert.ToInt64(Me.lupSupplier.EditValue)
            DAPurchasing.FromDate = Convert.ToDateTime(Me.deFromDate.EditValue)
            DAPurchasing.ToDate = Convert.ToDateTime(Me.deToDate.EditValue)

            gcUnsettledBills.DataSource = DAPurchasing.GetAllPurchaseUnsettledBills().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Settled Purchase Bills"
    Private Sub PopulateSettleGrid()
        Try
            gcPayments.DataSource = DACollections.CollectionGetAll().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Tab Control Events"
    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
        Select Case e.Page.TabControl.SelectedTabPageIndex
            Case 0
                Me.PopulateUnsettleGrid()
                lgPaymentGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                bbShowBy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                ' Me.txtPurchaseID.Text = String.Empty
                ' Me.txtSupplier.Text = String.Empty
            Case 1
                Me.PopulateSettleGrid()
                lgPaymentGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                bbShowBy.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'Me.txtPurchaseID.Text = String.Empty
                'Me.txtSupplier.Text = String.Empty

        End Select
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gcUnsettledBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcUnsettledBills.Click
        Me.DisplayRecord()
    End Sub

    Private Sub gvUnsettledBills_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvUnsettledBills.FocusedRowChanged
        Me.DisplayRecord()
    End Sub


    Private Sub gvSettledBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPayments.Click
        ' Me.DisplayRecord()
    End Sub

    Private Sub gvSettledBills_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPayments.FocusedRowChanged
        Me.DisplayRecord()
    End Sub

    Private Sub ricbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' gvCollections.SetFocusedRowCellValue(colDate, Date.Today)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Display Record"
    Private Sub DisplayRecord()

        Select Case xTab1.SelectedTabPageIndex
            Case 0

                'Me.txtPurchaseID.Text = gvUnsettledBills.GetFocusedRowCellValue(GridColumn1)


            Case 1
                'Me.txtPurchaseID.Text = gvSettledBills.GetFocusedRowCellValue(GridColumn13)



        End Select



    End Sub
#End Region


    Private Sub ClearFormData()
        Try
            teCheckNo.EditValue = Nothing
            deCheckdate.EditValue = Nothing
            cbeBank.EditValue = Nothing
            seAmount.EditValue = 0
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub


    Private Sub gvPayments_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPayments.DoubleClick
        'If gvPayments.RowCount > 0 Then
        '    xTab1.SelectedTabPageIndex = 0
        'End If
    End Sub


#Region "Populate Suppliers Lookup"
    Public Sub PopulateSupplierLookup()

        Try
            With lupSupplier
                .Properties.DataSource = DASuppliers.GetAllSuppliers.Tables(0)
                .Properties.DisplayMember = "Name"
                .Properties.ValueMember = "SupplierID"
                .Properties.PopupWidth = 350
            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region




    Private Sub ShowPrintPreview(ByVal collectionID As Long)
        Try
            Dim report As New xrPayment
            frmPrintPreview.PrintControl1.PrintingSystem = report.PrintingSystem


            Dim _DACompany As New DA.StartUp.DACompany
            _DACompany.GetCompany()

            report.xrCompany.Text = _DACompany.CompanyName
            report.xrCompanyName.Text = _DACompany.Address1 & vbNewLine + _DACompany.Address2 & vbNewLine + "Tel No : " + _DACompany.Telephone & vbNewLine + "Fax : " + _DACompany.Fax

            Dim ds As New DataSet


            With DACollections
                ' .CollectionID = Me.gvPayments.GetFocusedRowCellValue(ColCollectionID)
                .CollectionID = collectionID

                ds = .CollectionGetByCollectionID()




                If (ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0) Then
                    report.xrPeriod.Text = "Period : " + ds.Tables(0).Rows(0)("Remarks").ToString()

                    Dim paymentype As Integer

                    paymentype = Convert.ToInt32(ds.Tables(0).Rows(0)("PaymentTypeID").ToString())

                    If (paymentype = 1) Then
                        report.xrType.Text = ": " & "CASH"
                    ElseIf (paymentype = 2) Then
                        report.xrType.Text = ": " & "CHECK"
                    ElseIf (paymentype = 3) Then
                        report.xrType.Text = ": " & "CR CARD"
                    ElseIf (paymentype = 4) Then
                        report.xrType.Text = ": " & "OTHER"
                    End If
                    report.xrPayDate.Text = ": " & Convert.ToDateTime(ds.Tables(0).Rows(0)("Date").ToString()).ToString("dd-MMM-yy")
                    report.xrCheckNo.Text = ": " & ds.Tables(0).Rows(0)("Reference").ToString()
                    report.xrCheckDate.Text = ": " & Convert.ToDateTime(ds.Tables(0).Rows(0)("ReferenceDate").ToString()).ToString("dd-MMM-yy")
                    report.xrBank.Text = ": " & ds.Tables(0).Rows(0)("Bank").ToString()
                    report.xrAmount.Text = ": " & Convert.ToDecimal(ds.Tables(0).Rows(0)("Amount").ToString()).ToString("F2")
                End If

                If (ds.Tables.Count > 0 And ds.Tables(1).Rows.Count > 0) Then

                    Dim recount As Integer
                    recount = ds.Tables(1).Rows.Count

                    Dim total As Decimal
                    total = 0



                    For index As Integer = 0 To recount - 1



                        If (index = 0) Then

                            report.xrA.Text = IIf(IsDBNull(ds.Tables(1).Rows(index)("PurchaseID")), String.Empty, ds.Tables(1).Rows(index)("PurchaseID").ToString())
                            report.xrB.Text = IIf(IsDBNull(ds.Tables(1).Rows(index)("ReferenceNo")), String.Empty, ds.Tables(1).Rows(index)("ReferenceNo").ToString())
                            report.xrC.Text = Convert.ToDateTime(IIf(IsDBNull(ds.Tables(1).Rows(index)("PurchaseDate")), String.Empty, ds.Tables(1).Rows(index)("PurchaseDate"))).ToString("dd-MMM-yy")
                            report.xrD.Text = Convert.ToDecimal(IIf(IsDBNull(ds.Tables(1).Rows(index)("Total")), "0", ds.Tables(1).Rows(index)("Total"))).ToString("F2")

                            total = total + Convert.ToDecimal(IIf(IsDBNull(ds.Tables(1).Rows(index)("Total")), "0", ds.Tables(1).Rows(index)("Total"))).ToString("F2")

                            report.xrSupplier.Text = "Supplier : " & ds.Tables(1).Rows(index)("Name").ToString

                        Else

                            Dim detailsRow As New XRTableRow
                            Dim detailCell1 As New XRTableCell
                            Dim detailCell2 As New XRTableCell
                            Dim detailCell3 As New XRTableCell
                            Dim detailCell4 As New XRTableCell

                            detailCell1.Width = report.xrA.Width
                            detailCell2.Width = report.xrB.Width
                            detailCell3.Width = report.xrC.Width
                            detailCell4.Width = report.xrD.Width

                            detailCell1.TextAlignment = report.xrA.TextAlignment
                            detailCell2.TextAlignment = report.xrB.TextAlignment
                            detailCell3.TextAlignment = report.xrC.TextAlignment
                            detailCell4.TextAlignment = report.xrD.TextAlignment

                            detailCell1.Text = IIf(IsDBNull(ds.Tables(1).Rows(index)("PurchaseID")), String.Empty, ds.Tables(1).Rows(index)("PurchaseID").ToString())
                            detailCell2.Text = IIf(IsDBNull(ds.Tables(1).Rows(index)("ReferenceNo")), String.Empty, ds.Tables(1).Rows(index)("ReferenceNo").ToString())
                            detailCell3.Text = Convert.ToDateTime(IIf(IsDBNull(ds.Tables(1).Rows(index)("PurchaseDate")), String.Empty, ds.Tables(1).Rows(index)("PurchaseDate"))).ToString("dd-MMM-yy")
                            detailCell4.Text = Convert.ToDecimal(IIf(IsDBNull(ds.Tables(1).Rows(index)("Total")), String.Empty, ds.Tables(1).Rows(index)("Total"))).ToString("F2")

                            total = total + Convert.ToDecimal(IIf(IsDBNull(ds.Tables(1).Rows(index)("Total")), "0", ds.Tables(1).Rows(index)("Total"))).ToString("F2")

                            detailsRow.Cells.Add(detailCell1)
                            detailsRow.Cells.Add(detailCell2)
                            detailsRow.Cells.Add(detailCell3)
                            detailsRow.Cells.Add(detailCell4)

                            report.xrDetials.Rows.Add(detailsRow)

                        End If

                    Next

                    Dim detailsFooterRow As New XRTableRow
                    Dim detailFooterCell1 As New XRTableCell
                    Dim detailFooterCell2 As New XRTableCell

                    detailFooterCell1.Width = report.xrA.Width + report.xrB.Width + report.xrC.Width
                    detailFooterCell2.Width = report.xrD.Width

                    detailFooterCell1.Text = "Total"
                    detailFooterCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter

                    detailFooterCell2.Text = total.ToString("F2")
                    detailFooterCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight

                    detailsFooterRow.Cells.Add(detailFooterCell1)
                    detailsFooterRow.Cells.Add(detailFooterCell2)

                    detailsFooterRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    report.xrDetials.Rows.Add(detailsFooterRow)

                End If


            End With





            report.CreateDocument()
            report.BringToFront()
            frmPrintPreview.MdiParent = frmMain
            frmPrintPreview.Show()
            frmPrintPreview.BringToFront()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

End Class