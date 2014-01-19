Imports DA.Common.DAConstant
Imports DA.StartUp.DAEmployers
Imports DA.StartUp.DADoctors
Imports DA.StartUp.DAStock
Imports System.Data
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class frmReceipts

#Region "Variables"
    Private _DAEmployers As DA.StartUp.DAEmployers
    Private _DADoctors As DA.StartUp.DADoctors
    Private _DAStock As DA.StartUp.DAStock
    Private _DAReceipt As DA.Collections.DAReceipt

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

    Public ReadOnly Property DADoctors() As DA.StartUp.DADoctors
        Get
            If _DADoctors Is Nothing Then
                _DADoctors = New DA.StartUp.DADoctors
            End If

            Return _DADoctors
        End Get
    End Property

    Public ReadOnly Property DAStock() As DA.StartUp.DAStock
        Get
            If _DAStock Is Nothing Then
                _DAStock = New DA.StartUp.DAStock
            End If

            Return _DAStock
        End Get
    End Property

    Public ReadOnly Property DAReceipt() As DA.Collections.DAReceipt
        Get
            If _DAReceipt Is Nothing Then
                _DAReceipt = New DA.Collections.DAReceipt
            End If

            Return _DAReceipt
        End Get
    End Property

#End Region

#Region "Form Events"

    Private Sub frmReceipts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmReceipts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
        Me.PopulateStockGrid()
        Me.deFromDate.EditValue = DateAdd(DateInterval.Month, -3, Date.Today)
        Me.deToDate.EditValue = Date.Today
        Me.deDate.EditValue = Date.Today


     

    End Sub

    Private Sub frmReceipts_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
           
            Me.PopulateStocks()

            With DAReceipt
                .PrescriptionID = IIf(Me.lblPrescriptionID.Text = String.Empty, 0, Me.lblPrescriptionID.Text)

                If (.PrescriptionID <> 0) Then

                    .GetReceitByPrescriptionID()


                    If (.ReceiptID = 0) Then
                        Me.lciReceiptNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Me.seNoOfPairOfFrames.EditValue = .PFrameQty
                        Me.sePairOfFramesAmount.EditValue = .PFramePrice

                        If (.PLenseQty = 2) Then
                            Me.seNoOfLenses.EditValue = 1
                        ElseIf (.PLenseQty = 1) Then
                            Me.seNoOfLenses.EditValue = 0.5
                        End If

                        Me.sePairOfLenseAmount.EditValue = .PLensePrice

                    Else
                        Me.lciReceiptNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

                        Me.seNoOfPairOfFrames.EditValue = .NoOfPairOfFrames
                        Me.sePairOfFramesAmount.EditValue = .PairOfFramesAmount
                        Me.seNoOfLenses.EditValue = .NoOfLenses
                        Me.sePairOfLenseAmount.EditValue = .PairOfLenseAmount


                    End If


                    lblID.Text = .ReceiptID
                    Me.lblReceiptNo.Text = .ReceiptID
                    Me.teCustomer.EditValue = .CustomerName
                    Me.teAddressLine1.EditValue = .AddressLine1
                    Me.teAddressLine2.EditValue = .AddressLine2
                    Me.teAddressLine3.EditValue = .AddressLine3
                    Me.seAge.EditValue = .Age
                    Me.leRefractBy.EditValue = .RefractedBy
                    Me.lePrescriptionAttendedBy.EditValue = .PrescriptionAttendedBy
                    Me.dePrescriptionDate.EditValue = .PrescriptionDate
                    Me.seFullAmount.EditValue = .FullAmount
                    Me.seSpecialCharges.EditValue = .SpecialCharges
                    Me.seAdvancePaid.EditValue = .AdvancePaid
                    Me.seBalance.EditValue = .Balance
                    Me.tePrescriptionNo.EditValue = .SysNo

                    If (.ReceiptDate = Date.MinValue) Then
                        Me.deDate.EditValue = Date.Today
                    Else
                        Me.deDate.EditValue = .ReceiptDate
                    End If



                    Me.seNoOfFrameChange.EditValue = .NoOfFrameChange
                    Me.seFrameChangeAmount.EditValue = .FrameChangeAmount
                    Me.seRefractionEyePressureAmount.EditValue = .RefractionEyePressureAmount
                    Me.seTinttinAmount.EditValue = .TinttinAmount
                    Me.teCustomText.EditValue = .CustomText
                    Me.seCustomAmount.EditValue = .CustomAmount
                    Me.seTotal.EditValue = .Total
                    Me.teRefBillNo.EditValue = .RefBillNo
                    Me.seCashPaid.EditValue = .CashPaid
                    Me.meRemark.EditValue = .Remarks
                    Me.leSalesAttededBy.EditValue = .SalesAttendedBy
                    Me.PopulateStockGrid()


                Else

                    Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    'Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                End If






            End With

            Me.PopulateEmployers()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Bar Button Event"
    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Try
            Me.ClearFormData()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        Try
            If dxvpReceipt.Validate Then

                If lblID.Text = String.Empty Or lblID.Text = "0" Then
                    Me.SaveRecords()
                Else
                    Dim frm As New frmYesNo
                    frm.Text = "Record Already exists"
                    frm.LabelControl1.Text = "Record Already Exists"
                    frm.LabelControl2.Text = "Do you want to replace the selected record?"

                    If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                        Me.UpdateRecords()
                    End If
                End If

            End If

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
                    Me.DeleteReceipt(lblID.Text)
                    Me.ClearFormData()
                End If
            End If

            teCustomer.Focus()
        Catch ex As Exception
            Me.ClearFormData()
        End Try
    End Sub

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Try
            Me.Close()
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

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        Try
            With gvReceitHistory
                .ClearColumnsFilter()
                .ClearGrouping()
                .ClearSelection()
                .ClearSorting()
            End With

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub


    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try

            Select Case xTab1.SelectedTabPageIndex
                Case 0
                    If Not Me.tePrescriptionNo.Text = String.Empty Then

                        Me.ShowPrintPreview()

                    End If
                Case 1
                    If gvReceitHistory.RowCount > 0 Then

                        PrintPreview(gcReceitHistory, "Receipt Report")
                    Else
                        Exit Sub
                    End If

            End Select

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
            Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub
