Imports DA.StartUp.DAEmployers
Imports DA.Common.DAConstant
Public Class frmUserLogins

#Region "Variables"
    Private _DAEmployers As DA.StartUp.DAEmployers
    Private _DAUserLogins As DA.Common.DAUserLogins

#End Region

#Region "Constructor"
    Public ReadOnly Property DAEmployers() As DA.StartUp.DAEmployers
        Get

            If _DAEmployers Is Nothing Then
                _DAEmployers = New DA.StartUp.DAEmployers
            End If

            Return _DAEmployers
        End Get
    End Property


    Public ReadOnly Property DAUserLogins() As DA.Common.DAUserLogins
        Get

            If _DAUserLogins Is Nothing Then
                _DAUserLogins = New DA.Common.DAUserLogins
            End If

            Return _DAUserLogins
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frmSuppliers_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)

        Me.HideToolButtonsOnLoad()
        Me.PopulateGrid()

    End Sub

    Private Sub frmSuppliers_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.PopulateEmployers()
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
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Show Tool Buttons On New Record Tab change"
    Public Sub ShowToolButtonsOnNewRecordTabChange()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    End Sub
#End Region

#Region "Bar Button Events"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        If dxvpUsers.Validate Then
            If lblID.Text = String.Empty Then

                DAUserLogins.UserName = Me.teUserName.Text.Trim
                If DAUserLogins.IsUserNameExits() = True Then
                    Dim frm As New frmAlreadyExists

                    frm.Text = DA_USERLOGIN_CONFIRMATION_TITLE
                    frm.lblTitle.Text = DA_USERLOGIN_CONFIRMATION_TITLELABEL
                    frm.lblDescription.Text = DA_USERLOGIN_CONFIRMATION_DESCRIPTIONLABEL
                    frm.ShowDialog()
                    Me.leEmployer.Focus()
                Else

                    Me.SaveRecords()
                    Me.PopulateGrid()
                End If


            Else
                Dim frm As New frmUpdateYesNo
                '  frm.peImage.Image = CWB.My.Resources.Resources.ImgUpdate
                frm.Text = DA_UPDATE_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_UPDATE_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_UPDATE_CONFIRMATION_DESCRIPTIONLABEL

                If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    Me.SaveRecords()
                    Me.PopulateGrid()
                End If
            End If

        End If
    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Me.ClearFormData()
    End Sub

    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick
        If Not lblID.Text = String.Empty Then
            Dim frm As New frmDeleteYesNo
            frm.lblTitle.Text = DA_DELETE_CONFIRMATION_TITLELABEL
            frm.lblDescription.ForeColor = Color.Red
            'frm.peImage.Image = DA.Resources.Resources.ImgDelete
            frm.lblDescription.Text = DA_DELETE_CONFIRMATION_DESCRIPTIONLABEL
            frm.Text = DA_DELETE_CONFIRMATION_TITLE

            If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                Me.Delete(lblID.Text)
                Me.PopulateGrid()

            End If
        End If

    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvEmployers
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With

    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Me.DisplayRecord(gvEmployers, GridColumn2)
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        ' PrintPreview(gcSuppliers)
    End Sub
#End Region

#Region "Look up Edit Events"
    Private Sub leEmployer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leEmployer.EditValueChanged
        Try
            If Not IsDBNull(leEmployer.EditValue) Then
                With DAEmployers

                    .Employer_ID = Convert.ToInt64(Me.leEmployer.EditValue)
                    '.SelectRow()
                    ' peEmployer.EditValue = .EmployerImage
                End With

            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Populate Employers"
    Private Sub PopulateEmployers()
        Try
            leEmployer.Properties.DataSource = DAEmployers.GetAllEmployers.Tables(0)
            leEmployer.Properties.DisplayMember = "EmployerName"
            leEmployer.Properties.ValueMember = "EmployerID"

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Save Records"
    Private Sub SaveRecords()





        Try
            With DAUserLogins
                .UserLoginID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .EmployerID = leEmployer.EditValue
                .UserType = ceUserType.Text
                .UserName = teUserName.Text.Trim
                .Password = tePassword.Text.Trim
                .CreatedBy = UserID
                .UpdatedBy = UserID
                .Insert()
                Dim frm As New frmSavedOk
                frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                frm.ShowDialog()
            End With
            Me.ClearFormData()
        Catch ex As Exception
            MessageError(ex.ToString)

        End Try

    End Sub
#End Region

#Region "Delete Data"
    Private Sub Delete(ByVal UserLoginID As Int64)

        Try
            With DAUserLogins
                .EmployerID = UserLoginID
                .Delete()
            End With
            Me.ClearFormData()

        Catch ex As SqlClient.SqlException
            Dim frm As New frmOk
            frm.Text = DA_DELETE_ERROR_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_DELETE_ERROR_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_DELETE_ERROR_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()
        End Try

    End Sub
#End Region

#Region "Dispay Record"
    Public Sub DisplayRecord(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col As DevExpress.XtraGrid.Columns.GridColumn)

        Try
            If gvEmployers.RowCount > 0 And Not gvEmployers.IsFilterRow(gvEmployers.FocusedRowHandle) Then

                With DAUserLogins

                    .UserLoginID = Me.gvEmployers.GetFocusedRowCellValue(GridColumn1)
                    .SelectRow()

                    lblID.Text = .UserLoginID
                    leEmployer.EditValue = .EmployerID
                    ceUserType.Text = .UserType
                    teUserName.Text = .UserName
                    tePassword.Text = .Password
                    teRetypePassword.Text = .Password



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
            gcEmployers.DataSource = DAUserLogins.SelectAll.Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFormData()
        Try
            lblID.Text = String.Empty
            leEmployer.EditValue = DBNull.Value
            ceUserType.SelectedIndex = -1
            teUserName.Text = String.Empty
            tePassword.Text = String.Empty
            teRetypePassword.Text = String.Empty
            peEmployer.EditValue = DBNull.Value
            dxvpUsers.RemoveControlError(leEmployer)
            dxvpUsers.RemoveControlError(teUserName)
            dxvpUsers.RemoveControlError(tePassword)
            dxvpUsers.RemoveControlError(teRetypePassword)

            leEmployer.Focus()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Grid Events"
    Private Sub gvEmployers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvEmployers.Click
        Me.DisplayRecord(gvEmployers, GridColumn2)
    End Sub
#End Region


End Class