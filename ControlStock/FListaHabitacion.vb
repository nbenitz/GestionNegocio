Option Strict On
Public Class FListaHabitacion

    Dim Habitacion As New CHabitacion

    Private Sub FListaHabitaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarTabla()
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

    Private Sub CargarTabla()
        Dim Tabla As DataTable = Habitacion.ViewAll()
        Dim Filas As Integer = Tabla.Rows.Count
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Id As UInt64 = CULng(Tabla.Rows(i).Item(0))
                Dim Descrip As String = CStr(Tabla.Rows(i).Item(1))
                Dim Precio As String = CStr(Tabla.Rows(i).Item(2))
                Dim Tarifa As String = CStr(Tabla.Rows(i).Item(3))
                DataGridView1.Rows.Add(Id, Descrip, Precio, Tarifa)
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim row As Integer = e.RowIndex
            Dim IdHab As Integer = CInt(DataGridView1.Item(0, row).Value)
            Dim Descripcion As String = CStr(DataGridView1.Item(1, row).Value)
            Dim Precio As Integer = CInt(DataGridView1.Item(2, row).Value)
            Dim Tarifa As String = CStr(DataGridView1.Item(3, row).Value)
            Dim idTarifa As Integer = Habitacion.GetId(Tarifa)
            Dim frm As New FEditarHabitacion(IdHab, idTarifa, Tarifa, Descripcion, Precio)
            frm.MaximizeBox = False
            frm.MinimizeBox = False
            frm.ShowDialog()
            CargarTabla()
        End If
    End Sub

End Class