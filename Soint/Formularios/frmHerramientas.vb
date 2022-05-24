Public Class frmHerramientas
    Private Sub frmHerramientas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        HerramientasTableAdapter.Fill(DbsointDataSet.herramientas)

    End Sub

    Private Sub CategempleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HerramientasBindingNavigatorSaveItem.Click

        Validate()
        HerramientasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbsointDataSet)

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub HerramientasBindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles HerramientasBindingNavigatorAddNewItem.Click

        txtTipoTool.Focus()

    End Sub

    Private Sub txtObraTool_TextChanged(sender As Object, e As EventArgs) Handles txtObraTool.TextChanged

    End Sub

    Private Sub txtObraTool_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObraTool.KeyDown

        'Busco nro de obra por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmObra1 As New frmConsObra
            AddOwnedForm(frmObra1)
            frmObra1.ShowDialog()
            senial = 0
        End If

    End Sub

    Private Sub chbFuncionaTool_MouseHover(sender As Object, e As EventArgs) Handles chbFuncionaTool.MouseHover

        ToolTipMsg.ToolTipTitle = "Funciona."
        ToolTipMsg.SetToolTip(chbFuncionaTool, "Marque si el elemento funciona.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtObraTool_MouseHover(sender As Object, e As EventArgs) Handles txtObraTool.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Obra."
        ToolTipMsg.SetToolTip(txtObraTool, "Presione F1 para buscar la obra.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class