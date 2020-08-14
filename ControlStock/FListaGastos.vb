Option Strict On

Public Class FListaGastos
    Dim Compra As New CCompra
    Dim TablaGasto As New DataTable
    Dim TablaConcepto As New DataTable
    Dim IndiceConcepto As Integer = 0

    Private Sub FListaAltaBajaProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarConceptos()
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

    Private Sub CargarConceptos()
        TablaConcepto = Compra.ListarGasto
        CmbConcepto.Items.Clear()
        CmbConcepto.Items.Add("Todos")
        Dim Filas As Integer = TablaConcepto.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                CmbConcepto.Items.Add(TablaConcepto.Rows(i).Item(1))
            Next
        End If
        CmbConcepto.SelectedIndex = 0
    End Sub

    Private Sub cmbFiltrarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrarPor.SelectedIndexChanged
        Dim Indice As Integer = cmbFiltrarPor.SelectedIndex
        Select Case Indice
            Case Is = 0 'Todos
                dtpDesde.Visible = False
                dtpHasta.Visible = False
                lblBuscar.Visible = False
                lblHasta.Visible = False
                IndiceConcepto = CmbConcepto.SelectedIndex
                Select Case IndiceConcepto
                    Case Is = 0 'Todos
                        TablaGasto = Compra.BuscViewGasto("ORDER BY idGasto DESC")
                    Case Else 'Algun Concepto
                        Dim Concepto As String = CmbConcepto.Text
                        TablaGasto = Compra.BuscViewGasto("WHERE Descripcion = '" + Concepto + "'  ORDER BY idGasto DESC")
                End Select
                CargarTabla(TablaGasto)
            Case Is = 1 'Fecha
                dtpDesde.Visible = True
                dtpHasta.Visible = True
                lblBuscar.Visible = True
                lblHasta.Visible = True
                dtpDesde.Value = Now
                dtpHasta.Value = Now
        End Select
    End Sub

    Private Sub cmbMotivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbConcepto.SelectedIndexChanged, dtpDesde.ValueChanged, dtpHasta.ValueChanged
        Dim IndiceFiltrar As Integer = cmbFiltrarPor.SelectedIndex
        IndiceConcepto = CmbConcepto.SelectedIndex
        Select Case IndiceFiltrar
            Case Is = 0 'Todos
                Select Case IndiceConcepto
                    Case Is = 0 'Todos
                        TablaGasto = Compra.BuscViewGasto("ORDER BY idGasto DESC")
                    Case Else 'Algun concepto
                        Dim Concepto As String = CmbConcepto.Text
                        TablaGasto = Compra.BuscViewGasto("WHERE Descripcion = '" + Concepto + "'  ORDER BY idGasto DESC")
                End Select
            Case Is = 1 'Fecha
                Dim Fecha1 As String = Format(dtpDesde.Value, "yyyy-MM-dd")
                Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, dtpHasta.Value), "yyyy-MM-dd")
                Select Case IndiceConcepto
                    Case Is = 0 'Todos
                        TablaGasto = Compra.BuscViewGasto("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' ORDER BY idGasto DESC")
                    Case Else 'Algun concepto
                        Dim Concepto As String = CmbConcepto.Text
                        TablaGasto = Compra.BuscViewGasto("WHERE Fecha > '" + Fecha1 + "' and Fecha < '" + Fecha2 + "' AND Descripcion = '" + Concepto + "'  ORDER BY idGasto DESC")
                End Select
        End Select
        CargarTabla(TablaGasto)
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim IdGasto As Integer = CInt(Tabla.Rows(i).Item(0))
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(2))
                Dim Concepto As String = CStr(Tabla.Rows(i).Item(1))
                Dim Importe As Integer = CInt(Tabla.Rows(i).Item(3))
                DataGridView1.Rows.Add(IdGasto, Fecha, Concepto, Importe)
            Next
        End If
    End Sub
End Class