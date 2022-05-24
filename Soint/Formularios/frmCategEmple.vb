Public Class frmCategEmple
    Private Sub frmCategEmple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CategempleTableAdapter.Fill(DbsointDataSet.categemple)

        txtValorHoraCE.Text = Format(CDec(txtValorHoraCE.Text), "C")
        txtValorHoraCE.Refresh()

    End Sub

    Private Sub txtValorHoraCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorHoraCE.KeyPress

        SoloNumeros(txtValorHoraCE, e)

    End Sub

    Private Sub txtValorHoraCE_LostFocus(sender As Object, e As EventArgs) Handles txtValorHoraCE.LostFocus

        txtValorHoraCE.Text = Format(CDec(txtValorHoraCE.Text), "C")

    End Sub

    Private Sub CategempleBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CategempleBindingNavigatorSaveItem.Click

        Validate()
        CategempleBindingSource.EndEdit()

        TableAdapterManager.UpdateAll(DbsointDataSet)
        dt.AcceptChanges()

        txtNombreCE.Focus()
        txtValorHoraCE.Refresh()
        CategempleTableAdapter.Fill(DbsointDataSet.categemple)
        txtValorHoraCE.Text = Format(CDec(txtValorHoraCE.Text), "C")
        txtValorHoraCE.Refresh()


    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_1(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        txtNombreCE.Focus()

    End Sub

End Class