Module Variables
    '***Variables para usar en el sistema
    Public conexion As New MySqlConnection
    Public comando As New MySqlCommand
    Public CmdBuilder As MySqlCommandBuilder
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public TextoConn As String
    Public estado As String
    Public consulta As String
    Public fila As String
    Public detmsg As String
    Public tipomsg As String
    Public btnmsg As Integer
    Public datos As Byte
    Public senial As String
    Public fecha As String
    '***Variables para controlar niveles y usuarios
    Public nivel As Integer
    Public usuario As String
    '***Variables para procesar fecha
    Public fechajob, fechadb, dd, mm, yyyy, ceros As String
    Public pos1, pos2, longitud, cantidad As Integer
    '***Variables para procesar ceros en número
    Public numero, nroconceros As String
    Public largo As Integer
    '***Variables para procesar los códigos postales
    Public CodPostal, Localidad, Provincia As String
    Public idCodigo As Integer

    'Public Apunt As Integer = FreeFile()

    Public Sub ConectarMySql()

        TextoConn = My.Computer.FileSystem.ReadAllText("soint.txt")
        'conexion.ConnectionString = TextoConn

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.ConnectionString = TextoConn
                conexion.Open()
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                'MsgBox("Conexión correcta", MsgBoxStyle.Critical, "Información")
            Else
                conexion.Close()
                conexion.ConnectionString = TextoConn
                conexion.Open()
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                'MsgBox("Conexión correcta", MsgBoxStyle.Critical, "Información")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            MsgBox("Conexión errónea", MsgBoxStyle.Critical, "Atención")
        End Try

    End Sub

    Public Sub DesconectarMySql()

        conexion.Close()

    End Sub

    Public Sub SoloNumeros(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If

    End Sub

    Public Function ControlFecha(ByVal fecha As String)

        senial = 0
        If Not IsDate(fecha) Then
            fecha = ""
            detmsg = "Fecha errónea...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        Else
            senial = 0
        End If

        Return senial

    End Function

    Public Function ProcesarFecha()

        pos1 = InStr(1, fechajob, "/")
        pos2 = InStr(pos1 + 1, fechajob, "/")

        If pos1 < 5 Then
            dd = Mid(fechajob, 1, pos1 - 1)
        Else
            yyyy = Mid(fechajob, 1, pos1 - 1)
        End If

        mm = Mid(fechajob, pos1 + 1, ((pos2 - 1) - pos1))

        If pos2 < 8 Then
            yyyy = Mid(fechajob, pos2 + 1, 4)
        Else
            dd = Mid(fechajob, pos2 + 1, 4)
        End If

        PonerCeros(dd, 2)
        dd = nroconceros

        PonerCeros(mm, 2)
        mm = nroconceros

        If yyyy < 100 Then
            yyyy = "20" + yyyy
        End If

        fechajob = dd & "/" & mm & "/" & yyyy
        fechadb = yyyy & "/" & mm & "/" & dd

    End Function

    Public Function Letras(ByVal numero As String) As String

        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "," Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec & " - - - - - - - - -"
            Else
                Letras = palabras & " - - - - - - - - -"
            End If
        Else
            Letras = ""
        End If

    End Function

    Public Function PonerCeros(ByVal numero As String, ByVal largo As Integer) As String

        ceros = ""
        nroconceros = numero

        longitud = Len(numero)
        If longitud < largo Then
            cantidad = largo - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            nroconceros = ceros & numero
        End If

        Return nroconceros

    End Function

    Public Sub LeerCodigoPostal()

        Try
            comando.CommandText = "SELECT * FROM codpostal WHERE id_CodPos = '" & idCodigo & "' OR NroCodPos = '" & CodPostal & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                Localidad = CStr(row("LocalCodPos"))
                Provincia = CStr(row("ProvCodPos"))
                CodPostal = CStr(row("NroCodPos"))
                idCodigo = Val(CStr(row("id_CodPos")))
            Else
                Localidad = ""
                Provincia = ""
            End If

        Catch ex As Exception
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Public Function ValorPesos(ByVal numero As String) As String

        Dim entero, dec, flag As String
        flag = "N"

        For y = 1 To Len(numero)
            If Mid(numero, y, 1) <> "$" Then
                If Mid(numero, y, 1) = "," Or Mid(numero, y, 1) = "." Then
                    flag = "S"
                Else
                    If flag = "N" Then
                        entero = entero + Mid(numero, y, 1)
                    Else
                        dec = dec + Mid(numero, y, 1)
                    End If
                End If
            End If
        Next y

        If Len(dec) = 1 Then
            dec = dec & "0"
        End If

        numero = entero + "." + dec

        Return numero

    End Function


End Module
