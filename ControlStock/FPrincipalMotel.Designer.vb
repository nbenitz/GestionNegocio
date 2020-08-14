<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPrincipalMotel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPrincipalMotel))
        Me.TmrFecha = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaBajaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaAltaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeHabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosDeHabitaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbrirCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCerrarCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHistorialDeCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResumenDeCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaCredito = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibosDeDinero = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibirStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedirStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialRecepcion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProveed = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaProv = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProv = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaEmple = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoEmple = New System.Windows.Forms.ToolStripMenuItem()
        Me.Comisiones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaPagar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCobrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinanzas = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlVenta = New System.Windows.Forms.Panel()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.pbxVenta = New System.Windows.Forms.PictureBox()
        Me.lblHabitaciones = New System.Windows.Forms.Label()
        Me.Habitacion10 = New ControlStock.Habitacion()
        Me.Habitacion9 = New ControlStock.Habitacion()
        Me.Habitacion8 = New ControlStock.Habitacion()
        Me.Habitacion7 = New ControlStock.Habitacion()
        Me.Habitacion6 = New ControlStock.Habitacion()
        Me.Habitacion5 = New ControlStock.Habitacion()
        Me.Habitacion4 = New ControlStock.Habitacion()
        Me.Habitacion3 = New ControlStock.Habitacion()
        Me.Habitacion2 = New ControlStock.Habitacion()
        Me.Habitacion1 = New ControlStock.Habitacion()
        Me.pnlSalir = New System.Windows.Forms.Panel()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pnlCompra = New System.Windows.Forms.Panel()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.pbxCompras = New System.Windows.Forms.PictureBox()
        Me.pnlProd = New System.Windows.Forms.Panel()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.pbxProd = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlVenta.SuspendLayout()
        CType(Me.pbxVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSalir.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCompra.SuspendLayout()
        CType(Me.pbxCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProd.SuspendLayout()
        CType(Me.pbxProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrFecha
        '
        Me.TmrFecha.Enabled = True
        Me.TmrFecha.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuProd, Me.HabitacionesToolStripMenuItem, Me.mnuCaja, Me.mnuVentas, Me.mnuCompras, Me.mnuProveed, Me.mnuEmpleados, Me.mnuCuentas, Me.mnuFinanzas, Me.mnuUsuarios, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(928, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.mnuArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.mnuArchivo.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'mnuProd
        '
        Me.mnuProd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaProd, Me.NuevoProd, Me.ListaBajaDeProductosToolStripMenuItem, Me.ListaAltaDeProductosToolStripMenuItem})
        Me.mnuProd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuProd.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.mnuProd.Name = "mnuProd"
        Me.mnuProd.Size = New System.Drawing.Size(73, 20)
        Me.mnuProd.Text = "Productos"
        '
        'ConsultaProd
        '
        Me.ConsultaProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ConsultaProd.ForeColor = System.Drawing.Color.White
        Me.ConsultaProd.Name = "ConsultaProd"
        Me.ConsultaProd.Size = New System.Drawing.Size(196, 22)
        Me.ConsultaProd.Text = "Consultar Productos"
        '
        'NuevoProd
        '
        Me.NuevoProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NuevoProd.ForeColor = System.Drawing.Color.White
        Me.NuevoProd.Name = "NuevoProd"
        Me.NuevoProd.Size = New System.Drawing.Size(196, 22)
        Me.NuevoProd.Text = "Nuevo Producto"
        '
        'ListaBajaDeProductosToolStripMenuItem
        '
        Me.ListaBajaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaBajaDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaBajaDeProductosToolStripMenuItem.Name = "ListaBajaDeProductosToolStripMenuItem"
        Me.ListaBajaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListaBajaDeProductosToolStripMenuItem.Text = "Lista Baja de Productos"
        '
        'ListaAltaDeProductosToolStripMenuItem
        '
        Me.ListaAltaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaAltaDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaAltaDeProductosToolStripMenuItem.Name = "ListaAltaDeProductosToolStripMenuItem"
        Me.ListaAltaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListaAltaDeProductosToolStripMenuItem.Text = "Lista Alta de Productos"
        '
        'HabitacionesToolStripMenuItem
        '
        Me.HabitacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.ListaDeHabitacionesToolStripMenuItem, Me.ServiciosDeHabitaciónToolStripMenuItem, Me.AjustesToolStripMenuItem})
        Me.HabitacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HabitacionesToolStripMenuItem.Name = "HabitacionesToolStripMenuItem"
        Me.HabitacionesToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.HabitacionesToolStripMenuItem.Text = "Habitaciones"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListaDeHabitacionesToolStripMenuItem
        '
        Me.ListaDeHabitacionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaDeHabitacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaDeHabitacionesToolStripMenuItem.Name = "ListaDeHabitacionesToolStripMenuItem"
        Me.ListaDeHabitacionesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ListaDeHabitacionesToolStripMenuItem.Text = "Consultar Habitaciones"
        '
        'ServiciosDeHabitaciónToolStripMenuItem
        '
        Me.ServiciosDeHabitaciónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ServiciosDeHabitaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ServiciosDeHabitaciónToolStripMenuItem.Name = "ServiciosDeHabitaciónToolStripMenuItem"
        Me.ServiciosDeHabitaciónToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ServiciosDeHabitaciónToolStripMenuItem.Text = "Ajustes de Tiempo"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.AjustesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AjustesToolStripMenuItem.Text = "Ajustes de Tolerancia"
        '
        'mnuCaja
        '
        Me.mnuCaja.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrirCaja, Me.mnuCerrarCaja, Me.mnuHistorialDeCaja, Me.mnuResumenDeCaja})
        Me.mnuCaja.ForeColor = System.Drawing.Color.White
        Me.mnuCaja.Name = "mnuCaja"
        Me.mnuCaja.Size = New System.Drawing.Size(42, 20)
        Me.mnuCaja.Text = "Caja"
        '
        'mnuAbrirCaja
        '
        Me.mnuAbrirCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.mnuAbrirCaja.ForeColor = System.Drawing.Color.White
        Me.mnuAbrirCaja.Name = "mnuAbrirCaja"
        Me.mnuAbrirCaja.Size = New System.Drawing.Size(165, 22)
        Me.mnuAbrirCaja.Text = "Abrir Caja"
        '
        'mnuCerrarCaja
        '
        Me.mnuCerrarCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.mnuCerrarCaja.ForeColor = System.Drawing.Color.White
        Me.mnuCerrarCaja.Name = "mnuCerrarCaja"
        Me.mnuCerrarCaja.Size = New System.Drawing.Size(165, 22)
        Me.mnuCerrarCaja.Text = "Cerrar Caja"
        '
        'mnuHistorialDeCaja
        '
        Me.mnuHistorialDeCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.mnuHistorialDeCaja.ForeColor = System.Drawing.Color.White
        Me.mnuHistorialDeCaja.Name = "mnuHistorialDeCaja"
        Me.mnuHistorialDeCaja.Size = New System.Drawing.Size(165, 22)
        Me.mnuHistorialDeCaja.Text = "Historial de Caja"
        '
        'mnuResumenDeCaja
        '
        Me.mnuResumenDeCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.mnuResumenDeCaja.ForeColor = System.Drawing.Color.White
        Me.mnuResumenDeCaja.Name = "mnuResumenDeCaja"
        Me.mnuResumenDeCaja.Size = New System.Drawing.Size(165, 22)
        Me.mnuResumenDeCaja.Text = "Resumen de Caja"
        '
        'mnuVentas
        '
        Me.mnuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVenta, Me.ConsultarVenta, Me.NotaCredito, Me.RecibosDeDinero})
        Me.mnuVentas.ForeColor = System.Drawing.Color.White
        Me.mnuVentas.Name = "mnuVentas"
        Me.mnuVentas.Size = New System.Drawing.Size(53, 20)
        Me.mnuVentas.Text = "Ventas"
        '
        'NuevaVenta
        '
        Me.NuevaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NuevaVenta.ForeColor = System.Drawing.Color.White
        Me.NuevaVenta.Name = "NuevaVenta"
        Me.NuevaVenta.Size = New System.Drawing.Size(303, 22)
        Me.NuevaVenta.Text = "Nueva Venta"
        Me.NuevaVenta.Visible = False
        '
        'ConsultarVenta
        '
        Me.ConsultarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ConsultarVenta.ForeColor = System.Drawing.Color.White
        Me.ConsultarVenta.Name = "ConsultarVenta"
        Me.ConsultarVenta.Size = New System.Drawing.Size(303, 22)
        Me.ConsultarVenta.Text = "Consultar Ventas"
        '
        'NotaCredito
        '
        Me.NotaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NotaCredito.ForeColor = System.Drawing.Color.White
        Me.NotaCredito.Name = "NotaCredito"
        Me.NotaCredito.Size = New System.Drawing.Size(303, 22)
        Me.NotaCredito.Text = "Devoluciones (Nota de Crédito)"
        '
        'RecibosDeDinero
        '
        Me.RecibosDeDinero.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.RecibosDeDinero.ForeColor = System.Drawing.Color.White
        Me.RecibosDeDinero.Name = "RecibosDeDinero"
        Me.RecibosDeDinero.Size = New System.Drawing.Size(303, 22)
        Me.RecibosDeDinero.Text = "Recibos de Dinero sobre Compras a Crédito"
        '
        'mnuCompras
        '
        Me.mnuCompras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecibirStock, Me.ListaCompras, Me.PedirStock, Me.ListaPedidos, Me.HistorialRecepcion, Me.ProductosPedidos, Me.DevolverStock, Me.PagosRealizadosToolStripMenuItem})
        Me.mnuCompras.ForeColor = System.Drawing.Color.White
        Me.mnuCompras.Name = "mnuCompras"
        Me.mnuCompras.Size = New System.Drawing.Size(67, 20)
        Me.mnuCompras.Text = "Compras"
        '
        'RecibirStock
        '
        Me.RecibirStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.RecibirStock.ForeColor = System.Drawing.Color.White
        Me.RecibirStock.Name = "RecibirStock"
        Me.RecibirStock.Size = New System.Drawing.Size(241, 22)
        Me.RecibirStock.Text = "Nueva Compra"
        '
        'ListaCompras
        '
        Me.ListaCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaCompras.ForeColor = System.Drawing.Color.White
        Me.ListaCompras.Name = "ListaCompras"
        Me.ListaCompras.Size = New System.Drawing.Size(241, 22)
        Me.ListaCompras.Text = "Consultar Compras"
        '
        'PedirStock
        '
        Me.PedirStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PedirStock.ForeColor = System.Drawing.Color.White
        Me.PedirStock.Name = "PedirStock"
        Me.PedirStock.Size = New System.Drawing.Size(241, 22)
        Me.PedirStock.Text = "Pedir Stock"
        Me.PedirStock.Visible = False
        '
        'ListaPedidos
        '
        Me.ListaPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaPedidos.ForeColor = System.Drawing.Color.White
        Me.ListaPedidos.Name = "ListaPedidos"
        Me.ListaPedidos.Size = New System.Drawing.Size(241, 22)
        Me.ListaPedidos.Text = "Lista de Pedidos"
        Me.ListaPedidos.Visible = False
        '
        'HistorialRecepcion
        '
        Me.HistorialRecepcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.HistorialRecepcion.ForeColor = System.Drawing.Color.White
        Me.HistorialRecepcion.Name = "HistorialRecepcion"
        Me.HistorialRecepcion.Size = New System.Drawing.Size(241, 22)
        Me.HistorialRecepcion.Text = "Historial de Recepción"
        Me.HistorialRecepcion.Visible = False
        '
        'ProductosPedidos
        '
        Me.ProductosPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ProductosPedidos.ForeColor = System.Drawing.Color.White
        Me.ProductosPedidos.Name = "ProductosPedidos"
        Me.ProductosPedidos.Size = New System.Drawing.Size(241, 22)
        Me.ProductosPedidos.Text = "Productos en Pedido"
        Me.ProductosPedidos.Visible = False
        '
        'DevolverStock
        '
        Me.DevolverStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DevolverStock.ForeColor = System.Drawing.Color.White
        Me.DevolverStock.Name = "DevolverStock"
        Me.DevolverStock.Size = New System.Drawing.Size(241, 22)
        Me.DevolverStock.Text = "Devolver Producto a Proveedor"
        '
        'PagosRealizadosToolStripMenuItem
        '
        Me.PagosRealizadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PagosRealizadosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PagosRealizadosToolStripMenuItem.Name = "PagosRealizadosToolStripMenuItem"
        Me.PagosRealizadosToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.PagosRealizadosToolStripMenuItem.Text = "Pagos Realizados a Proveedores"
        '
        'mnuProveed
        '
        Me.mnuProveed.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaProv, Me.NuevoProv})
        Me.mnuProveed.ForeColor = System.Drawing.Color.White
        Me.mnuProveed.Name = "mnuProveed"
        Me.mnuProveed.Size = New System.Drawing.Size(84, 20)
        Me.mnuProveed.Text = "Proveedores"
        '
        'ListaProv
        '
        Me.ListaProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaProv.ForeColor = System.Drawing.Color.White
        Me.ListaProv.Name = "ListaProv"
        Me.ListaProv.Size = New System.Drawing.Size(193, 22)
        Me.ListaProv.Text = "Consultar Proveedores"
        '
        'NuevoProv
        '
        Me.NuevoProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NuevoProv.ForeColor = System.Drawing.Color.White
        Me.NuevoProv.Name = "NuevoProv"
        Me.NuevoProv.Size = New System.Drawing.Size(193, 22)
        Me.NuevoProv.Text = "Nuevo Proveedor"
        '
        'mnuEmpleados
        '
        Me.mnuEmpleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaEmple, Me.NuevoEmple, Me.Comisiones})
        Me.mnuEmpleados.ForeColor = System.Drawing.Color.White
        Me.mnuEmpleados.Name = "mnuEmpleados"
        Me.mnuEmpleados.Size = New System.Drawing.Size(77, 20)
        Me.mnuEmpleados.Text = "Empleados"
        '
        'ListaEmple
        '
        Me.ListaEmple.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaEmple.ForeColor = System.Drawing.Color.White
        Me.ListaEmple.Name = "ListaEmple"
        Me.ListaEmple.Size = New System.Drawing.Size(175, 22)
        Me.ListaEmple.Text = "Lista de Empleados"
        '
        'NuevoEmple
        '
        Me.NuevoEmple.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NuevoEmple.ForeColor = System.Drawing.Color.White
        Me.NuevoEmple.Name = "NuevoEmple"
        Me.NuevoEmple.Size = New System.Drawing.Size(175, 22)
        Me.NuevoEmple.Text = "Nuevo Empleado"
        '
        'Comisiones
        '
        Me.Comisiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Comisiones.ForeColor = System.Drawing.Color.White
        Me.Comisiones.Name = "Comisiones"
        Me.Comisiones.Size = New System.Drawing.Size(175, 22)
        Me.Comisiones.Text = "Comisiones"
        '
        'mnuCuentas
        '
        Me.mnuCuentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentaPagar, Me.CuentaCobrar, Me.NuevaCuenta})
        Me.mnuCuentas.ForeColor = System.Drawing.Color.White
        Me.mnuCuentas.Name = "mnuCuentas"
        Me.mnuCuentas.Size = New System.Drawing.Size(62, 20)
        Me.mnuCuentas.Text = "Cuentas"
        '
        'CuentaPagar
        '
        Me.CuentaPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.CuentaPagar.ForeColor = System.Drawing.Color.White
        Me.CuentaPagar.Name = "CuentaPagar"
        Me.CuentaPagar.Size = New System.Drawing.Size(240, 22)
        Me.CuentaPagar.Text = "Pago de Cuentas a Proveedores"
        '
        'CuentaCobrar
        '
        Me.CuentaCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.CuentaCobrar.ForeColor = System.Drawing.Color.White
        Me.CuentaCobrar.Name = "CuentaCobrar"
        Me.CuentaCobrar.Size = New System.Drawing.Size(240, 22)
        Me.CuentaCobrar.Text = "Cobro de Cuentas a Clientes"
        '
        'NuevaCuenta
        '
        Me.NuevaCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NuevaCuenta.ForeColor = System.Drawing.Color.White
        Me.NuevaCuenta.Name = "NuevaCuenta"
        Me.NuevaCuenta.Size = New System.Drawing.Size(240, 22)
        Me.NuevaCuenta.Text = "Nueva Cuenta"
        Me.NuevaCuenta.Visible = False
        '
        'mnuFinanzas
        '
        Me.mnuFinanzas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GastosGeneralesToolStripMenuItem, Me.ListaDeGastosToolStripMenuItem, Me.BalanceToolStripMenuItem})
        Me.mnuFinanzas.ForeColor = System.Drawing.Color.White
        Me.mnuFinanzas.Name = "mnuFinanzas"
        Me.mnuFinanzas.Size = New System.Drawing.Size(64, 20)
        Me.mnuFinanzas.Text = "Finanzas"
        '
        'GastosGeneralesToolStripMenuItem
        '
        Me.GastosGeneralesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.GastosGeneralesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GastosGeneralesToolStripMenuItem.Name = "GastosGeneralesToolStripMenuItem"
        Me.GastosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GastosGeneralesToolStripMenuItem.Text = "Gastos Generales"
        '
        'ListaDeGastosToolStripMenuItem
        '
        Me.ListaDeGastosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ListaDeGastosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaDeGastosToolStripMenuItem.Name = "ListaDeGastosToolStripMenuItem"
        Me.ListaDeGastosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ListaDeGastosToolStripMenuItem.Text = "Consultar Gastos"
        '
        'BalanceToolStripMenuItem
        '
        Me.BalanceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BalanceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BalanceToolStripMenuItem.Name = "BalanceToolStripMenuItem"
        Me.BalanceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BalanceToolStripMenuItem.Text = "Balance"
        '
        'mnuUsuarios
        '
        Me.mnuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarDeUsuarioToolStripMenuItem, Me.NuevoUsu, Me.ConsultarUsu, Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem, Me.ConsultarNivelDePrivilegiosToolStripMenuItem})
        Me.mnuUsuarios.ForeColor = System.Drawing.Color.White
        Me.mnuUsuarios.Name = "mnuUsuarios"
        Me.mnuUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.mnuUsuarios.Text = "Usuarios"
        '
        'CambiarDeUsuarioToolStripMenuItem
        '
        Me.CambiarDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.CambiarDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CambiarDeUsuarioToolStripMenuItem.Name = "CambiarDeUsuarioToolStripMenuItem"
        Me.CambiarDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario"
        '
        'NuevoUsu
        '
        Me.NuevoUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.NuevoUsu.ForeColor = System.Drawing.Color.White
        Me.NuevoUsu.Name = "NuevoUsu"
        Me.NuevoUsu.Size = New System.Drawing.Size(257, 22)
        Me.NuevoUsu.Text = "Nuevo Usuario"
        '
        'ConsultarUsu
        '
        Me.ConsultarUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ConsultarUsu.ForeColor = System.Drawing.Color.White
        Me.ConsultarUsu.Name = "ConsultarUsu"
        Me.ConsultarUsu.Size = New System.Drawing.Size(257, 22)
        Me.ConsultarUsu.Text = "Consultar Usuarios"
        '
        'AgregarNuevoNivelDePrivilegiosToolStripMenuItem
        '
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Name = "AgregarNuevoNivelDePrivilegiosToolStripMenuItem"
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Text = "Agregar Nuevo Nivel de Privilegios"
        '
        'ConsultarNivelDePrivilegiosToolStripMenuItem
        '
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.Name = "ConsultarNivelDePrivilegiosToolStripMenuItem"
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.Text = "Consultar Nivel de Privilegios"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDateTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(928, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDateTime
        '
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(16, 17)
        Me.lblDateTime.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlVenta)
        Me.Panel1.Controls.Add(Me.lblHabitaciones)
        Me.Panel1.Controls.Add(Me.Habitacion10)
        Me.Panel1.Controls.Add(Me.Habitacion9)
        Me.Panel1.Controls.Add(Me.Habitacion8)
        Me.Panel1.Controls.Add(Me.Habitacion7)
        Me.Panel1.Controls.Add(Me.Habitacion6)
        Me.Panel1.Controls.Add(Me.Habitacion5)
        Me.Panel1.Controls.Add(Me.Habitacion4)
        Me.Panel1.Controls.Add(Me.Habitacion3)
        Me.Panel1.Controls.Add(Me.Habitacion2)
        Me.Panel1.Controls.Add(Me.Habitacion1)
        Me.Panel1.Controls.Add(Me.pnlSalir)
        Me.Panel1.Controls.Add(Me.pnlCompra)
        Me.Panel1.Controls.Add(Me.pnlProd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 544)
        Me.Panel1.TabIndex = 82
        '
        'pnlVenta
        '
        Me.pnlVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlVenta.Controls.Add(Me.lblVenta)
        Me.pnlVenta.Controls.Add(Me.pbxVenta)
        Me.pnlVenta.Location = New System.Drawing.Point(151, 432)
        Me.pnlVenta.Name = "pnlVenta"
        Me.pnlVenta.Size = New System.Drawing.Size(152, 54)
        Me.pnlVenta.TabIndex = 112
        Me.pnlVenta.Visible = False
        '
        'lblVenta
        '
        Me.lblVenta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.ForeColor = System.Drawing.Color.White
        Me.lblVenta.Location = New System.Drawing.Point(66, 17)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(52, 20)
        Me.lblVenta.TabIndex = 83
        Me.lblVenta.Text = "Venta"
        '
        'pbxVenta
        '
        Me.pbxVenta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxVenta.Image = CType(resources.GetObject("pbxVenta.Image"), System.Drawing.Image)
        Me.pbxVenta.Location = New System.Drawing.Point(12, 3)
        Me.pbxVenta.Name = "pbxVenta"
        Me.pbxVenta.Size = New System.Drawing.Size(48, 46)
        Me.pbxVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxVenta.TabIndex = 83
        Me.pbxVenta.TabStop = False
        '
        'lblHabitaciones
        '
        Me.lblHabitaciones.AutoSize = True
        Me.lblHabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabitaciones.ForeColor = System.Drawing.Color.White
        Me.lblHabitaciones.Location = New System.Drawing.Point(153, 29)
        Me.lblHabitaciones.Name = "lblHabitaciones"
        Me.lblHabitaciones.Size = New System.Drawing.Size(137, 25)
        Me.lblHabitaciones.TabIndex = 111
        Me.lblHabitaciones.Text = "Habitaciones"
        '
        'Habitacion10
        '
        Me.Habitacion10.BackColor = System.Drawing.Color.Green
        Me.Habitacion10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion10.Location = New System.Drawing.Point(38, 341)
        Me.Habitacion10.Name = "Habitacion10"
        Me.Habitacion10.NumeroHabitacion = 10
        Me.Habitacion10.Ocupado = False
        Me.Habitacion10.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion10.TabIndex = 110
        Me.Habitacion10.Tolerancia = 15
        '
        'Habitacion9
        '
        Me.Habitacion9.BackColor = System.Drawing.Color.Green
        Me.Habitacion9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion9.Location = New System.Drawing.Point(290, 248)
        Me.Habitacion9.Name = "Habitacion9"
        Me.Habitacion9.NumeroHabitacion = 9
        Me.Habitacion9.Ocupado = False
        Me.Habitacion9.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion9.TabIndex = 109
        Me.Habitacion9.Tolerancia = 15
        '
        'Habitacion8
        '
        Me.Habitacion8.BackColor = System.Drawing.Color.Green
        Me.Habitacion8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion8.Location = New System.Drawing.Point(164, 248)
        Me.Habitacion8.Name = "Habitacion8"
        Me.Habitacion8.NumeroHabitacion = 8
        Me.Habitacion8.Ocupado = False
        Me.Habitacion8.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion8.TabIndex = 108
        Me.Habitacion8.Tolerancia = 15
        '
        'Habitacion7
        '
        Me.Habitacion7.BackColor = System.Drawing.Color.Green
        Me.Habitacion7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion7.Location = New System.Drawing.Point(38, 248)
        Me.Habitacion7.Name = "Habitacion7"
        Me.Habitacion7.NumeroHabitacion = 7
        Me.Habitacion7.Ocupado = False
        Me.Habitacion7.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion7.TabIndex = 107
        Me.Habitacion7.Tolerancia = 15
        '
        'Habitacion6
        '
        Me.Habitacion6.BackColor = System.Drawing.Color.Green
        Me.Habitacion6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion6.Location = New System.Drawing.Point(290, 155)
        Me.Habitacion6.Name = "Habitacion6"
        Me.Habitacion6.NumeroHabitacion = 6
        Me.Habitacion6.Ocupado = False
        Me.Habitacion6.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion6.TabIndex = 106
        Me.Habitacion6.Tolerancia = 15
        '
        'Habitacion5
        '
        Me.Habitacion5.BackColor = System.Drawing.Color.Green
        Me.Habitacion5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion5.Location = New System.Drawing.Point(164, 155)
        Me.Habitacion5.Name = "Habitacion5"
        Me.Habitacion5.NumeroHabitacion = 5
        Me.Habitacion5.Ocupado = False
        Me.Habitacion5.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion5.TabIndex = 105
        Me.Habitacion5.Tolerancia = 15
        '
        'Habitacion4
        '
        Me.Habitacion4.BackColor = System.Drawing.Color.Green
        Me.Habitacion4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion4.Location = New System.Drawing.Point(38, 155)
        Me.Habitacion4.Name = "Habitacion4"
        Me.Habitacion4.NumeroHabitacion = 4
        Me.Habitacion4.Ocupado = False
        Me.Habitacion4.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion4.TabIndex = 104
        Me.Habitacion4.Tolerancia = 15
        '
        'Habitacion3
        '
        Me.Habitacion3.BackColor = System.Drawing.Color.Green
        Me.Habitacion3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion3.Location = New System.Drawing.Point(290, 62)
        Me.Habitacion3.Name = "Habitacion3"
        Me.Habitacion3.NumeroHabitacion = 3
        Me.Habitacion3.Ocupado = False
        Me.Habitacion3.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion3.TabIndex = 103
        Me.Habitacion3.Tolerancia = 1
        '
        'Habitacion2
        '
        Me.Habitacion2.BackColor = System.Drawing.Color.Green
        Me.Habitacion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion2.Location = New System.Drawing.Point(164, 62)
        Me.Habitacion2.Name = "Habitacion2"
        Me.Habitacion2.NumeroHabitacion = 2
        Me.Habitacion2.Ocupado = False
        Me.Habitacion2.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion2.TabIndex = 102
        Me.Habitacion2.Tolerancia = 15
        '
        'Habitacion1
        '
        Me.Habitacion1.BackColor = System.Drawing.Color.Green
        Me.Habitacion1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habitacion1.Location = New System.Drawing.Point(38, 62)
        Me.Habitacion1.Name = "Habitacion1"
        Me.Habitacion1.NumeroHabitacion = 1
        Me.Habitacion1.Ocupado = False
        Me.Habitacion1.Size = New System.Drawing.Size(123, 90)
        Me.Habitacion1.TabIndex = 101
        Me.Habitacion1.Tolerancia = 15
        '
        'pnlSalir
        '
        Me.pnlSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSalir.Controls.Add(Me.lblSalir)
        Me.pnlSalir.Controls.Add(Me.pbxSalir)
        Me.pnlSalir.Location = New System.Drawing.Point(0, 489)
        Me.pnlSalir.Name = "pnlSalir"
        Me.pnlSalir.Size = New System.Drawing.Size(152, 54)
        Me.pnlSalir.TabIndex = 88
        '
        'lblSalir
        '
        Me.lblSalir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSalir.AutoSize = True
        Me.lblSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.ForeColor = System.Drawing.Color.White
        Me.lblSalir.Location = New System.Drawing.Point(67, 18)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(40, 20)
        Me.lblSalir.TabIndex = 87
        Me.lblSalir.Text = "Salir"
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxSalir.Image = Global.ControlStock.My.Resources.Resources.Salir
        Me.pbxSalir.Location = New System.Drawing.Point(12, 4)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(48, 46)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 86
        Me.pbxSalir.TabStop = False
        '
        'pnlCompra
        '
        Me.pnlCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlCompra.Controls.Add(Me.lblCompra)
        Me.pnlCompra.Controls.Add(Me.pbxCompras)
        Me.pnlCompra.Location = New System.Drawing.Point(151, 489)
        Me.pnlCompra.Name = "pnlCompra"
        Me.pnlCompra.Size = New System.Drawing.Size(152, 54)
        Me.pnlCompra.TabIndex = 87
        '
        'lblCompra
        '
        Me.lblCompra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.ForeColor = System.Drawing.Color.White
        Me.lblCompra.Location = New System.Drawing.Point(67, 17)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(65, 20)
        Me.lblCompra.TabIndex = 85
        Me.lblCompra.Text = "Compra"
        '
        'pbxCompras
        '
        Me.pbxCompras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxCompras.Image = Global.ControlStock.My.Resources.Resources.Checkout2
        Me.pbxCompras.Location = New System.Drawing.Point(13, 3)
        Me.pbxCompras.Name = "pbxCompras"
        Me.pbxCompras.Size = New System.Drawing.Size(48, 46)
        Me.pbxCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCompras.TabIndex = 84
        Me.pbxCompras.TabStop = False
        '
        'pnlProd
        '
        Me.pnlProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlProd.Controls.Add(Me.lblProd)
        Me.pnlProd.Controls.Add(Me.pbxProd)
        Me.pnlProd.Location = New System.Drawing.Point(302, 489)
        Me.pnlProd.Name = "pnlProd"
        Me.pnlProd.Size = New System.Drawing.Size(152, 54)
        Me.pnlProd.TabIndex = 85
        '
        'lblProd
        '
        Me.lblProd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProd.AutoSize = True
        Me.lblProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.ForeColor = System.Drawing.Color.White
        Me.lblProd.Location = New System.Drawing.Point(67, 18)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(81, 20)
        Me.lblProd.TabIndex = 85
        Me.lblProd.Text = "Productos"
        '
        'pbxProd
        '
        Me.pbxProd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxProd.Image = Global.ControlStock.My.Resources.Resources.Search100
        Me.pbxProd.Location = New System.Drawing.Point(13, 4)
        Me.pbxProd.Name = "pbxProd"
        Me.pbxProd.Size = New System.Drawing.Size(48, 46)
        Me.pbxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxProd.TabIndex = 84
        Me.pbxProd.TabStop = False
        '
        'FPrincipalMotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 590)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FPrincipalMotel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControlStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlVenta.ResumeLayout(False)
        Me.pnlVenta.PerformLayout()
        CType(Me.pbxVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSalir.ResumeLayout(False)
        Me.pnlSalir.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCompra.ResumeLayout(False)
        Me.pnlCompra.PerformLayout()
        CType(Me.pbxCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProd.ResumeLayout(False)
        Me.pnlProd.PerformLayout()
        CType(Me.pbxProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TmrFecha As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaBajaDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaAltaDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaCredito As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedirStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaPedidos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialRecepcion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosPedidos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolverStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaEmple As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoEmple As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Comisiones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProveed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaProv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCuentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaPagar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCobrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCuenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlSalir As System.Windows.Forms.Panel
    Friend WithEvents pnlCompra As System.Windows.Forms.Panel
    Friend WithEvents pnlProd As System.Windows.Forms.Panel
    Friend WithEvents lblSalir As System.Windows.Forms.Label
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents pbxCompras As System.Windows.Forms.PictureBox
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents pbxProd As System.Windows.Forms.PictureBox
    Friend WithEvents RecibosDeDinero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosRealizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFinanzas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHabitaciones As Label
    Friend WithEvents Habitacion10 As Habitacion
    Friend WithEvents Habitacion9 As Habitacion
    Friend WithEvents Habitacion8 As Habitacion
    Friend WithEvents Habitacion7 As Habitacion
    Friend WithEvents Habitacion6 As Habitacion
    Friend WithEvents Habitacion5 As Habitacion
    Friend WithEvents Habitacion4 As Habitacion
    Friend WithEvents Habitacion3 As Habitacion
    Friend WithEvents Habitacion2 As Habitacion
    Friend WithEvents Habitacion1 As Habitacion
    Friend WithEvents HabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeHabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosDeHabitaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsu As ToolStripMenuItem
    Friend WithEvents ConsultarUsu As ToolStripMenuItem
    Friend WithEvents RecibirStock As ToolStripMenuItem
    Friend WithEvents pnlVenta As Panel
    Friend WithEvents lblVenta As Label
    Friend WithEvents pbxVenta As PictureBox
    Friend WithEvents ConsultarNivelDePrivilegiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoNivelDePrivilegiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeGastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCaja As ToolStripMenuItem
    Friend WithEvents mnuAbrirCaja As ToolStripMenuItem
    Friend WithEvents mnuCerrarCaja As ToolStripMenuItem
    Friend WithEvents mnuHistorialDeCaja As ToolStripMenuItem
    Friend WithEvents mnuResumenDeCaja As ToolStripMenuItem
End Class
