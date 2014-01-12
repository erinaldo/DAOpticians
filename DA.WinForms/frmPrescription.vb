Imports DA.Common.DAConstant
Imports System
Imports DA.Prescription.DAPrescription
Imports DA.Common
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common

Public Class frmPrescription

#Region "Varibles"
    Private _DAPrescription As DA.Prescription.DAPrescription
    Private _DAEmployers As DA.StartUp.DAEmployers
    Private _DADoctors As DA.StartUp.DADoctors
    Dim _DACollections As DA.Collections.DACollections
    Private _DAStock As DA.StartUp.DAStock

#End Region

#Region "Constructors"

    Public ReadOnly Property DAPrescription() As DA.Prescription.DAPrescription
        Get

            If _DAPrescription Is Nothing Then
                _DAPrescription = New DA.Prescription.DAPrescription
            End If

            Return _DAPrescription
        End Get
    End Property

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

    Public ReadOnly Property DACollections() As DA.Collections.DACollections
        Get

            If _DACollections Is Nothing Then
                _DACollections = New DA.Collections.DACollections()
            End If

            Return _DACollections
        End Get
    End Property

    Public ReadOnly Property DAStock() As DA.StartUp.DAStock
        Get

            If _DAStock Is Nothing Then
                _DAStock = New DA.StartUp.DAStock()
            End If

            Return _DAStock
        End Get
    End Property

#End Region

#Region "Form Events"

    Private Sub frmPrescription_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Me.PopulateDoctors()
            Me.PopulateEmployers()
            Me.PopulateLenseFrames()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub frmPrescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint1)
        Me.HideToolButtonsOnLoad()

        Me.dePrescriptionDate.EditValue = Date.Today
        Me.deDueDate.EditValue = DateAdd(DateInterval.Year, 2, Me.dePrescriptionDate.EditValue)

        Me.deFromDate.EditValue = DateAdd(DateInterval.Year, -10, Date.Today)
        Me.deToDate.EditValue = Date.Today
        'Me.PopulateCollectionsGrid()

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        _Connection = _DB.CreateConnection
        _Connection.Open()
        _Transaction = _Connection.BeginTransaction()
        Me.PopulateCollectionsGrid(_DB, _Transaction)
        _Transaction.Commit()

        'Me.CalculateBalance()
        Me.sbReceipt.Enabled = False
        Me.PopulateListBox()
    End Sub

#End Region

#Region "Bar Button Events"

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Me.ClearFormData()
        cbeName.Focus()
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        If dxvpPrescription.Validate Then

            If Me.tePrescriptionNo.Text = String.Empty Then


                Me.gvCollections.PostEditor()
                Me.SaveRecords()
                Me.PopulateListBox()
                Me.PopulateLenseFrames()


            Else
                Dim frm As New frmYesNo
                frm.Text = "Record Already exists"
                frm.LabelControl1.Text = "Record Already Exists"
                frm.LabelControl2.Text = "Do you want to replace the selected record?"

                If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    Me.gvCollections.PostEditor()
                    Me.UpdateRecords()
                    Me.PopulateLenseFrames()
                    Dim frmx As New frmSavedOk
                    frmx.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                    frmx.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                    frmx.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                    frmx.ShowDialog()

                    Me.ClearFormData()

                End If

            End If

        End If

    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        Try
            With gvPrescriptionHistory
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

            If gvPrescriptionHistory.RowCount > 0 And Not gvPrescriptionHistory.IsFilterRow(gvPrescriptionHistory.FocusedRowHandle) Then
                xTab1.SelectedTabPageIndex = 0
                Me.ClearFormData()
                Me.DisplayRecord(Me.gvPrescriptionHistory.GetFocusedRowCellValue(GridColumn1))
            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub bbPrint1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint1.ItemClick
        Try


            Select Case xTab1.SelectedTabPageIndex
                Case 0
                    If Not Me.tePrescriptionNo.Text = String.Empty Then

                        Me.ShowPrintPreview()

                    End If
                Case 1
                    If gvPrescriptionHistory.RowCount > 0 Then

                        PrintPreview(gcPrescriptionHistory, "Prescription Report")
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
            Me.bbPrint1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

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
            Me.bbPrint1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub
#End Region

