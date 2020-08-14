Option Strict On

Public Class FPrincipal
    Dim Caja As New CCaja
    Dim NumCaja As UInt16 = 1
    Dim CI As String

    Dim ProdEditValue As Boolean
    Dim ProvEditValue As Boolean
    Dim ProdDeleteValue As Boolean
    Dim ProvDeleteValue As Boolean
    Dim ProdNuevoValue As Boolean
    Dim ProvNuevoValue As Boolean

    Sub New(ByVal CIValue As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'LblUsuario.Text = "Bienvenido: " & user
        CI = CIValue
    End Sub

    Public Sub Privilegios(ByVal ProdConsult As Boolean,
                           ByVal ProdReg As Boolean,
                           ByVal ProdEdit As Boolean,
                           ByVal ProdEliminar As Boolean,
                           ByVal VentasConsult As Boolean,
                           ByVal VentasReg As Boolean,
                           ByVal ComprasConsult As Boolean,
                           ByVal ComprasReg As Boolean,
                           ByVal ProvConsult As Boolean,
                           ByVal ProvReg As Boolean,
                           ByVal ProvEdit As Boolean,
                           ByVal ProvEliminar As Boolean,
                           ByVal EmpleAdmin As Boolean,
                           ByVal UsuAdmin As Boolean,
                           ByVal FinanzasAdmin As Boolean,
                           ByVal HabAdmin As Boolean,
                           ByVal CuentasAdmin As Boolean,
                           ByVal DevolAutoriCli As Boolean,
                           ByVal DevolAutoriProv As Boolean)

        ProdEditValue = ProdEdit
        ProvEditValue = ProvEdit
        ProdDeleteValue = ProdEliminar
        ProvDeleteValue = ProvEliminar
        ProdNuevoValue = ProdReg
        ProvNuevoValue = ProvReg
        NuevoProd.Visible = ProdReg
        ConsultaProd.Visible = ProdConsult
        pnlProd.Visible = ProdConsult
        NuevaVenta.Visible = VentasReg
        pnlVenta.Visible = VentasReg
        ConsultarVenta.Visible = VentasConsult
        RecibirStock.Visible = ComprasReg
        pnlCompra.Visible = ComprasReg
        ListaCompras.Visible = ComprasConsult
        NuevoProv.Visible = ProvReg
        ListaProv.Visible = ProvConsult
        mnuEmpleados.Visible = EmpleAdmin
        NuevoUsu.Visible = UsuAdmin
        ConsultarUsu.Visible = UsuAdmin
        AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Visible = UsuAdmin
        ConsultarNivelDePrivilegiosToolStripMenuItem.Visible = UsuAdmin
        mnuCuentas.Visible = CuentasAdmin
        mnuFinanzas.Visible = FinanzasAdmin
        NotaCredito.Visible = DevolAutoriCli
        DevolverStock.Visible = DevolAutoriProv
        ListaAltaDeProductosToolStripMenuItem.Visible = ProdEdit
        ListaBajaDeProductosToolStripMenuItem.Visible = ProdEdit
        RecibosDeDinero.Visible = CuentasAdmin
        PagosRealizadosToolStripMenuItem.Visible = CuentasAdmin
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

    End Sub

    Private Sub BtnBusqueda_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ConsultaProd.Click, lblProd.Click, pbxProd.Click, pnlProd.Click
        Dim Frm As New FListaProd
        Frm.pnlEditar.Visible = ProdEditValue
        Frm.PnlEliminar.Visible = ProdDeleteValue
        Frm.TbtnNuevo.Visible = ProdNuevoValue
        AbrirVentana(Frm)
    End Sub

    Private Sub BtnFactura_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NuevaVenta.Click, pnlVenta.Click, lblVenta.Click, pbxVenta.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FVenta
            Frm.CIEmpleado = CI
            Frm.lblHab.Visible = False
            Frm.lblHab2.Visible = False
            Frm.LblTituloHab.Visible = False
            Frm.FormBorderStyle = FormBorderStyle.FixedDialog
            Frm.MaximumSize = New Size(861, 593)
            Frm.MinimumSize = New Size(861, 593)
            Frm.Size = New Size(861, 593)
            Frm.ModoMotel = False
            AbrirVentana(Frm)
        Else
            MessageBox.Show("Debe abrir la Caja antes de realizar una Venta")
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub BtnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCompra.Click, pbxCompras.Click, pnlCompra.Click, RecibirStock.Click
        AbrirVentana(FCompra)
    End Sub

    Private Sub AgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoProd.Click
        AbrirVentana(FNuevoProducto)
    End Sub

    Private Sub CambiarDeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarDeUsuarioToolStripMenuItem.Click
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub ListaDeHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirVentana(FListaHabitacion2)
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirVentana(FAjustesTolerancia)
    End Sub

    Private Sub ReportesToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        AbrirVentana(FReporteHabitacion)
    End Sub

    Private Sub ServiciosDeHabitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirVentana(FAjustesTiempo)
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarVenta.Click
        Dim frm As New FListaVenta(Reporte.Tipo.Venta)
        AbrirVentana(frm)
    End Sub

    Private Sub ComisionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comisiones.Click
        AbrirVentana(FComision)
    End Sub

    Private Sub NuevoEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoEmple.Click
        AbrirVentana(FNuevoEmple)
    End Sub

    Private Sub ACobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCobrar.Click
        AbrirVentana(FCuentasCobrar)
    End Sub

    Private Sub ReportesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaCompras.Click
        Dim frm As New FListaCompra(Reporte.Tipo.Compra)
        AbrirVentana(frm)
    End Sub

    Private Sub APagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaPagar.Click
        AbrirVentana(FCuentasPagar)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaCredito.Click
        Dim frm As New FListaVenta(Reporte.Tipo.NotaCredVenta)
        AbrirVentana(frm)
    End Sub

    Private Sub DevolverStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolverStock.Click
        Dim frm As New FListaCompra(Reporte.Tipo.NotaCredCompra)
        AbrirVentana(frm)
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoProv.Click
        AbrirVentana(FNuevoProveed)
    End Sub

    Private Sub BalanceDiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirVentana(FBalance)
    End Sub

    Private Sub ListaEmple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaEmple.Click
        AbrirVentana(FListaEmple)
    End Sub

    Private Sub ListaProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaProv.Click
        Dim Frm As New FListaProveedores
        Frm.pnlEditar.Visible = ProvEditValue
        Frm.PnlEliminar.Visible = ProvDeleteValue
        Frm.BtnNuevo.Visible = ProvNuevoValue
        AbrirVentana(Frm)
    End Sub

    Private Sub ListaBajaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaBajaDeProductosToolStripMenuItem.Click
        AbrirVentana(FListaBajaProd)
    End Sub

    Private Sub ListaAltaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaAltaDeProductosToolStripMenuItem.Click
        AbrirVentana(FListaAltaProd)
    End Sub

    Private Sub AbrirCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaToolStripMenuItem.Click
        If Caja.CajaAbierta(NumCaja) = False Then
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            AbrirVentana(Frm)
        Else
            MessageBox.Show("La caja ya está abierta")
        End If
    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            Frm.ModoAbrir = False
            AbrirVentana(Frm)
        Else
            MessageBox.Show("La caja ya está cerrada")
        End If
    End Sub

    Private Sub HistorialDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeCajaToolStripMenuItem.Click
        Dim Frm As New FListaCajas 
        Frm.CIEmpleado = CI
        AbrirVentana(Frm)
    End Sub

    Private Sub AbrirVentana(ByVal Formulario As Form)
        Cursor.Current = Cursors.WaitCursor
        Formulario.MdiParent = Me
        Formulario.Show()
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click, pbxSalir.Click, lblSalir.Click, pnlSalir.Click
        End
    End Sub

    Private Sub BtnMinimizar_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlProd.MouseLeave, pnlCompra.MouseLeave, pnlSalir.MouseLeave
        Dim Pnl As Panel = CType(sender, Panel)
        Pnl.BackColor = Color.FromArgb(70, 90, 125)
    End Sub

    Private Sub Panel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlProd.MouseMove, pnlCompra.MouseMove, pnlVenta.MouseMove
        Dim Pnl As Panel = CType(sender, Panel)
        pnlProd.BackColor = Color.FromArgb(70, 90, 125)
        pnlCompra.BackColor = Color.FromArgb(70, 90, 125)
        pnlVenta.BackColor = Color.FromArgb(70, 90, 125)
        Pnl.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub LblProd_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblProd.MouseMove, pbxProd.MouseMove, lblProd.MouseMove
        pnlProd.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub LblCompra_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblCompra.MouseMove, pbxCompras.MouseMove, lblCompra.MouseMove
        pnlCompra.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub Panel6_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlSalir.MouseMove, lblSalir.MouseMove, pbxSalir.MouseMove
        pnlSalir.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub PnlVenta_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlVenta.MouseMove, lblVenta.MouseMove, pbxVenta.MouseMove
        pnlVenta.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub TmrFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFecha.Tick
        lblDateTime.Text = Format(Now, "dd/MM/yyyy  -  HH:mm:ss")
    End Sub

    Private Sub RecibosDeDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosDeDinero.Click
        Dim frm As New FListaRecivos
        frm.ModoVenta = True
        AbrirVentana(frm)
    End Sub

    Private Sub PagosRealizadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosRealizadosToolStripMenuItem.Click
        Dim frm As New FListaRecivos
        frm.ModoVenta = False
        AbrirVentana(frm)
    End Sub

    Private Sub ConsultarClentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarClentesToolStripMenuItem.Click
        AbrirVentana(FListaClientes)
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        AbrirVentana(FNuevoCliente)
    End Sub

    Private Sub BalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceToolStripMenuItem.Click
        AbrirVentana(FBalance)
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsu.Click
        Dim frm As New FListaEmple
        frm.ModoNuevoUsu = True
        AbrirVentana(frm)
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarUsu.Click
        AbrirVentana(FListaUsuarios)
    End Sub

    Private Sub AgregarNuevoNivelDePrivilegiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Click
        AbrirVentana(FNuevoPrivilegio)
    End Sub

    Private Sub ConsultarNivelDePrivilegiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarNivelDePrivilegiosToolStripMenuItem.Click
        AbrirVentana(FListaPrivilegios)
    End Sub

    Private Sub GastosGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosGeneralesToolStripMenuItem.Click
        AbrirVentana(FGasto)
    End Sub

    Private Sub ListaDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeGastosToolStripMenuItem.Click
        AbrirVentana(FListaGastos)
    End Sub

    Private Sub DetalleDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeCajaToolStripMenuItem.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FResumenCaja
            Frm.CIEmpleado = CI
            Frm.Show()
        Else
            MessageBox.Show("Seleccione una Caja del Historial para ver su Resumen")
            Dim Frm As New FListaCajas
            Frm.CIEmpleado = CI
            AbrirVentana(Frm)
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Frm As New FAcercaDe
        Frm.ShowDialog()
    End Sub

End Class