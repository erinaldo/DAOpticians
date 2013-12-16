Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports System
Public Class DAPurchaseOrder

#Region "Variables"
    Private _PurchaseOrderID As Int64
    Private _CurrentPurchaseOrderID As Int64
    Private _SupplierID As Int64
    Private _ReferenceNo As String
    Private _PurchaseOrderDate As Date
    Private _Note As String

    Private _StockID As Int64
    Private _RequiredQuantity As Decimal




#End Region

#Region "Properties"
    Public Property PurchaseOrderID() As Int64
        Get
            Return _PurchaseOrderID
        End Get
        Set(ByVal value As Int64)
            _PurchaseOrderID = value
        End Set
    End Property
    Public Property CurrentPurchaseOrderID() As Int64
        Get
            Return _CurrentPurchaseOrderID
        End Get
        Set(ByVal value As Int64)
            _CurrentPurchaseOrderID = Value
        End Set
    End Property
    Public Property SupplierID() As Int64
        Get
            Return _SupplierID
        End Get
        Set(ByVal value As Int64)
            _SupplierID = value
        End Set
    End Property
    Public Property ReferenceNo() As String
        Get
            Return _ReferenceNo
        End Get
        Set(ByVal value As String)
            _ReferenceNo = value
        End Set
    End Property
    Public Property PurchaseOrderDate() As Date
        Get
            Return _PurchaseOrderDate
        End Get
        Set(ByVal value As Date)
            _PurchaseOrderDate = value
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

    Public Property StockID() As Int64
        Get
            Return _StockID
        End Get
        Set(ByVal value As Int64)
            _StockID = value
        End Set
    End Property
    Public Property RequiredQuantity() As Decimal
        Get
            Return _RequiredQuantity
        End Get
        Set(ByVal value As Decimal)
            _RequiredQuantity = Value
        End Set
    End Property

#End Region

#Region "Insert PurchaseOrder"
    Public Sub InsertPurchaseOrder(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PURCHASEORDER_INSERT)
            db.AddInParameter(DBC, "@PurchaseOrderID", DbType.Int64, Me.PurchaseOrderID)
            db.AddInParameter(DBC, "@SupplierID", DbType.Int64, Me.SupplierID)
            db.AddInParameter(DBC, "@ReferenceNo", DbType.String, Me.ReferenceNo)
            db.AddInParameter(DBC, "@PurchaseOrderDate", DbType.DateTime, Me.PurchaseOrderDate)
            db.AddInParameter(DBC, "@Note", DbType.String, Me.Note)
            db.AddOutParameter(DBC, "@CurrentPurchaseOrderID", DbType.Int64, 0)

            db.ExecuteNonQuery(DBC, transaction)

            Me.CurrentPurchaseOrderID = Convert.ToInt64(db.GetParameterValue(DBC, "@CurrentPurchaseOrderID").ToString())
        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Insert PurchaseOrder Description"
    Public Sub InsertPurchaseOrderDescription(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PURCHASEORDERDESCRIPTION_INSERT)
            db.AddInParameter(DBC, "@PurchaseOrderID", DbType.Int64, Me.PurchaseOrderID)
            db.AddInParameter(DBC, "@StockID", DbType.Int64, Me.StockID)
            db.AddInParameter(DBC, "@RequiredQuantity", DbType.Decimal, Me.RequiredQuantity)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Get PurchasOrder By PurchaseOrderID"
    Public Sub GetPurchasesOrderByID()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PURCHASEORDER_GETBYID)
            DB.AddInParameter(DBC, "@PurchaseOrderID", DbType.Int64, Me.PurchaseOrderID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read

                        Me.SupplierID = Convert.ToInt64(IIf(Not IsDBNull(.Item("SupplierID")), Trim(.Item("SupplierID").ToString), 0))
                        Me.ReferenceNo = IIf(Not IsDBNull(.Item("ReferenceNo")), Trim(.Item("ReferenceNo").ToString), String.Empty)
                        Me.PurchaseOrderDate = IIf(Not IsDBNull(.Item("PurchaseOrderDate")), DateTime.Parse(Trim(.Item("PurchaseOrderDate").ToString)), String.Empty)
                        Me.Note = IIf(Not IsDBNull(.Item("Note")), Trim(.Item("Note").ToString), String.Empty)


                    Loop
                End With

                If (Not DR Is Nothing) Then
                    DR.Close()
                End If


            End Using

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Get PurchaseOrderDescription By PurchaseID"
    Public Function GetPurchaseOrderDescriptionByID() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PURCHASEORDERDESCRIPTION_GETBYID)
            DB.AddInParameter(DBC, "@PurchaseOrderID", DbType.Int64, Me.PurchaseOrderID)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region

#Region "GetAll PurchasesOrders"
    Public Function GetAllPurchasesOrders() As DataSet
        Try

            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PURCHASEORDER_GETALL)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
#End Region

#Region "PurchasesOrder Description Delete"
    Public Sub PurchasesOrderDescriptionDelete(ByVal db As Database, ByVal transaction As DbTransaction)

        Try
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PURCHASEORDERDESCRIPTION_DELETE)
            db.AddInParameter(DBC, "@PurchaseOrderID", DbType.Int64, Me.PurchaseOrderID)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception


        End Try

    End Sub
#End Region

End Class