#Region "Clear Form Data"
    Private Sub ClearFormData()

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try

            Me.teNIICNo.EditValue = Nothing
            Me.cbeName.EditValue = Nothing
            Me.cbeCareOf.EditValue = Nothing
            Me.teCustomerName.EditValue = Nothing
            Me.teCateOf.EditValue = Nothing
            Me.teAddress1.EditValue = Nothing
            Me.teAddress2.EditValue = Nothing
            Me.teAddress3.EditValue = Nothing
            Me.seAge.EditValue = Nothing
            Me.teTelephoneNo.EditValue = Nothing
            Me.teOfficeAddress.EditValue = Nothing
            Me.teOfficeTelNo.EditValue = Nothing
            Me.dePrescriptionDate.EditValue = Date.Today
            Me.deDueDate.EditValue = Nothing
            Me.tePrescriptionNo.EditValue = Nothing
            Me.teMobileNo.EditValue = Nothing

            Me.teBillNo.EditValue = Nothing
            Me.teInLx.EditValue = Nothing
            Me.teInLy.EditValue = Nothing
            Me.teInL2.EditValue = Nothing
            Me.teInL1.EditValue = Nothing
            Me.teInL4.EditValue = Nothing
            Me.teInL3.EditValue = Nothing
            Me.teInL6.EditValue = Nothing
            Me.teInL5.EditValue = Nothing
            Me.teInRy.EditValue = Nothing
            Me.teInRx.EditValue = Nothing
            Me.teInR6.EditValue = Nothing
            Me.teInR5.EditValue = Nothing
            Me.teInR4.EditValue = Nothing
            Me.teInR3.EditValue = Nothing
            Me.teInR2.EditValue = Nothing
            Me.teInR1.EditValue = Nothing
            Me.teExRy.EditValue = Nothing
            Me.teExRx.EditValue = Nothing
            Me.teExR6.EditValue = Nothing
            Me.teExR5.EditValue = Nothing
            Me.teExR4.EditValue = Nothing
            Me.teExR3.EditValue = Nothing
            Me.teExR2.EditValue = Nothing
            Me.teExR1.EditValue = Nothing
            Me.teExL6.EditValue = Nothing
            Me.teExL5.EditValue = Nothing
            Me.teExL4.EditValue = Nothing
            Me.teExL3.EditValue = Nothing
            Me.teExL2.EditValue = Nothing
            Me.teExL1.EditValue = Nothing
            Me.teExLy.EditValue = Nothing
            Me.teExLx.EditValue = Nothing

            Me.teHbRx.EditValue = Nothing
            Me.teHbRy.EditValue = Nothing
            Me.teHbR1.EditValue = Nothing
            Me.teHbR2.EditValue = Nothing
            Me.teHbR3.EditValue = Nothing
            Me.teHbR4.EditValue = Nothing
            Me.teHbR5.EditValue = Nothing
            Me.teHbR6.EditValue = Nothing
            Me.teHbLx.EditValue = Nothing
            Me.teHbLy.EditValue = Nothing
            Me.teHbL1.EditValue = Nothing
            Me.teHbL2.EditValue = Nothing
            Me.teHbL3.EditValue = Nothing
            Me.teHbL4.EditValue = Nothing
            Me.teHbL5.EditValue = Nothing
            Me.teHbL6.EditValue = Nothing

            Me.teInIOPLx.EditValue = Nothing
            Me.teInIOPLy.EditValue = Nothing
            Me.teExIOPLx.EditValue = Nothing
            Me.teExIOPLy.EditValue = Nothing
            Me.teHbIOPLx.EditValue = Nothing
            Me.teHbIOPLy.EditValue = Nothing
            Me.teInIOPRx.EditValue = Nothing
            Me.teInIOPRy.EditValue = Nothing
            Me.teExIOPRx.EditValue = Nothing
            Me.teExIOPRy.EditValue = Nothing
            Me.teHbIOPRx.EditValue = Nothing
            Me.teHbIOPRy.EditValue = Nothing

            Me.cbeLense.EditValue = Nothing
            Me.cbeFrame.EditValue = Nothing
            'Me.seTotal.EditValue = Nothing
            Me.meNote.EditValue = Nothing
            Me.seSPCharges.EditValue = 0
            Me.seFullAmount.EditValue = 0
            Me.teOrderOrder.EditValue = Nothing
            Me.teSegSize.EditValue = Nothing
            Me.leDispensedBy.EditValue = Nothing

            Me.tePD.EditValue = Nothing
            Me.leRefractedBy.EditValue = Nothing
            Me.leDispensedBy.EditValue = Nothing
            Me.teInsert.EditValue = Nothing
            Me.leAttendedBy.EditValue = Nothing
            Me.seBalance.EditValue = 0
            Me.deDelivaryDate.EditValue = Nothing
            lciDelivaryDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            Me.lupLenseRight.EditValue = Nothing
            Me.seLenseQtyRight.EditValue = 0
            Me.seLensePriceRight.EditValue = 0

            Me.lupLenseLeft.EditValue = Nothing
            Me.seLenseQtyLeft.EditValue = 0
            Me.seLensePriceLeft.EditValue = 0

            Me.LupFrame.EditValue = Nothing
            Me.seFrameQty.EditValue = 0
            Me.seFramePrice.EditValue = 0


            dxvpPrescription.RemoveControlError(cbeName)
            dxvpPrescription.RemoveControlError(teCustomerName)
            dxvpPrescription.RemoveControlError(leRefractedBy)
            dxvpPrescription.RemoveControlError(leDispensedBy)
            dxvpPrescription.RemoveControlError(leAttendedBy)
            dxvpPrescription.RemoveControlError(teAddress1)

            Me.deDueDate.EditValue = DateAdd(DateInterval.Year, 2, Me.dePrescriptionDate.EditValue)

            dxvpPrescription.RemoveControlError(dePrescriptionDate)
            dxvpPrescription.RemoveControlError(deDueDate)
            Me.lblID.Text = String.Empty
            Me.ceReady.Checked = False
            Me.ceDelivered.Checked = False
            Me.lciPrescriptionNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.sbReceipt.Enabled = False




            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()
            Me.PopulateCollectionsGrid(_DB, _Transaction)
            _Transaction.Commit()

            CalculateBalance()
        Catch ex As Exception
            _Transaction.Rollback()
        End Try

    End Sub
#End Region

