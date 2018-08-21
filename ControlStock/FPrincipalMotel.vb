Option Strict On

Public Class FPrincipalMotel
    Dim CI As String
    Dim ObjHabitacion As New CHabitacion
    Dim ModoHab As UInt16 = 2
    Private Const CANT_HABS As Integer = 10
    Private CampoHabEvents As HabEvents = New HabEvents()

    Dim ProdEditValue As Boolean
    Dim ProvEditValue As Boolean
    Dim ProdDeleteValue As Boolean
    Dim ProvDeleteValue As Boolean
    Dim ProdNuevoValue As Boolean
    Dim ProvNuevoValue As Boolean

    WithEvents frmVenta1 As New FVenta
    WithEvents frmVenta2 As New FVenta
    WithEvents frmVenta3 As New FVenta
    WithEvents frmVenta4 As New FVenta
    WithEvents frmVenta5 As New FVenta
    WithEvents frmVenta6 As New FVenta
    WithEvents frmVenta7 As New FVenta
    WithEvents frmVenta8 As New FVenta
    WithEvents frmVenta9 As New FVenta
    WithEvents frmVenta10 As New FVenta

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
        'NuevaVenta.Visible = VentasReg
        'pnlVenta.Visible = VentasReg
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
        HabitacionesToolStripMenuItem.Visible = HabAdmin
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

        frmVenta1.CIEmpleado = CI
        frmVenta2.CIEmpleado = CI
        frmVenta3.CIEmpleado = CI
        frmVenta4.CIEmpleado = CI
        frmVenta5.CIEmpleado = CI
        frmVenta6.CIEmpleado = CI
        frmVenta7.CIEmpleado = CI
        frmVenta8.CIEmpleado = CI
        frmVenta9.CIEmpleado = CI
        frmVenta10.CIEmpleado = CI
        frmVenta1.HabitacionNro = 1
        frmVenta2.HabitacionNro = 2
        frmVenta3.HabitacionNro = 3
        frmVenta4.HabitacionNro = 4
        frmVenta5.HabitacionNro = 5
        frmVenta6.HabitacionNro = 6
        frmVenta7.HabitacionNro = 7
        frmVenta8.HabitacionNro = 8
        frmVenta9.HabitacionNro = 9
        frmVenta10.HabitacionNro = 10
        frmVenta1.WindowState = FormWindowState.Minimized
        frmVenta2.WindowState = FormWindowState.Minimized
        frmVenta2.WindowState = FormWindowState.Minimized
        frmVenta3.WindowState = FormWindowState.Minimized
        frmVenta4.WindowState = FormWindowState.Minimized
        frmVenta5.WindowState = FormWindowState.Minimized
        frmVenta6.WindowState = FormWindowState.Minimized
        frmVenta7.WindowState = FormWindowState.Minimized
        frmVenta8.WindowState = FormWindowState.Minimized
        frmVenta10.WindowState = FormWindowState.Minimized

        CheckOcupSinSalida()
    End Sub

    Private Sub BtnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaProd.Click, lblProd.Click, pbxProd.Click, pnlProd.Click
        Dim Frm As New FListaProd
        Frm.pnlEditar.Visible = ProdEditValue
        Frm.PnlEliminar.Visible = ProdDeleteValue
        Frm.TbtnNuevo.Visible = ProdNuevoValue
        AbrirVentana(Frm)
    End Sub

    'Private Sub BtnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaVenta.Click
    'Dim frm As New FVenta
    '    frm.CIEmpleado = CI
    '    AbrirVentana(frm)
    'End Sub

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

    Private Sub ListaDeHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeHabitacionesToolStripMenuItem.Click
        AbrirVentana(FListaHabitacion2)
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        AbrirVentana(FAjustesTolerancia)
    End Sub

    Private Sub ReportesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        AbrirVentana(FReporteHabitacion)
    End Sub

    Private Sub ServiciosDeHabitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosDeHabitaciónToolStripMenuItem.Click
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

    Private Sub AbrirVentana(ByVal Formulario As Form)
        Cursor.Current = Cursors.WaitCursor
        Formulario.MdiParent = Me
        Formulario.Show()
        Formulario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click, pbxSalir.Click, lblSalir.Click, pnlSalir.Click
        End
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlProd.MouseLeave, pnlCompra.MouseLeave, pnlSalir.MouseLeave
        Dim Pnl As Panel = CType(sender, Panel)
        Pnl.BackColor = Color.FromArgb(70, 90, 125)
    End Sub

    Private Sub Panel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlProd.MouseMove, pnlCompra.MouseMove
        Dim Pnl As Panel = CType(sender, Panel)
        pnlProd.BackColor = Color.FromArgb(70, 90, 125)
        pnlCompra.BackColor = Color.FromArgb(70, 90, 125)
        Pnl.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub lblProd_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblProd.MouseMove, pbxProd.MouseMove
        pnlProd.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub lblCompra_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblCompra.MouseMove, pbxCompras.MouseMove
        pnlCompra.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    Private Sub Panel6_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlSalir.MouseMove, lblSalir.MouseMove, pbxSalir.MouseMove
        pnlSalir.BackColor = Color.FromArgb(82, 119, 169)
    End Sub

    ''Private Sub TmrFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFecha.Tick
    ''lblDateTime.Text = Format(Now, "dd/MM/yyyy  -  HH:mm:ss")
    ''End Sub

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

    Private Sub Habitacion1_Factura(sender As Object, e As HabEvents) Handles Habitacion1.FacturaClick, Habitacion2.FacturaClick, Habitacion3.FacturaClick, Habitacion4.FacturaClick, Habitacion5.FacturaClick, Habitacion6.FacturaClick, Habitacion7.FacturaClick, Habitacion8.FacturaClick, Habitacion9.FacturaClick, Habitacion10.FacturaClick
        Dim HabNro As Integer = e.Habitacion
        Dim Frm As FVenta = GetForm(HabNro)
        OcultarFrmVenta()
        AbrirVentana(Frm)
    End Sub

    Private Sub OcultarFrmVenta()
        frmVenta1.Hide()
        frmVenta2.Hide()
        frmVenta3.Hide()
        frmVenta4.Hide()
        frmVenta5.Hide()
        frmVenta6.Hide()
        frmVenta7.Hide()
        frmVenta8.Hide()
        frmVenta9.Hide()
        frmVenta10.Hide()
    End Sub

    Private Sub frmVenta_Facturado(sender As Object, e As HabEvents) Handles frmVenta1.Facturado, frmVenta2.Facturado, frmVenta3.Facturado, frmVenta4.Facturado, frmVenta5.Facturado, frmVenta6.Facturado, frmVenta7.Facturado, frmVenta8.Facturado, frmVenta9.Facturado, frmVenta10.Facturado
        Dim NroHab As Integer = e.Habitacion
        Select Case NroHab
            Case Is = 1
                Habitacion1.Ocupado = False
            Case Is = 2
                Habitacion2.Ocupado = False
            Case Is = 3
                Habitacion3.Ocupado = False
            Case Is = 4
                Habitacion4.Ocupado = False
            Case Is = 5
                Habitacion5.Ocupado = False
            Case Is = 6
                Habitacion6.Ocupado = False
            Case Is = 7
                Habitacion7.Ocupado = False
            Case Is = 8
                Habitacion8.Ocupado = False
            Case Is = 9
                Habitacion9.Ocupado = False
            Case Is = 10
                Habitacion10.Ocupado = False
        End Select
        If e.IdVenta > 0 Then
            If ObjHabitacion.RegistrarSalida(NroHab, e.IdVenta) = False Then
                MessageBox.Show("Hubo un problema al registrar la hora de salida")
            End If
        Else
            If ObjHabitacion.RegistrarSalida(NroHab) = False Then
                MessageBox.Show("Hubo un problema al registrar la hora de salida")
            End If
        End If
    End Sub

    Private Sub Habitacion_OcuparClick(sender As Object, e As HabEvents) Handles Habitacion1.OcuparClick, Habitacion2.OcuparClick, Habitacion3.OcuparClick, Habitacion4.OcuparClick, Habitacion5.OcuparClick, Habitacion6.OcuparClick, Habitacion7.OcuparClick, Habitacion8.OcuparClick, Habitacion9.OcuparClick, Habitacion10.OcuparClick
        If ObjHabitacion.RegistrarEntrada(e.Habitacion) = False Then
            MessageBox.Show("Hubo un problema al registrar la hora de entrada")
        End If
    End Sub

    Private Sub Habitacion1_ToleranciaTick(sender As Object, e As HabEvents) Handles Habitacion1.ToleranciaTick, Habitacion2.ToleranciaTick, Habitacion3.ToleranciaTick, Habitacion4.ToleranciaTick, Habitacion5.ToleranciaTick, Habitacion6.ToleranciaTick, Habitacion7.ToleranciaTick, Habitacion8.ToleranciaTick, Habitacion9.ToleranciaTick, Habitacion10.ToleranciaTick
        Dim ObjHab As Habitacion = CType(sender, Habitacion)
        Dim HabNro As Integer = e.Habitacion
        Dim frm As FVenta = frmVenta1
        Dim Delete As Image = My.Resources.Resources.button_cancel
        'Dim Descrip As String = CStr(TablaHab.Rows(HabNro - 1).Item(2))    ' Descripcion de la Habitación
        'Dim Precio As UInt32 = CUInt(TablaHab.Rows(HabNro - 1).Item(3))    ' Precio de la Habitación
        OcultarFrmVenta()
        Select Case HabNro
            Case Is = 1
                frm = frmVenta1
            Case Is = 2
                frm = frmVenta2
            Case Is = 3
                frm = frmVenta3
            Case Is = 4
                frm = frmVenta4
            Case Is = 5
                frm = frmVenta5
            Case Is = 6
                frm = frmVenta6
            Case Is = 7
                frm = frmVenta7
            Case Is = 8
                frm = frmVenta8
            Case Is = 9
                frm = frmVenta9
            Case Is = 10
                frm = frmVenta10
        End Select
        'Dim Tiempo As String = Strings.Left(ObjHab.Tiempo, Len(ObjHab.Tiempo) - 3)
        AbrirVentana(frm)
        'frm.DataGridView1.Rows.Add(Delete, HabNro, Descrip, Tiempo, Precio, 50000, 0, 1, "Habitación")
        frm.tmrTotal.Enabled = True
    End Sub

    Private Sub Habitacion1_Tick(sender As Object, e As HabEvents) Handles Habitacion1.Tick, Habitacion2.Tick, Habitacion3.Tick, Habitacion4.Tick, Habitacion5.Tick, Habitacion6.Tick, Habitacion7.Tick, Habitacion8.Tick, Habitacion9.Tick, Habitacion10.Tick
        Dim HabNro As Integer = e.Habitacion
        Dim Frm As FVenta = GetForm(HabNro)
        If PorNocheAdded(Frm) = False Then
            Dim CtrHab As Habitacion = CType(sender, Habitacion)
            Dim ServHab As UInt16
            Dim Tiempo As TimeSpan = CtrHab.Tiempo
            Dim Cantidad As Integer = 1

            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))
            If Tiempo.TotalMinutes <= TiempoNormal Then
                ServHab = 1
            Else
                ServHab = 2
                Tiempo = Tiempo.Subtract(TimeSpan.FromMinutes(TiempoNormal))
                TablaServ = ObjHabitacion.BuscarServ(2)
                Dim TiempoExceso As UInt32 = CUInt(TablaServ.Rows(0).Item(2))
                Cantidad = CInt(CInt(Tiempo.TotalMinutes) \ TiempoExceso)
                If (Tiempo.Minutes Mod TiempoExceso) > 0 Then
                    Cantidad += 1
                End If
            End If

            Dim Precio As Integer = GetPrecio(HabNro, ServHab)
            Dim Importe As Integer = Precio * Cantidad
            Dim Indice As Integer = Me.Indice(ServHab, Frm)
            If Indice < 0 Then 'Si aun no se ingreso, hecer
                AddToFactura(ServHab, GetDescrip(HabNro, ServHab), Tiempo.ToString("hh\:mm"), Precio, Importe, Frm)
            Else 'Sino, hecer
                Frm.DataGridView1.Rows.RemoveAt(Indice)
                Frm.DataGridView1.Rows.Insert(Indice, Nothing, ServHab, GetDescrip(HabNro, ServHab), Tiempo.ToString("hh\:mm"), Precio, Importe, 0, 1, "Habitación")
                Frm.tmrTotal.Enabled = True
            End If
        End If
    End Sub

    Private Sub Habitacion1_PorNocheClick(sender As Object, e As HabEvents) Handles Habitacion1.PorNocheClick, Habitacion2.PorNocheClick, Habitacion3.PorNocheClick, Habitacion4.PorNocheClick, Habitacion5.PorNocheClick, Habitacion6.PorNocheClick, Habitacion7.PorNocheClick, Habitacion8.PorNocheClick, Habitacion9.PorNocheClick, Habitacion10.PorNocheClick
        Dim CtrHab As Habitacion = CType(sender, Habitacion)
        Dim HabNro As Integer = e.Habitacion
        Dim Frm As FVenta = GetForm(HabNro)
        Dim ServHab As UInt16 = 3
        Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(ServHab)
        Dim HraEntrada As TimeSpan = CType(TablaServ.Rows(0).Item(3), TimeSpan)
        'Dim HraSalida As String = CStr(TablaServ.Rows(0).Item(4))
        Dim Precio = GetPrecio(HabNro, ServHab)
        Dim Tiempo As New TimeSpan(Now.Hour, Now.Minute, Now.Second)

        If Tiempo >= HraEntrada Then
            If Indice(ServHab, Frm) < 0 Then 'Si aun no se ingreso, hecer
                AddToFactura(ServHab, GetDescrip(HabNro, ServHab), "1", Precio, Precio, Frm)
            Else 'Sino, hecer
                MessageBox.Show("Ya se ha agregado previamente a la factura ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("La Tarifa por Noche solo se permite a partir de las " + HraEntrada.ToString("hh\:mm") +
                            " hs.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AddToFactura(ByVal HabNro As Integer, ByVal Descrip As String, ByVal Tiempo As String,
                               ByVal Precio As Integer, ByVal Importe As Integer, ByVal Frm As FVenta)
        OcultarFrmVenta()
        AbrirVentana(Frm)
        Frm.DataGridView1.Rows.Add(Nothing, HabNro, Descrip, Tiempo, Precio, Importe, 0, 1, "Habitación")
        Frm.tmrTotal.Enabled = True
    End Sub

    Private Function GetDescrip(ByVal HabNro As Integer, ByVal ServHab As UInt16) As String
        If ModoHab = 1 Then
            Dim TablaHab = ObjHabitacion.BuscarHab(HabNro, ServHab)
            GetDescrip = CStr(TablaHab.Rows(0).Item(2))
        Else
            Dim TipoTarifa As String = ObjHabitacion.GetDescrip(ServHab)
            GetDescrip = "Habitación" + CStr(HabNro) + " " + TipoTarifa
        End If
    End Function

    Private Function GetPrecio(ByVal HabNro As Integer, ByVal ServHab As Integer) As Integer
        If ModoHab = 1 Then
            Dim TablaHab = ObjHabitacion.BuscarHab(HabNro, ServHab)
            GetPrecio = CInt(TablaHab.Rows(0).Item(3))
        Else
            Dim TablaHab = ObjHabitacion.BuscarHab(HabNro)
            GetPrecio = CInt(TablaHab.Rows(0).Item(ServHab))
        End If
    End Function

    Private Function GetForm(ByVal HabNro As Integer) As FVenta
        GetForm = frmVenta1
        Select Case HabNro
            Case Is = 1
                GetForm = frmVenta1
            Case Is = 2
                GetForm = frmVenta2
            Case Is = 3
                GetForm = frmVenta3
            Case Is = 4
                GetForm = frmVenta4
            Case Is = 5
                GetForm = frmVenta5
            Case Is = 6
                GetForm = frmVenta6
            Case Is = 7
                GetForm = frmVenta7
            Case Is = 8
                GetForm = frmVenta8
            Case Is = 9
                GetForm = frmVenta9
            Case Is = 10
                GetForm = frmVenta10
        End Select
    End Function

    Private Function Indice(ByVal ServHab As Integer, ByVal Frm As FVenta) As Integer
        Indice = -1                                                  ' Guarda el indice si se encuentra el producto, si no se encuentra, el indice es -1
        Dim ServHabAux? As UInt64                                    ' Guarda el codigo del producto o sevicio de habitación encontrado en el datagrid
        Dim ObsAux As String                                         ' Guarda la observación, por si sea una habitación
        Dim Row As Integer = Frm.DataGridView1.Rows.Count
        If Row > 0 Then
            For i = 0 To Row - 1            'Buscar en el datagrid si ya se ingreso la habitación
                ServHabAux = Convert.ToUInt64(Frm.DataGridView1.Item(1, i).Value.ToString)     ' Guardar cada codigo
                ObsAux = Convert.ToString(Frm.DataGridView1.Item(8, i).Value.ToString)       ' Guardar Observacion

                If ObsAux <> "Habitación" Then  'Si no es una habitacion
                    ServHabAux = Nothing          'Borrar Código
                End If

                If ServHabAux = ServHab Then   'Comparar el codigo encontrado con el q se quiere agregar actualmente
                    'flag = True             'activar el flag, ya existe un código igual
                    Indice = i              'guardar el IndiceProd donde se encuentra el producto
                End If
            Next
        End If
    End Function

    Private Function PorNocheAdded(ByVal Frm As FVenta) As Boolean
        PorNocheAdded = False
        Dim ServHabAux? As UInt64                                    ' Guarda el codigo del producto o sevicio de habitación encontrado en el datagrid
        Dim ObsAux As String                                         ' Guarda la observación, por si sea una habitación
        Dim Row As Integer = Frm.DataGridView1.Rows.Count
        If Row > 0 Then
            For i = 0 To Row - 1            'Buscar en el datagrid si ya se ingreso la habitación
                ServHabAux = Convert.ToUInt64(Frm.DataGridView1.Item(1, i).Value.ToString)     ' Guardar cada codigo
                ObsAux = Convert.ToString(Frm.DataGridView1.Item(8, i).Value.ToString)       ' Guardar Observacion

                If ObsAux <> "Habitación" Then  'Si no es una habitacion
                    ServHabAux = Nothing          'Borrar Código
                End If

                If ServHabAux = 3 Then   'Comparar el codigo encontrado con el q se quiere agregar actualmente
                    PorNocheAdded = True             'activar el flag, ya existe un código igual
                End If
            Next
        End If
    End Function

    Private Sub CheckOcupSinSalida()
        Dim TablaOcup(CANT_HABS) As DataTable
        Dim Tiempo(CANT_HABS) As TimeSpan
        For i = 0 To CANT_HABS - 1
            TablaOcup(i) = ObjHabitacion.ChequearSinSalida(i + 1)
            Try
                Dim Fecha As Date = CType(TablaOcup(i).Rows(0).Item(1), Date)
                Dim Horas As Integer = CInt(DateDiff(DateInterval.Hour, Fecha, Now)) - Now.Hour
                Dim Time As New TimeSpan(Now.Hour + Horas, Now.Minute, Now.Second)
                Tiempo(i) = Time.Subtract(CType(TablaOcup(i).Rows(0).Item(0), TimeSpan))
            Catch ex As Exception
            End Try
        Next
        If TablaOcup(0).Rows.Count > 0 Then
            Habitacion1.Tiempo = Tiempo(0)
            Habitacion1.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(0) <= Time Then
                Time = Tiempo(0)
            End If
            AddToFactura(1, GetDescrip(1, 1), Time.ToString("hh\:mm"), GetPrecio(1, 1), GetPrecio(1, 1), frmVenta1)
            CampoHabEvents.Habitacion = 1
            Habitacion1_Tick(Habitacion1, CampoHabEvents)
        End If
        If TablaOcup(1).Rows.Count > 0 Then
            Habitacion2.Tiempo = Tiempo(1)
            Habitacion2.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(1) <= Time Then
                Time = Tiempo(1)
            End If
            AddToFactura(1, GetDescrip(2, 1), Time.ToString("hh\:mm"), GetPrecio(2, 1), GetPrecio(2, 1), frmVenta2)
            CampoHabEvents.Habitacion = 2
            Habitacion1_Tick(Habitacion2, CampoHabEvents)
        End If
        If TablaOcup(2).Rows.Count > 0 Then
            Habitacion3.Tiempo = Tiempo(2)
            Habitacion3.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(2) <= Time Then
                Time = Tiempo(2)
            End If
            AddToFactura(1, GetDescrip(3, 1), Time.ToString("hh\:mm"), GetPrecio(3, 1), GetPrecio(3, 1), frmVenta3)
            CampoHabEvents.Habitacion = 3
            Habitacion1_Tick(Habitacion3, CampoHabEvents)
        End If
        If TablaOcup(3).Rows.Count > 0 Then
            Habitacion4.Tiempo = Tiempo(3)
            Habitacion4.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(3) <= Time Then
                Time = Tiempo(3)
            End If
            AddToFactura(1, GetDescrip(4, 1), Time.ToString("hh\:mm"), GetPrecio(4, 1), GetPrecio(4, 1), frmVenta4)
            CampoHabEvents.Habitacion = 4
            Habitacion1_Tick(Habitacion4, CampoHabEvents)
        End If
        If TablaOcup(4).Rows.Count > 0 Then
            Habitacion5.Tiempo = Tiempo(4)
            Habitacion5.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(4) <= Time Then
                Time = Tiempo(4)
            End If
            AddToFactura(1, GetDescrip(5, 1), Time.ToString("hh\:mm"), GetPrecio(5, 1), GetPrecio(5, 1), frmVenta5)
            CampoHabEvents.Habitacion = 5
            Habitacion1_Tick(Habitacion5, CampoHabEvents)
        End If
        If TablaOcup(5).Rows.Count > 0 Then
            Habitacion6.Tiempo = Tiempo(5)
            Habitacion6.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(5) <= Time Then
                Time = Tiempo(5)
            End If
            AddToFactura(1, GetDescrip(6, 1), Time.ToString("hh\:mm"), GetPrecio(6, 1), GetPrecio(6, 1), frmVenta6)
            CampoHabEvents.Habitacion = 6
            Habitacion1_Tick(Habitacion6, CampoHabEvents)
        End If
        If TablaOcup(6).Rows.Count > 0 Then
            Habitacion7.Tiempo = Tiempo(6)
            Habitacion7.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(6) <= Time Then
                Time = Tiempo(6)
            End If
            AddToFactura(1, GetDescrip(7, 1), Time.ToString("hh\:mm"), GetPrecio(7, 1), GetPrecio(7, 1), frmVenta7)
            CampoHabEvents.Habitacion = 7
            Habitacion1_Tick(Habitacion7, CampoHabEvents)
        End If
        If TablaOcup(7).Rows.Count > 0 Then
            Habitacion8.Tiempo = Tiempo(7)
            Habitacion8.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(7) <= Time Then
                Time = Tiempo(7)
            End If
            AddToFactura(1, GetDescrip(8, 1), Time.ToString("hh\:mm"), GetPrecio(8, 1), GetPrecio(8, 1), frmVenta8)
            CampoHabEvents.Habitacion = 8
            Habitacion1_Tick(Habitacion8, CampoHabEvents)
        End If
        If TablaOcup(8).Rows.Count > 0 Then
            Habitacion9.Tiempo = Tiempo(8)
            Habitacion9.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(8) <= Time Then
                Time = Tiempo(8)
            End If
            AddToFactura(1, GetDescrip(9, 1), Time.ToString("hh\:mm"), GetPrecio(9, 1), GetPrecio(9, 1), frmVenta9)
            CampoHabEvents.Habitacion = 9
            Habitacion1_Tick(Habitacion9, CampoHabEvents)
        End If
        If TablaOcup(9).Rows.Count > 0 Then
            Habitacion10.Tiempo = Tiempo(9)
            Habitacion10.Ocupado = True
            Dim TablaServ As DataTable = ObjHabitacion.BuscarServ(1)
            Dim TiempoNormal As UInt32 = CUInt(TablaServ.Rows(0).Item(2))   'En minutos
            Dim Time As TimeSpan = TimeSpan.FromMinutes(TiempoNormal)       'Expresado en Formato Hora
            If Tiempo(9) <= Time Then
                Time = Tiempo(9)
            End If
            AddToFactura(1, GetDescrip(10, 1), Time.ToString("hh\:mm"), GetPrecio(10, 1), GetPrecio(10, 1), frmVenta10)
            CampoHabEvents.Habitacion = 10
            Habitacion1_Tick(Habitacion10, CampoHabEvents)
        End If
    End Sub

    Private Sub NuevaVenta_Click(sender As Object, e As EventArgs) Handles NuevaVenta.Click
        Dim Frm As New FVenta
        Frm.CIEmpleado = CI
        Frm.lblHab.Visible = False
        Frm.lblHab2.Visible = False
        Frm.LblTituloHab.Visible = False
        AbrirVentana(Frm)
    End Sub

    Private Sub NuevaCuenta_Click(sender As Object, e As EventArgs) Handles NuevaCuenta.Click

    End Sub


End Class