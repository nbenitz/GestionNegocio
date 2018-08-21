
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCajaMostrador
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
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.TxtMontoInicial = New System.Windows.Forms.TextBox()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblFecheApertura = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.ForeColor = System.Drawing.Color.White
        Me.LblMonto.Location = New System.Drawing.Point(21, 55)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(91, 18)
        Me.LblMonto.TabIndex = 84
        Me.LblMonto.Text = "Monto Inicial"
        '
        'TxtMontoInicial
        '
        Me.TxtMontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoInicial.Location = New System.Drawing.Point(118, 55)
        Me.TxtMontoInicial.Name = "TxtMontoInicial"
        Me.TxtMontoInicial.Size = New System.Drawing.Size(260, 22)
        Me.TxtMontoInicial.TabIndex = 0
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpleado.Location = New System.Drawing.Point(118, 21)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.ReadOnly = True
        Me.TxtEmpleado.Size = New System.Drawing.Size(260, 22)
        Me.TxtEmpleado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Empleado"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAceptar.Location = New System.Drawing.Point(118, 101)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 23)
        Me.btnAceptar.TabIndex = 89
        Me.btnAceptar.Text = "Abrir Caja"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(213, 101)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 23)
        Me.btnCancelar.TabIndex = 90
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        '
        'LblFecheApertura
        '
        Me.LblFecheApertura.AutoSize = True
        Me.LblFecheApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecheApertura.ForeColor = System.Drawing.Color.White
        Me.LblFecheApertura.Location = New System.Drawing.Point(115, 80)
        Me.LblFecheApertura.Name = "LblFecheApertura"
        Me.LblFecheApertura.Size = New System.Drawing.Size(61, 15)
        Me.LblFecheApertura.TabIndex = 91
        Me.LblFecheApertura.Text = "Abierto el "
        Me.LblFecheApertura.Visible = False
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(170, 82)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(57, 13)
        Me.LblFecha.TabIndex = 92
        Me.LblFecha.Text = "dd/mm/hh"
        Me.LblFecha.Visible = False
        '
        'FCajaMostrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(411, 142)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblFecheApertura)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.TxtEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMontoInicial)
        Me.Controls.Add(Me.LblMonto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FCajaMostrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMonto As System.Windows.Forms.Label
    Friend WithEvents TxtMontoInicial As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents LblFecheApertura As Label
    Friend WithEvents LblFecha As Label
End Class
