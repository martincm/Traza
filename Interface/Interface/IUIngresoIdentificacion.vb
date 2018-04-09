Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class IUIngresoIdentificacion
    Inherits DevComponents.DotNetBar.Office2007Form

    Dim dtRaza, dtProductores As DataTable
    Dim vIdProductor As Integer
    Dim vTipoIngreso As String
    Dim vCantidadSeleccionados As Integer
    Dim vCantidadDisponibles As Integer
    Dim vCantidadIngresados As Integer
    Dim prtSettings As PrinterSettings
    Dim reporte, reporteCopia As Dac.ReporteD1
    Dim numeraPaginas As Integer = 1

    Private Sub IUIngresoIdentificacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvCruza.Items.Add("")
        'Productor
        dtProductores = unafachada.TodosLosProductoresTable
        Me.cboProductor.Items.Clear()
        For Each unaFila As DataRow In dtProductores.Rows
            Me.cboProductor.Items.Add(unaFila("pro_nombre").ToString)
        Next
        Me.cboProductor.SelectedIndex = 0

        'Razas
        dtRaza = unafachada.TodosLasRazasTable
        Me.cboRaza.Items.Clear()
        Me.cboCruza.Items.Clear()
        Me.cboCruza.Items.Add("")
        For Each unaFila As DataRow In dtRaza.Rows
            Me.cboRaza.Items.Add(unaFila("raz_abr"))
            Me.cboCruza.Items.Add(unaFila("raz_abr"))
        Next
        Me.cboRaza.SelectedIndex = 0
        Me.cboCruza.SelectedIndex = 0
        Dim i As Integer
        For i = 0 To dtRaza.Rows.Count - 1
            dgvRaza.Items.Add(dtRaza.Rows(i).Item("raz_abr"))
            dgvCruza.Items.Add(dtRaza.Rows(i).Item("raz_abr"))
        Next i

        'COMBO SEXO
        Me.cboSexo.Items.Clear()
        Me.cboSexo.Items.Add("Macho")
        dgvSexo.Items.Add("Macho")
        Me.cboSexo.Items.Add("Hembra")
        dgvSexo.Items.Add("Hembra")
        Me.cboSexo.SelectedIndex = 0

        Me.dgvCastrado.Items.Clear()
        Me.dgvCastrado.Items.Add("NO")
        Me.dgvCastrado.Items.Add("SI")
        Me.cboCastrado.Items.Clear()
        Me.cboCastrado.Items.Add("NO")
        Me.cboCastrado.Items.Add("SI")

        Limpiar()

        With dtgvAnimales
            Dim col As New CalendarColumn()
            col.Name = "dgvNacimiento"
            col.HeaderText = "Fecha Nac."
            col.Width = 70
            Dim nombre As String = col.Name
            .Columns.Insert(1, col)
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige
            'LIMPIAR DATAGRID
            .Refresh()
        End With

    End Sub


    Public Sub cargarIngresos(ByVal pIdIngresos As Integer)
        limpiarGrid()
        Me.cboVersiones.Items.Clear()
        Me.cboVersiones.Items.Add("")
        Dim cadenaAgrupa As String = "SELECT ingresosLineas.Ing_Lin_Version AS Version, Count(Ing_Lin_id) AS Cantidad" & _
        " FROM ingresosLineas WHERE ingresosLineas.Ing_Lin_Version>0 AND Ing_Lin_IdCabezal=" & pIdIngresos & " GROUP BY ingresosLineas.Ing_Lin_Version"
        Dim detalleVersiones As DataSet = unafachada.EjecutarConsultaGENERICADataSet(cadenaAgrupa)

        If Not detalleVersiones Is Nothing Then
            If detalleVersiones.Tables(0).Rows.Count > 0 Then
                Dim i As Integer = 0
                Dim cantVersiones As Integer = 1
                For i = 0 To detalleVersiones.Tables(0).Rows.Count - 1
                    Dim unaFila As DataRow = detalleVersiones.Tables(0).Rows(i)
                    Me.cboVersiones.Items.Add(cantVersiones & "- NumOp: " & unaFila("version"))
                    cantVersiones += 1
                Next
                Me.cboVersiones.SelectedIndex = -1
            End If
        End If

        Dim bandera As Boolean = False
        'Limpiar()
        Dim cabezalOperaciones As DataRow = unafachada.BuscarCabezalIngresos(pIdIngresos)

        If Not cabezalOperaciones Is Nothing Then
            Me.txtCodigo.Text = cabezalOperaciones("Ing_Id")
            'Me.txtTitulo.Text = cabezalOperaciones("Ing_Titulo")
            Me.txtNumOperacion.Text = cabezalOperaciones("Ing_NumOperacion")
            Me.txtDesde.Text = cabezalOperaciones("Ing_Desde")
            Me.txtHasta.Text = cabezalOperaciones("Ing_Hasta")
            vIdProductor = cabezalOperaciones("Ing_IdProductor")
            Me.cboProductor.SelectedItem = cabezalOperaciones("Ing_NomProductor")
            'Me.dtpFecha.Value = cabezalOperaciones("Ing_fecha")
            Me.txtDicosePropietario.Text = cabezalOperaciones("Ing_DicosePropietario")
            Me.cboDicoseFisico.SelectedItem = cabezalOperaciones("Ing_DicoseLugarFisico")
            vTipoIngreso = cabezalOperaciones("Ing_TipoIngreso")
            ' Me.NudCnt.Text = cabezalOperaciones("Ing_TotalAnimales")
            Dim Cabanula As String = cabezalOperaciones("Ing_anula")
            '
            Me.cboPaginas.Items.Clear()
            Me.cboPaginas.Items.Add("Todas")
            Dim cantPaginas As Integer = cabezalOperaciones("Ing_Paginas")
            Dim i As Integer
            For i = 1 To cantPaginas
                Me.cboPaginas.Items.Add(i)
            Next

            Dim version As Integer
            Try
                version = Me.cboVersiones.SelectedItem
            Catch ex As Exception
                version = 0
            End Try
            cargarDetalleDataGrid(bandera, version, Me.txtCodigo.Text)
        End If

        If bandera = False Then
            ContarTodosElementos()
        End If
    End Sub

    Public Sub cargarDetalleDataGrid(ByRef bandera As Boolean, ByVal pVersion As Integer, ByVal pCabezal As Integer)
        Dim cargarTodasVersiones As Boolean
        Dim undsIngresosDetalles As DataSet
        If pVersion = 0 Then
            cargarTodasVersiones = True
        Else
            cargarTodasVersiones = False
        End If

        undsIngresosDetalles = unafachada.BuscarDetalleIngresosLineas(Me.txtCodigo.Text)


        If Not undsIngresosDetalles Is Nothing Then
            If undsIngresosDetalles.Tables(0).Rows.Count > 0 Then
                'PRE CARGAR DATAGRID 
                cargarDataGrid(undsIngresosDetalles.Tables(0), pVersion, cargarTodasVersiones)
            End If
            '    Dim i As Integer = 0
            '    For i = 0 To undsIngresosDetalles.Tables(0).Rows.Count - 1
            '        Dim unaFila As DataRow = undsIngresosDetalles.Tables(0).Rows(i)
            '        If unaFila("Ing_Lin_Version") > 0 Then
            '            BuscarDispositivoEnDatagrid(unaFila("Ing_Lin_Dispositivo"), unaFila)
            '        End If

            '    Next
            'Else
            '    ' MsgBox("Sin Detalle")
            'End If
        Else
            MsgBox("Error en Detalle")
            bandera = True
            With dtgvAnimales
                .Columns("dgvDispositivo").ReadOnly = True
                .DefaultCellStyle.BackColor = Color.Beige
                'LIMPIAR DATAGRID
                .DataSource = Nothing
                .Rows.Clear()
                .Refresh()
            End With
        End If
    End Sub

    'Public Sub BuscarDispositivoEnDatagrid(ByVal pDispositivo As String, ByVal pUnaFila As DataRow)
    '    Dim i As Integer = 0
    '    While i < dtgvAnimales.Rows.Count
    '        Dim disDatagrid As String = dtgvAnimales.Rows(i).Cells("dgvDispositivo").Value

    '        If disDatagrid = pDispositivo Then
    '            dtgvAnimales.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
    '            DesHabilitarEdicionDataGrid(i, True)
    '            Dim mes As Date = pUnaFila("Ing_Lin_FechaNac")
    '            mes = DateSerial(Year(mes), Month(mes) + 0, 1)
    '            Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = mes
    '            ' Me.dtgvAnimales.Item("dgvDispositivo", i).Value() = pUnaFila("ani_dispositivo")
    '            Me.dtgvAnimales.Item("dgvRaza", i).Value() = pUnaFila("Ing_Lin_Raza")
    '            Me.dtgvAnimales.Item("dgvCruza", i).Value() = pUnaFila("Ing_Lin_Cruza")
    '            Me.dtgvAnimales.Item("dgvSexo", i).Value() = pUnaFila("Ing_Lin_Sexo")
    '            Me.dtgvAnimales.Item("dgvPeso", i).Value() = pUnaFila("Ing_Lin_Peso")
    '            Me.dtgvAnimales.Item("dgvEstado", i).Value() = "USADO"
    '            Me.dtgvAnimales.Item("dgvPagina", i).Value() = pUnaFila("Ing_Lin_Pagina")

    '        End If

    '        i += 1
    '    End While
    'End Sub

    Public Sub DesHabilitarEdicionDataGrid(ByVal pos As Integer, ByVal pHabilitar As Boolean)
        Me.dtgvAnimales.Item("dgvchk", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvNacimiento", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvDispositivo", pos).ReadOnly = True
        Me.dtgvAnimales.Item("dgvRaza", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvCruza", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvSexo", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvPeso", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvEstado", pos).ReadOnly = pHabilitar
        Me.dtgvAnimales.Item("dgvPagina", pos).ReadOnly = pHabilitar
    End Sub

    Public Sub limpiarGrid()
        Me.cboPaginas.Items.Clear()
        dtgvAnimales.DataSource = Nothing
        dtgvAnimales.Rows.Clear()
        dtgvAnimales.Refresh()
        ContarTodosElementos()
    End Sub

    Public Sub cargarDataGrid(ByVal unDetalle As DataTable, ByVal pVersion As Integer, ByVal todas As Boolean)
        Dim i As Integer = 0
        While i < unDetalle.Rows.Count
            Dim pUnaFila As DataRow = unDetalle.Rows(i)
            Me.dtgvAnimales.Rows.Add()
            Me.dtgvAnimales.Item("dgvDispositivo", i).Value() = pUnaFila("Ing_Lin_Dispositivo")
            Me.dtgvAnimales.Item("dgvPagina", i).Value() = pUnaFila("Ing_Lin_Pagina")

            If pUnaFila("Ing_Lin_Version") > 0 Then

                If todas = True Then
                    dtgvAnimales.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    DesHabilitarEdicionDataGrid(i, True)
                    Dim mes As Date = pUnaFila("Ing_Lin_FechaNac")
                    mes = DateSerial(Year(mes), Month(mes) + 0, 1)
                    Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = mes
                    Me.dtgvAnimales.Item("dgvRaza", i).Value() = pUnaFila("Ing_Lin_Raza")
                    Me.dtgvAnimales.Item("dgvCruza", i).Value() = pUnaFila("Ing_Lin_Cruza")
                    Me.dtgvAnimales.Item("dgvSexo", i).Value() = pUnaFila("Ing_Lin_Sexo")
                    Me.dtgvAnimales.Item("dgvPeso", i).Value() = pUnaFila("Ing_Lin_Peso")
                    Me.dtgvAnimales.Item("dgvObs", i).Value() = pUnaFila("Ing_Lin_Obs")
                    Me.dtgvAnimales.Item("dgvEstado", i).Value() = "USADO"
                Else
                    If pUnaFila("Ing_Lin_Version") = pVersion Then
                        dtgvAnimales.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                        DesHabilitarEdicionDataGrid(i, True)
                        Dim mes As Date = pUnaFila("Ing_Lin_FechaNac")
                        mes = DateSerial(Year(mes), Month(mes) + 0, 1)
                        Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = mes
                        Me.dtgvAnimales.Item("dgvRaza", i).Value() = pUnaFila("Ing_Lin_Raza")
                        Me.dtgvAnimales.Item("dgvCruza", i).Value() = pUnaFila("Ing_Lin_Cruza")
                        Me.dtgvAnimales.Item("dgvSexo", i).Value() = pUnaFila("Ing_Lin_Sexo")
                        Me.dtgvAnimales.Item("dgvPeso", i).Value() = pUnaFila("Ing_Lin_Peso")
                        Me.dtgvAnimales.Item("dgvEstado", i).Value() = "USADO"
                    Else
                        Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = FormatDateTime(dtpNacimiento.Value, DateFormat.ShortDate)
                        Me.dtgvAnimales.Item("dgvRaza", i).Value() = Me.cboRaza.SelectedItem.ToString
                        Me.dtgvAnimales.Item("dgvCruza", i).Value() = Me.cboCruza.SelectedItem.ToString
                        Me.dtgvAnimales.Item("dgvSexo", i).Value() = Me.cboSexo.SelectedItem.ToString
                        Me.dtgvAnimales.Item("dgvPeso", i).Value() = 0
                        Me.dtgvAnimales.Item("dgvEstado", i).Value() = ""
                    End If

                End If
            Else
                Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = FormatDateTime(dtpNacimiento.Value, DateFormat.ShortDate)
                Me.dtgvAnimales.Item("dgvRaza", i).Value() = Me.cboRaza.SelectedItem.ToString
                Me.dtgvAnimales.Item("dgvCruza", i).Value() = Me.cboCruza.SelectedItem.ToString
                Me.dtgvAnimales.Item("dgvSexo", i).Value() = Me.cboSexo.SelectedItem.ToString
                Me.dtgvAnimales.Item("dgvPeso", i).Value() = 0
                Me.dtgvAnimales.Item("dgvEstado", i).Value() = ""

            End If


            i += 1
        End While

    End Sub
    Public Sub PreCargarDataGrid(ByVal pDesde As Integer, ByVal pHasta As Integer)
        'CARGAR DETALLE
        Dim cantTotalCaravanas, ultimaCelda As Integer
        Dim i As Integer = 0
        Dim cantRegistros As Integer = 0
        If Me.dtgvAnimales.Rows.Count > 0 Then
            cantRegistros = Me.dtgvAnimales.Rows.Count
            ultimaCelda = Me.dtgvAnimales.Rows.Count - 1
            i = cantRegistros
            cantTotalCaravanas = (pHasta - pDesde) + cantRegistros
            numeraPaginas = Me.dtgvAnimales.Item("dgvPagina", ultimaCelda).Value() + 1

        Else
            cantTotalCaravanas = pHasta - pDesde
            numeraPaginas = 1
        End If

        If pHasta >= pDesde Then

            Dim numeracion As Integer = pDesde
            Dim cuentaRegistros As Integer = 0
            For i = cantRegistros To cantTotalCaravanas
                Dim unaCaravana As String = numeracion
                Me.dtgvAnimales.Rows.Add()
                Me.dtgvAnimales.Item("dgvchk", i).Value = False
                Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = FormatDateTime(dtpNacimiento.Value, DateFormat.ShortDate)
                Me.dtgvAnimales.Item("dgvDispositivo", i).Value() = unafachada.DevolverNumeroCaravana(numeracion)
                Me.dtgvAnimales.Item("dgvRaza", i).Value() = Me.cboRaza.SelectedItem.ToString
                Me.dtgvAnimales.Item("dgvSexo", i).Value() = Me.cboSexo.SelectedItem.ToString
                Me.dtgvAnimales.Item("dgvCruza", i).Value() = Me.cboCruza.SelectedItem.ToString
                Me.dtgvAnimales.Item("dgvPagina", i).Value() = numeraPaginas
                cuentaRegistros += 1
                If cuentaRegistros >= NudUnidades.Value Then
                    Me.cboPaginas.Items.Add(numeraPaginas)
                    numeraPaginas += 1
                    cuentaRegistros = 0
                End If

                'If i < numeraPaginas * NudUnidades.Value Then

                '    Me.dtgvAnimales.Item("dgvPagina", i).Value() = numeraPaginas
                'Else
                '    numeraPaginas += 1
                '    Me.dtgvAnimales.Item("dgvPagina", i).Value() = numeraPaginas
                'End If

                numeracion += 1
            Next
        Else

            ' MsgBox("Sin Detalle")
        End If
    End Sub


    Private Sub cboProductor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub txtCantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSeleccionados.TextChanged

    End Sub
    Private Sub LabelX6_Click(sender As System.Object, e As System.EventArgs) Handles labelx115.Click

    End Sub


    Public Sub LimpiarSeleccion()
        Dim i As Integer = 0
        If Not dtgvAnimales Is Nothing Then
            If dtgvAnimales.Rows.Count > 0 Then
                While i < dtgvAnimales.Rows.Count
                    Try
                        Me.dtgvAnimales.Item("dgvchk", i).Value = False
                    Catch ex As Exception

                    End Try
                    i += 1
                End While
            End If
        End If
    End Sub

    Public Sub Seleccionar()
        Dim i As Integer = 0
        If Not dtgvAnimales Is Nothing Then
            If dtgvAnimales.Rows.Count > 0 Then
                While i < dtgvAnimales.Rows.Count
                    Try
                        If Me.dtgvAnimales.Item("dgvEstado", i).Value <> "USADO" Then
                            Me.dtgvAnimales.Item("dgvchk", i).Value = True
                            Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = FormatDateTime(dtpNacimiento.Value, DateFormat.ShortDate)
                            Me.dtgvAnimales.Item("dgvRaza", i).Value() = Me.cboRaza.SelectedItem.ToString
                            Me.dtgvAnimales.Item("dgvSexo", i).Value() = Me.cboSexo.SelectedItem.ToString
                            Me.dtgvAnimales.Item("dgvCruza", i).Value() = Me.cboCruza.SelectedItem.ToString
                        End If

                    Catch ex As Exception

                    End Try
                    i += 1
                End While

            End If
        End If
    End Sub


    Public Sub ContarTodosElementos()
        Me.txtSeleccionados.Text = 0
        Me.txtDisponibles.Text = 0
        Me.txtIngresados.Text = 0
        vCantidadSeleccionados = 0
        vCantidadDisponibles = 0
        vCantidadIngresados = 0
        Dim i As Integer = 0
        If Not dtgvAnimales Is Nothing Then
            If dtgvAnimales.Rows.Count > 0 Then
                While i < dtgvAnimales.Rows.Count
                    Try
                        If Me.dtgvAnimales.Item("dgvchk", i).Value = True Then
                            vCantidadSeleccionados += 1
                        End If

                        If Me.dtgvAnimales.Item("dgvEstado", i).Value = "USADO" Then
                            vCantidadIngresados += 1
                        End If

                    Catch ex As Exception

                    End Try
                    i += 1
                End While
                vCantidadDisponibles = dtgvAnimales.Rows.Count - (vCantidadSeleccionados + vCantidadIngresados)
                Me.txtDisponibles.Text = vCantidadDisponibles
                Me.txtSeleccionados.Text = vCantidadSeleccionados
                Me.txtIngresados.Text = vCantidadIngresados
            End If
        End If
    End Sub


    Public Function ValidarDisponibles() As Boolean
        Dim Usados As Integer = 0
        Dim i As Integer = 0
        If Not dtgvAnimales Is Nothing Then
            If dtgvAnimales.Rows.Count > 0 Then
                While i < dtgvAnimales.Rows.Count
                    Try
                        If Me.dtgvAnimales.Item("dgvEstado", i).Value = "USADO" Then
                            Usados += 1
                        End If
                    Catch ex As Exception

                    End Try
                    i += 1
                End While
                If Usados = dtgvAnimales.Rows.Count Then
                    Return True
                Else
                    Return False
                End If
            End If
        End If
    End Function


    Private Sub btnEscaner_Click(sender As System.Object, e As System.EventArgs) Handles btnEscaner.Click
        If unafachada.BuscarVentanaAbierta("IUIngresoFormulariosEscaneados") Then
            '  Dim unIUConsultaStockxArticulo = New IUConsultaStockxArticulo(codArt).Show
            IUIngresoFormulariosEscaneados.BringToFront()
        Else
            unafachada.ListaVentanas.Add("IUIngresoFormulariosEscaneados")
            Dim unIUIngresoFormulariosEscaneados = New IUIngresoFormulariosEscaneados
            unIUIngresoFormulariosEscaneados.Show()
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        If ValidarDisponibles() = False Then
            If Me.dtgvAnimales.Rows.Count > 0 Then
                Dim ultimaCelda As Integer = Me.dtgvAnimales.Rows.Count - 1
                Dim CantCajas As Integer = Me.dtgvAnimales.Item("dgvPagina", ultimaCelda).Value()
                Dim mensaje As String
                If Me.cboIngresos.SelectedIndex = -1 Then
                    mensaje = "¿ Desea ingresar operacion con: " & CantCajas & " Cajas ?"
                Else
                    mensaje = "¿ Desea ingresar: " & vCantidadSeleccionados & " Registros?"
                End If


                If (MsgBox(mensaje, _
                           MsgBoxStyle.YesNo, _
                          "Sistema Trazabilidad - Ingresos")) = MsgBoxResult.Yes Then
                    Dim numeroOperacion As Integer = 0
                    Try
                        numeroOperacion = txtNumOperacion.Text
                        If txtNumOperacion.Text > 0 Then
                            GuardarIngresoDetalle()
                            GuardarCabezal()
                            'IMRPRIMIR
                            If vCantidadSeleccionados > 0 Then
                                Imprimir(Me.txtCodigo.Text, 0, True)
                            End If

                            Limpiar()
                            MsgBox("Ingresado Correctamente")
                        Else
                            MsgBox("Ingrese Numero Operacion MGAP")
                            Me.txtNumOperacion.Focus()
                        End If
                    Catch ex As Exception
                        MsgBox("Ingrese Numero Operacion MGAP")
                        Me.txtNumOperacion.Focus()
                    End Try

                End If
            End If

        Else
            MsgBox("Formulario Completo")
        End If

    End Sub


    Public Sub Limpiar()
        Me.txtObservacion.Text = ""
        Me.dtpColocaccion.Value = Today
        Me.cboPaginas.Items.Clear()
        Me.cboPaginas.Items.Add("Todas")
        numeraPaginas = 1
        NudCajas.Value = 1
        NudUnidades.Value = 5
        CalcularCantDispositivos()
        Me.cboCruza.SelectedIndex = 0
        'Cargar COMBO TITULOS 
        Me.cboIngresos.Items.Clear()
        Dim dsIngresos As DataSet = unafachada.TodosLosIngresos
        For Each unaFila As DataRow In dsIngresos.Tables(0).Rows
            Me.cboIngresos.Items.Add(unaFila("Ing_Titulo"))
        Next
        Me.cboIngresos.SelectedIndex = -1
        vTipoIngreso = ""
        Dim mes As Date = Today
        mes = DateSerial(Year(mes), Month(mes) + 0, 1)
        Me.dtpNacimiento.Value = mes
        'Me.dtpFecha.Value = Today
        Me.txtNumOperacion.Text = 0
        Me.txtCodigo.Text = unafachada.TraerUltimoId("ingresos", "Ing_Id")
        With dtgvAnimales
            '.Columns("DtgFecha").ReadOnly = True
            .Columns("dgvDispositivo").ReadOnly = True
            ' alternar color de filas  
            'Dim col As New CalendarColumn()
            'col.Name = "dgvNacimiento"
            'col.HeaderText = "Fecha Nac."
            'Dim nombre As String = col.Name
            ''Me.dtgvAnimales.Columns.Add(col)
            '.Columns.Insert(1, col)
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige
            'LIMPIAR DATAGRID
            .DataSource = Nothing
            .Rows.Clear()
            .Refresh()
        End With


        ContarTodosElementos()
        Me.txtNumOperacion.Focus()
    End Sub

    Public Sub GuardarIngresoDetalle()
        Dim actualizarParametro As Boolean = False
        Dim unIngreso As DataRow
        Dim i As Integer
        Dim unParametro As Parametros = unafachada.BuscarParametros("VersionFormularioD1")
        Dim version As Integer = unParametro.ValorParametro + 1
        Dim NumIngreso As String = Me.txtCodigo.Text
        Dim unCabezal As DataRow = unafachada.BuscarCabezalIngresos(NumIngreso)
        If unCabezal Is Nothing Then

            While i < dtgvAnimales.Rows.Count
                Dim Caravana As String = Me.dtgvAnimales.Item("dgvDispositivo", i).Value()
                Dim mes As Date = Me.dtgvAnimales.Item("dgvNacimiento", i).Value()
                mes = DateSerial(Year(mes), Month(mes) + 0, 1)
                Dim fechaNacimiento As Date = mes
                Dim raza As String = ""
                Dim cruza As String = ""
                Dim sexo As String = ""
                Dim pesoNacimiento As Decimal = 0
                Dim NumeroPagina As Integer = Me.dtgvAnimales.Item("dgvPagina", i).Value()
                Dim ultimoId As Integer = unafachada.TraerUltimoId("ingresosLineas", "Ing_Lin_id")
                Dim cadenaConexionGuardarLineas As String = "INSERT INTO ingresosLineas (Ing_Lin_id,Ing_Lin_IdCabezal,Ing_Lin_fecha,Ing_Lin_Dispositivo,Ing_Lin_FechaNac,Ing_Lin_Raza,Ing_Lin_Cruza,Ing_Lin_Sexo,Ing_Lin_Peso,Ing_Lin_Version,Ing_Lin_Pagina) VALUES (" & ultimoId & "," & NumIngreso & "," & "'" & Today & "'" & "," & "'" & Caravana & "'" & "," & "'" & fechaNacimiento & "'" & "," & "'" & raza & "'" & "," & "'" & cruza & "'" & "," & "'" & sexo & "'" & "," & pesoNacimiento & "," & "0" & "," & NumeroPagina & ")"
                unafachada.EjecutarConsultaGENERICA(cadenaConexionGuardarLineas)
                i += 1
               
            End While
        End If


        i = 0
        While i < dtgvAnimales.Rows.Count

            Dim valido As Boolean = Me.dtgvAnimales.Item("dgvchk", i).Value()
            If valido = True Then

                Dim Caravana As String = Me.dtgvAnimales.Item("dgvDispositivo", i).Value()
                Dim mes As Date = Me.dtgvAnimales.Item("dgvNacimiento", i).Value()
                mes = DateSerial(Year(mes), Month(mes) + 0, 1)
                Dim fechaNacimiento As Date = mes
                Dim raza As String = Me.dtgvAnimales.Item("dgvRaza", i).Value()
                Dim cruza As String = Me.dtgvAnimales.Item("dgvCruza", i).Value()
                Dim dicoseNacimiento As String = Me.cboDicoseFisico.SelectedItem
                Dim sexo As String = Me.dtgvAnimales.Item("dgvSexo", i).Value()
                Dim obs As String = Me.dtgvAnimales.Item("dgvObs", i).Value()

                Dim pesoNacimiento As Decimal
                Try
                    pesoNacimiento = Me.dtgvAnimales.Item("dgvPeso", i).Value()
                Catch ex As Exception
                    pesoNacimiento = 0
                End Try
                Dim propietario As String = Me.txtDicosePropietario.Text
                Dim ubicacion As String = Me.cboDicoseFisico.SelectedItem
                Dim tenencia As String = Me.txtDicosePropietario.Text
                Dim vida As String = "Vivo"
                Dim trazabilidad As String = "Si"
                Dim fechaColocacion As Date = Me.dtpColocaccion.Value
                Dim tipoIngreso As String = 1
                'Animales
                Dim ultimoIdanimal As Integer = unafachada.TraerUltimoId("animal", "ani_id")
                Dim cadenaActualizaAnimales As String
                Dim unAnimal As DataRow = unafachada.BuscarDispositivo(Caravana)
                If unAnimal Is Nothing Then
                    cadenaActualizaAnimales = "INSERT INTO animal (ani_id,ani_dispositivo, ani_fechaNac, ani_raza, ani_cruza,ani_dicose_nacimiento,ani_sexo,ani_pesoNac,ani_propietario,ani_ubicacion,ani_tenencia,ani_vida,ani_trazabilidad,ani_tipoIngreso,ani_numIngreso) VALUES (" & ultimoIdanimal & "," & "'" & Caravana & "'" & "," & "'" & fechaNacimiento & "'" & "," & "'" & raza & "'" & "," & "'" & cruza & "'" & "," & "'" & dicoseNacimiento & "'" & "," & "'" & sexo & "'" & "," & pesoNacimiento & "," & "'" & propietario & "'" & "," & "'" & ubicacion & "'" & "," & "'" & tenencia & "'" & "," & "'" & vida & "'" & "," & "'" & trazabilidad & "'" & "," & tipoIngreso & "," & NumIngreso & ")"
                Else
                    cadenaActualizaAnimales = "UPDATE animal SET ani_fechaNac =" & "'" & fechaNacimiento & "'" & ", ani_raza =" & "'" & raza & "'" & ", ani_cruza =" & "'" & cruza & "'" & ", ani_sexo =" & "'" & sexo & "'" & ", ani_pesoNac =" & pesoNacimiento & " WHERE animal.ani_dispositivo=" & "'" & Caravana & "'"
                End If
                unafachada.EjecutarConsultaGENERICA(cadenaActualizaAnimales)

                'Ingresos Lineas

                Dim cadenaConexionVersiones As String = ""
                cadenaConexionVersiones = "UPDATE ingresosLineas SET Ing_Lin_FechaNac =" & "'" & fechaNacimiento & "'" & ", Ing_Lin_Raza =" & "'" & raza & "'" & ", Ing_Lin_Cruza =" & "'" & cruza & "'" & ", Ing_Lin_Sexo =" & "'" & sexo & "'" & ", Ing_Lin_Peso =" & pesoNacimiento & ", Ing_Lin_Version =" & version & ", Ing_Lin_FechaColocacion =" & "'" & fechaColocacion & "'" & ", Ing_Lin_Obs =" & "'" & obs & "'" & " WHERE Ing_Lin_Dispositivo=" & "'" & Caravana & "'"
                If unafachada.EjecutarConsultaGENERICA(cadenaConexionVersiones) Then
                    actualizarParametro = True
                End If

            End If
            i += 1
        End While

        If actualizarParametro Then
            unParametro.ValorParametro += 1
            unafachada.ModificarParametros(unParametro)
        End If
    End Sub

    Public Function GuardarCabezal() As Boolean

        Dim CabId As Integer = Me.txtCodigo.Text
        Dim titulo As String = Me.txtCodigo.Text & "- " & Today.ToString("dd/MM/yyyy") & " - " & "Nº Op: " & Me.txtNumOperacion.Text
        Dim cabTitulo As String = titulo
        Dim cabNumOperacion As String = Me.txtNumOperacion.Text
        Dim cabDesde As String = Me.txtDesde.Text
        Dim cabHasta As String = Me.txtHasta.Text
        Dim CabIdProductor As Integer = vIdProductor
        Dim CabNomProductor As String = Me.cboProductor.SelectedItem
        Dim Cabfecha As Date = Today
        Dim CabdicosePropietario As String = Me.txtDicosePropietario.Text
        Dim CabdicoseLugarFisico As String = Me.cboDicoseFisico.SelectedItem
        Dim CabtipoIngreso As String = vTipoIngreso
        Dim CabtotalAnimales As Integer = txtDisponibles.Text
        Dim Cabanula As String = ""
        Dim cabPaginas As Integer = numeraPaginas - 1
        Dim cabCerrado As String = ""
        Dim cadenaConexion As String
        Dim unCabezalIngresos As DataRow = unafachada.BuscarCabezalIngresos(CabId)

        If unCabezalIngresos Is Nothing Then
            cadenaConexion = "INSERT INTO ingresos (Ing_Id,Ing_Titulo,Ing_NumOperacion,Ing_Desde,Ing_Hasta,Ing_IdProductor,Ing_NomProductor,Ing_fecha,Ing_DicosePropietario,Ing_DicoseLugarFisico,Ing_TotalAnimales,Ing_TipoIngreso,Ing_anula,Ing_Paginas) VALUES (" & CabId & "," & "'" & cabTitulo & "'" & "," & cabNumOperacion & "," & "'" & cabDesde & "'" & "," & "'" & cabHasta & "'" & "," & "'" & CabIdProductor & "'" & "," & "'" & CabNomProductor & "'" & "," & "'" & Cabfecha & "'" & "," & "'" & CabdicosePropietario & "'" & "," & "'" & CabdicoseLugarFisico & "'" & "," & CabtotalAnimales & "," & "'" & CabtipoIngreso & "'" & "," & "'" & Nothing & "'" & "," & cabPaginas & ")"
        Else

        End If

        Return unafachada.EjecutarConsultaGENERICA(cadenaConexion)

    End Function

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dtpFecha_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LabelX10_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub cboIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboProductor_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboProductor.SelectedIndexChanged
        Dim unaFilaProductor As DataRow = unafachada.BuscarProductorxNombre(Me.cboProductor.SelectedItem.ToString, dtProductores)
        If Not unaFilaProductor Is Nothing Then
            vIdProductor = unaFilaProductor("pro_id")
            Me.txtDicosePropietario.Text = unaFilaProductor("pro_dicose")

            Dim TableDicoseProductor As DataTable = unafachada.TodosLosDicoseProductoresTable(vIdProductor)
            If TableDicoseProductor.Rows.Count > 0 Then
                Me.cboDicoseFisico.Items.Clear()
                For Each unaFila As DataRow In TableDicoseProductor.Rows
                    Me.cboDicoseFisico.Items.Add(unaFila("Dicose_Campo").ToString)
                Next
                Me.cboDicoseFisico.SelectedIndex = 0
            End If
          


        End If
    End Sub

    Private Sub cboIngresos_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboIngresos.SelectedIndexChanged
        If Me.cboIngresos.SelectedIndex >= 0 Then
            Dim titulo As String = Me.cboIngresos.SelectedItem.ToString
            Dim unCabezalIngresos As DataRow
            unCabezalIngresos = unafachada.BuscarCabezalIngresosxTitulo(titulo)
            Me.txtCodigo.Text = unCabezalIngresos("Ing_id")
            cargarIngresos(Me.txtCodigo.Text)
            Me.GroupBox3.Visible = False
        Else
            Me.GroupBox3.Visible = True
        End If


    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.GroupBox3.Visible = True
        Limpiar()
    End Sub

    Private Sub btnListar_Click(sender As System.Object, e As System.EventArgs) Handles btnListar.Click
        Dim i As Integer = 0
        If Not dtgvAnimales Is Nothing Then
            If dtgvAnimales.Rows.Count > 0 Then
                While i < dtgvAnimales.Rows.Count
                    Try
                        Dim mes As Date = Me.dtpNacimiento.Value
                        mes = DateSerial(Year(mes), Month(mes) + 0, 1)
                        If Me.dtgvAnimales.Item("dgvchk", i).Value = True Then
                            Me.dtgvAnimales.Item("dgvNacimiento", i).Value() = FormatDateTime(mes, DateFormat.ShortDate)
                            Me.dtgvAnimales.Item("dgvRaza", i).Value() = Me.cboRaza.SelectedItem.ToString
                            Me.dtgvAnimales.Item("dgvSexo", i).Value() = Me.cboSexo.SelectedItem.ToString
                            Me.dtgvAnimales.Item("dgvCruza", i).Value() = Me.cboCruza.SelectedItem.ToString
                            Me.dtgvAnimales.Item("dgvObs", i).Value() = Me.txtObservacion.Text
                            Me.dtgvAnimales.Item("dgvCastrado", i).Value() = Me.cboCastrado.SelectedItem.ToString
                        End If
                    Catch ex As Exception

                    End Try
                    i += 1
                End While
            End If
        End If
        ContarTodosElementos()

    End Sub

    Private Sub dtgvAnimales_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvAnimales.CellContentClick

    End Sub

    Private Sub dtgvAnimales_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvAnimales.CellContentDoubleClick

        If (MsgBox("¿ Desea Datos del Dispositivo Nº: " & dtgvAnimales.CurrentRow.Cells("dgvDispositivo").Value & " ?", _
                      MsgBoxStyle.YesNoCancel, _
                     "Sistema Trazabilidad - Eliminar Dispositivo")) = MsgBoxResult.Yes Then
            'Eliminar Celda
            If eliminarCelda() Then
                MsgBox("Eliminado Correctamente")
            Else
                MsgBox("Error al eliminar")
            End If
        End If
    End Sub

    Public Function eliminarCelda() As Boolean
        If Me.dtgvAnimales.Rows.Count > 1 Then
            Dim bandera As Boolean = False
            'dtgvAnimales.Rows.Remove(dtgvAnimales.CurrentRow)
            Dim Dispositivo As String = dtgvAnimales.CurrentRow.Cells("dgvDispositivo").Value
            Dim cadenaActualizacion As String
            cadenaActualizacion = "DELETE FROM animal WHERE ani_dispositivo=" & "'" & Dispositivo & "'"
            bandera = unafachada.EjecutarConsultaGENERICA(cadenaActualizacion)
            'Actualizar Ingresos Lineas
            Dim mes As Date = Me.dtpNacimiento.Value
            mes = DateSerial(Year(mes), Month(mes) + 0, 1)
            Dim cadenaConexionLineas As String = "UPDATE ingresosLineas SET Ing_Lin_FechaNac =" & "'" & mes & "'" & ", Ing_Lin_Raza =" & "'" & "" & "'" & ", Ing_Lin_Cruza =" & "'" & "" & "'" & ", Ing_Lin_Sexo =" & "'" & "" & "'" & ", Ing_Lin_Peso =" & 0 & ", Ing_Lin_Version =" & 0 & ", Ing_Lin_Imprime =" & 0 & " WHERE Ing_Lin_Dispositivo=" & "'" & Dispositivo & "'"
            bandera = unafachada.EjecutarConsultaGENERICA(cadenaConexionLineas)
            If bandera Then
                dtgvAnimales.CurrentRow.Cells("dgvNacimiento").Value = mes
                dtgvAnimales.CurrentRow.Cells("dgvRaza").Value = Me.cboRaza.SelectedItem
                dtgvAnimales.CurrentRow.Cells("dgvCruza").Value = Me.cboCruza.SelectedItem
                dtgvAnimales.CurrentRow.Cells("dgvSexo").Value = Me.cboSexo.SelectedItem
                dtgvAnimales.CurrentRow.Cells("dgvPeso").Value = 0
                dtgvAnimales.CurrentRow.Cells("dgvEstado").Value = ""
                dtgvAnimales.CurrentRow.DefaultCellStyle.BackColor = Color.Beige
                Dim pos As Integer = dtgvAnimales.CurrentRow.Index
                DesHabilitarEdicionDataGrid(pos, False)
            End If
            Return bandera
        End If
    End Function

    Private Sub dtgvAnimales_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvAnimales.CellValueChanged
        If dtgvAnimales.Rows.Count > 0 Then
            If dtgvAnimales.Columns(e.ColumnIndex).Name = "dgvchk" Then
                Dim count1 As Integer = 0
                For Each row As DataGridViewRow In dtgvAnimales.Rows
                    If row.Cells("dgvchk").Value IsNot Nothing And row.Cells("dgvchk").Value = True Then
                        count1 += 1
                      
                    End If
                Next
                vCantidadSeleccionados = count1
                vCantidadDisponibles = Me.dtgvAnimales.Rows.Count - count1
                txtSeleccionados.Text = vCantidadSeleccionados
                Me.txtDisponibles.Text = vCantidadDisponibles
            End If
        End If
    End Sub

    Private Sub dtgvAnimales_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles dtgvAnimales.CurrentCellDirtyStateChanged
        If dtgvAnimales.IsCurrentCellDirty Then
            dtgvAnimales.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub cboVersiones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboVersiones.SelectedIndexChanged
        Dim version As Integer

        Try
            Dim ValorCombo As String = Me.cboVersiones.SelectedItem
            ValorCombo = ValorCombo.Substring(ValorCombo.IndexOf("NumOp:") + 6)
            version = ValorCombo
        Catch ex As Exception
            limpiarGrid()
            version = 0
            cargarDetalleDataGrid(True, version, Me.txtCodigo.Text)
            ContarTodosElementos()
        End Try
        If version > 0 Then
            limpiarGrid()
            cargarDetalleDataGrid(True, version, Me.txtCodigo.Text)
            ContarTodosElementos()
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Imprimir(Me.txtCodigo.Text, 1, True)

    End Sub

    Public Sub Imprimir(ByVal pCabezal As Integer, ByVal pDesdeDonde As Integer, ByVal pVistaPrevia As Boolean)
        Dim listaPaginas As New List(Of Integer)
        Dim cadena As String
        cadena = "UPDATE ingresosLineas SET Ing_Lin_Imprime=0 WHERE Ing_Lin_IdCabezal=" & pCabezal
        unafachada.EjecutarConsultaGENERICA(cadena)
        Dim i As Integer = 0
        If dtgvAnimales.Rows.Count > 0 Then
            While i < dtgvAnimales.Rows.Count
                Try
                    Select Case pDesdeDonde
                        Case 0
                            'Imprimir Solo Seleccionados
                            If Me.dtgvAnimales.Item("dgvchk", i).Value = True Then
                                Dim numDispositivo As String = Me.dtgvAnimales.Item("dgvDispositivo", i).Value
                                listaPaginas.Add(Me.dtgvAnimales.Item("dgvPagina", i).Value)
                                cadena = "UPDATE ingresosLineas SET Ing_Lin_Imprime=1 WHERE Ing_Lin_Dispositivo=" & "'" & numDispositivo & "'" & " and " & "Ing_Lin_IdCabezal=" & pCabezal
                                unafachada.EjecutarConsultaGENERICA(cadena)
                            End If
                        Case 1
                            'Imprimir Usados dede Versiones
                            If Me.dtgvAnimales.Item("dgvEstado", i).Value = "USADO" Then
                                Dim numDispositivo As String = Me.dtgvAnimales.Item("dgvDispositivo", i).Value
                                listaPaginas.Add(Me.dtgvAnimales.Item("dgvPagina", i).Value)
                                cadena = "UPDATE ingresosLineas SET Ing_Lin_Imprime=1 WHERE Ing_Lin_Dispositivo=" & "'" & numDispositivo & "'" & " and " & "Ing_Lin_IdCabezal=" & pCabezal
                                unafachada.EjecutarConsultaGENERICA(cadena)
                            End If
                    End Select


                Catch ex As Exception

                End Try
                i += 1
            End While

            'Enviar a Imprimir
            reporte = New Dac.ReporteD1
            reporteCopia = New Dac.ReporteD1
            Try
                Dim cadenaCabezal As String = "select * from ingresos where Ing_Id=" & pCabezal
                Dim cadenaLineas As String
                Dim i2 As Integer = 0
                Dim filtros As String = " And "
                For i2 = 0 To listaPaginas.Count - 1
                    filtros &= "Ing_Lin_Pagina=" & listaPaginas.Item(i2) & " Or "
                Next
                If filtros.Length > 0 Then
                    filtros = filtros.Remove(filtros.Length - 4, 4)
                End If
                cadenaLineas = "select * from ingresosLineas where Ing_Lin_IdCabezal=" & pCabezal & filtros & " order by Ing_Lin_Pagina, Ing_Lin_Dispositivo"

        Dim listaCadenas As New List(Of String)
        Dim listaNombreTablas As New List(Of String)
        listaCadenas.Add(cadenaCabezal)
        listaNombreTablas.Add("ingresos")
        listaCadenas.Add(cadenaLineas)
        listaNombreTablas.Add("ingresosLineas")

        Dim DataSetD1 As New Dac.DsD1
        unafachada.EjecutarConsultaGENERICAVariasTablasDataSet(listaCadenas, DataSetD1, listaNombreTablas)

        'Paso Parametros
        ' reporte.SetParameterValue("@fechaNacimiento", "ORIGINAL")
        ' reporte.SetParameterValue("@Fecha2", fecha2)


                reporte.SetDataSource(DataSetD1)
                reporteCopia.SetDataSource(DataSetD1)
        ' reporte.SetParameterValue(0, "ORIGINAL")
        'reporte.SetParameterValue(1, pfecha2)
        If pVistaPrevia = True Then
                    Dim unImpresionD1Original As New IUReporteD1(reporte, False)
                    Dim unImpresionD1Copia As New IUReporteD1(reporteCopia, True)
                    unImpresionD1Original.Show()
                    unImpresionD1Copia.Show()
        Else
            '   reporte.PrintOptions.PrinterName =
        
                    If seleccionarImpresora() Then
                        Dim ImpCopias As Integer = prtSettings.Copies
                        Dim ImpInterc As Boolean = prtSettings.Collate
                        Dim ImpPriPag As Integer = prtSettings.FromPage
                        Dim ImpUltPag As Integer = prtSettings.ToPage

                        'reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLegal
                        'Dim ConfiguracionPagina As New PageSettings
                        'reporte.PrintToPrinter(prtSettings, ConfiguracionPagina, False)

                        reporte.PrintOptions.PrinterName = prtSettings.PrinterName
                        reporte.PrintToPrinter(ImpCopias, ImpInterc, ImpPriPag, ImpUltPag)

                        reporte.Close()
                        reporte.Dispose()
                    End If

        End If

            Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        End If
    End Sub


    Private Function seleccionarImpresora() As Boolean
        If prtSettings Is Nothing Then
            prtSettings = New PrinterSettings
            prtSettings.Copies = 1

            prtSettings.PrintRange = PrintRange.AllPages


        End If

        With PrintDialog1
            .AllowCurrentPage = True
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = True

            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = True
            .PrinterSettings = prtSettings

            If .ShowDialog() = DialogResult.OK Then
                prtSettings = .PrinterSettings
                Return True
            Else
                Return False
            End If

        End With
    End Function

    Public Function BuscarDuplicados(ByVal pDispositivo As String)
        Dim cntceros As Integer = 12 - pDispositivo.ToString.Length
        Dim ceros As String
        ceros = StrDup(cntceros, "0")
        Dim numCaravana As String = "858" & ceros & pDispositivo
        Dim i As Integer
        Dim bandera As Boolean = False
        While i < dtgvAnimales.Rows.Count
            Dim disDatagrid As String = dtgvAnimales.Rows(i).Cells("dgvDispositivo").Value
            If disDatagrid = numCaravana Then
                bandera = True
                Exit While
            End If
            i += 1
        End While
        Return bandera
    End Function

    Private Sub btnAgregarCajas_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCajas.Click
        If Me.cboIngresos.SelectedIndex = -1 Then
            If Not BuscarDuplicados(Me.txtDesde.Text) Then
                Dim cantAnimales As Integer
                Try
                    cantAnimales = Me.txtHasta.Text - Me.txtDesde.Text
                Catch ex As Exception
                    cantAnimales = 0
                End Try

                If cantAnimales > 0 Then
                    Me.vTipoIngreso = "D1-MANUAL"
                    Dim desde As Integer = CInt(txtDesde.Text)
                    Dim hasta As Integer = CInt(txtHasta.Text)
                    PreCargarDataGrid(desde, hasta)
                    'Seleccionar()
                    ContarTodosElementos()
                Else
                    Me.txtDesde.Focus()
                    MsgBox("Ingrese correctamente Desde - Hasta")
                End If
            Else
                MsgBox("Ya ha ingresado Numero de Dispositivo")
            End If
        Else
            'Seleccionar()
            ContarTodosElementos()
        End If

    End Sub

    Private Sub NudUnidades_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NudUnidades.ValueChanged
        CalcularCantDispositivos()
    End Sub
    Public Function CalcularCantDispositivos() As Integer
        Dim cantAnimales As Integer = 0
        Try
            cantAnimales = NudCajas.Value * NudUnidades.Value - 1
            Me.txtHasta.Text = Me.txtDesde.Text + cantAnimales
        Catch ex As Exception
            Me.txtHasta.Text = Me.txtDesde.Text
        End Try
        Return cantAnimales
    End Function

    Private Sub NudCajas_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NudCajas.ValueChanged
        CalcularCantDispositivos()
    End Sub

    Private Sub cboRaza_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboCruza_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

  
    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        limpiarGrid()
    End Sub

    Private Sub cboRaza_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboRaza.SelectedIndexChanged

    End Sub

    Private Sub txtDesde_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesde.TextChanged
        CalcularCantDispositivos()
    End Sub

    Private Sub cboPaginas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPaginas.SelectedIndexChanged
        LimpiarSeleccion()
        Dim Pagina As String = Me.cboPaginas.SelectedItem
        Dim primeraFila As Integer
        If Pagina = "Todas" Then
            Dim i As Integer = 0
            If Not dtgvAnimales Is Nothing Then
                If dtgvAnimales.Rows.Count > 0 Then
                    While i < dtgvAnimales.Rows.Count
                        Try
                            If Me.dtgvAnimales.Item("dgvEstado", i).Value = "" Then
                                Me.dtgvAnimales.Item("dgvchk", i).Value = True
                                If primeraFila = 0 Then
                                    primeraFila = i
                                End If

                            End If
                        Catch ex As Exception

                        End Try
                        i += 1
                    End While

                End If
            End If
        Else
            Dim numeroPagina As Integer
            Try
                numeroPagina = Me.cboPaginas.SelectedItem
            Catch ex As Exception
                numeroPagina = 0
            End Try

            Dim i As Integer = 0
            If Not dtgvAnimales Is Nothing Then
                If dtgvAnimales.Rows.Count > 0 Then
                    While i < dtgvAnimales.Rows.Count
                        Try
                            If Me.dtgvAnimales.Item("dgvPagina", i).Value = numeroPagina And Me.dtgvAnimales.Item("dgvEstado", i).Value = "" Then
                                Me.dtgvAnimales.Item("dgvchk", i).Value = True
                                If primeraFila = 0 Then
                                    primeraFila = i
                                End If
                            End If

                        Catch ex As Exception

                        End Try
                        i += 1
                    End While

                End If
            End If
        End If
        ContarTodosElementos()
        dtgvAnimales.CurrentCell = dtgvAnimales.Rows(primeraFila + 6).Cells(0)
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If Me.dtgvAnimales.Rows.Count > 0 Then
            If (MsgBox("¿ Desea Anular operacion Nº : " & Me.txtCodigo.Text & " ?", _
                         MsgBoxStyle.YesNo, _
                        "Sistema Trazabilidad - Ingresos")) = MsgBoxResult.Yes Then

                Dim cadenaConexionVersiones As String = ""
                cadenaConexionVersiones = "UPDATE ingresos SET Ing_anula =" & "'" & Today & "'" & " WHERE Ing_Id=" & Me.txtCodigo.Text
                If unafachada.EjecutarConsultaGENERICA(cadenaConexionVersiones) Then
                    Limpiar()
                    limpiarGrid()
                    ContarTodosElementos()
                    MsgBox("Anulado Correctamente")
                Else
                    MsgBox("Error al anular")
                End If


            End If
        End If
    End Sub
End Class