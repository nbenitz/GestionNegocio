Option Strict On
Public Class FListaAltaProd
    Dim Producto As New CProducto
    Dim TablaAlta As New DataTable
    Dim TablaMotivo As New DataTable
    Dim IndiceMotivo As Integer = 0

    Private Sub FListaAltaProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarMotivos()
        cmbFiltrarPor.SelectedIndex = 0
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CargarMotivos()
        TablaMotivo = Producto.ListarMotivoAlta
        cmbMotivo.Items.Clear()
        cmbMotivo.Items.Add("Todos")
        Dim Filas As Integer = TablaMotivo.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                cmbMotivo.Items.Add(TablaMotivo.Rows(i).Item(1))
            Next
        End If
        cmbMotivo.SelectedIndex = 0
    End Sub

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
                lblMotivo.Visible = True
                cmbMotivo.Visible = True
                IndiceMotivo = cmbMotivo.SelectedIndex
                Select Case IndiceMotivo
                    Case Is = 0 'Todos
                        TablaAlta = Producto.BuscViewAlta("ORDER BY idAlta DESC")
                    Case Else 'Algun Motivo
                        Dim Motivo As String = cmbMotivo.Text
                        TablaAlta = Producto.BuscViewAlta("WHERE Motivo = '" + Motivo + "'  ORDER BY idAlta DESC")
                End Select
                CargarTabla(TablaAlta)
            Case Is = 1 'Nro. Factura
                txtCod.Visible = True
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Ingrese Código"
                lblHasta.Visible = False
                IndiceMotivo = cmbMotivo.SelectedIndex
                lblMotivo.Visible = False
                cmbMotivo.Visible = False
            Case Is = 2 'Fecha
                txtCod.Visible = False
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblBuscar.Text = "Desde"
                lblHasta.Visible = True
                lblMotivo.Visible = True
                cmbMotivo.Visible = True

                dtpDesde.Value = Now
                dtpHasta.Value = Now
        End Select
    End Sub

    Private Sub cmbMotivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMotivo.SelectedIndexChanged, dtpDesde.ValueChanged, dtpHasta.ValueChanged
        Dim IndiceFiltrar As Integer = cmbFiltrarPor.SelectedIndex
        IndiceMotivo = cmbMotivo.SelectedIndex
        Select Case IndiceFiltrar
            Case Is = 0 'Todos
                Select Case IndiceMotivo
                    Case Is = 0 'Todos
                        TablaAlta = Producto.BuscViewAlta("ORDER BY idAlta DESC")
                    Case Else 'Algun motivo
                        Dim Motivo As String = cmbMotivo.Text
                        TablaAlta = Producto.BuscViewAlta("WHERE Motivo = '" + Motivo + "'  ORDER BY idAlta DESC")
                End Select
            Case Is = 2 'Fecha
                Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
                Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
                Select Case IndiceMotivo
                    Case Is = 0 'Todos
                        TablaAlta = Producto.BuscViewAlta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idAlta DESC")
                    Case Else 'Algun Motivo
                        Dim Motivo As String = cmbMotivo.Text
                        TablaAlta = Producto.BuscViewAlta("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND Motivo = '" + Motivo + "'  ORDER BY idAlta DESC")
                End Select
        End Select
        CargarTabla(TablaAlta)
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim idAlta As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(1))
                Dim idProd As UInt64 = CULng(Tabla.Rows(i).Item(2))
                Dim Descrip As String = CStr(Tabla.Rows(i).Item(3))
                Dim Motivo As String = CStr(Tabla.Rows(i).Item(4))
                Dim Cant As Double = CDbl(Tabla.Rows(i).Item(5))
                DataGridView1.Rows.Add(idAlta, Fecha, idProd, Descrip, Motivo, Cant)
            Next
        End If
    End Sub

    Private Sub txtCod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim idProd As String
            If txtCod.Text <> "" Then
                Try
                    idProd = txtCod.Text
                    TablaAlta = Producto.BuscViewAlta("WHERE idProductoFK = " + idProd)
                    CargarTabla(TablaAlta)
                Catch ex As Exception
                    MessageBox.Show("Ingrese un Código de producto válido")
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

End Class