#Region "Save Prescription Data"

    Private Sub SaveRecords()


        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing
        Dim pno As String

        Try


            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            With DAPrescription
                .PrescriptionID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .SysNo = IIf(tePrescriptionNo.EditValue = Nothing, String.Empty, tePrescriptionNo.EditValue)
                .Salutation1 = cbeName.EditValue
                .Salutation2 = cbeCareOf.EditValue
                .Name = teCustomerName.EditValue
                .Careof = teCateOf.EditValue
                .Address1 = teAddress1.EditValue
                .Address2 = teAddress2.EditValue
                .Address3 = teAddress3.EditValue
                .Office = teOfficeAddress.EditValue
                .Age = seAge.EditValue
                .TelNo = teTelephoneNo.EditValue
                .OfficeNo = teOfficeTelNo.EditValue
                .PrescriptionDate = dePrescriptionDate.EditValue
                .DueDate = deDueDate.EditValue
                .BillNo = teBillNo.EditValue
                .NICNo = teNIICNo.EditValue
                .MobileNo = teMobileNo.EditValue

                If (deDelivaryDate.EditValue = Nothing) Then
                    .DelivaryDate = Date.MinValue
                Else
                    .DelivaryDate = deDelivaryDate.EditValue

                End If

                .LenseRightStockID = lupLenseRight.EditValue
                .LenseRightQty = seLenseQtyRight.EditValue
                .LenseRightPrice = seLensePriceRight.EditValue

                .LenseLeftStockID = lupLenseLeft.EditValue
                .LenseLeftQty = seLenseQtyLeft.EditValue
                .LenseLeftPrice = seLensePriceLeft.EditValue

                .FrameStockID = LupFrame.EditValue
                .FrameQty = seFrameQty.EditValue
                .FramePrice = seFramePrice.EditValue

                .InLx = teInLx.EditValue()
                .InLy = teInLy.EditValue()
                .InL1 = teInL1.EditValue()
                .InL2 = teInL2.EditValue()
                .InL3 = teInL3.EditValue
                .InL4 = teInL4.EditValue
                .InL5 = teInL5.EditValue
                .InL6 = teInL6.EditValue

                .InRx = teInRx.EditValue
                .InRy = teInRy.EditValue
                .InR1 = teInR1.EditValue
                .InR2 = teInR2.EditValue
                .InR3 = teInR3.EditValue
                .InR4 = teInR4.EditValue
                .InR5 = teInR5.EditValue
                .InR6 = teInR6.EditValue

                .IxRx = teExRx.EditValue
                .IxRy = teExRy.EditValue
                .IxR1 = teExR1.EditValue
                .IxR2 = teExR2.EditValue
                .IxR3 = teExR3.EditValue
                .IxR4 = teExR4.EditValue
                .IxR5 = teExR5.EditValue
                .IxR6 = teExR6.EditValue

                .IxLx = teExLx.EditValue
                .IxLy = teExLy.EditValue
                .IxL1 = teExL1.EditValue
                .IxL2 = teExL2.EditValue
                .IxL3 = teExL3.EditValue
                .IxL4 = teExL4.EditValue
                .IxL5 = teExL5.EditValue
                .IxL6 = teExL6.EditValue

                .HxRx = teHbRx.EditValue
                .HxRy = teHbRy.EditValue
                .HxR1 = teHbR1.EditValue
                .HxR2 = teHbR2.EditValue
                .HxR3 = teHbR3.EditValue
                .HxR4 = teHbR4.EditValue
                .HxR5 = teHbR5.EditValue
                .HxR6 = teHbR6.EditValue

                .HxLx = teHbLx.EditValue
                .HxLy = teHbLy.EditValue
                .HxL1 = teHbL1.EditValue
                .HxL2 = teHbL2.EditValue
                .HxL3 = teHbL3.EditValue
                .HxL4 = teHbL4.EditValue
                .HxL5 = teHbL5.EditValue
                .HxL6 = teHbL6.EditValue


                .InIOPLx = teInIOPLx.EditValue
                .InIOPLy = teInIOPLy.EditValue
                .ExIOPLx = teExIOPLx.EditValue
                .ExIOPLy = teExIOPLy.EditValue
                .HbIOPLx = teHbIOPLx.EditValue
                .HbIOPLy = teHbIOPLy.EditValue

                .InIOPRx = teInIOPRx.EditValue
                .InIOPRy = teInIOPRy.EditValue
                .ExIOPRx = teExIOPRx.EditValue
                .ExIOPRy = teExIOPRy.EditValue
                .HbIOPRx = teHbIOPRx.EditValue
                .HbIOPRy = teHbIOPRy.EditValue

                .Lense = cbeLense.EditValue
                .Frame = cbeFrame.EditValue
                .Segment = teSegSize.EditValue
                .Pd = tePD.EditValue
                .Insert = teInsert.EditValue
                .Refracted = leRefractedBy.EditValue
                .Dispensed = leDispensedBy.EditValue
                .Orderno = teOrderOrder.EditValue
                .Fullamount = seFullAmount.EditValue
                .Specialcharges = seSPCharges.EditValue
                '.Total = seTotal.EditValue
                .Remarks = meNote.EditValue
                .Ready = ceReady.EditValue
                .Delivered = ceDelivered.EditValue
                .AttendedBy = leAttendedBy.EditValue

                .InsertPrescription(_DB, _Transaction)


                With DACollections


                    For i As Integer = 0 To Me.gvCollections.RowCount
                        If Not gvCollections.GetRowCellDisplayText(i, colType) = "" Then

                            .SystemID = DAPrescription.PrescriptionID
                            .TransactionTypeID = DAEnums.EnumTransactionTypes.PRESCRIPTION

                            Select Case Me.gvCollections.GetRowCellDisplayText(i, colType)

                                Case "CASH"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                                Case "CHECK"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                                Case "CR CARD"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD

                            End Select

                            .Date = Date.Parse(Me.gvCollections.GetRowCellDisplayText(i, colCollectionDate))
                            .Reference = Me.gvCollections.GetRowCellDisplayText(i, colReference)
                            .Amount = Val(Me.gvCollections.GetRowCellDisplayText(i, colAdvanceAmount))

                            If (Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate) = String.Empty) Then
                                .ReferenceDate = DateTime.MinValue
                            Else
                                .ReferenceDate = Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate)

                            End If

                            .Bank = Me.gvCollections.GetRowCellDisplayText(i, colBank)

                            .InsertCollection(_DB, _Transaction)
                        End If

                    Next

                End With

                pno = .PrescriptionID.ToString()

            End With

            _Transaction.Commit()


            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL + " [Prescription No  - " + pno + "]"
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            Me.ClearFormData()
            cbeName.Focus()

        Catch ex As Exception
            _Transaction.Rollback()
            MessageError(ex.ToString)
        Finally
            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If

        End Try
    End Sub

