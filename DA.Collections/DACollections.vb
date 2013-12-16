Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports System
Public Class DACollections

#Region "Variables"
    Private _CollectionID As Int64
    Private _SystemID As Int64
    Private _TransactionTypeID As Int64
    Private _PaymentTypeID As Int64
    Private _Date As DateTime
    Private _Reference As String
    Private _Amount As Decimal
    Private _ReferenceDate As DateTime
    Private _Bank As String
    Private _FromDate As Date
    Private _ToDate As Date
    Private _PurchaseID As Int64
    Private _Remarks As String


#End Region

#Region "Properties"
    Public Property CollectionID() As Int64
        Get
            Return _CollectionID
        End Get
        Set(ByVal value As Int64)
            _CollectionID = value
        End Set
    End Property
    Public Property SystemID() As Int64
        Get
            Return _SystemID
        End Get
        Set(ByVal value As Int64)
            _SystemID = value
        End Set
    End Property
    Public Property TransactionTypeID() As Int64
        Get
            Return _TransactionTypeID
        End Get
        Set(ByVal value As Int64)
            _TransactionTypeID = value
        End Set
    End Property
    Public Property PaymentTypeID() As Int64
        Get
            Return _PaymentTypeID
        End Get
        Set(ByVal value As Int64)
            _PaymentTypeID = value
        End Set
    End Property
    Public Property [Date]() As DateTime
        Get
            Return _Date
        End Get
        Set(ByVal value As DateTime)
            _Date = value
        End Set
    End Property
    Public Property Reference() As String
        Get
            Return _Reference
        End Get
        Set(ByVal value As String)
            _Reference = value
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
    Public Property ReferenceDate() As DateTime
        Get
            Return _ReferenceDate
        End Get
        Set(ByVal value As DateTime)
            _ReferenceDate = value
        End Set
    End Property
    Public Property Bank() As String
        Get
            Return _Bank
        End Get
        Set(ByVal value As String)
            _Bank = value
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
    Public Property PurchaseID() As Int64
        Get
            Return _PurchaseID
        End Get
        Set(ByVal value As Int64)
            _PurchaseID = value
        End Set
    End Property
    Public Property Remarks() As String
        Get
            Return _Remarks
        End Get
        Set(ByVal value As String)
            _Remarks = value
        End Set
    End Property
#End Region

#Region "Collection Insert"
    Public Sub InsertCollection(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_COLLECTION_INSERT)

            db.AddInParameter(DBC, "@SystemID", DbType.Int64, Me.SystemID)
            db.AddInParameter(DBC, "@TransactionTypeID", DbType.Int64, Me.TransactionTypeID)
            db.AddInParameter(DBC, "@PaymentTypeID", DbType.Int64, Me.PaymentTypeID)
            db.AddInParameter(DBC, "@Date", DbType.DateTime, Me.Date)
            db.AddInParameter(DBC, "@Reference", DbType.String, Me.Reference)
            db.AddInParameter(DBC, "@Amount", DbType.Decimal, Me.Amount)

            If (Me.ReferenceDate = DateTime.MinValue) Then
                db.AddInParameter(DBC, "@ReferenceDate", DbType.DateTime, Nothing)

            Else
                db.AddInParameter(DBC, "@ReferenceDate", DbType.DateTime, Me.ReferenceDate)

            End If

            db.AddInParameter(DBC, "@Bank", DbType.String, Me.Bank)

            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception



        End Try

    End Sub
#End Region

#Region "Collection Delete"
    Public Sub CollectionDelete(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_COLLECTION_DELETE)

            db.AddInParameter(DBC, "@SystemID", DbType.Int64, Me.SystemID)
            db.AddInParameter(DBC, "@TransactionTypeID", DbType.Int64, Me.TransactionTypeID)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Collection GetByID"
    Public Function CollectionGetByID() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_COLLECTION_GETBYID)
            db.AddInParameter(DBC, "@SystemID", DbType.Int64, Me.SystemID)
            db.AddInParameter(DBC, "@TransactionTypeID", DbType.Int64, Me.TransactionTypeID)

            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try





    End Function
