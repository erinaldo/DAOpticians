Imports DA.Stock.DASales
Imports DA.StartUp.DACustomers
Imports DA.StartUp.DAStock
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DA.Common



Public Class frmSales

#Region "Variables"
    Dim _DASales As DA.Stock.DASales
    Dim _DACustomers As DA.StartUp.DACustomers
    Dim _DAStockItems As DA.StartUp.DAStock
    Dim _DACollections As DA.Collections.DACollections
    Dim _DAEnums As DA.Common.DAEnums

  


#End Region

#Region "Constructor"
    Public ReadOnly Property DASales() As DA.Stock.DASales
        Get

            If _DASales Is Nothing Then
                _DASales = New DA.Stock.DASales
            End If

            Return _DASales
        End Get
    End Property

    Public ReadOnly Property DACustomers() As DA.StartUp.DACustomers
        Get

            If _DACustomers Is Nothing Then
                _DACustomers = New DA.StartUp.DACustomers
            End If

            Return _DACustomers
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
    Public ReadOnly Property DAStockItems() As DA.StartUp.DAStock
        Get

            If _DAStockItems Is Nothing Then
                _DAStockItems = New DA.StartUp.DAStock()
            End If

            Return _DAStockItems
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

    Private Sub frmSales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetDAPurchaseSalesBarButton(bbSave, bbNew, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)

        Me.HideToolButtonsOnLoad()
    End Sub

    Private Sub frmSales_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.PopulateCustomerLookup()
        Me.PopulateStockItemsGridLookup()
        Me.PopulateDescriptionGrid()
        Me.PopulateCollectionsGrid()
    End Sub



#End Region

#Region "Bar Button Events"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        If dxvpSales.Validate Then

            If lblSalesID.Text = String.Empty Then
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
        With gvSalesHistory
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With
    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Me.DisplayRecord()
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick

        Select Case xTab1.SelectedTabPageIndex
            Case 0
                If Me.lblSalesID.Text = String.Empty Then
                    'MessageOK("Can not print", "Emptry Record", "Select a record and try again...")
                    'Exit Sub
                    Me.ShowPrintPreview()
                End If
            Case 1
                If gvSalesHistory.RowCount > 0 Then
                    PrintPreview(gcSalesHistory, "Sales Report")
                End If

        End Select

     
    End Sub

#End Region

#Region "Clear Form Data"
    Public Sub ClearFormData()

        lblSalesID.Text = String.Empty
        teReferenceNo.Text = String.Empty
        seTaxPercent.Text = "0"
        seTaxAmount.Text = "0"
        seDiscount.Text = "0"
        meNote.Text = String.Empty
        sbCalculate.Text = "Calculate"
        lupCustomer.EditValue = DBNull.Value
        Me.PopulateDescriptionGrid()
        Me.PopulateCollectionsGrid()
        lupCustomer.Focus()

    End Sub
#End Region

#Region "Text Edit Events"
    Private Sub teReferenceNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teReferenceNo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            gvSalesDescription.AddNewRow()
            gcSalesDescription.Focus()
        End If
    End Sub
#End Region

#Region "Simple Button Events"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCalculate.Click
        Dim a As Decimal

        GridColumn5.SummaryItem.DisplayFormat = ""
        a = Val(GridColumn5.SummaryText)
        GridColumn5.SummaryItem.DisplayFormat = "Total : {0:n2}"


        sbCalculate.Text = a + Val(seTaxAmount.EditValue) - Val(seDiscount.EditValue)
        a = 0

        gcCollections.Focus()
        gvCollections.AddNewRow()

    End Sub
#End Region

#Region "Populate Customer Lookup"
    Public Sub PopulateCustomerLookup()

        Try
            With lupCustomer
                .Properties.DataSource = DACustomers.GetAllCustomers().Tables(0)
                .Properties.DisplayMember = "CustomerName"
                .Properties.ValueMember = "CustomerID"
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
            With gcSalesDescription
                DASales.SalesID = Convert.ToInt64(IIf(lblSalesID.Text = String.Empty, 0, lblSalesID.Text))
                .DataSource = DASales.GetSalesDescriptionByID.Tables(0)

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Collections Grid"
    Private Sub PopulateCollectionsGrid()
        Try
            DASales.SalesID = Convert.ToInt64(IIf(lblSalesID.Text = String.Empty, 0, lblSalesID.Text))
            DACollections.SystemID = DASales.SalesID
            DACollections.TransactionTypeID = DAEnums.EnumTransactionTypes.SALES
            gcCollections.DataSource = DACollections.CollectionGetByID().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Repository Events"
    Private Sub glupStockItems_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glupStockItems.EditValueChanged
        gvSalesDescription.SetFocusedRowCellValue(colDescription, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvSalesDescription.EditingValue))), "Description"))
        gvSalesDescription.SetFocusedRowCellValue(colUnitPrice, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvSalesDescription.EditingValue))), "SalesPrice"))
        gvSalesDescription.SetFocusedRowCellValue(colStockID, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvSalesDescription.EditingValue))), "StockID"))
        gvSalesDescription.SetFocusedRowCellValue(colPurchasePrice, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvSalesDescription.EditingValue))), "PurchasingPrice"))

    End Sub
