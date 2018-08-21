<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaVenta))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mas = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxImprimir = New System.Windows.Forms.PictureBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Reporte1 = New ControlStock.Reporte()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFactura, Me.Fecha, Me.Vendedor, Me.Cliente, Me.Total, Me.Mas})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(738, 456)
        Me.DataGridView1.TabIndex = 1
        '
        'NroFactura
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.NroFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.NroFactura.HeaderText = "Nro. Factura"
        Me.NroFactura.Name = "NroFactura"
        Me.NroFactura.ReadOnly = True
        Me.NroFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NroFactura.Width = 120
        '
        'Fecha
        '
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 150
        '
        'Vendedor
        '
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Vendedor.DefaultCellStyle = DataGridViewCellStyle4
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        Me.Vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Vendedor.Width = 150
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cliente.Width = 150
        '
        'Total
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Total.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.Width = 120
        '
        'Mas
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        Me.Mas.DefaultCellStyle = DataGridViewCellStyle6
        Me.Mas.HeaderText = ""
        Me.Mas.Name = "Mas"
        Me.Mas.ReadOnly = True
        Me.Mas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Mas.Width = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.cmbVendedor)
        Me.GroupBox1.Controls.Add(Me.lblVendedor)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbFiltrarPor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.txtNroFac)
        Me.GroupBox1.Controls.Add(Me.cmbAno)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 521)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 69)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(269, 32)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(106, 21)
        Me.cmbMes.TabIndex = 13
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(269, 32)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(106, 20)
        Me.dtpHasta.TabIndex = 55
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(266, 16)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 53
        Me.lblHasta.Text = "Hasta"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Items.AddRange(New Object() {"Todos", "Vendedor"})
        Me.cmbVendedor.Location = New System.Drawing.Point(401, 32)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(106, 21)
        Me.cmbVendedor.TabIndex = 48
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.ForeColor = System.Drawing.Color.White
        Me.lblVendedor.Location = New System.Drawing.Point(398, 16)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(61, 13)
        Me.lblVendedor.TabIndex = 47
        Me.lblVendedor.Text = "Vendedor"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(143, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(107, 13)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Ingrese Nro. Factura "
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Dia", "Mes", "Fecha", "Nro. Factura", "Todos"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(23, 32)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(106, 21)
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
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(146, 32)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 20)
        Me.dtpDesde.TabIndex = 54
        '
        'txtNroFac
        '
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.Location = New System.Drawing.Point(146, 32)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.Size = New System.Drawing.Size(117, 20)
        Me.txtNroFac.TabIndex = 44
        '
        'cmbAno
        '
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(146, 32)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(117, 21)
        Me.cmbAno.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(604, 553)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(155, 23)
        Me.txtTotal.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(601, 537)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Suma Total"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(53, 410)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 25)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(179, 410)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(74, 25)
        Me.btnRegistrar.TabIndex = 10
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        Me.btnRegistrar.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(125, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(510, 16)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Seleccione una Venta de la Lista al cual desea aplicar la Nota de Crédito"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pbxImprimir)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.Reporte1)
        Me.Panel1.Location = New System.Drawing.Point(21, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 456)
        Me.Panel1.TabIndex = 12
        '
        'pbxImprimir
        '
        Me.pbxImprimir.Image = Global.ControlStock.My.Resources.Resources.print
        Me.pbxImprimir.Location = New System.Drawing.Point(126, 405)
        Me.pbxImprimir.Name = "pbxImprimir"
        Me.pbxImprimir.Size = New System.Drawing.Size(37, 37)
        Me.pbxImprimir.TabIndex = 12
        Me.pbxImprimir.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.White
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.ControlStock.My.Resources.Resources.refresh1
        Me.btnActualizar.Location = New System.Drawing.Point(273, 410)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(32, 25)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.UseVisualStyleBackColor = False
        Me.btnActualizar.Visible = False
        '
        'Reporte1
        '
        Me.Reporte1.BackColor = System.Drawing.Color.White
        Me.Reporte1.Location = New System.Drawing.Point(36, 1)
        Me.Reporte1.Name = "Reporte1"
        Me.Reporte1.Size = New System.Drawing.Size(659, 451)
        Me.Reporte1.TabIndex = 8
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.NullValue = CType(resources.GetObject("DataGridViewCellStyle7.NullValue"), Object)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.go
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'FListaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 610)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FListaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Ventas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbxImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Reporte1 As ControlStock.Reporte
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents NroFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mas As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents pbxImprimir As System.Windows.Forms.PictureBox
End Class
