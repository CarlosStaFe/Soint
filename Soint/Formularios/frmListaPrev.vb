Imports Microsoft.Reporting.WinForms

Public Class frmListaPrev
    Dim nombre, titular, numero As String

    Private Sub frmListaPrev_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        preventivoTableAdapter.Fill(dbsointDataSet.preventivo)
        txtObra.Focus()

    End Sub

    Private Sub txtObra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObra.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 4
            Dim frmObra1 As New frmConsObra
            AddOwnedForm(frmObra1)
            frmObra1.ShowDialog()
            senial = 0
            LeerObra()
            btnImprimir.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            LeerObra()
            If senial = 1 Then
                txtObra.Focus()
                senial = 0
            Else
                btnImprimir.Focus()
            End If
        End If

    End Sub

    Private Sub txtObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObra.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub LeerObra()

        comando.CommandText = "SELECT * FROM obras WHERE NroObra = '" & txtObra.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtObra.Text = CStr(row("NroObra"))
            txtNombre.Text = CStr(row("NombreObra"))
            titular = CStr(row("TitularObra"))
            numero = txtObra.Text
            nombre = txtNombre.Text
            txtObra.Focus()
        Else
            detmsg = "Obra no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        comando = New MySqlCommand("DELETE FROM preventivo ", conexion)
        dr = comando.ExecuteReader
        dr.Close()

        CargarValores()

        comando.CommandText = "SELECT nombregrupo, nombrerubro, nombresrub, DetalleDetCpra, TotalDetCpra FROM detallecpra " _
                               & " INNER JOIN subrubros On idSRubDetCpra = id_srub  " _
                               & " INNER JOIN rubros    On fk_srub       = id_rubro " _
                               & " INNER JOIN grupos    On fk_rubro      = id_grupo " _
                               & " WHERE ObraDetCpra = '" & txtObra.Text & "' "

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows
                comando = New MySqlCommand("INSERT INTO preventivo VALUES(@id, @obra, @grupo, @rubro, @subrubro, @detalle, @importe)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@obra", txtObra.Text)
                comando.Parameters.AddWithValue("@grupo", CStr(row("NombreGrupo")))
                comando.Parameters.AddWithValue("@rubro", CStr(row("NombreRubro")))
                comando.Parameters.AddWithValue("@subrubro", CStr(row("NombreSRub")))
                comando.Parameters.AddWithValue("@detalle", CStr(row("DetalleDetCpra")))
                comando.Parameters.AddWithValue("@importe", (CStr(row("TotalDetCpra")) * -1))
                comando.ExecuteNonQuery()
            Next

        Else
            detmsg = "No tiene movimientos pendientes...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        '******* Establezcamos los parametros que enviaremos al reporte
        Dim parametros As ReportParameter() = New ReportParameter(0) {}

        parametros(0) = New ReportParameter("prmDetalle", " Nro: " & numero & " * Titular: " & titular & " * Nombre: " & nombre & " *")
        ReportViewer1.LocalReport.SetParameters(parametros)
        preventivoTableAdapter.Fill(dbsointDataSet.preventivo)

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub CargarValores()

        comando.CommandText = "SELECT * FROM gruposobras WHERE ObraGO = '" & txtObra.Text & "' "

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows
                comando = New MySqlCommand("INSERT INTO preventivo VALUES(@id, @obra, @grupo, @rubro, @subrubro, @detalle, @importe)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@obra", txtObra.Text)
                comando.Parameters.AddWithValue("@grupo", CStr(row("GrupoGO")))
                comando.Parameters.AddWithValue("@rubro", "")
                comando.Parameters.AddWithValue("@subrubro", "")
                comando.Parameters.AddWithValue("@detalle", "")
                comando.Parameters.AddWithValue("@importe", CStr(row("ImporteGO")))
                comando.ExecuteNonQuery()
            Next

        End If

    End Sub
End Class