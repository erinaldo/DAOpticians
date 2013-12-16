Public Class frmReminder

#Region "Variable"
    Private _DAPrescription As DA.Prescription.DAPrescription
#End Region

#Region "Constructors"

    Public ReadOnly Property DAPrescription() As DA.Prescription.DAPrescription
        Get

            If _DAPrescription Is Nothing Then
                _DAPrescription = New DA.Prescription.DAPrescription
            End If

            Return _DAPrescription
        End Get
    End Property

#End Region

#Region "Form Events"

    Private Sub frmReminder_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Me.PopluateGrid()

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

    Private Sub frmReminder_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

#End Region

#Region "Populate Grid"

    Private Sub PopluateGrid()
        Try

            Me.gcReminder.DataSource = DAPrescription.PrescriptionReminder().Tables(0)
        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub

#End Region

    
End Class