#End Region

#Region "Tab Events"

    Private Sub xTab1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
        Try
            Select Case e.Page.TabControl.SelectedTabPageIndex
                Case 0
                    Me.ShowToolButtonsOnNewRecordTabChange()
                Case 1
                    Me.ShowToolButtonsOnHistoryTabChange()
                    DAReceipt.FromDate = Me.deFromDate.EditValue
                    DAReceipt.ToDate = Me.deToDate.EditValue
                    Me.PopulateStockHistoryGrid()

            End Select
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Save Record"
    Private Sub SaveRecords()



        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try
            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            gvStock.PostEditor()

            With DAReceipt
                .ReceiptID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .ReceiptDate = deDate.EditValue
                .PrescriptionID = Convert.ToInt64(lblPrescriptionID.Text)

                .NoOfPairOfFrames = seNoOfPairOfFrames.EditValue
                .PairOfFramesAmount = sePairOfFramesAmount.EditValue
                .NoOfLenses = seNoOfLenses.EditValue
                .PairOfLenseAmount = sePairOfLenseAmount.EditValue
                .NoOfFrameChange = seNoOfFrameChange.EditValue
                .FrameChangeAmount = seFrameChangeAmount.EditValue
                .RefractionEyePressureAmount = seRefractionEyePressureAmount.EditValue
                .TinttinAmount = seTinttinAmount.EditValue
                .CustomText = teCustomText.EditValue
                .CustomAmount = seCustomAmount.EditValue
                .Total = seTotal.EditValue
                .RefBillNo = teRefBillNo.EditValue
                .CashPaid = seCashPaid.EditValue
                .Remarks = meRemark.EditValue
                .SalesAttendedBy = leSalesAttededBy.EditValue

                .InsertReceipt(_DB, _Transaction)

                For i As Integer = 0 To Me.gvStock.RowCount

                    If Not gvStock.GetRowCellDisplayText(i, gvStock.Columns(0)) = "" Then

                        .ReceiptID = .ReceiptID
                        .StockID = Me.gvStock.GetRowCellDisplayText(i, gColStockID)
                        .UnitPrice = Val(Me.gvStock.GetRowCellDisplayText(i, gColUnitPrice))
                        .PurchasingPrice = Val(Me.gvStock.GetRowCellDisplayText(i, gColPruchasingPrice))
                        .Quantity = Val(Me.gvStock.GetRowCellDisplayText(i, gColQty))
                        .Discount = Val(Me.gvStock.GetRowCellDisplayText(i, gColDiscount))
                        .Value = Val(Me.gvStock.GetRowCellDisplayText(i, gColValue))
                        .InsertReceiptDescription(_DB, _Transaction)

                        'Update Main Stock
                        .StockID = Me.gvStock.GetRowCellDisplayText(i, gColStockID)
                        .Quantity = Val(Me.gvStock.GetRowCellDisplayText(i, gColQty))
                        .UpdateStock(_DB, _Transaction)

                    End If

                Next

                _Transaction.Commit()




                Dim frm As New frmSavedOk
                frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                frm.ShowDialog()

                Me.ShowPrintPreview()

                Me.ClearFormData()

            End With




        Catch ex As Exception
            _Transaction.Rollback()
        Finally
            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If

        End Try
    End Sub
