Imports System.IO
Imports Dac, Persistencia
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data.OleDb
Imports System.Net.Mail
Imports Ionic.Zip
Imports Microsoft.Office.Interop
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Imports System.Windows.Forms
Imports System.Data.SqlTypes


Public Class Fachada
    Private Cnn As OleDb.OleDbConnection
    Private Shared _StrConexion As String
    Dim StrComando As String
    Dim adapter As New OleDbDataAdapter
    Dim Cb As OleDbCommandBuilder
    Private _nombre As String
    Private _TipoBaseDatos As String
    Private _listaVentanas As List(Of String)
    Private _tipoBaston As Integer
    Private _puertoBaston As String
    Private _NombreArchivoSeleccionado As String
    Private _AgregoTareaNueva As Integer
    Private _chipEnter As String
    Private _chipCambiar As String
    Private _chipDiccionario As String
    Private _ActivarSonido As Boolean


    Public Property ActivarSonido() As Boolean
        Get
            Return Me._ActivarSonido
        End Get
        Set(ByVal value As Boolean)
            Me._ActivarSonido = value
        End Set
    End Property

    Public Property chipCambiar() As String
        Get
            Return Me._chipCambiar
        End Get
        Set(ByVal value As String)
            Me._chipCambiar = value
        End Set
    End Property

    Public Property chipEnter() As String
        Get
            Return Me._chipEnter
        End Get
        Set(ByVal value As String)
            Me._chipEnter = value
        End Set
    End Property

    Public Property chipDiccionario() As String
        Get
            Return Me._chipDiccionario
        End Get
        Set(ByVal value As String)
            Me._chipDiccionario = value
        End Set
    End Property

    Public Property NombreArchivoSeleccionado() As String
        Get
            Return Me._NombreArchivoSeleccionado
        End Get
        Set(ByVal value As String)
            Me._NombreArchivoSeleccionado = value
        End Set
    End Property


    Protected Shared Function Conectar() As OleDbConnection
        Try
            Return New OleDbConnection(_StrConexion)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Property ListaVentanas() As List(Of String)
        Get
            Return Me._listaVentanas
        End Get
        Set(ByVal value As List(Of String))
            Me._listaVentanas = value
        End Set
    End Property

    Public Property StrConexion() As String
        Get
            Return Fachada._StrConexion
        End Get

        Set(value As String)
            _StrConexion = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(ByVal value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property TipoBaseDatos() As String
        Get
            Return Me._TipoBaseDatos
        End Get
        Set(ByVal value As String)
            Me._TipoBaseDatos = value
        End Set
    End Property

    Public Property tipoBaston() As Integer
        Get
            Return Me._tipoBaston
        End Get
        Set(ByVal value As Integer)
            Me._tipoBaston = value
        End Set
    End Property

    Public Property agregoTareaNueva() As Integer
        Get
            Return Me._AgregoTareaNueva
        End Get
        Set(ByVal value As Integer)
            Me._AgregoTareaNueva = value
        End Set
    End Property


    Public Property puertoBaston() As String
        Get
            Return Me._puertoBaston
        End Get
        Set(ByVal value As String)
            Me._puertoBaston = value
        End Set
    End Property


    Public Sub New()
        'Dim opcion As Integer = InputBox("Ingrese base datos")
        Dim opcion As Integer = 3
        ListaVentanas = New List(Of String)
        If IsConnectionAvailableServer("192.168.0.199") Then
            pPersistente.mCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\servidor\Trazauru\TrazaUru.mdb;Persist Security Info=False"
        Else
            Select Case opcion

                Case 1
                    pPersistente.mCadenaConexionSQLSERVER = "Data Source=.\SQLEXPRESS;AttachDbFileName=c:\traza\Traza_Uru_Data.mdf;Integrated Security=True;User Instance=False"
                    Me.StrConexion = pPersistente.mCadenaConexionSQLSERVER
                    Me.TipoBaseDatos = "SQLEXPRESS"
                Case 2
                    Dim cadenaMySQL As String = "Server=localhost;" & _
                    "Database=traza;User=root;Password=04poreso"
                    'Dim cadenaMySQL As String = "Server=db4free.net; Database=traza; Uid=martincm; Pwd=04poreso;Port=3306;"
                    pPersistente.mCadenaConexionMySQL = cadenaMySQL
                    Me.StrConexion = pPersistente.mCadenaConexionMySQL
                    Me.TipoBaseDatos = "MySQL"
                Case 3
                    pPersistente.mCadenaConexion = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & Environment.CurrentDirectory & "\TrazaUru.mdb"
                    Me.StrConexion = pPersistente.mCadenaConexion
                    Me.TipoBaseDatos = "ACCESS"


            End Select

        End If

        Try
            Me.tipoBaston = BuscarParametros("Baston").ValorParametro
            Me.puertoBaston = BuscarParametros("Puerto").ValorParametro
            Me.chipEnter = BuscarParametros("ChipEnter").ValorParametro
            Me.chipCambiar = BuscarParametros("ChipCambiar").ValorParametro
            Me.chipDiccionario = BuscarParametros("ChipDiccionario").ValorParametro
            Me.ActivarSonido = True
        Catch ex As Exception
            MsgBox("Error al obtener configuracion de baston")
        End Try

    End Sub

    Public Function DevolverNumeroCaravana(ByVal pNumero As String) As String
        Dim cntceros As Integer = 12 - pNumero.ToString.Length
        Dim ceros As String = StrDup(cntceros, "0")
        Dim numCaravana As String = "858" & ceros & pNumero
        Return numCaravana
    End Function


    Public Function TraerUltimoId(ByVal pTabla As String, ByVal pCampo As String) As Integer
        Dim retorno As Integer
        Try
            Dim unDs As DataSet = EjecutarConsultaGENERICADataSet("SELECT MAX(" & pCampo & ")" & "FROM " & pTabla)
            retorno = unDs.Tables(0).Rows(0).Item(0) + 1
        Catch ex As Exception
            retorno = 1
        End Try
        Return retorno
    End Function

    Public Function BuscarVentanaAbierta(ByVal pNombre As String) As Boolean
        Dim i As Integer = 0
        For i = 0 To Me.ListaVentanas.Count - 1
            If ListaVentanas.Item(i) = pNombre Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function QuitarVentanaAbierta(ByVal pNombre As String) As Boolean
        Dim i As Integer = 0
        For i = 0 To Me.ListaVentanas.Count - 1
            If ListaVentanas.Item(i) = pNombre Then
                Me.ListaVentanas.RemoveAt(i)
                Return True
            End If
        Next
        Return False

    End Function

    Public Function Extraer(ByVal nombreArchivo As String)
        Dim ZipAExtraer As String = Environment.CurrentDirectory & "\" & nombreArchivo
        Dim DirectorioExtraccion As String = Environment.CurrentDirectory
        Using zip1 As ZipFile = ZipFile.Read(ZipAExtraer)
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(DirectorioExtraccion, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Function

    Public Function Comprimir(ByVal nombreArchivo As String)
        Using zip As ZipFile = New ZipFile()
            zip.AddFile(Environment.CurrentDirectory & "\" & nombreArchivo)
            ' zip.AddFile("Archivo2")
            '  zip.AddFile("Archivo3")
            zip.Save("nombreArchivo.zip")
        End Using
    End Function

    Public Function BajarYObtenerCotizacion(ByVal pFechaArchivo As String) As List(Of String)
        Dim direccion As String = "http://www3.bcu.gub.uy/autoriza/opinme/" & "oicot" & pFechaArchivo & ".txt"
        Dim nombreArchivo As String = "oicot" & pFechaArchivo & ".txt"
        Dim existe As Boolean = File.Exists(Environment.CurrentDirectory & "\" & nombreArchivo)
        Dim lista As New List(Of String)

        If Not existe Then
            Descargar_Archivo(direccion, Environment.CurrentDirectory & "/oicot" & pFechaArchivo & ".txt")
            existe = File.Exists(Environment.CurrentDirectory & "\" & nombreArchivo)
        End If

        If existe Then
            Dim sr As StreamReader
            sr = New StreamReader((nombreArchivo))
            Dim Line As String = sr.ReadLine()

            While Not (Line Is Nothing)
                lista.Add(Line)
                Line = sr.ReadLine()
            End While
            sr.Close()
        End If
        Return lista
    End Function


    Public Function ObtenerCotizacion(ByVal pCodigoMoneda As String, ByVal pFecha As Date) As String
        'Recorro archivo txt y paso a Arraylist
        Dim bandera As Boolean = False
        Dim lineaRetorno As String = ""
        Dim linea As String = ""

        Dim mes As String = pFecha.Month
        Dim dia As String = pFecha.Day
        Dim ano As String = pFecha.Year

        If mes.Length = 1 Then
            mes = "0" & pFecha.Month
        End If

        If dia.Length = 1 Then
            dia = "0" & pFecha.Day
        End If
        ano = ano.Substring(2, 2)
        Dim fecha As String = dia & mes & ano

        Dim lista As List(Of String) = BajarYObtenerCotizacion(fecha)
        'Recorro Arraylist y encuentro plato y actualizo stock
        Dim i As Integer = 0
        For i = 0 To lista.Count - 1
            If lista.Item(i).Contains(pCodigoMoneda) Then
                linea = lista.Item(i)
                lineaRetorno = lista.Item(i).Substring(lista.Item(i).IndexOf("$") + 4)
                Exit For
            End If
        Next
        Return lineaRetorno

    End Function


#Region "Manejo Archivos FTP"

    Public Function Subir_Archivo(ByVal Url As String, ByVal Path_Archivo As String, ByVal usuario As String, ByVal password As String) As Boolean
        If My.Computer.Network.IsAvailable = True Then
            ' Controlador de error  
            Try
                ' Ejecuta el método UploadFile para subir el archivo  
                My.Computer.Network.UploadFile(Path_Archivo, Url, usuario, password, True, 2500, FileIO.UICancelOption.DoNothing)
                Return True
            Catch mensaje As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function Descargar_Archivo(ByVal Url As String, _
                                ByVal Path_Destino As String) As Boolean
        If Url = vbNullString Or Path_Destino = vbNullString Then
            MsgBox("No se indicó la url o el archivo de destino", _
                    MsgBoxStyle.Critical, "Error")
        Else
            If Len(Dir(Path_Destino)) <> 0 Then
                MsgBox("el archivo destino ya existe.Elija otro destino diferente", _
                                                MsgBoxStyle.Exclamation, "Error")
            Else
                On Error Resume Next
                My.Computer.Network.DownloadFile(Url, Path_Destino)
                If Err.Number = 0 Then
                    Descargar_Archivo = True
                Else
                    MsgBox(Err.Description)
                End If
                Err.Clear()
            End If
        End If
    End Function

#End Region

    Public Sub Desconectar()
        Cnn.Close()
    End Sub


#Region "Parametros"

    Public Function BuscarParametros(ByVal pNombreParametro As String) As Parametros
        Dim unpparametro As Persistencia.pParametro = New Persistencia.pParametro
        Dim unparametro As Parametros, unDs As DataSet
        If pNombreParametro = "" Then
        Else
            Dim cadena As String = "select * from Parametros where NombreParametro =" & "'" & pNombreParametro & "'"
            unDs = Persistencia.pPersistente.EjecutarSQL(cadena)
            If unDs.Tables(0).Rows.Count > 0 Then
                Dim unafila As DataRow = unDs.Tables(0).Rows(0)
                unparametro = New Parametros(CType(unafila.Item("NombreParametro"), String), CType(unafila.Item("ValorParametro"), String), CType(unafila.Item("DescripcionParametro"), String))
            End If
            Return unparametro
        End If

    End Function

    Public Function ModificarParametros(ByVal unparametro As Parametros) As Boolean
        If unparametro.Equals(BuscarParametros(unparametro.NombreParametro)) Then
            Return False
        Else
            Return unparametro.Modificar()
        End If
    End Function

    Public Function TodosLosParametros() As List(Of Parametros)
        Dim cadenaConsulta As String, colRetorno As New List(Of Parametros)
        cadenaConsulta = "Select * from Parametros order by NombreParametro"
        Dim dsparametros As DataSet
        dsparametros = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unaFila As DataRow
        Dim unparametro As Parametros
        For Each unaFila In dsparametros.Tables(0).Rows
            unparametro = New Parametros
            unparametro.NombreParametro = CStr(unaFila.Item("NombreParametro"))
            unparametro.ValorParametro = CStr(unaFila.Item("ValorParametro"))
            unparametro.DescripcionParametro = CStr(unaFila.Item("DescripcionParametro"))
            colRetorno.Add(unparametro)
            unparametro = Nothing
        Next
        Return colRetorno
    End Function

    Public Function TodosLosParametrosDataTable() As DataTable
        Dim cadenaConsulta As String = "select * from Parametros order by NombreParametro "
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)
    End Function



#End Region


    Public Function EjecutarConsulta(ByVal NombreConsulta As String) As Boolean
        Dim cmd As OleDb.OleDbCommand
        Dim retorno As Boolean = False
        'Me conecto a la base

        Cnn = New OleDb.OleDbConnection(StrConexion)
        Cnn.Open()


        'Establezo cual es la consulta a ejecutar
        cmd = New OleDb.OleDbCommand(NombreConsulta, Cnn)

        'Avisamos que vamos a ejecutar una "Consulta"
        cmd.CommandType = CommandType.StoredProcedure

        'Ejecuto el comando
        Try
            cmd.ExecuteNonQuery()
            retorno = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            retorno = False
        End Try
        'Me desconecto de la base
        Desconectar()
        Return retorno
    End Function

    Public Function EjecutarConsultaGENERICADataSet(ByVal pCadena As String) As DataSet
        If Me.TipoBaseDatos <> "ACCESS" Then
            pCadena = pCadena.Replace("#", "'")
        End If

        Dim cadenaActualizacion As String
        cadenaActualizacion = pCadena
        Try
            Dim ds As DataSet = pPersistente.EjecutarSQL(cadenaActualizacion)
            If Not ds Is Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                Try
                    Return ds
                Catch ex As Exception
                    Return Nothing
                End Try
            End If
        Catch ex As SqlClient.SqlException
            Throw New Exception("Error al acceder a la BD para modificar el parametros.")
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Function


    Public Function EjecutarConsultaGENERICAVariasTablasDataSet(ByVal plistaCadenas As List(Of String), ByRef pDataSet As DataSet, ByVal pListaNombreTablas As List(Of String)) As DataSet
        If plistaCadenas.Count > 0 Then
            Try
                pPersistente.EjecutarSQLVariasTablas(plistaCadenas, pDataSet, pListaNombreTablas)
                If Not pDataSet Is Nothing AndAlso pDataSet.Tables(0).Rows.Count > 0 Then
                    Try
                        Return pDataSet
                    Catch ex As Exception
                        Return Nothing
                    End Try
                End If
            Catch ex As SqlClient.SqlException
                Throw New Exception("Error al acceder a la BD para modificar el parametros.")
            Catch ex As Exception
                MsgBox(ex)
            End Try
        Else
            Return Nothing
        End If
    End Function

    Public Function EjecutarConsultaGENERICA(ByVal pCadena As String) As Boolean
        Dim cadenaActualizacion As String
        cadenaActualizacion = pCadena
        Try
            pPersistente.EjecutarNonQuery(cadenaActualizacion)
            Return True
        Catch ex As SqlClient.SqlException
            Throw New Exception("Error al acceder a la BD para modificar el parametros.")
        Catch ex As Exception
            'Throw New Exception("Error Inesperado al modificar el Factura Linea")
        End Try
        Return False
    End Function

    Public Function EjecutarConsulta(ByVal NombreConsulta As String, ByVal pdesde As Date, ByVal phasta As Date) As Boolean
        Dim cmd As OleDb.OleDbCommand
        Dim retorno As Boolean = False
        'Me conecto a la base
        Cnn = Conectar()
        Cnn.Open()

        'Establezo cual es la consulta a ejecutar
        cmd = New OleDb.OleDbCommand(NombreConsulta, Cnn)

        'Avisamos que vamos a ejecutar una "Consulta"
        cmd.CommandType = CommandType.StoredProcedure

        'Cargo los valores de los campos
        Dim Desde As String = pdesde.Day & "/" & pdesde.Month & "/" & pdesde.Year
        Dim Hasta As String = phasta.Day & "/" & phasta.Month & "/" & phasta.Year
        CargarParametros(cmd.Parameters, Desde, Hasta)

        'Ejecuto el comando
        Try
            cmd.ExecuteNonQuery()
            retorno = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            retorno = False
        End Try
        'Me desconecto de la base
        Desconectar()
        Return retorno
    End Function

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

    Public Sub ExportarExcelyAbrirlo(ByVal ds As DataSet)
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
        Dim fila As Integer = 1
        Dim columna As Integer = 1

        '/////////////////////////////////////////////////
        '// Armamos la linea con los títulos de columnas
        '/////////////////////////////////////////////////
        objHojaExcel.Range("A1").Select()
        For Each dc As DataColumn In ds.Tables(0).Columns
            objHojaExcel.Range(nombreColumna(columna) & 1).Value = dc.ColumnName
            columna += 1
        Next



        fila += 1

        '/////////////////////////////////////////////
        '// Le damos formato a la fila de los títulos
        '/////////////////////////////////////////////
        Dim objRango As Excel.Range
        Try

            objRango = objHojaExcel.Range("A1:" & nombreColumna(ds.Tables(0).Columns.Count) & "1")
            '  objRango = objHojaExcel.range("A1:I1")
            'objRango = objHojaExcel.range("A1" & nombreColumna(ds.Tables(0).Columns.Count) & "1")
        Catch ex As Exception

        End Try



        objRango.Font.Bold = True
        objRango.Cells.Interior.ColorIndex = 35

        objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        '//////////////////////////////////////////
        '// Cargamos todas las filas del datatable
        '//////////////////////////////////////////
        '  ProgressBar1.Maximum = ds.Tables(0).Rows.Count
        columna = 1
        ' ProgressBar1.Value = 0


        For Each dr As DataRow In ds.Tables(0).Rows
            columna = 1
            For Each dc As DataColumn In ds.Tables(0).Columns
                Try
                    Dim a As String = dr(dc.ColumnName)
                    objHojaExcel.Range(nombreColumna(columna) & fila).Value = dr(dc.ColumnName)
                Catch ex As Exception

                End Try

                columna += 1
            Next
            fila += 1
            ' ProgressBar1.Value += 1
        Next

        '//////////////////////////////////////
        '// Ajustamos automaticamente el ancho
        '// de todas las columnas utilizada
        '//////////////////////////////////////
        objRango = objHojaExcel.Range("A1:" & nombreColumna(ds.Tables(0).Columns.Count) & ds.Tables(0).Rows.Count.ToString)
        objRango.Select()
        objRango.Columns.AutoFit()

        '/////////////////////////////////////
        '// Le decimos a Excel que se muestre
        '/////////////////////////////////////
        MsgBox("Exportación a Excel completa", MsgBoxStyle.Information, ".:: SISTEMAS ::.")
        m_Excel.Visible = True

    End Sub

    Public Sub ExportarExcelDataTable(ByVal dataTable As DataTable)
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
        Dim fila As Integer = 1
        Dim columna As Integer = 1

        '/////////////////////////////////////////////////
        '// Armamos la linea con los títulos de columnas
        '/////////////////////////////////////////////////
        objHojaExcel.Range("A1").Select()
        For Each dc As DataColumn In dataTable.Columns
            objHojaExcel.Range(nombreColumna(columna) & 1).Value = dc.ColumnName
            columna += 1
        Next



        fila += 1

        '/////////////////////////////////////////////
        '// Le damos formato a la fila de los títulos
        '/////////////////////////////////////////////
        Dim objRango As Excel.Range
        Try

            objRango = objHojaExcel.Range("A1:" & nombreColumna(dataTable.Columns.Count) & "1")
            '  objRango = objHojaExcel.range("A1:I1")
            'objRango = objHojaExcel.range("A1" & nombreColumna(ds.Tables(0).Columns.Count) & "1")
        Catch ex As Exception

        End Try



        objRango.Font.Bold = True
        objRango.Cells.Interior.ColorIndex = 35

        objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        '//////////////////////////////////////////
        '// Cargamos todas las filas del datatable
        '//////////////////////////////////////////
        '  ProgressBar1.Maximum = ds.Tables(0).Rows.Count
        columna = 1
        ' ProgressBar1.Value = 0


        For Each dr As DataRow In dataTable.Rows

            columna = 1
            For Each dc As DataColumn In dataTable.Columns
                Try
                    Dim a As String = dr(dc.ColumnName)
                    Dim valorCelda As String = dr(dc.ColumnName)

                    objHojaExcel.Range(nombreColumna(columna) & fila).Value = "'" & valorCelda
                Catch ex As Exception

                End Try

                columna += 1
            Next
            fila += 1
            ' ProgressBar1.Value += 1
        Next

        '//////////////////////////////////////
        '// Ajustamos automaticamente el ancho
        '// de todas las columnas utilizada
        '//////////////////////////////////////
        objRango = objHojaExcel.Range("A1:" & nombreColumna(dataTable.Columns.Count) & dataTable.Rows.Count.ToString)
        objRango.Select()
        objRango.Columns.AutoFit()

        '/////////////////////////////////////
        '// Le decimos a Excel que se muestre
        '/////////////////////////////////////
        'MsgBox("Exportación a Excel completa", MsgBoxStyle.Information, ".:: SISTEMAS ::.")
        m_Excel.Visible = True

    End Sub

    Public Sub ExportarDataGridViewADataTable(ByVal miDataGrid As DataGridView, ByRef Tabla As DataTable)
        Try
            Dim filaNueva As System.Data.DataRow
            Dim numCols As Integer

            numCols = miDataGrid.ColumnCount

            For Each filaDatos As DataGridViewColumn In miDataGrid.Columns
                Tabla.Columns.Add(filaDatos.Name)
            Next

            ' Rellenamos los valores del DataTable nuevo con los valores de las celdas del DataGridView
            For Each filaDatos As DataGridViewRow In miDataGrid.Rows
                filaNueva = Tabla.NewRow()
                For i As Integer = 0 To numCols - 1
                    Try
                        filaNueva(i) = filaDatos.Cells.Item(i).Value

                        filaNueva(i) = CType(filaDatos.Cells(i).Value, String)
                    Catch ex As Exception

                    End Try

                Next
                Tabla.Rows.Add(filaNueva)
            Next

        Catch ex As Exception
            Tabla = New DataTable
        End Try

    End Sub

    Public Sub ExportarDataGridViewADataTableNombredeCabezera(ByVal miDataGrid As DataGridView, ByRef Tabla As DataTable)
        Try
            Dim filaNueva As System.Data.DataRow
            Dim numCols As Integer

            numCols = miDataGrid.ColumnCount

            If Tabla.Columns.Count = 0 Then
                For Each filaDatos As DataGridViewColumn In miDataGrid.Columns
                    Tabla.Columns.Add(filaDatos.HeaderText)
                Next
            End If

            ' Rellenamos los valores del DataTable nuevo con los valores de las celdas del DataGridView
            For Each filaDatos As DataGridViewRow In miDataGrid.Rows
                filaNueva = Tabla.NewRow()
                For i As Integer = 0 To numCols - 1
                    Try
                        filaNueva(i) = filaDatos.Cells.Item(i).Value

                        filaNueva(i) = CType(filaDatos.Cells(i).Value, String)
                    Catch ex As Exception

                    End Try

                Next
                Tabla.Rows.Add(filaNueva)
            Next

        Catch ex As Exception
            Tabla = New DataTable
        End Try

    End Sub

    Public Function ExportarDataGridView(ByVal miDataGrid As DataGridView) As DataTable
        Dim tabla As New DataTable
        Try
            Dim filaNueva As System.Data.DataRow
            Dim numCols As Integer

            'numCols = miDataGrid.ColumnCount

            For Each filaDatos As DataGridViewColumn In miDataGrid.Columns
                If filaDatos.Visible = True Then
                    tabla.Columns.Add(filaDatos.HeaderText)
                    numCols += 1
                End If
            Next

            ' Rellenamos los valores del DataTable nuevo con los valores de las celdas del DataGridView
            For Each filaDatos As DataGridViewRow In miDataGrid.Rows
                filaNueva = tabla.NewRow()
                Dim j As Integer = 0
                For i As Integer = 0 To numCols - 1
                    Try

                        While filaDatos.Cells(j).Visible = False
                            j += 1
                        End While

                        Dim ValorCelda As String = CType(filaDatos.Cells.Item(j).Value, String)
                        filaNueva(i) = ValorCelda

                    Catch ex As Exception

                    End Try
                    j += 1
                Next
                tabla.Rows.Add(filaNueva)
            Next

        Catch ex As Exception
            tabla = New DataTable
        End Try
        Return tabla
    End Function


    Public Sub EliminarTabla(ByVal ptabla As String)
        Dim unpParametro As New pParametro
        unpParametro.EliminarTabla(ptabla)
    End Sub

    Private Sub CargarParametros(ByRef Parametros As OleDb.OleDbParameterCollection, ByVal pDesde As String, ByVal pHasta As String)
        'Cargo los valores de los parametros
        With Parametros
            .Add("DESDE", pDesde)
            .Add("HASTA", pHasta)
        End With
    End Sub









#Region "categorias"


    Public Function AplicarFiltrosCategoria(ByVal pUnAnimal As DataRow, ByVal pFecha As Date) As String

        Dim Edad As Long
        Try
            Edad = DateDiff(DateInterval.Month, pUnAnimal("ani_fechaNac"), pFecha)
        Catch ex As Exception
            Edad = 0
        End Try

        Dim diasUbicacionActual As Long
        Dim fechaNula As Date = "1900" & "/" & "01" & "/" & "01"
        If pUnAnimal("ani_fecha_ubicacion_Actual") = fechaNula Then
            diasUbicacionActual = 0
        Else
            Try
                diasUbicacionActual = DateDiff(DateInterval.Day, pUnAnimal("ani_fecha_ubicacion_Actual"), pFecha)
            Catch ex As Exception
                diasUbicacionActual = 0
            End Try
        End If
       


        Dim filtros As String = ""
        If Not pUnAnimal("ani_sexo") Is Nothing Then
            If pUnAnimal("ani_sexo").Length > 0 Then
                filtros &= "cat_sexo=" & "'" & pUnAnimal("ani_sexo") & "'" & " And "
            End If
        End If

        If Edad > 0 Then
            filtros &= "cat_edadMin<=" & Edad & " and cat_edadMax>=" & Edad & " And "
        End If

        If diasUbicacionActual > 0 Then
            filtros &= "cat_permMin<=" & diasUbicacionActual & " and cat_permMax>=" & diasUbicacionActual & " And "
        End If

        filtros &= "cat_entorado=" & pUnAnimal("ani_entorado") & " And " & "cat_castrado=" & pUnAnimal("ani_castrado") & " And " & "cat_prenado=" & pUnAnimal("ani_prenado") & " And " & "cat_estado=0" & " And "

        If filtros.Length > 0 Then
            filtros = filtros.Remove(filtros.Length - 5, 5)
        End If

        Return filtros

    End Function

    Public Function CategoriaQPertenece(ByVal pUnAnimal As DataRow, ByVal pFecha As Date, ByVal dtcategorias As DataTable) As DataRow
        If Not dtcategorias Is Nothing Then
            Dim rows As DataRow()
            Dim filter As String = AplicarFiltrosCategoria(pUnAnimal, pFecha)
            ' sort and filter data
            rows = dtcategorias.Select(filter)
            If rows.Length > 0 Then
                Return rows(0)
            Else
                Return Nothing
            End If
        End If
    End Function

    Public Function TodasLasCategorias() As DataSet
        Dim cadenaConsulta As String = "select * from categoria where cat_estado=0 order by cat_nombre"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function

    Public Function TodasLasCategoriasxTipo(ByVal pTipoCategoria As String) As DataSet
        Dim cadenaConsulta As String = "select * from categoria where cat_estado=0 and cat_tipo=" & "'" & pTipoCategoria & "'" & " order by cat_nombre"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function

    Public Function BuscarCategorias(ByVal pidCabezal As String) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from categoria where cat_id =" & pidCabezal
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function




#End Region

#Region "Operaciones"

    Public Function TodasLasOperaciones() As DataSet
        Dim cadenaConsulta As String = "select * from operaciones where ope_anula=" & "'" & "'" & " order by ope_id"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function

    Public Function BuscarCabezalOperacion(ByVal pidCabezal As Integer) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from operaciones where ope_id =" & pidCabezal
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function

    Public Function BuscarCabezalOperacionxNombre(ByVal pNombreCabezal As String) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from operaciones where ope_nombre =" & "'" & pNombreCabezal & "'"
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function


    Public Function BuscarDetalleOperacion(ByVal pIdCabezal As Integer) As DataSet
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from operacionesLineas where ope_lin_idCabezal=" & pIdCabezal
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        If unDataSet.Tables(0).Rows.Count > 0 Then
            Return unDataSet
        Else
            Return Nothing
        End If
    End Function


#End Region

#Region "Ingresos"

    Public Function TodosLosIngresos() As DataSet
        Dim cadenaConsulta As String = "select * from ingresos where Ing_anula=" & "'" & "" & "'" & "order by Ing_Titulo"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function

    Public Function BuscarCabezalIngresos(ByVal pidCabezal As Integer) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from ingresos where Ing_id =" & pidCabezal
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function

    Public Function BuscarCabezalIngresosxTitulo(ByVal pNombreCabezal As String) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from ingresos where Ing_Titulo =" & "'" & pNombreCabezal & "'"
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function


    'Public Function BuscarDetalleIngresos(ByVal pIdCabezal As Integer) As DataSet
    '    Dim unDataSet As DataSet
    '    Dim cadenaConsulta As String = "select * from animal where ani_numIngreso=" & pIdCabezal
    '    unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
    '    If unDataSet.Tables(0).Rows.Count > 0 Then
    '        Return unDataSet
    '    Else
    '        Return Nothing
    '    End If
    'End Function


#End Region

#Region "Ingresos Lineas"

    Public Function TodosLosIngresosLineas() As DataSet
        Dim cadenaConsulta As String = "select * from ingresosLineas order by Ing_Lin_Version"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function

    Public Function BuscarIngresosLineas(ByVal pId As Integer) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from ingresosLineas where Ing_Lin_id =" & pId
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function

    Public Function BuscarDetalleIngresosLineas(ByVal pIdCabezal As Integer) As DataSet
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "SELECT * FROM ingresoslineas where Ing_Lin_IdCabezal=" & pIdCabezal & " ORDER BY Ing_Lin_id"
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        If unDataSet.Tables(0).Rows.Count > 0 Then
            Return unDataSet
        Else
            Return Nothing
        End If
    End Function

    Public Function BuscarDetalleIngresosLineasVersion(ByVal pIdVersion As Integer, ByVal pCabezal As Integer) As DataSet
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "SELECT * FROM ingresoslineas where Ing_Lin_Version=" & pIdVersion & " and Ing_Lin_IdCabezal = " & pCabezal & "" & " order by Ing_Lin_id"
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        If unDataSet.Tables(0).Rows.Count > 0 Then
            Return unDataSet
        Else
            Return Nothing
        End If
    End Function


#End Region



#Region "Eventos"

    Public Function TodosLasListasEventos() As DataTable
        Dim cadenaConsulta As String = "select * from Listaeventos order by eve_nombre "
        Dim dsListaEventos As DataSet
        dsListaEventos = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return dsListaEventos.Tables(0)
    End Function

    Public Function TodosLasListasEventosLineas(ByVal pIdEvento As Integer) As DataTable
        Dim cadenaConsulta As String = "select * from ListaEventosLineas where eve_lin_ideventos=" & pIdEvento & " order by eve_lin_nombre"
        Dim dsListaEventosLineas As DataSet
        dsListaEventosLineas = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return dsListaEventosLineas.Tables(0)
    End Function

    Public Function TodosLasListasEventosLineas() As DataTable
        Try
            Dim cadenaConsulta As String = "select * from ListaEventosLineas order by eve_lin_nombre"
            Dim dsListaEventosLineas As DataSet
            dsListaEventosLineas = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
            Return dsListaEventosLineas.Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function BuscarListaEventos(ByVal pNombre As String, ByVal dataEventos As DataTable) As DataRow
        For Each rw As DataRow In dataEventos.Rows
            If pNombre = rw("eve_nombre") Then
                Return rw
            End If
        Next rw
    End Function

    Public Function BuscarListaEventosLineas(ByVal pNombre As String, ByVal dataEventosLineas As DataTable, ByVal pColumna As String) As DataRow
        For Each rw As DataRow In dataEventosLineas.Rows
            If pNombre = rw(pColumna) Then
                Return rw
            End If
        Next rw
    End Function


#End Region

#Region "Productor"

    Public Function BuscarProductorxDicosePropietario(ByVal pDicosePropietario As String, ByVal pDataTable As DataTable) As DataRow

        For Each rw As DataRow In pDataTable.Rows
            If pDicosePropietario = rw("pro_dicose") Then
                Return rw
            End If
        Next rw

     
    End Function

    Public Function BuscarProductorxNombre(ByVal pNombre As String, ByVal pDataTable As DataTable) As DataRow
        For Each rw As DataRow In pDataTable.Rows
            If pNombre = rw("pro_nombre") Then
                Return rw
            End If
        Next rw
    End Function

    Public Function TodosLosProductoresTable() As DataTable
        Dim cadenaConsulta As String = "select * from productor order by pro_nombre "
        Dim dsProductor As DataSet
        dsProductor = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return dsProductor.Tables(0)
    End Function


#End Region


#Region "Dicose"

    Public Function TodosLosDicoseProductoresTable(ByVal PidProductor As String) As DataTable
        Dim cadenaConsulta As String = "select * from dicose where Dicose_IdProductor =" & PidProductor
        Dim dsProductor As DataSet
        dsProductor = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return dsProductor.Tables(0)
    End Function

    'Public Function BuscarDicoseProductor(ByVal PidProductor As String) As DataRow
    '    Dim unDs As DataSet
    '    Dim unafila As DataRow
    '    Dim cadena As String = "select * from dicose where Dicose_IdProductor =" & PidProductor
    '    unDs = Persistencia.pPersistente.EjecutarSQL(cadena)
    '    If unDs.Tables(0).Rows.Count > 0 Then
    '        unafila = unDs.Tables(0).Rows(0)
    '    End If
    '    Return unafila
    'End Function
#End Region


#Region "Razas"

    Public Function TodosLasRazasTable() As DataTable
        Dim cadenaConsulta As String = "select * from razas order by raz_orden "
        Dim dsRazas As DataSet
        dsRazas = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return dsRazas.Tables(0)
    End Function

#End Region

#Region "Potreros"


   
    Public Function TodosLosPotrerosTable() As DataTable
        Dim cadenaConsulta As String = "select * from potreros order by pot_id "
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)
    End Function

    Public Function BuscarPotreros(ByVal pId As Integer, ByVal pDataTable As DataTable) As DataRow
        For Each rw As DataRow In pDataTable.Rows
            If pId = rw(0) Then
                Return rw
            End If
        Next rw
    End Function

    Public Function BuscarPotrerosxNombre(ByVal pNombre As String, ByVal pDataTable As DataTable, ByVal pColumna As String) As DataRow
        For Each rw As DataRow In pDataTable.Rows
            If pNombre = rw(pColumna) Then
                Return rw
            End If
        Next rw
    End Function

#End Region


#Region "ANIMALES"


    Public Function TodosAnimalesAgrupados(ByVal pCampoGrupo As String, ByVal pCampoGrupo2 As String, ByVal pListaDicosePropietarios As List(Of String)) As DataTable
        Dim condicion As String = ""
        If Not pListaDicosePropietarios Is Nothing Then
            If pListaDicosePropietarios.Count > 0 Then
                condicion &= "WHERE "
                For Each DicosePropiedad As String In pListaDicosePropietarios

                    condicion &= "ani_propietario=" & "'" & DicosePropiedad & "'" & " Or  "
                Next
                If condicion.Length > 0 Then
                    condicion = condicion.Remove(condicion.Length - 5, 5)
                End If
            End If
        End If
        Dim cadenaConsulta As String
        If pCampoGrupo2.Length > 0 Then
            cadenaConsulta = "SELECT " & pCampoGrupo & "," & pCampoGrupo2 & " , Count(ani_id) AS Cantidad FROM animal " & condicion & " GROUP BY " & pCampoGrupo & " ," & pCampoGrupo2 & " ORDER BY " & pCampoGrupo & "," & pCampoGrupo2
        Else
            cadenaConsulta = " SELECT " & pCampoGrupo & " , Count (ani_id) AS Cantidad FROM animal " & condicion & " GROUP BY " & pCampoGrupo & " ORDER BY " & pCampoGrupo
        End If


        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)

    End Function

    Public Function TodosAnimalesAgrupadosxDicose(ByVal pCampoGrupo As String, ByVal pCampoGrupo2 As String, ByVal pDicosePropietario As String) As DataTable
        Dim condicion As String = ""
        condicion &= "WHERE ani_propietario=" & "'" & pDicosePropietario & "'"
        Dim cadenaConsulta As String
        If pCampoGrupo2.Length > 0 Then
            cadenaConsulta = "SELECT " & pCampoGrupo & "," & pCampoGrupo2 & " , Count(ani_id) AS Cantidad FROM animal " & condicion & " GROUP BY " & pCampoGrupo & " ," & pCampoGrupo2 & " ORDER BY " & pCampoGrupo & "," & pCampoGrupo2
        Else
            cadenaConsulta = " SELECT " & pCampoGrupo & " , Count (ani_id) AS Cantidad FROM animal " & condicion & " GROUP BY " & pCampoGrupo & " ORDER BY " & pCampoGrupo
        End If


        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)

    End Function

    Public Function TodosAnimalesFiltrados(ByVal pFiltro As String, ByVal pCampoOrden As String, ByVal pCampoOrden2 As String) As DataTable

        Dim cadenaConsulta As String
        If pFiltro.Length > 0 Then
            cadenaConsulta = "SELECT * FROM animal WHERE " & pFiltro & " ORDER BY " & pCampoOrden & "," & pCampoOrden2
        End If


        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)

    End Function



    Public Function LeerTxtDevoverCaravanas(ByVal pArchivo As String) As List(Of String)
        Try

            Dim listaCaravanas As New List(Of String)
            Dim sr As StreamReader
            sr = New StreamReader(pArchivo)
            Dim Line As String = sr.ReadLine()
            Dim lista As New List(Of String)
            While Not (Line Is Nothing)
                Try
                    Dim numCaravana As String = Line.Substring(Line.IndexOf("858"), 15) '& Chr(13)
                    '  Dim numCaravana2 As String = Line.IndexOf("858", 0, 8)
                    If numCaravana.Length = 15 Then
                        lista.Add(numCaravana)
                    End If
                    Line = sr.ReadLine()
                Catch ex As Exception
                    If Line = "000000000000000" Then
                        lista.Add("000000000000000")
                    End If
                    Line = sr.ReadLine()
                End Try

            End While
            sr.Close()
            Return lista
        Catch ex As Exception
            MsgBox("No se encuentra el archivo o esta abierto")
        End Try
    End Function

    Public Function LeerTxtEventos(ByVal pArchivo As String) As List(Of String)
        Try
            Dim sr As StreamReader
            sr = New StreamReader(pArchivo)
            Dim Line As String = sr.ReadLine()
            Dim lista As New List(Of String)
            While Not (Line Is Nothing)
                Try
                    If Line.Length > 0 Then
                        lista.Add(Line)
                    End If

                    Line = sr.ReadLine()
                Catch ex As Exception
                    Line = sr.ReadLine()
                End Try

            End While
            sr.Close()
            Return lista
        Catch ex As Exception
            MsgBox("No se encuentra el archivo o esta abierto")
        End Try
    End Function


    Public Function BuscarYborrar(ByVal pCampoBusqueda As String, ByRef pListaDeTXT As List(Of String)) As Boolean
        'Recorro archivo txt y paso a Arraylist
        Dim bandera As Boolean = False
        Dim linea As String = ""
        Dim indice As Integer
        Dim lista As List(Of String) = pListaDeTXT
        'Recorro Arraylist y encuentro plato y actualizo stock
        If pListaDeTXT.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To lista.Count - 1
                If lista.Item(i).Contains(pCampoBusqueda) Then
                    linea = lista.Item(i)
                    indice = i
                    bandera = True
                    Exit For
                End If
            Next

        End If

        If bandera = True Then
            pListaDeTXT.RemoveAt(indice)
        End If
        Return bandera
    End Function

    Public Sub GuardarTxt(ByVal pLista As List(Of String), ByVal pNombreRutaArchivo As String)
        Dim i As Integer = 0
        Dim sw As New StreamWriter(pNombreRutaArchivo)
        i = 0
        For i = 0 To pLista.Count - 1
            Dim linea As String = pLista(i)
            If linea.Length > 0 Then
                sw.WriteLine(linea)
            End If
        Next
        sw.Close()
    End Sub

    Public Function GenerarArchivoTxtCaravanas(ByVal lista As List(Of String), ByVal pNombreArchivo As String) As Boolean
        Dim ruta As String = Environment.CurrentDirectory & "\Lecturas\" & pNombreArchivo & ".txt"
        If File.Exists(ruta) Then
            'Dim Spath As String = pNombreArchivo & ".txt"
            ' Archivo  
            My.Computer.FileSystem.DeleteFile( _
                ruta, _
                FileIO.UIOption.AllDialogs, _
                FileIO.RecycleOption.SendToRecycleBin, _
                FileIO.UICancelOption.DoNothing)
        End If


        Dim i As Integer = 0
        'CREA EL ARCHIVO TXT
        Dim sw As New StreamWriter((ruta))
        i = 0
        For i = 0 To lista.Count - 1
            sw.WriteLine(lista.Item(i))
        Next
        sw.Close()
    End Function



    Public Sub GuardarTxtLecturas(ByVal pArchivo As String, ByVal pCadenas As String())
        Dim i As Integer = 0
        Dim cadenaGuardado As String = Environment.CurrentDirectory & " \Lecturas\" & (pArchivo)
        Dim sw As New StreamWriter(cadenaGuardado)
        i = 0
        For i = 0 To pCadenas.Length - 1
            Dim linea As String = pCadenas(i)
            If linea.Length > 0 Then
                sw.WriteLine(linea)
            End If
        Next
        sw.Close()
    End Sub

