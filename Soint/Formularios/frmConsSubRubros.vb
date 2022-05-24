Public Class frmConsSubRubros
    Private Sub frmConsSubRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RubrosTableAdapter.Fill(DbsointDataSet.rubros)
        SubrubrosTableAdapter.Fill(DbsointDataSet.subrubros)
        txtNombre.Focus()
        CargarDGV()

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        comando.CommandText = "SELECT subrubros.id_SRub AS 'ID SRUB', subrubros.fk_SRub AS 'FK SRUB', subrubros.NombreSRub AS 'NOMBRE SUBRUBRO', rubros.id_Rubro AS 'ID RUB', " _
                                & "rubros.NombreRubro AS 'NOMBRE RUBRO' FROM subrubros, rubros WHERE subrubros.fk_SRub = rubros.id_Rubro AND subrubros.NombreSRub LIKE '%" & txtNombre.Text & "%' ORDER BY subrubros.NombreSRub"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvSubRubros.DataSource = dt

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Nombre."
        ToolTipMsg.SetToolTip(txtNombre, "Ingrese el nombre del cliente que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvSubRubros_DoubleClick(sender As Object, e As EventArgs) Handles dgvSubRubros.DoubleClick

        If senial = 0 Then
            Dim frmCpra0 As frmCompras = CType(Owner, frmCompras)
            frmCpra0.txtIdSRubDetCpra.Text = dgvSubRubros.CurrentRow.Cells(0).Value.ToString
            frmCpra0.txtSRubDetCpra.Text = dgvSubRubros.CurrentRow.Cells(2).Value.ToString
        End If

        Close()

    End Sub

    Private Sub CargarDGV()

        comando.CommandText = "SELECT subrubros.id_SRub AS 'ID SRUB', subrubros.fk_SRub AS 'FK SRUB', subrubros.NombreSRub AS 'NOMBRE SUBRUBRO', rubros.id_Rubro AS 'ID RUB', " _
                                & "rubros.NombreRubro AS 'NOMBRE RUBRO' FROM subrubros, rubros WHERE  subrubros.fk_SRub = rubros.id_Rubro ORDER BY subrubros.NombreSRub"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvSubRubros.DataSource = dt
        dgvSubRubros.Columns(0).Width = 50
        dgvSubRubros.Columns(0).Visible = False
        dgvSubRubros.Columns(1).Width = 50
        dgvSubRubros.Columns(1).Visible = False
        dgvSubRubros.Columns(2).Width = 350
        dgvSubRubros.Columns(3).Width = 50
        dgvSubRubros.Columns(3).Visible = False
        dgvSubRubros.Columns(4).Width = 300

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Close()

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class