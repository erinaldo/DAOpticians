Imports DA.StartUp.DADoctors
Imports DA.Common.DAConstant

Public Class frmDoctors

#Region "Variables"

    Private _DaDoctors As DA.StartUp.DADoctors

#End Region

#Region "Constructor"
    Public ReadOnly Property DaDoctors() As DA.StartUp.DADoctors
        Get

            If _DaDoctors Is Nothing Then
                _DaDoctors = New DA.StartUp.DADoctors()
            End If

            Return _DaDoctors
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

        Try
            SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)

            Me.HideToolButtonsOnLoad()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try


    End Sub
#End Region

#Region "Bar Button Events"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        Try
            If dxvpDoctors.Validate Then
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
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick

        Try
            Me.ClearFormData()
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

            teDoctorName.Focus()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
       
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick

        Try
            With gvDoctors
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

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            PrintPreview(gcDoctors, "Doctors Report")
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Save Doctor Data"
    Private Sub SaveRecords()

     

        With DaDoctors
            .DoctorID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            .DoctorName = teDoctorName.Text.Trim
            .Address1 = teAddress1.Text.Trim
            .Address2 = teAddress2.Text.Trim
            .City = teCity.Text.Trim
            .Telephone = teTelephone.Text.Trim
            .Email = teEmail.Text.Trim
            .InsertDoctors()
            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            Me.ClearFormData()

        End With

    End Sub
#End Region

#Region "Delete Doctor"

    Private Sub DeleteSupplier(ByVal DoctorID As Int64)
        Try
            With DaDoctors
                .DoctorID = DoctorID
                .DeleteDoctor()
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

        If gvDoctors.RowCount > 0 Then
            xTab1.SelectedTabPageIndex = 0

            With DaDoctors
                .DoctorID = Me.gvDoctors.GetFocusedRowCellValue(GridColumn1)
                .GetDoctorByID()
                lblID.Text = .DoctorID
                teDoctorName.EditValue = .DoctorName
                teAddress1.EditValue = .Address1
                teAddress2.EditValue = .Address2
                teCity.EditValue = .City
                teTelephone.EditValue = .Telephone
                teEmail.EditValue = .Email

            End With


        End If
    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcDoctors.DataSource = DaDoctors.GetAllDoctors().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFormData()
        lblID.Text = String.Empty
        teDoctorName.EditValue = Nothing
        teDoctorName.EditValue = Nothing
        teAddress1.EditValue = Nothing
        teAddress2.EditValue = Nothing
        teCity.EditValue = Nothing
        teTelephone.EditValue = Nothing
        teEmail.EditValue = Nothing
        seCurrentBalance.EditValue = Nothing
        teDoctorName.Focus()

        dxvpDoctors.RemoveControlError(teDoctorName)


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
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub
#End Region

#Region "Show Tool Buttons On New Record Tab change"
    Public Sub ShowToolButtonsOnNewRecordTabChange()

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
    Private Sub gvSuppliers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvDoctors.DoubleClick
        Try
            Me.DisplayRecord()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try


    End Sub
#End Region


End Class