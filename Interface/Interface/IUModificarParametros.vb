Imports Dominio
Imports Inicio.IUMenu

Public Class IUModificarParametros
    Inherits System.Windows.Forms.Form



    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.txtnombre.Text = "" Then
            MessageBox.Show("No se pudo Ingresar, verifique Nombre", "Modificar Parametros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim unparametro As New Dominio.Parametros
            unparametro = New Dominio.Parametros
            unparametro.NombreParametro = txtnombre.Text
            unparametro.ValorParametro = txtvalor.Text
            unparametro.DescripcionParametro = txtdes.Text

            If unafachada.ModificarParametros(unparametro) Then

                MessageBox.Show("Modificado")
                Me.lsParametros.DataSource = Nothing
                Me.lsParametros.DataSource = unafachada.TodosLosParametros
            Else
                MessageBox.Show("No hay Cambios")
            End If
        End If
    End Sub


    Private Sub IUIngresoGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lsParametros.DataSource = unafachada.TodosLosParametros
    End Sub



    Private Sub lsGastos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsParametros.SelectedIndexChanged
        Dim unparametro As Parametros = CType(lsParametros.SelectedItem, Parametros)
        If unparametro IsNot Nothing Then
            txtnombre.Text = unparametro.NombreParametro
            txtvalor.Text = unparametro.ValorParametro
            txtdes.Text = unparametro.DescripcionParametro
        End If

    End Sub
End Class