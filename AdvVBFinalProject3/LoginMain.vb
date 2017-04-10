Public Class LoginMain
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click

        frmUsernameCreation.ShowDialog()

    End Sub

    Private Sub CloseApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseApplicationToolStripMenuItem.Click

        Me.Close()

    End Sub
End Class