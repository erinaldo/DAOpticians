Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports System

Public Class DAReceipt

#Region "Variables"

    Private _ReceiptID As Int64
    Private _PrescriptionID As Int64
    Private _CustomerName As String
    Private _AddressLine1 As String
    Private _AddressLine2 As String
    Private _AddressLine3 As String
    Private _Age As Int64
    Private _RefractedBy As String
    Private _PrescriptionAttendedBy As String
    Private _Date As DateTime
    Private _PrescriptionDate As DateTime
    Private _FullAmount As Decimal
    Private _SpecialCharged As Decimal
    Private _AdvancePaid As Decimal
    Private _Balance As Decimal
    Private _NoOfPairOfFrames As Int64
    Private _PairOfFramesAmount As Decimal
    Private _NoOfLenses As Int64
    Private _PairOfLenseAmount As Decimal
    Private _NoOfFrameChange As Int64
    Private _FrameChangeAmount As Decimal
    Private _RefractionEyePressureAmount As Decimal
    Private _TinttinAmount As Decimal
    Private _CustomeText As String
    Private _CustomAmount As Decimal
    Private _Total As Decimal
    Private _RefBillNo As String
    Private _CashPaid As Decimal
    Private _Remarks As String
    Private _SalesAttendedBy As String
    Private _IsActive As Boolean
    Private _FromDate As DateTime
    Private _ToDate As DateTime
    Private _StockID As Int64
    Private _UnitPrice As Decimal
    Private _PurchasingPrice As Decimal
    Private _Quantity As Decimal
    Private _Discount As Decimal
    Private _Value As Decimal
    Private _SysNo As String

    Private _PLenseQty As Decimal
    Private _PFrameQty As Integer
    Private _PLensePrice As Decimal
    Private _PFramePrice As Decimal

#End Region

