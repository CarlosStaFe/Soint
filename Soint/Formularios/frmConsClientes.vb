Public Class frmConsClientes
    Private Sub frmConsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClientesTableAdapter.Fill(DbsointDataSet.clientes)

        txtNombre.Focus()

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        comando.CommandText = "SELECT * FROM clientes WHERE NombreCli LIKE '%" & txtNombre.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvClientes.DataSource = dt

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Nombre."
        ToolTipMsg.SetToolTip(txtNombre, "Ingrese el nombre del cliente que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick

        If senial = 0 Then
            Dim frmCli0 As frmClientes = CType(Owner, frmClientes)
            frmCli0.txtId_Cli.Text = dgvClientes.CurrentRow.Cells(0).Value.ToString
            frmCli0.txtNroCli.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
            frmCli0.txtNombreCli.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString
            frmCli0.txtTitularCli.Text = dgvClientes.CurrentRow.Cells(3).Value.ToString
            frmCli0.txtDomicilioCli.Text = dgvClientes.CurrentRow.Cells(4).Value.ToString
            frmCli0.txtIdCodPosCli.Text = dgvClientes.CurrentRow.Cells(5).Value.ToString
            frmCli0.txtTelefCli.Text = dgvClientes.CurrentRow.Cells(6).Value.ToString
            frmCli0.cmbTipoIvaCli.Text = dgvClientes.CurrentRow.Cells(7).Value.ToString
            frmCli0.txtCuitCli.Text = dgvClientes.CurrentRow.Cells(8).Value.ToString
            frmCli0.txtIngBrutosCli.Text = dgvClientes.CurrentRow.Cells(9).Value.ToString
            frmCli0.txtObsCli.Text = dgvClientes.CurrentRow.Cells(10).Value.ToString
            frmCli0.txtEmailCli.Text = dgvClientes.CurrentRow.Cells(11).Value.ToString
        End If
        If senial = 1 Then
            Dim frmCli1 As frmObras = CType(Owner, frmObras)
            frmCli1.txtClienteObra.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
            frmCli1.txtTitularObra.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString
        End If
        If senial = 2 Then
            Dim frmCli2 As frmCtaCteCli = CType(Owner, frmCtaCteCli)
            frmCli2.txtCliente.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
            frmCli2.txtApelyNomb.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString
        End If

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