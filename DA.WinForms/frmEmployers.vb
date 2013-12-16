Imports DA.StartUp.DAEmployers
Imports DA.Common.DAConstant


Public Class frmEmployers


#Region "Variables"
    Private _DaEmployers As DA.StartUp.DAEmployers

#End Region

#Region "Constructor"


    Public ReadOnly Property DaEmployers() As DA.StartUp.DAEmployers
        Get

            If _DaEmployers Is Nothing Then
                _DaEmployers = New DA.StartUp.DAEmployers()
            End If

            Return _DaEmployers
        End Get
    End Property
#End Region

#Region "Form Event"

    Private Sub frmEmployers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEmployers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
        Me.PopulateDesignation()
    End Sub
#End Region

#Region "Bar Button Event"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        Try
            If dxvpEmployers.Validate Then
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
        Me.ClearFromData()
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            PrintPreview(gcEmployers, "Employers Report")
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
                    Me.DeleteEmployer(lblID.Text)
                    Me.ClearFromData()
                End If
            End If

            teEmployerName.Focus()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try


    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Try
            Me.DisplayEmployer()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        Try

            With gvEmployers
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

#Region "Save Employer Data"
    Private Sub SaveRecords()
        With DaEmployers
            .Employer_ID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            .Employer_Name = teEmployerName.Text.Trim
            .Address1 = teAddress1.Text.Trim
            .Address2 = teAddress2.Text.Trim
            .City = teCity.Text.Trim
            .Designation = lupDesignation.EditValue
            .NIC = teNICNo.Text.Trim
            .Telephone = teTelephone.Text.Trim
            .InsertEmployer()

            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            Me.ClearFromData()

        End With

    End Sub
#End Region

#Region "Save Designation"
    Private Sub SaveDesignation()
        Try
            With DaEmployers
                .DesignationName = Me.lupDesignation.Text
                .InsertDesignation()

            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Delete Designation"
    Private Sub DeleteDesignation()
        Try
            With DaEmployers
                .DesignationName = Me.lupDesignation.Text
                .DeleteDesignation()
            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFromData()
        lblID.Text = String.Empty
        teEmployerName.Text = String.Empty
        teAddress1.Text = String.Empty
        teAddress2.Text = String.Empty
        teCity.Text = String.Empty
        lupDesignation.EditValue = DBNull.Value
        teNicNo.Text = String.Empty
        teTelephone.Text = String.Empty
        teEmployerName.Focus()

    End Sub

#End Region

#Region "Display Employer"
    Public Sub DisplayEmployer()

        If gvEmployers.RowCount > 0 Then


            xTab1.SelectedTabPageIndex = 0
            With DaEmployers
                .Employer_ID = gvEmployers.GetFocusedRowCellValue(GridColumn1)
                .FindEmployerByID()
                lblID.Text = .Employer_ID
                teEmployerName.EditValue = .Employer_Name
                teAddress1.EditValue = .Address1
                teAddress2.EditValue = .Address2
                teCity.EditValue = .City
                lupDesignation.EditValue = .DesignationID
                teNICNo.EditValue = .NIC
                teTelephone.EditValue = .Telephone

            End With
        End If

    End Sub
#End Region

#Region "Delete Employer"
    Private Sub DeleteEmployer(ByVal EmployerID As Int64)
        With DaEmployers
            .Employer_ID = EmployerID
            .DeleteEmployer()
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

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcEmployers.DataSource = DaEmployers.GetAllEmployers().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Designation Lookup"
    Public Sub PopulateDesignation()

        Try
            With lupDesignation
                .Properties.DataSource = DaEmployers.GetAllDesigation.Tables(0)
                .Properties.DisplayMember = "Name"
                .Properties.ValueMember = "DesignationID"

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvEmployers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvEmployers.DoubleClick
        Try
            Me.DisplayEmployer()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try



    End Sub
#End Region

#Region "Lookup Events"
    Private Sub lupDesignation_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lupDesignation.ButtonClick
        Select Case e.Button.Index
            Case 1
                If Not Me.lupDesignation.Text = String.Empty Then
                    Me.SaveDesignation()
                    Me.PopulateDesignation()
                End If

            Case 2
                If Not Me.lupDesignation.Text = String.Empty Then
                    Dim f As New frmYesNo
                    f.LabelControl1.Text = "It is not recormended to delete the selected record?"
                    f.LabelControl2.ForeColor = Color.Red
                    f.LabelControl2.Text = "Click Yes to Delete..."
                    f.Text = "Delete The Current Record ?"

                    If f.ShowDialog = Windows.Forms.DialogResult.Yes Then
                        Me.DeleteDesignation()
                        Me.PopulateDesignation()
                    End If
                End If



        End Select
    End Sub
#End Region


  
End Class