#Region "Properties"

    Public Property ReceiptID() As Int64
        Get
            Return _ReceiptID
        End Get
        Set(ByVal value As Int64)
            _ReceiptID = value
        End Set
    End Property
    Public Property PrescriptionID() As Int64
        Get
            Return _PrescriptionID
        End Get
        Set(ByVal value As Int64)
            _PrescriptionID = value
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
    Public Property AddressLine1() As String
        Get
            Return _AddressLine1
        End Get
        Set(ByVal value As String)
            _AddressLine1 = value
        End Set
    End Property
    Public Property AddressLine2() As String
        Get
            Return _AddressLine2
        End Get
        Set(ByVal value As String)
            _AddressLine2 = value
        End Set
    End Property
    Public Property AddressLine3() As String
        Get
            Return _AddressLine3
        End Get
        Set(ByVal value As String)
            _AddressLine3 = value
        End Set
    End Property
    Public Property Age() As Int64
        Get
            Return _Age
        End Get
        Set(ByVal value As Int64)
            _Age = value
        End Set
    End Property
    Public Property RefractedBy() As String
        Get
            Return _RefractedBy
        End Get
        Set(ByVal value As String)
            _RefractedBy = value
        End Set
    End Property
    Public Property PrescriptionAttendedBy() As String
        Get
            Return _PrescriptionAttendedBy
        End Get
        Set(ByVal value As String)
            _PrescriptionAttendedBy = value
        End Set
    End Property
    Public Property ReceiptDate() As DateTime
        Get
            Return _Date
        End Get
        Set(ByVal value As DateTime)
            _Date = value
        End Set
    End Property
    Public Property PrescriptionDate() As DateTime
        Get
            Return _PrescriptionDate
        End Get
        Set(ByVal value As DateTime)
            _PrescriptionDate = value
        End Set
    End Property
    Public Property FullAmount() As Decimal
        Get
            Return _FullAmount
        End Get
        Set(ByVal value As Decimal)
            _FullAmount = value
        End Set
    End Property
    Public Property SpecialCharges() As Decimal
        Get
            Return _SpecialCharged
        End Get
        Set(ByVal value As Decimal)
            _SpecialCharged = value
        End Set
    End Property
    Public Property AdvancePaid() As Decimal
        Get
            Return _AdvancePaid
        End Get
        Set(ByVal value As Decimal)
            _AdvancePaid = value
        End Set
    End Property
    Public Property Balance() As Decimal
        Get
            Return _Balance
        End Get
        Set(ByVal value As Decimal)
            _Balance = value
        End Set
    End Property
    Public Property NoOfPairOfFrames() As Int64
        Get
            Return _NoOfPairOfFrames
        End Get
        Set(ByVal value As Int64)
            _NoOfPairOfFrames = value
        End Set
    End Property
    Public Property PairOfFramesAmount() As Decimal
        Get
            Return _PairOfFramesAmount
        End Get
        Set(ByVal value As Decimal)
            _PairOfFramesAmount = value
        End Set
    End Property
    Public Property NoOfLenses() As Int64
        Get
            Return _NoOfLenses
        End Get
        Set(ByVal value As Int64)
            _NoOfLenses = value
        End Set
    End Property
    Public Property PairOfLenseAmount() As Decimal
        Get
            Return _PairOfLenseAmount
        End Get
        Set(ByVal value As Decimal)
            _PairOfLenseAmount = value
        End Set
    End Property
    Public Property NoOfFrameChange() As Int64
        Get
            Return _NoOfFrameChange
        End Get
        Set(ByVal value As Int64)
            _NoOfFrameChange = value
        End Set
    End Property
    Public Property FrameChangeAmount() As Decimal
        Get
            Return _FrameChangeAmount
        End Get
        Set(ByVal value As Decimal)
            _FrameChangeAmount = value
        End Set
    End Property
    Public Property RefractionEyePressureAmount() As Decimal
        Get
            Return _RefractionEyePressureAmount
        End Get
        Set(ByVal value As Decimal)
            _RefractionEyePressureAmount = value
        End Set
    End Property
    Public Property TinttinAmount() As Decimal
        Get
            Return _TinttinAmount
        End Get
        Set(ByVal value As Decimal)
            _TinttinAmount = value
        End Set
    End Property
    Public Property CustomText() As String
        Get
            Return _CustomeText
        End Get
        Set(ByVal value As String)
            _CustomeText = value
        End Set
    End Property
    Public Property CustomAmount() As Decimal
        Get
            Return _CustomAmount
        End Get
        Set(ByVal value As Decimal)
            _CustomAmount = value
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
    Public Property RefBillNo() As String
        Get
            Return _RefBillNo
        End Get
        Set(ByVal value As String)
            _RefBillNo = value
        End Set
    End Property
    Public Property CashPaid() As Decimal
        Get
            Return _CashPaid
        End Get
        Set(ByVal value As Decimal)
            _CashPaid = value
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
    Public Property SalesAttendedBy() As String
        Get
            Return _SalesAttendedBy
        End Get
        Set(ByVal value As String)
            _SalesAttendedBy = value
        End Set
    End Property
    Public Property IsActive() As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property
    Public Property FromDate() As DateTime
        Get
            Return _FromDate
        End Get
        Set(ByVal value As DateTime)
            _FromDate = value
        End Set
    End Property
    Public Property ToDate() As DateTime
        Get
            Return _ToDate
        End Get
        Set(ByVal value As DateTime)
            _ToDate = value
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
    Public Property UnitPrice() As Decimal
        Get
            Return _UnitPrice
        End Get
        Set(ByVal value As Decimal)
            _UnitPrice = value
        End Set
    End Property
    Public Property Quantity() As Decimal
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Decimal)
            _Quantity = value
        End Set
    End Property
    Public Property PurchasingPrice() As Decimal
        Get
            Return _PurchasingPrice
        End Get
        Set(ByVal value As Decimal)
            _PurchasingPrice = Value
        End Set
    End Property
    Public Property Discount() As Decimal
        Get
            Return _Discount
        End Get
        Set(ByVal value As Decimal)
            _Discount = value
        End Set
    End Property
    Public Property Value() As Decimal
        Get
            Return _Value
        End Get
        Set(ByVal value As Decimal)
            _Value = Value
        End Set
    End Property
    Public Property SysNo() As String
        Get
            Return _SysNo
        End Get
        Set(ByVal value As String)
            _SysNo = value
        End Set
    End Property


    Public Property PLenseQty() As Decimal
        Get
            Return _PLenseQty
        End Get
        Set(ByVal value As Decimal)
            _PLenseQty = value
        End Set
    End Property

    Public Property PFrameQty() As Integer
        Get
            Return _PFrameQty
        End Get
        Set(ByVal value As Integer)
            _PFrameQty = value
        End Set
    End Property



    Public Property PFramePrice() As Decimal
        Get
            Return _PFramePrice
        End Get
        Set(ByVal value As Decimal)
            _PFramePrice = value
        End Set
    End Property


    Public Property PLensePrice() As Decimal
        Get
            Return _PLensePrice
        End Get
        Set(ByVal value As Decimal)
            _PLensePrice = value
        End Set
    End Property



