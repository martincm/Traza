<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUIngresoFormulariosEscaneados
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
        Me.BtnImagen = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Dud1 = New System.Windows.Forms.NumericUpDown()
        Me.Dud3 = New System.Windows.Forms.NumericUpDown()
        Me.Dud2 = New System.Windows.Forms.NumericUpDown()
        Me.Dud4 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lsDispositivos = New System.Windows.Forms.ListBox()
        Me.nudLecturas = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudInicioY = New System.Windows.Forms.NumericUpDown()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dud3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dud4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLecturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInicioY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnImagen
        '
        Me.BtnImagen.Location = New System.Drawing.Point(568, 25)
        Me.BtnImagen.Name = "BtnImagen"
        Me.BtnImagen.Size = New System.Drawing.Size(102, 23)
        Me.BtnImagen.TabIndex = 0
        Me.BtnImagen.Text = "ConvertirTodo"
        Me.BtnImagen.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(658, 409)
        Me.SplitContainer1.SplitterDistance = 331
        Me.SplitContainer1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 405)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 409)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Texto Completo"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(677, 226)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(233, 149)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(688, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(209, 81)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(822, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Recorte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dud1
        '
        Me.Dud1.Location = New System.Drawing.Point(708, 25)
        Me.Dud1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Dud1.Name = "Dud1"
        Me.Dud1.Size = New System.Drawing.Size(51, 20)
        Me.Dud1.TabIndex = 8
        Me.Dud1.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Dud3
        '
        Me.Dud3.Location = New System.Drawing.Point(708, 67)
        Me.Dud3.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Dud3.Name = "Dud3"
        Me.Dud3.Size = New System.Drawing.Size(51, 20)
        Me.Dud3.TabIndex = 9
        Me.Dud3.Value = New Decimal(New Integer() {370, 0, 0, 0})
        '
        'Dud2
        '
        Me.Dud2.Location = New System.Drawing.Point(765, 25)
        Me.Dud2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Dud2.Name = "Dud2"
        Me.Dud2.Size = New System.Drawing.Size(51, 20)
        Me.Dud2.TabIndex = 10
        Me.Dud2.Value = New Decimal(New Integer() {800, 0, 0, 0})
        '
        'Dud4
        '
        Me.Dud4.Location = New System.Drawing.Point(765, 67)
        Me.Dud4.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Dud4.Name = "Dud4"
        Me.Dud4.Size = New System.Drawing.Size(51, 20)
        Me.Dud4.TabIndex = 11
        Me.Dud4.Value = New Decimal(New Integer() {79, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(713, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "W"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(762, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "H"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(762, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(713, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "X"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(803, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "ContarBlancos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(564, 480)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Leer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Datos"
        '
        'lsDispositivos
        '
        Me.lsDispositivos.FormattingEnabled = True
        Me.lsDispositivos.Location = New System.Drawing.Point(12, 480)
        Me.lsDispositivos.Name = "lsDispositivos"
        Me.lsDispositivos.ScrollAlwaysVisible = True
        Me.lsDispositivos.Size = New System.Drawing.Size(546, 95)
        Me.lsDispositivos.TabIndex = 26
        '
        'nudLecturas
        '
        Me.nudLecturas.Location = New System.Drawing.Point(564, 509)
        Me.nudLecturas.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudLecturas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLecturas.Name = "nudLecturas"
        Me.nudLecturas.Size = New System.Drawing.Size(51, 20)
        Me.nudLecturas.TabIndex = 27
        Me.nudLecturas.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(563, 537)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Y"
        '
        'nudInicioY
        '
        Me.nudInicioY.Location = New System.Drawing.Point(583, 535)
        Me.nudInicioY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudInicioY.Name = "nudInicioY"
        Me.nudInicioY.Size = New System.Drawing.Size(51, 20)
        Me.nudInicioY.TabIndex = 28
        Me.nudInicioY.Value = New Decimal(New Integer() {800, 0, 0, 0})
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(320, 394)
        Me.ListBox1.TabIndex = 27
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(276, 20)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 30
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(49, 23)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(221, 20)
        Me.txtRuta.TabIndex = 31
        Me.txtRuta.Text = "C:\Users\Martin\Desktop\d1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Ruta"
        '
        'IUIngresoFormulariosEscaneados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(921, 594)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.nudInicioY)
        Me.Controls.Add(Me.nudLecturas)
        Me.Controls.Add(Me.lsDispositivos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dud4)
        Me.Controls.Add(Me.Dud2)
        Me.Controls.Add(Me.Dud3)
        Me.Controls.Add(Me.Dud1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BtnImagen)
        Me.Name = "IUIngresoFormulariosEscaneados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Trazabilidad - Ingreso Formularios Escaneados"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dud3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dud4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLecturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInicioY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnImagen As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Dud1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Dud3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Dud2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Dud4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lsDispositivos As System.Windows.Forms.ListBox
    Friend WithEvents nudLecturas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudInicioY As System.Windows.Forms.NumericUpDown
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
