Public Class frmDayBook

#Region "Variables"

    Private _DACollection As DA.Collections.DACollections

#End Region

#Region "Constructors"

    Public ReadOnly Property DACollection() As DA.Collections.DACollections
        Get

            If _DACollection Is Nothing Then
                _DACollection = New DA.Collections.DACollections
            End If

            Return _DACollection
        End Get
    End Property

#End Region

#Region "From Events"

    Private Sub frmDayBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.deFrom.EditValue = Date.Today
        Me.deTo.EditValue = Date.Today
    End Sub

    Private Sub frmDayBook_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Me.PopulateGrid()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub frmDayBook_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

#End Region

#Region "Populate Grid"

    Private Sub PopulateGrid()
        Try
            DACollection.FromDate = deFrom.EditValue
            DACollection.ToDate = deTo.EditValue
            gcDayBook.DataSource = DACollection.DayBookGetBydates().Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Button Events"

    Private Sub sbProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbProcess.Click
        Try
            Me.PopulateGrid()
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub cbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrint.Click
        Try
            PrintPreview(gcDayBook, "Day Book " + vbCrLf + "From - " + Me.deFrom.Text + " To - " + Me.deTo.Text)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

   
   
End Class