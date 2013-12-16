Imports DA.StartUp.DAStock
Imports DA.StartUp.DASuppliers
Imports DA.Common.DAConstant


Public Class frmStockItems

#Region "Variables"
    Private _DAStock As DA.StartUp.DAStock
    Private _DASuppliers As DA.StartUp.DASuppliers
#End Region

#Region "Constructor"
   
    Public ReadOnly Property DAStock() As DA.StartUp.DAStock
        Get

            If _DAStock Is Nothing Then
                _DAStock = New DA.StartUp.DAStock()
            End If

            Return _DAStock
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
#End Region

#Region "Form Events"

    Private Sub frmStockItems_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.PopulateSupplierLookup()
        Me.PopulateCategoryLookup()
    End Sub

    Private Sub frmStockItems_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmStockItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
    End Sub

#End Region

#Region "Bar button Event"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        Try
            If dxvpStockItems.Validate Then
                If lblID.Text = String.Empty Then
                    Me.SaveRecords()
                Else
                    Dim frm As New frmYesNo
                    frm.Text = "Record Already exists"
                    frm.LabelControl1.Text = "Record Already Exists"
                    frm.LabelControl2.Text = "Do you want to replace the selected record?"

                    If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                        Me.SaveRecords()
                    End If
                End If

            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

      

    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick

        Try
            Me.ClearFormData()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick
        If Not teStockCode.EditValue = String.Empty Then
            Dim f As New frmYesNo
            f.LabelControl1.Text = "It is not recormended to delete the selected record?"
            f.LabelControl2.ForeColor = Color.Red
            f.LabelControl2.Text = "Click Yes to Delete..."


            f.Text = "Delete The Current Record ?"

            If f.ShowDialog = Windows.Forms.DialogResult.Yes Then

                Me.DeleteStock(teStockCode.EditValue)
                Me.ClearFormData()
            End If
        End If

        teStockCode.Focus()
    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            PrintPreview(gcStockItems, "Stock Report")
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick

        Try
            Me.DisplayStock()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        Try
            With gvStockItems
                .ClearColumnsFilter()
                .ClearGrouping()
                .ClearSelection()
                .ClearSorting()
            End With
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

     

    End Sub
#End Region

#Region "Save Stock Data"
    Private Sub SaveRecords()
        With DAStock
            .StockID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            .Stock_Code = teStockCode.Text.Trim
            .Description = teDescription.Text.Trim
            .Stock_Category = LupStockCategory.EditValue
            .Purchasing_Price = sePurchasePrice.EditValue
            .Sales_Price = seSalesPrice.EditValue
            .Supplier = lupSupplier.EditValue
            .Reorder_Level = seReorderLevel.EditValue
            .Stock_Balance = seStockBalance.EditValue
            .Stock_Value = seStockValue.EditValue
            .InsertStock()

            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            Me.ClearFormData()

        End With

    End Sub
#End Region

#Region "Save Stock Category"
    Private Sub SaveStockCategory()
        Try
            With DAStock
                .StockCategoryName = Me.LupStockCategory.Text
                .InsertStockCategory()

            End With
        Catch ex As Exception
            
        End Try
    End Sub
#End Region

#Region "Delete Stock Category"
    Private Sub DeleteStockCategory()
        Try
            With DAStock
                .StockCategoryName = Me.LupStockCategory.Text
                .DeleteStockCategories()
            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFormData()

        teStockCode.Focus()
        teStockCode.EditValue = Nothing
        teDescription.EditValue = Nothing
        sePurchasePrice.EditValue = Nothing
        seSalesPrice.EditValue = Nothing
        seReorderLevel.EditValue = Nothing
        seStockBalance.EditValue = Nothing
        seStockValue.EditValue = Nothing
        lblID.Text = String.Empty
        LupStockCategory.EditValue = Nothing
        lupSupplier.EditValue = Nothing

        dxvpStockItems.RemoveControlError(teStockCode)
        dxvpStockItems.RemoveControlError(teDescription)

    End Sub

#End Region

#Region "Display Stock"
    Public Sub DisplayStock()

        If gvStockItems.RowCount > 0 Then
            xTab1.SelectedTabPageIndex = 0
            With DAStock
                .StockID = gvStockItems.GetFocusedRowCellValue(GridColumn1)
                .GetByStockID()
                Me.lblID.Text = .StockID
                teStockCode.EditValue = .Stock_Code
                teDescription.EditValue = .Description
                LupStockCategory.EditValue = .Stock_Category
                sePurchasePrice.EditValue = .Purchasing_Price
                seSalesPrice.EditValue = .Sales_Price
                lupSupplier.EditValue = .Supplier
                seReorderLevel.EditValue = .Reorder_Level
                seStockBalance.EditValue = .Stock_Balance
                seStockValue.EditValue = .Stock_Value
            End With
        End If



    End Sub
#End Region

#Region "Delete Stock"
    Private Sub DeleteStock(ByVal strStockCode As String)
        With DAStock
            .Stock_Code = strStockCode
            .DeleteStock()
        End With


    End Sub
#End Region

#Region "Hide Tool Buttons On Load"
    Public Sub HideToolButtonsOnLoad()
        Me.bbShowAll.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Show Tool Buttons On History Tab change"

    Public Sub ShowToolButtonsOnHistoryTabChange()
        Me.bbShowAll.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    End Sub

#End Region

#Region "Show Tool Buttons On New Record Tab change"

    Public Sub ShowToolButtonsOnNewRecordTabChange()
        Me.bbShowAll.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
                Me.PopulateGrid()

        End Select
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvStockItems_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvStockItems.DoubleClick
        Me.DisplayStock()
    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcStockItems.DataSource = DAStock.GetAllStockItems().Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)

        End Try
    End Sub
#End Region

#Region "Populate Suppliers Lookup"
    Public Sub PopulateSupplierLookup()

        Try
            With lupSupplier
                .Properties.DataSource = DASuppliers.GetAllSuppliers.Tables(0)
                .Properties.DisplayMember = "Name"
                .Properties.ValueMember = "SupplierID"

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Stock Category Lookup"
    Public Sub PopulateCategoryLookup()

        Try
            With LupStockCategory
                .Properties.DataSource = DAStock.GetAllStockCategories.Tables(0)
                .Properties.DisplayMember = "Name"
                .Properties.ValueMember = "StockCategoryID"

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Lookup Events"
    Private Sub LupStockCategory_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles LupStockCategory.ButtonClick
        Select Case e.Button.Index
            Case 1
                If Not Me.LupStockCategory.Text = String.Empty Then
                    Me.SaveStockCategory()
                    Me.PopulateCategoryLookup()
                End If

            Case 2
                If Not Me.LupStockCategory.Text = String.Empty Then
                    Dim f As New frmYesNo
                    f.LabelControl1.Text = "It is not recormended to delete the selected record?"
                    f.LabelControl2.ForeColor = Color.Red
                    f.LabelControl2.Text = "Click Yes to Delete..."
                    f.Text = "Delete The Current Record ?"

                    If f.ShowDialog = Windows.Forms.DialogResult.Yes Then
                        Me.DeleteStockCategory()
                        Me.PopulateCategoryLookup()
                    End If
                End If



        End Select
    End Sub
#End Region

  
End Class