<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCuentasPagar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCuentasPagar))
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEntrega = New System.Windows.Forms.Button()
        Me.pnlCredito = New System.Windows.Forms.Panel()
        Me.btnCredCancel = New System.Windows.Forms.Button()
        Me.lblCredGs = New System.Windows.Forms.Label()
        Me.btnCredOk = New System.Windows.Forms.Button()
        Me.txtCredEntrega = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Reporte1 = New ControlStock.Reporte()
        Me.GroupBox1.SuspendLayout()
        Me.pnlCredito.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNroFac
        '
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.Location = New System.Drawing.Point(172, 32)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.Size = New System.Drawing.Size(134, 20)
        Me.txtNroFac.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbFiltrarPor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNroFac)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(38, 525)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 69)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(169, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(94, 13)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Ingrese Proveedor"
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Todos", "Proveedor"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(23, 32)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(134, 21)
        Me.cmbFiltrarPor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver Por"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(36, 465)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 25)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(542, 541)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 13)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Suma Total"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtTotal.Location = New System.Drawing.Point(545, 557)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(98, 20)
        Me.txtTotal.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(110, 465)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 25)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar Cuenta"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEntrega
        '
        Me.btnEntrega.BackColor = System.Drawing.Color.White
        Me.btnEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrega.Location = New System.Drawing.Point(247, 465)
        Me.btnEntrega.Name = "btnEntrega"
        Me.btnEntrega.Size = New System.Drawing.Size(142, 25)
        Me.btnEntrega.TabIndex = 15
        Me.btnEntrega.Text = "Realizar una Entrega"
        Me.btnEntrega.UseVisualStyleBackColor = False
        '
        'pnlCredito
        '
        Me.pnlCredito.BackColor = System.Drawing.Color.White
        Me.pnlCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCredito.Controls.Add(Me.btnCredCancel)
        Me.pnlCredito.Controls.Add(Me.lblCredGs)
        Me.pnlCredito.Controls.Add(Me.btnCredOk)
        Me.pnlCredito.Controls.Add(Me.txtCredEntrega)
        Me.pnlCredito.Location = New System.Drawing.Point(395, 398)
        Me.pnlCredito.Name = "pnlCredito"
        Me.pnlCredito.Size = New System.Drawing.Size(204, 92)
        Me.pnlCredito.TabIndex = 57
        '
        'btnCredCancel
        '
        Me.btnCredCancel.BackColor = System.Drawing.Color.White
        Me.btnCredCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredCancel.Location = New System.Drawing.Point(107, 47)
        Me.btnCredCancel.Name = "btnCredCancel"
        Me.btnCredCancel.Size = New System.Drawing.Size(70, 25)
        Me.btnCredCancel.TabIndex = 70
        Me.btnCredCancel.Text = "Cancelar"
        Me.btnCredCancel.UseVisualStyleBackColor = False
        '
        'lblCredGs
        '
        Me.lblCredGs.AutoSize = True
        Me.lblCredGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredGs.ForeColor = System.Drawing.Color.Black
        Me.lblCredGs.Location = New System.Drawing.Point(18, 22)
        Me.lblCredGs.Name = "lblCredGs"
        Me.lblCredGs.Size = New System.Drawing.Size(31, 16)
        Me.lblCredGs.TabIndex = 69
        Me.lblCredGs.Text = "Gs."
        '
        'btnCredOk
        '
        Me.btnCredOk.BackColor = System.Drawing.Color.White
        Me.btnCredOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredOk.Location = New System.Drawing.Point(21, 47)
        Me.btnCredOk.Name = "btnCredOk"
        Me.btnCredOk.Size = New System.Drawing.Size(70, 25)
        Me.btnCredOk.TabIndex = 68
        Me.btnCredOk.Text = "Aceptar"
        Me.btnCredOk.UseVisualStyleBackColor = False
        '
        'txtCredEntrega
        '
        Me.txtCredEntrega.Location = New System.Drawing.Point(52, 21)
        Me.txtCredEntrega.Name = "txtCredEntrega"
        Me.txtCredEntrega.Size = New System.Drawing.Size(125, 20)
        Me.txtCredEntrega.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(272, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Cuentas a Pagar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCompra, Me.Proveedor, Me.Fecha, Me.Vto, Me.Total, Me.Entregado, Me.Saldo, Me.Detalle})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(723, 462)
        Me.DataGridView1.TabIndex = 59
        '
        'NroCompra
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.NroCompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.NroCompra.HeaderText = "Nro. Compra"
        Me.NroCompra.Name = "NroCompra"
        Me.NroCompra.ReadOnly = True
        Me.NroCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Proveedor.Width = 120
        '
        'Fecha
        '
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 75
        '
        'Vto
        '
        Me.Vto.HeaderText = "Vto"
        Me.Vto.Name = "Vto"
        Me.Vto.ReadOnly = True
        Me.Vto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Vto.Width = 75
        '
        'Total
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Entregado
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Entregado.DefaultCellStyle = DataGridViewCellStyle4
        Me.Entregado.HeaderText = "Entregado"
        Me.Entregado.Name = "Entregado"
        Me.Entregado.ReadOnly = True
        Me.Entregado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Saldo
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Detalle
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        Me.Detalle.DefaultCellStyle = DataGridViewCellStyle6
        Me.Detalle.HeaderText = ""
        Me.Detalle.Image = Global.ControlStock.My.Resources.Resources.apply1
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        Me.Detalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.Width = 22
        '
        'Reporte1
        '
        Me.Reporte1.BackColor = System.Drawing.Color.White
        Me.Reporte1.Location = New System.Drawing.Point(13, 52)
        Me.Reporte1.Name = "Reporte1"
        Me.Reporte1.Size = New System.Drawing.Size(723, 462)
        Me.Reporte1.TabIndex = 60
        '
        'FCuentasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 612)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlCredito)
        Me.Controls.Add(Me.btnEntrega)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Reporte1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FCuentasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas a Pagar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlCredito.ResumeLayout(False)
        Me.pnlCredito.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents cmbFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEntrega As System.Windows.Forms.Button
    Friend WithEvents pnlCredito As System.Windows.Forms.Panel
    Friend WithEvents btnCredCancel As System.Windows.Forms.Button
    Friend WithEvents lblCredGs As System.Windows.Forms.Label
    Friend WithEvents btnCredOk As System.Windows.Forms.Button
    Friend WithEvents txtCredEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Reporte1 As ControlStock.Reporte
    Friend WithEvents NroCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entregado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As System.Windows.Forms.DataGridViewImageColumn
End Class
