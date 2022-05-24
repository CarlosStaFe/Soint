Public Class frmCategIVA
    Private Sub CategivaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategivaBindingNavigatorSaveItem.Click

        Validate()
        CategivaBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbsointDataSet)

    End Sub

    Private Sub frmCategIVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CategivaTableAdapter.Fill(DbsointDataSet.categiva)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        DesconectarMySql()
        Close()

    End Sub
End Class