#Region "Animales"


    Public Function BuscarDispositivosDataTable(ByVal pNumDispositivo As String) As DataTable
        Dim unDs As DataSet
        If pNumDispositivo = "" Then
        Else
            Dim cadena As String = "select * from animal where ani_dispositivo =" & "'" & pNumDispositivo & "'"
            unDs = Persistencia.pPersistente.EjecutarSQL(cadena)
            If Not unDs Is Nothing Then
                If unDs.Tables(0).Rows.Count > 0 Then
                    Return unDs.Tables(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End If

    End Function

    Public Function BuscarDispositivo(ByVal pNumDispositivo As String) As DataRow
        Dim unDs As DataSet
        Dim unafila As DataRow
        If pNumDispositivo = "" Then
        Else
            Dim cadena As String = "select * from animal where ani_dispositivo =" & "'" & pNumDispositivo & "'"
            unDs = Persistencia.pPersistente.EjecutarSQL(cadena)
            If Not unDs Is Nothing Then
                If unDs.Tables(0).Rows.Count > 0 Then
                    unafila = unDs.Tables(0).Rows(0)
                End If
                Return unafila
            End If
        End If
    End Function


    Public Function TodosLosDispositivos() As List(Of String)
        Dim unaLista As New List(Of String)
        Dim unDs As DataSet
        Dim cadena As String = "select * from animal order by ani_id"
        unDs = Persistencia.pPersistente.EjecutarSQL(cadena)
        If unDs.Tables(0).Rows.Count > 0 Then
            Dim i As Integer = 0
            Do While i < unDs.Tables(0).Rows.Count
                unaLista.Add(unDs.Tables(0).Rows(i).Item("ani_dispositivo"))
                i += 1
            Loop

        End If
        Return unaLista

    End Function

    Public Function TodosLosAnimales() As DataTable
        Dim cadenaConsulta As String = "select * from animal order by ani_dispositivo "
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)
    End Function

    Public Function TodosLosAnimalesVida(ByVal pVida As String) As DataTable
        Dim cadenaConsulta As String = "select * from animal where ani_vida =" & "'" & pVida & "'"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds.Tables(0)
    End Function



