Imports DA.StartUp.DAStock
Imports DA.StartUp.DASuppliers
Imports DA.Common.DAConstant
Imports DA.Stock.DASales
Imports DA.StartUp.DACustomers
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common
Imports System.Text


Public Class frmLenseStockItems

    Private _DASuppliers As DA.StartUp.DASuppliers


#Region "Constructor"
    Private _DAStock As DA.StartUp.DAStock

    Public ReadOnly Property DAStock() As DA.StartUp.DAStock
        Get

            If _DAStock Is Nothing Then
                _DAStock = New DA.StartUp.DAStock()
            End If

            Return _DAStock
        End Get
    End Property

    Public ReadOnly Property DASuppliers() As DA.StartUp.DASuppliers
        Get

            If _DASuppliers Is Nothing Then
                _DASuppliers = New DA.StartUp.DASuppliers()
            End If

            Return _DASuppliers
        End Get
    End Property

#End Region

    Private Sub cbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGroup.SelectedIndexChanged

        If cbGroup.Text = "HMC" Then
            cbSubGroup.Properties.Items.Add("1.56")
            cbSubGroup.Properties.Items.Add("1.60")
            cbSubGroup.Properties.Items.Add("1.167")
        End If


    End Sub

    Private Sub sbLoadPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbLoadPower.Click

        If dxvpValidation.Validate Then



            Dim dt As New DataTable
            dt.Columns.Add("Power", System.Type.GetType("System.String"))
            dt.Columns.Add("Qty", System.Type.GetType("System.Decimal"))
            dt.Columns.Add("StockCode", System.Type.GetType("System.String"))
            dt.Columns.Add("StockDescription", System.Type.GetType("System.String"))
            dt.Columns.Add("PurchasePrice", System.Type.GetType("System.Decimal"))
            dt.Columns.Add("SalesPrice", System.Type.GetType("System.Decimal"))
            dt.Columns.Add("ReorderLevel", System.Type.GetType("System.Decimal"))
            dt.Columns.Add("SupplierID", System.Type.GetType("System.Int64"))
            dt.Columns.Add("Message", System.Type.GetType("System.String"))

            Dim type, group, subgroup As String

            type = cbType.Text.Trim
            group = cbGroup.Text.Trim
            subgroup = cbSubGroup.Text.Trim

            Dim final As String

            final = "-" + type
            final = final + IIf(group <> String.Empty, "-" + group, String.Empty)
            final = final + IIf(subgroup <> String.Empty, "-" + subgroup, String.Empty)

            Dim first As String
            first = Me.txtValue.Text

            Dim plusminus As String
            plusminus = Me.cmbValue.Text


            dt.Rows.Add("0.25", 0.0, first + plusminus + "0.25" + final, first + plusminus + "0.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("0.50", 0.0, first + plusminus + "0.50" + final, first + plusminus + "0.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("0.75", 0.0, first + plusminus + "0.75" + final, first + plusminus + "0.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("1.00", 0.0, first + plusminus + "1.00" + final, first + plusminus + "1.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("1.25", 0.0, first + plusminus + "1.25" + final, first + plusminus + "1.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("1.50", 0.0, first + plusminus + "1.50" + final, first + plusminus + "1.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("1.75", 0.0, first + plusminus + "1.75" + final, first + plusminus + "1.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("2.00", 0.0, first + plusminus + "2.00" + final, first + plusminus + "2.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("2.25", 0.0, first + plusminus + "2.25" + final, first + plusminus + "2.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("2.50", 0.0, first + plusminus + "2.50" + final, first + plusminus + "2.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("2.75", 0.0, first + plusminus + "2.75" + final, first + plusminus + "2.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("3.00", 0.0, first + plusminus + "3.00" + final, first + plusminus + "3.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("3.25", 0.0, first + plusminus + "3.25" + final, first + plusminus + "3.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("3.50", 0.0, first + plusminus + "3.50" + final, first + plusminus + "3.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("3.75", 0.0, first + plusminus + "3.75" + final, first + plusminus + "3.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("4.00", 0.0, first + plusminus + "4.00" + final, first + plusminus + "4.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("4.25", 0.0, first + plusminus + "4.25" + final, first + plusminus + "4.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("4.50", 0.0, first + plusminus + "4.50" + final, first + plusminus + "4.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("4.75", 0.0, first + plusminus + "4.75" + final, first + plusminus + "4.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("5.00", 0.0, first + plusminus + "5.00" + final, first + plusminus + "5.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("5.25", 0.0, first + plusminus + "5.25" + final, first + plusminus + "5.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("5.50", 0.0, first + plusminus + "5.50" + final, first + plusminus + "5.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("5.75", 0.0, first + plusminus + "5.75" + final, first + plusminus + "5.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("6.00", 0.0, first + plusminus + "6.00" + final, first + plusminus + "6.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("6.25", 0.0, first + plusminus + "6.25" + final, first + plusminus + "6.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("6.50", 0.0, first + plusminus + "6.50" + final, first + plusminus + "6.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("6.75", 0.0, first + plusminus + "6.75" + final, first + plusminus + "6.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("7.00", 0.0, first + plusminus + "7.00" + final, first + plusminus + "7.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("7.25", 0.0, first + plusminus + "7.25" + final, first + plusminus + "7.25" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("7.50", 0.0, first + plusminus + "7.50" + final, first + plusminus + "7.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("7.75", 0.0, first + plusminus + "7.75" + final, first + plusminus + "7.75" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("8.00", 0.0, first + plusminus + "8.00" + final, first + plusminus + "8.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("8.50", 0.0, first + plusminus + "8.50" + final, first + plusminus + "8.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("9.00", 0.0, first + plusminus + "9.00" + final, first + plusminus + "9.00" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("9.50", 0.0, first + plusminus + "9.50" + final, first + plusminus + "9.50" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("10.0", 0.0, first + plusminus + "10.0" + final, first + plusminus + "10.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("11.0", 0.0, first + plusminus + "11.0" + final, first + plusminus + "11.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("12.0", 0.0, first + plusminus + "12.0" + final, first + plusminus + "12.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("13.0", 0.0, first + plusminus + "13.0" + final, first + plusminus + "13.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("14.0", 0.0, first + plusminus + "14.0" + final, first + plusminus + "14.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("15.0", 0.0, first + plusminus + "15.0" + final, first + plusminus + "15.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("16.0", 0.0, first + plusminus + "16.0" + final, first + plusminus + "16.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("17.0", 0.0, first + plusminus + "17.0" + final, first + plusminus + "17.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("18.0", 0.0, first + plusminus + "18.0" + final, first + plusminus + "18.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("19.0", 0.0, first + plusminus + "19.0" + final, first + plusminus + "19.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("20.0", 0.0, first + plusminus + "20.0" + final, first + plusminus + "20.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("21.0", 0.0, first + plusminus + "21.0" + final, first + plusminus + "21.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("22.0", 0.0, first + plusminus + "22.0" + final, first + plusminus + "22.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("23.0", 0.0, first + plusminus + "23.0" + final, first + plusminus + "23.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("24.0", 0.0, first + plusminus + "24.0" + final, first + plusminus + "24.0" + final, 0.0, 0.0, 0.0, 0, "")
            dt.Rows.Add("25.0", 0.0, first + plusminus + "25.0" + final, first + plusminus + "25.0" + final, 0.0, 0.0, 0.0, 0, "")

            gcStockList.DataSource = dt

        End If

    End Sub

    Private Sub frmLenseStockItems_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub sbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbSave.Click
        Try

            If (ValidateData() = String.Empty) Then

                Dim frm As New frmYesNo
                frm.Text = "Ready Save"
                frm.LabelControl1.Text = "Do you want to save these records?"
                frm.LabelControl2.Text = "Click yes to save"

                If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    Me.SaveRecords()
                End If

            Else

                Dim frm As New frmOk
                frm.Text = "Error Exists"
                frm.lblTitle.Text = "Please correct error"
                frm.lblDescription.Text = "Can not save records."
                frm.ShowDialog()

            End If


        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub frmLenseStockItems_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Me.PopulateSupplierLookup()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#Region "Populate Suppliers Lookup"
    Public Sub PopulateSupplierLookup()

        Try
            With rileSupplier
                .DataSource = DASuppliers.GetAllSuppliers.Tables(0)
                .DisplayMember = "Name"
                .ValueMember = "SupplierID"

            End With


        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub risePurchasePrice_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles risePurchasePrice.ButtonClick
        gvStockList.PostEditor()
        Select Case e.Button.Index
            Case 1

                Dim r As Integer

                If IsNumeric(gvStockList.GetFocusedRowCellValue(GridColumn3)) Then
                    For r = 0 To gvStockList.RowCount
                        gvStockList.SetRowCellValue(r, GridColumn3, Convert.ToDecimal(gvStockList.GetFocusedRowCellValue(GridColumn3)))
                    Next
                End If
        End Select
    End Sub

    Private Sub riseSalesPrice_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles riseSalesPrice.ButtonClick
        gvStockList.PostEditor()
        Select Case e.Button.Index
            Case 1

                Dim r As Integer

                If IsNumeric(gvStockList.GetFocusedRowCellValue(GridColumn4)) Then
                    For r = 0 To gvStockList.RowCount
                        gvStockList.SetRowCellValue(r, GridColumn4, Convert.ToDecimal(gvStockList.GetFocusedRowCellValue(GridColumn4)))
                    Next
                End If
        End Select
    End Sub

    Private Sub rileSupplier_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles rileSupplier.ButtonClick
        gvStockList.PostEditor()
        Select Case e.Button.Index
            Case 1

                Dim r As Integer

                If IsNumeric(gvStockList.GetFocusedRowCellValue(GridColumn8)) Then
                    For r = 0 To gvStockList.RowCount
                        gvStockList.SetRowCellValue(r, GridColumn8, Convert.ToInt64(gvStockList.GetFocusedRowCellValue(GridColumn8)))
                    Next
                End If
        End Select
    End Sub

    Private Sub riseReorderLevel_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles riseReorderLevel.ButtonClick
        gvStockList.PostEditor()
        Select Case e.Button.Index
            Case 1

                Dim r As Integer

                If IsNumeric(gvStockList.GetFocusedRowCellValue(GridColumn9)) Then
                    For r = 0 To gvStockList.RowCount
                        gvStockList.SetRowCellValue(r, GridColumn9, Convert.ToDecimal(gvStockList.GetFocusedRowCellValue(GridColumn9)))
                    Next
                End If
        End Select
    End Sub

    Private Sub SaveRecords()


        Dim _Connection As DbConnection = Nothing
        Dim _Transaction As DbTransaction = Nothing

        Try


            Dim _DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            _Connection = _DB.CreateConnection
            _Connection.Open()
            _Transaction = _Connection.BeginTransaction()





            Dim j As Integer



            For j = 0 To gvStockList.RowCount - 1
                With DAStock

                    .StockID = 0
                    .Stock_Code = gvStockList.GetRowCellValue(j, GridColumn6).ToString
                    .Description = gvStockList.GetRowCellValue(j, GridColumn5).ToString
                    .Stock_Category = 3
                    .Purchasing_Price = Convert.ToDecimal(gvStockList.GetRowCellValue(j, GridColumn3).ToString)
                    .Sales_Price = Convert.ToDecimal(gvStockList.GetRowCellValue(j, GridColumn4).ToString)
                    .Supplier = Convert.ToInt64(gvStockList.GetRowCellValue(j, GridColumn8).ToString)
                    .Reorder_Level = Convert.ToDecimal(gvStockList.GetRowCellValue(j, GridColumn9).ToString)
                    .Stock_Balance = gvStockList.GetRowCellValue(j, GridColumn2).ToString
                    .Stock_Value = gvStockList.GetRowCellValue(j, GridColumn2).ToString * Convert.ToDecimal(gvStockList.GetRowCellValue(j, GridColumn3).ToString)
                    .InsertStock(_DB, _Transaction)

                End With

            Next

            _Transaction.Commit()


            Dim frm As New frmSavedOk
            frm.Text = DA_SAVESUCCESS_CONFIRMATION_TITLE
            frm.lblTitle.Text = DA_SAVESUCCESS_CONFIRMATION_TITLELABEL
            frm.lblDescription.Text = DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL
            frm.ShowDialog()

            gcStockList.DataSource = Nothing
       

        Catch ex As Exception
            _Transaction.Rollback()
        Finally
            If _Connection.State = ConnectionState.Open Then
                _Connection.Close()
            End If

        End Try
    End Sub

    Function ValidateData() As String
        Try
            Dim j As Integer

            Dim txt1 As New StringBuilder

            For j = 0 To gvStockList.RowCount - 1

                Dim txt As New StringBuilder

                If (gvStockList.GetRowCellValue(j, GridColumn6)) = String.Empty Then
                    txt.Append("Stock Code Price required. ")
                End If

                If (gvStockList.GetRowCellValue(j, GridColumn3)) = 0 Then
                    txt.Append("Purchase Price required. ")
                End If

                If (gvStockList.GetRowCellValue(j, GridColumn4)) = 0 Then
                    txt.Append("Sales Price required. ")
                End If

                If (gvStockList.GetRowCellValue(j, GridColumn8)) = Nothing Then
                    txt.Append("Supplier required. ")
                End If

                If (IsStockCodeExits(j, GridColumn6)) Then
                    txt.Append("Stock Code already exists. ")
                End If
            

                gvStockList.SetRowCellValue(j, GridColumn7, txt.ToString)

                txt1.Append(txt)

            Next

            Return txt1.ToString


        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Function

    Function IsStockCodeExits(ByVal rowhandle As Integer, ByVal gcol As DevExpress.XtraGrid.Columns.GridColumn) As Boolean
        Try

            DAStock.Stock_Code = gvStockList.GetRowCellValue(rowhandle, gcol)
            If (DAStock.IsStockExists()) Then

                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MessageError(ex.ToString)
        End Try

    End Function

End Class