Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors

Public Class DAHearingQuotation

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

    Private _Audiogram As String
    Private _BrandModalLeft As String
    Private _BrandModalRight As String
    Private _EarMold As String
    Private _EarMoldLeft As String
    Private _EarMoldRight As String
    Private _OtherAccessories As String
    Private _Gaurantee As String
    Private _PTALeft As String
    Private _PTARight As String

    Private _Total As Decimal
    Private _Valid_Days As String
    Private _BrandModal As String
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

    Public Property Audiogram() As String
        Get
            Return _Audiogram
        End Get
        Set(ByVal value As String)
            _Audiogram = value
        End Set
    End Property
    Public Property BrandModalLeft() As String
        Get
            Return _BrandModalLeft
        End Get
        Set(ByVal value As String)
            _BrandModalLeft = value
        End Set
    End Property
    Public Property BrandModalRight() As String
        Get
            Return _BrandModalRight
        End Get
        Set(ByVal value As String)
            _BrandModalRight = value
        End Set
    End Property
    Public Property EarMold() As String
        Get
            Return _EarMold
        End Get
        Set(ByVal value As String)
            _EarMold = value
        End Set
    End Property
    Public Property EarMoldLeft() As String
        Get
            Return _EarMoldLeft
        End Get
        Set(ByVal value As String)
            _EarMoldLeft = value
        End Set
    End Property
    Public Property EarMoldRight() As String
        Get
            Return _EarMoldRight
        End Get
        Set(ByVal value As String)
            _EarMoldRight = value
        End Set
    End Property
    Public Property OtherAccessories() As String
        Get
            Return _OtherAccessories
        End Get
        Set(ByVal value As String)
            _OtherAccessories = value
        End Set
    End Property
    Public Property Gaurantee() As String
        Get
            Return _Gaurantee
        End Get
        Set(ByVal value As String)
            _Gaurantee = value
        End Set
    End Property
    Public Property PTALeft() As String
        Get
            Return _PTALeft
        End Get
        Set(ByVal value As String)
            _PTALeft = value
        End Set
    End Property
    Public Property PTARight() As String
        Get
            Return _PTARight
        End Get
        Set(ByVal value As String)
            _PTARight = value
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
    Public Property BrandModal() As String
        Get
            Return _BrandModal
        End Get
        Set(ByVal value As String)
            _BrandModal = value
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
    Public Property HearingQuotationID() As Int64
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
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_HEARINGQUOTATION_INSERT)

            DB.AddInParameter(DBC, "@HearingQuotationID", DbType.Int64, Me.HearingQuotationID)
            DB.AddInParameter(DBC, "@QuotationNo", DbType.String, Me.QuotationNo)
            DB.AddInParameter(DBC, "@CustomerName", DbType.String, Me.CustomerName)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@Address3", DbType.String, Me.Address3)
            DB.AddInParameter(DBC, "@Age", DbType.Int32, Me.Age)
            DB.AddInParameter(DBC, "@Date", DbType.DateTime, Me.QuatationDate)

            DB.AddInParameter(DBC, "@Occupation", DbType.String, Me.Occupation)

            DB.AddInParameter(DBC, "@Audiogram", DbType.String, Me.Audiogram)
            DB.AddInParameter(DBC, "@BrandModal", DbType.String, Me.BrandModal)
            DB.AddInParameter(DBC, "@BrandModalLeft", DbType.String, Me.BrandModalLeft)
            DB.AddInParameter(DBC, "@BrandModalRight", DbType.String, Me.BrandModalRight)
            DB.AddInParameter(DBC, "@EarMold", DbType.String, Me.EarMold)
            DB.AddInParameter(DBC, "@EarMoldLeft", DbType.String, Me.EarMoldLeft)
            DB.AddInParameter(DBC, "@EarMoldRight", DbType.String, Me.EarMoldRight)
            DB.AddInParameter(DBC, "@Gaurantee", DbType.String, Me.Gaurantee)
            DB.AddInParameter(DBC, "@OtherAccessories", DbType.String, Me.OtherAccessories)
            DB.AddInParameter(DBC, "@PTALeft", DbType.String, Me.PTALeft)
            DB.AddInParameter(DBC, "@PTARight", DbType.String, Me.PTARight)


            DB.AddInParameter(DBC, "@Total", DbType.Decimal, Me.Total)
            DB.AddInParameter(DBC, "@Valid_Days", DbType.String, Me.Valid_Days)
            DB.AddInParameter(DBC, "@Remarks", DbType.String, Me.Remarks)
            DB.ExecuteNonQuery(DBC)

        Catch ex As Exception
            Throw
        End Try

    End Sub

