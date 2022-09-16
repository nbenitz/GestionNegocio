<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPrincipal
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
        Me.TmrFecha = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarGastoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultarClentes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevoCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDarDeBajaAInactivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosConDeudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembresia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListaMembresia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevaMembresia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosDeMembresíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaBajaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaAltaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategoria = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuAcceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccesoAjustes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAsistenciaSocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAsistenciaEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBarSide = New System.Windows.Forms.Panel()
        Me.pnlCerradura = New System.Windows.Forms.Panel()
        Me.lblCerradura = New System.Windows.Forms.Label()
        Me.pbxCerradura = New System.Windows.Forms.PictureBox()
        Me.pnlVenta = New System.Windows.Forms.Panel()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.pbxVenta = New System.Windows.Forms.PictureBox()
        Me.pnlCompra = New System.Windows.Forms.Panel()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.pbxCompras = New System.Windows.Forms.PictureBox()
        Me.pnlProd = New System.Windows.Forms.Panel()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.pbxProd = New System.Windows.Forms.PictureBox()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.lblEmpleado2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlEvento = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pbxRetraer = New System.Windows.Forms.PictureBox()
        Me.BtnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlBarSide.SuspendLayout()
        Me.pnlCerradura.SuspendLayout()
        CType(Me.pbxCerradura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVenta.SuspendLayout()
        CType(Me.pbxVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCompra.SuspendLayout()
        CType(Me.pbxCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProd.SuspendLayout()
        CType(Me.pbxProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.pbxRetraer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TmrFecha
        '
        Me.TmrFecha.Enabled = True
        Me.TmrFecha.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuCaja, Me.mnuVentas, Me.mnuCompras, Me.mnuClientes, Me.mnuMembresia, Me.mnuProd, Me.mnuProveed, Me.mnuEmpleados, Me.mnuCuentas, Me.mnuFinanzas, Me.mnuUsuarios, Me.mnuAcceso, Me.mnuAyuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1152, 35)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.mnuArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 31)
        Me.mnuArchivo.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'mnuCaja
        '
        Me.mnuCaja.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirCajaToolStripMenuItem, Me.CerrarCajaToolStripMenuItem, Me.HistorialDeCajaToolStripMenuItem, Me.DetalleDeCajaToolStripMenuItem, Me.RegistrarGastoCompraToolStripMenuItem, Me.CobrarToolStripMenuItem})
        Me.mnuCaja.ForeColor = System.Drawing.Color.White
        Me.mnuCaja.Name = "mnuCaja"
        Me.mnuCaja.Size = New System.Drawing.Size(42, 31)
        Me.mnuCaja.Text = "Caja"
        '
        'AbrirCajaToolStripMenuItem
        '
        Me.AbrirCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AbrirCajaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AbrirCajaToolStripMenuItem.Name = "AbrirCajaToolStripMenuItem"
        Me.AbrirCajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbrirCajaToolStripMenuItem.Text = "Abrir Caja"
        '
        'CerrarCajaToolStripMenuItem
        '
        Me.CerrarCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CerrarCajaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarCajaToolStripMenuItem.Name = "CerrarCajaToolStripMenuItem"
        Me.CerrarCajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarCajaToolStripMenuItem.Text = "Cerrar Caja"
        '
        'HistorialDeCajaToolStripMenuItem
        '
        Me.HistorialDeCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.HistorialDeCajaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HistorialDeCajaToolStripMenuItem.Name = "HistorialDeCajaToolStripMenuItem"
        Me.HistorialDeCajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HistorialDeCajaToolStripMenuItem.Text = "Historial de Caja"
        '
        'DetalleDeCajaToolStripMenuItem
        '
        Me.DetalleDeCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DetalleDeCajaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DetalleDeCajaToolStripMenuItem.Name = "DetalleDeCajaToolStripMenuItem"
        Me.DetalleDeCajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DetalleDeCajaToolStripMenuItem.Text = "Resumen de Caja"
        '
        'RegistrarGastoCompraToolStripMenuItem
        '
        Me.RegistrarGastoCompraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RegistrarGastoCompraToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RegistrarGastoCompraToolStripMenuItem.Name = "RegistrarGastoCompraToolStripMenuItem"
        Me.RegistrarGastoCompraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarGastoCompraToolStripMenuItem.Text = "Registrar Gasto"
        '
        'CobrarToolStripMenuItem
        '
        Me.CobrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CobrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CobrarToolStripMenuItem.Name = "CobrarToolStripMenuItem"
        Me.CobrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CobrarToolStripMenuItem.Text = "Caja Actual"
        Me.CobrarToolStripMenuItem.Visible = False
        '
        'mnuVentas
        '
        Me.mnuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVenta, Me.ConsultarVenta, Me.NotaCredito, Me.RecibosDeDinero})
        Me.mnuVentas.ForeColor = System.Drawing.Color.White
        Me.mnuVentas.Name = "mnuVentas"
        Me.mnuVentas.Size = New System.Drawing.Size(53, 31)
        Me.mnuVentas.Text = "Ventas"
        '
        'NuevaVenta
        '
        Me.NuevaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NuevaVenta.ForeColor = System.Drawing.Color.White
        Me.NuevaVenta.Name = "NuevaVenta"
        Me.NuevaVenta.Size = New System.Drawing.Size(303, 22)
        Me.NuevaVenta.Text = "Nueva Venta"
        Me.NuevaVenta.Visible = False
        '
        'ConsultarVenta
        '
        Me.ConsultarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ConsultarVenta.ForeColor = System.Drawing.Color.White
        Me.ConsultarVenta.Name = "ConsultarVenta"
        Me.ConsultarVenta.Size = New System.Drawing.Size(303, 22)
        Me.ConsultarVenta.Text = "Consultar Ventas"
        '
        'NotaCredito
        '
        Me.NotaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NotaCredito.ForeColor = System.Drawing.Color.White
        Me.NotaCredito.Name = "NotaCredito"
        Me.NotaCredito.Size = New System.Drawing.Size(303, 22)
        Me.NotaCredito.Text = "Devoluciones (Nota de Crédito)"
        '
        'RecibosDeDinero
        '
        Me.RecibosDeDinero.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
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
        Me.mnuCompras.Size = New System.Drawing.Size(67, 31)
        Me.mnuCompras.Text = "Compras"
        '
        'RecibirStock
        '
        Me.RecibirStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RecibirStock.ForeColor = System.Drawing.Color.White
        Me.RecibirStock.Name = "RecibirStock"
        Me.RecibirStock.Size = New System.Drawing.Size(241, 22)
        Me.RecibirStock.Text = "Nueva Compra"
        '
        'ListaCompras
        '
        Me.ListaCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaCompras.ForeColor = System.Drawing.Color.White
        Me.ListaCompras.Name = "ListaCompras"
        Me.ListaCompras.Size = New System.Drawing.Size(241, 22)
        Me.ListaCompras.Text = "Consultar Compras"
        '
        'PedirStock
        '
        Me.PedirStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PedirStock.ForeColor = System.Drawing.Color.White
        Me.PedirStock.Name = "PedirStock"
        Me.PedirStock.Size = New System.Drawing.Size(241, 22)
        Me.PedirStock.Text = "Pedir Stock"
        Me.PedirStock.Visible = False
        '
        'ListaPedidos
        '
        Me.ListaPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaPedidos.ForeColor = System.Drawing.Color.White
        Me.ListaPedidos.Name = "ListaPedidos"
        Me.ListaPedidos.Size = New System.Drawing.Size(241, 22)
        Me.ListaPedidos.Text = "Lista de Pedidos"
        Me.ListaPedidos.Visible = False
        '
        'HistorialRecepcion
        '
        Me.HistorialRecepcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.HistorialRecepcion.ForeColor = System.Drawing.Color.White
        Me.HistorialRecepcion.Name = "HistorialRecepcion"
        Me.HistorialRecepcion.Size = New System.Drawing.Size(241, 22)
        Me.HistorialRecepcion.Text = "Historial de Recepción"
        Me.HistorialRecepcion.Visible = False
        '
        'ProductosPedidos
        '
        Me.ProductosPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ProductosPedidos.ForeColor = System.Drawing.Color.White
        Me.ProductosPedidos.Name = "ProductosPedidos"
        Me.ProductosPedidos.Size = New System.Drawing.Size(241, 22)
        Me.ProductosPedidos.Text = "Productos en Pedido"
        Me.ProductosPedidos.Visible = False
        '
        'DevolverStock
        '
        Me.DevolverStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DevolverStock.ForeColor = System.Drawing.Color.White
        Me.DevolverStock.Name = "DevolverStock"
        Me.DevolverStock.Size = New System.Drawing.Size(241, 22)
        Me.DevolverStock.Text = "Devolver Producto a Proveedor"
        '
        'PagosRealizadosToolStripMenuItem
        '
        Me.PagosRealizadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PagosRealizadosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PagosRealizadosToolStripMenuItem.Name = "PagosRealizadosToolStripMenuItem"
        Me.PagosRealizadosToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.PagosRealizadosToolStripMenuItem.Text = "Pagos Realizados a Proveedores"
        '
        'mnuClientes
        '
        Me.mnuClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsultarClentes, Me.mnuNuevoCliente, Me.AsistenciaToolStripMenuItem, Me.mnuDarDeBajaAInactivos, Me.SociosConDeudaToolStripMenuItem})
        Me.mnuClientes.ForeColor = System.Drawing.Color.White
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(53, 31)
        Me.mnuClientes.Text = "Socios"
        '
        'mnuConsultarClentes
        '
        Me.mnuConsultarClentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuConsultarClentes.ForeColor = System.Drawing.Color.White
        Me.mnuConsultarClentes.Name = "mnuConsultarClentes"
        Me.mnuConsultarClentes.Size = New System.Drawing.Size(192, 22)
        Me.mnuConsultarClentes.Text = "Lista de Socios"
        '
        'mnuNuevoCliente
        '
        Me.mnuNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuNuevoCliente.ForeColor = System.Drawing.Color.White
        Me.mnuNuevoCliente.Name = "mnuNuevoCliente"
        Me.mnuNuevoCliente.Size = New System.Drawing.Size(192, 22)
        Me.mnuNuevoCliente.Text = "Nuevo Socio"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AsistenciaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'mnuDarDeBajaAInactivos
        '
        Me.mnuDarDeBajaAInactivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuDarDeBajaAInactivos.ForeColor = System.Drawing.Color.White
        Me.mnuDarDeBajaAInactivos.Name = "mnuDarDeBajaAInactivos"
        Me.mnuDarDeBajaAInactivos.Size = New System.Drawing.Size(192, 22)
        Me.mnuDarDeBajaAInactivos.Text = "Dar de Baja a Inactivos"
        '
        'SociosConDeudaToolStripMenuItem
        '
        Me.SociosConDeudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SociosConDeudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SociosConDeudaToolStripMenuItem.Name = "SociosConDeudaToolStripMenuItem"
        Me.SociosConDeudaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SociosConDeudaToolStripMenuItem.Text = "Socios con Deuda"
        '
        'mnuMembresia
        '
        Me.mnuMembresia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuListaMembresia, Me.mnuNuevaMembresia, Me.ContratosDeMembresíaToolStripMenuItem})
        Me.mnuMembresia.ForeColor = System.Drawing.Color.White
        Me.mnuMembresia.Name = "mnuMembresia"
        Me.mnuMembresia.Size = New System.Drawing.Size(83, 31)
        Me.mnuMembresia.Text = "Membresías"
        '
        'mnuListaMembresia
        '
        Me.mnuListaMembresia.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuListaMembresia.ForeColor = System.Drawing.Color.White
        Me.mnuListaMembresia.Name = "mnuListaMembresia"
        Me.mnuListaMembresia.Size = New System.Drawing.Size(204, 22)
        Me.mnuListaMembresia.Text = "Lista de Membresías"
        '
        'mnuNuevaMembresia
        '
        Me.mnuNuevaMembresia.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuNuevaMembresia.ForeColor = System.Drawing.Color.White
        Me.mnuNuevaMembresia.Name = "mnuNuevaMembresia"
        Me.mnuNuevaMembresia.Size = New System.Drawing.Size(204, 22)
        Me.mnuNuevaMembresia.Text = "Nueva Membresía"
        '
        'ContratosDeMembresíaToolStripMenuItem
        '
        Me.ContratosDeMembresíaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ContratosDeMembresíaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ContratosDeMembresíaToolStripMenuItem.Name = "ContratosDeMembresíaToolStripMenuItem"
        Me.ContratosDeMembresíaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ContratosDeMembresíaToolStripMenuItem.Text = "Contratos de Membresía"
        '
        'mnuProd
        '
        Me.mnuProd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaProd, Me.NuevoProd, Me.ListaBajaDeProductosToolStripMenuItem, Me.ListaAltaDeProductosToolStripMenuItem, Me.mnuCategoria})
        Me.mnuProd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuProd.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuProd.Name = "mnuProd"
        Me.mnuProd.Size = New System.Drawing.Size(73, 31)
        Me.mnuProd.Text = "Productos"
        '
        'ConsultaProd
        '
        Me.ConsultaProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ConsultaProd.ForeColor = System.Drawing.Color.White
        Me.ConsultaProd.Name = "ConsultaProd"
        Me.ConsultaProd.Size = New System.Drawing.Size(182, 22)
        Me.ConsultaProd.Text = "Consultar Productos"
        '
        'NuevoProd
        '
        Me.NuevoProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NuevoProd.ForeColor = System.Drawing.Color.White
        Me.NuevoProd.Name = "NuevoProd"
        Me.NuevoProd.Size = New System.Drawing.Size(182, 22)
        Me.NuevoProd.Text = "Nuevo Producto"
        '
        'ListaBajaDeProductosToolStripMenuItem
        '
        Me.ListaBajaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaBajaDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaBajaDeProductosToolStripMenuItem.Name = "ListaBajaDeProductosToolStripMenuItem"
        Me.ListaBajaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ListaBajaDeProductosToolStripMenuItem.Text = "Baja de Productos"
        '
        'ListaAltaDeProductosToolStripMenuItem
        '
        Me.ListaAltaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaAltaDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaAltaDeProductosToolStripMenuItem.Name = "ListaAltaDeProductosToolStripMenuItem"
        Me.ListaAltaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ListaAltaDeProductosToolStripMenuItem.Text = "Alta de Productos"
        '
        'mnuCategoria
        '
        Me.mnuCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuCategoria.ForeColor = System.Drawing.Color.White
        Me.mnuCategoria.Name = "mnuCategoria"
        Me.mnuCategoria.Size = New System.Drawing.Size(182, 22)
        Me.mnuCategoria.Text = "Categorías"
        '
        'mnuProveed
        '
        Me.mnuProveed.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaProv, Me.NuevoProv})
        Me.mnuProveed.ForeColor = System.Drawing.Color.White
        Me.mnuProveed.Name = "mnuProveed"
        Me.mnuProveed.Size = New System.Drawing.Size(84, 31)
        Me.mnuProveed.Text = "Proveedores"
        '
        'ListaProv
        '
        Me.ListaProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaProv.ForeColor = System.Drawing.Color.White
        Me.ListaProv.Name = "ListaProv"
        Me.ListaProv.Size = New System.Drawing.Size(193, 22)
        Me.ListaProv.Text = "Consultar Proveedores"
        '
        'NuevoProv
        '
        Me.NuevoProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
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
        Me.mnuEmpleados.Size = New System.Drawing.Size(77, 31)
        Me.mnuEmpleados.Text = "Empleados"
        '
        'ListaEmple
        '
        Me.ListaEmple.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaEmple.ForeColor = System.Drawing.Color.White
        Me.ListaEmple.Name = "ListaEmple"
        Me.ListaEmple.Size = New System.Drawing.Size(175, 22)
        Me.ListaEmple.Text = "Lista de Empleados"
        '
        'NuevoEmple
        '
        Me.NuevoEmple.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NuevoEmple.ForeColor = System.Drawing.Color.White
        Me.NuevoEmple.Name = "NuevoEmple"
        Me.NuevoEmple.Size = New System.Drawing.Size(175, 22)
        Me.NuevoEmple.Text = "Nuevo Empleado"
        '
        'Comisiones
        '
        Me.Comisiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Comisiones.ForeColor = System.Drawing.Color.White
        Me.Comisiones.Name = "Comisiones"
        Me.Comisiones.Size = New System.Drawing.Size(175, 22)
        Me.Comisiones.Text = "Comisiones"
        Me.Comisiones.Visible = False
        '
        'mnuCuentas
        '
        Me.mnuCuentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentaPagar, Me.CuentaCobrar, Me.NuevaCuenta})
        Me.mnuCuentas.ForeColor = System.Drawing.Color.White
        Me.mnuCuentas.Name = "mnuCuentas"
        Me.mnuCuentas.Size = New System.Drawing.Size(62, 31)
        Me.mnuCuentas.Text = "Cuentas"
        '
        'CuentaPagar
        '
        Me.CuentaPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CuentaPagar.ForeColor = System.Drawing.Color.White
        Me.CuentaPagar.Name = "CuentaPagar"
        Me.CuentaPagar.Size = New System.Drawing.Size(240, 22)
        Me.CuentaPagar.Text = "Pago de Cuentas a Proveedores"
        '
        'CuentaCobrar
        '
        Me.CuentaCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CuentaCobrar.ForeColor = System.Drawing.Color.White
        Me.CuentaCobrar.Name = "CuentaCobrar"
        Me.CuentaCobrar.Size = New System.Drawing.Size(240, 22)
        Me.CuentaCobrar.Text = "Cobro de Cuentas a Clientes"
        '
        'NuevaCuenta
        '
        Me.NuevaCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
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
        Me.mnuFinanzas.Size = New System.Drawing.Size(64, 31)
        Me.mnuFinanzas.Text = "Finanzas"
        '
        'GastosGeneralesToolStripMenuItem
        '
        Me.GastosGeneralesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GastosGeneralesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GastosGeneralesToolStripMenuItem.Name = "GastosGeneralesToolStripMenuItem"
        Me.GastosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GastosGeneralesToolStripMenuItem.Text = "Gastos Generales"
        '
        'ListaDeGastosToolStripMenuItem
        '
        Me.ListaDeGastosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListaDeGastosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListaDeGastosToolStripMenuItem.Name = "ListaDeGastosToolStripMenuItem"
        Me.ListaDeGastosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ListaDeGastosToolStripMenuItem.Text = "Consultar Gastos"
        '
        'BalanceToolStripMenuItem
        '
        Me.BalanceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
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
        Me.mnuUsuarios.Size = New System.Drawing.Size(64, 31)
        Me.mnuUsuarios.Text = "Usuarios"
        '
        'CambiarDeUsuarioToolStripMenuItem
        '
        Me.CambiarDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CambiarDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CambiarDeUsuarioToolStripMenuItem.Name = "CambiarDeUsuarioToolStripMenuItem"
        Me.CambiarDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario"
        '
        'NuevoUsu
        '
        Me.NuevoUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NuevoUsu.ForeColor = System.Drawing.Color.White
        Me.NuevoUsu.Name = "NuevoUsu"
        Me.NuevoUsu.Size = New System.Drawing.Size(257, 22)
        Me.NuevoUsu.Text = "Nuevo Usuario"
        '
        'ConsultarUsu
        '
        Me.ConsultarUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ConsultarUsu.ForeColor = System.Drawing.Color.White
        Me.ConsultarUsu.Name = "ConsultarUsu"
        Me.ConsultarUsu.Size = New System.Drawing.Size(257, 22)
        Me.ConsultarUsu.Text = "Consultar Usuarios"
        '
        'AgregarNuevoNivelDePrivilegiosToolStripMenuItem
        '
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Name = "AgregarNuevoNivelDePrivilegiosToolStripMenuItem"
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Text = "Agregar Nuevo Nivel de Privilegios"
        '
        'ConsultarNivelDePrivilegiosToolStripMenuItem
        '
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.Name = "ConsultarNivelDePrivilegiosToolStripMenuItem"
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ConsultarNivelDePrivilegiosToolStripMenuItem.Text = "Consultar Nivel de Privilegios"
        '
        'mnuAcceso
        '
        Me.mnuAcceso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAccesoAjustes, Me.mnuAsistenciaSocio, Me.mnuAsistenciaEmpleado})
        Me.mnuAcceso.ForeColor = System.Drawing.Color.White
        Me.mnuAcceso.Name = "mnuAcceso"
        Me.mnuAcceso.Size = New System.Drawing.Size(57, 31)
        Me.mnuAcceso.Text = "Acceso"
        '
        'mnuAccesoAjustes
        '
        Me.mnuAccesoAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuAccesoAjustes.ForeColor = System.Drawing.Color.White
        Me.mnuAccesoAjustes.Name = "mnuAccesoAjustes"
        Me.mnuAccesoAjustes.Size = New System.Drawing.Size(204, 22)
        Me.mnuAccesoAjustes.Text = "Ajustes"
        '
        'mnuAsistenciaSocio
        '
        Me.mnuAsistenciaSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuAsistenciaSocio.ForeColor = System.Drawing.Color.White
        Me.mnuAsistenciaSocio.Name = "mnuAsistenciaSocio"
        Me.mnuAsistenciaSocio.Size = New System.Drawing.Size(204, 22)
        Me.mnuAsistenciaSocio.Text = "Asistencia de Socios"
        '
        'mnuAsistenciaEmpleado
        '
        Me.mnuAsistenciaEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mnuAsistenciaEmpleado.ForeColor = System.Drawing.Color.White
        Me.mnuAsistenciaEmpleado.Name = "mnuAsistenciaEmpleado"
        Me.mnuAsistenciaEmpleado.Size = New System.Drawing.Size(204, 22)
        Me.mnuAsistenciaEmpleado.Text = "Asistencia de Empleados"
        '
        'mnuAyuda
        '
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.mnuAyuda.ForeColor = System.Drawing.Color.White
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.Size = New System.Drawing.Size(53, 31)
        Me.mnuAyuda.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'pnlBarSide
        '
        Me.pnlBarSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlBarSide.Controls.Add(Me.pnlCerradura)
        Me.pnlBarSide.Controls.Add(Me.pnlVenta)
        Me.pnlBarSide.Controls.Add(Me.pnlCompra)
        Me.pnlBarSide.Controls.Add(Me.pnlProd)
        Me.pnlBarSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBarSide.Location = New System.Drawing.Point(0, 35)
        Me.pnlBarSide.Name = "pnlBarSide"
        Me.pnlBarSide.Size = New System.Drawing.Size(160, 555)
        Me.pnlBarSide.TabIndex = 82
        '
        'pnlCerradura
        '
        Me.pnlCerradura.Controls.Add(Me.lblCerradura)
        Me.pnlCerradura.Controls.Add(Me.pbxCerradura)
        Me.pnlCerradura.Location = New System.Drawing.Point(0, 42)
        Me.pnlCerradura.Name = "pnlCerradura"
        Me.pnlCerradura.Size = New System.Drawing.Size(161, 41)
        Me.pnlCerradura.TabIndex = 113
        '
        'lblCerradura
        '
        Me.lblCerradura.AutoSize = True
        Me.lblCerradura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCerradura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerradura.ForeColor = System.Drawing.Color.White
        Me.lblCerradura.Location = New System.Drawing.Point(55, 11)
        Me.lblCerradura.Name = "lblCerradura"
        Me.lblCerradura.Size = New System.Drawing.Size(57, 20)
        Me.lblCerradura.TabIndex = 85
        Me.lblCerradura.Text = "Socios"
        '
        'pbxCerradura
        '
        Me.pbxCerradura.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxCerradura.Image = Global.ControlStock.My.Resources.Resources.customer
        Me.pbxCerradura.Location = New System.Drawing.Point(12, 3)
        Me.pbxCerradura.Name = "pbxCerradura"
        Me.pbxCerradura.Size = New System.Drawing.Size(35, 35)
        Me.pbxCerradura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCerradura.TabIndex = 84
        Me.pbxCerradura.TabStop = False
        '
        'pnlVenta
        '
        Me.pnlVenta.Controls.Add(Me.lblVenta)
        Me.pnlVenta.Controls.Add(Me.pbxVenta)
        Me.pnlVenta.Location = New System.Drawing.Point(0, 83)
        Me.pnlVenta.Name = "pnlVenta"
        Me.pnlVenta.Size = New System.Drawing.Size(161, 41)
        Me.pnlVenta.TabIndex = 112
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.ForeColor = System.Drawing.Color.White
        Me.lblVenta.Location = New System.Drawing.Point(55, 11)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(52, 20)
        Me.lblVenta.TabIndex = 83
        Me.lblVenta.Text = "Venta"
        '
        'pbxVenta
        '
        Me.pbxVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxVenta.Image = Global.ControlStock.My.Resources.Resources.Checkout
        Me.pbxVenta.Location = New System.Drawing.Point(12, 3)
        Me.pbxVenta.Name = "pbxVenta"
        Me.pbxVenta.Size = New System.Drawing.Size(35, 35)
        Me.pbxVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxVenta.TabIndex = 83
        Me.pbxVenta.TabStop = False
        '
        'pnlCompra
        '
        Me.pnlCompra.Controls.Add(Me.lblCompra)
        Me.pnlCompra.Controls.Add(Me.pbxCompras)
        Me.pnlCompra.Location = New System.Drawing.Point(0, 165)
        Me.pnlCompra.Name = "pnlCompra"
        Me.pnlCompra.Size = New System.Drawing.Size(161, 41)
        Me.pnlCompra.TabIndex = 87
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.ForeColor = System.Drawing.Color.White
        Me.lblCompra.Location = New System.Drawing.Point(55, 11)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(65, 20)
        Me.lblCompra.TabIndex = 85
        Me.lblCompra.Text = "Compra"
        '
        'pbxCompras
        '
        Me.pbxCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxCompras.Image = Global.ControlStock.My.Resources.Resources.Checkout2
        Me.pbxCompras.Location = New System.Drawing.Point(12, 3)
        Me.pbxCompras.Name = "pbxCompras"
        Me.pbxCompras.Size = New System.Drawing.Size(35, 35)
        Me.pbxCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxCompras.TabIndex = 84
        Me.pbxCompras.TabStop = False
        '
        'pnlProd
        '
        Me.pnlProd.Controls.Add(Me.lblProd)
        Me.pnlProd.Controls.Add(Me.pbxProd)
        Me.pnlProd.Location = New System.Drawing.Point(0, 124)
        Me.pnlProd.Name = "pnlProd"
        Me.pnlProd.Size = New System.Drawing.Size(161, 41)
        Me.pnlProd.TabIndex = 85
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.ForeColor = System.Drawing.Color.White
        Me.lblProd.Location = New System.Drawing.Point(55, 11)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(81, 20)
        Me.lblProd.TabIndex = 85
        Me.lblProd.Text = "Productos"
        '
        'pbxProd
        '
        Me.pbxProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxProd.Image = Global.ControlStock.My.Resources.Resources.Search100
        Me.pbxProd.Location = New System.Drawing.Point(12, 3)
        Me.pbxProd.Name = "pbxProd"
        Me.pbxProd.Size = New System.Drawing.Size(35, 35)
        Me.pbxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxProd.TabIndex = 84
        Me.pbxProd.TabStop = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPrincipal.Controls.Add(Me.lblCaja)
        Me.pnlPrincipal.Controls.Add(Me.lblEmpleado2)
        Me.pnlPrincipal.Controls.Add(Me.PictureBox1)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(160, 35)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(957, 555)
        Me.pnlPrincipal.TabIndex = 84
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.ForeColor = System.Drawing.Color.White
        Me.lblCaja.Location = New System.Drawing.Point(6, 29)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(154, 15)
        Me.lblCaja.TabIndex = 88
        Me.lblCaja.Text = "Caja abierta el dd/mm/aaaa"
        Me.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpleado2
        '
        Me.lblEmpleado2.AutoSize = True
        Me.lblEmpleado2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado2.ForeColor = System.Drawing.Color.White
        Me.lblEmpleado2.Location = New System.Drawing.Point(6, 11)
        Me.lblEmpleado2.Name = "lblEmpleado2"
        Me.lblEmpleado2.Size = New System.Drawing.Size(107, 15)
        Me.lblEmpleado2.TabIndex = 87
        Me.lblEmpleado2.Text = "Nombre Empleado"
        Me.lblEmpleado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ControlStock.My.Resources.Resources.logo_fitness_girsl_club_OFICCIAL
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(957, 555)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlRight.Controls.Add(Me.pnlEvento)
        Me.pnlRight.Controls.Add(Me.pnlTop)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1117, 35)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(35, 555)
        Me.pnlRight.TabIndex = 86
        '
        'pnlEvento
        '
        Me.pnlEvento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEvento.Location = New System.Drawing.Point(0, 26)
        Me.pnlEvento.Name = "pnlEvento"
        Me.pnlEvento.Size = New System.Drawing.Size(35, 529)
        Me.pnlEvento.TabIndex = 12
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pbxRetraer)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(35, 26)
        Me.pnlTop.TabIndex = 11
        '
        'pbxRetraer
        '
        Me.pbxRetraer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxRetraer.Image = Global.ControlStock.My.Resources.Resources.right_arrow
        Me.pbxRetraer.Location = New System.Drawing.Point(10, 5)
        Me.pbxRetraer.Name = "pbxRetraer"
        Me.pbxRetraer.Size = New System.Drawing.Size(15, 15)
        Me.pbxRetraer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxRetraer.TabIndex = 0
        Me.pbxRetraer.TabStop = False
        '
        'BtnCerrarForm
        '
        Me.BtnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarForm.Image = Global.ControlStock.My.Resources.Resources.close_16x
        Me.BtnCerrarForm.Location = New System.Drawing.Point(1117, 0)
        Me.BtnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarForm.Name = "BtnCerrarForm"
        Me.BtnCerrarForm.Size = New System.Drawing.Size(35, 35)
        Me.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCerrarForm.TabIndex = 115
        Me.BtnCerrarForm.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = Global.ControlStock.My.Resources.Resources.minimize_sign_16x
        Me.BtnMinimizar.Location = New System.Drawing.Point(1082, 0)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnMinimizar.TabIndex = 117
        Me.BtnMinimizar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblEmpleado)
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Location = New System.Drawing.Point(816, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 34)
        Me.Panel1.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(143, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "|"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpleado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleado.ForeColor = System.Drawing.Color.White
        Me.lblEmpleado.Location = New System.Drawing.Point(14, 9)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(125, 15)
        Me.lblEmpleado.TabIndex = 1
        Me.lblEmpleado.Text = "Nombre Empleado"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(155, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(103, 15)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "01/01/2022 - 00:00"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 590)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnMinimizar)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.BtnCerrarForm)
        Me.Controls.Add(Me.pnlBarSide)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControlStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlBarSide.ResumeLayout(False)
        Me.pnlCerradura.ResumeLayout(False)
        Me.pnlCerradura.PerformLayout()
        CType(Me.pbxCerradura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVenta.ResumeLayout(False)
        Me.pnlVenta.PerformLayout()
        CType(Me.pbxVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCompra.ResumeLayout(False)
        Me.pnlCompra.PerformLayout()
        CType(Me.pbxCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProd.ResumeLayout(False)
        Me.pnlProd.PerformLayout()
        CType(Me.pbxProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        CType(Me.pbxRetraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents pnlBarSide As System.Windows.Forms.Panel
    Friend WithEvents pnlCompra As System.Windows.Forms.Panel
    Friend WithEvents pnlProd As System.Windows.Forms.Panel
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents pbxCompras As System.Windows.Forms.PictureBox
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents pbxProd As System.Windows.Forms.PictureBox
    Friend WithEvents RecibosDeDinero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosRealizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFinanzas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsu As ToolStripMenuItem
    Friend WithEvents ConsultarUsu As ToolStripMenuItem
    Friend WithEvents RecibirStock As ToolStripMenuItem
    Friend WithEvents pnlVenta As Panel
    Friend WithEvents lblVenta As Label
    Friend WithEvents pbxVenta As PictureBox
    Friend WithEvents ConsultarNivelDePrivilegiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoNivelDePrivilegiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeGastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAyuda As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClientes As ToolStripMenuItem
    Friend WithEvents mnuNuevoCliente As ToolStripMenuItem
    Friend WithEvents mnuConsultarClentes As ToolStripMenuItem
    Friend WithEvents mnuCaja As ToolStripMenuItem
    Friend WithEvents AbrirCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalleDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCategoria As ToolStripMenuItem
    Friend WithEvents pnlCerradura As Panel
    Friend WithEvents lblCerradura As Label
    Friend WithEvents pbxCerradura As PictureBox
    Friend WithEvents mnuDarDeBajaAInactivos As ToolStripMenuItem
    Friend WithEvents RegistrarGastoCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SociosConDeudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents BtnCerrarForm As PictureBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlEvento As Panel
    Friend WithEvents pbxRetraer As PictureBox
    Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAcceso As ToolStripMenuItem
    Friend WithEvents mnuAccesoAjustes As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents mnuMembresia As ToolStripMenuItem
    Friend WithEvents mnuListaMembresia As ToolStripMenuItem
    Friend WithEvents mnuNuevaMembresia As ToolStripMenuItem
    Friend WithEvents ContratosDeMembresíaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAsistenciaSocio As ToolStripMenuItem
    Friend WithEvents mnuAsistenciaEmpleado As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents lblCaja As Label
    Friend WithEvents lblEmpleado2 As Label
End Class
