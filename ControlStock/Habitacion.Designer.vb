<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Habitacion
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblHabitacion = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OcupadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturarPorNocheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHabitacion
        '
        Me.lblHabitacion.AutoSize = True
        Me.lblHabitacion.BackColor = System.Drawing.Color.Black
        Me.lblHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblHabitacion.ForeColor = System.Drawing.Color.White
        Me.lblHabitacion.Location = New System.Drawing.Point(3, 5)
        Me.lblHabitacion.Name = "lblHabitacion"
        Me.lblHabitacion.Size = New System.Drawing.Size(21, 22)
        Me.lblHabitacion.TabIndex = 0
        Me.lblHabitacion.Text = "2"
        Me.lblHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTiempo
        '
        Me.lblTiempo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiempo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.ForeColor = System.Drawing.Color.White
        Me.lblTiempo.Location = New System.Drawing.Point(6, 79)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(174, 28)
        Me.lblTiempo.TabIndex = 1
        Me.lblTiempo.Text = "Libre"
        Me.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OcupadoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 26)
        '
        'OcupadoToolStripMenuItem
        '
        Me.OcupadoToolStripMenuItem.Name = "OcupadoToolStripMenuItem"
        Me.OcupadoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.OcupadoToolStripMenuItem.Text = "Ocupar"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem, Me.FacturarPorNocheToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(177, 48)
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturaToolStripMenuItem.Text = "Ver Factura"
        '
        'FacturarPorNocheToolStripMenuItem
        '
        Me.FacturarPorNocheToolStripMenuItem.Name = "FacturarPorNocheToolStripMenuItem"
        Me.FacturarPorNocheToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturarPorNocheToolStripMenuItem.Text = "Facturar por Noche"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Habitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblHabitacion)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Habitacion"
        Me.Size = New System.Drawing.Size(180, 130)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHabitacion As System.Windows.Forms.Label
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OcupadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FacturarPorNocheToolStripMenuItem As ToolStripMenuItem
End Class