#End Region

#Region "Menu"

    Public Function BuscarBoton(ByVal pIdOpcion As Integer, ByVal pIdTipo As Integer, ByVal pIdActividad As Integer) As DataRow
        Dim unDs As DataSet
        Dim unafila As DataRow
        Dim cadena As String = "SELECT menuSub.menu_sub_IdOpcion, menuSub.menu_sub_idTipo, menuSub.menu_sub_idActividad FROM(menuSub) WHERE menuSub.menu_sub_IdOpcion=" & pIdOpcion & " AND menuSub.menu_sub_idTipo= " & pIdTipo & " AND menuSub.menu_sub_idActividad=" & pIdActividad

        unDs = Persistencia.pPersistente.EjecutarSQL(cadena)
        If Not unDs Is Nothing Then
            If unDs.Tables(0).Rows.Count > 0 Then
                unafila = unDs.Tables(0).Rows(0)
            End If
            Return unafila
        End If

    End Function

    Public Function EliminarBoton(ByVal pIdOpcion As Integer, ByVal pIdTipo As Integer, ByVal pIdActividad As Integer) As Boolean
        Dim cadena As String = "DELETE menuSub.menu_sub_IdOpcion, menuSub.menu_sub_idTipo, menuSub.menu_sub_idActividad FROM(menuSub) WHERE menuSub.menu_sub_IdOpcion=" & pIdOpcion & " AND menuSub.menu_sub_idTipo= " & pIdTipo & " AND menuSub.menu_sub_idActividad=" & pIdActividad
        Return EjecutarConsultaGENERICA(cadena)

    End Function

    Public Function BuscarSubMenu(ByVal pActividad As Integer) As DataSet
        Dim cadenaConsulta As String = "select * from menuSub where menu_sub_idActividad=" & pActividad & " order by menu_sub_dispositivo"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function

    Public Function BuscarSubMenu(ByVal pNombre As String, ByVal dataMenu As DataTable) As DataSet
        Dim ds As New DataSet
        For Each rw As DataRow In dataMenu.Rows
            If pNombre = rw("menu_nombre") Then
                ds.Tables(0).Rows.Add(rw)
            End If
        Next rw
        Return ds
    End Function

    Public Function TodosLosMenu() As DataSet
        Dim cadenaConsulta As String = "select * from menu where menu_anula Is Null order by menu_nombre"
        Dim ds As DataSet
        ds = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Return ds
    End Function



    Public Function BuscarMenu(ByVal pNombre As String, ByVal dataMenu As DataTable) As DataRow
        For Each rw As DataRow In dataMenu.Rows
            If pNombre = rw("menu_nombre") Then
                Return rw
            End If
        Next rw
    End Function


