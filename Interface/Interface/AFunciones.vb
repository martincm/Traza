Imports Dominio
Imports Presentacion.IUInicio
Imports Microsoft.Office.Interop
Imports System



Public Class AFunciones
    Inherits System.Windows.Forms.Form
    Friend WithEvents DiasUbicacionActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trazabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents potreroDes As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents idpotreroDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents potrero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idpotrero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tenencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacionDes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents propietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cruza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents raza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dispositivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eventoLin As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdEventoLin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents evento As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdEvento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents dtgvEventos As System.Windows.Forms.DataGridView


    Public Sub ExportarExcelListViewyAbrirlo(ByVal pListView As ListView, ByVal pTituloInforme As String)
        '/////////////////////////////
        '// Creamos el Objeto Excel
        '/////////////////////////////
        Dim m_Excel
        Dim objLibroExcel
        Dim objHojaExcel
        m_Excel = CreateObject("Excel.Application")
        objLibroExcel = m_Excel.Workbooks.Add()
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Name = "Exportado"
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()

        '/////////////////////////////////////////////////////////
        '// Definimos dos variables para controlar fila y columna
        '/////////////////////////////////////////////////////////
        Dim fila As Integer = 4
        Dim columna As Integer = 1
        Dim columnaItem As Integer = 0

        objHojaExcel.Range("A1").Value = pTituloInforme

        Dim objRango2 As Excel.Range
        Try
            objRango2 = objHojaExcel.Range("A1")
        Catch ex As Exception

        End Try
        objRango2.Font.Bold = True
        objRango2.Font.Size = 18
        ' objRango2.Cells.Interior.ColorIndex = 35

        '/////////////////////////////////////////////////
        '// Armamos la linea con los títulos de columnas
        '/////////////////////////////////////////////////
        objHojaExcel.Range("A1").Select()

        For Each columnheader As ColumnHeader In pListView.Columns
            objHojaExcel.Range(nombreColumna(columna) & 4).Value = columnheader.Text
            columna += 1
        Next

        fila += 1

        '/////////////////////////////////////////////
        '// Le damos formato a la fila de los títulos
        '/////////////////////////////////////////////
        Dim objRango As Excel.Range
        Try
            objRango = objHojaExcel.Range("A4:" & nombreColumna(pListView.Columns.Count) & "4")
        Catch ex As Exception

        End Try

        objRango.Font.Bold = True
        objRango.Cells.Font.ColorIndex = 2
        objRango.Cells.Interior.ColorIndex = 10

        objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        '//////////////////////////////////////////
        '// Cargamos todas las filas del datatable
        '//////////////////////////////////////////
        columna = 1

        For Each filaList As ListViewItem In pListView.Items
            columna = 1
            columnaItem = 0
            For Each nombreColumnaList As ColumnHeader In pListView.Columns
                Try
                    Dim valorFila As Object = filaList.SubItems(columnaItem).Text
                    If IsNumeric(valorFila) Then
                        valorFila = CDec(valorFila)
                    End If
                    objHojaExcel.Range(nombreColumna(columna) & fila).Value = valorFila
                Catch ex As Exception

                End Try
                columnaItem += 1
                columna += 1
            Next
            fila += 1
        Next
        '//////////////////////////////////////
        '// Ajustamos automaticamente el ancho
        '// de todas las columnas utilizada
        '//////////////////////////////////////
        Dim RangoInicial As String = "A4:"
        Dim RangoFinal As String = nombreColumna(pListView.Columns.Count) & CStr(pListView.Items.Count + 4)
        objRango = objHojaExcel.Range(RangoInicial & RangoFinal)
        objRango.Select()
        objRango.Columns.AutoFit()
        '/////////////////////////////////////
        '// Le decimos a Excel que se muestre
        '/////////////////////////////////////
        m_Excel.Visible = True

    End Sub

    Public Function nombreColumna(ByVal numero As Integer) As String
        Dim columna(256) As String
        columna(1) = "A"
        columna(2) = "B"
        columna(3) = "C"
        columna(4) = "D"
        columna(5) = "E"
        columna(6) = "F"
        columna(7) = "G"
        columna(8) = "H"
        columna(9) = "I"
        columna(10) = "J"
        columna(11) = "K"
        columna(12) = "L"
        columna(13) = "M"
        columna(14) = "N"
        columna(15) = "O"
        columna(16) = "P"
        columna(17) = "Q"
        columna(18) = "R"
        columna(19) = "S"
        columna(20) = "T"
        columna(21) = "U"
        columna(22) = "V"
        columna(23) = "W"
        columna(24) = "X"
        columna(25) = "Y"
        columna(26) = "Z"
        columna(27) = "AA"
        columna(28) = "AB"
        columna(29) = "AC"
        columna(30) = "AD"
        columna(31) = "AE"
        columna(32) = "AF"
        columna(33) = "AG"
        columna(34) = "AH"
        columna(35) = "AI"
        columna(36) = "AJ"
        columna(37) = "AK"
        columna(38) = "AL"
        columna(39) = "AM"
        columna(40) = "AN"
        columna(41) = "AO"
        columna(42) = "AP"
        columna(43) = "AQ"
        columna(44) = "AR"
        columna(45) = "AS"
        columna(46) = "AT"
        columna(47) = "AU"
        columna(48) = "AV"
        columna(49) = "AW"
        columna(50) = "AX"
        columna(51) = "AY"
        columna(52) = "AZ"
        columna(53) = "BA"
        columna(54) = "BB"
        columna(55) = "BC"
        columna(56) = "BD"
        columna(57) = "BE"
        columna(58) = "BF"
        columna(59) = "BG"
        columna(60) = "BH"
        columna(61) = "BI"
        columna(62) = "BJ"
        columna(63) = "BK"
        columna(64) = "BL"
        columna(65) = "BM"
        columna(66) = "BN"
        columna(67) = "BO"
        columna(68) = "BP"
        columna(69) = "BQ"
        columna(70) = "BR"
        columna(71) = "BS"
        columna(72) = "BT"
        columna(73) = "BU"
        columna(74) = "BV"
        columna(75) = "BW"
        columna(76) = "BX"
        columna(77) = "BY"
        columna(78) = "BZ"
        columna(79) = "CA"
        columna(80) = "CB"
        columna(81) = "CC"
        columna(82) = "CD"
        columna(83) = "CE"
        columna(84) = "CF"
        columna(85) = "CG"
        columna(86) = "CH"
        columna(87) = "CI"
        columna(88) = "CJ"
        columna(89) = "CK"
        columna(90) = "CL"
        columna(91) = "CM"
        columna(92) = "CN"
        columna(93) = "CO"
        columna(94) = "CP"
        columna(95) = "CQ"
        columna(96) = "CR"
        columna(97) = "CS"
        columna(98) = "CT"
        columna(99) = "CU"
        columna(100) = "CV"
        columna(101) = "CW"
        columna(102) = "CX"
        columna(103) = "CY"
        columna(104) = "CZ"
        columna(105) = "DA"
        columna(106) = "DB"
        columna(107) = "DC"
        columna(108) = "DD"
        columna(109) = "DE"
        columna(110) = "DF"
        columna(111) = "DG"
        columna(112) = "DH"
        columna(113) = "DI"
        columna(114) = "DJ"
        columna(115) = "DK"
        columna(116) = "DL"
        columna(117) = "DM"
        columna(118) = "DN"
        columna(119) = "DO"
        columna(120) = "DP"
        columna(121) = "DQ"
        columna(122) = "DR"
        columna(123) = "DS"
        columna(124) = "DT"
        columna(125) = "DU"
        columna(126) = "DV"
        columna(127) = "DW"
        columna(128) = "DX"
        columna(129) = "DY"
        columna(130) = "DZ"
        columna(131) = "EA"
        columna(132) = "EB"
        columna(133) = "EC"
        columna(134) = "ED"
        columna(135) = "EE"
        columna(136) = "EF"
        columna(137) = "EG"
        columna(138) = "EH"
        columna(139) = "EI"
        columna(140) = "EJ"
        columna(141) = "EK"
        columna(142) = "EL"
        columna(143) = "EM"
        columna(144) = "EN"
        columna(145) = "EO"
        columna(146) = "EP"
        columna(147) = "EQ"
        columna(148) = "ER"
        columna(149) = "ES"
        columna(150) = "ET"
        columna(151) = "EU"
        columna(152) = "EV"
        columna(153) = "EW"
        columna(154) = "EX"
        columna(155) = "EY"
        columna(156) = "EZ"
        columna(157) = "FA"
        columna(158) = "FB"
        columna(159) = "FC"
        columna(160) = "FD"
        columna(161) = "FE"
        columna(162) = "FF"
        columna(163) = "FG"
        columna(164) = "FH"
        columna(165) = "FI"
        columna(166) = "FJ"
        columna(167) = "FK"
        columna(168) = "FL"
        columna(169) = "FM"
        columna(170) = "FN"
        columna(171) = "FO"
        columna(172) = "FP"
        columna(173) = "FQ"
        columna(174) = "FR"
        columna(175) = "FS"
        columna(176) = "FT"
        columna(177) = "FU"
        columna(178) = "FV"
        columna(179) = "FW"
        columna(180) = "FX"
        columna(181) = "FY"
        columna(182) = "FZ"
        columna(183) = "GA"
        columna(184) = "GB"
        columna(185) = "GC"
        columna(186) = "GD"
        columna(187) = "GE"
        columna(188) = "GF"
        columna(189) = "GG"
        columna(190) = "GH"
        columna(191) = "GI"
        columna(192) = "GJ"
        columna(193) = "GK"
        columna(194) = "GL"
        columna(195) = "GM"
        columna(196) = "GN"
        columna(197) = "GO"
        columna(198) = "GP"
        columna(199) = "GQ"
        columna(200) = "GR"
        columna(201) = "GS"
        columna(202) = "GT"
        columna(203) = "GU"
        columna(204) = "GV"
        columna(205) = "GW"
        columna(206) = "GX"
        columna(207) = "GY"
        columna(208) = "GZ"
        columna(209) = "HA"
        columna(210) = "HB"
        columna(211) = "HC"
        columna(212) = "HD"
        columna(213) = "HE"
        columna(214) = "HF"
        columna(215) = "HG"
        columna(216) = "HH"
        columna(217) = "HI"
        columna(218) = "HJ"
        columna(219) = "HK"
        columna(220) = "HL"
        columna(221) = "HM"
        columna(222) = "HN"
        columna(223) = "HO"
        columna(224) = "HP"
        columna(225) = "HQ"
        columna(226) = "HR"
        columna(227) = "HS"
        columna(228) = "HT"
        columna(229) = "HU"
        columna(230) = "HV"
        columna(231) = "HW"
        columna(232) = "HX"
        columna(233) = "HY"
        columna(234) = "HZ"
        columna(235) = "IA"
        columna(236) = "IB"
        columna(237) = "IC"
        columna(238) = "ID"
        columna(239) = "IE"
        columna(240) = "IF"
        columna(241) = "IG"
        columna(242) = "IH"
        columna(243) = "II"
        columna(244) = "IJ"
        columna(245) = "IK"
        columna(246) = "IL"
        columna(247) = "IM"
        columna(248) = "IN"
        columna(249) = "IO"
        columna(250) = "IP"
        columna(251) = "IQ"
        columna(252) = "IR"
        columna(253) = "IS"
        columna(254) = "IT"
        columna(255) = "IU"
        columna(256) = "IV"
        Return columna(numero)
    End Function

    Private Sub AFunciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub InitializeComponent()
        Me.dtgvEventos = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evento = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdEventoLin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventoLin = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dispositivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cruza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacionDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpotrero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.potrero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpotreroDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.potreroDes = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.vida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trazabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasUbicacionActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtgvEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvEventos
        '
        Me.dtgvEventos.AllowUserToAddRows = False
        Me.dtgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.fecha, Me.lote, Me.numeracion, Me.IdEvento, Me.evento, Me.IdEventoLin, Me.eventoLin, Me.Uni, Me.cnt, Me.dispositivo, Me.raza, Me.cruza, Me.sexo, Me.edad, Me.propietario, Me.ubicacion, Me.ubicacionDes, Me.tenencia, Me.idpotrero, Me.potrero, Me.idpotreroDestino, Me.potreroDes, Me.vida, Me.trazabilidad, Me.IdLinea, Me.DiasUbicacionActual})
        Me.dtgvEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgvEventos.Location = New System.Drawing.Point(49, 29)
        Me.dtgvEventos.Name = "dtgvEventos"
        Me.dtgvEventos.RowHeadersWidth = 25
        Me.dtgvEventos.Size = New System.Drawing.Size(612, 189)
        Me.dtgvEventos.TabIndex = 501
        '
        'chk
        '
        Me.chk.FillWeight = 30.0!
        Me.chk.HeaderText = "*"
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk.Width = 30
        '
        'fecha
        '
        Me.fecha.FillWeight = 70.0!
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 70
        '
        'lote
        '
        Me.lote.FillWeight = 120.0!
        Me.lote.HeaderText = "Lote"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        Me.lote.Width = 120
        '
        'numeracion
        '
        Me.numeracion.FillWeight = 35.0!
        Me.numeracion.HeaderText = "Num."
        Me.numeracion.Name = "numeracion"
        Me.numeracion.ReadOnly = True
        Me.numeracion.Width = 35
        '
        'IdEvento
        '
        Me.IdEvento.FillWeight = 20.0!
        Me.IdEvento.HeaderText = "Id"
        Me.IdEvento.Name = "IdEvento"
        Me.IdEvento.ReadOnly = True
        Me.IdEvento.Width = 20
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.ReadOnly = True
        '
        'IdEventoLin
        '
        Me.IdEventoLin.FillWeight = 20.0!
        Me.IdEventoLin.HeaderText = "Id"
        Me.IdEventoLin.Name = "IdEventoLin"
        Me.IdEventoLin.ReadOnly = True
        Me.IdEventoLin.Width = 20
        '
        'eventoLin
        '
        Me.eventoLin.HeaderText = "Sub-Evento"
        Me.eventoLin.MaxDropDownItems = 25
        Me.eventoLin.Name = "eventoLin"
        Me.eventoLin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eventoLin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Uni
        '
        Me.Uni.FillWeight = 40.0!
        Me.Uni.HeaderText = "Unid."
        Me.Uni.Name = "Uni"
        Me.Uni.ReadOnly = True
        Me.Uni.Width = 40
        '
        'cnt
        '
        Me.cnt.FillWeight = 40.0!
        Me.cnt.HeaderText = "Cnt."
        Me.cnt.Name = "cnt"
        Me.cnt.Width = 40
        '
        'dispositivo
        '
        Me.dispositivo.HeaderText = "Dispositivo"
        Me.dispositivo.Name = "dispositivo"
        Me.dispositivo.ReadOnly = True
        '
        'raza
        '
        Me.raza.FillWeight = 40.0!
        Me.raza.HeaderText = "Raza"
        Me.raza.Name = "raza"
        Me.raza.ReadOnly = True
        Me.raza.Width = 40
        '
        'cruza
        '
        Me.cruza.FillWeight = 40.0!
        Me.cruza.HeaderText = "Cruza"
        Me.cruza.Name = "cruza"
        Me.cruza.ReadOnly = True
        Me.cruza.Width = 40
        '
        'sexo
        '
        Me.sexo.FillWeight = 40.0!
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Width = 40
        '
        'edad
        '
        Me.edad.FillWeight = 40.0!
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.Width = 40
        '
        'propietario
        '
        Me.propietario.FillWeight = 80.0!
        Me.propietario.HeaderText = "Propietario"
        Me.propietario.Name = "propietario"
        Me.propietario.ReadOnly = True
        Me.propietario.Width = 80
        '
        'ubicacion
        '
        Me.ubicacion.FillWeight = 80.0!
        Me.ubicacion.HeaderText = "Ubicacion"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        Me.ubicacion.Width = 80
        '
        'ubicacionDes
        '
        Me.ubicacionDes.HeaderText = "Destino"
        Me.ubicacionDes.Name = "ubicacionDes"
        '
        'tenencia
        '
        Me.tenencia.FillWeight = 80.0!
        Me.tenencia.HeaderText = "Tenencia"
        Me.tenencia.Name = "tenencia"
        Me.tenencia.ReadOnly = True
        Me.tenencia.Width = 80
        '
        'idpotrero
        '
        Me.idpotrero.FillWeight = 20.0!
        Me.idpotrero.HeaderText = "Id"
        Me.idpotrero.Name = "idpotrero"
        Me.idpotrero.ReadOnly = True
        Me.idpotrero.Width = 20
        '
        'potrero
        '
        Me.potrero.FillWeight = 80.0!
        Me.potrero.HeaderText = "Potrero"
        Me.potrero.Name = "potrero"
        Me.potrero.ReadOnly = True
        Me.potrero.Width = 80
        '
        'idpotreroDestino
        '
        Me.idpotreroDestino.HeaderText = "Id"
        Me.idpotreroDestino.Name = "idpotreroDestino"
        Me.idpotreroDestino.ReadOnly = True
        '
        'potreroDes
        '
        Me.potreroDes.HeaderText = "Potrero Des."
        Me.potreroDes.Name = "potreroDes"
        Me.potreroDes.ReadOnly = True
        Me.potreroDes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.potreroDes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'vida
        '
        Me.vida.FillWeight = 50.0!
        Me.vida.HeaderText = "Vida"
        Me.vida.Name = "vida"
        Me.vida.ReadOnly = True
        Me.vida.Width = 50
        '
        'trazabilidad
        '
        Me.trazabilidad.FillWeight = 40.0!
        Me.trazabilidad.HeaderText = "Traza."
        Me.trazabilidad.Name = "trazabilidad"
        Me.trazabilidad.ReadOnly = True
        Me.trazabilidad.Width = 40
        '
        'IdLinea
        '
        Me.IdLinea.FillWeight = 30.0!
        Me.IdLinea.HeaderText = "Id"
        Me.IdLinea.Name = "IdLinea"
        Me.IdLinea.ReadOnly = True
        Me.IdLinea.Width = 30
        '
        'DiasUbicacionActual
        '
        Me.DiasUbicacionActual.FillWeight = 150.0!
        Me.DiasUbicacionActual.HeaderText = "Dias Ubicacion Actual"
        Me.DiasUbicacionActual.Name = "DiasUbicacionActual"
        Me.DiasUbicacionActual.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 26)
        Me.Button1.TabIndex = 502
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AFunciones
        '
        Me.ClientSize = New System.Drawing.Size(691, 374)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtgvEventos)
        Me.Name = "AFunciones"
        CType(Me.dtgvEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub dtgvEventos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvEventos.CellContentClick

    End Sub
End Class
