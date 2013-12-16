
Public Class frmLogin


#Region "Variables"

    Private _DAUserLogins As DA.Common.DAUserLogins


#End Region

#Region "Constructors"
    Public ReadOnly Property DAUserLogins() As DA.Common.DAUserLogins
        Get

            If _DAUserLogins Is Nothing Then
                _DAUserLogins = New DA.Common.DAUserLogins
            End If

            Return _DAUserLogins
        End Get
    End Property


#End Region

#Region "Form Events"
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        Me.PopulateLookup()
    End Sub
#End Region

#Region "Populate Users"
    Public Sub PopulateLookup()
        Try
            leUsers.Properties.DataSource = DAUserLogins.SelectAll.Tables(0)
            leUsers.Properties.DisplayMember = "UserName"
            leUsers.Properties.ValueMember = "UserLoginID"

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Button Events"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbExit.Click
        Application.Exit()
    End Sub

    Private Sub sbLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbLogin.Click

        Try
            If dxvpLogin.Validate Then

                DAUserLogins.UserName = Me.leUsers.Text
                DAUserLogins.Password = Me.tePassword.Text.Trim

                DAUserLogins.SelectRowByUserNameAndPassword()

                If IsDBNull(DAUserLogins.UserLoginID) Or DAUserLogins.UserLoginID = 0 Then
                    lblError.Text = "Wrong Password"
                Else
                    lblError.Text = "Athunticated"

                    UserID = DAUserLogins.UserLoginID
                    UserName = DAUserLogins.UserName
                    UserType = DAUserLogins.UserType


                    Select Case UserType

                        Case "USER"

                            frmMain.RibbonPage6.Visible = False 'Administrator page
                            frmMain.RibbonPageGroup1.Visible = False 'stock
                            frmMain.BarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never ' employers
                            frmMain.BarButtonItem23.Visibility = DevExpress.XtraBars.BarItemVisibility.Never ' company information
                    End Select

                    Me.Hide()
                    frmMain.Show()


                End If

            Else
                tePassword.Focus()
            End If

        Catch ex As Exception
            MessageError(ex.ToString)
        End Try



    End Sub
#End Region


End Class