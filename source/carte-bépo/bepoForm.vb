Public Class bepoForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()

            NotifyIcon1.BalloonTipText = "Cliquez sur l'icone pour rouvrir la carte bépo"
            NotifyIcon1.ShowBalloonTip(500)

        End If

    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick

        If e.Button = MouseButtons.Right Then 'Checks if the pressed button is the Right Mouse
            trayForm.Show() 'Shows the Form that is the parent of "traymenu"
            trayForm.Activate() 'Set the Form to "Active", that means that that will be the "selected" window
            trayForm.Width = 1 'Set the Form width to 1 pixel, that is needed because later we will set it behind the "traymenu"
            trayForm.Height = 1 'Set the Form Height to 1 pixel, for the same reason as above
        End If

    End Sub
End Class
