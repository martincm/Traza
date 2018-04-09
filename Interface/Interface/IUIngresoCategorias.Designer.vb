<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUIngresoCategorias
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LsView = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hiloSegundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.tabCategorias = New System.Windows.Forms.TabPage()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.cboSexo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cboEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.cboPrenado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.cboCastrado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.cboEntorado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.NudMaximo = New System.Windows.Forms.NumericUpDown()
        Me.NudMinimo = New System.Windows.Forms.NumericUpDown()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtCodigoEventos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.cboGruposEventos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboMedidaEventos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.txtFoneticaEventos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombreEvento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.btnNuevoEventos = New DevComponents.DotNetBar.ButtonX()
        Me.btnGuardarEventos = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.NudMaximoPerm = New System.Windows.Forms.NumericUpDown()
        Me.NudMinimoPerm = New System.Windows.Forms.NumericUpDown()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2.SuspendLayout()
        Me.tabCategorias.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NudMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NudMaximoPerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMinimoPerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LsView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(905, 259)
        Me.GroupBox2.TabIndex = 474
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorias"
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
        Me.LsView.Location = New System.Drawing.Point(15, 19)
        Me.LsView.Name = "LsView"
        Me.LsView.ShowItemToolTips = True
        Me.LsView.Size = New System.Drawing.Size(876, 226)
        Me.LsView.TabIndex = 99
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
        'hiloSegundoPlano
        '
        Me.hiloSegundoPlano.WorkerReportsProgress = True
        Me.hiloSegundoPlano.WorkerSupportsCancellation = True
        '
        'tabCategorias
        '
        Me.tabCategorias.Controls.Add(Me.txtCodigo)
        Me.tabCategorias.Controls.Add(Me.LabelX14)
        Me.tabCategorias.Controls.Add(Me.GroupBox1)
        Me.tabCategorias.Controls.Add(Me.LabelX5)
        Me.tabCategorias.Controls.Add(Me.dtpFecha)
        Me.tabCategorias.Location = New System.Drawing.Point(4, 22)
        Me.tabCategorias.Name = "tabCategorias"
        Me.tabCategorias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCategorias.Size = New System.Drawing.Size(899, 243)
        Me.tabCategorias.TabIndex = 0
        Me.tabCategorias.Text = "Categorias"
        Me.tabCategorias.UseVisualStyleBackColor = True
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
        Me.txtCodigo.Location = New System.Drawing.Point(790, 38)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(95, 29)
        Me.txtCodigo.TabIndex = 501
        Me.txtCodigo.Text = "1"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigo.WatermarkColor = System.Drawing.SystemColors.ControlLightLight
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.ForestGreen
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX14.Location = New System.Drawing.Point(790, 11)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(95, 21)
        Me.LabelX14.TabIndex = 500
        Me.LabelX14.Text = "Nº CODIGO"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX17)
        Me.GroupBox1.Controls.Add(Me.NudMaximoPerm)
        Me.GroupBox1.Controls.Add(Me.NudMinimoPerm)
        Me.GroupBox1.Controls.Add(Me.LabelX18)
        Me.GroupBox1.Controls.Add(Me.LabelX16)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.cboSexo)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.cboEstado)
        Me.GroupBox1.Controls.Add(Me.cboTipo)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.cboPrenado)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.cboCastrado)
        Me.GroupBox1.Controls.Add(Me.txtGuardar)
        Me.GroupBox1.Controls.Add(Me.cboEntorado)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.NudMaximo)
        Me.GroupBox1.Controls.Add(Me.NudMinimo)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 225)
        Me.GroupBox1.TabIndex = 471
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(99, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(290, 27)
        Me.txtNombre.TabIndex = 530
        Me.txtNombre.Text = "253001"
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(15, 116)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(53, 20)
        Me.LabelX7.TabIndex = 529
        Me.LabelX7.Text = "Sexo"
        '
        'cboSexo
        '
        Me.cboSexo.DisplayMember = "Text"
        Me.cboSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.ItemHeight = 16
        Me.cboSexo.Location = New System.Drawing.Point(99, 116)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(137, 22)
        Me.cboSexo.TabIndex = 528
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(405, 26)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(98, 23)
        Me.ButtonX1.TabIndex = 528
        Me.ButtonX1.Text = "&Nuevo"
        '
        'LabelX6
        '
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(251, 87)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(53, 20)
        Me.LabelX6.TabIndex = 527
        Me.LabelX6.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.DisplayMember = "Text"
        Me.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.ItemHeight = 16
        Me.cboEstado.Location = New System.Drawing.Point(310, 87)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(106, 22)
        Me.cboEstado.TabIndex = 526
        '
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 16
        Me.cboTipo.Location = New System.Drawing.Point(99, 87)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(137, 22)
        Me.cboTipo.TabIndex = 525
        '
        'LabelX10
        '
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(15, 197)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(78, 20)
        Me.LabelX10.TabIndex = 524
        Me.LabelX10.Text = "Preñado"
        '
        'cboPrenado
        '
        Me.cboPrenado.DisplayMember = "Text"
        Me.cboPrenado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPrenado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrenado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrenado.FormattingEnabled = True
        Me.cboPrenado.ItemHeight = 16
        Me.cboPrenado.Location = New System.Drawing.Point(99, 197)
        Me.cboPrenado.Name = "cboPrenado"
        Me.cboPrenado.Size = New System.Drawing.Size(92, 22)
        Me.cboPrenado.TabIndex = 523
        '
        'LabelX9
        '
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(15, 171)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(78, 20)
        Me.LabelX9.TabIndex = 522
        Me.LabelX9.Text = "Castrado"
        '
        'cboCastrado
        '
        Me.cboCastrado.DisplayMember = "Text"
        Me.cboCastrado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCastrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCastrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCastrado.FormattingEnabled = True
        Me.cboCastrado.ItemHeight = 16
        Me.cboCastrado.Location = New System.Drawing.Point(99, 171)
        Me.cboCastrado.Name = "cboCastrado"
        Me.cboCastrado.Size = New System.Drawing.Size(92, 22)
        Me.cboCastrado.TabIndex = 521
        '
        'txtGuardar
        '
        Me.txtGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.txtGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.txtGuardar.Location = New System.Drawing.Point(509, 26)
        Me.txtGuardar.Name = "txtGuardar"
        Me.txtGuardar.Size = New System.Drawing.Size(98, 23)
        Me.txtGuardar.TabIndex = 458
        Me.txtGuardar.Text = "&Guardar"
        '
        'cboEntorado
        '
        Me.cboEntorado.DisplayMember = "Text"
        Me.cboEntorado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEntorado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntorado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEntorado.FormattingEnabled = True
        Me.cboEntorado.ItemHeight = 16
        Me.cboEntorado.Location = New System.Drawing.Point(99, 143)
        Me.cboEntorado.Name = "cboEntorado"
        Me.cboEntorado.Size = New System.Drawing.Size(92, 22)
        Me.cboEntorado.TabIndex = 520
        '
        'LabelX8
        '
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(158, 58)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(78, 20)
        Me.LabelX8.TabIndex = 519
        Me.LabelX8.Text = "Edad Maxima"
        '
        'NudMaximo
        '
        Me.NudMaximo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMaximo.Location = New System.Drawing.Point(242, 58)
        Me.NudMaximo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudMaximo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMaximo.Name = "NudMaximo"
        Me.NudMaximo.Size = New System.Drawing.Size(53, 22)
        Me.NudMaximo.TabIndex = 518
        Me.NudMaximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudMinimo
        '
        Me.NudMinimo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMinimo.Location = New System.Drawing.Point(99, 58)
        Me.NudMinimo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudMinimo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMinimo.Name = "NudMinimo"
        Me.NudMinimo.Size = New System.Drawing.Size(53, 22)
        Me.NudMinimo.TabIndex = 517
        Me.NudMinimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(15, 146)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(78, 20)
        Me.LabelX2.TabIndex = 516
        Me.LabelX2.Text = "Entorado"
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(15, 87)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(78, 20)
        Me.LabelX3.TabIndex = 515
        Me.LabelX3.Text = "Tipo"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(15, 58)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(78, 20)
        Me.LabelX1.TabIndex = 512
        Me.LabelX1.Text = "Edad Minima"
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(15, 29)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(78, 20)
        Me.LabelX4.TabIndex = 511
        Me.LabelX4.Text = "Nombre"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Green
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX5.Location = New System.Drawing.Point(729, 89)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(65, 22)
        Me.LabelX5.TabIndex = 467
        Me.LabelX5.Text = "FECHA"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX5.Visible = False
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFecha.ButtonDropDown.Visible = True
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(796, 89)
        '
        '
        '
        Me.dtpFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpFecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFecha.MonthCalendar.DisplayMonth = New Date(2010, 9, 1, 0, 0, 0, 0)
        Me.dtpFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFecha.MonthCalendar.TodayButtonVisible = True
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(89, 22)
        Me.dtpFecha.TabIndex = 455
        Me.dtpFecha.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Visible = False
        Me.dtpFecha.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCategorias)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(907, 269)
        Me.TabControl1.TabIndex = 472
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtCodigoEventos)
        Me.TabPage2.Controls.Add(Me.LabelX13)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(899, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Eventos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtCodigoEventos
        '
        Me.txtCodigoEventos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCodigoEventos.Border.Class = "TextBoxBorder"
        Me.txtCodigoEventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoEventos.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoEventos.Location = New System.Drawing.Point(788, 35)
        Me.txtCodigoEventos.Name = "txtCodigoEventos"
        Me.txtCodigoEventos.ReadOnly = True
        Me.txtCodigoEventos.Size = New System.Drawing.Size(95, 29)
        Me.txtCodigoEventos.TabIndex = 503
        Me.txtCodigoEventos.Text = "1"
        Me.txtCodigoEventos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigoEventos.WatermarkColor = System.Drawing.SystemColors.ControlLightLight
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.ForestGreen
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX13.Location = New System.Drawing.Point(788, 8)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(95, 21)
        Me.LabelX13.TabIndex = 502
        Me.LabelX13.Text = "Nº CODIGO"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelX15)
        Me.GroupBox3.Controls.Add(Me.cboGruposEventos)
        Me.GroupBox3.Controls.Add(Me.cboMedidaEventos)
        Me.GroupBox3.Controls.Add(Me.LabelX12)
        Me.GroupBox3.Controls.Add(Me.txtFoneticaEventos)
        Me.GroupBox3.Controls.Add(Me.txtNombreEvento)
        Me.GroupBox3.Controls.Add(Me.LabelX11)
        Me.GroupBox3.Controls.Add(Me.btnNuevoEventos)
        Me.GroupBox3.Controls.Add(Me.btnGuardarEventos)
        Me.GroupBox3.Controls.Add(Me.LabelX19)
        Me.GroupBox3.Controls.Add(Me.LabelX20)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(674, 173)
        Me.GroupBox3.TabIndex = 472
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion"
        '
        'LabelX15
        '
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(15, 95)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(84, 20)
        Me.LabelX15.TabIndex = 536
        Me.LabelX15.Text = "Grupo"
        '
        'cboGruposEventos
        '
        Me.cboGruposEventos.DisplayMember = "Text"
        Me.cboGruposEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGruposEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGruposEventos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGruposEventos.FormattingEnabled = True
        Me.cboGruposEventos.ItemHeight = 16
        Me.cboGruposEventos.Location = New System.Drawing.Point(109, 93)
        Me.cboGruposEventos.Name = "cboGruposEventos"
        Me.cboGruposEventos.Size = New System.Drawing.Size(152, 22)
        Me.cboGruposEventos.TabIndex = 535
        '
        'cboMedidaEventos
        '
        Me.cboMedidaEventos.DisplayMember = "Text"
        Me.cboMedidaEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMedidaEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedidaEventos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedidaEventos.FormattingEnabled = True
        Me.cboMedidaEventos.ItemHeight = 16
        Me.cboMedidaEventos.Location = New System.Drawing.Point(109, 121)
        Me.cboMedidaEventos.Name = "cboMedidaEventos"
        Me.cboMedidaEventos.Size = New System.Drawing.Size(99, 22)
        Me.cboMedidaEventos.TabIndex = 534
        '
        'LabelX12
        '
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(322, 65)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(214, 20)
        Me.LabelX12.TabIndex = 532
        Me.LabelX12.Text = "* Solo para el reconocimiento de voz"
        '
        'txtFoneticaEventos
        '
        Me.txtFoneticaEventos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFoneticaEventos.Border.Class = "TextBoxBorder"
        Me.txtFoneticaEventos.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoneticaEventos.Location = New System.Drawing.Point(109, 60)
        Me.txtFoneticaEventos.Name = "txtFoneticaEventos"
        Me.txtFoneticaEventos.Size = New System.Drawing.Size(207, 27)
        Me.txtFoneticaEventos.TabIndex = 531
        Me.txtFoneticaEventos.Text = "fardo"
        '
        'txtNombreEvento
        '
        Me.txtNombreEvento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreEvento.Border.Class = "TextBoxBorder"
        Me.txtNombreEvento.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEvento.Location = New System.Drawing.Point(109, 27)
        Me.txtNombreEvento.Name = "txtNombreEvento"
        Me.txtNombreEvento.Size = New System.Drawing.Size(290, 27)
        Me.txtNombreEvento.TabIndex = 530
        Me.txtNombreEvento.Text = "Fardo"
        '
        'LabelX11
        '
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(15, 121)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(84, 20)
        Me.LabelX11.TabIndex = 529
        Me.LabelX11.Text = "Unidad Medida"
        '
        'btnNuevoEventos
        '
        Me.btnNuevoEventos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoEventos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevoEventos.Location = New System.Drawing.Point(415, 19)
        Me.btnNuevoEventos.Name = "btnNuevoEventos"
        Me.btnNuevoEventos.Size = New System.Drawing.Size(98, 23)
        Me.btnNuevoEventos.TabIndex = 528
        Me.btnNuevoEventos.Text = "&Nuevo"
        '
        'btnGuardarEventos
        '
        Me.btnGuardarEventos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardarEventos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardarEventos.Location = New System.Drawing.Point(519, 19)
        Me.btnGuardarEventos.Name = "btnGuardarEventos"
        Me.btnGuardarEventos.Size = New System.Drawing.Size(98, 23)
        Me.btnGuardarEventos.TabIndex = 458
        Me.btnGuardarEventos.Text = "&Guardar"
        '
        'LabelX19
        '
        Me.LabelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.Location = New System.Drawing.Point(15, 65)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(53, 20)
        Me.LabelX19.TabIndex = 512
        Me.LabelX19.Text = "Fonetica"
        '
        'LabelX20
        '
        Me.LabelX20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.Location = New System.Drawing.Point(15, 29)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(53, 20)
        Me.LabelX20.TabIndex = 511
        Me.LabelX20.Text = "Nombre"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "EdadMin"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "EdadMax"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Entorado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Castrado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Preñado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'LabelX16
        '
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.Location = New System.Drawing.Point(304, 120)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(123, 20)
        Me.LabelX16.TabIndex = 531
        Me.LabelX16.Text = "Dias Permanencia"
        '
        'LabelX17
        '
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(345, 146)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(48, 20)
        Me.LabelX17.TabIndex = 536
        Me.LabelX17.Text = "Maximo"
        '
        'NudMaximoPerm
        '
        Me.NudMaximoPerm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMaximoPerm.Location = New System.Drawing.Point(396, 146)
        Me.NudMaximoPerm.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudMaximoPerm.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMaximoPerm.Name = "NudMaximoPerm"
        Me.NudMaximoPerm.Size = New System.Drawing.Size(53, 22)
        Me.NudMaximoPerm.TabIndex = 535
        Me.NudMaximoPerm.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudMinimoPerm
        '
        Me.NudMinimoPerm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMinimoPerm.Location = New System.Drawing.Point(286, 146)
        Me.NudMinimoPerm.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudMinimoPerm.Name = "NudMinimoPerm"
        Me.NudMinimoPerm.Size = New System.Drawing.Size(53, 22)
        Me.NudMinimoPerm.TabIndex = 534
        '
        'LabelX18
        '
        Me.LabelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.Location = New System.Drawing.Point(241, 146)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(49, 20)
        Me.LabelX18.TabIndex = 533
        Me.LabelX18.Text = "Minimo"
        '
        'IUIngresoCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(938, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "IUIngresoCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IUIngresoCategorias"
        Me.GroupBox2.ResumeLayout(False)
        Me.tabCategorias.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NudMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NudMaximoPerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMinimoPerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents hiloSegundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabCategorias As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSexo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboPrenado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCastrado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboEntorado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NudMaximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudMinimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMedidaEventos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFoneticaEventos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNombreEvento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNuevoEventos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGuardarEventos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigoEventos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboGruposEventos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LsView As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NudMaximoPerm As System.Windows.Forms.NumericUpDown
    Friend WithEvents NudMinimoPerm As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
End Class
