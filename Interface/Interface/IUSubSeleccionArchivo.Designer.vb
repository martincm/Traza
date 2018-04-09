<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUSubSeleccionArchivo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgvHistorial = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbTitulo = New DevComponents.DotNetBar.LabelX()
        CType(Me.dtgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvHistorial
        '
        Me.dtgvHistorial.AllowUserToAddRows = False
        Me.dtgvHistorial.AllowUserToOrderColumns = True
        Me.dtgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.fecha, Me.tarea, Me.archivo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvHistorial.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgvHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgvHistorial.Location = New System.Drawing.Point(12, 40)
        Me.dtgvHistorial.Name = "dtgvHistorial"
        Me.dtgvHistorial.RowHeadersWidth = 5
        Me.dtgvHistorial.Size = New System.Drawing.Size(518, 252)
        Me.dtgvHistorial.TabIndex = 547
        '
        'Id
        '
        Me.Id.FillWeight = 40.0!
        Me.Id.HeaderText = "Id."
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 40
        '
        'fecha
        '
        Me.fecha.FillWeight = 85.0!
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 85
        '
        'tarea
        '
        Me.tarea.FillWeight = 180.0!
        Me.tarea.HeaderText = "Tarea"
        Me.tarea.Name = "tarea"
        Me.tarea.ReadOnly = True
        Me.tarea.Width = 180
        '
        'archivo
        '
        Me.archivo.FillWeight = 200.0!
        Me.archivo.HeaderText = "Archivo"
        Me.archivo.Name = "archivo"
        Me.archivo.ReadOnly = True
        Me.archivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.archivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.archivo.Width = 200
        '
        'lbTitulo
        '
        Me.lbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbTitulo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(518, 25)
        Me.lbTitulo.TabIndex = 594
        Me.lbTitulo.Text = "Seleccione un lote"
        Me.lbTitulo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'IUSubSeleccionArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(553, 311)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.dtgvHistorial)
        Me.Name = "IUSubSeleccionArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion Lotes"
        CType(Me.dtgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgvHistorial As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents archivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbTitulo As DevComponents.DotNetBar.LabelX
End Class
