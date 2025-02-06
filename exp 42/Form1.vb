Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim result As DialogResult
        result = MessageBox.Show("Is programming easy to learn?", "Important Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Great! Keep learning!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Don't worry, practice makes perfect!", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
