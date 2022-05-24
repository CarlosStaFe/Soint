Public Class frmConsEmpleados
    Private Sub frmConsEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpleadosTableAdapter.Fill(DbsointDataSet.empleados)

        txtNombre.Focus()

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        comando.CommandText = "SELECT * FROM empleados WHERE NombreEmp LIKE '%" & txtNombre.Text & "%' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvEmpleados.DataSource = dt

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Nombre."
        ToolTipMsg.SetToolTip(txtNombre, "Ingrese el nombre del empleado que quiere encontrar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick

        If senial = 0 Then
            Dim frmEmp0 As frmEmpleados = CType(Owner, frmEmpleados)
            frmEmp0.txtId_Emp.Text = dgvEmpleados.CurrentRow.Cells(0).Value.ToString
            frmEmp0.txtNroEmp.Text = dgvEmpleados.CurrentRow.Cells(1).Value.ToString
            frmEmp0.txtNombreEmp.Text = dgvEmpleados.CurrentRow.Cells(2).Value.ToString
            frmEmp0.txtDomicilioEmp.Text = dgvEmpleados.CurrentRow.Cells(3).Value.ToString
            frmEmp0.txtIdCodPosEmp.Text = dgvEmpleados.CurrentRow.Cells(4).Value.ToString
            frmEmp0.txtTelefEmp.Text = dgvEmpleados.CurrentRow.Cells(5).Value.ToString
            frmEmp0.cmbCategoriaEmp.Text = dgvEmpleados.CurrentRow.Cells(6).Value.ToString
            frmEmp0.txtCuilEmp.Text = dgvEmpleados.CurrentRow.Cells(7).Value.ToString
            frmEmp0.txtFuncionEmp.Text = dgvEmpleados.CurrentRow.Cells(8).Value.ToString
            frmEmp0.txtObsEmp.Text = dgvEmpleados.CurrentRow.Cells(9).Value.ToString
        End If
        If senial = 1 Then
            Dim frmEmp1 As frmCargarHoras = CType(Owner, frmCargarHoras)
            frmEmp1.txtId_Emp.Text = dgvEmpleados.CurrentRow.Cells(0).Value.ToString
            frmEmp1.txtNroEmp.Text = dgvEmpleados.CurrentRow.Cells(1).Value.ToString
            frmEmp1.txtNombreEmp.Text = dgvEmpleados.CurrentRow.Cells(2).Value.ToString
            frmEmp1.txtCategoriaEmp.Text = dgvEmpleados.CurrentRow.Cells(6).Value.ToString
        End If
        If senial = 2 Then
            Dim frmEmp2 As frmCtaCteJobs = CType(Owner, frmCtaCteJobs)
            frmEmp2.txtEmpleado.Text = dgvEmpleados.CurrentRow.Cells(1).Value.ToString
            frmEmp2.txtApelyNomb.Text = dgvEmpleados.CurrentRow.Cells(2).Value.ToString
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