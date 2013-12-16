Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors
Imports System

Public Class DAPrescription

#Region "Variables"
    Private _PrescriptionID As Int64
    Private _SysNo As String
    Private _Salutation1 As String
    Private _Name As String
    Private _Salutation2 As String
    Private _Careof As String
    Private _Address1 As String
    Private _Address2 As String
    Private _Address3 As String
    Private _Office As String
    Private _Age As Integer
    Private _TelNo As String
    Private _OfficeNo As String
    Private _PrescriptionDate As DateTime
    Private _DueDate As DateTime
    Private _BillNo As String
    Private _Lense As String
    Private _Frame As String
    Private _Segment As String
    Private _Pd As String
    Private _Insert As String
    Private _Refracted As String
    Private _Dispensed As String
    Private _Orderno As String
    Private _Fullamount As Decimal
    Private _Specialcharges As Decimal
    Private _Total As Decimal
    Private _Remarks As String
    Private _Ready As Boolean
    Private _Delivered As String
    Private _AttendedBy As String
    Private _Advance As Decimal
    Private _ReceiptID As Int64
    Private _MobileNo As String
    Private _DelivaryDate As Date
    Private _LenseStockID As Int64
    Private _FrameStockID As Int64
    Private _LenseQty As Decimal
    Private _FrameQty As Integer
    Private _LensePrice As Decimal
    Private _FramePrice As Decimal


    Private _InLx As String
    Private _InLy As String
    Private _InL1 As String
    Private _InL2 As String
    Private _InL3 As String
    Private _InL4 As String
    Private _InL5 As String
    Private _InL6 As String
    Private _InR1 As String
    Private _InR2 As String
    Private _InR3 As String
    Private _InR4 As String
    Private _InR5 As String
    Private _InR6 As String
    Private _InRx As String
    Private _InRy As String

    Private _IxLx As String
    Private _IxLy As String
    Private _IxL1 As String
    Private _IxL2 As String
    Private _IxL3 As String
    Private _IxL4 As String
    Private _IxL5 As String
    Private _IxL6 As String
    Private _IxR1 As String
    Private _IxR2 As String
    Private _IxR3 As String
    Private _IxR4 As String
    Private _IxR5 As String
    Private _IxR6 As String
    Private _IxRx As String
    Private _IxRy As String

    Private _HxLx As String
    Private _HxLy As String
    Private _HxL1 As String
    Private _HxL2 As String
    Private _HxL3 As String
    Private _HxL4 As String
    Private _HxL5 As String
    Private _HxL6 As String
    Private _HxR1 As String
    Private _HxR2 As String
    Private _HxR3 As String
    Private _HxR4 As String
    Private _HxR5 As String
    Private _HxR6 As String
    Private _HxRx As String
    Private _HxRy As String

    Private _InIOPLx As String
    Private _InIOPLy As String
    Private _ExIOPLx As String
    Private _ExIOPLy As String
    Private _HbIOPLx As String
    Private _HbIOPLy As String
    Private _InIOPRx As String
    Private _InIOPRy As String
    Private _ExIOPRx As String
    Private _ExIOPRy As String
    Private _HbIOPRx As String
    Private _HbIOPRy As String


    Private _FromDate As DateTime
    Private _ToDate As DateTime

    Private _NICNo As String

#End Region

