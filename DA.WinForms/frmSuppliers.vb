Imports DA.StartUp.DASuppliers
Imports DA.Collections.DACollections
Imports DA.Common.DAEnums
Imports DA.Common.DAConstant

Public Class frmSuppliers

#Region "Variables"
    Private _DaSuppliers As DA.StartUp.DASuppliers
    Private _DaCollections As DA.Collections.DACollections
    Private _DAEnums As DA.Common.DAEnums

#End Region

#Region "Constructor"

    Public ReadOnly Property DaSuppliers() As DA.StartUp.DASuppliers
        Get

            If _DaSuppliers Is Nothing Then
                _DaSuppliers = New DA.StartUp.DASuppliers()
            End If

            Return _DaSuppliers
        End Get
    End Property

    Public ReadOnly Property DaCollections() As DA.Collections.DACollections
        Get

            If _DaCollections Is Nothing Then
                _DaCollections = New DA.Collections.DACollections
            End If

            Return _DaCollections
        End Get
    End Property

    Public ReadOnly Property DAEnums() As DA.Common.DAEnums
        Get
            ' Create on demand...
            If _DAEnums Is Nothing Then
                _DAEnums = New DA.Common.DAEnums()
            End If

            Return _DAEnums
        End Get
    End Property

#End Region

#Region "Form Event"

    Private Sub frmSuppliers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)

        Me.HideToolButtonsOnLoad()

    End Sub
#End Region

#Region "Bar Button Event"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        Try
            If dxvpSuppliers.Validate Then
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

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick

        Try
            Me.Close()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Try
            Me.ClearFormData()
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            PrintPreview(gcSuppliers, "Supplier Report")
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub


    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick

        Try
            If Not lblID.Text = String.Empty Then
                Dim frm As New frmYesNo
                frm.LabelControl1.Text = DA_DELETE_CONFIRMATION_TITLELABEL
                frm.LabelControl2.ForeColor = Color.Red
                frm.LabelControl2.Text = DA_DELETE_CONFIRMATION_DESCRIPTIONLABEL
                frm.Text = DA_DELETE_CONFIRMATION_TITLE

                If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    Me.DeleteSupplier(lblID.Text)
                    Me.ClearFormData()
                End If
            End If

            teSupplierName.Focus()
        Catch ex As Exception
            Me.ClearFormData()
        End Try

    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick

        Try
            With gvSuppliers
                .ClearColumnsFilter()
                .ClearGrouping()
                .ClearSelection()
                .ClearSorting()
            End With

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

#Region "Save Supplier Data"
    Private Sub SaveRecords()
        Try
            With DaSuppliers
                .Supplier_ID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .Name = teSupplierName.EditValue
                .Contact_Person = teContactPerson.EditValue
                .Address1 = teAddress1.EditValue
                .Address2 = teAddress2.EditValue
                .Address3 = teAddress3.EditValue
                .Telephone = teTelephone.EditValue
                .Fax = teFax.EditValue
                .Email = teEmail.EditValue
                .Web_URL = teWebURL.EditValue
                .Note = meNote.EditValue
                .OpeningBalance = seOpeningBalance.EditValue
                .InsertSupplier()

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

#Region "Delete Supplier"
    Private Sub DeleteSupplier(ByVal SupplierID As Int64)

        Try
            With DaSuppliers
                .Supplier_ID = SupplierID
                .DeleteSupplier()
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

#Region "Dispay Record"
    Public Sub DisplayRecord()

        Try
            If gvSuppliers.RowCount > 0 And Not gvSuppliers.IsFilterRow(gvSuppliers.FocusedRowHandle) Then
                xTab1.SelectedTabPageIndex = 0
                With DaSuppliers
                    .Supplier_ID = Me.gvSuppliers.GetFocusedRowCellValue(GridColumn1)
                    .GetSupplierByID()
                    lblID.Text = .Supplier_ID
                    teSupplierName.EditValue = .Name
                    teContactPerson.EditValue = .Contact_Person
                    teAddress1.EditValue = .Address1
                    teAddress2.EditValue = .Address2
                    teAddress3.EditValue = .Address3
                    teTelephone.EditValue = .Telephone
                    teFax.EditValue = .Fax
                    teEmail.EditValue = .Email
                    teWebURL.EditValue = .Web_URL
                    meNote.EditValue = .Note
                    seOpeningBalance.EditValue = .OpeningBalance
                End With
            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try



    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcSuppliers.DataSource = DaSuppliers.GetAllSuppliers().Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFormData()

        Try
            teSupplierName.Focus()
            lblID.Text = String.Empty
            teSupplierName.EditValue = Nothing
            teContactPerson.EditValue = Nothing
            teAddress1.EditValue = Nothing
            teAddress2.EditValue = Nothing
            teAddress3.EditValue = Nothing
            teTelephone.EditValue = Nothing
            teFax.EditValue = Nothing
            teEmail.EditValue = Nothing
            teWebURL.EditValue = Nothing
            meNote.EditValue = Nothing
            seOpeningBalance.EditValue = Nothing
            dxvpSuppliers.RemoveControlError(teSupplierName)

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
            Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

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
            Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

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

#Region "Grid Events"
    Private Sub gvSuppliers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSuppliers.DoubleClick
        Try
            Me.DisplayRecord()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub
#End Region

  
End Class