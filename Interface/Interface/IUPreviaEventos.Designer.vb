<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUPreviaEventos
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNueva = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LsView = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chip = New System.Windows.Forms.TextBox()
        Me.chkSonido = New System.Windows.Forms.CheckBox()
        Me.chkDatosAnimales = New System.Windows.Forms.CheckBox()
        Me.chkTareasAnteriores = New System.Windows.Forms.CheckBox()
        Me.cboIngresos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Azure
        Me.GroupBox2.Controls.Add(Me.lbini)
        Me.GroupBox2.Controls.Add(Me.lbFin)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 112)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelX1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnNueva)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.cboIngresos)
        Me.GroupBox3.Controls.Add(Me.LabelX3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(892, 322)
        Me.GroupBox3.TabIndex = 611
        Me.GroupBox3.TabStop = False
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(274, 90)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 12)
        Me.LabelX1.TabIndex = 615
        Me.LabelX1.Text = "Disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 26)
        Me.Label2.TabIndex = 614
        Me.Label2.Text = "(Las caravanas de cada lote, deberá cargarlas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   posteriormente leyendolas dire" & _
    "ctamente del ¨Chip¨) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnNueva
        '
        Me.btnNueva.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNueva.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNueva.Location = New System.Drawing.Point(454, 104)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(92, 29)
        Me.btnNueva.TabIndex = 613
        Me.btnNueva.Text = "&Nueva"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LsView)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 161)
        Me.GroupBox1.TabIndex = 612
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
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
        Me.LsView.Location = New System.Drawing.Point(161, 22)
        Me.LsView.Name = "LsView"
        Me.LsView.ShowItemToolTips = True
        Me.LsView.Size = New System.Drawing.Size(326, 122)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 25)
        Me.Label1.TabIndex = 580
        Me.Label1.Text = "Configuracion previa al armado de lotes"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chip)
        Me.GroupBox4.Controls.Add(Me.chkSonido)
        Me.GroupBox4.Controls.Add(Me.chkDatosAnimales)
        Me.GroupBox4.Controls.Add(Me.chkTareasAnteriores)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(538, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(313, 161)
        Me.GroupBox4.TabIndex = 579
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Que datos desea vizualizar"
        '
        'chip
        '
        Me.chip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chip.Location = New System.Drawing.Point(26, 118)
        Me.chip.Name = "chip"
        Me.chip.Size = New System.Drawing.Size(270, 26)
        Me.chip.TabIndex = 579
        '
        'chkSonido
        '
        Me.chkSonido.AutoSize = True
        Me.chkSonido.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSonido.Location = New System.Drawing.Point(26, 70)
        Me.chkSonido.Name = "chkSonido"
        Me.chkSonido.Size = New System.Drawing.Size(123, 20)
        Me.chkSonido.TabIndex = 578
        Me.chkSonido.Text = "Activar Sonido"
        Me.chkSonido.UseVisualStyleBackColor = True
        '
        'chkDatosAnimales
        '
        Me.chkDatosAnimales.AutoSize = True
        Me.chkDatosAnimales.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatosAnimales.Location = New System.Drawing.Point(26, 18)
        Me.chkDatosAnimales.Name = "chkDatosAnimales"
        Me.chkDatosAnimales.Size = New System.Drawing.Size(127, 20)
        Me.chkDatosAnimales.TabIndex = 576
        Me.chkDatosAnimales.Text = "Datos Animales"
        Me.chkDatosAnimales.UseVisualStyleBackColor = True
        '
        'chkTareasAnteriores
        '
        Me.chkTareasAnteriores.AutoSize = True
        Me.chkTareasAnteriores.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTareasAnteriores.Location = New System.Drawing.Point(26, 44)
        Me.chkTareasAnteriores.Name = "chkTareasAnteriores"
        Me.chkTareasAnteriores.Size = New System.Drawing.Size(144, 20)
        Me.chkTareasAnteriores.TabIndex = 577
        Me.chkTareasAnteriores.Text = "Tareas Anteriores"
        Me.chkTareasAnteriores.UseVisualStyleBackColor = True
        '
        'cboIngresos
        '
        Me.cboIngresos.DisplayMember = "Text"
        Me.cboIngresos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIngresos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIngresos.FormattingEnabled = True
        Me.cboIngresos.ItemHeight = 21
        Me.cboIngresos.Location = New System.Drawing.Point(198, 106)
        Me.cboIngresos.Name = "cboIngresos"
        Me.cboIngresos.Size = New System.Drawing.Size(250, 27)
        Me.cboIngresos.TabIndex = 534
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(22, 109)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(179, 20)
        Me.LabelX3.TabIndex = 533
        Me.LabelX3.Text = "Seleccionar Actividad"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'SerialPort1
        '
        '
        'IUPreviaEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(916, 353)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "IUPreviaEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion Previa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbini As System.Windows.Forms.Label
    Friend WithEvents lbFin As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LsView As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboIngresos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkDatosAnimales As System.Windows.Forms.CheckBox
    Friend WithEvents chkTareasAnteriores As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSonido As System.Windows.Forms.CheckBox
    Friend WithEvents btnNueva As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents chip As System.Windows.Forms.TextBox

End Class
