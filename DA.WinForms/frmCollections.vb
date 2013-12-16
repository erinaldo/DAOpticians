Imports DA.Collections.DACollections



Public Class frmCollections

#Region "Variables"
    Dim _DACollecitons As DA.Collections.DACollections
#End Region
   
#Region "Constructor"
    Public ReadOnly Property DACollecitons() As DA.Collections.DACollections
        Get

            If _DACollecitons Is Nothing Then
                _DACollecitons = New DA.Collections.DACollections()
            End If

            Return _DACollecitons
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frmCollections_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCollections_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Me.gcCollections.DataSource = DACollecitons.CollectionGetAll.Tables(0)

        Catch ex As Exception

        End Try


    End Sub
#End Region

    
End Class