#End Region

#Region "Grid Events"

    Private Sub gvSalesDescription_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvSalesDescription.CellValueChanged
        Select Case e.Column.VisibleIndex

            Case 2, 3, 4
                Dim a, b, c As Decimal

                a = IIf(Not IsDBNull(gvSalesDescription.GetFocusedRowCellValue(GridColumn12)), gvSalesDescription.GetFocusedRowCellValue(GridColumn12), 0)
                b = IIf(Not IsDBNull(gvSalesDescription.GetFocusedRowCellValue(GridColumn3)), gvSalesDescription.GetFocusedRowCellValue(GridColumn3), 0)
                c = IIf(Not IsDBNull(gvSalesDescription.GetFocusedRowCellValue(GridColumn4)), gvSalesDescription.GetFocusedRowCellValue(GridColumn4), 0)
                gvSalesDescription.SetFocusedRowCellValue(GridColumn5, ((a * b) - c))
                a = 0
                b = 0
                c = 0
        End Select

    End Sub

    Private Sub gvCollections_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Select Case e.Column.VisibleIndex
            Case 0
                Dim a, b As Decimal

                GridColumn5.SummaryItem.DisplayFormat = ""
                a = Val(Val(GridColumn5.SummaryText))
                GridColumn5.SummaryItem.DisplayFormat = "Total : {0:n2}"



                GridColumn16.SummaryItem.DisplayFormat = ""
                b = Val(GridColumn16.SummaryText)
                GridColumn16.SummaryItem.DisplayFormat = "{0:n2}"


                gvCollections.SetFocusedRowCellValue(GridColumn14, Date.Today)
                gvCollections.SetFocusedRowCellValue(GridColumn16, Val(a + Val(seTaxAmount.EditValue) - Val(seDiscount.EditValue) - b))

        End Select
    End Sub

    Private Sub gcSalessDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvSalesDescription.KeyDown
        If e.KeyCode = Keys.Delete Then
            gvSalesDescription.DeleteRow(gvSalesDescription.FocusedRowHandle)
        End If
    End Sub

    Private Sub gcCollections_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcCollections.KeyDown, gvCollections.KeyDown
        If e.KeyCode = Keys.Delete Then
            gvCollections.DeleteRow(gvCollections.FocusedRowHandle)
        End If
    End Sub

    Private Sub gvSalesHistory_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSalesHistory.DoubleClick
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

#Region "Populate Sales History"
    Private Sub PopulateSalesHistory()

        Try
            gcSalesHistory.DataSource = DASales.GetAllSales().Tables(0)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Hide Tool Buttons On Load"
    Public Sub HideToolButtonsOnLoad()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


    End Sub
#End Region

#Region "Show Tool Buttons On History Tab change"
    Public Sub ShowToolButtonsOnHistoryTabChange()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


    End Sub
#End Region

#Region "Show Tool Buttons On New Record Tab change"

    Public Sub ShowToolButtonsOnNewRecordTabChange()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


    End Sub

#End Region

#Region "Tab Control Events"
    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
        Select Case e.Page.TabControl.SelectedTabPageIndex
            Case 0
                Me.ShowToolButtonsOnNewRecordTabChange()
            Case 1
                Me.ShowToolButtonsOnHistoryTabChange()
                Me.PopulateSalesHistory()

        End Select
    End Sub
#End Region

