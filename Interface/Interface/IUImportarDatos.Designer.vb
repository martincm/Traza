<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUImportarDatos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUImportarDatos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.btnImportar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaArchivo = New System.Windows.Forms.DateTimePicker()
        Me.txtIngresos = New System.Windows.Forms.TextBox()
        Me.txtActualiza = New System.Windows.Forms.TextBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TextPathExcel = New System.Windows.Forms.TextBox()
        Me.TextHoja = New System.Windows.Forms.TextBox()
        Me.hiloSegundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1011, 400)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 305)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Importados Excel"
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeight = 20
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGrid.Location = New System.Drawing.Point(6, 19)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersWidth = 20
        Me.DataGrid.Size = New System.Drawing.Size(569, 257)
        Me.DataGrid.TabIndex = 139
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbStatus)
        Me.GroupBox4.Controls.Add(Me.ProgressBar1)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.LabelX4)
        Me.GroupBox4.Controls.Add(Me.ButtonX1)
        Me.GroupBox4.Controls.Add(Me.LabelX3)
        Me.GroupBox4.Controls.Add(Me.TextPathExcel)
        Me.GroupBox4.Controls.Add(Me.TextHoja)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 31)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(383, 305)
        Me.GroupBox4.TabIndex = 142
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Importar Datos Excel"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(6, 257)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(97, 13)
        Me.lbStatus.TabIndex = 555
        Me.lbStatus.Text = "Espere por Favor..."
        Me.lbStatus.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 273)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(356, 23)
        Me.ProgressBar1.TabIndex = 144
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelX6)
        Me.GroupBox3.Controls.Add(Me.btnImportar)
        Me.GroupBox3.Controls.Add(Me.LabelX5)
        Me.GroupBox3.Controls.Add(Me.dtpFechaArchivo)
        Me.GroupBox3.Controls.Add(Me.txtIngresos)
        Me.GroupBox3.Controls.Add(Me.txtActualiza)
        Me.GroupBox3.Controls.Add(Me.LabelX2)
        Me.GroupBox3.Controls.Add(Me.txtPropietario)
        Me.GroupBox3.Controls.Add(Me.LabelX1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 144)
        Me.GroupBox3.TabIndex = 554
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion Archivo Excel"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(85, 93)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(52, 19)
        Me.LabelX6.TabIndex = 557
        Me.LabelX6.Text = "Ingresos"
        '
        'btnImportar
        '
        Me.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnImportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImportar.Location = New System.Drawing.Point(243, 102)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(100, 30)
        Me.btnImportar.TabIndex = 552
        Me.btnImportar.Text = "&Importar"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(15, 93)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(52, 19)
        Me.LabelX5.TabIndex = 555
        Me.LabelX5.Text = "Actuliza"
        '
        'dtpFechaArchivo
        '
        Me.dtpFechaArchivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaArchivo.Location = New System.Drawing.Point(107, 58)
        Me.dtpFechaArchivo.Name = "dtpFechaArchivo"
        Me.dtpFechaArchivo.Size = New System.Drawing.Size(236, 21)
        Me.dtpFechaArchivo.TabIndex = 549
        '
        'txtIngresos
        '
        Me.txtIngresos.BackColor = System.Drawing.Color.White
        Me.txtIngresos.Location = New System.Drawing.Point(85, 112)
        Me.txtIngresos.Name = "txtIngresos"
        Me.txtIngresos.ReadOnly = True
        Me.txtIngresos.Size = New System.Drawing.Size(52, 20)
        Me.txtIngresos.TabIndex = 556
        '
        'txtActualiza
        '
        Me.txtActualiza.BackColor = System.Drawing.Color.White
        Me.txtActualiza.Location = New System.Drawing.Point(15, 113)
        Me.txtActualiza.Name = "txtActualiza"
        Me.txtActualiza.ReadOnly = True
        Me.txtActualiza.Size = New System.Drawing.Size(52, 20)
        Me.txtActualiza.TabIndex = 555
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(13, 28)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(124, 19)
        Me.LabelX2.TabIndex = 543
        Me.LabelX2.Text = "Dicose Propietario:"
        '
        'txtPropietario
        '
        Me.txtPropietario.BackColor = System.Drawing.Color.White
        Me.txtPropietario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.Location = New System.Drawing.Point(143, 24)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.ReadOnly = True
        Me.txtPropietario.Size = New System.Drawing.Size(119, 27)
        Me.txtPropietario.TabIndex = 544
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(13, 60)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(88, 19)
        Me.LabelX1.TabIndex = 545
        Me.LabelX1.Text = "Fecha Archivo"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(6, 58)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(37, 19)
        Me.LabelX4.TabIndex = 553
        Me.LabelX4.Text = "Hoja:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(294, 26)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(49, 23)
        Me.ButtonX1.TabIndex = 552
        Me.ButtonX1.Text = "...."
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(6, 28)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(85, 19)
        Me.LabelX3.TabIndex = 550
        Me.LabelX3.Text = "Ruta Archivo"
        '
        'TextPathExcel
        '
        Me.TextPathExcel.BackColor = System.Drawing.Color.White
        Me.TextPathExcel.Location = New System.Drawing.Point(97, 27)
        Me.TextPathExcel.Name = "TextPathExcel"
        Me.TextPathExcel.ReadOnly = True
        Me.TextPathExcel.Size = New System.Drawing.Size(189, 20)
        Me.TextPathExcel.TabIndex = 116
        '
        'TextHoja
        '
        Me.TextHoja.BackColor = System.Drawing.Color.White
        Me.TextHoja.Location = New System.Drawing.Point(97, 53)
        Me.TextHoja.Name = "TextHoja"
        Me.TextHoja.ReadOnly = True
        Me.TextHoja.Size = New System.Drawing.Size(189, 20)
        Me.TextHoja.TabIndex = 118
        '
        'hiloSegundoPlano
        '
        Me.hiloSegundoPlano.WorkerReportsProgress = True
        Me.hiloSegundoPlano.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(55, 349)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(893, 44)
        Me.LabelX7.TabIndex = 544
        Me.LabelX7.Text = resources.GetString("LabelX7.Text")
        Me.LabelX7.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'IUImportarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1035, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IUImportarDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Trazabilidad - Importar Animales al sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextPathExcel As System.Windows.Forms.TextBox
    Friend WithEvents TextHoja As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaArchivo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIngresos As System.Windows.Forms.TextBox
    Friend WithEvents txtActualiza As System.Windows.Forms.TextBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents hiloSegundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
