<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FVentaGym
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVentaGym))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTotal = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlVenta = New System.Windows.Forms.Panel()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pnlXPack = New System.Windows.Forms.Panel()
        Me.btnUnidad = New System.Windows.Forms.Button()
        Me.btnPack = New System.Windows.Forms.Button()
        Me.btnPackCancel = New System.Windows.Forms.Button()
        Me.lblTituloXPack = New System.Windows.Forms.Label()
        Me.pnlPrecios = New System.Windows.Forms.Panel()
        Me.txtEditPrecio = New System.Windows.Forms.TextBox()
        Me.lblTitPrecio1 = New System.Windows.Forms.Label()
        Me.lblTitPrecio2 = New System.Windows.Forms.Label()
        Me.optPrecio3 = New System.Windows.Forms.RadioButton()
        Me.optPrecio2 = New System.Windows.Forms.RadioButton()
        Me.optPrecio1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitPrecios = New System.Windows.Forms.Label()
        Me.pnlEditCant = New System.Windows.Forms.Panel()
        Me.btnEditCantCancel = New System.Windows.Forms.Button()
        Me.txtEditCant = New System.Windows.Forms.TextBox()
        Me.lblEditCant = New System.Windows.Forms.Label()
        Me.pnlPiso = New System.Windows.Forms.Panel()
        Me.btnPorUnidad = New System.Windows.Forms.Button()
        Me.btnPorMetro = New System.Windows.Forms.Button()
        Me.btnPorCaja = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbxCrearProd = New System.Windows.Forms.PictureBox()
        Me.pnlCrearProd = New System.Windows.Forms.Panel()
        Me.ChkGenerar = New System.Windows.Forms.CheckBox()
        Me.btnNuevoPOk = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtNuevoPImporte = New System.Windows.Forms.TextBox()
        Me.txtNuevoPPrecio = New System.Windows.Forms.TextBox()
        Me.txtNuevoPCant = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNuevoPDescrip = New System.Windows.Forms.TextBox()
        Me.btnNuevoPCancel = New System.Windows.Forms.Button()
        Me.txtNuevoPCod = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblHab2 = New System.Windows.Forms.Label()
        Me.lblHab = New System.Windows.Forms.Label()
        Me.LblTituloHab = New System.Windows.Forms.Label()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.chkMayorista = New System.Windows.Forms.CheckBox()
        Me.pbxBuscCli = New System.Windows.Forms.PictureBox()
        Me.pnlCredito = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpVto = New System.Windows.Forms.DateTimePicker()
        Me.btnCredCancel = New System.Windows.Forms.Button()
        Me.lblCredGs = New System.Windows.Forms.Label()
        Me.btnCredOk = New System.Windows.Forms.Button()
        Me.txtCredEntrega = New System.Windows.Forms.TextBox()
        Me.btnCredNo = New System.Windows.Forms.Button()
        Me.btnCredSi = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optCredito = New System.Windows.Forms.RadioButton()
        Me.optContado = New System.Windows.Forms.RadioButton()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.pnlProdInfo = New System.Windows.Forms.Panel()
        Me.pnlPrecVenta = New System.Windows.Forms.Panel()
        Me.pnlInfoPiso = New System.Windows.Forms.Panel()
        Me.lblUnidxCaja = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblMxCaja = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPrecUnidP = New System.Windows.Forms.Label()
        Me.lblPrecPack = New System.Windows.Forms.Label()
        Me.lblPrecUnit = New System.Windows.Forms.Label()
        Me.lblPrecio1 = New System.Windows.Forms.Label()
        Me.lblPrecio2 = New System.Windows.Forms.Label()
        Me.lblPrecio3 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblInfoCod = New System.Windows.Forms.Label()
        Me.lblInfoDesc = New System.Windows.Forms.Label()
        Me.lblInfoStock = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblInfoPrec = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblInfoPrec2 = New System.Windows.Forms.Label()
        Me.pnlBuscProd = New System.Windows.Forms.Panel()
        Me.pbxNewProd = New System.Windows.Forms.PictureBox()
        Me.lblUnidXpack = New System.Windows.Forms.Label()
        Me.pnlVenderPor = New System.Windows.Forms.Panel()
        Me.optPaquete = New System.Windows.Forms.RadioButton()
        Me.optUnidad = New System.Windows.Forms.RadioButton()
        Me.lblVenderPor = New System.Windows.Forms.Label()
        Me.txtDescuent = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.cmbDescrip = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.chkDesc = New System.Windows.Forms.CheckBox()
        Me.optCod = New System.Windows.Forms.RadioButton()
        Me.optDesc = New System.Windows.Forms.RadioButton()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlAddRapido = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVenta.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlXPack.SuspendLayout()
        Me.pnlPrecios.SuspendLayout()
        Me.pnlEditCant.SuspendLayout()
        Me.pnlPiso.SuspendLayout()
        CType(Me.pbxCrearProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCrearProd.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCredito.SuspendLayout()
        Me.pnlProdInfo.SuspendLayout()
        Me.pnlPrecVenta.SuspendLayout()
        Me.pnlInfoPiso.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscProd.SuspendLayout()
        CType(Me.pbxNewProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVenderPor.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlAddRapido.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Del, Me.Cod, Me.Descripcion, Me.Cantt, Me.Precio, Me.Importe, Me.Descuento, Me.Unidades, Me.Obs, Me.Iva})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(565, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'Del
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        Me.Del.DefaultCellStyle = DataGridViewCellStyle1
        Me.Del.HeaderText = ""
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Del.Width = 22
        '
        'Cod
        '
        Me.Cod.FillWeight = 40.0!
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cod.Width = 74
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descripcion.Width = 235
        '
        'Cantt
        '
        Me.Cantt.HeaderText = "Cant"
        Me.Cantt.Name = "Cantt"
        Me.Cantt.ReadOnly = True
        Me.Cantt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cantt.Width = 65
        '
        'Precio
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Precio.Width = 75
        '
        'Importe
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle3
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Importe.Width = 75
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Desc"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descuento.Visible = False
        Me.Descuento.Width = 50
        '
        'Unidades
        '
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        Me.Unidades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Unidades.Visible = False
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Obs.Visible = False
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.ReadOnly = True
        Me.Iva.Visible = False
        Me.Iva.Width = 50
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(433, 495)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(138, 31)
        Me.txtTotal.TabIndex = 38
        Me.txtTotal.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'tmrTotal
        '
        Me.tmrTotal.Interval = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(298, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 25)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Total a Pagar"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(245, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(67, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Precios de Venta"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(245, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Descrip."
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(245, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cód."
        '
        'pnlVenta
        '
        Me.pnlVenta.BackColor = System.Drawing.Color.White
        Me.pnlVenta.Controls.Add(Me.BtnCerrarForm)
        Me.pnlVenta.Controls.Add(Me.pnlXPack)
        Me.pnlVenta.Controls.Add(Me.pnlPrecios)
        Me.pnlVenta.Controls.Add(Me.pnlEditCant)
        Me.pnlVenta.Controls.Add(Me.pnlPiso)
        Me.pnlVenta.Controls.Add(Me.pbxCrearProd)
        Me.pnlVenta.Controls.Add(Me.pnlCrearProd)
        Me.pnlVenta.Controls.Add(Me.lblHab2)
        Me.pnlVenta.Controls.Add(Me.lblHab)
        Me.pnlVenta.Controls.Add(Me.LblTituloHab)
        Me.pnlVenta.Controls.Add(Me.cmbVendedor)
        Me.pnlVenta.Controls.Add(Me.btnGuardar)
        Me.pnlVenta.Controls.Add(Me.btnCancel)
        Me.pnlVenta.Controls.Add(Me.chkMayorista)
        Me.pnlVenta.Controls.Add(Me.pbxBuscCli)
        Me.pnlVenta.Controls.Add(Me.pnlCredito)
        Me.pnlVenta.Controls.Add(Me.Label6)
        Me.pnlVenta.Controls.Add(Me.txtTotal)
        Me.pnlVenta.Controls.Add(Me.Label17)
        Me.pnlVenta.Controls.Add(Me.Label1)
        Me.pnlVenta.Controls.Add(Me.optCredito)
        Me.pnlVenta.Controls.Add(Me.DataGridView1)
        Me.pnlVenta.Controls.Add(Me.optContado)
        Me.pnlVenta.Controls.Add(Me.txtCliente)
        Me.pnlVenta.Controls.Add(Me.Label16)
        Me.pnlVenta.Controls.Add(Me.Label18)
        Me.pnlVenta.Controls.Add(Me.txtFecha)
        Me.pnlVenta.Controls.Add(Me.Label3)
        Me.pnlVenta.Controls.Add(Me.Label2)
        Me.pnlVenta.Controls.Add(Me.txtNroFac)
        Me.pnlVenta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlVenta.Location = New System.Drawing.Point(482, 0)
        Me.pnlVenta.Name = "pnlVenta"
        Me.pnlVenta.Size = New System.Drawing.Size(576, 543)
        Me.pnlVenta.TabIndex = 55
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(541, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 117
        Me.BtnCerrarForm.TabStop = False
        '
        'pnlXPack
        '
        Me.pnlXPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlXPack.Controls.Add(Me.btnUnidad)
        Me.pnlXPack.Controls.Add(Me.btnPack)
        Me.pnlXPack.Controls.Add(Me.btnPackCancel)
        Me.pnlXPack.Controls.Add(Me.lblTituloXPack)
        Me.pnlXPack.Location = New System.Drawing.Point(241, 236)
        Me.pnlXPack.Name = "pnlXPack"
        Me.pnlXPack.Size = New System.Drawing.Size(209, 91)
        Me.pnlXPack.TabIndex = 82
        Me.pnlXPack.Visible = False
        '
        'btnUnidad
        '
        Me.btnUnidad.BackColor = System.Drawing.Color.White
        Me.btnUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnidad.Location = New System.Drawing.Point(113, 44)
        Me.btnUnidad.Name = "btnUnidad"
        Me.btnUnidad.Size = New System.Drawing.Size(70, 25)
        Me.btnUnidad.TabIndex = 73
        Me.btnUnidad.Text = "Unidad"
        Me.btnUnidad.UseVisualStyleBackColor = False
        '
        'btnPack
        '
        Me.btnPack.BackColor = System.Drawing.Color.White
        Me.btnPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPack.Location = New System.Drawing.Point(22, 44)
        Me.btnPack.Name = "btnPack"
        Me.btnPack.Size = New System.Drawing.Size(70, 25)
        Me.btnPack.TabIndex = 72
        Me.btnPack.Text = "Paquete"
        Me.btnPack.UseVisualStyleBackColor = False
        '
        'btnPackCancel
        '
        Me.btnPackCancel.BackColor = System.Drawing.Color.White
        Me.btnPackCancel.FlatAppearance.BorderSize = 0
        Me.btnPackCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPackCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPackCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnPackCancel.Location = New System.Drawing.Point(186, 3)
        Me.btnPackCancel.Name = "btnPackCancel"
        Me.btnPackCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnPackCancel.TabIndex = 71
        Me.btnPackCancel.UseVisualStyleBackColor = False
        '
        'lblTituloXPack
        '
        Me.lblTituloXPack.AutoSize = True
        Me.lblTituloXPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloXPack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTituloXPack.Location = New System.Drawing.Point(56, 10)
        Me.lblTituloXPack.Name = "lblTituloXPack"
        Me.lblTituloXPack.Size = New System.Drawing.Size(92, 18)
        Me.lblTituloXPack.TabIndex = 65
        Me.lblTituloXPack.Text = "Vender Por"
        '
        'pnlPrecios
        '
        Me.pnlPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrecios.Controls.Add(Me.txtEditPrecio)
        Me.pnlPrecios.Controls.Add(Me.lblTitPrecio1)
        Me.pnlPrecios.Controls.Add(Me.lblTitPrecio2)
        Me.pnlPrecios.Controls.Add(Me.optPrecio3)
        Me.pnlPrecios.Controls.Add(Me.optPrecio2)
        Me.pnlPrecios.Controls.Add(Me.optPrecio1)
        Me.pnlPrecios.Controls.Add(Me.Button2)
        Me.pnlPrecios.Controls.Add(Me.lblTitPrecios)
        Me.pnlPrecios.Location = New System.Drawing.Point(353, 227)
        Me.pnlPrecios.Name = "pnlPrecios"
        Me.pnlPrecios.Size = New System.Drawing.Size(217, 119)
        Me.pnlPrecios.TabIndex = 83
        Me.pnlPrecios.Visible = False
        '
        'txtEditPrecio
        '
        Me.txtEditPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditPrecio.Location = New System.Drawing.Point(30, 85)
        Me.txtEditPrecio.Name = "txtEditPrecio"
        Me.txtEditPrecio.Size = New System.Drawing.Size(154, 21)
        Me.txtEditPrecio.TabIndex = 77
        '
        'lblTitPrecio1
        '
        Me.lblTitPrecio1.AutoSize = True
        Me.lblTitPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPrecio1.Location = New System.Drawing.Point(130, 38)
        Me.lblTitPrecio1.Name = "lblTitPrecio1"
        Me.lblTitPrecio1.Size = New System.Drawing.Size(54, 13)
        Me.lblTitPrecio1.TabIndex = 76
        Me.lblTitPrecio1.Text = "Precio 1"
        '
        'lblTitPrecio2
        '
        Me.lblTitPrecio2.AutoSize = True
        Me.lblTitPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPrecio2.Location = New System.Drawing.Point(130, 61)
        Me.lblTitPrecio2.Name = "lblTitPrecio2"
        Me.lblTitPrecio2.Size = New System.Drawing.Size(54, 13)
        Me.lblTitPrecio2.TabIndex = 75
        Me.lblTitPrecio2.Text = "Precio 2"
        '
        'optPrecio3
        '
        Me.optPrecio3.AutoSize = True
        Me.optPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrecio3.ForeColor = System.Drawing.Color.Black
        Me.optPrecio3.Location = New System.Drawing.Point(181, 101)
        Me.optPrecio3.Name = "optPrecio3"
        Me.optPrecio3.Size = New System.Drawing.Size(64, 17)
        Me.optPrecio3.TabIndex = 74
        Me.optPrecio3.Text = "Precio 3"
        Me.optPrecio3.UseVisualStyleBackColor = True
        Me.optPrecio3.Visible = False
        '
        'optPrecio2
        '
        Me.optPrecio2.AutoSize = True
        Me.optPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrecio2.ForeColor = System.Drawing.Color.Black
        Me.optPrecio2.Location = New System.Drawing.Point(30, 59)
        Me.optPrecio2.Name = "optPrecio2"
        Me.optPrecio2.Size = New System.Drawing.Size(98, 17)
        Me.optPrecio2.TabIndex = 73
        Me.optPrecio2.Text = "Precio Contado"
        Me.optPrecio2.UseVisualStyleBackColor = True
        '
        'optPrecio1
        '
        Me.optPrecio1.AutoSize = True
        Me.optPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrecio1.ForeColor = System.Drawing.Color.Black
        Me.optPrecio1.Location = New System.Drawing.Point(30, 36)
        Me.optPrecio1.Name = "optPrecio1"
        Me.optPrecio1.Size = New System.Drawing.Size(91, 17)
        Me.optPrecio1.TabIndex = 72
        Me.optPrecio1.Text = "Precio Crédito"
        Me.optPrecio1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.Button2.Location = New System.Drawing.Point(194, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(18, 18)
        Me.Button2.TabIndex = 71
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblTitPrecios
        '
        Me.lblTitPrecios.AutoSize = True
        Me.lblTitPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitPrecios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitPrecios.Location = New System.Drawing.Point(15, 10)
        Me.lblTitPrecios.Name = "lblTitPrecios"
        Me.lblTitPrecios.Size = New System.Drawing.Size(136, 18)
        Me.lblTitPrecios.TabIndex = 65
        Me.lblTitPrecios.Text = "Precios de Venta"
        '
        'pnlEditCant
        '
        Me.pnlEditCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditCant.Controls.Add(Me.btnEditCantCancel)
        Me.pnlEditCant.Controls.Add(Me.txtEditCant)
        Me.pnlEditCant.Controls.Add(Me.lblEditCant)
        Me.pnlEditCant.Location = New System.Drawing.Point(144, 212)
        Me.pnlEditCant.Name = "pnlEditCant"
        Me.pnlEditCant.Size = New System.Drawing.Size(204, 70)
        Me.pnlEditCant.TabIndex = 81
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
        Me.txtEditCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditCant.Location = New System.Drawing.Point(18, 34)
        Me.txtEditCant.Name = "txtEditCant"
        Me.txtEditCant.Size = New System.Drawing.Size(168, 21)
        Me.txtEditCant.TabIndex = 68
        '
        'lblEditCant
        '
        Me.lblEditCant.AutoSize = True
        Me.lblEditCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditCant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEditCant.Location = New System.Drawing.Point(15, 10)
        Me.lblEditCant.Name = "lblEditCant"
        Me.lblEditCant.Size = New System.Drawing.Size(123, 18)
        Me.lblEditCant.TabIndex = 65
        Me.lblEditCant.Text = "Editar Cantidad"
        '
        'pnlPiso
        '
        Me.pnlPiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPiso.Controls.Add(Me.btnPorUnidad)
        Me.pnlPiso.Controls.Add(Me.btnPorMetro)
        Me.pnlPiso.Controls.Add(Me.btnPorCaja)
        Me.pnlPiso.Controls.Add(Me.Button5)
        Me.pnlPiso.Controls.Add(Me.Label4)
        Me.pnlPiso.Location = New System.Drawing.Point(285, 180)
        Me.pnlPiso.Name = "pnlPiso"
        Me.pnlPiso.Size = New System.Drawing.Size(150, 139)
        Me.pnlPiso.TabIndex = 90
        Me.pnlPiso.Visible = False
        '
        'btnPorUnidad
        '
        Me.btnPorUnidad.BackColor = System.Drawing.Color.White
        Me.btnPorUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorUnidad.Location = New System.Drawing.Point(32, 101)
        Me.btnPorUnidad.Name = "btnPorUnidad"
        Me.btnPorUnidad.Size = New System.Drawing.Size(82, 25)
        Me.btnPorUnidad.TabIndex = 74
        Me.btnPorUnidad.Text = "Por Unidad"
        Me.btnPorUnidad.UseVisualStyleBackColor = False
        '
        'btnPorMetro
        '
        Me.btnPorMetro.BackColor = System.Drawing.Color.White
        Me.btnPorMetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorMetro.Location = New System.Drawing.Point(32, 70)
        Me.btnPorMetro.Name = "btnPorMetro"
        Me.btnPorMetro.Size = New System.Drawing.Size(82, 25)
        Me.btnPorMetro.TabIndex = 73
        Me.btnPorMetro.Text = "Por Metro"
        Me.btnPorMetro.UseVisualStyleBackColor = False
        '
        'btnPorCaja
        '
        Me.btnPorCaja.BackColor = System.Drawing.Color.White
        Me.btnPorCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorCaja.Location = New System.Drawing.Point(32, 39)
        Me.btnPorCaja.Name = "btnPorCaja"
        Me.btnPorCaja.Size = New System.Drawing.Size(82, 25)
        Me.btnPorCaja.TabIndex = 72
        Me.btnPorCaja.Text = "Por Caja"
        Me.btnPorCaja.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.Button5.Location = New System.Drawing.Point(128, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(18, 18)
        Me.Button5.TabIndex = 71
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Vender Por"
        '
        'pbxCrearProd
        '
        Me.pbxCrearProd.BackColor = System.Drawing.Color.Transparent
        Me.pbxCrearProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxCrearProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxCrearProd.Image = Global.ControlStock.My.Resources.Resources.Plus_over2
        Me.pbxCrearProd.Location = New System.Drawing.Point(9, 118)
        Me.pbxCrearProd.Name = "pbxCrearProd"
        Me.pbxCrearProd.Size = New System.Drawing.Size(21, 16)
        Me.pbxCrearProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxCrearProd.TabIndex = 85
        Me.pbxCrearProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxCrearProd, "Crear Producto")
        '
        'pnlCrearProd
        '
        Me.pnlCrearProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCrearProd.Controls.Add(Me.ChkGenerar)
        Me.pnlCrearProd.Controls.Add(Me.btnNuevoPOk)
        Me.pnlCrearProd.Controls.Add(Me.Label43)
        Me.pnlCrearProd.Controls.Add(Me.Label42)
        Me.pnlCrearProd.Controls.Add(Me.Label41)
        Me.pnlCrearProd.Controls.Add(Me.Label40)
        Me.pnlCrearProd.Controls.Add(Me.txtNuevoPImporte)
        Me.pnlCrearProd.Controls.Add(Me.txtNuevoPPrecio)
        Me.pnlCrearProd.Controls.Add(Me.txtNuevoPCant)
        Me.pnlCrearProd.Controls.Add(Me.Label21)
        Me.pnlCrearProd.Controls.Add(Me.txtNuevoPDescrip)
        Me.pnlCrearProd.Controls.Add(Me.btnNuevoPCancel)
        Me.pnlCrearProd.Controls.Add(Me.txtNuevoPCod)
        Me.pnlCrearProd.Controls.Add(Me.Label20)
        Me.pnlCrearProd.Location = New System.Drawing.Point(8, 143)
        Me.pnlCrearProd.Name = "pnlCrearProd"
        Me.pnlCrearProd.Size = New System.Drawing.Size(548, 117)
        Me.pnlCrearProd.TabIndex = 91
        Me.pnlCrearProd.Visible = False
        '
        'ChkGenerar
        '
        Me.ChkGenerar.AutoSize = True
        Me.ChkGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGenerar.ForeColor = System.Drawing.Color.Black
        Me.ChkGenerar.Location = New System.Drawing.Point(21, 81)
        Me.ChkGenerar.Name = "ChkGenerar"
        Me.ChkGenerar.Size = New System.Drawing.Size(64, 17)
        Me.ChkGenerar.TabIndex = 82
        Me.ChkGenerar.Text = "Generar"
        Me.ChkGenerar.UseVisualStyleBackColor = True
        '
        'btnNuevoPOk
        '
        Me.btnNuevoPOk.BackColor = System.Drawing.Color.White
        Me.btnNuevoPOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPOk.Location = New System.Drawing.Point(479, 83)
        Me.btnNuevoPOk.Name = "btnNuevoPOk"
        Me.btnNuevoPOk.Size = New System.Drawing.Size(63, 25)
        Me.btnNuevoPOk.TabIndex = 81
        Me.btnNuevoPOk.Text = "Aceptar"
        Me.btnNuevoPOk.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(476, 40)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(42, 13)
        Me.Label43.TabIndex = 80
        Me.Label43.Text = "Importe"
        Me.Label43.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(401, 40)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(37, 13)
        Me.Label42.TabIndex = 79
        Me.Label42.Text = "Precio"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(336, 40)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(29, 13)
        Me.Label41.TabIndex = 78
        Me.Label41.Text = "Cant"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(100, 40)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(63, 13)
        Me.Label40.TabIndex = 77
        Me.Label40.Text = "Descripción"
        '
        'txtNuevoPImporte
        '
        Me.txtNuevoPImporte.Location = New System.Drawing.Point(470, 55)
        Me.txtNuevoPImporte.Name = "txtNuevoPImporte"
        Me.txtNuevoPImporte.ReadOnly = True
        Me.txtNuevoPImporte.Size = New System.Drawing.Size(77, 20)
        Me.txtNuevoPImporte.TabIndex = 76
        Me.txtNuevoPImporte.Visible = False
        '
        'txtNuevoPPrecio
        '
        Me.txtNuevoPPrecio.Location = New System.Drawing.Point(394, 55)
        Me.txtNuevoPPrecio.Name = "txtNuevoPPrecio"
        Me.txtNuevoPPrecio.Size = New System.Drawing.Size(77, 20)
        Me.txtNuevoPPrecio.TabIndex = 75
        '
        'txtNuevoPCant
        '
        Me.txtNuevoPCant.Location = New System.Drawing.Point(332, 55)
        Me.txtNuevoPCant.Name = "txtNuevoPCant"
        Me.txtNuevoPCant.Size = New System.Drawing.Size(63, 20)
        Me.txtNuevoPCant.TabIndex = 74
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Código"
        '
        'txtNuevoPDescrip
        '
        Me.txtNuevoPDescrip.Location = New System.Drawing.Point(95, 55)
        Me.txtNuevoPDescrip.Name = "txtNuevoPDescrip"
        Me.txtNuevoPDescrip.Size = New System.Drawing.Size(238, 20)
        Me.txtNuevoPDescrip.TabIndex = 72
        '
        'btnNuevoPCancel
        '
        Me.btnNuevoPCancel.BackColor = System.Drawing.Color.White
        Me.btnNuevoPCancel.FlatAppearance.BorderSize = 0
        Me.btnNuevoPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoPCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoPCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnNuevoPCancel.Location = New System.Drawing.Point(525, 2)
        Me.btnNuevoPCancel.Name = "btnNuevoPCancel"
        Me.btnNuevoPCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnNuevoPCancel.TabIndex = 71
        Me.btnNuevoPCancel.UseVisualStyleBackColor = False
        '
        'txtNuevoPCod
        '
        Me.txtNuevoPCod.Location = New System.Drawing.Point(21, 55)
        Me.txtNuevoPCod.Name = "txtNuevoPCod"
        Me.txtNuevoPCod.Size = New System.Drawing.Size(75, 20)
        Me.txtNuevoPCod.TabIndex = 68
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(18, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 18)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "Crear Producto"
        '
        'lblHab2
        '
        Me.lblHab2.AutoSize = True
        Me.lblHab2.BackColor = System.Drawing.Color.Black
        Me.lblHab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblHab2.ForeColor = System.Drawing.Color.White
        Me.lblHab2.Location = New System.Drawing.Point(0, 0)
        Me.lblHab2.Name = "lblHab2"
        Me.lblHab2.Size = New System.Drawing.Size(21, 22)
        Me.lblHab2.TabIndex = 89
        Me.lblHab2.Text = "0"
        Me.lblHab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHab
        '
        Me.lblHab.AutoSize = True
        Me.lblHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHab.Location = New System.Drawing.Point(323, 33)
        Me.lblHab.Name = "lblHab"
        Me.lblHab.Size = New System.Drawing.Size(19, 20)
        Me.lblHab.TabIndex = 88
        Me.lblHab.Text = "0"
        '
        'LblTituloHab
        '
        Me.LblTituloHab.AutoSize = True
        Me.LblTituloHab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloHab.Location = New System.Drawing.Point(229, 33)
        Me.LblTituloHab.Name = "LblTituloHab"
        Me.LblTituloHab.Size = New System.Drawing.Size(98, 21)
        Me.LblTituloHab.TabIndex = 87
        Me.LblTituloHab.Text = "Habitación "
        '
        'cmbVendedor
        '
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(83, 89)
        Me.cmbVendedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbVendedor.Size = New System.Drawing.Size(111, 21)
        Me.cmbVendedor.TabIndex = 84
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.btnGuardar.Location = New System.Drawing.Point(60, 480)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(57, 57)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Registrar Venta")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.btnCancel.Location = New System.Drawing.Point(4, 480)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(57, 57)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar")
        '
        'chkMayorista
        '
        Me.chkMayorista.AutoSize = True
        Me.chkMayorista.Location = New System.Drawing.Point(425, 35)
        Me.chkMayorista.Name = "chkMayorista"
        Me.chkMayorista.Size = New System.Drawing.Size(71, 17)
        Me.chkMayorista.TabIndex = 80
        Me.chkMayorista.Text = "Mayorista"
        Me.chkMayorista.UseVisualStyleBackColor = True
        Me.chkMayorista.Visible = False
        '
        'pbxBuscCli
        '
        Me.pbxBuscCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxBuscCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxBuscCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxBuscCli.Image = Global.ControlStock.My.Resources.Resources.find
        Me.pbxBuscCli.Location = New System.Drawing.Point(529, 60)
        Me.pbxBuscCli.Name = "pbxBuscCli"
        Me.pbxBuscCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxBuscCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBuscCli.TabIndex = 79
        Me.pbxBuscCli.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxBuscCli, "Buscar Cliente")
        '
        'pnlCredito
        '
        Me.pnlCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCredito.Controls.Add(Me.Label39)
        Me.pnlCredito.Controls.Add(Me.dtpVto)
        Me.pnlCredito.Controls.Add(Me.btnCredCancel)
        Me.pnlCredito.Controls.Add(Me.lblCredGs)
        Me.pnlCredito.Controls.Add(Me.btnCredOk)
        Me.pnlCredito.Controls.Add(Me.txtCredEntrega)
        Me.pnlCredito.Controls.Add(Me.btnCredNo)
        Me.pnlCredito.Controls.Add(Me.btnCredSi)
        Me.pnlCredito.Controls.Add(Me.Label38)
        Me.pnlCredito.Controls.Add(Me.Label37)
        Me.pnlCredito.Location = New System.Drawing.Point(130, 288)
        Me.pnlCredito.Name = "pnlCredito"
        Me.pnlCredito.Size = New System.Drawing.Size(291, 179)
        Me.pnlCredito.TabIndex = 56
        Me.pnlCredito.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Maroon
        Me.Label39.Location = New System.Drawing.Point(33, 45)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 16)
        Me.Label39.TabIndex = 73
        Me.Label39.Text = "Vencimiento"
        '
        'dtpVto
        '
        Me.dtpVto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVto.Location = New System.Drawing.Point(132, 44)
        Me.dtpVto.Name = "dtpVto"
        Me.dtpVto.Size = New System.Drawing.Size(117, 20)
        Me.dtpVto.TabIndex = 72
        '
        'btnCredCancel
        '
        Me.btnCredCancel.BackColor = System.Drawing.Color.White
        Me.btnCredCancel.FlatAppearance.BorderSize = 0
        Me.btnCredCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredCancel.Image = Global.ControlStock.My.Resources.Resources.cancel
        Me.btnCredCancel.Location = New System.Drawing.Point(264, 5)
        Me.btnCredCancel.Name = "btnCredCancel"
        Me.btnCredCancel.Size = New System.Drawing.Size(18, 18)
        Me.btnCredCancel.TabIndex = 70
        Me.btnCredCancel.UseVisualStyleBackColor = False
        '
        'lblCredGs
        '
        Me.lblCredGs.AutoSize = True
        Me.lblCredGs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredGs.ForeColor = System.Drawing.Color.Black
        Me.lblCredGs.Location = New System.Drawing.Point(45, 141)
        Me.lblCredGs.Name = "lblCredGs"
        Me.lblCredGs.Size = New System.Drawing.Size(31, 16)
        Me.lblCredGs.TabIndex = 69
        Me.lblCredGs.Text = "Gs."
        '
        'btnCredOk
        '
        Me.btnCredOk.BackColor = System.Drawing.Color.White
        Me.btnCredOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredOk.Location = New System.Drawing.Point(210, 137)
        Me.btnCredOk.Name = "btnCredOk"
        Me.btnCredOk.Size = New System.Drawing.Size(63, 25)
        Me.btnCredOk.TabIndex = 68
        Me.btnCredOk.Text = "Aceptar"
        Me.btnCredOk.UseVisualStyleBackColor = False
        '
        'txtCredEntrega
        '
        Me.txtCredEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredEntrega.Location = New System.Drawing.Point(79, 140)
        Me.txtCredEntrega.Name = "txtCredEntrega"
        Me.txtCredEntrega.Size = New System.Drawing.Size(125, 21)
        Me.txtCredEntrega.TabIndex = 67
        '
        'btnCredNo
        '
        Me.btnCredNo.BackColor = System.Drawing.Color.White
        Me.btnCredNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredNo.Location = New System.Drawing.Point(154, 102)
        Me.btnCredNo.Name = "btnCredNo"
        Me.btnCredNo.Size = New System.Drawing.Size(35, 25)
        Me.btnCredNo.TabIndex = 66
        Me.btnCredNo.Text = "No"
        Me.btnCredNo.UseVisualStyleBackColor = False
        '
        'btnCredSi
        '
        Me.btnCredSi.BackColor = System.Drawing.Color.White
        Me.btnCredSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredSi.Location = New System.Drawing.Point(95, 102)
        Me.btnCredSi.Name = "btnCredSi"
        Me.btnCredSi.Size = New System.Drawing.Size(35, 25)
        Me.btnCredSi.TabIndex = 65
        Me.btnCredSi.Text = "Si"
        Me.btnCredSi.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Maroon
        Me.Label38.Location = New System.Drawing.Point(16, 73)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(257, 16)
        Me.Label38.TabIndex = 64
        Me.Label38.Text = "¿Desea realizar una entrega inicial?"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(67, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(154, 24)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "Venta a Crédito"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(356, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 15)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Condición"
        '
        'optCredito
        '
        Me.optCredito.AutoSize = True
        Me.optCredito.Location = New System.Drawing.Point(498, 91)
        Me.optCredito.Name = "optCredito"
        Me.optCredito.Size = New System.Drawing.Size(58, 17)
        Me.optCredito.TabIndex = 51
        Me.optCredito.Text = "Crédito"
        Me.optCredito.UseVisualStyleBackColor = True
        '
        'optContado
        '
        Me.optContado.AutoSize = True
        Me.optContado.Checked = True
        Me.optContado.Location = New System.Drawing.Point(425, 91)
        Me.optContado.Name = "optContado"
        Me.optContado.Size = New System.Drawing.Size(65, 17)
        Me.optContado.TabIndex = 50
        Me.optContado.TabStop = True
        Me.optContado.Text = "Contado"
        Me.optContado.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(425, 61)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(99, 20)
        Me.txtCliente.TabIndex = 49
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Cajero/ra"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(229, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 21)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Factura"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(83, 61)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFecha.Size = New System.Drawing.Size(111, 21)
        Me.txtFecha.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nro. Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'txtNroFac
        '
        Me.txtNroFac.BackColor = System.Drawing.Color.White
        Me.txtNroFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.Location = New System.Drawing.Point(83, 33)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.ReadOnly = True
        Me.txtNroFac.Size = New System.Drawing.Size(111, 21)
        Me.txtNroFac.TabIndex = 36
        Me.txtNroFac.Text = "0"
        Me.txtNroFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlProdInfo
        '
        Me.pnlProdInfo.Controls.Add(Me.pnlPrecVenta)
        Me.pnlProdInfo.Controls.Add(Me.Label24)
        Me.pnlProdInfo.Controls.Add(Me.Label23)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoCod)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoDesc)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoStock)
        Me.pnlProdInfo.Controls.Add(Me.PictureBox1)
        Me.pnlProdInfo.Controls.Add(Me.Label7)
        Me.pnlProdInfo.Controls.Add(Me.Label26)
        Me.pnlProdInfo.Controls.Add(Me.Label8)
        Me.pnlProdInfo.Controls.Add(Me.Label10)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoPrec)
        Me.pnlProdInfo.Controls.Add(Me.Label12)
        Me.pnlProdInfo.Controls.Add(Me.lblInfoPrec2)
        Me.pnlProdInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlProdInfo.Location = New System.Drawing.Point(0, 538)
        Me.pnlProdInfo.Name = "pnlProdInfo"
        Me.pnlProdInfo.Size = New System.Drawing.Size(482, 388)
        Me.pnlProdInfo.TabIndex = 67
        '
        'pnlPrecVenta
        '
        Me.pnlPrecVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrecVenta.Controls.Add(Me.pnlInfoPiso)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecUnidP)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecPack)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecUnit)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecio1)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecio2)
        Me.pnlPrecVenta.Controls.Add(Me.lblPrecio3)
        Me.pnlPrecVenta.Controls.Add(Me.Label9)
        Me.pnlPrecVenta.Location = New System.Drawing.Point(234, 251)
        Me.pnlPrecVenta.Name = "pnlPrecVenta"
        Me.pnlPrecVenta.Size = New System.Drawing.Size(248, 132)
        Me.pnlPrecVenta.TabIndex = 55
        '
        'pnlInfoPiso
        '
        Me.pnlInfoPiso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInfoPiso.Controls.Add(Me.lblUnidxCaja)
        Me.pnlInfoPiso.Controls.Add(Me.Label19)
        Me.pnlInfoPiso.Controls.Add(Me.lblMxCaja)
        Me.pnlInfoPiso.Controls.Add(Me.Label14)
        Me.pnlInfoPiso.Location = New System.Drawing.Point(0, 79)
        Me.pnlInfoPiso.Name = "pnlInfoPiso"
        Me.pnlInfoPiso.Size = New System.Drawing.Size(248, 48)
        Me.pnlInfoPiso.TabIndex = 62
        Me.pnlInfoPiso.Visible = False
        '
        'lblUnidxCaja
        '
        Me.lblUnidxCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnidxCaja.AutoSize = True
        Me.lblUnidxCaja.ForeColor = System.Drawing.Color.White
        Me.lblUnidxCaja.Location = New System.Drawing.Point(115, 25)
        Me.lblUnidxCaja.Name = "lblUnidxCaja"
        Me.lblUnidxCaja.Size = New System.Drawing.Size(22, 13)
        Me.lblUnidxCaja.TabIndex = 65
        Me.lblUnidxCaja.Text = "xxx"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(3, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 13)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "- Unidades x Caja:"
        '
        'lblMxCaja
        '
        Me.lblMxCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMxCaja.AutoSize = True
        Me.lblMxCaja.ForeColor = System.Drawing.Color.White
        Me.lblMxCaja.Location = New System.Drawing.Point(99, 5)
        Me.lblMxCaja.Name = "lblMxCaja"
        Me.lblMxCaja.Size = New System.Drawing.Size(22, 13)
        Me.lblMxCaja.TabIndex = 63
        Me.lblMxCaja.Text = "xxx"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(3, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "- Metros x Caja:"
        '
        'lblPrecUnidP
        '
        Me.lblPrecUnidP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecUnidP.AutoSize = True
        Me.lblPrecUnidP.ForeColor = System.Drawing.Color.White
        Me.lblPrecUnidP.Location = New System.Drawing.Point(96, 62)
        Me.lblPrecUnidP.Name = "lblPrecUnidP"
        Me.lblPrecUnidP.Size = New System.Drawing.Size(22, 13)
        Me.lblPrecUnidP.TabIndex = 61
        Me.lblPrecUnidP.Text = "xxx"
        Me.lblPrecUnidP.Visible = False
        '
        'lblPrecPack
        '
        Me.lblPrecPack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecPack.AutoSize = True
        Me.lblPrecPack.ForeColor = System.Drawing.Color.White
        Me.lblPrecPack.Location = New System.Drawing.Point(93, 41)
        Me.lblPrecPack.Name = "lblPrecPack"
        Me.lblPrecPack.Size = New System.Drawing.Size(22, 13)
        Me.lblPrecPack.TabIndex = 60
        Me.lblPrecPack.Text = "xxx"
        '
        'lblPrecUnit
        '
        Me.lblPrecUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecUnit.AutoSize = True
        Me.lblPrecUnit.ForeColor = System.Drawing.Color.White
        Me.lblPrecUnit.Location = New System.Drawing.Point(86, 20)
        Me.lblPrecUnit.Name = "lblPrecUnit"
        Me.lblPrecUnit.Size = New System.Drawing.Size(22, 13)
        Me.lblPrecUnit.TabIndex = 59
        Me.lblPrecUnit.Text = "xxx"
        '
        'lblPrecio1
        '
        Me.lblPrecio1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecio1.AutoSize = True
        Me.lblPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio1.ForeColor = System.Drawing.Color.LightGray
        Me.lblPrecio1.Location = New System.Drawing.Point(3, 20)
        Me.lblPrecio1.Name = "lblPrecio1"
        Me.lblPrecio1.Size = New System.Drawing.Size(82, 13)
        Me.lblPrecio1.TabIndex = 56
        Me.lblPrecio1.Text = "- Por Unidad:"
        '
        'lblPrecio2
        '
        Me.lblPrecio2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecio2.AutoSize = True
        Me.lblPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio2.ForeColor = System.Drawing.Color.LightGray
        Me.lblPrecio2.Location = New System.Drawing.Point(3, 41)
        Me.lblPrecio2.Name = "lblPrecio2"
        Me.lblPrecio2.Size = New System.Drawing.Size(89, 13)
        Me.lblPrecio2.TabIndex = 57
        Me.lblPrecio2.Text = "- Por Paquete:"
        '
        'lblPrecio3
        '
        Me.lblPrecio3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecio3.AutoSize = True
        Me.lblPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio3.ForeColor = System.Drawing.Color.LightGray
        Me.lblPrecio3.Location = New System.Drawing.Point(3, 62)
        Me.lblPrecio3.Name = "lblPrecio3"
        Me.lblPrecio3.Size = New System.Drawing.Size(82, 13)
        Me.lblPrecio3.TabIndex = 3
        Me.lblPrecio3.Text = "- Por Unidad:"
        Me.lblPrecio3.Visible = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightGray
        Me.Label24.Location = New System.Drawing.Point(300, 169)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 13)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Info. de Producto"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LightGray
        Me.Label23.Location = New System.Drawing.Point(332, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Foto"
        '
        'lblInfoCod
        '
        Me.lblInfoCod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoCod.AutoSize = True
        Me.lblInfoCod.ForeColor = System.Drawing.Color.White
        Me.lblInfoCod.Location = New System.Drawing.Point(278, 184)
        Me.lblInfoCod.Name = "lblInfoCod"
        Me.lblInfoCod.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoCod.TabIndex = 62
        Me.lblInfoCod.Text = "xxx"
        '
        'lblInfoDesc
        '
        Me.lblInfoDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoDesc.AutoSize = True
        Me.lblInfoDesc.ForeColor = System.Drawing.Color.White
        Me.lblInfoDesc.Location = New System.Drawing.Point(300, 207)
        Me.lblInfoDesc.Name = "lblInfoDesc"
        Me.lblInfoDesc.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoDesc.TabIndex = 61
        Me.lblInfoDesc.Text = "xxx"
        '
        'lblInfoStock
        '
        Me.lblInfoStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoStock.AutoSize = True
        Me.lblInfoStock.ForeColor = System.Drawing.Color.White
        Me.lblInfoStock.Location = New System.Drawing.Point(288, 229)
        Me.lblInfoStock.Name = "lblInfoStock"
        Me.lblInfoStock.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoStock.TabIndex = 60
        Me.lblInfoStock.Text = "xxx"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(252, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 144)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LightGray
        Me.Label26.Location = New System.Drawing.Point(245, 255)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Precio Minorista"
        '
        'lblInfoPrec
        '
        Me.lblInfoPrec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoPrec.AutoSize = True
        Me.lblInfoPrec.ForeColor = System.Drawing.Color.White
        Me.lblInfoPrec.Location = New System.Drawing.Point(344, 255)
        Me.lblInfoPrec.Name = "lblInfoPrec"
        Me.lblInfoPrec.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoPrec.TabIndex = 66
        Me.lblInfoPrec.Text = "xxx"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(245, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Precio Mayorista"
        '
        'lblInfoPrec2
        '
        Me.lblInfoPrec2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoPrec2.AutoSize = True
        Me.lblInfoPrec2.ForeColor = System.Drawing.Color.White
        Me.lblInfoPrec2.Location = New System.Drawing.Point(350, 276)
        Me.lblInfoPrec2.Name = "lblInfoPrec2"
        Me.lblInfoPrec2.Size = New System.Drawing.Size(22, 13)
        Me.lblInfoPrec2.TabIndex = 68
        Me.lblInfoPrec2.Text = "xxx"
        '
        'pnlBuscProd
        '
        Me.pnlBuscProd.Controls.Add(Me.pbxNewProd)
        Me.pnlBuscProd.Controls.Add(Me.lblUnidXpack)
        Me.pnlBuscProd.Controls.Add(Me.pnlVenderPor)
        Me.pnlBuscProd.Controls.Add(Me.txtDescuent)
        Me.pnlBuscProd.Controls.Add(Me.Label15)
        Me.pnlBuscProd.Controls.Add(Me.lblX)
        Me.pnlBuscProd.Controls.Add(Me.cmbDescrip)
        Me.pnlBuscProd.Controls.Add(Me.Label5)
        Me.pnlBuscProd.Controls.Add(Me.txtBuscar)
        Me.pnlBuscProd.Controls.Add(Me.lblCant)
        Me.pnlBuscProd.Controls.Add(Me.lblDesc)
        Me.pnlBuscProd.Controls.Add(Me.txtCant)
        Me.pnlBuscProd.Controls.Add(Me.chkDesc)
        Me.pnlBuscProd.Controls.Add(Me.optCod)
        Me.pnlBuscProd.Controls.Add(Me.optDesc)
        Me.pnlBuscProd.Controls.Add(Me.btnAgregar)
        Me.pnlBuscProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBuscProd.Location = New System.Drawing.Point(0, 0)
        Me.pnlBuscProd.Name = "pnlBuscProd"
        Me.pnlBuscProd.Size = New System.Drawing.Size(482, 134)
        Me.pnlBuscProd.TabIndex = 84
        '
        'pbxNewProd
        '
        Me.pbxNewProd.BackColor = System.Drawing.Color.Transparent
        Me.pbxNewProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxNewProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxNewProd.Image = Global.ControlStock.My.Resources.Resources.Plus_over2
        Me.pbxNewProd.Location = New System.Drawing.Point(236, 56)
        Me.pbxNewProd.Name = "pbxNewProd"
        Me.pbxNewProd.Size = New System.Drawing.Size(20, 20)
        Me.pbxNewProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxNewProd.TabIndex = 84
        Me.pbxNewProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxNewProd, "Nuevo Producto")
        '
        'lblUnidXpack
        '
        Me.lblUnidXpack.AutoSize = True
        Me.lblUnidXpack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidXpack.ForeColor = System.Drawing.Color.LightGray
        Me.lblUnidXpack.Location = New System.Drawing.Point(451, 63)
        Me.lblUnidXpack.Name = "lblUnidXpack"
        Me.lblUnidXpack.Size = New System.Drawing.Size(21, 13)
        Me.lblUnidXpack.TabIndex = 79
        Me.lblUnidXpack.Text = "00"
        '
        'pnlVenderPor
        '
        Me.pnlVenderPor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlVenderPor.Controls.Add(Me.optPaquete)
        Me.pnlVenderPor.Controls.Add(Me.optUnidad)
        Me.pnlVenderPor.Controls.Add(Me.lblVenderPor)
        Me.pnlVenderPor.Location = New System.Drawing.Point(14, 139)
        Me.pnlVenderPor.Name = "pnlVenderPor"
        Me.pnlVenderPor.Size = New System.Drawing.Size(217, 25)
        Me.pnlVenderPor.TabIndex = 83
        Me.pnlVenderPor.Visible = False
        '
        'optPaquete
        '
        Me.optPaquete.AutoSize = True
        Me.optPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPaquete.ForeColor = System.Drawing.Color.White
        Me.optPaquete.Location = New System.Drawing.Point(148, 1)
        Me.optPaquete.Name = "optPaquete"
        Me.optPaquete.Size = New System.Drawing.Size(65, 17)
        Me.optPaquete.TabIndex = 82
        Me.optPaquete.TabStop = True
        Me.optPaquete.Text = "Paquete"
        Me.optPaquete.UseVisualStyleBackColor = True
        '
        'optUnidad
        '
        Me.optUnidad.AutoSize = True
        Me.optUnidad.Checked = True
        Me.optUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUnidad.ForeColor = System.Drawing.Color.White
        Me.optUnidad.Location = New System.Drawing.Point(79, 1)
        Me.optUnidad.Name = "optUnidad"
        Me.optUnidad.Size = New System.Drawing.Size(59, 17)
        Me.optUnidad.TabIndex = 81
        Me.optUnidad.TabStop = True
        Me.optUnidad.Text = "Unidad"
        Me.optUnidad.UseVisualStyleBackColor = True
        '
        'lblVenderPor
        '
        Me.lblVenderPor.AutoSize = True
        Me.lblVenderPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenderPor.ForeColor = System.Drawing.Color.LightGray
        Me.lblVenderPor.Location = New System.Drawing.Point(5, 3)
        Me.lblVenderPor.Name = "lblVenderPor"
        Me.lblVenderPor.Size = New System.Drawing.Size(70, 13)
        Me.lblVenderPor.TabIndex = 56
        Me.lblVenderPor.Text = "Vender Por"
        '
        'txtDescuent
        '
        Me.txtDescuent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuent.Location = New System.Drawing.Point(336, 141)
        Me.txtDescuent.Name = "txtDescuent"
        Me.txtDescuent.Size = New System.Drawing.Size(60, 20)
        Me.txtDescuent.TabIndex = 45
        Me.txtDescuent.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(12, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 20)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Buscar Producto por:"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.LightGray
        Me.lblX.Location = New System.Drawing.Point(442, 62)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 78
        Me.lblX.Text = "x "
        '
        'cmbDescrip
        '
        Me.cmbDescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbDescrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDescrip.ForeColor = System.Drawing.Color.White
        Me.cmbDescrip.FormattingEnabled = True
        Me.cmbDescrip.Location = New System.Drawing.Point(14, 93)
        Me.cmbDescrip.Name = "cmbDescrip"
        Me.cmbDescrip.Size = New System.Drawing.Size(243, 26)
        Me.cmbDescrip.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(63, 56)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(168, 24)
        Me.txtBuscar.TabIndex = 75
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.Color.White
        Me.lblCant.Location = New System.Drawing.Point(277, 60)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(40, 17)
        Me.lblCant.TabIndex = 74
        Me.lblCant.Text = "Cant."
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(396, 144)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(16, 13)
        Me.lblDesc.TabIndex = 47
        Me.lblDesc.Text = "%"
        Me.lblDesc.Visible = False
        '
        'txtCant
        '
        Me.txtCant.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCant.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.ForeColor = System.Drawing.Color.White
        Me.txtCant.Location = New System.Drawing.Point(323, 55)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(113, 27)
        Me.txtCant.TabIndex = 73
        Me.txtCant.Text = "1"
        '
        'chkDesc
        '
        Me.chkDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDesc.AutoSize = True
        Me.chkDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesc.ForeColor = System.Drawing.Color.White
        Me.chkDesc.Location = New System.Drawing.Point(280, 143)
        Me.chkDesc.Name = "chkDesc"
        Me.chkDesc.Size = New System.Drawing.Size(63, 17)
        Me.chkDesc.TabIndex = 46
        Me.chkDesc.Text = "Desc. "
        Me.chkDesc.UseVisualStyleBackColor = True
        Me.chkDesc.Visible = False
        '
        'optCod
        '
        Me.optCod.AutoSize = True
        Me.optCod.Checked = True
        Me.optCod.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCod.ForeColor = System.Drawing.Color.White
        Me.optCod.Location = New System.Drawing.Point(181, 13)
        Me.optCod.Name = "optCod"
        Me.optCod.Size = New System.Drawing.Size(76, 24)
        Me.optCod.TabIndex = 71
        Me.optCod.TabStop = True
        Me.optCod.Text = "Código"
        Me.optCod.UseVisualStyleBackColor = True
        '
        'optDesc
        '
        Me.optDesc.AutoSize = True
        Me.optDesc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDesc.ForeColor = System.Drawing.Color.White
        Me.optDesc.Location = New System.Drawing.Point(280, 13)
        Me.optDesc.Name = "optDesc"
        Me.optDesc.Size = New System.Drawing.Size(105, 24)
        Me.optDesc.TabIndex = 70
        Me.optDesc.Text = "Descripción"
        Me.optDesc.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Location = New System.Drawing.Point(280, 91)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(156, 31)
        Me.btnAgregar.TabIndex = 69
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'ToolTip2
        '
        Me.ToolTip2.AutomaticDelay = 10
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.button_cancel
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.pnlProdInfo)
        Me.pnlRight.Controls.Add(Me.pnlAddRapido)
        Me.pnlRight.Controls.Add(Me.pnlBuscProd)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(0, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(482, 543)
        Me.pnlRight.TabIndex = 118
        '
        'pnlAddRapido
        '
        Me.pnlAddRapido.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlAddRapido.Controls.Add(Me.Label22)
        Me.pnlAddRapido.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddRapido.Location = New System.Drawing.Point(0, 134)
        Me.pnlAddRapido.Name = "pnlAddRapido"
        Me.pnlAddRapido.Size = New System.Drawing.Size(482, 404)
        Me.pnlAddRapido.TabIndex = 85
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 21)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(482, 383)
        Me.FlowLayoutPanel1.TabIndex = 82
        '
        'Label22
        '
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(482, 21)
        Me.Label22.TabIndex = 84
        Me.Label22.Text = "Selección Rápida"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FVentaGym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1058, 543)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FVentaGym"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVenta.ResumeLayout(False)
        Me.pnlVenta.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlXPack.ResumeLayout(False)
        Me.pnlXPack.PerformLayout()
        Me.pnlPrecios.ResumeLayout(False)
        Me.pnlPrecios.PerformLayout()
        Me.pnlEditCant.ResumeLayout(False)
        Me.pnlEditCant.PerformLayout()
        Me.pnlPiso.ResumeLayout(False)
        Me.pnlPiso.PerformLayout()
        CType(Me.pbxCrearProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCrearProd.ResumeLayout(False)
        Me.pnlCrearProd.PerformLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCredito.ResumeLayout(False)
        Me.pnlCredito.PerformLayout()
        Me.pnlProdInfo.ResumeLayout(False)
        Me.pnlProdInfo.PerformLayout()
        Me.pnlPrecVenta.ResumeLayout(False)
        Me.pnlPrecVenta.PerformLayout()
        Me.pnlInfoPiso.ResumeLayout(False)
        Me.pnlInfoPiso.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscProd.ResumeLayout(False)
        Me.pnlBuscProd.PerformLayout()
        CType(Me.pbxNewProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVenderPor.ResumeLayout(False)
        Me.pnlVenderPor.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlAddRapido.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrTotal As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPrecVenta As System.Windows.Forms.Panel
    Friend WithEvents lblPrecio1 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio2 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio3 As System.Windows.Forms.Label
    Friend WithEvents lblPrecUnidP As System.Windows.Forms.Label
    Friend WithEvents lblPrecPack As System.Windows.Forms.Label
    Friend WithEvents lblPrecUnit As System.Windows.Forms.Label
    Friend WithEvents lblInfoCod As System.Windows.Forms.Label
    Friend WithEvents lblInfoDesc As System.Windows.Forms.Label
    Friend WithEvents lblInfoStock As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents pnlProdInfo As System.Windows.Forms.Panel
    Friend WithEvents lblInfoPrec As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optCredito As System.Windows.Forms.RadioButton
    Friend WithEvents optContado As System.Windows.Forms.RadioButton
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents pnlCredito As System.Windows.Forms.Panel
    Friend WithEvents btnCredCancel As System.Windows.Forms.Button
    Friend WithEvents lblCredGs As System.Windows.Forms.Label
    Friend WithEvents btnCredOk As System.Windows.Forms.Button
    Friend WithEvents txtCredEntrega As System.Windows.Forms.TextBox
    Friend WithEvents btnCredNo As System.Windows.Forms.Button
    Friend WithEvents btnCredSi As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpVto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pbxBuscCli As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents pnlBuscProd As System.Windows.Forms.Panel
    Friend WithEvents lblUnidXpack As System.Windows.Forms.Label
    Friend WithEvents pnlVenderPor As System.Windows.Forms.Panel
    Friend WithEvents optPaquete As System.Windows.Forms.RadioButton
    Friend WithEvents optUnidad As System.Windows.Forms.RadioButton
    Friend WithEvents lblVenderPor As System.Windows.Forms.Label
    Friend WithEvents txtDescuent As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents cmbDescrip As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents chkDesc As System.Windows.Forms.CheckBox
    Friend WithEvents optCod As System.Windows.Forms.RadioButton
    Friend WithEvents optDesc As System.Windows.Forms.RadioButton
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents chkMayorista As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInfoPrec2 As System.Windows.Forms.Label
    Friend WithEvents pnlEditCant As System.Windows.Forms.Panel
    Friend WithEvents txtEditCant As System.Windows.Forms.TextBox
    Friend WithEvents lblEditCant As System.Windows.Forms.Label
    Friend WithEvents btnEditCantCancel As System.Windows.Forms.Button
    Friend WithEvents pnlXPack As System.Windows.Forms.Panel
    Friend WithEvents btnUnidad As System.Windows.Forms.Button
    Friend WithEvents btnPack As System.Windows.Forms.Button
    Friend WithEvents btnPackCancel As System.Windows.Forms.Button
    Friend WithEvents lblTituloXPack As System.Windows.Forms.Label
    Friend WithEvents pnlPrecios As System.Windows.Forms.Panel
    Friend WithEvents optPrecio3 As System.Windows.Forms.RadioButton
    Friend WithEvents optPrecio2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPrecio1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblTitPrecios As System.Windows.Forms.Label
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblHab As Label
    Friend WithEvents LblTituloHab As Label
    Friend WithEvents lblHab2 As Label
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantt As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Unidades As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents Iva As DataGridViewTextBoxColumn
    Friend WithEvents lblTitPrecio1 As Label
    Friend WithEvents lblTitPrecio2 As Label
    Friend WithEvents txtEditPrecio As TextBox
    Friend WithEvents pnlPiso As Panel
    Friend WithEvents btnPorUnidad As Button
    Friend WithEvents btnPorMetro As Button
    Friend WithEvents btnPorCaja As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pbxNewProd As PictureBox
    Friend WithEvents pnlInfoPiso As Panel
    Friend WithEvents lblUnidxCaja As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblMxCaja As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlCrearProd As Panel
    Friend WithEvents btnNuevoPOk As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents txtNuevoPImporte As TextBox
    Friend WithEvents txtNuevoPPrecio As TextBox
    Friend WithEvents txtNuevoPCant As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNuevoPDescrip As TextBox
    Friend WithEvents btnNuevoPCancel As Button
    Friend WithEvents txtNuevoPCod As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents pbxCrearProd As PictureBox
    Friend WithEvents ChkGenerar As CheckBox
    Friend WithEvents pnlVenta As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlAddRapido As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label22 As Label
End Class