#End Region

#Region "Collection GetByID"
    Public Function CollectionGetByID(ByVal DB As Database, ByVal transaction As DbTransaction) As DataSet

        Try

            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_COLLECTION_GETBYID)
            DB.AddInParameter(DBC, "@SystemID", DbType.Int64, Me.SystemID)
            DB.AddInParameter(DBC, "@TransactionTypeID", DbType.Int64, Me.TransactionTypeID)

            Return DB.ExecuteDataSet(DBC, transaction)
        Catch ex As Exception
            Return Nothing

        End Try





    End Function
#End Region

#Region "Collection Get All"
    Public Function CollectionGetAll() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_COLLECTION_GETALL)


            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try





    End Function
#End Region

#Region "Day book get by dates"

    Public Function DayBookGetBydates() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_DAYBOOK_GETBYDATES)
            db.AddInParameter(DBC, "@FromDate", DbType.Date, Me.FromDate)
            db.AddInParameter(DBC, "@ToDate", DbType.Date, Me.ToDate)
            Return db.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing

        End Try





    End Function
#End Region

#Region "Collection Invoice Insert"
    Public Sub InsertInvoiceCollection(ByVal db As Database, ByVal transaction As DbTransaction)



        Dim DBC As DbCommand = db.GetStoredProcCommand("CollectionInvoiceInsert")

        db.AddInParameter(DBC, "@CollectionID", DbType.Int64, Me.CollectionID)
        db.AddInParameter(DBC, "@PurchaseID", DbType.Int64, Me.PurchaseID)

        db.ExecuteNonQuery(DBC, transaction)



    End Sub
#End Region

#Region "Collection Insert new"
    Public Sub InsertCollectionNew(ByVal db As Database, ByVal transaction As DbTransaction)


        Dim DBC As DbCommand = db.GetStoredProcCommand("Collection_Insert_New")

        db.AddInParameter(DBC, "@SystemID", DbType.Int64, Me.SystemID)
        db.AddInParameter(DBC, "@TransactionTypeID", DbType.Int64, Me.TransactionTypeID)
        db.AddInParameter(DBC, "@PaymentTypeID", DbType.Int64, Me.PaymentTypeID)
        db.AddInParameter(DBC, "@Date", DbType.DateTime, Me.Date)
        db.AddInParameter(DBC, "@Reference", DbType.String, Me.Reference)
        db.AddInParameter(DBC, "@Amount", DbType.Decimal, Me.Amount)

        If (Me.ReferenceDate = DateTime.MinValue) Then
            db.AddInParameter(DBC, "@ReferenceDate", DbType.DateTime, Nothing)

        Else
            db.AddInParameter(DBC, "@ReferenceDate", DbType.DateTime, Me.ReferenceDate)

        End If

        db.AddInParameter(DBC, "@Bank", DbType.String, Me.Bank)
        db.AddInParameter(DBC, "@Remarks", DbType.String, Me.Remarks)

        db.AddOutParameter(DBC, "@CollectionID", DbType.Int64, 8)
        db.ExecuteNonQuery(DBC, transaction)
        Me.CollectionID = Convert.ToInt64(db.GetParameterValue(DBC, "@CollectionID").ToString())



    End Sub
#End Region

#Region "Collection Delete ID"
    Public Sub CollectionDeleteID()

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand("Collection_DeleteByID")
            db.AddInParameter(DBC, "@CollectionID", DbType.Int64, Me.CollectionID)

            db.ExecuteNonQuery(DBC)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Collection GetByCollectionID"
    Public Function CollectionGetByCollectionID() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)

            Dim DBC As DbCommand = DB.GetStoredProcCommand("Collection_GetByCollectionID")
            DB.AddInParameter(DBC, "@CollectionID", DbType.Int64, Me.CollectionID)

            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try





    End Function
#End Region

End Class
