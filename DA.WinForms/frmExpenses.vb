Imports DA.Collections.DAExpenses
Imports DA.Collections.DACollections
Imports DA.Common.DAConstant
Imports DA.Common
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common


Public Class frmExpenses

#Region "Variables"
    Private _DAExpense As DA.Collections.DAExpenses
    Private _DACollection As DA.Collections.DACollections
    Dim _DAEnums As DA.Common.DAEnums
#End Region

#Region "Constructors"
    
    Public ReadOnly Property DAExpense() As DA.Collections.DAExpenses
        Get

            If _DAExpense Is Nothing Then
                _DAExpense = New DA.Collections.DAExpenses()
            End If

            Return _DAExpense
        End Get
    End Property
    Public ReadOnly Property DAEnums() As DA.Common.DAEnums
        Get

            If _DAEnums Is Nothing Then
                _DAEnums = New DA.Common.DAEnums()
            End If

            Return _DAEnums
        End Get
    End Property

    
    Public ReadOnly Property DACollection() As DA.Collections.DACollections
        Get

            If _DACollection Is Nothing Then
                _DACollection = New DA.Collections.DACollections
            End If

            Return _DACollection
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frmExpenses_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
        Me.PopulateExpenseTypesLookup()
        Me.deDate.EditValue = Date.Today
        Me.deFrom.EditValue = Date.Today
        Me.deTo.EditValue = Date.Today

    End Sub
#End Region

#Region "Bar Button Events"

    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNew.ItemClick
        Me.ClearFormData()
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
     
        If dxvpExpenses.Validate Then
            If lblID.Text = String.Empty Then
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
            Me.ClearFormData()
        End If
    End Sub

    Private Sub bbRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefresh.ItemClick
        With gvExpenses
            .ClearColumnsFilter()
            .ClearGrouping()
            .ClearSelection()
            .ClearSorting()
        End With
    End Sub

    Private Sub bbDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick

        If Not lblID.Text = String.Empty Then
            Dim f As New frmYesNo
            f.LabelControl1.Text = "It is not recormended to delete the selected record?"
            f.LabelControl2.ForeColor = Color.Red
            f.LabelControl2.Text = "Click Yes to Delete..."


            f.Text = "Delete The Current Record ?"

            If f.ShowDialog = Windows.Forms.DialogResult.Yes Then

                Me.DeleteExpenses(lblID.Text)
                Me.ClearFormData()
            End If
        End If

        lupExpenseType.Focus()

    End Sub

    Private Sub bbDisplaySelected_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDisplaySelected.ItemClick
        Me.DisplayExpense()
    End Sub

    Private Sub bbPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrint.ItemClick
        Try
            If (gvExpenses.RowCount) > 0 Then

                PrintPreview(gcExpenses, "Expenses Report")
            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
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
        Select Case e.Page.TabControl.SelectedTabPageIndex
            Case 0
                Me.ShowToolButtonsOnNewRecordTabChange()
            Case 1
                Me.ShowToolButtonsOnHistoryTabChange()
                Me.PopulateGrid()


        End Select

    End Sub
#End Region

#Region "Clear Form Data"
    Private Sub ClearFormData()

        Me.txtDescription.EditValue = Nothing
        Me.seAmount.EditValue = 0
        Me.meNote.EditValue = String.Empty
        Me.lblID.Text = String.Empty
        Me.lupExpenseType.Focus()

    End Sub
#End Region

#Region "Populate ExpenseTypes Lookup"
    Public Sub PopulateExpenseTypesLookup()

        Try
            With lupExpenseType
                .Properties.DataSource = DAExpense.ExpenseTypesGetAll().Tables(0)
                .Properties.DisplayMember = "Description"
                .Properties.ValueMember = "ExpenseTypeID"

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Lookup Events"
    Private Sub lupExpenseType_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lupExpenseType.ButtonClick
        Select Case e.Button.Index
            Case 1
                If Not Me.lupExpenseType.Text = String.Empty Then
                    Me.SaveExpenseType()
                    Me.PopulateExpenseTypesLookup()
                End If

            Case 2
                If Not Me.lupExpenseType.Text = String.Empty Then
                    Dim f As New frmYesNo
                    f.LabelControl1.Text = "It is not recormended to delete the selected record?"
                    f.LabelControl2.ForeColor = Color.Red
                    f.LabelControl2.Text = "Click Yes to Delete..."
                    f.Text = "Delete The Current Record ?"

                    If f.ShowDialog = Windows.Forms.DialogResult.Yes Then
                        Me.DeleteExpenseType()
                        Me.PopulateExpenseTypesLookup()
                    End If
                End If



        End Select

    End Sub
#End Region

