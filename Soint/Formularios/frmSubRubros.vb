Public Class frmSubRubros
    Private Sub frmSubRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubrubrosTableAdapter.Fill(DbsointDataSet.subrubros)

        ConectarMySql()
        SubRubrosTableAdapter.Fill(dbsointDataSet.subrubros)
        CargarCombo()
        cmbNombreRubro.SelectedIndex = 0
        CargarDGV()
        Limpiar()

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT * FROM rubros ORDER BY NombreRubro ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbNombreRubro.Items.Add(dr(2).ToString)
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub CargarDGV()

        comando.CommandText = "SELECT rubros.NombreRubro, subrubros.id_SRub, subrubros.fk_SRub, subrubros.NombreSRub FROM subrubros " _
                               & " INNER JOIN rubros ON rubros.id_Rubro = subrubros.fk_SRub ORDER BY rubros.NombreRubro, subrubros.NombreSRub"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvSubRubros.DataSource = dt
        dgvSubRubros.Columns(0).Width = 290
        dgvSubRubros.Columns(0).HeaderText = "NOMBRE DE RUBRO"
        dgvSubRubros.Columns(1).Width = 10
        dgvSubRubros.Columns(1).Visible = False
        dgvSubRubros.Columns(2).Width = 10
        dgvSubRubros.Columns(2).Visible = False
        dgvSubRubros.Columns(3).Width = 320
        dgvSubRubros.Columns(3).HeaderText = "NOMBRE DE SUBRUBRO"

        If dt.Rows.Count > 0 Then
            cmbNombreRubro.Text = dgvSubRubros.CurrentRow.Cells(0).Value.ToString
            txtId_SRub.Text = dgvSubRubros.CurrentRow.Cells(1).Value.ToString
            txtIdRubro.Text = dgvSubRubros.CurrentRow.Cells(2).Value.ToString
            txtNombreSRub.Text = dgvSubRubros.CurrentRow.Cells(3).Value.ToString
        Else
            cmbNombreRubro.Text = ""
            txtId_SRub.Text = ""
            txtIdRubro.Text = ""
            txtNombreSRub.Text = ""
        End If

        Limpiar()

    End Sub

    Private Sub Limpiar()

        cmbNombreRubro.Text = ""
        txtIdRubro.Text = ""
        txtId_SRub.Text = ""
        txtNombreSRub.Text = ""

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        cmbNombreRubro.Focus()
        BtnGrabar.Visible = True
        BtnAgregar.Visible = False

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Seleccionar Rubros."
        ToolTipMsg.SetToolTip(cmbNombreRubro, "Seleccione el rubro que quiera agregar al subrubro.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand("INSERT INTO subrubros VALUES(@id, @rubro, @nombre)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@rubro", txtIdRubro.Text)
                comando.Parameters.AddWithValue("@nombre", txtNombreSRub.Text)

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

        cmbNombreRubro.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados del subrubro nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Actualizar()

        Limpiar()
        CargarDGV()

        SubrubrosTableAdapter.Fill(DbsointDataSet.subrubros)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnActualizar.Visible = True
        cmbNombreRubro.Focus()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE subrubros SET fk_SRub = '" & txtIdRubro.Text & "', NombreSRub = '" & txtNombreSRub.Text & "' " _
                                    & " WHERE id_SRub = " & txtId_SRub.Text & " ", conexion)
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
        SubrubrosTableAdapter.Fill(DbsointDataSet.subrubros)
        CargarDGV()

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del subrubro.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM subrubros WHERE id_SRub = " & txtId_SRub.Text & " "), conexion)
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
        SubrubrosTableAdapter.Fill(DbsointDataSet.subrubros)
        CargarDGV()

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el subrubro en pantalla.")
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

    Private Sub cmbNombreRubro_LostFocus(sender As Object, e As EventArgs) Handles cmbNombreRubro.LostFocus

        comando = New MySqlCommand("SELECT * FROM rubros WHERE NombreRubro = '" & cmbNombreRubro.Text & "' ", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtIdRubro.Text = Val(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub dgvRubros_DoubleClick(sender As Object, e As EventArgs) Handles dgvSubRubros.DoubleClick

        cmbNombreRubro.Text = dgvSubRubros.CurrentRow.Cells(0).Value.ToString
        txtId_SRub.Text = dgvSubRubros.CurrentRow.Cells(1).Value.ToString
        txtIdRubro.Text = dgvSubRubros.CurrentRow.Cells(2).Value.ToString
        txtNombreSRub.Text = dgvSubRubros.CurrentRow.Cells(3).Value.ToString

    End Sub
End Class