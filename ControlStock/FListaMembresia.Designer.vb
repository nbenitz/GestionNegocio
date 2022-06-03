<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FListaMembresia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FListaMembresia))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.PnlEliminar = New System.Windows.Forms.Panel()
        Me.LblEliminar = New System.Windows.Forms.Label()
        Me.PbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pnlEditar = New System.Windows.Forms.Panel()
        Me.lblEditar = New System.Windows.Forms.Label()
        Me.pbxEditar = New System.Windows.Forms.PictureBox()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLimiteTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVecesDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDiasSemana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDiasMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEliminar.SuspendLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditar.SuspendLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Motivo, Me.ColLimiteTiempo, Me.ColVecesDia, Me.ColDiasSemana, Me.ColDiasMes, Me.ColDias, Me.ColHorario})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 47)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(974, 359)
        Me.DataGridView1.TabIndex = 2
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1003, 35)
        Me.pnlTopBar.TabIndex = 8
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(93, 16)
        Me.lblTitulo.TabIndex = 118
        Me.lblTitulo.Text = "Membresías"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(968, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'PnlEliminar
        '
        Me.PnlEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEliminar.Controls.Add(Me.LblEliminar)
        Me.PnlEliminar.Controls.Add(Me.PbxEliminar)
        Me.PnlEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlEliminar.Location = New System.Drawing.Point(881, 412)
        Me.PnlEliminar.Name = "PnlEliminar"
        Me.PnlEliminar.Size = New System.Drawing.Size(105, 37)
        Me.PnlEliminar.TabIndex = 95
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
        Me.pnlEditar.Location = New System.Drawing.Point(785, 412)
        Me.pnlEditar.Name = "pnlEditar"
        Me.pnlEditar.Size = New System.Drawing.Size(93, 37)
        Me.pnlEditar.TabIndex = 94
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
        'Nombre
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Nombre.Width = 230
        '
        'Motivo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Motivo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Motivo.HeaderText = "Precio"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        Me.Motivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Motivo.Width = 80
        '
        'ColLimiteTiempo
        '
        Me.ColLimiteTiempo.HeaderText = "Límite de Tiempo"
        Me.ColLimiteTiempo.Name = "ColLimiteTiempo"
        Me.ColLimiteTiempo.ReadOnly = True
        Me.ColLimiteTiempo.Width = 85
        '
        'ColVecesDia
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColVecesDia.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColVecesDia.HeaderText = "Veces/día"
        Me.ColVecesDia.Name = "ColVecesDia"
        Me.ColVecesDia.ReadOnly = True
        Me.ColVecesDia.Width = 80
        '
        'ColDiasSemana
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColDiasSemana.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColDiasSemana.HeaderText = "Días/Semana"
        Me.ColDiasSemana.Name = "ColDiasSemana"
        Me.ColDiasSemana.ReadOnly = True
        Me.ColDiasSemana.Width = 90
        '
        'ColDiasMes
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColDiasMes.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColDiasMes.HeaderText = "Días/Mes"
        Me.ColDiasMes.Name = "ColDiasMes"
        Me.ColDiasMes.ReadOnly = True
        Me.ColDiasMes.Width = 80
        '
        'ColDias
        '
        Me.ColDias.HeaderText = "Días"
        Me.ColDias.Name = "ColDias"
        Me.ColDias.ReadOnly = True
        Me.ColDias.Width = 180
        '
        'ColHorario
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColHorario.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColHorario.HeaderText = "Horario"
        Me.ColHorario.Name = "ColHorario"
        Me.ColHorario.ReadOnly = True
        Me.ColHorario.Width = 120
        '
        'FListaMembresia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1003, 461)
        Me.Controls.Add(Me.PnlEliminar)
        Me.Controls.Add(Me.pnlEditar)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FListaMembresia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membresías"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEliminar.ResumeLayout(False)
        Me.PnlEliminar.PerformLayout()
        CType(Me.PbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditar.ResumeLayout(False)
        Me.pnlEditar.PerformLayout()
        CType(Me.pbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PnlEliminar As Panel
    Friend WithEvents LblEliminar As Label
    Friend WithEvents PbxEliminar As PictureBox
    Friend WithEvents pnlEditar As Panel
    Friend WithEvents lblEditar As Label
    Friend WithEvents pbxEditar As PictureBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Motivo As DataGridViewTextBoxColumn
    Friend WithEvents ColLimiteTiempo As DataGridViewTextBoxColumn
    Friend WithEvents ColVecesDia As DataGridViewTextBoxColumn
    Friend WithEvents ColDiasSemana As DataGridViewTextBoxColumn
    Friend WithEvents ColDiasMes As DataGridViewTextBoxColumn
    Friend WithEvents ColDias As DataGridViewTextBoxColumn
    Friend WithEvents ColHorario As DataGridViewTextBoxColumn
End Class
