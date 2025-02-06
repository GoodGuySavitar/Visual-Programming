Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Km to Meter Converter"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim km As Double
        If Double.TryParse(TextBox1.Text, km) Then
            Dim meters As Double = km * 1000
            Label2.Text = km.ToString() & " Km = " & meters.ToString() & " Meters"
        Else
            Label2.Text = "Enter a valid number"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
End Class
