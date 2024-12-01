Public Class view_appointment
    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint

    End Sub

    Private Sub RoundedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RoundedTextBox1.TextChanged

    End Sub

    Private Sub viewALl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Accept.Show()
        Me.Hide()

    End Sub
End Class