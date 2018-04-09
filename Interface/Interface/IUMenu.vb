Imports Dominio
Public Class IUMenu
    Public Shared unafachada As New Fachada()

    Private Sub IUMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub



    Function formularioAbierto(ByVal nomForm As String) As Boolean
        Dim f As Form
        For Each f In Me.MdiChildren
            If f.Name.ToUpper = nomForm.ToUpper Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub IngresoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub IngresosToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles IngresosToolStripMenuItem2.Click
        If Not formularioAbierto("IUIngresoPotreros") Then
            Dim unIUIngresoPotreros As New IUIngresoPotreros
            unIUIngresoPotreros.MdiParent = Me
            unIUIngresoPotreros.Show()
        End If
    End Sub

    Private Sub IngresosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles IngresosToolStripMenuItem1.Click
        If Not formularioAbierto("IUIngresoIdentificacion") Then
            Dim unIUIngresoIdentificacion As New IUIngresoIdentificacion
            unIUIngresoIdentificacion.MdiParent = Me
            unIUIngresoIdentificacion.Show()
        End If
    End Sub

    Private Sub IUMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StatusLabel.Text = "Tipo Base Datos: " & unafachada.TipoBaseDatos
        Dim obs As String = ""

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        If Not formularioAbierto("IUModificarParametros") Then
            Dim unIUModificarParametros As New IUModificarParametros
            unIUModificarParametros.MdiParent = Me
            unIUModificarParametros.Show()
        End If

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub IngresoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConsultasToolStripMenuItem1.Click
       
    End Sub

    Private Sub ImportarDesdeSNIGToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportarDesdeSNIGToolStripMenuItem.Click
        If Not formularioAbierto("IUImportarDatos") Then
            Dim unIUImportarDatos As New IUImportarDatos
            IUImportarDatos.MdiParent = Me
            IUImportarDatos.Show()
        End If
    End Sub

    Private Sub IngresoTiempoRealToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'If Not formularioAbierto("IUIngresoEventosDirecto") Then
        '    Dim unIUIngresoEventosDirecto As New IUIngresoEventosDirecto
        '    unIUIngresoEventosDirecto.MdiParent = Me
        '    unIUIngresoEventosDirecto.Show()
        'End If



    End Sub

    Private Sub ConfigurarAccesosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If Not formularioAbierto("IUConfigurarAccesos") Then
            Dim unIUConfigurarAccesos As New IUConfigurarAccesos
            unIUConfigurarAccesos.MdiParent = Me
            unIUConfigurarAccesos.Show()
        End If
    End Sub

    Private Sub IngresosToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles IngresosToolStripMenuItem3.Click
        If Not formularioAbierto("IUIngresoEventos") Then
            Dim unIUIngresoEventos As New IUIngresoEventos
            unIUIngresoEventos.MdiParent = Me
            unIUIngresoEventos.Show()
        End If
    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConsultasToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ConsultasToolStripMenuItem2.Click
        If Not formularioAbierto("IUConsultasVarias") Then
            Dim unConsultasVarias As New IUConsultasVarias
            unConsultasVarias.MdiParent = Me
            unConsultasVarias.Show()
        End If
    End Sub

    Private Sub EventosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ArmadoLotesLecturaDirectaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArmadoLotesLecturaDirectaToolStripMenuItem.Click
        If Not formularioAbierto("IUPreviaEventos") Then
            Dim unIUPreviaEventos As New IUPreviaEventos
            unIUPreviaEventos.MdiParent = Me
            unIUPreviaEventos.Show()
        End If
    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub BusquedaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusquedaToolStripMenuItem.Click

    End Sub

    Private Sub CamionesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        If Not formularioAbierto("IUConsultas") Then
            Dim unIUConsultas As New IUConsultas
            unIUConsultas.MdiParent = Me
            unIUConsultas.Show()
        End If
    End Sub

    Private Sub IngresoCategoriasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If Not formularioAbierto("IUIngresoCategorias") Then
            Dim unIUIngresoCategorias As New IUIngresoCategorias
            unIUIngresoCategorias.MdiParent = Me
            unIUIngresoCategorias.Show()
        End If
    End Sub

    Private Sub ConfigurarBastonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarBastonToolStripMenuItem.Click
        If Not formularioAbierto("IUBaston") Then
            Dim unIUBaston As New IUBaston
            unIUBaston.MdiParent = Me
            unIUBaston.Show()
        End If
    End Sub

    Private Sub BusquedaToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles BusquedaToolStripMenuItem2.Click

    End Sub
End Class