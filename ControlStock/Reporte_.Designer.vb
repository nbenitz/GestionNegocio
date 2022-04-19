<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtVto = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.Label()
        Me.txtProvVend = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.tagVto = New System.Windows.Forms.Label()
        Me.TagProvVend = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.TagId = New System.Windows.Forms.Label()
        Me.tagFecha = New System.Windows.Forms.Label()
        Me.tagSaldo = New System.Windows.Forms.Label()
        Me.txtEntregado = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.tagTotal = New System.Windows.Forms.Label()
        Me.tagEntregado = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.tagCliente = New System.Windows.Forms.Label()
        Me.Detalle = New System.Windows.Forms.DataGridView()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNotaInfo1 = New System.Windows.Forms.TextBox()
        Me.lblNotaInfo2 = New System.Windows.Forms.TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlEditCant = New System.Windows.Forms.Panel()
        Me.btnEditCantCancel = New System.Windows.Forms.Button()
        Me.txtEditCant = New System.Windows.Forms.TextBox()
        Me.lblEditCant = New System.Windows.Forms.Label()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlRecibo = New System.Windows.Forms.Panel()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditCant.SuspendLayout()
        Me.pnlRecibo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVto
        '
        Me.txtVto.AutoSize = True
        Me.txtVto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVto.Location = New System.Drawing.Point(542, 59)
        Me.txtVto.Name = "txtVto"
        Me.txtVto.Size = New System.Drawing.Size(27, 15)
        Me.txtVto.TabIndex = 102
        Me.txtVto.Text = "Vto:"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSize = True
        Me.txtCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(542, 38)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(49, 15)
        Me.txtCliente.TabIndex = 101
        Me.txtCliente.Text = "Cliente:"
        '
        'txtProvVend
        '
        Me.txtProvVend.AutoSize = True
        Me.txtProvVend.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvVend.Location = New System.Drawing.Point(89, 59)
        Me.txtProvVend.Name = "txtProvVend"
        Me.txtProvVend.Size = New System.Drawing.Size(66, 15)
        Me.txtProvVend.TabIndex = 100
        Me.txtProvVend.Text = "Proveedor:"
        '
        'txtNro
        '
        Me.txtNro.AutoSize = True
        Me.txtNro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro.Location = New System.Drawing.Point(89, 17)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(81, 15)
        Me.txtNro.TabIndex = 99
        Me.txtNro.Text = "Nro. Compra:"
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(89, 38)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(44, 15)
        Me.txtFecha.TabIndex = 98
        Me.txtFecha.Text = "Fecha:"
        '
        'tagVto
        '
        Me.tagVto.AutoSize = True
        Me.tagVto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagVto.Location = New System.Drawing.Point(509, 59)
        Me.tagVto.Name = "tagVto"
        Me.tagVto.Size = New System.Drawing.Size(29, 15)
        Me.tagVto.TabIndex = 97
        Me.tagVto.Text = "Vto:"
        '
        'TagProvVend
        '
        Me.TagProvVend.AutoSize = True
        Me.TagProvVend.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagProvVend.Location = New System.Drawing.Point(6, 59)
        Me.TagProvVend.Name = "TagProvVend"
        Me.TagProvVend.Size = New System.Drawing.Size(69, 15)
        Me.TagProvVend.TabIndex = 89
        Me.TagProvVend.Text = "Proveedor:"
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(253, 17)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(175, 22)
        Me.Titulo.TabIndex = 88
        Me.Titulo.Text = "Orden de Compra"
        '
        'TagId
        '
        Me.TagId.AutoSize = True
        Me.TagId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagId.Location = New System.Drawing.Point(6, 17)
        Me.TagId.Name = "TagId"
        Me.TagId.Size = New System.Drawing.Size(81, 15)
        Me.TagId.TabIndex = 87
        Me.TagId.Text = "Nro. Compra:"
        '
        'tagFecha
        '
        Me.tagFecha.AutoSize = True
        Me.tagFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagFecha.Location = New System.Drawing.Point(6, 38)
        Me.tagFecha.Name = "tagFecha"
        Me.tagFecha.Size = New System.Drawing.Size(44, 15)
        Me.tagFecha.TabIndex = 86
        Me.tagFecha.Text = "Fecha:"
        '
        'tagSaldo
        '
        Me.tagSaldo.AutoSize = True
        Me.tagSaldo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagSaldo.Location = New System.Drawing.Point(499, 416)
        Me.tagSaldo.Name = "tagSaldo"
        Me.tagSaldo.Size = New System.Drawing.Size(49, 16)
        Me.tagSaldo.TabIndex = 95
        Me.tagSaldo.Text = "Saldo:"
        '
        'txtEntregado
        '
        Me.txtEntregado.BackColor = System.Drawing.Color.White
        Me.txtEntregado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEntregado.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntregado.Location = New System.Drawing.Point(549, 390)
        Me.txtEntregado.Name = "txtEntregado"
        Me.txtEntregado.ReadOnly = True
        Me.txtEntregado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEntregado.Size = New System.Drawing.Size(102, 18)
        Me.txtEntregado.TabIndex = 94
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(549, 415)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldo.Size = New System.Drawing.Size(102, 18)
        Me.txtSaldo.TabIndex = 96
        '
        'tagTotal
        '
        Me.tagTotal.AutoSize = True
        Me.tagTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagTotal.Location = New System.Drawing.Point(505, 367)
        Me.tagTotal.Name = "tagTotal"
        Me.tagTotal.Size = New System.Drawing.Size(43, 16)
        Me.tagTotal.TabIndex = 93
        Me.tagTotal.Text = "Total:"
        '
        'tagEntregado
        '
        Me.tagEntregado.AutoSize = True
        Me.tagEntregado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagEntregado.Location = New System.Drawing.Point(471, 391)
        Me.tagEntregado.Name = "tagEntregado"
        Me.tagEntregado.Size = New System.Drawing.Size(77, 16)
        Me.tagEntregado.TabIndex = 91
        Me.tagEntregado.Text = "Entregado:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(549, 366)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(102, 18)
        Me.txtTotal.TabIndex = 92
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tagCliente
        '
        Me.tagCliente.AutoSize = True
        Me.tagCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagCliente.Location = New System.Drawing.Point(489, 38)
        Me.tagCliente.Name = "tagCliente"
        Me.tagCliente.Size = New System.Drawing.Size(49, 15)
        Me.tagCliente.TabIndex = 90
        Me.tagCliente.Text = "Cliente:"
        '
        'Detalle
        '
        Me.Detalle.AllowUserToAddRows = False
        Me.Detalle.AllowUserToDeleteRows = False
        Me.Detalle.AllowUserToResizeRows = False
        Me.Detalle.BackgroundColor = System.Drawing.Color.White
        Me.Detalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Del, Me.Cod, Me.Descrip, Me.Cant, Me.Precio, Me.Importe, Me.Unid, Me.Desc})
        Me.Detalle.Location = New System.Drawing.Point(9, 84)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.RowHeadersVisible = False
        Me.Detalle.Size = New System.Drawing.Size(659, 276)
        Me.Detalle.TabIndex = 85
        '
        'Del
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        Me.Del.DefaultCellStyle = DataGridViewCellStyle2
        Me.Del.HeaderText = ""
        Me.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Del.Name = "Del"
        Me.Del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Del.Visible = False
        Me.Del.Width = 22
        '
        'Cod
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Cod.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cod.FillWeight = 40.0!
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Descrip
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Descrip.DefaultCellStyle = DataGridViewCellStyle4
        Me.Descrip.HeaderText = "Descripción"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descrip.Width = 245
        '
        'Cant
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Precio
        '
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Importe
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle7
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Unid
        '
        Me.Unid.HeaderText = "Unidades"
        Me.Unid.Name = "Unid"
        Me.Unid.Visible = False
        '
        'Desc
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Desc.DefaultCellStyle = DataGridViewCellStyle8
        Me.Desc.HeaderText = "Desc"
        Me.Desc.Name = "Desc"
        Me.Desc.Visible = False
        Me.Desc.Width = 50
        '
        'lblNotaInfo1
        '
        Me.lblNotaInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNotaInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaInfo1.Location = New System.Drawing.Point(272, 364)
        Me.lblNotaInfo1.Multiline = True
        Me.lblNotaInfo1.Name = "lblNotaInfo1"
        Me.lblNotaInfo1.Size = New System.Drawing.Size(182, 32)
        Me.lblNotaInfo1.TabIndex = 103
        Me.lblNotaInfo1.Text = "Elimine los Productos de la Nota de Crédito que no desea devolver."
        Me.lblNotaInfo1.Visible = False
        '
        'lblNotaInfo2
        '
        Me.lblNotaInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNotaInfo2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaInfo2.Location = New System.Drawing.Point(272, 397)
        Me.lblNotaInfo2.Multiline = True
        Me.lblNotaInfo2.Name = "lblNotaInfo2"
        Me.lblNotaInfo2.Size = New System.Drawing.Size(182, 36)
        Me.lblNotaInfo2.TabIndex = 104
        Me.lblNotaInfo2.Text = "Cambie la cantidad de Productos si es necesario."
        Me.lblNotaInfo2.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.delete
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 20
        '
        'pnlEditCant
        '
        Me.pnlEditCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditCant.Controls.Add(Me.btnEditCantCancel)
        Me.pnlEditCant.Controls.Add(Me.txtEditCant)
        Me.pnlEditCant.Controls.Add(Me.lblEditCant)
        Me.pnlEditCant.Location = New System.Drawing.Point(355, 189)
        Me.pnlEditCant.Name = "pnlEditCant"
        Me.pnlEditCant.Size = New System.Drawing.Size(204, 70)
        Me.pnlEditCant.TabIndex = 105
        Me.pnlEditCant.Visible = False
        '
        'btnEditCantCancel
        '
        Me.btnEditCantCancel.BackColor = System.Drawing.Color.White
        Me.btnEditCantCancel.FlatAppearance.BorderSize = 0
        Me.btnEditCantCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCantCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCantCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnEditCantCancel.Location = New System.Drawing.Point(181, 3)
        Me.btnEditCantCancel.Name = "btnEditCantCancel"
        Me.btnEditCantCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnEditCantCancel.TabIndex = 71
        Me.btnEditCantCancel.UseVisualStyleBackColor = False
        '
        'txtEditCant
        '
        Me.txtEditCant.Location = New System.Drawing.Point(18, 34)
        Me.txtEditCant.Name = "txtEditCant"
        Me.txtEditCant.Size = New System.Drawing.Size(168, 20)
        Me.txtEditCant.TabIndex = 68
        '
        'lblEditCant
        '
        Me.lblEditCant.AutoSize = True
        Me.lblEditCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditCant.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEditCant.Location = New System.Drawing.Point(15, 10)
        Me.lblEditCant.Name = "lblEditCant"
        Me.lblEditCant.Size = New System.Drawing.Size(123, 18)
        Me.lblEditCant.TabIndex = 65
        Me.lblEditCant.Text = "Editar Cantidad"
        '
        'pnlRecibo
        '
        Me.pnlRecibo.Controls.Add(Me.pnlEditCant)
        Me.pnlRecibo.Controls.Add(Me.lblNotaInfo2)
        Me.pnlRecibo.Controls.Add(Me.lblNotaInfo1)
        Me.pnlRecibo.Controls.Add(Me.txtVto)
        Me.pnlRecibo.Controls.Add(Me.txtCliente)
        Me.pnlRecibo.Controls.Add(Me.txtProvVend)
        Me.pnlRecibo.Controls.Add(Me.txtNro)
        Me.pnlRecibo.Controls.Add(Me.txtFecha)
        Me.pnlRecibo.Controls.Add(Me.tagVto)
        Me.pnlRecibo.Controls.Add(Me.TagProvVend)
        Me.pnlRecibo.Controls.Add(Me.Titulo)
        Me.pnlRecibo.Controls.Add(Me.TagId)
        Me.pnlRecibo.Controls.Add(Me.tagFecha)
        Me.pnlRecibo.Controls.Add(Me.tagSaldo)
        Me.pnlRecibo.Controls.Add(Me.txtEntregado)
        Me.pnlRecibo.Controls.Add(Me.txtSaldo)
        Me.pnlRecibo.Controls.Add(Me.tagTotal)
        Me.pnlRecibo.Controls.Add(Me.tagEntregado)
        Me.pnlRecibo.Controls.Add(Me.txtTotal)
        Me.pnlRecibo.Controls.Add(Me.tagCliente)
        Me.pnlRecibo.Controls.Add(Me.Detalle)
        Me.pnlRecibo.Location = New System.Drawing.Point(0, 0)
        Me.pnlRecibo.Name = "pnlRecibo"
        Me.pnlRecibo.Size = New System.Drawing.Size(666, 451)
        Me.pnlRecibo.TabIndex = 106
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlRecibo)
        Me.Name = "Reporte"
        Me.Size = New System.Drawing.Size(666, 451)
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditCant.ResumeLayout(False)
        Me.pnlEditCant.PerformLayout()
        Me.pnlRecibo.ResumeLayout(False)
        Me.pnlRecibo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVto As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.Label
    Friend WithEvents txtProvVend As System.Windows.Forms.Label
    Friend WithEvents txtNro As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.Label
    Friend WithEvents tagVto As System.Windows.Forms.Label
    Friend WithEvents TagProvVend As System.Windows.Forms.Label
    Friend WithEvents Titulo As System.Windows.Forms.Label
    Friend WithEvents TagId As System.Windows.Forms.Label
    Friend WithEvents tagFecha As System.Windows.Forms.Label
    Friend WithEvents tagSaldo As System.Windows.Forms.Label
    Friend WithEvents txtEntregado As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents tagTotal As System.Windows.Forms.Label
    Friend WithEvents tagEntregado As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents tagCliente As System.Windows.Forms.Label
    Friend WithEvents Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblNotaInfo1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNotaInfo2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlEditCant As System.Windows.Forms.Panel
    Friend WithEvents btnEditCantCancel As System.Windows.Forms.Button
    Friend WithEvents txtEditCant As System.Windows.Forms.TextBox
    Friend WithEvents lblEditCant As System.Windows.Forms.Label
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Unid As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents pnlRecibo As Panel
End Class