#Region "Propertiese"

    Public Property PrescriptionID() As Int64
        Get
            Return _PrescriptionID
        End Get
        Set(ByVal value As Int64)
            _PrescriptionID = value
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
    Public Property Salutation1() As String
        Get
            Return _Salutation1
        End Get
        Set(ByVal value As String)
            If _Salutation1 = value Then
                Return
            End If
            _Salutation1 = value
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
    Public Property Salutation2() As String
        Get
            Return _Salutation2
        End Get
        Set(ByVal value As String)
            _Salutation2 = value
        End Set
    End Property
    Public Property Careof() As String
        Get
            Return _Careof
        End Get
        Set(ByVal value As String)
            _Careof = value
        End Set
    End Property
    Public Property Address1() As String
        Get
            Return _Address1
        End Get
        Set(ByVal value As String)
            If _Address1 = value Then
                Return
            End If
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
    Public Property Office() As String
        Get
            Return _Office
        End Get
        Set(ByVal value As String)
            _Office = value
        End Set
    End Property
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            If _Age = value Then
                Return
            End If
            _Age = value
        End Set
    End Property
    Public Property TelNo() As String
        Get
            Return _TelNo
        End Get
        Set(ByVal value As String)
            _TelNo = value
        End Set
    End Property
    Public Property OfficeNo() As String
        Get
            Return _OfficeNo
        End Get
        Set(ByVal value As String)
            _OfficeNo = value
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
    Public Property DueDate() As DateTime
        Get
            Return _DueDate
        End Get
        Set(ByVal value As DateTime)
            _DueDate = value
        End Set
    End Property
    Public Property BillNo() As String
        Get
            Return _BillNo
        End Get
        Set(ByVal value As String)
            _BillNo = value
        End Set
    End Property
    Public Property Lense() As String
        Get
            Return _Lense
        End Get
        Set(ByVal value As String)
            _Lense = value
        End Set
    End Property
    Public Property Frame() As String
        Get
            Return _Frame
        End Get
        Set(ByVal value As String)
            If _Frame = value Then
                Return
            End If
            _Frame = value
        End Set
    End Property
    Public Property Segment() As String
        Get
            Return _Segment
        End Get
        Set(ByVal value As String)
            _Segment = value
        End Set
    End Property
    Public Property Pd() As String
        Get
            Return _Pd
        End Get
        Set(ByVal value As String)
            If _Pd = value Then
                Return
            End If
            _Pd = value
        End Set
    End Property
    Public Property Insert() As String
        Get
            Return _Insert
        End Get
        Set(ByVal value As String)
            _Insert = value
        End Set
    End Property
    Public Property Refracted() As String
        Get
            Return _Refracted
        End Get
        Set(ByVal value As String)
            _Refracted = value
        End Set
    End Property
    Public Property Dispensed() As String
        Get
            Return _Dispensed
        End Get
        Set(ByVal value As String)
            _Dispensed = value
        End Set
    End Property
    Public Property Orderno() As String
        Get
            Return _Orderno
        End Get
        Set(ByVal value As String)
            _Orderno = value
        End Set
    End Property
    Public Property Fullamount() As Decimal
        Get
            Return _Fullamount
        End Get
        Set(ByVal value As Decimal)
            _Fullamount = value
        End Set
    End Property
    Public Property Specialcharges() As Decimal
        Get
            Return _Specialcharges
        End Get
        Set(ByVal value As Decimal)
            _Specialcharges = value
        End Set
    End Property
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            If _Total = value Then
                Return
            End If
            _Total = value
        End Set
    End Property
    Public Property Remarks() As String
        Get
            Return _Remarks
        End Get
        Set(ByVal value As String)
            If _Remarks = value Then
                Return
            End If
            _Remarks = value
        End Set
    End Property
    Public Property Ready() As Boolean
        Get
            Return _Ready
        End Get
        Set(ByVal value As Boolean)
            _Ready = value
        End Set
    End Property
    Public Property Delivered() As String
        Get
            Return _Delivered
        End Get
        Set(ByVal value As String)
            _Delivered = value
        End Set
    End Property
    Public Property AttendedBy() As String
        Get
            Return _AttendedBy
        End Get
        Set(ByVal value As String)
            _AttendedBy = value
        End Set
    End Property
    Public Property MobileNo() As String
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As String)
            _MobileNo = value
        End Set
    End Property
    Public Property DelivaryDate() As Date
        Get
            Return _DelivaryDate
        End Get
        Set(ByVal value As Date)
            _DelivaryDate = value
        End Set
    End Property

    Public Property InLx() As String
        Get
            Return _InLx
        End Get
        Set(ByVal value As String)
            _InLx = value
        End Set
    End Property
    Public Property InLy() As String
        Get
            Return _InLy
        End Get
        Set(ByVal value As String)
            _InLy = value
        End Set
    End Property
    Public Property InL1() As String
        Get
            Return _InL1
        End Get
        Set(ByVal value As String)
            _InL1 = value
        End Set
    End Property
    Public Property InL2() As String
        Get
            Return _InL2
        End Get
        Set(ByVal value As String)
            _InL2 = value
        End Set
    End Property
    Public Property InL3() As String
        Get
            Return _InL3
        End Get
        Set(ByVal value As String)
            If _InL3 = value Then
                Return
            End If
            _InL3 = value
        End Set
    End Property
    Public Property InL4() As String
        Get
            Return _InL4
        End Get
        Set(ByVal value As String)
            _InL4 = value
        End Set
    End Property
    Public Property InL5() As String
        Get
            Return _InL5
        End Get
        Set(ByVal value As String)
            If _InL5 = value Then
                Return
            End If
            _InL5 = value
        End Set
    End Property
    Public Property InL6() As String
        Get
            Return _InL6
        End Get
        Set(ByVal value As String)
            _InL6 = value
        End Set
    End Property
    Public Property InR1() As String
        Get
            Return _InR1
        End Get
        Set(ByVal value As String)
            _InR1 = value
        End Set
    End Property
    Public Property InR2() As String
        Get
            Return _InR2
        End Get
        Set(ByVal value As String)
            _InR2 = value
        End Set
    End Property
    Public Property InR3() As String
        Get
            Return _InR3
        End Get
        Set(ByVal value As String)
            If _InR3 = value Then
                Return
            End If
            _InR3 = value
        End Set
    End Property
    Public Property InR4() As String
        Get
            Return _InR4
        End Get
        Set(ByVal value As String)
            _InR4 = value
        End Set
    End Property
    Public Property InR5() As String
        Get
            Return _InR5
        End Get
        Set(ByVal value As String)
            If _InR5 = value Then
                Return
            End If
            _InR5 = value
        End Set
    End Property
    Public Property InR6() As String
        Get
            Return _InR6
        End Get
        Set(ByVal value As String)
            _InR6 = value
        End Set
    End Property
    Public Property InRx() As String
        Get
            Return _InRx
        End Get
        Set(ByVal value As String)
            If _InRx = value Then
                Return
            End If
            _InRx = value
        End Set
    End Property
    Public Property InRy() As String
        Get
            Return _InRy
        End Get
        Set(ByVal value As String)
            If _InRy = value Then
                Return
            End If
            _InRy = value
        End Set
    End Property

    Public Property IxLx() As String
        Get
            Return _IxLx
        End Get
        Set(ByVal value As String)
            _IxLx = value
        End Set
    End Property
    Public Property IxLy() As String
        Get
            Return _IxLy
        End Get
        Set(ByVal value As String)
            _IxLy = value
        End Set
    End Property
    Public Property IxL1() As String
        Get
            Return _IxL1
        End Get
        Set(ByVal value As String)
            If _IxL1 = value Then
                Return
            End If
            _IxL1 = value
        End Set
    End Property
    Public Property IxL2() As String
        Get
            Return _IxL2
        End Get
        Set(ByVal value As String)
            _IxL2 = value
        End Set
    End Property
    Public Property IxL3() As String
        Get
            Return _IxL3
        End Get
        Set(ByVal value As String)
            _IxL3 = value
        End Set
    End Property
    Public Property IxL4() As String
        Get
            Return _IxL4
        End Get
        Set(ByVal value As String)
            If _IxL4 = value Then
                Return
            End If
            _IxL4 = value
        End Set
    End Property
    Public Property IxL5() As String
        Get
            Return _IxL5
        End Get
        Set(ByVal value As String)
            _IxL5 = value
        End Set
    End Property
    Public Property IxL6() As String
        Get
            Return _IxL6
        End Get
        Set(ByVal value As String)
            _IxL6 = value
        End Set
    End Property
    Public Property IxR1() As String
        Get
            Return _IxR1
        End Get
        Set(ByVal value As String)
            If _IxR1 = value Then
                Return
            End If
            _IxR1 = value
        End Set
    End Property
    Public Property IxR2() As String
        Get
            Return _IxR2
        End Get
        Set(ByVal value As String)
            _IxR2 = value
        End Set
    End Property
    Public Property IxR3() As String
        Get
            Return _IxR3
        End Get
        Set(ByVal value As String)
            _IxR3 = value
        End Set
    End Property
    Public Property IxR4() As String
        Get
            Return _IxR4
        End Get
        Set(ByVal value As String)
            _IxR4 = value
        End Set
    End Property
    Public Property IxR5() As String
        Get
            Return _IxR5
        End Get
        Set(ByVal value As String)
            _IxR5 = value
        End Set
    End Property
    Public Property IxR6() As String
        Get
            Return _IxR6
        End Get
        Set(ByVal value As String)
            _IxR6 = value
        End Set
    End Property
    Public Property IxRx() As String
        Get
            Return _IxRx
        End Get
        Set(ByVal value As String)
            _IxRx = value
        End Set
    End Property
    Public Property IxRy() As String
        Get
            Return _IxRy
        End Get
        Set(ByVal value As String)
            _IxRy = value
        End Set
    End Property

    Public Property HxLx() As String
        Get
            Return _HxLx
        End Get
        Set(ByVal value As String)
            _HxLx = value
        End Set
    End Property
    Public Property HxLy() As String
        Get
            Return _HxLy
        End Get
        Set(ByVal value As String)
            _HxLy = value
        End Set
    End Property
    Public Property HxL1() As String
        Get
            Return _HxL1
        End Get
        Set(ByVal value As String)

            _HxL1 = value
        End Set
    End Property
    Public Property HxL2() As String
        Get
            Return _HxL2
        End Get
        Set(ByVal value As String)
            _HxL2 = value
        End Set
    End Property
    Public Property HxL3() As String
        Get
            Return _HxL3
        End Get
        Set(ByVal value As String)
            _HxL3 = value
        End Set
    End Property
    Public Property HxL4() As String
        Get
            Return _HxL4
        End Get
        Set(ByVal value As String)

            _HxL4 = value
        End Set
    End Property
    Public Property HxL5() As String
        Get
            Return _HxL5
        End Get
        Set(ByVal value As String)
            _HxL5 = value
        End Set
    End Property
    Public Property HxL6() As String
        Get
            Return _HxL6
        End Get
        Set(ByVal value As String)
            _HxL6 = value
        End Set
    End Property
    Public Property HxR1() As String
        Get
            Return _HxR1
        End Get
        Set(ByVal value As String)

            _HxR1 = value
        End Set
    End Property
    Public Property HxR2() As String
        Get
            Return _HxR2
        End Get
        Set(ByVal value As String)
            _HxR2 = value
        End Set
    End Property
    Public Property HxR3() As String
        Get
            Return _HxR3
        End Get
        Set(ByVal value As String)
            _HxR3 = value
        End Set
    End Property
    Public Property HxR4() As String
        Get
            Return _HxR4
        End Get
        Set(ByVal value As String)
            _HxR4 = value
        End Set
    End Property
    Public Property HxR5() As String
        Get
            Return _HxR5
        End Get
        Set(ByVal value As String)
            _HxR5 = value
        End Set
    End Property
    Public Property HxR6() As String
        Get
            Return _HxR6
        End Get
        Set(ByVal value As String)
            _HxR6 = value
        End Set
    End Property
    Public Property HxRx() As String
        Get
            Return _HxRx
        End Get
        Set(ByVal value As String)
            _HxRx = value
        End Set
    End Property
    Public Property HxRy() As String
        Get
            Return _HxRy
        End Get
        Set(ByVal value As String)
            _HxRy = value
        End Set
    End Property

    Public Property InIOPLx()
        Get
            Return _InIOPLx
        End Get
        Set(ByVal value)
            _InIOPLx = value
        End Set
    End Property
    Public Property InIOPLy()
        Get
            Return _InIOPLy
        End Get
        Set(ByVal value)
            _InIOPLy = value
        End Set
    End Property
    Public Property ExIOPLx()
        Get
            Return _ExIOPLx
        End Get
        Set(ByVal value)
            _ExIOPLx = value
        End Set
    End Property
    Public Property ExIOPLy()
        Get
            Return _ExIOPLy
        End Get
        Set(ByVal value)
            _ExIOPLy = value
        End Set
    End Property
    Public Property HbIOPLx()
        Get
            Return _HbIOPLx
        End Get
        Set(ByVal value)
            _HbIOPLx = value
        End Set
    End Property
    Public Property HbIOPLy()
        Get
            Return _HbIOPLy
        End Get
        Set(ByVal value)
            _HbIOPLy = value
        End Set
    End Property

    Public Property InIOPRx()
        Get
            Return _InIOPRx
        End Get
        Set(ByVal value)
            _InIOPRx = value
        End Set
    End Property
    Public Property InIOPRy()
        Get
            Return _InIOPRy
        End Get
        Set(ByVal value)
            _InIOPRy = value
        End Set
    End Property
    Public Property ExIOPRx()
        Get
            Return _ExIOPRx
        End Get
        Set(ByVal value)
            _ExIOPRx = value
        End Set
    End Property
    Public Property ExIOPRy()
        Get
            Return _ExIOPRy
        End Get
        Set(ByVal value)
            _ExIOPRy = value
        End Set
    End Property
    Public Property HbIOPRx()
        Get
            Return _HbIOPRx
        End Get
        Set(ByVal value)
            _HbIOPRx = value
        End Set
    End Property
    Public Property HbIOPRy()
        Get
            Return _HbIOPRy
        End Get
        Set(ByVal value)
            _HbIOPRy = value
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

    Public Property NICNo() As String
        Get
            Return _NICNo
        End Get
        Set(ByVal value As String)
            _NICNo = value
        End Set
    End Property
    Public Property Advance() As Decimal
        Get
            Return _Advance
        End Get
        Set(ByVal value As Decimal)
            _Advance = value
        End Set
    End Property
    Public Property ReceiptID() As Int64
        Get
            Return _ReceiptID
        End Get
        Set(ByVal value As Int64)
            _ReceiptID = value
        End Set
    End Property

    Public Property LenseStockID() As Int64
        Get
            Return _LenseStockID
        End Get
        Set(ByVal value As Int64)
            _LenseStockID = value
        End Set
    End Property

    Public Property FrameStockID() As Int64
        Get
            Return _FrameStockID
        End Get
        Set(ByVal value As Int64)
            _FrameStockID = value
        End Set
    End Property

    Public Property LenseQty() As Decimal
        Get
            Return _LenseQty
        End Get
        Set(ByVal value As Decimal)
            _LenseQty = value
        End Set
    End Property

    Public Property FrameQty() As Int32
        Get
            Return _FrameQty
        End Get
        Set(ByVal value As Int32)
            _FrameQty = value
        End Set
    End Property

    Public Property LensePrice() As Decimal
        Get
            Return _LensePrice
        End Get
        Set(ByVal value As Decimal)
            _LensePrice = value
        End Set
    End Property

    Public Property FramePrice() As Decimal
        Get
            Return _FramePrice
        End Get
        Set(ByVal value As Decimal)
            _FramePrice = value
        End Set
    End Property

