Imports Dominio, Inicio.IUMenu
Imports System.IO
Public Class IUBaston

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()



    End Sub




    Private Sub btnBuscarCom_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCom.Click
        GetSerialPortNames()
    End Sub

    Sub GetSerialPortNames()

        ' muestra COM ports disponibles.

        Dim l As Integer

        Dim ncom As String

        Try

            ComboPorts.Items.Clear()

            For Each sp As String In My.Computer.Ports.SerialPortNames

                l = sp.Length

                If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
                    ComboPorts.Items.Add(sp)
                Else
                    'hay una letra al final del COM
                    ncom = sp.Substring(0, l - 1)
                    ComboPorts.Items.Add(ncom)
                End If
            Next
            If ComboPorts.Items.Count >= 1 Then

                ComboPorts.Text = ComboPorts.Items(0)

            Else

                ComboPorts.Text = ""

            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub IUBaston_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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
        'Try
        '    If unafachada.tipoBaston = 1 Then
        '        numCaravana = SerialPort1.ReadLine
        '    Else
        '        numCaravana = SerialPort1.ReadExisting

        '    End If

        'Catch ex As Exception
        '    MsgBox(SerialPort1.ReadExisting.ToString)
        'End Try


    End Sub

#End Region

    Private Sub btnConectar_Click(sender As System.Object, e As System.EventArgs) Handles btnConectar.Click
        Conectar(ComboPorts.SelectedItem)
    End Sub

    'Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click
    '    Try

    '        SerialPort1.Write(Me.Text_denviados.Text)

    '        Me.Text_drecibidos.Clear()

    '    Catch ex As Exception
    '        Setup_Puerto_Serie(Me.ComboPorts.SelectedItem)
    '        MsgBox(ex.Message)

    '    End Try
    'End Sub

End Class