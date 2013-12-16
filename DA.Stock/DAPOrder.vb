Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports System

Public Class DAPOrder

#Region "Varibles"

    Private _POID As Int64
    Private _SupplierID As Int64
    Private _Date As DateTime
    Private _CMNO As Decimal
    Private _Amount As Decimal
    Private _VAT As Decimal
    Private _BTT As Decimal
    Private _PP As Decimal
    Private _Others As Decimal

#End Region

#Region "Properties"

    Public Property POID() As Int64
        Get
            Return _POID
        End Get
        Set(ByVal value As Int64)
            _POID = value
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

    Public Property PODate() As Date
        Get
            Return _Date
        End Get
        Set(ByVal value As Date)
            _Date = value
        End Set
    End Property

    Public Property CMNO() As Decimal
        Get
            Return _CMNO
        End Get
        Set(ByVal value As Decimal)
            _CMNO = value
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

    Public Property VAT() As Decimal
        Get
            Return _VAT
        End Get
        Set(ByVal value As Decimal)
            _VAT = value
        End Set
    End Property

    Public Property BTT() As Decimal
        Get
            Return _BTT
        End Get
        Set(ByVal value As Decimal)
            _BTT = value
        End Set
    End Property

    Public Property PP() As Decimal
        Get
            Return _PP
        End Get
        Set(ByVal value As Decimal)
            _PP = value
        End Set
    End Property

    Public Property Others() As Decimal
        Get
            Return _Others
        End Get
        Set(ByVal value As Decimal)
            _Others = value
        End Set
    End Property

#End Region

#Region "Insert PurchaseOrder"
    Public Sub InsertPurchaseOrder()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PORDER_INSERT)

            DB.AddInParameter(DBC, "@POID", DbType.Int64, Me.POID)
            DB.AddInParameter(DBC, "@SupplierID", DbType.Int64, Me.SupplierID)
            DB.AddInParameter(DBC, "@Date", DbType.DateTime, Me.PODate)
            DB.AddInParameter(DBC, "@CMNO", DbType.Decimal, Me.CMNO)

            DB.AddInParameter(DBC, "@Amount", DbType.Decimal, Me.Amount)
            DB.AddInParameter(DBC, "@VAT", DbType.Decimal, Me.VAT)
            DB.AddInParameter(DBC, "@BTT", DbType.Decimal, Me.BTT)
            DB.AddInParameter(DBC, "@PP", DbType.Decimal, Me.PP)
            DB.AddInParameter(DBC, "@Others", DbType.Decimal, Me.Others)

            DB.ExecuteNonQuery(DBC)

        Catch ex As Exception
            Throw
        End Try

    End Sub
#End Region

#Region "Get PurchasOrder By PurchaseOrderID"

    Public Sub GetPurchasesOrderByID()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PORDER_GETBYID)
            DB.AddInParameter(DBC, "@POID", DbType.Int64, Me.POID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read

                        Me.SupplierID = Convert.ToInt64(IIf(Not IsDBNull(.Item("SupplierID")), Trim(.Item("SupplierID").ToString), 0))
                        Me.PODate = IIf(Not IsDBNull(.Item("Date")), DateTime.Parse(Trim(.Item("Date").ToString)), String.Empty)
                        Me.CMNO = Convert.ToDecimal(IIf(Not IsDBNull(.Item("CMNO")), Trim(.Item("CMNO").ToString), 0))
                        Me.Amount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Amount")), Trim(.Item("Amount").ToString), 0))
                        Me.VAT = Convert.ToDecimal(IIf(Not IsDBNull(.Item("VAT")), Trim(.Item("VAT").ToString), 0))
                        Me.BTT = Convert.ToDecimal(IIf(Not IsDBNull(.Item("BTT")), Trim(.Item("BTT").ToString), 0))
                        Me.PP = Convert.ToDecimal(IIf(Not IsDBNull(.Item("PP")), Trim(.Item("PP").ToString), 0))
                        Me.Others = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Others")), Trim(.Item("Others").ToString), 0))



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

#Region "GetAll PurchasesOrders"

    Public Function GetAllPurchasesOrders() As DataSet
        Try

            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PORDER_GETALL)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
#End Region

#Region "PurchasesOrder  Delete"

    Public Sub PurchasesOrderDelete()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PORDER_DELETE)
            DB.AddInParameter(DBC, "@POID", DbType.Int64, Me.POID)
            DB.ExecuteNonQuery(DBC)

        Catch ex As Exception


        End Try

    End Sub
#End Region

End Class
