Option Strict On

Public Class FReporteHabitacion
    Dim Habitacion As New CHabitacion
    Dim TablaManual As DataTable
    Dim TablaSensor As DataTable
    Dim FrmPricip As FPrincipalMotel

    Private Sub FReporteHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFecha.Value = Now
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable, ByVal DataGrid As DataGridView)
        Dim Filas As Integer = Tabla.Rows.Count
        DataGrid.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim Id As UInt32 = CUInt(Tabla.Rows(i).Item(0))
                Dim NroHab As UInt16 = CUShort((Tabla.Rows(i).Item(1)))
                Dim HraEntrada As String = Format(Tabla.Rows(i).Item(2), "HH:mm")
                Dim HraSalida As String = "-"
                Try
                    HraSalida = Format(Tabla.Rows(i).Item(3), "HH:mm")
                Catch
                End Try
                DataGrid.Rows.Add(Id, NroHab, HraEntrada, HraSalida)
            Next
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DtpFecha.ValueChanged
        Dim Fecha As String = Format(DtpFecha.Value, "yyyy-MM-dd")
        TablaManual = Habitacion.VerReporteManual(Fecha)
        TablaSensor = Habitacion.VerReporteSensor(Fecha)
        CargarTabla(TablaManual, DataGridView1)
        CargarTabla(TablaSensor, DataGridView2)
        CargarTabla3()
        CargarTabla4()
        LblNroRegMot.Text = CStr(TablaManual.Rows.Count)
        LblNroRegSens.Text = CStr(TablaSensor.Rows.Count)
    End Sub

    Private Sub CargarTabla3()
        DataGridView3.Rows.Clear()

        Dim Filas As Integer = TablaSensor.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim Id As UInt32 = CUInt((TablaSensor.Rows(i).Item(0)))
                Dim NroHab As UInt16 = CUShort((TablaSensor.Rows(i).Item(1)))
                Dim HraESensor As Date = CDate(TablaSensor.Rows(i).Item(2))
                Dim HraSSensor As Date = Nothing
                Try
                    HraSSensor = CDate(TablaSensor.Rows(i).Item(3))
                Catch
                End Try
                Dim TablaAjustes As DataTable = Habitacion.VerAjustes

                Dim Registro As DataTable = Habitacion.BuscarReporteM(NroHab, HraESensor, HraSSensor)
                If Registro.Rows.Count > 0 Then
                    Dim HraEManual As Date = CDate(Registro.Rows(0).Item(2))
                    Dim HraSManual As Date = CDate(Registro.Rows(0).Item(3))
                    Dim TolEntrada As UInt16 = CUShort(TablaAjustes.Rows(0).Item(1))
                    Dim TolSalida As UInt16 = CUShort(TablaAjustes.Rows(0).Item(2))

                    If DateDiff(DateInterval.Minute, HraESensor, HraEManual) > TolEntrada Or
                            DateDiff(DateInterval.Minute, HraSManual, HraSSensor) > TolSalida Then
                        DataGridView3.Rows.Add(Id, NroHab, Format(HraESensor, "HH:mm"), Format(HraSSensor, "HH:mm"))
                    End If
                Else
                    Dim Tolerancia As UInt16 = CUShort(TablaAjustes.Rows(0).Item(3))
                    If DateDiff(DateInterval.Minute, HraESensor, HraSSensor) > Tolerancia Then
                        DataGridView3.Rows.Add(Id, NroHab, Format(HraESensor, "HH:mm"), Format(HraSSensor, "HH:mm"))
                    End If
                    If HraSSensor = #1/1/0001 12:00:00 AM# Then
                        DataGridView3.Rows.Add(Id, NroHab, Format(HraESensor, "HH:mm"), "-")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub CargarTabla4()
        DataGridView4.Rows.Clear()

        Dim Filas As Integer = TablaManual.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim Id As UInt32 = CUInt((TablaManual.Rows(i).Item(0)))
                Dim NroHab As UInt16 = CUShort((TablaManual.Rows(i).Item(1)))
                Dim HraEManual As Date = CDate(TablaManual.Rows(i).Item(2))
                Dim HraSManual As Date = Nothing
                Try
                    HraSManual = CDate(TablaManual.Rows(i).Item(3))
                Catch
                End Try
                Dim TablaAjustes As DataTable = Habitacion.VerAjustes

                Dim Registro As DataTable = Habitacion.BuscarReporteS(NroHab, HraEManual, HraSManual)
                If Registro.Rows.Count > 0 Then
                    Dim HraESensor As Date = CDate(Registro.Rows(0).Item(2))
                    Dim HraSSensor As Date = CDate(Registro.Rows(0).Item(3))
                    Dim TolEntrada As UInt16 = CUShort(TablaAjustes.Rows(0).Item(1))
                    Dim TolSalida As UInt16 = CUShort(TablaAjustes.Rows(0).Item(2))

                    If DateDiff(DateInterval.Minute, HraEManual, HraESensor) > TolEntrada Or
                            DateDiff(DateInterval.Minute, HraSSensor, HraSManual) > TolSalida Then
                        DataGridView4.Rows.Add(Id, NroHab, Format(HraEManual, "HH:mm"), Format(HraSManual, "HH:mm"))
                    End If
                Else
                    Dim Tolerancia As UInt16 = CUShort(TablaAjustes.Rows(0).Item(3))
                    If DateDiff(DateInterval.Minute, HraEManual, HraSManual) > Tolerancia Then
                        DataGridView4.Rows.Add(Id, NroHab, Format(HraEManual, "HH:mm"), Format(HraSManual, "HH:mm"))
                    End If
                    If HraSManual = #1/1/0001 12:00:00 AM# Then
                        DataGridView4.Rows.Add(Id, NroHab, Format(HraEManual, "HH:mm"), "-")
                    End If
                End If
            Next
        End If
    End Sub

End Class