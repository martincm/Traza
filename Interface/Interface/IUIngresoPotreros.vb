Imports Dominio, Inicio.IUMenu
Public Class IUIngresoPotreros


    Private Sub txtGuardar_Click(sender As System.Object, e As System.EventArgs) Handles txtGuardar.Click
        guardar()
    End Sub


    Public Sub guardar()
        If Me.txtNombrePotrero.Text.Length > 0 Then
            Dim potId As Integer = Me.txtCodigo.Text
            Dim potNombre As String = Me.txtNombrePotrero.Text
            Dim potSuelo As String = Me.txtSuelo.Text
            Dim potDetalle As String = Me.txtDetalle.Text
            Dim potTenencia As String = Me.cboTenencia.SelectedItem
            Dim potSupTotal As Decimal = Me.txtSuperficieTotal.Text
            Dim potSupInu As Decimal = Me.txtSuperficieinutilizada.Text
            Dim cadenaActualizaAnimales As String = ""
            cadenaActualizaAnimales = "INSERT INTO potreros (pot_id,pot_fecha,pot_nombre,pot_usosuelo,pot_detalle,pot_tenencia,pot_superficie,pot_superficieInutilizada) VALUES (" & potId & "," & "'" & Today & "'" & "," & "'" & potNombre & "'" & "," & "'" & potSuelo & "'" & "," & "'" & potDetalle & "'" & "," & "'" & potTenencia & "'" & "," & potSupTotal & "," & potSupInu & ")"
            If unafachada.EjecutarConsultaGENERICA(cadenaActualizaAnimales) Then
                MsgBox("Correctamente")
            End If
            limpiar()
        End If

    End Sub

    Public Sub limpiar()
        Me.txtCodigo.Text = unafachada.TraerUltimoId("potreros", "pot_id")
        Me.txtNombrePotrero.Text = ""
        Me.txtSuelo.Text = ""
        Me.txtDetalle.Text = ""
        Me.cboTenencia.SelectedItem = 0
        Me.txtSuperficieTotal.Text = 0
        Me.txtSuperficieinutilizada.Text = 0
    End Sub
    Private Sub IUIngresoPotreros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Today

        'COMBO EVENTOS
        Me.cboTenencia.Items.Clear()
        Me.cboTenencia.Items.Add("Propio")
        Me.cboTenencia.Items.Add("Ajeno")
        Me.cboTenencia.SelectedIndex = 0
        CheckForIllegalCrossThreadCalls = False
        Me.limpiar()
    End Sub


    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        Me.txtNombrePotrero.Text = 0

    End Sub



    Private Sub TextBoxX6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxX6.TextChanged

    End Sub

    Private Sub ButtonX1_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        limpiar()
        Me.txtNombrePotrero.Focus()
    End Sub
End Class