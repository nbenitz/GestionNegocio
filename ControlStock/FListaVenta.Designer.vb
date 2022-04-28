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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaVenta))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mas = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbxImprimir = New System.Windows.Forms.PictureBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pnlReporte = New System.Windows.Forms.Panel()
        Me.pnlEditCant = New System.Windows.Forms.Panel()
        Me.btnEditCantCancel = New System.Windows.Forms.Button()
        Me.txtEditCant = New System.Windows.Forms.TextBox()
        Me.lblEditCant = New System.Windows.Forms.Label()
        Me.lblNotaInfo2 = New System.Windows.Forms.TextBox()
        Me.lblNotaInfo1 = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.Label()
        Me.txtVend = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.TagVend = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.TagId = New System.Windows.Forms.Label()
        Me.tagFecha = New System.Windows.Forms.Label()
        Me.tagTotal = New System.Windows.Forms.Label()
        Me.txtTotal2 = New System.Windows.Forms.TextBox()
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
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReporte.SuspendLayout()
        Me.pnlEditCant.SuspendLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFactura, Me.Fecha, Me.Vendedor, Me.Cliente, Me.Total, Me.Mas})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(21, 91)
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
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Mas.DefaultCellStyle = DataGridViewCellStyle6
        Me.Mas.HeaderText = ""
        Me.Mas.Name = "Mas"
        Me.Mas.ReadOnly = True
        Me.Mas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Mas.Width = 22
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 553)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 69)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(269, 34)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(106, 21)
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
        Me.cmbVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVendedor.ForeColor = System.Drawing.Color.White
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Items.AddRange(New Object() {"Todos", "Vendedor"})
        Me.cmbVendedor.Location = New System.Drawing.Point(401, 33)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(106, 23)
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
        Me.cmbFiltrarPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbFiltrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFiltrarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltrarPor.ForeColor = System.Drawing.Color.White
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Dia", "Mes", "Fecha", "Nro. Factura", "Todos"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(23, 33)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(106, 23)
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
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(146, 34)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 21)
        Me.dtpDesde.TabIndex = 54
        '
        'txtNroFac
        '
        Me.txtNroFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.ForeColor = System.Drawing.Color.White
        Me.txtNroFac.Location = New System.Drawing.Point(146, 32)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.Size = New System.Drawing.Size(117, 22)
        Me.txtNroFac.TabIndex = 44
        '
        'cmbAno
        '
        Me.cmbAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAno.ForeColor = System.Drawing.Color.White
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(146, 33)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(117, 23)
        Me.cmbAno.TabIndex = 13
        '
        'cmbMes
        '
        Me.cmbMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.ForeColor = System.Drawing.Color.White
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(269, 33)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(106, 23)
        Me.cmbMes.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(604, 585)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(155, 22)
        Me.txtTotal.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(601, 569)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Suma Total"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(14, 410)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(140, 410)
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
        Me.lblTitulo.Location = New System.Drawing.Point(125, 52)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(510, 16)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Seleccione una Venta de la Lista al cual desea aplicar la Nota de Crédito"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitulo.Visible = False
        '
        'pbxImprimir
        '
        Me.pbxImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxImprimir.Image = Global.ControlStock.My.Resources.Resources.print
        Me.pbxImprimir.Location = New System.Drawing.Point(87, 405)
        Me.pbxImprimir.Name = "pbxImprimir"
        Me.pbxImprimir.Size = New System.Drawing.Size(35, 35)
        Me.pbxImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxImprimir.TabIndex = 12
        Me.pbxImprimir.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.White
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.ControlStock.My.Resources.Resources.refresh1
        Me.btnActualizar.Location = New System.Drawing.Point(234, 410)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(32, 25)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.UseVisualStyleBackColor = False
        Me.btnActualizar.Visible = False
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.NullValue = CType(resources.GetObject("DataGridViewCellStyle8.NullValue"), Object)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.go
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.Label2)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(779, 35)
        Me.pnlTopBar.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Lista de Ventas"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(744, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'pnlReporte
        '
        Me.pnlReporte.BackColor = System.Drawing.Color.White
        Me.pnlReporte.Controls.Add(Me.pbxImprimir)
        Me.pnlReporte.Controls.Add(Me.pnlEditCant)
        Me.pnlReporte.Controls.Add(Me.lblNotaInfo2)
        Me.pnlReporte.Controls.Add(Me.btnActualizar)
        Me.pnlReporte.Controls.Add(Me.lblNotaInfo1)
        Me.pnlReporte.Controls.Add(Me.btnSalir)
        Me.pnlReporte.Controls.Add(Me.btnRegistrar)
        Me.pnlReporte.Controls.Add(Me.txtCliente)
        Me.pnlReporte.Controls.Add(Me.txtVend)
        Me.pnlReporte.Controls.Add(Me.txtNro)
        Me.pnlReporte.Controls.Add(Me.txtFecha)
        Me.pnlReporte.Controls.Add(Me.TagVend)
        Me.pnlReporte.Controls.Add(Me.Titulo)
        Me.pnlReporte.Controls.Add(Me.TagId)
        Me.pnlReporte.Controls.Add(Me.tagFecha)
        Me.pnlReporte.Controls.Add(Me.tagTotal)
        Me.pnlReporte.Controls.Add(Me.txtTotal2)
        Me.pnlReporte.Controls.Add(Me.tagCliente)
        Me.pnlReporte.Controls.Add(Me.Detalle)
        Me.pnlReporte.Location = New System.Drawing.Point(24, 92)
        Me.pnlReporte.Name = "pnlReporte"
        Me.pnlReporte.Size = New System.Drawing.Size(665, 450)
        Me.pnlReporte.TabIndex = 107
        '
        'pnlEditCant
        '
        Me.pnlEditCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditCant.Controls.Add(Me.btnEditCantCancel)
        Me.pnlEditCant.Controls.Add(Me.txtEditCant)
        Me.pnlEditCant.Controls.Add(Me.lblEditCant)
        Me.pnlEditCant.Location = New System.Drawing.Point(350, 188)
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
        'lblNotaInfo2
        '
        Me.lblNotaInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNotaInfo2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaInfo2.Location = New System.Drawing.Point(274, 397)
        Me.lblNotaInfo2.Multiline = True
        Me.lblNotaInfo2.Name = "lblNotaInfo2"
        Me.lblNotaInfo2.Size = New System.Drawing.Size(182, 36)
        Me.lblNotaInfo2.TabIndex = 104
        Me.lblNotaInfo2.Text = "Cambie la cantidad de Productos si es necesario."
        Me.lblNotaInfo2.Visible = False
        '
        'lblNotaInfo1
        '
        Me.lblNotaInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNotaInfo1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaInfo1.Location = New System.Drawing.Point(274, 364)
        Me.lblNotaInfo1.Multiline = True
        Me.lblNotaInfo1.Name = "lblNotaInfo1"
        Me.lblNotaInfo1.Size = New System.Drawing.Size(182, 32)
        Me.lblNotaInfo1.TabIndex = 103
        Me.lblNotaInfo1.Text = "Elimine los Productos de la Nota de Crédito que no desea devolver."
        Me.lblNotaInfo1.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.AutoSize = True
        Me.txtCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(538, 38)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(49, 15)
        Me.txtCliente.TabIndex = 101
        Me.txtCliente.Text = "Cliente:"
        '
        'txtVend
        '
        Me.txtVend.AutoSize = True
        Me.txtVend.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVend.Location = New System.Drawing.Point(85, 59)
        Me.txtVend.Name = "txtVend"
        Me.txtVend.Size = New System.Drawing.Size(59, 15)
        Me.txtVend.TabIndex = 100
        Me.txtVend.Text = "Vendedor"
        '
        'txtNro
        '
        Me.txtNro.AutoSize = True
        Me.txtNro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro.Location = New System.Drawing.Point(85, 17)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(81, 15)
        Me.txtNro.TabIndex = 99
        Me.txtNro.Text = "Nro. Compra:"
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(85, 38)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(44, 15)
        Me.txtFecha.TabIndex = 98
        Me.txtFecha.Text = "Fecha:"
        '
        'TagVend
        '
        Me.TagVend.AutoSize = True
        Me.TagVend.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagVend.Location = New System.Drawing.Point(2, 59)
        Me.TagVend.Name = "TagVend"
        Me.TagVend.Size = New System.Drawing.Size(64, 15)
        Me.TagVend.TabIndex = 89
        Me.TagVend.Text = "Vendedor:"
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(249, 17)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(137, 22)
        Me.Titulo.TabIndex = 88
        Me.Titulo.Text = "Nota de Venta"
        '
        'TagId
        '
        Me.TagId.AutoSize = True
        Me.TagId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagId.Location = New System.Drawing.Point(2, 17)
        Me.TagId.Name = "TagId"
        Me.TagId.Size = New System.Drawing.Size(81, 15)
        Me.TagId.TabIndex = 87
        Me.TagId.Text = "Nro. Compra:"
        '
        'tagFecha
        '
        Me.tagFecha.AutoSize = True
        Me.tagFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagFecha.Location = New System.Drawing.Point(2, 38)
        Me.tagFecha.Name = "tagFecha"
        Me.tagFecha.Size = New System.Drawing.Size(44, 15)
        Me.tagFecha.TabIndex = 86
        Me.tagFecha.Text = "Fecha:"
        '
        'tagTotal
        '
        Me.tagTotal.AutoSize = True
        Me.tagTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagTotal.Location = New System.Drawing.Point(484, 413)
        Me.tagTotal.Name = "tagTotal"
        Me.tagTotal.Size = New System.Drawing.Size(48, 20)
        Me.tagTotal.TabIndex = 93
        Me.tagTotal.Text = "Total:"
        '
        'txtTotal2
        '
        Me.txtTotal2.BackColor = System.Drawing.Color.White
        Me.txtTotal2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal2.ForeColor = System.Drawing.Color.Black
        Me.txtTotal2.Location = New System.Drawing.Point(538, 413)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.ReadOnly = True
        Me.txtTotal2.Size = New System.Drawing.Size(110, 20)
        Me.txtTotal2.TabIndex = 92
        Me.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tagCliente
        '
        Me.tagCliente.AutoSize = True
        Me.tagCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagCliente.Location = New System.Drawing.Point(485, 38)
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Del, Me.Cod, Me.Descrip, Me.Cant, Me.Precio, Me.Importe, Me.Unid, Me.Desc})
        Me.Detalle.Location = New System.Drawing.Point(5, 84)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.RowHeadersVisible = False
        Me.Detalle.Size = New System.Drawing.Size(659, 276)
        Me.Detalle.TabIndex = 85
        '
        'Del
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.NullValue = Nothing
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        Me.Del.DefaultCellStyle = DataGridViewCellStyle10
        Me.Del.HeaderText = ""
        Me.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Del.Name = "Del"
        Me.Del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Del.Visible = False
        Me.Del.Width = 22
        '
        'Cod
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Cod.DefaultCellStyle = DataGridViewCellStyle11
        Me.Cod.FillWeight = 40.0!
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Descrip
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Descrip.DefaultCellStyle = DataGridViewCellStyle12
        Me.Descrip.HeaderText = "Descripción"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descrip.Width = 245
        '
        'Cant
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle13
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Precio
        '
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle14
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Importe
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle15
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
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle16.Format = "N0"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.Desc.DefaultCellStyle = DataGridViewCellStyle16
        Me.Desc.HeaderText = "Desc"
        Me.Desc.Name = "Desc"
        Me.Desc.Visible = False
        Me.Desc.Width = 50
        '
        'FListaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 645)
        Me.Controls.Add(Me.pnlReporte)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FListaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Ventas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReporte.ResumeLayout(False)
        Me.pnlReporte.PerformLayout()
        Me.pnlEditCant.ResumeLayout(False)
        Me.pnlEditCant.PerformLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents pbxImprimir As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlReporte As Panel
    Friend WithEvents pnlEditCant As Panel
    Friend WithEvents btnEditCantCancel As Button
    Friend WithEvents txtEditCant As TextBox
    Friend WithEvents lblEditCant As Label
    Friend WithEvents lblNotaInfo2 As TextBox
    Friend WithEvents lblNotaInfo1 As TextBox
    Friend WithEvents txtCliente As Label
    Friend WithEvents txtVend As Label
    Friend WithEvents txtNro As Label
    Friend WithEvents txtFecha As Label
    Friend WithEvents TagVend As Label
    Friend WithEvents Titulo As Label
    Friend WithEvents TagId As Label
    Friend WithEvents tagFecha As Label
    Friend WithEvents tagTotal As Label
    Friend WithEvents txtTotal2 As TextBox
    Friend WithEvents tagCliente As Label
    Friend WithEvents Detalle As DataGridView
    Friend WithEvents NroFactura As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Mas As DataGridViewImageColumn
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Unid As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip2 As ToolTip
End Class
