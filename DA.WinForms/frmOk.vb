Public Class frmOk 


#Region "Form Events"
    Private Sub frmOk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub
  
#End Region


   
End Class