#End Region

#Region "Update Records"
    Private Sub UpdateRecords()

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing


        Try


            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()


            gvStock.PostEditor()


            With DAReceipt
                .ReceiptID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .ReceiptDate = deDate.EditValue
                .PrescriptionID = Convert.ToInt64(lblPrescriptionID.Text)
                .NoOfPairOfFrames = seNoOfPairOfFrames.EditValue
                .NoOfPairOfFrames = seNoOfPairOfFrames.EditValue
                .NoOfPairOfFrames = seNoOfPairOfFrames.EditValue
                .PairOfFramesAmount = sePairOfFramesAmount.EditValue
                .NoOfLenses = seNoOfLenses.EditValue
                .PairOfLenseAmount = sePairOfLenseAmount.EditValue
                .NoOfFrameChange = seNoOfFrameChange.EditValue
                .FrameChangeAmount = seFrameChangeAmount.EditValue
                .RefractionEyePressureAmount = seRefractionEyePressureAmount.EditValue
                .TinttinAmount = seTinttinAmount.EditValue
                .CustomText = teCustomText.EditValue
                .CustomAmount = seCustomAmount.EditValue
                .Total = seTotal.EditValue
                .RefBillNo = teRefBillNo.EditValue
                .CashPaid = seCashPaid.EditValue
                .Remarks = meRemark.EditValue
                .SalesAttendedBy = leSalesAttededBy.EditValue

                .InsertReceipt(_DB, _Transaction)

                .AddToStock(_DB, _Transaction)

                .ReceiptDescriptionDelete(_DB, _Transaction)

                For i As Integer = 0 To Me.gvStock.RowCount

                    If Not gvStock.GetRowCellDisplayText(i, gvStock.Columns(0)) = "" Then

                        .ReceiptID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                        .StockID = Me.gvStock.GetRowCellDisplayText(i, gColStockID)
                        .UnitPrice = Val(Me.gvStock.GetRowCellDisplayText(i, gColUnitPrice))
                        .PurchasingPrice = Val(Me.gvStock.GetRowCellDisplayText(i, gColPruchasingPrice))
                        .Quantity = Val(Me.gvStock.GetRowCellDisplayText(i, gColQty))
                        .Discount = Val(Me.gvStock.GetRowCellDisplayText(i, gColDiscount))
                        .Value = Val(Me.gvStock.GetRowCellDisplayText(i, gColValue))
                        .InsertReceiptDescription(_DB, _Transaction)

                        'Update Main Stock
                        .StockID = Me.gvStock.GetRowCellDisplayText(i, gColStockID)
                        .Quantity = Val(Me.gvStock.GetRowCellDisplayText(i, gColQty))
                        .UpdateStock(_DB, _Transaction)

                    End If

                Next

            End With


            _Transaction.Commit()

            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()


            Me.ClearFormData()


        Catch ex As Exception
            _Transaction.Rollback()

        Finally

            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If


        End Try

    End Sub
#End Region

