Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant


Public Class DACustomers

#Region "Varaibles"
    Private _CustomerID As Int64
    Private _CustomerName As String
    Private _Address1 As String
    Private _Address2 As String
    Private _City As String
    Private _Telephone As String
    Private _Email As String
    Private _CurrentBalance As Decimal
#End Region

#Region "Properties"
    Public Property CustomerID() As Int64
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int64)
            _CustomerID = value
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            Return _CustomerName
        End Get
        Set(ByVal value As String)
            _CustomerName = value
        End Set
    End Property
    Public Property Address1() As String
        Get
            Return _Address1
        End Get
        Set(ByVal value As String)
            _Address1 = value
        End Set
    End Property
    Public Property Address2() As String
        Get
            Return _Address2
        End Get
        Set(ByVal value As String)
            _Address2 = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            If _City = value Then
                Return
            End If
            _City = value
        End Set
    End Property
    Public Property Telephone() As String
        Get
            Return _Telephone
        End Get
        Set(ByVal value As String)
            _Telephone = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    Public Property CurrentBalance() As Decimal
        Get
            Return _CurrentBalance
        End Get
        Set(ByVal value As Decimal)
            _CurrentBalance = value
        End Set
    End Property
#End Region

#Region "Insert Customers"
    Public Sub InsertCustomers()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_CUSTOMER_INSERT)
            DB.AddInParameter(DBC, "@CustomerID", DbType.Int64, Me.CustomerID)
            DB.AddInParameter(DBC, "@CustomerName", DbType.String, Me.CustomerName)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@City", DbType.String, Me.City)
            DB.AddInParameter(DBC, "@Telephone", DbType.String, Me.Telephone)
            DB.AddInParameter(DBC, "@Email", DbType.String, Me.Email)
            DB.AddInParameter(DBC, "@CurrentBalance", DbType.Decimal, Me.CurrentBalance)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Delete Suppliers"
    Public Sub DeleteCustomer()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_CUSTOMER_DELETE)
            DB.AddInParameter(DBC, "@CustomerID", DbType.Int64, Me.CustomerID)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception

        End Try
               
    End Sub
#End Region

#Region "Get Customer By CustomerID"
    Public Sub GetCustomerByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_CUSTOMER_GETBYID)
        Try

            DB.AddInParameter(DBC, "@CustomerID", DbType.Int64, Me.CustomerID)
            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.CustomerID = Convert.ToInt64(IIf(Not IsDBNull(.Item("CustomerID")), Trim(.Item("CustomerID").ToString), 0))
                        Me.CustomerName = IIf(Not IsDBNull(.Item("CustomerName")), Trim(.Item("CustomerName").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.City = IIf(Not IsDBNull(.Item("City")), Trim(.Item("City").ToString), String.Empty)
                        Me.Telephone = IIf(Not IsDBNull(.Item("Telephone")), Trim(.Item("Telephone").ToString), String.Empty)
                        Me.Email = IIf(Not IsDBNull(.Item("Email")), Trim(.Item("Email").ToString), String.Empty)
                        Me.CurrentBalance = Convert.ToDecimal(IIf(Not IsDBNull(.Item("CurrentBalance")), Trim(.Item("CurrentBalance").ToString), 0))
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

#Region "Get All Customers"
    Public Function GetAllCustomers() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_CUSTOMER_GETALL)
            Return DB.ExecuteDataSet(DBC)
            DBC.Dispose()
        Catch ex As Exception

            Return Nothing
        End Try




    End Function
#End Region


End Class
