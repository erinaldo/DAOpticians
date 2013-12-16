Imports DA.Stock.DAPurchasing
Imports DA.StartUp.DASuppliers
Imports DA.StartUp.DAStock
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DA.Collections
Imports DA.Common


Public Class frmPurchases

#Region "Variables"
    Dim _DApurchasing As DA.Stock.DAPurchasing
    Dim _DASuppliers As DA.StartUp.DASuppliers
    Dim _DAStockItems As DA.StartUp.DAStock
    Dim _DACollections As DA.Collections.DACollections
    Dim _DAEnums As DA.Common.DAEnums



#End Region

#Region "Constructor"
    Public ReadOnly Property DApurchasing() As DA.Stock.DaPurchasing
        Get

            If _DApurchasing Is Nothing Then
                _DApurchasing = New DA.Stock.DaPurchasing()
            End If

            Return _DApurchasing
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
    
    Public ReadOnly Property DAStockItems() As DA.StartUp.DAStock
        Get

            If _DAStockItems Is Nothing Then
                _DAStockItems = New DA.StartUp.DAStock()
            End If

            Return _DAStockItems
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

    Private Sub frmPurchases_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPurchasings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetDAPurchaseSalesBarButton(bbSave, bbNew, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)

        Me.HideToolButtonsOnLoad()

    End Sub

    Private Sub frmPurchases_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.PopulateSupplierLookup()
        Me.PopulateStockItemsGridLookup()
        Me.PopulateDescriptionGrid()
        Me.PopulateCollectionsGrid()
    End Sub
#End Region

#Region "Bar Button Events"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        If dxvpPurchase.Validate Then

            If lblPurchaseID.Text = String.Empty Then
                Me.SaveRecords()
                Me.PopulateStockItemsGridLookup()

            Else
                Me.UpdateRecords()
                Me.PopulateStockItemsGridLookup()
            End If

        End If

    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick

        Me.ClearFormData()

    End Sub
    
    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvPurchaseHistory
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With
    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Try
            Me.DisplayRecord()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick

        If (gvPurchaseHistory.RowCount) > 0 Then
            PrintPreview(gcPurchaseHistory, "Purchases Report")
        End If

    End Sub
#End Region

#Region "Clear Form Data"
    Public Sub ClearFormData()

        lblPurchaseID.Text = String.Empty
        teReferenceNo.Text = String.Empty
        seTaxPercent.Text = "0"
        seTaxAmount.Text = "0"
        seDiscount.Text = "0"
        meNote.Text = String.Empty
        sbCalculate.Text = "Calculate"
        lupSupplier.EditValue = DBNull.Value
        Me.PopulateDescriptionGrid()
        Me.PopulateCollectionsGrid()
        lupSupplier.Focus()

    End Sub
#End Region

#Region "Text Edit Events"
    Private Sub teReferenceNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teReferenceNo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            gvPurchasesDescription.AddNewRow()
            gcPurchasesDescription.Focus()
        End If
    End Sub
#End Region

#Region "Simple Button Events"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCalculate.Click
        Dim a As Decimal

        colValue.SummaryItem.DisplayFormat = ""
        a = Val(colValue.SummaryText)
        colValue.SummaryItem.DisplayFormat = "Total : {0:n2}"


        sbCalculate.Text = a + Val(seTaxAmount.EditValue) - Val(seDiscount.EditValue)
        a = 0

        gcCollections.Focus()
        gvCollections.AddNewRow()

    End Sub
#End Region

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

