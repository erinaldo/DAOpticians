Imports DA.Stock.DAPurchasing
Imports DA.Collections
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common
Imports DA.Common.DAConstant

Public Class frmPayBills

#Region "Variables"
    Dim _DAPurchasing As DA.Stock.DAPurchasing
    Dim _DACollections As DA.Collections.DACollections
    Dim _DAEnums As DA.Common.DAEnums
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
        Me.PopulateUnsettleGrid()
        Me.PopulateCollectionsGrid()
    End Sub

    Private Sub frmPayBills_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetDAPayBillsBarButton(bbSave, bbPrint, bbShowBy, bbRefresh, bbClose)

    End Sub

    Private Sub frmPayBills_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Bar Button Events"
    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
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
                gvCollections.PostEditor()

                With DACollections
                    .SystemID = Convert.ToInt64(IIf(txtPurchaseID.Text = String.Empty, 0, txtPurchaseID.Text))
                    .TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE
                    .CollectionDelete(_DB, _Transaction)


                    'Add new Records to Collection Table
                    For i As Integer = 0 To Me.gvCollections.RowCount
                        If Not gvCollections.GetRowCellDisplayText(i, gvCollections.Columns(0)) = "" Then
                            .SystemID = Convert.ToInt64(IIf(txtPurchaseID.Text = String.Empty, 0, txtPurchaseID.Text))
                            .TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE

                            Select Case Me.gvCollections.GetRowCellDisplayText(i, GridColumn8)

                                Case "CASH"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                                Case "CHECK"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                                Case "CR CARD"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD

                            End Select

                            .Date = Date.Parse(Me.gvCollections.GetRowCellDisplayText(i, colDate))
                            .Reference = Me.gvCollections.GetRowCellDisplayText(i, GridColumn10)

                            If (Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate) = String.Empty) Then
                                .ReferenceDate = DateTime.MinValue
                            Else
                                .ReferenceDate = Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate)

                            End If

                            .Bank = Me.gvCollections.GetRowCellDisplayText(i, colBank)

                            .Amount = Val(Me.gvCollections.GetRowCellDisplayText(i, GridColumn12))
                            .InsertCollection(_DB, _Transaction)
                        End If

                    Next

                End With

                _Transaction.Commit()
                Me.PopulateUnsettleGrid()


            Catch ex As Exception
                _Transaction.Rollback()
            Finally
                If _Connection.State = ConnectionState.Open Then
                    _Connection.Close()
                End If
            End Try


        End If

    End Sub

    Private Sub bbShowBy_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbShowBy.ItemClick
        Select Case xTab1.SelectedTabPageIndex
            Case 0
                gvUnsettledBills.Columns("Supplier").Group()
            Case 1
                gvSettledBills.Columns("Supplier").Group()

        End Select

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
                With gvSettledBills
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
            gcUnsettledBills.DataSource = DAPurchasing.GetAllPurchaseUnsettledBills().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Settled Purchase Bills"
    Private Sub PopulateSettleGrid()
        Try
            gcSettledBills.DataSource = DAPurchasing.GetAllPurchaseSettledBills().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Collections Grid"
    Private Sub PopulateCollectionsGrid()
        Try
            DAPurchasing.PurchaseID = Me.txtPurchaseID.Text
            DACollections.SystemID = DAPurchasing.PurchaseID
            DACollections.TransactionTypeID = DAEnums.EnumTransactionTypes.PURCHASE
            gcCollections.DataSource = DACollections.CollectionGetByID().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Tab Control Events"
    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
        Select Case e.Page.TabControl.SelectedTabPageIndex
            Case 0
                Me.PopulateUnsettleGrid()
                Me.txtPurchaseID.Text = String.Empty
                Me.txtSupplier.Text = String.Empty
            Case 1
                Me.PopulateSettleGrid()
                Me.txtPurchaseID.Text = String.Empty
                Me.txtSupplier.Text = String.Empty
               
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


    Private Sub gvSettledBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSettledBills.Click
        Me.DisplayRecord()
    End Sub

    Private Sub gvSettledBills_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvSettledBills.FocusedRowChanged
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

#Region "Display Record"
    Private Sub DisplayRecord()

        Select Case xTab1.SelectedTabPageIndex
            Case 0
                Me.txtPurchaseID.Text = gvUnsettledBills.GetFocusedRowCellValue(GridColumn1)
                Me.txtSupplier.Text = gvUnsettledBills.GetFocusedRowCellValue(GridColumn2)
                Me.PopulateCollectionsGrid()
            Case 1
                Me.txtPurchaseID.Text = gvSettledBills.GetFocusedRowCellValue(GridColumn13)
                Me.txtSupplier.Text = gvSettledBills.GetFocusedRowCellValue(GridColumn14)
                Me.PopulateCollectionsGrid()

        End Select

        

    End Sub
#End Region


    

End Class