#Region "Save Expenses"
    Private Sub SaveRecords()

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try

            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            With DAExpense
                .ExpenseID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .Type = Me.cbeType.EditValue
                .Description = Me.txtDescription.EditValue
                Select Case cbePaymentType.SelectedIndex
                    Case 0
                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                    Case 1
                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                    Case 2
                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD
                End Select

                .ExpenseDate = Me.deDate.EditValue
                .Amount = Me.seAmount.EditValue
                .Note = Me.meNote.EditValue
                .InsertExpnese(_DB, _Transaction)

                With DACollection
                    .SystemID = DAExpense.CurrentExpenseID

                    If Me.cbeType.EditValue = "OTHER INCOME" Then
                        .TransactionTypeID = Common.DAEnums.EnumTransactionTypes.OTHERINCOME

                    ElseIf Me.cbeType.EditValue = "EXPENSE" Then
                        .TransactionTypeID = Common.DAEnums.EnumTransactionTypes.EXPENSES

                    End If


               
                    Select Case Me.cbePaymentType.SelectedIndex
                        Case 0
                            .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                        Case 1
                            .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                        Case 2
                            .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD
                    End Select

                    .Date = Date.Now
                    .Reference = String.Empty
                    .Amount = Me.seAmount.EditValue
                    .InsertCollection(_DB, _Transaction)

                End With
                _Transaction.Commit()

                Dim frm As New frmSavedOk
                frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                frm.ShowDialog()

                Me.ClearFormData()

            End With
        Catch ex As Exception
            _Transaction.Rollback()
        End Try

    End Sub
#End Region

#Region "Update Expenses"
    Private Sub UpdateRecords()

        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try

            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()

            With DAExpense
                .ExpenseID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                .Type = Me.cbeType.EditValue
                .Description = Me.txtDescription.EditValue

                Select Case cbePaymentType.SelectedIndex
                    Case 0
                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                    Case 1
                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                    Case 2
                        .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD
                End Select

                .ExpenseDate = Me.deDate.EditValue
                .Amount = Me.seAmount.EditValue
                .Note = Me.meNote.EditValue
                .InsertExpnese(_DB, _Transaction)



                With DACollection

                    .SystemID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                    .TransactionTypeID = DAEnums.EnumTransactionTypes.EXPENSES
                    .CollectionDelete(_DB, _Transaction)

                    .SystemID = Convert.ToInt64(IIf(lblID.Text = String.Empty, 0, lblID.Text))
                    If Me.cbeType.EditValue = "OTHER INCOME" Then
                        .TransactionTypeID = Common.DAEnums.EnumTransactionTypes.OTHERINCOME

                    ElseIf Me.cbeType.EditValue = "EXPENSE" Then
                        .TransactionTypeID = Common.DAEnums.EnumTransactionTypes.EXPENSES

                    End If


                    Select Case Me.cbePaymentType.SelectedIndex
                        Case 0
                            .PaymentTypeID = DAEnums.EnumPaymentTypes.CASH
                        Case 1
                            .PaymentTypeID = DAEnums.EnumPaymentTypes.CHECK
                        Case 2
                            .PaymentTypeID = DAEnums.EnumPaymentTypes.CCARD
                    End Select

                    .Date = Date.Now
                    .Reference = String.Empty
                    .Amount = Me.seAmount.EditValue
                    .InsertCollection(_DB, _Transaction)

                End With
                _Transaction.Commit()

                Dim frm As New frmSavedOk
                frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
                frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
                frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
                frm.ShowDialog()

                Me.ClearFormData()
            End With
        Catch ex As Exception
            _Transaction.Rollback()
        End Try

    End Sub
#End Region

#Region "Save Expense Type"
    Private Sub SaveExpenseType()
        Try
            With DAExpense
                .Description = Me.lupExpenseType.Text
                .InsertExpneseTypes()

            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Delete Expense Type"
    Private Sub DeleteExpenseType()
        Try
            With DAExpense
                .Description = Me.lupExpenseType.Text
                .ExpenseTypesDelete()
            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Populate Grid"
    Public Sub PopulateGrid()
        Try
            DAExpense.FromDate = Me.deFrom.EditValue
            DAExpense.ToDate = Me.deTo.EditValue
            gcExpenses.DataSource = DAExpense.ExpenseGetByDates().Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Delete Expenses"
    Private Sub DeleteExpenses(ByVal ExpenseID As Int64)
        With DAExpense
            .ExpenseID = ExpenseID
            .ExpenseDelete()
        End With


    End Sub
#End Region

#Region "Display Expense"
    Public Sub DisplayExpense()

        If gvExpenses.RowCount > 0 Then


            xTab1.SelectedTabPageIndex = 0
            With DAExpense
                .ExpenseID = gvExpenses.GetFocusedRowCellValue(GridColumn1)
                .GetExpenseByID()
                lblID.Text = .ExpenseID
                cbeType.EditValue = .Type
                txtDescription.EditValue = .Description

                Select Case .PaymentTypeID
                    Case 1
                        cbePaymentType.SelectedIndex = 0
                    Case 2
                        cbePaymentType.SelectedIndex = 1
                    Case 3
                        cbePaymentType.SelectedIndex = 2


                End Select

                deDate.EditValue = .ExpenseDate
                seAmount.EditValue = .Amount
                meNote.EditValue = .Note


            End With
        End If

    End Sub
#End Region

#Region "Grid Events"
    Private Sub gvExpenses_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvExpenses.DoubleClick
        Me.DisplayExpense()
    End Sub
#End Region

#Region "Button Events"

    Private Sub sbProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbProcess.Click
        Try
            Me.PopulateGrid()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

End Class