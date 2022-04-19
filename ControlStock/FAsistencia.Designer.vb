<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAsistencia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.dgvAsistencia = New System.Windows.Forms.DataGridView()
        Me.FechaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ced = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.pbxBuscCli = New System.Windows.Forms.PictureBox()
        Me.pbxDelCli = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvAusencia = New System.Windows.Forms.DataGridView()
        Me.lblAusente = New System.Windows.Forms.Label()
        Me.lblTitAusente = New System.Windows.Forms.Label()
        Me.lblCantSocio = New System.Windows.Forms.Label()
        Me.lblTitCantSocios = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ausen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerDias = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VerFicha = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDelCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAusencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(760, 35)
        Me.pnlTopBar.TabIndex = 83
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(9, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(70, 17)
        Me.lblTitulo.TabIndex = 117
        Me.lblTitulo.Text = "Asistencia"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(725, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'dgvAsistencia
        '
        Me.dgvAsistencia.AllowUserToAddRows = False
        Me.dgvAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAsistencia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAsistencia.ColumnHeadersHeight = 25
        Me.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAsistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaCol, Me.Hor, Me.Ced, Me.NombreCol, Me.Obs})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsistencia.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAsistencia.Location = New System.Drawing.Point(7, 63)
        Me.dgvAsistencia.Name = "dgvAsistencia"
        Me.dgvAsistencia.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAsistencia.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAsistencia.RowHeadersVisible = False
        Me.dgvAsistencia.Size = New System.Drawing.Size(734, 313)
        Me.dgvAsistencia.TabIndex = 84
        '
        'FechaCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.FechaCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaCol.Frozen = True
        Me.FechaCol.HeaderText = "Fecha"
        Me.FechaCol.Name = "FechaCol"
        Me.FechaCol.ReadOnly = True
        Me.FechaCol.Width = 80
        '
        'Hor
        '
        Me.Hor.Frozen = True
        Me.Hor.HeaderText = "Hora"
        Me.Hor.Name = "Hor"
        Me.Hor.ReadOnly = True
        Me.Hor.Width = 80
        '
        'Ced
        '
        Me.Ced.Frozen = True
        Me.Ced.HeaderText = "CI"
        Me.Ced.Name = "Ced"
        Me.Ced.ReadOnly = True
        Me.Ced.Width = 80
        '
        'NombreCol
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.NombreCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.NombreCol.Frozen = True
        Me.NombreCol.HeaderText = "Nombre"
        Me.NombreCol.Name = "NombreCol"
        Me.NombreCol.ReadOnly = True
        Me.NombreCol.Width = 230
        '
        'Obs
        '
        Me.Obs.Frozen = True
        Me.Obs.HeaderText = "Observación"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Width = 230
        '
        'cmbMes
        '
        Me.cmbMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.ForeColor = System.Drawing.Color.White
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(253, 24)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(106, 23)
        Me.cmbMes.TabIndex = 87
        '
        'dtpHasta
        '
        Me.dtpHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(253, 25)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(106, 21)
        Me.dtpHasta.TabIndex = 95
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(250, 8)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 93
        Me.lblHasta.Text = "Hasta"
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocio.ForeColor = System.Drawing.Color.White
        Me.lblSocio.Location = New System.Drawing.Point(382, 8)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(39, 13)
        Me.lblSocio.TabIndex = 91
        Me.lblSocio.Text = "Socio"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(125, 10)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(38, 13)
        Me.lblBuscar.TabIndex = 90
        Me.lblBuscar.Text = "Desde"
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbFiltrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFiltrarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltrarPor.ForeColor = System.Drawing.Color.White
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Dia", "Mes", "Fecha", "Ausencias"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(7, 24)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(106, 23)
        Me.cmbFiltrarPor.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Ver Por"
        '
        'dtpDesde
        '
        Me.dtpDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(128, 25)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 21)
        Me.dtpDesde.TabIndex = 94
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.White
        Me.txtCI.Location = New System.Drawing.Point(385, 26)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.ReadOnly = True
        Me.txtCI.Size = New System.Drawing.Size(158, 21)
        Me.txtCI.TabIndex = 89
        '
        'cmbAno
        '
        Me.cmbAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAno.ForeColor = System.Drawing.Color.White
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(128, 24)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(106, 23)
        Me.cmbAno.TabIndex = 96
        '
        'pbxBuscCli
        '
        Me.pbxBuscCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxBuscCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxBuscCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxBuscCli.Image = Global.ControlStock.My.Resources.Resources.find
        Me.pbxBuscCli.Location = New System.Drawing.Point(549, 25)
        Me.pbxBuscCli.Name = "pbxBuscCli"
        Me.pbxBuscCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxBuscCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBuscCli.TabIndex = 97
        Me.pbxBuscCli.TabStop = False
        '
        'pbxDelCli
        '
        Me.pbxDelCli.BackColor = System.Drawing.Color.Transparent
        Me.pbxDelCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxDelCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxDelCli.Image = Global.ControlStock.My.Resources.Resources.delete
        Me.pbxDelCli.Location = New System.Drawing.Point(580, 26)
        Me.pbxDelCli.Name = "pbxDelCli"
        Me.pbxDelCli.Size = New System.Drawing.Size(25, 22)
        Me.pbxDelCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDelCli.TabIndex = 98
        Me.pbxDelCli.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAusente)
        Me.Panel1.Controls.Add(Me.lblTitAusente)
        Me.Panel1.Controls.Add(Me.lblCantSocio)
        Me.Panel1.Controls.Add(Me.lblTitCantSocios)
        Me.Panel1.Controls.Add(Me.pbxDelCli)
        Me.Panel1.Controls.Add(Me.pbxBuscCli)
        Me.Panel1.Controls.Add(Me.lblHasta)
        Me.Panel1.Controls.Add(Me.lblSocio)
        Me.Panel1.Controls.Add(Me.lblBuscar)
        Me.Panel1.Controls.Add(Me.cmbFiltrarPor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCI)
        Me.Panel1.Controls.Add(Me.dtpDesde)
        Me.Panel1.Controls.Add(Me.dtpHasta)
        Me.Panel1.Controls.Add(Me.cmbAno)
        Me.Panel1.Controls.Add(Me.cmbMes)
        Me.Panel1.Controls.Add(Me.dgvAusencia)
        Me.Panel1.Controls.Add(Me.dgvAsistencia)
        Me.Panel1.Location = New System.Drawing.Point(5, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 410)
        Me.Panel1.TabIndex = 99
        '
        'dgvAusencia
        '
        Me.dgvAusencia.AllowUserToAddRows = False
        Me.dgvAusencia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvAusencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAusencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAusencia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAusencia.ColumnHeadersHeight = 25
        Me.dgvAusencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAusencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Ausen, Me.VerDias, Me.VerFicha})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAusencia.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAusencia.Location = New System.Drawing.Point(7, 63)
        Me.dgvAusencia.Name = "dgvAusencia"
        Me.dgvAusencia.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAusencia.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvAusencia.RowHeadersVisible = False
        Me.dgvAusencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvAusencia.Size = New System.Drawing.Size(734, 313)
        Me.dgvAusencia.TabIndex = 103
        '
        'lblAusente
        '
        Me.lblAusente.AutoSize = True
        Me.lblAusente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAusente.ForeColor = System.Drawing.Color.White
        Me.lblAusente.Location = New System.Drawing.Point(308, 383)
        Me.lblAusente.Name = "lblAusente"
        Me.lblAusente.Size = New System.Drawing.Size(43, 17)
        Me.lblAusente.TabIndex = 102
        Me.lblAusente.Text = "5 días"
        Me.lblAusente.Visible = False
        '
        'lblTitAusente
        '
        Me.lblTitAusente.AutoSize = True
        Me.lblTitAusente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitAusente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitAusente.Location = New System.Drawing.Point(217, 383)
        Me.lblTitAusente.Name = "lblTitAusente"
        Me.lblTitAusente.Size = New System.Drawing.Size(85, 17)
        Me.lblTitAusente.TabIndex = 101
        Me.lblTitAusente.Text = "Días ausente:"
        Me.lblTitAusente.Visible = False
        '
        'lblCantSocio
        '
        Me.lblCantSocio.AutoSize = True
        Me.lblCantSocio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantSocio.ForeColor = System.Drawing.Color.White
        Me.lblCantSocio.Location = New System.Drawing.Point(131, 383)
        Me.lblCantSocio.Name = "lblCantSocio"
        Me.lblCantSocio.Size = New System.Drawing.Size(57, 17)
        Me.lblCantSocio.TabIndex = 100
        Me.lblCantSocio.Text = "0 Socios"
        '
        'lblTitCantSocios
        '
        Me.lblTitCantSocios.AutoSize = True
        Me.lblTitCantSocios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitCantSocios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitCantSocios.Location = New System.Drawing.Point(4, 383)
        Me.lblTitCantSocios.Name = "lblTitCantSocios"
        Me.lblTitCantSocios.Size = New System.Drawing.Size(124, 17)
        Me.lblTitCantSocios.TabIndex = 99
        Me.lblTitCantSocios.Text = "Cantidad de Socios:"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "CI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 230
        '
        'Ausen
        '
        Me.Ausen.Frozen = True
        Me.Ausen.HeaderText = "Días Ausente"
        Me.Ausen.Name = "Ausen"
        Me.Ausen.ReadOnly = True
        '
        'VerDias
        '
        Me.VerDias.Frozen = True
        Me.VerDias.HeaderText = "Ver Días"
        Me.VerDias.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.VerDias.Name = "VerDias"
        Me.VerDias.ReadOnly = True
        Me.VerDias.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VerDias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'VerFicha
        '
        Me.VerFicha.Frozen = True
        Me.VerFicha.HeaderText = "Fer Ficha"
        Me.VerFicha.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.VerFicha.Name = "VerFicha"
        Me.VerFicha.ReadOnly = True
        Me.VerFicha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VerFicha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTopBar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAsistencia"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBuscCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDelCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAusencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents dgvAsistencia As DataGridView
    Friend WithEvents FechaCol As DataGridViewTextBoxColumn
    Friend WithEvents Hor As DataGridViewTextBoxColumn
    Friend WithEvents Ced As DataGridViewTextBoxColumn
    Friend WithEvents NombreCol As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblSocio As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents cmbFiltrarPor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents txtCI As TextBox
    Friend WithEvents cmbAno As ComboBox
    Friend WithEvents pbxBuscCli As PictureBox
    Friend WithEvents pbxDelCli As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCantSocio As Label
    Friend WithEvents lblTitCantSocios As Label
    Friend WithEvents lblAusente As Label
    Friend WithEvents lblTitAusente As Label
    Friend WithEvents dgvAusencia As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Ausen As DataGridViewTextBoxColumn
    Friend WithEvents VerDias As DataGridViewImageColumn
    Friend WithEvents VerFicha As DataGridViewImageColumn
End Class
