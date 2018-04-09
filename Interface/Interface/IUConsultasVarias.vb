Imports Dominio, Inicio.IUMenu
Imports System.IO
Imports System.Threading
Imports System.IO.Ports
Imports System.Speech.Recognition

Public Class IUConsultasVarias
    Dim unDataSet As DataSet
    Dim dtListaEventosLineas As DataTable


    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click


        Dim ini As String = Me.DtpFechaDesde.Value.Year & "/" & Me.DtpFechaDesde.Value.Month & "/" & Me.DtpFechaDesde.Value.Day
        Dim fin As String = Me.dtpFechaHasta.Value.Year & "/" & Me.dtpFechaHasta.Value.Month & "/" & Me.dtpFechaHasta.Value.Day
        dtgv.DataSource = Nothing
        dtgv.Rows.Clear()
        dtgv.Refresh()

        Select Case Me.cboConsultas.SelectedIndex
            Case -1
                MsgBox("Seleccione una opcion")

            Case 0
                LabelX13.Text = "CONSULTA GENERAL DESDE: " & ini & " AL: " & fin
                'Dim cadena As String = "SELECT operacionesLineas.ope_lin_evento AS EventoPrincipal, operacionesLineas.ope_lin_eventoLin AS EventoSecundario, Count(operacionesLineas.ope_lin_id) AS Cantidad FROM(operacionesLineas) WHERE(((operacionesLineas.ope_lin_fecha) >= " & "#" & ini & "#" & " And (operacionesLineas.ope_lin_fecha) <=" & "#" & fin & "#" & " )) GROUP BY operacionesLineas.ope_lin_evento, operacionesLineas.ope_lin_eventoLin;"

                Dim cadena As String = "SELECT operacionesLineas.ope_lin_fecha AS Fecha, operacionesLineas.ope_lin_lote AS Lote, operacionesLineas.ope_lin_evento AS EventoPrincipal, operacionesLineas.ope_lin_eventoLin AS EventoSecundario, Count(operacionesLineas.ope_lin_id) AS Cantidad, operacionesLineas.ope_lin_potreroOri AS Origen, operacionesLineas.ope_lin_potreroDes AS Destino, productor.pro_nombre AS Productor, operacionesLineas.ope_lin_dicoseCampoOri AS DicoseOri, operacionesLineas.ope_lin_dicoseCampoDes AS DicoseDes" & _
                " FROM operacionesLineas INNER JOIN productor ON operacionesLineas.ope_lin_dicoseCampoOri = productor.pro_dicose " & _
                " WHERE (((operacionesLineas.ope_lin_fecha)>=" & "#" & ini & "#" & " And " & "(operacionesLineas.ope_lin_fecha)<=" & "#" & fin & "#" & ")) " & _
                " GROUP BY operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_lote, operacionesLineas.ope_lin_evento, operacionesLineas.ope_lin_eventoLin, operacionesLineas.ope_lin_potreroOri, operacionesLineas.ope_lin_potreroDes, productor.pro_nombre, operacionesLineas.ope_lin_dicoseCampoOri, operacionesLineas.ope_lin_dicoseCampoDes;"
                unDataSet = unafachada.EjecutarConsultaGENERICADataSet(cadena)
                Try
                    dtgv.DataSource = unDataSet.Tables(0)
                Catch ex As Exception
                    dtgv.DataSource = Nothing
                End Try

            Case 1
                Me.lbdis.Visible = True
                LabelX13.Text = "CONSULTA INDIVIDUAL DESDE: " & ini & " AL: " & fin
                Dim cadena As String = "SELECT operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo AS Dispositivo, Count(operacionesLineas.ope_lin_id) AS Unidad, operacionesLineas.ope_lin_eventoLin AS Evento, animal.ani_potrero AS Ubicacion, animal.ani_fechaNac AS Nacio, animal.ani_raza AS Raza, animal.ani_cruza AS Cruza, animal.ani_sexo AS Sexo FROM operacionesLineas INNER JOIN animal ON operacionesLineas.ope_lin_dispositivo = animal.ani_dispositivo WHERE (((operacionesLineas.ope_lin_fecha)>=" & "#" & ini & "#" & " And (operacionesLineas.ope_lin_fecha)<=" & "#" & fin & "#" & ") AND ((operacionesLineas.ope_lin_dispositivo)=" & "'" & Me.txtDispositivo.Text & "'" & "))GROUP BY operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo, operacionesLineas.ope_lin_eventoLin, animal.ani_potrero, animal.ani_fechaNac, animal.ani_raza, animal.ani_cruza, animal.ani_sexo"
                unDataSet = unafachada.EjecutarConsultaGENERICADataSet(cadena)
                Try
                    dtgv.DataSource = unDataSet.Tables(0)
                Catch ex As Exception
                    dtgv.DataSource = Nothing
                End Try


        End Select



    End Sub





    Private Sub IUConsultasVarias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DtpFechaDesde.Value = Today
        Me.dtpFechaHasta.Value = Today

        Me.cboConsultas.Items.Clear()
        Me.cboConsultas.Items.Add("Eventos")
        Me.cboConsultas.Items.Add("Eventos Individuales")
        Me.cboConsultas.SelectedIndex = 0
        'COMBO EVENTOS LINEAS
        dtListaEventosLineas = unafachada.TodosLasListasEventosLineas()
    End Sub

    Public Function CargarComboDesdeDataTable(ByVal pCombo As ComboBox, ByVal pDataTable As DataTable, ByVal pColumna As Integer) As Boolean
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
        unafachada.ExportarExcelyAbrirlo(unDataSet)
    End Sub


    Public Sub BuscarEventosxAnimal(ByVal pDispositivo As String)
        Me.txtIniDis.Text = ""
        Me.txtFinDis.Text = ""

        Me.txtIniDis.Text = pDispositivo.Substring(6, 5)
        Me.txtFinDis.Text = pDispositivo.Substring(11, 4)


        'If Me.txtFinDis.Text.Length = 3 Then
        '    Me.txtFinDis.Text = "0" & terminacion
        'End If

        pDispositivo = pDispositivo.Substring(0, 15)


        dtgv.DataSource = Nothing
        dtgv.Rows.Clear()
        dtgv.Refresh()
        If pDispositivo.Length = 15 Then
            Me.lbdis.Visible = True
            Dim ini As String = Me.DtpFechaDesde.Value.Year & "/" & Me.DtpFechaDesde.Value.Month & "/" & Me.DtpFechaDesde.Value.Day
            Dim fin As String = Me.dtpFechaHasta.Value.Year & "/" & Me.dtpFechaHasta.Value.Month & "/" & Me.dtpFechaHasta.Value.Day
            Dim cadena As String = "SELECT operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo AS Dispositivo, Count(operacionesLineas.ope_lin_id) AS Unidad, operacionesLineas.ope_lin_eventoLin AS Evento, animal.ani_potrero AS Ubicacion, animal.ani_fechaNac AS Nacio, animal.ani_raza AS Raza, animal.ani_cruza AS Cruza, animal.ani_sexo AS Sexo FROM operacionesLineas INNER JOIN animal ON operacionesLineas.ope_lin_dispositivo = animal.ani_dispositivo WHERE (((operacionesLineas.ope_lin_fecha)>=" & "#" & ini & "#" & " And (operacionesLineas.ope_lin_fecha)<=" & "#" & fin & "#" & ") AND ((operacionesLineas.ope_lin_dispositivo)=" & "'" & pDispositivo & "'" & "))GROUP BY operacionesLineas.ope_lin_fecha, operacionesLineas.ope_lin_dispositivo, operacionesLineas.ope_lin_eventoLin, animal.ani_potrero, animal.ani_fechaNac, animal.ani_raza, animal.ani_cruza, animal.ani_sexo"
            unDataSet = unafachada.EjecutarConsultaGENERICADataSet(cadena)

            Dim cadenaAnimal As String = "SELECT animal.ani_dispositivo, animal.ani_fechaNac, animal.ani_nombre, animal.ani_raza, animal.ani_cruza, animal.ani_padre, animal.ani_madre, animal.ani_dicose_nacimiento, animal.ani_sexo, animal.ani_pesoNac, animal.ani_propietario, animal.ani_ubicacion, animal.ani_tenencia, animal.ani_vida, animal.ani_trazabilidad, animal.ani_potrero, animal.ani_entorado, animal.ani_castrado, animal.ani_prenado, animal.ani_fecha_ubicacion_Actual, animal.ani_errores, animal.ani_peso FROM(animal) WHERE(((animal.ani_dispositivo) =" & "'" & pDispositivo & "'" & ")) GROUP BY animal.ani_dispositivo, animal.ani_fechaNac, animal.ani_nombre, animal.ani_raza, animal.ani_cruza, animal.ani_padre, animal.ani_madre, animal.ani_dicose_nacimiento, animal.ani_sexo, animal.ani_pesoNac, animal.ani_propietario, animal.ani_ubicacion, animal.ani_tenencia, animal.ani_vida, animal.ani_trazabilidad, animal.ani_potrero, animal.ani_entorado, animal.ani_castrado, animal.ani_prenado, animal.ani_fecha_ubicacion_Actual, animal.ani_errores, animal.ani_peso;"
            Dim unAnimalDataSet As DataSet = unafachada.EjecutarConsultaGENERICADataSet(cadenaAnimal)
            'DATOS ANIMAL
            If Not unAnimalDataSet Is Nothing Then
                If unAnimalDataSet.Tables(0).Rows.Count > 0 Then
                    Try
                        Me.txtEdad.Text = DateDiff(DateInterval.Month, unAnimalDataSet.Tables(0).Rows(0).Item("ani_fechaNac"), Today)
                    Catch ex As Exception
                        Me.txtEdad.Text = "N/A"
                    End Try

                    Try
                        Me.txtRaza.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_raza")
                    Catch ex As Exception
                        Me.txtRaza.Text = "N/A"
                    End Try

                    Try
                        Me.txtSexo.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_sexo")
                    Catch ex As Exception
                        Me.txtSexo.Text = "N/A"
                    End Try

                    Try
                        Me.txtTenencia.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_tenencia")
                    Catch ex As Exception
                        Me.txtTenencia.Text = "N/A"
                    End Try

                    Try
                        Me.txtUbicacion.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_ubicacion")
                    Catch ex As Exception
                        Me.txtUbicacion.Text = "N/A"
                    End Try

                    Try
                        Me.txtPropietario.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_propietario")
                    Catch ex As Exception
                        Me.txtPropietario.Text = "N/A"
                    End Try

                    Try
                        Me.txtVida.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_vida")
                    Catch ex As Exception
                        Me.txtVida.Text = "N/A"
                    End Try

                    Try
                        Me.txtTraza.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_trazabilidad")
                    Catch ex As Exception
                        Me.txtTraza.Text = "N/A"
                    End Try

                    Try
                        Me.txtPotrero.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_potrero")
                    Catch ex As Exception
                        Me.txtPotrero.Text = "N/A"
                    End Try

                    Try
                        Me.txtPesoNac.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_pesoNac")
                    Catch ex As Exception
                        Me.txtPesoNac.Text = "N/A"
                    End Try

                    Try
                        Me.txtCastrado.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_castrado")
                    Catch ex As Exception
                        Me.txtCastrado.Text = "N/A"
                    End Try

                    Try
                        Me.txtEntorado.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_entorado")
                    Catch ex As Exception
                        Me.txtEntorado.Text = "N/A"
                    End Try

                    Try
                        Me.txtPrenado.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_prenado")
                    Catch ex As Exception
                        Me.txtPrenado.Text = "N/A"
                    End Try

                    Try
                        Me.txtPrenado.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_prenado")
                    Catch ex As Exception
                        Me.txtPrenado.Text = "N/A"
                    End Try

                    Try
                        Me.txtDicoseNac.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_dicose_nacimiento")
                    Catch ex As Exception
                        Me.txtDicoseNac.Text = "N/A"
                    End Try

                    Try
                        Me.txtCruza.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_cruza")
                    Catch ex As Exception
                        Me.txtCruza.Text = "N/A"
                    End Try

                    Try
                        Dim fechaUbicacionActual As Date = unAnimalDataSet.Tables(0).Rows(0).Item("ani_fecha_ubicacion_Actual")
                        Dim dias As Integer = DateDiff(DateInterval.Day, fechaUbicacionActual, Today)
                        Me.txtDiasUbicacion.Text = dias
                    Catch ex As Exception
                        Me.txtDiasUbicacion.Text = "N/A"
                    End Try

                    Try
                        Me.txtErrores.Text = unAnimalDataSet.Tables(0).Rows(0).Item("ani_errores")
                    Catch ex As Exception
                        Me.txtErrores.Text = "N/A"
                    End Try

                    Try
                        Me.txtPesoActual.Text = Math.Round(unAnimalDataSet.Tables(0).Rows(0).Item("ani_peso"), 0)

                    Catch ex As Exception
                        Me.txtPesoActual.Text = "N/A"
                    End Try



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



    Private Sub txtDispositivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDispositivo.TextChanged

    End Sub
End Class