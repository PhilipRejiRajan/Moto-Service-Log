Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form_Invoice

    Private WithEvents PrintDoc As New PrintDocument()
    Private PrintPreviewDlg As New PrintPreviewDialog()

    'Database Connection String
    Dim connectionString As String = "Data Source=HOMEDESKTOP2452\SQLEXPRESS;Initial Catalog=Moto_Service_Log;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"


    Private Sub form_Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Registration Number in Registration Number ComboBox
        LoadRegNoComboBox()

    End Sub

    'Cancel Button: Close Invoice Form
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        form_dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub form_Invoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        form_dashboard.Show()
    End Sub

    'Print Document Event: Draws Invoice Panel to Print
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
        e.Graphics.DrawImage(bmp, 50, 50)

    End Sub

    'Print Button: Open Print Preview Dialog
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If combox_regno.SelectedItem = "" Or combox_billid.SelectedItem = "" Then
            MessageBox.Show("Please Select Registration Number and Bill ID!")
        Else
            PrintPreviewDlg.Document = PrintDocument1
            PrintPreviewDlg.StartPosition = FormStartPosition.CenterScreen
            PrintPreviewDlg.WindowState = FormWindowState.Maximized
            PrintPreviewDlg.ShowDialog()
        End If

    End Sub

    'Function to Load Registration Number in Registration Number ComboBox
    Private Sub LoadRegNoComboBox()

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                cmd.CommandText = "select regno from Registration_Table"
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                Do While datareader1.Read()
                    combox_regno.Items.Add(datareader1("regno").ToString())
                Loop
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    'Function to Load BillIDs in BillID ComboBox
    Private Sub LoadBillIDComboBox()

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                cmd.CommandText = "select billid from Billing_Table where regno=@regno"
                cmd.Parameters.AddWithValue("@regno", combox_regno.SelectedItem)
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                Do While datareader1.Read()
                    combox_billid.Items.Add(datareader1("billid").ToString())
                Loop
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    'Loads Customer and Bike Details in Customer and Bike Details Panel
    Private Sub combox_regno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_regno.SelectedIndexChanged

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Select Customer and Bike Details from Registration Table
                cmd.CommandText = "select custname,phoneno,address,email,make,model,yearofmfd from Registration_Table where regno=@regno"
                Dim parameter As New SqlParameter("@regno", SqlDbType.Int)
                parameter.Value = combox_regno.SelectedItem
                cmd.Parameters.Add(parameter)

                'Display Customer and Bike Details in TextBoxes
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                Do While datareader1.Read()
                    txtbox_custname.Text = datareader1("custname")
                    txtbox_phoneno.Text = datareader1("phoneno")
                    txtbox_address.Text = datareader1("address")
                    txtbox_email.Text = datareader1("email")
                    txtbox_make.Text = datareader1("make")
                    txtbox_model.Text = datareader1("model")
                    txtbox_yearofmfd.Text = datareader1("yearofmfd")
                Loop
                datareader1.Close()

                'Load BillIDs in BillID ComboBox
                LoadBillIDComboBox()

                'Load Services Data in Services DataGridView
                Load_Services_Data()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Loads Bill Details in Bill Details Panel
    Private Sub combox_billid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_billid.SelectedIndexChanged

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Select Bill Details from Billing Table
                cmd.CommandText = "select billdate,totalamount,paymentmode,status from Billing_Table where billid=@billid"
                Dim parameter As New SqlParameter("@billid", SqlDbType.Int)
                parameter.Value = combox_billid.SelectedItem
                cmd.Parameters.Add(parameter)

                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                Do While datareader1.Read()
                    dtpick_billdate.Value = datareader1("billdate")
                    txtbox_totalamt.Text = datareader1("totalamount")
                    txtbox_paymode.Text = datareader1("paymentmode")
                    txtbox_status.Text = datareader1("status")
                Loop
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Function to Load Services Data in Services DataGridView
    Private Sub Load_Services_Data()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Select Services Data from Service Assignments Table and Services Table
                cmd.CommandText = "select sa.serviceid,s.servname,sa.servdate,sa.status,sa.servcost from Service_Assignments_Table sa,Services_Table s  where sa.serviceid=s.serviceid and regno=@regno"
                cmd.Parameters.AddWithValue("@regno", combox_regno.SelectedItem)
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                'Displaying details in DataGridView
                Dim datatable1 As New DataTable()
                datatable1.Load(datareader1)
                dgv_services.DataSource = datatable1
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub
End Class