#End Region

#Region "Insert Receipt"

    Public Sub InsertReceipt(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_RECEIPTS_INSERT)
            db.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)
            db.AddInParameter(DBC, "@PrescriptionID", DbType.Int64, Me.PrescriptionID)
            db.AddInParameter(DBC, "@Date", DbType.DateTime, Me.ReceiptDate)
            db.AddInParameter(DBC, "@NoOfPairOfFrames", DbType.Int64, Me.NoOfPairOfFrames)
            db.AddInParameter(DBC, "@PairOfFramesAmount", DbType.Decimal, Me.PairOfFramesAmount)
            db.AddInParameter(DBC, "@NoOfLenses", DbType.Int64, Me.NoOfLenses)
            db.AddInParameter(DBC, "@PairOfLenseAmount", DbType.Decimal, Me.PairOfLenseAmount)
            db.AddInParameter(DBC, "@NoOfFrameChange", DbType.Int64, Me.NoOfFrameChange)
            db.AddInParameter(DBC, "@FrameChangeAmount", DbType.Decimal, Me.FrameChangeAmount)
            db.AddInParameter(DBC, "@RefractionEyePressureAmount", DbType.Decimal, Me.RefractionEyePressureAmount)
            db.AddInParameter(DBC, "@TinttinAmount", DbType.Decimal, Me.TinttinAmount)
            db.AddInParameter(DBC, "@CustomText", DbType.String, Me.CustomText)
            db.AddInParameter(DBC, "@CustomAmount", DbType.Decimal, Me.CustomAmount)
            db.AddInParameter(DBC, "@Total", DbType.Decimal, Me.Total)
            db.AddInParameter(DBC, "@RefBillNo", DbType.String, Me.RefBillNo)
            db.AddInParameter(DBC, "@CashPaid", DbType.Decimal, Me.CashPaid)
            db.AddInParameter(DBC, "@Remarks", DbType.String, Me.Remarks)
            db.AddInParameter(DBC, "@SalesAttendedBy", DbType.String, Me.SalesAttendedBy)
            db.AddOutParameter(DBC, "@CurrentReceiptID", DbType.Int64, 0)
            db.ExecuteNonQuery(DBC, transaction)

            Dim newid As Int64


            If Not (IsDBNull(db.GetParameterValue(DBC, "@CurrentReceiptID"))) Then
                newid = Convert.ToInt64(db.GetParameterValue(DBC, "@CurrentReceiptID").ToString())
            End If

            If (newid <> -1) Then
                Me.ReceiptID = newid
            End If


        Catch ex As Exception


        End Try

    End Sub

#End Region

