﻿Public Class frmCompras
    Dim porcentaje, cantidad, unitario, neto, ivares, ivanores, impinterno, subtotal, total As Double
    Dim importe1, importe2, importe3, importe4, importe5 As Double
    Dim item, renglon, id As Integer
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        LimpiarTodo()
        ActivarBotones1()
        txtNroProvCpra.Focus()

    End Sub

    Private Sub txtNroProvCpra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProvCpra.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmProv2 As New frmConsProveedores
            AddOwnedForm(frmProv2)
            frmProv2.ShowDialog()
            senial = 0
            txtFechaCpra.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerProveedor()
            txtFechaCpra.Focus()
        End If

    End Sub

    Private Sub txtNroProvCpra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroProvCpra.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNroProvCpra_MouseHover(sender As Object, e As EventArgs) Handles txtNroProvCpra.MouseHover

        ToolTipMsg.ToolTipTitle = "Número Proveedor."
        ToolTipMsg.SetToolTip(txtNroProvCpra, "Presione F1 para consultar el padrón de proveedores.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerProveedor()

        comando.CommandText = "SELECT * FROM proveedores WHERE NroProv = " & txtNroProvCpra.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtTitularCpra.Text = CStr(row("RazonSocialProv"))
        Else
            detmsg = "Proveedor no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        End If

    End Sub

    Private Sub txtFechaCpra_Leave(sender As Object, e As EventArgs) Handles txtFechaCpra.Leave

        fechajob = txtFechaCpra.Text
        If txtFechaCpra.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtFechaCpra.Text = ""
                txtFechaCpra.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtFechaCpra.Text = fechajob
                txtFechaCpra.Refresh()
            End If
        End If

    End Sub

    Private Sub txtPrefijoCpra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrefijoCpra.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPrefijoCpra_LostFocus(sender As Object, e As EventArgs) Handles txtPrefijoCpra.LostFocus

        numero = txtPrefijoCpra.Text
        PonerCeros(numero, 4)
        txtPrefijoCpra.Text = nroconceros
        txtPrefijoCpra.Refresh()

    End Sub

    Private Sub txtSubfijoCpra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubfijoCpra.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtSubfijoCpra_LostFocus(sender As Object, e As EventArgs) Handles txtSubfijoCpra.LostFocus

        numero = txtSubfijoCpra.Text
        PonerCeros(numero, 8)
        txtSubfijoCpra.Text = nroconceros
        txtSubfijoCpra.Refresh()

        LeerCompra()

        btnLimpiar.Visible = True

        txtCantDetCpra.Focus()

    End Sub

    Private Sub txtCantDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtCantDetCpra.LostFocus

        If txtCantDetCpra.Text <> "0" Then
            txtDetalleDetCpra.Focus()
        End If

    End Sub

    Private Sub txtDetalleDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtDetalleDetCpra.LostFocus

        If txtDetalleDetCpra.Text = "" Then
            txtDetalleDetCpra.Focus()
        End If

    End Sub

    Private Sub txtUnitDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtUnitDetCpra.LostFocus

        If txtUnitDetCpra.Text = "" Then
            txtUnitDetCpra.Focus()
        Else
            IniciarVariables()
            unitario = txtUnitDetCpra.Text
            txtUnitDetCpra.Text = Format(CDec(txtUnitDetCpra.Text), "########0.00")

            If cbxTipoCbteCpra.Text = "FAA" Then
                comando.CommandText = "SELECT * FROM categiva WHERE AbrevCI = 'RI' "
                dt = New DataTable
                da = New MySqlDataAdapter(comando)
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    porcentaje = Val(CStr(row("RespInsCI")))
                    cantidad = Val(txtCantDetCpra.Text)
                    neto = cantidad * unitario
                    txtNetoDetCpra.Text = Str(neto)
                    ivares = (neto * porcentaje) / 100
                    txtResDetCpra.Text = Str(ivares)
                    txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "########0.00")
                    txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "########0.00")
                End If
            Else
                cantidad = Val(txtCantDetCpra.Text)
                neto = cantidad * unitario
                txtNetoDetCpra.Text = Str(neto)
                txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "########0.00")
            End If
        End If

    End Sub

    Private Sub txtNetoDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtNetoDetCpra.LostFocus

        If txtNetoDetCpra.Text = "" Then
            neto = 0
            txtNetoDetCpra.Text = "0"
            txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "########0.00")
        Else
            numero = txtNetoDetCpra.Text
            txtNetoDetCpra.Text = ValorPesos(numero)
            neto = txtNetoDetCpra.Text
            txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "########0.00")
        End If

    End Sub

    Private Sub txtResDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtResDetCpra.LostFocus

        If txtResDetCpra.Text = "" Then
            ivares = 0
            txtResDetCpra.Text = "0"
            txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "########0.00")
        Else
            numero = txtResDetCpra.Text
            txtResDetCpra.Text = ValorPesos(numero)
            ivares = txtResDetCpra.Text
            txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "########0.00")
        End If

    End Sub

    Private Sub txtNoResDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtNoResDetCpra.LostFocus

        If txtNoResDetCpra.Text = "" Then
            ivanores = 0
            txtNoResDetCpra.Text = "0"
            txtNoResDetCpra.Text = Format(CDec(txtNoResDetCpra.Text), "########0.00")
        Else
            numero = txtNoResDetCpra.Text
            txtNoResDetCpra.Text = ValorPesos(numero)
            ivanores = txtNoResDetCpra.Text
            txtNoResDetCpra.Text = Format(CDec(txtNoResDetCpra.Text), "########0.00")
        End If

    End Sub

    Private Sub txtImpIntDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtImpIntDetCpra.LostFocus

        If txtImpIntDetCpra.Text = "" Then
            impinterno = 0
            txtImpIntDetCpra.Text = "0"
            txtImpIntDetCpra.Text = Format(CDec(txtImpIntDetCpra.Text), "########0.00")
        Else
            numero = txtImpIntDetCpra.Text
            txtImpIntDetCpra.Text = ValorPesos(numero)
            impinterno = txtImpIntDetCpra.Text
            txtImpIntDetCpra.Text = Format(CDec(txtImpIntDetCpra.Text), "########0.00")
        End If

    End Sub

    Private Sub txtTotalDetCpra_GotFocus(sender As Object, e As EventArgs) Handles txtTotalDetCpra.GotFocus

        subtotal = neto + ivares + ivanores + impinterno
        txtTotalDetCpra.Text = subtotal
        txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "########0.00")

    End Sub

    Private Sub txtTotalDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtTotalDetCpra.LostFocus

        If txtTotalDetCpra.Text = "" Then
            subtotal = 0
            txtTotalDetCpra.Text = "0"
            txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "########0.00")
        Else
            numero = txtTotalDetCpra.Text
            txtTotalDetCpra.Text = ValorPesos(numero)
            subtotal = txtTotalDetCpra.Text
            txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "########0.00")
        End If

    End Sub

    Private Sub txtImputadoDetCpra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSRubDetCpra.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmCpra0 As New frmConsSubRubros
            AddOwnedForm(frmCpra0)
            frmCpra0.ShowDialog()
            senial = 0
            txtObraDetCpra.Focus()

        End If

    End Sub

    Private Sub txtObraDetCpra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObraDetCpra.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmObra2 As New frmConsObra
            AddOwnedForm(frmObra2)
            frmObra2.ShowDialog()
            senial = 0
            LeerObra()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerObra()
        End If

    End Sub

    Private Sub LeerObra()

        comando.CommandText = "SELECT * FROM obras WHERE NroObra = '" & txtObraDetCpra.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtObraDetCpra.Text = CStr(row("NroObra"))
            btnAgregar.Visible = True
            btnAgregar.Focus()
        Else
            txtObraDetCpra.Text = ""
            detmsg = "Obra no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtObraDetCpra.Focus()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        CargarDGV()
        Calcular()
        btnGrabar.Visible = True

    End Sub

    Private Sub CargarDGV()

        dgvDetCompras.Rows.Add()
        item = dgvDetCompras.Rows.Count
        fila = item - 1
        dgvDetCompras.Rows(fila).Cells(0).Value = 0
        dgvDetCompras.Rows(fila).Cells(1).Value = 0
        dgvDetCompras.Rows(fila).Cells(2).Value = item.ToString()
        dgvDetCompras.Rows(fila).Cells(3).Value = txtCantDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(4).Value = txtDetalleDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(5).Value = txtUnitDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(6).Value = txtNetoDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(7).Value = txtResDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(8).Value = txtNoResDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(9).Value = txtImpIntDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(10).Value = txtTotalDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(11).Value = txtIdSRubDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(12).Value = txtSRubDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(13).Value = txtObraDetCpra.Text

    End Sub

    Private Sub Calcular()

        importe1 = importe1 + neto
        importe2 = importe2 + ivares
        importe3 = importe3 + ivanores
        importe4 = importe4 + impinterno
        importe5 = importe5 + subtotal
        txtNetoCpra.Text = Format(CDec(importe1), "########0.00")
        txtIvaResCpra.Text = Format(CDec(importe2), "########0.00")
        txtIvaNoResCpra.Text = Format(CDec(importe3), "########0.00")
        txtImpIntCpra.Text = Format(CDec(importe4), "########0.00")
        txtTotalCpra.Text = Format(CDec(importe5), "########0.00")

        LimpiarRenglonIngreso()
        txtCantDetCpra.Focus()

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        GrabarCompra()
        LimpiarTodo()
        txtNroProvCpra.Focus()

    End Sub

    Private Sub GrabarCompra()

        Try
            comando = New MySqlCommand("INSERT INTO compras VALUES(@id, @prov, @titular, @fecha, @tipo, @prefijo, @subfijo, @neto, @ivares, @ivanores, @impint, @total)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@prov", txtNroProvCpra.Text)
            comando.Parameters.AddWithValue("@titular", txtTitularCpra.Text)
            fechajob = txtFechaCpra.Text
            ProcesarFecha()
            comando.Parameters.AddWithValue("@fecha", fechadb)
            comando.Parameters.AddWithValue("@tipo", cbxTipoCbteCpra.Text)
            comando.Parameters.AddWithValue("@prefijo", txtPrefijoCpra.Text)
            comando.Parameters.AddWithValue("@subfijo", txtSubfijoCpra.Text)
            comando.Parameters.AddWithValue("@neto", txtNetoCpra.Text)
            comando.Parameters.AddWithValue("@ivares", txtIvaResCpra.Text)
            comando.Parameters.AddWithValue("@ivanores", txtIvaNoResCpra.Text)
            comando.Parameters.AddWithValue("@impint", txtImpIntCpra.Text)
            comando.Parameters.AddWithValue("@total", txtTotalCpra.Text)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            detmsg = "Grabación de compra cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        '*** BUSCO EL ÚLTIMO INDICE GRABADO EN LA TABLA COMPRA ***
        comando.CommandText = "SELECT @@identity AS id"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        id = dt.Rows(0).Item(0).ToString()
        '*********************************************************

        renglon = dgvDetCompras.Rows.Count

        For j = 0 To renglon - 1
            Try
                comando = New MySqlCommand("INSERT INTO detallecpra VALUES(@id, @idcpra, @item, @cantidad, @detalle, @unitario, @neto, @ivares, @ivanores, @impint, @total, @idsubrubro, @subrubro, @obra)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@idcpra", id)
                comando.Parameters.AddWithValue("@item", dgvDetCompras.Rows(j).Cells(2).Value)
                comando.Parameters.AddWithValue("@cantidad", dgvDetCompras.Rows(j).Cells(3).Value)
                comando.Parameters.AddWithValue("@detalle", dgvDetCompras.Rows(j).Cells(4).Value)
                comando.Parameters.AddWithValue("@unitario", dgvDetCompras.Rows(j).Cells(5).Value)
                comando.Parameters.AddWithValue("@neto", dgvDetCompras.Rows(j).Cells(6).Value)
                comando.Parameters.AddWithValue("@ivares", dgvDetCompras.Rows(j).Cells(7).Value)
                comando.Parameters.AddWithValue("@ivanores", dgvDetCompras.Rows(j).Cells(8).Value)
                comando.Parameters.AddWithValue("@impint", dgvDetCompras.Rows(j).Cells(9).Value)
                comando.Parameters.AddWithValue("@total", dgvDetCompras.Rows(j).Cells(10).Value)
                comando.Parameters.AddWithValue("@idsubrubro", dgvDetCompras.Rows(j).Cells(11).Value)
                comando.Parameters.AddWithValue("@subrubro", dgvDetCompras.Rows(j).Cells(12).Value)
                comando.Parameters.AddWithValue("@obra", dgvDetCompras.Rows(j).Cells(13).Value)
                comando.ExecuteNonQuery()

            Catch ex As Exception
                detmsg = "Grabación detalle de compra cancelada...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End Try
        Next

        GrabarCtaCte()
        ActivarBotones1()

    End Sub

    Private Sub LimpiarCabecera()

        txtId_Cpra.Text = ""
        txtNroProvCpra.Text = ""
        txtTitularCpra.Text = ""
        txtFechaCpra.Text = ""
        cbxTipoCbteCpra.Text = ""
        txtPrefijoCpra.Text = ""
        txtSubfijoCpra.Text = ""
        cbxTipoCbteCpra.SelectedItem = 0

    End Sub

    Private Sub LimpiarRenglonIngreso()

        txtCantDetCpra.Text = "0"
        txtDetalleDetCpra.Text = ""
        txtUnitDetCpra.Text = "0"
        txtNetoDetCpra.Text = "0"
        txtResDetCpra.Text = "0"
        txtNoResDetCpra.Text = "0"
        txtImpIntDetCpra.Text = "0"
        txtTotalDetCpra.Text = "0"
        txtUnitDetCpra.Text = Format(CDec(txtUnitDetCpra.Text), "########0.00")
        txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "########0.00")
        txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "########0.00")
        txtNoResDetCpra.Text = Format(CDec(txtNoResDetCpra.Text), "########0.00")
        txtImpIntDetCpra.Text = Format(CDec(txtImpIntDetCpra.Text), "########0.00")
        txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "########0.00")

    End Sub

    Private Sub IniciarVariables()

        porcentaje = 0
        unitario = 0
        neto = 0
        ivares = 0
        ivanores = 0
        impinterno = 0
        subtotal = 0
        total = 0

    End Sub

    Private Sub LimpiarTodo()

        LimpiarCabecera()
        LimpiarRenglonIngreso()

        'dgvDetCompras.DataSource = Nothing
        dgvDetCompras.Rows.Clear()

        txtIdSRubDetCpra.Text = ""
        txtSRubDetCpra.Text = ""
        txtObraDetCpra.Text = ""

        importe1 = 0
        importe2 = 0
        importe3 = 0
        importe4 = 0
        importe5 = 0

        txtNetoCpra.Text = "0"
        txtIvaResCpra.Text = "0"
        txtIvaNoResCpra.Text = "0"
        txtImpIntCpra.Text = "0"
        txtTotalCpra.Text = "0"

        txtNetoCpra.Text = Format(CDec(txtNetoCpra.Text), "########0.00")
        txtIvaResCpra.Text = Format(CDec(txtIvaResCpra.Text), "########0.00")
        txtIvaNoResCpra.Text = Format(CDec(txtIvaNoResCpra.Text), "########0.00")
        txtImpIntCpra.Text = Format(CDec(txtImpIntCpra.Text), "########0.00")
        txtTotalCpra.Text = Format(CDec(txtTotalCpra.Text), "########0.00")

        IniciarVariables()

        txtNroProvCpra.Focus()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarTodo()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub LeerCompra()

        comando.CommandText = "SELECT * FROM compras WHERE NroProvCpra = '" & txtNroProvCpra.Text & "' AND PrefijoCpra = '" & txtPrefijoCpra.Text & "' " _
                                & " AND SubfijoCpra = '" & txtSubfijoCpra.Text & "' AND TipoCbteCpra = '" & cbxTipoCbteCpra.Text & "' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtId_Cpra.Text = CStr(row("id_Cpra"))
            importe1 = CStr(row("NetoCpra"))
            importe2 = CStr(row("IvaResCpra"))
            importe3 = CStr(row("IvaNoResCpra"))
            importe4 = CStr(row("ImpIntCpra"))
            importe5 = CStr(row("TotalCpra"))
            txtNetoCpra.Text = Format(CDec(importe1), "########0.00")
            txtIvaResCpra.Text = Format(CDec(importe2), "########0.00")
            txtIvaNoResCpra.Text = Format(CDec(importe3), "########0.00")
            txtImpIntCpra.Text = Format(CDec(importe4), "########0.00")
            txtTotalCpra.Text = Format(CDec(importe5), "########0.00")
            CargarDGVCompra()
            btnLimpiar.Visible = True
            btnModificar.Visible = True
            btnEliminar.Visible = True
        End If

    End Sub

    Private Sub CargarDGVCompra()

        comando = New MySqlCommand("SELECT * FROM detallecpra WHERE IdCpraDetCpra = '" & txtId_Cpra.Text & "' ORDER BY ItemDetCpra", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                dgvDetCompras.Rows.Add()
                item = dgvDetCompras.Rows.Count
                fila = item - 1
                dgvDetCompras.Rows(fila).Cells(0).Value = dr(0).ToString()
                dgvDetCompras.Rows(fila).Cells(1).Value = dr(1).ToString()
                dgvDetCompras.Rows(fila).Cells(2).Value = dr(2).ToString()
                dgvDetCompras.Rows(fila).Cells(3).Value = dr(3).ToString()
                dgvDetCompras.Rows(fila).Cells(4).Value = dr(4).ToString()
                dgvDetCompras.Rows(fila).Cells(5).Value = Format(CDec(dr(5).ToString()), "########0.00")
                dgvDetCompras.Rows(fila).Cells(6).Value = Format(CDec(dr(6).ToString()), "########0.00")
                dgvDetCompras.Rows(fila).Cells(7).Value = Format(CDec(dr(7).ToString()), "########0.00")
                dgvDetCompras.Rows(fila).Cells(8).Value = Format(CDec(dr(8).ToString()), "########0.00")
                dgvDetCompras.Rows(fila).Cells(9).Value = Format(CDec(dr(9).ToString()), "########0.00")
                dgvDetCompras.Rows(fila).Cells(10).Value = Format(CDec(dr(10).ToString()), "########0.00")
                dgvDetCompras.Rows(fila).Cells(11).Value = dr(11).ToString()
                dgvDetCompras.Rows(fila).Cells(12).Value = dr(12).ToString()
                dgvDetCompras.Rows(fila).Cells(13).Value = dr(13).ToString()
            End While
        End If

        dr.Close()

    End Sub

    Private Sub dgvDetCompras_DoubleClick(sender As Object, e As EventArgs) Handles dgvDetCompras.DoubleClick

        fila = dgvDetCompras.CurrentRow.Index
        txtId_DetCpra.Text = dgvDetCompras.CurrentRow.Cells(0).Value.ToString
        txtId_Cpra.Text = dgvDetCompras.CurrentRow.Cells(1).Value.ToString
        txtItemDetCpra.Text = dgvDetCompras.CurrentRow.Cells(2).Value.ToString
        txtCantDetCpra.Text = dgvDetCompras.CurrentRow.Cells(3).Value.ToString
        txtDetalleDetCpra.Text = dgvDetCompras.CurrentRow.Cells(4).Value.ToString
        txtUnitDetCpra.Text = dgvDetCompras.CurrentRow.Cells(5).Value.ToString
        txtNetoDetCpra.Text = dgvDetCompras.CurrentRow.Cells(6).Value.ToString
        txtResDetCpra.Text = dgvDetCompras.CurrentRow.Cells(7).Value.ToString
        txtNoResDetCpra.Text = dgvDetCompras.CurrentRow.Cells(8).Value.ToString
        txtImpIntDetCpra.Text = dgvDetCompras.CurrentRow.Cells(9).Value.ToString
        txtTotalDetCpra.Text = dgvDetCompras.CurrentRow.Cells(10).Value.ToString
        txtIdSRubDetCpra.Text = dgvDetCompras.CurrentRow.Cells(11).Value.ToString
        txtSRubDetCpra.Text = dgvDetCompras.CurrentRow.Cells(12).Value.ToString
        txtObraDetCpra.Text = dgvDetCompras.CurrentRow.Cells(13).Value.ToString
        txtUnitDetCpra.Text = Format(CDec(txtUnitDetCpra.Text), "########0.00")
        txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "########0.00")
        txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "########0.00")
        txtNoResDetCpra.Text = Format(CDec(txtNoResDetCpra.Text), "########0.00")
        txtImpIntDetCpra.Text = Format(CDec(txtImpIntDetCpra.Text), "########0.00")
        txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "########0.00")

        btnActualizar.Visible = True
        btnAgregar.Visible = False
        txtCantDetCpra.Focus()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        dgvDetCompras.Rows(fila).Cells(0).Value = txtId_DetCpra.Text
        dgvDetCompras.Rows(fila).Cells(1).Value = txtId_Cpra.Text
        dgvDetCompras.Rows(fila).Cells(2).Value = txtItemDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(3).Value = txtCantDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(4).Value = txtDetalleDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(5).Value = txtUnitDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(6).Value = txtNetoDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(7).Value = txtResDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(8).Value = txtNoResDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(9).Value = txtImpIntDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(10).Value = txtTotalDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(11).Value = txtIdSRubDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(12).Value = txtSRubDetCpra.Text
        dgvDetCompras.Rows(fila).Cells(13).Value = txtObraDetCpra.Text

        CalcularTotales()
        LimpiarRenglonIngreso()

    End Sub

    Private Sub CalcularTotales()

        IniciarVariables()
        renglon = dgvDetCompras.Rows.Count

        For j = 0 To renglon - 1
            neto = neto + dgvDetCompras.Rows(j).Cells(6).Value
            ivares = ivares + dgvDetCompras.Rows(j).Cells(7).Value
            ivanores = ivanores + dgvDetCompras.Rows(j).Cells(8).Value
            impinterno = impinterno + dgvDetCompras.Rows(j).Cells(9).Value
            total = total + dgvDetCompras.Rows(j).Cells(10).Value
        Next

        txtNetoCpra.Text = neto
        txtIvaResCpra.Text = ivares
        txtIvaNoResCpra.Text = ivanores
        txtImpIntCpra.Text = impinterno
        txtTotalCpra.Text = total

        txtNetoCpra.Text = Format(CDec(txtNetoCpra.Text), "########0.00")
        txtIvaResCpra.Text = Format(CDec(txtIvaResCpra.Text), "########0.00")
        txtIvaNoResCpra.Text = Format(CDec(txtIvaNoResCpra.Text), "########0.00")
        txtImpIntCpra.Text = Format(CDec(txtImpIntCpra.Text), "########0.00")
        txtTotalCpra.Text = Format(CDec(txtTotalCpra.Text), "########0.00")

    End Sub

    Private Sub ActivarBotones1()

        btnActualizar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnGrabar.Visible = False

        txtNroProvCpra.Focus()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then

            fechajob = txtFechaCpra.Text
            ProcesarFecha()

            comando = New MySqlCommand("UPDATE compras SET NroProvCpra = '" & txtNroProvCpra.Text & "', TitularCpra = '" & txtTitularCpra.Text & "', FechaCpra = '" & fechadb & "', " _
                                    & "TipoCbteCpra = '" & cbxTipoCbteCpra.Text & "', PrefijoCpra = '" & txtPrefijoCpra.Text & "', SubfijoCpra = '" & txtSubfijoCpra.Text & "', NetoCpra = '" & txtNetoCpra.Text & "', " _
                                    & "IvaResCpra = '" & txtIvaResCpra.Text & "', IvaNoResCpra = '" & txtIvaNoResCpra.Text & "', ImpIntCpra = '" & txtImpIntCpra.Text & "', TotalCpra = '" & txtTotalCpra.Text & "' " _
                                    & " WHERE id_Cpra = " & txtId_Cpra.Text & " AND  NroProvCpra = " & txtNroProvCpra.Text & "", conexion)
            comando.ExecuteNonQuery()

            renglon = dgvDetCompras.Rows.Count

            For j = 0 To renglon - 1

                txtId_DetCpra.Text = dgvDetCompras.CurrentRow.Cells(0).Value.ToString
                txtId_Cpra.Text = dgvDetCompras.CurrentRow.Cells(1).Value.ToString
                txtItemDetCpra.Text = dgvDetCompras.CurrentRow.Cells(2).Value.ToString
                txtCantDetCpra.Text = dgvDetCompras.CurrentRow.Cells(3).Value.ToString
                txtDetalleDetCpra.Text = dgvDetCompras.CurrentRow.Cells(4).Value.ToString
                txtUnitDetCpra.Text = dgvDetCompras.CurrentRow.Cells(5).Value.ToString
                txtNetoDetCpra.Text = dgvDetCompras.CurrentRow.Cells(6).Value.ToString
                txtResDetCpra.Text = dgvDetCompras.CurrentRow.Cells(7).Value.ToString
                txtNoResDetCpra.Text = dgvDetCompras.CurrentRow.Cells(8).Value.ToString
                txtImpIntDetCpra.Text = dgvDetCompras.CurrentRow.Cells(9).Value.ToString
                txtTotalDetCpra.Text = dgvDetCompras.CurrentRow.Cells(10).Value.ToString
                txtIdSRubDetCpra.Text = dgvDetCompras.CurrentRow.Cells(11).Value.ToString
                txtSRubDetCpra.Text = dgvDetCompras.CurrentRow.Cells(12).Value.ToString
                txtObraDetCpra.Text = dgvDetCompras.CurrentRow.Cells(13).Value.ToString

                comando = New MySqlCommand("UPDATE detallecpra SET id_DetCpra = '" & txtId_DetCpra.Text & "', idCpraDetCpra = '" & txtId_Cpra.Text & "', ItemDetCpra = '" & txtItemDetCpra.Text & "', " _
                                    & "CantDetCpra = '" & txtCantDetCpra.Text & "', DetalleDetCpra = '" & txtDetalleDetCpra.Text & "', UnitDetCpra = '" & txtUnitDetCpra.Text & "', NetoDetCpra = '" & txtNetoDetCpra.Text & "', " _
                                    & "ResDetCpra = '" & txtResDetCpra.Text & "', NoResDetCpra = '" & txtNoResDetCpra.Text & "', ImpIntDetCpra = '" & txtImpIntDetCpra.Text & "', TotalDetCpra = '" & txtTotalDetCpra.Text & "', " _
                                    & "IdSRubDetCpra = '" & txtIdSRubDetCpra.Text & "', SRubDetCpra = '" & txtSRubDetCpra.Text & "', ObraDetCpra = '" & txtObraDetCpra.Text & "' " _
                                    & " WHERE id_DetCpra = " & txtId_DetCpra.Text & " AND  IdCpraDetCpra = " & txtId_Cpra.Text & "", conexion)
                comando.ExecuteNonQuery()
            Next

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

        ActivarBotones1()

        LimpiarTodo()

        txtNroProvCpra.Focus()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        detmsg = "Desea Eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then

            comando = New MySqlCommand(("DELETE FROM compras WHERE NroProvCpra = '" & txtNroProvCpra.Text & "' AND  id_Cpra = '" & txtId_Cpra.Text & "'"), conexion)
            comando.ExecuteNonQuery()

            comando = New MySqlCommand(("DELETE FROM detallecpra WHERE idCpraDetCpra = '" & txtId_Cpra.Text & "' "), conexion)
            comando.ExecuteNonQuery()

            detmsg = "Registro eliminado correctamente...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            LimpiarTodo()
            ActivarBotones1()

        End If

    End Sub

    Private Sub GrabarCtaCte()

        Try
            comando = New MySqlCommand("INSERT INTO ctactepro VALUES(@id, @idcpra, @prov, @fecha, @tipo, @prefijo, @subfijo, @detalle, @debe, @haber, @saldo, @obs)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@idcpra", id)
            comando.Parameters.AddWithValue("@prov", txtNroProvCpra.Text)
            fechajob = txtFechaCpra.Text
            ProcesarFecha()
            comando.Parameters.AddWithValue("@fecha", fechadb)
            comando.Parameters.AddWithValue("@tipo", cbxTipoCbteCpra.Text)
            comando.Parameters.AddWithValue("@prefijo", txtPrefijoCpra.Text)
            comando.Parameters.AddWithValue("@subfijo", txtSubfijoCpra.Text)
            comando.Parameters.AddWithValue("@detalle", "")
            comando.Parameters.AddWithValue("@debe", 0)
            comando.Parameters.AddWithValue("@haber", txtTotalCpra.Text)
            comando.Parameters.AddWithValue("@saldo", 0)
            comando.Parameters.AddWithValue("@obs", "")
            comando.ExecuteNonQuery()
        Catch ex As Exception
            detmsg = "Grabación de cuenta corriente cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar los datos ingresados.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(btnActualizar, "Presione para modificar los datos ingresados en la grilla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(btnAgregar, "Presione agregar una nueva compra.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(btnEliminar, "Presione para eliminar la compra seleccionar.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnGrabar_MouseHover(sender As Object, e As EventArgs) Handles btnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(btnGrabar, "Presione para grabar la compra cargada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnModificar_MouseHover(sender As Object, e As EventArgs) Handles btnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(btnModificar, "Presione para grabar las modificaciones ingresadas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class