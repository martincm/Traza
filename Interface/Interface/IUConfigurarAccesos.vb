Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports System.Threading
Imports System.IO.Ports
Public Class IUConfigurarAccesos


    'COMBO EVENTOS LINEAS
    Dim dtListaEventosLineas As DataTable = unafachada.TodosLasListasEventosLineas()
    Dim dtListaEventos As DataTable = unafachada.TodosLasListasEventos
    Dim dsMenu As DataSet = unafachada.TodosLosMenu
    Private CodigoEvento, CodigoEventoLineas
    Dim puertoCOM As String
    Public Shared numCaravana As String
    Dim focoChip As Integer
    Dim fonetica As String
    Dim conectado As Boolean
    Dim puerto As String

   


    Public Sub guardar()
        Dim bandera As Boolean = False
        Dim cntBotones As Integer = 0
        Dim mensaje As String = "Desde guardar los cambios"
        If (MsgBox(mensaje, _
                        MsgBoxStyle.YesNo, _
                       "Sistema Trazabilidad - Ingresos")) = MsgBoxResult.Yes Then
            unafachada.agregoTareaNueva = 1
            'Guardar Detalle
            For Each lv As ListViewItem In LsView.Items


                Dim Chip As String = lv.SubItems(1).Text
                Dim IdOpcion As Integer = lv.SubItems(2).Text
                Dim Opcion As String = lv.SubItems(3).Text
                Dim IdTipo As Integer = lv.SubItems(4).Text
                Dim Tipo As String = lv.SubItems(5).Text
                Dim IdActividad As Integer = lv.SubItems(6).Text
                Dim Actividad As String = lv.SubItems(7).Text
                Dim Fonetica As String = lv.SubItems(8).Text

                Dim unBoton As DataRow = unafachada.BuscarBoton(IdOpcion, IdTipo, IdActividad)
                If unBoton Is Nothing Then
                    Dim UltimoBoton As Integer = unafachada.TraerUltimoId("menuSub", "menu_sub_id")
                    Dim cadena As String = "INSERT INTO menuSub (menu_sub_id,menu_sub_dispositivo,menu_sub_IdOpcion,menu_sub_Opcion,menu_sub_idTipo,menu_sub_Tipo,menu_sub_idActividad,menu_sub_Actividad,menu_sub_fonetica) VALUES (" & UltimoBoton & "," & "'" & Chip & "'" & "," & IdOpcion & "," & "'" & Opcion & "'" & "," & IdTipo & "," & "'" & Tipo & "'" & "," & IdActividad & "," & "'" & Actividad & "'" & "," & "'" & Fonetica & "'" & ")"
                    bandera = unafachada.EjecutarConsultaGENERICA(cadena)
                    'Else
                    '    unafachada.EjecutarConsultaGENERICA("UPDATE menuSub SET menu_sub_dispositivo =" & "'" & Chip & "'" & ", menu_sub_IdOpcion =" & IdOpcion & ", menu_sub_Opcion =" & "'" & Opcion & "'" & ", menu_sub_idTipo =" & IdTipo & ", menu_sub_Tipo =" & "'" & Tipo & "'" & ", menu_sub_idActividad =" & IdActividad & ", menu_sub_Actividad =" & "'" & Actividad & "'" & " WHERE menuSub.menu_sub_IdOpcion=" & IdOpcion & " AND menuSub.menu_sub_idTipo= " & IdTipo & " AND menuSub.menu_sub_idActividad=" & IdActividad)
                End If
                cntBotones += 1
            Next

            Dim cadenaCabezal As String
            Dim fecha As String = Today.Year & "/" & Today.Month & "/" & Today.Day
            Dim unCabezal As DataRow = unafachada.BuscarMenu(Me.txtNombreActividad.Text, dsMenu.Tables(0))
            If unCabezal Is Nothing Then
                Dim UltimoMenu As Integer = unafachada.TraerUltimoId("menu", "menu_id")
                cadenaCabezal = "INSERT INTO menu (menu_id,menu_nombre,menu_cnt_botones,menu_tipo,menu_fecha) VALUES (" & UltimoMenu & "," & "'" & Me.txtNombreActividad.Text & "'" & "," & cntBotones & "," & "'" & Me.cboTipo.SelectedItem & "'" & "," & "'" & fecha & "'" & ")"
            Else
                cadenaCabezal = "UPDATE menu SET menu_nombre =" & "'" & Me.txtNombreActividad.Text & "'" & ", menu_cnt_botones =" & cntBotones & ", menu_tipo =" & "'" & cboTipo.SelectedItem & "'" & ", menu_fecha =" & "'" & fecha & "'" & " WHERE menu_id=" & Me.txtCodigo.Text
            End If
            unafachada.EjecutarConsultaGENERICA(cadenaCabezal)
            limpiarMenu()



        End If
    End Sub


    Public Sub Eliminar()

        Dim Chip As String = LsView.FocusedItem.SubItems(1).Text
        Dim IdOpcion As Integer = LsView.FocusedItem.SubItems(2).Text
        Dim Opcion As String = LsView.FocusedItem.SubItems(3).Text
        Dim IdTipo As Integer = LsView.FocusedItem.SubItems(4).Text
        Dim Tipo As String = LsView.FocusedItem.SubItems(5).Text
        Dim IdActividad As Integer = LsView.FocusedItem.SubItems(6).Text
        Dim Actividad As String = LsView.FocusedItem.SubItems(7).Text

        Dim mensaje As String = "Desde Eliminar el chip: " & Chip & " Opcion: " & Opcion
        If (MsgBox(mensaje, _
                        MsgBoxStyle.YesNo, _
                       "Sistema Trazabilidad - Eliminar")) = MsgBoxResult.Yes Then
            For i As Integer = LsView.SelectedItems.Count - 1 To 0 Step -1
                LsView.SelectedItems(i).Remove()
            Next

            Dim unBoton As DataRow = unafachada.BuscarBoton(IdOpcion, IdTipo, IdActividad)
            If Not unBoton Is Nothing Then
                If unafachada.EliminarBoton(IdOpcion, IdTipo, IdActividad) Then
                    'MsgBox("Eliminado")
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
            MsgBox(SerialPort1.ReadExisting.ToString)
        End Try


    End Sub