#End Region

#Region "Insert Prescription"

    Public Sub InsertPrescription(ByVal DB As Database, ByVal transaction As DbTransaction)

        Try

            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTION_INSERT)

            DB.AddInParameter(DBC, "@PrescriptionID", DbType.Int64, Me.PrescriptionID)
            'DB.AddInParameter(DBC, "@SysNo", DbType.String, Me.SysNo)
            DB.AddInParameter(DBC, "@Salutation1", DbType.String, Me.Salutation1)
            DB.AddInParameter(DBC, "@Name", DbType.String, Me.Name)
            DB.AddInParameter(DBC, "@Salutation2", DbType.String, Me.Salutation2)
            DB.AddInParameter(DBC, "@Careof", DbType.String, Me.Careof)
            DB.AddInParameter(DBC, "@Address1", DbType.String, Me.Address1)
            DB.AddInParameter(DBC, "@Address2", DbType.String, Me.Address2)
            DB.AddInParameter(DBC, "@Address3", DbType.String, Me.Address3)
            DB.AddInParameter(DBC, "@Office", DbType.String, Me.Office)
            DB.AddInParameter(DBC, "@Age", DbType.Int32, Me.Age)
            DB.AddInParameter(DBC, "@TelNo", DbType.String, Me.TelNo)
            DB.AddInParameter(DBC, "@OfficeNo", DbType.String, Me.OfficeNo)
            DB.AddInParameter(DBC, "@PrescriptionDate", DbType.DateTime, Me.PrescriptionDate)
            DB.AddInParameter(DBC, "@BillNo", DbType.String, Me.BillNo)
            DB.AddInParameter(DBC, "@DueDate", DbType.DateTime, Me.DueDate)
            DB.AddInParameter(DBC, "@Lense", DbType.String, Me.Lense)
            DB.AddInParameter(DBC, "@Frame", DbType.String, Me.Frame)
            DB.AddInParameter(DBC, "@Segment", DbType.String, Me.Segment)
            DB.AddInParameter(DBC, "@Pd", DbType.String, Me.Pd)
            DB.AddInParameter(DBC, "@Insert", DbType.String, Me.Insert)
            DB.AddInParameter(DBC, "@Refracted", DbType.String, Me.Refracted)
            DB.AddInParameter(DBC, "@Dispensed", DbType.String, Me.Dispensed)
            DB.AddInParameter(DBC, "@Orderno", DbType.String, Me.Orderno)
            DB.AddInParameter(DBC, "@Fullamount", DbType.Currency, Me.Fullamount)
            DB.AddInParameter(DBC, "@Specialcharges", DbType.Currency, Me.Specialcharges)
            DB.AddInParameter(DBC, "@Total", DbType.Currency, Me.Total)
            DB.AddInParameter(DBC, "@Remarks", DbType.String, Me.Remarks)
            DB.AddInParameter(DBC, "@Ready", DbType.Boolean, Me.Ready)
            DB.AddInParameter(DBC, "@Delivered", DbType.Boolean, Me.Delivered)
            DB.AddInParameter(DBC, "@AttendedBy", DbType.String, Me.AttendedBy)
            DB.AddInParameter(DBC, "@NICNo", DbType.String, Me.NICNo)
            DB.AddInParameter(DBC, "@MobileNo", DbType.String, Me.MobileNo)

            If (Me.DelivaryDate = Date.MinValue) Then
                DB.AddInParameter(DBC, "@DelivaryDate", DbType.Date, Nothing)
            Else
                DB.AddInParameter(DBC, "@DelivaryDate", DbType.Date, Me.DelivaryDate)

            End If

            DB.AddInParameter(DBC, "@LenseStockID", DbType.Int64, Me.LenseStockID)
            DB.AddInParameter(DBC, "@FrameStockID", DbType.Int64, Me.FrameStockID)
            DB.AddInParameter(DBC, "@LenseQty", DbType.Decimal, Me.LenseQty)
            DB.AddInParameter(DBC, "@FrameQty", DbType.Decimal, Me.FrameQty)
            DB.AddInParameter(DBC, "@LensePrice", DbType.Decimal, Me.LensePrice)
            DB.AddInParameter(DBC, "@FramePrice", DbType.Decimal, Me.FramePrice)


            DB.AddOutParameter(DBC, "@CurrentSysNo", DbType.String, 10)
            DB.AddOutParameter(DBC, "@NewPrescriptionID", DbType.Int64, 10)


            DB.ExecuteNonQuery(DBC, transaction)

            Dim newid As String
            newid = DB.GetParameterValue(DBC, "@CurrentSysNo").ToString

            If (newid = String.Empty) Then
                newid = Me.SysNo
            End If


            Dim newprescriptionID As Int64
            newprescriptionID = Convert.ToInt64(DB.GetParameterValue(DBC, "@NewPrescriptionID").ToString)

            If (newprescriptionID <> -1) Then
                Me.PrescriptionID = newprescriptionID
            End If

            Dim DBI As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTIONINTERNAL_INSERT)
            DB.AddInParameter(DBI, "@SysNo", DbType.String, newid)
            DB.AddInParameter(DBI, "@Lx", DbType.String, Me.InLx)
            DB.AddInParameter(DBI, "@Ly", DbType.String, Me.InLy)
            DB.AddInParameter(DBI, "@L1", DbType.String, Me.InL1)
            DB.AddInParameter(DBI, "@L2", DbType.String, Me.InL2)
            DB.AddInParameter(DBI, "@L3", DbType.String, Me.InL3)
            DB.AddInParameter(DBI, "@L4", DbType.String, Me.InL4)
            DB.AddInParameter(DBI, "@L5", DbType.String, Me.InL5)
            DB.AddInParameter(DBI, "@L6", DbType.String, Me.InL6)

            DB.AddInParameter(DBI, "@IOPLx", DbType.String, Me.InIOPLx)
            DB.AddInParameter(DBI, "@IOPLy", DbType.String, Me.InIOPLy)


            DB.AddInParameter(DBI, "@R1", DbType.String, Me.InR1)
            DB.AddInParameter(DBI, "@R2", DbType.String, Me.InR2)
            DB.AddInParameter(DBI, "@R3", DbType.String, Me.InR3)
            DB.AddInParameter(DBI, "@R4", DbType.String, Me.InR4)
            DB.AddInParameter(DBI, "@R5", DbType.String, Me.InR5)
            DB.AddInParameter(DBI, "@R6", DbType.String, Me.InR6)
            DB.AddInParameter(DBI, "@Rx", DbType.String, Me.InRx)
            DB.AddInParameter(DBI, "@Ry", DbType.String, Me.InRy)

            DB.AddInParameter(DBI, "@IOPRx", DbType.String, Me.InIOPRx)
            DB.AddInParameter(DBI, "@IOPRy", DbType.String, Me.InIOPRy)


            DB.ExecuteNonQuery(DBI)

            Dim DBX As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTIONEXTERNAL_INSERT)
            DB.AddInParameter(DBX, "@SysNo", DbType.String, newid)
            DB.AddInParameter(DBX, "@Lx", DbType.String, Me.IxLx)
            DB.AddInParameter(DBX, "@Ly", DbType.String, Me.IxLy)
            DB.AddInParameter(DBX, "@L1", DbType.String, Me.IxL1)
            DB.AddInParameter(DBX, "@L2", DbType.String, Me.IxL2)
            DB.AddInParameter(DBX, "@L3", DbType.String, Me.IxL3)
            DB.AddInParameter(DBX, "@L4", DbType.String, Me.IxL4)
            DB.AddInParameter(DBX, "@L5", DbType.String, Me.IxL5)
            DB.AddInParameter(DBX, "@L6", DbType.String, Me.IxL6)

            DB.AddInParameter(DBX, "@IOPLx", DbType.String, Me.ExIOPLx)
            DB.AddInParameter(DBX, "@IOPLy", DbType.String, Me.ExIOPLy)

            DB.AddInParameter(DBX, "@R1", DbType.String, Me.IxR1)
            DB.AddInParameter(DBX, "@R2", DbType.String, Me.IxR2)
            DB.AddInParameter(DBX, "@R3", DbType.String, Me.IxR3)
            DB.AddInParameter(DBX, "@R4", DbType.String, Me.IxR4)
            DB.AddInParameter(DBX, "@R5", DbType.String, Me.IxR5)
            DB.AddInParameter(DBX, "@R6", DbType.String, Me.IxR6)
            DB.AddInParameter(DBX, "@Rx", DbType.String, Me.IxRx)
            DB.AddInParameter(DBX, "@Ry", DbType.String, Me.IxRy)

            DB.AddInParameter(DBX, "@IOPRx", DbType.String, Me.ExIOPRx)
            DB.AddInParameter(DBX, "@IOPRy", DbType.String, Me.ExIOPRy)

            DB.ExecuteNonQuery(DBX)

            Dim DBH As DbCommand = DB.GetStoredProcCommand(PRESCRIPTIONHBRX_INSERT)
            DB.AddInParameter(DBH, "@SysNo", DbType.String, newid)
            DB.AddInParameter(DBH, "@Lx", DbType.String, Me.HxLx)
            DB.AddInParameter(DBH, "@Ly", DbType.String, Me.HxLy)
            DB.AddInParameter(DBH, "@L1", DbType.String, Me.HxL1)
            DB.AddInParameter(DBH, "@L2", DbType.String, Me.HxL2)
            DB.AddInParameter(DBH, "@L3", DbType.String, Me.HxL3)
            DB.AddInParameter(DBH, "@L4", DbType.String, Me.HxL4)
            DB.AddInParameter(DBH, "@L5", DbType.String, Me.HxL5)
            DB.AddInParameter(DBH, "@L6", DbType.String, Me.HxL6)

            DB.AddInParameter(DBH, "@IOPLx", DbType.String, Me.HbIOPLx)
            DB.AddInParameter(DBH, "@IOPLy", DbType.String, Me.HbIOPLy)

            DB.AddInParameter(DBH, "@R1", DbType.String, Me.HxR1)
            DB.AddInParameter(DBH, "@R2", DbType.String, Me.HxR2)
            DB.AddInParameter(DBH, "@R3", DbType.String, Me.HxR3)
            DB.AddInParameter(DBH, "@R4", DbType.String, Me.HxR4)
            DB.AddInParameter(DBH, "@R5", DbType.String, Me.HxR5)
            DB.AddInParameter(DBH, "@R6", DbType.String, Me.HxR6)
            DB.AddInParameter(DBH, "@Rx", DbType.String, Me.HxRx)
            DB.AddInParameter(DBH, "@Ry", DbType.String, Me.HxRy)

            DB.AddInParameter(DBH, "@IOPRx", DbType.String, Me.HbIOPRx)
            DB.AddInParameter(DBH, "@IOPRy", DbType.String, Me.HbIOPRy)








            DB.ExecuteNonQuery(DBH)



        Catch ex As Exception




        End Try

    End Sub