#Region "Populate Stock Items Grid Lookup"
    Public Sub PopulateStockItemsGridLookup()

        Try
            With glupStockItems
                .DataSource = DAStockItems.GetAllStockItems.Tables(0)
                .DisplayMember = "StockCode"
                .ValueMember = "StockCode"
            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Description Grid"
    Public Sub PopulateDescriptionGrid()

        Try
            With gcPurchasesDescription
                DApurchasing.PurchaseID = Convert.ToInt64(IIf(lblPurchaseID.Text = String.Empty, 0, lblPurchaseID.Text))
                .DataSource = DApurchasing.GetPurchaseDescriptionByID.Tables(0)

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Collections Grid"
    Private Sub PopulateCollectionsGrid()
        Try
            DApurchasing.PurchaseID = Convert.ToInt64(IIf(lblPurchaseID.Text = String.Empty, 0, lblPurchaseID.Text))
            DACollections.SystemID = DApurchasing.PurchaseID
            DACollections.TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE
            gcCollections.DataSource = DACollections.CollectionGetByID().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Repository Events"
    Private Sub glupStockItems_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glupStockItems.EditValueChanged
        Try
            gvPurchasesDescription.SetFocusedRowCellValue(colDescription, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvPurchasesDescription.EditingValue))), "Description"))
            gvPurchasesDescription.SetFocusedRowCellValue(colUnitPrice, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvPurchasesDescription.EditingValue))), "PurchasingPrice"))
            gvPurchasesDescription.SetFocusedRowCellValue(colStockID, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvPurchasesDescription.EditingValue))), "StockID"))

        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Grid Events"

    Private Sub gvPurchasesDescription_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPurchasesDescription.CellValueChanged
        Select Case e.Column.VisibleIndex

            Case 2, 3, 4
                Dim a, b, c As Decimal

                a = IIf(Not IsDBNull(gvPurchasesDescription.GetFocusedRowCellValue(colUnitPrice)), gvPurchasesDescription.GetFocusedRowCellValue(colUnitPrice), 0)
                b = IIf(Not IsDBNull(gvPurchasesDescription.GetFocusedRowCellValue(colQuantity)), gvPurchasesDescription.GetFocusedRowCellValue(colQuantity), 0)
                c = IIf(Not IsDBNull(gvPurchasesDescription.GetFocusedRowCellValue(colDiscount)), gvPurchasesDescription.GetFocusedRowCellValue(colDiscount), 0)
                gvPurchasesDescription.SetFocusedRowCellValue(colValue, ((a * b) - c))
                a = 0
                b = 0
                c = 0
        End Select

    End Sub

    Private Sub gvCollectionGrid_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Select Case e.Column.VisibleIndex
            Case 0
                Dim a, b As Decimal

                colValue.SummaryItem.DisplayFormat = ""
                a = Val(Val(colValue.SummaryText))
                colValue.SummaryItem.DisplayFormat = "Total : {0:n2}"



                colAmount.SummaryItem.DisplayFormat = ""
                b = Val(colAmount.SummaryText)
                colAmount.SummaryItem.DisplayFormat = "{0:n2}"


                gvCollections.SetFocusedRowCellValue(colDate, Date.Today)
                gvCollections.SetFocusedRowCellValue(colAmount, Val(a + Val(seTaxAmount.EditValue) - Val(seDiscount.EditValue) - b))

        End Select
    End Sub

    Private Sub gcPurchasesDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvPurchasesDescription.KeyDown
        If e.KeyCode = Keys.Delete Then
            gvPurchasesDescription.DeleteRow(gvPurchasesDescription.FocusedRowHandle)
        End If
    End Sub

    Private Sub gvCollections_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvCollections.KeyDown
        If e.KeyCode = Keys.Delete Then
            gvCollections.DeleteRow(gvCollections.FocusedRowHandle)
        End If
    End Sub

    Private Sub gvPurchaseHistory_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPurchaseHistory.DoubleClick
        Me.DisplayRecord()
    End Sub

    Private Sub ricbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ricbType.SelectedIndexChanged
        Try
            gvCollections.SetFocusedRowCellValue(colDate, Date.Today)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Purchase History"
    Private Sub PopulatePurchaseHistory()

        Try
            gcPurchaseHistory.DataSource = DApurchasing.GetAllPurchases().Tables(0)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Hide Tool Buttons On Load"
    Public Sub HideToolButtonsOnLoad()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never



    End Sub
#End Region

#Region "Show Tool Buttons On History Tab change"
    Public Sub ShowToolButtonsOnHistoryTabChange()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbprint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


    End Sub
#End Region

#Region "Show Tool Buttons On New Record Tab change"
    Public Sub ShowToolButtonsOnNewRecordTabChange()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


    End Sub
#End Region

#Region "Tab Control Events"
    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
        Select Case e.Page.TabControl.SelectedTabPageIndex
            Case 0
                Me.ShowToolButtonsOnNewRecordTabChange()
            Case 1
                Me.ShowToolButtonsOnHistoryTabChange()
                Me.PopulatePurchaseHistory()

        End Select
    End Sub
#End Region

#Region "Spin Edit Events"
    Private Sub seTaxPercent_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seTaxPercent.EditValueChanged
        Me.CalculateTaxAmount()
    End Sub
    Private Sub seTaxPercent_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles seTaxPercent.ButtonClick
        Me.CalculateTaxAmount()
    End Sub
#End Region

