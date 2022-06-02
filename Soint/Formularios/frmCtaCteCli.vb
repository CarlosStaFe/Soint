Public Class frmCtaCteCli
    Dim debe, haber, saldo, saldoant As Decimal
    Dim detalle, estado, id, obs, fechadb, fechajob As String
    Dim pos1, pos2, longitud, cantidad As Integer
    Dim yyyy, mm, dd, ceros As String

    Private Sub frmCtaCteCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CtactecliTableAdapter.Fill(DbsointDataSet.ctactecli)
        dgvCtasctes.DataSource = Nothing
        txtCliente.Focus()

    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmEmp2 As New frmConsEmpleados
            AddOwnedForm(frmEmp2)
            frmEmp2.ShowDialog()
            senial = 0
            LeerCliente()
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerCliente()
        End If

    End Sub

    Private Sub txtCliente_MouseHover(sender As Object, e As EventArgs) Handles txtCliente.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Cliente."
        ToolTipMsg.SetToolTip(txtCliente, "Presione F1 para buscar el cliente deseado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerCliente()

        comando.CommandText = "SELECT * FROM clientes WHERE NroCli = " & txtCliente.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelyNomb.Text = CStr(row("NombreCli"))
        Else
            txtApelyNomb.Text = ""
        End If

        SaldoCtaCte()

    End Sub

    Private Sub SaldoCtaCte()

        comando.CommandText = "SELECT * FROM ctacteemp WHERE NroCCEmp = " & txtCliente.Text & " ORDER BY FechaCC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCtasctes.DataSource = dt

        dgvCtasctes.Sort(dgvCtasctes.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        debe = 0
        haber = 0
        saldo = 0
        saldoant = 0

        If dgvCtasctes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasctes.Rows
                If Not Fila Is Nothing Then
                    debe = Fila.Cells(9).Value
                    haber = Fila.Cells(10).Value
                    saldo = saldoant + debe - haber
                    Fila.Cells(11).Value = saldo
                    saldoant = saldo
                    detalle = Fila.Cells(6).Value
                    comando.CommandText = "UPDATE ctacteemp SET SaldoCCEmp = '" & saldo & "' WHERE DetalleCCCli = '" & detalle & "' AND NroCCEmp = '" & txtCliente.Text & "' "
                    comando.ExecuteNonQuery()
                    If Fila.Cells(12).Value = "PENDIENTE" Or Fila.Cells(12).Value = "LIQUIDADA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.Orange
                    End If
                End If
            Next
        Else
            detmsg = "No posee movimientos en la Cuenta Corriente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        txtSaldo.Text = saldo
        txtSaldo.Text = Format(CDec(txtSaldo.Text), "C")
        dgvCtasctes.Refresh()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        For i As Integer = 0 To dgvCtasctes.Rows.Count - 1

            id = dgvCtasctes.Rows(i).Cells(0).Value()
            debe = dgvCtasctes.Rows(i).Cells(8).Value()
            haber = dgvCtasctes.Rows(i).Cells(10).Value()
            saldo = dgvCtasctes.Rows(i).Cells(11).Value()
            estado = dgvCtasctes.Rows(i).Cells(12).Value()
            If estado = "PENDIENTE" Then
                'fecpago = "1900-01-01"
            Else
                fechajob = dgvCtasctes.Rows(i).Cells(2).Value()
                ProcesarFecha()
            End If
            obs = dgvCtasctes.Rows(i).Cells(13).Value()

            comando.CommandText = "UPDATE ctacteemp SET DebeCCEmp = '" & debe & "', HaberCCEmp = '" & haber & "', SaldoCCEmp = '" & saldo & "', EstadoCCEmp = '" & estado & "'," _
                                  & " ObsCC = '" & obs & "'" _
                                  & " WHERE id_CCEmp = '" & id & "' AND NroCC = '" & txtCliente.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtCliente.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtCliente.Focus()

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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtCliente.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtCliente.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

End Class