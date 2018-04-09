<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUBaston
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboPorts = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnConectar = New DevComponents.DotNetBar.ButtonX()
        Me.btnBuscarCom = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Text_denviados = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboPorts)
        Me.GroupBox1.Controls.Add(Me.btnConectar)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCom)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.Text_denviados)
        Me.GroupBox1.Controls.Add(Me.btnEnviar)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 157)
        Me.GroupBox1.TabIndex = 473
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comunicacion"
        '
        'ComboPorts
        '
        Me.ComboPorts.DisplayMember = "Text"
        Me.ComboPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPorts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboPorts.FormattingEnabled = True
        Me.ComboPorts.ItemHeight = 16
        Me.ComboPorts.Location = New System.Drawing.Point(202, 58)
        Me.ComboPorts.Name = "ComboPorts"
        Me.ComboPorts.Size = New System.Drawing.Size(136, 22)
        Me.ComboPorts.TabIndex = 510
        '
        'btnConectar
        '
        Me.btnConectar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConectar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnConectar.Location = New System.Drawing.Point(344, 55)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(112, 23)
        Me.btnConectar.TabIndex = 476
        Me.btnConectar.Text = "Concectar"
        '
        'btnBuscarCom
        '
        Me.btnBuscarCom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscarCom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBuscarCom.Location = New System.Drawing.Point(26, 55)
        Me.btnBuscarCom.Name = "btnBuscarCom"
        Me.btnBuscarCom.Size = New System.Drawing.Size(102, 25)
        Me.btnBuscarCom.TabIndex = 464
        Me.btnBuscarCom.Text = "Buscar COM"
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(143, 57)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(53, 20)
        Me.LabelX7.TabIndex = 463
        Me.LabelX7.Text = "Puertos:"
        '
        'Text_denviados
        '
        Me.Text_denviados.Location = New System.Drawing.Point(467, 58)
        Me.Text_denviados.Name = "Text_denviados"
        Me.Text_denviados.Size = New System.Drawing.Size(119, 20)
        Me.Text_denviados.TabIndex = 466
        Me.Text_denviados.Text = "*G"
        '
        'btnEnviar
        '
        Me.btnEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEnviar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEnviar.Location = New System.Drawing.Point(467, 88)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(119, 27)
        Me.btnEnviar.TabIndex = 461
        Me.btnEnviar.Text = "Enviar Datos"
        '
        'IUBaston
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 234)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "IUBaston"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IUBaston"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConectar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBuscarCom As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Text_denviados As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboPorts As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
