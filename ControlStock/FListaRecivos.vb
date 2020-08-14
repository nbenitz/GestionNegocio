
Public Class FListaRecivos

    Dim Venta As New CVenta
    Dim Compra As New CCompra
    Dim TablaRecibo As New DataTable
    Dim ModoVentaValue As Boolean

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                txtCod.Visible = False
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = False
                lblHasta.Visible = False
                txtCod.Visible = False
                If ModoVentaValue Then
                    TablaRecibo = Venta.BuscRecibo()
                Else
                    TablaRecibo = Compra.BuscRecibo()
                End If
                CargarTabla(TablaRecibo)
            Case Is = 1 'Nro. Factura
                txtCod.Visible = True
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Ingrese Nro. de Factura"
                lblHasta.Visible = False
                txtCod.Select(0, txtCod.TextLength)
                txtCod.Focus()
            Case Is = 2 'Fecha
                txtCod.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblBuscar.Text = "Desde"
                lblHasta.Visible = True
                dtpDesde.Value = Now
                dtpHasta.Value = Now
        End Select
    End Sub

    Private Sub FListaRecivoPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFiltrarPor.SelectedIndex = 0
    End Sub

    Private Sub txtCod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroFactura As Integer
            If txtCod.Text <> "" Then
                Try
                    NroFactura = CInt(txtCod.Text)
                    If ModoVentaValue Then
                        TablaRecibo = Venta.BuscRecibo(NroFactura)
                    Else
                        TablaRecibo = Compra.BuscRecibo(NroFactura)
                    End If
                    CargarTabla(TablaRecibo)
                Catch ex As Exception
                    MessageBox.Show("Ingrese un número de factura válido")
                    txtCod.Text = ""
                End Try
            End If
        End If
    End Sub

    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged, dtpHasta.ValueChanged
        Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
        If ModoVentaValue Then
            TablaRecibo = Venta.BuscRecibo(Fecha1, Fecha2)
        Else
            TablaRecibo = Compra.BuscRecibo(Fecha1, Fecha2)
        End If
        CargarTabla(TablaRecibo)
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idRecibo As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim idFactura As Integer = CInt(Tabla.Rows(i).Item(1))
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(2))
                Dim Importe As Integer = CInt(Tabla.Rows(i).Item(3))
                DataGridView1.Rows.Add(idRecibo, idFactura, Fecha, Importe)
            Next
        End If
    End Sub

    Public WriteOnly Property ModoVenta() As Boolean
        Set(ByVal Valor As Boolean)
            ModoVentaValue = Valor
            If Valor = True Then
                Me.Text = "Pagos recibidos por Ventas a Crédito"
            Else
                Me.Text = "Pagos realizados por Compras a Crédito"
            End If
        End Set
    End Property

End Class