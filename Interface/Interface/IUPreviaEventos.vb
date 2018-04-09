Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports System.Threading
Imports System.IO.Ports
Public Class IUPreviaEventos


    'COMBO EVENTOS LINEAS
    Dim dtListaEventosLineas As DataTable = unafachada.TodosLasListasEventosLineas()
    Dim dtListaEventos As DataTable = unafachada.TodosLasListasEventos
    Dim dsMenu As DataSet = unafachada.TodosLosMenu
    Private CodigoEvento, CodigoEventoLineas
    Public Shared numCaravana As String
    Dim focoChip As Integer
    Dim fonetica As String
    Dim conectado As Boolean
    Dim puerto As String
    Dim idActividadSeleccionada As Integer


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

    Public Function CargarComboLineas(ByVal pCombo As ComboBox, ByVal pDataTable As DataTable, ByVal pColumna As String, ByVal pCodigoEventoPrincipal As String) As Boolean
        pCombo.Items.Clear()
        pCombo.Items.Add("")
        If pDataTable.Rows.Count > 0 Then
            For Each rw As DataRow In pDataTable.Rows
                If pCodigoEventoPrincipal = rw("eve_lin_ideventos") Then
                    pCombo.Items.Add(rw(pColumna))
                End If

            Next rw
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub CrearColumnas()
        With LsView
            .Items.Clear()
            .Columns.Clear()
            '.Columns.Add("Nº Boton", 70, HorizontalAlignment.Left)
            .Columns.Add("Chip", 120, HorizontalAlignment.Left)
            '.Columns.Add("Id", 30, HorizontalAlignment.Left)
            .Columns.Add("Opcion", 170, HorizontalAlignment.Left)
            '.Columns.Add("Id", 30, HorizontalAlignment.Left)
            '.Columns.Add("Tipo", 100, HorizontalAlignment.Left)
            '.Columns.Add("Id", 30, HorizontalAlignment.Left)
            '.Columns.Add("Actividad", 120, HorizontalAlignment.Left)
            '.Columns.Add("Fonetica", 100, HorizontalAlignment.Left)
        End With

    End Sub

    Public Function BuscarEnListview(ByVal pEvento As Integer)
        For Each lv As ListViewItem In LsView.Items
            If pEvento = lv.SubItems(2).Text Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function


    Private Sub IUPreviaEventos_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.SerialPort1.Dispose()
        Me.SerialPort1.Close()
        GC.Collect()
        If Not formularioAbierto("IUIngresoEventosDirecto") Then
            Dim unIUIngresoEventosDirecto As New IUIngresoEventosDirecto(idActividadSeleccionada)
            'unIUIngresoEventosDirecto.MdiParent = Me
            unIUIngresoEventosDirecto.Show()
        End If


    End Sub

    Function formularioAbierto(ByVal nomForm As String) As Boolean
        Dim f As Form
        For Each f In Me.MdiChildren
            If f.Name.ToUpper = nomForm.ToUpper Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub IUPreviaEventos_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        unafachada.TodosLosParametros()
        CrearColumnas()

        'Cargar COMBO TITULOS 
        Me.cboIngresos.Items.Clear()
        For Each unaFila As DataRow In dsMenu.Tables(0).Rows
            Me.cboIngresos.Items.Add(unaFila("menu_nombre"))
        Next
        Dim TareaSeleccionada As String
        Try
            TareaSeleccionada = unafachada.BuscarParametros("TareaSeleccionada").ValorParametro
        Catch ex As Exception
            TareaSeleccionada = ""
        End Try

        If TareaSeleccionada.Length > 0 Then
            Me.cboIngresos.SelectedItem = TareaSeleccionada
        Else
            Me.cboIngresos.SelectedIndex = 0
        End If

        Me.chkDatosAnimales.Checked = True
        Me.chkTareasAnteriores.Checked = True
        Me.chkSonido.Checked = True
        ActivarBaston()

    End Sub

    Public Sub ActivarBaston()

        Dim puerto As String = unafachada.puertoBaston
        If Conectar(puerto) Then
            Timer2.Enabled = True
        Else
            Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
            textoaVoz.Start("Conecte Baston a la PC")

        End If
    End Sub


    Private Sub LsView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LsView.SelectedIndexChanged
        Try
            Me.lbini.Text = LsView.FocusedItem.SubItems(0).Text.Substring(6, 5)
            Me.lbFin.Text = LsView.FocusedItem.SubItems(0).Text.Substring(11, 4)
        Catch ex As Exception
            Me.lbini.Text = ""
            Me.lbFin.Text = ""
        End Try

    End Sub


    Private Sub cboIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboIngresos.SelectedIndexChanged
        Dim unaFilaMenu As DataRow = unafachada.BuscarMenu(Me.cboIngresos.SelectedItem, dsMenu.Tables(0))
        Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
        If Not unaFilaMenu Is Nothing Then
            CrearColumnas()
            Dim CodigoTarea As Integer = unaFilaMenu.Item("menu_id")
            Dim NombreActividad As String = unaFilaMenu.Item("menu_nombre")
            idActividadSeleccionada = CodigoTarea
            textoaVoz.Start(Me.cboIngresos.SelectedItem)
            Dim dsSubMenuDetalle As DataSet = unafachada.BuscarSubMenu(CodigoTarea)
            ' Me.cboTipo.SelectedItem = unaFilaMenu.Item("menu_tipo")
            If Not dsSubMenuDetalle Is Nothing Then
                If dsSubMenuDetalle.Tables(0).Rows.Count > 0 Then
                    Dim unParametro As New Parametros
                    unParametro.NombreParametro = "TareaSeleccionada"
                    unParametro.ValorParametro = NombreActividad
                    unParametro.DescripcionParametro = "Selecciona Tarea"
                    unParametro.Modificar()

                    For Each rw As DataRow In dsSubMenuDetalle.Tables(0).Rows
                        Dim fila As New ListViewItem
                        Dim ultimoNumero As Integer = LsView.Items.Count + 1
                        fila = LsView.Items.Add(rw.Item("menu_sub_dispositivo"))
                        'fila = LsView.Items.Add(ultimoNumero)
                        'fila.SubItems.Add(rw.Item("menu_sub_dispositivo"))
                        'fila.SubItems.Add(rw.Item("menu_sub_IdOpcion"))
                        fila.SubItems.Add(rw.Item("menu_sub_Opcion"))
                        'fila.SubItems.Add(rw.Item("menu_sub_idTipo"))
                        'fila.SubItems.Add(rw.Item("menu_sub_Tipo"))
                        'fila.SubItems.Add(rw.Item("menu_sub_idActividad"))
                        'fila.SubItems.Add(rw.Item("menu_sub_Actividad"))
                        'fila.SubItems.Add(rw.Item("menu_sub_fonetica"))
                    Next rw
                End If
            End If

        End If
    End Sub


    Private Sub chkDatosAnimales_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDatosAnimales.CheckedChanged
        If Me.chkDatosAnimales.Checked = True Then
            Dim unParametro As New Parametros("MostrarAnimales", 1, "Mostrar animales ingreso eventos directos")
            unParametro.Modificar()
        Else
            Dim unParametro As New Parametros("MostrarAnimales", 0, "Mostrar animales ingreso eventos directos")
            unParametro.Modificar()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs)
        If (MsgBox("Desea cerrar lotes temporales ?", _
                MsgBoxStyle.YesNo, _
               "Sistema Trazabilidad - Eliminar Lotes Temporales")) = MsgBoxResult.Yes Then
            Dim Archivo As String = Environment.CurrentDirectory & "\tempEventos.txt"
            Dim existe As Boolean = File.Exists(Archivo)
            If existe Then
                Try
                    My.Computer.FileSystem.DeleteFile(Archivo, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    MsgBox("Eliminados los lotes, si desea recuperarlos han quedado en la papelera de reciclaje")
                Catch ex As Exception
                    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
                End Try
            End If
        End If

    End Sub

    Private Sub btnNueva_Click(sender As System.Object, e As System.EventArgs) Handles btnNueva.Click
        AbrirConfigurarAccesos()
        Timer1.Enabled = True
    End Sub

    Public Sub AbrirConfigurarAccesos()
        'Dim unIUIngresoProductos = New IUIngresoproductos

        If unafachada.BuscarVentanaAbierta("IUConfigurarAccesos") Then
            Me.SerialPort1.Dispose()
            Me.SerialPort1.Close()
            unafachada.agregoTareaNueva = 0
            IUConfigurarAccesos.BringToFront()
        Else
            'AgregoUnProducto = 1
            Me.SerialPort1.Dispose()
            Me.SerialPort1.Close()
            unafachada.ListaVentanas.Add("IUConfigurarAccesos")
            unafachada.agregoTareaNueva = 0
            IUConfigurarAccesos.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If unafachada.agregoTareaNueva = 1 Then
            dsMenu = unafachada.TodosLosMenu()
            'Cargar COMBO TITULOS 
            Me.cboIngresos.Items.Clear()
            For Each unaFila As DataRow In dsMenu.Tables(0).Rows
                Me.cboIngresos.Items.Add(unaFila("menu_nombre"))
            Next
            Me.cboIngresos.SelectedIndex = 1

            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If Not numCaravana Is Nothing Then
            If numCaravana.ToString.Length > 15 Then
                If numCaravana.Contains("LA URY") Then
                    Timer1.Enabled = False
                    MsgBox("Configure el baston con el codigo de su pais, 858 en el sistema alflex")

                Else

                    If unafachada.tipoBaston = 1 Then
                        numCaravana = numCaravana.Substring(numCaravana.IndexOf("858"), 15)
                    Else
                        numCaravana = numCaravana.Substring(numCaravana.IndexOf("999"), 15)
                    End If


                    Me.chip.Text = numCaravana
                    'Me.lbini.Text = numCaravana.Substring(6, 5)
                    'Me.lbFin.Text = numCaravana.Substring(11, 4)
                    numCaravana = ""
                End If
            End If

        End If

    End Sub


#Region "Puerto COM"


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

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If unafachada.tipoBaston = 1 Then
                numCaravana = SerialPort1.ReadLine
            Else
                numCaravana = SerialPort1.ReadExisting

            End If

        Catch ex As Exception

        End Try


    End Sub

#End Region

    Public Sub TextoaVozHilo(ByVal ptexto As String)
        Try
            ' Initialize a new instance of the SpeechSynthesizer.
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak(ptexto)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chip_TextChanged(sender As System.Object, e As System.EventArgs) Handles chip.TextChanged

        If Me.chip.Text.Length > 0 Then
            Try
                If Me.chip.Text.Length = 15 Then
                    
                    Select Case chip.Text
                        Case unafachada.chipCambiar
                            Try
                                Me.cboIngresos.SelectedIndex += 1
                            Catch ex As Exception
                                Me.cboIngresos.SelectedIndex = 0
                            End Try
                        Case unafachada.chipEnter
                            If Me.LsView.Items.Count > 0 Then
                                Me.Close()
                            Else
                                Dim textoaVoz As New Thread(AddressOf TextoaVozHilo) 'Crear el hilo 1
                                textoaVoz.Start("Actividad sin chip asociados")
                            End If

                    End Select
                End If
            Catch ex As Exception

            End Try

        End If
        Me.chip.Text = ""

    End Sub

    Private Sub chkTareasAnteriores_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTareasAnteriores.CheckedChanged

    End Sub

    Private Sub chkSonido_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSonido.CheckedChanged
        If Me.chkSonido.Checked = True Then
            unafachada.ActivarSonido = True
        Else
            unafachada.ActivarSonido = False
        End If
    End Sub
End Class