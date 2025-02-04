Public Class form_Login
    Private Sub form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim secondForm As New form_dashboard()
        secondForm.Show()
        Me.Hide()
    End Sub

    Private Sub form_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class
