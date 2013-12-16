Imports DA.StartUp.DACustomers
Imports DA.Common.DAConstant


Public Class frmCustomers

#Region "Variables"
    Private _DaCustomer As DA.StartUp.DACustomers

#End Region

#Region "Constructor"
    Public ReadOnly Property DaCustomer() As DA.StartUp.DACustomers
        Get

            If _DaCustomer Is Nothing Then
                _DaCustomer = New DA.StartUp.DACustomers()
            End If

            Return _DaCustomer
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frmCustomers_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub
    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)

        Me.HideToolButtonsOnLoad()
    End Sub
#End Region

#Region "Bar Button Events"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        If dxvpCutomer.Validate Then
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
    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Me.ClearFromData()
    End Sub

    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick
        If Not lblID.Text = String.Empty Then
            Dim frm As New frmYesNo
            frm.LabelControl1.Text = "It is not recormended to delete the selected record?"
            frm.LabelControl2.ForeColor = Color.Red
            frm.LabelControl2.Text = "Click Yes to Delete..."
            frm.Text = "Delete The Current Record ?"

            If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                Me.DeleteSupplier(lblID.Text)
                Me.ClearFromData()
            End If
        End If

        teCustomerName.Focus()
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvCustomers
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With

    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Me.DisplayRecord()
    End Sub
#End Region

#Region "Save Supplier Data"
    Private Sub SaveRecords()
        With DaCustomer
            .CustomerID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            .CustomerName = teCustomerName.Text.Trim
            .Address1 = teAddress1.Text.Trim
            .Address2 = teAddress2.Text.Trim
            .City = teCity.Text.Trim
            .Telephone = teTelephone.Text.Trim
            .Email = teEmail.Text.Trim
            .CurrentBalance = Convert.ToDecimal(seCurrentBalance.Text.Trim)
            .InsertCustomers()
            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()
        End With
        Me.ClearFromData()
    End Sub
#End Region

#Region "Delete Supplier"
    Private Sub DeleteSupplier(ByVal CustomerID As Int64)
        With DaCustomer
            .CustomerID = CustomerID
            .DeleteCustomer()
        End With


    End Sub
#End Region

#Region "Dispay Record"
    Public Sub DisplayRecord()
        If gvCustomers.RowCount > 0 Then
            xTab1.SelectedTabPageIndex = 0
            With DaCustomer
                .CustomerID = Me.gvCustomers.GetFocusedRowCellValue(GridColumn1)
                .GetCustomerByID()
                lblID.Text = .CustomerID
                teCustomerName.EditValue = .CustomerName
                teAddress1.EditValue = .Address1
                teAddress2.EditValue = .Address2
                teCity.EditValue = .City
                teTelephone.EditValue = .Telephone
                teEmail.EditValue = .Email
                seCurrentBalance.EditValue = .CurrentBalance

            End With


        End If
    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcCustomers.DataSource = DaCustomer.GetAllCustomers().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFromData()
        lblID.Text = String.Empty
        teCustomerName.Text = String.Empty
        teCustomerName.Text = String.Empty
        teAddress1.Text = String.Empty
        teAddress2.Text = String.Empty
        teCity.Text = String.Empty
        teTelephone.Text = String.Empty
        teEmail.Text = String.Empty
        seCurrentBalance.EditValue = 0
        teCustomerName.Focus()

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
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Show Tool Buttons On New Record Tab change"
    Public Sub ShowToolButtonsOnNewRecordTabChange()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
                Me.PopulateGrid()

        End Select
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvSuppliers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvCustomers.DoubleClick
        Me.DisplayRecord()
    End Sub
#End Region


End Class