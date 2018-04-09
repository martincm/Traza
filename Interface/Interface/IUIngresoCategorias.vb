Imports Dominio, Inicio.IUMenu
Public Class IUIngresoCategorias


    Private Sub txtGuardar_Click(sender As System.Object, e As System.EventArgs) Handles txtGuardar.Click
        Guardar()
    End Sub

    Public Sub Guardar()
        If Me.txtNombre.Text.Length > 0 Then
            Dim mensaje As String = ""
            Dim bandera As Boolean = False
            Dim catId As Integer = Me.txtCodigo.Text
            Dim catNombre As String = Me.txtNombre.Text
            Dim catEdadMinima As Integer = Me.NudMinimo.Value
            Dim catEdadMaxima As Integer = Me.NudMaximo.Value
            Dim catTipo As String = Me.cboTipo.SelectedItem
            Dim catEntorado As Integer = Me.cboEntorado.SelectedIndex
            Dim catCastrado As Integer = Me.cboCastrado.SelectedIndex
            Dim catPrenado As Integer = Me.cboPrenado.SelectedIndex
            Dim catEstado As String = Me.cboEstado.SelectedIndex
            Dim catSexo As String = Me.cboSexo.SelectedItem
            Dim catMinimoPermanencia As Long = Me.NudMinimoPerm.Value
            Dim catMaximoPermanencia As Long = Me.NudMaximoPerm.Value
            Dim cadenaActualizaAnimales As String = ""
            If Not unafachada.BuscarCategorias(Me.txtCodigo.Text) Is Nothing Then
                cadenaActualizaAnimales = "UPDATE categoria SET cat_nombre=" & "'" & catNombre & "'" & ", cat_edadMin =" & catEdadMinima & ", cat_edadMax =" & catEdadMaxima & ", cat_tipo=" & "'" & catTipo & "'" & ", cat_entorado =" & catEntorado & ", cat_castrado=" & catCastrado & ", cat_prenado =" & catPrenado & ", cat_estado =" & catEstado & ", cat_sexo =" & "'" & catSexo & "'" & ", cat_permMin =" & catMinimoPermanencia & ", cat_permMax =" & catMaximoPermanencia & " WHERE cat_id=" & catId
                mensaje = "Actualizado"
            Else
                cadenaActualizaAnimales = "INSERT INTO categoria (cat_id,cat_nombre,cat_edadMin,cat_edadMax,cat_tipo,cat_entorado,cat_castrado,cat_prenado,cat_estado,cat_sexo,cat_permMin,cat_permMax) VALUES (" & catId & "," & "'" & catNombre & "'" & "," & catEdadMinima & "," & catEdadMaxima & "," & "'" & catTipo & "'" & "," & catEntorado & "," & catCastrado & "," & catPrenado & "," & catEstado & "," & "'" & catSexo & "'" & "," & catMinimoPermanencia & "," & catMaximoPermanencia & ")"
                mensaje = "Guardado"
            End If

            If bandera = unafachada.EjecutarConsultaGENERICA(cadenaActualizaAnimales) Then
                MsgBox(mensaje & "Correctamente")
            End If
            limpiarCategorias()
        End If
    End Sub

    Private Sub IUIngresoCategorias_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = 112 Then        ' F1

        'ElseIf e.KeyCode = 113 Then    ' F2
        '    limpiarCategorias()
        '    Me.txtNombre.Focus()

        'ElseIf e.KeyCode = 114 Then    ' F3

        'ElseIf e.KeyCode = 115 Then    ' F4
        '    Guardar()
        'End If
    End Sub

    Private Sub IUIngresoCategorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        limpiarCategorias()
       
    End Sub


    Public Sub crearColumnas()
        With LsView
            LsView.Items.Clear()
            .Columns.Clear()
            .Columns.Add("Id", 50, HorizontalAlignment.Left)
            .Columns.Add("Nombre", 100, HorizontalAlignment.Left)
            .Columns.Add("Sexo", 80, HorizontalAlignment.Left)
            .Columns.Add("EdadMin", 90, HorizontalAlignment.Left)
            .Columns.Add("EdadMax", 90, HorizontalAlignment.Left)
            .Columns.Add("Tipo", 90, HorizontalAlignment.Left)
            .Columns.Add("Entorado", 90, HorizontalAlignment.Left)
            .Columns.Add("Castrado", 90, HorizontalAlignment.Left)
            .Columns.Add("Preñado", 90, HorizontalAlignment.Left)
            .Columns.Add("Estado", 90, HorizontalAlignment.Left)
            .Columns.Add("PermMin", 90, HorizontalAlignment.Left)
            .Columns.Add("PermMax", 90, HorizontalAlignment.Left)


            '.View = View.Details
            '.FullRowSelect = False
            '.GridLines = True
            '.HideSelection = False
        End With

    End Sub


    Public Sub CargarCategorias(ByVal pDataSet As DataSet)
        crearColumnas()
        Dim i As Integer
        If Not pDataSet Is Nothing Then
            If pDataSet.Tables(0).Rows.Count > 0 Then
                While i < pDataSet.Tables(0).Rows.Count
                    Try
                        Dim unaFila As DataRow = pDataSet.Tables(0).Rows(i)
                        Dim lvi As ListViewItem
                        lvi = Me.LsView.Items.Add(unaFila("cat_id"))
                        lvi.SubItems.Add(unaFila("cat_nombre"))
                        lvi.SubItems.Add(unaFila("cat_sexo"))
                        lvi.SubItems.Add(unaFila("cat_edadMin"))
                        lvi.SubItems.Add(unaFila("cat_edadMax"))
                        lvi.SubItems.Add(unaFila("cat_tipo"))
                        lvi.SubItems.Add(unaFila("cat_entorado"))
                        lvi.SubItems.Add(unaFila("cat_castrado"))
                        lvi.SubItems.Add(unaFila("cat_prenado"))
                        lvi.SubItems.Add(unaFila("cat_estado"))
                        lvi.SubItems.Add(unaFila("cat_permMin"))
                        lvi.SubItems.Add(unaFila("cat_permMax"))


                    Catch ex As Exception

                    End Try
                    i += 1
                End While
            End If
        End If
    End Sub

    Public Sub limpiarCategorias()
        CargarCategorias(unafachada.TodasLasCategorias)
        Me.dtpFecha.Value = Today
        Me.txtNombre.Text = ""
        Me.NudMinimo.Value = 1
        Me.NudMaximo.Value = 1
        Me.NudMinimoPerm.Value = 0
        Me.NudMaximoPerm.Value = 10000
        Me.cboTipo.Items.Clear()
        Me.cboTipo.Items.Add("PERSONALIZADA")
        Me.cboTipo.Items.Add("DICOSE")

        Me.cboCastrado.Items.Clear()
        Me.cboEntorado.Items.Clear()
        Me.cboPrenado.Items.Clear()
        Me.cboSexo.Items.Clear()

        Me.cboCastrado.Items.Add("NO")
        Me.cboCastrado.Items.Add("SI")
        Me.cboEntorado.Items.Add("NO")
        Me.cboEntorado.Items.Add("SI")
        Me.cboPrenado.Items.Add("NO")
        Me.cboPrenado.Items.Add("SI")

        Me.cboSexo.Items.Add("Macho")
        Me.cboSexo.Items.Add("Hembra")

        Me.cboEstado.Items.Clear()
        Me.cboEstado.Items.Add("ACTIVO")
        Me.cboEstado.Items.Add("INACTIVO")

        Me.cboCastrado.SelectedIndex = 0
        Me.cboEntorado.SelectedIndex = 0
        Me.cboPrenado.SelectedIndex = 0
        Me.cboTipo.SelectedIndex = 0
        Me.cboEstado.SelectedIndex = 0
        Me.txtCodigo.Text = unafachada.TraerUltimoId("categoria", "cat_id")
    End Sub

    

    Public Function eliminarCelda() As Boolean

        Dim r As Integer
        r = MsgBox("Desea Eliminar Categoria", vbYesNo + vbInformation)
        Select Case r
            Case 6
                If Me.LsView.Items.Count > 1 Then
                    Dim bandera As Boolean = False
                    'dtgvAnimales.Rows.Remove(dtgvAnimales.CurrentRow)
                    Dim IdCategoria As String = CInt(LsView.SelectedItems(0).SubItems(0).Text)
                    Dim cadenaActualizacion As String
                    cadenaActualizacion = "DELETE FROM categoria WHERE cat_id=" & IdCategoria
                    bandera = unafachada.EjecutarConsultaGENERICA(cadenaActualizacion)
                    If bandera Then
                        limpiarCategorias()
                    End If
                    Return bandera
                End If

            Case 7

        End Select

       
    End Function




    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        limpiarCategorias()
        Me.txtNombre.Focus()
    End Sub

    Private Sub hiloSegundoPlano_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles hiloSegundoPlano.DoWork

    End Sub

    Private Sub hiloSegundoPlano_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles hiloSegundoPlano.ProgressChanged

    End Sub

    Private Sub dtgv_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If (MsgBox("¿ Desea Eliminar Categoria : " & LsView.SelectedItems(0).SubItems(1).Text & " ?", _
                     MsgBoxStyle.YesNoCancel, _
                    "Sistema Trazabilidad - Eliminar Categoria")) = MsgBoxResult.Yes Then
            'Eliminar Celda
            If eliminarCelda() Then
                MsgBox("Eliminado Correctamente")
            Else
                MsgBox("Error al eliminar")
            End If
        End If


    End Sub

    Private Sub LsView_DoubleClick(sender As Object, e As System.EventArgs) Handles LsView.DoubleClick
        eliminarCelda()
    End Sub

    Private Sub LsView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LsView.SelectedIndexChanged

        If TabControl1.SelectedTab.Name = "tabCategorias" Then
            If Me.LsView.Items.Count > 0 Then
                Me.txtCodigo.Text = LsView.FocusedItem.Text
                Me.txtNombre.Text = LsView.FocusedItem.SubItems(1).Text
                Me.cboSexo.SelectedItem = LsView.FocusedItem.SubItems(2).Text
                Me.NudMinimo.Value = LsView.FocusedItem.SubItems(3).Text
                Me.NudMaximo.Value = LsView.FocusedItem.SubItems(4).Text
                Me.cboTipo.SelectedItem = LsView.FocusedItem.SubItems(5).Text
                Me.cboEntorado.SelectedIndex = LsView.FocusedItem.SubItems(6).Text
                Me.cboCastrado.SelectedIndex = LsView.FocusedItem.SubItems(7).Text
                Me.cboPrenado.SelectedIndex = LsView.FocusedItem.SubItems(8).Text
                Me.cboEstado.SelectedIndex = LsView.FocusedItem.SubItems(9).Text

            End If
        End If
    End Sub

  
    Private Sub btnGuardarEventos_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarEventos.Click

    End Sub

    Private Sub tabCategorias_Click(sender As System.Object, e As System.EventArgs) Handles tabCategorias.Click

    End Sub

    Private Sub cboSexo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSexo.SelectedIndexChanged

    End Sub
End Class