Public Class frmGrupos
    Private Sub frmGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        GruposTableAdapter.Fill(DbsointDataSet.grupos)

    End Sub

    Private Sub GruposBindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles GruposBindingNavigatorAddNewItem.Click

        txtNombreGrupo.Focus()

    End Sub

    Private Sub GruposBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GruposBindingNavigatorSaveItem.Click

        Validate()
        GruposBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbsointDataSet)

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub


End Class