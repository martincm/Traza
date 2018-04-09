Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports DevComponents.DotNetBar.Controls
Imports Microsoft.Office.Interop
Public Class IUIngresoEventos

    Dim RecibiendoDatos As Boolean = False
    Dim dtRaza, dtListaEventos, dtListaEventosLineas, dtPotreros, dtTemporal As DataTable
    Dim listaDispositivosFiltrados As List(Of String)
    Dim ListaDispositivos As List(Of String)
    Dim filtroRaza, filtroSexo As Boolean
    Dim vIdEvento As Integer
    Dim vIdSubEvento As Integer
    Dim vPotreroDestino As Integer
    Dim vPotrero As Integer
    Dim opcionDatos As Integer
    Private bEdit, finalizado As Boolean
    Dim nombreArchivo As String
    Dim tamanoActualListaTimer2, tamanoActualListaTimer1 As Integer

    'Variables Para Cargar Detalles
    Dim listaRazas As New List(Of String)
    Dim listaCruzas As New List(Of String)
    Dim listaPropietarios As New List(Of String)
    Dim listaUbicacion As New List(Of String)
    Dim listaTenencia As New List(Of String)
    Dim DicosePropietario As String
    Dim DicoseUbicacion As String
    Dim DicoseTenencia As String
  

    Private Sub txtGuardar_Click(sender As System.Object, e As System.EventArgs)
        CargarAnimales(1)

    End Sub

    Public Function CargarAnimales(ByVal pOrigenDatos As Integer) As Boolean
        Dim cargarOrigenDatos As Boolean = False
        Dim bandera As Boolean = False
        Select Case pOrigenDatos
            Case 1
                Me.cboRaza.Items.Clear()
                Me.cboRaza.Items.Add("")
                Me.cboCruza.Items.Clear()
                Me.cboCruza.Items.Add("")

                Me.SerialPort1.Close()
                Me.SerialPort1.Dispose()

                nombreArchivo = "Lecturas " & Today.Day & "-" & Today.Month & "-" & Today.Year & " v" & Now.Second & ".txt"
                bandera = BajarBaston()

                'ListaDispositivos = unafachada.LeerTxtDevoverCaravanas(Environment.CurrentDirectory & " \Lecturas\" & nombreArchivo)
                'cargarOrigenDatos = True
            Case 2
                Me.cboRaza.Items.Clear()
                Me.cboRaza.Items.Add("")
                Me.cboCruza.Items.Clear()
                Me.cboCruza.Items.Add("")
                Me.SerialPort1.Close()
                Me.SerialPort1.Dispose()
                ListaDispositivos = Nothing
                cargarOrigenDatos = True
                bandera = True
            Case 3
                unafachada.NombreArchivoSeleccionado = ""
                SeleccionarArchivoLotes()

                Me.cboRaza.Items.Clear()
                Me.cboRaza.Items.Add("")
                Me.cboCruza.Items.Clear()
                Me.cboCruza.Items.Add("")
                Dim existe As Boolean = File.Exists(Environment.CurrentDirectory & "\LecturasTiempoReal\" & unafachada.NombreArchivoSeleccionado)
                If existe Then
                    Dim listaTxtRegistrosTemporal As New List(Of String)
                    Dim listaOrdenada As New List(Of String)
                    listaTxtRegistrosTemporal = unafachada.LeerTxtEventos(Environment.CurrentDirectory & "\LecturasTiempoReal\" & unafachada.NombreArchivoSeleccionado)

                    Using MyReader As New Microsoft.VisualBasic.
                               FileIO.TextFieldParser(Environment.CurrentDirectory & "\LecturasTiempoReal\" & unafachada.NombreArchivoSeleccionado)
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
                                    listaOrdenada.Add(grupoEvento & ";" & pDispositivo)
                                Else
                                    If currentRow(0).Contains("Titulo") Then
                                        Me.lbTitulo.Text = "Tarea: " & currentRow(1) & " Fecha-Hora: " & currentRow(2)
                                    End If
                                End If
                            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                                MsgBox("Line " & ex.Message &
                                "is not valid and will be skipped.")
                            End Try
                        End While
                    End Using
                    listaOrdenada.Sort()

                    Dim i2 As Integer
                    Dim ListaOrdenadaLoteada As New List(Of String)
                    Dim loteAnterior As String = ""
                    For i2 = 0 To listaOrdenada.Count - 1
                        Dim linea As String = listaOrdenada.Item(i2)
                        Dim Palabras As String() = linea.Split(New Char() {";"c})
                        Dim unaCaravana As String = Palabras(1)
                        Dim unLote As String = Palabras(0)

                        If unLote <> loteAnterior Then
                            ListaOrdenadaLoteada.Add("nuevo;000000000000000")
                            ListaOrdenadaLoteada.Add(unLote & ";" & unaCaravana)
                            loteAnterior = unLote
                        Else
                            ListaOrdenadaLoteada.Add(unLote & ";" & unaCaravana)
                        End If
                    Next
                    bandera = True
                    CargarDetalle(ListaOrdenadaLoteada)
                    dtTemporal = New DataTable
                    unafachada.ExportarDataGridViewADataTable(Me.DataGrid, dtTemporal)
                Else
                    ' MsgBox("No existe archivo " & unafachada.NombreArchivoSeleccionado)
                End If


            Case 4
                Me.cboRaza.Items.Clear()
                Me.cboRaza.Items.Add("")
                Me.cboCruza.Items.Clear()
                Me.cboCruza.Items.Add("")
                opcionDatos = 1

                nombreArchivo = "Lecturas.txt"

                ListaDispositivos = unafachada.LeerTxtDevoverCaravanas(Environment.CurrentDirectory & " \" & nombreArchivo)
                If Not ListaDispositivos Is Nothing Then

                    If ListaDispositivos.Count > 0 Then
                        bandera = True
                        cargarOrigenDatos = True
                    End If
                End If


            Case Else

                MsgBox("Seleccione Origen de Datos")

        End Select

        If cargarOrigenDatos = True And bandera = True Then
            LimpiarFormulario()
            cargarTitulos()
            bEdit = False
            Me.dtpFecha.Value = Today
            'TRAER ID OPERACIONES
            TraerIdOperaciones()

            CargarDetalle(ListaDispositivos)
            dtTemporal = New DataTable
            unafachada.ExportarDataGridViewADataTable(Me.DataGrid, dtTemporal)
        End If
        Return bandera
    End Function

    Public Sub FiltrarDataTableAgregarALista(ByVal dt As DataTable, ByVal filter As String, ByVal sort As String)
        If Not dt Is Nothing Then
            listaDispositivosFiltrados = New List(Of String)
            Dim rows As DataRow()
            ' sort and filter data
            rows = dt.Select(filter, sort)
            For Each dr As DataRow In rows
                listaDispositivosFiltrados.Add(dr.Item("IdLinea"))
            Next

        End If
    End Sub

    Public Function RetornarFiltrarDataTableAgregarALista(ByVal dt As DataTable, ByVal filter As String, ByVal sort As String) As DataTable
        Dim DataTable As New DataTable
        DataTable = dt.Copy()
        DataTable.Clear()

        If Not dt Is Nothing Then
            Dim rows As DataRow()
            ' sort and filter data
            rows = dt.Select(filter, sort)
            For Each dr As DataRow In rows
                DataTable.ImportRow(dr)
            Next
            Return DataTable
        End If
    End Function

    Function RetornoDataTable(ByVal dt As DataTable, ByVal filter As String, ByVal sort As String) As DataTable
        If Not dt Is Nothing Then
            listaDispositivosFiltrados = New List(Of String)
            Dim rows As DataRow()

            Dim dtNew As DataTable

            ' copy table structure
            dtNew = dt.Clone()

            ' sort and filter data
            rows = dt.Select(filter, sort)

            ' fill dtNew with selected rows

            For Each dr As DataRow In rows
                dtNew.ImportRow(dr)
                listaDispositivosFiltrados.Add(dr.Item(10))
            Next

            ' return filtered dt
            Return dtNew
        End If
    End Function


    Public Sub CargarDetalle(ByVal pListaCaravanas As List(Of String))
        'CARGAR DETALLE
        'Variables Para Cargar Detalles
        listaRazas = New List(Of String)
        listaCruzas = New List(Of String)
        listaPropietarios = New List(Of String)
        listaUbicacion = New List(Of String)
        listaTenencia = New List(Of String)
        DicosePropietario = ""
        DicoseUbicacion = ""
        DicoseTenencia = ""

        DataGrid.DataSource = Nothing
        DataGrid.Rows.Clear()
        DataGrid.Refresh()

        Dim lote As Integer = 1
        Dim loteNumInterno As Integer = 0
        Me.cboLote.Items.Clear()
        Me.cboLote.Items.Add("")
        Me.cboLote.Items.Add(lote)
        Me.cboPropietario.Items.Clear()
        Me.cboPropietario.Items.Add("")
        Me.cboUbicacion.Items.Clear()
        Me.cboUbicacion.Items.Add("")
        Me.cboTenencia.Items.Clear()
        Me.cboTenencia.Items.Add("")


        If opcionDatos = 1 Then


            Dim RazaAnterior As String = ""
            If Not pListaCaravanas Is Nothing Then
                If pListaCaravanas.Count > 0 Then
                    'BARRA DE PROGRESO
                    ProgressBar1.Value = 0
                    ProgressBar1.Minimum = 0
                    ProgressBar1.Maximum = pListaCaravanas.Count - 1

                    Dim i As Integer = 0
                    For i = 0 To pListaCaravanas.Count - 1
                        Dim unaCaravana As String = pListaCaravanas.Item(i)
                        Me.DataGrid.Rows.Add()
                        'NUMERACION LINEAS
                        Me.DataGrid.Item("IdLinea", i).Value = i + 1
                        ProgressBar1.Value = i
                        If unaCaravana = "000000000000000" Then
                            DataGrid.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                            loteNumInterno = 0
                            lote += 1
                            Me.cboLote.Items.Add(lote)
                        Else
                            loteNumInterno += 1
                            Me.DataGrid.Item("chk", i).Value = False
                            Me.DataGrid.Item("fecha", i).Value() = Me.dtpFecha.Value.ToString("dd/MM/yyyy")
                            Me.DataGrid.Item("lote", i).Value = lote
                            Me.DataGrid.Item("numeracion", i).Value = loteNumInterno
                            Me.DataGrid.Item("dispositivo", i).Value() = unaCaravana
                            'Buscar dispositivo

                            Dim unaCaravanaRow As DataRow = unafachada.BuscarDispositivo(unaCaravana)
                            If Not unaCaravanaRow Is Nothing Then
                                Dim unPotreros As DataRow
                                Try
                                    unPotreros = unafachada.BuscarPotreros(unaCaravanaRow.Item("ani_IdPotrero"), dtPotreros)
                                    Me.DataGrid.Item("potrero", i).Value() = unPotreros.Item("pot_nombre")
                                    Me.DataGrid.Item("idpotrero", i).Value() = unaCaravanaRow.Item("ani_IdPotrero")
                                Catch ex As Exception
                                    Me.DataGrid.Item("idpotrero", i).Value() = 3
                                    Me.DataGrid.Item("potrero", i).Value() = "N/A"
                                End Try

                                Me.DataGrid.Item("raza", i).Value() = unaCaravanaRow.Item("ani_raza")
                                If Not DataGrid.Item("raza", i).Value() Is Nothing Then
                                    If DataGrid.Item("raza", i).Value().ToString.Length > 0 Then
                                        If BuscarEnLista(DataGrid.Item("raza", i).Value(), listaRazas) = False Then
                                            listaRazas.Add(DataGrid.Item("raza", i).Value())
                                            Me.cboRaza.Items.Add(DataGrid.Item("raza", i).Value())
                                        End If
                                    End If
                                End If


                                Me.DataGrid.Item("cruza", i).Value() = unaCaravanaRow.Item("ani_cruza")
                                If Not DataGrid.Item("cruza", i).Value() Is Nothing Then
                                    If DataGrid.Item("cruza", i).Value().ToString.Length > 0 Then
                                        If BuscarEnLista(DataGrid.Item("cruza", i).Value(), listaCruzas) = False Then
                                            listaCruzas.Add(DataGrid.Item("cruza", i).Value())
                                            Me.cboCruza.Items.Add(DataGrid.Item("cruza", i).Value())
                                        End If
                                    End If
                                End If



                                Me.DataGrid.Item("sexo", i).Value() = unaCaravanaRow.Item("ani_sexo")
                                Dim Meses As Integer
                                Try
                                    Meses = DateDiff(DateInterval.Month, unaCaravanaRow.Item("ani_fechaNac"), Today)
                                Catch ex As Exception
                                    Meses = 0
                                End Try
                                If Meses > 500 Then
                                    Meses = 0
                                End If
                                Me.DataGrid.Item("edad", i).Value() = Meses

                                Dim DiasUbicacionActual As Integer
                                Try
                                    DiasUbicacionActual = DateDiff(DateInterval.Day, unaCaravanaRow.Item("ani_fecha_ubicacion_Actual"), Today)
                                Catch ex As Exception
                                    DiasUbicacionActual = 0
                                End Try
                                Me.DataGrid.Item("DiasUbicacionActual", i).Value() = DiasUbicacionActual


                                If Not unaCaravanaRow.Item("ani_propietario") Is Nothing Then
                                    If unaCaravanaRow.Item("ani_propietario").ToString.Length > 0 Then
                                        If unaCaravanaRow.Item("ani_propietario") <> DicosePropietario Then
                                            If BuscarEnLista(unaCaravanaRow.Item("ani_propietario"), listaPropietarios) = False Then
                                                listaPropietarios.Add(unaCaravanaRow.Item("ani_propietario"))
                                                Me.cboPropietario.Items.Add(unaCaravanaRow.Item("ani_propietario"))
                                            End If

                                        End If
                                    End If
                                End If
                                Try
                                    DicosePropietario = unaCaravanaRow.Item("ani_propietario")
                                Catch ex As Exception

                                End Try

                                If Not unaCaravanaRow.Item("ani_ubicacion") Is Nothing Then
                                    If unaCaravanaRow.Item("ani_ubicacion").ToString.Length > 0 Then
                                        If unaCaravanaRow.Item("ani_ubicacion") <> DicoseUbicacion Then
                                            If BuscarEnLista(unaCaravanaRow.Item("ani_ubicacion"), listaUbicacion) = False Then
                                                listaUbicacion.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                                Me.cboUbicacion.Items.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                            End If

                                        End If
                                    End If
                                End If
                                Try
                                    DicoseUbicacion = unaCaravanaRow.Item("ani_ubicacion")
                                Catch ex As Exception

                                End Try

                                If Not unaCaravanaRow.Item("ani_tenencia") Is Nothing Then
                                    If unaCaravanaRow.Item("ani_tenencia").ToString.Length > 0 Then
                                        If unaCaravanaRow.Item("ani_tenencia") <> DicoseTenencia Then
                                            If BuscarEnLista(unaCaravanaRow.Item("ani_tenencia"), listaTenencia) = False Then
                                                listaTenencia.Add(unaCaravanaRow.Item("ani_tenencia"))
                                                Me.cboTenencia.Items.Add(unaCaravanaRow.Item("ani_tenencia"))
                                            End If

                                        End If
                                    End If
                                End If

                                Try
                                    DicoseTenencia = unaCaravanaRow.Item("ani_tenencia")
                                Catch ex As Exception

                                End Try


                                Me.DataGrid.Item("propietario", i).Value() = unaCaravanaRow.Item("ani_propietario")
                                Me.DataGrid.Item("ubicacion", i).Value() = unaCaravanaRow.Item("ani_ubicacion")
                                Me.DataGrid.Item("tenencia", i).Value() = unaCaravanaRow.Item("ani_tenencia")
                                Me.DataGrid.Item("vida", i).Value() = unaCaravanaRow.Item("ani_vida")
                                Me.DataGrid.Item("trazabilidad", i).Value() = unaCaravanaRow.Item("ani_trazabilidad")

                            Else
                                Me.DataGrid.Item("raza", i).Value() = "N/A"
                                Me.DataGrid.Item("cruza", i).Value() = "N/A"
                                Me.DataGrid.Item("sexo", i).Value() = "N/A"
                                Me.DataGrid.Item("edad", i).Value() = "0"
                                Me.DataGrid.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon

                            End If
                        End If

                    Next
                Else
                    ' MsgBox("Sin Detalle")
                End If
            End If
        End If

        If opcionDatos = 2 Then
            'BASE DE DATOS
            Dim unDtAnimales As DataTable = unafachada.TodosLosAnimales
            lote = 1
            If unDtAnimales.Rows.Count > 0 Then
                'BARRA DE PROGRESO
                ProgressBar1.Value = 0
                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = unDtAnimales.Rows.Count - 1

                Dim i As Integer = 0
                Do While i < unDtAnimales.Rows.Count
                    Me.DataGrid.Rows.Add()
                    'NUMERACION LINEAS
                    Me.DataGrid.Item("IdLinea", i).Value = i + 1
                    ProgressBar1.Value = i
                    Dim unaCaravanaRow As DataRow = unDtAnimales.Rows(i)
                    loteNumInterno += 1
                    Me.DataGrid.Item("chk", i).Value = False
                    Me.DataGrid.Item("fecha", i).Value() = Me.dtpFecha.Value.ToString("dd/MM/yyyy")
                    Me.DataGrid.Item("lote", i).Value = lote
                    Me.DataGrid.Item("numeracion", i).Value = loteNumInterno
                    Me.DataGrid.Item("dispositivo", i).Value() = unaCaravanaRow.Item("ani_Dispositivo")
                    Dim unPotreros As DataRow
                    Try
                        unPotreros = unafachada.BuscarPotreros(unaCaravanaRow.Item("ani_IdPotrero"), dtPotreros)
                        Me.DataGrid.Item("potrero", i).Value() = unPotreros.Item("pot_nombre")
                        Me.DataGrid.Item("idpotrero", i).Value() = unaCaravanaRow.Item("ani_IdPotrero")
                    Catch ex As Exception
                        Me.DataGrid.Item("idpotrero", i).Value() = 3
                        Me.DataGrid.Item("potrero", i).Value() = "N/A"
                    End Try

                    Me.DataGrid.Item("raza", i).Value() = unaCaravanaRow.Item("ani_raza")
                    If Not DataGrid.Item("raza", i).Value() Is Nothing Then
                        If DataGrid.Item("raza", i).Value().ToString.Length > 0 Then
                            If BuscarEnLista(DataGrid.Item("raza", i).Value(), listaRazas) = False Then
                                listaRazas.Add(DataGrid.Item("raza", i).Value())
                                Me.cboRaza.Items.Add(DataGrid.Item("raza", i).Value())
                            End If
                        End If
                    End If


                    Me.DataGrid.Item("cruza", i).Value() = unaCaravanaRow.Item("ani_cruza")
                    If Not DataGrid.Item("cruza", i).Value() Is Nothing Then
                        If DataGrid.Item("cruza", i).Value().ToString.Length > 0 Then
                            If BuscarEnLista(DataGrid.Item("cruza", i).Value(), listaCruzas) = False Then
                                listaCruzas.Add(DataGrid.Item("cruza", i).Value())
                                Me.cboCruza.Items.Add(DataGrid.Item("cruza", i).Value())
                            End If
                        End If
                    End If

                    Me.DataGrid.Item("sexo", i).Value() = unaCaravanaRow.Item("ani_sexo")

                    Dim DiasUbicacionActual As Integer
                    Try
                        DiasUbicacionActual = DateDiff(DateInterval.Day, unaCaravanaRow.Item("ani_fecha_ubicacion_Actual"), Today)
                    Catch ex As Exception
                        DiasUbicacionActual = 0
                    End Try
                    Me.DataGrid.Item("DiasUbicacionActual", i).Value() = DiasUbicacionActual

                    Dim Meses As Integer
                    Try
                        Meses = DateDiff(DateInterval.Month, unaCaravanaRow.Item("ani_fechaNac"), Today)
                    Catch ex As Exception
                        Meses = 0
                    End Try
                    If Meses > 500 Then
                        Meses = 0
                    End If

                    Me.DataGrid.Item("edad", i).Value() = Meses
                    If Not unaCaravanaRow.Item("ani_propietario") Is Nothing Then
                        If unaCaravanaRow.Item("ani_propietario").ToString.Length > 0 Then
                            If unaCaravanaRow.Item("ani_propietario") <> DicosePropietario Then
                                If BuscarEnLista(unaCaravanaRow.Item("ani_propietario"), listaPropietarios) = False Then
                                    listaPropietarios.Add(unaCaravanaRow.Item("ani_propietario"))
                                    Me.cboPropietario.Items.Add(unaCaravanaRow.Item("ani_propietario"))
                                End If

                            End If
                        End If
                    End If
                    Try
                        DicosePropietario = unaCaravanaRow.Item("ani_propietario")
                    Catch ex As Exception

                    End Try

                    If Not unaCaravanaRow.Item("ani_ubicacion") Is Nothing Then
                        If unaCaravanaRow.Item("ani_ubicacion").ToString.Length > 0 Then
                            If unaCaravanaRow.Item("ani_ubicacion") <> DicoseUbicacion Then
                                If BuscarEnLista(unaCaravanaRow.Item("ani_ubicacion"), listaUbicacion) = False Then
                                    listaUbicacion.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                    Me.cboUbicacion.Items.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                End If

                            End If
                        End If
                    End If
                    Try
                        DicoseUbicacion = unaCaravanaRow.Item("ani_ubicacion")
                    Catch ex As Exception

                    End Try

                    If Not unaCaravanaRow.Item("ani_tenencia") Is Nothing Then
                        If unaCaravanaRow.Item("ani_tenencia").ToString.Length > 0 Then
                            If unaCaravanaRow.Item("ani_tenencia") <> DicoseTenencia Then
                                If BuscarEnLista(unaCaravanaRow.Item("ani_tenencia"), listaTenencia) = False Then
                                    listaTenencia.Add(unaCaravanaRow.Item("ani_tenencia"))
                                    Me.cboTenencia.Items.Add(unaCaravanaRow.Item("ani_tenencia"))
                                End If

                            End If
                        End If
                    End If

                    Try
                        DicoseTenencia = unaCaravanaRow.Item("ani_tenencia")
                    Catch ex As Exception

                    End Try


                    Me.DataGrid.Item("propietario", i).Value() = unaCaravanaRow.Item("ani_propietario")
                    Me.DataGrid.Item("ubicacion", i).Value() = unaCaravanaRow.Item("ani_ubicacion")
                    Me.DataGrid.Item("tenencia", i).Value() = unaCaravanaRow.Item("ani_tenencia")
                    Me.DataGrid.Item("vida", i).Value() = unaCaravanaRow.Item("ani_vida")
                    Me.DataGrid.Item("trazabilidad", i).Value() = unaCaravanaRow.Item("ani_trazabilidad")
                    i += 1

                Loop

            End If
        End If

        If opcionDatos = 3 Then
            'LECTURAS TIEMPO REAL
            If Not pListaCaravanas Is Nothing Then
                If pListaCaravanas.Count > 0 Then
                    'BARRA DE PROGRESO
                    ProgressBar1.Value = 0
                    ProgressBar1.Minimum = 0
                    ProgressBar1.Maximum = pListaCaravanas.Count - 1

                    Me.cboLote.Items.Clear()
                    Me.cboLote.Items.Add("")
                    Dim i As Integer = 0
                    Dim loteAnterior As String = ""
                    For i = 0 To pListaCaravanas.Count - 1
                        ProgressBar1.Value = i
                        Dim linea As String = pListaCaravanas.Item(i)
                        Dim Palabras As String() = linea.Split(New Char() {";"c})
                        Dim unaCaravana As String = Palabras(1)
                        Dim unLote As String = Palabras(0)
                        Me.DataGrid.Rows.Add()
                        'NUMERACION LINEAS
                        Me.DataGrid.Item("IdLinea", i).Value = i + 1

                        If unLote <> loteAnterior Then
                            If unLote <> "nuevo" Then
                                Me.cboLote.Items.Add(unLote)
                            End If
                            loteAnterior = unLote
                        End If

                        If unaCaravana = "000000000000000" Then
                            DataGrid.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                            loteNumInterno = 0
                        Else
                            loteNumInterno += 1
                            Me.DataGrid.Item("chk", i).Value = False
                            Me.DataGrid.Item("fecha", i).Value() = Me.dtpFecha.Value.ToString("dd/MM/yyyy")
                            Me.DataGrid.Item("lote", i).Value = unLote
                            Me.DataGrid.Item("numeracion", i).Value = loteNumInterno
                            Me.DataGrid.Item("dispositivo", i).Value() = unaCaravana
                            'Buscar dispositivo

                            Dim unaCaravanaRow As DataRow = unafachada.BuscarDispositivo(unaCaravana)
                            If Not unaCaravanaRow Is Nothing Then
                                Dim unPotreros As DataRow
                                Try
                                    unPotreros = unafachada.BuscarPotreros(unaCaravanaRow.Item("ani_IdPotrero"), dtPotreros)
                                    Me.DataGrid.Item("potrero", i).Value() = unPotreros.Item("pot_nombre")
                                    Me.DataGrid.Item("idpotrero", i).Value() = unaCaravanaRow.Item("ani_IdPotrero")
                                Catch ex As Exception
                                    Me.DataGrid.Item("idpotrero", i).Value() = 3
                                    Me.DataGrid.Item("potrero", i).Value() = "N/A"
                                End Try


                                Me.DataGrid.Item("raza", i).Value() = unaCaravanaRow.Item("ani_raza")
                                If Not DataGrid.Item("raza", i).Value() Is Nothing Then
                                    If DataGrid.Item("raza", i).Value().ToString.Length > 0 Then
                                        If BuscarEnLista(DataGrid.Item("raza", i).Value(), listaRazas) = False Then
                                            listaRazas.Add(DataGrid.Item("raza", i).Value())
                                            Me.cboRaza.Items.Add(DataGrid.Item("raza", i).Value())
                                        End If
                                    End If
                                End If


                                Me.DataGrid.Item("cruza", i).Value() = unaCaravanaRow.Item("ani_cruza")
                                If Not DataGrid.Item("cruza", i).Value() Is Nothing Then
                                    If DataGrid.Item("cruza", i).Value().ToString.Length > 0 Then
                                        If BuscarEnLista(DataGrid.Item("cruza", i).Value(), listaCruzas) = False Then
                                            listaCruzas.Add(DataGrid.Item("cruza", i).Value())
                                            Me.cboCruza.Items.Add(DataGrid.Item("cruza", i).Value())
                                        End If
                                    End If
                                End If

                                Me.DataGrid.Item("sexo", i).Value() = unaCaravanaRow.Item("ani_sexo")
                                Dim Meses As Integer
                                Try
                                    Meses = DateDiff(DateInterval.Month, unaCaravanaRow.Item("ani_fechaNac"), Today)
                                Catch ex As Exception
                                    Meses = 0
                                End Try
                                If Meses > 500 Then
                                    Meses = 0
                                End If
                                Me.DataGrid.Item("edad", i).Value() = Meses

                                Dim DiasUbicacionActual As Integer
                                Try
                                    DiasUbicacionActual = DateDiff(DateInterval.Day, unaCaravanaRow.Item("ani_fecha_ubicacion_Actual"), Today)
                                Catch ex As Exception
                                    DiasUbicacionActual = 0
                                End Try
                                Me.DataGrid.Item("DiasUbicacionActual", i).Value() = DiasUbicacionActual


                                If Not unaCaravanaRow.Item("ani_propietario") Is Nothing Then
                                    If unaCaravanaRow.Item("ani_propietario").ToString.Length > 0 Then
                                        If unaCaravanaRow.Item("ani_propietario") <> DicosePropietario Then
                                            If BuscarEnLista(unaCaravanaRow.Item("ani_propietario"), listaPropietarios) = False Then
                                                listaPropietarios.Add(unaCaravanaRow.Item("ani_propietario"))
                                                Me.cboPropietario.Items.Add(unaCaravanaRow.Item("ani_propietario"))
                                            End If

                                        End If
                                    End If
                                End If
                                Try
                                    DicosePropietario = unaCaravanaRow.Item("ani_propietario")
                                Catch ex As Exception

                                End Try

                                If Not unaCaravanaRow.Item("ani_ubicacion") Is Nothing Then
                                    If unaCaravanaRow.Item("ani_ubicacion").ToString.Length > 0 Then
                                        If unaCaravanaRow.Item("ani_ubicacion") <> DicoseUbicacion Then
                                            If BuscarEnLista(unaCaravanaRow.Item("ani_ubicacion"), listaUbicacion) = False Then
                                                listaUbicacion.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                                Me.cboUbicacion.Items.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                            End If

                                        End If
                                    End If
                                End If
                                Try
                                    DicoseUbicacion = unaCaravanaRow.Item("ani_ubicacion")
                                Catch ex As Exception

                                End Try

                                If Not unaCaravanaRow.Item("ani_tenencia") Is Nothing Then
                                    If unaCaravanaRow.Item("ani_tenencia").ToString.Length > 0 Then
                                        If unaCaravanaRow.Item("ani_tenencia") <> DicoseTenencia Then
                                            If BuscarEnLista(unaCaravanaRow.Item("ani_tenencia"), listaTenencia) = False Then
                                                listaTenencia.Add(unaCaravanaRow.Item("ani_tenencia"))
                                                Me.cboTenencia.Items.Add(unaCaravanaRow.Item("ani_tenencia"))
                                            End If

                                        End If
                                    End If
                                End If

                                Try
                                    DicoseTenencia = unaCaravanaRow.Item("ani_tenencia")
                                Catch ex As Exception

                                End Try


                                Me.DataGrid.Item("propietario", i).Value() = unaCaravanaRow.Item("ani_propietario")
                                Me.DataGrid.Item("ubicacion", i).Value() = unaCaravanaRow.Item("ani_ubicacion")
                                Me.DataGrid.Item("tenencia", i).Value() = unaCaravanaRow.Item("ani_tenencia")
                                Me.DataGrid.Item("vida", i).Value() = unaCaravanaRow.Item("ani_vida")
                                Me.DataGrid.Item("trazabilidad", i).Value() = unaCaravanaRow.Item("ani_trazabilidad")

                            Else
                                Me.DataGrid.Item("raza", i).Value() = "N/A"
                                Me.DataGrid.Item("cruza", i).Value() = "N/A"
                                Me.DataGrid.Item("sexo", i).Value() = "N/A"
                                Me.DataGrid.Item("edad", i).Value() = "0"
                                Me.DataGrid.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                            End If

                        End If
                    Next


                Else
                    ' MsgBox("Sin Detalle")
                End If
            End If
        End If

        lbDescarga.Visible = False
    End Sub



    Private Sub IUIngresoEventos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Origen 
        Me.cboOrigen.Items.Clear()
        Me.cboOrigen.Items.Add("")
        Me.cboOrigen.Items.Add("Desde Baston")
        Me.cboOrigen.Items.Add("Base de datos")
        Me.cboOrigen.Items.Add("Armado de lotes")
        Me.cboOrigen.Items.Add("Desde Txt")

        Me.cboOrigen.SelectedIndex = 1
        'Potreros
        dtPotreros = unafachada.TodosLosPotrerosTable
        CargarComboDesdeDataTable(Me.cboPotreros, dtPotreros, "pot_nombre")
        CargarComboDesdeDataTable(Me.cboPotreroDestino, dtPotreros, "pot_nombre")

        'COMBO EVENTOS
        dtListaEventos = unafachada.TodosLasListasEventos
        If CargarComboDesdeDataTable(Me.cboListaEventos, dtListaEventos, "eve_nombre") = False Then
            vIdEvento = 0
        End If

        Me.cboListaEventos.SelectedIndex = 1

        'COMBO EVENTOS LINEAS
        dtListaEventosLineas = unafachada.TodosLasListasEventosLineas(vIdEvento)
        CargarComboDesdeDataTable(Me.cboListaEventosLineas, dtListaEventosLineas, "eve_lin_nombre")
        ''Cargar Combo DatagridView
        'CargarComboDesdeDataTableDatagridView(Me.eventoLin, dtListaEventosLineas, 2)

        Me.cboListaEventosLineas.SelectedIndex = 1


        'Razas
        dtRaza = unafachada.TodosLasRazasTable

        'COMBO SEXO
        Me.cboSexo.Items.Clear()
        Me.cboSexo.Items.Add("")
        Me.cboSexo.Items.Add("Macho")
        Me.cboSexo.Items.Add("Hembra")
        Me.cboSexo.SelectedIndex = -1
        Me.dtpFecha.Value = Today
        ''SERIAL PORTS
        'GetSerialPortNames()
        CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR P
    End Sub

    Public Sub cargarTitulos()
        Me.cboOperaciones.Items.Clear()
        Dim dsOperaciones As DataSet = unafachada.TodasLasOperaciones
        If dsOperaciones.Tables(0).Rows.Count > 0 Then
            For Each unaFila As DataRow In dsOperaciones.Tables(0).Rows
                Me.cboOperaciones.Items.Add(unaFila("ope_nombre"))
            Next
        End If
        Me.cboOperaciones.SelectedIndex = -1
    End Sub

    Public Sub NuevaOperacion(ByVal pCargarAnimales As Boolean, ByVal pOrigenDatos As Integer)

        If pCargarAnimales = True Then
            CargarAnimales(pOrigenDatos)
        End If

        ' LimpiarSeleccion()
    End Sub

    Public Sub GuardarOperacion()
        Dim banderaCabezal As Boolean = False
        Dim banderaDetalle As Boolean = False
        Dim GuardarMovimientos As Boolean
        Dim ActualizarAnimales As Boolean
        Dim guardarCabezal As Boolean = False
        Dim tipoBaseDatos As String
        'If pGuardarComo = True Then
        '    titulo = unafachada.TraeridOrdenProduccion & "- " & Me.dtpFecha.Value.ToString("dd/MM/yyyy") & " - "
        'End If

        If Me.txtSeleccionados.Text > 0 Then
            tipoBaseDatos = unafachada.TipoBaseDatos
            Dim i As Integer
            While i < DataGrid.Rows.Count
                ActualizarAnimales = False
                Dim valido As Boolean = Me.DataGrid.Item("chk", i).Value()
                If valido = True Then
                    Dim DetPotreroIdDes As String = Me.DataGrid.Item("idpotreroDestino", i).Value()
                    If DetPotreroIdDes Is Nothing Then
                        DetPotreroIdDes = 0
                    End If
                    Dim DetFecha As String
                    Dim fecha As Date = Me.DataGrid.Item("fecha", i).Value()
                    DetFecha = fecha.ToString("dd/MM/yyyy")
                    If tipoBaseDatos = "MySQL" Then
                        DetFecha = fecha.ToString("yyyy/MM/dd")
                    End If

                    Dim DetLote As String = Me.DataGrid.Item("lote", i).Value()
                    Dim DetOrd As Integer = Me.DataGrid.Item("numeracion", i).Value()
                    Dim DetIdEvento As Integer = Me.DataGrid.Item("IdEvento", i).Value()
                    Dim DetEvento As String = Me.DataGrid.Item("evento", i).Value()
                    Dim DetIdEventoLin As Integer = Me.DataGrid.Item("IdEventoLin", i).Value()
                    Dim DetEventoLin As String = Me.DataGrid.Item("eventoLin", i).Value()
                    Dim DetDispositivo As String = Me.DataGrid.Item("dispositivo", i).Value()
                    Dim Detuni As String = Me.DataGrid.Item("uni", i).Value() '
                    If Detuni Is Nothing Then
                        Detuni = "0"
                    End If
                    Dim Detcnt As Decimal = Me.DataGrid.Item("cnt", i).Value()
                    Dim DetPotreroOri As String = Me.DataGrid.Item("potrero", i).Value() '
                    If DetPotreroOri Is Nothing Then
                        DetPotreroOri = ""
                    End If
                    Dim DetPotreroDes As String = Me.DataGrid.Item("potreroDes", i).Value() '
                    If DetPotreroDes Is Nothing Then
                        DetPotreroDes = ""
                    End If

                    Dim DetPotreroIdOri As String = Me.DataGrid.Item("idpotrero", i).Value() '
                    If DetPotreroIdOri Is Nothing Then
                        DetPotreroIdOri = 0
                    End If

                    Dim DetDicoseUbicacionOri As String
                    Try
                        DetDicoseUbicacionOri = Me.DataGrid.Item("ubicacion", i).Value()
                    Catch ex As Exception
                        DetDicoseUbicacionOri = ""
                    End Try


                    Dim DetDicoseUbicacionDes As String = Me.DataGrid.Item("ubicacionDes", i).Value() '
                    If DetDicoseUbicacionDes Is Nothing Then
                        DetDicoseUbicacionDes = ""
                    End If

                    Dim DetDicosePropietario As String = Me.DataGrid.Item("propietario", i).Value() '
                    If DetDicosePropietario Is Nothing Then
                        DetDicosePropietario = ""
                    End If


                    'CON NUMERO ENVIADO 
                    'Dim cadenaConexion As String = "INSERT INTO operacionesLineas (ope_lin_id,ope_lin_idCabezal,ope_lin_fecha,ope_lin_lote, ope_lin_num, ope_lin_idevento,ope_lin_evento,ope_lin_ideventoLin,ope_lin_eventoLin,ope_lin_dispositivo,ope_lin_uni,ope_lin_cnt,ope_lin_potreroIdOri,ope_lin_potreroOri,ope_lin_potreroIdDes,ope_lin_potreroDes,ope_lin_dicoseCampoOri,ope_lin_dicoseCampoDes) VALUES (" & "1" & "," & Me.txtCodigo.Text & "," & "'" & DetFecha & "'" & "," & DetLote & "," & DetOrd & "," & DetIdEvento & "," & "'" & DetEvento & "'" & "," & DetIdEventoLin & "," & "'" & DetEventoLin & "'" & "," & "'" & DetDispositivo & "'" & "," & "'" & Detuni & "'" & "," & Detcnt & "," & DetPotreroIdOri & "," & "'" & DetPotreroOri & "'" & "," & DetPotreroIdDes & "," & "'" & DetPotreroDes & "'" & "," & "'" & DetDicoseUbicacionOri & "'" & "," & "'" & DetDicoseUbicacionDes & "'" & ")"
                    Dim cadenaConexion As String = "INSERT INTO operacionesLineas (ope_lin_idCabezal,ope_lin_fecha,ope_lin_lote, ope_lin_num, ope_lin_idevento,ope_lin_evento,ope_lin_ideventoLin,ope_lin_eventoLin,ope_lin_dispositivo,ope_lin_uni,ope_lin_cnt,ope_lin_potreroIdOri,ope_lin_potreroOri,ope_lin_potreroIdDes,ope_lin_potreroDes,ope_lin_dicoseCampoOri,ope_lin_dicoseCampoDes,ope_lin_dicosePropietario) VALUES (" & Me.txtCodigo.Text & "," & "'" & DetFecha & "'" & "," & "'" & DetLote & "'" & "," & DetOrd & "," & DetIdEvento & "," & "'" & DetEvento & "'" & "," & DetIdEventoLin & "," & "'" & DetEventoLin & "'" & "," & "'" & DetDispositivo & "'" & "," & "'" & Detuni & "'" & "," & Detcnt & "," & DetPotreroIdOri & "," & "'" & DetPotreroOri & "'" & "," & DetPotreroIdDes & "," & "'" & DetPotreroDes & "'" & "," & "'" & DetDicoseUbicacionOri & "'" & "," & "'" & DetDicoseUbicacionDes & "'" & "," & "'" & DetDicosePropietario & "'" & ")"
                    GuardarMovimientos = False
                    'SECCION MOVIMIENTOS 
                    Select Case vIdEvento
                        Case 4
                            'MOVIMIENTOS
                            If DetPotreroIdDes <> 0 And DetPotreroIdDes <> DetPotreroIdOri Then
                                GuardarMovimientos = True
                                ActualizarAnimales = True
                            Else
                                GuardarMovimientos = False
                            End If

                        Case Else
                            GuardarMovimientos = True
                    End Select

                    If GuardarMovimientos = True Then
                        If ActualizarAnimales Then
                            Dim cadenaActualizaAnimales As String = "UPDATE animal SET ani_IdPotrero =" & DetPotreroIdDes & ", ani_potrero =" & "'" & DetPotreroDes & "'" & " WHERE animal.ani_dispositivo=" & "'" & DetDispositivo & "'"
                            banderaDetalle = unafachada.EjecutarConsultaGENERICA(cadenaActualizaAnimales)
                        End If
                        banderaDetalle = unafachada.EjecutarConsultaGENERICA(cadenaConexion)
                        guardarCabezal = True
                    End If

                End If
                i += 1
            End While

            If guardarCabezal = True Then
                'GUARDAR CABEZAL
                Dim CabFecha As Date = Me.dtpFecha.Value
                If tipoBaseDatos = "MySQL" Then
                    CabFecha = dtpFecha.Value.ToString("yyyy/MM/dd")
                End If
                Dim CabNombre As String = Me.dtpFecha.Value.ToString("dd/MM/yyyy") & " - " & Me.cboListaEventos.SelectedItem
                Dim CabAnimales As String = Me.txtSeleccionados.Text
                Dim CabTipo As String = Me.txtTipoIngreso.Text
                Dim cabEvento As String = Me.cboListaEventos.SelectedItem
                Dim cabIdEvento As Integer = vIdEvento
                'Dim cadenaConexionCabezal As String = "INSERT INTO operaciones (ope_id,ope_fecha,ope_nombre,ope_Idevento,ope_evento,ope_cantAnimales,ope_anula,ope_tipo) VALUES (" & "1" & "," & "'" & CabFecha & "'" & "," & "'" & Cabnombre & "'" & "," & cabIdEvento & "," & "'" & cabEvento & "'" & "," & CabAnimales & "," & "'" & Nothing & "'" & "," & "'" & CabTipo & "'" & ")"
                Dim cadenaConexionCabezal As String = "INSERT INTO operaciones (ope_fecha,ope_nombre,ope_Idevento,ope_evento,ope_cantAnimales,ope_anula,ope_tipo) VALUES (" & "'" & CabFecha & "'" & "," & "'" & CabNombre & "'" & "," & cabIdEvento & "," & "'" & cabEvento & "'" & "," & CabAnimales & "," & "'" & Nothing & "'" & "," & "'" & CabTipo & "'" & ")"
                banderaCabezal = unafachada.EjecutarConsultaGENERICA(cadenaConexionCabezal)
            End If
            If banderaCabezal And banderaDetalle Then
                MsgBox("Guardado Correctamente")
                If ActualizarAnimales = True Then
                    NuevaOperacion(True, opcionDatos)
                Else
                    NuevaOperacion(False, opcionDatos)
                End If
            Else
                MsgBox("Error Al Guaradar")
            End If
        Else
            MsgBox("Debe Seleccionar al menos un animal")

        End If

    End Sub

    Public Sub CargarOperacion(ByVal pCodigo As Integer, ByVal pCabezalOperaciones As DataRow)
        'Cargar COMBO TITULOS 
        Me.cboOperaciones.Items.Clear()
        Dim dsOperaciones As DataSet = unafachada.TodasLasOperaciones
        If dsOperaciones.Tables(0).Rows.Count > 0 Then
            For Each unaFila As DataRow In dsOperaciones.Tables(0).Rows
                Me.cboOperaciones.Items.Add(unaFila("ope_nombre"))
            Next
        End If

        txtCodigo.Text = pCabezalOperaciones("ope_id")
        dtpFecha.Value = pCabezalOperaciones("ope_fecha")
        txtSeleccionados.Text = pCabezalOperaciones("ope_cantAnimales")
        Dim anula As String
        Try
            anula = pCabezalOperaciones("ope_anula")
        Catch ex As Exception
            anula = ""
        End Try
        Me.txtTipoIngreso.Text = pCabezalOperaciones("ope_tipo")

        'CARGAR DETALLE
        Dim unDsDetalleOperacion As DataSet = unafachada.BuscarDetalleOperacion(pCodigo)
        If Not unDsDetalleOperacion Is Nothing Then
            DataGrid.DataSource = Nothing
            DataGrid.Rows.Clear()
            DataGrid.Refresh()
            If unDsDetalleOperacion.Tables(0).Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To unDsDetalleOperacion.Tables(0).Rows.Count - 1
                    Dim unaFila As DataRow = unDsDetalleOperacion.Tables(0).Rows(i)
                    Me.DataGrid.Rows.Add()
                    Me.DataGrid.Item("IdLinea", i).Value() = unaFila("ope_lin_id")
                    Me.DataGrid.Item("fecha", i).Value() = unaFila("ope_lin_fecha")
                    Me.DataGrid.Item("lote", i).Value() = unaFila("ope_lin_lote")
                    Me.DataGrid.Item("numeracion", i).Value() = unaFila("ope_lin_num")
                    Me.DataGrid.Item("IdEvento", i).Value() = unaFila("ope_lin_idevento")
                    Me.DataGrid.Item("evento", i).Value() = unaFila("ope_lin_evento")
                    Me.DataGrid.Item("IdEventoLin", i).Value() = unaFila("ope_lin_ideventoLin")
                    Me.DataGrid.Item("eventoLin", i).Value() = unaFila("ope_lin_eventoLin")
                    Me.DataGrid.Item("dispositivo", i).Value() = unaFila("ope_lin_dispositivo")
                    Me.DataGrid.Item("uni", i).Value() = unaFila("ope_lin_uni")
                    Me.DataGrid.Item("cnt", i).Value() = unaFila("ope_lin_cnt")
                    Me.DataGrid.Item("potrero", i).Value() = unaFila("ope_lin_potreroOri")
                    Me.DataGrid.Item("potreroDes", i).Value() = unaFila("ope_lin_potreroDes")
                    Me.DataGrid.Item("ubicacion", i).Value() = unaFila("ope_lin_dicoseCampoOri")
                    Me.DataGrid.Item("ubicacionDes", i).Value() = unaFila("ope_lin_dicoseCampoDes")
                Next
            Else
                ' MsgBox("Sin Detalle")
            End If
        Else
            MsgBox("Sin Detalle")
        End If
    End Sub


    Public Sub TraerIdOperaciones()
        Try
            Dim unDs As DataSet = unafachada.EjecutarConsultaGENERICADataSet("SELECT MAX(ope_id) FROM operaciones")
            Me.txtCodigo.Text = unDs.Tables(0).Rows(0).Item(0) + 1
        Catch ex As Exception
            Me.txtCodigo.Text = 1
        End Try
    End Sub

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

    Public Function CargarComboDesdeDataTableDatagridView(ByRef pCombo As DataGridViewComboBoxColumn, ByVal pDataTable As DataTable, ByVal pColumna As String) As Boolean
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

    Public Sub LimpiarSeleccion()
        Me.txtSeleccionados.Text = 0
        Dim i As Integer = 0
        If Not DataGrid Is Nothing Then
            If DataGrid.Rows.Count > 0 Then
                While i < DataGrid.Rows.Count
                    Try
                        Me.DataGrid.Item("chk", i).Value = False
                        DataGrid.Rows(i).Cells("IdEventoLin").Value = 0
                        DataGrid.Rows(i).Cells("eventoLin").Value = Nothing
                        DataGrid.Rows(i).Cells("IdEvento").Value = 0
                        DataGrid.Rows(i).Cells("evento").Value = Nothing
                        DataGrid.Rows(i).Cells("potreroDes").Value = Nothing
                        Me.DataGrid.Item("idpotreroDestino", i).Value = 0

                    Catch ex As Exception

                    End Try
                    i += 1
                End While
            End If
        End If
    End Sub

    Public Sub LimpiarFormulario()
        LimpiarSeleccion()
        Me.NudMeses.Value = 200
        Me.lbpotdestino.Visible = False
        Me.cboPotreroDestino.Visible = False
        Try
            Me.cboRaza.SelectedIndex = -1
            Me.cboCruza.SelectedIndex = -1
            Me.cboPotreros.SelectedIndex = 0
            Me.cboPotreroDestino.SelectedIndex = 0
            Me.cboPotreroDestino.SelectedIndex = 0
            ' Dim ultimoLote As Integer = cboLote.SelectedIndex
            'cboLote.SelectedIndex = 0
            'cboLote.SelectedIndex = ultimoLote
            cboSexo.SelectedIndex = 0
            cboPotreros.SelectedIndex = 0
            cboPropietario.SelectedIndex = 0
            cboUbicacion.SelectedIndex = 0
            cboTenencia.SelectedIndex = 0
            Me.txtGuia.Text = ""
            Seleccionar()
        Catch ex As Exception

        End Try


    End Sub


    Public Function BuscarEnListaDispositivo(ByVal pNumeracion As String) As Boolean
        Dim bandera As Boolean = False
        If listaDispositivosFiltrados IsNot Nothing Then
            Dim i As Integer = 0
            Do While i < listaDispositivosFiltrados.Count And Not bandera
                If listaDispositivosFiltrados.Item(i) = pNumeracion Then
                    bandera = True
                End If
                i += 1
            Loop
        Else
            bandera = False
        End If
        Return bandera
    End Function

    Public Function BuscarEnLista(ByVal pItem As String, ByVal pLista As List(Of String)) As Boolean
        Dim bandera As Boolean = False
        If pLista IsNot Nothing Then
            Dim i As Integer = 0
            Do While i < pLista.Count And Not bandera
                If pLista.Item(i) = pItem Then
                    bandera = True
                End If
                i += 1
            Loop
        Else
            bandera = False
        End If
        Return bandera
    End Function


    Public Function AplicarFiltros() As String
        Dim filtros As String = ""
        If Not Me.cboRaza.SelectedItem Is Nothing Then
            If Me.cboRaza.SelectedItem.ToString.Length > 0 Then
                filtros &= "raza=" & "'" & Me.cboRaza.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboSexo.SelectedItem Is Nothing Then
            If Me.cboSexo.SelectedItem.ToString.Length > 0 Then
                filtros &= "sexo=" & "'" & Me.cboSexo.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboLote.SelectedItem Is Nothing Then
            If Me.cboLote.SelectedItem.ToString.Length > 0 Then
                filtros &= "lote=" & "'" & Me.cboLote.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboPotreros.SelectedItem Is Nothing Then
            If Me.cboPotreros.SelectedItem.ToString.Length > 0 Then
                filtros &= "potrero=" & "'" & Me.cboPotreros.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboCruza.SelectedItem Is Nothing Then
            If Me.cboCruza.SelectedItem.ToString.Length > 0 Then
                filtros &= "cruza=" & "'" & Me.cboCruza.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboPropietario.SelectedItem Is Nothing Then
            If Me.cboPropietario.SelectedItem.ToString.Length > 0 Then
                filtros &= "propietario=" & "'" & Me.cboPropietario.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboUbicacion.SelectedItem Is Nothing Then
            If Me.cboUbicacion.SelectedItem.ToString.Length > 0 Then
                filtros &= "ubicacion=" & "'" & Me.cboUbicacion.SelectedItem & "'" & " And "
            End If
        End If

        If Not Me.cboTenencia.SelectedItem Is Nothing Then
            If Me.cboTenencia.SelectedItem.ToString.Length > 0 Then
                filtros &= "tenencia=" & "'" & Me.cboTenencia.SelectedItem & "'" & " And "
            End If
        End If


        If Me.NudMeses.Value > 0 Then
            filtros &= "edad<=" & Me.NudMeses.Value & " And "
        End If

        If filtros.Length > 0 Then
            filtros = filtros.Remove(filtros.Length - 5, 5)
        End If

        If Me.chInvertir.Checked = True Then
            filtros = filtros.Replace("=", "<>")
            filtros = filtros.Replace("edad<<>", "edad<=")
            filtros = filtros.Replace("lote<>", "lote=")

        End If

        Return filtros

    End Function

    Public Function Seleccionar() As Integer
        LimpiarSeleccion()
        If DataGrid.Rows.Count > 0 Then
            Dim primeraFilaLote As Integer = 0
            Dim filtros As String = AplicarFiltros()
            If filtros.Length > 0 Then
                FiltrarDataTableAgregarALista(dtTemporal, filtros, "IdLinea")
                If Not DataGrid Is Nothing Then
                    If DataGrid.Rows.Count > 0 Then
                        Dim i As Integer = 0
                        While i < DataGrid.Rows.Count
                            Dim NumeracionDatagrid As String = DataGrid.Rows(i).Cells("IdLinea").Value
                            If Not NumeracionDatagrid Is Nothing Then
                                If NumeracionDatagrid > 0 Then
                                    'CONTAR ITEMS
                                    If BuscarEnListaDispositivo(NumeracionDatagrid) Then
                                        Me.txtSeleccionados.Text += 1
                                        If primeraFilaLote = 0 Then
                                            primeraFilaLote = i
                                        End If

                                        Me.DataGrid.Item("chk", i).Value = True
                                        If Not Me.cboListaEventos.SelectedItem Is Nothing Then
                                            If Me.cboListaEventos.SelectedItem.ToString.Length > 0 Then
                                                Me.DataGrid.Item("evento", i).Value = Me.cboListaEventos.SelectedItem
                                                Me.DataGrid.Item("IdEvento", i).Value = vIdEvento

                                            End If

                                            If vIdEvento = 4 And vIdSubEvento = 6 And Not Me.cboPotreroDestino.SelectedItem Is Nothing Then
                                                If Me.cboPotreroDestino.SelectedItem.ToString.Length > 0 Then
                                                    Me.DataGrid.Item("idpotreroDestino", i).Value = vPotreroDestino
                                                    Me.DataGrid.Item("potreroDes", i).Value = Me.cboPotreroDestino.SelectedItem
                                                End If
                                            End If

                                        End If

                                        If Not Me.cboListaEventosLineas.SelectedItem Is Nothing Then
                                            If Me.cboListaEventosLineas.SelectedItem.ToString.Length > 0 And Me.cboListaEventos.SelectedItem.ToString.Length > 0 Then
                                                Me.DataGrid.Item("eventoLin", i).Value = Me.cboListaEventosLineas.SelectedItem
                                                Me.DataGrid.Item("IdEventoLin", i).Value = vIdSubEvento
                                                Dim unaFilaSubEvento As DataRow = unafachada.BuscarListaEventosLineas(Me.cboListaEventosLineas.SelectedItem, dtListaEventosLineas, "eve_lin_nombre")
                                                Me.DataGrid.Item("Uni", i).Value = unaFilaSubEvento.Item("eve_lin_uni")

                                                If vIdEvento = 4 And vIdSubEvento = 6 And Not Me.cboPotreroDestino.SelectedItem Is Nothing Then
                                                    If Me.cboPotreroDestino.SelectedItem.ToString.Length > 0 Then
                                                        Me.DataGrid.Item("idpotreroDestino", i).Value = vPotreroDestino
                                                        Me.DataGrid.Item("potreroDes", i).Value = Me.cboPotreroDestino.SelectedItem
                                                    End If
                                                End If

                                            End If

                                        End If
                                    End If
                                End If
                            End If
                            i += 1
                        End While
                    End If
                End If

            End If
            Return primeraFilaLote
        End If
    End Function


#Region "Puerto Serie"

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

    'Sub GetSerialPortNames()

    '    ' muestra COM ports disponibles.

    '    Dim l As Integer

    '    Dim ncom As String

    '    Try

    '        ComboPorts.Items.Clear()

    '        For Each sp As String In My.Computer.Ports.SerialPortNames

    '            l = sp.Length

    '            If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
    '                ComboPorts.Items.Add(sp)
    '            Else
    '                'hay una letra al final del COM
    '                ncom = sp.Substring(0, l - 1)
    '                ComboPorts.Items.Add(ncom)
    '            End If
    '        Next
    '        If ComboPorts.Items.Count >= 1 Then

    '            ComboPorts.Text = ComboPorts.Items(0)

    '        Else

    '            ComboPorts.Text = ""

    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub


    'Private Sub btnBuscarCom_Click(sender As System.Object, e As System.EventArgs)
    '    GetSerialPortNames()
    'End Sub

    Public Function Conectar(ByVal pPuertoCom As String) As Boolean
        Return Setup_Puerto_Serie(pPuertoCom)

    End Function

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim ListaCaravanas As New List(Of String) 'vector que servira de buffer par
        'Dim bufer(1500) As Byte      'utilizada para almacenar los datos que se reciben por el puerto
        Dim pos As Integer    ' sera utilizada como contador
        Dim Retorno As String = ""
        Dim Descarga(1024) As Byte
        Try

            Retorno += SerialPort1.ReadExisting.ToString

            'ListaCaravanas.Item(pos) = bufer

            Me.Text_drecibidos.Text += Retorno
            RecibiendoDatos = True
            'pos = pos + 1

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

#End Region

    'Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs)
    '    'Try

    '    '    SerialPort1.Write(Me.Text_denviados.Text)

    '    '    Me.Text_drecibidos.Clear()

    '    'Catch ex As Exception
    '    '    Setup_Puerto_Serie(Me.ComboPorts.SelectedItem)
    '    '    MsgBox(ex.Message)

    '    'End Try
    'End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If RecibiendoDatos = True Then
            tamanoActualListaTimer1 = Me.Text_drecibidos.Text.Length

            If Me.Text_drecibidos.Text.Contains("ATMC") = False Then
                If tamanoActualListaTimer2 = tamanoActualListaTimer1 And tamanoActualListaTimer2 > 0 And tamanoActualListaTimer1 > 0 Then
                    lbDescarga.Visible = False
                    RecibiendoDatos = False
                    Me.Timer1.Enabled = False
                    Me.Timer2.Enabled = False
                    Me.lbDescarga.Text = "Descarga Finalizada"
                    AlmacenarDatosEnTxtBaston()
                    finalizado = True
                    'CARGAR EN DATAGIRD
                    ListaDispositivos = unafachada.LeerTxtDevoverCaravanas(Environment.CurrentDirectory & " \Lecturas\" & nombreArchivo)
                    CargarDetalle(ListaDispositivos)
                    dtTemporal = New DataTable
                    unafachada.ExportarDataGridViewADataTable(Me.DataGrid, dtTemporal)

                End If
            End If

            If tamanoActualListaTimer1 = 0 Then
                Me.lbDescarga.Text = "Encienda el Baston"
            Else
                Me.lbDescarga.Text = "Descargando Datos ... Espere por favor...."
            End If

            If Me.Text_drecibidos.Text.Contains("ATMC") Then
                Me.Text_drecibidos.Clear()
                SerialPort1.Write("*G")
            End If

        End If
        Me.lbDescarga.Visible = True
    End Sub


    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs)




    End Sub



    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Public Function BajarBaston() As Boolean
        Dim bandera As Boolean = Conectar(unafachada.puertoBaston)
        If bandera Then
            Try
                lbDescarga.Visible = True
                RecibiendoDatos = True
                Me.Timer1.Enabled = True
                Me.Timer2.Enabled = True
                SerialPort1.Write("*G")
                Me.Text_drecibidos.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Conecte baston a la PC")
        End If
        Return bandera
    End Function

    Public Sub AlmacenarDatosEnTxtBaston()
        Dim cadenas As String()
        cadenas = Me.Text_drecibidos.Text.Split("#")
        unafachada.GuardarTxtLecturas(nombreArchivo, cadenas)
    End Sub

    Private Sub cboEventos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim unaFila As DataRow
        Try
            unaFila = unafachada.BuscarListaEventos(Me.cboListaEventos.SelectedItem, dtListaEventos)
            vIdEvento = unaFila(0)

            'COMBO EVENTOS LINEAS
            Me.cboListaEventosLineas.Items.Clear()
            dtListaEventosLineas = unafachada.TodosLasListasEventosLineas(vIdEvento)
            CargarComboDesdeDataTable(Me.cboListaEventosLineas, dtListaEventosLineas, "eve_lin_nombre")
            Me.cboListaEventosLineas.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboEventos_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboListaEventos.SelectedIndexChanged
        LimpiarSeleccion()
        Dim unaFila As DataRow
        Try
            unaFila = unafachada.BuscarListaEventos(Me.cboListaEventos.SelectedItem, dtListaEventos)
            vIdEvento = unaFila(0)
            'COMBO EVENTOS LINEAS
            dtListaEventosLineas = unafachada.TodosLasListasEventosLineas(vIdEvento)
            cargarComboLineas()
            Seleccionar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargarComboLineas()
        If CargarComboDesdeDataTable(Me.cboListaEventosLineas, dtListaEventosLineas, "eve_lin_nombre") = False Then
            vIdSubEvento = 0
        End If
        'Cargar Combo DatagridView
        ' CargarComboDesdeDataTableDatagridView(Me.eventoLin, dtListaEventosLineas, "eve_lin_nombre")

        Me.cboListaEventosLineas.SelectedIndex = 1
    End Sub

    Private Sub cboEventosLineas_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboListaEventosLineas.SelectedIndexChanged
        LimpiarSeleccion()
        If Me.cboListaEventosLineas.SelectedItem.ToString.Length > 0 And Me.cboListaEventos.SelectedItem.ToString.Length > 0 Then
            Dim unaFila As DataRow
            Try
                unaFila = unafachada.BuscarListaEventosLineas(Me.cboListaEventosLineas.SelectedItem, dtListaEventosLineas, "eve_lin_nombre")
                vIdSubEvento = unaFila(0)
                If vIdSubEvento = 6 Then
                    Me.cboPotreroDestino.Visible = True
                    Me.lbpotdestino.Visible = True
                    Me.cboPotreroDestino.SelectedIndex = 0
                Else
                    vPotreroDestino = 0
                    Me.cboPotreroDestino.Visible = False
                    Me.lbpotdestino.Visible = False
                    Seleccionar()
                End If


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cboEventos_SelectedIndexChanged_2(sender As System.Object, e As System.EventArgs) Handles cboOperaciones.SelectedIndexChanged
        LimpiarSeleccion()
        Dim titulo As String = Me.cboOperaciones.SelectedItem.ToString
        Dim unCabezal As DataRow
        unCabezal = unafachada.BuscarCabezalOperacionxNombre(titulo)
        Me.txtCodigo.Text = unCabezal("ope_id")
        CargarOperacion(Me.txtCodigo.Text, unCabezal)

    End Sub



    Private Sub dtgvEventos_BindingContextChanged(sender As Object, e As System.EventArgs)

    End Sub


    Private Sub dtgvCaravanas_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim columna As Integer = dtgvEventos.CurrentCell.ColumnIndex
        'Dim numeroFila As Integer = dtgvEventos.CurrentRow.Index

        ' '''''''''COLUMNA SUB EVENTO
        'If columna = 5 Then
        '    bEdit = True
        '    'FIN 
        '    Me.eventoLin.Items.Clear()
        '    Dim dtgIdEvento As Integer = dtgvEventos.Rows(numeroFila).Cells("IdEvento").Value
        '    dtListaEventosLineas = unafachada.TodosLasListasEventosLineas(dtgIdEvento)
        '    CargarComboDesdeDataTableDatagridView(Me.eventoLin, dtListaEventosLineas, 2)
        'End If

    End Sub





    Private Sub ComboBox_SelectedIndexChanged( _
    ByVal sender As Object, ByVal e As EventArgs)

        Dim columna As Integer = DataGrid.CurrentCell.ColumnIndex
        Dim numeroFila As Integer = DataGrid.CurrentRow.Index


        '''''''''COLUMNA EVENTO
        'If columna = 5 Then

        '    Dim unaFila As DataRow
        '    Dim dtgIdEvento As Integer
        '    Try
        '        'INICIO BUSQUEDA NUMERACION
        '        Dim NomEvento As String = CType(CType(sender, ComboBox).SelectedItem, String)
        '        unaFila = unafachada.BuscarListaEventos(NomEvento, dtListaEventos)
        '        dtgIdEvento = unaFila.Item(0)
        '        dtgvEventos.Rows(numeroFila).Cells("IdEvento").Value = dtgIdEvento
        '    Catch ex As Exception
        '        dtgvEventos.Rows(numeroFila).Cells("IdEvento").Value = ""
        '    End Try


        'End If
        '''''''''COLUMNA SUB-EVENTO
        If columna = 7 Then
            Dim unaFila As DataRow
            Try
                Dim NomEvento As String = CType(CType(sender, ComboBox).SelectedItem, String)
                unaFila = unafachada.BuscarListaEventosLineas(NomEvento, dtListaEventosLineas, "eve_lin_nombre")
                DataGrid.Rows(numeroFila).Cells("IdEventoLin").Value = unaFila.Item(0)
            Catch ex As Exception
                DataGrid.Rows(numeroFila).Cells("chk").Value = False
                DataGrid.Rows(numeroFila).Cells("IdEventoLin").Value = ""
            End Try

        End If

        If columna = 22 Then
            Dim unaFila As DataRow
            Try
                Dim NomPotrero As String = CType(CType(sender, ComboBox).SelectedItem, String)
                unaFila = unafachada.BuscarPotrerosxNombre(NomPotrero, dtPotreros, "pot_nombre")
                DataGrid.Rows(numeroFila).Cells("idpotreroDestino").Value = unaFila.Item(0)
            Catch ex As Exception
                DataGrid.Rows(numeroFila).Cells("chk").Value = False
                DataGrid.Rows(numeroFila).Cells("idpotreroDestino").Value = ""
            End Try

        End If

    End Sub

    Private Sub dtgvEventos_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)


    End Sub

    Private Sub ComboPorts_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub



    Private Sub dtgvEventos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        'Me.eventoLin.Items.Clear()
        LimpiarSeleccion()

    End Sub

    Private Sub NudMeses_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NudMeses.ValueChanged
        Seleccionar()

    End Sub

    Private Sub cboLote_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboLote.SelectedIndexChanged
        Dim PrimeraFila As Integer = Seleccionar()
        DataGrid.CurrentCell = DataGrid.Rows(PrimeraFila).Cells(0)

    End Sub

    Private Sub cboRaza_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboRaza.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub cboSexo_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboSexo.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub cboPotreros_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPotreros.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub cboPotreroDestino_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPotreroDestino.SelectedIndexChanged
        Dim unaFila As DataRow
        Try
            unaFila = unafachada.BuscarPotrerosxNombre(Me.cboPotreroDestino.SelectedItem, dtPotreros, "pot_nombre")
            vPotreroDestino = unaFila(0)
            Seleccionar()
        Catch ex As Exception
            LimpiarSeleccion()
        End Try
    End Sub

    Private Sub cboCruza_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCruza.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub cboPropietario_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPropietario.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub cboUbicacion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboUbicacion.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub cboTenencia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTenencia.SelectedIndexChanged
        Seleccionar()
    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub dtgvEventos_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If Not vIdEvento = 4 And vIdSubEvento = 6 Then
            potreroDes.ReadOnly = False
        Else
            potreroDes.ReadOnly = True
        End If
    End Sub


    Private Sub dtgvEventos_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If DataGrid.Columns(e.ColumnIndex).Name = "chk" Then
            Dim count1 As Integer = 0
            For Each row As DataGridViewRow In DataGrid.Rows
                If row.Cells("chk").Value IsNot Nothing And row.Cells("chk").Value = True Then
                    count1 += 1
                End If
            Next

            txtSeleccionados.Text = count1
        End If
    End Sub

    Private Sub dtgvEventos_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs)
        If DataGrid.IsCurrentCellDirty Then
            DataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtgvEventos_EditingControlShowing1(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)

        Dim combo As ComboBox
        Try
            combo = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then

                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectedIndexChanged, _
                    New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

                ' Add the event handler. 
                AddHandler combo.SelectedIndexChanged, _
                    New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTitulo_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub dtpFecha_Click(sender As System.Object, e As System.EventArgs) Handles dtpFecha.Click

    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.datagridbusqueda.Visible = False
        Me.DataGrid.Visible = True

        Me.lbTitulo.Text = "Origen de Datos: " & Me.cboOrigen.SelectedItem.ToString
        finalizado = False
        NuevaOperacion(True, opcionDatos)

    End Sub

    Private Sub cboOrigen_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboOrigen.SelectedIndexChanged
        opcionDatos = Me.cboOrigen.SelectedIndex
        Me.txtTipoIngreso.Text = Me.cboOrigen.SelectedItem
    End Sub

    'Private Sub btnConectar_Click_1(sender As System.Object, e As System.EventArgs)
    '    Conectar(Me.ComboPorts.SelectedItem)
    'End Sub

    Private Sub hiloSegundoPlano_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub ButtonX1_Click_1(sender As System.Object, e As System.EventArgs)
        If Conectar(unafachada.puertoBaston) Then

        End If

        Try

            SerialPort1.Write("*C")

            Me.Text_drecibidos.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub LabelX1_Click(sender As System.Object, e As System.EventArgs) Handles LabelX1.Click

    End Sub

    Private Sub LabelX3_Click(sender As System.Object, e As System.EventArgs) Handles LabelX3.Click

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        tamanoActualListaTimer2 = Me.Text_drecibidos.Text.Length
        Me.lbDescarga.Visible = False
        If Me.Text_drecibidos.Text.Contains("ATMC") Then
            Me.Text_drecibidos.Clear()
            SerialPort1.Write("*G")
        End If

    End Sub

    Private Sub chInvertir_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chInvertir.CheckedChanged
        Seleccionar()
    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub GenerarTxt_Click(sender As System.Object, e As System.EventArgs) Handles GenerarTxt.Click


        If Me.txtGuia.Text.Length = 7 Then
            Dim message, title, defaultValue As String
            Dim unParametro As Parametros = unafachada.BuscarParametros("DireccionEnvioMail")
            If Not unParametro Is Nothing Then
                If unParametro.ValorParametro.Length > 0 Then
                    defaultValue = unParametro.ValorParametro
                Else
                    defaultValue = ""   ' Set default value.
                End If
            Else
                defaultValue = ""   ' Set default value.
            End If


            Dim myValue As Object
            ' Set prompt.
            message = "Escribe direccion de correo electronico a enviar archivo Snig"
            ' Set title.
            title = "Envio Archivo SNIG"


            ' Display message, title, and default value.
            myValue = InputBox(message, title, defaultValue)
            ' If user has clicked Cancel, set myValue to defaultValue
            If myValue Is "" Then myValue = defaultValue

            Dim i As Integer
            Dim generoTxt As Boolean
            Dim listaCaravanas As New List(Of String)
            Dim mes As String = dtpFecha.Value.Month
            Dim dia As String = dtpFecha.Value.Day

            If mes.Length = 1 Then
                mes = "0" & dtpFecha.Value.Month
            End If

            If dia.Length = 1 Then
                dia = "0" & dtpFecha.Value.Day
            End If

            Dim hora As String = Now.Hour
            Dim minutos As String = Now.Minute

            If hora.Length = 1 Then
                hora = "0" & Now.Hour
            End If

            If minutos.Length = 1 Then
                minutos = "0" & Now.Minute
            End If
            Dim nombreArchivoGuardado As String
            nombreArchivoGuardado = "Lecturas SNIG " & dia & "-" & mes & "-" & dtpFecha.Value.Year
            Dim cantidadRegistrosParaEnvio As Integer = 0
            While i < DataGrid.Rows.Count
                Dim valido As Boolean = Me.DataGrid.Item("chk", i).Value()
                If valido = True Then
                    cantidadRegistrosParaEnvio += 1
                    generoTxt = True
                    Dim DetDispositivo As String = Me.DataGrid.Item("dispositivo", i).Value()


                    Dim cadena As String = ""
                    cadena = "[|A0000000" & DetDispositivo & "|" & dia & mes & dtpFecha.Value.Year & "|" & hora & minutos & "00" & "|" & txtGuia.Text & "|" & ".|.|.|.|.|.|.|.|.|.|]"

                    listaCaravanas.Add(cadena)
                    '[|A0000000858000005533121|24102013|150000|V111111|.|.|.|.|.|.|.|.|.|.|]

                End If
                i += 1
            End While

            If generoTxt Then
                unafachada.GenerarArchivoTxtCaravanas(listaCaravanas, nombreArchivoGuardado)

                If myValue.ToString.Contains("@") Then
                    Dim BanderaEnvioCorrecto As Boolean = False
                    While BanderaEnvioCorrecto = False 'mientras no se haya enviado el archivo
                        Try
                            Dim fechas As String = dia & "-" & mes & "-" & dtpFecha.Value.Year
                            'aqui deberia ir tu codigo para comprimir
                            BanderaEnvioCorrecto = unafachada.enviar_mail("martincm@gmail.com", myValue, "Archivo Lecturas SNIG Dia: " & fechas, unafachada.Firma(fechas, cantidadRegistrosParaEnvio), nombreArchivoGuardado & ".txt", "")
                        Catch ex As Exception
                            System.Threading.Thread.Sleep(5000) 'espera un poco
                            BanderaEnvioCorrecto = False
                        End Try
                    End While
                End If


                Process.Start("Notepad.exe", Environment.CurrentDirectory & "\Lecturas\" & nombreArchivoGuardado & ".txt")
            End If

        Else
            MsgBox("Ingrese Numero de guia Correctamente ej. V111111")
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs)




    End Sub

    Public Sub Imprimir(ByVal pReporte As Object, ByVal pUnDataTable As DataTable)
        'Dim reporte As New Dac.ReporteOperacionAgrupaLotePropietario
        pReporte.SetDataSource(pUnDataTable)
        Dim unImpresionLecturasReal As New IUReporteOperaciones(pReporte, cboOrigen.SelectedItem)
        unImpresionLecturasReal.Show()

    End Sub

    Public Function DataTableComun() As DataTable
        Dim filtros As String = "numeracion>0"
        Dim undataTable As DataTable = RetornarFiltrarDataTableAgregarALista(dtTemporal, filtros, "lote")
        Return undataTable
    End Function

    Public Function DataTableCruzado() As DataTable
        Dim filtros As String = "numeracion>0"
        Dim undataTableCruzado As DataTable = RetornarFiltrarDataTableAgregarALista(dtTemporal, filtros, "lote")
        Dim tablaPrincipal As New DataTable
        Dim i As Integer
        Dim FilaAnterior, NombreFilaActual As String
        For i = 0 To undataTableCruzado.Rows.Count - 1
            NombreFilaActual = undataTableCruzado.Rows(i)("lote").ToString()
            If NombreFilaActual <> FilaAnterior Then
                tablaPrincipal.Columns.Add(NombreFilaActual)
                FilaAnterior = NombreFilaActual
            End If
        Next i


        Dim valor, NombreColumna As String
        For i = 0 To undataTableCruzado.Rows.Count - 1
            NombreColumna = undataTableCruzado.Rows(i)("lote").ToString()
            valor = undataTableCruzado.Rows(i)("dispositivo").ToString() & " " & undataTableCruzado.Rows(i)("edad").ToString()
            BuscarLugarVacio(NombreColumna, tablaPrincipal, valor)
        Next i
        'Dim ds As New DataSet
        'ds.Tables.Add(tablaPrincipal)
        'ds.WriteXmlSchema(Environment.CurrentDirectory & "\impresion.xml")

        Return tablaPrincipal
    End Function


    Public Function BuscarIndiceFilaVacia(ByVal pNombreColumna As String, ByRef pDataTable As DataTable) As Integer

        If pDataTable.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To pDataTable.Rows.Count - 1

                Dim Row As DataRow = pDataTable.Rows(i)
                Dim valorenColumna As String
                Try
                    valorenColumna = Row(pNombreColumna)
                Catch ex As Exception
                    Return i
                End Try
            Next i
        End If


    End Function
    Public Sub BuscarLugarVacio(ByVal pNombreColumna As String, ByRef pDataTable As DataTable, ByVal pValorFila As String)

        If Not pDataTable Is Nothing Then
            If pDataTable.Rows.Count > 0 Then
                Dim indice As Integer = BuscarIndiceFilaVacia(pNombreColumna, pDataTable)
                Dim Row As DataRow = pDataTable.Rows(indice)


                Dim valorenColumna As String
                Try
                    valorenColumna = Row(pNombreColumna)
                Catch ex As Exception
                    valorenColumna = ""
                End Try


                If valorenColumna.Length > 0 Then
                    Dim NuevaRow As DataRow
                    NuevaRow = pDataTable.NewRow()
                    NuevaRow.Item(pNombreColumna) = pValorFila
                    pDataTable.Rows.Add(NuevaRow)
                Else
                    Row(pNombreColumna) = pValorFila
                End If

            Else
                Dim Row As DataRow
                Row = pDataTable.NewRow()
                Row.Item(pNombreColumna) = pValorFila
                pDataTable.Rows.Add(Row)
            End If

        End If


    End Sub


    Private Sub btnver_Click(sender As System.Object, e As System.EventArgs)


    End Sub


    Public Sub eliminarFila()

        Dim value As DataGridViewSelectedRowCollection
        value = DataGrid.SelectedRows

        For Each vfila As DataGridViewRow In value
            DataGrid.Rows.Remove(vfila)
        Next


        'If Me.txtSeleccionados.Text > 0 Then
        '    For i As Integer = dtgvEventos.Rows.Count - 1 To 0 Step -1
        '        Dim valido As Boolean = Me.dtgvEventos.Item("chk", i).Value()
        '        If valido = True Then
        '            Me.dtgvEventos.Rows.RemoveAt(i)

        '        End If

        '        i += 1
        '    Next
        'End If



    End Sub

    Private Sub ButtonX1_Click_2(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Dim PenultimaCelda, loteNumInterno, idCelda As Integer
        If Me.DataGrid.Rows.Count > 0 Then
            PenultimaCelda = Me.DataGrid.Rows.Count - 1
            If Me.DataGrid.Item("lote", PenultimaCelda).Value = "Manual" Then
                loteNumInterno = Me.DataGrid.Item("numeracion", PenultimaCelda).Value() + 1
            Else
                Me.cboLote.Items.Add("Manual")
                loteNumInterno = 1
                idCelda = Me.DataGrid.Item("IdLinea", PenultimaCelda).Value() + 1
                Me.DataGrid.Rows.Add()
                DataGrid.Rows(PenultimaCelda + 1).DefaultCellStyle.BackColor = Color.LightGreen
                Me.DataGrid.Item("IdLinea", PenultimaCelda + 1).Value = idCelda
            End If

            PenultimaCelda = Me.DataGrid.Rows.Count - 1
            idCelda = Me.DataGrid.Item("IdLinea", PenultimaCelda).Value() + 1

            'Agregar Fila
            Me.DataGrid.Rows.Add()
            Me.DataGrid.Item("IdLinea", PenultimaCelda + 1).Value = idCelda
            Dim unaCaravana As String = unafachada.DevolverNumeroCaravana(Me.txtDispositivoManual.Text)
            Me.DataGrid.Item("chk", PenultimaCelda + 1).Value = False
            Me.DataGrid.Item("fecha", PenultimaCelda + 1).Value() = Me.dtpFecha.Value.ToString("dd/MM/yyyy")
            Me.DataGrid.Item("lote", PenultimaCelda + 1).Value = "Manual"
            Me.DataGrid.Item("numeracion", PenultimaCelda + 1).Value = loteNumInterno
            Me.DataGrid.Item("dispositivo", PenultimaCelda + 1).Value() = unaCaravana
            'Buscar dispositivo

            Dim unaCaravanaRow As DataRow = unafachada.BuscarDispositivo(unaCaravana)
            If Not unaCaravanaRow Is Nothing Then
                Dim unPotreros As DataRow
                Try
                    unPotreros = unafachada.BuscarPotreros(unaCaravanaRow.Item("ani_IdPotrero"), dtPotreros)
                    Me.DataGrid.Item("potrero", PenultimaCelda + 1).Value() = unPotreros.Item("pot_nombre")
                    Me.DataGrid.Item("idpotrero", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_IdPotrero")
                Catch ex As Exception
                    Me.DataGrid.Item("idpotrero", PenultimaCelda + 1).Value() = 3
                    Me.DataGrid.Item("potrero", PenultimaCelda + 1).Value() = "N/A"
                End Try

                Me.DataGrid.Item("raza", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_raza")
                If Not DataGrid.Item("raza", PenultimaCelda + 1).Value() Is Nothing Then
                    If DataGrid.Item("raza", PenultimaCelda + 1).Value().ToString.Length > 0 Then
                        If BuscarEnLista(DataGrid.Item("raza", PenultimaCelda + 1).Value(), listaRazas) = False Then
                            listaRazas.Add(DataGrid.Item("raza", PenultimaCelda + 1).Value())
                            Me.cboRaza.Items.Add(DataGrid.Item("raza", PenultimaCelda + 1).Value())
                        End If
                    End If
                End If


                Me.DataGrid.Item("cruza", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_cruza")
                If Not DataGrid.Item("cruza", PenultimaCelda + 1).Value() Is Nothing Then
                    If DataGrid.Item("cruza", PenultimaCelda + 1).Value().ToString.Length > 0 Then
                        If BuscarEnLista(DataGrid.Item("cruza", PenultimaCelda + 1).Value(), listaCruzas) = False Then
                            listaCruzas.Add(DataGrid.Item("cruza", PenultimaCelda + 1).Value())
                            Me.cboCruza.Items.Add(DataGrid.Item("cruza", PenultimaCelda + 1).Value())
                        End If
                    End If
                End If



                Me.DataGrid.Item("sexo", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_sexo")
                Dim Meses As Integer
                Try
                    Meses = DateDiff(DateInterval.Month, unaCaravanaRow.Item("ani_fechaNac"), Today)
                Catch ex As Exception
                    Meses = 0
                End Try
                If Meses > 500 Then
                    Meses = 0
                End If
                Me.DataGrid.Item("edad", PenultimaCelda + 1).Value() = Meses

                Dim DiasUbicacionActual As Integer
                Try
                    DiasUbicacionActual = DateDiff(DateInterval.Day, unaCaravanaRow.Item("ani_fecha_ubicacion_Actual"), Today)
                Catch ex As Exception
                    DiasUbicacionActual = 0
                End Try
                Me.DataGrid.Item("DiasUbicacionActual", PenultimaCelda + 1).Value() = DiasUbicacionActual


                If Not unaCaravanaRow.Item("ani_propietario") Is Nothing Then
                    If unaCaravanaRow.Item("ani_propietario").ToString.Length > 0 Then
                        If unaCaravanaRow.Item("ani_propietario") <> DicosePropietario Then
                            If BuscarEnLista(unaCaravanaRow.Item("ani_propietario"), listaPropietarios) = False Then
                                listaPropietarios.Add(unaCaravanaRow.Item("ani_propietario"))
                                Me.cboPropietario.Items.Add(unaCaravanaRow.Item("ani_propietario"))
                            End If

                        End If
                    End If
                End If
                Try
                    DicosePropietario = unaCaravanaRow.Item("ani_propietario")
                Catch ex As Exception

                End Try

                If Not unaCaravanaRow.Item("ani_ubicacion") Is Nothing Then
                    If unaCaravanaRow.Item("ani_ubicacion").ToString.Length > 0 Then
                        If unaCaravanaRow.Item("ani_ubicacion") <> DicoseUbicacion Then
                            If BuscarEnLista(unaCaravanaRow.Item("ani_ubicacion"), listaUbicacion) = False Then
                                listaUbicacion.Add(unaCaravanaRow.Item("ani_ubicacion"))
                                Me.cboUbicacion.Items.Add(unaCaravanaRow.Item("ani_ubicacion"))
                            End If

                        End If
                    End If
                End If
                Try
                    DicoseUbicacion = unaCaravanaRow.Item("ani_ubicacion")
                Catch ex As Exception

                End Try

                If Not unaCaravanaRow.Item("ani_tenencia") Is Nothing Then
                    If unaCaravanaRow.Item("ani_tenencia").ToString.Length > 0 Then
                        If unaCaravanaRow.Item("ani_tenencia") <> DicoseTenencia Then
                            If BuscarEnLista(unaCaravanaRow.Item("ani_tenencia"), listaTenencia) = False Then
                                listaTenencia.Add(unaCaravanaRow.Item("ani_tenencia"))
                                Me.cboTenencia.Items.Add(unaCaravanaRow.Item("ani_tenencia"))
                            End If

                        End If
                    End If
                End If

                Try
                    DicoseTenencia = unaCaravanaRow.Item("ani_tenencia")
                Catch ex As Exception

                End Try


                Me.DataGrid.Item("propietario", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_propietario")
                Me.DataGrid.Item("ubicacion", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_ubicacion")
                Me.DataGrid.Item("tenencia", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_tenencia")
                Me.DataGrid.Item("vida", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_vida")
                Me.DataGrid.Item("trazabilidad", PenultimaCelda + 1).Value() = unaCaravanaRow.Item("ani_trazabilidad")

            Else
                Me.DataGrid.Item("raza", PenultimaCelda + 1).Value() = "N/A"
                Me.DataGrid.Item("cruza", PenultimaCelda + 1).Value() = "N/A"
                Me.DataGrid.Item("sexo", PenultimaCelda + 1).Value() = "N/A"
                Me.DataGrid.Item("edad", PenultimaCelda + 1).Value() = "0"
                DataGrid.Rows(PenultimaCelda + 1).DefaultCellStyle.BackColor = Color.LightSalmon

            End If
        End If

        'AGREGAR FILA A DATATABLE TEMPORAL
        Dim UltimaCeldaDataGrid As DataGridViewRow = Me.DataGrid.Rows(Me.DataGrid.Rows.Count - 1)
        Dim numCols As Integer = Me.DataGrid.ColumnCount
        Dim filaNueva As System.Data.DataRow
        filaNueva = dtTemporal.NewRow()
        For i As Integer = 0 To numCols - 1
            Try
                filaNueva(i) = UltimaCeldaDataGrid.Cells.Item(i).Value

                filaNueva(i) = CType(UltimaCeldaDataGrid.Cells(i).Value, String)
            Catch ex As Exception

            End Try

        Next
        dtTemporal.Rows.Add(filaNueva)




    End Sub




    Private Sub dtgvEventos_CellContentClick_2(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub

    Private Sub dtgvEventos_CellValueChanged1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellValueChanged
        If DataGrid.Columns(e.ColumnIndex).Name = "chk" Then
            Dim count1 As Integer = 0
            For Each row As DataGridViewRow In DataGrid.Rows
                If row.Cells("chk").Value IsNot Nothing And row.Cells("chk").Value = True Then
                    count1 += 1
                End If
            Next

            txtSeleccionados.Text = count1
        End If
    End Sub

    Private Sub dtgvEventos_CurrentCellDirtyStateChanged1(sender As Object, e As System.EventArgs) Handles DataGrid.CurrentCellDirtyStateChanged
        If DataGrid.IsCurrentCellDirty Then
            DataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtgvEventos_EditingControlShowing2(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGrid.EditingControlShowing
        'Dim combo As ComboBox
        'Try
        '    combo = CType(e.Control, ComboBox)
        '    If (combo IsNot Nothing) Then

        '        ' Remove an existing event-handler, if present, to avoid 
        '        ' adding multiple handlers when the editing control is reused.
        '        RemoveHandler combo.SelectedIndexChanged, _
        '            New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

        '        ' Add the event handler. 
        '        AddHandler combo.SelectedIndexChanged, _
        '            New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub SeleccionarArchivoLotes()
        If Not IUMenu.formularioAbierto("IUSubSeleccionArchivo") Then
            Dim unIUSubSeleccionArchivo As New IUSubSeleccionArchivo()
            unIUSubSeleccionArchivo.ShowDialog()

        End If

    End Sub


#Region " funciones extras "

    Public Sub ExportarExcelDataGridViewX(ByVal pDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX)

        If pDataGridView.RowCount > 0 Then
            'Dim xlApp As Microsoft.Office.Interop.Excel.Application
            'Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            'Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            'Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            Dim m_Excel
            Dim objLibroExcel
            Dim objHojaExcel
            m_Excel = CreateObject("Excel.Application")
            objLibroExcel = m_Excel.Workbooks.Add()
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Name = "Exportado"
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()


            'xlApp = New Microsoft.Office.Interop.Excel.Application
            'xlWorkBook = xlApp.Workbooks.Add(misValue)
            'xlWorkSheet = xlWorkBook.Sheets("sheet1")


            For i = 0 To pDataGridView.RowCount - 2
                For j = 0 To pDataGridView.ColumnCount - 1
                    Dim objecto As Object = pDataGridView.Item(j, i)

                    objHojaExcel.Cells(i + 1, j + 1) = pDataGridView(j, i).Value
                Next
            Next

            objHojaExcel.SaveAs("C:\vbexcel.xlsx")
            objLibroExcel.Close()
            m_Excel.Quit()
            releaseObject(m_Excel)
            releaseObject(objLibroExcel)
            releaseObject(objHojaExcel)
            MsgBox("C:\vbexcel.xlsx")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

#End Region


    Private Sub btnEliminar2_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar2.Click
        eliminarFila()
    End Sub

    Private Sub ButtonX2_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If (MsgBox("Guardar cambios ?", _
                   MsgBoxStyle.YesNo, _
                  "Sistema Trazabilidad - Guardar Eventos")) = MsgBoxResult.Yes Then
            Dim i As Integer
            Dim bandera As Boolean = False
            While i < DataGrid.Rows.Count
                Dim valido As Boolean = Me.DataGrid.Item("chk", i).Value()
                If valido = True Then
                    bandera = True
                End If
                i += 1
            End While

            If bandera = True Then
                GuardarOperacion()
            Else
                MsgBox("Agregue al menos un registro en detalle o complete la linea")
            End If
        Else

        End If
    End Sub

    Private Sub ButtonItem4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem4.Click

        If Me.dtTemporal.Rows.Count > 0 Then
            Dim dataTable As DataTable
            dataTable = unafachada.ExportarDataGridView(Me.DataGrid)
            unafachada.ExportarExcelDataTable(dataTable)
        End If
    End Sub

    Private Sub ButtonItem3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem3.Click
        Dim unReportePropietario As New Dac.ReporteOperacionAgrupaLotePropietario
        'Dim unReportePropietario As New Dac.ReporteOperaciones 
        Dim undataTable As DataTable = DataTableComun()
        Imprimir(unReportePropietario, undataTable)
    End Sub

    Private Sub ButtonItem2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem2.Click
        DataGrid.DataSource = Nothing
        DataGrid.Rows.Clear()
        DataGrid.Columns.Clear()
        DataGrid.Refresh()
        Me.DataGrid.DataSource = DataTableCruzado()
    End Sub

    Private Sub txtBusquedaDis_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBusquedaDis.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.DataGrid.Visible = False
            Me.datagridbusqueda.Visible = True

            Dim Dispositivo As String = unafachada.DevolverNumeroCaravana(Me.txtBusquedaDis.Text)
            Dim unDt As DataTable = unafachada.BuscarDispositivosDataTable(Dispositivo)

            Me.datagridbusqueda.DataSource = Nothing
            Me.datagridbusqueda.DataSource = unDt

           

            If unDt Is Nothing Then
                MsgBox("No existe dispositivo: " & Dispositivo & " en base de datos")
            End If
        End If
    End Sub

    Private Sub txtBusquedaDis_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusquedaDis.KeyPress

    End Sub

  
    Private Sub txtBusquedaDis_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusquedaDis.TextChanged

    End Sub


    Public Sub OrdenarColumnas()
        'If Not Me.DataGrid Is Nothing Then

        '    If Me.DataGrid.Rows.Count > 0 Then

        '        Dim listaColorear As New List(Of String)
        '        Try

        '            With DataGrid
        '                'Colores Fijos de Celdas
        '                Dim colorBloqueFijo As Color = txt_color_bloque_incompleto.BackColor
        '                Dim colorBloque1 As Color = txtBloque1.BackColor
        '                Dim colorBloque2 As Color = txtBloque2.BackColor

        '                .Columns("PredioINV").DefaultCellStyle.BackColor = colorBloqueFijo
        '                If ColumnaOperario = True Then
        '                    .Columns("Operario").DefaultCellStyle.BackColor = colorBloqueFijo
        '                End If

        '                .Columns("BloqueINV").DefaultCellStyle.BackColor = colorBloqueFijo
        '                .Columns("LargoTrozaINV").DefaultCellStyle.BackColor = colorBloqueFijo
        '                .Columns("EspecieINV").DefaultCellStyle.BackColor = colorBloqueFijo
        '                .Columns("SuperficieINV").DefaultCellStyle.BackColor = colorBloqueFijo
        '                .Columns("inv_distancia_extraccion").DefaultCellStyle.BackColor = colorBloqueFijo
        '                .Columns("inv_vol_med").DefaultCellStyle.BackColor = colorBloqueFijo

        '                For i As Integer = 0 To Me.DataGrid.Rows.Count - 1

        '                    If .Rows(i).Cells("Arboles_cosechados").Value > 0 Then
        '                        .Rows(i).Cells("PredioINV").Style.BackColor = chkCosechando.BackColor
        '                        .Rows(i).Cells("BloqueINV").Style.BackColor = chkCosechando.BackColor
        '                        If ColumnaOperario = True Then
        '                            .Columns("Operario").DefaultCellStyle.BackColor = chkCosechando.BackColor
        '                        End If
        '                        .Rows(i).Cells("LargoTrozaINV").Style.BackColor = chkCosechando.BackColor
        '                        .Rows(i).Cells("EspecieINV").Style.BackColor = chkCosechando.BackColor
        '                        .Rows(i).Cells("SuperficieINV").Style.BackColor = chkCosechando.BackColor
        '                        .Rows(i).Cells("inv_distancia_extraccion").Style.BackColor = chkCosechando.BackColor
        '                        .Rows(i).Cells("inv_vol_med").Style.BackColor = chkCosechando.BackColor
        '                    End If

        '                    If .Rows(i).Cells("inv_cierre_cosecha").Value.ToString.Length > 0 Then
        '                        .Rows(i).Cells("PredioINV").Style.BackColor = chkFinCosecha.BackColor
        '                        .Rows(i).Cells("BloqueINV").Style.BackColor = chkFinCosecha.BackColor
        '                        If ColumnaOperario = True Then
        '                            .Columns("Operario").DefaultCellStyle.BackColor = chkFinCosecha.BackColor
        '                        End If
        '                        .Rows(i).Cells("LargoTrozaINV").Style.BackColor = chkFinCosecha.BackColor
        '                        .Rows(i).Cells("EspecieINV").Style.BackColor = chkFinCosecha.BackColor
        '                        .Rows(i).Cells("SuperficieINV").Style.BackColor = chkFinCosecha.BackColor
        '                        .Rows(i).Cells("inv_distancia_extraccion").Style.BackColor = chkFinCosecha.BackColor
        '                        .Rows(i).Cells("inv_vol_med").Style.BackColor = chkFinCosecha.BackColor

        '                    End If

        '                    If .Rows(i).Cells("inv_cierre_extraccion").Value.ToString.Length > 0 Then
        '                        .Rows(i).Cells("PredioINV").Style.BackColor = ChkFin.BackColor
        '                        .Rows(i).Cells("BloqueINV").Style.BackColor = ChkFin.BackColor
        '                        If ColumnaOperario = True Then
        '                            .Columns("Operario").DefaultCellStyle.BackColor = ChkFin.BackColor
        '                        End If

        '                        .Rows(i).Cells("LargoTrozaINV").Style.BackColor = ChkFin.BackColor
        '                        .Rows(i).Cells("EspecieINV").Style.BackColor = ChkFin.BackColor
        '                        .Rows(i).Cells("SuperficieINV").Style.BackColor = ChkFin.BackColor
        '                        .Rows(i).Cells("inv_distancia_extraccion").Style.BackColor = ChkFin.BackColor
        '                        .Rows(i).Cells("inv_vol_med").Style.BackColor = ChkFin.BackColor

        '                    End If
        '                Next


        '                'Nombres ------------------
        '                '.Columns("CntPD").HeaderText = "Nº PD"
        '                .Columns("PredioINV").HeaderText = "Predio"
        '                .Columns("BloqueINV").HeaderText = "Bloque"
        '                .Columns("LargoTrozaINV").HeaderText = "L_Troza"
        '                .Columns("EspecieINV").HeaderText = "Especie"
        '                .Columns("SuperficieINV").HeaderText = "Superficie"
        '                .Columns("inv_distancia_extraccion").HeaderText = "Dist. MDP"
        '                .Columns("inv_vol_med").HeaderText = "mcs/ha MDP"

        '                'Porcentaje avance
        '                .Columns("%_Avance_HV").HeaderText = "%_Avance_HV"
        '                .Columns("%_Avance_FW").HeaderText = "%_Avance_FW"


        '                'Arboles
        '                .Columns("Arb_x_Ha_inv").HeaderText = "MDP Arb/Há"
        '                .Columns("Arb_x_Ha_cuenta").HeaderText = "Hv Arb/Há"
        '                .Columns("inv_arboles_totales").HeaderText = "MDP Tot Arb"
        '                .Columns("Arboles_cosechados").HeaderText = "Hv Tot Arb"

        '                'Volumen x Arbol
        '                .Columns("MDP_Vol_Arb").HeaderText = "EMP Vol/Arb"
        '                .Columns("PIL_Vol_Arb").HeaderText = "Pilas Vol/Arb Mdp"
        '                .Columns("ENT_Vol_Arb").HeaderText = "Planta Vol/Arb Mdp"
        '                .Columns("PIL_Arb_Cosechados_Vol_Arb").HeaderText = "Pil/Arb_Cos_Vol/Arb"

        '                'Volumen Total
        '                .Columns("MCS_MDP").HeaderText = "Mcs Tot Mdp"
        '                .Columns("MCS_PIL").HeaderText = "Mcs Tot Pilas"
        '                .Columns("MCS_HAR").HeaderText = "Mcs Tot Hv"
        '                .Columns("inv_entregado").HeaderText = "Mcs Tot Planta"

        '                'Prod. Harvester
        '                .Columns("Mcs/Hr_Hv_Tabla").HeaderText = "Mcs/Hr_Hv_Tabla"
        '                .Columns("Mcs/Hr_Hv_Real_Tabla").HeaderText = "Mcs/Hr_Hv_Real_Tabla"
        '                .Columns("Mcs/Hr_Hv_Real_Final").HeaderText = "Mcs/Hr_Hv_Real_Final"
        '                .Columns("Mcs/Hr_Hv_Final").HeaderText = "Mcs/Hr_Hv_Final"
        '                .Columns("Hv_Dif").HeaderText = "Dif_%"

        '                'Prod. Forwarder
        '                .Columns("Mcs/Hr_Fw_Tabla").HeaderText = "Mcs/Hr_Fw_Tabla"
        '                .Columns("Mcs/Hr_Fw_Real_Final").HeaderText = "Mcs/Hr_Fw_Real_Final"
        '                .Columns("Mcs/Hr_Fw_Real_Tabla").HeaderText = "Mcs/Hr_Fw_Real_Tabla"

        '                'Estimado Horas Harvester
        '                .Columns("Hv_Hs_Tot_Med").HeaderText = "Hr_Hv_Prog."
        '                .Columns("Hv_Hs_Total").HeaderText = "Hr_Hv_Real"
        '                .Columns("Hv_Hs_Dif").HeaderText = "Hr_Hv_Dif"
        '                .Columns("Hv_Hs_Dif_%").HeaderText = "Hr_Hv_Dif_%"

        '                'Estimado Horas Forwarder
        '                .Columns("Fw_Hs_Tot_Med").HeaderText = "Hr Fw Programado"
        '                .Columns("Fw_Hs_Total").HeaderText = "Hr Fw Real"
        '                .Columns("Fw_Hs_Dif").HeaderText = "Hr Fw Diferencia"

        '                'Distancia estimada
        '                .Columns("Km_Tot_Estim").HeaderText = "Fw Dist Programada"
        '                .Columns("Km_Tot_Real").HeaderText = "Fw Dist Real"
        '                .Columns("Km_Dif").HeaderText = "Km Diferencia"

        '                ' Costos 
        '                .Columns("Precio").HeaderText = "Precio"
        '                .Columns("Tope_MDP").HeaderText = "Tope_MDP"
        '                .Columns("Tope_Aj").HeaderText = "Tope_Aj"
        '                .Columns("Pagos_FW").HeaderText = "Pagos_FW"
        '                .Columns("Dif_Real").HeaderText = "Dif_Real"

        '                ' Valorizaciones
        '                .Columns("Precio_Cos").HeaderText = "Precio_Cos"
        '                .Columns("Precio_Ext").HeaderText = "Precio_Ext"
        '                .Columns("Mcs_Mdp_U$S").HeaderText = "Mcs_Mdp_U$S"
        '                .Columns("Mcs_Pilas_U$S").HeaderText = "Mcs_Pilas_U$S"
        '                .Columns("Mcs_Hv_U$S").HeaderText = "Mcs_Hv_U$S"
        '                .Columns("Mcs_Entrega_U$S").HeaderText = "Mcs_Entrega_U$S"

        '                '.Columns("HsMaq_PD").HeaderText = "Horas Maq"
        '                '.Columns("Mcs_hr_PIL_PD").HeaderText = "Mcs_Hrs"
        '                '.Columns("CarrosPIL").HeaderText = "Carros Estim."
        '                '.Columns("CarrosPD").HeaderText = "Carros Reales"
        '                '.Columns("CoefINV").HeaderText = "Coef. Pila"
        '                '.Columns("DistanciaPD").HeaderText = "Dist. Recorrida"
        '                '.Columns("DistPromPD").HeaderText = "Dist. prom."
        '                '.Columns("GasOilPD").HeaderText = "GasOil"

        '                'Campos Datagrid Visibles----------------------------------------
        '                .Columns("CntPD").Visible = False
        '                .Columns("PredioINV").Visible = True
        '                .Columns("IdBloque").Visible = False
        '                .Columns("BloqueINV").Visible = True
        '                If ColumnaOperario = True Then
        '                    .Columns("Operario").Visible = True
        '                    .Columns("IdOperario").Visible = False
        '                End If
        '                .Columns("inv_superficie").Visible = False
        '                .Columns("SuperficieINV").Visible = True
        '                .Columns("LargoTrozaINV").Visible = False
        '                .Columns("EspecieINV").Visible = True
        '                .Columns("inv_vol_med").Visible = True
        '                .Columns("inv_distancia_extraccion").Visible = True

        '                'Arboles 
        '                If chk_Arboles.Checked = True Then
        '                    .Columns("Arb_x_Ha_inv").Visible = True
        '                    .Columns("Arb_x_Ha_cuenta").Visible = True
        '                    .Columns("inv_arboles_totales").Visible = True
        '                    .Columns("Arboles_cosechados").Visible = True
        '                    listaColorear.Add("Arboles")
        '                Else
        '                    .Columns("Arb_x_Ha_inv").Visible = False
        '                    .Columns("Arb_x_Ha_cuenta").Visible = False
        '                    .Columns("inv_arboles_totales").Visible = False
        '                    .Columns("Arboles_cosechados").Visible = False
        '                End If
        '                'Fin Arboles

        '                'Volumen Total
        '                If chk_volumen_total.Checked = True Then
        '                    .Columns("MCS_MDP").Visible = True
        '                    .Columns("MCS_PIL").Visible = True
        '                    .Columns("MCS_HAR").Visible = True
        '                    .Columns("inv_entregado").Visible = True
        '                    listaColorear.Add("VolumenTotal")
        '                Else
        '                    .Columns("MCS_MDP").Visible = False
        '                    .Columns("MCS_PIL").Visible = False
        '                    .Columns("MCS_HAR").Visible = False
        '                    .Columns("inv_entregado").Visible = False
        '                End If

        '                'Volumen x Arbol
        '                If chk_volumnes_x_arbol.Checked = True Then
        '                    .Columns("MDP_Vol_Arb").Visible = True
        '                    .Columns("PIL_Vol_Arb").Visible = False
        '                    .Columns("ENT_Vol_Arb").Visible = False
        '                    .Columns("PIL_Arb_Cosechados_Vol_Arb").Visible = True
        '                    listaColorear.Add("VolumenArbol")
        '                Else
        '                    .Columns("MDP_Vol_Arb").Visible = False
        '                    .Columns("PIL_Vol_Arb").Visible = False
        '                    .Columns("ENT_Vol_Arb").Visible = False
        '                    .Columns("PIL_Arb_Cosechados_Vol_Arb").Visible = False
        '                End If

        '                'Prod. Harvester
        '                If chk_Prod_Harvester.Checked = True Then
        '                    .Columns("Mcs/Hr_Hv_Tabla").Visible = True
        '                    .Columns("Mcs/Hr_Hv_Real_Tabla").Visible = True
        '                    .Columns("Mcs/Hr_Hv_Final").Visible = True
        '                    .Columns("Mcs/Hr_Hv_Real_Final").Visible = True
        '                    .Columns("Hv_Dif").Visible = True
        '                    listaColorear.Add("Hv_Mcs")
        '                Else
        '                    .Columns("Mcs/Hr_Hv_Tabla").Visible = False
        '                    .Columns("Mcs/Hr_Hv_Real_Tabla").Visible = False
        '                    .Columns("Mcs/Hr_Hv_Real_Final").Visible = False
        '                    .Columns("Mcs/Hr_Hv_Final").Visible = False
        '                    .Columns("Hv_Dif").Visible = False
        '                End If

        '                'Prod. Forwarder
        '                If chk_Prod_Forwarder.Checked = True Then
        '                    .Columns("Mcs/Hr_Fw_Tabla").Visible = True
        '                    .Columns("Mcs/Hr_Fw_Real_Final").Visible = True
        '                    .Columns("Mcs/Hr_Fw_Real_Tabla").Visible = True
        '                    listaColorear.Add("Fw_Mcs")
        '                Else
        '                    .Columns("Mcs/Hr_Fw_Tabla").Visible = False
        '                    .Columns("Mcs/Hr_Fw_Real_Final").Visible = False
        '                    .Columns("Mcs/Hr_Fw_Real_Tabla").Visible = False

        '                End If

        '                'Estimado Horas Harvester
        '                If chk_Horas_Harvester.Checked = True Then
        '                    .Columns("Hv_Hs_Tot_Med").Visible = True
        '                    .Columns("Hv_Hs_Total").Visible = True
        '                    .Columns("Hv_Hs_Dif").Visible = True
        '                    .Columns("Hv_Hs_Dif_%").Visible = True
        '                    listaColorear.Add("Hv_Hs")
        '                Else
        '                    .Columns("Hv_Hs_Tot_Med").Visible = False
        '                    .Columns("Hv_Hs_Total").Visible = False
        '                    .Columns("Hv_Hs_Dif").Visible = False
        '                    .Columns("Hv_Hs_Dif_%").Visible = False

        '                End If

        '                'Estimado Horas Forwarder
        '                If chk_Horas_Forwarder.Checked = True Then
        '                    .Columns("Fw_Hs_Tot_Med").Visible = True
        '                    .Columns("Fw_Hs_Total").Visible = True
        '                    .Columns("Fw_Hs_Dif").Visible = True
        '                    listaColorear.Add("Fw_Hs")
        '                Else
        '                    .Columns("Fw_Hs_Tot_Med").Visible = False
        '                    .Columns("Fw_Hs_Total").Visible = False
        '                    .Columns("Fw_Hs_Dif").Visible = False
        '                End If

        '                'Distancia Estimada
        '                If chk_Distancias.Checked = True Then
        '                    .Columns("Km_Tot_Estim").Visible = True
        '                    .Columns("Km_Tot_Real").Visible = True
        '                    .Columns("Km_Dif").Visible = True
        '                    listaColorear.Add("Distancia")
        '                Else
        '                    .Columns("Km_Tot_Estim").Visible = False
        '                    .Columns("Km_Tot_Real").Visible = False
        '                    .Columns("Km_Dif").Visible = False
        '                End If

        '                'Costos
        '                If chkCostos.Checked = True Then
        '                    .Columns("%_Avance_FW").Visible = True
        '                    .Columns("%_Avance_HV").Visible = True
        '                    .Columns("Precio").Visible = True
        '                    .Columns("Tope_MDP").Visible = True
        '                    .Columns("Tope_Aj").Visible = True
        '                    .Columns("Pagos_FW").Visible = True
        '                    .Columns("Dif_Real").Visible = True

        '                    listaColorear.Add("Costos")
        '                Else
        '                    .Columns("%_Avance_FW").Visible = False
        '                    .Columns("%_Avance_HV").Visible = False
        '                    .Columns("Precio").Visible = False
        '                    .Columns("Tope_MDP").Visible = False
        '                    .Columns("Tope_Aj").Visible = False
        '                    .Columns("Pagos_FW").Visible = False
        '                    .Columns("Dif_Real").Visible = False
        '                End If


        '                'Valorizacion
        '                If chk_valor.Checked = True Then
        '                    .Columns("Precio_Cos").Visible = True
        '                    .Columns("Precio_Ext").Visible = True
        '                    .Columns("Mcs_Mdp_U$S").Visible = True
        '                    .Columns("Mcs_Pilas_U$S").Visible = True
        '                    .Columns("Mcs_Hv_U$S").Visible = True
        '                    .Columns("Mcs_Entrega_U$S").Visible = True
        '                    listaColorear.Add("Valores")
        '                Else
        '                    .Columns("Precio_Cos").Visible = False
        '                    .Columns("Precio_Ext").Visible = False
        '                    .Columns("Mcs_Mdp_U$S").Visible = False
        '                    .Columns("Mcs_Pilas_U$S").Visible = False
        '                    .Columns("Mcs_Hv_U$S").Visible = False
        '                    .Columns("Mcs_Entrega_U$S").Visible = False
        '                End If


        '                .Columns("HsMaq_PD").Visible = False
        '                .Columns("Mcs_hr_PIL_PD").Visible = False
        '                .Columns("Mcs_Hrs_Tabla").Visible = False
        '                .Columns("CarrosPIL").Visible = False
        '                .Columns("DistanciaPD").Visible = False
        '                .Columns("DistPromPD").Visible = False
        '                .Columns("CarrosPD").Visible = False
        '                .Columns("CoefINV").Visible = False
        '                .Columns("GasOilPD").Visible = False
        '                .Columns("inv_vol_arb").Visible = False
        '                .Columns("mcs_estimados").Visible = False
        '                .Columns("Dist. Forecentro").Visible = False

        '                .Columns("inv_cierre_cosecha").Visible = False
        '                .Columns("inv_cierre_extraccion").Visible = False



        '                'Orden de columnas
        '                .Columns("PredioINV").DisplayIndex = 0
        '                .Columns("BloqueINV").DisplayIndex = 1
        '                .Columns("EspecieINV").DisplayIndex = 2
        '                If ColumnaOperario = True Then
        '                    .Columns("Operario").DisplayIndex = 3
        '                End If

        '                .Columns("SuperficieINV").DisplayIndex = 4
        '                .Columns("inv_vol_med").DisplayIndex = 5
        '                .Columns("LargoTrozaINV").DisplayIndex = 6
        '                .Columns("inv_distancia_extraccion").DisplayIndex = 7

        '                .Columns("%_Avance_HV").DisplayIndex = 8
        '                .Columns("%_Avance_FW").DisplayIndex = 9

        '                'Arboles
        '                .Columns("inv_arboles_totales").DisplayIndex = 10
        '                .Columns("Arboles_cosechados").DisplayIndex = 11
        '                .Columns("Arb_x_Ha_inv").DisplayIndex = 12
        '                .Columns("Arb_x_Ha_cuenta").DisplayIndex = 13

        '                'Volumen Total
        '                .Columns("MCS_MDP").DisplayIndex = 14
        '                .Columns("MCS_HAR").DisplayIndex = 15
        '                .Columns("MCS_PIL").DisplayIndex = 16
        '                .Columns("inv_entregado").DisplayIndex = 17


        '                'Volumen x Arboles
        '                .Columns("MDP_Vol_Arb").DisplayIndex = 18
        '                .Columns("PIL_Arb_Cosechados_Vol_Arb").DisplayIndex = 19
        '                .Columns("PIL_Vol_Arb").DisplayIndex = 20
        '                .Columns("ENT_Vol_Arb").DisplayIndex = 21

        '                'Prod. Harvester
        '                .Columns("Mcs/Hr_Hv_Tabla").DisplayIndex = 22
        '                .Columns("Mcs/Hr_Hv_Real_Tabla").DisplayIndex = 23

        '                .Columns("Mcs/Hr_Hv_Final").DisplayIndex = 24
        '                .Columns("Mcs/Hr_Hv_Real_Final").DisplayIndex = 25
        '                .Columns("Hv_Dif").DisplayIndex = 26

        '                'Prod . Forwarder
        '                .Columns("Mcs/Hr_Fw_Tabla").DisplayIndex = 27
        '                .Columns("Mcs/Hr_Fw_Real_Final").DisplayIndex = 28
        '                .Columns("Mcs/Hr_Fw_Real_Tabla").DisplayIndex = 29


        '                'Estimado Horas Harvester
        '                .Columns("Hv_Hs_Tot_Med").DisplayIndex = 30
        '                .Columns("Hv_Hs_Total").DisplayIndex = 31
        '                .Columns("Hv_Hs_Dif").DisplayIndex = 32
        '                .Columns("Hv_Hs_Dif_%").DisplayIndex = 33

        '                'Estimado Horas Forwarder
        '                .Columns("Fw_Hs_Tot_Med").DisplayIndex = 34
        '                .Columns("Fw_Hs_Total").DisplayIndex = 35
        '                .Columns("Fw_Hs_Dif").DisplayIndex = 36

        '                'Distancia estimada
        '                .Columns("Km_Tot_Estim").DisplayIndex = 37
        '                .Columns("Km_Tot_Real").DisplayIndex = 38
        '                .Columns("Km_Dif").DisplayIndex = 39

        '                'Costos
        '                .Columns("Precio").DisplayIndex = 40
        '                .Columns("Tope_MDP").DisplayIndex = 41
        '                .Columns("Tope_Aj").DisplayIndex = 42
        '                .Columns("Pagos_FW").DisplayIndex = 43
        '                .Columns("Dif_Real").DisplayIndex = 44

        '                'Valores
        '                .Columns("Precio_Cos").DisplayIndex = 45
        '                .Columns("Precio_Ext").DisplayIndex = 46
        '                .Columns("Mcs_Mdp_U$S").DisplayIndex = 47
        '                .Columns("Mcs_Hv_U$S").DisplayIndex = 48
        '                .Columns("Mcs_Pilas_U$S").DisplayIndex = 49
        '                .Columns("Mcs_Entrega_U$S").DisplayIndex = 50

        '                'Inmovilizar Paneles
        '                .Columns("PredioINV").Frozen = True

        '                If ColumnaOperario = True Then
        '                    .Columns("Operario").Frozen = True
        '                End If

        '                .Columns("BloqueINV").Frozen = True

        '                '.Columns("HsMaq_PD").DisplayIndex = 31
        '                '.Columns("Mcs_hr_PIL_PD").DisplayIndex = 32
        '                '.Columns("Mcs_Hrs_Tabla").DisplayIndex = 33
        '                '.Columns("CarrosPIL").DisplayIndex = 34
        '                '.Columns("DistanciaPD").DisplayIndex = 35
        '                '.Columns("DistPromPD").DisplayIndex = 36
        '                '.Columns("CarrosPD").DisplayIndex = 37
        '                '.Columns("CoefINV").DisplayIndex = 38
        '                '.Columns("GasOilPD").DisplayIndex = 39
        '                Me.colorear(listaColorear, colorBloque1, colorBloque2)
        '                Me.DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '            End With
        '        Catch ex As Exception
        '            MsgBox("Error al ordenar columnas")
        '        End Try
        '    End If
        'End If

    End Sub

End Class