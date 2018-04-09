<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUMenu))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDesdeSNIGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarBastonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotrerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EventosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArmadoLotesLecturaDirectaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 556)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(932, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(53, 17)
        Me.StatusLabel.Tag = "usuario"
        Me.StatusLabel.Text = "Usuario: "
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarDesdeSNIGToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.ConfigurarBastonToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'ImportarDesdeSNIGToolStripMenuItem
        '
        Me.ImportarDesdeSNIGToolStripMenuItem.Name = "ImportarDesdeSNIGToolStripMenuItem"
        Me.ImportarDesdeSNIGToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ImportarDesdeSNIGToolStripMenuItem.Text = "Importar Desde SNIG"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'ConfigurarBastonToolStripMenuItem
        '
        Me.ConfigurarBastonToolStripMenuItem.Name = "ConfigurarBastonToolStripMenuItem"
        Me.ConfigurarBastonToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConfigurarBastonToolStripMenuItem.Text = "Configurar Baston"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem1, Me.BusquedaToolStripMenuItem, Me.BusquedaToolStripMenuItem2})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.IngresosToolStripMenuItem.Text = "Identificación"
        '
        'IngresosToolStripMenuItem1
        '
        Me.IngresosToolStripMenuItem1.Name = "IngresosToolStripMenuItem1"
        Me.IngresosToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.IngresosToolStripMenuItem1.Text = "Ingreso D1"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.BusquedaToolStripMenuItem.Text = "Consultas D1"
        '
        'BusquedaToolStripMenuItem2
        '
        Me.BusquedaToolStripMenuItem2.Name = "BusquedaToolStripMenuItem2"
        Me.BusquedaToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.BusquedaToolStripMenuItem2.Text = "Busqueda Dispositvo"
        '
        'PotrerosToolStripMenuItem
        '
        Me.PotrerosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem2, Me.ModificacionToolStripMenuItem1, Me.BusquedaToolStripMenuItem1})
        Me.PotrerosToolStripMenuItem.Name = "PotrerosToolStripMenuItem"
        Me.PotrerosToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.PotrerosToolStripMenuItem.Text = "Potreros"
        '
        'IngresosToolStripMenuItem2
        '
        Me.IngresosToolStripMenuItem2.Name = "IngresosToolStripMenuItem2"
        Me.IngresosToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.IngresosToolStripMenuItem2.Text = "Ingreso"
        '
        'ModificacionToolStripMenuItem1
        '
        Me.ModificacionToolStripMenuItem1.Name = "ModificacionToolStripMenuItem1"
        Me.ModificacionToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ModificacionToolStripMenuItem1.Text = "Modificacion"
        '
        'BusquedaToolStripMenuItem1
        '
        Me.BusquedaToolStripMenuItem1.Name = "BusquedaToolStripMenuItem1"
        Me.BusquedaToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.BusquedaToolStripMenuItem1.Text = "Busqueda"
        '
        'ConsultasToolStripMenuItem1
        '
        Me.ConsultasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem1.Name = "ConsultasToolStripMenuItem1"
        Me.ConsultasToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ConsultasToolStripMenuItem1.Text = "Stock"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.EventosToolStripMenuItem1, Me.ConsultasToolStripMenuItem1, Me.PotrerosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EventosToolStripMenuItem1
        '
        Me.EventosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem3, Me.ConsultasToolStripMenuItem2, Me.ArmadoLotesLecturaDirectaToolStripMenuItem})
        Me.EventosToolStripMenuItem1.Name = "EventosToolStripMenuItem1"
        Me.EventosToolStripMenuItem1.Size = New System.Drawing.Size(99, 20)
        Me.EventosToolStripMenuItem1.Text = "Menu Principal"
        '
        'IngresosToolStripMenuItem3
        '
        Me.IngresosToolStripMenuItem3.Name = "IngresosToolStripMenuItem3"
        Me.IngresosToolStripMenuItem3.Size = New System.Drawing.Size(230, 22)
        Me.IngresosToolStripMenuItem3.Text = "Aplicar Eventos Animales"
        '
        'ConsultasToolStripMenuItem2
        '
        Me.ConsultasToolStripMenuItem2.Name = "ConsultasToolStripMenuItem2"
        Me.ConsultasToolStripMenuItem2.Size = New System.Drawing.Size(230, 22)
        Me.ConsultasToolStripMenuItem2.Text = "Consultas Eventos Animales"
        '
        'ArmadoLotesLecturaDirectaToolStripMenuItem
        '
        Me.ArmadoLotesLecturaDirectaToolStripMenuItem.Name = "ArmadoLotesLecturaDirectaToolStripMenuItem"
        Me.ArmadoLotesLecturaDirectaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ArmadoLotesLecturaDirectaToolStripMenuItem.Text = "Armado Lotes Lectura Directa"
        '
        'IUMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(932, 578)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "IUMenu"
        Me.Text = "Sistema - Trazabilidad"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PotrerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImportarDesdeSNIGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArmadoLotesLecturaDirectaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarBastonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
