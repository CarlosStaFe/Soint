Public Class frmCargarAdicionales
    Private Sub frmCargarAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AdicionjobsTableAdapter.Fill(DbsointDataSet.adicionjobs)

    End Sub

    Private Sub AdicionjobsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdicionjobsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdicionjobsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsointDataSet)

    End Sub
End Class