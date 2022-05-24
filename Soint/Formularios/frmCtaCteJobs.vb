Public Class frmCtaCteJobs
    Dim debe, haber, saldo, saldoant As Decimal
    Dim detalle, estado, id, obs, fechadb, fechajob As String
    Dim pos1, pos2, longitud, cantidad As Integer
    Dim yyyy, mm, dd, ceros As String

    Private Sub frmCtaCteJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CtacteempTableAdapter.Fill(DbsointDataSet.ctacteemp)
        dgvCtasctes.DataSource = Nothing
        txtEmpleado.Focus()

    End Sub

    Private Sub txtEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpleado.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmEmp2 As New frmConsEmpleados
            AddOwnedForm(frmEmp2)
            frmEmp2.ShowDialog()
            senial = 0
            LeerEmpleado()
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerEmpleado()
        End If

    End Sub

    Private Sub txtEmpleado_MouseHover(sender As Object, e As EventArgs) Handles txtEmpleado.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Empleado."
        ToolTipMsg.SetToolTip(txtEmpleado, "Presione F1 para buscar el empleado deseado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerEmpleado()

        comando.CommandText = "SELECT * FROM empleados WHERE NroEmp = " & txtEmpleado.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelyNomb.Text = CStr(row("NombreEmp"))
        Else
            txtApelyNomb.Text = ""
        End If

        SaldoCtaCte()

    End Sub

    Private Sub SaldoCtaCte()

        comando.CommandText = "SELECT * FROM ctacteemp WHERE NroCCEmp = " & txtEmpleado.Text & " ORDER BY FechaCC"
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
                    comando.CommandText = "UPDATE ctacteemp SET SaldoCCEmp = '" & saldo & "' WHERE DetalleCCEmp = '" & detalle & "' AND NroCCEmp = '" & txtEmpleado.Text & "' "
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
                                  & " WHERE id_CCEmp = '" & id & "' AND NroCC = '" & txtEmpleado.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtEmpleado.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtEmpleado.Focus()

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

        txtEmpleado.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtEmpleado.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub ProcesarFecha()

        pos1 = InStr(1, fechajob, "/")
        pos2 = InStr(pos1 + 1, fechajob, "/")

        dd = Mid(fechajob, 1, pos1 - 1)
        mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))
        yyyy = Mid(fechajob, pos2 + 1, 4)

        ceros = ""
        longitud = Len(dd)
        If longitud < 2 Then
            cantidad = 2 - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            dd = ceros & dd
        End If

        ceros = ""
        longitud = Len(mm)
        If longitud < 2 Then
            cantidad = 2 - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            mm = ceros & mm
        End If

        If yyyy < 100 Then
            yyyy = "20" + yyyy
        End If

        fechajob = dd & "/" & mm & "/" & yyyy
        fechadb = yyyy & "/" & mm & "/" & dd

    End Sub

End Class