Public Class frmObras
    Private Sub frmObras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        Actualizar()
        dgvObras.DataSource = Nothing

    End Sub

    Private Sub txtClienteObra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteObra.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmCli1 As New frmConsClientes
            AddOwnedForm(frmCli1)
            frmCli1.ShowDialog()
            senial = 0
            CargarDGV()
            txtClienteObra.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerClientes()
            If senial = 1 Then
                Actualizar()
                txtClienteObra.Focus()
                CargarDGV()
                senial = 0
            End If
        End If

    End Sub

    Private Sub txtClienteObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClienteObra.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        ObrasBindingSource.AddNew()
        NroNuevo()
        txtNroObra.Show()
        BtnAgregar.Visible = False
        BtnGrabar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        cmbEstadoObra.SelectedIndex = 0
        'txtNroObra.Focus()

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos de una nueva obra.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                fechajob = txtFechaObra.Text
                ProcesarFecha()
                txtFechaObra.Text = fechadb
                fechajob = txtFecEstadoObra.Text
                ProcesarFecha()
                txtFecEstadoObra.Text = fechadb

                comando = New MySqlCommand("INSERT INTO obras VALUES(@id, @cliente, @obra, @nombre, @fecobra, @titular, @lugar, @estado, @fecestado, @obs)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@cliente", txtClienteObra.Text)
                comando.Parameters.AddWithValue("@obra", txtNroObra.Text)
                comando.Parameters.AddWithValue("@nombre", txtNombreObra.Text)
                comando.Parameters.AddWithValue("@fecobra", txtFechaObra.Text)
                comando.Parameters.AddWithValue("@titular", txtTitularObra.Text)
                comando.Parameters.AddWithValue("@lugar", txtLugarObra.Text)
                comando.Parameters.AddWithValue("@estado", cmbEstadoObra.Text)
                comando.Parameters.AddWithValue("@fecestado", txtFecEstadoObra.Text)
                comando.Parameters.AddWithValue("@obs", txtObsObra.Text)
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

        Actualizar()
        CargarDGV()

        txtClienteObra.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados de la obra nueva.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then

            fechajob = txtFechaObra.Text
            ProcesarFecha()
            txtFechaObra.Text = fechadb
            fechajob = txtFecEstadoObra.Text
            ProcesarFecha()
            txtFecEstadoObra.Text = fechadb

            comando = New MySqlCommand("UPDATE obras SET ClienteObra = '" & txtClienteObra.Text & "', NroObra = '" & txtNroObra.Text & "', FechaObra = '" & txtFechaObra.Text & "', " _
                                    & "TitularObra = '" & txtTitularObra.Text & "', LugarObra = '" & txtLugarObra.Text & "', EstadoObra = '" & cmbEstadoObra.Text & "', " _
                                    & "FecEstadoObra = '" & txtFecEstadoObra.Text & "', ObsObra = '" & txtObsObra.Text & "', NombreObra = '" & txtNombreObra.Text & "' " _
                                    & " WHERE id_Obra = '" & txtId_Obra.Text & "' AND  ClienteObra = '" & txtClienteObra.Text & "' ", conexion)
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
        ObrasTableAdapter.Fill(DbsointDataSet.obras)

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados de la obra.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM obras WHERE id_Obra = " & txtId_Obra.Text & " AND  ClienteObra = " & txtClienteObra.Text & ""), conexion)
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
        ObrasTableAdapter.Fill(DbsointDataSet.obras)

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar la obra en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 1
        Dim frmObra1 As New frmConsClientes
        AddOwnedForm(frmObra1)
        frmObra1.ShowDialog()
        CargarDGV()
        senial = 0

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar en el padrón un clientes.")
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

    Private Sub LeerClientes()

        comando.CommandText = "SELECT * FROM clientes WHERE NroCli = '" & txtClienteObra.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            CargarCliente()
        Else
            detmsg = "Cliente no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        End If

    End Sub

    Private Sub CargarCliente()

        Dim row As DataRow = dt.Rows(0)

        txtClienteObra.Text = CStr(row("NroCli"))
        txtTitularObra.Text = CStr(row("NombreCli"))

        CargarDGV()

        txtFechaObra.Focus()

    End Sub

    Private Sub NroNuevo()

        comando = New MySqlCommand("SELECT MAX(NroObra) NroObra FROM obras WHERE NroObra > 0", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtNroObra.Text = Val(dr(0).ToString) + 1
            End While
        Else
            txtNroObra.Text = 1
        End If
        dr.Close()

        'txtNroObra.Enabled = False
        txtClienteObra.Focus()

    End Sub

    Private Sub Actualizar()

        ObrasTableAdapter.Fill(DbsointDataSet.obras)
        txtId_Obra.Text = ""
        txtClienteObra.Text = ""
        txtTitularObra.Text = ""
        txtNroObra.Text = ""
        txtNombreObra.Text = ""
        txtFechaObra.Text = ""
        txtLugarObra.Text = ""
        cmbEstadoObra.Text = ""
        txtFecEstadoObra.Text = ""
        txtObsObra.Text = ""
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = True
        BtnActualizar.Visible = True
        dgvObras.DataSource = Nothing
        txtClienteObra.Focus()

    End Sub

    Private Sub CargarDGV()

        comando.CommandText = "SELECT * FROM obras WHERE ClienteObra = '" & txtClienteObra.Text & "' ORDER BY FechaObra DESC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvObras.DataSource = dt

        If dgvObras.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvObras.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells(6).Value = "TERMINADA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.GreenYellow
                    End If
                End If
            Next
        End If

        'btnLimpiar.Visible = True

    End Sub

    Private Sub dgvObras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObras.CellContentClick

        txtId_Obra.Text = dgvObras.CurrentRow.Cells(0).Value.ToString
        txtClienteObra.Text = dgvObras.CurrentRow.Cells(1).Value.ToString
        txtNroObra.Text = dgvObras.CurrentRow.Cells(2).Value.ToString
        txtNombreObra.Text = dgvObras.CurrentRow.Cells(3).Value.ToString
        txtFechaObra.Text = dgvObras.CurrentRow.Cells(4).Value.ToString
        txtTitularObra.Text = dgvObras.CurrentRow.Cells(5).Value.ToString
        txtLugarObra.Text = dgvObras.CurrentRow.Cells(6).Value.ToString
        cmbEstadoObra.Text = dgvObras.CurrentRow.Cells(7).Value.ToString
        txtFecEstadoObra.Text = dgvObras.CurrentRow.Cells(8).Value.ToString
        txtObsObra.Text = dgvObras.CurrentRow.Cells(9).Value.ToString
        fechajob = txtFechaObra.Text
        ProcesarFecha()
        txtFechaObra.Text = fechajob
        fechajob = txtFecEstadoObra.Text
        ProcesarFecha()
        txtFecEstadoObra.Text = fechajob

        BtnEliminar.Visible = True
        BtnActualizar.Visible = True
        BtnAgregar.Visible = False

    End Sub

    Private Sub txtFechaObra_Leave(sender As Object, e As EventArgs) Handles txtFechaObra.Leave

        fechajob = txtFechaObra.Text
        If txtFechaObra.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtFechaObra.Text = ""
                txtFechaObra.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtFechaObra.Text = fechajob
                txtFechaObra.Refresh()
            End If
        End If

    End Sub

    Private Sub txtFecEstadoObra_Leave(sender As Object, e As EventArgs) Handles txtFecEstadoObra.Leave

        fechajob = txtFecEstadoObra.Text
        If txtFecEstadoObra.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtFecEstadoObra.Text = ""
                txtFecEstadoObra.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtFecEstadoObra.Text = fechajob
                txtFecEstadoObra.Refresh()
            End If
        End If

    End Sub

End Class