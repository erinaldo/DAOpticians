Imports DA.Prescription.DAQuotation
Imports DA.Common.DAConstant

Public Class frmHearingQuotation

#Region "Variables"

    Private _DaHearingQuotation As DA.Prescription.DAHearingQuotation

#End Region

#Region "Constructor"

    Public ReadOnly Property DaHearingQuotation() As DA.Prescription.DAHearingQuotation
        Get

            If _DaHearingQuotation Is Nothing Then
                _DaHearingQuotation = New DA.Prescription.DAHearingQuotation
            End If

            Return _DaHearingQuotation
        End Get
    End Property

#End Region

#Region "Form Event"

    Private Sub frmQuotation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmQuotations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint1)
        Me.HideToolButtonsOnLoad()
        Me.deQuotationDate.EditValue = Date.Today
    End Sub

#End Region

#Region "Bar Button Event"
    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick

        Try
            If dxvpQuotations.Validate Then
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
                    Me.DeleteQuotation(lblID.Text)
                    Me.ClearFormData()
                End If
            End If

            teName.Focus()
        Catch ex As Exception
            Me.ClearFormData()
        End Try




    End Sub

    Private Sub bbPrint1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint1.ItemClick
        Try
            Select Case xTab1.SelectedTabPageIndex
                Case 0
                    If Not Me.lblID.Text = String.Empty Then

                        Me.ShowPrintPreview()

                    End If
                Case 1
                    If gvQuotations.RowCount > 0 Then

                        PrintPreview(gcQuotations, "Quotation Report")
                    Else
                        Exit Sub
                    End If

            End Select
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

#Region "Save Quotation Data"
    Private Sub SaveRecords()
        With DaHearingQuotation

            .HearingQuotationID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
            .QuotationNo = teQuotationNo.Text.Trim
            .CustomerName = teName.EditValue
            .Address1 = teAddress1.EditValue
            .Address2 = teAddress2.EditValue
            .Address3 = teAddress3.EditValue
            .Age = seAge.EditValue
            .QuatationDate = deQuotationDate.EditValue
            .Occupation = teOccupation.EditValue
            .Valid_Days = teValidDays.EditValue

            .Audiogram = cbeAudiogram.EditValue
            .BrandModal = teBrandModal.EditValue
            .BrandModalLeft = teBrandModalLeft.EditValue
            .BrandModalRight = teBrandModalRight.EditValue
            .EarMold = teEarMold.EditValue
            .EarMoldLeft = teEarMoldLeft.EditValue
            .EarMoldRight = teEarMoldRight.EditValue
            .OtherAccessories = teOtherAccessories.EditValue
            .Gaurantee = teGaurantee.EditValue
            .PTALeft = tePTALeft.EditValue
            .PTARight = tePTARight.EditValue

            .Total = seTotalAmount.EditValue
            .Remarks = meNote.EditValue

            .InsertQuotation()

            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            Me.ClearFormData()

        End With

    End Sub
#End Region

#Region "Dispay Record"

    Public Sub DisplayRecord()


        If gvQuotations.RowCount > 0 And Not gvQuotations.IsFilterRow(gvQuotations.FocusedRowHandle) Then
            xTab1.SelectedTabPageIndex = 0
            With DaHearingQuotation
                .HearingQuotationID = Me.gvQuotations.GetFocusedRowCellValue(GridColumn1)
                .QuotationGetByID()
                lblID.Text = .HearingQuotationID
                teQuotationNo.EditValue = .QuotationNo
                teName.EditValue = .CustomerName
                teAddress1.EditValue = .Address1
                teAddress2.EditValue = .Address2
                teAddress3.EditValue = .Address3
                seAge.EditValue = .Age
                deQuotationDate.EditValue = .QuatationDate
                teOccupation.EditValue = .Occupation

                cbeAudiogram.EditValue = .Audiogram
                teBrandModalLeft.EditValue = .BrandModalLeft
                teBrandModalRight.EditValue = .BrandModalRight
                teEarMold.EditValue = .EarMold
                teEarMoldLeft.EditValue = .EarMoldLeft
                teEarMoldRight.EditValue = .EarMoldRight
                teOtherAccessories.EditValue = .OtherAccessories
                teGaurantee.EditValue = .Gaurantee
                tePTALeft.EditValue = .PTALeft
                tePTARight.EditValue = .PTARight

                seTotalAmount.EditValue = .Total
                teValidDays.EditValue = .Valid_Days
                teBrandModal.EditValue = .BrandModal
                meNote.EditValue = .Remarks

            End With
        End If


    End Sub

