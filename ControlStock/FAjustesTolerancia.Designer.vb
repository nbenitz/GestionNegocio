<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAjustesTolerancia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtTol1 = New System.Windows.Forms.TextBox()
        Me.TxtTol3 = New System.Windows.Forms.TextBox()
        Me.LblPrecio3 = New System.Windows.Forms.Label()
        Me.TxtTol2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblPrecio2 = New System.Windows.Forms.Label()
        Me.LblPrecio1 = New System.Windows.Forms.Label()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.btnCancel.Location = New System.Drawing.Point(361, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(41, 38)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar")
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.btnGuardar.Location = New System.Drawing.Point(317, 206)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(41, 38)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 84
        Me.btnGuardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        '
        'TxtTol1
        '
        Me.TxtTol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTol1.Location = New System.Drawing.Point(309, 36)
        Me.TxtTol1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTol1.Name = "TxtTol1"
        Me.TxtTol1.Size = New System.Drawing.Size(68, 22)
        Me.TxtTol1.TabIndex = 1
        '
        'TxtTol3
        '
        Me.TxtTol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTol3.Location = New System.Drawing.Point(309, 136)
        Me.TxtTol3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTol3.Name = "TxtTol3"
        Me.TxtTol3.Size = New System.Drawing.Size(68, 22)
        Me.TxtTol3.TabIndex = 4
        '
        'LblPrecio3
        '
        Me.LblPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio3.ForeColor = System.Drawing.Color.White
        Me.LblPrecio3.Location = New System.Drawing.Point(18, 132)
        Me.LblPrecio3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio3.Name = "LblPrecio3"
        Me.LblPrecio3.Size = New System.Drawing.Size(283, 39)
        Me.LblPrecio3.TabIndex = 9
        Me.LblPrecio3.Text = "Margen de tolerancia para un cierre inesperado de la puerta"
        '
        'TxtTol2
        '
        Me.TxtTol2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTol2.Location = New System.Drawing.Point(309, 86)
        Me.TxtTol2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTol2.Name = "TxtTol2"
        Me.TxtTol2.Size = New System.Drawing.Size(68, 22)
        Me.TxtTol2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTol3)
        Me.GroupBox1.Controls.Add(Me.LblPrecio3)
        Me.GroupBox1.Controls.Add(Me.LblPrecio2)
        Me.GroupBox1.Controls.Add(Me.TxtTol1)
        Me.GroupBox1.Controls.Add(Me.LblPrecio1)
        Me.GroupBox1.Controls.Add(Me.TxtTol2)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(17, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 187)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajustes de Tolerancia"
        '
        'LblPrecio2
        '
        Me.LblPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio2.ForeColor = System.Drawing.Color.White
        Me.LblPrecio2.Location = New System.Drawing.Point(18, 82)
        Me.LblPrecio2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio2.Name = "LblPrecio2"
        Me.LblPrecio2.Size = New System.Drawing.Size(283, 43)
        Me.LblPrecio2.TabIndex = 8
        Me.LblPrecio2.Text = "Margen de tolerancia por abajo de la hora de salida del reporte"
        '
        'LblPrecio1
        '
        Me.LblPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio1.ForeColor = System.Drawing.Color.White
        Me.LblPrecio1.Location = New System.Drawing.Point(18, 31)
        Me.LblPrecio1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio1.Name = "LblPrecio1"
        Me.LblPrecio1.Size = New System.Drawing.Size(283, 44)
        Me.LblPrecio1.TabIndex = 6
        Me.LblPrecio1.Text = "Margen de tolerancia por arriba de la hora de entrada del reporte"
        '
        'FAjustesTolerancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 256)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FAjustesTolerancia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes"
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents TxtTol1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTol3 As System.Windows.Forms.TextBox
    Friend WithEvents LblPrecio3 As System.Windows.Forms.Label
    Friend WithEvents TxtTol2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblPrecio2 As System.Windows.Forms.Label
    Friend WithEvents LblPrecio1 As System.Windows.Forms.Label
End Class
