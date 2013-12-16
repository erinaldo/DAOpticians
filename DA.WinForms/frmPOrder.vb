Imports DA.Collections.DAExpenses
Imports DA.Collections.DACollections
Imports DA.Common.DAConstant
Imports DA.Common
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common


Public Class frmPOrder

#Region "Variables"

    Private _DAPOrder As DA.Stock.DAPOrder
    Private _DASuppliers As DA.StartUp.DASuppliers

#End Region

#Region "Constructors"

    Public ReadOnly Property DAPOrder() As DA.Stock.DAPOrder
        Get

            If _DAPOrder Is Nothing Then
                _DAPOrder = New DA.Stock.DAPOrder()
            End If

            Return _DAPOrder
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
    Private Sub frmExpenses_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
        Me.deDate.EditValue = Date.Today
    End Sub

    Private Sub frmPOrder_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.PopulateSupplierLookup()
    End Sub

#End Region

#Region "Bar Button Events"

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick

        Try
            Me.ClearFormData()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        Try
            If dxvpPOrder.Validate Then
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
                Me.ClearFormData()
            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

      
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvPOrder
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With
    End Sub

    Private Sub bPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            Select Case xTab1.SelectedTabPageIndex
                Case 0
                    If Not Me.lblID.Text = String.Empty Then

                        ' Me.ShowPrintPreview()

                    End If
                Case 1
                    If gvPOrder.RowCount > 0 Then

                        PrintPreview(gcPOrder, "Purchase Order Report")
                    Else
                        Exit Sub
                    End If

            End Select
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick

        Try
            If Not lblID.Text = String.Empty Then
                Dim f As New frmYesNo
                f.LabelControl1.Text = "It is not recormended to delete the selected record?"
                f.LabelControl2.ForeColor = Color.Red
                f.LabelControl2.Text = "Click Yes to Delete..."


                f.Text = "Delete The Current Record ?"

                If f.ShowDialog = Windows.Forms.DialogResult.Yes Then

                    Me.DeletePOrder(lblID.Text)
                    Me.ClearFormData()
                End If
            End If



        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

      
    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick

        Try
            Me.DisplayRecord()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

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
            Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
            Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
     
    End Sub
#End Region

#Region "Tab Control Events"
    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged

        Try
            Select Case e.Page.TabControl.SelectedTabPageIndex
                Case 0
                    Me.ShowToolButtonsOnNewRecordTabChange()
                Case 1
                    Me.ShowToolButtonsOnHistoryTabChange()
                    Me.PopulateGrid()


            End Select
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    

    End Sub
#End Region

#Region "Clear Form Data"
    Private Sub ClearFormData()
        Try
            lblID.Text = String.Empty
            Me.leSupplierID.Focus()
            Me.leSupplierID.EditValue = Nothing
            Me.deDate.EditValue = Nothing
            Me.seCMNO.EditValue = Nothing
            Me.seAmount.EditValue = Nothing
            Me.seVAT.EditValue = Nothing
            Me.seBTT.EditValue = Nothing
            Me.sePP.EditValue = Nothing
            Me.seOthers.EditValue = Nothing
            dxvpPOrder.RemoveControlError(leSupplierID)
            dxvpPOrder.RemoveControlError(deDate)

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

     
    End Sub
#End Region

#Region "Save Purchase order"
    Private Sub SaveRecords()


        Try


            With DAPOrder
                .POID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .SupplierID = Me.leSupplierID.EditValue
                .PODate = Me.deDate.EditValue
                .Amount = Me.seAmount.EditValue
                .CMNO = Me.seCMNO.EditValue
                .VAT = Me.seVAT.EditValue
                .BTT = Me.seBTT.EditValue
                .PP = Me.sePP.EditValue
                .Others = Me.seOthers.EditValue
                .InsertPurchaseOrder()

                Dim frm As New frmSavedOk
                frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                frm.ShowDialog()

                Me.ClearFormData()

            End With

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcPOrder.DataSource = DAPOrder.GetAllPurchasesOrders().Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Delete purchase order"
    Private Sub DeletePOrder(ByVal POID As Int64)

        Try
            With DAPOrder
                .POID = POID
                .PurchasesOrderDelete()
            End With

        Catch ex As Exception

            Dim frm As New frmOk
            frm.Text = DA_DELETE_ERROR_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_DELETE_ERROR_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_DELETE_ERROR_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

        End Try
      

    End Sub
#End Region

#Region "Display Purchase order"
    Public Sub DisplayRecord()

        Try
            If gvPOrder.RowCount > 0 Then

                xTab1.SelectedTabPageIndex = 0
                With DAPOrder
                    Me.lblID.Text = gvPOrder.GetFocusedRowCellValue(GridColumn1)
                    .POID = Me.lblID.Text
                    .GetPurchasesOrderByID()

                    Me.leSupplierID.EditValue = .SupplierID
                    Me.deDate.EditValue = .PODate
                    Me.seAmount.EditValue = .Amount
                    Me.seCMNO.EditValue = .CMNO
                    Me.seVAT.EditValue = .VAT
                    Me.seBTT.EditValue = .BTT
                    Me.sePP.EditValue = .PP
                    Me.seOthers.EditValue = .Others

                End With
            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

       

    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvExpenses_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPOrder.DoubleClick

        Try
            Me.DisplayRecord()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Populate Suppliers Lookup"
    Public Sub PopulateSupplierLookup()

        Try
            With leSupplierID
                .Properties.DataSource = DASuppliers.GetAllSuppliers.Tables(0)
                .Properties.DisplayMember = "Name"
                .Properties.ValueMember = "SupplierID"
                .Properties.PopupWidth = 350
            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region




End Class