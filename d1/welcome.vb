Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class welcome
    Private Sub Record_button_Click(sender As Object, e As EventArgs) Handles Record_button.Click
        record.Show()
        Me.Hide()
    End Sub

    Private Sub Prescription_button_Click(sender As Object, e As EventArgs) Handles Prescription_button.Click
        prescription.Show()
        Me.Hide()

    End Sub

    Private Sub Appointment_button_Click(sender As Object, e As EventArgs) Handles Appointment_button.Click
        appointment.Show()
        Me.Hide()
    End Sub
End Class