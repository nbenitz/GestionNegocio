<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEditarHabitacion2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEditarHabitacion2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNroHab = New System.Windows.Forms.TextBox()
        Me.TxtPrecio1 = New System.Windows.Forms.TextBox()
        Me.TxtPrecio3 = New System.Windows.Forms.TextBox()
        Me.LblPrecio3 = New System.Windows.Forms.Label()
        Me.TxtPrecio2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblPrecio2 = New System.Windows.Forms.Label()
        Me.LblPrecio1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Image = Global.ControlStock.My.Resources.Resources.file_exclude
        Me.btnCancel.Location = New System.Drawing.Point(330, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(41, 38)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancel.TabIndex = 83
        Me.btnCancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar")
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.ControlStock.My.Resources.Resources.file_apply
        Me.btnGuardar.Location = New System.Drawing.Point(292, 239)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(41, 38)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 84
        Me.btnGuardar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        '
        'txtNroHab
        '
        Me.txtNroHab.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroHab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroHab.ForeColor = System.Drawing.Color.White
        Me.txtNroHab.Location = New System.Drawing.Point(157, 41)
        Me.txtNroHab.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroHab.Name = "txtNroHab"
        Me.txtNroHab.ReadOnly = True
        Me.txtNroHab.Size = New System.Drawing.Size(189, 22)
        Me.txtNroHab.TabIndex = 0
        '
        'TxtPrecio1
        '
        Me.TxtPrecio1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtPrecio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio1.ForeColor = System.Drawing.Color.White
        Me.TxtPrecio1.Location = New System.Drawing.Point(157, 77)
        Me.TxtPrecio1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecio1.Name = "TxtPrecio1"
        Me.TxtPrecio1.Size = New System.Drawing.Size(189, 22)
        Me.TxtPrecio1.TabIndex = 1
        '
        'TxtPrecio3
        '
        Me.TxtPrecio3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtPrecio3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio3.ForeColor = System.Drawing.Color.White
        Me.TxtPrecio3.Location = New System.Drawing.Point(157, 147)
        Me.TxtPrecio3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecio3.Name = "TxtPrecio3"
        Me.TxtPrecio3.Size = New System.Drawing.Size(189, 22)
        Me.TxtPrecio3.TabIndex = 4
        '
        'LblPrecio3
        '
        Me.LblPrecio3.AutoSize = True
        Me.LblPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio3.ForeColor = System.Drawing.Color.White
        Me.LblPrecio3.Location = New System.Drawing.Point(26, 148)
        Me.LblPrecio3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio3.Name = "LblPrecio3"
        Me.LblPrecio3.Size = New System.Drawing.Size(63, 18)
        Me.LblPrecio3.TabIndex = 9
        Me.LblPrecio3.Text = "x Noche"
        '
        'TxtPrecio2
        '
        Me.TxtPrecio2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtPrecio2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio2.ForeColor = System.Drawing.Color.White
        Me.TxtPrecio2.Location = New System.Drawing.Point(157, 112)
        Me.TxtPrecio2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecio2.Name = "TxtPrecio2"
        Me.TxtPrecio2.Size = New System.Drawing.Size(189, 22)
        Me.TxtPrecio2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio3)
        Me.GroupBox1.Controls.Add(Me.LblPrecio3)
        Me.GroupBox1.Controls.Add(Me.txtNroHab)
        Me.GroupBox1.Controls.Add(Me.LblPrecio2)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio1)
        Me.GroupBox1.Controls.Add(Me.LblPrecio1)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(17, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 191)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar Precios"
        '
        'LblPrecio2
        '
        Me.LblPrecio2.AutoSize = True
        Me.LblPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio2.ForeColor = System.Drawing.Color.White
        Me.LblPrecio2.Location = New System.Drawing.Point(26, 113)
        Me.LblPrecio2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio2.Name = "LblPrecio2"
        Me.LblPrecio2.Size = New System.Drawing.Size(127, 18)
        Me.LblPrecio2.TabIndex = 8
        Me.LblPrecio2.Text = "Adicional c/ 30min"
        '
        'LblPrecio1
        '
        Me.LblPrecio1.AutoSize = True
        Me.LblPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio1.ForeColor = System.Drawing.Color.White
        Me.LblPrecio1.Location = New System.Drawing.Point(26, 78)
        Me.LblPrecio1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio1.Name = "LblPrecio1"
        Me.LblPrecio1.Size = New System.Drawing.Size(61, 18)
        Me.LblPrecio1.TabIndex = 6
        Me.LblPrecio1.Text = "x 1 hora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nro. Habitación"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(399, 35)
        Me.pnlTopBar.TabIndex = 85
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(128, 16)
        Me.lblTitulo.TabIndex = 116
        Me.lblTitulo.Text = "Editar Habitación"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(364, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'FEditarHabitacion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(399, 287)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FEditarHabitacion2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Habitación"
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents txtNroHab As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio3 As System.Windows.Forms.TextBox
    Friend WithEvents LblPrecio3 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblPrecio2 As System.Windows.Forms.Label
    Friend WithEvents LblPrecio1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
End Class