#Region "Calculate Tax Amount"
    Private Sub CalculateTaxAmount()
        Dim a, b As Decimal

        colValue.SummaryItem.DisplayFormat = ""
        a = Val(colValue.SummaryText)
        b = a * seTaxPercent.EditValue / 100
        seTaxAmount.EditValue = b
        colValue.SummaryItem.DisplayFormat = "Total : {0:n2}"
    End Sub
#End Region

#Region "Dispay Record"
    Public Sub DisplayRecord()
        If gvPurchaseHistory.RowCount > 0 Then
            xTab1.SelectedTabPageIndex = 0
            With DApurchasing
                .PurchaseID = Me.gvPurchaseHistory.GetFocusedRowCellValue(GridColumn18)
                .GetPurchasesByID()
                lblPurchaseID.Text = .PurchaseID
                lupSupplier.EditValue = .Supplier_ID
                dePurchaseDate.EditValue = .PurchaseDate
                teReferenceNo.Text = .Ref_Bill_No
                meNote.Text = .Note
                seTaxPercent.Text = .TaxPercent
                seTaxAmount.Text = .TaxAmount
                seDiscount.Text = .Discount
                Me.PopulateDescriptionGrid()
                Me.PopulateCollectionsGrid()
            End With


        End If
    End Sub
#End Region

#Region "Save Record"
    Private Sub SaveRecords()



        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try


            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()


            gvPurchasesDescription.PostEditor()
            gvCollections.PostEditor()



            With DApurchasing
                .PurchaseID = Convert.ToInt64(IIf(lblPurchaseID.Text = String.Empty, 0, lblPurchaseID.Text))
                .Supplier_ID = lupSupplier.EditValue
                .PurchaseDate = dePurchaseDate.Text
                .Ref_Bill_No = teReferenceNo.Text.Trim

                colValue.SummaryItem.DisplayFormat = ""
                .Total = gvPurchasesDescription.Columns("Value").SummaryText
                .TaxPercent = seTaxPercent.Text
                .TaxAmount = seTaxAmount.Text
                .Discount = seDiscount.Text
                .Note = meNote.Text
                .Paid = 0
                .InsertPurchase(_DB, _Transaction)



                For i As Integer = 0 To Me.gvPurchasesDescription.RowCount
                    If Not gvPurchasesDescription.GetRowCellDisplayText(i, gvPurchasesDescription.Columns(0)) = "" Then
                        .PurchaseID = .CurrentPurchaseID
                        .StockID = Me.gvPurchasesDescription.GetRowCellDisplayText(i, colStockID)
                        .Unit_Price = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colUnitPrice))
                        .Quantity = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colQuantity))
                        .Discount = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colDiscount))
                        .Value = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colValue))
                        .InsertPurchaseDescription(_DB, _Transaction)

                        'Update Main Stock
                        .StockID = Me.gvPurchasesDescription.GetRowCellDisplayText(i, colStockID)
                        .StockBalance = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colQuantity))
                        .UpdateStock(_DB, _Transaction)


                    End If

                Next



                With DACollections
                    For i As Integer = 0 To Me.gvCollections.RowCount
                        If Not gvCollections.GetRowCellDisplayText(i, gvCollections.Columns(0)) = "" Then
                            .SystemID = DApurchasing.CurrentPurchaseID
                            .TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE

                            Select Case Me.gvCollections.GetRowCellDisplayText(i, colType)

                                Case "CASH"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                                Case "CHECK"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                                Case "CR CARD"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD

                            End Select

                            .Date = Date.Parse(Me.gvCollections.GetRowCellDisplayText(i, colDate))
                            .Reference = Me.gvCollections.GetRowCellDisplayText(i, colCheckNo)


                            If (Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate) = String.Empty) Then
                                .ReferenceDate = DateTime.MinValue
                            Else
                                .ReferenceDate = Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate)

                            End If

                            .Bank = Me.gvCollections.GetRowCellDisplayText(i, colBank)

                            .Amount = Val(Me.gvCollections.GetRowCellDisplayText(i, colAmount))
                            .InsertCollection(_DB, _Transaction)
                        End If

                    Next

                End With



                _Transaction.Commit()
                Me.ClearFormData()


            End With


        Catch ex As Exception
            _Transaction.Rollback()
        Finally
            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If

        End Try
    End Sub
#End Region

