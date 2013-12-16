Imports DA.Stock.DAPurchasing
Imports DA.StartUp.DASuppliers
Imports DA.StartUp.DAStock
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant

Imports DA.Common
Public Class frmPurchaseOrder

#Region "Variables"
    Dim _DASuppliers As DA.StartUp.DASuppliers
    Dim _DAStockItems As DA.StartUp.DAStock
    Dim _DAPurchaseOrder As DA.Stock.DAPurchaseOrder

#End Region

#Region "Constructors"
    Public ReadOnly Property DAStockItems() As DA.StartUp.DAStock
        Get

            If _DAStockItems Is Nothing Then
                _DAStockItems = New DA.StartUp.DAStock()
            End If

            Return _DAStockItems
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
    
    
    Public ReadOnly Property DAPurchaseOrder() As DA.Stock.DAPurchaseOrder
        Get

            If _DAPurchaseOrder Is Nothing Then
                _DAPurchaseOrder = New DA.Stock.DAPurchaseOrder
            End If

            Return _DAPurchaseOrder
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frmPurchaseOrder_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPurchaseOrder_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.PopulateSupplierLookup()
        Me.PopulateStockItemsGridLookup()
        Me.PopulateDescriptionGrid()

    End Sub

    Private Sub frmPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
        Me.dePurchaseOrderDate.DateTime = Date.Today
    End Sub

#End Region

#Region "Bar Button Events"

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        If dxvpSupplier.Validate Then

            If lblPurchaseOrderID.Text = String.Empty Then
                Me.SaveRecords()
                Me.PopulateStockItemsGridLookup()

            Else
                Me.UpdateRecords()
                Me.PopulateStockItemsGridLookup()
            End If

        End If

    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Me.ClearFormData()
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvPurchaseOrderHistory
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With
    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Me.DisplayRecord()
    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Select Case xTab1.SelectedTabPageIndex
            Case 0
                If Me.lblPurchaseOrderID.Text = String.Empty Then
                    'MessageOK("Can not print", "Emptry Record", "Select a record and try again...")
                    'Exit Sub
                    'Else
                    Me.ShowPrintPreview()
                End If
            Case 1
                If gvPurchaseOrderHistory.RowCount > 0 Then
                    PrintPreview(gcPurchaseOrderHistory, "Pruchase Order Report")
               
                End If

        End Select

    End Sub
#End Region

#Region "Hide Tool Buttons On Load"
    Public Sub HideToolButtonsOnLoad()
        Try
            Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
      


    End Sub
#End Region

#Region "Show Tool Buttons On History Tab change"
    Public Sub ShowToolButtonsOnHistoryTabChange()
        Try

            Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    
    End Sub
#End Region

#Region "Show Tool Buttons On New Record Tab change"
    Public Sub ShowToolButtonsOnNewRecordTabChange()

        Try

            Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
      
    End Sub
#End Region

#Region "Tab Control Events"
    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
        Select Case e.Page.TabControl.SelectedTabPageIndex
            Case 0
                Me.ShowToolButtonsOnNewRecordTabChange()
            Case 1
                Me.ShowToolButtonsOnHistoryTabChange()
                Me.PopulatePurchaseOrderHistory()

        End Select
    End Sub
#End Region

