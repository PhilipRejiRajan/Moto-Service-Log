Public Class form_Login
    Private Sub form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = txtbox_uname.Text
        Dim password As String = txtbox_pword.Text
        If username = "admin" And password = "admin1234" Then
            MsgBox("Login Successful!")
            openDashboard()
        Else
            MsgBox("Invalid Username or Password!")
        End If

    End Sub

    Private Sub openDashboard()
        Dim secondForm As New form_dashboard()
        secondForm.Show()
        Me.Hide()
    End Sub

    Private Sub form_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class
