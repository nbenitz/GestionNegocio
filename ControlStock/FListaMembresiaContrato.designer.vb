<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaMembresiaContrato
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaMembresiaContrato))
        Me.dgvMembresia = New System.Windows.Forms.DataGridView()
        Me.NroCont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Memb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Atras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.txtTotalCostoMembresia = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pbxDelCli = New System.Windows.Forms.PictureBox()
        Me.pbxBuscCli = New System.Windows.Forms.PictureBox()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtTotalDescuento = New System.Windows.Forms.TextBox()
        Me.txtTotalPagado = New System.Windows.Forms.TextBox()
        Me.txtTotalSaldo = New System.Windows.Forms.TextBox()
        Me.txtCantAtraso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvMembresia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDelCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMembresia
        '
        Me.dgvMembresia.AllowUserToAddRows = False
        Me.dgvMembresia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvMembresia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMembresia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMembresia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembresia.ColumnHeadersHeight = 41
        Me.dgvMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMembresia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCont, Me.CiNro, Me.Cliente, Me.Memb, Me.Period, Me.Cost, Me.Descuent, Me.Pagad, Me.Saldo, Me.Atras})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembresia.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMembresia.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvMembresia.Location = New System.Drawing.Point(12, 100)
        Me.dgvMembresia.MultiSelect = False
        Me.dgvMembresia.Name = "dgvMembresia"
        Me.dgvMembresia.ReadOnly = True
        Me.dgvMembresia.RowHeadersVisible = False
        Me.dgvMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembresia.Size = New System.Drawing.Size(1034, 486)
        Me.dgvMembresia.TabIndex = 1
        '
        'NroCont
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.NroCont.DefaultCellStyle = DataGridViewCellStyle2
        Me.NroCont.Frozen = True
        Me.NroCont.HeaderText = "Nro."
        Me.NroCont.Name = "NroCont"
        Me.NroCont.ReadOnly = True
        Me.NroCont.Width = 70
        '
        'CiNro
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CiNro.DefaultCellStyle = DataGridViewCellStyle3
        Me.CiNro.Frozen = True
        Me.CiNro.HeaderText = "CI"
        Me.CiNro.Name = "CiNro"
        Me.CiNro.ReadOnly = True
        Me.CiNro.Width = 80
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 150
        '
        'Memb
        '
        Me.Memb.HeaderText = "Membresía"
        Me.Memb.Name = "Memb"
        Me.Memb.ReadOnly = True
        Me.Memb.Width = 120
        '
        'Period
        '
        Me.Period.HeaderText = "Periodo"
        Me.Period.Name = "Period"
        Me.Period.ReadOnly = True
        Me.Period.Width = 150
        '
        'Cost
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cost.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cost.HeaderText = "Costo Membresía"
        Me.Cost.Name = "Cost"
        Me.Cost.ReadOnly = True
        Me.Cost.Width = 90
        '
        'Descuent
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Descuent.DefaultCellStyle = DataGridViewCellStyle5
        Me.Descuent.HeaderText = "Descuento Aplicado"
        Me.Descuent.Name = "Descuent"
        Me.Descuent.ReadOnly = True
        Me.Descuent.Width = 90
        '
        'Pagad
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Pagad.DefaultCellStyle = DataGridViewCellStyle6
        Me.Pagad.HeaderText = "Total Pagado"
        Me.Pagad.Name = "Pagad"
        Me.Pagad.ReadOnly = True
        Me.Pagad.Width = 90
        '
        'Saldo
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle7
        Me.Saldo.HeaderText = "Saldo Pendiente"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 90
        '
        'Atras
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Atras.DefaultCellStyle = DataGridViewCellStyle8
        Me.Atras.HeaderText = "Días Atraso"
        Me.Atras.Name = "Atras"
        Me.Atras.ReadOnly = True
        Me.Atras.Width = 70
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(257, 67)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(106, 21)
        Me.dtpHasta.TabIndex = 55
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(254, 49)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 53
        Me.lblHasta.Text = "Hasta"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(131, 49)
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
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Dia", "Mes", "Fecha", "Nro. Contrato", "Todos"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(11, 66)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(106, 23)
        Me.cmbFiltrarPor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver Por"
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(134, 67)
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
        Me.txtNroFac.Location = New System.Drawing.Point(134, 65)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.Size = New System.Drawing.Size(106, 22)
        Me.txtNroFac.TabIndex = 44
        '
        'cmbAno
        '
        Me.cmbAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAno.ForeColor = System.Drawing.Color.White
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(134, 66)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(106, 23)
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
        Me.cmbMes.Location = New System.Drawing.Point(257, 66)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(106, 23)
        Me.cmbMes.TabIndex = 13
        '
        'txtTotalCostoMembresia
        '
        Me.txtTotalCostoMembresia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCostoMembresia.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalCostoMembresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCostoMembresia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCostoMembresia.ForeColor = System.Drawing.Color.White
        Me.txtTotalCostoMembresia.Location = New System.Drawing.Point(582, 629)
        Me.txtTotalCostoMembresia.Name = "txtTotalCostoMembresia"
        Me.txtTotalCostoMembresia.ReadOnly = True
        Me.txtTotalCostoMembresia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalCostoMembresia.Size = New System.Drawing.Size(90, 24)
        Me.txtTotalCostoMembresia.TabIndex = 4
        Me.txtTotalCostoMembresia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(489, 629)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 20)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Suma Total"
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle10
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
        Me.pnlTopBar.Size = New System.Drawing.Size(1060, 35)
        Me.pnlTopBar.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Lista de Contratos de Membresía"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(1025, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'pbxDelCli
        '
        Me.pbxDelCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxDelCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxDelCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxDelCli.Image = Global.ControlStock.My.Resources.Resources.delete
        Me.pbxDelCli.Location = New System.Drawing.Point(561, 67)
        Me.pbxDelCli.Name = "pbxDelCli"
        Me.pbxDelCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxDelCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDelCli.TabIndex = 102
        Me.pbxDelCli.TabStop = False
        '
        'pbxBuscCli
        '
        Me.pbxBuscCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxBuscCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxBuscCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxBuscCli.Image = Global.ControlStock.My.Resources.Resources.find
        Me.pbxBuscCli.Location = New System.Drawing.Point(533, 66)
        Me.pbxBuscCli.Name = "pbxBuscCli"
        Me.pbxBuscCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxBuscCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBuscCli.TabIndex = 101
        Me.pbxBuscCli.TabStop = False
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocio.ForeColor = System.Drawing.Color.White
        Me.lblSocio.Location = New System.Drawing.Point(369, 49)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(37, 15)
        Me.lblSocio.TabIndex = 100
        Me.lblSocio.Text = "Socio"
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.White
        Me.txtCI.Location = New System.Drawing.Point(372, 67)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(158, 21)
        Me.txtCI.TabIndex = 99
        '
        'txtTotalDescuento
        '
        Me.txtTotalDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescuento.ForeColor = System.Drawing.Color.White
        Me.txtTotalDescuento.Location = New System.Drawing.Point(671, 629)
        Me.txtTotalDescuento.Name = "txtTotalDescuento"
        Me.txtTotalDescuento.ReadOnly = True
        Me.txtTotalDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalDescuento.Size = New System.Drawing.Size(90, 24)
        Me.txtTotalDescuento.TabIndex = 103
        Me.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPagado.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPagado.ForeColor = System.Drawing.Color.White
        Me.txtTotalPagado.Location = New System.Drawing.Point(760, 629)
        Me.txtTotalPagado.Name = "txtTotalPagado"
        Me.txtTotalPagado.ReadOnly = True
        Me.txtTotalPagado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalPagado.Size = New System.Drawing.Size(90, 24)
        Me.txtTotalPagado.TabIndex = 104
        Me.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSaldo
        '
        Me.txtTotalSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSaldo.ForeColor = System.Drawing.Color.White
        Me.txtTotalSaldo.Location = New System.Drawing.Point(849, 629)
        Me.txtTotalSaldo.Name = "txtTotalSaldo"
        Me.txtTotalSaldo.ReadOnly = True
        Me.txtTotalSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalSaldo.Size = New System.Drawing.Size(90, 24)
        Me.txtTotalSaldo.TabIndex = 105
        Me.txtTotalSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantAtraso
        '
        Me.txtCantAtraso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCantAtraso.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCantAtraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantAtraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantAtraso.ForeColor = System.Drawing.Color.White
        Me.txtCantAtraso.Location = New System.Drawing.Point(938, 629)
        Me.txtCantAtraso.Name = "txtCantAtraso"
        Me.txtCantAtraso.ReadOnly = True
        Me.txtCantAtraso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCantAtraso.Size = New System.Drawing.Size(90, 24)
        Me.txtCantAtraso.TabIndex = 106
        Me.txtCantAtraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(582, 589)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 37)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Costo Membresía"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(671, 589)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 37)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Descuento Aplicado"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(761, 589)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 37)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Total Pagado"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(849, 589)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 37)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Saldo Pendiente"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(938, 589)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 37)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Socios con días de atraso"
        '
        'FListaMembresiaContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 665)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCantAtraso)
        Me.Controls.Add(Me.txtTotalSaldo)
        Me.Controls.Add(Me.txtTotalPagado)
        Me.Controls.Add(Me.txtTotalDescuento)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.pbxDelCli)
        Me.Controls.Add(Me.pbxBuscCli)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.cmbFiltrarPor)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtNroFac)
        Me.Controls.Add(Me.txtTotalCostoMembresia)
        Me.Controls.Add(Me.cmbAno)
        Me.Controls.Add(Me.dgvMembresia)
        Me.Controls.Add(Me.cmbMes)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FListaMembresiaContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Ventas"
        CType(Me.dgvMembresia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDelCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMembresia As System.Windows.Forms.DataGridView
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents txtTotalCostoMembresia As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbxDelCli As PictureBox
    Friend WithEvents pbxBuscCli As PictureBox
    Friend WithEvents lblSocio As Label
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtTotalDescuento As TextBox
    Friend WithEvents txtTotalPagado As TextBox
    Friend WithEvents txtTotalSaldo As TextBox
    Friend WithEvents txtCantAtraso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NroCont As DataGridViewTextBoxColumn
    Friend WithEvents CiNro As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Memb As DataGridViewTextBoxColumn
    Friend WithEvents Period As DataGridViewTextBoxColumn
    Friend WithEvents Cost As DataGridViewTextBoxColumn
    Friend WithEvents Descuent As DataGridViewTextBoxColumn
    Friend WithEvents Pagad As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Atras As DataGridViewTextBoxColumn
End Class