#End Region

#Region "Delete Quotation"

    Public Sub DeleteQuotation()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_HEARINGQUOTATION_DELETE)
        DB.AddInParameter(DBC, "@HearingQuotationID", DbType.String, Me.HearingQuotationID)
        DB.ExecuteNonQuery(DBC)
    End Sub

#End Region

#Region "Get Quotation By QuotationID"

    Public Sub QuotationGetByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_HEARINGQUOTATION_GETBYID)
        Try

            DB.AddInParameter(DBC, "@HearingQuotationID", DbType.String, Me.HearingQuotationID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.HearingQuotationID = IIf(Not IsDBNull(.Item("HearingQuotationID")), Trim(.Item("HearingQuotationID").ToString), 0)
                        Me.QuotationNo = IIf(Not IsDBNull(.Item("QuotationNo")), Trim(.Item("QuotationNo").ToString), String.Empty)
                        Me.CustomerName = IIf(Not IsDBNull(.Item("CustomerName")), Trim(.Item("CustomerName").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.Address3 = IIf(Not IsDBNull(.Item("Address3")), Trim(.Item("Address3").ToString), String.Empty)
                        Me.Age = IIf(Not IsDBNull(.Item("Age")), Int32.Parse(Trim(.Item("Age").ToString)), String.Empty)
                        Me.QuatationDate = IIf(Not IsDBNull(.Item("Date")), DateTime.Parse(Trim(.Item("Date").ToString)), String.Empty)
                        Me.Occupation = IIf(Not IsDBNull(.Item("Occupation")), Trim(.Item("Occupation").ToString), String.Empty)

                        Me.Audiogram = IIf(Not IsDBNull(.Item("Audiogram")), Trim(.Item("Audiogram").ToString), String.Empty)
                        Me.BrandModalLeft = IIf(Not IsDBNull(.Item("BrandModalLeft")), Trim(.Item("BrandModalLeft").ToString), String.Empty)
                        Me.BrandModalRight = IIf(Not IsDBNull(.Item("BrandModalRight")), Trim(.Item("BrandModalRight").ToString), String.Empty)
                        Me.EarMold = IIf(Not IsDBNull(.Item("EarMold")), Trim(.Item("EarMold").ToString), String.Empty)
                        Me.EarMoldLeft = IIf(Not IsDBNull(.Item("EarMoldLeft")), Trim(.Item("EarMoldLeft").ToString), String.Empty)
                        Me.EarMoldRight = IIf(Not IsDBNull(.Item("EarMoldRight")), Trim(.Item("EarMoldRight").ToString), String.Empty)
                        Me.Gaurantee = IIf(Not IsDBNull(.Item("Gaurantee")), Trim(.Item("Gaurantee").ToString), String.Empty)
                        Me.OtherAccessories = IIf(Not IsDBNull(.Item("OtherAccessories")), Trim(.Item("OtherAccessories").ToString), String.Empty)

                        Me.PTALeft = IIf(Not IsDBNull(.Item("PTALeft")), Trim(.Item("PTALeft").ToString), String.Empty)
                        Me.PTARight = IIf(Not IsDBNull(.Item("PTARight")), Trim(.Item("PTARight").ToString), String.Empty)

                        Me.Total = IIf(Not IsDBNull(.Item("Total")), .Item("Total").ToString, 0)
                        Me.Valid_Days = IIf(Not IsDBNull(.Item("Valid Days")), Trim(.Item("Valid Days").ToString), String.Empty)
                        Me.BrandModal = IIf(Not IsDBNull(.Item("BrandModal")), Trim(.Item("BrandModal").ToString), String.Empty)
                        Me.Remarks = IIf(Not IsDBNull(.Item("Remarks")), Trim(.Item("Remarks").ToString), String.Empty)
                    Loop
                End With

                If (Not DR Is Nothing) Then
                    DR.Close()
                End If


            End Using



        Catch ex As Exception
            Throw
        Finally
            DBC.Dispose()



        End Try


    End Sub

#End Region

#Region "GetAll Quotations"

    Public Function GetAllQuotations() As DataSet
        Try

            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_HEARINGQUOTATION_GETALL)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
#End Region


End Class