#Region "Dispay Record"
    Public Sub DisplayRecord()
        If gvReceitHistory.RowCount > 0 And Not gvReceitHistory.IsFilterRow(gvReceitHistory.FocusedRowHandle) Then
            xTab1.SelectedTabPageIndex = 0
            With DAReceipt
                .ReceiptID = Me.gvReceitHistory.GetFocusedRowCellValue(GridColumn13)
                .GetReceitByID()

                lblID.Text = .ReceiptID
                Me.lblPrescriptionID.Text = .PrescriptionID
                Me.lblReceiptNo.Text = .ReceiptID
                Me.teCustomer.EditValue = .CustomerName
                Me.teAddressLine1.EditValue = .AddressLine1
                Me.teAddressLine2.EditValue = .AddressLine2
                Me.teAddressLine3.EditValue = .AddressLine3
                Me.seAge.EditValue = .Age
                Me.leRefractBy.EditValue = .RefractedBy
                Me.lePrescriptionAttendedBy.EditValue = .PrescriptionAttendedBy
                Me.dePrescriptionDate.EditValue = .PrescriptionDate
                Me.seFullAmount.EditValue = .FullAmount
                Me.seSpecialCharges.EditValue = .SpecialCharges
                Me.seAdvancePaid.EditValue = .AdvancePaid
                Me.seBalance.EditValue = .Balance
                Me.tePrescriptionNo.EditValue = .SysNo
                Me.deDate.EditValue = .ReceiptDate
                Me.seNoOfPairOfFrames.EditValue = .NoOfPairOfFrames
                Me.seNoOfPairOfFrames.EditValue = .NoOfPairOfFrames
                Me.seNoOfPairOfFrames.EditValue = .NoOfPairOfFrames
                Me.sePairOfFramesAmount.EditValue = .PairOfFramesAmount
                Me.seNoOfLenses.EditValue = .NoOfLenses
                Me.sePairOfLenseAmount.EditValue = .PairOfLenseAmount
                Me.seNoOfFrameChange.EditValue = .NoOfFrameChange
                Me.seFrameChangeAmount.EditValue = .FrameChangeAmount
                Me.seRefractionEyePressureAmount.EditValue = .RefractionEyePressureAmount
                Me.seTinttinAmount.EditValue = .TinttinAmount
                Me.teCustomText.EditValue = .CustomText
                Me.seCustomAmount.EditValue = .CustomAmount
                Me.seTotal.EditValue = .Total
                Me.teRefBillNo.EditValue = .RefBillNo
                Me.seCashPaid.EditValue = .CashPaid
                Me.meRemark.EditValue = .Remarks
                Me.leSalesAttededBy.EditValue = .SalesAttendedBy

                Me.PopulateStockGrid()

            End With


        End If
    End Sub
#End Region

#Region "Delete Receipt"
    Private Sub DeleteReceipt(ByVal _ReceiptID As Int64)

        Try
            With DAReceipt
                .ReceiptID = _ReceiptID
                .ReceitDelete()
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

