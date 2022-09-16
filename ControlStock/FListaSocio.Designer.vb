<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FListaSocio
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaSocio))
        Me.lblAux = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.ColSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColFoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Memb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSocios = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PnlEliminar = New System.Windows.Forms.Panel()
        Me.LblEliminar = New System.Windows.Forms.Label()
        Me.PbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pnlEditar = New System.Windows.Forms.Panel()
        Me.lblEditar = New System.Windows.Forms.Label()
        Me.pbxEditar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pnlSeleccionar = New System.Windows.Forms.Panel()
        Me.lblSeleccionar = New System.Windows.Forms.Label()
        Me.pbxSeleccionar = New System.Windows.Forms.PictureBox()
        Me.pnlFicha = New System.Windows.Forms.Panel()
        Me.lblFicha = New System.Windows.Forms.Label()
        Me.pbxFicha = New System.Windows.Forms.PictureBox()
        Me.chkAlDia = New System.Windows.Forms.CheckBox()
        Me.chkCuotaVencida = New System.Windows.Forms.CheckBox()
        Me.chkConDeuda = New System.Windows.Forms.CheckBox()
        Me.chkInactivos = New System.Windows.Forms.CheckBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PnlEliminar.SuspendLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditar.SuspendLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSeleccionar.SuspendLayout()
        CType(Me.pbxSeleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFicha.SuspendLayout()
        CType(Me.pbxFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.BackColor = System.Drawing.Color.LightGray
        Me.lblAux.ForeColor = System.Drawing.Color.Black
        Me.lblAux.Location = New System.Drawing.Point(302, 31)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(43, 13)
        Me.lblAux.TabIndex = 7
        Me.lblAux.Text = "ToolTip"
        Me.lblAux.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        '
        'txtBuscar
        '
        Me.txtBuscar.AutoSize = False
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(150, 23)
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.file_edit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCliente.ColumnHeadersHeight = 25
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColSelect, Me.ColFoto, Me.CI, Me.Nombre, Me.Memb, Me.Tel, Me.ColPendiente, Me.ColEstado, Me.Acc})
        Me.dgvCliente.GridColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.dgvCliente.Location = New System.Drawing.Point(7, 43)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCliente.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCliente.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCliente.RowTemplate.Height = 56
        Me.dgvCliente.RowTemplate.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(934, 511)
        Me.dgvCliente.TabIndex = 5
        '
        'ColSelect
        '
        Me.ColSelect.Frozen = True
        Me.ColSelect.HeaderText = ""
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.ReadOnly = True
        Me.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColSelect.Width = 25
        '
        'ColFoto
        '
        Me.ColFoto.Frozen = True
        Me.ColFoto.HeaderText = "Foto"
        Me.ColFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ColFoto.Name = "ColFoto"
        Me.ColFoto.ReadOnly = True
        Me.ColFoto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColFoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColFoto.Width = 56
        '
        'CI
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CI.DefaultCellStyle = DataGridViewCellStyle3
        Me.CI.Frozen = True
        Me.CI.HeaderText = "CI"
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        '
        'Nombre
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 220
        '
        'Memb
        '
        Me.Memb.Frozen = True
        Me.Memb.HeaderText = "Membresía"
        Me.Memb.Name = "Memb"
        Me.Memb.ReadOnly = True
        Me.Memb.Width = 220
        '
        'Tel
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Tel.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tel.HeaderText = "Teléfono"
        Me.Tel.Name = "Tel"
        Me.Tel.ReadOnly = True
        Me.Tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPendiente
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ColPendiente.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColPendiente.HeaderText = "Saldo Pend."
        Me.ColPendiente.Name = "ColPendiente"
        Me.ColPendiente.ReadOnly = True
        Me.ColPendiente.Width = 90
        '
        'ColEstado
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColEstado.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColEstado.HeaderText = "Estado"
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.ReadOnly = True
        '
        'Acc
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Acc.DefaultCellStyle = DataGridViewCellStyle8
        Me.Acc.HeaderText = "ID Acceso"
        Me.Acc.Name = "Acc"
        Me.Acc.ReadOnly = True
        Me.Acc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Acc.Visible = False
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.NullValue = Nothing
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.ControlStock.My.Resources.Resources.file_del
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 22
        '
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnActualizar.Image = Global.ControlStock.My.Resources.Resources.refresh1
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(23, 32)
        Me.btnActualizar.Text = "Actualizar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = Global.ControlStock.My.Resources.Resources.add
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(23, 32)
        Me.BtnNuevo.Text = "ToolStripButton1"
        Me.BtnNuevo.ToolTipText = "Nuevo Empleado"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripLabel1.Text = "Buscar:"
        '
        'Separador
        '
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSocios, Me.BtnNuevo, Me.btnActualizar, Me.Separador, Me.ToolStripLabel1, Me.txtBuscar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(949, 35)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSocios
        '
        Me.lblSocios.AutoSize = False
        Me.lblSocios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocios.ForeColor = System.Drawing.Color.White
        Me.lblSocios.MergeIndex = 3
        Me.lblSocios.Name = "lblSocios"
        Me.lblSocios.Size = New System.Drawing.Size(60, 32)
        Me.lblSocios.Text = "Socios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'PnlEliminar
        '
        Me.PnlEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEliminar.Controls.Add(Me.LblEliminar)
        Me.PnlEliminar.Controls.Add(Me.PbxEliminar)
        Me.PnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlEliminar.Location = New System.Drawing.Point(832, 560)
        Me.PnlEliminar.Name = "PnlEliminar"
        Me.PnlEliminar.Size = New System.Drawing.Size(105, 37)
        Me.PnlEliminar.TabIndex = 93
        '
        'LblEliminar
        '
        Me.LblEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblEliminar.AutoSize = True
        Me.LblEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEliminar.ForeColor = System.Drawing.Color.White
        Me.LblEliminar.Location = New System.Drawing.Point(33, 9)
        Me.LblEliminar.Name = "LblEliminar"
        Me.LblEliminar.Size = New System.Drawing.Size(65, 20)
        Me.LblEliminar.TabIndex = 85
        Me.LblEliminar.Text = "Eliminar"
        '
        'PbxEliminar
        '
        Me.PbxEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PbxEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxEliminar.Image = Global.ControlStock.My.Resources.Resources.file_del
        Me.PbxEliminar.Location = New System.Drawing.Point(3, 3)
        Me.PbxEliminar.Name = "PbxEliminar"
        Me.PbxEliminar.Size = New System.Drawing.Size(32, 30)
        Me.PbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxEliminar.TabIndex = 84
        Me.PbxEliminar.TabStop = False
        '
        'pnlEditar
        '
        Me.pnlEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlEditar.Controls.Add(Me.lblEditar)
        Me.pnlEditar.Controls.Add(Me.pbxEditar)
        Me.pnlEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlEditar.Location = New System.Drawing.Point(736, 560)
        Me.pnlEditar.Name = "pnlEditar"
        Me.pnlEditar.Size = New System.Drawing.Size(93, 37)
        Me.pnlEditar.TabIndex = 92
        '
        'lblEditar
        '
        Me.lblEditar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEditar.AutoSize = True
        Me.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditar.ForeColor = System.Drawing.Color.White
        Me.lblEditar.Location = New System.Drawing.Point(33, 9)
        Me.lblEditar.Name = "lblEditar"
        Me.lblEditar.Size = New System.Drawing.Size(51, 20)
        Me.lblEditar.TabIndex = 85
        Me.lblEditar.Text = "Editar"
        '
        'pbxEditar
        '
        Me.pbxEditar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxEditar.Image = Global.ControlStock.My.Resources.Resources.file_edit
        Me.pbxEditar.Location = New System.Drawing.Point(3, 3)
        Me.pbxEditar.Name = "pbxEditar"
        Me.pbxEditar.Size = New System.Drawing.Size(32, 30)
        Me.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEditar.TabIndex = 84
        Me.pbxEditar.TabStop = False
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(914, -1)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 117
        Me.BtnCerrarForm.TabStop = False
        '
        'pnlSeleccionar
        '
        Me.pnlSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSeleccionar.Controls.Add(Me.lblSeleccionar)
        Me.pnlSeleccionar.Controls.Add(Me.pbxSeleccionar)
        Me.pnlSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSeleccionar.Location = New System.Drawing.Point(7, 560)
        Me.pnlSeleccionar.Name = "pnlSeleccionar"
        Me.pnlSeleccionar.Size = New System.Drawing.Size(131, 37)
        Me.pnlSeleccionar.TabIndex = 118
        Me.pnlSeleccionar.Visible = False
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionar.ForeColor = System.Drawing.Color.White
        Me.lblSeleccionar.Location = New System.Drawing.Point(33, 9)
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(92, 20)
        Me.lblSeleccionar.TabIndex = 85
        Me.lblSeleccionar.Text = "Seleccionar"
        '
        'pbxSeleccionar
        '
        Me.pbxSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSeleccionar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.pbxSeleccionar.Location = New System.Drawing.Point(3, 3)
        Me.pbxSeleccionar.Name = "pbxSeleccionar"
        Me.pbxSeleccionar.Size = New System.Drawing.Size(32, 30)
        Me.pbxSeleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxSeleccionar.TabIndex = 84
        Me.pbxSeleccionar.TabStop = False
        '
        'pnlFicha
        '
        Me.pnlFicha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlFicha.Controls.Add(Me.lblFicha)
        Me.pnlFicha.Controls.Add(Me.pbxFicha)
        Me.pnlFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlFicha.Location = New System.Drawing.Point(616, 560)
        Me.pnlFicha.Name = "pnlFicha"
        Me.pnlFicha.Size = New System.Drawing.Size(117, 37)
        Me.pnlFicha.TabIndex = 119
        '
        'lblFicha
        '
        Me.lblFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFicha.AutoSize = True
        Me.lblFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicha.ForeColor = System.Drawing.Color.White
        Me.lblFicha.Location = New System.Drawing.Point(33, 9)
        Me.lblFicha.Name = "lblFicha"
        Me.lblFicha.Size = New System.Drawing.Size(77, 20)
        Me.lblFicha.TabIndex = 85
        Me.lblFicha.Text = "Ver Ficha"
        '
        'pbxFicha
        '
        Me.pbxFicha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxFicha.Image = Global.ControlStock.My.Resources.Resources.file_document
        Me.pbxFicha.Location = New System.Drawing.Point(3, 3)
        Me.pbxFicha.Name = "pbxFicha"
        Me.pbxFicha.Size = New System.Drawing.Size(32, 30)
        Me.pbxFicha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFicha.TabIndex = 84
        Me.pbxFicha.TabStop = False
        '
        'chkAlDia
        '
        Me.chkAlDia.BackColor = System.Drawing.Color.Green
        Me.chkAlDia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlDia.ForeColor = System.Drawing.Color.White
        Me.chkAlDia.Location = New System.Drawing.Point(411, 6)
        Me.chkAlDia.Name = "chkAlDia"
        Me.chkAlDia.Size = New System.Drawing.Size(57, 23)
        Me.chkAlDia.TabIndex = 120
        Me.chkAlDia.Text = "Al día"
        Me.chkAlDia.UseVisualStyleBackColor = False
        '
        'chkCuotaVencida
        '
        Me.chkCuotaVencida.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkCuotaVencida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuotaVencida.ForeColor = System.Drawing.Color.White
        Me.chkCuotaVencida.Location = New System.Drawing.Point(474, 6)
        Me.chkCuotaVencida.Name = "chkCuotaVencida"
        Me.chkCuotaVencida.Size = New System.Drawing.Size(102, 23)
        Me.chkCuotaVencida.TabIndex = 121
        Me.chkCuotaVencida.Text = "Cuota Vencida"
        Me.chkCuotaVencida.UseVisualStyleBackColor = False
        '
        'chkConDeuda
        '
        Me.chkConDeuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.chkConDeuda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConDeuda.ForeColor = System.Drawing.Color.White
        Me.chkConDeuda.Location = New System.Drawing.Point(582, 6)
        Me.chkConDeuda.Name = "chkConDeuda"
        Me.chkConDeuda.Size = New System.Drawing.Size(85, 23)
        Me.chkConDeuda.TabIndex = 122
        Me.chkConDeuda.Text = "Con Deuda"
        Me.chkConDeuda.UseVisualStyleBackColor = False
        '
        'chkInactivos
        '
        Me.chkInactivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkInactivos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInactivos.ForeColor = System.Drawing.Color.White
        Me.chkInactivos.Location = New System.Drawing.Point(673, 6)
        Me.chkInactivos.Name = "chkInactivos"
        Me.chkInactivos.Size = New System.Drawing.Size(73, 23)
        Me.chkInactivos.TabIndex = 124
        Me.chkInactivos.Text = "Inactivos"
        Me.chkInactivos.UseVisualStyleBackColor = False
        Me.chkInactivos.Visible = False
        '
        'chkTodos
        '
        Me.chkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.chkTodos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.ForeColor = System.Drawing.Color.White
        Me.chkTodos.Location = New System.Drawing.Point(348, 6)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(57, 23)
        Me.chkTodos.TabIndex = 125
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = False
        '
        'FListaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 602)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.chkInactivos)
        Me.Controls.Add(Me.chkConDeuda)
        Me.Controls.Add(Me.chkCuotaVencida)
        Me.Controls.Add(Me.chkAlDia)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.pnlFicha)
        Me.Controls.Add(Me.pnlSeleccionar)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.PnlEliminar)
        Me.Controls.Add(Me.pnlEditar)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FListaSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PnlEliminar.ResumeLayout(False)
        Me.PnlEliminar.PerformLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditar.ResumeLayout(False)
        Me.pnlEditar.PerformLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSeleccionar.ResumeLayout(False)
        Me.pnlSeleccionar.PerformLayout()
        CType(Me.pbxSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFicha.ResumeLayout(False)
        Me.pnlFicha.PerformLayout()
        CType(Me.pbxFicha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAux As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PnlEliminar As Panel
    Friend WithEvents LblEliminar As Label
    Friend WithEvents PbxEliminar As PictureBox
    Friend WithEvents pnlEditar As Panel
    Friend WithEvents lblEditar As Label
    Friend WithEvents pbxEditar As PictureBox
    Friend WithEvents Membresia As DataGridViewTextBoxColumn
    Friend WithEvents Acceso As DataGridViewTextBoxColumn
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lblSocios As ToolStripLabel
    Friend WithEvents pnlSeleccionar As Panel
    Friend WithEvents lblSeleccionar As Label
    Friend WithEvents pbxSeleccionar As PictureBox
    Friend WithEvents pnlFicha As Panel
    Friend WithEvents lblFicha As Label
    Friend WithEvents pbxFicha As PictureBox
    Friend WithEvents ColSelect As DataGridViewCheckBoxColumn
    Friend WithEvents ColFoto As DataGridViewImageColumn
    Friend WithEvents CI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Memb As DataGridViewTextBoxColumn
    Friend WithEvents Tel As DataGridViewTextBoxColumn
    Friend WithEvents ColPendiente As DataGridViewTextBoxColumn
    Friend WithEvents ColEstado As DataGridViewTextBoxColumn
    Friend WithEvents Acc As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents chkAlDia As CheckBox
    Friend WithEvents chkCuotaVencida As CheckBox
    Friend WithEvents chkConDeuda As CheckBox
    Friend WithEvents chkInactivos As CheckBox
    Friend WithEvents chkTodos As CheckBox
End Class
