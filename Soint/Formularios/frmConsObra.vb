Public Class frmConsObra
    Private Sub frmConsObra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ObrasTableAdapter.Fill(DbsointDataSet.obras)

        txtTitular.Focus()

    End Sub

    Private Sub txtTitular_Leave(sender As Object, e As EventArgs) Handles txtTitular.Leave

        comando.CommandText = "SELECT * FROM obras WHERE TitularObra LIKE '%" & txtTitular.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvObras.DataSource = dt

    End Sub

    Private Sub txtTitular_MouseHover(sender As Object, e As EventArgs) Handles txtTitular.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Nombre."
        ToolTipMsg.SetToolTip(txtTitular, "Ingrese el nombre del cliente de la obra que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvObras_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObras.CellDoubleClick

        If senial = 0 Then
            Dim frmObra0 As frmCargarHoras = CType(Owner, frmCargarHoras)
            frmObra0.txtNroObra.Text = dgvObras.CurrentRow.Cells(2).Value.ToString
            frmObra0.txtTitular.Text = dgvObras.CurrentRow.Cells(4).Value.ToString
            frmObra0.txtLugar.Text = dgvObras.CurrentRow.Cells(5).Value.ToString
        End If
        If senial = 1 Then
            Dim frmObra1 As frmHerramientas = CType(Owner, frmHerramientas)
            frmObra1.txtObraTool.Text = dgvObras.CurrentRow.Cells(5).Value.ToString
        End If
        If senial = 2 Then
            Dim frmObra2 As frmCompras = CType(Owner, frmCompras)
            frmObra2.txtObraDetCpra.Text = dgvObras.CurrentRow.Cells(2).Value.ToString
        End If
        'If senial = 3 Then
        '    Dim frmObra3 As frmObras = CType(Owner, frmObras)
        '    frmObra3.txtClienteObra.Text = dgvObras.CurrentRow.Cells(1).Value.ToString
        'End If

        Close()

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