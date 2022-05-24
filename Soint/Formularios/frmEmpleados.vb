Public Class frmEmpleados
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        EmpleadosTableAdapter.Fill(DbsointDataSet.empleados)
        CargarCombo()
        idCodigo = DbsointDataSet.empleados.Rows(0).Item(5)
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click

        Validate()
        EmpleadosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbsointDataSet)

    End Sub

    Private Sub txtNroEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroEmp.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmEmp0 As New frmConsEmpleados
            AddOwnedForm(frmEmp0)
            frmEmp0.ShowDialog()
            idCodigo = txtIdCodPosEmp.Text
            CodPostal = txtCodPostal.Text
            LeerCodigoPostal()
            CargoLocalidad()
            senial = 0
            txtNombreEmp.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerEmpleados()
            txtNombreEmp.Focus()
            If senial = 1 Then
                Actualizar()
                txtNroEmp.Focus()
                senial = 0
            End If
        End If

    End Sub

    Private Sub txtNroEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroEmp.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        EmpleadosBindingSource.AddNew()
        NroNuevo()
        txtNroEmp.Show()
        txtNombreEmp.Focus()
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
        cmbCategoriaEmp.SelectedIndex = 0

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos de un nuevo empleado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                EmpleadosBindingSource.EndEdit()
                EmpleadosTableAdapter.Update(DbsointDataSet.empleados)
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

        txtNroEmp.Focus()

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados del empleado nuevo.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE empleados SET NroEmp = '" & txtNroEmp.Text & "', NombreEmp = '" & txtNombreEmp.Text & "', FecNacEmp = '" & txtFecNacEmp.Text & "', " _
                                    & "DomicilioEmp = '" & txtDomicilioEmp.Text & "', IdCodPosEmp = '" & txtIdCodPosEmp.Text & "', TelefEmp = '" & txtTelefEmp.Text & "', " _
                                    & "CategoriaEmp = '" & cmbCategoriaEmp.Text & "', CuilEmp = '" & txtCuilEmp.Text & "' , FuncionEmp = '" & txtFuncionEmp.Text & "', ObsEmp = '" & txtObsEmp.Text & "' " _
                                    & " WHERE id_Emp = " & txtId_Emp.Text & " AND  NroEmp = " & txtNroEmp.Text & "", conexion)
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
        EmpleadosTableAdapter.Fill(DbsointDataSet.empleados)
        idCodigo = txtIdCodPosEmp.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos modificados del empleado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM empleados WHERE id_Emp = " & txtId_Emp.Text & " AND  NroEmp = " & txtNroEmp.Text & ""), conexion)
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
        EmpleadosTableAdapter.Fill(DbsointDataSet.empleados)
        idCodigo = txtIdCodPosEmp.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el empleado en pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 0
        Dim frmEmp0 As New frmConsEmpleados
        AddOwnedForm(frmEmp0)
        frmEmp0.ShowDialog()
        senial = 0
        idCodigo = txtIdCodPosEmp.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar en el padrón un empleado.")
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

        EmpleadosBindingSource.MoveFirst()
        idCodigo = txtIdCodPosEmp.Text
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

        EmpleadosBindingSource.MovePrevious()
        idCodigo = txtIdCodPosEmp.Text
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

        EmpleadosBindingSource.MoveNext()
        idCodigo = txtIdCodPosEmp.Text
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

        EmpleadosBindingSource.MoveLast()
        idCodigo = txtIdCodPosEmp.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()

    End Sub

    Private Sub BtnUltimo_MouseHover(sender As Object, e As EventArgs) Handles BtnUltimo.MouseHover

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
            senial = 2
            Dim frmCodPos2 As New frmConsCodPos
            AddOwnedForm(frmCodPos2)
            frmCodPos2.ShowDialog()
            idCodigo = txtIdCodPosEmp.Text
            CodPostal = ""
            LeerCodigoPostal()
            CargoLocalidad()
            txtTelefEmp.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            idCodigo = 0
            CodPostal = txtCodPostal.Text
            LeerCodigoPostal()
            CargoLocalidad()
            txtTelefEmp.Focus()
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

    Private Sub LeerEmpleados()

        comando.CommandText = "SELECT * FROM empleados WHERE NroCli = " & txtNroEmp.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            CargarEmpleado()
            idCodigo = txtIdCodPosEmp.Text
            CodPostal = ""
            LeerCodigoPostal()
            CargoLocalidad()
        Else
            detmsg = "Empleado no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        End If

    End Sub

    Private Sub CargarEmpleado()

        Dim row As DataRow = dt.Rows(0)

        txtId_Emp.Text = CStr(row("id_Emp"))
        txtNroEmp.Text = CStr(row("NroEmp"))
        txtNombreEmp.Text = CStr(row("NombreEmp"))
        txtDomicilioEmp.Text = CStr(row("DomicilioEmp"))
        txtIdCodPosEmp.Text = CStr(row("IdCodPosEmp"))
        txtTelefEmp.Text = CStr(row("TelefEmp"))
        cmbCategoriaEmp.Text = CStr(row("CategoriaEmp"))
        txtCuilEmp.Text = CStr(row("CuilEmp"))
        txtFuncionEmp.Text = CStr(row("FuncionEmp"))
        txtObsEmp.Text = CStr(row("ObsEmp"))

    End Sub

    Private Sub NroNuevo()

        comando = New MySqlCommand("SELECT MAX(NroEmp) NroEmp FROM empleados WHERE NroEmp > 0", conexion)
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                txtNroEmp.Text = Val(dr(0).ToString) + 1
            End While
            'Else
            '    txtNroEmp.Text = 1
        End If
        dr.Close()

    End Sub

    Private Sub Actualizar()

        EmpleadosTableAdapter.Fill(DbsointDataSet.empleados)
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
        idCodigo = txtIdCodPosEmp.Text
        CodPostal = ""
        LeerCodigoPostal()
        CargoLocalidad()
        txtNroEmp.Focus()

    End Sub

    Private Sub txtCuilEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuilEmp.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT NombreCE FROM categemple ORDER BY NombreCE DESC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbCategoriaEmp.Items.Add(dr(0).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub txtFecNacEmp_Leave(sender As Object, e As EventArgs) Handles txtFecNacEmp.Leave

        fechajob = txtFecNacEmp.Text
        If txtFecNacEmp.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtFecNacEmp.Text = ""
                txtFecNacEmp.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtFecNacEmp.Text = fechajob
                txtFecNacEmp.Refresh()
            End If
        End If

    End Sub

    Private Sub CargoLocalidad()

        txtCodPostal.Text = CodPostal
        txtIdCodPosEmp.Text = idCodigo
        txtLocalidad.Text = Localidad
        txtProvincia.Text = Provincia

    End Sub

End Class