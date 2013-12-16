Imports DA.StartUp.DACompany
Public Class frmCompany

#Region "Properties"
    Private _DACompany As DA.StartUp.DACompany
#End Region

#Region "Constructors"
    
    Public ReadOnly Property DACompany() As DA.StartUp.DACompany
        Get

            If _DACompany Is Nothing Then
                _DACompany = New DA.StartUp.DACompany()
            End If

            Return _DACompany
        End Get
    End Property
#End Region

#Region "Form Events"
    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDAStartUpBarButton(bbSave, bbNew, bbDelete, bbClose, bbDisplaySelected, bbRefresh, bbPrint)
        Me.HideToolButtonsOnLoad()
        Me.DisplayCompany()
    End Sub

    Private Sub frmCompany_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Hide Tool Buttons On Load"
    Public Sub HideToolButtonsOnLoad()

        Me.bbDisplaySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.bbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
#End Region

#Region "Bar Button Events"
    Private Sub bbClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSave.ItemClick
        Me.SaveCompany()
    End Sub
#End Region

#Region "Save Company"
    Private Sub SaveCompany()
        With DACompany
            .CompanyName = Me.teCompanyName.Text.Trim
            .Address1 = Me.teAddressLine1.Text.Trim
            .Address2 = Me.teAddressLine2.Text.Trim
            .Telephone = Me.teTelephone.Text.Trim
            .Fax = Me.teFax.Text.Trim
            .Email = Me.teEmail.Text.Trim
            .WebURL = Me.teWebURL.Text.Trim
            .RegNo = Me.teRegNo.Text.Trim
            .InsertCompany()
        End With

        MessageOK("Saved Succefull", "Chagnes You Made Succefully Updated", "Press OK to Continue...")


    End Sub
#End Region

#Region "Display Company"
    Private Sub DisplayCompany()
        With DACompany
            .GetCompany()
            Me.teCompanyName.Text = .CompanyName
            Me.teAddressLine1.Text = .Address1
            Me.teAddressLine2.Text = .Address2
            Me.teTelephone.Text = .Telephone
            Me.teFax.Text = .Fax
            Me.teEmail.Text = .Email
            Me.teWebURL.Text = .WebURL
            Me.teRegNo.Text = .RegNo
        End With
    End Sub
#End Region

End Class