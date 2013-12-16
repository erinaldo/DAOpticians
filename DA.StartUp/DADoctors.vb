Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant


Public Class DADoctors

#Region "Varaibles"

    Private _DoctorID As Int64
    Private _DoctorName As String
    Private _Address1 As String
    Private _Address2 As String
    Private _City As String
    Private _Telephone As String
    Private _Email As String

#End Region

#Region "Properties"

    Public Property DoctorID() As Int64
        Get
            Return _DoctorID
        End Get
        Set(ByVal value As Int64)
            _DoctorID = value
        End Set
    End Property
    Public Property DoctorName() As String
        Get
            Return _DoctorName
        End Get
        Set(ByVal value As String)
            _DoctorName = value
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
    
#End Region

#Region "Insert Doctors"
    Public Sub InsertDoctors()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DOCTOR_INSERT)
            DB.AddInParameter(DBC, "@DoctorID", DbType.Int64, Me.DoctorID)
            DB.AddInParameter(DBC, "@DoctorName", DbType.String, Me.DoctorName)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@City", DbType.String, Me.City)
            DB.AddInParameter(DBC, "@Telephone", DbType.String, Me.Telephone)
            DB.AddInParameter(DBC, "@Email", DbType.String, Me.Email)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Delete Doctors"
    Public Sub DeleteDoctor()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DOCTOR_DELETE)
            DB.AddInParameter(DBC, "@DoctorID", DbType.Int64, Me.DoctorID)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Get Doctor By DoctorsID"
    Public Sub GetDoctorByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DOCTOR_GETBYID)
        Try

            DB.AddInParameter(DBC, "@DoctorID", DbType.Int64, Me.DoctorID)
            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.DoctorID = Convert.ToInt64(IIf(Not IsDBNull(.Item("DoctorID")), Trim(.Item("DoctorID").ToString), 0))
                        Me.DoctorName = IIf(Not IsDBNull(.Item("DoctorName")), Trim(.Item("DoctorName").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.City = IIf(Not IsDBNull(.Item("City")), Trim(.Item("City").ToString), String.Empty)
                        Me.Telephone = IIf(Not IsDBNull(.Item("Telephone")), Trim(.Item("Telephone").ToString), String.Empty)
                        Me.Email = IIf(Not IsDBNull(.Item("Email")), Trim(.Item("Email").ToString), String.Empty)
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

#Region "Get All Doctors"
    Public Function GetAllDoctors() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_DOCTOR_GETALL)
            Return DB.ExecuteDataSet(DBC)
            DBC.Dispose()
        Catch ex As Exception

            Return Nothing
        End Try




    End Function
#End Region


End Class
