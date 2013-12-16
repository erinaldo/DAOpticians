Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors

Public Class DAEmployers

#Region "Variables"
    Private _Employer_ID As Int64
    Private _Employer_Name As String
    Private _Address1 As String
    Private _Address2 As String
    Private _City As String
    Private _Designation As String
    Private _NIC As String
    Private _Telephone As String
    Private _DesignationName As String
    Private _DesignationID As Int64


#End Region

#Region "Properties"
    Public Property Employer_ID() As Int64
        Get
            Return _Employer_ID
        End Get
        Set(ByVal value As Int64)
            _Employer_ID = value
        End Set
    End Property
    Public Property Employer_Name() As String
        Get
            Return _Employer_Name
        End Get
        Set(ByVal value As String)
            _Employer_Name = value
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
            _City = value
        End Set
    End Property
    Public Property Designation() As String
        Get
            Return _Designation
        End Get
        Set(ByVal value As String)
            _Designation = value
        End Set
    End Property
    Public Property NIC() As String
        Get
            Return _NIC
        End Get
        Set(ByVal value As String)
            _NIC = value
        End Set
    End Property
    Public Property Telephone() As String
        Get
            Return _Telephone
        End Get
        Set(ByVal value As String)
            _Telephone = Value
        End Set
    End Property

    Public Property DesignationName() As String
        Get
            Return _DesignationName
        End Get
        Set(ByVal value As String)
            _DesignationName = Value
        End Set
    End Property

    Public Property DesignationID() As Int64
        Get
            Return _DesignationID
        End Get
        Set(ByVal value As Int64)
            _DesignationID = Value
        End Set
    End Property
#End Region

#Region "Insert Employer"
    Public Sub InsertEmployer()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_EMPLOYER_INSERT)
            DB.AddInParameter(DBC, "@Employer_ID", DbType.Int64, Me.Employer_ID)
            DB.AddInParameter(DBC, "@Employer_Name", DbType.String, Me.Employer_Name)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@City", DbType.String, Me.City)
            DB.AddInParameter(DBC, "@Designation", DbType.String, Me.Designation)
            DB.AddInParameter(DBC, "@NIC_No", DbType.String, Me.NIC)
            DB.AddInParameter(DBC, "@Telephone", DbType.String, Me.Telephone)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception




        End Try
    End Sub
#End Region

#Region "Delete Employers"
    Public Sub DeleteEmployer()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_EMPLOYER_DELETE)
        DB.AddInParameter(DBC, "@Employer_ID", DbType.Int64, Me.Employer_ID)
        DB.ExecuteNonQuery(DBC)
    End Sub
#End Region

#Region "Get Employer By Employer ID"
    Public Sub FindEmployerByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_EMPLOYER_GETBYID)
        Try

            DB.AddInParameter(DBC, "@Employer_ID", DbType.String, Me.Employer_ID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.Employer_ID = IIf(Not IsDBNull(.Item("EmployerID")), Trim(.Item("EmployerID").ToString), String.Empty)
                        Me.Employer_Name = IIf(Not IsDBNull(.Item("EmployerName")), Trim(.Item("EmployerName").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.City = IIf(Not IsDBNull(.Item("City")), Trim(.Item("City").ToString), String.Empty)
                        Me.DesignationID = IIf(Not IsDBNull(.Item("Designation")), Trim(.Item("Designation").ToString), String.Empty)
                        Me.NIC = IIf(Not IsDBNull(.Item("NICNo")), Trim(.Item("NICNo").ToString), String.Empty)
                        Me.Telephone = IIf(Not IsDBNull(.Item("Telephone")), Trim(.Item("Telephone").ToString), String.Empty)

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

#Region "Get All Employers"
    Public Function GetAllEmployers() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_EMPLOYER_GETALL)
            Return DB.ExecuteDataSet(DBC)
            DBC.Dispose()
        Catch ex As Exception

            Return Nothing
        End Try




    End Function
#End Region

#Region "Insert Designation"
    Public Sub InsertDesignation()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DESIGNATION_INSERT)
            DB.AddInParameter(DBC, "@Name", DbType.String, Me.DesignationName)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception




        End Try

    End Sub

#End Region

#Region "Delete Designation"
    Public Sub DeleteDesignation()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DESIGNATION_DELETE)
            DB.AddInParameter(DBC, "@Name", DbType.String, Me.DesignationName)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Get All Designation"
    Public Function GetAllDesigation() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DESIGNATION_GETALL)
            Return DB.ExecuteDataSet(DBC)
            DBC.Dispose()
        Catch ex As Exception

            Return Nothing
        End Try




    End Function
#End Region
End Class
