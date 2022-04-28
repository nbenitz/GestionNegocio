<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSocioInfo
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
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblTituloPendiente = New System.Windows.Forms.Label()
        Me.lblAtraso = New System.Windows.Forms.Label()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.lblTituloAtraso = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMembresia = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.pnlSocioInfo = New System.Windows.Forms.Panel()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        Me.pnlSocioInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSaldo
        '
        Me.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Yellow
        Me.lblSaldo.Location = New System.Drawing.Point(411, 410)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(116, 37)
        Me.lblSaldo.TabIndex = 33
        Me.lblSaldo.Text = "30.000"
        '
        'lblTituloPendiente
        '
        Me.lblTituloPendiente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTituloPendiente.AutoSize = True
        Me.lblTituloPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloPendiente.Location = New System.Drawing.Point(411, 373)
        Me.lblTituloPendiente.Name = "lblTituloPendiente"
        Me.lblTituloPendiente.Size = New System.Drawing.Size(145, 29)
        Me.lblTituloPendiente.TabIndex = 32
        Me.lblTituloPendiente.Text = "Saldo Pend."
        '
        'lblAtraso
        '
        Me.lblAtraso.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAtraso.AutoSize = True
        Me.lblAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtraso.ForeColor = System.Drawing.Color.Yellow
        Me.lblAtraso.Location = New System.Drawing.Point(409, 296)
        Me.lblAtraso.Name = "lblAtraso"
        Me.lblAtraso.Size = New System.Drawing.Size(35, 37)
        Me.lblAtraso.TabIndex = 31
        Me.lblAtraso.Text = "0"
        '
        'pbxFoto
        '
        Me.pbxFoto.Image = Global.ControlStock.My.Resources.Resources.userblack
        Me.pbxFoto.Location = New System.Drawing.Point(31, 102)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(250, 250)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxFoto.TabIndex = 22
        Me.pbxFoto.TabStop = False
        '
        'lblTituloAtraso
        '
        Me.lblTituloAtraso.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTituloAtraso.AutoSize = True
        Me.lblTituloAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAtraso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloAtraso.Location = New System.Drawing.Point(411, 259)
        Me.lblTituloAtraso.Name = "lblTituloAtraso"
        Me.lblTituloAtraso.Size = New System.Drawing.Size(135, 29)
        Me.lblTituloAtraso.TabIndex = 30
        Me.lblTituloAtraso.Text = "Días Atraso"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNombre.Location = New System.Drawing.Point(55, 52)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(239, 37)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Nombre Cliente"
        '
        'lblVencimiento
        '
        Me.lblVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblVencimiento.Location = New System.Drawing.Point(55, 296)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(193, 37)
        Me.lblVencimiento.TabIndex = 28
        Me.lblVencimiento.Text = "Vencimiento"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(55, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Socia"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(55, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Vencimiento"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(55, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Membresia"
        '
        'lblMembresia
        '
        Me.lblMembresia.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMembresia.AutoSize = True
        Me.lblMembresia.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembresia.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMembresia.Location = New System.Drawing.Point(55, 177)
        Me.lblMembresia.Name = "lblMembresia"
        Me.lblMembresia.Size = New System.Drawing.Size(298, 37)
        Me.lblMembresia.TabIndex = 26
        Me.lblMembresia.Text = "Nombre Membresia"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(57, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Estado"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Lime
        Me.lblEstado.Location = New System.Drawing.Point(54, 403)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(101, 45)
        Me.lblEstado.TabIndex = 38
        Me.lblEstado.Text = "Al día"
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.pnlSocioInfo)
        Me.pnlInfo.Controls.Add(Me.pbxFoto)
        Me.pnlInfo.Location = New System.Drawing.Point(40, 32)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(960, 517)
        Me.pnlInfo.TabIndex = 39
        '
        'pnlSocioInfo
        '
        Me.pnlSocioInfo.Controls.Add(Me.lblEstado)
        Me.pnlSocioInfo.Controls.Add(Me.Label3)
        Me.pnlSocioInfo.Controls.Add(Me.lblSaldo)
        Me.pnlSocioInfo.Controls.Add(Me.lblTituloPendiente)
        Me.pnlSocioInfo.Controls.Add(Me.lblAtraso)
        Me.pnlSocioInfo.Controls.Add(Me.lblTituloAtraso)
        Me.pnlSocioInfo.Controls.Add(Me.lblNombre)
        Me.pnlSocioInfo.Controls.Add(Me.lblVencimiento)
        Me.pnlSocioInfo.Controls.Add(Me.Label2)
        Me.pnlSocioInfo.Controls.Add(Me.Label6)
        Me.pnlSocioInfo.Controls.Add(Me.Label4)
        Me.pnlSocioInfo.Controls.Add(Me.lblMembresia)
        Me.pnlSocioInfo.Location = New System.Drawing.Point(349, 18)
        Me.pnlSocioInfo.Name = "pnlSocioInfo"
        Me.pnlSocioInfo.Size = New System.Drawing.Size(580, 478)
        Me.pnlSocioInfo.TabIndex = 39
        Me.pnlSocioInfo.Visible = False
        '
        'FSocioInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 589)
        Me.Controls.Add(Me.pnlInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FSocioInfo"
        Me.Text = "FSocioInfo"
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlSocioInfo.ResumeLayout(False)
        Me.pnlSocioInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblTituloPendiente As Label
    Friend WithEvents lblAtraso As Label
    Friend WithEvents pbxFoto As PictureBox
    Friend WithEvents lblTituloAtraso As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblVencimiento As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMembresia As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents pnlSocioInfo As Panel
End Class
