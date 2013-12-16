Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors


Public Class DASuppliers

#Region "Variables"
    Private _Supplier_ID As Int64
    Private _Name As String
    Private _Inactive As Boolean
    Private _Contact_Person As String
    Private _Address1 As String
    Private _Address2 As String
    Private _Address3 As String
    Private _Telephone As String
    Private _Fax As String
    Private _Email As String
    Private _Web_URL As String
    Private _Note As String
    Private _OpeningBalance As Decimal



#End Region

#Region "Properties"

    Public Property Supplier_ID() As Int64
        Get
            Return _Supplier_ID
        End Get
        Set(ByVal value As Int64)
            _Supplier_ID = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Public Property Inactive() As Boolean
        Get
            Return _Inactive
        End Get
        Set(ByVal value As Boolean)
            If _Inactive = Value Then
                Return
            End If
            _Inactive = Value
        End Set
    End Property
    Public Property Contact_Person() As String
        Get
            Return _Contact_Person
        End Get
        Set(ByVal value As String)
            If _Contact_Person = Value Then
                Return
            End If
            _Contact_Person = Value
        End Set
    End Property
    Public Property Address1() As String
        Get
            Return _Address1
        End Get
        Set(ByVal value As String)
            If _Address1 = Value Then
                Return
            End If
            _Address1 = Value
        End Set
    End Property
    Public Property Address2() As String
        Get
            Return _Address2
        End Get
        Set(ByVal value As String)
            _Address2 = Value
        End Set
    End Property
    Public Property Address3() As String
        Get
            Return _Address3
        End Get
        Set(ByVal value As String)
            _Address3 = value
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
    Public Property Fax() As String
        Get
            Return _Fax
        End Get
        Set(ByVal value As String)
            If _Fax = Value Then
                Return
            End If
            _Fax = Value
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
    Public Property Web_URL() As String
        Get
            Return _Web_URL
        End Get
        Set(ByVal value As String)
            _Web_URL = value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return _Note
        End Get
        Set(ByVal value As String)
            _Note = Value
        End Set
    End Property
    Public Property OpeningBalance() As Decimal
        Get
            Return _OpeningBalance
        End Get
        Set(ByVal value As Decimal)
            _OpeningBalance = Value
        End Set
    End Property
  
#End Region

#Region "Insert Suppliers"
    Public Sub InsertSupplier()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_SUPPLIER_INSERT)
            DB.AddInParameter(DBC, "@SupplierId", DbType.Int64, Me.Supplier_ID)
            DB.AddInParameter(DBC, "@Name", DbType.String, Me.Name)
            DB.AddInParameter(DBC, "@Contact_Person", DbType.String, Me.Contact_Person)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@Address3", DbType.String, Me.Address3)
            DB.AddInParameter(DBC, "@Telephone", DbType.String, Me.Telephone)
            DB.AddInParameter(DBC, "@Fax", DbType.String, Me.Fax)
            DB.AddInParameter(DBC, "@Email", DbType.String, Me.Email)
            DB.AddInParameter(DBC, "@Web_URL", DbType.String, Me.Web_URL)
            DB.AddInParameter(DBC, "@Note", DbType.String, Me.Note)
            DB.AddInParameter(DBC, "@OpeningBalance", DbType.Decimal, Me.OpeningBalance)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception




        End Try

    End Sub

#End Region

#Region "Delete Suppliers"
    Public Sub DeleteSupplier()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_SUPPLIER_DELETE)
            DB.AddInParameter(DBC, "@SupplierID", DbType.Int64, Me.Supplier_ID)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception
            
        End Try
       
    End Sub
#End Region

#Region "Get Suppliers By Supplier ID"
    Public Sub GetSupplierByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_SUPPLIER_GETBYID)
        Try

            DB.AddInParameter(DBC, "@SupplierID", DbType.Int64, Me.Supplier_ID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.Supplier_ID = IIf(Not IsDBNull(.Item("SupplierID")), Trim(.Item("SupplierID").ToString), String.Empty)
                        Me.Name = IIf(Not IsDBNull(.Item("Name")), Trim(.Item("Name").ToString), String.Empty)
                        Me.Contact_Person = IIf(Not IsDBNull(.Item("ContactPerson")), Trim(.Item("ContactPerson").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.Address3 = IIf(Not IsDBNull(.Item("Address3")), Trim(.Item("Address3").ToString), String.Empty)
                        Me.Telephone = IIf(Not IsDBNull(.Item("Telephone")), Trim(.Item("Telephone").ToString), String.Empty)
                        Me.Fax = IIf(Not IsDBNull(.Item("Fax")), Trim(.Item("Fax").ToString), String.Empty)
                        Me.Email = IIf(Not IsDBNull(.Item("Email")), Trim(.Item("Email").ToString), String.Empty)
                        Me.Web_URL = IIf(Not IsDBNull(.Item("WebURL")), Trim(.Item("WebURL").ToString), String.Empty)
                        Me.Note = IIf(Not IsDBNull(.Item("Note")), Trim(.Item("Note").ToString), String.Empty)
                        Me.OpeningBalance = Convert.ToDecimal(IIf(Not IsDBNull(.Item("OpeningBalance")), Trim(.Item("OpeningBalance").ToString), 0.0))
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

#Region "Get All Suppliers"
    Public Function GetAllSuppliers() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_SUPLLIER_GETALL)
            Return DB.ExecuteDataSet(DBC)
            DBC.Dispose()
        Catch ex As Exception

            Return Nothing
        End Try




    End Function
#End Region

 
End Class
