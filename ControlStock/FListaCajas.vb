Option Strict On
Public Class FListaCajas
    Dim Caja As New CCaja
    Dim TablaCaja As New DataTable
    Dim ModoVentaValue As Boolean
    Dim NumCaja As Integer = 1
    Dim CIValue As String

    Private Sub DtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DtpFecha.ValueChanged
        Dim Fecha As String = Format(DtpFecha.Value, "yyyy-MM-dd")
        TablaCaja = Caja.BuscarView(Fecha)
        CargarTabla(TablaCaja)
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim Empleado As String = CStr(Tabla.Rows(i).Item(0))
                Dim Caja As UInt16 = CUShort(Tabla.Rows(i).Item(1))
                Dim FechaIni As String = CStr(Tabla.Rows(i).Item(2))
                Dim HoraIni As TimeSpan = CType(Tabla.Rows(i).Item(3), TimeSpan)
                Dim MontoIni As Integer = CInt(Tabla.Rows(i).Item(4))
                Dim FechaFin As String
                Dim HoraFin As TimeSpan
                Dim MontoFin As Integer
                Try
                    FechaFin = CStr(Tabla.Rows(i).Item(5))
                    HoraFin = CType(Tabla.Rows(i).Item(6), TimeSpan)
                    MontoFin = CInt(Tabla.Rows(i).Item(7))
                    DataGridView1.Rows.Add(Empleado, Caja, FechaIni, HoraIni.ToString("hh\:mm"), MontoIni, FechaFin, HoraFin.ToString("hh\:mm"), MontoFin)
                Catch
                    DataGridView1.Rows.Add(Empleado, Caja, FechaIni, HoraIni.ToString("hh\:mm"), MontoIni, "Abierto", "---", "---")
                End Try
            Next
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

    Private Sub LblAbrirCaja_Click(sender As Object, e As EventArgs) Handles LblAbrirCaja.Click
        If Caja.CajaAbierta(NumCaja) = False Then
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CIValue
            Frm.MdiParent = MdiParent
            Frm.Show()
        Else
            MessageBox.Show("La caja ya está abierta")
        End If
    End Sub

    Private Sub LblCerrarCaja_Click(sender As Object, e As EventArgs) Handles LblCerrarCaja.Click
        If Caja.CajaAbierta(NumCaja) Then
            Dim Frm As New FCajaMostrador
            Frm.CIEmpleado = CIValue
            Frm.ModoAbrir = False
            Frm.MdiParent = MdiParent
            Frm.Show()
        Else
            MessageBox.Show("La caja ya está cerrada")
        End If
    End Sub

    Private Sub LblResumenCaja_Click(sender As Object, e As EventArgs) Handles LblResumenCaja.Click
        Try
            Dim Frm As New FResumenCaja
            Frm.CIEmpleado = CIValue
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Frm.Fecha = CDate(TablaCaja.Rows(row).Item(2))
            Frm.Hora = CType(TablaCaja.Rows(row).Item(3), TimeSpan).ToString
            Frm.DesdeHistorial = True
            Frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FListaCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFecha.Value = Today
    End Sub

End Class