#End Region

#Region "Get Prescription By Prescription By ID"
    Public Function GetPrescriptionByID(ByVal DB As Database, ByVal transaction As DbTransaction) As Boolean

        Dim result As Boolean
        result = False


        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTION_SELECTBYID)

        Try
            DB.AddInParameter(DBC, "@PrescriptionID", DbType.String, Me.PrescriptionID)

            Using DR As IDataReader = DB.ExecuteReader(DBC, transaction)

                With DR
                    Do While .Read
                        Me.PrescriptionID = Convert.ToInt64(IIf(Not IsDBNull(.Item("PrescriptionID")), Trim(.Item("PrescriptionID").ToString), 0))
                        Me.SysNo = IIf(Not IsDBNull(.Item("SysNo")), Trim(.Item("SysNo").ToString), String.Empty)
                        Me.Salutation1 = IIf(Not IsDBNull(.Item("Salutation1")), Trim(.Item("Salutation1").ToString), String.Empty)
                        Me.Name = IIf(Not IsDBNull(.Item("Name")), Trim(.Item("Name").ToString), String.Empty)
                        Me.Salutation2 = IIf(Not IsDBNull(.Item("Salutation2")), Trim(.Item("Salutation2").ToString), String.Empty)
                        Me.Careof = IIf(Not IsDBNull(.Item("Careof")), Trim(.Item("Careof").ToString), String.Empty)
                        Me.Address1 = IIf(Not IsDBNull(.Item("Address1")), Trim(.Item("Address1").ToString), String.Empty)
                        Me.Address2 = IIf(Not IsDBNull(.Item("Address2")), Trim(.Item("Address2").ToString), String.Empty)
                        Me.Address3 = IIf(Not IsDBNull(.Item("Address3")), Trim(.Item("Address3").ToString), String.Empty)
                        Me.Office = IIf(Not IsDBNull(.Item("Office")), Trim(.Item("Office").ToString), String.Empty)

                        'Dim _Age As Integer
                        '_Age = 0

                        'Integer.TryParse(.Item("Age").ToString, _Age)

                        'Me.Age = _Age
                        Me.Age = Val(.Item("Age"))

                        Me.TelNo = IIf(Not IsDBNull(.Item("TelNo")), Trim(.Item("TelNo").ToString), String.Empty)
                        Me.OfficeNo = IIf(Not IsDBNull(.Item("OfficeNo")), Trim(.Item("OfficeNo").ToString), String.Empty)
                        Me.PrescriptionDate = IIf(Not IsDBNull(.Item("PrescriptionDate")), DateTime.Parse(.Item("PrescriptionDate").ToString), String.Empty)
                        Me.DueDate = IIf(Not IsDBNull(.Item("DueDate")), DateTime.Parse(.Item("DueDate").ToString), String.Empty)
                        Me.BillNo = IIf(Not IsDBNull(.Item("BillNo")), Trim(.Item("BillNo").ToString), String.Empty)
                        Me.Lense = IIf(Not IsDBNull(.Item("Lense")), Trim(.Item("Lense").ToString), String.Empty)
                        Me.Frame = IIf(Not IsDBNull(.Item("Frame")), Trim(.Item("Frame").ToString), String.Empty)
                        Me.Segment = IIf(Not IsDBNull(.Item("Segment")), Trim(.Item("Segment").ToString), String.Empty)
                        Me.Pd = IIf(Not IsDBNull(.Item("Pd")), Trim(.Item("Pd").ToString), String.Empty)
                        Me.Insert = IIf(Not IsDBNull(.Item("Insert")), Trim(.Item("Insert").ToString), String.Empty)
                        Me.Refracted = IIf(Not IsDBNull(.Item("Refracted")), Trim(.Item("Refracted").ToString), String.Empty)
                        Me.Dispensed = IIf(Not IsDBNull(.Item("Dispensed")), Trim(.Item("Dispensed").ToString), String.Empty)
                        Me.Orderno = IIf(Not IsDBNull(.Item("Orderno")), Trim(.Item("Orderno").ToString), String.Empty)
                        Me.Fullamount = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Fullamount")), .Item("Fullamount").ToString, 0))
                        Me.Specialcharges = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Specialcharges")), .Item("Specialcharges").ToString, 0))
                        Me.Total = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Total")), Trim(.Item("Total").ToString), 0))
                        Me.Remarks = IIf(Not IsDBNull(.Item("Remarks")), Trim(.Item("Remarks").ToString), String.Empty)
                        Me.Ready = IIf(Not IsDBNull(.Item("Ready")), Boolean.Parse(Trim(.Item("Ready").ToString)), String.Empty)
                        Me.Delivered = IIf(Not IsDBNull(.Item("Delivered")), Boolean.Parse(Trim(.Item("Delivered").ToString)), String.Empty)
                        Me.AttendedBy = IIf(Not IsDBNull(.Item("AttendedBy")), Trim(.Item("AttendedBy").ToString), String.Empty)
                        Me.NICNo = IIf(Not IsDBNull(.Item("NICNo")), Trim(.Item("NICNo").ToString), String.Empty)
                        Me.MobileNo = IIf(Not IsDBNull(.Item("MobileNo")), Trim(.Item("MobileNo").ToString), String.Empty)

                        Me.Advance = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Advance")), Trim(.Item("Advance").ToString), 0))
                        Me.ReceiptID = Convert.ToInt64(IIf(Not IsDBNull(.Item("ReceiptID")), Trim(.Item("ReceiptID").ToString), 0))
                        Me.DelivaryDate = Convert.ToDateTime(IIf(Not IsDBNull(.Item("DelivaryDate")), .Item("DelivaryDate").ToString, Date.MinValue))

                        Me.LenseStockID = Convert.ToInt64(IIf(Not IsDBNull(.Item("LenseStockID")), Trim(.Item("LenseStockID").ToString), 0))
                        Me.FrameStockID = Convert.ToInt64(IIf(Not IsDBNull(.Item("FrameStockID")), Trim(.Item("FrameStockID").ToString), 0))
                        Me.LenseQty = Convert.ToDecimal(IIf(Not IsDBNull(.Item("LenseQty")), Trim(.Item("LenseQty").ToString), 0))
                        Me.FrameQty = Convert.ToInt32(IIf(Not IsDBNull(.Item("FrameQty")), Trim(.Item("FrameQty").ToString), 0))
                        Me.LensePrice = Convert.ToDecimal(IIf(Not IsDBNull(.Item("LensePrice")), Trim(.Item("LensePrice").ToString), 0))
                        Me.FramePrice = Convert.ToDecimal(IIf(Not IsDBNull(.Item("FramePrice")), Trim(.Item("FramePrice").ToString), 0))

                        result = True

                    Loop
                End With

                If (Not DR Is Nothing) Then
                    DR.Close()
                End If

            End Using


            Dim DBX As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTIONINTERNAL_SELECTBYID)

            DB.AddInParameter(DBX, "@SysNo", DbType.String, Me.SysNo)
            Using DRX As IDataReader = DB.ExecuteReader(DBX)


                Me.InLx = String.Empty
                Me.InLy = String.Empty
                Me.InL1 = String.Empty
                Me.InL2 = String.Empty
                Me.InL3 = String.Empty
                Me.InL4 = String.Empty
                Me.InL5 = String.Empty
                Me.InL6 = String.Empty

                Me.InRx = String.Empty
                Me.InRy = String.Empty
                Me.InR1 = String.Empty
                Me.InR2 = String.Empty
                Me.InR3 = String.Empty
                Me.InR4 = String.Empty
                Me.InR5 = String.Empty
                Me.InR6 = String.Empty

                Me.InIOPLx = String.Empty
                Me.InIOPLy = String.Empty
                Me.InIOPRx = String.Empty
                Me.InIOPRy = String.Empty


                With DRX
                    Do While .Read

                        Me.InLx = IIf(Not IsDBNull(.Item("Lx")), Trim(.Item("Lx").ToString), String.Empty)
                        Me.InLy = IIf(Not IsDBNull(.Item("Ly")), Trim(.Item("Ly").ToString), String.Empty)
                        Me.InL1 = IIf(Not IsDBNull(.Item("L1")), Trim(.Item("L1").ToString), String.Empty)
                        Me.InL2 = IIf(Not IsDBNull(.Item("L2")), Trim(.Item("L2").ToString), String.Empty)
                        Me.InL3 = IIf(Not IsDBNull(.Item("L3")), Trim(.Item("L3").ToString), String.Empty)
                        Me.InL4 = IIf(Not IsDBNull(.Item("L4")), Trim(.Item("L4").ToString), String.Empty)
                        Me.InL5 = IIf(Not IsDBNull(.Item("L5")), Trim(.Item("L5").ToString), String.Empty)
                        Me.InL6 = IIf(Not IsDBNull(.Item("L6")), Trim(.Item("L6").ToString), String.Empty)

                        Me.InIOPLx = IIf(Not IsDBNull(.Item("IOPLx")), Trim(.Item("IOPLx").ToString), String.Empty)
                        Me.InIOPLy = IIf(Not IsDBNull(.Item("IOPLy")), Trim(.Item("IOPLy").ToString), String.Empty)


                        Me.InRx = IIf(Not IsDBNull(.Item("Rx")), Trim(.Item("Rx").ToString), String.Empty)
                        Me.InRy = IIf(Not IsDBNull(.Item("Ry")), Trim(.Item("Ry").ToString), String.Empty)
                        Me.InR1 = IIf(Not IsDBNull(.Item("R1")), Trim(.Item("R1").ToString), String.Empty)
                        Me.InR2 = IIf(Not IsDBNull(.Item("R2")), Trim(.Item("R2").ToString), String.Empty)
                        Me.InR3 = IIf(Not IsDBNull(.Item("R3")), Trim(.Item("R3").ToString), String.Empty)
                        Me.InR4 = IIf(Not IsDBNull(.Item("R4")), Trim(.Item("R4").ToString), String.Empty)
                        Me.InR5 = IIf(Not IsDBNull(.Item("R5")), Trim(.Item("R5").ToString), String.Empty)
                        Me.InR6 = IIf(Not IsDBNull(.Item("R6")), Trim(.Item("R6").ToString), String.Empty)

                        Me.InIOPRx = IIf(Not IsDBNull(.Item("IOPRx")), Trim(.Item("IOPRx").ToString), String.Empty)
                        Me.InIOPRy = IIf(Not IsDBNull(.Item("IOPRy")), Trim(.Item("IOPRy").ToString), String.Empty)


                    Loop

                End With

                If (Not DRX Is Nothing) Then



                    DRX.Close()
                End If

            End Using



            Dim DBY As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTIONEXTERNAL_SELECTBYID)
            DB.AddInParameter(DBY, "@SysNo", DbType.String, Me.SysNo)
            Using DRY As IDataReader = DB.ExecuteReader(DBY)

                Me.IxLx = String.Empty
                Me.IxLy = String.Empty
                Me.IxL1 = String.Empty
                Me.IxL2 = String.Empty
                Me.IxL3 = String.Empty
                Me.IxL4 = String.Empty
                Me.IxL5 = String.Empty
                Me.IxL6 = String.Empty

                Me.IxRx = String.Empty
                Me.IxRy = String.Empty
                Me.IxR1 = String.Empty
                Me.IxR2 = String.Empty
                Me.IxR3 = String.Empty
                Me.IxR4 = String.Empty
                Me.IxR5 = String.Empty
                Me.IxR6 = String.Empty


                Me.ExIOPLx = String.Empty
                Me.ExIOPLy = String.Empty
                Me.ExIOPRx = String.Empty
                Me.ExIOPRy = String.Empty

                With DRY
                    Do While .Read

                        Me.IxLx = IIf(Not IsDBNull(.Item("Lx")), Trim(.Item("Lx").ToString), String.Empty)
                        Me.IxLy = IIf(Not IsDBNull(.Item("Ly")), Trim(.Item("Ly").ToString), String.Empty)
                        Me.IxL1 = IIf(Not IsDBNull(.Item("L1")), Trim(.Item("L1").ToString), String.Empty)
                        Me.IxL2 = IIf(Not IsDBNull(.Item("L2")), Trim(.Item("L2").ToString), String.Empty)
                        Me.IxL3 = IIf(Not IsDBNull(.Item("L3")), Trim(.Item("L3").ToString), String.Empty)
                        Me.IxL4 = IIf(Not IsDBNull(.Item("L4")), Trim(.Item("L4").ToString), String.Empty)
                        Me.IxL5 = IIf(Not IsDBNull(.Item("L5")), Trim(.Item("L5").ToString), String.Empty)
                        Me.IxL6 = IIf(Not IsDBNull(.Item("L6")), Trim(.Item("L6").ToString), String.Empty)

                        Me.ExIOPLx = IIf(Not IsDBNull(.Item("IOPLx")), Trim(.Item("IOPLx").ToString), String.Empty)
                        Me.ExIOPLy = IIf(Not IsDBNull(.Item("IOPLy")), Trim(.Item("IOPLy").ToString), String.Empty)


                        Me.IxRx = IIf(Not IsDBNull(.Item("Rx")), Trim(.Item("Rx").ToString), String.Empty)
                        Me.IxRy = IIf(Not IsDBNull(.Item("Ry")), Trim(.Item("Ry").ToString), String.Empty)
                        Me.IxR1 = IIf(Not IsDBNull(.Item("R1")), Trim(.Item("R1").ToString), String.Empty)
                        Me.IxR2 = IIf(Not IsDBNull(.Item("R2")), Trim(.Item("R2").ToString), String.Empty)
                        Me.IxR3 = IIf(Not IsDBNull(.Item("R3")), Trim(.Item("R3").ToString), String.Empty)
                        Me.IxR4 = IIf(Not IsDBNull(.Item("R4")), Trim(.Item("R4").ToString), String.Empty)
                        Me.IxR5 = IIf(Not IsDBNull(.Item("R5")), Trim(.Item("R5").ToString), String.Empty)
                        Me.IxR6 = IIf(Not IsDBNull(.Item("R6")), Trim(.Item("R6").ToString), String.Empty)


                        Me.ExIOPRx = IIf(Not IsDBNull(.Item("IOPRx")), Trim(.Item("IOPRx").ToString), String.Empty)
                        Me.ExIOPRy = IIf(Not IsDBNull(.Item("IOPRy")), Trim(.Item("IOPRy").ToString), String.Empty)



                    Loop
                End With

                If (Not DRY Is Nothing) Then
                    DRY.Close()
                End If


            End Using

            Dim DBH As DbCommand = DB.GetStoredProcCommand(PRESCRIPTIONHBRX_SELECTBYID)
            DB.AddInParameter(DBH, "@SysNo", DbType.String, Me.SysNo)
            Using DRZ As IDataReader = DB.ExecuteReader(DBH)

                Me.HxLx = String.Empty
                Me.HxLy = String.Empty
                Me.HxL1 = String.Empty
                Me.HxL2 = String.Empty
                Me.HxL3 = String.Empty
                Me.HxL4 = String.Empty
                Me.HxL5 = String.Empty
                Me.HxL6 = String.Empty

                Me.HxRx = String.Empty
                Me.HxRy = String.Empty
                Me.HxR1 = String.Empty
                Me.HxR2 = String.Empty
                Me.HxR3 = String.Empty
                Me.HxR4 = String.Empty
                Me.HxR5 = String.Empty
                Me.HxR6 = String.Empty

                Me.HbIOPLx = String.Empty
                Me.HbIOPLy = String.Empty
                Me.HbIOPRx = String.Empty
                Me.HbIOPRy = String.Empty

                With DRZ
                    Do While .Read

                        Me.HxLx = IIf(Not IsDBNull(.Item("Lx")), Trim(.Item("Lx").ToString), String.Empty)
                        Me.HxLy = IIf(Not IsDBNull(.Item("Ly")), Trim(.Item("Ly").ToString), String.Empty)
                        Me.HxL1 = IIf(Not IsDBNull(.Item("L1")), Trim(.Item("L1").ToString), String.Empty)
                        Me.HxL2 = IIf(Not IsDBNull(.Item("L2")), Trim(.Item("L2").ToString), String.Empty)
                        Me.HxL3 = IIf(Not IsDBNull(.Item("L3")), Trim(.Item("L3").ToString), String.Empty)
                        Me.HxL4 = IIf(Not IsDBNull(.Item("L4")), Trim(.Item("L4").ToString), String.Empty)
                        Me.HxL5 = IIf(Not IsDBNull(.Item("L5")), Trim(.Item("L5").ToString), String.Empty)
                        Me.HxL6 = IIf(Not IsDBNull(.Item("L6")), Trim(.Item("L6").ToString), String.Empty)

                        Me.HbIOPLx = IIf(Not IsDBNull(.Item("IOPLx")), Trim(.Item("IOPLx").ToString), String.Empty)
                        Me.HbIOPLy = IIf(Not IsDBNull(.Item("IOPLy")), Trim(.Item("IOPLy").ToString), String.Empty)

                        Me.HxRx = IIf(Not IsDBNull(.Item("Rx")), Trim(.Item("Rx").ToString), String.Empty)
                        Me.HxRy = IIf(Not IsDBNull(.Item("Ry")), Trim(.Item("Ry").ToString), String.Empty)
                        Me.HxR1 = IIf(Not IsDBNull(.Item("R1")), Trim(.Item("R1").ToString), String.Empty)
                        Me.HxR2 = IIf(Not IsDBNull(.Item("R2")), Trim(.Item("R2").ToString), String.Empty)
                        Me.HxR3 = IIf(Not IsDBNull(.Item("R3")), Trim(.Item("R3").ToString), String.Empty)
                        Me.HxR4 = IIf(Not IsDBNull(.Item("R4")), Trim(.Item("R4").ToString), String.Empty)
                        Me.HxR5 = IIf(Not IsDBNull(.Item("R5")), Trim(.Item("R5").ToString), String.Empty)
                        Me.HxR6 = IIf(Not IsDBNull(.Item("R6")), Trim(.Item("R6").ToString), String.Empty)

                        Me.HbIOPRx = IIf(Not IsDBNull(.Item("IOPRx")), Trim(.Item("IOPRx").ToString), String.Empty)
                        Me.HbIOPRy = IIf(Not IsDBNull(.Item("IOPRy")), Trim(.Item("IOPRy").ToString), String.Empty)


                    Loop
                End With


                If (Not DRZ Is Nothing) Then
                    DRZ.Close()
                End If

            End Using

            DBC.Dispose()
            DBX.Dispose()
            DBY.Dispose()


            Return result

        Catch ex As Exception

            Throw

        End Try


    End Function
