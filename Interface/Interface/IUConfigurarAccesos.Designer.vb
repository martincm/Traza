<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUConfigurarAccesos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbini = New System.Windows.Forms.Label()
        Me.lbFin = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBaston = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboIngresos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtNombreActividad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.chip = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LsView = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btnAgregar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.cboEventos1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Azure
        Me.GroupBox2.Controls.Add(Me.lbini)
        Me.GroupBox2.Controls.Add(Me.lbFin)
        Me.GroupBox2.Location = New System.Drawing.Point(711, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 112)
        Me.GroupBox2.TabIndex = 595
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chip Boton Actual"
        '
        'lbini
        '
        Me.lbini.AutoSize = True
        Me.lbini.BackColor = System.Drawing.Color.Transparent
        Me.lbini.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbini.Location = New System.Drawing.Point(15, 27)
        Me.lbini.Name = "lbini"
        Me.lbini.Size = New System.Drawing.Size(108, 37)
        Me.lbini.TabIndex = 596
        Me.lbini.Text = "02117"
        '
        'lbFin
        '
        Me.lbFin.AutoSize = True
        Me.lbFin.BackColor = System.Drawing.Color.Transparent
        Me.lbFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFin.Location = New System.Drawing.Point(3, 57)
        Me.lbFin.Name = "lbFin"
        Me.lbFin.Size = New System.Drawing.Size(136, 55)
        Me.lbFin.TabIndex = 595
        Me.lbFin.Text = "0552"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'btnBaston
        '
        Me.btnBaston.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBaston.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBaston.Location = New System.Drawing.Point(597, 18)
        Me.btnBaston.Name = "btnBaston"
        Me.btnBaston.Size = New System.Drawing.Size(88, 23)
        Me.btnBaston.TabIndex = 610
        Me.btnBaston.Text = "Activar Baston"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboIngresos)
        Me.GroupBox3.Controls.Add(Me.LabelX3)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Controls.Add(Me.LabelX1)
        Me.GroupBox3.Controls.Add(Me.txtNombreActividad)
        Me.GroupBox3.Controls.Add(Me.ButtonX1)
        Me.GroupBox3.Controls.Add(Me.cboTipo)
        Me.GroupBox3.Controls.Add(Me.txtGuardar)
        Me.GroupBox3.Controls.Add(Me.LabelX11)
        Me.GroupBox3.Controls.Add(Me.LabelX13)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(873, 139)
        Me.GroupBox3.TabIndex = 611
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Menu Principal"
        '
        'cboIngresos
        '
        Me.cboIngresos.DisplayMember = "Text"
        Me.cboIngresos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboIngresos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIngresos.FormattingEnabled = True
        Me.cboIngresos.ItemHeight = 21
        Me.cboIngresos.Location = New System.Drawing.Point(483, 34)
        Me.cboIngresos.Name = "cboIngresos"
        Me.cboIngresos.Size = New System.Drawing.Size(202, 27)
        Me.cboIngresos.TabIndex = 534
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(530, 15)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(155, 20)
        Me.LabelX3.TabIndex = 533
        Me.LabelX3.Text = "Actividades disponibles"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCodigo.Border.Class = "TextBoxBorder"
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(760, 51)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(95, 29)
        Me.txtCodigo.TabIndex = 532
        Me.txtCodigo.Text = "1"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigo.WatermarkColor = System.Drawing.SystemColors.ControlLightLight
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.ForestGreen
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX1.Location = New System.Drawing.Point(760, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(95, 21)
        Me.LabelX1.TabIndex = 531
        Me.LabelX1.Text = "Nº CODIGO"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreActividad.Border.Class = "TextBoxBorder"
        Me.txtNombreActividad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreActividad.Location = New System.Drawing.Point(123, 38)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.Size = New System.Drawing.Size(217, 27)
        Me.txtNombreActividad.TabIndex = 530
        Me.txtNombreActividad.Text = "Ecografia"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(483, 67)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(98, 23)
        Me.ButtonX1.TabIndex = 528
        Me.ButtonX1.Text = "&Nuevo"
        '
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 16
        Me.cboTipo.Location = New System.Drawing.Point(123, 71)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(137, 22)
        Me.cboTipo.TabIndex = 525
        '
        'txtGuardar
        '
        Me.txtGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.txtGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.txtGuardar.Location = New System.Drawing.Point(587, 67)
        Me.txtGuardar.Name = "txtGuardar"
        Me.txtGuardar.Size = New System.Drawing.Size(98, 23)
        Me.txtGuardar.TabIndex = 458
        Me.txtGuardar.Text = "&Guardar"
        '
        'LabelX11
        '
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(13, 72)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(42, 20)
        Me.LabelX11.TabIndex = 515
        Me.LabelX11.Text = "Tipo"
        '
        'LabelX13
        '
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(13, 41)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(104, 20)
        Me.LabelX13.TabIndex = 511
        Me.LabelX13.Text = "Nombre Actividad"
        '
        'chip
        '
        Me.chip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chip.Location = New System.Drawing.Point(47, 17)
        Me.chip.Name = "chip"
        Me.chip.Size = New System.Drawing.Size(148, 26)
        Me.chip.TabIndex = 533
        Me.chip.Text = "22563"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chip)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.LsView)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.btnBaston)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.LabelX14)
        Me.GroupBox1.Controls.Add(Me.cboEventos1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 284)
        Me.GroupBox1.TabIndex = 612
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botones"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(593, 231)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(92, 23)
        Me.ButtonX2.TabIndex = 615
        Me.ButtonX2.Text = "Eliminar"
        '
        'LsView
        '
        '
        '
        '
        Me.LsView.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground
        Me.LsView.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground
        Me.LsView.Border.Class = "ListViewBorder"
        Me.LsView.Border.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LsView.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsView.FullRowSelect = True
        Me.LsView.GridLines = True
        Me.LsView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LsView.Location = New System.Drawing.Point(22, 65)
        Me.LsView.Name = "LsView"
        Me.LsView.ShowItemToolTips = True
        Me.LsView.Size = New System.Drawing.Size(663, 160)
        Me.LsView.TabIndex = 614
        Me.LsView.UseCompatibleStateImageBehavior = False
        Me.LsView.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 430
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(211, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(92, 20)
        Me.LabelX2.TabIndex = 537
        Me.LabelX2.Text = "Nombre Lote "
        '
        'btnAgregar
        '
        Me.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAgregar.Location = New System.Drawing.Point(473, 18)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        '
        'LabelX14
        '
        Me.LabelX14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(6, 21)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(35, 20)
        Me.LabelX14.TabIndex = 518
        Me.LabelX14.Text = "Chip"
        '
        'cboEventos1
        '
        Me.cboEventos1.DisplayMember = "Text"
        Me.cboEventos1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEventos1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEventos1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventos1.FormattingEnabled = True
        Me.cboEventos1.ItemHeight = 19
        Me.cboEventos1.Location = New System.Drawing.Point(327, 19)
        Me.cboEventos1.Name = "cboEventos1"
        Me.cboEventos1.Size = New System.Drawing.Size(130, 25)
        Me.cboEventos1.TabIndex = 601
        '
        'SerialPort1
        '
        '
        'IUConfigurarAccesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(910, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "IUConfigurarAccesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IUConfigurarAccesos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbini As System.Windows.Forms.Label
    Friend WithEvents lbFin As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnBaston As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreActividad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LsView As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chip As System.Windows.Forms.TextBox
    Friend WithEvents cboEventos1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cboIngresos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX

End Class
