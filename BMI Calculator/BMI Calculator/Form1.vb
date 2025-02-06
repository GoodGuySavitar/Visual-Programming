Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim height As Double
        Dim weight As Double

        If Not Double.TryParse(txtHeight.Text, height) OrElse Not Double.TryParse(txtWeight.Text, weight) Then
            MessageBox.Show("Please enter valid numerical values for Height and Weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        height = height / 100

        If height <= 0 Or weight <= 0 Then
            MessageBox.Show("Height and Weight must be positive numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim bmi As Double = weight / (height * height)

        Dim category As String = ""
        If bmi < 18.5 Then
            category = "Underweight"
        ElseIf bmi >= 18.5 And bmi < 24.9 Then
            category = "Normal weight"
        ElseIf bmi >= 25 And bmi < 29.9 Then
            category = "Overweight"
        Else
            category = "Obese"
        End If

        lblResult.Text = "BMI: " & Math.Round(bmi, 2).ToString() & " - " & category
    End Sub



End Class