#End Region

#Region "ComboEdit Data Population"
    Public Sub BankPop(ByVal Col As String, ByVal Com As DevExpress.XtraEditors.ComboBoxEdit)
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRESCRIPTION_SELECT_POP)


        Try


            Using DR As IDataReader = DB.ExecuteReader(DBC)
                Com.Properties.Items.Clear()

                With DR
                    Do While .Read
                        Com.Properties.Items.Add(IIf(Not IsDBNull(.Item(Col)), Trim(.Item(Col).ToString), ""))
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

#Region "Precription Get By Dates"

    Public Function PrescriptionGetByDates() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PRESCRIPTION_GETBYDATES)
            db.AddInParameter(DBC, "@FromDate", DbType.DateTime, Me.FromDate)
            db.AddInParameter(DBC, "@ToDate", DbType.DateTime, Me.ToDate)

            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try


    End Function

#End Region

#Region "Precription Reminder"

    Public Function PrescriptionReminder() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PRESCRIPTION_REMINDER)

            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try


    End Function

#End Region

#Region "Precription Get All"

    Public Function PrescriptionAll() As DataSet

        Try
            Dim db As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = db.GetStoredProcCommand(DA_PRESCRIPTION_GETBYALL)


            Return db.ExecuteDataSet(DBC)
        Catch ex As Exception
            Return Nothing

        End Try


    End Function

#End Region



End Class
