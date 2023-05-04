Public Class Formlogin

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_username.Text = "admin" And txt_password.Text = "12345" Then
            Formutama.Show()
            Me.Hide()
        Else
            MsgBox("Username atau Password Salah!")
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_signup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Username : admin dan Password : 12345")
    End Sub

    Private Sub Formlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
