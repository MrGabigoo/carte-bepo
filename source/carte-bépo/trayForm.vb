Public Class trayForm
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Application.Exit()

    End Sub

    Private Sub trayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ContextMenuStrip1.Show(Cursor.Position) 'Shows the Right click menu on the cursor position
        Me.Left = ContextMenuStrip1.Left + 1 'Puts the form behind the menu horizontally
        Me.Top = ContextMenuStrip1.Top + 1 'Puts the form behind the menu vertically

    End Sub

    Private Sub trayForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate

        Me.Close() 'Closes the "trayform" Form and consequently every thing in it, including the "traymenu"

    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click

        aboutForm.Show()

    End Sub
End Class