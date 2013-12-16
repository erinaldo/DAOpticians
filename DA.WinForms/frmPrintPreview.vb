Public Class frmPrintPreview

#Region "Form Events"
    Private Sub frmReport_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' RibbonControl1.Minimized = True
    End Sub
#End Region

    
    Private Sub PrintPreviewBarItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintPreviewBarItem24.ItemClick
        Me.Close()
    End Sub
End Class