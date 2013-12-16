Imports DA.StartUp.DABanks
Imports DA.Common.DAConstant

Public Class frmBanks

#Region "Variables"
    Private _DaBank As DA.StartUp.DABanks

#End Region

#Region "Constructor"


    Public ReadOnly Property DaBank() As DA.StartUp.DABanks
        Get

            If _DaBank Is Nothing Then
                _DaBank = New DA.StartUp.DABanks()
            End If

            Return _DaBank
        End Get
    End Property
#End Region

#Region "Form Event"

    Private Sub frmSuppliers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmBanks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
            Me.HideToolButtonsOnLoad()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    

    End Sub
#End Region

#Region "Bar Button Event"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        Try
            If dxvpBanks.Validate = True Then

                If lblID.Text = String.Empty Then
                    DaBank.Account_No = teAccountNo.EditValue.ToString.Trim
                    If DaBank.IsAccountNoExists() = True Then
                        MessageOK("Can not save", "Account No Already Exists", "Change the Account No and Save")
                    Else
                        Me.SaveRecords()
                    End If
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

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            PrintPreview(gcBanks, "Bank Report")
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Try
            Me.ClearFromData()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick

        Try
            If Not teAccountNo.Text = String.Empty Then
                Dim frm As New frmYesNo
                frm.LabelControl1.Text = DA_DELETE_CONFIRMATION_TITLELABEL
                frm.LabelControl2.ForeColor = Color.Red
                frm.LabelControl2.Text = DA_DELETE_CONFIRMATION_DESCRIPTIONLABEL
                frm.Text = DA_DELETE_CONFIRMATION_TITLE

                If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then

                    Me.Deletebank(teAccountNo.Text)
                    Me.ClearFromData()
                End If
            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

     






    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Me.DisplayRecord()
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvBanks
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With
    End Sub
#End Region

#Region "Save Bank Data"
    Private Sub SaveRecords()
        With DaBank
            .BankID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            .Account_No = teAccountNo.EditValue
            .AccountType = cbeAccountType.EditValue
            .Bank = teBank.EditValue
            .InsertBank()

            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            Me.ClearFromData()

        End With

    End Sub
#End Region

#Region "Clears Form Data"

    Private Sub ClearFromData()
        teAccountNo.Text = String.Empty
        cbeAccountType.SelectedIndex = -1
        teBank.Text = String.Empty
        lblID.Text = String.Empty
        teAccountNo.Enabled = True
        teAccountNo.Focus()

    End Sub

#End Region

#Region "Display Bank"
    Public Sub DisplayBank(ByVal strBank As String)

        With DaBank
            .Account_No = strBank
            .GetByID()
            teBank.EditValue = .Bank
        End With


    End Sub
#End Region

#Region "Delete Bank"
    Private Sub Deletebank(ByVal strAccountNo As String)
        With DaBank
            .Account_No = strAccountNo
            .DeleteBank()
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
    Private Sub gvSuppliers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.DisplayRecord()

        Catch ex As Exception
            MessageError(ex.ToString)

        End Try

    End Sub
#End Region

#Region "Dispay Record"
    Public Sub DisplayRecord()

        If gvBanks.RowCount > 0 And Not gvBanks.IsFilterRow(gvBanks.FocusedRowHandle) Then

            xTab1.SelectedTabPageIndex = 0
            With DaBank
                .BankID = Me.gvBanks.GetFocusedRowCellValue(GridColumn1)
                .GetByID()
                lblID.Text = .BankID
                teAccountNo.EditValue = .Account_No
                cbeAccountType.EditValue = .AccountType
                teBank.EditValue = .Bank
            End With
            teAccountNo.Enabled = False

        End If
    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcBanks.DataSource = DaBank.GetAllBanks().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvBanks_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBanks.DoubleClick
        Me.DisplayRecord()
    End Sub
#End Region


   

End Class