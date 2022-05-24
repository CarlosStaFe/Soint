Public Class frmRubros
    Private Sub frmRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        RubrosTableAdapter.Fill(DbsointDataSet.rubros)
        CargarCombo()
        cmbNombreGrupo.SelectedIndex = 0
        CargarDGV()
        Limpiar()

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT * FROM grupos ORDER BY NombreGrupo ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbNombreGrupo.Items.Add(dr(1).ToString)
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub CargarDGV()

        comando.CommandText = "SELECT grupos.NombreGrupo, rubros.id_Rubro, rubros.fk_Rubro, rubros.NombreRubro FROM rubros " _
                               & " INNER JOIN grupos ON grupos.id_Grupo = rubros.fk_Rubro ORDER BY grupos.NombreGrupo, rubros.NombreRubro"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvRubros.DataSource = dt
        dgvRubros.Columns(0).Width = 310
        dgvRubros.Columns(0).HeaderText = "NOMBRE DE GRUPO"
        dgvRubros.Columns(1).Width = 10
        dgvRubros.Columns(1).Visible = False
        dgvRubros.Columns(2).Width = 10
        dgvRubros.Columns(2).Visible = False
        dgvRubros.Columns(3).Width = 320
        dgvRubros.Columns(3).HeaderText = "NOMBRE DE RUBRO"

        If dt.Rows.Count > 0 Then
            cmbNombreGrupo.Text = dgvRubros.CurrentRow.Cells(0).Value.ToString
            txtId_Rubro.Text = dgvRubros.CurrentRow.Cells(1).Value.ToString
            txtIdGrupo.Text = dgvRubros.CurrentRow.Cells(2).Value.ToString
            txtNombreRubro.Text = dgvRubros.CurrentRow.Cells(3).Value.ToString
        Else
            cmbNombreGrupo.Text = ""
            txtId_Rubro.Text = ""
            txtIdGrupo.Text = ""
            txtNombreRubro.Text = ""
        End If

        Limpiar()

    End Sub

    Private Sub Limpiar()

        cmbNombreGrupo.Text = ""
        txtIdGrupo.Text = ""
        txtId_Rubro.Text = ""
        txtNombreRubro.Text = ""

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        cmbNombreGrupo.Focus()
        BtnGrabar.Visible = True
        BtnAgregar.Visible = False

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Seleccionar Grupos."
        ToolTipMsg.SetToolTip(cmbNombreGrupo, "Seleccione el grupo que quiera agregar el rubro.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand("INSERT INTO rubros VALUES(@id, @grupo, @nombre)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@grupo", txtIdGrupo.Text)
                comando.Parameters.AddWithValue("@nombre", txtNombreRubro.Text)

                comando.ExecuteNonQuery()

                detmsg = "Registro guardado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDGV()
        Actualizar()

        cmbNombreGrupo.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados del rubro nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Actualizar()

        Limpiar()
        CargarDGV()

        RubrosTableAdapter.Fill(DbsointDataSet.rubros)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnActualizar.Visible = True
        cmbNombreGrupo.Focus()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE rubros SET fk_Rubro = '" & txtIdGrupo.Text & "', NombreRubro = '" & txtNombreRubro.Text & "' " _
                                    & " WHERE id_Rubro = " & txtId_Rubro.Text & " ", conexion)
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
        RubrosTableAdapter.Fill(DbsointDataSet.rubros)
        CargarDGV()

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del rubro.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM rubros WHERE id_Rubro = " & txtId_Rubro.Text & " "), conexion)
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
        RubrosTableAdapter.Fill(DbsointDataSet.rubros)
        CargarDGV()

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el rubro en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Actualizar()

    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(BtnActualizar, "Presione para volver al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub cmbNombreGrupo_LostFocus(sender As Object, e As EventArgs) Handles cmbNombreGrupo.LostFocus

        comando = New MySqlCommand("SELECT * FROM grupos WHERE NombreGrupo = '" & cmbNombreGrupo.Text & "' ", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtIdGrupo.Text = Val(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub dgvRubros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellDoubleClick

        cmbNombreGrupo.Text = dgvRubros.CurrentRow.Cells(0).Value.ToString
        txtId_Rubro.Text = dgvRubros.CurrentRow.Cells(1).Value.ToString
        txtIdGrupo.Text = dgvRubros.CurrentRow.Cells(2).Value.ToString
        txtNombreRubro.Text = dgvRubros.CurrentRow.Cells(3).Value.ToString

    End Sub
End Class