#Region "Insert receipt description"

    Public Sub InsertReceiptDescription(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_RECEIPTSDESCRIPTION_INSERT)
            db.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)
            db.AddInParameter(DBC, "@StockID", DbType.Int64, Me.StockID)
            db.AddInParameter(DBC, "@UnitPrice", DbType.Decimal, Me.UnitPrice)
            db.AddInParameter(DBC, "@PurchasingPrice", DbType.Decimal, Me.PurchasingPrice)
            db.AddInParameter(DBC, "@Qty", DbType.Decimal, Me.Quantity)
            db.AddInParameter(DBC, "@Discount", DbType.Decimal, Me.Discount)
            db.AddInParameter(DBC, "@Value", DbType.Decimal, Me.Value)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Delete Receipt"

    Public Sub ReceitDelete()

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_RECEIPTS_DELETE)
            db.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)
            db.ExecuteNonQuery(DBC)

        Catch ex As Exception


        End Try

    End Sub

#End Region

#Region "Receipt Get By ID"

    Public Sub GetReceitByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_RECEIPTS_GETBYID)
        Try

            DB.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read

                        Me.ReceiptID = Convert.ToInt64(IIf(Not IsDBNull(.Item("ReceiptID")), Trim(.Item("ReceiptID").ToString), 0))
                        Me.CustomerName = IIf(Not IsDBNull(.Item("Name")), Trim(.Item("Name").ToString), String.Empty)
                        Me.AddressLine1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.AddressLine2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.AddressLine3 = IIf(Not IsDBNull(.Item("Address3")), Trim(.Item("Address3").ToString), String.Empty)
                        Me.Age = Convert.ToInt64(IIf(Not IsDBNull(.Item("Age")), Trim(.Item("Age").ToString), 0))
                        Me.RefractedBy = IIf(Not IsDBNull(.Item("Refracted")), Trim(.Item("Refracted").ToString), String.Empty)
                        Me.PrescriptionAttendedBy = IIf(Not IsDBNull(.Item("AttendedBy")), Trim(.Item("AttendedBy").ToString), String.Empty)
                        Me.ReceiptDate = Convert.ToDateTime(IIf(Not IsDBNull(.Item("Date")), Trim(.Item("Date").ToString), DateTime.MinValue))
                        Me.PrescriptionDate = Convert.ToDateTime(IIf(Not IsDBNull(.Item("PrescriptionDate")), Trim(.Item("PrescriptionDate").ToString), DateTime.MinValue))

                        Me.FullAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("FullAmount")), Trim(.Item("FullAmount").ToString), 0))
                        Me.SpecialCharges = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Specialcharges")), Trim(.Item("Specialcharges").ToString), 0))
                        Me.AdvancePaid = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Advance")), Trim(.Item("Advance").ToString), 0))
                        Me.Balance = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Balance")), Trim(.Item("Balance").ToString), 0))

                        Me.NoOfLenses = Convert.ToInt64(IIf(Not IsDBNull(.Item("NoOfLenses")), Trim(.Item("NoOfLenses").ToString), 0))
                        Me.PairOfLenseAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("PairOfLenseAmount")), Trim(.Item("PairOfLenseAmount").ToString), 0))

                        Me.NoOfPairOfFrames = Convert.ToInt64(IIf(Not IsDBNull(.Item("NoOfPairOfFrames")), Trim(.Item("NoOfPairOfFrames").ToString), 0))
                        Me.PairOfFramesAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("PairOfFramesAmount")), Trim(.Item("PairOfFramesAmount").ToString), 0))
                       
                        Me.NoOfFrameChange = Convert.ToInt64(IIf(Not IsDBNull(.Item("NoOfFrameChange")), Trim(.Item("NoOfFrameChange").ToString), 0))
                        Me.FrameChangeAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("FrameChangeAmount")), Trim(.Item("FrameChangeAmount").ToString), 0))
                        Me.RefractionEyePressureAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("RefractionEyePressureAmount")), Trim(.Item("RefractionEyePressureAmount").ToString), 0))
                        Me.TinttinAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("TinttinAmount")), Trim(.Item("TinttinAmount").ToString), 0))
                        Me.CustomText = IIf(Not IsDBNull(.Item("CustomText")), Trim(.Item("CustomText").ToString), String.Empty)
                        Me.CustomAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("CustomAmount")), Trim(.Item("CustomAmount").ToString), 0))
                        Me.Total = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Total")), Trim(.Item("Total").ToString), 0))
                        Me.RefBillNo = IIf(Not IsDBNull(.Item("RefBillNo")), Trim(.Item("RefBillNo").ToString), String.Empty)
                        Me.CashPaid = Convert.ToDecimal(IIf(Not IsDBNull(.Item("CashPaid")), Trim(.Item("CashPaid").ToString), 0))
                        Me.Remarks = IIf(Not IsDBNull(.Item("Remarks")), Trim(.Item("Remarks").ToString), String.Empty)
                        Me.SalesAttendedBy = IIf(Not IsDBNull(.Item("SalesAttendedBy")), Trim(.Item("SalesAttendedBy").ToString), String.Empty)
                        Me.SysNo = IIf(Not IsDBNull(.Item("SysNo")), Trim(.Item("SysNo").ToString), String.Empty)



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

