Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports DA.Common.DAConstant
Imports DevExpress.XtraEditors
Imports System

Public Class DAPriceList

#Region "Variables"

    Private _PricePresetID As Int64
    Private _StartValue As Decimal
    Private _EndValue As Decimal
    Private _Price As Decimal

    Private _PriceListID As Int64
    Private _ItemName As String


#End Region

#Region "Properties"

    Public Property PricePresetID() As Int64
        Get
            Return _PricePresetID
        End Get
        Set(ByVal value As Int64)
            _PricePresetID = value
        End Set
    End Property
    Public Property StartValue() As Decimal
        Get
            Return _StartValue
        End Get
        Set(ByVal value As Decimal)
            _StartValue = value
        End Set
    End Property
    Public Property EndValue() As Decimal
        Get
            Return _EndValue
        End Get
        Set(ByVal value As Decimal)
            _EndValue = value
        End Set
    End Property
    Public Property Price() As Decimal
        Get
            Return _Price
        End Get
        Set(ByVal value As Decimal)
            _Price = value
        End Set
    End Property

    Public Property PriceListID() As Int64
        Get
            Return _PriceListID
        End Get
        Set(ByVal value As Int64)
            _PriceListID = value
        End Set
    End Property
    Public Property ItemName() As String
        Get
            Return _ItemName
        End Get
        Set(ByVal value As String)
            _ItemName = value
        End Set
    End Property

#End Region

#Region "Get All Price Preset"

    Public Function GetAllPricePreset() As DataSet

        Try

            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRICEPRESET_GETALL)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

#Region "Update Price Prest"

    Public Function UpdatePricePreset(ByVal ds As DataSet) As Int64

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRICEPRESET_UPDATE)

            DB.AddInParameter(DBC, "@PricePresetID", DbType.Int64, "PricePresetID", DataRowVersion.Current)
            DB.AddInParameter(DBC, "@StartValue", DbType.Decimal, "StartValue", DataRowVersion.Current)
            DB.AddInParameter(DBC, "@EndValue", DbType.Decimal, "EndValue", DataRowVersion.Current)
            DB.AddInParameter(DBC, "@Price", DbType.Decimal, "Price", DataRowVersion.Current)

            Dim i As Int64
            i = DB.UpdateDataSet(ds, "tblPricePreset", Nothing, DBC, Nothing, Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Continue)

            Return i

        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Insert Pice List"

    Public Sub InsertPriceList()

        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRICELIST_INSERT)

            DB.AddInParameter(DBC, "@PriceListID", DbType.Int64, Me.PriceListID)
            DB.AddInParameter(DBC, "@ItemName", DbType.String, Me.ItemName)
            DB.AddInParameter(DBC, "@StartValue", DbType.Decimal, Me.StartValue)
            DB.AddInParameter(DBC, "@EndValue", DbType.Decimal, Me.EndValue)
            DB.AddInParameter(DBC, "@Price", DbType.Decimal, Me.Price)
         
            DB.ExecuteNonQuery(DBC)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Get All Price List"

    Public Function GetAllPriceList() As DataSet

        Try

            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRICELISTGETALL)
            Return DB.ExecuteDataSet(DBC)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

#Region "Get PriceList By ID"

    Public Sub PriceListGetByID()
        Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
        Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRICELISTGETBYID)
        Try

            DB.AddInParameter(DBC, "@PriceListID", DbType.Int64, Me.PriceListID)

            Using DR As IDataReader = DB.ExecuteReader(DBC)


                With DR
                    Do While .Read
                        Me.PriceListID = IIf(Not IsDBNull(.Item("PriceListID")), Trim(.Item("PriceListID").ToString), 0)
                        Me.ItemName = IIf(Not IsDBNull(.Item("ItemName")), Trim(.Item("ItemName").ToString), String.Empty)
                        Me.StartValue = Convert.ToDecimal(IIf(Not IsDBNull(.Item("StartValue")), Trim(.Item("StartValue").ToString), 0))
                        Me.EndValue = Convert.ToDecimal(IIf(Not IsDBNull(.Item("EndValue")), Trim(.Item("EndValue").ToString), 0))
                        Me.Price = Convert.ToDecimal(IIf(Not IsDBNull(.Item("Price")), Trim(.Item("Price").ToString), 0))

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

#Region "Delete Price List"

    Public Sub DeletePriceList()
        Try
            Dim DB As Database = DatabaseFactory.CreateDatabase(DA_DBCONNECTION_STRING)
            Dim DBC As DbCommand = DB.GetStoredProcCommand(DA_PRICELIST_DELETE)
            DB.AddInParameter(DBC, "@PriceListID", DbType.Int64, Me.PriceListID)
            DB.ExecuteNonQuery(DBC)
        Catch ex As Exception

        End Try

    End Sub

#End Region


End Class
