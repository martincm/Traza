Imports Dominio, Inicio.IUMenu
Imports System.Speech.Recognition
Imports System.Speech.Recognition.SrgsGrammar
Imports System.Speech.Synthesis
Imports System.Globalization


Public Class IUConsultas
    Dim dtTodosLosAnimales As DataTable = unafachada.TodosLosAnimales
    Dim dtProductores, dtCategorias, dtAnimalesPreviaFiltro As DataTable
    Dim dtTodasLasCategorias As DataTable = unafachada.TodasLasCategorias.Tables(0)
    'Dim dtAnimalesFiltradosPropiedad As DataTable
    Dim dtTemporalPrincipal, dtTemporalSecundario As DataTable
    Dim bandera As Boolean = False
    Private campoAgrupaAnimales, campoAgrupaAnimales2 As String
    Private nombreAgrupacion, nombreAgrupacion2 As String
    Dim listaDicosePropietarios As New List(Of String)
    Dim listaFiltrosVarios As New List(Of String)
    Dim varPropietario As String
          


    Private Sub IUConsultas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'cargar Lista de Filtros
        listaFiltrosVarios.Add("ani_raza")
        listaFiltrosVarios.Add("ani_cruza")
        listaFiltrosVarios.Add("ani_ubicacion")
        listaFiltrosVarios.Add("ani_tenencia")
        listaFiltrosVarios.Add("ani_potrero")
        listaFiltrosVarios.Add("ani_vida")
        listaFiltrosVarios.Add("ani_trazabilidad")
        listaFiltrosVarios.Add("ani_errores")

        Me.dtpFecha.Value = Today
        dtgvCategorias.DataSource = Nothing
        dtgvCategorias.Rows.Clear()
        dtgvCategorias.Refresh()

        'dtPotreros = unafachada.TodosLosPotrerosTable
        'Try
        '    CargarComboDesdeDataTable(Me.cboPotreros, dtPotreros, "pot_nombre")
        'Catch ex As Exception

        'End Try

        Me.cboCategoria.Items.Clear()
        Me.cboCategoria.Items.Add("Dicose")
        Me.cboCategoria.Items.Add("Personalizada")
        Me.cboCategoria.SelectedIndex = 0

        dtgvSexo.Items.Add("Macho")
        dtgvSexo.Items.Add("Hembra")

        dtgvEntorado.Items.Add("No")
        dtgvEntorado.Items.Add("Si")

        dtgvCastrado.Items.Add("No")
        dtgvCastrado.Items.Add("Si")

        dtgvPrenado.Items.Add("No")
        dtgvPrenado.Items.Add("Si")


        Me.cboAgrupacion.Items.Clear()
        Me.cboAgrupacion.Items.Add("")
        Me.cboAgrupacion.Items.Add("Raza")
        Me.cboAgrupacion.Items.Add("Cruza")
        Me.cboAgrupacion.Items.Add("Propietario")
        Me.cboAgrupacion.Items.Add("Ubicacion")
        Me.cboAgrupacion.Items.Add("Tenencia")
        Me.cboAgrupacion.Items.Add("Potrero")
        Me.cboAgrupacion.Items.Add("Vida")
        Me.cboAgrupacion.Items.Add("Trazabilidad")
        Me.cboAgrupacion.Items.Add("Errores")
        Me.cboAgrupacion.SelectedItem = "Propietario"

        Me.cboAgrupacion2.Items.Clear()
        Me.cboAgrupacion2.Items.Add("Raza")
        Me.cboAgrupacion2.Items.Add("Cruza")
        Me.cboAgrupacion2.Items.Add("Propietario")
        Me.cboAgrupacion2.Items.Add("Ubicacion")
        Me.cboAgrupacion2.Items.Add("Tenencia")
        Me.cboAgrupacion2.Items.Add("Potrero")
        Me.cboAgrupacion2.Items.Add("Vida")
        Me.cboAgrupacion2.Items.Add("Trazabilidad")
        Me.cboAgrupacion2.Items.Add("Errores")
        Me.cboAgrupacion2.SelectedItem = "Ubicacion"

        Me.dtgvDetalle.ClipboardCopyMode = _
        DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        'Cargar Categorias perzonalizadas
        CargarCategoriasPersonalizadas()

        'Cargar Arbol con filtros
        CargarTreeView()

    End Sub

    Public Sub CargarCategoriasPersonalizadas()
       
        If Not dtTodasLasCategorias Is Nothing Then

            If dtTodasLasCategorias.Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To dtTodasLasCategorias.Rows.Count - 1
                    Dim unaFila As DataRow = dtTodasLasCategorias.Rows(i)
                    If unaFila("cat_tipo") = "PERSONALIZADA" Then
                        dtgvCategorias.Rows.Add()
                        Dim ultimaFila As Integer = dtgvCategorias.Rows.Count - 1
                        Try
                            Me.dtgvCategorias.Item("dtgvNombre", ultimaFila).Value() = unaFila("cat_nombre")
                            Me.dtgvCategorias.Item("dtgvSexo", ultimaFila).Value() = unaFila("cat_sexo")
                            Me.dtgvCategorias.Item("dtgvEdadMin", ultimaFila).Value() = unaFila("cat_edadMin")
                            Me.dtgvCategorias.Item("dtgvEdadMax", ultimaFila).Value() = unaFila("cat_edadMax")

                            If unaFila("cat_entorado") = 0 Then
                                Me.dtgvCategorias.Item("dtgvEntorado", ultimaFila).Value() = "No"
                            Else
                                Me.dtgvCategorias.Item("dtgvEntorado", ultimaFila).Value() = "Si"
                            End If

                            If unaFila("cat_castrado") = 0 Then
                                Me.dtgvCategorias.Item("dtgvCastrado", ultimaFila).Value() = "No"
                            Else
                                Me.dtgvCategorias.Item("dtgvCastrado", ultimaFila).Value() = "Si"
                            End If

                            If unaFila("cat_prenado") = 0 Then
                                Me.dtgvCategorias.Item("dtgvPrenado", ultimaFila).Value() = "No"
                            Else
                                Me.dtgvCategorias.Item("dtgvPrenado", ultimaFila).Value() = "Si"
                            End If

                            Me.dtgvCategorias.Item("dtgvDiasPermMin", ultimaFila).Value() = unaFila("cat_permMin")
                            Me.dtgvCategorias.Item("dtgvDiasPermMax", ultimaFila).Value() = unaFila("cat_permMax")

                        Catch ex As Exception

                        End Try

                    End If
                Next
            End If

        End If
    End Sub


    Public Function CargarComboDesdeDataTable(ByVal pCombo As ComboBox, ByVal pDataTable As DataTable, ByVal pColumna As String) As Boolean
        pCombo.Items.Clear()
        pCombo.Items.Add("TODOS")
        If pDataTable.Rows.Count > 0 Then
            For Each rw As DataRow In pDataTable.Rows
                pCombo.Items.Add(rw(pColumna))
            Next rw
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnConsulta_Click(sender As System.Object, e As System.EventArgs) Handles btnConsulta.Click
        If Not Me.cboAgrupacion.SelectedItem Is Nothing Then
            Consulta()
        End If

    End Sub

    Public Sub Consulta()
        If Me.cboAgrupacion.SelectedItem.ToString() <> Me.cboAgrupacion2.SelectedItem.ToString() Then
            Me.dtgvCategorias.Visible = False
            Try

                If Me.cboCategoria.SelectedItem = "Personalizada" Then
                    dtCategorias.Rows.Clear()

                    If dtgvCategorias.Rows.Count > 0 Then
                        Dim i As Integer = 1
                        Dim indice As Integer = 0
                        For Each unafila As DataGridViewRow In dtgvCategorias.Rows
                            Dim seleccionado As Boolean = unafila.Cells("dtgvSel").Value
                            If seleccionado = True Then
                                Dim nombre As String = unafila.Cells("dtgvNombre").Value
                                Dim sexo As String = unafila.Cells("dtgvSexo").Value
                                Dim edadMin As String = unafila.Cells("dtgvEdadMin").Value
                                Dim edadMax As String = unafila.Cells("dtgvEdadMax").Value

                                Dim entorado As String = unafila.Cells("dtgvEntorado").Value
                                If entorado = "No" Then
                                    entorado = 0
                                Else
                                    entorado = 1
                                End If

                                Dim castrado As String = unafila.Cells("dtgvCastrado").Value
                                If castrado = "No" Then
                                    castrado = 0
                                Else
                                    castrado = 1
                                End If

                                Dim prenado As String = unafila.Cells("dtgvPrenado").Value
                                If prenado = "No" Then
                                    prenado = 0
                                Else
                                    prenado = 1
                                End If

                                Dim DiasPermMin As String = unafila.Cells("dtgvDiasPermMin").Value
                                Dim DiasPermMax As String = unafila.Cells("dtgvDiasPermMax").Value
                                If validarCampos(indice) Then
                                    dtCategorias.Rows.Add(i, nombre, sexo, edadMin, edadMax, "PERSONALIZADA", entorado, castrado, prenado, 0, DiasPermMin, DiasPermMax)
                                End If
                                indice += 1
                                i += 1
                            End If
                        Next


                    End If
                End If


            Catch ex As Exception

            End Try

                If Not dtCategorias Is Nothing Then
                    If dtCategorias.Rows.Count > 0 Then

                    'FILTRO PREVIAMENTE LOS ANIMALES
                        dtAnimalesPreviaFiltro = Filtrar()

                        If Me.cboAgrupacion.SelectedItem.ToString.Length > 0 Then
                            Me.txtTotal.Text = 0
                        Me.nombreAgrupacion = Me.cboAgrupacion.SelectedItem
                            Me.nombreAgrupacion2 = Me.cboAgrupacion2.SelectedItem
                            bandera = False
                            'DATAGRID PRINCIPAL
                            dtTemporalPrincipal = New DataTable
                            dtgvAnimales.DataSource = Nothing
                            dtgvAnimales.Rows.Clear()
                            dtgvAnimales.Columns.Clear()
                            dtgvAnimales.Refresh()
                            dtgvAnimales.Columns.Add("dgvCantidad", "Uni.")
                            dtgvAnimales.Columns.Add("dgvCategoria", "Categorias")
                            dtgvAnimales.Columns.Add("dgvIdCategoria", "IdCategorias")

                            'DATAGRID SECUNDARIO
                            dtTemporalSecundario = New DataTable
                            dtgvDetalle.DataSource = Nothing
                            dtgvDetalle.Rows.Clear()
                            dtgvDetalle.Refresh()

                            campoAgrupaAnimales = "ani_" & nombreAgrupacion
                            campoAgrupaAnimales = campoAgrupaAnimales.ToLower()

                            'segunda agrupacion
                            campoAgrupaAnimales2 = "ani_" & nombreAgrupacion2
                            campoAgrupaAnimales2 = campoAgrupaAnimales2.ToLower()

                            Dim dataTableAgrupados As DataTable = unafachada.TodosAnimalesAgrupados(campoAgrupaAnimales, campoAgrupaAnimales2, Me.listaDicosePropietarios)
                            Dim nombreCampoAgrupa As String
                            Dim nombreCampoAgrupa2 As String
                            Dim valorCampoAgrupa As String
                            dtgvAnimales.Columns.Add(campoAgrupaAnimales, nombreAgrupacion)
                            dtgvAnimales.Columns.Add(campoAgrupaAnimales2, nombreAgrupacion2)
                            For Each rw As DataRow In dataTableAgrupados.Rows
                                nombreCampoAgrupa = rw(0)
                                nombreCampoAgrupa2 = rw(1)
                                valorCampoAgrupa = rw("Cantidad")
                                CargarDetalle(campoAgrupaAnimales, nombreCampoAgrupa, valorCampoAgrupa, campoAgrupaAnimales2, nombreCampoAgrupa2)
                                dtgvAnimales.Rows.Clear()
                                dtgvDetalle.Rows.Clear()
                            Next rw

                            dtgvAnimales.DataSource = Nothing
                            dtgvAnimales.Columns.Clear()
                            Me.dtgvAnimales.DataSource = dtTemporalPrincipal
                            dtgvDetalle.DataSource = Nothing
                            Me.dtgvDetalle.DataSource = dtTemporalPrincipal

                            'CRUZAMIENTO DE DATOS
                            Cruzar()


                        Else
                            MsgBox("Seleccione como va agrupar los datos")
                            Me.cboAgrupacion.Focus()
                        End If
                    Else
                        MsgBox("Seleccione/Ingrese al menos una categoria: " & Me.cboCategoria.SelectedItem)
                    End If
                Else
                    MsgBox("No existen categorias")
                End If

            Else
                MsgBox("Seleccione algun filtro")
            End If

    End Sub


    Public Sub CargarDetalle(ByVal pCampoAgrupa As String, ByVal pNombreCampoAgrupa As String, ByVal pValorCampoAgrupa As Long, ByVal pCampoAgrupa2 As String, ByVal pNombreCampoAgrupa2 As String)

        If Not dtAnimalesPreviaFiltro Is Nothing Then
            If dtAnimalesPreviaFiltro.Rows.Count > 0 Then
                Dim filtros As String = AplicarFiltrosDetalle(pCampoAgrupa, pNombreCampoAgrupa, pCampoAgrupa2, pNombreCampoAgrupa2)
                Dim FilasAnimalesFiltradas As DataRow() = dtAnimalesPreviaFiltro.Select(filtros)

                Dim i As Integer = 0
                While i < FilasAnimalesFiltradas.Length
                    ' Visualizamos el porcentaje en el Label
                    Dim UnAnimalRow As DataRow = FilasAnimalesFiltradas(i)
                    'Buscar Categoria a la que pertenece Animal
                    Dim CategoriaPerteneceRow As DataRow = unafachada.CategoriaQPertenece(UnAnimalRow, Me.dtpFecha.Value, dtCategorias)
                    Dim idCategoria As Integer
                    Dim nombreCategoria As String
                    'Buscar Categoria en DataGrid
                    If CategoriaPerteneceRow Is Nothing Then
                        idCategoria = 0
                        nombreCategoria = "Sin/Cat."
                    Else
                        idCategoria = CategoriaPerteneceRow("cat_id")
                        nombreCategoria = CategoriaPerteneceRow("cat_nombre")
                    End If


                    If Not BuscarCategoriaEnDataGrid(idCategoria) Then
                        Me.dtgvAnimales.Rows.Add()
                        Dim ultimaCelda As Integer = Me.dtgvAnimales.Rows.Count - 1
                        dtgvAnimales.Rows(ultimaCelda).Cells("dgvIdCategoria").Value = idCategoria
                        dtgvAnimales.Rows(ultimaCelda).Cells(pCampoAgrupa).Value = pNombreCampoAgrupa
                        dtgvAnimales.Rows(ultimaCelda).Cells(pCampoAgrupa2).Value = pNombreCampoAgrupa2
                        dtgvAnimales.Rows(ultimaCelda).Cells("dgvCategoria").Value = nombreCategoria
                        'If idCategoria = 0 Then
                        '    dtgvAnimales.Rows(ultimaCelda).Cells("dgvCategoria").Value = "Sin/Cat."
                        '    TreeView1.Nodes(0).Nodes.Add(idCategoria, "Sin/Cat.")
                        'Else
                        '    dtgvAnimales.Rows(ultimaCelda).Cells("dgvCategoria").Value = CategoriaPerteneceRow("cat_nombre")
                        'End If
                        dtgvAnimales.Rows(ultimaCelda).Cells("dgvCantidad").Value = 1
                    End If
                    FilasAnimalesFiltradas(i).Item("ani_categoria") = nombreCategoria
                    'Cargar en datagrid detalle
                    cargarDataGridDetalle(FilasAnimalesFiltradas(i), dtpFecha.Value, idCategoria)
                    i += 1
                    Me.txtTotal.Text += 1
                End While


            End If
        End If

        unafachada.ExportarDataGridViewADataTableNombredeCabezera(Me.dtgvAnimales, dtTemporalPrincipal)
        unafachada.ExportarDataGridViewADataTableNombredeCabezera(Me.dtgvDetalle, dtTemporalSecundario)


    End Sub

    Public Sub cargarDataGridDetalle(ByVal UnAnimalFiltrado As DataRow, ByVal pfecha As Date, ByVal pIdCategoria As Long)

        Me.dtgvDetalle.Rows.Add()
        dtgvDetalle.CurrentCell = dtgvDetalle.Rows(dtgvDetalle.RowCount - 1).Cells(0)
        dtgvDetalle.CurrentRow.Cells("numeracion").Value += dtgvDetalle.RowCount
        dtgvDetalle.CurrentRow.Cells("categoria").Value = UnAnimalFiltrado("ani_categoria")
        dtgvDetalle.CurrentRow.Cells("dispositivo").Value = UnAnimalFiltrado("ani_dispositivo")
        dtgvDetalle.CurrentRow.Cells("raza").Value = UnAnimalFiltrado("ani_raza")
        dtgvDetalle.CurrentRow.Cells("cruza").Value = UnAnimalFiltrado("ani_cruza")
        dtgvDetalle.CurrentRow.Cells("sexo").Value = UnAnimalFiltrado("ani_sexo")
        Dim Edad As Long
        Try
            Edad = DateDiff(DateInterval.Month, UnAnimalFiltrado("ani_fechaNac"), pfecha)
        Catch ex As Exception
            Edad = 0
        End Try
        dtgvDetalle.CurrentRow.Cells("edad").Value = Edad

        dtgvDetalle.CurrentRow.Cells("propietario").Value = UnAnimalFiltrado("ani_propietario")
        dtgvDetalle.CurrentRow.Cells("ubicacion").Value = UnAnimalFiltrado("ani_ubicacion")
        dtgvDetalle.CurrentRow.Cells("tenencia").Value = UnAnimalFiltrado("ani_tenencia")
        dtgvDetalle.CurrentRow.Cells("potrero").Value = UnAnimalFiltrado("ani_potrero")
        dtgvDetalle.CurrentRow.Cells("vida").Value = UnAnimalFiltrado("ani_vida")
        dtgvDetalle.CurrentRow.Cells("trazabilidad").Value = UnAnimalFiltrado("ani_trazabilidad")
        dtgvDetalle.CurrentRow.Cells("errores").Value = UnAnimalFiltrado("ani_errores")

        Dim dias As String
        Try
            dias = DateDiff(DateInterval.Day, UnAnimalFiltrado("ani_fecha_ubicacion_Actual"), pfecha)
        Catch ex As Exception
            dias = "N/A"
        End Try

        dtgvDetalle.CurrentRow.Cells("DiasUbicacionActual").Value = dias
        dtgvDetalle.CurrentRow.Cells("IdCategoria").Value = pIdCategoria

    End Sub

    Public Function BuscarCategoriaEnDataGrid(ByVal pIdCategoria As Integer) As Boolean
        Dim i As Integer
        Dim bandera As Boolean = False
        Do While i < dtgvAnimales.Rows.Count And bandera = False
            If dtgvAnimales.Rows(i).Cells("dgvIdCategoria").Value = pIdCategoria Then
                Me.dtgvAnimales.Item("dgvCantidad", i).Value() += 1
                bandera = True
                Exit Do
            End If
            i += 1
        Loop
        Return bandera
    End Function


    Function formularioAbierto(ByVal nomForm As String) As Boolean
        Dim f As Form
        For Each f In Me.MdiChildren
            If f.Name.ToUpper = nomForm.ToUpper Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    Public Function ComprobarFiltros(ByVal pDataGrid As DataGridView, ByVal pNombreCampoSeleccion As String) As Boolean
       
        Dim bandera As Boolean = False
        listaDicosePropietarios = New List(Of String)
        If Not pDataGrid Is Nothing Then
            If pDataGrid.Rows.Count > 0 Then
                For Each unafila As DataGridViewRow In pDataGrid.Rows
                    Dim seleccionado As Boolean = unafila.Cells(pNombreCampoSeleccion).Value
                    If seleccionado = True Then
                        bandera = True
                        If pNombreCampoSeleccion = "dtgvFiltroPropietarioSel" Then
                            listaDicosePropietarios.Add(unafila.Cells("dtgvFiltroPropietarioNombre").Value)
                        End If

                        If pNombreCampoSeleccion = "dtgvFiltroSel" Then

                        End If
                    End If
                Next
            End If
        End If
        Return bandera

    End Function


    Public Function AplicarFiltrosDetalle(ByVal pCampoAgrupa As String, ByVal pNombreCampoAgrupa As String, ByVal pCampoAgrupa2 As String, ByVal pNombreCampoAgrupa2 As String) As String
        Dim filtros As String = ""
        'If pNombreCampoAgrupa.Length > 0 Then
        '    filtros &= pCampoAgrupa & "=" & "'" & pNombreCampoAgrupa & "'" & " And "
        'End If

        If pNombreCampoAgrupa.Length > 0 Then
            filtros &= pCampoAgrupa & "=" & "'" & pNombreCampoAgrupa & "'" & " And "
        End If

        If pNombreCampoAgrupa2.Length > 0 Then
            filtros &= pCampoAgrupa2 & "=" & "'" & pNombreCampoAgrupa2 & "'" & " And "
        End If

        If filtros.Length > 0 Then
            filtros = filtros.Remove(filtros.Length - 5, 5)
        End If
        Return filtros

    End Function




    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub cboPotreros_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Public Sub Cruzar()
        If dtTemporalPrincipal.Rows.Count > 0 Then
            Me.dtgvDetalle.Visible = False
            Me.dtgvAnimales.DataSource = DataTableCruzado(dtTemporalPrincipal, "Categorias", campoAgrupaAnimales2)
            TotalFilasDataGrid()
            TotalColumnasDataGrid()

            ' Resize the master DataGridView columns to fit the newly loaded data.
            dtgvAnimales.AutoResizeColumns()

            ' Configure the details DataGridView so that its columns automatically 
            ' adjust their widths when the data changes.
            dtgvAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            bandera = True
        End If
    End Sub

    Public Sub TotalFilasDataGrid()

        'For indice As Integer = 0 To dtgvAnimales.Columns.Count - 1
        '    Dim nombreColumna As String = dtgvAnimales.Columns(indice).HeaderText

        'Next
        Dim i, col As Integer
        Dim SumaFila As Integer
        While i < dtgvAnimales.Rows.Count - 1
            SumaFila = 0
            For col = 2 To dtgvAnimales.Columns.Count - 1
                Try
                    SumaFila += Me.dtgvAnimales.Item(col, i).Value()
                Catch ex As Exception

                End Try

            Next
            Me.dtgvAnimales.Rows(i).Cells(dtgvAnimales.Columns.Count - 1).Value = SumaFila
            i += 1
        End While
    End Sub

    Public Sub TotalColumnasDataGrid()
        Dim i, col As Integer
        Dim SumaColumna As Integer
        For col = 2 To dtgvAnimales.Columns.Count - 1

            SumaColumna = 0
            While i < dtgvAnimales.Rows.Count - 1
                Try
                    SumaColumna += Me.dtgvAnimales.Item(col, i).Value()
                Catch ex As Exception

                End Try
                i += 1
            End While
            i = 0
            Me.dtgvAnimales.Rows(dtgvAnimales.Rows.Count - 1).Cells(col).Value = SumaColumna
        Next



    End Sub

    Public Function DataTableCruzado(ByVal pDataTable As DataTable, ByVal pCampoAgrupa As String, ByVal pCampoAgrupa2 As String) As DataTable
        'Dim filtros As String = "numeracion>0"
        'Dim undataTableCruzado As DataTable = RetornarFiltrarDataTableAgregarALista(pdataTable, filtros, "categoria")
        Dim tablaPrincipal As New DataTable
        tablaPrincipal.Columns.Add(nombreAgrupacion)
        If pCampoAgrupa.Length > 0 Then
            tablaPrincipal.Columns.Add(nombreAgrupacion2)
        End If

        Dim i As Integer
        Dim FilaAnterior, NombreFilaActual, NombreFilaActual2 As String

        'BARRA DE PROGRESO
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = pDataTable.Rows.Count - 1

        For i = 0 To pDataTable.Rows.Count - 1

            NombreFilaActual = pDataTable.Rows(i)(pCampoAgrupa).ToString()
            If NombreFilaActual <> FilaAnterior Then
                Try
                    tablaPrincipal.Columns.Add(NombreFilaActual)
                Catch ex As Exception

                End Try

                FilaAnterior = NombreFilaActual
            End If
        Next i

        'Agregar Filas
        FilaAnterior = ""
        Dim filaanterior2 As String = ""
        For i = 0 To pDataTable.Rows.Count - 1
            NombreFilaActual = pDataTable.Rows(i)(nombreAgrupacion).ToString()
            NombreFilaActual2 = pDataTable.Rows(i)(nombreAgrupacion2).ToString()
            If NombreFilaActual <> FilaAnterior Or NombreFilaActual2 <> filaanterior2 Then
                Try
                    tablaPrincipal.Rows.Add(NombreFilaActual)
                    Dim ultimaFila As Integer = tablaPrincipal.Rows.Count - 1

                    If pCampoAgrupa2.Length > 0 Then
                        tablaPrincipal.Rows(ultimaFila)(nombreAgrupacion2) = NombreFilaActual2
                    End If
                Catch ex As Exception

                End Try
                filaanterior2 = NombreFilaActual2
                FilaAnterior = NombreFilaActual
            End If
        Next i
        tablaPrincipal.Rows.Add("Totales")

        Dim valor, NombreColumna, filaAgrupa, filaAgrupa2 As String
        For i = 0 To pDataTable.Rows.Count - 1
            NombreColumna = pDataTable.Rows(i)(pCampoAgrupa).ToString()
            valor = pDataTable.Rows(i)("Uni.").ToString()
            filaAgrupa = pDataTable.Rows(i)(nombreAgrupacion).ToString()
            filaAgrupa2 = pDataTable.Rows(i)(nombreAgrupacion2).ToString()
            BuscarLugarVacio(NombreColumna, tablaPrincipal, valor, filaAgrupa, filaAgrupa2)
            ' Valor actual del Progressbar
            ProgressBar1.Value = i
        Next i
        'Dim ds As New DataSet
        'ds.Tables.Add(tablaPrincipal)
        'ds.WriteXmlSchema(Environment.CurrentDirectory & "\impresion.xml")
        tablaPrincipal.Columns.Add("Totales")
        Return tablaPrincipal
    End Function

    Public Sub BuscarLugarVacio(ByVal pNombreColumna As String, ByRef pDataTable As DataTable, ByVal pValorFila As String, ByVal pFilaAgrupa As String, ByVal pFilaAgrupa2 As String)

        If Not pDataTable Is Nothing Then
            If pDataTable.Rows.Count > 0 Then
                Dim indice As Integer = BuscarIndiceFilaVacia(pNombreColumna, pDataTable, pFilaAgrupa, pFilaAgrupa2)
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


    Public Function BuscarIndiceFilaVacia(ByVal pNombreColumna As String, ByRef pDataTable As DataTable, ByVal pFilaAgrupa As String, ByVal pFilaAgrupa2 As String) As Integer

        If pDataTable.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To pDataTable.Rows.Count - 1

                Dim Row As DataRow = pDataTable.Rows(i)
                Dim valorenColumna As String
                If Row(nombreAgrupacion) = pFilaAgrupa And Row(nombreAgrupacion2) = pFilaAgrupa2 Then
                    Try
                        valorenColumna = Row(pNombreColumna)
                    Catch ex As Exception
                        Return i
                    End Try
                End If

            Next i
        End If


    End Function


    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs)




    End Sub

    Private Sub dtgvAnimales_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvAnimales.CellContentClick
        '  I_DataGridView_CurrentCellChanged(sender, e)

    End Sub


    Private Sub I_DataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles dtgvAnimales.CurrentCellChanged
        If bandera = True Then
            If Me.dtgvAnimales.CurrentCellAddress.X < 0 Or Me.dtgvAnimales.CurrentCellAddress.Y < 0 Then Exit Sub

            ' The Windows Me.I_DataGridView object will have already deselected the current cell and selected the 
            ' new cell as per user navigation using mouse or cursor keys.  We just need to store the current
            ' co-ordinates for the currently selected cell.

            Me.txtColumna.Text = dtgvAnimales.Columns(Me.dtgvAnimales.CurrentCellAddress.X).Name
            Me.txtFila.Text = dtgvAnimales.Rows(Me.dtgvAnimales.CurrentCellAddress.Y).Cells(0).Value
            Try
                Me.txtFila2.Text = dtgvAnimales.Rows(Me.dtgvAnimales.CurrentCellAddress.Y).Cells(1).Value
            Catch ex As Exception

            End Try

            Try
                Me.txtValor.Text = dtgvAnimales.CurrentCell.Value
                MostrarDetalle(Me.txtColumna.Text, Me.txtFila.Text, Me.txtFila2.Text)

            Catch ex As Exception
                Me.txtValor.Text = 0
            End Try




            Exit Sub
        End If
    End Sub


    Public Sub MostrarDetalle(ByVal pColumna As String, ByVal pFila As String, ByVal pFila2 As String)
        dtgvDetalle.DataSource = Nothing
        dtgvDetalle.Rows.Clear()
        dtgvDetalle.Refresh()
        Me.txtDetalle.Text = 0
        Dim rows As DataRow()
        Try
            Dim cantTotal As Integer = dtTemporalSecundario.Rows.Count

            Dim filtro As String = "Categoria=" & "'" & pColumna & "'" & " and " & nombreAgrupacion & "=" & "'" & pFila & "'" & " and " & nombreAgrupacion2 & "=" & "'" & pFila2 & "'"
            rows = dtTemporalSecundario.Select(filtro, "Nº Disp.")
        Catch ex As Exception


        End Try
        If rows.Length > 0 Then
            For Each dr As DataRow In rows
                Me.dtgvDetalle.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13), dr(14), dr(15))
                Me.txtDetalle.Text += 1
            Next
            Me.dtgvDetalle.Visible = True

        End If

    End Sub

    Private Sub IUConsultas_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.dtgvDetalle.Visible = False
        dtgvCategorias.Visible = False
    End Sub

    Private Sub CopiarFilasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarFilasToolStripMenuItem.Click
        If dtgvDetalle.GetCellCount( _
            DataGridViewElementStates.Selected) > 0 Then
            Try
                ' Agregar seleccion a clipboard
                Clipboard.SetDataObject( _
                  dtgvDetalle.GetClipboardContent())
                '   Me.TextBox1.Text = Clipboard.GetText() 'Por si quiren presentarlo en texto(asignar propiedad multiline = true).
            Catch ex As System.Runtime.InteropServices.ExternalException
            End Try

        End If
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged
        'If Not dtCategorias Is Nothing Then
        '    If dtCategorias.Rows.Count > 0 Then
        '        dtCategorias.Rows.Clear()
        '    End If
        'End If

        If Me.cboCategoria.SelectedItem = "Personalizada" Then
            dtgvCategorias.Visible = True
        End If

        If Me.cboCategoria.SelectedItem = "Dicose" Then
            Try
                Dim filtro As String = "cat_tipo=" & "'" & "DICOSE" & "'"
                dtCategorias = SelectDataTable(dtTodasLasCategorias, filtro, "cat_nombre")

            Catch ex As Exception

            End Try

            dtgvCategorias.Visible = False

        End If

    End Sub

    Private Sub dtgvCategorias_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvCategorias.CellContentClick

    End Sub

    Private Sub dtgvCategorias_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvCategorias.CellEndEdit
        'Dim iniciando As Boolean = False
        'bEdit = True
        ' obtener indice de la columna  
        Dim columna As Integer = dtgvCategorias.CurrentCell.ColumnIndex
        Dim numeroFila As Integer = dtgvCategorias.CurrentRow.Index
        Dim colorCelda As Color
        If validarCampos(numeroFila) = False Then
            dtgvCategorias.Rows(numeroFila).Cells("dtgvSel").ReadOnly = True
            colorCelda = Color.Bisque
            PreCargarGridCategorias(numeroFila)

        Else
            dtgvCategorias.Rows(numeroFila).Cells("dtgvSel").ReadOnly = False
            colorCelda = Color.LightGreen
            dtgvCategorias.AllowUserToAddRows = True
        End If


        'Pintar celdas
        For i As Integer = 0 To dtgvCategorias.Columns.Count - 1
            dtgvCategorias.Rows(numeroFila).Cells(i).Style.BackColor = colorCelda
        Next

    End Sub

    Public Function validarCampos(ByVal pnumeroFila As Integer) As Boolean
        Dim nombre As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvNombre").Value
        Dim sexo As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvSexo").Value
        Dim edadMin As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvEdadMin").Value
        Dim edadMax As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvEdadMax").Value
        Dim entorado As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvEntorado").Value
        Dim castrado As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvCastrado").Value
        Dim prenado As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvPrenado").Value
        Dim DiasPermMin As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvDiasPermMin").Value
        Dim DiasPermMax As String = dtgvCategorias.Rows(pnumeroFila).Cells("dtgvDiasPermMax").Value

        If nombre Is Nothing Or sexo Is Nothing Or edadMin Is Nothing Or edadMax Is Nothing Or entorado Is Nothing Or castrado Is Nothing Or prenado Is Nothing Or DiasPermMin Is Nothing Or DiasPermMax Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function PreCargarGridCategorias(ByVal pnumeroFila As Integer) As Boolean

        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvSexo").Value = "Macho"
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvEdadMin").Value = 1
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvEdadMax").Value = 200
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvEntorado").Value = "No"
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvCastrado").Value = "Si"
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvPrenado").Value = "No"
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvDiasPermMin").Value = 0
        dtgvCategorias.Rows(pnumeroFila).Cells("dtgvDiasPermMax").Value = 10000

    End Function

    Private Sub btnExporta2_Click(sender As System.Object, e As System.EventArgs) Handles btnExporta2.Click
        If Not dtTemporalPrincipal Is Nothing Then
            If Me.dtTemporalPrincipal.Rows.Count > 0 Then
                Dim dataTable As DataTable
                dataTable = unafachada.ExportarDataGridView(Me.dtgvAnimales)
                unafachada.ExportarExcelDataTable(dataTable)
            End If
        End If

    End Sub

    Private Sub btnIngresoCat_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresoCat.Click
        If Not formularioAbierto("IUIngresoCategorias") Then
            Dim unIUIngresoCategorias As New IUIngresoCategorias
            unIUIngresoCategorias.Show()
        End If
    End Sub

    Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String, ByVal sort As String) As DataTable
        If filter.Length > 0 Then
            Dim rows As DataRow()

            Dim dtNew As DataTable

            ' copy table structure
            dtNew = dt.Clone()

            ' sort and filter data
            rows = dt.Select(filter, sort)

            ' fill dtNew with selected rows

            For Each dr As DataRow In rows
                dtNew.ImportRow(dr)

            Next

            ' return filtered dt
            Return dtNew
        Else
            Return dt
        End If
    End Function


    Private Sub cboAgrupacion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAgrupacion.SelectedIndexChanged
        'If Not Me.cboPropietario.SelectedItem Is Nothing Then
        '    If Me.cboPropietario.SelectedItem.ToString.Length > 0 Then
        '        If ComprobarFiltros(Me.dtgvFiltrosPropiedad, "dtgvFiltroPropietarioSel") Then
        '            Dim filtrosPropiedad As String = AplicarFiltrosPreviamentePropiedad()
        '            'FILTRO PREVIAMENTE LOS ANIMALES
        '            'dtAnimalesFiltradosPropiedad = SelectDataTable(dtTodosLosAnimales, filtrosPropiedad, campoAgrupaAnimales)
        '            If Me.cboAgrupacion.SelectedItem.ToString.Length > 0 Then
        '                BuscarFiltros(Me.dtgvFiltros, Me.cboAgrupacion)
        '            Else
        '                Me.dtgvFiltros.Visible = False
        '            End If
        '        Else
        '            MsgBox("Seleccione al mennos un propietario")
        '            Me.cboPropietario.Focus()
        '            Me.dtgvFiltros.Visible = False
        '        End If
        '    End If
        'End If

    End Sub



    Public Sub BuscarFiltros(ByVal pDatagrid As DataGridView, ByVal pCombo As ComboBox)
        pDatagrid.Visible = True
        Dim campoFiltro As String
        campoFiltro = "ani_" & pCombo.SelectedItem
        campoFiltro = campoFiltro.ToLower()
        Dim dataTableAgrupados As DataTable = unafachada.TodosAnimalesAgrupados(campoFiltro, "", Me.listaDicosePropietarios)

        If Not dataTableAgrupados Is Nothing Then
            If dataTableAgrupados.Rows.Count > 0 Then
                pDatagrid.Rows.Clear()
                Dim i As Integer = 0
                For i = 0 To dataTableAgrupados.Rows.Count - 1
                    Dim unaFila As DataRow = dataTableAgrupados.Rows(i)

                    'Dim ultimaFila As Integer = dtgvCategorias.Rows.Count - 1
                    Try
                        Dim seleccionado As Boolean = True
                        Dim Nombre As String = unaFila(campoFiltro)
                        Dim Cantidad As Long = unaFila("Cantidad")
                        pDatagrid.Rows.Add(seleccionado, Cantidad, Nombre)
                        'Me.dtgvFiltros.Item("dtgvFiltroSel", ultimaFila).Value() = True
                        'Me.dtgvFiltros.Item("dtgvFiltroNombre", ultimaFila).Value() = unaFila(campoFiltro)
                        'Me.dtgvFiltros.Item("dtgvFiltroCantidad", ultimaFila).Value() = unaFila("Cantidad")

                    Catch ex As Exception

                    End Try

                Next
                ' Resize the master DataGridView columns to fit the newly loaded data.
                pDatagrid.AutoResizeColumns()

                ' Configure the details DataGridView so that its columns automatically 
                ' adjust their widths when the data changes.
                pDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            End If
        End If


    End Sub

    Private Sub cboPropietario_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'If Me.cboPropietario.SelectedItem.ToString.Length > 0 Then
        '    Me.dtgvFiltrosPropiedad.Visible = True
        'Else
        '    dtgvFiltrosPropiedad.Visible = False
        'End If
    End Sub

    Public Sub cargarPropietarios(ByVal pDatagrid As DataGridView)
        Dim campoFiltro As String
        campoFiltro = "ani_propietario"
        campoFiltro = campoFiltro.ToLower()
        Dim dataTableAgrupados As DataTable = unafachada.TodosAnimalesAgrupados(campoFiltro, "", Me.listaDicosePropietarios)

        If Not dataTableAgrupados Is Nothing Then
            If dataTableAgrupados.Rows.Count > 0 Then
                pDatagrid.Rows.Clear()
                Dim i As Integer = 0
                For i = 0 To dataTableAgrupados.Rows.Count - 1
                    Dim unaFila As DataRow = dataTableAgrupados.Rows(i)

                    'Dim ultimaFila As Integer = dtgvCategorias.Rows.Count - 1
                    Try
                        Dim seleccionado As Boolean = True
                        Dim Nombre As String = unaFila(campoFiltro)
                        Dim Cantidad As Long = unaFila("Cantidad")
                        pDatagrid.Rows.Add(seleccionado, Cantidad, Nombre)

                        'Me.dtgvFiltros.Item("dtgvFiltroSel", ultimaFila).Value() = True
                        'Me.dtgvFiltros.Item("dtgvFiltroNombre", ultimaFila).Value() = unaFila(campoFiltro)
                        'Me.dtgvFiltros.Item("dtgvFiltroCantidad", ultimaFila).Value() = unaFila("Cantidad")

                    Catch ex As Exception

                    End Try

                Next
                ' Resize the master DataGridView columns to fit the newly loaded data.
                pDatagrid.AutoResizeColumns()

                ' Configure the details DataGridView so that its columns automatically 
                ' adjust their widths when the data changes.
                pDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            End If
        End If


    End Sub

    Public Sub CargarTreeView()
        Dim campoFiltro As String
        campoFiltro = "ani_propietario"
        campoFiltro = campoFiltro.ToLower()
        Dim dataTableAgrupados As DataTable = unafachada.TodosAnimalesAgrupados(campoFiltro, "", Me.listaDicosePropietarios)
        If Not dataTableAgrupados Is Nothing Then
            If dataTableAgrupados.Rows.Count > 0 Then
                Dim i As Integer = 0
                Me.TreeFiltros.Nodes.Add(campoFiltro, "Propietario")
                For i = 0 To dataTableAgrupados.Rows.Count - 1
                    Dim unaFila As DataRow = dataTableAgrupados.Rows(i)

                    Try
                        Dim nombreNodo As String = unaFila(campoFiltro)
                        Dim Cantidad As Long = unaFila("Cantidad")

                        Me.TreeFiltros.Nodes(campoFiltro).Nodes.Add(nombreNodo, nombreNodo & "(" & Cantidad & ")")
                        CargarTreeViewSecundarios(nombreNodo, nombreNodo)
                    Catch ex As Exception

                    End Try

                Next


            End If
        End If


    End Sub

    Public Sub CargarTreeViewSecundarios(ByVal pNombreDelNodo As String, ByVal pDicosePropiedad As String)
        'Dim campoFiltro As String
        'TextoFiltrado = ""
        'campoFiltro = "ani_raza"
        'campoFiltro = campoFiltro.ToLower()

        For Each campoFiltro As String In Me.listaFiltrosVarios
            campoFiltro = campoFiltro.ToLower()

            For Each nodo As TreeNode In Me.TreeFiltros.Nodes("ani_propietario").Nodes(pNombreDelNodo).Nodes
                If nodo.Name = campoFiltro Then
                    Exit Sub
                End If
            Next

            Dim dataTableAgrupados As DataTable = unafachada.TodosAnimalesAgrupadosxDicose(campoFiltro, "", pDicosePropiedad)
            Dim nombreMostrar As String = campoFiltro.Substring(4, campoFiltro.Length - 4)
            Me.TreeFiltros.Nodes("ani_propietario").Nodes(pNombreDelNodo).Nodes.Add(campoFiltro, nombreMostrar)

            If Not dataTableAgrupados Is Nothing Then
                If dataTableAgrupados.Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To dataTableAgrupados.Rows.Count - 1
                        Dim unaFila As DataRow = dataTableAgrupados.Rows(i)

                        Try
                            Dim Nombre As String = unaFila(campoFiltro)
                            Dim Cantidad As Long = unaFila("Cantidad")

                            Me.TreeFiltros.Nodes("ani_propietario").Nodes(pNombreDelNodo).Nodes(campoFiltro).Nodes.Add(Nombre, Nombre & "(" & Cantidad & ")")

                        Catch ex As Exception

                        End Try

                    Next

                End If
            End If
        Next

    End Sub

    Public Function RecorrerNodos() As List(Of String())
        Dim listaFiltros As New List(Of String())
        'Se Declara una colección de nodos apartir de tu Treeview
        'del que se va a recorrer
        Dim nodes As TreeNodeCollection = TreeFiltros.Nodes
        'Se recorren los nodos principales
        For Each n As TreeNode In nodes
            'Se Declara un metodo para que recorra los hijos de los principales
            'Y los hijos de los hijos....Recorrido Total en pocas palabras
            'Para ello se envía el nodo actual para evaluar si tiene hijos
            RecorrerNodos(n, listaFiltros)
        Next
        Return listaFiltros
    End Function

    Private Function RecorrerNodos(treeNode As TreeNode, ByRef pListaFiltros As List(Of String())) As List(Of String())
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá
            'para luego verificar si esta o no checado
            For Each tn As TreeNode In treeNode.Nodes
                'Se Verifica si esta marcado...
                If tn.Checked = True Then
                    ''Si esta marcado mostramos el texto del nodo
                    'Dim Padre As String = tn.Parent.Name
                    'Dim nombreCampo As String = tn.Name
                    'Dim valorCampo As String = tn.Text


                    'If Padre = "ani_propietario" Then
                    '    Dim empieza As Integer = valorCampo.IndexOf("(")
                    '    Dim termina As Integer = valorCampo.IndexOf(")")
                    '    valorCampo = valorCampo.Remove(empieza, valorCampo.Length - empieza)

                    '    varPropietario = valorCampo
                    'End If

                    'If Not nombreCampo.Contains("ani") Then
                    '    Dim filtro(2) As String
                    '    filtro(0) = Padre
                    '    filtro(1) = valorCampo
                    '    filtro(2) = varPropietario
                    '    pListaFiltros.Add(filtro)
                    'End If
                    If tn.Parent.Name = "ani_propietario" Then
                        Dim empieza As Integer = tn.Text.IndexOf("(")
                        Dim termina As Integer = tn.Text.IndexOf(")")
                        varPropietario = tn.Text.Remove(empieza, tn.Text.Length - empieza)

                    End If
                Else
                    If tn.Parent.Name = "ani_propietario" Then
                        Dim empieza As Integer = tn.Text.IndexOf("(")
                        Dim termina As Integer = tn.Text.IndexOf(")")
                        varPropietario = tn.Text.Remove(empieza, tn.Text.Length - empieza)
                    End If

                    'Si esta marcado mostramos el texto del nodo
                    Dim Padre As String = tn.Parent.Name
                    Dim nombreCampo As String = tn.Name
                    Dim valorCampo As String = tn.Text

                   

                    If Not nombreCampo.Contains("ani") Then
                        Dim empieza2 As Integer = tn.Text.IndexOf("(")
                        Dim termina2 As Integer = tn.Text.IndexOf(")")
                        valorCampo = tn.Text.Remove(empieza2, tn.Text.Length - empieza2)
                        Dim filtro(2) As String
                        filtro(0) = Padre
                        filtro(1) = valorCampo
                        filtro(2) = varPropietario
                        pListaFiltros.Add(filtro)
                    End If
                    'MsgBox(tn.Text)

                End If
                'Ahora hago verificacion a los hijos del nodo actual            
                'Esta iteración no acabara hasta llegar al ultimo nodo principal
                RecorrerNodos(tn, pListaFiltros)
            Next
            Return pListaFiltros
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Function

    Private Sub MarcarTodosLosNodos(treeNode As TreeNode, ByVal pValor As Boolean)
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá
            'para luego verificar si esta o no checado
            For Each tn As TreeNode In treeNode.Nodes
                'Se Verifica si esta marcado...
                tn.Checked = pValor
                'Ahora hago verificacion a los hijos del nodo actual            
                'Esta iteración no acabara hasta llegar al ultimo nodo principal
                MarcarTodosLosNodos(tn, pValor)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Public Sub MarcarTodosLosNodos(ByVal pvalor As Boolean)
        'Se Declara una colección de nodos apartir de tu Treeview
        'del que se va a recorrer
        Dim nodes As TreeNodeCollection = TreeFiltros.Nodes
        'Se recorren los nodos principales
        For Each n As TreeNode In nodes
            'Se Declara un metodo para que recorra los hijos de los principales
            'Y los hijos de los hijos....Recorrido Total en pocas palabras
            'Para ello se envía el nodo actual para evaluar si tiene hijos
            MarcarTodosLosNodos(n, pvalor)
        Next

    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MarcarTodosLosNodos(True)

        ' RecorrerNodos()
    End Sub

    Private Sub TreeFiltros_AfterCheck(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeFiltros.AfterCheck
        'Dim nodoRaiz As TreeNode = e.Node

        'Dim nombreDelNodo As String = e.Node.Name
        'If Not nombreDelNodo = "ani_propietario" Then
        If e.Node.Checked Then
            MarcarTodosLosNodos(e.Node, True)

            'If nodoRaiz.Parent.Name = "ani_propietario" Then
            '    Me.listaDicosePropietarios.Add(nombreDelNodo)
            '    CargarTreeViewSecundarios(nombreDelNodo, nombreDelNodo)
            'End If

        Else
            MarcarTodosLosNodos(e.Node, False)
            '    If nodoRaiz.PrevVisibleNode.Name = "ani_propietario" Then
            '        'Dim dicose As String = e.Node.Text.Substring(0, 9)
            '        QuitarDicosePropietario(nombreDelNodo)
            '    End If
            'End If
        End If
    End Sub

    Private Sub TreeFiltros_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeFiltros.AfterSelect
        

    End Sub

    Public Function QuitarDicosePropietario(ByVal pNombre As String) As Boolean
        If listaDicosePropietarios.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To Me.listaDicosePropietarios.Count - 1
                If listaDicosePropietarios.Item(i) = pNombre Then
                    listaDicosePropietarios.RemoveAt(i)
                    Return True
                End If
            Next
            Return False
        End If
    End Function

    Public Function BuscarDicoseEnLista(ByVal pNombre As String, ByRef pLista As List(Of String)) As Boolean
        Dim i As Integer = 0
        For i = 0 To pLista.Count - 1
            If pLista.Item(i) = pNombre Then
                Return True
            End If
        Next
        Return False
    End Function

    

    Public Function Filtrar() As DataTable
        Dim FiltroPropietarios As String = ""
        Dim dataTableFiltrado As DataTable = SelectDataTable(dtTodosLosAnimales, "", "")
        Me.txtNotas.Text = ""
        Dim lista As List(Of String()) = RecorrerNodos()
        Dim PropietariosMarcados As New List(Of String)
        For Each unPropietario() As String In lista
            Dim DicosePropietario As String = unPropietario(2)
            If Not BuscarDicoseEnLista(DicosePropietario, PropietariosMarcados) Then
                PropietariosMarcados.Add(DicosePropietario)
            End If

        Next

        For Each unPropietario As String In PropietariosMarcados
            For Each unaFila As String In listaFiltrosVarios
                Dim unaListaCadenas As List(Of String) = SepararCamposConsulta(lista, unaFila, unPropietario)
                Dim Cadena As String = ""

                If unaListaCadenas.Count > 0 Then
                    For Each unaCadena As String In unaListaCadenas
                        Cadena &= unaCadena & " And "
                    Next
                    Cadena = Cadena.Remove(Cadena.Length - 5, 5)
                    Cadena = "ani_propietario <>" & "'" & unPropietario & "'" & " Or " & Cadena
                    'Prueba SQL
                    ' Dim unDataSet As DataTable = unafachada.TodosAnimalesFiltrados(Cadena, "ani_raza", "ani_raza")

                    dataTableFiltrado = SelectDataTable(dataTableFiltrado, Cadena, "ani_raza")
                    Me.txtNotas.Text &= Cadena & vbCrLf

                    Me.TextBoxX1.Text = dataTableFiltrado.Rows.Count
                End If
            Next
        Next

        Return dataTableFiltrado
    End Function

    Public Function SepararCamposConsulta(ByVal pLista As List(Of String()), ByVal pNombreCampo As String, ByVal pPropietario As String) As List(Of String)
        Dim unaLista As New List(Of String)
        Dim nombreCampoAnterior As String = ""
        Dim operador As String = ""
        Dim cadena As String = ""
        For Each unaFila As String() In pLista
            Dim nombreCampo As String = unaFila(0)
            Dim valorCampo As String = unaFila(1)
            'Dim empieza As Integer = valorCampo.IndexOf("(")
            'Dim termina As Integer = valorCampo.IndexOf(")")
            'Try
            'valorCampo = valorCampo.Remove(empieza, valorCampo.Length - empieza)
            'Catch ex As Exception
            'End Try
            Dim Propietario As String = unaFila(2)
            '*************************************************************************

            If nombreCampo = pNombreCampo And Propietario = pPropietario Then
                cadena = nombreCampo & " <> " & "'" & valorCampo & "'" & operador
                unaLista.Add(cadena)
            End If
        Next
        Return unaLista
    End Function

    Public Function FiltrarxPropietario(ByVal pLista As List(Of String()), ByRef pListaPropietariosNoMarcados As List(Of String)) As DataTable
        Dim DataTablePropietarios As DataTable
        Dim FiltroPropietarios As String = ""
        Dim nombreCampoAnterior As String = ""
        Dim operador As String = ""
        For Each unaFila As String() In pLista
            Dim nombreCampo As String = unaFila(0)
            Dim valorCampo As String = unaFila(1)
            Dim Propietario As String = unaFila(2)

            'If nombreCampoAnterior <> nombreCampo Then
            '    If Not nombreCampo = "ani_propietario" Then
            '        operador = " And "
            '    Else
            '        operador = ""
            '    End If
            'Else
            '    operador = " Or "
            'End If

            'Dim empieza As Integer = valorCampo.IndexOf("(")
            'Dim termina As Integer = valorCampo.IndexOf(")")
            'valorCampo = valorCampo.Remove(empieza, valorCampo.Length - empieza)
            'nombreCampoAnterior = nombreCampo

            If nombreCampo = "ani_propietario" Then
                pListaPropietariosNoMarcados.Add(valorCampo)
                FiltroPropietarios &= "ani_propietario<>" & valorCampo & " Or "
            End If


        Next

        If FiltroPropietarios.Length > 0 Then
            FiltroPropietarios = FiltroPropietarios.Remove(FiltroPropietarios.Length - 4, 4)
            DataTablePropietarios = SelectDataTable(dtTodosLosAnimales, FiltroPropietarios, campoAgrupaAnimales)
            Return DataTablePropietarios
        End If

    End Function

  
End Class