#Region "Clear Form Data"

    Private Sub ClearFormData()
        Try

            teCustomer.Focus()

            teCustomer.EditValue = Nothing
            teAddressLine1.EditValue = Nothing
            teAddressLine2.EditValue = Nothing
            teAddressLine3.EditValue = Nothing
            seAge.EditValue = 0
            leRefractBy.EditValue = Nothing
            lePrescriptionAttendedBy.EditValue = Nothing
            dePrescriptionDate.EditValue = Nothing
            tePrescriptionNo.EditValue = Nothing
            seFullAmount.EditValue = 0
            seSpecialCharges.EditValue = 0
            seAdvancePaid.EditValue = 0
            seBalance.EditValue = 0
            seNoOfPairOfFrames.EditValue = 0
            sePairOfFramesAmount.EditValue = 0
            seNoOfLenses.EditValue = 0
            sePairOfLenseAmount.EditValue = 0
            seNoOfFrameChange.EditValue = 0
            seFrameChangeAmount.EditValue = 0
            seRefractionEyePressureAmount.EditValue = 0
            seTinttinAmount.EditValue = 0
            teCustomText.EditValue = Nothing
            seCustomAmount.EditValue = 0
            seTotal.EditValue = 0
            teRefBillNo.EditValue = Nothing
            seCashPaid.EditValue = 0
            meRemark.EditValue = Nothing
            leSalesAttededBy.EditValue = Nothing
            lblReceiptNo.Text = String.Empty
            lblID.Text = String.Empty

            dxvpReceipt.RemoveControlError(teCustomer)
            dxvpReceipt.RemoveControlError(seAge)
            dxvpReceipt.RemoveControlError(seFullAmount)
            dxvpReceipt.RemoveControlError(seSpecialCharges)
            dxvpReceipt.RemoveControlError(seAdvancePaid)
            dxvpReceipt.RemoveControlError(seBalance)
            dxvpReceipt.RemoveControlError(seNoOfPairOfFrames)
            dxvpReceipt.RemoveControlError(sePairOfFramesAmount)
            dxvpReceipt.RemoveControlError(seNoOfLenses)
            dxvpReceipt.RemoveControlError(sePairOfLenseAmount)
            dxvpReceipt.RemoveControlError(seNoOfFrameChange)
            dxvpReceipt.RemoveControlError(seFrameChangeAmount)
            dxvpReceipt.RemoveControlError(seRefractionEyePressureAmount)
            dxvpReceipt.RemoveControlError(seTinttinAmount)
            dxvpReceipt.RemoveControlError(seCustomAmount)
            dxvpReceipt.RemoveControlError(seTotal)
            dxvpReceipt.RemoveControlError(seCashPaid)
            dxvpReceipt.RemoveControlError(leSalesAttededBy)
            Me.lciReceiptNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.bbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.PopulateStockGrid()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

    '#Region "Populate Employers"
    '    Private Sub PopulateEmployers()
    '        Try

    '            Dim dt As New DataTable
    '            dt = DAEmployers.GetAllEmployers.Tables(0)

    '            lePrescriptionAttendedBy.Properties.DataSource = dt
    '            lePrescriptionAttendedBy.Properties.DisplayMember = "EmployerName"
    '            lePrescriptionAttendedBy.Properties.ValueMember = "EmployerID"

    '            'leSalesAttededBy.Properties.DataSource = dt
    '            'leSalesAttededBy.Properties.DisplayMember = "EmployerName"
    '            'leSalesAttededBy.Properties.ValueMember = "EmployerID"


    '        Catch ex As Exception
    '            MessageError(ex.ToString)
    '        End Try
    '    End Sub
    '#End Region

    '#Region "Populate Doctors"
    '    Private Sub PopulateDoctors()
    '        Try

    '            leRefractBy.Properties.DataSource = DADoctors.GetAllDoctors.Tables(0)
    '            leRefractBy.Properties.DisplayMember = "DoctorName"
    '            leRefractBy.Properties.ValueMember = "DoctorID"


    '        Catch ex As Exception
    '            MessageError(ex.ToString)
    '        End Try
    '    End Sub
    '#End Region

