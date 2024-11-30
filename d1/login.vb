Public Class login
    Private passwordVisible As Boolean = False ' Track password visibility state

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RoundedTextBox1.TextChanged

    End Sub

    Private Sub RoundedTextBox5_TextChanged(sender As Object, e As EventArgs) Handles RoundedTextBox5.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If passwordVisible Then
            ' Hide the password
            RoundedTextBox5.UseSystemPasswordChar = True
            passwordVisible = False
        Else
            ' Show the password
            RoundedTextBox5.UseSystemPasswordChar = False
            passwordVisible = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If passwordVisible Then
            ' Hide the password
            RoundedTextBox6.UseSystemPasswordChar = True
            passwordVisible = False
        Else
            ' Show the password
            RoundedTextBox6.UseSystemPasswordChar = False
            passwordVisible = True
        End If
    End Sub
End Class