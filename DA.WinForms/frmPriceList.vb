Imports DA.Prescription.DAPriceList
Imports DA.Common.DAConstant

Public Class frmPriceList

#Region "Variables"

    Dim _DAPriceList As DA.Prescription.DAPriceList
    Dim dsPricePreset As New DataSet
#End Region

#Region "Constructor"

    Public ReadOnly Property DAPriceList() As DA.Prescription.DAPriceList
        Get

            If _DAPriceList Is Nothing Then
                _DAPriceList = New DA.Prescription.DAPriceList()
            End If

            Return _DAPriceList
        End Get
    End Property
#End Region

#Region "Form Events"

    Private Sub frmPriceList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.PopulatePricePreset()
        Me.PopulatePriceList()
        Me.HideToolButtonsOnLoad()
        GridColumn10.Group()
    End Sub

    Private Sub frmPriceList_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

#End Region

#Region "Hide Tool Buttons On Load"
    Public Sub HideToolButtonsOnLoad()
        Try
            Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
            Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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

#Region "Populate Price Preset"

    Private Sub PopulatePricePreset()
        Try
            Try
                dsPricePreset = DAPriceList.GetAllPricePreset()
                dsPricePreset.Tables(0).TableName = "tblPricePreset"
                gcPricePreset.DataSource = dsPricePreset.Tables(0)

            Catch ex As Exception
                MessageError(ex.ToString)
            End Try
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Price List"

    Private Sub PopulatePriceList()
        Try
            Try

                gcPriceList.DataSource = DAPriceList.GetAllPriceList.Tables(0)

            Catch ex As Exception
                MessageError(ex.ToString)
            End Try
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Bar Button Events"


    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        Try

            If xTab1.SelectedTabPageIndex = 0 Then

                gvPricePreset.PostEditor()
                gvPricePreset.UpdateCurrentRow()
                Dim i As Int64

                i = DAPriceList.UpdatePricePreset(dsPricePreset)

                If (i > 0) Then

                    Dim frm As New frmSavedOk
                    frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                    frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                    frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                    frm.ShowDialog()

                End If

          

            ElseIf xTab1.SelectedTabPageIndex = 1 Then

                If dxvpPriceList.Validate Then
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

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Try
            Me.DisplayRecord()
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

                    Me.DeletePriceList(lblID.Text)
                    Me.ClearFormData()

                End If
            End If



        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            If gvPriceList.RowCount > 0 Then
                PrintPreview(gcPriceList, "Price List Report")
            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        Try
            With gvPriceList
                .ClearColumnsFilter()
                .ClearGrouping()
                .ClearSelection()
                .ClearSorting()
            End With
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

#End Region

#Region "Save Price List"
    Private Sub SaveRecords()

        Try
            With DAPriceList


                .PriceListID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))

                .ItemName = teItemName.EditValue
                .StartValue = seFrom.EditValue
                .EndValue = seTo.EditValue
                .Price = sePrice.EditValue

                .InsertPriceList()

                Dim frm As New frmSavedOk
                frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                frm.ShowDialog()

                Me.ClearFormData()
                Me.PopulatePriceList()
            End With

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub
#End Region

#Region "Clear Form Data"

    Public Sub ClearFormData()

        Try
            lblID.Text = String.Empty
            teItemName.EditValue = Nothing
            seFrom.EditValue = 0
            seTo.EditValue = 0
            sePrice.EditValue = 0
            teItemName.Focus()


        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Dispay Record"

    Public Sub DisplayRecord()

        Try
            If gvPriceList.RowCount > 0 Then
                xTab1.SelectedTabPageIndex = 1

                With DAPriceList

                    .PriceListID = Me.gvPriceList.GetFocusedRowCellValue(GridColumn9)
                    .PriceListGetByID()
                    lblID.Text = .PriceListID
                    teItemName.EditValue = .ItemName
                    seFrom.EditValue = .StartValue
                    seTo.EditValue = .EndValue
                    sePrice.EditValue = .Price

                End With


            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

       
    End Sub
#End Region

#Region "Delete Price List"

    Private Sub DeletePriceList(ByVal PriceListID As Int64)

        Try
            With DAPriceList
                .PriceListID = PriceListID
                .DeletePriceList()
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

#Region "Tab Events"

    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged

        Try

            Select Case e.Page.TabControl.SelectedTabPageIndex
                Case 0
                    Me.ShowToolButtonsOnHistoryTabChange()
                    Me.PopulatePricePreset()
                    Me.PopulatePriceList()
                Case 1

                    Me.ShowToolButtonsOnNewRecordTabChange()


            End Select

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Grid Events"

    Private Sub gvPriceList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPriceList.DoubleClick
        Try
            Me.DisplayRecord()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

  
End Class