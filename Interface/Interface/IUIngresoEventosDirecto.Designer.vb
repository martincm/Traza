<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUIngresoEventosDirecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUIngresoEventosDirecto))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.DtpFechaDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtDispositivo = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Lsnumeros = New System.Windows.Forms.ListBox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.chkDispositivo = New System.Windows.Forms.CheckBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtCruza = New System.Windows.Forms.TextBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtTenencia = New System.Windows.Forms.TextBox()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtVida = New System.Windows.Forms.TextBox()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.txtTraza = New System.Windows.Forms.TextBox()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txtPotrero = New System.Windows.Forms.TextBox()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.txtPesoNac = New System.Windows.Forms.TextBox()
        Me.txtEntorado = New System.Windows.Forms.TextBox()
        Me.txtCastrado = New System.Windows.Forms.TextBox()
        Me.txtPrenado = New System.Windows.Forms.TextBox()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.txtDicoseNac = New System.Windows.Forms.TextBox()
        Me.chkRaza = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.chkSexo = New System.Windows.Forms.CheckBox()
        Me.chkTraza = New System.Windows.Forms.CheckBox()
        Me.chkCruza = New System.Windows.Forms.CheckBox()
        Me.chkEdad = New System.Windows.Forms.CheckBox()
        Me.chkVida = New System.Windows.Forms.CheckBox()
        Me.chkPeso = New System.Windows.Forms.CheckBox()
        Me.chkPotrero = New System.Windows.Forms.CheckBox()
        Me.chkDicoseNac = New System.Windows.Forms.CheckBox()
        Me.chkUbicacion = New System.Windows.Forms.CheckBox()
        Me.chkTenencia = New System.Windows.Forms.CheckBox()
        Me.chkPropietario = New System.Windows.Forms.CheckBox()
        Me.chkEntorado = New System.Windows.Forms.CheckBox()
        Me.chkCastrado = New System.Windows.Forms.CheckBox()
        Me.chkPrenado = New System.Windows.Forms.CheckBox()
        Me.txtDiasUbicacion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDiasUbicacion = New System.Windows.Forms.CheckBox()
        Me.txtOrejano = New System.Windows.Forms.TextBox()
        Me.chkPesoActual = New System.Windows.Forms.CheckBox()
        Me.txtPesoActual = New System.Windows.Forms.TextBox()
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbini = New System.Windows.Forms.Label()
        Me.lbFin = New System.Windows.Forms.Label()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.txtErrores = New System.Windows.Forms.TextBox()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaRef = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtFoco = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.txtEscucha = New System.Windows.Forms.TextBox()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.cboEventos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtIdEvento = New System.Windows.Forms.TextBox()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.btnExportar = New DevComponents.DotNetBar.ButtonX()
        Me.txtIdEventoPrincipal = New System.Windows.Forms.TextBox()
        Me.txtEvento = New System.Windows.Forms.TextBox()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX()
        Me.btnBaston = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.cboOpciones = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.chkSelAntes = New System.Windows.Forms.CheckBox()
        Me.ListaDispositivos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbOpciones = New DevComponents.DotNetBar.LabelX()
        Me.lbTitulo = New DevComponents.DotNetBar.LabelX()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpFechaRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(223, 507)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(40, 17)
        Me.LabelX1.TabIndex = 534
        Me.LabelX1.Text = "Hasta"
        '
        'dtpFechaHasta
        '
        '
        '
        '
        Me.dtpFechaHasta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFechaHasta.ButtonDropDown.Visible = True
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Location = New System.Drawing.Point(269, 504)
        '
        '
        '
        Me.dtpFechaHasta.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpFechaHasta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFechaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFechaHasta.MonthCalendar.DisplayMonth = New Date(2010, 9, 1, 0, 0, 0, 0)
        Me.dtpFechaHasta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFechaHasta.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFechaHasta.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFechaHasta.MonthCalendar.TodayButtonVisible = True
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(108, 21)
        Me.dtpFechaHasta.TabIndex = 533
        Me.dtpFechaHasta.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(383, 503)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(92, 22)
        Me.ButtonX1.TabIndex = 532
        Me.ButtonX1.Text = "Consulta"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(64, 509)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(43, 12)
        Me.LabelX4.TabIndex = 531
        Me.LabelX4.Text = "Desde"
        '
        'DtpFechaDesde
        '
        '
        '
        '
        Me.DtpFechaDesde.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtpFechaDesde.ButtonDropDown.Visible = True
        Me.DtpFechaDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaDesde.Location = New System.Drawing.Point(109, 504)
        '
        '
        '
        Me.DtpFechaDesde.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.DtpFechaDesde.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtpFechaDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtpFechaDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtpFechaDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtpFechaDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtpFechaDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtpFechaDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtpFechaDesde.MonthCalendar.DisplayMonth = New Date(2010, 9, 1, 0, 0, 0, 0)
        Me.DtpFechaDesde.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DtpFechaDesde.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DtpFechaDesde.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DtpFechaDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtpFechaDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtpFechaDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtpFechaDesde.MonthCalendar.TodayButtonVisible = True
        Me.DtpFechaDesde.Name = "DtpFechaDesde"
        Me.DtpFechaDesde.Size = New System.Drawing.Size(108, 21)
        Me.DtpFechaDesde.TabIndex = 528
        Me.DtpFechaDesde.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'dtgv
        '
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgv.Location = New System.Drawing.Point(13, 386)
        Me.dtgv.Name = "dtgv"
        Me.dtgv.Size = New System.Drawing.Size(302, 100)
        Me.dtgv.TabIndex = 535
        '
        'txtDispositivo
        '
        Me.txtDispositivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispositivo.Location = New System.Drawing.Point(122, 357)
        Me.txtDispositivo.Multiline = True
        Me.txtDispositivo.Name = "txtDispositivo"
        Me.txtDispositivo.Size = New System.Drawing.Size(193, 32)
        Me.txtDispositivo.TabIndex = 537
        '
        'SerialPort1
        '
        '
        'LabelX13
        '
        Me.LabelX13.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(105, 243)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(177, 38)
        Me.LabelX13.TabIndex = 540
        Me.LabelX13.WordWrap = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(66, 377)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(79, 22)
        Me.ButtonX2.TabIndex = 542
        Me.ButtonX2.Text = "Consultar"
        '
        'Lsnumeros
        '
        Me.Lsnumeros.FormattingEnabled = True
        Me.Lsnumeros.Location = New System.Drawing.Point(151, 330)
        Me.Lsnumeros.Name = "Lsnumeros"
        Me.Lsnumeros.Size = New System.Drawing.Size(120, 69)
        Me.Lsnumeros.TabIndex = 543
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(66, 330)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(79, 23)
        Me.LabelX7.TabIndex = 547
        Me.LabelX7.Text = "Zona Prueba"
        '
        'chkDispositivo
        '
        Me.chkDispositivo.AutoSize = True
        Me.chkDispositivo.Location = New System.Drawing.Point(60, 97)
        Me.chkDispositivo.Name = "chkDispositivo"
        Me.chkDispositivo.Size = New System.Drawing.Size(15, 14)
        Me.chkDispositivo.TabIndex = 575
        Me.chkDispositivo.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(6, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(32, 19)
        Me.LabelX2.TabIndex = 539
        Me.LabelX2.Text = "Raza"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(6, 86)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(32, 23)
        Me.LabelX3.TabIndex = 540
        Me.LabelX3.Text = "Sexo"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(6, 56)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(47, 19)
        Me.LabelX5.TabIndex = 541
        Me.LabelX5.Text = "Cruza"
        '
        'txtRaza
        '
        Me.txtRaza.BackColor = System.Drawing.Color.White
        Me.txtRaza.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaza.Location = New System.Drawing.Point(48, 19)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.ReadOnly = True
        Me.txtRaza.Size = New System.Drawing.Size(46, 27)
        Me.txtRaza.TabIndex = 542
        '
        'txtSexo
        '
        Me.txtSexo.BackColor = System.Drawing.Color.White
        Me.txtSexo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo.Location = New System.Drawing.Point(47, 86)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.ReadOnly = True
        Me.txtSexo.Size = New System.Drawing.Size(48, 27)
        Me.txtSexo.TabIndex = 543
        '
        'txtCruza
        '
        Me.txtCruza.BackColor = System.Drawing.Color.White
        Me.txtCruza.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCruza.Location = New System.Drawing.Point(47, 54)
        Me.txtCruza.Name = "txtCruza"
        Me.txtCruza.ReadOnly = True
        Me.txtCruza.Size = New System.Drawing.Size(47, 27)
        Me.txtCruza.TabIndex = 544
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(9, 120)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(44, 23)
        Me.LabelX6.TabIndex = 545
        Me.LabelX6.Text = "Edad"
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.White
        Me.txtEdad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(48, 118)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(47, 27)
        Me.txtEdad.TabIndex = 546
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(150, 157)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(69, 18)
        Me.LabelX8.TabIndex = 547
        Me.LabelX8.Text = "Propietario"
        '
        'txtPropietario
        '
        Me.txtPropietario.BackColor = System.Drawing.Color.White
        Me.txtPropietario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.Location = New System.Drawing.Point(229, 150)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.ReadOnly = True
        Me.txtPropietario.Size = New System.Drawing.Size(104, 27)
        Me.txtPropietario.TabIndex = 548
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(150, 187)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(69, 19)
        Me.LabelX9.TabIndex = 549
        Me.LabelX9.Text = "Tenencia"
        '
        'txtTenencia
        '
        Me.txtTenencia.BackColor = System.Drawing.Color.White
        Me.txtTenencia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenencia.Location = New System.Drawing.Point(229, 183)
        Me.txtTenencia.Name = "txtTenencia"
        Me.txtTenencia.ReadOnly = True
        Me.txtTenencia.Size = New System.Drawing.Size(104, 27)
        Me.txtTenencia.TabIndex = 550
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(150, 218)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(69, 23)
        Me.LabelX10.TabIndex = 551
        Me.LabelX10.Text = "Ubicacion"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.BackColor = System.Drawing.Color.White
        Me.txtUbicacion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(229, 216)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.ReadOnly = True
        Me.txtUbicacion.Size = New System.Drawing.Size(104, 27)
        Me.txtUbicacion.TabIndex = 552
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(9, 284)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(34, 23)
        Me.LabelX11.TabIndex = 553
        Me.LabelX11.Text = "Vida"
        '
        'txtVida
        '
        Me.txtVida.BackColor = System.Drawing.Color.White
        Me.txtVida.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVida.Location = New System.Drawing.Point(50, 284)
        Me.txtVida.Name = "txtVida"
        Me.txtVida.ReadOnly = True
        Me.txtVida.Size = New System.Drawing.Size(65, 23)
        Me.txtVida.TabIndex = 554
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(7, 255)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(43, 23)
        Me.LabelX12.TabIndex = 555
        Me.LabelX12.Text = "Traza."
        '
        'txtTraza
        '
        Me.txtTraza.BackColor = System.Drawing.Color.White
        Me.txtTraza.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTraza.Location = New System.Drawing.Point(49, 255)
        Me.txtTraza.Name = "txtTraza"
        Me.txtTraza.ReadOnly = True
        Me.txtTraza.Size = New System.Drawing.Size(67, 23)
        Me.txtTraza.TabIndex = 556
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(154, 48)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(57, 23)
        Me.LabelX14.TabIndex = 557
        Me.LabelX14.Text = "Potrero"
        '
        'txtPotrero
        '
        Me.txtPotrero.BackColor = System.Drawing.Color.White
        Me.txtPotrero.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPotrero.Location = New System.Drawing.Point(230, 48)
        Me.txtPotrero.Name = "txtPotrero"
        Me.txtPotrero.ReadOnly = True
        Me.txtPotrero.Size = New System.Drawing.Size(122, 27)
        Me.txtPotrero.TabIndex = 558
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(154, 87)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(65, 16)
        Me.LabelX15.TabIndex = 559
        Me.LabelX15.Text = "Peso Nac."
        '
        'txtPesoNac
        '
        Me.txtPesoNac.BackColor = System.Drawing.Color.White
        Me.txtPesoNac.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoNac.Location = New System.Drawing.Point(230, 85)
        Me.txtPesoNac.Name = "txtPesoNac"
        Me.txtPesoNac.ReadOnly = True
        Me.txtPesoNac.Size = New System.Drawing.Size(53, 27)
        Me.txtPesoNac.TabIndex = 560
        '
        'txtEntorado
        '
        Me.txtEntorado.BackColor = System.Drawing.Color.White
        Me.txtEntorado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntorado.Location = New System.Drawing.Point(73, 156)
        Me.txtEntorado.Name = "txtEntorado"
        Me.txtEntorado.ReadOnly = True
        Me.txtEntorado.Size = New System.Drawing.Size(36, 27)
        Me.txtEntorado.TabIndex = 561
        '
        'txtCastrado
        '
        Me.txtCastrado.BackColor = System.Drawing.Color.White
        Me.txtCastrado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCastrado.Location = New System.Drawing.Point(73, 189)
        Me.txtCastrado.Name = "txtCastrado"
        Me.txtCastrado.ReadOnly = True
        Me.txtCastrado.Size = New System.Drawing.Size(36, 27)
        Me.txtCastrado.TabIndex = 562
        '
        'txtPrenado
        '
        Me.txtPrenado.BackColor = System.Drawing.Color.White
        Me.txtPrenado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenado.Location = New System.Drawing.Point(73, 221)
        Me.txtPrenado.Name = "txtPrenado"
        Me.txtPrenado.ReadOnly = True
        Me.txtPrenado.Size = New System.Drawing.Size(36, 27)
        Me.txtPrenado.TabIndex = 563
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.Location = New System.Drawing.Point(9, 158)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(58, 23)
        Me.LabelX16.TabIndex = 564
        Me.LabelX16.Text = "Entorado"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(9, 192)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(58, 23)
        Me.LabelX17.TabIndex = 565
        Me.LabelX17.Text = "Castrado"
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.Transparent
        Me.LabelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.Location = New System.Drawing.Point(9, 223)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(58, 23)
        Me.LabelX18.TabIndex = 566
        Me.LabelX18.Text = "Preñado"
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        Me.LabelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.Location = New System.Drawing.Point(154, 21)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(77, 15)
        Me.LabelX19.TabIndex = 567
        Me.LabelX19.Text = "Dicose Nac."
        '
        'txtDicoseNac
        '
        Me.txtDicoseNac.BackColor = System.Drawing.Color.White
        Me.txtDicoseNac.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDicoseNac.Location = New System.Drawing.Point(230, 16)
        Me.txtDicoseNac.Name = "txtDicoseNac"
        Me.txtDicoseNac.ReadOnly = True
        Me.txtDicoseNac.Size = New System.Drawing.Size(103, 27)
        Me.txtDicoseNac.TabIndex = 568
        '
        'chkRaza
        '
        Me.chkRaza.AutoSize = True
        Me.chkRaza.Location = New System.Drawing.Point(100, 25)
        Me.chkRaza.Name = "chkRaza"
        Me.chkRaza.Size = New System.Drawing.Size(15, 14)
        Me.chkRaza.TabIndex = 551
        Me.chkRaza.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(4, 331)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 569
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(4, 362)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 570
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        Me.LabelX20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.Location = New System.Drawing.Point(29, 326)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(71, 23)
        Me.LabelX20.TabIndex = 571
        Me.LabelX20.Text = "Sin Sonido"
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.Transparent
        Me.LabelX21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX21.Location = New System.Drawing.Point(30, 357)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(86, 23)
        Me.LabelX21.TabIndex = 572
        Me.LabelX21.Text = "Activa Sonido"
        '
        'chkSexo
        '
        Me.chkSexo.AutoSize = True
        Me.chkSexo.Location = New System.Drawing.Point(98, 93)
        Me.chkSexo.Name = "chkSexo"
        Me.chkSexo.Size = New System.Drawing.Size(15, 14)
        Me.chkSexo.TabIndex = 573
        Me.chkSexo.UseVisualStyleBackColor = True
        '
        'chkTraza
        '
        Me.chkTraza.AutoSize = True
        Me.chkTraza.Location = New System.Drawing.Point(122, 260)
        Me.chkTraza.Name = "chkTraza"
        Me.chkTraza.Size = New System.Drawing.Size(15, 14)
        Me.chkTraza.TabIndex = 574
        Me.chkTraza.UseVisualStyleBackColor = True
        '
        'chkCruza
        '
        Me.chkCruza.AutoSize = True
        Me.chkCruza.Location = New System.Drawing.Point(100, 61)
        Me.chkCruza.Name = "chkCruza"
        Me.chkCruza.Size = New System.Drawing.Size(15, 14)
        Me.chkCruza.TabIndex = 575
        Me.chkCruza.UseVisualStyleBackColor = True
        '
        'chkEdad
        '
        Me.chkEdad.AutoSize = True
        Me.chkEdad.Location = New System.Drawing.Point(100, 125)
        Me.chkEdad.Name = "chkEdad"
        Me.chkEdad.Size = New System.Drawing.Size(15, 14)
        Me.chkEdad.TabIndex = 576
        Me.chkEdad.UseVisualStyleBackColor = True
        '
        'chkVida
        '
        Me.chkVida.AutoSize = True
        Me.chkVida.Location = New System.Drawing.Point(121, 289)
        Me.chkVida.Name = "chkVida"
        Me.chkVida.Size = New System.Drawing.Size(15, 14)
        Me.chkVida.TabIndex = 577
        Me.chkVida.UseVisualStyleBackColor = True
        '
        'chkPeso
        '
        Me.chkPeso.AutoSize = True
        Me.chkPeso.Location = New System.Drawing.Point(289, 90)
        Me.chkPeso.Name = "chkPeso"
        Me.chkPeso.Size = New System.Drawing.Size(15, 14)
        Me.chkPeso.TabIndex = 578
        Me.chkPeso.UseVisualStyleBackColor = True
        '
        'chkPotrero
        '
        Me.chkPotrero.AutoSize = True
        Me.chkPotrero.Location = New System.Drawing.Point(358, 54)
        Me.chkPotrero.Name = "chkPotrero"
        Me.chkPotrero.Size = New System.Drawing.Size(15, 14)
        Me.chkPotrero.TabIndex = 579
        Me.chkPotrero.UseVisualStyleBackColor = True
        '
        'chkDicoseNac
        '
        Me.chkDicoseNac.AutoSize = True
        Me.chkDicoseNac.Location = New System.Drawing.Point(339, 21)
        Me.chkDicoseNac.Name = "chkDicoseNac"
        Me.chkDicoseNac.Size = New System.Drawing.Size(15, 14)
        Me.chkDicoseNac.TabIndex = 580
        Me.chkDicoseNac.UseVisualStyleBackColor = True
        '
        'chkUbicacion
        '
        Me.chkUbicacion.AutoSize = True
        Me.chkUbicacion.Location = New System.Drawing.Point(339, 223)
        Me.chkUbicacion.Name = "chkUbicacion"
        Me.chkUbicacion.Size = New System.Drawing.Size(15, 14)
        Me.chkUbicacion.TabIndex = 581
        Me.chkUbicacion.UseVisualStyleBackColor = True
        '
        'chkTenencia
        '
        Me.chkTenencia.AutoSize = True
        Me.chkTenencia.Location = New System.Drawing.Point(339, 190)
        Me.chkTenencia.Name = "chkTenencia"
        Me.chkTenencia.Size = New System.Drawing.Size(15, 14)
        Me.chkTenencia.TabIndex = 582
        Me.chkTenencia.UseVisualStyleBackColor = True
        '
        'chkPropietario
        '
        Me.chkPropietario.AutoSize = True
        Me.chkPropietario.Location = New System.Drawing.Point(339, 156)
        Me.chkPropietario.Name = "chkPropietario"
        Me.chkPropietario.Size = New System.Drawing.Size(15, 14)
        Me.chkPropietario.TabIndex = 583
        Me.chkPropietario.UseVisualStyleBackColor = True
        '
        'chkEntorado
        '
        Me.chkEntorado.AutoSize = True
        Me.chkEntorado.Location = New System.Drawing.Point(115, 163)
        Me.chkEntorado.Name = "chkEntorado"
        Me.chkEntorado.Size = New System.Drawing.Size(15, 14)
        Me.chkEntorado.TabIndex = 584
        Me.chkEntorado.UseVisualStyleBackColor = True
        '
        'chkCastrado
        '
        Me.chkCastrado.AutoSize = True
        Me.chkCastrado.Location = New System.Drawing.Point(115, 197)
        Me.chkCastrado.Name = "chkCastrado"
        Me.chkCastrado.Size = New System.Drawing.Size(15, 14)
        Me.chkCastrado.TabIndex = 585
        Me.chkCastrado.UseVisualStyleBackColor = True
        '
        'chkPrenado
        '
        Me.chkPrenado.AutoSize = True
        Me.chkPrenado.Location = New System.Drawing.Point(115, 228)
        Me.chkPrenado.Name = "chkPrenado"
        Me.chkPrenado.Size = New System.Drawing.Size(15, 14)
        Me.chkPrenado.TabIndex = 586
        Me.chkPrenado.UseVisualStyleBackColor = True
        '
        'txtDiasUbicacion
        '
        Me.txtDiasUbicacion.BackColor = System.Drawing.Color.White
        Me.txtDiasUbicacion.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasUbicacion.Location = New System.Drawing.Point(286, 243)
        Me.txtDiasUbicacion.Name = "txtDiasUbicacion"
        Me.txtDiasUbicacion.ReadOnly = True
        Me.txtDiasUbicacion.Size = New System.Drawing.Size(58, 31)
        Me.txtDiasUbicacion.TabIndex = 587
        Me.txtDiasUbicacion.Text = "0000"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDiasUbicacion)
        Me.GroupBox1.Controls.Add(Me.txtOrejano)
        Me.GroupBox1.Controls.Add(Me.chkPesoActual)
        Me.GroupBox1.Controls.Add(Me.txtPesoActual)
        Me.GroupBox1.Controls.Add(Me.LabelX25)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LabelX23)
        Me.GroupBox1.Controls.Add(Me.txtErrores)
        Me.GroupBox1.Controls.Add(Me.LabelX22)
        Me.GroupBox1.Controls.Add(Me.txtDiasUbicacion)
        Me.GroupBox1.Controls.Add(Me.chkPrenado)
        Me.GroupBox1.Controls.Add(Me.chkCastrado)
        Me.GroupBox1.Controls.Add(Me.chkEntorado)
        Me.GroupBox1.Controls.Add(Me.chkPropietario)
        Me.GroupBox1.Controls.Add(Me.chkTenencia)
        Me.GroupBox1.Controls.Add(Me.chkUbicacion)
        Me.GroupBox1.Controls.Add(Me.chkDicoseNac)
        Me.GroupBox1.Controls.Add(Me.chkPotrero)
        Me.GroupBox1.Controls.Add(Me.chkPeso)
        Me.GroupBox1.Controls.Add(Me.chkVida)
        Me.GroupBox1.Controls.Add(Me.chkEdad)
        Me.GroupBox1.Controls.Add(Me.chkCruza)
        Me.GroupBox1.Controls.Add(Me.chkTraza)
        Me.GroupBox1.Controls.Add(Me.chkSexo)
        Me.GroupBox1.Controls.Add(Me.LabelX21)
        Me.GroupBox1.Controls.Add(Me.LabelX20)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chkRaza)
        Me.GroupBox1.Controls.Add(Me.txtDicoseNac)
        Me.GroupBox1.Controls.Add(Me.LabelX19)
        Me.GroupBox1.Controls.Add(Me.LabelX18)
        Me.GroupBox1.Controls.Add(Me.LabelX17)
        Me.GroupBox1.Controls.Add(Me.LabelX16)
        Me.GroupBox1.Controls.Add(Me.txtPrenado)
        Me.GroupBox1.Controls.Add(Me.txtCastrado)
        Me.GroupBox1.Controls.Add(Me.txtEntorado)
        Me.GroupBox1.Controls.Add(Me.txtPesoNac)
        Me.GroupBox1.Controls.Add(Me.LabelX15)
        Me.GroupBox1.Controls.Add(Me.txtPotrero)
        Me.GroupBox1.Controls.Add(Me.LabelX14)
        Me.GroupBox1.Controls.Add(Me.txtTraza)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.txtVida)
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.txtUbicacion)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.txtTenencia)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.txtPropietario)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.txtCruza)
        Me.GroupBox1.Controls.Add(Me.txtSexo)
        Me.GroupBox1.Controls.Add(Me.txtRaza)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 448)
        Me.GroupBox1.TabIndex = 541
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Animal"
        '
        'chkDiasUbicacion
        '
        Me.chkDiasUbicacion.AutoSize = True
        Me.chkDiasUbicacion.Location = New System.Drawing.Point(350, 249)
        Me.chkDiasUbicacion.Name = "chkDiasUbicacion"
        Me.chkDiasUbicacion.Size = New System.Drawing.Size(15, 14)
        Me.chkDiasUbicacion.TabIndex = 595
        Me.chkDiasUbicacion.UseVisualStyleBackColor = True
        '
        'txtOrejano
        '
        Me.txtOrejano.BackColor = System.Drawing.Color.White
        Me.txtOrejano.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrejano.Location = New System.Drawing.Point(258, 273)
        Me.txtOrejano.Name = "txtOrejano"
        Me.txtOrejano.ReadOnly = True
        Me.txtOrejano.Size = New System.Drawing.Size(46, 27)
        Me.txtOrejano.TabIndex = 594
        Me.txtOrejano.Visible = False
        '
        'chkPesoActual
        '
        Me.chkPesoActual.AutoSize = True
        Me.chkPesoActual.Location = New System.Drawing.Point(289, 122)
        Me.chkPesoActual.Name = "chkPesoActual"
        Me.chkPesoActual.Size = New System.Drawing.Size(15, 14)
        Me.chkPesoActual.TabIndex = 593
        Me.chkPesoActual.UseVisualStyleBackColor = True
        '
        'txtPesoActual
        '
        Me.txtPesoActual.BackColor = System.Drawing.Color.White
        Me.txtPesoActual.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoActual.Location = New System.Drawing.Point(230, 117)
        Me.txtPesoActual.Name = "txtPesoActual"
        Me.txtPesoActual.ReadOnly = True
        Me.txtPesoActual.Size = New System.Drawing.Size(53, 27)
        Me.txtPesoActual.TabIndex = 592
        '
        'LabelX25
        '
        Me.LabelX25.BackColor = System.Drawing.Color.Transparent
        Me.LabelX25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX25.Location = New System.Drawing.Point(155, 119)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(41, 20)
        Me.LabelX25.TabIndex = 591
        Me.LabelX25.Text = "Peso:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox2.Controls.Add(Me.lbini)
        Me.GroupBox2.Controls.Add(Me.chkDispositivo)
        Me.GroupBox2.Controls.Add(Me.lbFin)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 121)
        Me.GroupBox2.TabIndex = 594
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nº Dispositivo"
        '
        'lbini
        '
        Me.lbini.AutoSize = True
        Me.lbini.BackColor = System.Drawing.Color.Transparent
        Me.lbini.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbini.Location = New System.Drawing.Point(15, 15)
        Me.lbini.Name = "lbini"
        Me.lbini.Size = New System.Drawing.Size(110, 37)
        Me.lbini.TabIndex = 596
        Me.lbini.Text = "08651"
        '
        'lbFin
        '
        Me.lbFin.AutoSize = True
        Me.lbFin.BackColor = System.Drawing.Color.Transparent
        Me.lbFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFin.Location = New System.Drawing.Point(3, 44)
        Me.lbFin.Name = "lbFin"
        Me.lbFin.Size = New System.Drawing.Size(136, 55)
        Me.lbFin.TabIndex = 595
        Me.lbFin.Text = "8651"
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.Transparent
        Me.LabelX23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX23.Location = New System.Drawing.Point(150, 276)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(47, 20)
        Me.LabelX23.TabIndex = 590
        Me.LabelX23.Text = "Errores"
        '
        'txtErrores
        '
        Me.txtErrores.BackColor = System.Drawing.Color.White
        Me.txtErrores.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtErrores.Location = New System.Drawing.Point(203, 273)
        Me.txtErrores.Name = "txtErrores"
        Me.txtErrores.ReadOnly = True
        Me.txtErrores.Size = New System.Drawing.Size(36, 27)
        Me.txtErrores.TabIndex = 589
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.Transparent
        Me.LabelX22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX22.Location = New System.Drawing.Point(150, 249)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(130, 21)
        Me.LabelX22.TabIndex = 588
        Me.LabelX22.Text = "Dias Ubicacion Actual"
        '
        'dtpFechaRef
        '
        '
        '
        '
        Me.dtpFechaRef.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFechaRef.ButtonDropDown.Visible = True
        Me.dtpFechaRef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRef.Location = New System.Drawing.Point(812, 31)
        '
        '
        '
        Me.dtpFechaRef.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpFechaRef.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFechaRef.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFechaRef.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaRef.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFechaRef.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFechaRef.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFechaRef.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFechaRef.MonthCalendar.DisplayMonth = New Date(2010, 9, 1, 0, 0, 0, 0)
        Me.dtpFechaRef.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFechaRef.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFechaRef.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFechaRef.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFechaRef.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaRef.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFechaRef.MonthCalendar.TodayButtonVisible = True
        Me.dtpFechaRef.Name = "dtpFechaRef"
        Me.dtpFechaRef.Size = New System.Drawing.Size(108, 21)
        Me.dtpFechaRef.TabIndex = 576
        Me.dtpFechaRef.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX24
        '
        Me.LabelX24.BackColor = System.Drawing.Color.Transparent
        Me.LabelX24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX24.Location = New System.Drawing.Point(812, 11)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(107, 17)
        Me.LabelX24.TabIndex = 577
        Me.LabelX24.Text = "Fecha Referencia"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(333, 32)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(194, 21)
        Me.txtStatus.TabIndex = 580
        '
        'txtFoco
        '
        Me.txtFoco.BackColor = System.Drawing.Color.White
        Me.txtFoco.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoco.Location = New System.Drawing.Point(151, 587)
        Me.txtFoco.Name = "txtFoco"
        Me.txtFoco.ReadOnly = True
        Me.txtFoco.Size = New System.Drawing.Size(106, 23)
        Me.txtFoco.TabIndex = 581
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.Transparent
        Me.LabelX26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX26.Location = New System.Drawing.Point(263, 597)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(61, 15)
        Me.LabelX26.TabIndex = 582
        Me.LabelX26.Text = "OPCION:"
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.Transparent
        Me.LabelX27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX27.Location = New System.Drawing.Point(333, 14)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(65, 21)
        Me.LabelX27.TabIndex = 584
        Me.LabelX27.Text = "ESTADO:"
        '
        'txtEscucha
        '
        Me.txtEscucha.BackColor = System.Drawing.Color.White
        Me.txtEscucha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEscucha.Location = New System.Drawing.Point(14, 588)
        Me.txtEscucha.Name = "txtEscucha"
        Me.txtEscucha.ReadOnly = True
        Me.txtEscucha.Size = New System.Drawing.Size(131, 23)
        Me.txtEscucha.TabIndex = 585
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.Transparent
        Me.LabelX28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX28.Location = New System.Drawing.Point(14, 567)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(80, 15)
        Me.LabelX28.TabIndex = 586
        Me.LabelX28.Text = "Escucha...."
        '
        'cboEventos
        '
        Me.cboEventos.DisplayMember = "Text"
        Me.cboEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEventos.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventos.FormattingEnabled = True
        Me.cboEventos.ItemHeight = 25
        Me.cboEventos.Location = New System.Drawing.Point(126, 22)
        Me.cboEventos.Name = "cboEventos"
        Me.cboEventos.Size = New System.Drawing.Size(194, 31)
        Me.cboEventos.TabIndex = 587
        '
        'txtIdEvento
        '
        Me.txtIdEvento.BackColor = System.Drawing.Color.White
        Me.txtIdEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEvento.Location = New System.Drawing.Point(341, 587)
        Me.txtIdEvento.Name = "txtIdEvento"
        Me.txtIdEvento.ReadOnly = True
        Me.txtIdEvento.Size = New System.Drawing.Size(25, 23)
        Me.txtIdEvento.TabIndex = 590
        Me.txtIdEvento.Text = "0"
        Me.txtIdEvento.Visible = False
        '
        'LabelX30
        '
        Me.LabelX30.BackColor = System.Drawing.Color.Transparent
        Me.LabelX30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX30.Location = New System.Drawing.Point(13, 27)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(116, 15)
        Me.LabelX30.TabIndex = 591
        Me.LabelX30.Text = "EVENTO ACTUAL"
        '
        'btnExportar
        '
        Me.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportar.Location = New System.Drawing.Point(333, 386)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(96, 23)
        Me.btnExportar.TabIndex = 536
        Me.btnExportar.Text = "&Exportar"
        '
        'txtIdEventoPrincipal
        '
        Me.txtIdEventoPrincipal.BackColor = System.Drawing.Color.White
        Me.txtIdEventoPrincipal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEventoPrincipal.Location = New System.Drawing.Point(232, 568)
        Me.txtIdEventoPrincipal.Name = "txtIdEventoPrincipal"
        Me.txtIdEventoPrincipal.ReadOnly = True
        Me.txtIdEventoPrincipal.Size = New System.Drawing.Size(25, 23)
        Me.txtIdEventoPrincipal.TabIndex = 592
        Me.txtIdEventoPrincipal.Text = "0"
        Me.txtIdEventoPrincipal.Visible = False
        '
        'txtEvento
        '
        Me.txtEvento.BackColor = System.Drawing.Color.White
        Me.txtEvento.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvento.Location = New System.Drawing.Point(266, 568)
        Me.txtEvento.Name = "txtEvento"
        Me.txtEvento.ReadOnly = True
        Me.txtEvento.Size = New System.Drawing.Size(121, 23)
        Me.txtEvento.TabIndex = 593
        Me.txtEvento.Text = "0"
        Me.txtEvento.Visible = False
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(435, 386)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(92, 23)
        Me.ButtonX3.TabIndex = 616
        Me.ButtonX3.Text = "Eliminar"
        Me.ButtonX3.Visible = False
        '
        'LabelX29
        '
        Me.LabelX29.BackColor = System.Drawing.Color.Transparent
        Me.LabelX29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX29.Location = New System.Drawing.Point(43, 362)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(73, 17)
        Me.LabelX29.TabIndex = 617
        Me.LabelX29.Text = "Dispositivo"
        '
        'btnBaston
        '
        Me.btnBaston.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBaston.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBaston.Location = New System.Drawing.Point(360, 428)
        Me.btnBaston.Name = "btnBaston"
        Me.btnBaston.Size = New System.Drawing.Size(115, 24)
        Me.btnBaston.TabIndex = 618
        Me.btnBaston.Text = "Activar Baston"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelX31)
        Me.GroupBox3.Controls.Add(Me.cboOpciones)
        Me.GroupBox3.Controls.Add(Me.btnCerrar)
        Me.GroupBox3.Controls.Add(Me.chkSelAntes)
        Me.GroupBox3.Controls.Add(Me.ListaDispositivos)
        Me.GroupBox3.Controls.Add(Me.btnImprimir)
        Me.GroupBox3.Controls.Add(Me.cboEventos)
        Me.GroupBox3.Controls.Add(Me.LabelX30)
        Me.GroupBox3.Controls.Add(Me.btnBaston)
        Me.GroupBox3.Controls.Add(Me.LabelX29)
        Me.GroupBox3.Controls.Add(Me.ButtonX3)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.txtStatus)
        Me.GroupBox3.Controls.Add(Me.LabelX27)
        Me.GroupBox3.Controls.Add(Me.dtgv)
        Me.GroupBox3.Controls.Add(Me.txtDispositivo)
        Me.GroupBox3.Controls.Add(Me.ButtonX1)
        Me.GroupBox3.Controls.Add(Me.DtpFechaDesde)
        Me.GroupBox3.Controls.Add(Me.LabelX4)
        Me.GroupBox3.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox3.Controls.Add(Me.LabelX1)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(407, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 547)
        Me.GroupBox3.TabIndex = 619
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingreso de sucesos"
        '
        'LabelX31
        '
        Me.LabelX31.BackColor = System.Drawing.Color.Transparent
        Me.LabelX31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX31.Location = New System.Drawing.Point(43, 339)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(50, 17)
        Me.LabelX31.TabIndex = 624
        Me.LabelX31.Text = "Opcion"
        '
        'cboOpciones
        '
        Me.cboOpciones.DisplayMember = "Text"
        Me.cboOpciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpciones.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpciones.FormattingEnabled = True
        Me.cboOpciones.ItemHeight = 17
        Me.cboOpciones.Location = New System.Drawing.Point(122, 333)
        Me.cboOpciones.Name = "cboOpciones"
        Me.cboOpciones.Size = New System.Drawing.Size(193, 23)
        Me.cboOpciones.TabIndex = 623
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.Location = New System.Drawing.Point(395, 336)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(132, 23)
        Me.btnCerrar.TabIndex = 622
        Me.btnCerrar.Text = "Cerrar"
        '
        'chkSelAntes
        '
        Me.chkSelAntes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSelAntes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkSelAntes.Location = New System.Drawing.Point(354, 462)
        Me.chkSelAntes.Name = "chkSelAntes"
        Me.chkSelAntes.Size = New System.Drawing.Size(176, 32)
        Me.chkSelAntes.TabIndex = 621
        Me.chkSelAntes.Text = "Seleccionar antes de imprimir"
        '
        'ListaDispositivos
        '
        Me.ListaDispositivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaDispositivos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListaDispositivos.FullRowSelect = True
        Me.ListaDispositivos.GridLines = True
        Me.ListaDispositivos.Location = New System.Drawing.Point(13, 62)
        Me.ListaDispositivos.Name = "ListaDispositivos"
        Me.ListaDispositivos.Size = New System.Drawing.Size(513, 268)
        Me.ListaDispositivos.TabIndex = 620
        Me.ListaDispositivos.UseCompatibleStateImageBehavior = False
        Me.ListaDispositivos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 154
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descripción"
        Me.ColumnHeader3.Width = 171
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnImprimir.Location = New System.Drawing.Point(430, 425)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 23)
        Me.btnImprimir.TabIndex = 619
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbOpciones)
        Me.GroupBox4.Controls.Add(Me.lbTitulo)
        Me.GroupBox4.Controls.Add(Me.dtpFechaRef)
        Me.GroupBox4.Controls.Add(Me.LabelX24)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(929, 114)
        Me.GroupBox4.TabIndex = 620
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Actividad"
        '
        'lbOpciones
        '
        Me.lbOpciones.BackColor = System.Drawing.Color.Transparent
        Me.lbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOpciones.Location = New System.Drawing.Point(9, 56)
        Me.lbOpciones.Name = "lbOpciones"
        Me.lbOpciones.Size = New System.Drawing.Size(911, 44)
        Me.lbOpciones.TabIndex = 621
        Me.lbOpciones.Text = "Ecografia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2"
        '
        'lbTitulo
        '
        Me.lbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(54, 11)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(642, 41)
        Me.lbTitulo.TabIndex = 592
        Me.lbTitulo.Text = "Ecografia"
        Me.lbTitulo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Timer3
        '
        Me.Timer3.Interval = 300
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cant"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'IUIngresoEventosDirecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(955, 623)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEvento)
        Me.Controls.Add(Me.txtIdEvento)
        Me.Controls.Add(Me.txtIdEventoPrincipal)
        Me.Controls.Add(Me.LabelX28)
        Me.Controls.Add(Me.txtEscucha)
        Me.Controls.Add(Me.LabelX26)
        Me.Controls.Add(Me.txtFoco)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.Lsnumeros)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.LabelX13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IUIngresoEventosDirecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos en tiempo Real"
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpFechaRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtpFechaDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtDispositivo As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Lsnumeros As System.Windows.Forms.ListBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkDispositivo As System.Windows.Forms.CheckBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents txtCruza As System.Windows.Forms.TextBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTenencia As System.Windows.Forms.TextBox
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVida As System.Windows.Forms.TextBox
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTraza As System.Windows.Forms.TextBox
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPotrero As System.Windows.Forms.TextBox
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPesoNac As System.Windows.Forms.TextBox
    Friend WithEvents txtEntorado As System.Windows.Forms.TextBox
    Friend WithEvents txtCastrado As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenado As System.Windows.Forms.TextBox
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDicoseNac As System.Windows.Forms.TextBox
    Friend WithEvents chkRaza As System.Windows.Forms.CheckBox
    Private WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Private WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkSexo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTraza As System.Windows.Forms.CheckBox
    Friend WithEvents chkCruza As System.Windows.Forms.CheckBox
    Friend WithEvents chkEdad As System.Windows.Forms.CheckBox
    Friend WithEvents chkVida As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeso As System.Windows.Forms.CheckBox
    Friend WithEvents chkPotrero As System.Windows.Forms.CheckBox
    Friend WithEvents chkDicoseNac As System.Windows.Forms.CheckBox
    Friend WithEvents chkUbicacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkTenencia As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropietario As System.Windows.Forms.CheckBox
    Friend WithEvents chkEntorado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCastrado As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrenado As System.Windows.Forms.CheckBox
    Friend WithEvents txtDiasUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtErrores As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaRef As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPesoActual As System.Windows.Forms.TextBox
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkPesoActual As System.Windows.Forms.CheckBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtFoco As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEscucha As System.Windows.Forms.TextBox
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboEventos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtIdEvento As System.Windows.Forms.TextBox
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtOrejano As System.Windows.Forms.TextBox
    Friend WithEvents txtIdEventoPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents txtEvento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbini As System.Windows.Forms.Label
    Friend WithEvents lbFin As System.Windows.Forms.Label
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBaston As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbTitulo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbOpciones As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListaDispositivos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkSelAntes As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiasUbicacion As System.Windows.Forms.CheckBox
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboOpciones As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