#End Region



#Region "Reconocimiento de voz"

    Public Function LeerTxtDiccionario(ByVal pArchivo As String) As String()
        Try

            Dim ListaDiccionario As New List(Of String)
            Dim sr As StreamReader
            sr = New StreamReader(pArchivo)
            Dim Line As String = sr.ReadLine()
            Dim lista As New List(Of String)
            While Not (Line Is Nothing)
                Try
                    If Line.ToString.Length > 0 Then
                        lista.Add(Line)
                    End If

                    Line = sr.ReadLine()

                Catch ex As Exception
                    Line = sr.ReadLine()
                End Try

            End While
            sr.Close()
            Dim ultimoItem As Integer = lista.Count - 1

            'lista.RemoveAt(ultimoItem)

            Dim array As String() = lista.ToArray
            Return array
        Catch ex As Exception
            MsgBox("No se encuentra el archivo o esta abierto")
        End Try
    End Function


#End Region

#End Region



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Function IsConnectionAvailableServer(ByVal pNumeroIp As String) As Boolean
        Dim Packet As New APing.CPing
        Dim retValue
        Packet.HostName = Trim(pNumeroIp)
        If Packet.HostName = "" Then
            MsgBox("Introduza una IP (Ejemplo: '127.0.0.1') o un Host Name (Ejemplo: 'www.unsitio___x.com')")
        Else
            If Packet.Open Then
                retValue = Packet.Ping
                If retValue <> -1 Then
                    Packet.Close()
                    Return True
                    'MsgBox("Tiempo de Respuesta Aproximado en milisegundos : " & retValue)
                Else
                    'MsgBox("IP o Host Name Inaccesible")
                End If
                Packet.Close()
                Return False
            End If
        End If
    End Function

    Public Function Firma(ByVal pfecha As String, ByVal pcantidadRegistros As String) As String
        Dim Cadena As String
        Cadena = _
           "<html>" & _
              "<head>" & _
                 "<title>" & _
                      "Sistema Trazabilidad - Envio Archivo SNIG</title>" & _
               "</head>" & _
               "<body>" & _
                 "<p>" & _
                  "<h1>" & _
                     "<Font Color=Green>" & _
                          "Archivo Lecturas Dispositivos Fecha: " & pfecha & _
                           "</p>" & _
                          "Total Animales: " & pcantidadRegistros & _
                     "</Font>" & _
                  "</h1>" & _
                 "</p>" & _
                 "<p>" & _
                  "<h3>Sistemas J.Martin Cardone</h3>" & _
                 "</p>" & _
                 "<p>" & "Mensaje enviado Automaticamente el " & _
                        Now.ToShortDateString & _
                       " a las " & Now.ToLongTimeString & _
                 "</p>" & _
               "</body>" & _
            "</html>"
        Return Cadena
    End Function
    Public Function enviar_mail(ByVal i_de As String, ByVal i_para As String, ByVal asunto As String, ByVal mensaje As String, ByVal pArchivo As String, ByVal pArchivo2 As String, Optional ByRef pCadenaLog As String = "") As Boolean
        Dim bandera As Boolean = True
        Dim att As System.Net.Mail.Attachment
        Dim att2 As System.Net.Mail.Attachment
        If pArchivo.Length > 3 Then
            att = New System.Net.Mail.Attachment(Environment.CurrentDirectory & "\Lecturas\" & pArchivo)
        End If
        If pArchivo2.Length > 3 Then
            att2 = New System.Net.Mail.Attachment(Environment.CurrentDirectory & "\Lecturas\" & pArchivo2)
        End If
        'Dim insMail As New MailMessage(New MailAddress(i_de), New MailAddress(i_para))
        Dim insMail As New MailMessage()
        '   insMail.From.Address(i_de)

        Dim destinatarios As String = i_para
        For Each mail As String In destinatarios.Split(New Char(), ";")
            insMail.To.Add(New System.Net.Mail.MailAddress(mail))
        Next

        With insMail
            .Subject = asunto
            .IsBodyHtml = True 'envia el mensaje como html
            .Body = mensaje
            .From = New MailAddress(i_de)
            .ReplyTo = New MailAddress(i_de)
            If pArchivo.Length > 3 Then
                .Attachments.Add(att)
            End If
            If pArchivo2.Length > 3 Then
                .Attachments.Add(att2)
            End If


        End With
        Dim smtp As New System.Net.Mail.SmtpClient
        'smtp.Host = "smtp.gmail.com"
        smtp.Host = "smtp.gmail.com"
        'smtp.Port = 587
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New System.Net.NetworkCredential("martincm@gmail.com", "hiol884")

        Try
            smtp.Send(insMail)
        Catch ex As Exception
            pCadenaLog &= "Error Enviar Mail"
            pCadenaLog &= vbCrLf
            bandera = False
        End Try
        Return bandera

    End Function

    Public Function BuscarHistorial(ByVal pIdActividad As Integer, ByVal pCerrado As Integer, ByVal pEliminado As Integer) As DataRow
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from historial where His_id_actividad =" & pIdActividad & " and His_cerrado=" & pCerrado & " and His_eliminado=" & pEliminado & " order by His_fecha DESC"
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        Dim unafila As DataRow
        If unDataSet.Tables(0).Rows.Count > 0 Then
            unafila = unDataSet.Tables(0).Rows(0)
        End If
        Return unafila
    End Function

    Public Function TodosLosHistorial(ByVal pCerrado As Integer, ByVal pEliminado As Integer) As DataTable
        Dim unDataSet As DataSet
        Dim cadenaConsulta As String = "select * from historial where His_cerrado =" & pCerrado & " and His_eliminado=" & pEliminado & " order by His_fecha DESC"
        unDataSet = Persistencia.pPersistente.EjecutarSQL(cadenaConsulta)
        If unDataSet.Tables(0).Rows.Count > 0 Then
            Return unDataSet.Tables(0)
        End If
        Return Nothing
    End Function

    Public Function CerrarHistorial(ByVal pIdHistorial As Integer, ByVal pCerrado As Integer, ByVal pEliminado As Integer) As Boolean
        Dim cadenaConsulta As String = "UPDATE historial SET His_cerrado=" & pCerrado & ", His_eliminado=" & pEliminado & " WHERE His_id=" & pIdHistorial
        Return EjecutarConsultaGENERICA(cadenaConsulta)
    End Function



End Class

Namespace APing


    Structure Angel_Ping
#Region "VARIABLES"
        Dim Data() As Byte
        Dim Type_Message As Byte
        Dim SubCode_type As Byte
        Dim Complement_CheckSum As UInt16
        Dim Identifier As UInt16
        Dim SequenceNumber As UInt16
#End Region
#Region "Metodos"
        Public Sub Initialize(ByVal type As Byte, ByVal subCode As Byte, ByVal payload() As Byte)
            Dim Buffer_IcmpPacket() As Byte
            Dim CksumBuffer() As UInt16
            Dim IcmpHeaderBufferIndex As Int32 = 0
            Dim Index As Integer
            Me.Type_Message = type
            Me.SubCode_type = subCode
            Complement_CheckSum = UInt16.Parse("0")
            Identifier = UInt16.Parse("45")
            SequenceNumber = UInt16.Parse("0")
            Data = payload
            Buffer_IcmpPacket = Serialize()
            ReDim CksumBuffer((Buffer_IcmpPacket.Length() \ 2) - 1)
            For Index = 0 To (CksumBuffer.Length() - 1)
                CksumBuffer(Index) = BitConverter.ToUInt16(Buffer_IcmpPacket, IcmpHeaderBufferIndex)
                IcmpHeaderBufferIndex += 2
            Next Index
            Complement_CheckSum = MCheckSum.Calculate(CksumBuffer, CksumBuffer.Length())
        End Sub
        Public Function Size() As Integer
            Return (8 + Data.Length())
        End Function
        Public Function Serialize() As Byte()
            Dim Buffer() As Byte
            Dim B_Seq() As Byte = BitConverter.GetBytes(SequenceNumber)
            Dim B_Cksum() As Byte = BitConverter.GetBytes(Complement_CheckSum)
            Dim B_Id() As Byte = BitConverter.GetBytes(Identifier)
            Dim Index As Int32 = 0
            ReDim Buffer(Size() - 1)
            Buffer(0) = Type_Message
            Buffer(1) = SubCode_type
            Index += 2
            Array.Copy(B_Cksum, 0, Buffer, Index, 2) : Index += 2
            Array.Copy(B_Id, 0, Buffer, Index, 2) : Index += 2
            Array.Copy(B_Seq, 0, Buffer, Index, 2) : Index += 2
            If (Data.Length() > 0) Then Array.Copy(Data, 0, Buffer, Index, Data.Length())
            Return Buffer
        End Function
#End Region
    End Structure
    Public Class CPing
#Region "Contactes"
        Private Const DATA_SIZE As Integer = 32
        Private Const DEFAULT_TIMEOUT As Integer = 1000
        Private Const ICMP_ECHO As Integer = 8
        Private Const SOCKET_ERROR As Integer = -1
        Private Const PING_ERROR As Integer = -1
        Private Const RECV_SIZE As Integer = 128
#End Region
#Region "VARIABLES"
        Private _Open As Boolean = False
        Private _Initialized As Boolean
        Private _RecvBuffer() As Byte
        Private _Packet As Angel_Ping
        Private _HostName As String
        Private _Server As EndPoint
        Private _Local As EndPoint
        Private _Socket As Socket
#End Region
#Region "CONSTRUCTORS & FINALIZER"
        Public Sub New(ByVal hostName As String)
            Me.HostName() = hostName
            ReDim _RecvBuffer(RECV_SIZE - 1)
        End Sub
        Public Sub New()
            Me.HostName() = Dns.GetHostName()
            ReDim _RecvBuffer(RECV_SIZE - 1)
        End Sub
        Private Overloads Sub finalize()
            Me.Close()
            Erase _RecvBuffer
        End Sub
#End Region
#Region "Metodos"
        Public Property HostName() As String
            Get
                Return _HostName
            End Get
            Set(ByVal Value As String)
                _HostName = Value
                If (_Open) Then
                    Me.Close()
                    Me.Open()
                End If
            End Set
        End Property
        Public ReadOnly Property IsOpen() As Boolean
            Get
                Return _Open
            End Get
        End Property
        Public Function Open() As Boolean
            Dim Payload() As Byte
            If (Not _Open) Then
                Try
                    ReDim Payload(DATA_SIZE)
                    _Packet.Initialize(ICMP_ECHO, 0, Payload)
                    _Socket = New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp)
                    _Server = New IPEndPoint(Dns.GetHostByName(_HostName).AddressList(0), 0)
                    _Local = New IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList(0), 0)
                    _Open = True
                Catch
                    Return False
                End Try
            End If
            Return True
        End Function
        Public Function Close() As Boolean
            If (_Open) Then
                _Socket.Close()
                _Socket = Nothing
                _Server = Nothing
                _Local = Nothing
                _Open = False
            End If
            Return True
        End Function
        Public Overloads Function Ping() As Integer
            Return Ping(DEFAULT_TIMEOUT)
        End Function
        Public Overloads Function Ping(ByVal timeOutMilliSeconds As Integer) As Integer
            Dim TimeOut As Integer = timeOutMilliSeconds + Environment.TickCount()
            Try
                If (SOCKET_ERROR = _Socket.SendTo(_Packet.Serialize(), _Packet.Size(), 0, _Server)) Then
                    Return PING_ERROR
                End If
            Catch
            End Try
            Do
                If (_Socket.Poll(1000, SelectMode.SelectRead)) Then
                    _Socket.ReceiveFrom(_RecvBuffer, RECV_SIZE, 0, _Local)
                    Return (timeOutMilliSeconds - (TimeOut - Environment.TickCount()))
                ElseIf (Environment.TickCount() >= TimeOut) Then
                    Return PING_ERROR
                End If
            Loop While (True)
        End Function
#End Region
    End Class
    Module MCheckSum
#Region "Metodos"
        <StructLayout(LayoutKind.Explicit)> Structure UNION_INT16
            <FieldOffset(0)> Dim lsb As Byte
            <FieldOffset(1)> Dim msb As Byte
            <FieldOffset(0)> Dim w16 As Short
        End Structure
        <StructLayout(LayoutKind.Explicit)> Structure UNION_INT32
            <FieldOffset(0)> Dim lsw As UNION_INT16
            <FieldOffset(2)> Dim msw As UNION_INT16     '
            <FieldOffset(0)> Dim w32 As Integer
        End Structure
        Public Function Calculate(ByRef buffer() As UInt16, ByVal size As Int32) As UInt16
            Dim Counter As Int32 = 0
            Dim Cksum32 As UNION_INT32
            Do While (size > 0)
                Cksum32.w32 += Convert.ToInt32(buffer(Counter))
                Counter += 1
                size -= 1
            Loop
            Cksum32.w32 = Cksum32.msw.w16 + Cksum32.lsw.w16 + Cksum32.msw.w16
            Return Convert.ToUInt16(Cksum32.lsw.w16 Xor &HFFFF)
        End Function
#End Region
    End Module
End Namespace