#End Region

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


    Public Sub setearNumeroEventoLineas(ByRef pCodigoEventoLineas As Integer, ByRef pFonetica As String)
        Try
            Dim unaFila As DataRow = unafachada.BuscarListaEventosLineas(Me.cboEventos1.SelectedItem, dtListaEventosLineas, "eve_lin_nombre")
            pCodigoEventoLineas = unaFila.Item("eve_lin_id")
            pFonetica = unaFila.Item("eve_lin_fonetica")
        Catch ex As Exception
            pCodigoEventoLineas = 0
            pFonetica = ""
        End Try
    End Sub

    Public Sub setearNumeroEvento(ByRef pCodigoEvento As Integer)
        Try
            Dim unaFila As DataRow = unafachada.BuscarListaEventos(Me.cboTipo.SelectedItem, dtListaEventos)
            pCodigoEvento = unaFila.Item("eve_id")
        Catch ex As Exception
            pCodigoEvento = 0

        End Try
    End Sub


    Private Sub cboEventos1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        limpiarMenu()
    End Sub

    Public Sub limpiarMenu()
        CrearColumnas()
        Me.chip.Text = ""
        Me.txtNombreActividad.Text = ""
        Me.txtCodigo.Text = unafachada.TraerUltimoId("menu", "menu_id")
        Me.cboTipo.SelectedIndex = 1
        Me.cboIngresos.SelectedIndex = -1
        Me.txtNombreActividad.Focus()
    End Sub

    Public Sub CrearColumnas()
        With LsView
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("Nº Boton", 70, HorizontalAlignment.Left)
            .Columns.Add("Chip", 120, HorizontalAlignment.Left)
            .Columns.Add("Id", 30, HorizontalAlignment.Left)
            .Columns.Add("Opcion", 100, HorizontalAlignment.Left)
            .Columns.Add("Id", 30, HorizontalAlignment.Left)
            .Columns.Add("Tipo", 100, HorizontalAlignment.Left)
            .Columns.Add("Id", 30, HorizontalAlignment.Left)
            .Columns.Add("Actividad", 120, HorizontalAlignment.Left)
            .Columns.Add("Fonetica", 100, HorizontalAlignment.Left)
        End With

        '.View = View.Details
        '.FullRowSelect = False

        '.GridLines = True

        '.HideSelection = False
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

    Public Function BuscarChip()
        For Each lv As ListViewItem In LsView.Items
            If Me.chip.Text = lv.SubItems(1).Text Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function


    Public Sub ReasignarNumeracion()
        Dim i As Integer = 1
        If LsView.Items.Count > 0 Then
            For Each lv As ListViewItem In LsView.Items
                lv.SubItems(0).Text = i
                i += 1
            Next
        End If

    End Sub


    Public Sub AgregarUnaFila(ByVal pEvento As String, ByVal pChip As String)
        If CodigoEvento > 0 And Me.chip.Text.Length > 0 And CodigoEventoLineas > 1 Then

            If BuscarChip() = False Then
                If BuscarEnListview(CodigoEventoLineas) Then
                    MsgBox("Ya existe esa opcion en dispositivo")
                Else
                    Dim fila As New ListViewItem
                    Dim ultimoNumero As Integer = LsView.Items.Count + 1
                    fila = LsView.Items.Add(ultimoNumero)
                    fila.SubItems.Add(pChip)
                    fila.SubItems.Add(CodigoEventoLineas)
                    fila.SubItems.Add(pEvento)
                    fila.SubItems.Add(CodigoEvento)
                    fila.SubItems.Add(cboTipo.SelectedItem)
                    fila.SubItems.Add(Me.txtCodigo.Text)
                    fila.SubItems.Add(Me.txtNombreActividad.Text)
                    fila.SubItems.Add(fonetica)
                End If
            Else
                MsgBox("Dispositivo en uso")
            End If
        Else
            MsgBox("Seleccione un tipo para actividad , opcion del chip, leea el chip")
        End If


    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs)
        For i As Integer = LsView.SelectedItems.Count - 1 To 0 Step -1
            LsView.SelectedItems(i).Remove()
        Next
        ReasignarNumeracion()
        Eliminar()
    End Sub



    Private Sub txtGuardar_Click(sender As System.Object, e As System.EventArgs)
        guardar()
    End Sub

    



    Private Sub chip_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles chip.TextChanged
        Try
            If Me.chip.Text.Length = 15 Then
                Me.lbini.Text = chip.Text.Substring(6, 5)
                Me.lbFin.Text = chip.Text.Substring(11, 4)
            End If
        Catch ex As Exception
            Me.lbini.Text = ""
            Me.lbFin.Text = ""
        End Try

        'For i As Integer = LsView.SelectedItems.Count - 1 To 0 Step -1
        '    LsView.SelectedItems(i).SubItems(1).Text = Me.chip.Text
        '    'LsView.SelectedItems(i).SubItems(2).Text = CodigoEvento
        'Next
    End Sub

    Private Sub IUConfigurarAccesos_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.LsView.Items.Count > 0 Then
            guardar()
        End If
        unafachada.QuitarVentanaAbierta("IUConfigurarAccesos")
    End Sub


    Private Sub IUConfigurarAccesos_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CargarComboDesdeDataTable(Me.cboTipo, dtListaEventos, "eve_nombre")
        unafachada.TodosLosParametros()
        Me.Timer1.Enabled = False
        CrearColumnas()

        'Cargar COMBO TITULOS 
        Me.cboIngresos.Items.Clear()
        For Each unaFila As DataRow In dsMenu.Tables(0).Rows
            Me.cboIngresos.Items.Add(unaFila("menu_nombre"))
        Next
        Me.cboIngresos.SelectedIndex = -1
        ActivarBaston()
        limpiarMenu()
    End Sub

    Private Sub btnAgregar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        AgregarUnaFila(Me.cboEventos1.SelectedItem, Me.chip.Text)
    End Sub

    Private Sub btnBaston_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBaston.Click
        
    End Sub

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

    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If Not numCaravana Is Nothing Then
            If numCaravana.ToString.Length > 15 Then
                If numCaravana.Contains("LA URY") Then
                    Timer1.Enabled = False
                    MsgBox("Configure el baston con el codigo de su pais, 858 en el sistema alflex")

                Else

                    If unafachada.tipoBaston = 1 Then
                        numCaravana = numCaravana.Substring(numCaravana.IndexOf("858"), 15)
                    Else
                        numCaravana = numCaravana.Substring(numCaravana.IndexOf("152"), 15)
                    End If


                    Me.chip.Text = numCaravana
                    Me.lbini.Text = numCaravana.Substring(6, 5)
                    Me.lbFin.Text = numCaravana.Substring(11, 4)
                    numCaravana = ""
                End If
            End If

        End If
    End Sub

    

    Private Sub LsView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LsView.SelectedIndexChanged
        Try
            Me.lbini.Text = LsView.FocusedItem.SubItems(1).Text.Substring(6, 5)
            Me.lbFin.Text = LsView.FocusedItem.SubItems(1).Text.Substring(11, 4)
        Catch ex As Exception
            Me.lbini.Text = ""
            Me.lbFin.Text = ""
        End Try

        'If Me.LsView.Items.Count > 0 Then
        '    Me.chip.Text = LsView.FocusedItem.SubItems(1).Text
        '    Me.cboEventos1.SelectedItem = LsView.FocusedItem.SubItems(3).Text
        '    Me.btnAgregar.Visible = False
        '    Me.btnNuevo.Visible = True
        '    Try
        '        Me.lbini.Text = chip.Text.Substring(6, 5)
        '        Me.lbFin.Text = chip.Text.Substring(11, 4)
        '    Catch ex As Exception
        '        Me.lbini.Text = ""
        '        Me.lbFin.Text = ""
        '    End Try

        'End If
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        setearNumeroEvento(CodigoEvento)

        If Me.cboTipo.SelectedIndex > 0 Then
            CargarComboLineas(Me.cboEventos1, dtListaEventosLineas, "eve_lin_nombre", CodigoEvento)
        End If
    End Sub

    Private Sub cboEventos1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cboEventos1.SelectedIndexChanged
        setearNumeroEventoLineas(CodigoEventoLineas, fonetica)
    End Sub

    Private Sub ButtonX2_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Eliminar()
    End Sub

    Private Sub txtGuardar_Click_1(sender As System.Object, e As System.EventArgs) Handles txtGuardar.Click
        guardar()
    End Sub

    Private Sub ButtonX1_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        limpiarMenu()

    End Sub

    Private Sub cboIngresos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboIngresos.SelectedIndexChanged
        Dim unaFilaMenu As DataRow = unafachada.BuscarMenu(Me.cboIngresos.SelectedItem, dsMenu.Tables(0))

        If Not unaFilaMenu Is Nothing Then
            CrearColumnas()
            txtCodigo.Text = unaFilaMenu.Item("menu_id")
            txtNombreActividad.Text = unaFilaMenu.Item("menu_nombre")
            Me.cboTipo.SelectedItem = unaFilaMenu.Item("menu_tipo")
            Dim dsSubMenuDetalle As DataSet = unafachada.BuscarSubMenu(txtCodigo.Text)

            If Not dsSubMenuDetalle Is Nothing Then
                If dsSubMenuDetalle.Tables(0).Rows.Count > 0 Then
                    For Each rw As DataRow In dsSubMenuDetalle.Tables(0).Rows
                        Dim fila As New ListViewItem
                        Dim ultimoNumero As Integer = LsView.Items.Count + 1
                        fila = LsView.Items.Add(ultimoNumero)
                        fila.SubItems.Add(rw.Item("menu_sub_dispositivo"))
                        fila.SubItems.Add(rw.Item("menu_sub_IdOpcion"))
                        fila.SubItems.Add(rw.Item("menu_sub_Opcion"))
                        fila.SubItems.Add(rw.Item("menu_sub_idTipo"))
                        fila.SubItems.Add(rw.Item("menu_sub_Tipo"))
                        fila.SubItems.Add(rw.Item("menu_sub_idActividad"))
                        fila.SubItems.Add(rw.Item("menu_sub_Actividad"))
                        fila.SubItems.Add(rw.Item("menu_sub_fonetica"))
                    Next rw
                End If
            End If

        End If
    End Sub


End Class