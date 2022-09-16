<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaCajas
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaCajas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cajaa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCierreDeclarado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Faltant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoRetiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoSgteCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.pbxDelCli = New System.Windows.Forms.PictureBox()
        Me.pnlResumen = New System.Windows.Forms.Panel()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.pbxResumen = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalDiferencia = New System.Windows.Forms.TextBox()
        Me.txtTotalMontoRetiro = New System.Windows.Forms.TextBox()
        Me.txtTotalFaltante = New System.Windows.Forms.TextBox()
        Me.txtTotalMontoDeclarado = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotalMontoCierre = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDelCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResumen.SuspendLayout()
        CType(Me.pbxResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.ColumnHeadersHeight = 55
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.Empleado, Me.Cajaa, Me.FechaIni, Me.FechaFin, Me.MontoIni, Me.MontoFin, Me.MontoCierreDeclarado, Me.Faltant, Me.MontoRetiro, Me.MontoSgteCaja, Me.Diferencia})
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(15, 105)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridView1.RowTemplate.Height = 44
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(964, 350)
        Me.DataGridView1.TabIndex = 16
        '
        'Sel
        '
        Me.Sel.Frozen = True
        Me.Sel.HeaderText = ""
        Me.Sel.Name = "Sel"
        Me.Sel.ReadOnly = True
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.Width = 25
        '
        'Empleado
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Empleado.DefaultCellStyle = DataGridViewCellStyle16
        Me.Empleado.Frozen = True
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'Cajaa
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Cajaa.DefaultCellStyle = DataGridViewCellStyle17
        Me.Cajaa.Frozen = True
        Me.Cajaa.HeaderText = "Caja"
        Me.Cajaa.Name = "Cajaa"
        Me.Cajaa.ReadOnly = True
        Me.Cajaa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cajaa.Width = 50
        '
        'FechaIni
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaIni.DefaultCellStyle = DataGridViewCellStyle18
        Me.FechaIni.Frozen = True
        Me.FechaIni.HeaderText = "Fecha Apertura"
        Me.FechaIni.Name = "FechaIni"
        Me.FechaIni.ReadOnly = True
        Me.FechaIni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FechaFin
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaFin.DefaultCellStyle = DataGridViewCellStyle19
        Me.FechaFin.Frozen = True
        Me.FechaFin.HeaderText = "Fecha Cierre"
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.ReadOnly = True
        Me.FechaFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MontoIni
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N0"
        DataGridViewCellStyle20.NullValue = "0"
        Me.MontoIni.DefaultCellStyle = DataGridViewCellStyle20
        Me.MontoIni.Frozen = True
        Me.MontoIni.HeaderText = "Monto Apertura"
        Me.MontoIni.Name = "MontoIni"
        Me.MontoIni.ReadOnly = True
        Me.MontoIni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MontoIni.Width = 80
        '
        'MontoFin
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N0"
        DataGridViewCellStyle21.NullValue = Nothing
        DataGridViewCellStyle21.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.MontoFin.DefaultCellStyle = DataGridViewCellStyle21
        Me.MontoFin.Frozen = True
        Me.MontoFin.HeaderText = "Monto Cierre"
        Me.MontoFin.Name = "MontoFin"
        Me.MontoFin.ReadOnly = True
        Me.MontoFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MontoFin.Width = 80
        '
        'MontoCierreDeclarado
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N0"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.MontoCierreDeclarado.DefaultCellStyle = DataGridViewCellStyle22
        Me.MontoCierreDeclarado.Frozen = True
        Me.MontoCierreDeclarado.HeaderText = "Monto Cierre Declarado"
        Me.MontoCierreDeclarado.Name = "MontoCierreDeclarado"
        Me.MontoCierreDeclarado.ReadOnly = True
        Me.MontoCierreDeclarado.Width = 80
        '
        'Faltant
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N0"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.Faltant.DefaultCellStyle = DataGridViewCellStyle23
        Me.Faltant.Frozen = True
        Me.Faltant.HeaderText = "Faltante"
        Me.Faltant.Name = "Faltant"
        Me.Faltant.ReadOnly = True
        Me.Faltant.Width = 80
        '
        'MontoRetiro
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N0"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.MontoRetiro.DefaultCellStyle = DataGridViewCellStyle24
        Me.MontoRetiro.Frozen = True
        Me.MontoRetiro.HeaderText = "Monto Retiro"
        Me.MontoRetiro.Name = "MontoRetiro"
        Me.MontoRetiro.ReadOnly = True
        Me.MontoRetiro.Width = 80
        '
        'MontoSgteCaja
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "N0"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.MontoSgteCaja.DefaultCellStyle = DataGridViewCellStyle25
        Me.MontoSgteCaja.Frozen = True
        Me.MontoSgteCaja.HeaderText = "Monto Restante Sgte Caja"
        Me.MontoSgteCaja.Name = "MontoSgteCaja"
        Me.MontoSgteCaja.ReadOnly = True
        Me.MontoSgteCaja.Width = 80
        '
        'Diferencia
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "N0"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.Diferencia.DefaultCellStyle = DataGridViewCellStyle26
        Me.Diferencia.HeaderText = "Diferencia con Caja Anterior"
        Me.Diferencia.Name = "Diferencia"
        Me.Diferencia.ReadOnly = True
        Me.Diferencia.Width = 80
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(991, 35)
        Me.pnlTopBar.TabIndex = 59
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(133, 16)
        Me.lblTitulo.TabIndex = 116
        Me.lblTitulo.Text = "Apertura y Cierres"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(956, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbFiltrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFiltrarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltrarPor.ForeColor = System.Drawing.Color.White
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Dia", "Mes", "Fecha", "Todos"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(15, 64)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(106, 23)
        Me.cmbFiltrarPor.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Ver Por"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(238, 65)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(106, 21)
        Me.dtpHasta.TabIndex = 68
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(235, 47)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 66
        Me.lblHasta.Text = "Hasta"
        '
        'LblBuscar
        '
        Me.LblBuscar.AutoSize = True
        Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.ForeColor = System.Drawing.Color.White
        Me.LblBuscar.Location = New System.Drawing.Point(124, 47)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(107, 13)
        Me.LblBuscar.TabIndex = 65
        Me.LblBuscar.Text = "Ingrese Nro. Factura "
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(127, 65)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 21)
        Me.dtpDesde.TabIndex = 67
        '
        'txtNroFac
        '
        Me.txtNroFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.ForeColor = System.Drawing.Color.White
        Me.txtNroFac.Location = New System.Drawing.Point(127, 63)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.Size = New System.Drawing.Size(106, 22)
        Me.txtNroFac.TabIndex = 64
        '
        'cmbAno
        '
        Me.cmbAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAno.ForeColor = System.Drawing.Color.White
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(127, 64)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(106, 23)
        Me.cmbAno.TabIndex = 62
        '
        'cmbMes
        '
        Me.cmbMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.ForeColor = System.Drawing.Color.White
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(238, 64)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(106, 23)
        Me.cmbMes.TabIndex = 63
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocio.ForeColor = System.Drawing.Color.White
        Me.lblSocio.Location = New System.Drawing.Point(361, 45)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(61, 15)
        Me.lblSocio.TabIndex = 102
        Me.lblSocio.Text = "Empleado"
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.White
        Me.txtCI.Location = New System.Drawing.Point(364, 66)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(158, 21)
        Me.txtCI.TabIndex = 101
        '
        'pbxDelCli
        '
        Me.pbxDelCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxDelCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxDelCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxDelCli.Image = Global.ControlStock.My.Resources.Resources.delete
        Me.pbxDelCli.Location = New System.Drawing.Point(528, 65)
        Me.pbxDelCli.Name = "pbxDelCli"
        Me.pbxDelCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxDelCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDelCli.TabIndex = 103
        Me.pbxDelCli.TabStop = False
        '
        'pnlResumen
        '
        Me.pnlResumen.Controls.Add(Me.lblResumen)
        Me.pnlResumen.Controls.Add(Me.pbxResumen)
        Me.pnlResumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlResumen.Location = New System.Drawing.Point(15, 491)
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Size = New System.Drawing.Size(205, 37)
        Me.pnlResumen.TabIndex = 120
        '
        'lblResumen
        '
        Me.lblResumen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumen.ForeColor = System.Drawing.Color.White
        Me.lblResumen.Location = New System.Drawing.Point(33, 9)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(165, 20)
        Me.lblResumen.TabIndex = 85
        Me.lblResumen.Text = "Ver Resumen de Caja"
        '
        'pbxResumen
        '
        Me.pbxResumen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxResumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxResumen.Image = Global.ControlStock.My.Resources.Resources.file_document
        Me.pbxResumen.Location = New System.Drawing.Point(3, 3)
        Me.pbxResumen.Name = "pbxResumen"
        Me.pbxResumen.Size = New System.Drawing.Size(32, 30)
        Me.pbxResumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxResumen.TabIndex = 84
        Me.pbxResumen.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(868, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 37)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "Diferencia con Caja Anterior"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(706, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 37)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Monto Retiro"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(631, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Faltante"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(546, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 37)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Monto Cierre Declarado"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(469, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 37)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Monto Cierre"
        '
        'txtTotalDiferencia
        '
        Me.txtTotalDiferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDiferencia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiferencia.ForeColor = System.Drawing.Color.White
        Me.txtTotalDiferencia.Location = New System.Drawing.Point(871, 502)
        Me.txtTotalDiferencia.Name = "txtTotalDiferencia"
        Me.txtTotalDiferencia.ReadOnly = True
        Me.txtTotalDiferencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalDiferencia.Size = New System.Drawing.Size(80, 27)
        Me.txtTotalDiferencia.TabIndex = 126
        Me.txtTotalDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalMontoRetiro
        '
        Me.txtTotalMontoRetiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalMontoRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalMontoRetiro.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMontoRetiro.ForeColor = System.Drawing.Color.White
        Me.txtTotalMontoRetiro.Location = New System.Drawing.Point(707, 501)
        Me.txtTotalMontoRetiro.Name = "txtTotalMontoRetiro"
        Me.txtTotalMontoRetiro.ReadOnly = True
        Me.txtTotalMontoRetiro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalMontoRetiro.Size = New System.Drawing.Size(80, 27)
        Me.txtTotalMontoRetiro.TabIndex = 125
        Me.txtTotalMontoRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalFaltante
        '
        Me.txtTotalFaltante.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalFaltante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalFaltante.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFaltante.ForeColor = System.Drawing.Color.White
        Me.txtTotalFaltante.Location = New System.Drawing.Point(628, 501)
        Me.txtTotalFaltante.Name = "txtTotalFaltante"
        Me.txtTotalFaltante.ReadOnly = True
        Me.txtTotalFaltante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFaltante.Size = New System.Drawing.Size(80, 27)
        Me.txtTotalFaltante.TabIndex = 124
        Me.txtTotalFaltante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalMontoDeclarado
        '
        Me.txtTotalMontoDeclarado.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalMontoDeclarado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalMontoDeclarado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMontoDeclarado.ForeColor = System.Drawing.Color.White
        Me.txtTotalMontoDeclarado.Location = New System.Drawing.Point(549, 501)
        Me.txtTotalMontoDeclarado.Name = "txtTotalMontoDeclarado"
        Me.txtTotalMontoDeclarado.ReadOnly = True
        Me.txtTotalMontoDeclarado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalMontoDeclarado.Size = New System.Drawing.Size(80, 27)
        Me.txtTotalMontoDeclarado.TabIndex = 123
        Me.txtTotalMontoDeclarado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(399, 503)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 20)
        Me.lblTotal.TabIndex = 122
        Me.lblTotal.Text = "Totales"
        '
        'txtTotalMontoCierre
        '
        Me.txtTotalMontoCierre.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTotalMontoCierre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalMontoCierre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMontoCierre.ForeColor = System.Drawing.Color.White
        Me.txtTotalMontoCierre.Location = New System.Drawing.Point(470, 501)
        Me.txtTotalMontoCierre.Name = "txtTotalMontoCierre"
        Me.txtTotalMontoCierre.ReadOnly = True
        Me.txtTotalMontoCierre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalMontoCierre.Size = New System.Drawing.Size(80, 27)
        Me.txtTotalMontoCierre.TabIndex = 121
        Me.txtTotalMontoCierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FListaCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 551)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalDiferencia)
        Me.Controls.Add(Me.txtTotalMontoRetiro)
        Me.Controls.Add(Me.txtTotalFaltante)
        Me.Controls.Add(Me.txtTotalMontoDeclarado)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotalMontoCierre)
        Me.Controls.Add(Me.pnlResumen)
        Me.Controls.Add(Me.pbxDelCli)
        Me.Controls.Add(Me.lblSocio)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.LblBuscar)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.txtNroFac)
        Me.Controls.Add(Me.cmbAno)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.cmbFiltrarPor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FListaCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura y Cierres"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDelCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResumen.ResumeLayout(False)
        Me.pnlResumen.PerformLayout()
        CType(Me.pbxResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents cmbFiltrarPor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents lblHasta As Label
    Friend WithEvents LblBuscar As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents txtNroFac As TextBox
    Friend WithEvents cmbAno As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents lblSocio As Label
    Friend WithEvents txtCI As TextBox
    Friend WithEvents pbxDelCli As PictureBox
    Friend WithEvents pnlResumen As Panel
    Friend WithEvents lblResumen As Label
    Friend WithEvents pbxResumen As PictureBox
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Cajaa As DataGridViewTextBoxColumn
    Friend WithEvents FechaIni As DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As DataGridViewTextBoxColumn
    Friend WithEvents MontoIni As DataGridViewTextBoxColumn
    Friend WithEvents MontoFin As DataGridViewTextBoxColumn
    Friend WithEvents MontoCierreDeclarado As DataGridViewTextBoxColumn
    Friend WithEvents Faltant As DataGridViewTextBoxColumn
    Friend WithEvents MontoRetiro As DataGridViewTextBoxColumn
    Friend WithEvents MontoSgteCaja As DataGridViewTextBoxColumn
    Friend WithEvents Diferencia As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalDiferencia As TextBox
    Friend WithEvents txtTotalMontoRetiro As TextBox
    Friend WithEvents txtTotalFaltante As TextBox
    Friend WithEvents txtTotalMontoDeclarado As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotalMontoCierre As TextBox
End Class
