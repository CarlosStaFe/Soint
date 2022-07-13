Public Class frmPreventivo
    Dim item, renglon As Integer
    Dim id, obra As Integer
    Dim nombre, grupo, obs As String
    Dim importe As Double
    Private Sub frmPreventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CargarGrupos()
        txtObraGO.Focus()

    End Sub

    Private Sub txtObraGO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObraGO.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmObra3 As New frmConsObra
            AddOwnedForm(frmObra3)
            frmObra3.ShowDialog()
            senial = 0
            LeerObra()
            cmbGrupoGO.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerObra()
            cmbGrupoGO.Focus()
        End If

    End Sub

    Private Sub LeerObra()

        comando.CommandText = "SELECT * FROM obras WHERE NroObra = '" & txtObraGO.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtObraGO.Text = CStr(row("NroObra"))
            txtNombreGO.Text = CStr(row("NombreObra"))

            LeerPreventivo()

            btnAgregar.Visible = True
            btnAgregar.Focus()
        Else
            txtObraGO.Text = ""
            detmsg = "Obra no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtObraGO.Focus()
        End If

    End Sub

    Private Sub LeerPreventivo()

        comando = New MySqlCommand("SELECT * FROM gruposobras WHERE ObraGO = '" & txtObraGO.Text & "' ORDER BY NombreGO", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                dgvPreventivo.Rows.Add()
                item = dgvPreventivo.Rows.Count
                fila = item - 1
                dgvPreventivo.Rows(fila).Cells(0).Value = dr(0).ToString()
                dgvPreventivo.Rows(fila).Cells(1).Value = dr(1).ToString()
                dgvPreventivo.Rows(fila).Cells(2).Value = dr(2).ToString()
                dgvPreventivo.Rows(fila).Cells(3).Value = dr(3).ToString()
                dgvPreventivo.Rows(fila).Cells(4).Value = Format(CDec(dr(4).ToString()), "########0.00")
                dgvPreventivo.Rows(fila).Cells(5).Value = dr(5).ToString()
            End While
        End If

        dr.Close()

    End Sub

    Private Sub CargarGrupos()

        comando = New MySqlCommand("SELECT NombreGrupo FROM grupos ORDER BY NombreGrupo ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbGrupoGO.Items.Add(dr(0).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub txtImporteGO_LostFocus(sender As Object, e As EventArgs) Handles txtImporteGO.LostFocus

        If txtImporteGO.Text = "" Then
            txtImporteGO.Focus()
        Else
            txtImporteGO.Text = Format(CDec(txtImporteGO.Text), "########0.00")
        End If

    End Sub

    Private Sub txtObsGO_LostFocus(sender As Object, e As EventArgs) Handles txtObsGO.LostFocus

        btnAgregar.Focus()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        dgvPreventivo.Rows.Add()
        item = dgvPreventivo.Rows.Count
        fila = item - 1
        dgvPreventivo.Rows(fila).Cells(0).Value = 0
        dgvPreventivo.Rows(fila).Cells(1).Value = txtObraGO.Text
        dgvPreventivo.Rows(fila).Cells(2).Value = txtNombreGO.Text
        dgvPreventivo.Rows(fila).Cells(3).Value = cmbGrupoGO.Text
        dgvPreventivo.Rows(fila).Cells(4).Value = txtImporteGO.Text
        dgvPreventivo.Rows(fila).Cells(5).Value = txtObsGO.Text
        btnGrabar.Visible = True

        Limpiar()

    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(btnAgregar, "Presione para ingresar los datos de un nuevo empleado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Limpiar()

        cmbGrupoGO.Text = ""
        txtImporteGO.Text = ""
        txtObsGO.Text = ""
        cmbGrupoGO.SelectedItem = 0

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        renglon = dgvPreventivo.Rows.Count

        For j = 0 To renglon - 1

            id = dgvPreventivo.Rows(j).Cells(0).Value
            obra = dgvPreventivo.Rows(j).Cells(1).Value
            nombre = dgvPreventivo.Rows(j).Cells(2).Value
            grupo = dgvPreventivo.Rows(j).Cells(3).Value
            importe = dgvPreventivo.Rows(j).Cells(4).Value
            obs = dgvPreventivo.Rows(j).Cells(5).Value

            Try
                If id = 0 Then
                    comando = New MySqlCommand("INSERT INTO gruposobras VALUES(@id, @obra, @nombre, @grupo, @importe, @obs)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@obra", obra)
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@grupo", grupo)
                    comando.Parameters.AddWithValue("@importe", importe)
                    comando.Parameters.AddWithValue("@obs", obs)
                    comando.ExecuteNonQuery()

                Else
                    comando = New MySqlCommand("UPDATE gruposobras SET ObraGO = '" & obra & "', NombreGO = '" & nombre & "', GrupoGO = '" & grupo & "', ImporteGO = '" & importe & "', ObsGO = '" & obs & "' WHERE id_GO = '" & id & "' ", conexion)
                    comando.ExecuteNonQuery()

                End If

            Catch ex As Exception
                detmsg = "Grabación preventivo cancelada...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End Try
        Next

        Actualizar()
        Limpiar()
        dgvPreventivo.Rows.Clear()

        txtObraGO.Focus()

    End Sub

    Private Sub btnGrabar_MouseHover(sender As Object, e As EventArgs) Handles btnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(btnGrabar, "Presione para grabar los datos ingresados del empleado nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE gruposobras SET ObraGO = '" & txtObraGO.Text & "', NombreGO = '" & txtNombreGO.Text & "', GrupoGO = '" & cmbGrupoGO.Text & "', ImporteGO = '" & txtImporteGO.Text & "', ObsGO = '" & txtObsGO.Text & "' WHERE id_GO = '" & txtId_GO.Text & "' ", conexion)
            comando.ExecuteNonQuery()
            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        dgvPreventivo.Rows.Clear()
        LeerPreventivo()
        Limpiar()

    End Sub

    Private Sub btnModificar_MouseHover(sender As Object, e As EventArgs) Handles btnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(btnModificar, "Presione para grabar los datos modificados del empleado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM gruposobras WHERE id_GO = " & txtId_GO.Text & " AND  ObraGO = " & txtObraGO.Text & ""), conexion)
            comando.ExecuteNonQuery()
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        dgvPreventivo.Rows.Clear()
        LeerPreventivo()
        Limpiar()

    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(btnEliminar, "Presione para eliminar el empleado en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Actualizar()

    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(btnActualizar, "Presione para volver al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtObraGO.Text = ""
        txtNombreGO.Text = ""

        Limpiar()
        dgvPreventivo.Rows.Clear()

        txtObraGO.Focus()

    End Sub

    Private Sub Actualizar()

        btnAgregar.Visible = True
        btnGrabar.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnActualizar.Visible = False
        txtObraGO.Focus()

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

    Private Sub dgvPreventivo_DoubleClick(sender As Object, e As EventArgs) Handles dgvPreventivo.DoubleClick

        fila = dgvPreventivo.CurrentRow.Index
        txtId_GO.Text = dgvPreventivo.CurrentRow.Cells(0).Value.ToString
        txtObraGO.Text = dgvPreventivo.CurrentRow.Cells(1).Value.ToString
        txtNombreGO.Text = dgvPreventivo.CurrentRow.Cells(2).Value.ToString
        cmbGrupoGO.Text = dgvPreventivo.CurrentRow.Cells(3).Value.ToString
        txtImporteGO.Text = dgvPreventivo.CurrentRow.Cells(4).Value.ToString
        txtObsGO.Text = dgvPreventivo.CurrentRow.Cells(5).Value.ToString
        txtImporteGO.Text = Format(CDec(txtImporteGO.Text), "########0.00")

        btnModificar.Visible = True
        btnEliminar.Visible = True
        btnGrabar.Visible = False
        btnAgregar.Visible = False
        txtImporteGO.Focus()

    End Sub

End Class