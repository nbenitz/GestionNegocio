﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEmpleado))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSocio = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComision = New System.Windows.Forms.TextBox()
        Me.Comision = New System.Windows.Forms.Label()
        Me.btnSocioSgte = New System.Windows.Forms.Button()
        Me.pnlAcceso = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxRemoveFP = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbxAddCard = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbxAddFP = New System.Windows.Forms.PictureBox()
        Me.btnAccesoAtras = New System.Windows.Forms.Button()
        Me.btnAsignarAcceso = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSocio = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAcceso = New System.Windows.Forms.Button()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pnlSocio.SuspendLayout()
        Me.pnlAcceso.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRemoveFP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.pbxAddCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.pbxAddFP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.White
        Me.txtCI.Location = New System.Drawing.Point(220, 103)
        Me.txtCI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCI.MaxLength = 15
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(389, 26)
        Me.txtCI.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(220, 136)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(389, 26)
        Me.txtNombre.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(220, 238)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(389, 26)
        Me.txtDireccion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(121, 240)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dirección"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(220, 204)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(389, 26)
        Me.txtTelefono.TabIndex = 3
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.White
        Me.txtApellido.Location = New System.Drawing.Point(220, 171)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(389, 26)
        Me.txtApellido.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(121, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(121, 206)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(121, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CI *"
        '
        'pnlSocio
        '
        Me.pnlSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSocio.Controls.Add(Me.Label6)
        Me.pnlSocio.Controls.Add(Me.txtComision)
        Me.pnlSocio.Controls.Add(Me.Comision)
        Me.pnlSocio.Controls.Add(Me.btnSocioSgte)
        Me.pnlSocio.Controls.Add(Me.txtApellido)
        Me.pnlSocio.Controls.Add(Me.txtCI)
        Me.pnlSocio.Controls.Add(Me.Label3)
        Me.pnlSocio.Controls.Add(Me.Label1)
        Me.pnlSocio.Controls.Add(Me.txtDireccion)
        Me.pnlSocio.Controls.Add(Me.txtTelefono)
        Me.pnlSocio.Controls.Add(Me.Label5)
        Me.pnlSocio.Controls.Add(Me.Label2)
        Me.pnlSocio.Controls.Add(Me.txtNombre)
        Me.pnlSocio.Controls.Add(Me.Label4)
        Me.pnlSocio.Location = New System.Drawing.Point(0, 65)
        Me.pnlSocio.Name = "pnlSocio"
        Me.pnlSocio.Size = New System.Drawing.Size(800, 600)
        Me.pnlSocio.TabIndex = 104
        Me.pnlSocio.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(612, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "%"
        '
        'txtComision
        '
        Me.txtComision.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComision.ForeColor = System.Drawing.Color.White
        Me.txtComision.Location = New System.Drawing.Point(220, 273)
        Me.txtComision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComision.MaxLength = 100
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(389, 26)
        Me.txtComision.TabIndex = 5
        '
        'Comision
        '
        Me.Comision.AutoSize = True
        Me.Comision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comision.ForeColor = System.Drawing.Color.White
        Me.Comision.Location = New System.Drawing.Point(121, 275)
        Me.Comision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Comision.Name = "Comision"
        Me.Comision.Size = New System.Drawing.Size(74, 20)
        Me.Comision.TabIndex = 17
        Me.Comision.Text = "Comisión"
        '
        'btnSocioSgte
        '
        Me.btnSocioSgte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSocioSgte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSocioSgte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSocioSgte.Location = New System.Drawing.Point(626, 397)
        Me.btnSocioSgte.Name = "btnSocioSgte"
        Me.btnSocioSgte.Size = New System.Drawing.Size(108, 33)
        Me.btnSocioSgte.TabIndex = 6
        Me.btnSocioSgte.Text = "Siguiente"
        Me.btnSocioSgte.UseVisualStyleBackColor = False
        '
        'pnlAcceso
        '
        Me.pnlAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlAcceso.Controls.Add(Me.PictureBox1)
        Me.pnlAcceso.Controls.Add(Me.pbxRemoveFP)
        Me.pnlAcceso.Controls.Add(Me.Label19)
        Me.pnlAcceso.Controls.Add(Me.FlowLayoutPanel2)
        Me.pnlAcceso.Controls.Add(Me.Label10)
        Me.pnlAcceso.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlAcceso.Controls.Add(Me.btnAccesoAtras)
        Me.pnlAcceso.Controls.Add(Me.btnAsignarAcceso)
        Me.pnlAcceso.Controls.Add(Me.Label7)
        Me.pnlAcceso.Location = New System.Drawing.Point(0, 65)
        Me.pnlAcceso.Name = "pnlAcceso"
        Me.pnlAcceso.Size = New System.Drawing.Size(800, 600)
        Me.pnlAcceso.TabIndex = 105
        Me.pnlAcceso.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ControlStock.My.Resources.Resources.remove
        Me.PictureBox1.Location = New System.Drawing.Point(244, 308)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'pbxRemoveFP
        '
        Me.pbxRemoveFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxRemoveFP.Image = Global.ControlStock.My.Resources.Resources.remove
        Me.pbxRemoveFP.Location = New System.Drawing.Point(244, 145)
        Me.pbxRemoveFP.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxRemoveFP.Name = "pbxRemoveFP"
        Me.pbxRemoveFP.Size = New System.Drawing.Size(20, 20)
        Me.pbxRemoveFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxRemoveFP.TabIndex = 115
        Me.pbxRemoveFP.TabStop = False
        Me.pbxRemoveFP.Visible = False
        Me.pbxRemoveFP.WaitOnLoad = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(344, 231)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 21)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Tarjeta"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.AutoScrollMargin = New System.Drawing.Size(10, 0)
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlowLayoutPanel2.Controls.Add(Me.pbxAddCard)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(267, 266)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(214, 110)
        Me.FlowLayoutPanel2.TabIndex = 109
        Me.FlowLayoutPanel2.WrapContents = False
        '
        'pbxAddCard
        '
        Me.pbxAddCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxAddCard.Image = Global.ControlStock.My.Resources.Resources.add_target
        Me.pbxAddCard.Location = New System.Drawing.Point(3, 3)
        Me.pbxAddCard.Name = "pbxAddCard"
        Me.pbxAddCard.Size = New System.Drawing.Size(100, 100)
        Me.pbxAddCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxAddCard.TabIndex = 110
        Me.pbxAddCard.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(321, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 21)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Huella Dactilar"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoScrollMargin = New System.Drawing.Size(10, 0)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.pbxAddFP)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(267, 102)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(214, 110)
        Me.FlowLayoutPanel1.TabIndex = 107
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'pbxAddFP
        '
        Me.pbxAddFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxAddFP.Image = Global.ControlStock.My.Resources.Resources.add_target
        Me.pbxAddFP.Location = New System.Drawing.Point(3, 3)
        Me.pbxAddFP.Name = "pbxAddFP"
        Me.pbxAddFP.Size = New System.Drawing.Size(100, 100)
        Me.pbxAddFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxAddFP.TabIndex = 109
        Me.pbxAddFP.TabStop = False
        '
        'btnAccesoAtras
        '
        Me.btnAccesoAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAccesoAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccesoAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccesoAtras.Location = New System.Drawing.Point(529, 410)
        Me.btnAccesoAtras.Name = "btnAccesoAtras"
        Me.btnAccesoAtras.Size = New System.Drawing.Size(108, 33)
        Me.btnAccesoAtras.TabIndex = 103
        Me.btnAccesoAtras.Text = "Antrás"
        Me.btnAccesoAtras.UseVisualStyleBackColor = False
        '
        'btnAsignarAcceso
        '
        Me.btnAsignarAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAsignarAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsignarAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarAcceso.Location = New System.Drawing.Point(643, 410)
        Me.btnAsignarAcceso.Name = "btnAsignarAcceso"
        Me.btnAsignarAcceso.Size = New System.Drawing.Size(108, 33)
        Me.btnAsignarAcceso.TabIndex = 102
        Me.btnAsignarAcceso.Text = "Registrar"
        Me.btnAsignarAcceso.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(283, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Credenciales de Acceso"
        '
        'btnSocio
        '
        Me.btnSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSocio.Location = New System.Drawing.Point(0, 34)
        Me.btnSocio.Name = "btnSocio"
        Me.btnSocio.Size = New System.Drawing.Size(142, 30)
        Me.btnSocio.TabIndex = 107
        Me.btnSocio.Text = "Información Básica"
        Me.btnSocio.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(8, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(128, 16)
        Me.lblTitulo.TabIndex = 108
        Me.lblTitulo.Text = "Nuevo Empleado"
        '
        'btnAcceso
        '
        Me.btnAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceso.Location = New System.Drawing.Point(141, 34)
        Me.btnAcceso.Name = "btnAcceso"
        Me.btnAcceso.Size = New System.Drawing.Size(142, 30)
        Me.btnAcceso.TabIndex = 112
        Me.btnAcceso.Text = "Acceso"
        Me.btnAcceso.UseVisualStyleBackColor = False
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(750, -1)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 114
        Me.BtnCerrarForm.TabStop = False
        '
        'FEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 533)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.btnAcceso)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnSocio)
        Me.Controls.Add(Me.pnlSocio)
        Me.Controls.Add(Me.pnlAcceso)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socio"
        Me.pnlSocio.ResumeLayout(False)
        Me.pnlSocio.PerformLayout()
        Me.pnlAcceso.ResumeLayout(False)
        Me.pnlAcceso.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRemoveFP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.pbxAddCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.pbxAddFP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlSocio As Panel
    Friend WithEvents pnlAcceso As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSocio As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnSocioSgte As Button
    Friend WithEvents btnAsignarAcceso As Button
    Friend WithEvents btnAcceso As Button
    Friend WithEvents btnAccesoAtras As Button
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents pbxAddFP As PictureBox
    Friend WithEvents pbxAddCard As PictureBox
    Friend WithEvents pbxRemoveFP As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtComision As TextBox
    Friend WithEvents Comision As Label
    Friend WithEvents Label6 As Label
End Class
