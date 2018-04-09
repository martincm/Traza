Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class IUImportarDatos
    Dim dataTableDatosExcel As DataTable
    Dim Actualiza As Integer
    Dim Ingresos As Integer
    Private listaImportadaExcel As List(Of String)
    Dim importarDatos As New Thread(AddressOf Importar)


    Private Sub IUImportarDatos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If importarDatos.IsAlive Then
            e.Cancel = True
            MsgBox("No puede cerrar la ventana, espere que finalice el proceso de importación")
        End If
    End Sub


    Private Sub IUImportarDatos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Public Sub seleccionarArchivo()
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"

            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextPathExcel.Text = .FileName
                Dim Archivo As New IO.FileInfo(.FileName)

                Try
                    Me.dtpFechaArchivo.Value = Archivo.CreationTime
                    Me.TextHoja.Text = ObtenerNombrePrimeraHoja(TextPathExcel.Text)
                    Me.txtPropietario.Text = Me.TextHoja.Text.Substring(9, 9)

                Catch ex As Exception
                    Me.txtPropietario.Text = ""
                End Try

            End If
        End With
    End Sub

    Private Sub BtnCargar_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Function ObtenerNombrePrimeraHoja(rutaLibro As String) As String

        Dim app As Excel.Application = Nothing

        Try
            app = New Excel.Application()

            ' Abrimos el libro de trabajo
            '
            Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)

            ' Referenciamos la hoja cuyo índice sea 1.
            '
            Dim ws As Excel.Worksheet = CType(wb.Worksheets.Item(1), Excel.Worksheet)

            ' Obtenemos el nombre de la hoja.
            '
            Dim name As String = ws.Name

            ws = Nothing

            ' Cerramos el libro
            '
            wb.Close()
            wb = Nothing

            ' Devolvemos el nombre de la hoja
            '
            Return name

        Catch ex As Exception
            ' Se ha producido un error; devolvemos la excepción
            ' al procedimiento llamador.
            '
            Throw

        Finally
            ' Cerramos Excel.
            '
            If (Not app Is Nothing) Then _
                app.Quit()

            ' Disminuimos el contador de referencias y liberamos el objeto.
            '
            Runtime.InteropServices.Marshal.ReleaseComObject(app)

            app = Nothing

        End Try

    End Function

    Public Function ImportarDatosExcel(ByVal pNombreHoja As String) As DataTable
        dataTableDatosExcel = New DataTable
        DataGrid.DataSource = Nothing
        DataGrid.Rows.Clear()
        DataGrid.Refresh()
        'rango = Me.Rango1.Text & ":" & Me.Rango2.Text  'Rango de datos (opcional)  

        Try
            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + TextPathExcel.Text + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            'strconn = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (TextPathExcel.Text & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=2"";")))
            Dim mconn As New OleDbConnection(strconn)
            Dim cadena As String = "Select * from [" & pNombreHoja & "$]"
            'Dim cadena As String = "Select * from [" & rango & "]"
            Dim ad As New OleDbDataAdapter(cadena, mconn)
            mconn.Open()
            ad.Fill(dataTableDatosExcel)
            mconn.Close()
            Me.DataGrid.DataSource = dataTableDatosExcel
            'Traer Datos EXCEL
            If dataTableDatosExcel.Rows.Count > 0 Then
                Me.DataGrid.DataSource = dataTableDatosExcel
                For Each row As DataRow In dataTableDatosExcel.Rows
                    'Dim unTran As New ImportarTransferencia
                    'Try
                    '    unTran.numeroOperario = row.Item("Nro")
                    '    unTran.fecha = row.Item("Fecha")
                    '    unTran.destinoTransferencia = row.Item("Destino")
                    '    lista.Add(unTran)
                    'Catch ex As Exception
                    '    Exit For
                    'End Try
                Next

            End If


        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
            If ex.Message = "La tabla externa no tiene el formato esperado." Then
                Dim mensaje As String = "Siga los siguientes pasos " + Chr(13) + "1-Abra el archivo en Excel" + Chr(13) + "2- En menú Archivo elija Guardar Como..." + Chr(13) + "3- Debajo del nombre, en Tipo: elija: Libro de Excel 97-2003" + Chr(13) + "4- Escriba un nombre de archivo y guarde!, vuelva a seleccionarlo en el sistema de trazabilidad"
                MsgBox(mensaje)
            End If

        End Try

        Return dataTableDatosExcel
    End Function

    Private Sub TextPathExcel_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextPathExcel.TextChanged

    End Sub

    Private Sub btnCargar_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        seleccionarArchivo()
        If Me.TextHoja.Text.Length > 0 Then
            ImportarDatosExcel(Me.TextHoja.Text)
        End If
    End Sub

    Private Sub btnImportar_Click(sender As System.Object, e As System.EventArgs) Handles btnImportar.Click
        'Dim hilo1 As New Thread(AddressOf Importar) 'Crear el hilo 1
        'hilo1.Start()
        ''Esperar a que realmente mueran los hilos
        'While hilo1.IsAlive
        '    lbStatus.Text = "Espere por Favor..."
        'End While
        'lbStatus.Text = "Finalizado !!!"

        'hiloSegundoPlano.RunWorkerAsync(Importar())

        Timer1.Enabled = True
        Me.txtActualiza.Text = 0
        Me.txtIngresos.Text = 0
        'BARRA DE PROGRESO
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = dataTableDatosExcel.Rows.Count

        If (MsgBox("Desea importar datos animales al sistema ?", _
              MsgBoxStyle.YesNo, _
             "Sistema Trazabilidad - Importar datos")) = MsgBoxResult.Yes Then
            Me.btnImportar.Enabled = False
            importarDatos.Start()
        End If



    End Sub

    Public Sub ActualizarBarraProgreso(ByVal pValor As Integer)
        ProgressBar1.Value = pValor
    End Sub

    Public Sub Importar()
        Actualiza = 0
        Ingresos = 0
     
            If dataTableDatosExcel.Rows.Count > 0 Then
                Dim ActualizarBarra As New Thread(AddressOf ActualizarBarraProgreso) 'Crear el hilo 1
                Dim i As Integer = 0
                For Each row As DataRow In dataTableDatosExcel.Rows
                    ' Valor actual del Progressbar
                    'ActualizarBarra.Start(i)
                    i += 1
                    Dim NumDispositvo As String = row.Item("Dispositivo ")
                    Dim Dispositivo As String = unafachada.DevolverNumeroCaravana(NumDispositvo)

                    Dim raza As String
                    Try
                        raza = row.Item("Raza ")
                    Catch ex As Exception
                        raza = "N/A"
                    End Try
                    Dim Cruza As String
                    Try
                        Cruza = row.Item("Cruza ")
                    Catch ex As Exception
                        Cruza = "N/A"
                    End Try

                    Dim Sexo As String = row.Item("Sexo ")

                    Dim EdadMeses As Integer = row.Item("Edad(meses) ")

                    Dim EdadDias As String
                    Try
                        EdadDias = row.Item("Edad (dias) ")

                    Catch ex As Exception
                        EdadDias = "N/A"
                    End Try

                    Dim Propietario As String = ""
                    If row.Item("Propietario ").ToString.Length = 8 Then
                        Propietario = "0" & row.Item("Propietario ")
                    Else
                        Propietario = row.Item("Propietario ")
                    End If

                    Dim Ubicacion As String = ""
                    If row.Item("Ubicacion ").ToString.Length = 8 Then
                        Ubicacion = "0" & row.Item("Ubicacion ")
                    Else
                        Ubicacion = row.Item("Ubicacion ")
                    End If

                    Dim Tenedor As String = ""
                    If row.Item("Tenedor ").ToString.Length = 8 Then
                        Tenedor = "0" & row.Item("Tenedor ")
                    Else
                        Tenedor = row.Item("Tenedor ")
                    End If

                    Dim Vida As String = row.Item("Status de vida ")
                    Dim Trazabilidad As String = row.Item("Status de trazabilidad ")
                    Dim Errores As String = row.Item("Errores ")

                    Dim FechaIngresoUbicacionActualDate As Date
                    Dim FechaIngresoUbicacionActual As String
                    Try
                        FechaIngresoUbicacionActualDate = row.Item("Fecha ingreso a ubicacion actual ")
                        FechaIngresoUbicacionActual = FechaIngresoUbicacionActualDate.Year & "/" & FechaIngresoUbicacionActualDate.Month & "/" & FechaIngresoUbicacionActualDate.Day
                    Catch ex As Exception
                        FechaIngresoUbicacionActual = "1900" & "/" & "01" & "/" & "01"
                    End Try

                    Dim fechaNacimiento As String
                    Dim fecha As Date
                    Try
                        If EdadDias = 0 Then
                            fechaNacimiento = "1900" & "/" & "01" & "/" & "01"
                        Else
                            fecha = dtpFechaArchivo.Value.AddDays(EdadDias * -1) 'Resta días
                            fechaNacimiento = fecha.Year & "/" & fecha.Month & "/" & fecha.Day
                        End If

                    Catch ex As Exception
                        Try
                            fecha = dtpFechaArchivo.Value.AddMonths(EdadMeses * -1) 'Resta días
                            fechaNacimiento = fecha.Year & "/" & fecha.Month & "/" & fecha.Day
                        Catch ex2 As Exception
                            fechaNacimiento = "1900" & "/" & "01" & "/" & "01"
                        End Try
                    End Try


                    Dim castrado, entorado, prenado As Integer

                    If Sexo = "Macho" Then
                        castrado = 1
                        entorado = 0
                        prenado = 0
                    Else
                        castrado = 0
                        entorado = 0
                        prenado = 0
                    End If

                    Dim cadenaActualizaAnimales As String
                    Dim IdAnimal As Integer
                    Dim unAnimal As DataRow = unafachada.BuscarDispositivo(Dispositivo)
                    If Not unAnimal Is Nothing Then
                        Actualiza += 1
                        IdAnimal = unAnimal.Item("ani_id")
                        cadenaActualizaAnimales = "UPDATE animal SET ani_fechaNac =" & "'" & fechaNacimiento & "'" & ", ani_raza =" & "'" & raza & "'" & ", ani_cruza =" & "'" & Cruza & "'" & ", ani_sexo =" & "'" & Sexo & "'" & ", ani_pesoNac =" & 0 & ", ani_propietario =" & "'" & Propietario & "'" & ", ani_ubicacion =" & "'" & Ubicacion & "'" & ", ani_tenencia =" & "'" & Tenedor & "'" & ", ani_vida =" & "'" & Vida & "'" & ", ani_trazabilidad =" & "'" & Trazabilidad & "'" & ", ani_tipoIngreso =" & 2 & ", ani_IdPotrero =" & 1 & ", ani_potrero =" & "'" & "Sin Determinar" & "'" & ", ani_fecha_ubicacion_Actual =" & "'" & FechaIngresoUbicacionActual & "'" & ", ani_errores =" & "'" & Errores & "'" & ", ani_entorado =" & entorado & ", ani_castrado =" & castrado & ", ani_prenado =" & prenado & " WHERE animal.ani_dispositivo=" & "'" & Dispositivo & "'"
                    Else
                        Ingresos += 1
                        IdAnimal = unafachada.TraerUltimoId("animal", "ani_id")

                        cadenaActualizaAnimales = "INSERT INTO animal (ani_id,ani_numIngreso,ani_dispositivo, ani_fechaNac, ani_raza, ani_cruza,ani_sexo,ani_pesoNac,ani_propietario,ani_ubicacion,ani_tenencia,ani_vida,ani_trazabilidad,ani_tipoIngreso,ani_IdPotrero,ani_potrero,ani_fecha_ubicacion_Actual,ani_errores,ani_entorado,ani_castrado,ani_prenado) VALUES (" & IdAnimal & "," & "'" & "0" & "'" & "," & "'" & Dispositivo & "'" & "," & "'" & fechaNacimiento & "'" & "," & "'" & raza & "'" & "," & "'" & Cruza & "'" & "," & "'" & Sexo & "'" & "," & 0 & "," & "'" & Propietario & "'" & "," & "'" & Ubicacion & "'" & "," & "'" & Tenedor & "'" & "," & "'" & Vida & "'" & "," & "'" & Trazabilidad & "'" & "," & 2 & "," & 1 & "," & "'" & "Sin Determinar" & "'" & "," & "'" & FechaIngresoUbicacionActual & "'" & "," & "'" & Errores & "'" & "," & entorado & "," & castrado & "," & prenado & ")"
                    End If

                    Try
                        unafachada.EjecutarConsultaGENERICA(cadenaActualizaAnimales)
                    Catch ex As Exception
                        MsgBox("Error en Dispositivo: " & Dispositivo)
                    End Try

                Next
            MsgBox("Proceso Finalizado")
            End If
          

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If importarDatos.IsAlive = True Then
            Me.btnImportar.Enabled = False
        Else
            Me.btnImportar.Enabled = True
            Me.txtActualiza.Text = Actualiza
            Me.txtIngresos.Text = Ingresos
        End If


    End Sub
End Class