#End Region

#Region "Clears Form Data"

    Private Sub ClearFormData()
        teQuotationNo.Focus()
        lblID.Text = String.Empty
        teQuotationNo.EditValue = Nothing
        teName.EditValue = Nothing
        teAddress1.EditValue = Nothing
        teAddress2.EditValue = Nothing
        teAddress3.EditValue = Nothing
        seAge.EditValue = 0

        teOccupation.EditValue = Nothing
        teValidDays.EditValue = Nothing
        cbeAudiogram.EditValue = Nothing
        teBrandModal.EditValue = Nothing
        teBrandModalLeft.EditValue = Nothing
        teBrandModalRight.EditValue = Nothing
        teEarMold.EditValue = Nothing
        teEarMoldLeft.EditValue = Nothing
        teEarMoldRight.EditValue = Nothing
        teOtherAccessories.EditValue = Nothing
        teGaurantee.EditValue = Nothing
        tePTALeft.EditValue = Nothing
        tePTARight.EditValue = Nothing

        seTotalAmount.EditValue = 0
        teGaurantee.EditValue = Nothing
        ' tePrescription.EditValue = Nothing
        meNote.EditValue = Nothing

    End Sub

#End Region

#Region "Delete Quotation"
    Private Sub DeleteQuotation(ByVal strQuotation As String)
        With DaHearingQuotation
            .QuotationNo = strQuotation
            .DeleteQuotation()
        End With


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

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            gcQuotations.DataSource = DaHearingQuotation.GetAllQuotations().Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Tab Control Events"

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xTab1.SelectedPageChanged
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

    Private Sub gvQuotations_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvQuotations.DoubleClick
        Try
            Me.DisplayRecord()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Sub

#End Region

#Region "Show Print Preview"

    Private Sub ShowPrintPreview()
        Try
            Dim report As New xrHearingQuotation
            frmPrintPreview.PrintControl1.PrintingSystem = report.PrintingSystem


            Dim _DACompany As New DA.StartUp.DACompany
            _DACompany.GetCompany()

            report.xrCompanyName.Text = _DACompany.CompanyName

            With DaHearingQuotation
                .HearingQuotationID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .QuotationGetByID()
                report.xrlName.Text = ": " + .CustomerName
                report.xrlAddress1.Text = ": " + .Address1
                report.xrlAddress2.Text = ": " + .Address2
                report.xrlAddress3.Text = ": " + .Address3
                report.xrlOccupation.Text = ": " + .Occupation
                report.xrlAge.Text = ": " + .Age.ToString()
                report.xrlQuotationDate.Text = ": " + .QuatationDate.ToString("dd-MMM-yy")
                report.xrlDay.Text = .Valid_Days
                report.xrlCurrentDate.Text = ": " + Date.Today.ToString("dd-MMM-yy")

                report.xrlAudiogram.Text = ": " + .Audiogram

                report.xrtBranModal.Text = .BrandModal
                report.xrtBrandLeft.Text = .BrandModalLeft
                report.xrtBrandRight.Text = .BrandModalRight

                report.xrtEarMold.Text = .EarMold
                report.xrtEarLeft.Text = .EarMoldLeft
                report.xrtEarRight.Text = .EarMoldRight

                report.xrtPTALeft.Text = .PTALeft
                report.xrtPTARight.Text = .PTARight


                report.xrlOtherAccessories.Text = ": " + .OtherAccessories
                report.xrlGaurantee.Text = ": " + .Gaurantee
                report.xrlTotalAmount.Text = ": " + .Total.ToString("F")



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




End Class