#Region "Spin Edit Events"
    Private Sub seTaxPercent_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seTaxPercent.EditValueChanged, seTaxPercent.EditValueChanged
        Me.CalculateTaxAmount()
    End Sub
    Private Sub seTaxPercent_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles seTaxPercent.ButtonClick, seTaxPercent.ButtonClick
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
        If gvSalesHistory.RowCount > 0 Then
            xTab1.SelectedTabPageIndex = 0
            With DASales
                .SalesID = Me.gvSalesHistory.GetFocusedRowCellValue(GridColumn41)
                .GetSalesByID()
                lblSalesID.Text = .SalesID
                lupCustomer.EditValue = .CustomerID
                deSalesDate.EditValue = .SalesDate
                teReferenceNo.Text = .ReferenceNo
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


            gvSalesDescription.PostEditor()
            gvCollections.PostEditor()

            With DASales
                .SalesID = Convert.ToInt64(IIf(lblSalesID.Text = String.Empty, 0, lblSalesID.Text))
                .CustomerID = lupCustomer.EditValue
                .SalesDate = deSalesDate.Text
                .ReferenceNo = teReferenceNo.Text.Trim

                colValue.SummaryItem.DisplayFormat = ""
                .Total = gvSalesDescription.Columns("Value").SummaryText
                .TaxPercent = seTaxPercent.Text
                .TaxAmount = seTaxAmount.Text
                .Discount = seDiscount.Text
                .Note = meNote.Text
                .Paid = 0
                .InsertSales(_DB, _Transaction)


                For i As Integer = 0 To Me.gvSalesDescription.RowCount
                    If Not gvSalesDescription.GetRowCellDisplayText(i, gvSalesDescription.Columns(0)) = "" Then
                        .SalesID = .CurrentSalesID
                        .StockID = Me.gvSalesDescription.GetRowCellDisplayText(i, colStockID)
                        .UnitPrice = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colUnitPrice))
                        .PurchasingPrice = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colPurchasePrice))
                        .Quantity = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colQuantity))
                        .Discount = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colDiscount))
                        .Value = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colValue))
                        .InsertSalesDescription(_DB, _Transaction)

                        'Update Main Stock
                        .StockID = Me.gvSalesDescription.GetRowCellDisplayText(i, colStockID)
                        .StockBalance = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colQuantity))
                        .UpdateStock(_DB, _Transaction)


                    End If

                Next



                With DACollections
                    For i As Integer = 0 To Me.gvCollections.RowCount
                        If Not gvCollections.GetRowCellDisplayText(i, gvCollections.Columns(0)) = "" Then
                            .SystemID = DASales.CurrentSalesID
                            .TransactionTypeID = DAEnums.EnumTransactionTypes.SALES

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

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        If f.DialogResult = Windows.Forms.DialogResult.Yes Then
            Try


                Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
                _Connection = _DB.CreateConnection
                _Connection.Open()
                _Transaction = _Connection.BeginTransaction()


                gvSalesDescription.PostEditor()
                gvCollections.PostEditor()

                With DASales
                    .SalesID = Convert.ToInt64(IIf(lblSalesID.Text = String.Empty, 0, lblSalesID.Text))
                    .CustomerID = lupCustomer.EditValue
                    .SalesDate = deSalesDate.Text
                    .ReferenceNo = teReferenceNo.Text.Trim

                    colValue.SummaryItem.DisplayFormat = ""
                    .Total = gvSalesDescription.Columns("Value").SummaryText
                    .TaxPercent = seTaxPercent.Text
                    .TaxAmount = seTaxAmount.Text
                    .Discount = seDiscount.Text
                    .Note = meNote.Text
                    .Paid = 0
                    .InsertSales(_DB, _Transaction)

                    .AddToStock(_DB, _Transaction)
                    .SalesDescriptionDelete(_DB, _Transaction)


                    For i As Integer = 0 To Me.gvSalesDescription.RowCount
                        If Not gvSalesDescription.GetRowCellDisplayText(i, gvSalesDescription.Columns(0)) = "" Then

                            .StockID = Me.gvSalesDescription.GetRowCellDisplayText(i, colStockID)
                            .UnitPrice = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colUnitPrice))
                            .PurchasingPrice = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colPurchasePrice))
                            .Quantity = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colQuantity))
                            .Discount = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colDiscount))
                            .Value = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colValue))
                            .InsertSalesDescription(_DB, _Transaction)

                            'Update Main Stock
                            .StockID = Me.gvSalesDescription.GetRowCellDisplayText(i, colStockID)
                            .StockBalance = Val(Me.gvSalesDescription.GetRowCellDisplayText(i, colQuantity))
                            .UpdateStock(_DB, _Transaction)


                        End If

                    Next



                    With DACollections
                        .SystemID = Convert.ToInt64(IIf(lblSalesID.Text = String.Empty, 0, lblSalesID.Text))
                        .TransactionTypeID = DAEnums.EnumTransactionTypes.SALES
                        .CollectionDelete(_DB, _Transaction)


                        'Add new Records to Collection Table

                        For i As Integer = 0 To Me.gvCollections.RowCount
                            If Not gvCollections.GetRowCellDisplayText(i, gvCollections.Columns(0)) = "" Then
                                .SystemID = Convert.ToInt64(IIf(lblSalesID.Text = String.Empty, 0, lblSalesID.Text))
                                .TransactionTypeID = DAEnums.EnumTransactionTypes.SALES

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
            Dim _xrSales As New xrSales
            _frmPrintPreview.PrintControl1.PrintingSystem = _xrSales.PrintingSystem
            _xrSales.CreateDocument()
            _frmPrintPreview.MdiParent = frmMain
            _frmPrintPreview.Show()
            _frmPrintPreview.BringToFront()

        Catch ex As Exception

        End Try
    End Sub
#End Region


End Class