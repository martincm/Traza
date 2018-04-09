<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUIngresoEventos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUIngresoEventos))
        Me.dtpFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Text_drecibidos = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datagridbusqueda = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DataGrid = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.cboOperaciones = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtGuia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.chInvertir = New System.Windows.Forms.CheckBox()
        Me.GenerarTxt = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar2 = New DevComponents.DotNetBar.ButtonItem()
        Me.txtDispositivoManual = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.cboTenencia = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboUbicacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.cboPropietario = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbpotdestino = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.cboPotreroDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboCruza = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtSeleccionados = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboListaEventosLineas = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.cboListaEventos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cboPotreros = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboSexo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboRaza = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboLote = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.NudMeses = New System.Windows.Forms.NumericUpDown()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtBusquedaDis = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDescarga = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtTipoIngreso = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.lbTitulo = New DevComponents.DotNetBar.LabelX()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dispositivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cruza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEventoLin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventoLin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacionDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpotrero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.potrero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpotreroDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.potreroDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trazabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasUbicacionActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datagridbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NudMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.dtpFecha.Location = New System.Drawing.Point(56, 19)
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
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(12, 21)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 19)
        Me.LabelX2.TabIndex = 454
        Me.LabelX2.Text = "Fecha"
        '
        'Text_drecibidos
        '
        Me.Text_drecibidos.Location = New System.Drawing.Point(957, 44)
        Me.Text_drecibidos.Multiline = True
        Me.Text_drecibidos.Name = "Text_drecibidos"
        Me.Text_drecibidos.Size = New System.Drawing.Size(104, 21)
        Me.Text_drecibidos.TabIndex = 467
        Me.Text_drecibidos.Visible = False
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datagridbusqueda)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.DataGrid)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1049, 487)
        Me.GroupBox2.TabIndex = 473
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eventos"
        '
        'datagridbusqueda
        '
        Me.datagridbusqueda.AllowUserToAddRows = False
        Me.datagridbusqueda.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridbusqueda.DefaultCellStyle = DataGridViewCellStyle1
        Me.datagridbusqueda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.datagridbusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.datagridbusqueda.Location = New System.Drawing.Point(-13, 16)
        Me.datagridbusqueda.Name = "datagridbusqueda"
        Me.datagridbusqueda.RowHeadersWidth = 5
        Me.datagridbusqueda.Size = New System.Drawing.Size(1034, 244)
        Me.datagridbusqueda.TabIndex = 548
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 266)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(874, 10)
        Me.ProgressBar1.TabIndex = 547
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToOrderColumns = True
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeracion, Me.chk, Me.fecha, Me.lote, Me.dispositivo, Me.raza, Me.cruza, Me.sexo, Me.edad, Me.IdEvento, Me.evento, Me.IdEventoLin, Me.eventoLin, Me.Uni, Me.cnt, Me.propietario, Me.ubicacion, Me.ubicacionDes, Me.tenencia, Me.idpotrero, Me.potrero, Me.idpotreroDestino, Me.potreroDes, Me.vida, Me.trazabilidad, Me.IdLinea, Me.DiasUbicacionActual})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGrid.Location = New System.Drawing.Point(15, 16)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersWidth = 5
        Me.DataGrid.Size = New System.Drawing.Size(1028, 244)
        Me.DataGrid.TabIndex = 546
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonX2)
        Me.GroupBox4.Controls.Add(Me.LabelX8)
        Me.GroupBox4.Controls.Add(Me.LabelX18)
        Me.GroupBox4.Controls.Add(Me.cboOperaciones)
        Me.GroupBox4.Controls.Add(Me.txtGuia)
        Me.GroupBox4.Controls.Add(Me.chInvertir)
        Me.GroupBox4.Controls.Add(Me.GenerarTxt)
        Me.GroupBox4.Controls.Add(Me.ButtonX1)
        Me.GroupBox4.Controls.Add(Me.txtDispositivoManual)
        Me.GroupBox4.Controls.Add(Me.LabelX17)
        Me.GroupBox4.Controls.Add(Me.cboTenencia)
        Me.GroupBox4.Controls.Add(Me.cboUbicacion)
        Me.GroupBox4.Controls.Add(Me.LabelX16)
        Me.GroupBox4.Controls.Add(Me.cboPropietario)
        Me.GroupBox4.Controls.Add(Me.lbpotdestino)
        Me.GroupBox4.Controls.Add(Me.LabelX15)
        Me.GroupBox4.Controls.Add(Me.cboPotreroDestino)
        Me.GroupBox4.Controls.Add(Me.cboCruza)
        Me.GroupBox4.Controls.Add(Me.LabelX13)
        Me.GroupBox4.Controls.Add(Me.LabelX1)
        Me.GroupBox4.Controls.Add(Me.LabelX11)
        Me.GroupBox4.Controls.Add(Me.LabelX3)
        Me.GroupBox4.Controls.Add(Me.txtSeleccionados)
        Me.GroupBox4.Controls.Add(Me.cboListaEventosLineas)
        Me.GroupBox4.Controls.Add(Me.LabelX12)
        Me.GroupBox4.Controls.Add(Me.cboListaEventos)
        Me.GroupBox4.Controls.Add(Me.LabelX5)
        Me.GroupBox4.Controls.Add(Me.cboPotreros)
        Me.GroupBox4.Controls.Add(Me.cboSexo)
        Me.GroupBox4.Controls.Add(Me.cboRaza)
        Me.GroupBox4.Controls.Add(Me.cboLote)
        Me.GroupBox4.Controls.Add(Me.NudMeses)
        Me.GroupBox4.Controls.Add(Me.LabelX10)
        Me.GroupBox4.Controls.Add(Me.LabelX9)
        Me.GroupBox4.Controls.Add(Me.LabelX6)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 282)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(884, 190)
        Me.GroupBox4.TabIndex = 497
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtros"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.White
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(428, 80)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(121, 29)
        Me.ButtonX2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem4, Me.ButtonItem2, Me.ButtonItem3})
        Me.ButtonX2.TabIndex = 547
        Me.ButtonX2.Text = "&Guardar"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ImagePaddingHorizontal = 8
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Exportar"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ImagePaddingHorizontal = 8
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Ver Cruzado"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ImagePaddingHorizontal = 8
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Imprimir"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Green
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX8.Location = New System.Drawing.Point(750, 105)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(121, 18)
        Me.LabelX8.TabIndex = 539
        Me.LabelX8.Text = "Guia"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.Moccasin
        Me.LabelX18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.ForeColor = System.Drawing.Color.Black
        Me.LabelX18.Location = New System.Drawing.Point(757, 9)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(121, 18)
        Me.LabelX18.TabIndex = 545
        Me.LabelX18.Text = "Dispositivo"
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DisplayMember = "Text"
        Me.cboOperaciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.ItemHeight = 16
        Me.cboOperaciones.Location = New System.Drawing.Point(582, 155)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(145, 22)
        Me.cboOperaciones.TabIndex = 495
        Me.cboOperaciones.Visible = False
        '
        'txtGuia
        '
        Me.txtGuia.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtGuia.Border.Class = "TextBoxBorder"
        Me.txtGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuia.Location = New System.Drawing.Point(750, 125)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.Size = New System.Drawing.Size(121, 29)
        Me.txtGuia.TabIndex = 521
        '
        'chInvertir
        '
        Me.chInvertir.AutoSize = True
        Me.chInvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chInvertir.Location = New System.Drawing.Point(241, 132)
        Me.chInvertir.Name = "chInvertir"
        Me.chInvertir.Size = New System.Drawing.Size(126, 17)
        Me.chInvertir.TabIndex = 520
        Me.chInvertir.Text = "Invertir Seleccion"
        Me.chInvertir.UseVisualStyleBackColor = True
        '
        'GenerarTxt
        '
        Me.GenerarTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.GenerarTxt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.GenerarTxt.Location = New System.Drawing.Point(750, 161)
        Me.GenerarTxt.Name = "GenerarTxt"
        Me.GenerarTxt.Size = New System.Drawing.Size(121, 23)
        Me.GenerarTxt.TabIndex = 538
        Me.GenerarTxt.Text = "&General txt"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.White
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(757, 53)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(121, 23)
        Me.ButtonX1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnEliminar2})
        Me.ButtonX1.TabIndex = 544
        Me.ButtonX1.Text = "&Ingresar"
        '
        'btnEliminar2
        '
        Me.btnEliminar2.ImagePaddingHorizontal = 8
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Text = "Eliminar"
        '
        'txtDispositivoManual
        '
        Me.txtDispositivoManual.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDispositivoManual.Border.Class = "TextBoxBorder"
        Me.txtDispositivoManual.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispositivoManual.Location = New System.Drawing.Point(757, 25)
        Me.txtDispositivoManual.Name = "txtDispositivoManual"
        Me.txtDispositivoManual.Size = New System.Drawing.Size(121, 27)
        Me.txtDispositivoManual.TabIndex = 543
        Me.txtDispositivoManual.Text = "984697"
        '
        'LabelX17
        '
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(227, 74)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(58, 20)
        Me.LabelX17.TabIndex = 519
        Me.LabelX17.Text = "Tenencia"
        '
        'cboTenencia
        '
        Me.cboTenencia.DisplayMember = "Text"
        Me.cboTenencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTenencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTenencia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTenencia.FormattingEnabled = True
        Me.cboTenencia.ItemHeight = 16
        Me.cboTenencia.Location = New System.Drawing.Point(304, 72)
        Me.cboTenencia.Name = "cboTenencia"
        Me.cboTenencia.Size = New System.Drawing.Size(116, 22)
        Me.cboTenencia.TabIndex = 518
        '
        'cboUbicacion
        '
        Me.cboUbicacion.DisplayMember = "Text"
        Me.cboUbicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUbicacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUbicacion.FormattingEnabled = True
        Me.cboUbicacion.ItemHeight = 16
        Me.cboUbicacion.Location = New System.Drawing.Point(304, 43)
        Me.cboUbicacion.Name = "cboUbicacion"
        Me.cboUbicacion.Size = New System.Drawing.Size(116, 22)
        Me.cboUbicacion.TabIndex = 517
        '
        'LabelX16
        '
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.Location = New System.Drawing.Point(227, 44)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(58, 20)
        Me.LabelX16.TabIndex = 516
        Me.LabelX16.Text = "Ubicacion"
        '
        'cboPropietario
        '
        Me.cboPropietario.DisplayMember = "Text"
        Me.cboPropietario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPropietario.FormattingEnabled = True
        Me.cboPropietario.ItemHeight = 16
        Me.cboPropietario.Location = New System.Drawing.Point(304, 15)
        Me.cboPropietario.Name = "cboPropietario"
        Me.cboPropietario.Size = New System.Drawing.Size(116, 22)
        Me.cboPropietario.TabIndex = 515
        '
        'lbpotdestino
        '
        Me.lbpotdestino.BackColor = System.Drawing.Color.Green
        Me.lbpotdestino.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpotdestino.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbpotdestino.Location = New System.Drawing.Point(581, 118)
        Me.lbpotdestino.Name = "lbpotdestino"
        Me.lbpotdestino.Size = New System.Drawing.Size(145, 18)
        Me.lbpotdestino.TabIndex = 499
        Me.lbpotdestino.Text = "DESTINO"
        Me.lbpotdestino.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lbpotdestino.Visible = False
        '
        'LabelX15
        '
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(227, 15)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(71, 20)
        Me.LabelX15.TabIndex = 514
        Me.LabelX15.Text = "Propietario"
        '
        'cboPotreroDestino
        '
        Me.cboPotreroDestino.DisplayMember = "Text"
        Me.cboPotreroDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPotreroDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPotreroDestino.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPotreroDestino.FormattingEnabled = True
        Me.cboPotreroDestino.ItemHeight = 16
        Me.cboPotreroDestino.Location = New System.Drawing.Point(581, 138)
        Me.cboPotreroDestino.Name = "cboPotreroDestino"
        Me.cboPotreroDestino.Size = New System.Drawing.Size(145, 22)
        Me.cboPotreroDestino.TabIndex = 498
        '
        'cboCruza
        '
        Me.cboCruza.DisplayMember = "Text"
        Me.cboCruza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCruza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCruza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCruza.FormattingEnabled = True
        Me.cboCruza.ItemHeight = 16
        Me.cboCruza.Location = New System.Drawing.Point(69, 99)
        Me.cboCruza.Name = "cboCruza"
        Me.cboCruza.Size = New System.Drawing.Size(64, 22)
        Me.cboCruza.TabIndex = 513
        '
        'LabelX13
        '
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(15, 99)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(38, 20)
        Me.LabelX13.TabIndex = 512
        Me.LabelX13.Text = "Cruza"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Green
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX1.Location = New System.Drawing.Point(581, 69)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(145, 18)
        Me.LabelX1.TabIndex = 496
        Me.LabelX1.Text = "SUB - EVENTO"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Green
        Me.LabelX11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX11.Location = New System.Drawing.Point(428, 18)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(121, 19)
        Me.LabelX11.TabIndex = 511
        Me.LabelX11.Text = "Seleccionados"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Green
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX3.Location = New System.Drawing.Point(581, 17)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(145, 18)
        Me.LabelX3.TabIndex = 495
        Me.LabelX3.Text = "EVENTOS"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtSeleccionados
        '
        Me.txtSeleccionados.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSeleccionados.Border.Class = "TextBoxBorder"
        Me.txtSeleccionados.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeleccionados.Location = New System.Drawing.Point(428, 37)
        Me.txtSeleccionados.Name = "txtSeleccionados"
        Me.txtSeleccionados.ReadOnly = True
        Me.txtSeleccionados.Size = New System.Drawing.Size(121, 37)
        Me.txtSeleccionados.TabIndex = 510
        Me.txtSeleccionados.Text = "0"
        Me.txtSeleccionados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboListaEventosLineas
        '
        Me.cboListaEventosLineas.DisplayMember = "Text"
        Me.cboListaEventosLineas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboListaEventosLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboListaEventosLineas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboListaEventosLineas.FormattingEnabled = True
        Me.cboListaEventosLineas.ItemHeight = 16
        Me.cboListaEventosLineas.Location = New System.Drawing.Point(581, 89)
        Me.cboListaEventosLineas.Name = "cboListaEventosLineas"
        Me.cboListaEventosLineas.Size = New System.Drawing.Size(145, 22)
        Me.cboListaEventosLineas.TabIndex = 494
        '
        'LabelX12
        '
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(229, 103)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(94, 20)
        Me.LabelX12.TabIndex = 509
        Me.LabelX12.Text = "Edad - Meses <="
        '
        'cboListaEventos
        '
        Me.cboListaEventos.DisplayMember = "Text"
        Me.cboListaEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboListaEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboListaEventos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboListaEventos.FormattingEnabled = True
        Me.cboListaEventos.ItemHeight = 16
        Me.cboListaEventos.Location = New System.Drawing.Point(581, 36)
        Me.cboListaEventos.Name = "cboListaEventos"
        Me.cboListaEventos.Size = New System.Drawing.Size(145, 22)
        Me.cboListaEventos.TabIndex = 493
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(15, 129)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(48, 20)
        Me.LabelX5.TabIndex = 508
        Me.LabelX5.Text = "Potrero"
        '
        'cboPotreros
        '
        Me.cboPotreros.DisplayMember = "Text"
        Me.cboPotreros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPotreros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPotreros.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPotreros.FormattingEnabled = True
        Me.cboPotreros.ItemHeight = 16
        Me.cboPotreros.Location = New System.Drawing.Point(69, 129)
        Me.cboPotreros.Name = "cboPotreros"
        Me.cboPotreros.Size = New System.Drawing.Size(128, 22)
        Me.cboPotreros.TabIndex = 507
        '
        'cboSexo
        '
        Me.cboSexo.DisplayMember = "Text"
        Me.cboSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.ItemHeight = 16
        Me.cboSexo.Location = New System.Drawing.Point(69, 71)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(104, 22)
        Me.cboSexo.TabIndex = 506
        '
        'cboRaza
        '
        Me.cboRaza.DisplayMember = "Text"
        Me.cboRaza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRaza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.ItemHeight = 16
        Me.cboRaza.Location = New System.Drawing.Point(69, 43)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(64, 22)
        Me.cboRaza.TabIndex = 505
        '
        'cboLote
        '
        Me.cboLote.DisplayMember = "Text"
        Me.cboLote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.ItemHeight = 16
        Me.cboLote.Location = New System.Drawing.Point(69, 15)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(152, 22)
        Me.cboLote.TabIndex = 504
        '
        'NudMeses
        '
        Me.NudMeses.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudMeses.Location = New System.Drawing.Point(329, 101)
        Me.NudMeses.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudMeses.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMeses.Name = "NudMeses"
        Me.NudMeses.Size = New System.Drawing.Size(53, 22)
        Me.NudMeses.TabIndex = 503
        Me.NudMeses.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'LabelX10
        '
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(15, 45)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(38, 20)
        Me.LabelX10.TabIndex = 463
        Me.LabelX10.Text = "Raza"
        '
        'LabelX9
        '
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(15, 72)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(38, 20)
        Me.LabelX9.TabIndex = 488
        Me.LabelX9.Text = "Sexo"
        '
        'LabelX6
        '
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(15, 17)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(38, 20)
        Me.LabelX6.TabIndex = 492
        Me.LabelX6.Text = "Lote"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelX7)
        Me.GroupBox3.Controls.Add(Me.txtBusquedaDis)
        Me.GroupBox3.Controls.Add(Me.lbDescarga)
        Me.GroupBox3.Controls.Add(Me.LabelX4)
        Me.GroupBox3.Controls.Add(Me.cboOrigen)
        Me.GroupBox3.Controls.Add(Me.txtTipoIngreso)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Controls.Add(Me.LabelX14)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.LabelX2)
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.lbTitulo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(918, 82)
        Me.GroupBox3.TabIndex = 476
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingreso Eventos"
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(12, 50)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(38, 19)
        Me.LabelX7.TabIndex = 595
        Me.LabelX7.Text = "Disp."
        '
        'txtBusquedaDis
        '
        Me.txtBusquedaDis.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBusquedaDis.Border.Class = "TextBoxBorder"
        Me.txtBusquedaDis.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaDis.Location = New System.Drawing.Point(56, 50)
        Me.txtBusquedaDis.Name = "txtBusquedaDis"
        Me.txtBusquedaDis.Size = New System.Drawing.Size(224, 27)
        Me.txtBusquedaDis.TabIndex = 594
        '
        'lbDescarga
        '
        Me.lbDescarga.BackColor = System.Drawing.Color.White
        Me.lbDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescarga.ForeColor = System.Drawing.Color.Black
        Me.lbDescarga.Location = New System.Drawing.Point(570, 18)
        Me.lbDescarga.Name = "lbDescarga"
        Me.lbDescarga.Size = New System.Drawing.Size(241, 23)
        Me.lbDescarga.TabIndex = 511
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(166, 19)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(78, 20)
        Me.LabelX4.TabIndex = 510
        Me.LabelX4.Text = "Origen Datos"
        '
        'cboOrigen
        '
        Me.cboOrigen.DisplayMember = "Text"
        Me.cboOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.ItemHeight = 16
        Me.cboOrigen.Location = New System.Drawing.Point(250, 19)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(197, 22)
        Me.cboOrigen.TabIndex = 509
        '
        'txtTipoIngreso
        '
        Me.txtTipoIngreso.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTipoIngreso.Border.Class = "TextBoxBorder"
        Me.txtTipoIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoIngreso.ForeColor = System.Drawing.Color.Black
        Me.txtTipoIngreso.Location = New System.Drawing.Point(717, 12)
        Me.txtTipoIngreso.Name = "txtTipoIngreso"
        Me.txtTipoIngreso.ReadOnly = True
        Me.txtTipoIngreso.Size = New System.Drawing.Size(37, 29)
        Me.txtTipoIngreso.TabIndex = 500
        Me.txtTipoIngreso.Text = "1"
        Me.txtTipoIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipoIngreso.Visible = False
        Me.txtTipoIngreso.WatermarkColor = System.Drawing.SystemColors.ControlLightLight
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
        Me.txtCodigo.Location = New System.Drawing.Point(817, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(95, 29)
        Me.txtCodigo.TabIndex = 499
        Me.txtCodigo.Text = "1"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigo.Visible = False
        Me.txtCodigo.WatermarkColor = System.Drawing.SystemColors.ControlLightLight
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.ForestGreen
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX14.Location = New System.Drawing.Point(817, 9)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(95, 15)
        Me.LabelX14.TabIndex = 498
        Me.LabelX14.Text = "Nº CODIGO"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX14.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevo.Location = New System.Drawing.Point(464, 18)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(99, 21)
        Me.btnNuevo.TabIndex = 476
        Me.btnNuevo.Text = "Cargar"
        '
        'lbTitulo
        '
        Me.lbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(286, 47)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(613, 25)
        Me.lbTitulo.TabIndex = 593
        Me.lbTitulo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Timer2
        '
        Me.Timer2.Interval = 6000
        '
        'chk
        '
        Me.chk.FillWeight = 30.0!
        Me.chk.HeaderText = "*"
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 35.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Num."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 35
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 20
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 20
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unid."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cnt."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dispositivo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Raza"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 40
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cruza"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 40
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 40
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Width = 40
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Propietario"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tenencia"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 20
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Potrero"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 80
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn19.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn20.HeaderText = "Vida"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn20.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn21.HeaderText = "Traza."
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 40
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn22.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn22.Width = 30
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn23.HeaderText = "Dias Ubicacion Actual"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 150
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn24.HeaderText = "Orden"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 150
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "IdLinea"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "DiasUbica. Actual"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'numeracion
        '
        Me.numeracion.FillWeight = 40.0!
        Me.numeracion.HeaderText = "Ord."
        Me.numeracion.Name = "numeracion"
        Me.numeracion.ReadOnly = True
        Me.numeracion.Width = 40
        '
        'fecha
        '
        Me.fecha.FillWeight = 85.0!
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 85
        '
        'lote
        '
        Me.lote.FillWeight = 130.0!
        Me.lote.HeaderText = "Lotes"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        Me.lote.Width = 130
        '
        'dispositivo
        '
        Me.dispositivo.FillWeight = 130.0!
        Me.dispositivo.HeaderText = "Nº Disp."
        Me.dispositivo.Name = "dispositivo"
        Me.dispositivo.ReadOnly = True
        Me.dispositivo.Width = 130
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
        'IdEvento
        '
        Me.IdEvento.HeaderText = "IdEvento"
        Me.IdEvento.Name = "IdEvento"
        Me.IdEvento.ReadOnly = True
        Me.IdEvento.Visible = False
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.ReadOnly = True
        Me.evento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'IdEventoLin
        '
        Me.IdEventoLin.HeaderText = "IdEventoLin"
        Me.IdEventoLin.Name = "IdEventoLin"
        Me.IdEventoLin.ReadOnly = True
        Me.IdEventoLin.Visible = False
        '
        'eventoLin
        '
        Me.eventoLin.HeaderText = "Sub-Evento"
        Me.eventoLin.Name = "eventoLin"
        Me.eventoLin.ReadOnly = True
        Me.eventoLin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.eventoLin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Uni
        '
        Me.Uni.FillWeight = 40.0!
        Me.Uni.HeaderText = "Uni"
        Me.Uni.Name = "Uni"
        Me.Uni.ReadOnly = True
        Me.Uni.Width = 40
        '
        'cnt
        '
        Me.cnt.FillWeight = 40.0!
        Me.cnt.HeaderText = "cnt"
        Me.cnt.Name = "cnt"
        Me.cnt.ReadOnly = True
        Me.cnt.Width = 40
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
        'ubicacionDes
        '
        Me.ubicacionDes.HeaderText = "Destino"
        Me.ubicacionDes.Name = "ubicacionDes"
        Me.ubicacionDes.ReadOnly = True
        '
        'tenencia
        '
        Me.tenencia.FillWeight = 85.0!
        Me.tenencia.HeaderText = "Tenencia"
        Me.tenencia.Name = "tenencia"
        Me.tenencia.ReadOnly = True
        Me.tenencia.Width = 85
        '
        'idpotrero
        '
        Me.idpotrero.HeaderText = "idpotrero"
        Me.idpotrero.Name = "idpotrero"
        Me.idpotrero.ReadOnly = True
        Me.idpotrero.Visible = False
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
        'idpotreroDestino
        '
        Me.idpotreroDestino.HeaderText = "idpotreroDestino"
        Me.idpotreroDestino.Name = "idpotreroDestino"
        Me.idpotreroDestino.ReadOnly = True
        Me.idpotreroDestino.Visible = False
        '
        'potreroDes
        '
        Me.potreroDes.FillWeight = 120.0!
        Me.potreroDes.HeaderText = "Pot. Destino"
        Me.potreroDes.Name = "potreroDes"
        Me.potreroDes.ReadOnly = True
        Me.potreroDes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.potreroDes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.potreroDes.Width = 120
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
        Me.trazabilidad.HeaderText = "Traza"
        Me.trazabilidad.Name = "trazabilidad"
        Me.trazabilidad.ReadOnly = True
        Me.trazabilidad.Width = 85
        '
        'IdLinea
        '
        Me.IdLinea.HeaderText = "IdLinea"
        Me.IdLinea.Name = "IdLinea"
        Me.IdLinea.ReadOnly = True
        Me.IdLinea.Visible = False
        '
        'DiasUbicacionActual
        '
        Me.DiasUbicacionActual.HeaderText = "DiasUbica. Actual"
        Me.DiasUbicacionActual.Name = "DiasUbicacionActual"
        Me.DiasUbicacionActual.ReadOnly = True
        '
        'IUIngresoEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(1073, 593)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Text_drecibidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IUIngresoEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Trazabilidad - Ingreso de Eventos"
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.datagridbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NudMeses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Text_drecibidos As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboListaEventos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboListaEventosLineas As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboOperaciones As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTipoIngreso As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NudMeses As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboLote As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboSexo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboRaza As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboPotreros As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSeleccionados As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbpotdestino As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboPotreroDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboUbicacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboPropietario As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCruza As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboTenencia As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lbDescarga As DevComponents.DotNetBar.LabelX
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chInvertir As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenerarTxt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtGuia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDispositivoManual As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGrid As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbTitulo As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEliminar2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBusquedaDis As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents datagridbusqueda As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents numeracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dispositivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents raza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cruza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEvento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEventoLin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eventoLin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents propietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacionDes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tenencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idpotrero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents potrero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idpotreroDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents potreroDes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trazabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasUbicacionActual As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
