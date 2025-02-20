Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class form_Invoice

    Private WithEvents PrintDoc As New PrintDocument()
    Private PrintPreviewDlg As New PrintPreviewDialog()

    Private Sub form_Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        PrintPreviewDlg.Document = PrintDocument1
        PrintPreviewDlg.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDlg.WindowState = FormWindowState.Maximized
        PrintPreviewDlg.ShowDialog()
    End Sub

End Class