﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaEmple
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaEmple))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbVerPor = New System.Windows.Forms.ToolStripComboBox()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlEliminar = New System.Windows.Forms.Panel()
        Me.LblEliminar = New System.Windows.Forms.Label()
        Me.PbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pnlEditar = New System.Windows.Forms.Panel()
        Me.lblEditar = New System.Windows.Forms.Label()
        Me.pbxEditar = New System.Windows.Forms.PictureBox()
        Me.pnlNuevoUsu = New System.Windows.Forms.Panel()
        Me.lblNuevoUsu = New System.Windows.Forms.Label()
        Me.PbxNuevoUsu = New System.Windows.Forms.PictureBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PnlEliminar.SuspendLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditar.SuspendLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNuevoUsu.SuspendLayout()
        CType(Me.PbxNuevoUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
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
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.Nombre, Me.Apellido, Me.Tel, Me.Dir, Me.Comision})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(6, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(752, 354)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.btnNuevo, Me.btnActualizar, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cmbVerPor, Me.txtBuscar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(764, 35)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(75, 32)
        Me.ToolStripLabel2.Text = "Empleados"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.ControlStock.My.Resources.Resources.add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(23, 32)
        Me.btnNuevo.Text = "ToolStripButton1"
        Me.btnNuevo.ToolTipText = "Nuevo Empleado"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 32)
        Me.ToolStripLabel1.Text = "Ver Por:"
        '
        'cmbVerPor
        '
        Me.cmbVerPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbVerPor.ForeColor = System.Drawing.Color.White
        Me.cmbVerPor.Items.AddRange(New Object() {"Todos", "Nombre", "Apellido", "CI Nro:"})
        Me.cmbVerPor.Name = "cmbVerPor"
        Me.cmbVerPor.Size = New System.Drawing.Size(121, 35)
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 35)
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.AutoSize = False
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = Global.ControlStock.My.Resources.Resources.BtnCerrarForm_Image
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(34, 34)
        Me.btnSalir.Text = "ToolStripButton1"
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.BackColor = System.Drawing.Color.LightGray
        Me.lblAux.Location = New System.Drawing.Point(208, 31)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(43, 13)
        Me.lblAux.TabIndex = 4
        Me.lblAux.Text = "ToolTip"
        Me.lblAux.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        '
        'PnlEliminar
        '
        Me.PnlEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEliminar.Controls.Add(Me.LblEliminar)
        Me.PnlEliminar.Controls.Add(Me.PbxEliminar)
        Me.PnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlEliminar.Location = New System.Drawing.Point(654, 406)
        Me.PnlEliminar.Name = "PnlEliminar"
        Me.PnlEliminar.Size = New System.Drawing.Size(105, 37)
        Me.PnlEliminar.TabIndex = 89
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
        Me.pnlEditar.Location = New System.Drawing.Point(558, 406)
        Me.pnlEditar.Name = "pnlEditar"
        Me.pnlEditar.Size = New System.Drawing.Size(93, 37)
        Me.pnlEditar.TabIndex = 88
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
        'pnlNuevoUsu
        '
        Me.pnlNuevoUsu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlNuevoUsu.Controls.Add(Me.lblNuevoUsu)
        Me.pnlNuevoUsu.Controls.Add(Me.PbxNuevoUsu)
        Me.pnlNuevoUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlNuevoUsu.Location = New System.Drawing.Point(6, 406)
        Me.pnlNuevoUsu.Name = "pnlNuevoUsu"
        Me.pnlNuevoUsu.Size = New System.Drawing.Size(146, 37)
        Me.pnlNuevoUsu.TabIndex = 90
        Me.pnlNuevoUsu.Visible = False
        '
        'lblNuevoUsu
        '
        Me.lblNuevoUsu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNuevoUsu.AutoSize = True
        Me.lblNuevoUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNuevoUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoUsu.ForeColor = System.Drawing.Color.White
        Me.lblNuevoUsu.Location = New System.Drawing.Point(33, 9)
        Me.lblNuevoUsu.Name = "lblNuevoUsu"
        Me.lblNuevoUsu.Size = New System.Drawing.Size(107, 20)
        Me.lblNuevoUsu.TabIndex = 85
        Me.lblNuevoUsu.Text = "Crear Usuario"
        '
        'PbxNuevoUsu
        '
        Me.PbxNuevoUsu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PbxNuevoUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxNuevoUsu.Image = Global.ControlStock.My.Resources.Resources.file_new
        Me.PbxNuevoUsu.Location = New System.Drawing.Point(3, 3)
        Me.PbxNuevoUsu.Name = "PbxNuevoUsu"
        Me.PbxNuevoUsu.Size = New System.Drawing.Size(32, 30)
        Me.PbxNuevoUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxNuevoUsu.TabIndex = 84
        Me.PbxNuevoUsu.TabStop = False
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.NullValue = CType(resources.GetObject("DataGridViewCellStyle11.NullValue"), Object)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.file_edit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'CI
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CI.DefaultCellStyle = DataGridViewCellStyle2
        Me.CI.HeaderText = "CI Nro."
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        Me.CI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CI.Width = 80
        '
        'Nombre
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Nombre.Width = 110
        '
        'Apellido
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Apellido.DefaultCellStyle = DataGridViewCellStyle4
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Apellido.Width = 110
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
        'Dir
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Dir.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dir.HeaderText = "Dirección"
        Me.Dir.Name = "Dir"
        Me.Dir.ReadOnly = True
        Me.Dir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Dir.Width = 250
        '
        'Comision
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Comision.DefaultCellStyle = DataGridViewCellStyle7
        Me.Comision.HeaderText = "Comisión"
        Me.Comision.Name = "Comision"
        Me.Comision.ReadOnly = True
        Me.Comision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Comision.Width = 70
        '
        'FListaEmple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 447)
        Me.Controls.Add(Me.pnlNuevoUsu)
        Me.Controls.Add(Me.PnlEliminar)
        Me.Controls.Add(Me.pnlEditar)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FListaEmple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PnlEliminar.ResumeLayout(False)
        Me.PnlEliminar.PerformLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditar.ResumeLayout(False)
        Me.pnlEditar.PerformLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNuevoUsu.ResumeLayout(False)
        Me.pnlNuevoUsu.PerformLayout()
        CType(Me.PbxNuevoUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbVerPor As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblAux As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PnlEliminar As Panel
    Friend WithEvents LblEliminar As Label
    Friend WithEvents PbxEliminar As PictureBox
    Friend WithEvents pnlEditar As Panel
    Friend WithEvents lblEditar As Label
    Friend WithEvents pbxEditar As PictureBox
    Friend WithEvents pnlNuevoUsu As Panel
    Friend WithEvents lblNuevoUsu As Label
    Friend WithEvents PbxNuevoUsu As PictureBox
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents CI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Tel As DataGridViewTextBoxColumn
    Friend WithEvents Dir As DataGridViewTextBoxColumn
    Friend WithEvents Comision As DataGridViewTextBoxColumn
End Class
