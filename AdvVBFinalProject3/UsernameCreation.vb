
Public Class frmUsernameCreation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            MembertableBindingSource.EndEdit()
            MemberTableTableAdapter.Update(CALSdatabaseDataSet.Membertable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub frmUsernameCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MembertableBindingSource.AddNew()

    End Sub
End Class