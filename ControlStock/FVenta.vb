Option Strict On
Public Class FVenta
    Dim Caja As New CCaja
    Dim NumCaja As UInt16 = 1

    Dim Venta As New CVenta
    Dim Empleado As New CEmpleado
    Dim Producto As New CProducto
    Dim Cliente As New CCliente
    Dim Habitacion As New CHabitacion
    Dim Proveedor As New CProveedor
    Dim Tabla As New DataTable
    Dim TablaCli As New DataTable
    Dim TablaEmple As DataTable
    Dim Param As String
    Dim CIValue As String
    Dim ModoMotelValue As Boolean = True
    Dim CICli As String = ""
    Dim Descuent As Boolean = False
    Dim Entrega? As Integer = Nothing
    Dim GridFila As Integer
    Dim Total As Integer
    Dim PorCaja, PorMetro, PorUnidad As Boolean
    WithEvents FrmCliente As New FListaClientes

    Public Event Facturado(ByVal sender As System.Object, ByVal e As HabEvents)
    Private CampoHabEvents As HabEvents = New HabEvents()

    ''Dim Minimizar As Boolean = True
    Private Sub FVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarEmple()

        Try
            Dim TablaEmple2 As DataTable = Empleado.CargarEmple(CIValue)
            cmbVendedor.SelectedText = CStr(TablaEmple2.Rows(0).Item(1)) + " " + CStr(TablaEmple2.Rows(0).Item(2))
        Catch ex As Exception
        End Try

        txtNroFac.Text = CStr(Venta.CargarNroFac())
        txtFecha.Text = Now.Date.ToShortDateString
        optCod.Checked = True
        optUnidad.Checked = True
        lblX.Visible = False
        lblUnidXpack.Visible = False
        ToolTip2.IsBalloon = True
        ClienteDefecto()
        Limpiar()
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDescrip.Items.Clear()
            cmbDescrip.Text = ""
            Param = txtBuscar.Text
            If Param <> "" Then
                '------------------------------------------------------------------------------------------------------
                If optDesc.Checked Then                                     'BUSCAR POR DESCRIPCION
                    Tabla = Producto.BuscProdDesc(Param)
                    Dim Filas As Integer = Tabla.Rows.Count
                    If Filas > 0 Then
                        For i As Integer = 0 To (Filas - 1)
                            cmbDescrip.Items.Add(Tabla.Rows(i).Item(3))
                        Next
                        cmbDescrip.Text = CStr(cmbDescrip.Items(0))
                        cmbDescrip.Focus()
                        Timer1.Enabled = True
                    End If
                    '------------------------------------------------------------------------------------------------------
                Else                                                        'BUSCAR POR CODIGO
                    Dim Cod As String = txtBuscar.Text
                    Tabla = Producto.BuscProdCod(Cod)
                    Dim Filas As Integer = Tabla.Rows.Count
                    If Filas > 0 Then
                        cmbDescrip.Items.Add(Tabla.Rows(0).Item(3))
                        cmbDescrip.Text = CStr(cmbDescrip.Items(0))
                    Else
                        MostrarMsj("El Código no existe")
                        txtBuscar.Select(0, txtBuscar.TextLength)
                    End If
                End If
            Else

            End If
        End If
    End Sub

    Sub MostrarMsj(ByVal Texto As String)
        ''Minimizar = False
        MessageBox.Show(Texto)
        ''Minimizar = True
    End Sub

    'Private Sub txtEfectivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '   If e.KeyCode = Keys.Enter Then
    '      If Val(txtEfectivo.Text) >= Val(txtTotal.Text) Then
    '         txtVuelto.Text = Val(txtEfectivo.Text) - Val(txtTotal.Text)
    '    Else
    '       MostrarMsj("El Cantidad a Pagar es mayor al Efectivo ingresado")
    '      txtEfectivo.Select(0, txtEfectivo.Text.Length)
    ' End If
    'End If
    'End Sub

    Private Sub txtBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Click
        txtBuscar.Select(0, txtBuscar.Text.Length)
    End Sub

    Private Sub txtCant_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCant.Click
        txtCant.Select(0, txtCant.Text.Length)
    End Sub

    'Private Sub txtEfectivo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '   txtEfectivo.Select(0, txtEfectivo.Text.Length)
    'End Sub

    Private Sub txtCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar.Focus()
        End If
    End Sub

    Private Sub cmbDescrip_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDescrip.DropDownClosed
        Dim Fila As Integer = cmbDescrip.SelectedIndex
        Select Case CStr(Tabla.Rows(Fila).Item(11))
            Case "Si", "SiCaja", "SiMetro"
                pnlXPack.Visible = True
                btnPack.Focus()
            Case "Piso"
                pnlPiso.Visible = True
                btnPorMetro.Focus()
        End Select

        txtCant.Focus()
        txtCant.Select(0, txtCant.Text.Length)
    End Sub

    Private Sub cmbDescrip_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDescrip.SelectedIndexChanged
        Dim Fila As Integer = cmbDescrip.SelectedIndex
        Try
            pnlCliente.Visible = False
            pnlProdInfo.Visible = True
            txtDescuent.Text = "0"
            lblX.Visible = False
            lblUnidXpack.Visible = False
            Try
                PictureBox1.Image = Nothing
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                PictureBox1.Image = ByteArrayToImage(CType(Tabla.Rows(Fila).Item(12), Byte()))
            Catch
            End Try
            lblInfoCod.Text = CStr(Tabla.Rows(Fila).Item(0))
            lblInfoDesc.Text = CStr(Tabla.Rows(Fila).Item(3))
            lblInfoStock.Text = CStr(Tabla.Rows(Fila).Item(9))

            Select Case CStr(Tabla.Rows(Fila).Item(11))
                Case "Si", "SiCaja", "SiMetro"
                    lblPrecio3.Visible = False
                    lblPrecUnidP.Visible = False
                    pnlInfoPiso.Visible = False
                    pnlPrecVenta.Visible = True
                    If optDesc.Checked Then             'Si la busqueda es por descripcion
                        'pnlVenderPor.Visible = True
                        optUnidad.Checked = True
                        optPaquete.Checked = False
                    End If
                    If CStr(Tabla.Rows(Fila).Item(11)) = "SiMetro" Then
                        lblInfoStock.Text = lblInfoStock.Text + " metros"
                    Else
                        lblInfoStock.Text = lblInfoStock.Text + " unidades"
                    End If
                    lblPrecUnit.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(5)))
                    lblPrecPack.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(8)))

                    If optCod.Checked Then
                        pnlXPack.Visible = True
                        btnPack.Focus()
                    End If
                    Select Case CStr(Tabla.Rows(Fila).Item(11))
                        Case "Si"
                            btnPack.Text = "Paquete"
                            btnUnidad.Text = "Unidad"
                            lblPrecio1.Text = "- Por Unidad:"
                            lblPrecio2.Text = "- Por Paquete:"
                        Case "SiCaja"
                            btnPack.Text = "Caja"
                            btnUnidad.Text = "Paquete"
                            lblPrecio1.Text = "- Por Paquete:"
                            lblPrecio2.Text = "- Por Caja:"
                        Case "SiMetro"
                            btnPack.Text = "Entero"
                            btnUnidad.Text = "Metro"
                            lblPrecio1.Text = "- Por Metro:"
                            lblPrecio2.Text = "- Entero:"
                    End Select
                Case "No", "Kilo"
                    pnlPrecVenta.Visible = False
                    pnlInfoPiso.Visible = False

                    lblInfoPrec.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(5)))
                    lblInfoPrec2.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(6)))

                    Select Case CStr(Tabla.Rows(Fila).Item(11))
                        Case "No"
                            lblInfoStock.Text = lblInfoStock.Text + "  Unidades"
                        Case "Kilo"
                            lblInfoStock.Text = lblInfoStock.Text + "  Kg."
                    End Select
                    If optCod.Checked Then
                        btnAgregar_Click(Me, Nothing)
                    End If
                Case "Piso"
                    Dim UnidXCaja As Integer = CInt(Tabla.Rows(Fila).Item(10))
                    Dim MxCaja As Double = CDbl(Tabla.Rows(Fila).Item(16))
                    Dim CantCajas As Double = CInt(lblInfoStock.Text) / UnidXCaja
                    Dim CantMetros As Double = CInt(lblInfoStock.Text) * MxCaja / UnidXCaja
                    CantCajas = Math.Round(CantCajas, 2, MidpointRounding.ToEven)
                    CantMetros = Math.Round(CantMetros, 2, MidpointRounding.ToEven)
                    pnlPrecVenta.Visible = True
                    lblInfoStock.Text = lblInfoStock.Text + " unid / " + CStr(CantCajas) + " Cajas / " + CStr(CantMetros) + " m"

                    lblPrecUnit.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(8)))
                    lblPrecPack.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(5)))
                    lblPrecUnidP.Text = String.Format("{0:N0}", CInt(Tabla.Rows(Fila).Item(6)))

                    lblPrecio1.Text = "- Por Caja:"
                    lblPrecio2.Text = "- Por Metro:"
                    lblPrecio3.Visible = True
                    lblPrecUnidP.Visible = True

                    lblMxCaja.Text = CStr(MxCaja)
                    lblUnidxCaja.Text = CStr(UnidXCaja)
                    pnlInfoPiso.Visible = True
                    If optCod.Checked Then
                        pnlPiso.Visible = True
                        btnPorCaja.Focus()
                    End If
            End Select

        Catch
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
        If cmbDescrip.Text.Length > 0 Then                                  ' Si se selecciono un Producto
            '---------------------------------------------------------------------------------------------------------
            Dim Delete As Image = My.Resources.button_cancel      ' Imagen delete q se agrega al datagrid
            Dim IndiceProd As Integer = cmbDescrip.SelectedIndex            ' Indice del producto seleccionado
            Dim idProd As String = CStr(Tabla.Rows(IndiceProd).Item(0))    ' Cod del Producto seleccionado
            Param = cmbDescrip.Text                                         ' Contiene la descripcion de producto
            Dim Unidades As Double = 1                                     ' Factor multiplicativo p/ ventas x Pack
            Dim Obs As String = ""
            Dim CantStock As Double = CDbl(Tabla.Rows(IndiceProd).Item(9))  ' Cantidad disponible en stock
            Dim Iva As Int16 = CShort(Tabla.Rows(IndiceProd).Item(13))
            Dim Cant As Double                                             ' Contendra la cantidad a agregar
            Cant = CDbl(txtCant.Text)
            Dim UnidMedida As String = ""
            Dim Desc As Integer = CargarDescuanto()
            Dim PrecioVenta As Integer = CargarPrecio(IndiceProd)
            '--------------------------------------------------------------------------------------------------------
            Dim flag As Boolean = False                         ' Para saber si ya se ingreso el producto en el datagrid
            Dim Indice As Integer                               ' Guarda el indice si se encuentra el producto
            Dim idProdAux As String                            ' Guarda el codigo del producto encontrado en el datagrid
            Dim ObsAux As String                                ' Guarda la observación, por si sea una habitación
            Dim CantAux As Double                               ' Guarda la cant del producto encontrado en el datagrid
            Dim Row As Integer = DataGridView1.Rows.Count
            If Row > 0 Then
                For i As Integer = 0 To Row - 1            'Buscar en el datagrid si ya se ingreso el producto
                    idProdAux = Convert.ToString(DataGridView1.Item(1, i).Value.ToString)    ' Guardar cada codigo
                    ObsAux = Convert.ToString(DataGridView1.Item(8, i).Value.ToString)       ' Guardar Observacion
                    If ObsAux = "Habitación" Then
                        idProdAux = Nothing
                    End If
                    If idProdAux = idProd Then  'Comparar el codigo encontrado con el q se quiere agregar actualmente
                        CantAux = SoloNumeros(DataGridView1.Item(3, GridFila).Value.ToString)      ' Guardar cada cantidad
                        flag = True             'activar el flag
                        Indice = i              'guardar el IndiceProd donde se encuentra el producto
                        Cant += CantAux         'sumar la cantidad anterior a la cantidad actual
                    End If
                Next
            End If
            '--------------------------------------------------------------------------------------------------------
            Select Case CStr(Tabla.Rows(IndiceProd).Item(11))    ' Comprobar si el producto se vende por Pack
                Case "Si", "SiCaja", "SiMetro"
                    If optPaquete.Checked = True Then  'Vender por Paquete si se ha seleccionado la opcion
                        Unidades = CDbl(Tabla.Rows(IndiceProd).Item(10))
                        Obs = "(Paquete)"
                        PrecioVenta = CInt(Tabla.Rows(IndiceProd).Item(8))
                        PrecioVenta = Descontar(PrecioVenta)
                    Else
                        Select Case CStr(Tabla.Rows(IndiceProd).Item(11))
                            Case "Si"
                                UnidMedida = " unid"
                            Case "SiMetro"
                                UnidMedida = " m"
                        End Select
                    End If
                Case "Piso"
                    If PorCaja Then
                        Unidades = CDbl(Tabla.Rows(IndiceProd).Item(10))
                        Obs = "(Caja)"
                        PrecioVenta = CInt(Tabla.Rows(IndiceProd).Item(8))
                        PrecioVenta = Descontar(PrecioVenta)
                    ElseIf PorMetro Then
                        'Dim Lado1, Lado2, MxUnid, UnidPiso, MxCaja, CantCajas, UniXCaja, PisoSuelto As Double
                        'Lado1 = CDbl(Tabla.Rows(IndiceProd).Item(13))
                        'Lado2 = CDbl(Tabla.Rows(IndiceProd).Item(14))
                        'MxUnid = Lado1 * Lado2 / 10000
                        'UnidPiso = Math.Ceiling(Cant / MxUnid)
                        'Cant = UnidPiso * MxUnid
                        'Unidades = 1 / MxUnid
                        Dim UnidPiso, MxCaja, CantCajas, UniXCaja As Double
                        UniXCaja = CDbl(Tabla.Rows(IndiceProd).Item(10))
                        MxCaja = CDbl(Tabla.Rows(IndiceProd).Item(10))
                        CantCajas = Math.Floor(Cant / MxCaja)
                        UnidPiso = Math.Round((Cant / MxCaja - CantCajas) * 10)
                        UnidPiso += CantCajas * UniXCaja

                        'MessageBox.Show(CStr(CantCajas) + " Cajas + " + CStr(Math.Round((Cant / MxCaja - CantCajas) * 10)) + " Unidades = " + CStr(UnidPiso) + "Unidades")
                        Param = Param + " (" + CStr(CantCajas) + " Cajas + " + CStr(Math.Round((Cant / MxCaja - CantCajas) * 10)) + " Unid." + ")"

                        Unidades = UnidPiso / Cant
                        Obs = "(metros)"
                        UnidMedida = " m"
                    ElseIf PorUnidad Then
                        PrecioVenta = CInt(Tabla.Rows(IndiceProd).Item(6))
                        PrecioVenta = Descontar(PrecioVenta)
                        Obs = "(unidades)"
                        UnidMedida = " unid"
                    End If
                Case "Kilo"
                    UnidMedida = " Kg"

            End Select
            '--------------------------------------------------------------------------------------------------------
            If CantStock >= (Cant * Unidades) Then                              'Si hay suficientes unidades en stock
                '----------------------------------------------------------------------------------------------------
                Dim Importe As Integer = CInt(Cant * PrecioVenta)

                If flag = False Then 'Si aun no se ingreso, hecer
                    DataGridView1.Rows.Add(Delete, idProd, Param, CStr(Cant) + UnidMedida, PrecioVenta, Importe, Desc, Unidades, Obs, Iva)
                Else 'Sino, hecer
                    DataGridView1.Rows.RemoveAt(Indice)
                    DataGridView1.Rows.Insert(Indice, Delete, idProd, Param, CStr(Cant) + UnidMedida, PrecioVenta, Importe, Desc, Unidades, Obs, Iva)
                End If
                MostrarDescuento()
                chkDesc.Checked = False
                txtCant.Text = "1"
                tmrTotal.Enabled = True
                txtBuscar.Focus()
                txtBuscar.Select(0, txtBuscar.Text.Length)
                PorMetro = False
                PorCaja = False
                PorUnidad = False
                'fin
            ElseIf CantStock = 0 Then
                MostrarMsj("Producto sin existencia en el Stock")
                txtBuscar.Focus()
                txtBuscar.Select(0, txtBuscar.Text.Length)
            Else
                MostrarMsj("No hay suficientes unidades en el Stock")
                txtCant.Focus()
                txtCant.Select(0, txtCant.Text.Length)
            End If
        Else
            txtBuscar.Focus()
            ToolTip2.Show("No se ha seleccionado ningún Producto", txtBuscar, 0, -40, 2000)
        End If
    End Sub


    Private Sub GenerarFactura()
        '
        'Hacemos una instancia de la clase EFactura para
        'llenarla con los valores contenidos en los controles del Formulario
        Dim Factura As New CEncabezadoFactura()
        Factura.FechaFacturacion = CDate(txtFecha.Text)
        Factura.Cliente = txtCliente.Text
        If cmbCliResult.SelectedIndex <> -1 Then
            Factura.Ruc = CICli
            Factura.Direccion = CStr(TablaCli.Rows(cmbCliResult.SelectedIndex).Item(3))
        Else
            Factura.Ruc = "xxx"
        End If
        If optContado.Checked Then
            Factura.Contado = CChar("x")
            Factura.Credito = CChar(" ")
        Else
            Factura.Contado = CChar(" ")
            Factura.Credito = CChar("x")
        End If
        Factura.Subtotal_0 = 0
        Factura.Subtotal_5 = 0
        Factura.Subtotal_10 = 0
        Factura.Total = Convert.ToDecimal(txtTotal.Text)

        'Recorremos los Rows existentes actualmente en el control DataGridView
        'para asignar los datos a las propiedades
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim Producto As New CDetalleFactura()
            '
            'Vamos tomando los valores de las celdas del row que estamos 
            'recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
            '
            Producto.Id = Convert.ToString(row.Cells(1).Value)
            Producto.Descripcion = Convert.ToString(row.Cells(2).Value)
            Producto.Cantidad = Convert.ToString(row.Cells(3).Value)
            Producto.Precio = Convert.ToDecimal(row.Cells(4).Value)
            Producto.Importe_0 = 0
            Producto.Importe_5 = 0
            Producto.Importe_10 = 0
            Dim IvaAux As Decimal = Convert.ToDecimal(row.Cells(9).Value)
            If IvaAux = 0 Then
                Producto.Importe_0 = Convert.ToDecimal(row.Cells(5).Value)
                Factura.Subtotal_0 += Producto.Importe_0
            ElseIf IvaAux = 5 Then
                Producto.Importe_5 = Convert.ToDecimal(row.Cells(5).Value)
                Factura.Subtotal_5 += Producto.Importe_5
            ElseIf IvaAux = 10 Then
                Producto.Importe_10 = Convert.ToDecimal(row.Cells(5).Value)
                Factura.Subtotal_10 += Producto.Importe_10
            End If
            '
            'Vamos agregando el Item a la lista del detalle
            '
            Factura.Detalle.Add(Producto)
        Next

        Factura.Iva_5 = Math.Round(Factura.Subtotal_5 / 21)
        Factura.Iva_10 = Math.Round(Factura.Subtotal_10 / 11)
        Factura.Iva_Total = Factura.Iva_5 + Factura.Iva_10
        '
        'Creamos una instancia del Formulario que contiene nuestro
        'ReportViewer
        '
        Dim Frm As New FReporteFactura()
        '
        'Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
        'que se mostrara en los parametros creados en el LocalReport, para este ejemplo
        'estamos Seteando los valores directamente pero usted puede usar algun control
        '
        'Frm.Titulo = "Este es un ejemplo de Factura"
        'Frm.Empresa = "Este es un ejemplo del Nombre de la Empresa"
        '
        'Recuerde que invoice es una Lista Generica declarada en FacturaRtp, es una lista
        'porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
        'implementen IEnumerable.
        '
        'Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
        Frm.Encabezado.Add(Factura)
        '
        'Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
        'es un lista del tipo EArticulo bastara con igualarla
        '
        Frm.Detalle = Factura.Detalle
        Frm.ShowDialog()
    End Sub

    Private Function GetUnidMedida(ByVal Obs As String) As String

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If ModoMotelValue Then
            Dim Tabla As DataTable = Habitacion.VerAjustes
            Dim Tolerancia As Integer = CInt(Tabla.Rows(0).Item(3))

            Dim TablaOcup As DataTable
            Dim Tiempo As TimeSpan
            TablaOcup = Habitacion.ChequearSinSalida(HabitacionNro)
            Try
                Dim Fecha As Date = CType(TablaOcup.Rows(0).Item(1), Date)
                Dim Horas As Integer = CInt(DateDiff(DateInterval.Hour, Fecha, Now)) - Now.Hour
                Dim Time As New TimeSpan(Now.Hour + Horas, Now.Minute, Now.Second)
                Tiempo = Time.Subtract(CType(TablaOcup.Rows(0).Item(0), TimeSpan))
            Catch ex As Exception
            End Try

            If Tiempo.TotalMinutes <= Tolerancia Then
                CampoHabEvents.IdVenta = 0
                RaiseEvent Facturado(Me, CampoHabEvents)
                Hide()
            Else
                MessageBox.Show("No se puede cancelar esta factura ya que se superó el tiempo de tolerancia")
            End If
        Else
            Limpiar()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim Filas As Integer = DataGridView1.Rows.Count
        If Filas > 0 Then
            If txtCliente.Text <> "" Then
                If cmbVendedor.Text <> "" Then
                    If optCredito.Checked = True Then
                        btnCredOk.Visible = False
                        lblCredGs.Visible = False
                        txtCredEntrega.Visible = False
                        pnlCredito.Visible = True
                    Else
                        GuardarVenta()
                    End If
                Else
                    cmbVendedor.Focus()
                    Me.ToolTip2.Show("Ingrese Vendedor", cmbVendedor, 0, -40, 2000)
                End If
            Else
                txtCliente.Focus()
                Me.ToolTip2.Show("Ingrese Cliente", pbxBuscCli, 0, -40, 2000)
            End If
        Else
            txtBuscar.Focus()
            Me.ToolTip2.Show("Ingrese Productos", txtBuscar, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Limpiar()
        Entrega = 0
        CICli = ""
        txtCliente.Text = ""
        txtBuscar.Text = ""
        txtTotal.Text = CStr(0)
        ClienteDefecto()
        txtCant.Text = CStr(1)
        cmbDescrip.Text = ""
        dtpVto.Value = Now
        chkMayorista.Checked = False
        cmbDescrip.Items.Clear()
        DataGridView1.Rows.Clear()
        optContado.Checked = True
        pnlProdInfo.Visible = False
        pnlInfoCli.Visible = False
        pnlPrecVenta.Visible = False
        pnlCliente.Visible = False
        pnlCredito.Visible = False
        'pnlVenderPor.Visible = False
        txtFecha.Text = Now.Date.ToShortDateString
        txtBuscar.Focus()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cmbDescrip.DroppedDown = True
        Timer1.Enabled = False
    End Sub

    Private Sub tmrTotal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTotal.Tick
        Total = 0
        Dim Filas As Integer = DataGridView1.Rows.Count - 1
        For i As Integer = 0 To Filas
            Total += Convert.ToInt32(DataGridView1.Item(5, i).Value.ToString)
        Next
        txtTotal.Text = Format(Total, "###,##")
        tmrTotal.Enabled = False
    End Sub

    Private Sub chkDesc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesc.CheckedChanged
        If chkDesc.Checked = True Then
            lblDesc.Visible = True
            txtDescuent.Visible = True
            txtDescuent.Focus()
        Else
            lblDesc.Visible = False
            txtDescuent.Visible = False
            txtDescuent.Text = ""
        End If
    End Sub

    Public Property CIEmpleado() As String
        Get
            CIEmpleado = CIValue
        End Get
        Set(ByVal value As String)
            CIValue = value
        End Set
    End Property

    Public WriteOnly Property ModoMotel() As Boolean
        Set(ByVal Value As Boolean)
            ModoMotelValue = Value
        End Set
    End Property

    Public Property HabitacionNro() As Integer
        Get
            Return CampoHabEvents.Habitacion
        End Get
        Set(ByVal value As Integer)
            CampoHabEvents.Habitacion = value
            lblHab.Text = CStr(value)
            lblHab2.Text = CStr(value)
        End Set
    End Property

    Private Sub MostrarDescuento()
        If Descuent Then
            Descripcion.Width = 185
            Descuento.Visible = True
        Else
            Descripcion.Width = 235
            Descuento.Visible = False
        End If
    End Sub

    Private Function Descontar(ByVal PrecioVenta As Integer) As Integer
        Dim Desc As Integer = CInt(txtDescuent.Text)
        If chkDesc.Checked = True Then  'realizar el descuento
            PrecioVenta = CInt(PrecioVenta - PrecioVenta * Desc / 100)
            Descuent = True
        End If
        Return PrecioVenta
    End Function

    Private Sub tmrCliente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCliente.Tick
        cmbCliResult.DroppedDown = True
        tmrCliente.Enabled = False
    End Sub

    Private Sub txtCliBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCliResult.Items.Clear()
            cmbCliResult.Text = ""
            Param = txtCliBuscar.Text
            If Param <> "" Then
                Try
                    If cmbCliBuscarPor.SelectedIndex = 0 Then   'Por CI
                        TablaCli = Cliente.BuscCli("WHERE CI like '%" + Param + "%'")
                    Else                                        'Por Nombre
                        TablaCli = Cliente.BuscCli("WHERE Nombre like '%" + Param + "%'")
                    End If
                Catch
                    MostrarMsj("No hay coincidencias")
                End Try
                Dim Filas As Integer = TablaCli.Rows.Count
                If Filas > 0 Then
                    For i As Integer = 0 To (Filas - 1)
                        cmbCliResult.Items.Add(TablaCli.Rows(i).Item(1))
                    Next
                    cmbCliResult.Text = CStr(cmbCliResult.Items(0))
                    cmbCliResult.Focus()
                    tmrCliente.Enabled = True
                    pnlInfoCli.Visible = True
                End If
                ''Else

            End If
        End If
    End Sub

    Private Sub cmbCliResult_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliResult.SelectedIndexChanged
        Dim Fila As Integer = cmbCliResult.SelectedIndex
        If Fila <> -1 Then
            lblCliCI.Text = CStr(TablaCli.Rows(Fila).Item(0))
            lblCliNom.Text = CStr(TablaCli.Rows(Fila).Item(1))
            Try
                lblCliTel.Text = CStr(TablaCli.Rows(Fila).Item(2))
            Catch
                lblCliTel.Text = "- - -"
            End Try
            Try
                lblCliDir.Text = CStr(TablaCli.Rows(Fila).Item(3))
            Catch
                lblCliDir.Text = "- - -"
            End Try
        Else
            cmbCliResult.Focus()
            Me.ToolTip2.Show("Seleccione un Cliente", cmbCliResult, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnCliAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliAdd.Click
        Dim Fila As Integer = cmbCliResult.SelectedIndex
        If Fila <> -1 Then
            pnlCliente.Visible = False
            pnlBuscProd.Visible = True
            txtCliente.Text = CStr(TablaCli.Rows(cmbCliResult.SelectedIndex).Item(1))
            CICli = CStr(TablaCli.Rows(cmbCliResult.SelectedIndex).Item(0))
        Else
            cmbCliResult.Focus()
            ToolTip2.Show("Seleccione un Cliente", cmbCliResult, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnCliGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliGuardar.Click
        Dim CliNombre As String = txtCliNom.Text
        Dim CliTel As String = txtCliTel.Text
        Dim CliDir As String = txtCliDir.Text
        Dim CliPropiet As String = txtPropietario.Text
        Try
            CICli = txtCliCI.Text
            If txtCliNom.Text <> "" Then
                If CliPropiet = "" Then
                    CliPropiet = " "
                End If
                Dim foto As Byte()
                If Cliente.InserCliente(CICli, CliNombre, "", CliTel, CliDir, CliPropiet, foto, Now.Date) = True Then
                    txtCliente.Text = CliNombre
                    LimpiarNewCli()
                    pnlCliente.Visible = False
                    pnlBuscProd.Visible = True
                Else
                    CICli = ""
                    MostrarMsj("Hubo un error al guardar el Cliente")
                End If
            Else
                txtCliNom.Focus()
                Me.ToolTip2.Show("Ingrese el Nombre", txtCliNom, 0, -40, 2000)
            End If
        Catch
            txtCliCI.Focus()
            txtCliCI.Select(0, txtCliCI.Text.Length)
            ToolTip2.Show("Ingrese un Nro. de Ced/RUC válido", txtCliCI, 0, -40, 3000)
        End Try
    End Sub

    Private Sub LimpiarNewCli()
        txtCliCI.Text = ""
        txtCliNom.Text = ""
        txtCliTel.Text = ""
        txtCliDir.Text = ""
    End Sub

    Private Sub optUnidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optUnidad.CheckedChanged
        If optUnidad.Checked = True Then
            lblX.Visible = False
            lblUnidXpack.Visible = False
            lblUnidXpack.Text = CStr(1)
        End If

    End Sub

    Private Sub optPaquete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPaquete.CheckedChanged
        If optPaquete.Checked And optDesc.Checked Then
            lblX.Visible = True
            lblUnidXpack.Visible = True
            Dim Fila As Integer = cmbDescrip.SelectedIndex
            lblUnidXpack.Text = CStr(Tabla.Rows(Fila).Item(10))
        End If
    End Sub

    Private Sub btnCredSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredSi.Click
        lblCredGs.Visible = True
        txtCredEntrega.Text = ""
        txtCredEntrega.Visible = True
        btnCredOk.Visible = True
        txtCredEntrega.Focus()
    End Sub

    Private Sub GuardarVenta()
        Dim Filas As Integer = DataGridView1.Rows.Count
        Dim NroFac As Integer = Venta.CargarNroFac()
        Dim idProd As String
        Dim Cant As Double
        Dim Unidades As Double
        Dim Desc As Integer
        Dim Precio As Integer
        Dim Obs As String = ""
        Dim Cancelado As String
        Dim fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim Vto As String = Format(dtpVto.Value, "yyyy-MM-dd")
        If optContado.Checked = True Then
            Cancelado = "Si"
        Else
            Cancelado = "No"
        End If
        Try
            If Venta.InserVenta(NroFac, CInt(CIValue), CICli, fecha, Cancelado, Entrega, Vto) = False Then
                MostrarMsj("Hubo un error al guardar la factura")
                Exit Try
            End If
            Filas -= 1
            For i As Integer = 0 To Filas
                idProd = Convert.ToString(DataGridView1.Item(1, i).Value)
                Precio = Convert.ToInt32(DataGridView1.Item(4, i).Value)
                Desc = Convert.ToInt32(DataGridView1.Item(6, i).Value)
                Unidades = Convert.ToDouble(DataGridView1.Item(7, i).Value)
                Obs = Convert.ToString(DataGridView1.Item(8, i).Value)
                If Obs <> "Habitación" Then
                    Cant = SoloNumeros(DataGridView1.Item(3, i).Value.ToString)
                    If Venta.InserDetalleVenta(NroFac, idProd, Cant, Unidades, Precio, Obs, Desc) = False Then
                        'Borrar último registro de venta
                        MostrarMsj("Hubo un error al guardar la factura")
                        Exit Try
                    End If
                Else        'Insertar detalles de ocupación de habitaciones
                    Dim SubTotal As Integer = Convert.ToInt32(DataGridView1.Item(5, i).Value)
                    If idProd = "3" Then  'si es por noche
                        Cant = Convert.ToDouble(DataGridView1.Item(3, i).Value)
                    Else    'si el tiempo se mide por hora
                        Dim Tiempo As TimeSpan = TimeSpan.Parse(CStr(DataGridView1.Item(3, i).Value) + ":00")
                        Cant = Tiempo.TotalMinutes
                    End If
                    If Habitacion.InserDetalleOcup(NroFac, HabitacionNro, CInt(idProd), CInt(Cant), CUInt(Precio), SubTotal) = False Then
                        'Borrar detalles de esta venta
                        'Borrar esta venta
                        MostrarMsj("Hubo un error al guardar la factura")
                        Exit Try
                    End If
                End If

            Next
            If optContado.Checked = False And Entrega > 0 Then
                If Venta.InserRecibo(Venta.CargarNroRecib, NroFac, fecha, CInt(Entrega)) = False Then
                    MostrarMsj("Hubo un error al guardar el Recibo")
                    Exit Try
                End If
            End If
            txtNroFac.Text = CStr(Venta.CargarNroFac())
            'Imprimir()
            'GenerarFactura()
            MostrarMsj("Factura Registrada")
            Limpiar()
            Descuent = False
            MostrarDescuento()
            If ModoMotelValue Then
                Hide()
                CampoHabEvents.IdVenta = NroFac
                RaiseEvent Facturado(Me, CampoHabEvents)
            End If
        Catch MiError As Exception
            MostrarMsj(MiError.Message)
        End Try
    End Sub

    Private Sub Imprimir()
        Dim Condicion As String
        If optContado.Checked = True Then
            Condicion = "Contado"
        Else
            Condicion = "Credito"
        End If

        Dim Ds As New DataSet
        Ds.Tables.Add("GVData")

        Dim Col As DataColumn
        For Each DgvCol As DataGridViewColumn In DataGridView1.Columns
            Col = New DataColumn(DgvCol.Name)
            Ds.Tables("GVData").Columns.Add(Col)
        Next

        Dim Row As DataRow
        Dim ColCount As Integer = DataGridView1.Columns.Count - 1
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Row = Ds.Tables("GVData").Rows.Add
            For Each Column As DataGridViewColumn In DataGridView1.Columns
                Row.Item(Column.Index) = DataGridView1.Rows.Item(i).Cells(Column.Index).Value
            Next
        Next
        Dim Frm As New FImprimir(CStr(Venta.CargarNroFac), Now, txtCliente.Text, Condicion, cmbVendedor.Text,
                                Total, Ds.Tables("GVData"))
        ''frm.TopMost = True
        ''Minimizar = False
        Frm.ShowDialog()
        ''Minimizar = True

    End Sub

    Private Sub btnCredOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredOk.Click
        If txtCredEntrega.Text <> "" Then
            Entrega = CInt(txtCredEntrega.Text)
            If Entrega < Total Then
                pnlCredito.Visible = False
                GuardarVenta()
            Else
                txtCredEntrega.Focus()
                ToolTip2.Show("La Entrega debe ser menor que el monto Total", txtCredEntrega, 0, -40, 2000)
            End If
        Else
            txtCredEntrega.Focus()
            ToolTip2.Show("Ingrese el monto de la Entrega", txtCredEntrega, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnCredNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredNo.Click
        Entrega = 0
        pnlCredito.Visible = False
        GuardarVenta()
    End Sub

    Private Sub btnCredCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredCancel.Click
        pnlCredito.Visible = False
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Then
            Dim Observacion As String = Convert.ToString(DataGridView1.Item(8, e.RowIndex).Value.ToString)
            If Observacion <> "Habitación" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
                tmrTotal.Enabled = True
            End If
        End If
        If e.ColumnIndex = 3 And e.RowIndex >= 0 Then
            pnlEditCant.Visible = True
            txtEditCant.Text = ""
            txtEditCant.Focus()
            GridFila = e.RowIndex
        End If
        If e.ColumnIndex = 4 And e.RowIndex >= 0 Then
            GridFila = e.RowIndex
            Dim Cod As String = Convert.ToString(DataGridView1.Item(1, GridFila).Value.ToString)
            Tabla = Producto.BuscProdCod(Cod)
            Dim Present As String = CStr(Tabla.Rows(0).Item(11))
            optPrecio1.Checked = False
            optPrecio2.Checked = False
            optPrecio3.Checked = False
            txtEditPrecio.Text = ""
            pnlPrecios.Visible = True
            Select Case Present
                Case "Si", "SiCaja", "SiMetro"
                    optPrecio1.Text = CStr(Tabla.Rows(0).Item(5))
                    optPrecio2.Text = CStr(Tabla.Rows(0).Item(8))
                    optPrecio1.Visible = True
                    optPrecio2.Visible = True
                    lblTitPrecio1.Visible = True
                    lblTitPrecio2.Visible = True
                    Select Case Present
                        Case "Si"
                            lblTitPrecio2.Text = "Paquete"
                            lblTitPrecio1.Text = "Unidad"
                        Case "SiCaja"
                            lblTitPrecio2.Text = "Caja"
                            lblTitPrecio1.Text = "Paquete"
                        Case "SiMetro"
                            lblTitPrecio2.Text = "Entero"
                            lblTitPrecio1.Text = "Metro"
                    End Select
                Case "No", "Kilo"
                    optPrecio1.Text = CStr(Tabla.Rows(0).Item(5))
                    optPrecio2.Text = CStr(Tabla.Rows(0).Item(6))
                    optPrecio3.Text = CStr(Tabla.Rows(0).Item(7))
                    lblTitPrecio2.Text = "Minorista"
                    lblTitPrecio1.Text = "Mayorista"
                    optPrecio1.Visible = True
                    optPrecio2.Visible = True
                Case "Piso"
                    optPrecio1.Visible = False
                    optPrecio2.Visible = False
                    lblTitPrecio1.Visible = False
                    lblTitPrecio2.Visible = False
                    txtEditPrecio.Focus()
            End Select
        End If
    End Sub

    Private Sub pbxBuscCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxBuscCli.Click
        pnlProdInfo.Visible = False
        pnlBuscProd.Visible = False
        pnlCliente.Visible = True
        pnlInfoCli.Visible = False
        cmbCliBuscarPor.SelectedIndex = 0
        txtCliBuscar.Focus()
    End Sub

    Private Sub ClienteDefecto()
        Try
            TablaCli = Cliente.BuscCli("WHERE CI = " + "1")
            txtCliente.Text = CStr(TablaCli.Rows(0).Item(1))
            CICli = CStr(TablaCli.Rows(0).Item(0))
        Catch
        End Try
    End Sub

    Private Sub pbxCerrarPnl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        'If optCod.Checked Then
        'If Char.IsDigit(e.KeyChar) Then
        'e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        'e.Handled = False
        'Else
        'e.Handled = True
        'End If
        'End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCant.KeyPress, txtEditCant.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Letra As Char = e.KeyChar
        If Letra = Convert.ToChar(",") Or Letra = Convert.ToChar(".") Then
            Dim Present As String = "Kilo"
            If Caja Is txtCant Then
                Try
                    Present = CStr(Tabla.Rows(cmbDescrip.SelectedIndex).Item(11))
                Catch ex As Exception
                End Try
            Else
                Try
                    Dim Cod As String = DataGridView1.Item(1, GridFila).Value.ToString
                    Tabla = Producto.BuscProdCod(Cod)
                    Present = CStr(Tabla.Rows(0).Item(11))
                Catch ex As Exception
                End Try
            End If
            Dim Obs As String
            If PorMetro = False Then
                Obs = DataGridView1.Item(8, GridFila).Value.ToString
            End If
            If Present = "Kilo" Or (Present = "SiMetro" And optUnidad.Checked) Or (Present = "Piso" And (PorMetro Or Obs = "(metros)")) Then
                If Letra = Convert.ToChar(",") Then
                    e.Handled = False
                Else
                    e.Handled = True
                    Caja.Text = Caja.Text + ","
                    Caja.Select(Caja.Text.Length, 0)
                End If
            Else
                e.Handled = True
                Caja.Focus()
                ToolTip2.Show("Los productos por unidades o paquetes no aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf Char.IsDigit(Letra) Then
            e.Handled = False
        ElseIf Char.IsControl(Letra) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If Letra = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBusCliCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCliCancel.Click
        pnlCliente.Visible = False
        pnlBuscProd.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pnlCliente.Visible = False
        pnlBuscProd.Visible = True
    End Sub

    Private Function Lright(ByVal p1 As String, ByVal p2 As Integer) As Object
        Throw New NotImplementedException
    End Function

    Private Sub txtEditCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If PorMetro Then
                    txtCant.Text = txtEditCant.Text
                    btnAgregar_Click(Me, Nothing)
                    pnlEditCant.Visible = False
                Else
                    'Chequear cantidad en stock
                    Dim Cod As String = Convert.ToString(DataGridView1.Item(1, GridFila).Value.ToString)
                    Tabla = Producto.BuscProdCod(Cod)

                    'Dim Present As String = CStr(Tabla.Rows(0).Item(10))


                    Dim CantStock As Double = CDbl(Tabla.Rows(0).Item(9))
                    Dim CantEdit As Double = CDbl(txtEditCant.Text)
                    Dim CantDescontar As Double = CantEdit   'Stock a descontar
                    Dim UnidMedida As String = ""

                    Dim Present As String = Tabla.Rows(0).Item(11).ToString
                    Dim Obs As String = DataGridView1.Item(8, GridFila).Value.ToString

                    If Obs <> "(Paquete)" Then
                        Select Case Present
                            Case "Si"
                                UnidMedida = " unid"
                            Case "SiMetro"
                                UnidMedida = " m"
                        End Select
                    End If

                    If Present = "Kilo" Then
                        UnidMedida = " Kg"
                    ElseIf Present = "Piso" And Obs = "(unidades)" Then
                        UnidMedida = " unid"
                    End If


                    If Obs = "(metros)" Then
                        'Dim Lado1, Lado2, MxUnid As Double
                        'Lado1 = CDbl(Tabla.Rows(0).Item(13))
                        'Lado2 = CDbl(Tabla.Rows(0).Item(14))
                        'MxUnid = Lado1 * Lado2 / 10000
                        'Dim UnidPiso As Double = Math.Ceiling(CantEdit / MxUnid)
                        'CantDescontar = UnidPiso
                        'CantEdit = UnidPiso * MxUnid
                        Dim MxCaja, CantCajas, UniXCaja As Double
                        UniXCaja = CDbl(Tabla.Rows(0).Item(10))
                        MxCaja = CDbl(Tabla.Rows(0).Item(16))
                        CantCajas = Math.Floor(CantEdit / MxCaja)
                        CantDescontar = Math.Round((CantEdit / MxCaja - CantCajas) * 10)
                        CantDescontar += CantCajas * UniXCaja

                        Dim Descrip As String = CStr(Tabla.Rows(0).Item(3))
                        DataGridView1.Item(7, GridFila).Value = CantDescontar / CantEdit
                        DataGridView1.Item(2, GridFila).Value = Descrip + " (" + CStr(CantCajas) + " Cajas + " + CStr(Math.Round((CantEdit / MxCaja - CantCajas) * 10)) + " Unid." + ")"
                        UnidMedida = " m"

                    ElseIf obs = "(Paquete)" Or obs = "(Caja)" Or obs = "(Entero)" Then
                        Dim Unidades As Double = CDbl(DataGridView1.Item(7, GridFila).Value)
                        CantDescontar = CantEdit * Unidades
                    ElseIf Obs = "(unidades)" Then
                        UnidMedida = " unid"
                    End If


                    If CantDescontar <= 0 Then
                        MostrarMsj("La cantidad debe ser mayor a cero")
                    Else
                        If CantStock >= CantDescontar Then
                            DataGridView1.Item(3, GridFila).Value = CStr(CantEdit) + UnidMedida
                            pnlEditCant.Visible = False
                            txtBuscar.Focus()
                            txtBuscar.Select(0, txtBuscar.Text.Length)
                            DataGridView1.Item(5, GridFila).Value = CDbl(DataGridView1.Item(4, GridFila).Value) * CantEdit
                            tmrTotal.Enabled = True
                            'DataGridView1.Item(3, GridFila).Value = CStr(CantEdit) + UnidMedida
                        Else
                            MostrarMsj("No hay suficientes unidades en Stock")
                        End If
                    End If
                End If
            Catch ex As Exception
                MostrarMsj("Valor de Cantidad no Válida")
            End Try
        End If
    End Sub

    Private Sub btnEditCantCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCantCancel.Click
        pnlEditCant.Visible = False
    End Sub

    Private Sub cmbVendedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVendedor.Click
        cmbVendedor.DroppedDown = True
    End Sub

    Private Sub optCod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCod.Click, optDesc.Click, _
        txtFecha.Click, txtNroFac.Click, txtTotal.Click, DataGridView1.Click, pbxBuscCli.Click, _
        chkMayorista.Click, optContado.Click, optCredito.Click, cmbVendedor.SelectedIndexChanged

        txtBuscar.Focus()
        txtBuscar.Select(0, txtBuscar.Text.Length)
    End Sub

    Private Sub MostrarMas(ByRef Value As Boolean)
        cmbDescrip.Visible = Value
        lblCant.Visible = Value
        txtCant.Visible = Value
        btnAgregar.Visible = Value
        txtCant.Text = "1"
        txtBuscar.Text = ""
    End Sub

    Private Sub optCod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCod.CheckedChanged
        MostrarMas(Not optCod.Checked)
    End Sub

    Private Function CargarDescuanto() As Integer
        If txtDescuent.Text = "" Then                                   ' Asignar descuento si no se ingreso nada
            txtDescuent.Text = "0"
        End If
        Dim Desc As Integer = CInt(txtDescuent.Text)
        Return Desc
    End Function

    Private Function CargarPrecio(ByVal IndiceProd As Integer) As Integer
        Dim Precio As Integer
        'If chkMayorista.Checked Then 'If optCredito.Checked Then                            ' Seleccionar precio (Crédito o Contado)
        Precio = CInt(Tabla.Rows(IndiceProd).Item(5))
        'Else
        'Precio = CInt(Tabla.Rows(IndiceProd).Item(5))
        'End If
        Precio = Descontar(Precio)                            ' Se aplica el descuento
        Return Precio
    End Function

    Private Sub btnPackCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPackCancel.Click
        pnlXPack.Visible = False
    End Sub

    Private Sub btnPack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPack.Click
        optPaquete.Checked = True
        optUnidad.Checked = False
        pnlXPack.Visible = False
        If optCod.Checked Then
            btnAgregar_Click(Nothing, Nothing)
        Else
            txtCant.Focus()
            txtCant.Select(0, txtCant.Text.Length)
        End If
    End Sub

    Private Sub btnUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnidad.Click
        optPaquete.Checked = False
        optUnidad.Checked = True
        pnlXPack.Visible = False
        btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Sub btnAgregar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.GotFocus
        btnAgregar.ForeColor = Color.Orange
    End Sub

    Private Sub btnAgregar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.LostFocus
        btnAgregar.ForeColor = Color.White
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pnlPrecios.Visible = False
    End Sub

    Private Sub optPrecio1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPrecio1.Click, optPrecio2.Click, optPrecio3.Click
        Dim Opcion As RadioButton = CType(sender, RadioButton)
        Dim Cod As String = Convert.ToString(DataGridView1.Item(1, GridFila).Value.ToString)
        Tabla = Producto.BuscProdCod(Cod)
        Dim Present As String = CStr(Tabla.Rows(0).Item(11))
        Select Case Present
            Case "Si", "SiCaja", "SiMetro"
                If Opcion Is optPrecio2 Then
                    Dim Unidades As String = CStr(Tabla.Rows(0).Item(10))
                    DataGridView1.Item(7, GridFila).Value = Unidades
                    Select Case Present
                        Case "Si"
                            DataGridView1.Item(8, GridFila).Value = "(Paquete)"
                        Case "SiCaja"
                            DataGridView1.Item(8, GridFila).Value = "(Caja)"
                        Case "SiMetro"
                            DataGridView1.Item(8, GridFila).Value = "(Entero)"
                    End Select
                End If
        End Select
        DataGridView1.Item(4, GridFila).Value = Opcion.Text
        pnlPrecios.Visible = False
        txtBuscar.Focus()
        txtBuscar.Select(0, txtBuscar.Text.Length)
        DataGridView1.Item(5, GridFila).Value = CDbl(DataGridView1.Item(4, GridFila).Value) *
            SoloNumeros(DataGridView1.Item(3, GridFila).Value.ToString)
        tmrTotal.Enabled = True
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FVenta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Normal
    End Sub

    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    'Dim strEstado As String = Me.WindowState.ToString()
    'If strEstado = "Maximized" Then
    'Me.WindowState = FormWindowState.Normal
    'Dim Ancho As Integer = Me.Size.Width
    'End If
    'End Sub

    Private Sub cmbVendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVendedor.SelectedIndexChanged
        Dim Indice As Integer = cmbVendedor.SelectedIndex
        If Indice >= 0 Then
            CIValue = CStr(TablaEmple.Rows(Indice).Item(0))
        End If
    End Sub

    Private Sub CargarEmple()
        TablaEmple = Empleado.ListarEmple()
        cmbVendedor.Items.Clear()
        cmbVendedor.Text = ""
        Dim Filas As Integer = TablaEmple.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                cmbVendedor.Items.Add(CStr(TablaEmple.Rows(i).Item(1)) + " " + CStr(TablaEmple.Rows(i).Item(2)))
            Next
        End If
    End Sub

    Private Sub FVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub txtEditPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEditPrecio.KeyPress, txtNuevoPPrecio.KeyPress, txtNuevoPCant.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If e.KeyChar = Convert.ToChar(",") Then
            If Caja Is txtNuevoPCant Then
                e.Handled = False
            Else
                e.Handled = True
                Caja.Focus()
                ToolTip2.Show("No se aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf e.KeyChar = Convert.ToChar(".") Then
            e.Handled = True
            If Caja Is txtNuevoPCant Then
                Caja.Text = Caja.Text + ","
                Caja.Select(Caja.Text.Length, 0)
            Else
                Caja.Focus()
                ToolTip2.Show("No se aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEditPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim Precio As Double = CDbl(txtEditPrecio.Text)
                Dim Cod As String = Convert.ToString(DataGridView1.Item(1, GridFila).Value.ToString)
                Tabla = Producto.BuscProdCod(Cod)
                Dim Costo As Integer = CInt(Tabla.Rows(0).Item(4))
                Dim Present As String = CStr(Tabla.Rows(0).Item(11))

                Select Case Present
                    Case "Si", "SiCaja", "SiMetro"
                        Dim UnidxPack As Long = CLng(Tabla.Rows(0).Item(10))
                        Costo = CInt(Costo / UnidxPack)
                    Case "Piso"
                        Dim UnidxPack As Long = CLng(Tabla.Rows(0).Item(10))
                        Dim Obs As String = DataGridView1.Item(8, GridFila).Value.ToString
                        If Obs = "(metros)" Then
                            Dim MxCaja As Double
                            MxCaja = CDbl(Tabla.Rows(0).Item(16))
                            Costo = CInt(Costo / MxCaja)
                        Else
                            Costo = CInt(Costo / UnidxPack)
                        End If
                End Select

                If Precio >= Costo Then
                    DataGridView1.Item(4, GridFila).Value = Precio
                    pnlPrecios.Visible = False
                    txtBuscar.Focus()
                    txtBuscar.Select(0, txtBuscar.Text.Length)
                    DataGridView1.Item(5, GridFila).Value = CDbl(DataGridView1.Item(4, GridFila).Value) *
                        SoloNumeros(DataGridView1.Item(3, GridFila).Value.ToString)
                    tmrTotal.Enabled = True
                Else
                    MessageBox.Show("El Precio de Venta no puede ser inferior al Precio de Costo")
                End If
            Catch ex As Exception
                MessageBox.Show("Valor de Cantidad no Válida")
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlPiso.Visible = False
    End Sub

    Private Sub btnPorCaja_Click(sender As Object, e As EventArgs) Handles btnPorCaja.Click
        PorCaja = True
        PorUnidad = False
        PorMetro = False
        pnlPiso.Visible = False
        If optCod.Checked Then
            btnAgregar_Click(Nothing, Nothing)
        Else
            txtCant.Focus()
            txtCant.Select(0, txtCant.Text.Length)
        End If
    End Sub

    Private Sub PorMetro_Click_1(sender As Object, e As EventArgs) Handles btnPorMetro.Click
        PorCaja = False
        PorUnidad = False
        PorMetro = True
        pnlPiso.Visible = False

        If optCod.Checked Then
            pnlEditCant.Visible = True
            txtEditCant.Focus()
            txtEditCant.Select(0, txtEditCant.Text.Length)
            'btnAgregar_Click(Nothing, Nothing)
        Else
            txtCant.Focus()
            txtCant.Select(0, txtCant.Text.Length)
        End If
    End Sub

    Private Sub pbxNewProd_Click(sender As Object, e As EventArgs) Handles pbxNewProd.Click
        Dim Frm As New FNuevoProducto
        Frm.MaximizeBox = False
        Frm.MinimizeBox = False
        Frm.ShowDialog()
        txtBuscar.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub btnPorUnidad_Click(sender As Object, e As EventArgs) Handles btnPorUnidad.Click
        PorCaja = False
        PorUnidad = True
        PorMetro = False
        pnlPiso.Visible = False
        If optCod.Checked Then
            btnAgregar_Click(Nothing, Nothing)
        Else
            txtCant.Focus()
            txtCant.Select(0, txtCant.Text.Length)
        End If
    End Sub

    Private Sub pbxCrearProd_Click(sender As Object, e As EventArgs) Handles pbxCrearProd.Click
        txtNuevoPDescrip.Text = ""
        txtNuevoPCant.Text = ""
        txtNuevoPPrecio.Text = ""
        txtNuevoPImporte.Text = ""
        ChkGenerar.Checked = False
        ChkGenerar.Checked = True
        pnlCrearProd.Visible = True
        txtNuevoPDescrip.Focus()
    End Sub

    Private Sub txtEditPrecio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEditPrecio.KeyUp, txtNuevoPPrecio.KeyUp
        If (txtEditPrecio.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(txtEditPrecio.Text, importe)
            txtEditPrecio.Text = String.Format("{0:N0}", importe)
            txtEditPrecio.SelectionStart = txtEditPrecio.TextLength
        End If
    End Sub

    Public Function SoloNumeros(ByVal strCadena As String) As Double
        Dim SoloNumero As String = ""
        Dim index As Integer
        For index = 1 To Len(strCadena)
            If (Mid$(strCadena, index, 1) Like "#") _
                Or (Mid$(strCadena, index, 1) = "-") _
                Or (Mid$(strCadena, index, 1) = ",") Then
                SoloNumero = SoloNumero & Mid$(strCadena, index, 1)
            End If
        Next
        Return CDbl(SoloNumero)
    End Function

    Private Sub ChkGenerar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGenerar.CheckedChanged
        If ChkGenerar.Checked Then
            Dim idProd As String = Producto.GenerarCódigo
            If idProd <> "0" Then
                txtNuevoPCod.Text = idProd
            Else
                txtNuevoPCod.Text = ""
            End If
            txtNuevoPCod.ReadOnly = True
        Else
            txtNuevoPCod.Text = ""
            txtNuevoPCod.ReadOnly = False
        End If
    End Sub

    Private Sub txtNuevoPDescrip_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNuevoPDescrip.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNuevoPCant.Focus()
            txtNuevoPCant_LostFocus(Me, Nothing)
        End If
    End Sub

    Private Sub txtNuevoPCant_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNuevoPCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNuevoPPrecio.Focus()
            txtNuevoPCant_LostFocus(Me, Nothing)
        End If
    End Sub

    Private Sub txtNuevoPCant_LostFocus(sender As Object, e As EventArgs) Handles txtNuevoPCant.LostFocus, txtNuevoPPrecio.LostFocus
        If CrearProductoImporteOk() Then
            txtNuevoPImporte.Text = CStr(CLng(txtNuevoPCant.Text) * CInt(txtNuevoPPrecio.Text))
        End If
    End Sub

    Private Function CrearProductoImporteOk() As Boolean
        CrearProductoImporteOk = False
        If txtNuevoPCant.Text <> "" And txtNuevoPPrecio.Text <> "" Then
            If CLng(txtNuevoPCant.Text) > 0 Then
                If CInt(txtNuevoPPrecio.Text) > 0 Then
                    CrearProductoImporteOk = True
                Else
                    txtNuevoPPrecio.Focus()
                    ToolTip2.Show("Valor no válido", txtNuevoPPrecio, 0, -40, 2000)
                End If
            Else
                txtNuevoPCant.Focus()
                ToolTip2.Show("Valor no válido", txtNuevoPCant, 0, -40, 2000)
            End If
        End If
    End Function

    Private Sub btnNuevoPOk_Click(sender As Object, e As EventArgs) Handles btnNuevoPOk.Click
        If txtNuevoPDescrip.Text <> "" Then
            If txtNuevoPCant.Text <> "" Then
                If txtNuevoPPrecio.Text <> "" Then
                    If CrearProductoImporteOk() Then
                        GuardarProducto()
                    End If
                Else
                    txtNuevoPPrecio.Focus()
                    ToolTip2.Show("Complete todos los campos", txtNuevoPPrecio, 0, -40, 2000)
                End If
            Else
                txtNuevoPCant.Focus()
                ToolTip2.Show("Complete todos los campos", txtNuevoPCant, 0, -40, 2000)
            End If
        Else
            txtNuevoPDescrip.Focus()
            ToolTip2.Show("Complete todos los campos", txtNuevoPDescrip, 0, -40, 2000)
        End If
    End Sub

    Private Sub btnNuevoPCancel_Click(sender As Object, e As EventArgs) Handles btnNuevoPCancel.Click
        pnlCrearProd.Visible = False
    End Sub

    Private Sub txtNuevoPDescrip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevoPDescrip.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNuevoPPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNuevoPPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNuevoPOk.Focus()
            txtNuevoPCant_LostFocus(Me, Nothing)
        End If
    End Sub

    Private Sub GuardarProducto()
        Dim idProd As String = txtNuevoPCod.Text
        Dim TablaProv As DataTable = Proveedor.Buscar("")
        Dim idProv As String = CStr(TablaProv.Rows(0).Item(0))
        Dim Descrip As String = txtNuevoPDescrip.Text
        Dim PrecCompra As Integer = 0
        Dim Categoria As String = "1"
        Dim PrecPack? As Integer
        Dim Precio1 As Integer = CInt(txtNuevoPPrecio.Text)
        Dim Precio2 As Integer = Precio1
        Dim UnidXpack?, Lado1?, Lado2?, MxCaja? As Double
        Dim Stock As Double = CDbl(txtNuevoPCant.Text)
        Dim PorPack As String = "No"
        Dim Foto As Byte()
        Dim Iva As Int16 = 10
        If Producto.VerificarCod(idProd) = True Then
            If Producto.InserProducto(idProd, idProv, Categoria, Descrip, PrecCompra, Precio1, Precio2, 0, PrecPack, Stock, UnidXpack, PorPack, Foto, Iva, Lado1, Lado2, MxCaja) = False Then
                MessageBox.Show("Hubo un error al crear el Producto")
            Else
                'MessageBox.Show("Producto Guardado")
                Dim Delete As Image = My.Resources.button_cancel      ' Imagen delete q se agrega al datagrid                                       ' Contiene la descripcion de producto
                Dim Unidades As Double = 1                            ' Factor multiplicativo p/ ventas x Pack
                Dim Obs As String = ""
                Dim Desc As Integer = 0
                Dim importe As Integer = CInt(Stock * Precio1)
                DataGridView1.Rows.Add(Delete, idProd, Descrip, Stock, Precio1, importe, Desc, Unidades, Obs, Iva)
                tmrTotal.Enabled = True
                pnlCrearProd.Visible = False
            End If
        Else
            MessageBox.Show("El Código ingresado ya existe")
            txtNuevoPCod.Select(0, txtNuevoPCod.Text.Length)
            txtNuevoPCod.Focus()
        End If
    End Sub

End Class