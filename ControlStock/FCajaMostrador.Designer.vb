
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCajaMostrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCajaMostrador))
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.TxtMontoInicial = New System.Windows.Forms.TextBox()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAbrirAceptar = New System.Windows.Forms.Button()
        Me.btnAbrirCancelar = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblFechaApertura = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.pnlAbrir = New System.Windows.Forms.Panel()
        Me.lblMontoDiferencia = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTitDiferencia = New System.Windows.Forms.Label()
        Me.lblMontoCaja = New System.Windows.Forms.Label()
        Me.lblCajaActual = New System.Windows.Forms.Label()
        Me.lblGs = New System.Windows.Forms.Label()
        Me.btnGasto = New System.Windows.Forms.Button()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMontoReal = New System.Windows.Forms.TextBox()
        Me.txtMontoRetiro = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.pbxInfo2 = New System.Windows.Forms.PictureBox()
        Me.btnCerrarCancelar = New System.Windows.Forms.Button()
        Me.btnCerrarAceptar = New System.Windows.Forms.Button()
        Me.lblMontoSgteCaja = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlFaltante = New System.Windows.Forms.Panel()
        Me.lblFaltante = New System.Windows.Forms.Label()
        Me.lblTitFaltante = New System.Windows.Forms.Label()
        Me.pnlInfo2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.pnlInfo1 = New System.Windows.Forms.Panel()
        Me.pbxCerrarPnlInfo1 = New System.Windows.Forms.PictureBox()
        Me.LblInfo1 = New System.Windows.Forms.Label()
        Me.pbxInfo1 = New System.Windows.Forms.PictureBox()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbrir.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        CType(Me.pbxInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFaltante.SuspendLayout()
        Me.pnlInfo2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo1.SuspendLayout()
        CType(Me.pbxCerrarPnlInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.ForeColor = System.Drawing.Color.White
        Me.LblMonto.Location = New System.Drawing.Point(18, 24)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(96, 20)
        Me.LblMonto.TabIndex = 84
        Me.LblMonto.Text = "Monto Inicial"
        '
        'TxtMontoInicial
        '
        Me.TxtMontoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtMontoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMontoInicial.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoInicial.ForeColor = System.Drawing.Color.White
        Me.TxtMontoInicial.Location = New System.Drawing.Point(20, 47)
        Me.TxtMontoInicial.Name = "TxtMontoInicial"
        Me.TxtMontoInicial.Size = New System.Drawing.Size(184, 27)
        Me.TxtMontoInicial.TabIndex = 0
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TxtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmpleado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpleado.ForeColor = System.Drawing.Color.White
        Me.TxtEmpleado.Location = New System.Drawing.Point(293, 76)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.ReadOnly = True
        Me.TxtEmpleado.Size = New System.Drawing.Size(220, 27)
        Me.TxtEmpleado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(210, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Empleado"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 10
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 2
        '
        'btnAbrirAceptar
        '
        Me.btnAbrirAceptar.BackColor = System.Drawing.Color.Red
        Me.btnAbrirAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbrirAceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAbrirAceptar.Location = New System.Drawing.Point(20, 131)
        Me.btnAbrirAceptar.Name = "btnAbrirAceptar"
        Me.btnAbrirAceptar.Size = New System.Drawing.Size(89, 29)
        Me.btnAbrirAceptar.TabIndex = 89
        Me.btnAbrirAceptar.Text = "Abrir Caja"
        Me.btnAbrirAceptar.UseVisualStyleBackColor = False
        '
        'btnAbrirCancelar
        '
        Me.btnAbrirCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAbrirCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAbrirCancelar.Location = New System.Drawing.Point(115, 131)
        Me.btnAbrirCancelar.Name = "btnAbrirCancelar"
        Me.btnAbrirCancelar.Size = New System.Drawing.Size(89, 29)
        Me.btnAbrirCancelar.TabIndex = 90
        Me.btnAbrirCancelar.Text = "Cancelar"
        Me.btnAbrirCancelar.UseVisualStyleBackColor = False
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        '
        'LblFechaApertura
        '
        Me.LblFechaApertura.AutoSize = True
        Me.LblFechaApertura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaApertura.ForeColor = System.Drawing.Color.White
        Me.LblFechaApertura.Location = New System.Drawing.Point(211, 47)
        Me.LblFechaApertura.Name = "LblFechaApertura"
        Me.LblFechaApertura.Size = New System.Drawing.Size(79, 20)
        Me.LblFechaApertura.TabIndex = 91
        Me.LblFechaApertura.Text = "Abierto el "
        Me.LblFechaApertura.Visible = False
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(283, 47)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(81, 20)
        Me.LblFecha.TabIndex = 92
        Me.LblFecha.Text = "dd/mm/hh"
        Me.LblFecha.Visible = False
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.BtnCerrarForm)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(776, 35)
        Me.pnlTopBar.TabIndex = 93
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(111, 17)
        Me.lblTitulo.TabIndex = 116
        Me.lblTitulo.Text = "Apertura de Caja"
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrarForm.Image = CType(resources.GetObject("BtnCerrarForm.Image"), System.Drawing.Image)
        Me.BtnCerrarForm.Location = New System.Drawing.Point(741, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'pnlAbrir
        '
        Me.pnlAbrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlAbrir.Controls.Add(Me.lblMontoDiferencia)
        Me.pnlAbrir.Controls.Add(Me.Label6)
        Me.pnlAbrir.Controls.Add(Me.lblTitDiferencia)
        Me.pnlAbrir.Controls.Add(Me.btnAbrirCancelar)
        Me.pnlAbrir.Controls.Add(Me.btnAbrirAceptar)
        Me.pnlAbrir.Controls.Add(Me.TxtMontoInicial)
        Me.pnlAbrir.Controls.Add(Me.LblMonto)
        Me.pnlAbrir.Location = New System.Drawing.Point(255, 231)
        Me.pnlAbrir.Name = "pnlAbrir"
        Me.pnlAbrir.Size = New System.Drawing.Size(229, 180)
        Me.pnlAbrir.TabIndex = 94
        '
        'lblMontoDiferencia
        '
        Me.lblMontoDiferencia.AutoSize = True
        Me.lblMontoDiferencia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoDiferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMontoDiferencia.Location = New System.Drawing.Point(51, 103)
        Me.lblMontoDiferencia.Name = "lblMontoDiferencia"
        Me.lblMontoDiferencia.Size = New System.Drawing.Size(15, 17)
        Me.lblMontoDiferencia.TabIndex = 123
        Me.lblMontoDiferencia.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(19, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 17)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Gs."
        '
        'lblTitDiferencia
        '
        Me.lblTitDiferencia.AutoSize = True
        Me.lblTitDiferencia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitDiferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitDiferencia.Location = New System.Drawing.Point(19, 82)
        Me.lblTitDiferencia.Name = "lblTitDiferencia"
        Me.lblTitDiferencia.Size = New System.Drawing.Size(188, 17)
        Me.lblTitDiferencia.TabIndex = 119
        Me.lblTitDiferencia.Text = "Diferencia con la Caja Anterior:"
        '
        'lblMontoCaja
        '
        Me.lblMontoCaja.AutoSize = True
        Me.lblMontoCaja.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMontoCaja.Location = New System.Drawing.Point(290, 122)
        Me.lblMontoCaja.Name = "lblMontoCaja"
        Me.lblMontoCaja.Size = New System.Drawing.Size(194, 65)
        Me.lblMontoCaja.TabIndex = 107
        Me.lblMontoCaja.Text = "100.000"
        '
        'lblCajaActual
        '
        Me.lblCajaActual.AutoSize = True
        Me.lblCajaActual.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajaActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCajaActual.Location = New System.Drawing.Point(332, 183)
        Me.lblCajaActual.Name = "lblCajaActual"
        Me.lblCajaActual.Size = New System.Drawing.Size(84, 20)
        Me.lblCajaActual.TabIndex = 108
        Me.lblCajaActual.Text = "Caja Actual"
        '
        'lblGs
        '
        Me.lblGs.AutoSize = True
        Me.lblGs.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGs.Location = New System.Drawing.Point(267, 158)
        Me.lblGs.Name = "lblGs"
        Me.lblGs.Size = New System.Drawing.Size(28, 20)
        Me.lblGs.TabIndex = 109
        Me.lblGs.Text = "Gs."
        '
        'btnGasto
        '
        Me.btnGasto.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGasto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGasto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGasto.Location = New System.Drawing.Point(312, 222)
        Me.btnGasto.Name = "btnGasto"
        Me.btnGasto.Size = New System.Drawing.Size(136, 29)
        Me.btnGasto.TabIndex = 110
        Me.btnGasto.Text = "Registrar Gasto"
        Me.btnGasto.UseVisualStyleBackColor = False
        '
        'btnCompra
        '
        Me.btnCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCompra.Location = New System.Drawing.Point(25, 267)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(136, 29)
        Me.btnCompra.TabIndex = 111
        Me.btnCompra.Text = "Registrar Compra"
        Me.btnCompra.UseVisualStyleBackColor = False
        Me.btnCompra.Visible = False
        '
        'btnIngreso
        '
        Me.btnIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngreso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIngreso.Location = New System.Drawing.Point(25, 302)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(136, 29)
        Me.btnIngreso.TabIndex = 112
        Me.btnIngreso.Text = "Ingresar Efectivo"
        Me.btnIngreso.UseVisualStyleBackColor = False
        Me.btnIngreso.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 20)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "¿Cúanto dinero hay en la Caja?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 20)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "¿Cúanto dinero vas a sacar de la Caja?"
        '
        'txtMontoReal
        '
        Me.txtMontoReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMontoReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoReal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoReal.ForeColor = System.Drawing.Color.White
        Me.txtMontoReal.Location = New System.Drawing.Point(52, 53)
        Me.txtMontoReal.Name = "txtMontoReal"
        Me.txtMontoReal.Size = New System.Drawing.Size(184, 29)
        Me.txtMontoReal.TabIndex = 115
        '
        'txtMontoRetiro
        '
        Me.txtMontoRetiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMontoRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoRetiro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoRetiro.ForeColor = System.Drawing.Color.White
        Me.txtMontoRetiro.Location = New System.Drawing.Point(52, 138)
        Me.txtMontoRetiro.Name = "txtMontoRetiro"
        Me.txtMontoRetiro.Size = New System.Drawing.Size(184, 29)
        Me.txtMontoRetiro.TabIndex = 116
        Me.txtMontoRetiro.Text = "0"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCerrar.Location = New System.Drawing.Point(25, 198)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(136, 29)
        Me.btnCerrar.TabIndex = 117
        Me.btnCerrar.Text = "CerrarCaja"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.pbxInfo2)
        Me.pnlCerrar.Controls.Add(Me.btnCerrarCancelar)
        Me.pnlCerrar.Controls.Add(Me.btnCerrarAceptar)
        Me.pnlCerrar.Controls.Add(Me.lblMontoSgteCaja)
        Me.pnlCerrar.Controls.Add(Me.Label7)
        Me.pnlCerrar.Controls.Add(Me.Label5)
        Me.pnlCerrar.Controls.Add(Me.txtMontoRetiro)
        Me.pnlCerrar.Controls.Add(Me.txtMontoReal)
        Me.pnlCerrar.Controls.Add(Me.Label2)
        Me.pnlCerrar.Controls.Add(Me.Label1)
        Me.pnlCerrar.Controls.Add(Me.pnlFaltante)
        Me.pnlCerrar.Location = New System.Drawing.Point(196, 233)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(356, 283)
        Me.pnlCerrar.TabIndex = 118
        '
        'pbxInfo2
        '
        Me.pbxInfo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxInfo2.Image = Global.ControlStock.My.Resources.Resources.boton_de_informacion
        Me.pbxInfo2.Location = New System.Drawing.Point(240, 56)
        Me.pbxInfo2.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxInfo2.Name = "pbxInfo2"
        Me.pbxInfo2.Size = New System.Drawing.Size(24, 24)
        Me.pbxInfo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxInfo2.TabIndex = 126
        Me.pbxInfo2.TabStop = False
        '
        'btnCerrarCancelar
        '
        Me.btnCerrarCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCerrarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCerrarCancelar.Location = New System.Drawing.Point(148, 221)
        Me.btnCerrarCancelar.Name = "btnCerrarCancelar"
        Me.btnCerrarCancelar.Size = New System.Drawing.Size(89, 29)
        Me.btnCerrarCancelar.TabIndex = 123
        Me.btnCerrarCancelar.Text = "Cancelar"
        Me.btnCerrarCancelar.UseVisualStyleBackColor = False
        '
        'btnCerrarAceptar
        '
        Me.btnCerrarAceptar.BackColor = System.Drawing.Color.Red
        Me.btnCerrarAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarAceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCerrarAceptar.Location = New System.Drawing.Point(53, 221)
        Me.btnCerrarAceptar.Name = "btnCerrarAceptar"
        Me.btnCerrarAceptar.Size = New System.Drawing.Size(89, 29)
        Me.btnCerrarAceptar.TabIndex = 122
        Me.btnCerrarAceptar.Text = "Cerrar Caja"
        Me.btnCerrarAceptar.UseVisualStyleBackColor = False
        '
        'lblMontoSgteCaja
        '
        Me.lblMontoSgteCaja.AutoSize = True
        Me.lblMontoSgteCaja.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoSgteCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMontoSgteCaja.Location = New System.Drawing.Point(82, 191)
        Me.lblMontoSgteCaja.Name = "lblMontoSgteCaja"
        Me.lblMontoSgteCaja.Size = New System.Drawing.Size(15, 17)
        Me.lblMontoSgteCaja.TabIndex = 121
        Me.lblMontoSgteCaja.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(50, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 17)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Gs."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 17)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Efectivo que queda para la sgte. Caja:"
        '
        'pnlFaltante
        '
        Me.pnlFaltante.Controls.Add(Me.lblFaltante)
        Me.pnlFaltante.Controls.Add(Me.lblTitFaltante)
        Me.pnlFaltante.Location = New System.Drawing.Point(52, 85)
        Me.pnlFaltante.Name = "pnlFaltante"
        Me.pnlFaltante.Size = New System.Drawing.Size(183, 22)
        Me.pnlFaltante.TabIndex = 124
        Me.pnlFaltante.Visible = False
        '
        'lblFaltante
        '
        Me.lblFaltante.AutoSize = True
        Me.lblFaltante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaltante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFaltante.Location = New System.Drawing.Point(81, 1)
        Me.lblFaltante.Name = "lblFaltante"
        Me.lblFaltante.Size = New System.Drawing.Size(15, 17)
        Me.lblFaltante.TabIndex = 119
        Me.lblFaltante.Text = "0"
        '
        'lblTitFaltante
        '
        Me.lblTitFaltante.AutoSize = True
        Me.lblTitFaltante.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitFaltante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitFaltante.Location = New System.Drawing.Point(-2, 1)
        Me.lblTitFaltante.Name = "lblTitFaltante"
        Me.lblTitFaltante.Size = New System.Drawing.Size(82, 17)
        Me.lblTitFaltante.TabIndex = 117
        Me.lblTitFaltante.Text = "Faltante:  Gs."
        '
        'pnlInfo2
        '
        Me.pnlInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlInfo2.Controls.Add(Me.PictureBox1)
        Me.pnlInfo2.Controls.Add(Me.LblInfo2)
        Me.pnlInfo2.Location = New System.Drawing.Point(465, 281)
        Me.pnlInfo2.Name = "pnlInfo2"
        Me.pnlInfo2.Size = New System.Drawing.Size(254, 189)
        Me.pnlInfo2.TabIndex = 125
        Me.pnlInfo2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(230, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 127
        Me.PictureBox1.TabStop = False
        '
        'LblInfo2
        '
        Me.LblInfo2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo2.ForeColor = System.Drawing.Color.White
        Me.LblInfo2.Location = New System.Drawing.Point(14, 14)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(213, 167)
        Me.LblInfo2.TabIndex = 114
        Me.LblInfo2.Text = "Es el monto real de dinero existente en la caja." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si este monto es menor que lo" &
    "s registros del sistema, entonces se registra un faltante; si el monto es mayor," &
    " se registra un sobrante."
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReporte.Location = New System.Drawing.Point(25, 233)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(136, 29)
        Me.btnReporte.TabIndex = 126
        Me.btnReporte.Text = "Reporte de Caja"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'pnlInfo1
        '
        Me.pnlInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlInfo1.Controls.Add(Me.pbxCerrarPnlInfo1)
        Me.pnlInfo1.Controls.Add(Me.LblInfo1)
        Me.pnlInfo1.Location = New System.Drawing.Point(485, 130)
        Me.pnlInfo1.Name = "pnlInfo1"
        Me.pnlInfo1.Size = New System.Drawing.Size(254, 102)
        Me.pnlInfo1.TabIndex = 127
        Me.pnlInfo1.Visible = False
        '
        'pbxCerrarPnlInfo1
        '
        Me.pbxCerrarPnlInfo1.Image = CType(resources.GetObject("pbxCerrarPnlInfo1.Image"), System.Drawing.Image)
        Me.pbxCerrarPnlInfo1.Location = New System.Drawing.Point(230, 0)
        Me.pbxCerrarPnlInfo1.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxCerrarPnlInfo1.Name = "pbxCerrarPnlInfo1"
        Me.pbxCerrarPnlInfo1.Size = New System.Drawing.Size(24, 24)
        Me.pbxCerrarPnlInfo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxCerrarPnlInfo1.TabIndex = 127
        Me.pbxCerrarPnlInfo1.TabStop = False
        '
        'LblInfo1
        '
        Me.LblInfo1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo1.ForeColor = System.Drawing.Color.White
        Me.LblInfo1.Location = New System.Drawing.Point(14, 14)
        Me.LblInfo1.Name = "LblInfo1"
        Me.LblInfo1.Size = New System.Drawing.Size(213, 86)
        Me.LblInfo1.TabIndex = 114
        Me.LblInfo1.Text = "Es el monto de dinero que debería existir en Caja de acuerdo a los registros del " &
    "Sistema"
        '
        'pbxInfo1
        '
        Me.pbxInfo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxInfo1.Image = Global.ControlStock.My.Resources.Resources.boton_de_informacion
        Me.pbxInfo1.Location = New System.Drawing.Point(438, 179)
        Me.pbxInfo1.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxInfo1.Name = "pbxInfo1"
        Me.pbxInfo1.Size = New System.Drawing.Size(24, 24)
        Me.pbxInfo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxInfo1.TabIndex = 128
        Me.pbxInfo1.TabStop = False
        '
        'FCajaMostrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 595)
        Me.Controls.Add(Me.pbxInfo1)
        Me.Controls.Add(Me.pnlInfo1)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.pnlInfo2)
        Me.Controls.Add(Me.pnlCerrar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblFechaApertura)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnCompra)
        Me.Controls.Add(Me.btnGasto)
        Me.Controls.Add(Me.lblGs)
        Me.Controls.Add(Me.lblCajaActual)
        Me.Controls.Add(Me.lblMontoCaja)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.TxtEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlAbrir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FCajaMostrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Caja"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbrir.ResumeLayout(False)
        Me.pnlAbrir.PerformLayout()
        Me.pnlCerrar.ResumeLayout(False)
        Me.pnlCerrar.PerformLayout()
        CType(Me.pbxInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFaltante.ResumeLayout(False)
        Me.pnlFaltante.PerformLayout()
        Me.pnlInfo2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo1.ResumeLayout(False)
        CType(Me.pbxCerrarPnlInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMonto As System.Windows.Forms.Label
    Friend WithEvents TxtMontoInicial As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAbrirAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAbrirCancelar As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents LblFechaApertura As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents pnlAbrir As Panel
    Friend WithEvents lblMontoCaja As Label
    Friend WithEvents lblCajaActual As Label
    Friend WithEvents lblGs As Label
    Friend WithEvents btnGasto As Button
    Friend WithEvents btnCompra As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMontoReal As TextBox
    Friend WithEvents txtMontoRetiro As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents pnlCerrar As Panel
    Friend WithEvents lblMontoSgteCaja As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFaltante As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTitFaltante As Label
    Friend WithEvents btnCerrarCancelar As Button
    Friend WithEvents btnCerrarAceptar As Button
    Friend WithEvents pnlFaltante As Panel
    Friend WithEvents pbxInfo2 As PictureBox
    Friend WithEvents pnlInfo2 As Panel
    Friend WithEvents LblInfo2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMontoDiferencia As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTitDiferencia As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents pnlInfo1 As Panel
    Friend WithEvents pbxCerrarPnlInfo1 As PictureBox
    Friend WithEvents LblInfo1 As Label
    Friend WithEvents pbxInfo1 As PictureBox
End Class
