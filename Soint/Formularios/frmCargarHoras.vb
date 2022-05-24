Public Class frmCargarHoras
    Dim importe, horas, subtotal As Double

    Private Sub frmCargarHoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        HorasjobsTableAdapter.Fill(DbsointDataSet.horasjobs)
        Limpiar()
        txtNroObra.Focus()

    End Sub

    Private Sub txtNroObra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroObra.KeyDown

        'Busco nro de obra por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmObra0 As New frmConsObra
            AddOwnedForm(frmObra0)
            frmObra0.ShowDialog()
            LeerObra()
            senial = 0
        End If

        'Busco empleados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerObra()
        End If

    End Sub

    Private Sub txtNroObra_MouseHover(sender As Object, e As EventArgs) Handles txtNroObra.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Obra."
        ToolTipMsg.SetToolTip(txtNroObra, "Presione F1 para buscar la Obra a cargar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtNroEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroEmp.KeyDown

        'Busco nro empleado por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmEmp1 As New frmConsEmpleados
            AddOwnedForm(frmEmp1)
            frmEmp1.ShowDialog()
            LeerEmpleado()
            CargarDgv()
            senial = 0
        End If

        'Busco empleados por número de matrícula
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerEmpleado()
            CargarDgv()
        End If

        txtHoras.Text = ""
        txtSubtotal.Text = ""

    End Sub

    Private Sub txtNroEmp_MouseHover(sender As Object, e As EventArgs) Handles txtNroEmp.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Empleado."
        ToolTipMsg.SetToolTip(txtNroEmp, "Presione F1 para buscar en el padrón de empleados.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub CargarDgv()

        comando.CommandText = "SELECT * FROM horasjobs WHERE EmpleadoHJ = '" & txtNroEmp.Text & "' ORDER BY FechaHJ DESC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvHoras.DataSource = dt

        horas = 0
        subtotal = 0

        If dgvHoras.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvHoras.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(7).Value = "LIQUIDADA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.GreenYellow
                    Else
                        horas = horas + Fila.Cells(4).Value
                        subtotal = subtotal + Fila.Cells(6).Value
                    End If
                End If
            Next
        End If

        txtTotalHoras.Text = horas
        txtTotalHoras.Text = Format(CDec(txtTotalHoras.Text), "C")

        txtTotalSubtotal.Text = subtotal
        txtTotalSubtotal.Text = Format(CDec(txtTotalSubtotal.Text), "C")

        btnLimpiar.Visible = True

    End Sub

    Private Sub txtFecha_LostFocus(sender As Object, e As EventArgs) Handles txtFecha.LostFocus

        comando.CommandText = "SELECT * FROM horasjobs WHERE EmpleadoHJ = '" & txtNroEmp.Text & "' AND FechaHJ = '" & fechadb & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvHoras.DataSource = dt

        If dt.Rows.Count > 0 Then
            CargarRenglon()
            CargarDgv()
        Else
            CargarDgv()
            txtHoras.Text = ""
            txtSubtotal.Text = ""
            btnAgregar.Visible = True
            btnLimpiar.Visible = True
            btnAgregar.Focus()
        End If

        txtHoras.Focus()

    End Sub

    Private Sub txtFecha_Leave(sender As Object, e As EventArgs) Handles txtFecha.Leave

        fechajob = txtFecha.Text
        If txtFecha.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtFecha.Text = ""
                txtFecha.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtFecha.Text = fechajob
                txtFecha.Refresh()
            End If
        End If

    End Sub

    Private Sub CargarRenglon()

        fechajob = dgvHoras.CurrentRow.Cells(2).Value.ToString
        ProcesarFecha()
        txtFecha.Text = fechajob
        txtHoras.Text = dgvHoras.CurrentRow.Cells(4).Value.ToString
        txtImporte.Text = dgvHoras.CurrentRow.Cells(5).Value.ToString
        txtSubtotal.Text = dgvHoras.CurrentRow.Cells(6).Value.ToString
        txtObs.Text = dgvHoras.CurrentRow.Cells(12).Value.ToString
        txtHoras.Text = Format(CDec(txtHoras.Text), "C")
        txtImporte.Text = Format(CDec(txtImporte.Text), "C")
        txtSubtotal.Text = Format(CDec(txtSubtotal.Text), "C")
        btnEliminar.Visible = True
        btnActualizar.Visible = True
        btnAgregar.Visible = False

    End Sub
    Private Sub LeerObra()

        comando.CommandText = "SELECT * FROM obras WHERE NroObra = '" & txtNroObra.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtNroObra.Text = CStr(row("NroObra"))
            txtTitular.Text = CStr(row("TitularObra"))
            txtLugar.Text = CStr(row("LugarObra"))
            txtNroEmp.Focus()
        Else
            txtNombreEmp.Text = ""
            txtNroEmp.Text = ""
            detmsg = "Obra no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtNroObra.Focus()
        End If

    End Sub


    Private Sub LeerEmpleado()

        comando.CommandText = "SELECT * FROM empleados WHERE NroEmp = '" & txtNroEmp.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtId_Emp.Text = CStr(row("id_Emp"))
            txtNroEmp.Text = CStr(row("NroEmp"))
            txtNombreEmp.Text = CStr(row("NombreEmp"))
            txtCategoriaEmp.Text = CStr(row("CategoriaEmp"))
            LeerCategoria()
            txtImporte.Text = Format(CDec(txtImporte.Text), "C")
            txtFecha.Focus()
        Else
            txtNombreEmp.Text = ""
            txtNroEmp.Text = ""
            detmsg = "Empleado no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtNroEmp.Focus()
        End If

    End Sub

    Private Sub LeerCategoria()

        comando.CommandText = "SELECT * FROM categemple WHERE NombreCE = '" & txtCategoriaEmp.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtImporte.Text = CStr(row("ValorHoraCE"))
            importe = txtImporte.Text
        Else
            txtNombreEmp.Text = ""
            detmsg = "Categoría no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub txtHoras_LostFocus(sender As Object, e As EventArgs) Handles txtHoras.LostFocus

        txtHoras.Text = Format(CDec(txtHoras.Text), "C")
        txtImporte.Text = Format(CDec(txtImporte.Text), "C")

    End Sub

    Private Sub txtImporte_LostFocus(sender As Object, e As EventArgs) Handles txtImporte.LostFocus

        If txtHoras.Text <> "" Then
            txtSubtotal.Text = txtImporte.Text * txtHoras.Text
            txtSubtotal.Text = Format(CDec(txtSubtotal.Text), "C")
            txtObs.Focus()
        Else
            txtHoras.Focus()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            detmsg = "Desea Eliminar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand(("DELETE FROM horasjobs WHERE EmpleadoHJ = '" & txtNroEmp.Text & "' AND  FechaHJ = '" & fechadb & "'"), conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro eliminado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        dgvHoras.DataSource = Nothing

        CargarDgv()

        txtFecha.Text = ""
        txtHoras.Text = ""
        txtImporte.Text = ""
        txtSubtotal.Text = ""
        txtObs.Text = ""

        btnEliminar.Visible = False
        btnActualizar.Visible = False
        txtFecha.Focus()

    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try
            detmsg = "Desea Actualizar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand(("UPDATE horasjobs SET HorasHJ = '" & txtHoras.Text & "', ValorHJ = '" & txtImporte.Text & "', SubtotalHJ = '" & txtSubtotal.Text & "', " _
                                            & " ObsHJ = '" & txtObs.Text & "'  WHERE FechaHJ = '" & fechadb & "' AND  EmpleadoHJ = '" & txtNroEmp.Text & "'"), conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro actualizado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Modificación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        txtFecha.Text = ""
        txtHoras.Text = ""
        txtImporte.Text = ""
        txtSubtotal.Text = ""
        txtObs.Text = ""
        btnEliminar.Visible = False
        btnActualizar.Visible = False
        txtFecha.Focus()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            comando = New MySqlCommand("INSERT INTO horasjobs VALUES(@id, @obra, @fecha, @nroemp, @horas, @valor, @subtotal, @estado, @yyyy, @mm ,@quincena," _
                                   & " @fechaliq, @obs)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@obra", txtNroObra.Text)
            comando.Parameters.AddWithValue("@fecha", fechadb)
            comando.Parameters.AddWithValue("@nroemp", txtNroEmp.Text)
            comando.Parameters.AddWithValue("@horas", txtHoras.Text)
            comando.Parameters.AddWithValue("@valor", txtImporte.Text)
            comando.Parameters.AddWithValue("@subtotal", txtSubtotal.Text)
            comando.Parameters.AddWithValue("@estado", "PENDIENTE")
            comando.Parameters.AddWithValue("@yyyy", "")
            comando.Parameters.AddWithValue("@mm", "")
            comando.Parameters.AddWithValue("@quincena", "")
            comando.Parameters.AddWithValue("@fechaliq", Nothing)
            comando.Parameters.AddWithValue("@obs", txtObs.Text)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        txtFecha.Text = ""
        txtHoras.Text = ""
        txtSubtotal.Text = ""
        txtObs.Text = ""
        btnAgregar.Visible = False
        txtFecha.Focus()

    End Sub

    Private Sub Limpiar()

        txtNroObra.Text = ""
        txtTitular.Text = ""
        txtLugar.Text = ""
        txtNroEmp.Text = ""
        txtNombreEmp.Text = ""
        txtFecha.Text = ""
        txtHoras.Text = ""
        txtImporte.Text = ""
        txtSubtotal.Text = ""
        txtObs.Text = ""
        fechajob = ""

        dgvHoras.DataSource = Nothing

        txtTotalHoras.Text = 0
        txtTotalHoras.Text = Format(CDec(txtTotalHoras.Text), "C")

        txtTotalSubtotal.Text = 0
        txtTotalSubtotal.Text = Format(CDec(txtTotalSubtotal.Text), "C")

        btnActualizar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnLimpiar.Visible = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

        txtNroEmp.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar sin borrar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub dgvHoras_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoras.CellDoubleClick

        CargarRenglon()
        txtHoras.Focus()

    End Sub

    Private Sub dgvHoras_MouseHover(sender As Object, e As EventArgs) Handles dgvHoras.MouseHover

        ToolTipMsg.ToolTipTitle = "Doble Clic."
        ToolTipMsg.SetToolTip(dgvHoras, "Presione doble clic para seleccionar el renglón deseado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(btnEliminar, "Presione para eliminar el renglón seleccionado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(btnEliminar, "Presione para actualizar el renglón modificado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(btnEliminar, "Presione para agragar los datos ingresados.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class