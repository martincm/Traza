<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUConsultas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnConsulta = New DevComponents.DotNetBar.ButtonX()
        Me.btnExporta2 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnIngresoCat = New DevComponents.DotNetBar.ButtonItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtTotal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dtgvAnimales = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dtgvDetalle = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarFilasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFila = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtColumna = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtValor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtDetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboAgrupacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.cboCategoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtgvCategorias = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.dtgvSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dtgvSexo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtgvEntorado = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtgvCastrado = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtgvPrenado = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboAgrupacion2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtNotas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TreeFiltros = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFila2 = New DevComponents.DotNetBar.Controls.TextBoxX()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dispositivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cruza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.potrero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trazabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasUbicacionActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Errores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgvEdadMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgvEdadMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgvDiasPermMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgvDiasPermMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIdCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dtgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConsulta
        '
        Me.btnConsulta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConsulta.BackColor = System.Drawing.Color.White
        Me.btnConsulta.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnConsulta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Location = New System.Drawing.Point(192, 47)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(89, 21)
        Me.btnConsulta.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnExporta2, Me.btnIngresoCat})
        Me.btnConsulta.SubItemsExpandWidth = 20
        Me.btnConsulta.TabIndex = 526
        Me.btnConsulta.Text = "Consultar"
        '
        'btnExporta2
        '
        Me.btnExporta2.ImagePaddingHorizontal = 8
        Me.btnExporta2.Name = "btnExporta2"
        Me.btnExporta2.Text = "Exportar a excel"
        '
        'btnIngresoCat
        '
        Me.btnIngresoCat.ImagePaddingHorizontal = 8
        Me.btnIngresoCat.Name = "btnIngresoCat"
        Me.btnIngresoCat.Text = "Ingreso Categorias"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(240, 428)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(778, 12)
        Me.ProgressBar1.TabIndex = 527
        '
        'LabelX13
        '
        Me.LabelX13.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(784, 12)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(188, 38)
        Me.LabelX13.TabIndex = 529
        Me.LabelX13.Text = "Consultas de stock"
        Me.LabelX13.WordWrap = True
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(825, 56)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(52, 19)
        Me.LabelX2.TabIndex = 530
        Me.LabelX2.Text = "Stock Al:"
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFecha.ButtonDropDown.Visible = True
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(883, 56)
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
        Me.dtpFecha.TabIndex = 531
        Me.dtpFecha.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Green
        Me.LabelX11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX11.Location = New System.Drawing.Point(842, 447)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(85, 19)
        Me.LabelX11.TabIndex = 545
        Me.LabelX11.Text = "Total"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTotal.Border.Class = "TextBoxBorder"
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(842, 466)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 29)
        Me.txtTotal.TabIndex = 544
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1043, 22)
        Me.StatusStrip1.TabIndex = 546
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dtgvAnimales
        '
        Me.dtgvAnimales.AllowUserToAddRows = False
        Me.dtgvAnimales.AllowUserToOrderColumns = True
        Me.dtgvAnimales.BackgroundColor = System.Drawing.Color.LightGray
        Me.dtgvAnimales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCantidad, Me.dgvCategoria, Me.dgvIdCategoria})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvAnimales.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgvAnimales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgvAnimales.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgvAnimales.Location = New System.Drawing.Point(240, 115)
        Me.dtgvAnimales.Name = "dtgvAnimales"
        Me.dtgvAnimales.ReadOnly = True
        Me.dtgvAnimales.RowHeadersWidth = 5
        Me.dtgvAnimales.Size = New System.Drawing.Size(778, 316)
        Me.dtgvAnimales.TabIndex = 551
        '
        'dtgvDetalle
        '
        Me.dtgvDetalle.AllowUserToAddRows = False
        Me.dtgvDetalle.AllowUserToOrderColumns = True
        Me.dtgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeracion, Me.categoria, Me.dispositivo, Me.raza, Me.cruza, Me.sexo, Me.edad, Me.propietario, Me.ubicacion, Me.tenencia, Me.potrero, Me.vida, Me.trazabilidad, Me.DiasUbicacionActual, Me.IdCategoria, Me.Errores})
        Me.dtgvDetalle.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvDetalle.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgvDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgvDetalle.Location = New System.Drawing.Point(254, 145)
        Me.dtgvDetalle.Name = "dtgvDetalle"
        Me.dtgvDetalle.RowHeadersWidth = 20
        Me.dtgvDetalle.Size = New System.Drawing.Size(740, 254)
        Me.dtgvDetalle.TabIndex = 555
        Me.dtgvDetalle.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarFilasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'CopiarFilasToolStripMenuItem
        '
        Me.CopiarFilasToolStripMenuItem.Name = "CopiarFilasToolStripMenuItem"
        Me.CopiarFilasToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CopiarFilasToolStripMenuItem.Text = "Copiar filas"
        '
        'txtFila
        '
        Me.txtFila.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFila.Border.Class = "TextBoxBorder"
        Me.txtFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFila.Location = New System.Drawing.Point(546, 502)
        Me.txtFila.Name = "txtFila"
        Me.txtFila.ReadOnly = True
        Me.txtFila.Size = New System.Drawing.Size(110, 22)
        Me.txtFila.TabIndex = 557
        Me.txtFila.Visible = False
        '
        'txtColumna
        '
        Me.txtColumna.BackColor = System.Drawing.Color.LightGreen
        '
        '
        '
        Me.txtColumna.Border.Class = "TextBoxBorder"
        Me.txtColumna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColumna.Location = New System.Drawing.Point(430, 502)
        Me.txtColumna.Name = "txtColumna"
        Me.txtColumna.ReadOnly = True
        Me.txtColumna.Size = New System.Drawing.Size(110, 22)
        Me.txtColumna.TabIndex = 558
        Me.txtColumna.Visible = False
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(430, 487)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(110, 10)
        Me.LabelX1.TabIndex = 559
        Me.LabelX1.Text = "Columna"
        Me.LabelX1.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(551, 487)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(81, 10)
        Me.LabelX3.TabIndex = 560
        Me.LabelX3.Text = "Fila"
        Me.LabelX3.Visible = False
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtValor.Border.Class = "TextBoxBorder"
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(689, 482)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(110, 22)
        Me.txtValor.TabIndex = 561
        Me.txtValor.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Green
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX4.Location = New System.Drawing.Point(339, 476)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(85, 19)
        Me.LabelX4.TabIndex = 563
        Me.LabelX4.Text = "Detalle"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX4.Visible = False
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDetalle.Border.Class = "TextBoxBorder"
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(339, 495)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.Size = New System.Drawing.Size(85, 29)
        Me.txtDetalle.TabIndex = 562
        Me.txtDetalle.Text = "0"
        Me.txtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDetalle.Visible = False
        '
        'cboAgrupacion
        '
        Me.cboAgrupacion.DisplayMember = "Text"
        Me.cboAgrupacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAgrupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgrupacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAgrupacion.FormattingEnabled = True
        Me.cboAgrupacion.ItemHeight = 16
        Me.cboAgrupacion.Location = New System.Drawing.Point(115, 19)
        Me.cboAgrupacion.Name = "cboAgrupacion"
        Me.cboAgrupacion.Size = New System.Drawing.Size(153, 22)
        Me.cboAgrupacion.TabIndex = 566
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(20, 19)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(62, 21)
        Me.LabelX7.TabIndex = 567
        Me.LabelX7.Text = "1º Nivel"
        '
        'cboCategoria
        '
        Me.cboCategoria.DisplayMember = "Text"
        Me.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.ItemHeight = 16
        Me.cboCategoria.Location = New System.Drawing.Point(20, 46)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(153, 22)
        Me.cboCategoria.TabIndex = 568
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(20, 24)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(97, 17)
        Me.LabelX5.TabIndex = 569
        Me.LabelX5.Text = "Tipo Categoria"
        '
        'dtgvCategorias
        '
        Me.dtgvCategorias.AllowUserToAddRows = False
        Me.dtgvCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgvSel, Me.dtgvNombre, Me.dtgvSexo, Me.dtgvEdadMin, Me.dtgvEdadMax, Me.dtgvEntorado, Me.dtgvCastrado, Me.dtgvPrenado, Me.dtgvDiasPermMin, Me.dtgvDiasPermMax})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvCategorias.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgvCategorias.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgvCategorias.Location = New System.Drawing.Point(319, 90)
        Me.dtgvCategorias.Name = "dtgvCategorias"
        Me.dtgvCategorias.RowHeadersWidth = 20
        Me.dtgvCategorias.Size = New System.Drawing.Size(716, 185)
        Me.dtgvCategorias.TabIndex = 570
        Me.dtgvCategorias.Visible = False
        '
        'dtgvSel
        '
        Me.dtgvSel.FillWeight = 40.0!
        Me.dtgvSel.HeaderText = "Sel."
        Me.dtgvSel.Name = "dtgvSel"
        Me.dtgvSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgvSel.Width = 40
        '
        'dtgvSexo
        '
        Me.dtgvSexo.FillWeight = 80.0!
        Me.dtgvSexo.HeaderText = "Sexo"
        Me.dtgvSexo.Name = "dtgvSexo"
        Me.dtgvSexo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvSexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgvSexo.Width = 80
        '
        'dtgvEntorado
        '
        Me.dtgvEntorado.FillWeight = 60.0!
        Me.dtgvEntorado.HeaderText = "Entorado"
        Me.dtgvEntorado.Name = "dtgvEntorado"
        Me.dtgvEntorado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvEntorado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgvEntorado.Width = 60
        '
        'dtgvCastrado
        '
        Me.dtgvCastrado.FillWeight = 55.0!
        Me.dtgvCastrado.HeaderText = "Castrado"
        Me.dtgvCastrado.Name = "dtgvCastrado"
        Me.dtgvCastrado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvCastrado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgvCastrado.Width = 55
        '
        'dtgvPrenado
        '
        Me.dtgvPrenado.FillWeight = 55.0!
        Me.dtgvPrenado.HeaderText = "Peñado"
        Me.dtgvPrenado.Name = "dtgvPrenado"
        Me.dtgvPrenado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvPrenado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dtgvPrenado.Width = 55
        '
        'cboAgrupacion2
        '
        Me.cboAgrupacion2.DisplayMember = "Text"
        Me.cboAgrupacion2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAgrupacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgrupacion2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAgrupacion2.FormattingEnabled = True
        Me.cboAgrupacion2.ItemHeight = 16
        Me.cboAgrupacion2.Location = New System.Drawing.Point(115, 47)
        Me.cboAgrupacion2.Name = "cboAgrupacion2"
        Me.cboAgrupacion2.Size = New System.Drawing.Size(153, 22)
        Me.cboAgrupacion2.TabIndex = 571
        '
        'LabelX8
        '
        Me.LabelX8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(20, 48)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(60, 21)
        Me.LabelX8.TabIndex = 572
        Me.LabelX8.Text = "2º Nivel"
        '
        'txtNotas
        '
        Me.txtNotas.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNotas.Border.Class = "TextBoxBorder"
        Me.txtNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.Location = New System.Drawing.Point(206, 446)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ReadOnly = True
        Me.txtNotas.Size = New System.Drawing.Size(545, 35)
        Me.txtNotas.TabIndex = 575
        Me.txtNotas.Visible = False
        '
        'TreeFiltros
        '
        Me.TreeFiltros.CheckBoxes = True
        Me.TreeFiltros.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeFiltros.HideSelection = False
        Me.TreeFiltros.Location = New System.Drawing.Point(10, 21)
        Me.TreeFiltros.Name = "TreeFiltros"
        Me.TreeFiltros.Size = New System.Drawing.Size(200, 269)
        Me.TreeFiltros.TabIndex = 582
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 583
        Me.Button1.Text = "Seleccionar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(739, 493)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.ReadOnly = True
        Me.TextBoxX1.Size = New System.Drawing.Size(60, 22)
        Me.TextBoxX1.TabIndex = 586
        Me.TextBoxX1.Visible = False
        '
        'txtFila2
        '
        Me.txtFila2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFila2.Border.Class = "TextBoxBorder"
        Me.txtFila2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFila2.Location = New System.Drawing.Point(662, 497)
        Me.txtFila2.Name = "txtFila2"
        Me.txtFila2.ReadOnly = True
        Me.txtFila2.Size = New System.Drawing.Size(110, 22)
        Me.txtFila2.TabIndex = 587
        Me.txtFila2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cant"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 30
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 130.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Potreros"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ord."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.FillWeight = 130.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lotes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 130.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nº Disp."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Raza"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 45
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cruza"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 45
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 45
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.FillWeight = 85.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Propietario"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 85
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.FillWeight = 85.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 85
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.FillWeight = 85.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn14.Width = 85
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.FillWeight = 85.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tenencia"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn15.Width = 85
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "Potrero"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn16.Width = 120
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Vida"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 70
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.FillWeight = 85.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Traza"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 85
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn19.HeaderText = "DiasUbica. Actual"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 45
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.FillWeight = 130.0!
        Me.DataGridViewTextBoxColumn20.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 130
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn21.HeaderText = "EdadMin"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 60
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn22.HeaderText = "EdadMax"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn23.HeaderText = "DiasPermMin"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 75
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn24.HeaderText = "DiasPermMax"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 75
        '
        'numeracion
        '
        Me.numeracion.FillWeight = 40.0!
        Me.numeracion.HeaderText = "Ord."
        Me.numeracion.Name = "numeracion"
        Me.numeracion.ReadOnly = True
        Me.numeracion.Width = 40
        '
        'categoria
        '
        Me.categoria.FillWeight = 130.0!
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 130
        '
        'dispositivo
        '
        Me.dispositivo.FillWeight = 140.0!
        Me.dispositivo.HeaderText = "Nº Disp."
        Me.dispositivo.Name = "dispositivo"
        Me.dispositivo.ReadOnly = True
        Me.dispositivo.Width = 140
        '
        'raza
        '
        Me.raza.FillWeight = 45.0!
        Me.raza.HeaderText = "Raza"
        Me.raza.Name = "raza"
        Me.raza.ReadOnly = True
        Me.raza.Width = 45
        '
        'cruza
        '
        Me.cruza.FillWeight = 45.0!
        Me.cruza.HeaderText = "Cruza"
        Me.cruza.Name = "cruza"
        Me.cruza.ReadOnly = True
        Me.cruza.Width = 45
        '
        'sexo
        '
        Me.sexo.FillWeight = 70.0!
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Width = 70
        '
        'edad
        '
        Me.edad.FillWeight = 45.0!
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.Width = 45
        '
        'propietario
        '
        Me.propietario.FillWeight = 85.0!
        Me.propietario.HeaderText = "Propietario"
        Me.propietario.Name = "propietario"
        Me.propietario.ReadOnly = True
        Me.propietario.Width = 85
        '
        'ubicacion
        '
        Me.ubicacion.FillWeight = 85.0!
        Me.ubicacion.HeaderText = "Ubicacion"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        Me.ubicacion.Width = 85
        '
        'tenencia
        '
        Me.tenencia.FillWeight = 85.0!
        Me.tenencia.HeaderText = "Tenencia"
        Me.tenencia.Name = "tenencia"
        Me.tenencia.ReadOnly = True
        Me.tenencia.Width = 85
        '
        'potrero
        '
        Me.potrero.FillWeight = 120.0!
        Me.potrero.HeaderText = "Potrero"
        Me.potrero.Name = "potrero"
        Me.potrero.ReadOnly = True
        Me.potrero.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.potrero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.potrero.Width = 120
        '
        'vida
        '
        Me.vida.FillWeight = 70.0!
        Me.vida.HeaderText = "Vida"
        Me.vida.Name = "vida"
        Me.vida.ReadOnly = True
        Me.vida.Width = 70
        '
        'trazabilidad
        '
        Me.trazabilidad.FillWeight = 85.0!
        Me.trazabilidad.HeaderText = "Trazabilidad"
        Me.trazabilidad.Name = "trazabilidad"
        Me.trazabilidad.ReadOnly = True
        Me.trazabilidad.Width = 85
        '
        'DiasUbicacionActual
        '
        Me.DiasUbicacionActual.HeaderText = "DiasPermanencia"
        Me.DiasUbicacionActual.Name = "DiasUbicacionActual"
        Me.DiasUbicacionActual.ReadOnly = True
        '
        'IdCategoria
        '
        Me.IdCategoria.HeaderText = "IdCategoria"
        Me.IdCategoria.Name = "IdCategoria"
        Me.IdCategoria.ReadOnly = True
        Me.IdCategoria.Visible = False
        '
        'Errores
        '
        Me.Errores.HeaderText = "errores"
        Me.Errores.Name = "Errores"
        '
        'dtgvNombre
        '
        Me.dtgvNombre.FillWeight = 130.0!
        Me.dtgvNombre.HeaderText = "Categoria"
        Me.dtgvNombre.Name = "dtgvNombre"
        Me.dtgvNombre.Width = 130
        '
        'dtgvEdadMin
        '
        Me.dtgvEdadMin.FillWeight = 60.0!
        Me.dtgvEdadMin.HeaderText = "EdadMin"
        Me.dtgvEdadMin.Name = "dtgvEdadMin"
        Me.dtgvEdadMin.Width = 60
        '
        'dtgvEdadMax
        '
        Me.dtgvEdadMax.FillWeight = 60.0!
        Me.dtgvEdadMax.HeaderText = "EdadMax"
        Me.dtgvEdadMax.Name = "dtgvEdadMax"
        Me.dtgvEdadMax.Width = 60
        '
        'dtgvDiasPermMin
        '
        Me.dtgvDiasPermMin.FillWeight = 75.0!
        Me.dtgvDiasPermMin.HeaderText = "DiasPermMin"
        Me.dtgvDiasPermMin.Name = "dtgvDiasPermMin"
        Me.dtgvDiasPermMin.Width = 75
        '
        'dtgvDiasPermMax
        '
        Me.dtgvDiasPermMax.FillWeight = 75.0!
        Me.dtgvDiasPermMax.HeaderText = "DiasPermMax"
        Me.dtgvDiasPermMax.Name = "dtgvDiasPermMax"
        Me.dtgvDiasPermMax.Width = 75
        '
        'dgvCantidad
        '
        Me.dgvCantidad.FillWeight = 60.0!
        Me.dgvCantidad.HeaderText = "Uni."
        Me.dgvCantidad.Name = "dgvCantidad"
        Me.dgvCantidad.ReadOnly = True
        Me.dgvCantidad.Width = 60
        '
        'dgvCategoria
        '
        Me.dgvCategoria.FillWeight = 250.0!
        Me.dgvCategoria.HeaderText = "Categorias"
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.ReadOnly = True
        Me.dgvCategoria.Width = 250
        '
        'dgvIdCategoria
        '
        Me.dgvIdCategoria.HeaderText = "IdCategorias"
        Me.dgvIdCategoria.Name = "dgvIdCategoria"
        Me.dgvIdCategoria.ReadOnly = True
        Me.dgvIdCategoria.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.FillWeight = 130.0!
        Me.DataGridViewTextBoxColumn25.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 130
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn26.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 75
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn27.HeaderText = "Animales"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 60
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.FillWeight = 90.0!
        Me.DataGridViewTextBoxColumn28.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAgrupacion2)
        Me.GroupBox1.Controls.Add(Me.cboAgrupacion)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 86)
        Me.GroupBox1.TabIndex = 588
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agrupamientos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Controls.Add(Me.cboCategoria)
        Me.GroupBox2.Controls.Add(Me.btnConsulta)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 86)
        Me.GroupBox2.TabIndex = 589
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorias"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TreeFiltros)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 325)
        Me.GroupBox3.TabIndex = 590
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtros"
        '
        'IUConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1043, 540)
        Me.Controls.Add(Me.dtgvCategorias)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFila2)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.dtgvDetalle)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtColumna)
        Me.Controls.Add(Me.txtFila)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.dtgvAnimales)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelX11)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.LabelX13)
        Me.MaximizeBox = False
        Me.Name = "IUConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas de stock "
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dtgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsulta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents dtgvAnimales As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgvDetalle As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvIdCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtFila As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtColumna As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtValor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboAgrupacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents numeracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dispositivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents raza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cruza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents propietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tenencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents potrero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trazabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasUbicacionActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Errores As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarFilasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboCategoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtgvCategorias As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExporta2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents dtgvSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dtgvNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgvSexo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dtgvEdadMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgvEdadMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgvEntorado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dtgvCastrado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dtgvPrenado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dtgvDiasPermMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgvDiasPermMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnIngresoCat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cboAgrupacion2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNotas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreeFiltros As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFila2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
