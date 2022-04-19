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
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pnlSocioInfo = New System.Windows.Forms.Panel()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.BtnCuentas = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.btnSeguimiento = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.lblAtraso = New System.Windows.Forms.Label()
        Me.lblTituloPendiente = New System.Windows.Forms.Label()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.lblMembresia = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTituloAtraso = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSocioInfo.SuspendLayout()
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
        Me.pnlTopBar.Size = New System.Drawing.Size(700, 35)
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
        Me.BtnCerrarForm.Location = New System.Drawing.Point(665, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'pnlSocioInfo
        '
        Me.pnlSocioInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSocioInfo.Controls.Add(Me.lblAcceso)
        Me.pnlSocioInfo.Controls.Add(Me.Label8)
        Me.pnlSocioInfo.Controls.Add(Me.btnBaja)
        Me.pnlSocioInfo.Controls.Add(Me.BtnCuentas)
        Me.pnlSocioInfo.Controls.Add(Me.btnAsistencia)
        Me.pnlSocioInfo.Controls.Add(Me.btnSeguimiento)
        Me.pnlSocioInfo.Controls.Add(Me.btnCobrar)
        Me.pnlSocioInfo.Controls.Add(Me.btnEditar)
        Me.pnlSocioInfo.Controls.Add(Me.lblEstado)
        Me.pnlSocioInfo.Controls.Add(Me.Label14)
        Me.pnlSocioInfo.Controls.Add(Me.Label11)
        Me.pnlSocioInfo.Controls.Add(Me.lblCI)
        Me.pnlSocioInfo.Controls.Add(Me.lblAlias)
        Me.pnlSocioInfo.Controls.Add(Me.lblTelefono)
        Me.pnlSocioInfo.Controls.Add(Me.lblDireccion)
        Me.pnlSocioInfo.Controls.Add(Me.Label12)
        Me.pnlSocioInfo.Controls.Add(Me.lblFechaNac)
        Me.pnlSocioInfo.Controls.Add(Me.Label9)
        Me.pnlSocioInfo.Controls.Add(Me.Label10)
        Me.pnlSocioInfo.Controls.Add(Me.Label5)
        Me.pnlSocioInfo.Controls.Add(Me.lblSaldo)
        Me.pnlSocioInfo.Controls.Add(Me.pbxFoto)
        Me.pnlSocioInfo.Controls.Add(Me.lblAtraso)
        Me.pnlSocioInfo.Controls.Add(Me.lblTituloPendiente)
        Me.pnlSocioInfo.Controls.Add(Me.lblVencimiento)
        Me.pnlSocioInfo.Controls.Add(Me.lblMembresia)
        Me.pnlSocioInfo.Controls.Add(Me.Label2)
        Me.pnlSocioInfo.Controls.Add(Me.Label1)
        Me.pnlSocioInfo.Controls.Add(Me.Label3)
        Me.pnlSocioInfo.Controls.Add(Me.lblTituloAtraso)
        Me.pnlSocioInfo.Controls.Add(Me.lblNombre)
        Me.pnlSocioInfo.Controls.Add(Me.Label4)
        Me.pnlSocioInfo.Controls.Add(Me.Label6)
        Me.pnlSocioInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSocioInfo.Location = New System.Drawing.Point(5, 35)
        Me.pnlSocioInfo.Name = "pnlSocioInfo"
        Me.pnlSocioInfo.Size = New System.Drawing.Size(690, 400)
        Me.pnlSocioInfo.TabIndex = 83
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcceso.ForeColor = System.Drawing.Color.White
        Me.lblAcceso.Location = New System.Drawing.Point(273, 171)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(13, 17)
        Me.lblAcceso.TabIndex = 45
        Me.lblAcceso.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(193, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Cod. Acceso"
        '
        'btnBaja
        '
        Me.btnBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.ForeColor = System.Drawing.Color.White
        Me.btnBaja.Location = New System.Drawing.Point(531, 347)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(134, 30)
        Me.btnBaja.TabIndex = 43
        Me.btnBaja.Text = "Dar de Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'BtnCuentas
        '
        Me.BtnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCuentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCuentas.Location = New System.Drawing.Point(24, 239)
        Me.BtnCuentas.Name = "BtnCuentas"
        Me.BtnCuentas.Size = New System.Drawing.Size(134, 30)
        Me.BtnCuentas.TabIndex = 42
        Me.BtnCuentas.Text = "Cuenta Corriente"
        Me.BtnCuentas.UseVisualStyleBackColor = True
        '
        'btnAsistencia
        '
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAsistencia.Location = New System.Drawing.Point(24, 275)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(134, 30)
        Me.btnAsistencia.TabIndex = 41
        Me.btnAsistencia.Text = "Asistencia"
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'btnSeguimiento
        '
        Me.btnSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeguimiento.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSeguimiento.Location = New System.Drawing.Point(24, 311)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(134, 30)
        Me.btnSeguimiento.TabIndex = 40
        Me.btnSeguimiento.Text = "Seguimiento"
        Me.btnSeguimiento.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCobrar.Location = New System.Drawing.Point(24, 347)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(134, 30)
        Me.btnCobrar.TabIndex = 39
        Me.btnCobrar.Text = "Cobrar Cuota"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.Location = New System.Drawing.Point(24, 203)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(134, 30)
        Me.btnEditar.TabIndex = 38
        Me.btnEditar.Text = "Editar Datos"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Lime
        Me.lblEstado.Location = New System.Drawing.Point(278, 275)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(44, 17)
        Me.lblEstado.TabIndex = 37
        Me.lblEstado.Text = "Al día"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(194, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(228, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Datos de Membresía"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.ForeColor = System.Drawing.Color.White
        Me.lblCI.Location = New System.Drawing.Point(273, 44)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(57, 17)
        Me.lblCI.TabIndex = 34
        Me.lblCI.Text = "4111222"
        '
        'lblAlias
        '
        Me.lblAlias.AutoSize = True
        Me.lblAlias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlias.ForeColor = System.Drawing.Color.White
        Me.lblAlias.Location = New System.Drawing.Point(273, 86)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(38, 17)
        Me.lblAlias.TabIndex = 33
        Me.lblAlias.Text = "Álias"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(273, 107)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(78, 17)
        Me.lblTelefono.TabIndex = 32
        Me.lblTelefono.Text = "0994123123"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.White
        Me.lblDireccion.Location = New System.Drawing.Point(273, 128)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(66, 17)
        Me.lblDireccion.TabIndex = 31
        Me.lblDireccion.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(229, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 17)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Datos Básicos"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.ForeColor = System.Drawing.Color.White
        Me.lblFechaNac.Location = New System.Drawing.Point(273, 150)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(13, 17)
        Me.lblFechaNac.TabIndex = 29
        Me.lblFechaNac.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(193, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Fecha Nac."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(193, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(193, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "CI"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Yellow
        Me.lblSaldo.Location = New System.Drawing.Point(278, 317)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(43, 17)
        Me.lblSaldo.TabIndex = 21
        Me.lblSaldo.Text = "30000"
        Me.lblSaldo.Visible = False
        '
        'pbxFoto
        '
        Me.pbxFoto.Image = Global.ControlStock.My.Resources.Resources.userblack
        Me.pbxFoto.Location = New System.Drawing.Point(12, 14)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(158, 174)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxFoto.TabIndex = 10
        Me.pbxFoto.TabStop = False
        '
        'lblAtraso
        '
        Me.lblAtraso.AutoSize = True
        Me.lblAtraso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtraso.ForeColor = System.Drawing.Color.Yellow
        Me.lblAtraso.Location = New System.Drawing.Point(278, 296)
        Me.lblAtraso.Name = "lblAtraso"
        Me.lblAtraso.Size = New System.Drawing.Size(15, 17)
        Me.lblAtraso.TabIndex = 19
        Me.lblAtraso.Text = "0"
        Me.lblAtraso.Visible = False
        '
        'lblTituloPendiente
        '
        Me.lblTituloPendiente.AutoSize = True
        Me.lblTituloPendiente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloPendiente.Location = New System.Drawing.Point(194, 317)
        Me.lblTituloPendiente.Name = "lblTituloPendiente"
        Me.lblTituloPendiente.Size = New System.Drawing.Size(77, 17)
        Me.lblTituloPendiente.TabIndex = 20
        Me.lblTituloPendiente.Text = "Saldo Pend."
        Me.lblTituloPendiente.Visible = False
        '
        'lblVencimiento
        '
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.ForeColor = System.Drawing.Color.White
        Me.lblVencimiento.Location = New System.Drawing.Point(278, 254)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(85, 17)
        Me.lblVencimiento.TabIndex = 16
        Me.lblVencimiento.Text = "Vencimiento"
        '
        'lblMembresia
        '
        Me.lblMembresia.AutoSize = True
        Me.lblMembresia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembresia.ForeColor = System.Drawing.Color.White
        Me.lblMembresia.Location = New System.Drawing.Point(278, 233)
        Me.lblMembresia.Name = "lblMembresia"
        Me.lblMembresia.Size = New System.Drawing.Size(130, 17)
        Me.lblMembresia.TabIndex = 14
        Me.lblMembresia.Text = "Nombre Membresia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(193, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(193, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(193, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Álias"
        '
        'lblTituloAtraso
        '
        Me.lblTituloAtraso.AutoSize = True
        Me.lblTituloAtraso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAtraso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTituloAtraso.Location = New System.Drawing.Point(194, 296)
        Me.lblTituloAtraso.Name = "lblTituloAtraso"
        Me.lblTituloAtraso.Size = New System.Drawing.Size(75, 17)
        Me.lblTituloAtraso.TabIndex = 18
        Me.lblTituloAtraso.Text = "Días Atraso"
        Me.lblTituloAtraso.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(273, 65)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(105, 17)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(194, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Membresia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(194, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Vencimiento"
        '
        'FSocioFicha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 440)
        Me.Controls.Add(Me.pnlSocioInfo)
        Me.Controls.Add(Me.pnlTopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FSocioFicha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FSocioFicha"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSocioInfo.ResumeLayout(False)
        Me.pnlSocioInfo.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents pnlSocioInfo As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbxFoto As PictureBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblTituloPendiente As Label
    Friend WithEvents lblAtraso As Label
    Friend WithEvents lblTituloAtraso As Label
    Friend WithEvents lblVencimiento As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMembresia As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents lblAlias As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBaja As Button
    Friend WithEvents BtnCuentas As Button
    Friend WithEvents btnAsistencia As Button
    Friend WithEvents btnSeguimiento As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblAcceso As Label
    Friend WithEvents Label8 As Label
End Class
