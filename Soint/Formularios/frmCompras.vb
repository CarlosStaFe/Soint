Public Class frmCompras
    Dim porcentaje, cantidad, unitario, neto, ivares, ivanores, impinterno, subtotal, total As Double
    Dim importe1, importe2, importe3, importe4, importe5 As Double
    Dim item, renglon As Integer
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        DetallecpraTableAdapter.Fill(DbsointDataSet.detallecpra)
        ComprasTableAdapter.Fill(DbsointDataSet.compras)

        'Limpiar()
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

        'LeerCompra()

        txtCantDetCpra.Focus()

        importe1 = 0
        importe2 = 0
        importe3 = 0
        importe4 = 0
        importe5 = 0

    End Sub

    Private Sub txtCantDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtCantDetCpra.LostFocus

        If txtCantDetCpra.Text = "" Then
            txtCantDetCpra.Focus()
        Else
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
            txtUnitDetCpra.Text = Format(CDec(txtUnitDetCpra.Text), "C")

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
                    txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "C")
                    txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "C")
                End If
            End If

        End If
    End Sub

    Private Sub txtNetoDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtNetoDetCpra.LostFocus

        If txtNetoDetCpra.Text = "" Then
            neto = 0
            txtNetoDetCpra.Text = "0"
            txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "C")
        Else
            numero = txtNetoDetCpra.Text
            txtNetoDetCpra.Text = ValorPesos(numero)
            neto = txtNetoDetCpra.Text
            txtNetoDetCpra.Text = Format(CDec(txtNetoDetCpra.Text), "C")
        End If

    End Sub

    Private Sub txtResDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtResDetCpra.LostFocus

        If txtResDetCpra.Text = "" Then
            ivares = 0
            txtResDetCpra.Text = "0"
            txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "C")
        Else
            numero = txtResDetCpra.Text
            txtResDetCpra.Text = ValorPesos(numero)
            ivares = txtResDetCpra.Text
            txtResDetCpra.Text = Format(CDec(txtResDetCpra.Text), "C")
        End If

    End Sub

    Private Sub txtNoResDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtNoResDetCpra.LostFocus

        If txtNoResDetCpra.Text = "" Then
            ivanores = 0
            txtNoResDetCpra.Text = "0"
            txtNoResDetCpra.Text = Format(CDec(txtNoResDetCpra.Text), "C")
        Else
            numero = txtNoResDetCpra.Text
            txtNoResDetCpra.Text = ValorPesos(numero)
            ivanores = txtNoResDetCpra.Text
            txtNoResDetCpra.Text = Format(CDec(txtNoResDetCpra.Text), "C")
        End If

    End Sub

    Private Sub txtImpIntDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtImpIntDetCpra.LostFocus

        If txtImpIntDetCpra.Text = "" Then
            impinterno = 0
            txtImpIntDetCpra.Text = "0"
            txtImpIntDetCpra.Text = Format(CDec(txtImpIntDetCpra.Text), "C")
        Else
            numero = txtImpIntDetCpra.Text
            txtImpIntDetCpra.Text = ValorPesos(numero)
            impinterno = txtImpIntDetCpra.Text
            txtImpIntDetCpra.Text = Format(CDec(txtImpIntDetCpra.Text), "C")
        End If

    End Sub

    Private Sub txtTotalDetCpra_GotFocus(sender As Object, e As EventArgs) Handles txtTotalDetCpra.GotFocus

        subtotal = neto + ivares + ivanores + impinterno
        txtTotalDetCpra.Text = subtotal
        txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "C")

    End Sub

    Private Sub txtTotalDetCpra_LostFocus(sender As Object, e As EventArgs) Handles txtTotalDetCpra.LostFocus

        If txtTotalDetCpra.Text = "" Then
            subtotal = 0
            txtTotalDetCpra.Text = "0"
            txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "C")
        Else
            numero = txtTotalDetCpra.Text
            txtTotalDetCpra.Text = ValorPesos(numero)
            subtotal = txtTotalDetCpra.Text
            txtTotalDetCpra.Text = Format(CDec(txtTotalDetCpra.Text), "C")
        End If

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        CargarDGV()
        Calcular()

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
            btnAgregar.Visible = True
            btnAgregar.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerObra()
            btnAgregar.Visible = True
            btnAgregar.Focus()
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
        Else
            txtObraDetCpra.Text = ""
            detmsg = "Obra no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtObraDetCpra.Focus()
        End If

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
        txtNetoCpra.Text = Format(CDec(importe1), "C")
        txtIvaResCpra.Text = Format(CDec(importe2), "C")
        txtIvaNoResCpra.Text = Format(CDec(importe3), "C")
        txtImpIntCpra.Text = Format(CDec(importe4), "C")
        txtTotalCpra.Text = Format(CDec(importe5), "C")

        LimpiarIngreso()

    End Sub

    Private Sub LimpiarIngreso()

        txtCantDetCpra.Text = ""
        txtDetalleDetCpra.Text = ""
        txtUnitDetCpra.Text = ""
        txtNetoDetCpra.Text = ""
        txtResDetCpra.Text = ""
        txtNoResDetCpra.Text = ""
        txtImpIntDetCpra.Text = ""
        txtTotalDetCpra.Text = ""
        txtCantDetCpra.Focus()

    End Sub

End Class