#End Region

#Region "Update Prescription Data"

    Private Sub UpdateRecords()


        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try

            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            With DAPrescription
                .PrescriptionID = Convert.ToInt64(Me.lblID.Text)
                .SysNo = tePrescriptionNo.EditValue
                .Salutation1 = cbeName.EditValue
                .Salutation2 = cbeCareOf.EditValue
                .Name = teCustomerName.EditValue
                .Careof = teCateOf.EditValue
                .Address1 = teAddress1.EditValue
                .Address2 = teAddress2.EditValue
                .Address3 = teAddress3.EditValue
                .Office = teOfficeAddress.EditValue
                .Age = seAge.EditValue
                .TelNo = teTelephoneNo.EditValue
                .OfficeNo = teOfficeTelNo.EditValue
                .PrescriptionDate = dePrescriptionDate.EditValue
                .DueDate = deDueDate.EditValue
                .BillNo = teBillNo.EditValue
                .NICNo = teNIICNo.EditValue
                .MobileNo = teMobileNo.EditValue

                If (deDelivaryDate.EditValue = Nothing) Then
                    .DelivaryDate = Date.MinValue
                Else
                    .DelivaryDate = deDelivaryDate.EditValue

                End If


                .LenseRightStockID = lupLenseRight.EditValue
                .LenseRightQty = seLenseQtyRight.EditValue
                .LenseRightPrice = seLensePriceRight.EditValue

                .LenseLeftStockID = lupLenseLeft.EditValue
                .LenseLeftQty = seLenseQtyLeft.EditValue
                .LenseLeftPrice = seLensePriceLeft.EditValue

                .FrameStockID = LupFrame.EditValue
                .FrameQty = seFrameQty.EditValue
                .FramePrice = seFramePrice.EditValue

                .InLx = teInLx.EditValue
                .InLy = teInLy.EditValue
                .InL1 = teInL1.EditValue
                .InL2 = teInL2.EditValue
                .InL3 = teInL3.EditValue
                .InL4 = teInL4.EditValue
                .InL5 = teInL5.EditValue
                .InL6 = teInL6.EditValue

                .InRx = teInRx.EditValue
                .InRy = teInRy.EditValue
                .InR1 = teInR1.EditValue
                .InR2 = teInR2.EditValue
                .InR3 = teInR3.EditValue
                .InR4 = teInR4.EditValue
                .InR5 = teInR5.EditValue
                .InR6 = teInR6.EditValue

                .IxRx = teExRx.EditValue
                .IxRy = teExRy.EditValue
                .IxR1 = teExR1.EditValue
                .IxR2 = teExR2.EditValue
                .IxR3 = teExR3.EditValue
                .IxR4 = teExR4.EditValue
                .IxR5 = teExR5.EditValue
                .IxR6 = teExR6.EditValue

                .IxLx = teExLx.EditValue
                .IxLy = teExLy.EditValue
                .IxL1 = teExL1.EditValue
                .IxL2 = teExL2.EditValue
                .IxL3 = teExL3.EditValue
                .IxL4 = teExL4.EditValue
                .IxL5 = teExL5.EditValue
                .IxL6 = teExL6.EditValue

                .HxRx = teHbRx.EditValue
                .HxRy = teHbRy.EditValue
                .HxR1 = teHbR1.EditValue
                .HxR2 = teHbR2.EditValue
                .HxR3 = teHbR3.EditValue
                .HxR4 = teHbR4.EditValue
                .HxR5 = teHbR5.EditValue
                .HxR6 = teHbR6.EditValue

                .HxLx = teHbLx.EditValue
                .HxLy = teHbLy.EditValue
                .HxL1 = teHbL1.EditValue
                .HxL2 = teHbL2.EditValue
                .HxL3 = teHbL3.EditValue
                .HxL4 = teHbL4.EditValue
                .HxL5 = teHbL5.EditValue
                .HxL6 = teHbL6.EditValue

                .InIOPLx = teInIOPLx.EditValue
                .InIOPLy = teInIOPLy.EditValue
                .ExIOPLx = teExIOPLx.EditValue
                .ExIOPLy = teExIOPLy.EditValue
                .HbIOPLx = teHbIOPLx.EditValue
                .HbIOPLy = teHbIOPLy.EditValue

                .InIOPRx = teInIOPRx.EditValue
                .InIOPRy = teInIOPRy.EditValue
                .ExIOPRx = teExIOPRx.EditValue
                .ExIOPRy = teExIOPRy.EditValue
                .HbIOPRx = teHbIOPRx.EditValue
                .HbIOPRy = teHbIOPRy.EditValue

                .Lense = cbeLense.EditValue
                .Frame = cbeFrame.EditValue
                .Segment = teSegSize.EditValue
                .Pd = tePD.EditValue
                .Insert = teInsert.EditValue
                .Refracted = leRefractedBy.EditValue
                .Dispensed = leDispensedBy.EditValue
                .Orderno = teOrderOrder.EditValue
                .Fullamount = seFullAmount.EditValue
                .Specialcharges = seSPCharges.EditValue
                '.Total = seTotal.EditValue
                .Remarks = meNote.EditValue
                .Ready = ceReady.EditValue
                .Delivered = ceDelivered.EditValue
                .AttendedBy = leAttendedBy.EditValue

                .InsertPrescription(_DB, _Transaction)


                With DACollections

                    .SystemID = Convert.ToInt64(lblID.Text)
                    .TransactionTypeID = DAEnums.EnumTransactionTypes.PRESCRIPTION
                    .CollectionDelete(_DB, _Transaction)

                    For i As Integer = 0 To Me.gvCollections.RowCount
                        If Not gvCollections.GetRowCellDisplayText(i, colType) = "" Then

                            .SystemID = DAPrescription.PrescriptionID
                            .TransactionTypeID = DAEnums.EnumTransactionTypes.PRESCRIPTION

                            Select Case Me.gvCollections.GetRowCellDisplayText(i, colType)

                                Case "CASH"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                                Case "CHECK"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                                Case "CR CARD"
                                    .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD

                            End Select

                            .Date = Date.Parse(Me.gvCollections.GetRowCellDisplayText(i, colCollectionDate))
                            .Reference = Me.gvCollections.GetRowCellDisplayText(i, colReference)
                            .Amount = Val(Me.gvCollections.GetRowCellDisplayText(i, colAdvanceAmount))

                            If (Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate) = String.Empty) Then
                                .ReferenceDate = DateTime.MinValue
                            Else
                                .ReferenceDate = Me.gvCollections.GetRowCellDisplayText(i, colReferenceDate)

                            End If

                            .Bank = Me.gvCollections.GetRowCellDisplayText(i, colBank)

                            .InsertCollection(_DB, _Transaction)
                        End If

                    Next

                End With


            End With

            _Transaction.Commit()


            'Dim frm As New frmSavedOk
            'frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            'frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            'frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            'frm.ShowDialog()

            'Me.ClearFormData()

        Catch ex As Exception
            _Transaction.Rollback()
            MessageError(ex.ToString)
            Me.ClearFormData()
        Finally
            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If

        End Try
    End Sub

