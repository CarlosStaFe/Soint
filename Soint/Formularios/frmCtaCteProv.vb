Public Class frmCtaCteProv
    Dim debe, haber, saldo, saldoant As Decimal
    Dim detalle, estado, id, obs, fechadb, fechajob As String
    Dim pos1, pos2, longitud, cantidad As Integer
    Dim yyyy, mm, dd, ceros As String

    Private Sub frmCtaCteProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CtacteproTableAdapter.Fill(DbsointDataSet.ctactepro)
        dgvCtasctes.DataSource = Nothing
        txtProveedor.Focus()

    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmProv1 As New frmConsProveedores
            AddOwnedForm(frmProv1)
            frmProv1.ShowDialog()
            senial = 0
            LeerProveedor()
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerProveedor()
        End If

    End Sub

    Private Sub txtProveedor_MouseHover(sender As Object, e As EventArgs) Handles txtProveedor.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Proveedor."
        ToolTipMsg.SetToolTip(txtProveedor, "Presione F1 para buscar el proveedor deseado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerProveedor()

        comando.CommandText = "SELECT * FROM proveedores WHERE NroProv = " & txtProveedor.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtTitular.Text = CStr(row("RazonSocialProv"))
        Else
            txtTitular.Text = ""
        End If

        SaldoCtaCte()

    End Sub

    Private Sub SaldoCtaCte()

        comando.CommandText = "SELECT * FROM ctactepro WHERE NroCCPro = " & txtProveedor.Text & " ORDER BY FechaCCPro"
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
                    debe = Fila.Cells(7).Value
                    haber = Fila.Cells(8).Value
                    saldo = saldoant - debe + haber
                    Fila.Cells(9).Value = saldo
                    saldoant = saldo
                    'detalle = Fila.Cells(6).Value
                    comando.CommandText = "UPDATE ctactepro SET SaldoCCPro = '" & saldo & "' WHERE DetalleCCPro = '" & detalle & "' AND NroCCPro = '" & txtProveedor.Text & "' "
                    comando.ExecuteNonQuery()
                    If Fila.Cells(10).Value = "PENDIENTE" Then
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
                                  & " WHERE id_CCEmp = '" & id & "' AND NroCC = '" & txtProveedor.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtProveedor.Text = ""
        txtTitular.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtProveedor.Focus()

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
        txtProveedor.Text = ""
        txtTitular.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes.DataSource = Nothing
        txtProveedor.Focus()

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