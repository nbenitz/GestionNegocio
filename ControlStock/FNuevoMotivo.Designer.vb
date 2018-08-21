<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNuevoMotivo
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BtnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Motivo"
        '
        'txtMotivo
        '
        Me.txtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.Location = New System.Drawing.Point(73, 17)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(245, 22)
        Me.txtMotivo.TabIndex = 87
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.BtnGuardar.Location = New System.Drawing.Point(245, 45)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(41, 38)
        Me.BtnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnGuardar.TabIndex = 89
        Me.BtnGuardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Aceptar")
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.BtnCancel.Location = New System.Drawing.Point(285, 45)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(41, 38)
        Me.BtnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCancel.TabIndex = 88
        Me.BtnCancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnCancel, "Cancelar")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'FNuevoMotivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 95)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FNuevoMotivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Motivo"
        CType(Me.BtnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
