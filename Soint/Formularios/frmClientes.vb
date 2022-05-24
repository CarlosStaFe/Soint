Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        ClientesTableAdapter.Fill(DbsointDataSet.clientes)
        CargarIVA()
        idCodigo = DbsointDataSet.clientes.Rows(0).Item(5)
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub txtNroCli_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroCli.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmCli0 As New frmConsClientes
            AddOwnedForm(frmCli0)
            frmCli0.ShowDialog()
            idCodigo = txtIdCodPosCli.Text
            CodPostal = txtCodPostal.Text
            LeerCodigoPostal()
            CargoLocalidad()
            senial = 0
            txtNombreCli.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerClientes()
            txtNombreCli.Focus()
            If senial = 1 Then
                Actualizar()
                txtNroCli.Focus()
                senial = 0
            End If
        End If

    End Sub

    Private Sub txtNroCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroCli.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        ClientesBindingSource.AddNew()
        NroNuevo()
        txtNroCli.Show()
        txtNombreCli.Focus()
        BtnAgregar.Visible = False
        BtnGrabar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = False
        BtnAnterior.Visible = False
        BtnSiguiente.Visible = False
        BtnUltimo.Visible = False
        cmbTipoIvaCli.SelectedIndex = 0

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos de un nuevo cliente.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                ClientesBindingSource.EndEdit()
                ClientesTableAdapter.Update(DbsointDataSet.clientes)
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

        txtNroCli.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados del cliente nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE clientes SET NroCli = '" & txtNroCli.Text & "', NombreCli = '" & txtNombreCli.Text & "', TitularCli = '" & txtTitularCli.Text & "', " _
                                    & "DomicilioCli = '" & txtDomicilioCli.Text & "', IdCodPosCli = '" & txtIdCodPosCli.Text & "', TelefCli = '" & txtTelefCli.Text & "', EmailCli = '" & txtEmailCli.Text & "', " _
                                    & "TipoIvaCli = '" & cmbTipoIvaCli.Text & "', CuitCli = '" & txtCuitCli.Text & "', IngBrutosCli = '" & txtIngBrutosCli.Text & "', ObsCli = '" & txtObsCli.Text & "' " _
                                    & " WHERE id_Cli = " & txtId_Cli.Text & " AND  NroCli = " & txtNroCli.Text & "", conexion)
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
        ClientesTableAdapter.Fill(DbsointDataSet.clientes)
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del cliente.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM clientes WHERE id_Cli = " & txtId_Cli.Text & " AND  NroCli = " & txtNroCli.Text & ""), conexion)
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
        ClientesTableAdapter.Fill(DbsointDataSet.clientes)
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el cliente en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 0
        Dim frmCli0 As New frmConsClientes
        AddOwnedForm(frmCli0)
        frmCli0.ShowDialog()
        senial = 0
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar en el padrón un cliente.")
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

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        ClientesBindingSource.MoveFirst()
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnPrimer_MouseHover(sender As Object, e As EventArgs) Handles BtnPrimer.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Primer."
        ToolTipMsg.SetToolTip(BtnPrimer, "Presione para ir al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        ClientesBindingSource.MovePrevious()
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnAnterior_MouseHover(sender As Object, e As EventArgs) Handles BtnAnterior.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Anterior."
        ToolTipMsg.SetToolTip(BtnAnterior, "Presione para ir al registro anterior del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        ClientesBindingSource.MoveNext()
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnSiguiente_MouseHover(sender As Object, e As EventArgs) Handles BtnSiguiente.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Siguiente."
        ToolTipMsg.SetToolTip(BtnSiguiente, "Presione para ir al registro siguiente del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        ClientesBindingSource.MoveLast()
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnUltimo_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnUltimo.MouseMove

        ToolTipMsg.ToolTipTitle = "Botón Último."
        ToolTipMsg.SetToolTip(BtnUltimo, "Presione para ir al último registro del padrón.")
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

    Private Sub txtCodPostal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodPostal.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmCodPos1 As New frmConsCodPos
            AddOwnedForm(frmCodPos1)
            frmCodPos1.ShowDialog()
            idCodigo = txtIdCodPosCli.Text
            CodPostal = 0
            LeerCodigoPostal()
            CargoLocalidad()
            txtTelefCli.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            idCodigo = 0
            CodPostal = txtCodPostal.Text
            LeerCodigoPostal()
            CargoLocalidad()
            txtTelefCli.Focus()
        End If

    End Sub

    Private Sub txtCodPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodPostal.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCodPostal_MouseHover(sender As Object, e As EventArgs) Handles txtCodPostal.MouseHover

        ToolTipMsg.ToolTipTitle = "Código Postal."
        ToolTipMsg.SetToolTip(txtCodPostal, "Presione F1 para consultar el podrón de códigos postales o el código y luego Enter.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerClientes()

        comando.CommandText = "SELECT * FROM clientes WHERE NroCli = " & txtNroCli.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            CargarCliente()
            idCodigo = txtIdCodPosCli.Text
            CodPostal = ""
            LeerCodigoPostal()
            CargoLocalidad()
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

        txtId_Cli.Text = CStr(row("id_Cli"))
        txtNroCli.Text = CStr(row("NroCli"))
        txtNombreCli.Text = CStr(row("NombreCli"))
        txtTitularCli.Text = CStr(row("TitularCli"))
        txtDomicilioCli.Text = CStr(row("DomicilioCli"))
        txtIdCodPosCli.Text = CStr(row("IdCodPosCli"))
        txtTelefCli.Text = CStr(row("TelefCli"))
        cmbTipoIvaCli.Text = CStr(row("TipoIvaCli"))
        txtCuitCli.Text = CStr(row("CuitCli"))
        txtIngBrutosCli.Text = CStr(row("IngBrutosCli"))
        txtObsCli.Text = CStr(row("ObsCli"))

    End Sub

    Private Sub NroNuevo()

        comando = New MySqlCommand("SELECT MAX(NroCli) NroCli FROM clientes WHERE NroCli > 0", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtNroCli.Text = Val(dr(0).ToString) + 1
            End While
        Else
            txtNroCli.Text = 1
        End If
        dr.Close()

    End Sub

    Private Sub Actualizar()

        ClientesTableAdapter.Fill(DbsointDataSet.clientes)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = True
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True
        idCodigo = txtIdCodPosCli.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()
        txtNroCli.Focus()

    End Sub

    Private Sub txtCuitCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuitCli.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtIngBrutosCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIngBrutosCli.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub CargarIVA()

        comando = New MySqlCommand("SELECT DISTINCT DescripcionCI FROM categiva ORDER BY DescripcionCI DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbTipoIvaCli.Items.Add(dr(0).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub CargoLocalidad()

        txtCodPostal.Text = CodPostal
        txtIdCodPosCli.Text = idCodigo
        txtLocalidad.Text = Localidad
        txtProvincia.Text = Provincia

    End Sub


End Class