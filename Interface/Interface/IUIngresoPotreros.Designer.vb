<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUIngresoPotreros
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
        Me.dtpFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtNombrePotrero = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboTenencia = New System.Windows.Forms.ComboBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtDetalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtSuelo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSuperficieTotal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSuperficieinutilizada = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dtgvCaravanas = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caravana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtgvCaravanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFecha.ButtonDropDown.Visible = True
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(487, 275)
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
        Me.dtpFecha.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'txtGuardar
        '
        Me.txtGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.txtGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.txtGuardar.Location = New System.Drawing.Point(539, 63)
        Me.txtGuardar.Name = "txtGuardar"
        Me.txtGuardar.Size = New System.Drawing.Size(95, 23)
        Me.txtGuardar.TabIndex = 458
        Me.txtGuardar.Text = "Guardar"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Green
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX4.Location = New System.Drawing.Point(20, 63)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(153, 26)
        Me.LabelX4.TabIndex = 461
        Me.LabelX4.Text = "Nombre del Potrero"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Green
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX5.Location = New System.Drawing.Point(420, 275)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(65, 22)
        Me.LabelX5.TabIndex = 467
        Me.LabelX5.Text = "FECHA"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtNombrePotrero
        '
        Me.txtNombrePotrero.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombrePotrero.Border.Class = "TextBoxBorder"
        Me.txtNombrePotrero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePotrero.Location = New System.Drawing.Point(190, 63)
        Me.txtNombrePotrero.Name = "txtNombrePotrero"
        Me.txtNombrePotrero.Size = New System.Drawing.Size(229, 26)
        Me.txtNombrePotrero.TabIndex = 469
        Me.txtNombrePotrero.Text = "La Aguada"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTenencia)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtDetalle)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.txtSuelo)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 143)
        Me.GroupBox1.TabIndex = 471
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Suelo"
        '
        'cboTenencia
        '
        Me.cboTenencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTenencia.FormattingEnabled = True
        Me.cboTenencia.Location = New System.Drawing.Point(133, 97)
        Me.cboTenencia.Name = "cboTenencia"
        Me.cboTenencia.Size = New System.Drawing.Size(179, 21)
        Me.cboTenencia.TabIndex = 474
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX1.Location = New System.Drawing.Point(15, 97)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(112, 19)
        Me.LabelX1.TabIndex = 473
        Me.LabelX1.Text = "Tenencia"
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDetalle.Border.Class = "TextBoxBorder"
        Me.txtDetalle.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(133, 63)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(330, 23)
        Me.txtDetalle.TabIndex = 472
        Me.txtDetalle.Text = "Praderas de primer año"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        '
        '
        '
        Me.LabelX3.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX3.Location = New System.Drawing.Point(15, 27)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(112, 19)
        Me.LabelX3.TabIndex = 471
        Me.LabelX3.Text = "Uso de Suelo"
        '
        'txtSuelo
        '
        Me.txtSuelo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSuelo.Border.Class = "TextBoxBorder"
        Me.txtSuelo.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuelo.Location = New System.Drawing.Point(133, 26)
        Me.txtSuelo.Name = "txtSuelo"
        Me.txtSuelo.Size = New System.Drawing.Size(330, 23)
        Me.txtSuelo.TabIndex = 470
        Me.txtSuelo.Text = "Praderas artificiales permanentes"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX2.Location = New System.Drawing.Point(15, 63)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(112, 19)
        Me.LabelX2.TabIndex = 463
        Me.LabelX2.Text = "Detalle"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(692, 400)
        Me.TabControl1.TabIndex = 472
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.ButtonX1)
        Me.TabPage1.Controls.Add(Me.LabelX14)
        Me.TabPage1.Controls.Add(Me.txtSuperficieTotal)
        Me.TabPage1.Controls.Add(Me.txtSuperficieinutilizada)
        Me.TabPage1.Controls.Add(Me.LabelX7)
        Me.TabPage1.Controls.Add(Me.LabelX6)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtNombrePotrero)
        Me.TabPage1.Controls.Add(Me.LabelX5)
        Me.TabPage1.Controls.Add(Me.LabelX4)
        Me.TabPage1.Controls.Add(Me.dtpFecha)
        Me.TabPage1.Controls.Add(Me.txtGuardar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(684, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Potrero"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSuperficieTotal
        '
        Me.txtSuperficieTotal.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSuperficieTotal.Border.Class = "TextBoxBorder"
        Me.txtSuperficieTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuperficieTotal.Location = New System.Drawing.Point(190, 275)
        Me.txtSuperficieTotal.Name = "txtSuperficieTotal"
        Me.txtSuperficieTotal.Size = New System.Drawing.Size(81, 26)
        Me.txtSuperficieTotal.TabIndex = 476
        Me.txtSuperficieTotal.Text = "108"
        Me.txtSuperficieTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSuperficieinutilizada
        '
        Me.txtSuperficieinutilizada.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSuperficieinutilizada.Border.Class = "TextBoxBorder"
        Me.txtSuperficieinutilizada.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuperficieinutilizada.Location = New System.Drawing.Point(190, 307)
        Me.txtSuperficieinutilizada.Name = "txtSuperficieinutilizada"
        Me.txtSuperficieinutilizada.Size = New System.Drawing.Size(81, 26)
        Me.txtSuperficieinutilizada.TabIndex = 475
        Me.txtSuperficieinutilizada.Text = "23"
        Me.txtSuperficieinutilizada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX7.Location = New System.Drawing.Point(20, 314)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(164, 19)
        Me.LabelX7.TabIndex = 473
        Me.LabelX7.Text = "Superficie Inutilizada (Has)"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX6.Location = New System.Drawing.Point(20, 282)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(136, 19)
        Me.LabelX6.TabIndex = 472
        Me.LabelX6.Text = "Superficie Total (Has) "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBoxX7)
        Me.TabPage2.Controls.Add(Me.TextBoxX6)
        Me.TabPage2.Controls.Add(Me.LabelX8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(684, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mejoramientos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBoxX7
        '
        Me.TextBoxX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX7.Location = New System.Drawing.Point(49, 76)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.Size = New System.Drawing.Size(196, 80)
        Me.TextBoxX7.TabIndex = 472
        Me.TextBoxX7.Text = "02269"
        Me.TextBoxX7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxX6
        '
        Me.TextBoxX6.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX6.Border.Class = "TextBoxBorder"
        Me.TextBoxX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX6.Location = New System.Drawing.Point(20, 162)
        Me.TextBoxX6.Name = "TextBoxX6"
        Me.TextBoxX6.Size = New System.Drawing.Size(257, 116)
        Me.TextBoxX6.TabIndex = 471
        Me.TextBoxX6.Text = "8658"
        Me.TextBoxX6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Green
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX8.Location = New System.Drawing.Point(49, 44)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(196, 26)
        Me.LabelX8.TabIndex = 462
        Me.LabelX8.Text = "Nº Dispositivo"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dtgvCaravanas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(684, 374)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Animales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dtgvCaravanas
        '
        Me.dtgvCaravanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvCaravanas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.fecha, Me.caravana, Me.evento, Me.lote})
        Me.dtgvCaravanas.Location = New System.Drawing.Point(17, 23)
        Me.dtgvCaravanas.Name = "dtgvCaravanas"
        Me.dtgvCaravanas.Size = New System.Drawing.Size(539, 323)
        Me.dtgvCaravanas.TabIndex = 472
        '
        'chk
        '
        Me.chk.FillWeight = 50.0!
        Me.chk.HeaderText = "    *"
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk.Width = 50
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.ForestGreen
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX14.Location = New System.Drawing.Point(563, 6)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(95, 21)
        Me.LabelX14.TabIndex = 502
        Me.LabelX14.Text = "Nº CODIGO"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(435, 63)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(98, 23)
        Me.ButtonX1.TabIndex = 529
        Me.ButtonX1.Text = "&Nuevo"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Caravana"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Evento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'caravana
        '
        Me.caravana.HeaderText = "Caravana"
        Me.caravana.Name = "caravana"
        Me.caravana.ReadOnly = True
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.ReadOnly = True
        '
        'lote
        '
        Me.lote.HeaderText = "Lote"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
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
        Me.txtCodigo.Location = New System.Drawing.Point(563, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(95, 29)
        Me.txtCodigo.TabIndex = 530
        Me.txtCodigo.Text = "1"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigo.WatermarkColor = System.Drawing.SystemColors.ControlLightLight
        '
        'IUIngresoPotreros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(727, 424)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "IUIngresoPotreros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IUIngresoPotreros"
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dtgvCaravanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNombrePotrero As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDetalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSuelo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cboTenencia As System.Windows.Forms.ComboBox
    Friend WithEvents txtSuperficieTotal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSuperficieinutilizada As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dtgvCaravanas As System.Windows.Forms.DataGridView
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents caravana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
