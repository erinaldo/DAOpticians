Public Class frmError 

#Region "Button Events"
    Private Sub sbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbOk.Click
        Me.Close()
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmError_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub
#End Region

End Class