<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUReporteOperaciones
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
        Me.crvD1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvD1
        '
        Me.crvD1.ActiveViewIndex = -1
        Me.crvD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvD1.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvD1.Location = New System.Drawing.Point(0, 0)
        Me.crvD1.Name = "crvD1"
        Me.crvD1.SelectionFormula = ""
        Me.crvD1.Size = New System.Drawing.Size(851, 409)
        Me.crvD1.TabIndex = 6
        Me.crvD1.ViewTimeSelectionFormula = ""
        '
        'IUReporteOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 409)
        Me.Controls.Add(Me.crvD1)
        Me.Name = "IUReporteOperaciones"
        Me.Text = "IUReporteOperaciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvD1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
