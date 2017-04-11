Public Class LoginMain
    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click

        frmUsernameCreation.ShowDialog()

    End Sub

    Private Sub CloseApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseApplicationToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        MemberTableTableAdapter.ValidateUserNamePassword(CALSdatabaseDataSet.MemberTable, txtUsernameLogin.Text, txtPasswordLogin.Text)

    End Sub

    Private Sub MemberTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MemberTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CALSdatabaseDataSet)

    End Sub

    Private Sub LoginMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet.MemberTable' table. You can move, or remove it, as needed.
        Me.MemberTableTableAdapter.Fill(Me.CALSdatabaseDataSet.MemberTable)

    End Sub
End Class