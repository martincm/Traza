Imports Dominio, Inicio.IUMenu
Public Class IUReporteD1
    Dim Reporte As Dac.ReporteD1
    Private Sub IUReporteD1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Reporte.Close()
        Reporte.Dispose()
    End Sub

    Private Sub IUReporteD1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub crvD1_Load(sender As System.Object, e As System.EventArgs) Handles crvD1.Load

    End Sub
    Sub New(ByVal pReporte As Dac.ReporteD1, ByVal pEsCopia As Boolean)
        Reporte = pReporte

        'Dim UltimaPagina As Integer
        'UltimaPagina = rpt.FormatEngine.GetLastPageNumber(New CrystalDecisions.Shared.ReportPageRequestContext())
        'rpt.PrintToPrinter(1, True, 0, 0) 'Imprimimos todo el reporte con las paginas que tenga.
        'rpt.Close() 'Cerramos el reporte
        'rpt.Dispose() 'Destruimos el reporte para que no te sature la memoria


        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Try
            '    Dim cadenaCabezal As String = "select * from ingresos where Ing_Id=" & pNumeroIngreso
            '    Dim cadenaLineas As String
            '    cadenaLineas = "select * from ingresosLineas where Ing_Lin_IdCabezal=" & pNumeroIngreso


            '    Dim listaCadenas As New List(Of String)
            '    Dim listaNombreTablas As New List(Of String)
            '    listaCadenas.Add(cadenaCabezal)
            '    listaNombreTablas.Add("ingresos")
            '    listaCadenas.Add(cadenaLineas)
            '    listaNombreTablas.Add("ingresosLineas")

            '    Dim DataSetD1 As New Dac.DsD1
            '    unafachada.EjecutarConsultaGENERICAVariasTablasDataSet(listaCadenas, DataSetD1, listaNombreTablas)

            'Paso(Parametros)
            Reporte.SetParameterValue(0, pEsCopia)
            '    ' reporte.SetParameterValue("@Fecha2", fecha2)

            '    reporte.SetDataSource(DataSetD1)

            '    ' reporte.SetParameterValue(0, "ORIGINAL")
            '    'reporte.SetParameterValue(1, pfecha2)

            crvD1.ReportSource = Reporte


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

End Class