Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports System.Threading
Imports System.IO.Ports
Imports System.Speech.Recognition

Public Class IUIngresoEventosDirecto
    Dim unDataSet As DataSet
    Private EventoLineaRow As DataRow
    Dim dtEventosLineas As DataTable = unafachada.TodosLasListasEventosLineas()
    Dim dtProductores As DataTable = unafachada.TodosLosProductoresTable
    Dim dtAnimales As DataTable = unafachada.TodosLosAnimales()
    Dim dtParametros As DataTable = unafachada.TodosLosParametrosDataTable
    'Reconocimieto de voz
    Dim reconocedorEventos As SpeechRecognitionEngine
    Public Shared numCaravana As String
    Dim dtListaEventosLineas As DataTable
    Dim NombreArchivo As String
    Dim listaTxtRegistrosTemporal As List(Of String)
    Dim ListaDiccionarioEventos As String()
    Dim subMenuChip As DataSet
    Dim UnAnimal As DataRow
    Dim idActividad As Integer
    Dim idHistorial As Integer
    Dim banderadeCierre As Boolean


    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        eventosAnteriores(Me.txtDispositivo.Text)

    End Sub

    Public Sub eventosAnteriores(ByVal pAnimal As String)
        Dim ini As String = Me.DtpFechaDesde.Value.Year & "/" & Me.DtpFechaDesde.Value.Month & "/" & Me.DtpFechaDesde.Value.Day
        Dim fin As String = Me.dtpFechaHasta.Value.Year & "/" & Me.dtpFechaHasta.Value.Month & "/" & Me.dtpFechaHasta.Value.Day
        LabelX13.Text = "CONSULTA INDIVIDUAL DESDE: " & ini & " AL: " & fin
        Dim cadena As String = "SELECT operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo AS Dispositivo, Count(operacionesLineas.ope_lin_id) AS Unidad, operacionesLineas.ope_lin_eventoLin AS Evento, animal.ani_potrero AS Ubicacion, animal.ani_fechaNac AS Nacio, animal.ani_raza AS Raza, animal.ani_cruza AS Cruza, animal.ani_sexo AS Sexo FROM operacionesLineas INNER JOIN animal ON operacionesLineas.ope_lin_dispositivo = animal.ani_dispositivo WHERE (((operacionesLineas.ope_lin_fecha)>=" & "#" & ini & "#" & " And (operacionesLineas.ope_lin_fecha)<=" & "#" & fin & "#" & ") AND ((operacionesLineas.ope_lin_dispositivo)=" & "'" & Me.txtDispositivo.Text & "'" & "))GROUP BY operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo, operacionesLineas.ope_lin_eventoLin, animal.ani_potrero, animal.ani_fechaNac, animal.ani_raza, animal.ani_cruza, animal.ani_sexo"
        unDataSet = unafachada.EjecutarConsultaGENERICADataSet(cadena)
        Try
            dtgv.DataSource = unDataSet.Tables(0)
        Catch ex As Exception
            dtgv.DataSource = Nothing
        End Try
    End Sub


    Public Sub crearColumnas()
        ListaDispositivos.FullRowSelect = True
        ListaDispositivos.MultiSelect = False
        With ListaDispositivos
            .Columns.Clear()
            .Columns.Add("Evento", 80, HorizontalAlignment.Left)
            .Columns.Add("Dispositivo", 140, HorizontalAlignment.Left)
            .Columns.Add("Sexo", 70, HorizontalAlignment.Left)
            .Columns.Add("Raza", 60, HorizontalAlignment.Left)
            .Columns.Add("Edad", 60, HorizontalAlignment.Left)
            .Columns.Add("Id", 40, HorizontalAlignment.Left)
            .Columns.Add("Sub-Evento", 110, HorizontalAlignment.Left)
            .Columns.Add("Registrado", 70, HorizontalAlignment.Left)
            .Columns.Add("Id", 40, HorizontalAlignment.Left)
            .Columns.Add("Tipo ", 110, HorizontalAlignment.Left)
            .Columns.Add("Fecha Lectura", 140, HorizontalAlignment.Left)

            'If TypeOf Datos(0) Is IPrintUtilListView Then
            '    Datos(0).ToColumnHeaders(.Columns)
            'Else
            '    .Columns.Add("Nombre", 120, HorizontalAlignment.Left)
            'End If

            '.View = View.Details
            '.FullRowSelect = False
            '.GridLines = True
            '.HideSelection = False
        End With

    End Sub

    Private Sub IUIngresoEventosDirecto_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.SerialPort1.Dispose()
        Me.SerialPort1.Close()

    End Sub


    Private Sub IUIngresoEventosDirecto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim bandera As Boolean = False
        Me.DtpFechaDesde.Value = Today
        Me.dtpFechaHasta.Value = Today
        Me.dtpFechaRef.Value = Today
        Me.Timer1.Enabled = False
        Me.Timer2.Enabled = False
        crearColumnas()

        'COMBO EVENTOS LINEAS
        dtListaEventosLineas = unafachada.TodosLasListasEventosLineas()
        CargarComboDesdeDataTable(Me.cboEventos, dtListaEventosLineas, "eve_lin_nombre")

        Me.cboOpciones.Items.Clear()
        Me.cboOpciones.Items.Add("")
        Me.cboOpciones.Items.Add("Cambiar Actividad")
        Me.cboOpciones.Items.Add("Finalizar Actividad")
        Me.cboOpciones.SelectedIndex = 0
        '** HISTORIAL **
        'Dim unaFilaHistorial As DataRow
        Try
            Dim unaFilaHistorial As DataRow = unafachada.BuscarHistorial(idActividad, 0, 0)
            NombreArchivo = unaFilaHistorial("His_archivo")
            idHistorial = unaFilaHistorial("His_id")
        Catch ex As Exception
            NombreArchivo = ""
        End Try


        Dim existe As Boolean = File.Exists(Environment.CurrentDirectory & "\LecturasTiempoReal\" & NombreArchivo)
        If existe Then
            listaTxtRegistrosTemporal = unafachada.LeerTxtEventos(Environment.CurrentDirectory & "\LecturasTiempoReal\" & NombreArchivo)

            Using MyReader As New Microsoft.VisualBasic.
                       FileIO.TextFieldParser(
                         Environment.CurrentDirectory & "\LecturasTiempoReal\" & NombreArchivo)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(";")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        'Fila Actual
                        currentRow = MyReader.ReadFields()
                        If currentRow(0).Contains("858") Then
                            Dim pDispositivo As String = currentRow(0)
                            Dim pSexo As String = currentRow(1)
                            Dim pRaza As String = currentRow(2)
                            Dim pEdad As String = currentRow(3)
                            Dim pIdEvento As String = currentRow(4)
                            Dim grupoEvento As String = currentRow(5)
                            Dim pOrejano As String = currentRow(6)
                            Dim idEvento As String = currentRow(7)
                            Dim evento As String = currentRow(8)
                            Dim fechaLectura As String = currentRow(9)
                            Dim unaFilaParametroBuscarAnimales As DataRow = BuscarParametros("MostrarAnimales")
                            Dim MostrarAnimales As Boolean = False
                            If unaFilaParametroBuscarAnimales("ValorParametro") = 1 Then
                                MostrarAnimales = True
                            End If

                            Try
                                AgregarUnaFila(pDispositivo, pSexo, pRaza, pEdad, pIdEvento, grupoEvento, pOrejano, 1, idEvento, evento, MostrarAnimales, fechaLectura, False)
                            Catch ex As Exception

                            End Try

                        End If
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                        "is not valid and will be skipped.")
                    End Try
                End While
            End Using


        Else
            listaTxtRegistrosTemporal = New List(Of String)
            bandera = True
        End If
        cargarMenu(idActividad, bandera)

        If unafachada.ActivarSonido = True Then
            'VOZ
            Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            textoaVoz.Start("Usted ingreso en actividad: " & Me.lbTitulo.Text)
            Thread.Sleep(500)
            Dim Totales As String = TotalxGrupos()

            If Totales <> "Se encuentra vacio" Then
                Dim textoaVoz2 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                textoaVoz2.Start("Resumen de lo ya guardado")
                Thread.Sleep(500)
            End If

            Dim textoaVoz3 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            textoaVoz3.Start(Totales)
            Thread.Sleep(500)
        End If

        ActivarBaston()
    End Sub



    Public Sub cargarMenu(ByVal pIdActividad As Integer, ByVal pNuevo As Boolean)
        Dim guardarCabezal As Boolean = False
        subMenuChip = unafachada.BuscarSubMenu(pIdActividad)
        Me.lbOpciones.Text = "Opciones: "
        If Not subMenuChip Is Nothing Then
            If subMenuChip.Tables(0).Rows.Count > 0 Then
                Dim nombreActividad As String = subMenuChip.Tables(0).Rows(0)("menu_sub_Actividad")
                For Each rw As DataRow In subMenuChip.Tables(0).Rows
                    Me.lbOpciones.Text += rw("menu_sub_Opcion") & ": " & rw("menu_sub_dispositivo") & "  |  "
                Next rw

                If pNuevo = True Then
                    Me.listaTxtRegistrosTemporal.Add("Titulo" & ";" & lbTitulo.Text & ";" & Now & ";" & pIdActividad)
                    Dim cntceros As Integer = 4 - pIdActividad.ToString.Length
                    Dim ceros As String = StrDup(cntceros, "0")
                    Dim NumeroActividad As String = ceros & pIdActividad
                    Dim TraerUltimoId As Integer
                    If NombreArchivo.Length = 0 Then
                        TraerUltimoId = unafachada.TraerUltimoId("historial", "His_id")
                        NombreArchivo = NumeroActividad & "-" & lbTitulo.Text & "- " & Today.Day & "-" & Today.Month & "-" & Today.Year & " id" & TraerUltimoId & ".txt"
                        idHistorial = TraerUltimoId
                        guardarCabezal = True
                    End If

                    If guardarCabezal Then
                        Dim cadena As String = "INSERT INTO historial (His_id,His_id_actividad,His_nombre,His_fecha,His_archivo,His_cerrado,His_eliminado) VALUES (" & TraerUltimoId & "," & pIdActividad & "," & "'" & nombreActividad & "'" & "," & "'" & Now & "'" & "," & "'" & NombreArchivo & "'" & "," & 0 & "," & 0 & ")"
                        unafachada.EjecutarConsultaGENERICA(cadena)
                    End If
                End If
                'Estableer Titulo 
                Me.lbTitulo.Text = idHistorial & "- " & nombreActividad
            Else
                Me.lbTitulo.Text = "salga de esta ventana e ingrese chip con opciones"
                Dim textoaVoz2 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                textoaVoz2.Start("Ingrese chip con opciones para este evento")


            End If

        End If
    End Sub

    Public Sub cargarDiccionario(ByVal pIdActividad As Integer)
        subMenuChip = unafachada.BuscarSubMenu(pIdActividad)
        If subMenuChip.Tables(0).Rows.Count > 0 Then
            Dim Diccionario(subMenuChip.Tables(0).Rows.Count) As String
            Dim i As Integer = 0
            For Each rw As DataRow In subMenuChip.Tables(0).Rows
                Diccionario(i) = rw("menu_sub_fonetica")
                i += 1
            Next rw
            ListaDiccionarioEventos = Diccionario
        End If

    End Sub

    Public Function BuscarOpcionBoton(ByVal pChip As String) As DataRow
        If subMenuChip.Tables(0).Rows.Count > 0 Then
            If pChip.Length > 0 Then
                If unafachada.tipoBaston <> 1 Then
                    pChip = pChip.Substring(0, pChip.Length - 1)
                End If

                Try
                    For Each rw As DataRow In subMenuChip.Tables(0).Rows
                        If rw("menu_sub_dispositivo") = pChip Then
                            Return rw
                        End If
                    Next rw
                Catch ex As Exception
                    Return Nothing
                End Try
            End If
        End If
    End Function


    Public Function CargarComboDesdeDataTable(ByVal pCombo As ComboBox, ByVal pDataTable As DataTable, ByVal pColumna As String) As Boolean
        pCombo.Items.Clear()
        pCombo.Items.Add("")
        If pDataTable.Rows.Count > 0 Then
            For Each rw As DataRow In pDataTable.Rows
                pCombo.Items.Add(rw(pColumna))
            Next rw
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click
        AFunciones.ExportarExcelListViewyAbrirlo(Me.ListaDispositivos, "Eventos " & Me.dtpFechaRef.Value)
    End Sub

    Private Sub txtDispositivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDispositivo.TextChanged
        If Timer3.Enabled = False Then
            Dim bandera As Boolean = False
            Dim OpcionBuscarAnimal As Boolean = False
            Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            Dim BuscarAnimal As New Thread(AddressOf BuscarAnimalHilo) 'Crear el hilo 1

            If Me.txtDispositivo.Text.Length > 0 Then
                Select Case Me.txtDispositivo.Text

                    Case unafachada.chipEnter
                        'CHIP ENTER
                        If Me.cboOpciones.SelectedIndex <> 0 Then

                            Select Case Me.cboOpciones.SelectedIndex
                                Case 1
                                    textoaVoz.Start("Seleccione una actividad")
                                    Me.SerialPort1.Dispose()
                                    Me.SerialPort1.Close()
                                    Me.Dispose()
                                    Me.Close()
                                    Dim unIUPreviaEventos As New IUPreviaEventos
                                    unIUPreviaEventos.Show()
                                    GC.Collect()
                                Case 2
                                    If unafachada.ActivarSonido = True Then
                                        'VOZ
                                        Dim Totales As String = TotalxGrupos()
                                        If Totales <> "Se encuentra vacio" Then
                                            Dim textoaVoz2 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                                            textoaVoz2.Start("Resumen de lo ingresado")
                                            Thread.Sleep(500)
                                        End If

                                        Dim textoaVoz3 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                                        textoaVoz3.Start(Totales)

                                        Dim tiempoDormir As Integer = (Totales.Length * 800) / 46
                                        Thread.Sleep(tiempoDormir)
                                        Dim textoaVoz4 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                                        textoaVoz4.Start("Confirma cerrar lote ? " & Me.lbTitulo.Text)
                                        Thread.Sleep(800)
                                        Timer3.Interval = 8000
                                        Timer3.Enabled = True
                                    End If

                                    'textoaVoz.Start("Lote Cerrado")
                                    'cerrar()

                                Case Else

                            End Select

                        End If

                    Case unafachada.chipCambiar
                        'CHIP CAMBIAR OPCIONES COMBO
                        Try
                            Me.cboOpciones.SelectedIndex += 1
                        Catch ex As Exception
                            Me.cboOpciones.SelectedIndex = 1
                        End Try


                    Case unafachada.chipDiccionario
                        'CHIP ACTIVAR DICCIONARIO
                        Dim diccionario() As String = unafachada.LeerTxtDiccionario(Environment.CurrentDirectory & "\Diccionario\Diccionario.txt")
                        ActivarEventos(diccionario)
                    Case Else

                        'BUSCAR SI ES UN CHIP Q PERTENCE A UN EVENTO
                        Dim FilaMenu As DataRow = BuscarOpcionBoton(txtDispositivo.Text)
                        If Not FilaMenu Is Nothing Then
                            bandera = True
                            Dim unEventoFila As DataRow = BuscarEventosLineas(FilaMenu("menu_sub_fonetica"))
                            If Not unEventoFila Is Nothing Then
                                Me.cboEventos.SelectedItem = unEventoFila.Item("eve_lin_nombre")
                                Me.txtIdEvento.Text = unEventoFila("eve_lin_id").ToString
                                'VOZ EVENTO
                                textoaVoz.Start(Me.cboEventos.SelectedItem)
                            End If

                        Else
                            If Me.txtDispositivo.Text.Length = 15 Then
                                Dim unaFilaParametroBuscarAnimales As DataRow = BuscarParametros("MostrarAnimales")
                                If unaFilaParametroBuscarAnimales("ValorParametro") = 1 Then
                                    OpcionBuscarAnimal = True
                                    BuscarAnimal.Start(txtDispositivo.Text)
                                    Thread.Sleep(500)
                                    'Buscar Eventos Anteriores 
                                    Dim unaFilaParametroTareas As DataRow = BuscarParametros("MostrarTareas")
                                    If unaFilaParametroTareas("ValorParametro") = 1 Then
                                        BuscarEventos()
                                    End If
                                End If
                            End If
                        End If

                        If Me.txtIdEvento.Text > 0 And bandera = False Then
                            If Me.txtDispositivo.Text.Length = 15 Then
                                Dim fechaLectura As String = Format(Now, "General date")
                                AgregarUnaFila(Me.txtDispositivo.Text, Me.txtSexo.Text, Me.txtRaza.Text, Me.txtEdad.Text, Me.txtIdEvento.Text, Me.cboEventos.SelectedItem, Me.txtOrejano.Text, 0, Me.txtIdEventoPrincipal.Text, Me.txtEvento.Text, OpcionBuscarAnimal, fechaLectura, True)
                            End If

                        Else
                            Try
                                textoaVoz.Start("Seleccione lote")
                                Thread.Sleep(500)
                            Catch ex As Exception

                            End Try


                        End If

                End Select
            End If
            Me.txtDispositivo.Text = ""
        End If
    End Sub


    Public Sub GuardarOperacion()
        Dim banderaCabezal As Boolean = False
        Dim banderaDetalle As Boolean = False
        Dim GuardarMovimientos As Boolean
        Dim ActualizarAnimales As Boolean
        Dim guardarCabezal As Boolean = False
        Dim DetFecha As String
        Dim fecha As Date = Today
        DetFecha = fecha.ToString("dd/MM/yyyy")
        If unafachada.TipoBaseDatos = "MySQL" Then
            DetFecha = fecha.ToString("yyyy/MM/dd")
        End If

        'If pGuardarComo = True Then
        '    titulo = unafachada.TraeridOrdenProduccion & "- " & Me.dtpFecha.Value.ToString("dd/MM/yyyy") & " - "
        'End If

        'If Me.ListaDispositivos.Items.Count > 0 Then

        '    Dim i As Integer
        '    While i < ListaDispositivos.Items.Count
        '        Dim dispositivo As String = ListaDispositivos.Items(1).Text
        '        Dim sexo As String = ListaDispositivos.Items(2).Text
        '        Dim raza As String = ListaDispositivos.Items(3).Text
        '        Dim edad As String = ListaDispositivos.Items(4).Text
        '        Dim idEvento As String = ListaDispositivos.Items(5).Text
        '        Dim evento As String = ListaDispositivos.Items(6).Text
        '        Dim orejano As String = ListaDispositivos.Items(7).Text
        '        Dim UltimoIdoperacionesLineas As Integer = unafachada.TraerUltimoId("operacionesLineas", "ope_lin_idCabezal")
        '        'CON NUMERO ENVIADO 
        '        'Dim cadenaConexion As String = "INSERT INTO operacionesLineas (ope_lin_id,ope_lin_idCabezal,ope_lin_fecha,ope_lin_lote, ope_lin_num, ope_lin_idevento,ope_lin_evento,ope_lin_ideventoLin,ope_lin_eventoLin,ope_lin_dispositivo,ope_lin_uni,ope_lin_cnt,ope_lin_potreroIdOri,ope_lin_potreroOri,ope_lin_potreroIdDes,ope_lin_potreroDes,ope_lin_dicoseCampoOri,ope_lin_dicoseCampoDes) VALUES (" & "1" & "," & Me.txtCodigo.Text & "," & "'" & DetFecha & "'" & "," & DetLote & "," & DetOrd & "," & DetIdEvento & "," & "'" & DetEvento & "'" & "," & DetIdEventoLin & "," & "'" & DetEventoLin & "'" & "," & "'" & DetDispositivo & "'" & "," & "'" & Detuni & "'" & "," & Detcnt & "," & DetPotreroIdOri & "," & "'" & DetPotreroOri & "'" & "," & DetPotreroIdDes & "," & "'" & DetPotreroDes & "'" & "," & "'" & DetDicoseUbicacionOri & "'" & "," & "'" & DetDicoseUbicacionDes & "'" & ")"
        '        Dim cadenaConexion As String = "INSERT INTO operacionesLineas (ope_lin_idCabezal,ope_lin_fecha, ope_lin_idevento,ope_lin_evento,ope_lin_ideventoLin,ope_lin_eventoLin,ope_lin_dispositivo,ope_lin_uni,ope_lin_cnt,ope_lin_potreroIdOri,ope_lin_potreroOri,ope_lin_potreroIdDes,ope_lin_potreroDes,ope_lin_dicoseCampoOri,ope_lin_dicoseCampoDes) VALUES (" & UltimoIdoperacionesLineas & "," & "'" & DetFecha & "'" & "," & DetLote & "," & DetOrd & "," & DetIdEvento & "," & "'" & DetEvento & "'" & "," & DetIdEventoLin & "," & "'" & DetEventoLin & "'" & "," & "'" & DetDispositivo & "'" & "," & "'" & Detuni & "'" & "," & Detcnt & "," & DetPotreroIdOri & "," & "'" & DetPotreroOri & "'" & "," & DetPotreroIdDes & "," & "'" & DetPotreroDes & "'" & "," & "'" & DetDicoseUbicacionOri & "'" & "," & "'" & DetDicoseUbicacionDes & "'" & ")"

        '        If GuardarMovimientos = True Then
        '            banderaDetalle = unafachada.EjecutarConsultaGENERICA(cadenaConexion)
        '            guardarCabezal = True
        '        End If
        '        i += 1
        '    End While
        'End If


        '    If guardarCabezal = True Then
        '        'GUARADR CABEZAL
        '        Dim CabFecha As Date = Me.dtpFecha.Value
        '        Dim Cabnombre As String = Me.dtpFecha.Value.ToString("dd/MM/yyyy") & " - " & Me.cboListaEventos.SelectedItem
        '        Dim CabAnimales As String = Me.txtSeleccionados.Text
        '        Dim CabTipo As String = Me.txtTipoIngreso.Text
        '        Dim cabEvento As String = Me.cboListaEventos.SelectedItem
        '        Dim cabIdEvento As Integer = vIdEvento

        '        'Dim cadenaConexionCabezal As String = "INSERT INTO operaciones (ope_id,ope_fecha,ope_nombre,ope_Idevento,ope_evento,ope_cantAnimales,ope_anula,ope_tipo) VALUES (" & "1" & "," & "'" & CabFecha & "'" & "," & "'" & Cabnombre & "'" & "," & cabIdEvento & "," & "'" & cabEvento & "'" & "," & CabAnimales & "," & "'" & Nothing & "'" & "," & "'" & CabTipo & "'" & ")"
        '        Dim cadenaConexionCabezal As String = "INSERT INTO operaciones (ope_fecha,ope_nombre,ope_Idevento,ope_evento,ope_cantAnimales,ope_anula,ope_tipo) VALUES (" & "'" & CabFecha & "'" & "," & "'" & Cabnombre & "'" & "," & cabIdEvento & "," & "'" & cabEvento & "'" & "," & CabAnimales & "," & "'" & Nothing & "'" & "," & "'" & CabTipo & "'" & ")"
        '        banderaCabezal = unafachada.EjecutarConsultaGENERICA(cadenaConexionCabezal)
        '    End If
        '    If banderaCabezal And banderaDetalle Then
        '        MsgBox("Guardado Correctamente")
        '        If ActualizarAnimales = True Then
        '            NuevaOperacion(True, opcionDatos)
        '        Else
        '            NuevaOperacion(False, opcionDatos)
        '        End If
        '    Else
        '        MsgBox("Error Al Guaradar")
        '    End If
        'Else
        '    MsgBox("Debe Seleccionar al menos un animal")

        'End If

    End Sub

    Public Sub ActivarEventos(ByVal pListaDiccionario As String())
        Try
            ListaDiccionarioEventos = pListaDiccionario
            reconocedorEventos = New SpeechRecognitionEngine()
            reconocedorEventos.SetInputToDefaultAudioDevice()
            Dim grammar As New GrammarBuilder
            grammar.Append(New Choices(ListaDiccionarioEventos))
            reconocedorEventos.LoadGrammar(New Grammar(grammar))
            reconocedorEventos.RecognizeAsync(RecognizeMode.Single)
            Me.txtStatus.Text = "Diga un evento..."
            TextoaVozHilo("Diga un evento")
            AddHandler reconocedorEventos.SpeechDetected, AddressOf detectado
            AddHandler reconocedorEventos.SpeechRecognitionRejected, AddressOf noreco
            AddHandler reconocedorEventos.SpeechRecognized, AddressOf EscucharEventos
        Catch ex As Exception

        End Try

        Timer2.Enabled = True
    End Sub


    Public Sub BuscarAnimalHilo2(ByVal pDispositivo As String)
        'Dim cadenaAnimal As String = "SELECT animal.ani_dispositivo, animal.ani_fechaNac, animal.ani_nombre, animal.ani_raza, animal.ani_cruza, animal.ani_padre, animal.ani_madre, animal.ani_dicose_nacimiento, animal.ani_sexo, animal.ani_pesoNac, animal.ani_propietario, animal.ani_ubicacion, animal.ani_tenencia, animal.ani_vida, animal.ani_trazabilidad, animal.ani_potrero, animal.ani_entorado, animal.ani_castrado, animal.ani_prenado, animal.ani_fecha_ubicacion_Actual, animal.ani_errores, animal.ani_peso FROM(animal) WHERE(((animal.ani_dispositivo) =" & "'" & pDispositivo & "'" & ")) GROUP BY animal.ani_dispositivo, animal.ani_fechaNac, animal.ani_nombre, animal.ani_raza, animal.ani_cruza, animal.ani_padre, animal.ani_madre, animal.ani_dicose_nacimiento, animal.ani_sexo, animal.ani_pesoNac, animal.ani_propietario, animal.ani_ubicacion, animal.ani_tenencia, animal.ani_vida, animal.ani_trazabilidad, animal.ani_potrero, animal.ani_entorado, animal.ani_castrado, animal.ani_prenado, animal.ani_fecha_ubicacion_Actual, animal.ani_errores, animal.ani_peso;"
        'Dim unAnimalDataSetEncontrado As DataSet = unafachada.EjecutarConsultaGENERICADataSet(cadenaAnimal)
        'UnAnimalDataSet = unAnimalDataSetEncontrado
    End Sub

    Public Function BuscarAnimal(ByVal pDispositivo As String) As DataRow
        Try

            Dim rows As DataRow()
            ' sort and filter data
            rows = dtAnimales.Select("ani_dispositivo= " & pDispositivo)
            Return rows(0)

        Catch ex As Exception
            UnAnimal = Nothing
        End Try
    End Function

    Public Sub BuscarAnimalHilo(ByVal pDispositivo As String)
        Try

            Dim rows As DataRow()
            ' sort and filter data
            rows = dtAnimales.Select("ani_dispositivo= " & pDispositivo)
            UnAnimal = rows(0)

        Catch ex As Exception
            UnAnimal = Nothing
        End Try
    End Sub


    Public Sub BuscarEventos()
        Dim pDispositivo As String = Me.txtDispositivo.Text
        Me.lbini.Text = ""
        Me.lbFin.Text = ""
        Me.lbini.Text = pDispositivo.Substring(6, 5)
        Me.lbFin.Text = pDispositivo.Substring(11, 4)
        'If Me.txtFinDis.Text.Length = 3 Then
        '    Me.txtFinDis.Text = "0" & terminacion
        'End If
        pDispositivo = pDispositivo.Substring(0, 15)
        dtgv.DataSource = Nothing
        dtgv.Rows.Clear()
        dtgv.Refresh()
        If pDispositivo.Length = 15 Then
            'DATOS ANIMAL
            If Not UnAnimal Is Nothing Then
                If UnAnimal("ani_dispositivo").ToString.Length > 0 Then
                    'Lista Operacion Anteriores
                    Dim ini As String = Me.DtpFechaDesde.Value.Year & "/" & Me.DtpFechaDesde.Value.Month & "/" & Me.DtpFechaDesde.Value.Day
                    Dim fin As String = Me.dtpFechaHasta.Value.Year & "/" & Me.dtpFechaHasta.Value.Month & "/" & Me.dtpFechaHasta.Value.Day
                    Dim cadena As String = "SELECT operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo AS Dispositivo, Count(operacionesLineas.ope_lin_id) AS Unidad, operacionesLineas.ope_lin_eventoLin AS Evento, animal.ani_potrero AS Ubicacion, animal.ani_fechaNac AS Nacio, animal.ani_raza AS Raza, animal.ani_cruza AS Cruza, animal.ani_sexo AS Sexo FROM operacionesLineas INNER JOIN animal ON operacionesLineas.ope_lin_dispositivo = animal.ani_dispositivo WHERE (((operacionesLineas.ope_lin_fecha)>=" & "#" & ini & "#" & " And (operacionesLineas.ope_lin_fecha)<=" & "#" & fin & "#" & ") AND ((operacionesLineas.ope_lin_dispositivo)=" & "'" & pDispositivo & "'" & "))GROUP BY operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo, operacionesLineas.ope_lin_eventoLin, animal.ani_potrero, animal.ani_fechaNac, animal.ani_raza, animal.ani_cruza, animal.ani_sexo"
                    unDataSet = unafachada.EjecutarConsultaGENERICADataSet(cadena)

                    Dim meses As Integer
                    Try
                        meses = DateDiff(DateInterval.Month, UnAnimal("ani_fechaNac"), dtpFechaRef.Value)
                        If meses = 1365 Then
                            meses = 0
                        End If
                        Me.txtEdad.Text = meses

                    Catch ex As Exception
                        Me.txtEdad.Text = "N/A"
                    End Try

                    Try
                        Me.txtRaza.Text = UnAnimal("ani_raza")
                    Catch ex As Exception
                        Me.txtRaza.Text = "N/A"
                    End Try

                    Try
                        Me.txtSexo.Text = UnAnimal("ani_sexo")
                    Catch ex As Exception
                        Me.txtSexo.Text = "N/A"
                    End Try

                    Try
                        Me.txtTenencia.Text = UnAnimal("ani_tenencia")
                    Catch ex As Exception
                        Me.txtTenencia.Text = "N/A"
                    End Try

                    Try
                        Me.txtUbicacion.Text = UnAnimal("ani_ubicacion")
                    Catch ex As Exception
                        Me.txtUbicacion.Text = "N/A"
                    End Try

                    Try
                        Dim nombreProductor As String = unafachada.BuscarProductorxDicosePropietario(UnAnimal("ani_propietario"), dtProductores)("pro_nombre")
                        Me.txtPropietario.Text = nombreProductor
                    Catch ex As Exception
                        Me.txtPropietario.Text = "N/A"
                    End Try

                    Try
                        Me.txtVida.Text = UnAnimal("ani_vida")
                    Catch ex As Exception
                        Me.txtVida.Text = "N/A"
                    End Try

                    Try
                        Me.txtTraza.Text = UnAnimal("ani_trazabilidad")
                    Catch ex As Exception
                        Me.txtTraza.Text = "N/A"
                    End Try

                    Try
                        Me.txtPotrero.Text = UnAnimal("ani_potrero")
                    Catch ex As Exception
                        Me.txtPotrero.Text = "N/A"
                    End Try

                    Try
                        Me.txtPesoNac.Text = UnAnimal("ani_pesoNac")
                    Catch ex As Exception
                        Me.txtPesoNac.Text = "N/A"
                    End Try

                    Try
                        Me.txtCastrado.Text = UnAnimal("ani_castrado")
                    Catch ex As Exception
                        Me.txtCastrado.Text = "N/A"
                    End Try

                    Try
                        Me.txtEntorado.Text = UnAnimal("ani_entorado")
                    Catch ex As Exception
                        Me.txtEntorado.Text = "N/A"
                    End Try

                    Try
                        Me.txtPrenado.Text = UnAnimal("ani_prenado")
                    Catch ex As Exception
                        Me.txtPrenado.Text = "N/A"
                    End Try

                    Try
                        Me.txtDicoseNac.Text = UnAnimal("ani_dicose_nacimiento")
                    Catch ex As Exception
                        Me.txtDicoseNac.Text = "N/A"
                    End Try

                    Try
                        Me.txtCruza.Text = UnAnimal("ani_cruza")
                    Catch ex As Exception
                        Me.txtCruza.Text = "N/A"
                    End Try

                    Try
                        Dim fechaUbicacionActual As Date = UnAnimal("ani_fecha_ubicacion_Actual")
                        Dim dias As Integer = DateDiff(DateInterval.Day, fechaUbicacionActual, Me.dtpFechaRef.Value)
                        Me.txtDiasUbicacion.Text = dias
                    Catch ex As Exception
                        Me.txtDiasUbicacion.Text = "N/A"
                    End Try

                    Try
                        Me.txtErrores.Text = UnAnimal("ani_errores")
                    Catch ex As Exception
                        Me.txtErrores.Text = "N/A"
                    End Try

                    Try
                        Me.txtPesoActual.Text = Math.Round(UnAnimal("ani_peso"), 0)

                    Catch ex As Exception
                        Me.txtPesoActual.Text = "N/A"
                    End Try
                    Me.txtOrejano.Text = 0

                    EmitirSonidos()
                End If

                Try
                    If unDataSet.Tables(0).Rows.Count > 0 Then
                        dtgv.DataSource = unDataSet.Tables(0)
                    Else
                        dtgv.DataSource = Nothing
                    End If
                Catch ex As Exception
                    dtgv.DataSource = Nothing
                End Try
            Else
                limpiarDatosAnimal()
                Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                Me.txtOrejano.Text = 1
                textoaVoz.Start("Orejano")
                'Thread.Sleep(1500)
                'textoaVoz.Abort()
                ''Esperar a que realmente mueran los hilos
                'While textoaVoz.IsAlive
                'End While
                ' My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\" & "Orejano" & ".wav", AudioPlayMode.WaitToComplete)


            End If

        End If
    End Sub

    Public Sub limpiarDatosAnimal()
        Me.txtEdad.Text = "N/A"
        Me.txtRaza.Text = "N/A"
        Me.txtSexo.Text = "N/A"
        Me.txtTenencia.Text = "N/A"
        Me.txtUbicacion.Text = "N/A"
        Me.txtPropietario.Text = "N/A"
        Me.txtVida.Text = "N/A"
        Me.txtTraza.Text = "N/A"
        Me.txtPotrero.Text = "N/A"
        Me.txtPesoNac.Text = "N/A"
        Me.txtCastrado.Text = "N/A"
        Me.txtEntorado.Text = "N/A"
        Me.txtPrenado.Text = "N/A"
        Me.txtPrenado.Text = "N/A"
        Me.txtDicoseNac.Text = "N/A"
        Me.txtCruza.Text = "N/A"

    End Sub

    Public Sub EmitirSonidos()
        If unafachada.ActivarSonido = True Then
            Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            Dim texto As String = ""
            Try
                If Me.chkEdad.Checked = True Then
                    texto = "Edad " & Me.txtEdad.Text

                    'My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\Categorias\" & "Edad" & ".wav", AudioPlayMode.WaitToComplete)
                    'My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\" & pNumero & ".wav", AudioPlayMode.WaitToComplete)
                End If

                If Me.chkPropietario.Checked = True Then
                    texto &= " " & Me.txtPropietario.Text
                End If

                If Me.chkDiasUbicacion.Checked = True Then
                    texto &= " Dias " & Me.txtDiasUbicacion.Text
                End If

                If Me.chkSexo.Checked = True Then
                    If Me.txtSexo.Text <> "-" Then
                        If Me.txtSexo.Text = "Macho" Then
                            texto &= " Macho"
                            'My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\" & "macho" & ".wav", AudioPlayMode.WaitToComplete)
                        End If

                        If Me.txtSexo.Text = "Hembra" Then
                            texto &= " Hembra"
                            'My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\" & "hembra" & ".wav", AudioPlayMode.WaitToComplete)
                        End If
                    Else
                        texto &= (" Sexo sin informacion")
                    End If
                End If

                If Me.chkPotrero.Checked = True Then
                    Try
                        texto &= " " & Me.txtPotrero.Text
                        'My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\Potreros\" & Me.txtPotrero.Text & ".wav", AudioPlayMode.WaitToComplete)
                    Catch ex As Exception
                        'MsgBox("No se encuentra el sonido")
                    End Try

                End If

                If Me.chkDispositivo.Checked = True Then

                    Dim terminacion As String = Me.txtDispositivo.Text.Substring(6, 9)
                    texto &= " Chip " & terminacion
                End If



                If Me.chkPesoActual.Checked = True Then
                    texto &= " Peso " & Me.txtPesoActual.Text
                End If

                If texto.Length > 1 Then
                    textoaVoz.Start(texto)
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub deletrearNumeros(ByVal pNumero As String)
        Dim i As Integer = 0
        Dim numeroActual As Integer
        Try
            While i <= pNumero.Length
                numeroActual = pNumero.Substring(i, 1)
                My.Computer.Audio.Play(Environment.CurrentDirectory & "\Sonidos\0-9\" & numeroActual & ".wav", AudioPlayMode.WaitToComplete)
                i += 1
            End While
        Catch ex As Exception

        End Try

    End Sub

    Public Function Conectar(ByVal pPuertoCom As String) As Boolean
        Return Setup_Puerto_Serie(pPuertoCom)

    End Function

    Function Setup_Puerto_Serie(ByVal pComboPorts As String) As Boolean

        Try

            With SerialPort1

                If .IsOpen Then

                    .Close()

                End If

                .PortName = pComboPorts

                .BaudRate = 9600 '// 9600 baud rate Baston Alfflex ' 1200 baquano

                .DataBits = 8 '// 8 data bits

                .StopBits = IO.Ports.StopBits.One '// 1 Stop bit

                .Parity = IO.Ports.Parity.None '

                .DtrEnable = False

                .Handshake = IO.Ports.Handshake.None

                .ReadBufferSize = 2048

                .WriteBufferSize = 1024

                '.ReceivedBytesThreshold = 1

                .WriteTimeout = 500

                .Encoding = System.Text.Encoding.Default
                .Open() ' ABRE EL PUERTO SERIE
                Return True
            End With

        Catch ex As Exception
            Return False
            'MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Function


    Public Sub ActivarBaston()
        Dim puerto As String = unafachada.puertoBaston
        If Conectar(puerto) Then
            Me.btnBaston.Enabled = False

            Timer1.Enabled = True
        Else
            Me.btnBaston.Enabled = True
            MsgBox("Conecte Baston a la PC")

        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Try
            If unafachada.tipoBaston = 1 Then
                numCaravana = SerialPort1.ReadLine
            Else
                numCaravana = SerialPort1.ReadExisting
            End If


            'numCaravana = SerialPort1.ReadExisting
        Catch ex As Exception
            'MsgBox(SerialPort1.ReadExisting.ToString)
        End Try

        'Dim ListaCaravanas As New List(Of String) 'vector que servira de buffer par
        'Dim bufer(1500) As Byte      'utilizada para almacenar los datos que se reciben por el puerto
        'Dim pos As Integer    ' sera utilizada como contador
        'Dim Retorno As String = ""
        'Dim Descarga(1024) As Byte
        'numCaravana = ""
        'Control.CheckForIllegalCrossThreadCalls = False
        'Try
        '    'numCaravana = SerialPort1.ReadLine

        '    'numCaravana = numDispositivo.Replace("#", "")

        '    'If numCaravana.Length > 15 Then
        '    '    numCaravana = numCaravana.Substring(0, 15)
        '    '    If numCaravana.Length = 15 Then
        '    '        BuscarEventos(numCaravana)
        '    '    End If

        '    'End If
        '    'pos = pos + 1

        'Catch ex As Exception

        '    MsgBox(ex.Message)

        'End Try
    End Sub





    Private Sub ButtonX2_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Me.txtDispositivo.Visible = True
        Me.Lsnumeros.Items.Clear()
        Me.Lsnumeros.Items.Add("858000012969212")
        Me.Lsnumeros.Items.Add("858000024346102")
        Me.Lsnumeros.Items.Add("858000024168248")
        Me.Lsnumeros.Items.Add("858000022555145")
        Me.Lsnumeros.Items.Add("858000000964340")
        Me.Lsnumeros.Items.Add("858000022555142")
        Me.Lsnumeros.Items.Add("858000000964343")
        Me.Lsnumeros.Items.Add("858000022555139")
        Me.Lsnumeros.Items.Add("858000003259233")
        Me.Lsnumeros.Items.Add("858000022555061")
        Me.Lsnumeros.Items.Add("858000000258888")



    End Sub

    Private Sub Lsnumeros_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Lsnumeros.SelectedIndexChanged
        Me.txtDispositivo.Text = Nothing
        Me.txtDispositivo.Text = Me.Lsnumeros.SelectedItem.ToString
    End Sub


    Private Sub btnEscuchar_Click(sender As System.Object, e As System.EventArgs)


    End Sub


#Region "Sonidos"

    Private Sub detectado(ByVal sender As Object, ByVal e As SpeechDetectedEventArgs)
        ''MsgBox(e.AudioPosition.Duration.ToString())
        Dim reconoce As String = e.ToString
    End Sub
    Private Sub noreco(ByVal sender As Object, ByVal e As SpeechRecognitionRejectedEventArgs)
        ''MsgBox("No se reconoce el comando de VOZ")
        Try
            '  voz.Speak("Comando no encontrado")
        Catch ex As Exception

        End Try

    End Sub

    Public Sub EscucharEventos(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
        Dim palabra As String = e.Result.Text.ToUpper.ToString
        Dim unEventoFila As DataRow = BuscarEventosLineasEscuchada(palabra)

        If Not unEventoFila Is Nothing Then
            Me.cboEventos.SelectedItem = unEventoFila.Item("eve_lin_nombre")
            Me.txtIdEvento.Text = unEventoFila("eve_lin_id").ToString
            textoaVoz.Start("Seleccionado " & Me.cboEventos.SelectedItem)
        Else
            Me.cboEventos.SelectedIndex = 0
            Me.txtIdEvento.Text = 0
        End If

        If Not unEventoFila Is Nothing Then
            'Variables de Estados 
            Me.txtFoco.Text = palabra
            Me.txtEscucha.Text = palabra
        End If

    End Sub

    Public Sub AgregarUnaFila(ByVal pDispositivo As String, ByVal pSexo As String, ByVal pRaza As String, ByVal pEdad As String, ByVal pIdEvento As String, ByVal pEvento As String, ByVal pOrejano As String, ByVal pDesde As Integer, ByVal pIdEventoPrincipal As Integer, ByVal pEventoPrincipal As String, ByVal pDatosAnimal As Boolean, ByVal pFechaLectura As Date, ByVal pGuardar As Boolean)
        Dim grupoEvento As String
        Dim Orejano As Integer
        If pDesde = 1 Then
            grupoEvento = pEvento
            Orejano = pOrejano
        Else
            grupoEvento = Me.cboEventos.SelectedItem
            Try
                Orejano = txtOrejano.Text
            Catch ex As Exception
                Orejano = 1
            End Try

        End If

        If pDatosAnimal = False Then
            Orejano = 1
            pSexo = "N/A"
            pRaza = "N/A"
            pEdad = "N/A"
        Else
            If pDesde = 1 Then
                Dim unaFilaAnimal As DataRow = BuscarAnimal(pDispositivo)
                If Not unaFilaAnimal Is Nothing Then
                    Orejano = 0
                    pSexo = unaFilaAnimal("ani_sexo")
                    pRaza = unaFilaAnimal("ani_raza")
                    Dim meses As Integer
                    Try
                        meses = DateDiff(DateInterval.Month, unaFilaAnimal("ani_fechaNac"), dtpFechaRef.Value)
                        If meses = 1365 Then
                            meses = 0
                        End If
                    Catch ex As Exception
                        meses = 0
                    End Try
                    pEdad = meses

                Else
                    Orejano = 1
                    pSexo = "N/A"
                    pRaza = "N/A"
                    pEdad = "N/A"
                End If
            End If
        End If

        If pDispositivo.Length = 15 Then
            Dim g As ListViewGroup = BuscarGrupo(grupoEvento)
            Dim lvi As New ListViewItem("")
            lvi.SubItems.Add(pDispositivo)
            lvi.SubItems.Add(pSexo)
            lvi.SubItems.Add(pRaza)
            lvi.SubItems.Add(pEdad)
            lvi.SubItems.Add(pIdEvento)
            lvi.SubItems.Add(grupoEvento)
            lvi.SubItems.Add(Orejano)
            lvi.SubItems.Add(pIdEventoPrincipal)
            lvi.SubItems.Add(pEventoPrincipal)
            lvi.SubItems.Add(pFechaLectura)

            If Orejano = 1 Then
                lvi.BackColor = Color.LightSalmon
                lvi.SubItems.Item(1).BackColor = Color.LightSalmon
                lvi.SubItems.Item(2).BackColor = Color.LightSalmon
                lvi.SubItems.Item(3).BackColor = Color.LightSalmon
                lvi.SubItems.Item(4).BackColor = Color.LightSalmon
                lvi.SubItems.Item(5).BackColor = Color.LightSalmon
                lvi.SubItems.Item(6).BackColor = Color.LightSalmon
                lvi.SubItems.Item(7).BackColor = Color.LightSalmon
                lvi.SubItems.Item(8).BackColor = Color.LightSalmon
                'para(cero) 'LightGoldenrodYellow
            End If

            Dim unaLinea As String = pDispositivo & ";" & pSexo & ";" & pRaza & ";" & pEdad & ";" & pIdEvento & ";" & grupoEvento & ";" & Orejano & ";" & pIdEventoPrincipal & ";" & pEventoPrincipal & ";" & pFechaLectura

            If pDesde = 0 Then
                'Elimina el registro si existe
                Dim indiceListView As Integer
                Dim banderaListView As Boolean = False
                If unafachada.BuscarYborrar(pDispositivo, listaTxtRegistrosTemporal) Then

                    If ListaDispositivos.Items.Count > 0 Then
                        Dim i As Integer = 0
                        For i = 0 To ListaDispositivos.Items.Count
                            Dim linea As String = ListaDispositivos.Items(i).SubItems(1).Text
                            If linea.Contains(pDispositivo) Then
                                indiceListView = i
                                banderaListView = True
                                Exit For
                            End If
                        Next
                    End If
                    If banderaListView = True Then
                        ListaDispositivos.Items(indiceListView).Remove()
                    End If

                End If

                If pGuardar = True Then
                    Me.listaTxtRegistrosTemporal.Add(unaLinea)
                    Dim nombreYrutaArchivo As String = Environment.CurrentDirectory & "\LecturasTiempoReal\" & NombreArchivo
                    unafachada.GuardarTxt(listaTxtRegistrosTemporal, nombreYrutaArchivo)
                End If

            End If
            lvi.Group = g
            ListaDispositivos.Items.Add(lvi)
        End If
    End Sub


    Public Function BuscarGrupo(ByVal pNombre As String) As ListViewGroup
        Dim bandera As Boolean = False
        Dim g As ListViewGroup
        For Each lv As ListViewItem In ListaDispositivos.Items
            If pNombre = lv.SubItems(6).Text Then
                bandera = True
                g = lv.Group
                Exit For
            End If
        Next

        If bandera = False Then
            g = New ListViewGroup(pNombre)
            ListaDispositivos.Groups.Add(g)
        End If
        Return g


    End Function

    Public Function TotalxGrupos() As String
        Dim retorno As String = ""
        If ListaDispositivos.Groups.Count > 0 Then
            Dim Total As Integer
            Dim TotalGeneral As Integer
            Dim nombre As String
            Dim g As ListViewGroup
            Dim i As Integer = 0
            For i = 0 To ListaDispositivos.Groups.Count - 1
                Try
                    Total = ListaDispositivos.Groups.Item(i).Items.Count
                    If Total > 0 Then
                        g = ListaDispositivos.Groups(i)
                        nombre = g.Header
                        Total = ListaDispositivos.Groups.Item(i).Items.Count
                        retorno &= "Cantidad de " & nombre & " " & Total & "  "
                        TotalGeneral += ListaDispositivos.Groups.Item(i).Items.Count
                    End If

                Catch ex As Exception

                End Try
            Next
            retorno &= "Total General " & TotalGeneral
        Else
            retorno &= "Se encuentra vacio"
        End If
        Return retorno
    End Function

    Public Function BuscarEventosLineasEscuchada(ByVal pPalabra As String) As DataRow
        Try
            For Each rw As DataRow In dtEventosLineas.Rows
                If rw("eve_lin_fonetica").ToString.ToUpper.Contains(pPalabra) Then
                    Return rw
                End If
            Next rw
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Function BuscarEventosLineas(ByVal pPalabra As String) As DataRow
        Try
            For Each rw As DataRow In dtEventosLineas.Rows
                If rw("eve_lin_fonetica") = pPalabra Then
                    Return rw
                End If
            Next rw
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Function BuscarParametros(ByVal pNombre As String) As DataRow
        Try
            For Each rw As DataRow In dtParametros.Rows
                If rw("NombreParametro") = pNombre Then
                    Return rw
                End If
            Next rw
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Sub TextoaVozHilo(ByVal ptexto As String)
        If unafachada.ActivarSonido = True Then
            Try
                ' Initialize a new instance of the SpeechSynthesizer.
                Dim SAPI
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(ptexto)

            Catch ex As Exception

            End Try
        End If
    End Sub

#End Region



    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Me.txtStatus.Text = "Esperando Orden..."
        Try
            'ACTIVO ESCUCHA MULTIPLE 
            reconocedorEventos.Dispose()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        Catch ex As Exception

        End Try
        Timer2.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not numCaravana Is Nothing Then
            If numCaravana.Contains("LA URY") Then
                Timer1.Enabled = False
                MsgBox("Configure el baston con el codigo de su pais, 858 en el sistema alflex")
            Else
                If numCaravana.ToString.Length > 15 Then
                    Try
                        If unafachada.tipoBaston = 1 Then
                            numCaravana = numCaravana.Substring(numCaravana.IndexOf("858"), 15)
                        Else
                            numCaravana = numCaravana.Substring(numCaravana.IndexOf("999"), 15)
                        End If

                        Me.txtDispositivo.Text = numCaravana
                    Catch ex As Exception

                    End Try
                    numCaravana = ""
                End If
            End If
        End If
    End Sub

    Private Sub cboEventos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEventos.SelectedIndexChanged
        Try
            Dim unaFila As DataRow = unafachada.BuscarListaEventosLineas(Me.cboEventos.SelectedItem, dtEventosLineas, "eve_lin_nombre")
            Me.txtIdEvento.Text = unaFila.Item("eve_lin_id")
            Me.txtIdEventoPrincipal.Text = unaFila.Item("eve_lin_ideventos")
            Me.txtEvento.Text = unaFila.Item("eve_lin_nombrePrincipal")
        Catch ex As Exception
            Me.txtIdEvento.Text = 0
        End Try


    End Sub


    Private Sub ListaDispositivos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        'Dim indice As String = ListaDispositivos.FocusedItem.SubItems(1).Text
        ' ListaDispositivos.FocusedItem.Remove()
        Dim indice As String
        For i As Integer = ListaDispositivos.SelectedItems.Count - 1 To 0 Step -1
            indice = ListaDispositivos.SelectedItems(i).SubItems(1).Text
            ListaDispositivos.SelectedItems(i).Remove()

        Next


    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles btnBaston.Click
        ActivarBaston()
    End Sub






    Public Sub New(ByVal pIdActividad As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        idActividad = pIdActividad
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub chkDicoseNac_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDicoseNac.CheckedChanged

    End Sub

    Private Sub chkEdad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEdad.CheckedChanged

    End Sub

   
   
    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        cerrar()
    End Sub

    Public Sub cerrar()
        Dim Eliminado As Integer
        If Me.ListaDispositivos.Items.Count > 0 Then
            Eliminado = 0
        Else
            Eliminado = 1
        End If

        unafachada.CerrarHistorial(idHistorial, 1, Eliminado)
        Me.SerialPort1.Dispose()
        Me.SerialPort1.Close()
        Me.Dispose()
        Me.Close()
        Dim unIUPreviaEventos As New IUPreviaEventos
        unIUPreviaEventos.Show()
        GC.Collect()
    End Sub

    Private Sub cboOpciones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboOpciones.SelectedIndexChanged
        Try
            If Me.cboOpciones.SelectedIndex <> 0 Then
                Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                textoaVoz.Start(Me.cboOpciones.SelectedItem.ToString)
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        banderadeCierre = False
        If Me.txtDispositivo.Text = unafachada.chipEnter Then
            banderadeCierre = True
        End If

        If banderadeCierre = True Then
            Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            textoaVoz.Start("Lote Cerrado")
            cerrar()
            Me.txtDispositivo.Text = ""
            Timer3.Enabled = False

        Else
            Dim textoaVoz1 As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            textoaVoz1.Start("Cierre Cancelado, expiro el tiempo de cierre")
            Me.txtDispositivo.Text = ""
            cboOpciones.SelectedIndex = 0
            Timer3.Enabled = False
        End If

    End Sub


   
End Class