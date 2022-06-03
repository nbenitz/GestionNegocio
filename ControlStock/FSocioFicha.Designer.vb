<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSocioFicha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSocioFicha))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.PnlEliminar = New System.Windows.Forms.Panel()
        Me.LblEliminar = New System.Windows.Forms.Label()
        Me.PbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pnlEditar = New System.Windows.Forms.Panel()
        Me.lblEditar = New System.Windows.Forms.Label()
        Me.pbxEditar = New System.Windows.Forms.PictureBox()
        Me.dgvMembresias = New System.Windows.Forms.DataGridView()
        Me.lblConocio = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.BtnCuentas = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.btnSeguimiento = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.lblAlias = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblSaldoPendiente = New System.Windows.Forms.Label()
        Me.lblTitSaldoPendiente = New System.Windows.Forms.Label()
        Me.ColSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Memb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVenc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Atras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEliminar.SuspendLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditar.SuspendLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMembresias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTopBar.Size = New System.Drawing.Size(949, 35)
        Me.pnlTopBar.TabIndex = 82
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(9, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(100, 17)
        Me.lblTitulo.TabIndex = 117
        Me.lblTitulo.Text = "Ficha del Socio"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(914, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'PnlEliminar
        '
        Me.PnlEliminar.Controls.Add(Me.LblEliminar)
        Me.PnlEliminar.Controls.Add(Me.PbxEliminar)
        Me.PnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlEliminar.Location = New System.Drawing.Point(318, 535)
        Me.PnlEliminar.Name = "PnlEliminar"
        Me.PnlEliminar.Size = New System.Drawing.Size(105, 37)
        Me.PnlEliminar.TabIndex = 123
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
        Me.pnlEditar.Controls.Add(Me.lblEditar)
        Me.pnlEditar.Controls.Add(Me.pbxEditar)
        Me.pnlEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlEditar.Location = New System.Drawing.Point(222, 535)
        Me.pnlEditar.Name = "pnlEditar"
        Me.pnlEditar.Size = New System.Drawing.Size(93, 37)
        Me.pnlEditar.TabIndex = 122
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
        'dgvMembresias
        '
        Me.dgvMembresias.AllowUserToAddRows = False
        Me.dgvMembresias.AllowUserToResizeRows = False
        Me.dgvMembresias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvMembresias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMembresias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMembresias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembresias.ColumnHeadersHeight = 25
        Me.dgvMembresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMembresias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColSelect, Me.Memb, Me.ColInicio, Me.ColVenc, Me.Cost, Me.Pagad, Me.Saldo, Me.Atras})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembresias.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMembresias.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvMembresias.Location = New System.Drawing.Point(222, 345)
        Me.dgvMembresias.MultiSelect = False
        Me.dgvMembresias.Name = "dgvMembresias"
        Me.dgvMembresias.ReadOnly = True
        Me.dgvMembresias.RowHeadersVisible = False
        Me.dgvMembresias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembresias.Size = New System.Drawing.Size(701, 184)
        Me.dgvMembresias.TabIndex = 121
        '
        'lblConocio
        '
        Me.lblConocio.AutoSize = True
        Me.lblConocio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConocio.ForeColor = System.Drawing.Color.White
        Me.lblConocio.Location = New System.Drawing.Point(297, 235)
        Me.lblConocio.Name = "lblConocio"
        Me.lblConocio.Size = New System.Drawing.Size(13, 17)
        Me.lblConocio.TabIndex = 120
        Me.lblConocio.Text = "-"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(217, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 35)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "¿Cómo nos conoció?"
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcceso.ForeColor = System.Drawing.Color.White
        Me.lblAcceso.Location = New System.Drawing.Point(297, 274)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(13, 17)
        Me.lblAcceso.TabIndex = 118
        Me.lblAcceso.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(217, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Cod. Acceso"
        '
        'btnBaja
        '
        Me.btnBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.Color.LightGray
        Me.btnBaja.Location = New System.Drawing.Point(787, 261)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(134, 30)
        Me.btnBaja.TabIndex = 116
        Me.btnBaja.Text = "Dar de Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'BtnCuentas
        '
        Me.BtnCuentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCuentas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCuentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCuentas.Location = New System.Drawing.Point(787, 117)
        Me.BtnCuentas.Name = "BtnCuentas"
        Me.BtnCuentas.Size = New System.Drawing.Size(134, 30)
        Me.BtnCuentas.TabIndex = 115
        Me.BtnCuentas.Text = "Cuenta Corriente"
        Me.BtnCuentas.UseVisualStyleBackColor = True
        '
        'btnAsistencia
        '
        Me.btnAsistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistencia.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAsistencia.Location = New System.Drawing.Point(787, 153)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(134, 30)
        Me.btnAsistencia.TabIndex = 114
        Me.btnAsistencia.Text = "Asistencia"
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'btnSeguimiento
        '
        Me.btnSeguimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeguimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguimiento.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSeguimiento.Location = New System.Drawing.Point(787, 189)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(134, 30)
        Me.btnSeguimiento.TabIndex = 113
        Me.btnSeguimiento.Text = "Seguimiento"
        Me.btnSeguimiento.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCobrar.Location = New System.Drawing.Point(787, 225)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(134, 30)
        Me.btnCobrar.TabIndex = 112
        Me.btnCobrar.Text = "Cobrar Cuota"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.Location = New System.Drawing.Point(787, 81)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(134, 30)
        Me.btnEditar.TabIndex = 111
        Me.btnEditar.Text = "Editar Datos"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(246, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 17)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Historial de Membresías"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.ForeColor = System.Drawing.Color.White
        Me.lblCI.Location = New System.Drawing.Point(297, 108)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(57, 17)
        Me.lblCI.TabIndex = 109
        Me.lblCI.Text = "4111222"
        '
        'lblAlias
        '
        Me.lblAlias.AutoSize = True
        Me.lblAlias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlias.ForeColor = System.Drawing.Color.White
        Me.lblAlias.Location = New System.Drawing.Point(297, 150)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(38, 17)
        Me.lblAlias.TabIndex = 108
        Me.lblAlias.Text = "Álias"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(297, 171)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(78, 17)
        Me.lblTelefono.TabIndex = 107
        Me.lblTelefono.Text = "0994123123"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.White
        Me.lblDireccion.Location = New System.Drawing.Point(297, 192)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(66, 17)
        Me.lblDireccion.TabIndex = 106
        Me.lblDireccion.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(253, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 17)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Datos Básicos"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.ForeColor = System.Drawing.Color.White
        Me.lblFechaNac.Location = New System.Drawing.Point(297, 214)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(13, 17)
        Me.lblFechaNac.TabIndex = 104
        Me.lblFechaNac.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(217, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Fecha Nac."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(217, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(217, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 17)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "CI"
        '
        'pbxFoto
        '
        Me.pbxFoto.Image = Global.ControlStock.My.Resources.Resources.userblack
        Me.pbxFoto.Location = New System.Drawing.Point(10, 99)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(173, 192)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxFoto.TabIndex = 96
        Me.pbxFoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(217, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(217, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(217, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Álias"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(297, 129)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(105, 17)
        Me.lblNombre.TabIndex = 98
        Me.lblNombre.Text = "Nombre Cliente"
        '
        'lblSaldoPendiente
        '
        Me.lblSaldoPendiente.AutoSize = True
        Me.lblSaldoPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSaldoPendiente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPendiente.ForeColor = System.Drawing.Color.White
        Me.lblSaldoPendiente.Location = New System.Drawing.Point(642, 274)
        Me.lblSaldoPendiente.Name = "lblSaldoPendiente"
        Me.lblSaldoPendiente.Size = New System.Drawing.Size(13, 17)
        Me.lblSaldoPendiente.TabIndex = 125
        Me.lblSaldoPendiente.Text = "-"
        '
        'lblTitSaldoPendiente
        '
        Me.lblTitSaldoPendiente.AutoSize = True
        Me.lblTitSaldoPendiente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitSaldoPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitSaldoPendiente.Location = New System.Drawing.Point(502, 274)
        Me.lblTitSaldoPendiente.Name = "lblTitSaldoPendiente"
        Me.lblTitSaldoPendiente.Size = New System.Drawing.Size(134, 17)
        Me.lblTitSaldoPendiente.TabIndex = 124
        Me.lblTitSaldoPendiente.Text = "Total Saldo Pendiente"
        '
        'ColSelect
        '
        Me.ColSelect.HeaderText = ""
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.ReadOnly = True
        Me.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSelect.Width = 23
        '
        'Memb
        '
        Me.Memb.HeaderText = "Membresía"
        Me.Memb.Name = "Memb"
        Me.Memb.ReadOnly = True
        Me.Memb.Width = 120
        '
        'ColInicio
        '
        Me.ColInicio.HeaderText = "Inicio"
        Me.ColInicio.Name = "ColInicio"
        Me.ColInicio.ReadOnly = True
        Me.ColInicio.Width = 85
        '
        'ColVenc
        '
        Me.ColVenc.HeaderText = "Vencimiento"
        Me.ColVenc.Name = "ColVenc"
        Me.ColVenc.ReadOnly = True
        Me.ColVenc.Width = 90
        '
        'Cost
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cost.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cost.HeaderText = "Precio"
        Me.Cost.Name = "Cost"
        Me.Cost.ReadOnly = True
        Me.Cost.Width = 85
        '
        'Pagad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Pagad.DefaultCellStyle = DataGridViewCellStyle3
        Me.Pagad.HeaderText = "Pagado"
        Me.Pagad.Name = "Pagad"
        Me.Pagad.ReadOnly = True
        Me.Pagad.Width = 90
        '
        'Saldo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Saldo.HeaderText = "Pendiente"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 90
        '
        'Atras
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Atras.DefaultCellStyle = DataGridViewCellStyle5
        Me.Atras.HeaderText = "Días Atraso"
        Me.Atras.Name = "Atras"
        Me.Atras.ReadOnly = True
        Me.Atras.Width = 90
        '
        'FSocioFicha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 602)
        Me.Controls.Add(Me.lblSaldoPendiente)
        Me.Controls.Add(Me.lblTitSaldoPendiente)
        Me.Controls.Add(Me.PnlEliminar)
        Me.Controls.Add(Me.pnlEditar)
        Me.Controls.Add(Me.dgvMembresias)
        Me.Controls.Add(Me.lblConocio)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblAcceso)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.BtnCuentas)
        Me.Controls.Add(Me.btnAsistencia)
        Me.Controls.Add(Me.btnSeguimiento)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.lblAlias)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pbxFoto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.pnlTopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FSocioFicha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FSocioFicha"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEliminar.ResumeLayout(False)
        Me.PnlEliminar.PerformLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditar.ResumeLayout(False)
        Me.pnlEditar.PerformLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMembresias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents PnlEliminar As Panel
    Friend WithEvents LblEliminar As Label
    Friend WithEvents PbxEliminar As PictureBox
    Friend WithEvents pnlEditar As Panel
    Friend WithEvents lblEditar As Label
    Friend WithEvents pbxEditar As PictureBox
    Friend WithEvents dgvMembresias As DataGridView
    Friend WithEvents lblConocio As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblAcceso As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBaja As Button
    Friend WithEvents BtnCuentas As Button
    Friend WithEvents btnAsistencia As Button
    Friend WithEvents btnSeguimiento As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents lblAlias As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pbxFoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSaldoPendiente As Label
    Friend WithEvents lblTitSaldoPendiente As Label
    Friend WithEvents ColSelect As DataGridViewCheckBoxColumn
    Friend WithEvents Memb As DataGridViewTextBoxColumn
    Friend WithEvents ColInicio As DataGridViewTextBoxColumn
    Friend WithEvents ColVenc As DataGridViewTextBoxColumn
    Friend WithEvents Cost As DataGridViewTextBoxColumn
    Friend WithEvents Pagad As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Atras As DataGridViewTextBoxColumn
End Class