#End Region

#Region "Display Prescription"

    Public Sub DisplayRecord(ByVal Pid As Int64)

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try
            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            With DAPrescription
                .PrescriptionID = Pid
                .GetPrescriptionByID(_DB, _Transaction)

                lciPrescriptionNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                lblID.Text = .PrescriptionID
                tePrescriptionNo.EditValue = .SysNo

                cbeName.EditValue = .Salutation1
                cbeCareOf.EditValue = .Salutation2
                teCustomerName.EditValue = .Name
                teCateOf.EditValue = .Careof
                teAddress1.EditValue = .Address1
                teAddress2.EditValue = .Address2
                teAddress3.EditValue = .Address3
                teOfficeAddress.EditValue = .Office
                seAge.EditValue = .Age
                teTelephoneNo.EditValue = .TelNo
                teOfficeTelNo.EditValue = .OfficeNo
                dePrescriptionDate.EditValue = .PrescriptionDate
                deDueDate.EditValue = .DueDate
                teBillNo.EditValue = .BillNo
                teNIICNo.EditValue = .NICNo
                teMobileNo.EditValue = .MobileNo

                teInLx.EditValue = .InLx
                teInLy.EditValue = .InLy
                teInL1.EditValue = .InL1
                teInL2.EditValue = .InL2
                teInL3.EditValue = .InL3
                teInL4.EditValue = .InL4
                teInL5.EditValue = .InL5
                teInL6.EditValue = .InL6

                teInRx.EditValue = .InRx
                teInRy.EditValue = .InRy
                teInR1.EditValue = .InR1
                teInR2.EditValue = .InR2
                teInR3.EditValue = .InR3
                teInR4.EditValue = .InR4
                teInR5.EditValue = .InR5
                teInR6.EditValue = .InR6

                teExRx.EditValue = .IxRx
                teExRy.EditValue = .IxRy
                teExR1.EditValue = .IxR1
                teExR2.EditValue = .IxR2
                teExR3.EditValue = .IxR3
                teExR4.EditValue = .IxR4
                teExR5.EditValue = .IxR5
                teExR6.EditValue = .IxR6

                teExLx.EditValue = .IxLx
                teExLy.EditValue = .IxLy
                teExL1.EditValue = .IxL1
                teExL2.EditValue = .IxL2
                teExL3.EditValue = .IxL3
                teExL4.EditValue = .IxL4
                teExL5.EditValue = .IxL5
                teExL6.EditValue = .IxL6

                teHbRx.EditValue = .HxRx
                teHbRy.EditValue = .HxRy
                teHbR1.EditValue = .HxR1
                teHbR2.EditValue = .HxR2
                teHbR3.EditValue = .HxR3
                teHbR4.EditValue = .HxR4
                teHbR5.EditValue = .HxR5
                teHbR6.EditValue = .HxR6

                teHbLx.EditValue = .HxLx
                teHbLy.EditValue = .HxLy
                teHbL1.EditValue = .HxL1
                teHbL2.EditValue = .HxL2
                teHbL3.EditValue = .HxL3
                teHbL4.EditValue = .HxL4
                teHbL5.EditValue = .HxL5
                teHbL6.EditValue = .HxL6

                teInIOPLx.EditValue = .InIOPLx
                teInIOPLy.EditValue = .InIOPLy
                teExIOPLx.EditValue = .ExIOPLx
                teExIOPLy.EditValue = .ExIOPLy
                teHbIOPLx.EditValue = .HbIOPLx
                teHbIOPLy.EditValue = .HbIOPLy
                teInIOPRx.EditValue = .InIOPRx
                teInIOPRy.EditValue = .InIOPRy
                teExIOPRx.EditValue = .ExIOPRx
                teExIOPRy.EditValue = .ExIOPRy
                teHbIOPRx.EditValue = .HbIOPRx
                teHbIOPRy.EditValue = .HbIOPRy


                cbeLense.EditValue = .Lense
                cbeFrame.EditValue = .Frame
                teSegSize.EditValue = .Segment
                tePD.EditValue = .Pd
                teInsert.EditValue = .Insert
                leRefractedBy.EditValue = .Refracted
                leDispensedBy.EditValue = .Dispensed
                teOrderOrder.EditValue = .Orderno
                seFullAmount.EditValue = .Fullamount
                seSPCharges.EditValue = .Specialcharges
                'seTotal.EditValue = .Total
                meNote.EditValue = .Remarks

                If (.Ready = True) Then
                    ceReady.Checked = True
                Else
                    ceReady.Checked = False
                End If

                If (.Delivered) Then
                    ceDelivered.Checked = True

                    If (.DelivaryDate = Date.MinValue) Then

                        lciDelivaryDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                    Else

                        deDelivaryDate.EditValue = .DelivaryDate
                        lciDelivaryDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    End If


                Else
                    ceDelivered.Checked = False
                    lciDelivaryDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                End If


                leAttendedBy.EditValue = .AttendedBy

                lupLenseRight.EditValue = .LenseRightStockID
                seLenseQtyRight.EditValue = .LenseRightQty
                seLensePriceRight.EditValue = .LenseRightPrice

                lupLenseLeft.EditValue = .LenseLeftStockID
                seLenseQtyLeft.EditValue = .LenseLeftQty
                seLensePriceLeft.EditValue = .LenseLeftPrice

                LupFrame.EditValue = .FrameStockID
                seFrameQty.EditValue = .FrameQty
                seFramePrice.EditValue = .FramePrice

                Me.PopulateCollectionsGrid(_DB, _Transaction)
                Me.CalculateBalance()
            End With

            _Transaction.Commit()

        Catch ex As Exception

            _Transaction.Rollback()
            MessageError(ex.ToString)
            Me.ClearFormData()

        Finally
            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If
        End Try







    End Sub

