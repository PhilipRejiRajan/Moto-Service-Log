Public Class form_Login
    Private Sub form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Login Button: User Authentication
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = txtbox_uname.Text
        Dim password As String = txtbox_pword.Text
        If username = "admin" And password = "1234" Then
            MsgBox("Login Successful!")
            openDashboard()
        Else
            MsgBox("Invalid Username or Password!")
        End If

    End Sub

    'Open Dashboard Form
    Private Sub openDashboard()
        Dim secondForm As New form_dashboard()
        secondForm.Show()
        Me.Hide()
    End Sub

    'Close Application
    Private Sub form_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    'Shift Focus to Next Control on Enter Key Press
    Private Sub form_Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
