Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports System
Public Class DAExpenses

#Region "Variables"
    Private _ExpenseID As Int64
    Private _Type As String
    Private _PaymentTypeID As Int64
    Private _ExpenseDate As Date
    Private _Amount As Decimal
    Private _Note As String
    Private _Description As String
    Private _CurrentExpenseID As Int64

    Private _FromDate As Date
    Private _ToDate As Date

#End Region

#Region "Porperties"
    Public Property ExpenseID() As Int64
        Get
            Return _ExpenseID
        End Get
        Set(ByVal value As Int64)
            _ExpenseID = value
        End Set
    End Property
    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property
    Public Property PaymentTypeID() As Int64
        Get
            Return _PaymentTypeID
        End Get
        Set(ByVal value As Int64)
            _PaymentTypeID = Value
        End Set
    End Property
    Public Property ExpenseDate() As Date
        Get
            Return _ExpenseDate
        End Get
        Set(ByVal value As Date)
            _ExpenseDate = value
        End Set
    End Property
    Public Property Amount() As Decimal
        Get
            Return _Amount
        End Get
        Set(ByVal value As Decimal)
            _Amount = value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return _Note
        End Get
        Set(ByVal value As String)
            _Note = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = Value
        End Set
    End Property
    Public Property CurrentExpenseID() As Int64
        Get
            Return _CurrentExpenseID
        End Get
        Set(ByVal value As Int64)
            _CurrentExpenseID = Value
        End Set
    End Property
    Public Property FromDate() As Date
        Get
            Return _FromDate
        End Get
        Set(ByVal value As Date)
            _FromDate = value
        End Set
    End Property
    Public Property ToDate() As Date
        Get
            Return _ToDate
        End Get
        Set(ByVal value As Date)
            _ToDate = value
        End Set
    End Property
#End Region

#Region "Expense Insert"
    Public Sub InsertExpnese(ByVal db As Database, ByVal transaction As DbTransaction)

        Try


            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_EXPENSES_INSERT)

            db.AddInParameter(DBC, "@ExpenseID", DbType.Int64, Me.ExpenseID)
            db.AddInParameter(DBC, "@Type", DbType.String, Me.Type)
            db.AddInParameter(DBC, "@Description", DbType.String, Me.Description)
            db.AddInParameter(DBC, "@PaymentTypeID", DbType.Int64, Me.PaymentTypeID)
            db.AddInParameter(DBC, "@ExpenseDate", DbType.Date, Me.ExpenseDate)
            db.AddInParameter(DBC, "@Amount", DbType.Decimal, Me.Amount)
            db.AddInParameter(DBC, "@Note", DbType.String, Me.Note)
            db.AddOutParameter(DBC, "@CurrentExpenseID", DbType.Int64, 0)
            db.ExecuteNonQuery(DBC, transaction)
            Me.CurrentExpenseID = Convert.ToInt64(db.GetParameterValue(DBC, "@CurrentExpenseID").ToString())

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Expense Delete"
    Public Sub ExpenseDelete()

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_EXPENSES_DELETE)
            db.AddInParameter(DBC, "@ExpenseID", DbType.Int64, Me.ExpenseID)
            db.ExecuteNonQuery(DBC)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Expense GetAll"

    Public Function ExpenseGetByDates() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_EXPENSES_GETALL)
            db.AddInParameter(DBC, "@FromDate", DbType.Date, Me.FromDate)
            db.AddInParameter(DBC, "@ToDate", DbType.Date, Me.ToDate)
            Return db.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

#Region "Get Expense By ExpenseID"
    Public Sub GetExpenseByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_EXPENSE_GETBYID)
        Try

            DB.AddInParameter(DBC, "@ExpenseID", DbType.Int64, Me.ExpenseID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.ExpenseID = Convert.ToInt64(IIf(Not IsDBNull(.Item("ExpenseID")), Trim(.Item("ExpenseID").ToString), String.Empty))
                        Me.Type = IIf(Not IsDBNull(.Item("Type")), Trim(.Item("Type").ToString), String.Empty)
                        Me.Description = IIf(Not IsDBNull(.Item("Description")), Trim(.Item("Description").ToString), String.Empty)
                        Me.PaymentTypeID = Convert.ToInt64(IIf(Not IsDBNull(.Item("PaymentTypeID")), Trim(.Item("PaymentTypeID").ToString), String.Empty))
                        Me.ExpenseDate = (IIf(Not IsDBNull(.Item("ExpenseDate")), Trim(.Item("ExpenseDate")), String.Empty))
                        Me.Amount = IIf(Not IsDBNull(.Item("Amount")), Trim(.Item("Amount").ToString), String.Empty)
                        Me.Note = IIf(Not IsDBNull(.Item("Note")), Trim(.Item("Note").ToString), String.Empty)
                    Loop
                End With

                If (Not DR Is Nothing) Then
                    DR.Close()
                End If


            End Using



        Catch ex As Exception

        Finally
            DBC.Dispose()



        End Try


    End Sub
#End Region

#Region "ExpensTypse Insert"
    Public Sub InsertExpneseTypes()

        Try

            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_EXPENSETYPES_INSERT)
            db.AddInParameter(DBC, "@Description", DbType.String, Me.Description)
            db.ExecuteNonQuery(DBC)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "ExpenseTypes Delete"
    Public Sub ExpenseTypesDelete()

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_EXPENSETYPES_DELETE)
            db.AddInParameter(DBC, "@Description", DbType.String, Me.Description)
            db.ExecuteNonQuery(DBC)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "ExpenseTypes GetAll"
    Public Function ExpenseTypesGetAll() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_EXPENSETYPES_GETALL)

            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try





    End Function
#End Region

End Class