#Region "Populate Purchase History"
    Private Sub PopulatePurchaseOrderHistory()

        Try
            gcPurchaseOrderHistory.DataSource = DAPurchaseOrder.GetAllPurchasesOrders().Tables(0)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Clear Form Data"
    Public Sub ClearFormData()

        lblPurchaseOrderID.Text = String.Empty
        teReferenceNo.Text = String.Empty
        meNote.Text = String.Empty
        lupSupplier.EditValue = DBNull.Value
        Me.PopulateDescriptionGrid()

        lupSupplier.Focus()

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
            With gcPurchaseOrderDescription
                DAPurchaseOrder.PurchaseOrderID = Convert.ToInt64(IIf(lblPurchaseOrderID.Text = String.Empty, 0, lblPurchaseOrderID.Text))
                .DataSource = DAPurchaseOrder.GetPurchaseOrderDescriptionByID.Tables(0)

            End With


        Catch ex As Exception

        End Try
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


            gvPurchaseOrderDescription.PostEditor()




            With DAPurchaseOrder
                .PurchaseOrderID = Convert.ToInt64(IIf(lblPurchaseOrderID.Text = String.Empty, 0, lblPurchaseOrderID.Text))
                .SupplierID = lupSupplier.EditValue
                .PurchaseOrderDate = dePurchaseOrderDate.Text
                .ReferenceNo = teReferenceNo.Text.Trim
                .Note = meNote.Text
                .InsertPurchaseOrder(_DB, _Transaction)



                For i As Integer = 0 To Me.gvPurchaseOrderDescription.RowCount
                    If Not gvPurchaseOrderDescription.GetRowCellDisplayText(i, gvPurchaseOrderDescription.Columns(0)) = "" Then
                        .PurchaseOrderID = .CurrentPurchaseOrderID
                        .StockID = Me.gvPurchaseOrderDescription.GetRowCellDisplayText(i, GridColumn11)
                        .RequiredQuantity = Val(Me.gvPurchaseOrderDescription.GetRowCellDisplayText(i, GridColumn3))
                        .InsertPurchaseOrderDescription(_DB, _Transaction)

                    End If

                Next


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


                gvPurchaseOrderDescription.PostEditor()

                With DAPurchaseOrder
                    .PurchaseOrderID = Convert.ToInt64(IIf(lblPurchaseOrderID.Text = String.Empty, 0, lblPurchaseOrderID.Text))
                    .SupplierID = lupSupplier.EditValue
                    .PurchaseOrderDate = dePurchaseOrderDate.Text
                    .ReferenceNo = teReferenceNo.Text.Trim
                    .Note = meNote.Text
                    .InsertPurchaseOrder(_DB, _Transaction)

                    .PurchasesOrderDescriptionDelete(_DB, _Transaction)


                    For i As Integer = 0 To Me.gvPurchaseOrderDescription.RowCount
                        If Not gvPurchaseOrderDescription.GetRowCellDisplayText(i, gvPurchaseOrderDescription.Columns(0)) = "" Then

                            .StockID = Me.gvPurchaseOrderDescription.GetRowCellDisplayText(i, GridColumn11)
                            .RequiredQuantity = Val(Me.gvPurchaseOrderDescription.GetRowCellDisplayText(i, GridColumn3))
                            .InsertPurchaseOrderDescription(_DB, _Transaction)

                        End If

                    Next


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

#Region "Dispay Record"
    Public Sub DisplayRecord()
        If gvPurchaseOrderHistory.RowCount > 0 Then
            xTab1.SelectedTabPageIndex = 0
            With DAPurchaseOrder
                .PurchaseOrderID = Me.gvPurchaseOrderHistory.GetFocusedRowCellValue(GridColumn4)
                .GetPurchasesOrderByID()
                lblPurchaseOrderID.Text = .PurchaseOrderID
                lupSupplier.EditValue = .SupplierID
                dePurchaseOrderDate.EditValue = .PurchaseOrderDate
                teReferenceNo.Text = .ReferenceNo
                meNote.Text = .Note
                Me.PopulateDescriptionGrid()

            End With


        End If
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvPurchaseOrderHistory_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPurchaseOrderHistory.DoubleClick
        Me.DisplayRecord()
    End Sub

    Private Sub gcPurchaseOrderDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcPurchaseOrderDescription.KeyDown
        If e.KeyCode = Keys.Delete Then
            gvPurchaseOrderDescription.DeleteRow(gvPurchaseOrderDescription.FocusedRowHandle)
        End If
    End Sub

    
#End Region

#Region "Repository Events"
    Private Sub glupStockItems_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles glupStockItems.EditValueChanged

        Try
            gvPurchaseOrderDescription.SetFocusedRowCellValue(GridColumn2, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvPurchaseOrderDescription.EditingValue))), "Description"))
            gvPurchaseOrderDescription.SetFocusedRowCellValue(GridColumn3, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvPurchaseOrderDescription.EditingValue))), "RequiredQuantity"))
            gvPurchaseOrderDescription.SetFocusedRowCellValue(GridColumn11, glupStockItems.View.GetRowCellValue(glupStockItems.View.GetRowHandle(glupStockItems.View.GetDataSourceRowIndex(glupStockItems.GetIndexByKeyValue(gvPurchaseOrderDescription.EditingValue))), "StockID"))

        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Show Print Preview"
    Private Sub ShowPrintPreview()
        Try
            Dim _frmPrintPreview As New frmPrintPreview
            Dim _xrPurchasOrder As New xrPurchaseOrder
            _xrPurchasOrder.PurchaseOrder_GetByIDTableAdapter.GetData(Me.gvPurchaseOrderHistory.GetFocusedRowCellValue(GridColumn4))
            _xrPurchasOrder.PurchaseOrderDescription_GetByIDTableAdapter.GetData(Me.gvPurchaseOrderHistory.GetFocusedRowCellValue(GridColumn4))
            _frmPrintPreview.PrintControl1.PrintingSystem = _xrPurchasOrder.PrintingSystem

            _xrPurchasOrder.CreateDocument()

            _frmPrintPreview.MdiParent = frmMain
            _frmPrintPreview.Show()
            _frmPrintPreview.BringToFront()
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class