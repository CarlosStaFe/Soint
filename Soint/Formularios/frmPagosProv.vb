﻿Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class frmPagosProv
    Dim contador As Integer
    Dim ImpLetras, flag As String
    Dim tiponro, comprobante, dd, mm, yyyy As String
    Dim fecha, id, pagado, letratotal As String
    Dim saldofac, pagadofac, importe, imppagado As Double
    Dim obs, cuit As String
    Dim archivo As String
    Dim fecvto As String
    Dim resto, pagoact, restoant, saldoact, saldopago As Double

    Private Sub frmPagosProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        senial = ""
        'ControlarCaja()

        If flag = "NO" Then
            Limpiar()
            txtProveedor.Enabled = False
            txtObs.Enabled = False
            txtEfectivo.Enabled = False
            txtTransferencia.Enabled = False
            txtTarjeta.Enabled = False
            btnSalir.Focus()
        Else
            CtacteproTableAdapter.Fill(DbsointDataSet.ctactepro)
            Limpiar()
            txtProveedor.Focus()
            ReportViewer1.RefreshReport()
            txtFecha.Text = Format(Now, "dd/MM/yyyy")
        End If

        'ReportViewer1.RefreshReport()

    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 3
            Dim frmProv3 As New frmConsProveedores
            AddOwnedForm(frmProv3)
            frmProv3.ShowDialog()
            txtProveedor.Focus()
            senial = 0
        End If
        If e.KeyCode = Keys.Enter Then
            LeerProveedores()
            CargarCtasCtes()
        End If

    End Sub

    Private Sub LeerProveedores()

        comando = New MySqlCommand("SELECT * FROM proveedores WHERE NroProv = '" & txtProveedor.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                txtNombre.Text = dr(2).ToString
                flag = "S"
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub CargarCtasCtes()

        comando.CommandText = "SELECT * FROM ctactepro WHERE NroCCPro = " & txtProveedor.Text & " AND EstadoCCPro = 'PENDIENTE' ORDER BY FechaCCPro"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        txtSaldo.Text = "0"
        contador = 0

        dgvCtasCtes.DataSource = dt

        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                'txtSaldo.Text = txtSaldo.Text - Fila.Cells(8).Value + Fila.Cells(9).Value
                txtSaldo.Text = txtSaldo.Text - Fila.Cells(14).Value
            Next
            txtSaldo.Text = Format(CDec(txtSaldo.Text), "########0.00")
            txtApagar.Text = Format(CDec(txtApagar.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
            dgvCtasCtes.Refresh()
            btnLimpiar.Visible = True
            dgvCtasCtes.Focus()
        Else
            detmsg = "No posee deudas pendientes...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            Limpiar()
            txtProveedor.Focus()
        End If

    End Sub

    Private Sub txtEfectivo_LostFocus(sender As Object, e As EventArgs) Handles txtEfectivo.LostFocus

        If txtEfectivo.Text > 0 Then
            txtDiferencia.Text = txtApagar.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
            txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
            txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        End If

        If txtDiferencia.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtTransferencia_LostFocus(sender As Object, e As EventArgs) Handles txtTransferencia.LostFocus

        If txtTransferencia.Text > 0 Then
            txtDiferencia.Text = txtApagar.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
            txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
            txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        End If

        If txtDiferencia.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtTarjeta_LostFocus(sender As Object, e As EventArgs) Handles txtTarjeta.LostFocus

        If txtTarjeta.Text > 0 Then
            txtDiferencia.Text = txtApagar.Text - txtEfectivo.Text - txtTransferencia.Text - txtTarjeta.Text
            txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
            txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
            txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")
            txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        End If

        If txtDiferencia.Text < 0 Then
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub txtObs_LostFocus(sender As Object, e As EventArgs) Handles txtObs.LostFocus

        If dgvCtasCtes.Rows.Count > 0 Then
            If txtDiferencia.Text = txtSaldo.Text Then
                detmsg = "DEBE CARGAR ALGÚN PAGO...!!!"
                tipomsg = "info"
                btnmsg = 1
                frmMsgBox.ShowDialog()
                txtEfectivo.Focus()
            Else
                imppagado = Val(txtEfectivo.Text) + Val(txtTransferencia.Text) + Val(txtTarjeta.Text)
                letratotal = Convert.ToDouble(imppagado)
                btnImprimir.Visible = True
                btnImprimir.Focus()
            End If
        Else
            detmsg = "DEBE MARCAR ALGÚN RENGLÓN...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        If txtDiferencia.Text < "0" Then
            detmsg = "DEBE MARCAR OTRA BOLETA O MODIFICAR EL IMPORTE DE PAGO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

            btnImprimir.Visible = False
            txtEfectivo.Focus()
        End If

    End Sub
    Private Sub Limpiar()

        txtProveedor.Text = ""
        txtNombre.Text = ""
        txtApagar.Text = "0"
        txtDiferencia.Text = "0"
        txtEfectivo.Text = "0"
        txtTransferencia.Text = "0"
        txtTarjeta.Text = "0"
        txtSaldo.Text = "0"
        pagado = "0"
        txtObs.Text = ""
        cuit = ""
        contador = 0
        txtSaldo.Text = Format(CDec(txtSaldo.Text), "########0.00")
        txtApagar.Text = Format(CDec(txtApagar.Text), "########0.00")
        txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        txtEfectivo.Text = Format(CDec(txtEfectivo.Text), "########0.00")
        txtTransferencia.Text = Format(CDec(txtTransferencia.Text), "########0.00")
        txtTarjeta.Text = Format(CDec(txtTarjeta.Text), "########0.00")

        dgvCtasCtes.DataSource = Nothing

        btnSalir.Visible = True
        btnLimpiar.Visible = False
        btnImprimir.Visible = False
        'rdbNotaCredito.Checked = False

        txtProveedor.Focus()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

    End Sub

    Private Sub ProcesarRecibo()

        If txtDiferencia.Text = txtApagar.Text Then
            detmsg = "DEBE INGRESAR UN IMPORTE DE PAGO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtEfectivo.Focus()
        Else

            comando = New MySqlCommand("DELETE FROM recibo ", conexion)
            dr = comando.ExecuteReader
            dr.Close()

            imppagado = Val(txtEfectivo.Text) + Val(txtTarjeta.Text) + Val(txtTransferencia.Text)
            saldopago = imppagado

            If dgvCtasCtes.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                    If Fila.Cells(15).Value = "X" Then

                        id = Fila.Cells(0).Value
                        fechajob = Fila.Cells(3).Value
                        ProcesarFecha()
                        fecvto = fechadb
                        resto = Fila.Cells(14).Value

                        restoant = saldopago
                        saldopago = saldopago - resto

                        If saldopago >= 0 Then
                            pagoact = resto
                            saldoact = 0
                        Else
                            pagoact = restoant
                            saldoact = resto - restoant
                        End If

                        comando = New MySqlCommand("INSERT INTO recibo VALUES(@id, @fecha, @detalle, @periodo, @impcbte, @pagoant, @saldoant, @pagoact, @saldoact, @obs)", conexion)

                        comando.Parameters.AddWithValue("@id", id)
                        comando.Parameters.AddWithValue("@fecha", fecvto)
                        comando.Parameters.AddWithValue("@detalle", Fila.Cells(5).Value + "-" + Fila.Cells(6).Value)
                        comando.Parameters.AddWithValue("@periodo", "")
                        comando.Parameters.AddWithValue("@impcbte", Fila.Cells(9).Value)
                        comando.Parameters.AddWithValue("@pagoant", Fila.Cells(13).Value)
                        comando.Parameters.AddWithValue("@saldoant", Fila.Cells(14).Value)
                        comando.Parameters.AddWithValue("@pagoact", pagoact)
                        comando.Parameters.AddWithValue("@saldoact", saldoact)
                        comando.Parameters.AddWithValue("@obs", Fila.Cells(12).Value)
                        comando.ExecuteNonQuery()
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub dgvCtasCtes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCtasCtes.CellDoubleClick

        If dgvCtasCtes.CurrentRow.Cells(15).Value = "" Then
            dgvCtasCtes.CurrentRow.Cells(15).Value = "X"
            dgvCtasCtes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
            txtApagar.Text = txtApagar.Text + dgvCtasCtes.CurrentRow.Cells(9).Value
            txtDiferencia.Text = txtDiferencia.Text + dgvCtasCtes.CurrentRow.Cells(9).Value
            contador = contador + 1
        Else
            dgvCtasCtes.CurrentRow.Cells(15).Value = ""
            dgvCtasCtes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            txtApagar.Text = txtApagar.Text - dgvCtasCtes.CurrentRow.Cells(9).Value
            txtDiferencia.Text = txtDiferencia.Text - dgvCtasCtes.CurrentRow.Cells(9).Value
            contador = contador - 1
        End If
        txtApagar.Text = Format(CDec(txtApagar.Text), "########0.00")
        txtDiferencia.Text = Format(CDec(txtDiferencia.Text), "########0.00")
        If contador = 9 Then
            detmsg = "Ya completó la cantidad de renglones...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtEfectivo.Focus()
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        If txtDiferencia.Text = txtApagar.Text Then
            detmsg = "DEBE INGRESAR UN IMPORTE DE PAGO...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtEfectivo.Focus()
        Else

            '*** LIMPIAMOS EL DataSource DEL INFORME ********
            ReportViewer1.LocalReport.DataSources.Clear()

            ImpLetras = Letras(letratotal)
            ProcesarRecibo()

            PonerCeros(txtProveedor.Text, 5)
            txtProveedor.Text = nroconceros

            comando.CommandText = "SELECT * FROM comprobantes WHERE TipoCpbte = 'CIP'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                comprobante = CStr(row("PrefijoCpbte"))
                comprobante = comprobante + 1
            End If

            PonerCeros(comprobante, 8)
            comprobante = nroconceros

        End If

        '******* Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '******* Establezcamos los parametros que enviaremos al reporte
        Dim parametros As ReportParameter() = New ReportParameter(13) {}

        fecha = CDate(Date.Now)
        parametros(0) = New ReportParameter("prmTipoCpbte", "COMPROBANTE INTERNO DE PAGO")
        parametros(1) = New ReportParameter("prmComprobante", comprobante)
        parametros(2) = New ReportParameter("prmTipoNro", "PROVEEDOR")
        parametros(3) = New ReportParameter("prmNro", txtProveedor.Text)
        parametros(4) = New ReportParameter("prmNombre", txtNombre.Text)
        parametros(5) = New ReportParameter("prmImpLetras", ImpLetras)
        parametros(6) = New ReportParameter("prmCuit", cuit)
        parametros(7) = New ReportParameter("prmEfectivo", txtEfectivo.Text)
        parametros(8) = New ReportParameter("prmTransferencia", txtTransferencia.Text)
        parametros(9) = New ReportParameter("prmTarjeta", txtTarjeta.Text)
        parametros(10) = New ReportParameter("prmTotal", imppagado)
        parametros(11) = New ReportParameter("prmObs", txtObs.Text)
        parametros(12) = New ReportParameter("prmUser", "")
        parametros(13) = New ReportParameter("prmFecha", txtFecha.Text)


        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsRecibo", reciboBindingSource))
        ReportViewer1.LocalReport.SetParameters(parametros)

        reciboTableAdapter.Fill(DbsointDataSet.recibo)

        ReciboAPDF()

        ReportViewer1.RefreshReport()

        '****** Clase del Proyecto
        Dim printer As ReportPrinter = New ReportPrinter()
        printer.Print(ReportViewer1.LocalReport)

        ActualizarTablas()

        Limpiar()

    End Sub

    Private Sub ReciboAPDF()

        Dim nombrePDF As String
        nombrePDF = "CIP" & "-" & comprobante & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ""

        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim newFile As New FileStream("\\DESKTOP\dbsoint\CIP\" & nombrePDF & ".pdf", FileMode.Create)
        archivo = nombrePDF & ".pdf"
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

    End Sub

    Private Sub ActualizarTablas()

        fechajob = txtFecha.Text
        ProcesarFecha()
        fecha = fechadb
        obs = ""

        '***ACTUALIZAR CTASCTES***

        comando.CommandText = "SELECT * FROM recibo ORDER BY FecVtoRec"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows

            If Val(CStr(row("SaldoActRec"))) = 0 Then
                estado = "PAGADA"
            Else
                estado = "PENDIENTE"
            End If

            id = CStr(row("id_Rec"))
            pagadofac = Val(CStr(row("PagoAntRec"))) + Val(CStr(row("PagoActRec")))

            comando = New MySqlCommand("UPDATE ctactepro SET PagadoCCPro = '" & pagadofac & "', EstadoCCPro = '" & estado & "'," _
                                            & " RestoCCPro = '" & CStr(row("SaldoActRec")) & "', ObsCCPro = '" & CStr(row("ObsRec")) + " - " + comprobante & "' " _
                                            & " WHERE NroCCPro = '" & txtProveedor.Text & "' AND id_CCPro = '" & id & "' ", conexion)
            comando.ExecuteNonQuery()

        Next

        '***ACTUALIZO CTACTE***
        importe = Val(pagado)
        comando = New MySqlCommand("INSERT INTO ctactepro VALUES(@id, @idctacte, @nrocta, @fechacta, @tipo, @prefijo, @subfijo, @detalle, @debe, @haber, @saldo, @estado, @obs, @pagado, @resto)", conexion)

        comando.Parameters.AddWithValue("@id", 0)
        comando.Parameters.AddWithValue("@idctacte", id)
        comando.Parameters.AddWithValue("@nrocta", txtProveedor.Text)
        comando.Parameters.AddWithValue("@fechacta", fecha)
        comando.Parameters.AddWithValue("@tipo", "CIP")
        comando.Parameters.AddWithValue("@prefijo", "0001")
        comando.Parameters.AddWithValue("@subfijo", comprobante)
        comando.Parameters.AddWithValue("@detalle", "CIP Nro.: " & comprobante)
        comando.Parameters.AddWithValue("@debe", imppagado)
        comando.Parameters.AddWithValue("@haber", 0)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@estado", "PAGO")
        comando.Parameters.AddWithValue("@obs", txtObs.Text)
        comando.Parameters.AddWithValue("@pagado", imppagado)
        comando.Parameters.AddWithValue("@resto", 0)
        comando.ExecuteNonQuery()

        '***GRABAR CAJA***
        'GrabarCaja()

        '***GRABO COMPROBANTE***
        comando = New MySqlCommand("UPDATE comprobantes SET PrefijoCpbte = '" & comprobante & "' WHERE TipoCpbte = 'CIP'", conexion)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub GrabarCaja()

        Dim efectivo, tarjeta, transferencia As Double
        efectivo = 0
        tarjeta = 0
        transferencia = 0

        If txtEfectivo.Text > "0" Then
            efectivo = Val(txtEfectivo.Text)
        End If
        If txtTransferencia.Text > "0" Then
            transferencia = Val(txtTransferencia.Text)
        End If
        If txtTarjeta.Text > "0" Then
            tarjeta = Val(txtTarjeta.Text)
        End If

        comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfe, @obs, @estado)", conexion)
        comando.Parameters.AddWithValue("@fecha", fecha)
        comando.Parameters.AddWithValue("@detalle", "CIP Nro.: " & comprobante & " - " & txtNombre.Text)
        comando.Parameters.AddWithValue("@debe", imppagado)
        comando.Parameters.AddWithValue("@haber", 0)
        comando.Parameters.AddWithValue("@saldo", 0)
        comando.Parameters.AddWithValue("@efectivo", efectivo)
        comando.Parameters.AddWithValue("@tarjeta", tarjeta)
        comando.Parameters.AddWithValue("@transfe", transferencia)
        comando.Parameters.AddWithValue("@obs", txtObs.Text)
        comando.Parameters.AddWithValue("@estado", "ABIERTA")
        comando.ExecuteNonQuery()

    End Sub

End Class