#Region "Populate Stocks"
    Private Sub PopulateStocks()
        Try

            rigleStocks.DataSource = DAStock.GetAllStockItems.Tables(0)

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Populate Stock Grid"

    Private Sub PopulateStockGrid()
        Try
            DAReceipt.ReceiptID = Convert.ToInt64(IIf(Me.lblID.Text <> String.Empty, lblID.Text, 0))
            Me.gcStock.DataSource = DAReceipt.ReceiptDescriptionGetByReceiptID.Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Stock History Grid"
    Private Sub PopulateStockHistoryGrid()
        Try
            Me.gcReceitHistory.DataSource = DAReceipt.ReceiptGetByDates.Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Button Events"

    Private Sub sbProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbProcess.Click
        Try
            If dxvpReceiptHistory.Validate Then

                DAReceipt.FromDate = Me.deFromDate.EditValue
                DAReceipt.ToDate = Me.deToDate.EditValue
                Me.PopulateStockHistoryGrid()

            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Grid Events"

    Private Sub gvStock_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvStock.CellValueChanged
        Select Case e.Column.ColumnEditName

            Case "riseQuantity", "riseUnitPrice", "reseDiscount"
                Dim Qty, UnitPrice, Discount As Decimal

                Qty = IIf(Not IsDBNull(gvStock.GetFocusedRowCellValue(gColQty)), gvStock.GetFocusedRowCellValue(gColQty), 0)
                UnitPrice = IIf(Not IsDBNull(gvStock.GetFocusedRowCellValue(gColUnitPrice)), gvStock.GetFocusedRowCellValue(gColUnitPrice), 0)
                Discount = IIf(Not IsDBNull(gvStock.GetFocusedRowCellValue(gColDiscount)), gvStock.GetFocusedRowCellValue(gColDiscount), 0)
                gvStock.SetFocusedRowCellValue(gColValue, ((Qty * UnitPrice) - Discount))
                Qty = 0
                UnitPrice = 0
                Discount = 0
        End Select
    End Sub

    Private Sub rigleStocks_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rigleStocks.EditValueChanged
        Try

            gvStock.SetFocusedRowCellValue(gColDescription, rigleStocks.View.GetRowCellValue(rigleStocks.View.GetRowHandle(rigleStocks.View.GetDataSourceRowIndex(rigleStocks.GetIndexByKeyValue(gvStock.EditingValue))), "Description"))
            gvStock.SetFocusedRowCellValue(gColUnitPrice, rigleStocks.View.GetRowCellValue(rigleStocks.View.GetRowHandle(rigleStocks.View.GetDataSourceRowIndex(rigleStocks.GetIndexByKeyValue(gvStock.EditingValue))), "SalesPrice"))
            gvStock.SetFocusedRowCellValue(gColPruchasingPrice, rigleStocks.View.GetRowCellValue(rigleStocks.View.GetRowHandle(rigleStocks.View.GetDataSourceRowIndex(rigleStocks.GetIndexByKeyValue(gvStock.EditingValue))), "PurchasingPrice"))
            gvStock.SetFocusedRowCellValue(gColStockID, rigleStocks.View.GetRowCellValue(rigleStocks.View.GetRowHandle(rigleStocks.View.GetDataSourceRowIndex(rigleStocks.GetIndexByKeyValue(gvStock.EditingValue))), "StockID"))
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try


    End Sub

    Private Sub gvReceitHistory_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvReceitHistory.DoubleClick
        Try
            Me.DisplayRecord()
            Me.lciReceiptNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Show Print Preview"

    Private Sub ShowPrintPreview()
        Try
            Dim report As New xrReceipt
            frmPrintPreview.PrintControl1.PrintingSystem = report.PrintingSystem

            With DAReceipt
                .ReceiptID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .GetReceitByID()

                report.xrlCustomerName.Text = .CustomerName
                report.xrlAddress1.Text = .AddressLine1
                report.xrlAddress2.Text = .AddressLine2
                report.xrlAddress3.Text = .AddressLine3
                report.xrlReceiptNo.Text = .ReceiptID
                report.xrlPrescriptionNo.Text = .SysNo
                report.xrlDate.Text = Date.Today.ToString("dd-MMM-yy")
                report.xrRefractBy.Text = .RefractedBy
                report.xrlFullAmount.Text = .FullAmount.ToString("F2")
                report.xrlAdvance.Text = .AdvancePaid.ToString("F2")
                report.xrlBalance.Text = .Balance.ToString("F2")



                report.xrlNoOfFrames.Text = .NoOfPairOfFrames
                report.xrlNoofLenses.Text = .NoOfLenses
                report.xrlNoOfFrameChanges.Text = .NoOfFrameChange

                report.xrlFrameAmount.Text = .PairOfFramesAmount.ToString("F2")
                report.xrlLenseAmount.Text = .PairOfLenseAmount.ToString("F2")
                report.xrlFrameChangeAmount.Text = .FrameChangeAmount.ToString("F2")
                report.xrlTesting.Text = .RefractionEyePressureAmount.ToString("F2")
                report.xrltinTin.Text = .TinttinAmount.ToString("F2")
                report.xrlCustomText.Text = .CustomText
                report.xrlCustomAmount.Text = .CustomAmount.ToString("F2")
                report.xrlTotal.Text = .Total.ToString("F2")


            End With

            report.CreateDocument()
            report.BringToFront()
            frmPrintPreview.MdiParent = frmMain
            frmPrintPreview.Show()
            frmPrintPreview.BringToFront()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Employers"

    Private Sub PopulateEmployers()
        Try
            Dim employersDataTable As New DataTable
            employersDataTable = DAEmployers.GetAllEmployers().Tables(0)

            leSalesAttededBy.Properties.Items.Clear()
          
            If (employersDataTable.Rows.Count > 0) Then

                For index As Integer = 0 To employersDataTable.Rows.Count - 1

                    leSalesAttededBy.Properties.Items.Add(employersDataTable.Rows(index)("EmployerName"))


                Next



            End If




        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

End Class