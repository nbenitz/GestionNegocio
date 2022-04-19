
Public Class FComision
    Dim Empleado As New CEmpleado
    Dim Venta As New CVenta
    Dim TablaEmple As New DataTable
    Dim Anho As Integer = Now.Year
    Dim Mes As Integer = Now.Month
    Dim FechaInicial As Date, FechaFinal As Date
    Dim SemanaInicial As Integer
    Dim SemanaFinal As Integer
    Dim SemanaActual As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 9
            cmbAno.Items.Add(Now.Year - i)
        Next
        cmbAno.Text = CStr(Now.Year)
        TablaEmple = Empleado.ListarEmple()
        cmbVendedor.Items.Clear()
        cmbVendedor.Items.Add("Todos")
        Dim Filas As Integer = TablaEmple.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                cmbVendedor.Items.Add(CStr(TablaEmple.Rows(i).Item(1)) + " " + CStr(TablaEmple.Rows(i).Item(2)))
            Next
        End If
        cmbVendedor.SelectedIndex = 0
        cmbMes.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged '', cmbAno.SelectedIndexChanged
        MostrarSemana()
    End Sub

    Private Sub MostrarSemana()
        Dim V1, S1, S2 As Integer
        Mes = cmbMes.SelectedIndex + 1
        Anho = CInt(cmbAno.Text)

        SemanaInicial = DatePart(DateInterval.WeekOfYear, _
        New Date(Anho, Mes, 1), _
        FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)

        SemanaActual = DatePart(DateInterval.WeekOfYear, Now, _
        FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)

        If Mes < 12 Then
            SemanaFinal = DatePart(DateInterval.WeekOfYear, _
            New Date(Anho, Mes + 1, 1).AddDays(-1), _
            FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
        Else
            SemanaFinal = DatePart(DateInterval.WeekOfYear, _
            New Date(Anho + 1, 1, 1).AddDays(-1), _
            FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
        End If
        S1 = SemanaInicial
        S2 = SemanaFinal
        cmbSemana.Items.Clear()
        cmbSemana.Text = ""
        Dim Indice As Integer = 0
        For V1 = S1 To S2
            cmbSemana.Items.Add("Semana Nº : " + CType(V1, String))
            If V1 = SemanaActual And CInt(Anho) = Now.Year Then
                cmbSemana.SelectedIndex = Indice
            End If
            Indice += 1
        Next
    End Sub

    Private Sub cmbSemana_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSemana.SelectedIndexChanged
        Dim NumSemana As Integer
        Dim PrimerDia = New Date(Anho, 1, 1).DayOfWeek
        Anho = CInt(cmbAno.Text)

        NumSemana = CInt(Microsoft.VisualBasic.Right(CStr(cmbSemana.SelectedItem), 2))
        FechaInicial = DateAdd(DateInterval.WeekOfYear, NumSemana - 1,
                               DateAdd(DateInterval.Day, (-PrimerDia), CDate("01/01/" & Anho)))
        FechaInicial = DateAdd(DateInterval.Day, 1, FechaInicial)
        FechaFinal = DateAdd(DateInterval.Day, 6, FechaInicial)
        lblFechaRango.Text = "Del " + CStr(FechaInicial) + " Al " + CStr(FechaFinal)
        Consultar()
    End Sub

    Private Sub Consultar()
        Dim IndiceVend = cmbVendedor.SelectedIndex
        Dim Fecha1 As String = Format(FechaInicial, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, FechaFinal), "yyyy-MM-dd")
        Dim TablaVenta As DataTable
        Select Case IndiceVend
            Case Is = 0 'Todos
                CargarTabla2()
            Case Else 'Algun Vendedor
                Dim CI As String = CStr(TablaEmple.Rows(IndiceVend - 1).Item(0))
                TablaVenta = Empleado.BuscViewVenta(Fecha1, Fecha2, CI)
                CargarTabla(TablaVenta)
        End Select

    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        Dim SumaTotal As Integer = 0
        Dim SumaComis As Integer = 0
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Try
                    Dim CI As Integer = CInt(Tabla.Rows(i).Item(0))
                    Dim Vendedor As String = CStr(Tabla.Rows(i).Item(1))
                    Dim Total As Integer = CInt(Tabla.Rows(i).Item(2))
                    Dim Comision As Integer = CInt(Tabla.Rows(i).Item(3))
                    Dim Dia1 As String = CStr(FechaInicial.Day)
                    Dim Dia2 As String = CStr(FechaFinal.Day)
                    Dim Mes1 As String
                    Dim Mes2 As String = CStr(cmbMes.SelectedItem)
                    If CInt(Dia2) > CInt(Dia1) Then
                        Mes1 = Mes2
                    Else
                        Mes1 = CStr(cmbMes.Items.Item(cmbMes.SelectedIndex - 1))
                    End If
                    DataGridView1.Rows.Add("Del " + Dia1 + " de " + Mes1 + " Al " + Dia2 + _
                                       " de " + Mes2 + " del " + cmbAno.Text, _
                                       CI, Vendedor, Total, Comision)
                    SumaTotal = SumaTotal + Convert.ToInt32(DataGridView1.Item(3, i).Value.ToString)
                    SumaComis = SumaComis + Convert.ToInt32(DataGridView1.Item(4, i).Value.ToString)
                Catch ex As Exception

                End Try
            Next
            lblTotal.Text = CStr(SumaTotal)
            lblComision.Text = CStr(SumaComis)
        End If
    End Sub

    Private Sub CargarTabla2()
        Dim CantEmple As Integer = TablaEmple.Rows.Count
        Dim SumaTotal As Integer = 0
        Dim SumaComis As Integer = 0
        Dim Fecha1 As String = Format(FechaInicial, "yyyy-MM-dd")
        Dim Fecha2 As String = Format(DateAdd(DateInterval.Day, 1, FechaFinal), "yyyy-MM-dd")
        DataGridView1.Rows.Clear()
        For i = 0 To CantEmple - 1
            Try
                Dim CI As String = CStr(TablaEmple.Rows(i).Item(0))
                Dim TablaVenta As DataTable = Empleado.BuscViewVenta(Fecha1, Fecha2, CI)
                Dim Vendedor As String = CStr(TablaVenta.Rows(0).Item(1))
                Dim Total As Integer = CInt(TablaVenta.Rows(0).Item(2))
                Dim Comision As Integer = CInt(TablaVenta.Rows(0).Item(3))
                Dim Dia1 As String = CStr(FechaInicial.Day)
                Dim Dia2 As String = CStr(FechaFinal.Day)
                Dim Mes1 As String
                Dim Mes2 As String = CStr(cmbMes.SelectedItem)
                If CInt(Dia2) > CInt(Dia1) Then
                    Mes1 = Mes2
                Else
                    If Mes2 = "Enero" Then
                        Mes1 = "Diciembre"
                    Else
                        Mes1 = CStr(cmbMes.Items.Item(cmbMes.SelectedIndex - 1))
                    End If
                End If
                'MessageBox.Show("Del " + Dia1 + " de " + Mes1 + " Al " + Dia2 + " de " + Mes2 + " del " + cmbAno.Text)
                DataGridView1.Rows.Add("Del " + Dia1 + " de " + Mes1 + " Al " + Dia2 + _
                                       " de " + Mes2 + " del " + cmbAno.Text, _
                                       CI, Vendedor, Total, Comision)
                SumaTotal = SumaTotal + Convert.ToInt32(DataGridView1.Item(3, i).Value.ToString)
                SumaComis = SumaComis + Convert.ToInt32(DataGridView1.Item(4, i).Value.ToString)
            Catch ex As Exception

            End Try
        Next
        lblTotal.Text = CStr(SumaTotal)
        lblComision.Text = CStr(SumaComis)
    End Sub

    Private Sub cmbAno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAno.SelectedIndexChanged
        cmbSemana.Text = ""
        cmbMes.Text = ""
    End Sub

    Private Sub cmbVendedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVendedor.SelectedIndexChanged
        Consultar()
    End Sub

    Private Sub cmbAno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAno.Click

    End Sub

    Private Sub cmbMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.Click

    End Sub
End Class