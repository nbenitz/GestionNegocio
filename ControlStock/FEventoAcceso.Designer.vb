﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FEventoAcceso
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAccesos = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOpenDoor = New System.Windows.Forms.Button()
        Me.pnlListaIngreso = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConectado = New System.Windows.Forms.Label()
        Me.pnlSocioInfo = New System.Windows.Forms.Panel()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblTituloPendiente = New System.Windows.Forms.Label()
        Me.lblAtraso = New System.Windows.Forms.Label()
        Me.lblTituloAtraso = New System.Windows.Forms.Label()
        Me.btnCuota = New System.Windows.Forms.Button()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMembresia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrHide = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblUltimaClave = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvAccesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlListaIngreso.SuspendLayout()
        Me.pnlSocioInfo.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccesos
        '
        Me.dgvAccesos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvAccesos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAccesos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccesos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAccesos.ColumnHeadersHeight = 25
        Me.dgvAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAccesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.FechaCol, Me.NombreCol})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccesos.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvAccesos.Location = New System.Drawing.Point(12, 38)
        Me.dgvAccesos.Name = "dgvAccesos"
        Me.dgvAccesos.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccesos.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvAccesos.RowHeadersVisible = False
        Me.dgvAccesos.Size = New System.Drawing.Size(373, 183)
        Me.dgvAccesos.TabIndex = 2
        '
        'Cod
        '
        Me.Cod.Frozen = True
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Visible = False
        Me.Cod.Width = 60
        '
        'FechaCol
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.FechaCol.DefaultCellStyle = DataGridViewCellStyle7
        Me.FechaCol.Frozen = True
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        Me.FechaCol.ReadOnly = True
        Me.FechaCol.Width = 130
        '
        'NombreCol
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.NombreCol.DefaultCellStyle = DataGridViewCellStyle8
        Me.NombreCol.Frozen = True
        Me.NombreCol.HeaderText = "Nombre"
        Me.NombreCol.Name = "NombreCol"
        Me.NombreCol.ReadOnly = True
        Me.NombreCol.Width = 200
        '
        'btnOpenDoor
        '
        Me.btnOpenDoor.BackColor = System.Drawing.Color.Green
        Me.btnOpenDoor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpenDoor.ForeColor = System.Drawing.Color.White
        Me.btnOpenDoor.Location = New System.Drawing.Point(12, 123)
        Me.btnOpenDoor.Name = "btnOpenDoor"
        Me.btnOpenDoor.Size = New System.Drawing.Size(136, 29)
        Me.btnOpenDoor.TabIndex = 3
        Me.btnOpenDoor.Text = "Permitir Paso"
        Me.btnOpenDoor.UseVisualStyleBackColor = False
        Me.btnOpenDoor.Visible = False
        '
        'pnlListaIngreso
        '
        Me.pnlListaIngreso.Controls.Add(Me.Label1)
        Me.pnlListaIngreso.Controls.Add(Me.dgvAccesos)
        Me.pnlListaIngreso.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlListaIngreso.Location = New System.Drawing.Point(0, 168)
        Me.pnlListaIngreso.Name = "pnlListaIngreso"
        Me.pnlListaIngreso.Size = New System.Drawing.Size(382, 252)
        Me.pnlListaIngreso.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Últimos Ingresos"
        '
        'lblConectado
        '
        Me.lblConectado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblConectado.AutoSize = True
        Me.lblConectado.ForeColor = System.Drawing.Color.White
        Me.lblConectado.Location = New System.Drawing.Point(12, 526)
        Me.lblConectado.Name = "lblConectado"
        Me.lblConectado.Size = New System.Drawing.Size(77, 13)
        Me.lblConectado.TabIndex = 8
        Me.lblConectado.Text = "Desconectado"
        '
        'pnlSocioInfo
        '
        Me.pnlSocioInfo.Controls.Add(Me.btnOpenDoor)
        Me.pnlSocioInfo.Controls.Add(Me.pbxFoto)
        Me.pnlSocioInfo.Controls.Add(Me.lblSaldo)
        Me.pnlSocioInfo.Controls.Add(Me.lblTituloPendiente)
        Me.pnlSocioInfo.Controls.Add(Me.lblAtraso)
        Me.pnlSocioInfo.Controls.Add(Me.lblTituloAtraso)
        Me.pnlSocioInfo.Controls.Add(Me.btnCuota)
        Me.pnlSocioInfo.Controls.Add(Me.lblVencimiento)
        Me.pnlSocioInfo.Controls.Add(Me.Label6)
        Me.pnlSocioInfo.Controls.Add(Me.lblMembresia)
        Me.pnlSocioInfo.Controls.Add(Me.Label4)
        Me.pnlSocioInfo.Controls.Add(Me.lblNombre)
        Me.pnlSocioInfo.Controls.Add(Me.Label2)
        Me.pnlSocioInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSocioInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlSocioInfo.Name = "pnlSocioInfo"
        Me.pnlSocioInfo.Size = New System.Drawing.Size(382, 168)
        Me.pnlSocioInfo.TabIndex = 9
        Me.pnlSocioInfo.Visible = False
        '
        'pbxFoto
        '
        Me.pbxFoto.Image = Global.ControlStock.My.Resources.Resources.userblack
        Me.pbxFoto.Location = New System.Drawing.Point(12, 10)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(136, 142)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxFoto.TabIndex = 10
        Me.pbxFoto.TabStop = False
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Yellow
        Me.lblSaldo.Location = New System.Drawing.Point(309, 102)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(42, 13)
        Me.lblSaldo.TabIndex = 21
        Me.lblSaldo.Text = "30000"
        '
        'lblTituloPendiente
        '
        Me.lblTituloPendiente.AutoSize = True
        Me.lblTituloPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloPendiente.Location = New System.Drawing.Point(309, 84)
        Me.lblTituloPendiente.Name = "lblTituloPendiente"
        Me.lblTituloPendiente.Size = New System.Drawing.Size(65, 13)
        Me.lblTituloPendiente.TabIndex = 20
        Me.lblTituloPendiente.Text = "Saldo Pend."
        '
        'lblAtraso
        '
        Me.lblAtraso.AutoSize = True
        Me.lblAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtraso.ForeColor = System.Drawing.Color.Yellow
        Me.lblAtraso.Location = New System.Drawing.Point(309, 66)
        Me.lblAtraso.Name = "lblAtraso"
        Me.lblAtraso.Size = New System.Drawing.Size(14, 13)
        Me.lblAtraso.TabIndex = 19
        Me.lblAtraso.Text = "0"
        '
        'lblTituloAtraso
        '
        Me.lblTituloAtraso.AutoSize = True
        Me.lblTituloAtraso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloAtraso.Location = New System.Drawing.Point(309, 48)
        Me.lblTituloAtraso.Name = "lblTituloAtraso"
        Me.lblTituloAtraso.Size = New System.Drawing.Size(63, 13)
        Me.lblTituloAtraso.TabIndex = 18
        Me.lblTituloAtraso.Text = "Días Atraso"
        '
        'btnCuota
        '
        Me.btnCuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCuota.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuota.ForeColor = System.Drawing.Color.White
        Me.btnCuota.Location = New System.Drawing.Point(154, 123)
        Me.btnCuota.Name = "btnCuota"
        Me.btnCuota.Size = New System.Drawing.Size(217, 29)
        Me.btnCuota.TabIndex = 17
        Me.btnCuota.Text = "Cuota Vencida"
        Me.btnCuota.UseVisualStyleBackColor = False
        '
        'lblVencimiento
        '
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.ForeColor = System.Drawing.Color.White
        Me.lblVencimiento.Location = New System.Drawing.Point(154, 102)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(76, 13)
        Me.lblVencimiento.TabIndex = 16
        Me.lblVencimiento.Text = "Vencimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(154, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Vencimiento"
        '
        'lblMembresia
        '
        Me.lblMembresia.AutoSize = True
        Me.lblMembresia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembresia.ForeColor = System.Drawing.Color.White
        Me.lblMembresia.Location = New System.Drawing.Point(154, 66)
        Me.lblMembresia.Name = "lblMembresia"
        Me.lblMembresia.Size = New System.Drawing.Size(114, 13)
        Me.lblMembresia.TabIndex = 14
        Me.lblMembresia.Text = "Nombre Membresia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(154, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Membresia"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(154, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(154, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'tmrHide
        '
        Me.tmrHide.Interval = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Probar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 449)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "373"
        Me.TextBox1.Visible = False
        '
        'lblUltimaClave
        '
        Me.lblUltimaClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUltimaClave.AutoSize = True
        Me.lblUltimaClave.ForeColor = System.Drawing.Color.White
        Me.lblUltimaClave.Location = New System.Drawing.Point(252, 526)
        Me.lblUltimaClave.Name = "lblUltimaClave"
        Me.lblUltimaClave.Size = New System.Drawing.Size(16, 13)
        Me.lblUltimaClave.TabIndex = 12
        Me.lblUltimaClave.Text = "..."
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(146, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Última Clave Leída:"
        '
        'FEventoAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 548)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUltimaClave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblConectado)
        Me.Controls.Add(Me.pnlListaIngreso)
        Me.Controls.Add(Me.pnlSocioInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FEventoAcceso"
        Me.Text = "FEventoAcceso"
        CType(Me.dgvAccesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlListaIngreso.ResumeLayout(False)
        Me.pnlListaIngreso.PerformLayout()
        Me.pnlSocioInfo.ResumeLayout(False)
        Me.pnlSocioInfo.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAccesos As DataGridView
    Friend WithEvents btnOpenDoor As Button
    Friend WithEvents pnlListaIngreso As Panel
    Friend WithEvents lblConectado As Label
    Friend WithEvents pnlSocioInfo As Panel
    Friend WithEvents pbxFoto As PictureBox
    Friend WithEvents btnCuota As Button
    Friend WithEvents lblVencimiento As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMembresia As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAtraso As Label
    Friend WithEvents lblTituloAtraso As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblTituloPendiente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrHide As Timer
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents NombreCol As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblUltimaClave As Label
    Friend WithEvents Label3 As Label
End Class
