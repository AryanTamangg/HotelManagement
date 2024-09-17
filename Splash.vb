

Public Class Splash
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the timer when the form loads
        Timer1.Start()
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increase the progress bar value
        ProgressBar1.Value += 5

        ' Check if the progress bar value reaches its maximum
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ' Stop the timer
            Timer1.Stop()

            ' Open the next form
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class