#End Region

#Region "Spin Edit Events"
    Private Sub seFullAmount_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles seFullAmount.EditValueChanging
        Me.CalculateBalance()
    End Sub

    Private Sub seSPCharges_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles seSPCharges.EditValueChanging
        Me.CalculateBalance()
    End Sub

    Private Sub seFullAmount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seFullAmount.EditValueChanged
        Me.CalculateBalance()
    End Sub

    Private Sub seSPCharges_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seSPCharges.EditValueChanged
        Me.CalculateBalance()
    End Sub
#End Region

#Region "Populate Prescription History Grid"

    Private Sub PopulatePrescriptionHistoryGrid()
        Try
            Me.gcPrescriptionHistory.DataSource = DAPrescription.PrescriptionGetByDates.Tables(0)
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
                    Me.Cursor = Cursors.WaitCursor
                    Me.ShowToolButtonsOnHistoryTabChange()
                    DAPrescription.FromDate = Me.deFromDate.EditValue
                    DAPrescription.ToDate = Me.deToDate.EditValue
                    Me.PopulatePrescriptionHistoryGrid()
                    Me.Cursor = Cursors.Default
            End Select
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Grid Events"

    Private Sub gvPrescriptionHistory_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPrescriptionHistory.DoubleClick
        Try

            If gvPrescriptionHistory.RowCount > 0 And Not gvPrescriptionHistory.IsFilterRow(gvPrescriptionHistory.FocusedRowHandle) Then
                xTab1.SelectedTabPageIndex = 0
                Me.ClearFormData()
                Me.DisplayRecord(Me.gvPrescriptionHistory.GetFocusedRowCellValue(GridColumn1))
                Me.lciPrescriptionNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.sbReceipt.Enabled = True
                Me.CalculateBalance()
            End If



        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub gvCollections_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvCollections.CellValueChanged

        If e.Column.Name = colAdvanceAmount.Name Then

            Try
                Me.CalculateBalance()
            Catch ex As Exception
                MessageError(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub gvCollections_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvCollections.RowUpdated
        Try
            Me.CalculateBalance()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub gvCollections_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvCollections.RowCountChanged
        Try
            Me.CalculateBalance()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub gvCollections_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvCollections.FocusedRowChanged
        Try
            Me.CalculateBalance()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Button Event"

    Private Sub sbProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbProcess.Click
        Try
            If dxvpPrescriptionHistory.Validate Then

                DAPrescription.FromDate = Me.deFromDate.EditValue
                DAPrescription.ToDate = Me.deToDate.EditValue

                Me.Cursor = Cursors.WaitCursor
                Me.PopulatePrescriptionHistoryGrid()
                Me.Cursor = Cursors.Default

            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Collections Grid"
    Private Sub PopulateCollectionsGrid(ByVal DB As Database, ByVal transaction As DbTransaction)
        Try
            DACollections.SystemID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            DACollections.TransactionTypeID = DAEnums.EnumTransactionTypes.PRESCRIPTION
            gcCollections.DataSource = DACollections.CollectionGetByID().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Repository Events"

    Private Sub ricbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ricbType.SelectedIndexChanged
        Try
            gvCollections.SetFocusedRowCellValue(colCollectionDate, Date.Today)

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Button Events"

    Private Sub sbPirceList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbPirceList.Click
        Try
            frmPriceList.StartPosition = FormStartPosition.CenterScreen
            frmPriceList.ShowDialog()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub sbReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbReceipt.Click
        Try


            frmReceipts.lblPrescriptionID.Text = Convert.ToInt64(Me.lblID.Text)
            'frmReceipts.dePrescriptionDate.EditValue = Me.dePrescriptionDate.EditValue
            'frmReceipts.tePrescriptionNo.EditValue = Me.tePrescriptionNo.EditValue
            'frmReceipts.teCustomer.EditValue = Me.teCustomerName.EditValue
            'frmReceipts.teAddressLine1.EditValue = Me.teAddress1.EditValue
            'frmReceipts.teAddressLine2.EditValue = Me.teAddress2.EditValue
            'frmReceipts.teAddressLine3.EditValue = Me.teAddress3.EditValue
            'frmReceipts.seAge.EditValue = Me.seAge.EditValue
            'frmReceipts.leRefractBy.EditValue = Me.leRefractedBy.EditValue
            'frmReceipts.lePrescriptionAttendedBy.EditValue = Me.leAttendedBy.EditValue
            'frmReceipts.seFullAmount.EditValue = Me.seFullAmount.EditValue
            'frmReceipts.seSpecialCharges.EditValue = Me.seSPCharges.EditValue
            'frmReceipts.seAdvancePaid.EditValue = Me.colAdvanceAmount.SummaryText
            'frmReceipts.seBalance.EditValue = Me.seBalance.EditValue
            'frmReceipts.StartPosition = FormStartPosition.CenterScreen
            frmReceipts.MdiParent = frmMain
            frmReceipts.Show()
            frmReceipts.BringToFront()


        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Calculate Balance"
    Private Sub CalculateBalance()
        Try
            Dim total, advance, balance As Decimal
            total = 0
            advance = 0
            balance = 0
            total = Me.seFullAmount.EditValue

            If (Me.colAdvanceAmount.SummaryText <> String.Empty) Then
                advance = Me.colAdvanceAmount.SummaryText
            Else
                advance = 0
            End If


            balance = total - advance
            Me.seBalance.EditValue = balance

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Show Print Preview"

    Private Sub ShowPrintPreview()

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try

            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            Dim report As New xrPrescription
            frmPrintPreview.PrintControl1.PrintingSystem = report.PrintingSystem


            Dim _DACompany As New DA.StartUp.DACompany
            _DACompany.GetCompany()

            report.xrCompanyName.Text = _DACompany.CompanyName
            report.xrCompanyAddress.Text = _DACompany.Address1 + vbLf + _DACompany.Address2 + vbLf + "Telephone : " + _DACompany.Telephone + " Fax : " + _DACompany.Fax + vbLf + "Reg No - " + _DACompany.RegNo

            With DAPrescription
                .PrescriptionID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .GetPrescriptionByID(_DB, _Transaction)

                report.xrPrescriptionNo.Text = ": " + .SysNo
                report.xrOrderNo.Text = ": " + .Orderno
                report.xrDate.Text = ": " + UCase(.PrescriptionDate.ToString("dd-MMM-yy"))

                report.xrCustomerName.Text = ": " + .Salutation1 + " " + .Name
                report.xrCareOf.Text = ": " + .Salutation2 + " " + .Careof
                report.xrAddress.Text = ": " + .Address1 + vbLf + ": " + .Address2 + vbLf + ": " + .Address3
                report.xrOfficeAddress.Text = ": " + .Office
                report.xrAge.Text = ": " + .Age.ToString
                report.xrExpireDate.Text = ": " + UCase(.DueDate.ToString("dd-MMM-yy"))
                report.xrReceiptNo.Text = ": " + .ReceiptID.ToString
                report.xrTelephoneNo.Text = ": " + .TelNo
                report.xrDescOfFrame.Text = ": " + .Frame
                report.xrDescofLense.Text = ": " + .Lense
                report.xrRefractedBy.Text = ": " + .Refracted
                report.xrDispensedBy.Text = ": " + .Dispensed

                report.xrLSPH1.Text = .InL1
                report.xrLSPH2.Text = .InL2
                report.xrLCYL1.Text = .InL3
                report.xrLCYL2.Text = .InL4
                report.xrLAXIS1.Text = .InL5
                report.xrLAXIS2.Text = .InL6

                report.xrRSPH1.Text = .InR1
                report.xrRSPH2.Text = .InR2
                report.xrRCYL1.Text = .InR3
                report.xrRCYL2.Text = .InR4
                report.xrRAXIS1.Text = .InR5
                report.xrRAXIS2.Text = .InR6

                report.xrSegmentSize.Text = ": " + .Segment
                report.xrInsert.Text = ": " + .Insert
                report.xrPD.Text = ": " + .Pd

                report.xrFullAmount.Text = ": " + .Fullamount.ToString("F2")
                report.xrSpecialCharges.Text = ": " + .Specialcharges.ToString("F2")
                report.xrAdvancePaid.Text = ": " + .Advance.ToString("F2")
                report.xrBalance.Text = ": " + (.Fullamount - .Advance).ToString("F2")
                report.xrRemarks.Text = ": " + .Remarks


            End With

            _Transaction.Commit()

            report.CreateDocument()
            report.BringToFront()
            frmPrintPreview.MdiParent = frmMain
            frmPrintPreview.Show()
            frmPrintPreview.BringToFront()
        Catch ex As Exception
            _Transaction.Rollback()
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Doctores"

    Private Sub PopulateDoctors()
        Try
            Dim doctorsDataTable As New DataTable
            doctorsDataTable = DADoctors.GetAllDoctors().Tables(0)

            leRefractedBy.Properties.Items.Clear()

            If (doctorsDataTable.Rows.Count > 0) Then

                For index As Integer = 0 To doctorsDataTable.Rows.Count - 1

                    leRefractedBy.Properties.Items.Add(doctorsDataTable.Rows(index)("DoctorName"))
                Next



            End If




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

            leAttendedBy.Properties.Items.Clear()
            leDispensedBy.Properties.Items.Clear()

            If (employersDataTable.Rows.Count > 0) Then

                For index As Integer = 0 To employersDataTable.Rows.Count - 1

                    leAttendedBy.Properties.Items.Add(employersDataTable.Rows(index)("EmployerName"))
                    leDispensedBy.Properties.Items.Add(employersDataTable.Rows(index)("EmployerName"))

                Next



            End If




        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Populate Listbox"

    Private Sub PopulateListBox()
        Try

            Dim prescriptionDataTable As New DataTable
            prescriptionDataTable = DAPrescription.PrescriptionAll.Tables(0)

            Dim reccount As Int64

            reccount = prescriptionDataTable.Rows.Count

            Dim Totallist(reccount - 1) As Object

            For index As Integer = 0 To reccount - 1
                Totallist(index) = prescriptionDataTable.Rows(index)("PrescriptionID").ToString()
            Next

            'Dim list As ArrayList = New ArrayList()

            'For index As Integer = 0 To reccount - 1
            '    list.Add(prescriptionDataTable.Rows(index)("PrescriptionID").ToString())
            'Next

            lbcSearchList.Items.Clear()
            lbcSearchList.Items.AddRange((Totallist))



        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Editors Events"

    Private Sub cbeLense_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeLense.Enter
        cbeLense.EditValue = "CR39"
    End Sub

    Private Sub dePrescriptionDate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dePrescriptionDate.EditValueChanged
        Me.deDueDate.EditValue = DateAdd(DateInterval.Year, 2, Me.dePrescriptionDate.EditValue)
    End Sub

    Private Sub ceDelivered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceDelivered.CheckedChanged

        If ceDelivered.Checked Then
            lciDelivaryDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            deDelivaryDate.EditValue = Date.Today
        Else
            lciDelivaryDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            deDelivaryDate.EditValue = Nothing

        End If

    End Sub

    Private Sub lbcSearchList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbcSearchList.SelectedIndexChanged
        Try

            If Not String.IsNullOrEmpty((Me.lbcSearchList.SelectedItem)) Then

                Dim PID As Int64
                PID = Convert.ToInt32(Me.lbcSearchList.SelectedItem)
                Me.DisplayRecord(PID)
                Me.sbReceipt.Enabled = True
            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub teSeachID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teSeachID.KeyPress

        Try
            If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
                lbcSearchList.SetSelected(lbcSearchList.FindStringExact(teSeachID.Text), True)
                lbcSearchList.MakeItemVisible(lbcSearchList.FindStringExact(teSeachID.Text))
            End If
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try


    End Sub

    Private Sub lbcSearchList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbcSearchList.Click
        Try

            If Not String.IsNullOrEmpty((Me.lbcSearchList.SelectedItem)) Then

                Dim PID As Int64
                PID = Convert.ToInt32(Me.lbcSearchList.SelectedItem)
                Me.DisplayRecord(PID)
                Me.sbReceipt.Enabled = True
            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Populate Lense/Frames"

    Private Sub PopulateLenseFrames()
        Try

            Me.lupLenseRight.Properties.ValueMember = "StockID"
            Me.lupLenseLeft.Properties.ValueMember = "StockID"

            Me.lupLenseRight.Properties.DisplayMember = "StockCode"
            Me.lupLenseLeft.Properties.DisplayMember = "StockCode"


            Dim dvlense As New DataView(DAStock.GetAllStockItems().Tables(0))
            dvlense.RowFilter = "CategoryName='LENSE'"
            Me.lupLenseRight.Properties.DataSource = dvlense
            Me.lupLenseLeft.Properties.DataSource = dvlense

            Me.LupFrame.Properties.ValueMember = "StockID"
            Me.LupFrame.Properties.DisplayMember = "StockCode"

            Dim dvlense1 As New DataView(DAStock.GetAllStockItems().Tables(0))
            dvlense1.RowFilter = "CategoryName='FRAME'"
            Me.LupFrame.Properties.DataSource = dvlense1



        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

    Private Sub lupLense_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lupLenseRight.EditValueChanged
        Try
            Me.seLensePriceRight.EditValue = FormatNumber(Me.lupLenseRight.GetColumnValue("SalesPrice"), 2)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

    Private Sub LupFrame_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LupFrame.EditValueChanged
        Try
            Me.seFramePrice.EditValue = FormatNumber(Me.lupLenseRight.GetColumnValue("SalesPrice"), 2)
            Me.seFrameQty.EditValue = 1
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub lupLenseLeft_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lupLenseLeft.EditValueChanged
        Try
            Me.seLensePriceLeft.EditValue = FormatNumber(Me.lupLenseLeft.GetColumnValue("SalesPrice"), 2)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
End Class