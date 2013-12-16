Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors

Public Class DAQuotation

#Region "Variables"
    Private _QuotationID As Int64
    Private _Quotation_No As String
    Private _Customer_Name As String
    Private _Address1 As String
    Private _Address2 As String
    Private _Address3 As String
    Private _Age As Integer
    Private _QuatationDate As DateTime
    Private _Occupation As String
    Private _Firm As String
    Private _Frame As Decimal
    Private _Lense As Decimal
    Private _Others As Decimal
    Private _Total As Decimal
    Private _Valid_Days As String
    Private _Prescription As String
    Private _Remarks As String
#End Region

#Region "Properties"

    Public Property QuotationNo() As String
        Get
            Return _Quotation_No
        End Get
        Set(ByVal value As String)
            _Quotation_No = value
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            Return _Customer_Name
        End Get
        Set(ByVal value As String)
            _Customer_Name = value
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
    Public Property Address3() As String
        Get
            Return _Address3
        End Get
        Set(ByVal value As String)
            _Address3 = value
        End Set
    End Property
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            _Age = value
        End Set
    End Property
    Public Property QuatationDate() As DateTime
        Get
            Return _QuatationDate
        End Get
        Set(ByVal value As DateTime)
            _QuatationDate = value
        End Set
    End Property
    Public Property Occupation() As String
        Get
            Return _Occupation
        End Get
        Set(ByVal value As String)
            _Occupation = value
        End Set
    End Property
    Public Property Firm() As String
        Get
            Return _Firm
        End Get
        Set(ByVal value As String)
            _Firm = value
        End Set
    End Property
    Public Property Frame() As Decimal
        Get
            Return _Frame
        End Get
        Set(ByVal value As Decimal)
            _Frame = value
        End Set
    End Property
    Public Property Lense() As Decimal
        Get
            Return _Lense
        End Get
        Set(ByVal value As Decimal)
            _Lense = value
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
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total = value
        End Set
    End Property
    Public Property Valid_Days() As String
        Get
            Return _Valid_Days
        End Get
        Set(ByVal value As String)
            _Valid_Days = value
        End Set
    End Property
    Public Property Prescription() As String
        Get
            Return _Prescription
        End Get
        Set(ByVal value As String)
            _Prescription = value
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

    Public Property QuotationID() As Int64
        Get
            Return _QuotationID
        End Get
        Set(ByVal value As Int64)
            _QuotationID = value
        End Set
    End Property


#End Region

#Region "Insert Quotation"

    Public Sub InsertQuotation()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_QUOTATION_INSERT)

            DB.AddInParameter(DBC, "@QuotationID", DbType.Int64, Me.QuotationID)
            DB.AddInParameter(DBC, "@QuotationNo", DbType.String, Me.QuotationNo)
            DB.AddInParameter(DBC, "@CustomerName", DbType.String, Me.CustomerName)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@Address3", DbType.String, Me.Address3)
            DB.AddInParameter(DBC, "@Age", DbType.Int32, Me.Age)
            DB.AddInParameter(DBC, "@Date", DbType.DateTime, Me.QuatationDate)

            DB.AddInParameter(DBC, "@Occupation", DbType.String, Me.Occupation)
            DB.AddInParameter(DBC, "@Firm", DbType.String, Me.Firm)
            DB.AddInParameter(DBC, "@Frame", DbType.Decimal, Me.Frame)
            DB.AddInParameter(DBC, "@Lense", DbType.Decimal, Me.Lense)
            DB.AddInParameter(DBC, "@Others", DbType.Decimal, Me.Others)
            DB.AddInParameter(DBC, "@Total", DbType.Decimal, Me.Total)
            DB.AddInParameter(DBC, "@Valid_Days", DbType.String, Me.Valid_Days)
            DB.AddInParameter(DBC, "@Prescription", DbType.String, Me.Prescription)
            DB.AddInParameter(DBC, "@Remarks", DbType.String, Me.Remarks)
            DB.ExecuteNonQuery(DBC)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Delete Quotation"

    Public Sub DeleteQuotation()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_QUOTATION_DELETE)
        DB.AddInParameter(DBC, "@QuotationID", DbType.String, Me.QuotationID)
        DB.ExecuteNonQuery(DBC)
    End Sub

#End Region

#Region "Get Quotation By QuotationID"

    Public Sub QuotationGetByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_QUOTATION_GETBYID)
        Try

            DB.AddInParameter(DBC, "@QuotationID", DbType.String, Me.QuotationID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.QuotationID = IIf(Not IsDBNull(.Item("QuotationID")), Trim(.Item("QuotationID").ToString), 0)
                        Me.QuotationNo = IIf(Not IsDBNull(.Item("QuotationNo")), Trim(.Item("QuotationNo").ToString), String.Empty)
                        Me.CustomerName = IIf(Not IsDBNull(.Item("CustomerName")), Trim(.Item("CustomerName").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.Address3 = IIf(Not IsDBNull(.Item("Address3")), Trim(.Item("Address3").ToString), String.Empty)
                        Me.Age = IIf(Not IsDBNull(.Item("Age")), Int32.Parse(Trim(.Item("Age").ToString)), String.Empty)
                        Me.QuatationDate = IIf(Not IsDBNull(.Item("Date")), DateTime.Parse(Trim(.Item("Date").ToString)), String.Empty)
                        Me.Occupation = IIf(Not IsDBNull(.Item("Occupation")), Trim(.Item("Occupation").ToString), String.Empty)
                        Me.Firm = IIf(Not IsDBNull(.Item("Firm")), Trim(.Item("Firm").ToString), String.Empty)
                        Me.Frame = IIf(Not IsDBNull(.Item("Frame")), Decimal.Parse(Trim(.Item("Frame").ToString)), String.Empty)
                        Me.Lense = IIf(Not IsDBNull(.Item("Lense")), Decimal.Parse(Trim(.Item("Lense").ToString)), String.Empty)
                        Me.Others = IIf(Not IsDBNull(.Item("Others")), Decimal.Parse(Trim(.Item("Others").ToString)), String.Empty)
                        Me.Total = IIf(Not IsDBNull(.Item("Total")), Decimal.Parse(Trim(.Item("Total").ToString)), String.Empty)
                        Me.Valid_Days = IIf(Not IsDBNull(.Item("Valid Days")), Trim(.Item("Valid Days").ToString), String.Empty)
                        Me.Prescription = IIf(Not IsDBNull(.Item("Prescription")), Trim(.Item("Prescription").ToString), String.Empty)
                        Me.Remarks = IIf(Not IsDBNull(.Item("Remarks")), Trim(.Item("Remarks").ToString), String.Empty)
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

#Region "GetAll Quotations"

    Public Function GetAllQuotations() As DataSet
        Try

            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_QUOTATION_GETALL)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
#End Region


End Class