#Region "Receipt Get By Prescription ID"

    Public Sub GetReceitByPrescriptionID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_RECEIPTS_GETBYPRESCRIPTIONID)
        Try

            DB.AddInParameter(DBC, "@PrescriptionID", DbType.Int64, Me.PrescriptionID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read

                        Me.ReceiptID = Convert.ToInt64(IIf(Not IsDBNull(.Item("ReceiptID")), Trim(.Item("ReceiptID").ToString), 0))
                        Me.CustomerName = IIf(Not IsDBNull(.Item("Name")), Trim(.Item("Name").ToString), String.Empty)
                        Me.AddressLine1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.AddressLine2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.AddressLine3 = IIf(Not IsDBNull(.Item("Address3")), Trim(.Item("Address3").ToString), String.Empty)
                        Me.Age = Convert.ToInt64(IIf(Not IsDBNull(.Item("Age")), Trim(.Item("Age").ToString), 0))
                        Me.RefractedBy = IIf(Not IsDBNull(.Item("Refracted")), Trim(.Item("Refracted").ToString), String.Empty)
                        Me.PrescriptionAttendedBy = IIf(Not IsDBNull(.Item("AttendedBy")), Trim(.Item("AttendedBy").ToString), String.Empty)
                        Me.ReceiptDate = Convert.ToDateTime(IIf(Not IsDBNull(.Item("Date")), Trim(.Item("Date").ToString), DateTime.MinValue))
                        Me.PrescriptionDate = Convert.ToDateTime(IIf(Not IsDBNull(.Item("PrescriptionDate")), Trim(.Item("PrescriptionDate").ToString), DateTime.MinValue))

                        Me.FullAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("FullAmount")), Trim(.Item("FullAmount").ToString), 0))
                        Me.SpecialCharges = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Specialcharges")), Trim(.Item("Specialcharges").ToString), 0))
                        Me.AdvancePaid = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Advance")), Trim(.Item("Advance").ToString), 0))
                        Me.Balance = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Balance")), Trim(.Item("Balance").ToString), 0))

                        Me.NoOfLenses = Convert.ToInt64(IIf(Not IsDBNull(.Item("NoOfLenses")), Trim(.Item("NoOfLenses").ToString), 0))
                        Me.PairOfLenseAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("PairOfLenseAmount")), Trim(.Item("PairOfLenseAmount").ToString), 0))

                        Me.NoOfPairOfFrames = Convert.ToInt64(IIf(Not IsDBNull(.Item("NoOfPairOfFrames")), Trim(.Item("NoOfPairOfFrames").ToString), 0))
                        Me.PairOfFramesAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("PairOfFramesAmount")), Trim(.Item("PairOfFramesAmount").ToString), 0))

                        Me.NoOfFrameChange = Convert.ToInt64(IIf(Not IsDBNull(.Item("NoOfFrameChange")), Trim(.Item("NoOfFrameChange").ToString), 0))
                        Me.FrameChangeAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("FrameChangeAmount")), Trim(.Item("FrameChangeAmount").ToString), 0))
                        Me.RefractionEyePressureAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("RefractionEyePressureAmount")), Trim(.Item("RefractionEyePressureAmount").ToString), 0))
                        Me.TinttinAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("TinttinAmount")), Trim(.Item("TinttinAmount").ToString), 0))
                        Me.CustomText = IIf(Not IsDBNull(.Item("CustomText")), Trim(.Item("CustomText").ToString), String.Empty)
                        Me.CustomAmount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("CustomAmount")), Trim(.Item("CustomAmount").ToString), 0))
                        Me.Total = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Total")), Trim(.Item("Total").ToString), 0))
                        Me.RefBillNo = IIf(Not IsDBNull(.Item("RefBillNo")), Trim(.Item("RefBillNo").ToString), String.Empty)
                        Me.CashPaid = Convert.ToDecimal(IIf(Not IsDBNull(.Item("CashPaid")), Trim(.Item("CashPaid").ToString), 0))
                        Me.Remarks = IIf(Not IsDBNull(.Item("Remarks")), Trim(.Item("Remarks").ToString), String.Empty)
                        Me.SalesAttendedBy = IIf(Not IsDBNull(.Item("SalesAttendedBy")), Trim(.Item("SalesAttendedBy").ToString), String.Empty)
                        Me.SysNo = IIf(Not IsDBNull(.Item("SysNo")), Trim(.Item("SysNo").ToString), String.Empty)

                        Me.PFrameQty = IIf(Not IsDBNull(.Item("FrameQty")), Trim(.Item("FrameQty").ToString), 0)
                        Me.PFramePrice = IIf(Not IsDBNull(.Item("FramePrice")), Trim(.Item("FramePrice").ToString), 0)
                        Me.PLenseQty = IIf(Not IsDBNull(.Item("LenseQty")), Trim(.Item("LenseQty").ToString), 0)
                        Me.PLensePrice = IIf(Not IsDBNull(.Item("LensePrice")), Trim(.Item("LensePrice").ToString), 0)




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

