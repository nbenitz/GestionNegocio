Option Strict On
Option Explicit On

Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class FPrincipal
    Dim FrmEventoAcceso As New FEventoAcceso
    Dim Caja As New CCaja
    Dim NumCaja As UInt16 = 1
    Dim CI As String

    Dim ProdEditValue As Boolean
    Dim ProvEditValue As Boolean
    Dim ProdDeleteValue As Boolean
    Dim ProvDeleteValue As Boolean
    Dim ProdNuevoValue As Boolean
    Dim ProvNuevoValue As Boolean

    Dim ColorOscuro As Color = Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
    Dim ColorNormal As Color = Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))

    Dim Retraido As Boolean = False

    Sub New(ByVal CIValue As String)
        InitializeComponent()
        'LblUsuario.Text = "Bienvenido: " & user
        CI = CIValue
        Dim Emple As New CEmpleado
        Dim TablaEmple As DataTable = Emple.CargarEmple(CIValue)
        lblEmpleado.Text = CStr(TablaEmple.Rows(0).Item(1)) + " " + CStr(TablaEmple.Rows(0).Item(2))
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
                           ByVal DevolAutoriProv As Boolean,
                           ByVal MembresiaAdmin As Boolean,
                           ByVal AccesoAdmin As Boolean)

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
        mnuCaja.Visible = VentasReg
        ConsultarVenta.Visible = VentasConsult
        RecibirStock.Visible = ComprasReg
        pnlCompra.Visible = ComprasReg
        ListaCompras.Visible = ComprasConsult
        mnuCompras.Visible = ComprasConsult And ComprasReg And DevolAutoriProv And CuentasAdmin
        NuevoProv.Visible = ProvReg
        ListaProv.Visible = ProvConsult
        mnuProveed.Visible = ProdReg And ProvConsult
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
        mnuCategoria.Visible = ProdEdit
        mnuMembresia.Visible = MembresiaAdmin
        mnuAcceso.Visible = AccesoAdmin
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEventoAcceso()

        'pbxLogo.Location = New Point(CInt((pnlPrincipal.Width - pbxLogo.Width) / 2),
        'CInt((pnlPrincipal.Height - pbxLogo.Height) / 2))

        'pbxLogo.Image.Dispose()
        'pbxLogo.Image = ChangeOpacity(My.Resources.Logo, 0.3)

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

    Private Sub LoadEventoAcceso()
        Cursor.Current = Cursors.WaitCursor

        FrmEventoAcceso.TopLevel = False
        FrmEventoAcceso.FormBorderStyle = FormBorderStyle.None
        FrmEventoAcceso.Dock = DockStyle.Fill
        pnlRight.Width = FrmEventoAcceso.Width
        'pnlEvento.Width = FrmEventoAcceso.Width
        pnlEvento.Controls.Add(FrmEventoAcceso)
        pnlEvento.Tag = FrmEventoAcceso
        FrmEventoAcceso.Show()
        'frm.BringToFront()
        'FrmEventoAcceso.init()
    End Sub

    Private Sub BtnBusqueda_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ConsultaProd.Click, lblProd.Click, pbxProd.Click, pnlProd.Click
        Dim Frm As New FListaProd
        Frm.pnlEditar.Visible = ProdEditValue
        Frm.PnlEliminar.Visible = ProdDeleteValue
        Frm.TbtnNuevo.Visible = ProdNuevoValue
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub BtnFactura_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NuevaVenta.Click, pnlVenta.Click, lblVenta.Click, pbxVenta.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim FrmVenta As New FVentaGym
            FrmVenta.CIEmpleado = CI
            FrmVenta.lblHab.Visible = False
            FrmVenta.lblHab2.Visible = False
            FrmVenta.LblTituloHab.Visible = False
            FrmVenta.ModoMotel = False
            FrmVenta.CargarAccesoRapido()
            AbrirFormEnPanel(FrmVenta)
        Else
            MessageBox.Show("Debe abrir la Caja antes de realizar una Venta")
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub BtnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCompra.Click, pbxCompras.Click, pnlCompra.Click, RecibirStock.Click
        Dim Frm As New FCompra
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub Molinete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCerradura.Click, pbxCerradura.Click, pnlCerradura.Click
        Dim Frm As New FListaSocio
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub AgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoProd.Click
        Dim Frm As New FNuevoProducto
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub CambiarDeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarDeUsuarioToolStripMenuItem.Click
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub ListaDeHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(FListaHabitacion2)
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(FAjustesTolerancia)
    End Sub

    Private Sub ReportesToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        AbrirFormEnPanel(FReporteHabitacion)
    End Sub

    Private Sub ServiciosDeHabitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(FAjustesTiempo)
    End Sub

    Private Sub ConsultarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarVenta.Click
        Dim Frm As New FListaVenta()
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub ComisionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comisiones.Click
        AbrirFormEnPanel(FComision)
    End Sub

    Private Sub NuevoEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoEmple.Click
        Dim Frm As New FEmpleado
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub ACobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCobrar.Click
        Dim Frm As New FCuentasCobrar
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub ReportesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaCompras.Click
        Dim frm As New FListaCompra()
        AbrirFormEnPanel(frm)
    End Sub

    Private Sub APagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaPagar.Click
        AbrirFormEnPanel(FCuentasPagar)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaCredito.Click
        Dim frm As New FListaVenta()
        frm.ModoNotaCredito()
        AbrirFormEnPanel(frm)
    End Sub

    Private Sub DevolverStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolverStock.Click
        Dim frm As New FListaCompra()
        frm.ModoNotaCredito()
        AbrirFormEnPanel(frm)
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoProv.Click
        AbrirFormEnPanel(FNuevoProveed)
    End Sub

    Private Sub BalanceDiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormEnPanel(FBalance)
    End Sub

    Private Sub ListaEmple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaEmple.Click
        AbrirFormEnPanel(FListaEmple)
    End Sub

    Private Sub ListaProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaProv.Click
        Dim Frm As New FListaProveedores
        Frm.pnlEditar.Visible = ProvEditValue
        Frm.PnlEliminar.Visible = ProvDeleteValue
        Frm.BtnNuevo.Visible = ProvNuevoValue
        'AbrirFormEnPanel( Frm)
    End Sub

    Private Sub ListaBajaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaBajaDeProductosToolStripMenuItem.Click
        AbrirFormEnPanel(FListaBajaProd)
    End Sub

    Private Sub ListaAltaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaAltaDeProductosToolStripMenuItem.Click
        AbrirFormEnPanel(FListaAltaProd)
    End Sub

    Private Sub AbrirCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaToolStripMenuItem.Click
        If Caja.CajaAbierta(NumCaja) = False Then
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            'AbrirFormEnPanel( Frm)
        Else
            MessageBox.Show("La caja ya está abierta")
        End If
    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            Frm.ModoAbrir = False
            AbrirFormEnPanel(Frm)
        Else
            MessageBox.Show("La caja ya está cerrada")
        End If
    End Sub

    Private Sub HistorialDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeCajaToolStripMenuItem.Click
        Dim Frm As New FListaCajas
        Frm.CIEmpleado = CI
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub AbrirFormEnPanel(ByVal FrmNuevo As Form)
        Dim FrmViejo As Form
        Dim FormExiste As Boolean = False
        For Each form As Form In pnlPrincipal.Controls.OfType(Of Form)()
            If (FrmNuevo.Name.Equals(form.Name)) Then
                FrmViejo = form
                FormExiste = True
            Else
                form.Hide()
            End If
        Next

        If Not FormExiste Then      'Si form no fue econtrado/ no existe
            FrmNuevo.TopLevel = False
            FrmNuevo.FormBorderStyle = FormBorderStyle.None
            If FrmNuevo.Width > (pnlPrincipal.Width - 10) Then
                OcultarPnlRight()
            End If
            FrmNuevo.Location = New Point(CInt((pnlPrincipal.Width - FrmNuevo.Width) / 2),
                                     CInt((pnlPrincipal.Height - FrmNuevo.Height) / 2))
            'Formulario.Dock = DockStyle.Fill
            pnlPrincipal.Controls.Add(FrmNuevo)
            pnlPrincipal.Tag = FrmNuevo
            'AddHandler FrmNuevo.FormClosed, AddressOf Me.CerrarFormulario
            FrmNuevo.Show()
            FrmNuevo.BringToFront()
        Else
            FrmViejo.Show()
            FrmViejo.BringToFront()
        End If

    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        'If (Application.OpenForms("Form1") Is Nothing) Then
        'Button1.BackColor = Color.FromArgb(4, 41, 68)
        'End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Panel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlProd.MouseLeave, pnlCompra.MouseLeave, pnlCerradura.MouseLeave
        Dim Pnl As Panel = CType(sender, Panel)
        Pnl.BackColor = ColorOscuro
    End Sub

    Private Sub Panel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlProd.MouseMove, pnlCompra.MouseMove, pnlVenta.MouseMove, pnlCerradura.MouseMove
        Dim Pnl As Panel = CType(sender, Panel)
        pnlProd.BackColor = ColorOscuro
        pnlCompra.BackColor = ColorOscuro
        pnlVenta.BackColor = ColorOscuro
        pnlCerradura.BackColor = ColorOscuro
        Pnl.BackColor = ColorNormal
    End Sub

    Private Sub LblProd_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblProd.MouseMove, pbxProd.MouseMove, lblProd.MouseMove
        pnlProd.BackColor = ColorNormal
    End Sub

    Private Sub LblCompra_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblCompra.MouseMove, pbxCompras.MouseMove, lblCompra.MouseMove
        pnlCompra.BackColor = ColorNormal
    End Sub

    Private Sub PnlVenta_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlVenta.MouseMove, lblVenta.MouseMove, pbxVenta.MouseMove
        pnlVenta.BackColor = ColorNormal
    End Sub

    Private Sub PnlCerradura_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlCerradura.MouseMove, lblCerradura.MouseMove, pbxCerradura.MouseMove
        pnlCerradura.BackColor = ColorNormal
    End Sub



    Private Sub TmrFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFecha.Tick
        lblHora.Text = Format(Now, "dd/MM/yyyy - HH:mm")
    End Sub

    Private Sub RecibosDeDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosDeDinero.Click
        Dim frm As New FListaRecivos
        frm.ModoVenta = True
        AbrirFormEnPanel(frm)
    End Sub

    Private Sub PagosRealizadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosRealizadosToolStripMenuItem.Click
        Dim frm As New FListaRecivos
        frm.ModoVenta = False
        AbrirFormEnPanel(frm)
    End Sub

    Private Sub ConsultarClentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConsultarClentes.Click
        AbrirFormEnPanel(FListaSocio)
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNuevoCliente.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FNuevoSocio
            AbrirFormEnPanel(Frm)
        Else
            MessageBox.Show("Debe abrir la Caja para poder cobrar una membresía a un socio")
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CI
            Frm.ShowDialog()
        End If
    End Sub

    Private Sub BalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceToolStripMenuItem.Click
        AbrirFormEnPanel(FBalance)
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsu.Click
        Dim frm As New FListaEmple
        frm.ModoNuevoUsu = True
        AbrirFormEnPanel(frm)
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarUsu.Click
        AbrirFormEnPanel(FListaUsuarios)
    End Sub

    Private Sub AgregarNuevoNivelDePrivilegiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoNivelDePrivilegiosToolStripMenuItem.Click
        AbrirFormEnPanel(FNuevoPrivilegioGym)
    End Sub

    Private Sub ConsultarNivelDePrivilegiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarNivelDePrivilegiosToolStripMenuItem.Click
        AbrirFormEnPanel(FListaPrivilegios)
    End Sub

    Private Sub GastosGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosGeneralesToolStripMenuItem.Click
        AbrirFormEnPanel(FGasto)
    End Sub

    Private Sub ListaDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeGastosToolStripMenuItem.Click
        AbrirFormEnPanel(FListaGastos)
    End Sub

    Private Sub DetalleDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeCajaToolStripMenuItem.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FResumenCaja
            Frm.CIEmpleado = CI
            AbrirFormEnPanel(Frm)
        Else
            MessageBox.Show("Seleccione una Caja del Historial para ver su Resumen")
            Dim Frm As New FListaCajas
            Frm.CIEmpleado = CI
            AbrirFormEnPanel(Frm)
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Frm As New FAcercaDe
        Frm.ShowDialog()
    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCategoria.Click
        AbrirFormEnPanel(FListaCategoriaProd)
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        End
    End Sub

    Private Sub pbxRetraer_Click(sender As Object, e As EventArgs) Handles pbxRetraer.Click
        If Retraido Then
            MostrarPnlRight()
        Else
            OcultarPnlRight()
        End If
    End Sub

    Private Sub OcultarPnlRight()
        If Not Retraido Then
            Retraido = True
            pnlRight.Width = 35
            pbxRetraer.Image = My.Resources.left_arrow
            FrmEventoAcceso.Hide()
        End If
    End Sub

    Private Sub MostrarPnlRight()
        If Retraido Then
            Retraido = False
            pnlRight.Width = 404
            pbxRetraer.Image = My.Resources.right_arrow
            FrmEventoAcceso.Show()
        End If
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click
        Dim Frm As New FAsistencia
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub mnuAccesoAjustes_Click(sender As Object, e As EventArgs) Handles mnuAccesoAjustes.Click
        Dim Frm As New FAjustesAcceso
        AbrirFormEnPanel(Frm)
    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ListaDeMembresíasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuListaMembresia.Click
        AbrirFormEnPanel(FListaMembresia)
    End Sub

    Private Sub NuevaMembresíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNuevaMembresia.Click
        AbrirFormEnPanel(FNuevoMembresia)
    End Sub

    Private Sub ContratosDeMembresíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosDeMembresíaToolStripMenuItem.Click
        Dim Frm As New FListaMembresiaContrato
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub SociosConDeudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SociosConDeudaToolStripMenuItem.Click
        Dim Frm As New FCuentasCobrar
        AbrirFormEnPanel(Frm)
    End Sub

    Private Sub AsistenciaDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAsistenciaSocio.Click
        Dim Frm As New FAsistencia
        AbrirFormEnPanel(Frm)
    End Sub

End Class