Imports Dominio, Inicio.IUMenu
Public Class IUReporteOperaciones
    Dim Reporte As Object

    Private Sub IUReporteOperaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Sub New(ByVal pReporte As Object, ByVal pTitulo As String)
        Reporte = pReporte
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Try
            'Paso(Parametros)
            Reporte.SetParameterValue(0, pTitulo)
            '    ' reporte.SetParameterValue("@Fecha2", fecha2)

            '    reporte.SetDataSource(DataSetD1)

            '    ' reporte.SetParameterValue(0, "ORIGINAL")
            '    'reporte.SetParameterValue(1, pfecha2)

            crvD1.ReportSource = Reporte


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub crvD1_Load(sender As System.Object, e As System.EventArgs) Handles crvD1.Load

    End Sub
End Class