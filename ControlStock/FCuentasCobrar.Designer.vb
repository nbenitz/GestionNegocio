<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCuentasCobrar
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
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCuentasCobrar))
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle66 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSumaTotal = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mas = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEntrega = New System.Windows.Forms.Button()
        Me.txtCredEntrega = New System.Windows.Forms.TextBox()
        Me.btnCredOk = New System.Windows.Forms.Button()
        Me.lblCredGs = New System.Windows.Forms.Label()
        Me.btnCredCancel = New System.Windows.Forms.Button()
        Me.pnlCredito = New System.Windows.Forms.Panel()
        Me.pnlRecibo = New System.Windows.Forms.Panel()
        Me.txtVto = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.tagVto = New System.Windows.Forms.Label()
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
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCredito.SuspendLayout()
        Me.pnlRecibo.SuspendLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(584, 518)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 13)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "Suma Total"
        '
        'txtSumaTotal
        '
        Me.txtSumaTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtSumaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSumaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumaTotal.ForeColor = System.Drawing.Color.White
        Me.txtSumaTotal.Location = New System.Drawing.Point(587, 534)
        Me.txtSumaTotal.Name = "txtSumaTotal"
        Me.txtSumaTotal.ReadOnly = True
        Me.txtSumaTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSumaTotal.Size = New System.Drawing.Size(98, 24)
        Me.txtSumaTotal.TabIndex = 60
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(169, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(42, 13)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Ingrese"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbFiltrarPor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 502)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 69)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbFiltrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFiltrarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltrarPor.ForeColor = System.Drawing.Color.White
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Todos", "Nombre de Cliente", "CI"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(23, 32)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(134, 24)
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
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.White
        Me.txtBusqueda.Location = New System.Drawing.Point(172, 32)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(134, 24)
        Me.txtBusqueda.TabIndex = 44
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle52.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle52
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFactura, Me.Fecha, Me.Cliente, Me.concep, Me.Vto, Me.Total, Me.Entregado, Me.Saldo, Me.Mas})
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle59.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle59
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle60.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle60
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle61
        Me.DataGridView1.Size = New System.Drawing.Size(725, 451)
        Me.DataGridView1.TabIndex = 58
        '
        'NroFactura
        '
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle53.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.NroFactura.DefaultCellStyle = DataGridViewCellStyle53
        Me.NroFactura.HeaderText = "Nro. Venta"
        Me.NroFactura.Name = "NroFactura"
        Me.NroFactura.ReadOnly = True
        Me.NroFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NroFactura.Visible = False
        '
        'Fecha
        '
        DataGridViewCellStyle54.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle54
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 75
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cliente.Width = 120
        '
        'concep
        '
        Me.concep.HeaderText = "Concepto"
        Me.concep.Name = "concep"
        Me.concep.ReadOnly = True
        Me.concep.Width = 130
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
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle55.Format = "N0"
        DataGridViewCellStyle55.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle55
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.Width = 90
        '
        'Entregado
        '
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle56.Format = "N0"
        DataGridViewCellStyle56.NullValue = Nothing
        Me.Entregado.DefaultCellStyle = DataGridViewCellStyle56
        Me.Entregado.HeaderText = "Entregado"
        Me.Entregado.Name = "Entregado"
        Me.Entregado.ReadOnly = True
        Me.Entregado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Entregado.Width = 90
        '
        'Saldo
        '
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle57.Format = "N0"
        DataGridViewCellStyle57.NullValue = Nothing
        DataGridViewCellStyle57.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle57
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Saldo.Width = 90
        '
        'Mas
        '
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle58.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle58.NullValue = Nothing
        DataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Mas.DefaultCellStyle = DataGridViewCellStyle58
        Me.Mas.HeaderText = ""
        Me.Mas.Image = Global.ControlStock.My.Resources.Resources.apply1
        Me.Mas.Name = "Mas"
        Me.Mas.ReadOnly = True
        Me.Mas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Mas.Width = 22
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(9, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 25)
        Me.btnSalir.TabIndex = 63
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(83, 415)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 25)
        Me.btnCancelar.TabIndex = 64
        Me.btnCancelar.Text = "Cancelar Cuenta"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEntrega
        '
        Me.btnEntrega.BackColor = System.Drawing.Color.White
        Me.btnEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrega.Location = New System.Drawing.Point(220, 415)
        Me.btnEntrega.Name = "btnEntrega"
        Me.btnEntrega.Size = New System.Drawing.Size(142, 25)
        Me.btnEntrega.TabIndex = 65
        Me.btnEntrega.Text = "Realizar una Entrega"
        Me.btnEntrega.UseVisualStyleBackColor = False
        '
        'txtCredEntrega
        '
        Me.txtCredEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredEntrega.Location = New System.Drawing.Point(52, 21)
        Me.txtCredEntrega.Name = "txtCredEntrega"
        Me.txtCredEntrega.Size = New System.Drawing.Size(125, 20)
        Me.txtCredEntrega.TabIndex = 67
        '
        'btnCredOk
        '
        Me.btnCredOk.BackColor = System.Drawing.Color.White
        Me.btnCredOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCredOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredOk.Location = New System.Drawing.Point(21, 47)
        Me.btnCredOk.Name = "btnCredOk"
        Me.btnCredOk.Size = New System.Drawing.Size(70, 25)
        Me.btnCredOk.TabIndex = 68
        Me.btnCredOk.Text = "Aceptar"
        Me.btnCredOk.UseVisualStyleBackColor = False
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
        'btnCredCancel
        '
        Me.btnCredCancel.BackColor = System.Drawing.Color.White
        Me.btnCredCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCredCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredCancel.Location = New System.Drawing.Point(107, 47)
        Me.btnCredCancel.Name = "btnCredCancel"
        Me.btnCredCancel.Size = New System.Drawing.Size(70, 25)
        Me.btnCredCancel.TabIndex = 70
        Me.btnCredCancel.Text = "Cancelar"
        Me.btnCredCancel.UseVisualStyleBackColor = False
        '
        'pnlCredito
        '
        Me.pnlCredito.BackColor = System.Drawing.Color.White
        Me.pnlCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCredito.Controls.Add(Me.btnCredCancel)
        Me.pnlCredito.Controls.Add(Me.lblCredGs)
        Me.pnlCredito.Controls.Add(Me.btnCredOk)
        Me.pnlCredito.Controls.Add(Me.txtCredEntrega)
        Me.pnlCredito.Location = New System.Drawing.Point(308, 253)
        Me.pnlCredito.Name = "pnlCredito"
        Me.pnlCredito.Size = New System.Drawing.Size(204, 92)
        Me.pnlCredito.TabIndex = 66
        '
        'pnlRecibo
        '
        Me.pnlRecibo.BackColor = System.Drawing.Color.White
        Me.pnlRecibo.Controls.Add(Me.btnEntrega)
        Me.pnlRecibo.Controls.Add(Me.pnlCredito)
        Me.pnlRecibo.Controls.Add(Me.txtVto)
        Me.pnlRecibo.Controls.Add(Me.txtCliente)
        Me.pnlRecibo.Controls.Add(Me.btnCancelar)
        Me.pnlRecibo.Controls.Add(Me.txtNro)
        Me.pnlRecibo.Controls.Add(Me.btnSalir)
        Me.pnlRecibo.Controls.Add(Me.txtFecha)
        Me.pnlRecibo.Controls.Add(Me.tagVto)
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
        Me.pnlRecibo.Location = New System.Drawing.Point(38, 44)
        Me.pnlRecibo.Name = "pnlRecibo"
        Me.pnlRecibo.Size = New System.Drawing.Size(666, 451)
        Me.pnlRecibo.TabIndex = 119
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
        'txtNro
        '
        Me.txtNro.AutoSize = True
        Me.txtNro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro.Location = New System.Drawing.Point(89, 38)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(81, 15)
        Me.txtNro.TabIndex = 99
        Me.txtNro.Text = "Nro. Compra:"
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(89, 59)
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
        'TagId
        '
        Me.TagId.AutoSize = True
        Me.TagId.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagId.Location = New System.Drawing.Point(6, 38)
        Me.TagId.Name = "TagId"
        Me.TagId.Size = New System.Drawing.Size(55, 15)
        Me.TagId.TabIndex = 87
        Me.TagId.Text = "Número:"
        '
        'tagFecha
        '
        Me.tagFecha.AutoSize = True
        Me.tagFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagFecha.Location = New System.Drawing.Point(6, 59)
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
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle62.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle62
        Me.Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Descrip, Me.Cant, Me.Precio, Me.Importe})
        Me.Detalle.Location = New System.Drawing.Point(9, 84)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.RowHeadersVisible = False
        Me.Detalle.Size = New System.Drawing.Size(659, 276)
        Me.Detalle.TabIndex = 85
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle68.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle68.NullValue = Nothing
        DataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle68
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.apply1
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 22
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(750, 35)
        Me.pnlTopBar.TabIndex = 120
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(136, 16)
        Me.lblTitulo.TabIndex = 116
        Me.lblTitulo.Text = "Deudas de Socios"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(715, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'Cod
        '
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.Black
        Me.Cod.DefaultCellStyle = DataGridViewCellStyle63
        Me.Cod.FillWeight = 40.0!
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Descrip
        '
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.Black
        Me.Descrip.DefaultCellStyle = DataGridViewCellStyle64
        Me.Descrip.HeaderText = "Descripción"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descrip.Width = 245
        '
        'Cant
        '
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle65
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Precio
        '
        DataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle66.Format = "N0"
        DataGridViewCellStyle66.NullValue = Nothing
        DataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.Black
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle66
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Importe
        '
        DataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle67.Format = "N0"
        DataGridViewCellStyle67.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle67
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FCuentasCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 585)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlRecibo)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtSumaTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FCuentasCobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas a Cobrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCredito.ResumeLayout(False)
        Me.pnlCredito.PerformLayout()
        Me.pnlRecibo.ResumeLayout(False)
        Me.pnlRecibo.PerformLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtSumaTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Reporte1 As ControlStock.Reporte
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEntrega As Button
    Friend WithEvents txtCredEntrega As TextBox
    Friend WithEvents btnCredOk As Button
    Friend WithEvents lblCredGs As Label
    Friend WithEvents btnCredCancel As Button
    Friend WithEvents pnlCredito As Panel
    Friend WithEvents pnlRecibo As Panel
    Friend WithEvents txtVto As Label
    Friend WithEvents txtCliente As Label
    Friend WithEvents txtNro As Label
    Friend WithEvents txtFecha As Label
    Friend WithEvents tagVto As Label
    Friend WithEvents TagId As Label
    Friend WithEvents tagFecha As Label
    Friend WithEvents tagSaldo As Label
    Friend WithEvents txtEntregado As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents tagTotal As Label
    Friend WithEvents tagEntregado As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents tagCliente As Label
    Friend WithEvents Detalle As DataGridView
    Friend WithEvents NroFactura As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents concep As DataGridViewTextBoxColumn
    Friend WithEvents Vto As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Entregado As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Mas As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
