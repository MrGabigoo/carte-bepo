Public Class aboutForm

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        bepoForm.Opacity = TrackBar1.Value / 100
        Label3.Text = TrackBar1.Value.ToString + "%"
    End Sub

    Private Sub aboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = bepoForm.Opacity * 100
        Label3.Text = (bepoForm.Opacity * 100).ToString + "%"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class