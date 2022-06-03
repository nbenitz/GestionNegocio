Option Strict On
Public Class FBalance
    Dim oVenta As New CVenta
    Dim oMembresia As New CMembresia
    Dim oCompra As New CCompra

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CargarIngreso(ByVal Fecha1 As String, ByVal Fecha2 As String)
        dgvIngreso.Rows.Clear()
        txtTotalI.Text = "0"
        'Dim Tabla As DataTable
        'Tabla = oVenta.BuscViewVenta(Fecha1, Fecha2)
        'CargarTablaI(Tabla, "Ventas al Contado")
        'Tabla = oVenta.BuscRecibo2(Fecha1, Fecha2)
        'CargarTablaI(Tabla, "Abono de Clientes sobre ventas")
        'Tabla = oVenta.BuscNota(Fecha1, Fecha2)
        'CargarTablaI(Tabla, "Devoluciones")
        'Tabla = oMembresia.BuscViewMembresia(Fecha1, Fecha2)
        'CargarTablaI(Tabla, "Membresía")

        Dim Tabla As DataTable = oVenta.BuscViewIngreso(Fecha1, Fecha2)
        CargarTablaI(Tabla)
    End Sub

    Private Sub CargarIngreso(ByVal Año As String)
        dgvIngreso.Rows.Clear()
        txtTotalI.Text = "0"
        Dim Tabla As DataTable
        Tabla = oVenta.BuscIngreso("zventasxmes", Año)
        CargarTablaI2(Tabla, "Ventas al Contado")
        Tabla = oVenta.BuscIngreso("zrecibocobroxmes", Año)
        CargarTablaI2(Tabla, "Abono de Clientes")
        Tabla = oVenta.BuscIngreso("znotavxmes", Año)
        CargarTablaI2(Tabla, "Devoluciones")
        Tabla = oVenta.BuscIngreso("zmembresiasxmes", Año)
        CargarTablaI2(Tabla, "Pagos de Membresía")
    End Sub

    Private Sub CargarEgreso(ByVal Fecha1 As String, ByVal Fecha2 As String)
        dgvEgreso.Rows.Clear()
        txtTotalE.Text = "0"
        Dim Tabla As DataTable
        Tabla = oCompra.BuscViewCompra(Fecha1, Fecha2)
        CargarTablaE(Tabla, "Compras al Contado")
        Tabla = oCompra.BuscRecibo2(Fecha1, Fecha2)
        CargarTablaE(Tabla, "Abono a Proveedores")
        Tabla = oCompra.BuscNota(Fecha1, Fecha2)
        CargarTablaE(Tabla, "Devoluciones")
        Tabla = oCompra.BuscGasto(Fecha1, Fecha2)
        CargarTablaE(Tabla, "Gastos Generales")
    End Sub

    Private Sub CargarEgreso(ByVal Año As String)
        dgvEgreso.Rows.Clear()
        txtTotalE.Text = "0"
        Dim Tabla As DataTable
        Tabla = oCompra.BuscEgreso("zcomprasxmes", Año)
        CargarTablaE2(Tabla, "Compras al Contado")
        Tabla = oCompra.BuscEgreso("zrecibopagoxmes", Año)
        CargarTablaE2(Tabla, "Abono a Proveedores")
        Tabla = oCompra.BuscEgreso("znotacxmes", Año)
        CargarTablaE2(Tabla, "Devoluciones")
        Tabla = oCompra.BuscEgreso("zgastoxmes", Año)
        CargarTablaE2(Tabla, "Gastos Generales")
    End Sub

    Private Sub CargarTablaI(ByVal Tabla As DataTable, ByVal Concepto As String)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = CInt(txtTotalI.Text)
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As String = Format(CDate(Tabla.Rows(i).Item(0)), "dd MMM yyyy")
                Dim Ingreso As Integer = CInt(Tabla.Rows(i).Item(1))
                If Concepto = "Devoluciones" Then
                    Ingreso = -Ingreso
                End If
                dgvIngreso.Rows.Add(Fecha, Concepto, Ingreso)
                SumaTotal = SumaTotal + Ingreso
            Next
        End If
        txtTotalI.Text = Format(SumaTotal, "###,##0")
    End Sub

    Private Sub CargarTablaI(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = CInt(txtTotalI.Text)
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As String = Format(CDate(Tabla.Rows(i).Item(0)), "dd MMM yyyy")
                Dim Ingreso As Integer = CInt(Tabla.Rows(i).Item(1))
                Dim Concepto As String = CStr(Tabla.Rows(i).Item(2))
                If Concepto = "Devoluciones" Then
                    Ingreso = -Ingreso
                End If
                dgvIngreso.Rows.Add(Fecha, Concepto, Ingreso)
                SumaTotal = SumaTotal + Ingreso
            Next
        End If
        txtTotalI.Text = Format(SumaTotal, "###,##0")
    End Sub

    Private Sub CargarTablaE(ByVal Tabla As DataTable, ByVal Concepto As String)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = CInt(txtTotalE.Text)
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As String = Format(CDate(Tabla.Rows(i).Item(0)), "dd MMM yyyy")
                Dim Egreso As Integer = CInt(Tabla.Rows(i).Item(1))
                If Concepto = "Devoluciones" Then
                    Egreso = -Egreso
                End If
                dgvEgreso.Rows.Add(Fecha, Concepto, Egreso)
                SumaTotal = SumaTotal + Egreso
            Next
        End If
        txtTotalE.Text = Format(SumaTotal, "###,##0")
    End Sub

    Private Sub CargarTablaI2(ByVal Tabla As DataTable, ByVal Concepto As String)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = CInt(txtTotalI.Text)
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(0))
                Dim Ingreso As Integer = CInt(Tabla.Rows(i).Item(1))
                If Concepto = "Devoluciones" Then
                    Ingreso = -Ingreso
                End If
                dgvIngreso.Rows.Add(Fecha, Concepto, Ingreso)
                SumaTotal = SumaTotal + Ingreso
            Next
        End If
        txtTotalI.Text = Format(SumaTotal, "###,##0")
    End Sub

    Private Sub CargarTablaE2(ByVal Tabla As DataTable, ByVal Concepto As String)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = CInt(txtTotalE.Text)
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(0))
                Dim Egreso As Integer = CInt(Tabla.Rows(i).Item(1))
                If Concepto = "Devoluciones" Then
                    Egreso = -Egreso
                End If
                dgvEgreso.Rows.Add(Fecha, Concepto, Egreso)
                SumaTotal = SumaTotal + Egreso
            Next
        End If
        txtTotalE.Text = Format(SumaTotal, "###,##0")
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ListarMes()
        lblMes.Visible = True
        cmbMes.Visible = True
        cmbAnho.Text = CStr(Now.Year)
        cmbMes.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub ListarAño()
        lblMes.Visible = False
        cmbMes.Visible = False
        cmbAnho.Text = ""
    End Sub

    Private Sub FBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 9
            cmbAnho.Items.Add(Now.Year - i)
        Next
        cmbVerPor.SelectedIndex = 0
    End Sub

    Private Sub cmbVerPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVerPor.SelectedIndexChanged
        Select Case cmbVerPor.SelectedIndex
            Case Is = 0 'Mensual
                ListarMes()
            Case Is = 1 'Anual
                ListarAño()
        End Select
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        Dim Mes As Integer = cmbMes.SelectedIndex + 1
        Dim fecha1 As String = cmbAnho.Text + "-" + CStr(Mes) + "-01"
        Dim fecha2 As String
        If Mes = 12 Then
            fecha2 = CStr(CInt(cmbAnho.Text) + 1) + "-01-01"
        Else
            fecha2 = cmbAnho.Text + "-" + CStr(Mes + 1) + "-01"
        End If
        CargarIngreso(fecha1, fecha2)
        CargarEgreso(fecha1, fecha2)
        Dim Balance As Integer = CInt(txtTotalI.Text) - CInt(txtTotalE.Text)
        txtBalance.Text = Format(Balance, "###,##0")
        If Balance < 0 Then
            txtBalance.ForeColor = Color.Red
        Else
            txtBalance.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbAnho_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnho.SelectedIndexChanged
        If cmbVerPor.SelectedIndex = 0 And cmbAnho.Focused = True Then
            cmbMes.Text = ""
            cmbMes.DroppedDown = True
        ElseIf cmbVerPor.SelectedIndex = 1 Then
            CargarIngreso(cmbAnho.Text)
            CargarEgreso(cmbAnho.Text)
            Dim Balance As Integer = CInt(txtTotalI.Text) - CInt(txtTotalE.Text)
            txtBalance.Text = Format(Balance, "###,##0")
            If Balance < 0 Then
                txtBalance.ForeColor = Color.Red
            Else
                txtBalance.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class