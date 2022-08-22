Imports Microsoft.Reporting.WinForms

Public Class frmListaObras
    Dim flag, detalle As String

    Private Sub frmListaObras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()

        obrasTableAdapter.Fill(dbsointDataSet.obras)

        CargarCombo()

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT EstadoObra FROM obras ORDER BY EstadoObra", conexion)
        dr = comando.ExecuteReader

        cmbEstado.Items.Add("TODOS")

        If dr.HasRows Then
            While dr.Read
                cmbEstado.Items.Add(dr(0).ToString)
            End While
        End If

        dr.Close()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

    End Sub

    Private Sub Limpiar()

        cmbEstado.SelectedIndex = 0
        detalle = ""
        btnSalir.Visible = True
        btnLimpiar.Visible = False
        btnImprimir.Visible = False

        cmbEstado.Focus()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        btnLimpiar.Visible = True
        btnImprimir.Visible = False

        flag = 0
        detalle = "Listado de Obras - "

        comando.CommandText = "SELECT * FROM obras "

        '********** ESTADOS **********
        If cmbEstado.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Estado: TODOS * "
        Else
            comando.CommandText = comando.CommandText & " WHERE EstadoObra = '" & cmbEstado.Text & "' "
            detalle = detalle & "Estado: " & cmbEstado.Text & " * "
        End If

        '********** CHEQUEO EL ORDEN DEL LISTADO **********
        If rbtnCliente.Checked Then
            detalle = detalle & "ORDENADO POR CLIENTE * "
            comando.CommandText = comando.CommandText & "ORDER BY titularObra "
        End If

        If rbtnObra.Checked Then
            detalle = detalle & "ORDENADO POR OBRA * "
            comando.CommandText = comando.CommandText & "ORDER BY NroObra "
        End If


        '******* Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()
        '******* Establezcamos los parametros que enviaremos al reporte
        Dim parametros As ReportParameter() = New ReportParameter(1) {}

        parametros(0) = New ReportParameter("prmDetalle", detalle)
        parametros(1) = New ReportParameter("prmUser", "")


        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsObras", obrasBindingSource))
        ReportViewer1.LocalReport.SetParameters(parametros)

        obrasTableAdapter.Fill(dbsointDataSet.obras)

        ReportViewer1.RefreshReport()

    End Sub

End Class