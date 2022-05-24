Public Class frmAdicionales

    Private Sub frmAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        AdicionalesTableAdapter.Fill(DbsointDataSet.adicionales)
        txtValorAdi.Text = Format(Val(txtValorAdi.Text), "###.###,##")
        txtValorAdi.Refresh()

    End Sub
    Private Sub AdicionalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdicionalesBindingNavigatorSaveItem.Click

        Validate()
        AdicionalesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbsointDataSet)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        txtCodigoAdi.Focus()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub txtValorAdi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorAdi.KeyPress

        SoloNumeros(txtValorAdi, e)

    End Sub

    Private Sub txtValorAdi_LostFocus(sender As Object, e As EventArgs) Handles txtValorAdi.LostFocus

        txtValorAdi.Text = Format(CDec(txtValorAdi.Text), "C")

    End Sub

End Class