Public Class SumOfNumbers
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub EnterNumberButton_Click(sender As Object, e As EventArgs) Handles EnterNumberButton.Click
        Dim maxNumber As Integer = 0
        Dim count As Integer = 0
        Dim total As Integer = 0
        Dim userNumber As String = ""

        userNumber = InputBox("Enter a positive integer value.", "Input Needed", "10")
        If Integer.TryParse(userNumber, maxNumber) Then
            If maxNumber < 0 Then
                MessageBox.Show("Enter a POSITIVE integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                For count = 1 To maxNumber
                    total = total + count
                Next
                MessageBox.Show("Sum of the numbers 1 to " & maxNumber & " is " & total, "Sum of Numbers")
            End If
        Else
            MessageBox.Show("Enter a positive integer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SumOfNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnterNumberButton.Focus()
    End Sub
End Class
