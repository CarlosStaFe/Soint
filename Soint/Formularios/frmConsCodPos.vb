Public Class frmConsCodPos
    Private Sub frmConsCodPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comando.CommandText = "SELECT NroCodPos AS 'CODIGO', LocalCodPos AS 'LOCALIDAD', ProvCodPos AS 'PROVINCIA' , id_CodPos AS 'ID' FROM codpostal"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodpostal.DataSource = dt
        dgvCodpostal.Columns(0).Width = 70
        dgvCodpostal.Columns(1).Width = 200
        dgvCodpostal.Columns(2).Width = 210
        dgvCodpostal.Columns(3).Width = 50

        txtLocalidad.Focus()

    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress

        comando.CommandText = "SELECT NroCodPos AS 'CODIGO', LocalCodPos AS 'LOCALIDAD', ProvCodPos AS 'PROVINCIA', id_CodPos AS 'ID' FROM codpostal WHERE LocalCodPos LIKE '%" & txtLocalidad.Text & "%'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCodpostal.DataSource = dt

    End Sub

    Private Sub txtLocalidad_MouseHover(sender As Object, e As EventArgs) Handles txtLocalidad.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Localidad."
        ToolTipMsg.SetToolTip(txtLocalidad, "Presione F1 para buscar la localidad deseada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvCodpostal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCodpostal.CellDoubleClick

        If senial = 0 Then
            Dim frmCodPos0 As frmCodPostal = CType(Owner, frmCodPostal)
            frmCodPos0.txtNroCodPos.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmCodPos0.txtLocalCodPos.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmCodPos0.txtProvCodPos.Text = dgvCodpostal.CurrentRow.Cells(2).Value.ToString
            frmCodPos0.txtId_CodPos.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        If senial = 1 Then
            Dim frmCodPos1 As frmClientes = CType(Owner, frmClientes)
            frmCodPos1.txtCodPostal.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmCodPos1.txtLocalidad.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmCodPos1.txtProvincia.Text = dgvCodpostal.CurrentRow.Cells(2).Value.ToString
            frmCodPos1.txtIdCodPosCli.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        If senial = 2 Then
            Dim frmCodPos2 As frmEmpleados = CType(Owner, frmEmpleados)
            frmCodPos2.txtCodPostal.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmCodPos2.txtLocalidad.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmCodPos2.txtProvincia.Text = dgvCodpostal.CurrentRow.Cells(2).Value.ToString
            frmCodPos2.txtIdCodPosEmp.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
        End If

        If senial = 3 Then
            Dim frmCodPos3 As frmProveedores = CType(Owner, frmProveedores)
            frmCodPos3.txtCodPos.Text = dgvCodpostal.CurrentRow.Cells(0).Value.ToString
            frmCodPos3.txtLocalidad.Text = dgvCodpostal.CurrentRow.Cells(1).Value.ToString
            frmCodPos3.txtProvincia.Text = dgvCodpostal.CurrentRow.Cells(2).Value.ToString
            frmCodPos3.txtIdCodPosProv.Text = dgvCodpostal.CurrentRow.Cells(3).Value.ToString
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