#Region "Receipt Description Get By ID"

    Public Function ReceiptDescriptionGetByReceiptID() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_RECEIPTSDESCRIPTIONGETBYRECEIPTID)
            db.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)
            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try

    End Function

#End Region

#Region "Receipt Get By Dates"

    Public Function ReceiptGetByDates() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_RECEIPTS_GETBYDATES)
            db.AddInParameter(DBC, "@FromDate", DbType.DateTime, Me.FromDate)
            db.AddInParameter(DBC, "@ToDate", DbType.DateTime, Me.ToDate)

            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try


    End Function

#End Region

#Region "Update Stock from Receipts"
    Public Sub UpdateStock(ByVal db As Database, ByVal transaction As DbTransaction)

        Try
            'Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_STOCK_UPDATEBYSALES)

            db.AddInParameter(DBC, "@StockID", DbType.Int64, Me.StockID)
            db.AddInParameter(DBC, "@StockBalance", DbType.Decimal, Me.Quantity)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Add to Stock from Receipt"
    Public Sub AddToStock(ByVal db As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_STOCK_ADDFROMRECEIPT)
            db.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception


        End Try

    End Sub
#End Region

#Region "Receipt Description Delete"
    Public Sub ReceiptDescriptionDelete(ByVal db As Database, ByVal transaction As DbTransaction)

        Try
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_RECEIPTSDESCRIPTION_DELETE)
            db.AddInParameter(DBC, "@ReceiptID", DbType.Int64, Me.ReceiptID)
            db.ExecuteNonQuery(DBC, transaction)

        Catch ex As Exception


        End Try

    End Sub
#End Region

End Class