#Region "Update Records"
    Private Sub UpdateRecords()

        Dim f As New frmYesNo
        f.Text = "Save the record?"
        f.LabelControl1.Text = "Saving this record will overwrite any existing record..."
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


                gvPurchasesDescription.PostEditor()
                gvCollections.PostEditor()

                With DApurchasing
                    .PurchaseID = Convert.ToInt64(IIf(lblPurchaseID.Text = String.Empty, 0, lblPurchaseID.Text))
                    .Supplier_ID = lupSupplier.EditValue
                    .PurchaseDate = dePurchaseDate.Text
                    .Ref_Bill_No = teReferenceNo.Text.Trim

                    colValue.SummaryItem.DisplayFormat = ""
                    .Total = gvPurchasesDescription.Columns("Value").SummaryText
                    .TaxPercent = seTaxPercent.Text
                    .TaxAmount = seTaxAmount.Text
                    .Discount = seDiscount.Text
                    .Note = meNote.Text
                    .Paid = 0
                    .InsertPurchase(_DB, _Transaction)

                    .RemoveFromStock(_DB, _Transaction)
                    .PurchasesDescriptionDelete(_DB, _Transaction)


                    For i As Integer = 0 To Me.gvPurchasesDescription.RowCount
                        If Not gvPurchasesDescription.GetRowCellDisplayText(i, gvPurchasesDescription.Columns(0)) = "" Then

                            .StockID = Me.gvPurchasesDescription.GetRowCellDisplayText(i, colStockID)
                            .Unit_Price = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colUnitPrice))
                            .Quantity = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colQuantity))
                            .Discount = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colDiscount))
                            .Value = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colValue))
                            .InsertPurchaseDescription(_DB, _Transaction)

                            'Update Main Stock
                            .StockID = Me.gvPurchasesDescription.GetRowCellDisplayText(i, colStockID)
                            .StockBalance = Val(Me.gvPurchasesDescription.GetRowCellDisplayText(i, colQuantity))
                            .UpdateStock(_DB, _Transaction)


                        End If

                    Next



                    With DACollections
                        .SystemID = Convert.ToInt64(IIf(lblPurchaseID.Text = String.Empty, 0, lblPurchaseID.Text))
                        .TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE
                        .CollectionDelete(_DB, _Transaction)


                        'Add new Records to Collection Table
                        For i As Integer = 0 To Me.gvCollections.RowCount
                            If Not gvCollections.GetRowCellDisplayText(i, gvCollections.Columns(0)) = "" Then
                                .SystemID = Convert.ToInt64(IIf(lblPurchaseID.Text = String.Empty, 0, lblPurchaseID.Text))
                                .TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE

                                Select Case Me.gvCollections.GetRowCellDisplayText(i, colType)

                                    Case "CASH"
                                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                                    Case "CHECK"
                                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                                    Case "CR CARD"
                                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD

                                End Select

                                .Date = Date.Parse(Me.gvCollections.GetRowCellDisplayText(i, colDate))
                                .Reference = Me.gvCollections.GetRowCellDisplayText(i, colCheckNo)


                                If (Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate) = String.Empty) Then
                                    .ReferenceDate = DateTime.MinValue
                                Else
                                    .ReferenceDate = Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate)

                                End If

                                .Bank = Me.gvCollections.GetRowCellDisplayText(i, colBank)

                                .Amount = Val(Me.gvCollections.GetRowCellDisplayText(i, colAmount))
                                .InsertCollection(_DB, _Transaction)
                            End If

                        Next

                    End With


                    _Transaction.Commit()
                    Me.ClearFormData()


                End With

            Catch ex As Exception
                _Transaction.Rollback()
            Finally
                If _Connection.State = ConnectionState.Open Then
                    _Connection.Close()
                End If

            End Try

        Else
            Exit Sub
        End If

    End Sub
#End Region

#Region "Show Print Preview"
    Private Sub ShowPrintPreview()
        Try
            Dim _frmPrintPreview As New frmPrintPreview
            Dim _xrPurchasing As New xrPurchasing
            _xrPurchasing.Purchases_GetByIDTableAdapter.GetData(Me.gvPurchaseHistory.GetFocusedRowCellValue(GridColumn18))
            _xrPurchasing.PurchasesDescription_GetByIDTableAdapter.GetData(Me.gvPurchaseHistory.GetFocusedRowCellValue(GridColumn18))
            _frmPrintPreview.PrintControl1.PrintingSystem = _xrPurchasing.PrintingSystem

            _xrPurchasing.CreateDocument()

            _frmPrintPreview.MdiParent = frmMain
            _frmPrintPreview.Show()
            _frmPrintPreview.BringToFront()
        Catch ex As Exception

        End Try
    End Sub
#End Region
    
    
End Class