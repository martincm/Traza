Imports Dominio, Inicio.IUMenu
Public Class IUSubSeleccionArchivo

    Private dtHistorial As DataTable
  
    Private Sub IUSubSeleccionArchivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarHistorial()
    End Sub



    Public Sub cargarHistorial()
        If dtHistorial.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dtHistorial.Rows.Count - 1
                Try
                    Me.dtgvHistorial.Rows.Add()
                    Me.dtgvHistorial.Item("Id", i).Value() = dtHistorial.Rows(i)("His_id")
                    Me.dtgvHistorial.Item("fecha", i).Value() = dtHistorial.Rows(i)("His_fecha").ToString()
                    Me.dtgvHistorial.Item("tarea", i).Value = dtHistorial.Rows(i)("His_nombre").ToString()
                    Me.dtgvHistorial.Item("archivo", i).Value = dtHistorial.Rows(i)("His_archivo").ToString()
                Catch ex As Exception

                End Try
            Next i
        End If
    End Sub
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtHistorial = unafachada.TodosLosHistorial(1, 0)

    End Sub

    Private Sub dtgvHistorial_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvHistorial.CellContentClick

    End Sub

    Private Sub dtgvHistorial_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvHistorial.CellContentDoubleClick
        unafachada.NombreArchivoSeleccionado = dtgvHistorial.CurrentRow.Cells("archivo").Value()
        Me.Dispose()
        Me.Close()
    End Sub

End Class