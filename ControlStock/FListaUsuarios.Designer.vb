<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaUsuarios
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbVerPor = New System.Windows.Forms.ToolStripComboBox()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelPrivilegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlEliminar = New System.Windows.Forms.Panel()
        Me.LblEliminar = New System.Windows.Forms.Label()
        Me.PbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pnlEditar = New System.Windows.Forms.Panel()
        Me.lblEditar = New System.Windows.Forms.Label()
        Me.pbxEditar = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PnlEliminar.SuspendLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditar.SuspendLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Usu, Me.Pass, Me.NivelPrivilegio, Me.CIEmpleado})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(574, 321)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnActualizar, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cmbVerPor, Me.txtBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(586, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.ControlStock.My.Resources.Resources.add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.btnNuevo.Text = "ToolStripButton1"
        Me.btnNuevo.ToolTipText = "Nuevo "
        '
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnActualizar.Image = Global.ControlStock.My.Resources.Resources.refresh1
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(23, 22)
        Me.btnActualizar.Text = "Actualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel1.Text = "Ver Por:"
        '
        'cmbVerPor
        '
        Me.cmbVerPor.Items.AddRange(New Object() {"Todos", "Nombre de Usuario", "CI de Empleado"})
        Me.cmbVerPor.Name = "cmbVerPor"
        Me.cmbVerPor.Size = New System.Drawing.Size(121, 25)
        '
        'txtBuscar
        '
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 25)
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Location = New System.Drawing.Point(208, 25)
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
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.NullValue = Nothing
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.ControlStock.My.Resources.Resources.file_edit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 22
        '
        'Id
        '
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Id.DefaultCellStyle = DataGridViewCellStyle10
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Id.Width = 60
        '
        'Usu
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Usu.DefaultCellStyle = DataGridViewCellStyle11
        Me.Usu.HeaderText = "Usuario"
        Me.Usu.Name = "Usu"
        Me.Usu.ReadOnly = True
        Me.Usu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Usu.Width = 120
        '
        'Pass
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Pass.DefaultCellStyle = DataGridViewCellStyle12
        Me.Pass.HeaderText = "Contraseña"
        Me.Pass.Name = "Pass"
        Me.Pass.ReadOnly = True
        Me.Pass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Pass.Width = 120
        '
        'NivelPrivilegio
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.NullValue = Nothing
        Me.NivelPrivilegio.DefaultCellStyle = DataGridViewCellStyle13
        Me.NivelPrivilegio.HeaderText = "Nivel de Privilegio"
        Me.NivelPrivilegio.Name = "NivelPrivilegio"
        Me.NivelPrivilegio.ReadOnly = True
        Me.NivelPrivilegio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NivelPrivilegio.Width = 120
        '
        'CIEmpleado
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.NullValue = Nothing
        Me.CIEmpleado.DefaultCellStyle = DataGridViewCellStyle14
        Me.CIEmpleado.HeaderText = "CI Empleado"
        Me.CIEmpleado.Name = "CIEmpleado"
        Me.CIEmpleado.ReadOnly = True
        Me.CIEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CIEmpleado.Width = 120
        '
        'PnlEliminar
        '
        Me.PnlEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEliminar.Controls.Add(Me.LblEliminar)
        Me.PnlEliminar.Controls.Add(Me.PbxEliminar)
        Me.PnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlEliminar.Location = New System.Drawing.Point(476, 368)
        Me.PnlEliminar.Name = "PnlEliminar"
        Me.PnlEliminar.Size = New System.Drawing.Size(105, 37)
        Me.PnlEliminar.TabIndex = 91
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
        Me.pnlEditar.Location = New System.Drawing.Point(380, 368)
        Me.pnlEditar.Name = "pnlEditar"
        Me.pnlEditar.Size = New System.Drawing.Size(93, 37)
        Me.pnlEditar.TabIndex = 90
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
        'FListaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(586, 406)
        Me.Controls.Add(Me.PnlEliminar)
        Me.Controls.Add(Me.pnlEditar)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FListaUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PnlEliminar.ResumeLayout(False)
        Me.PnlEliminar.PerformLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditar.ResumeLayout(False)
        Me.pnlEditar.PerformLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Usu As DataGridViewTextBoxColumn
    Friend WithEvents Pass As DataGridViewTextBoxColumn
    Friend WithEvents NivelPrivilegio As DataGridViewTextBoxColumn
    Friend WithEvents CIEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents PnlEliminar As Panel
    Friend WithEvents LblEliminar As Label
    Friend WithEvents PbxEliminar As PictureBox
    Friend WithEvents pnlEditar As Panel
    Friend WithEvents lblEditar As Label
    Friend WithEvents pbxEditar As PictureBox
End Class
