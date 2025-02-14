Imports System.Data.SqlClient
Public Class form_dashboard

    'Database Connection String
    Dim connectionString As String = "Data Source=HOMEDESKTOP2452\SQLEXPRESS;Initial Catalog=Moto_Service_Log;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    Private Sub form_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Close Application
    Private Sub form_dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    'Shift Focus to Next Control on Enter Key Press
    Private Sub form_dashboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Registration Tab Code:

    'Register Button: User and Bike Registration
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click

        'Check if Registration Number is Empty or Zero
        If txtbox_regno.Text = "" Or txtbox_regno.Text = "0" Then
            MessageBox.Show("Please enter vaild Registration Number!")
            Return
        Else Using conn As New SqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = conn

                    'Inserting details into Registration Table
                    cmd.CommandText = "insert into Registration_Table([regno],[custname],[phoneno],[address],[email],[make],[model],[yearofmfd]) values (@regno, @custname, @phoneno, @address, @email, @make, @model, @yearofmfd)"
                    cmd.Parameters.AddWithValue("@regno", txtbox_regno.Text)
                    cmd.Parameters.AddWithValue("@custname", txtbox_custname.Text)
                    cmd.Parameters.AddWithValue("@phoneno", txtbox_phoneno.Text)
                    cmd.Parameters.AddWithValue("@address", txtbox_address.Text)
                    cmd.Parameters.AddWithValue("@email", txtbox_email.Text)
                    cmd.Parameters.AddWithValue("@make", txtbox_make.Text)
                    cmd.Parameters.AddWithValue("@model", txtbox_model.Text)
                    cmd.Parameters.AddWithValue("@yearofmfd", txtbox_yearofmfd.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Rows inserted: " & rowsAffected)

                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        End If
    End Sub

    'Clear Button: Clear all Textboxes
    Private Sub btn_reg_clear_Click(sender As Object, e As EventArgs) Handles btn_reg_clear.Click
        txtbox_regno.Clear()
        txtbox_custname.Clear()
        txtbox_phoneno.Clear()
        txtbox_address.Clear()
        txtbox_email.Clear()
        txtbox_make.Clear()
        txtbox_model.Clear()
        txtbox_yearofmfd.Clear()
    End Sub

    'View Details Button: View all details from Registration Table
    Private Sub btn_reg_viewdetails_Click(sender As Object, e As EventArgs) Handles btn_reg_viewdetails.Click
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting all details from Registration Table
                cmd.CommandText = "select * from Registration_Table"
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                'Displaying details in DataGridView
                Dim datatable1 As New DataTable()
                datatable1.Load(datareader1)
                dgv_regtab.DataSource = datatable1
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Delete Row Button: Delete selected row from Registration Table
    Private Sub btn_reg_deleterow_Click(sender As Object, e As EventArgs) Handles btn_reg_deleterow.Click

        'Check if any row is selected
        If dgv_regtab.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Deleting selected row from Registration Table
                cmd.CommandText = "delete from Registration_Table where regno = @regno"
                cmd.Parameters.AddWithValue("@regno", dgv_regtab.SelectedRows(0).Cells(0).Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows deleted: " & rowsAffected)

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Edit Row Button: Edit selected row in Registration Table
    Private Sub btn_reg_editrow_Click(sender As Object, e As EventArgs) Handles btn_reg_editrow.Click
        If dgv_regtab.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgv_regtab.SelectedRows(0)
            Dim regno As Integer = row.Cells(0).Value
            Dim custname As String = row.Cells(1).Value
            Dim phoneno As String = row.Cells(2).Value
            Dim address As String = row.Cells(3).Value
            Dim email As String = row.Cells(4).Value
            Dim make As String = row.Cells(5).Value
            Dim model As String = row.Cells(6).Value
            Dim yearofmfd As Integer = row.Cells(7).Value

            Update_Registration_Table(regno, custname, phoneno, address, email, make, model, yearofmfd)

        Else
            MessageBox.Show("Please select a row to edit!")
        End If
    End Sub

    'Function to Update selected row in Registration Table
    Private Sub Update_Registration_Table(regno As Integer, custname As String, phoneno As String, address As String, email As String, make As String, model As String, yearofmfd As Integer)

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Updating selected row in Registration Table
                cmd.CommandText = "update Registration_Table set custname = @custname, phoneno = @phoneno, address = @address, email = @email, make = @make, model = @model, yearofmfd = @yearofmfd where regno = @regno"
                cmd.Parameters.AddWithValue("@regno", regno)
                cmd.Parameters.AddWithValue("@custname", custname)
                cmd.Parameters.AddWithValue("@phoneno", phoneno)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@make", make)
                cmd.Parameters.AddWithValue("@model", model)
                cmd.Parameters.AddWithValue("@yearofmfd", yearofmfd)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows updated: " & rowsAffected)

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub
End Class