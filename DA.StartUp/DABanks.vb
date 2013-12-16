Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors
Public Class DABanks

#Region "Variables"
    Private _BankID As Int64
    Private _Account_No As String
    Private _Bank As String
    Private _AccountType As String
#End Region

#Region "Propertise"
    Public Property BankID() As Int64
        Get
            Return _BankID
        End Get
        Set(ByVal value As Int64)
            _BankID = Value
        End Set
    End Property
    Public Property Account_No() As String
        Get
            Return _Account_No
        End Get
        Set(ByVal value As String)
            _Account_No = value
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
    Public Property AccountType() As String
        Get
            Return _AccountType
        End Get
        Set(ByVal value As String)
            _AccountType = Value
        End Set
    End Property
#End Region

#Region "Insert Bank"
    Public Sub InsertBank()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_BANKS_INSERT)

            DB.AddInParameter(DBC, "@BankID", DbType.Int64, Me.BankID)
            DB.AddInParameter(DBC, "@Account_No", DbType.String, Me.Account_No)
            DB.AddInParameter(DBC, "@AccountType", DbType.String, Me.AccountType)

            DB.AddInParameter(DBC, "@Bank", DbType.String, Me.Bank)
            
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception




        End Try

    End Sub

#End Region

#Region "Delete Bank"
    Public Sub DeleteBank()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_BANKS_DELETE)
        DB.AddInParameter(DBC, "@BankID", DbType.Int64, Me.BankID)
        DB.ExecuteNonQuery(DBC)
    End Sub
#End Region

#Region "Get By BankID"
    Public Sub GetByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_BANKS_GETBYID)
        Try

            DB.AddInParameter(DBC, "@BankID", DbType.Int64, Me.BankID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read

                        Me.Account_No = IIf(Not IsDBNull(.Item("AccountNo")), Trim(.Item("AccountNo").ToString), String.Empty)
                        Me.AccountType = IIf(Not IsDBNull(.Item("AccountType")), Trim(.Item("AccountType").ToString), String.Empty)
                        Me.Bank = IIf(Not IsDBNull(.Item("Bank")), Trim(.Item("Bank").ToString), String.Empty)

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

#Region "Get All Banks"
    Public Function GetAllBanks() As DataSet
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_BANKS_GETALL)
            Return DB.ExecuteDataSet(DBC)
            DBC.Dispose()
        Catch ex As Exception

            Return Nothing
        End Try




    End Function
#End Region

#Region "Is Account No Exists"
    Public Function IsAccountNoExists() As Boolean
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_BANKS_ISACCOUNTNOEXISTS)
            DB.AddInParameter(DBC, "@AccountNo", DbType.String, Me.Account_No)
            DB.AddOutParameter(DBC, "@IsExists", DbType.Int16, 1)

            DB.ExecuteNonQuery(DBC)
            Dim Result As Int16
            Result = Convert.ToInt16(DB.GetParameterValue(DBC, "@IsExists").ToString())

            If Result = 1 Then
                Return True
            Else
                Return False
            End If
          
            DBC.Dispose()
        Catch ex As Exception

            Return False
        End Try


    End Function
#End Region

End Class
