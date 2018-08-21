Option Strict On

Public Class FListaHabitacion2
    Dim Habitacion As New CHabitacion

    Private Sub FListaHabitaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Precio1.HeaderText = Habitacion.GetDescrip(1)
        Precio2.HeaderText = Habitacion.GetDescrip(2)
        Precio3.HeaderText = Habitacion.GetDescrip(3)
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
        Dim Tabla As DataTable = Habitacion.ViewAll2()
        Dim Filas As Integer = Tabla.Rows.Count
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                Dim Id As UInt64 = CULng(Tabla.Rows(i).Item(0))
                Dim Precio1 As String = CStr(Tabla.Rows(i).Item(1))
                Dim Precio2 As String = CStr(Tabla.Rows(i).Item(2))
                Dim Precio3 As String = CStr(Tabla.Rows(i).Item(3))
                DataGridView1.Rows.Add(Id, Precio1, Precio2, Precio3)
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim Row As Integer = e.RowIndex
            Dim IdHab As Integer = CInt(DataGridView1.Item(0, Row).Value)
            Dim Precio1 As String = CStr(DataGridView1.Item(1, Row).Value)
            Dim Precio2 As String = CStr(DataGridView1.Item(2, Row).Value)
            Dim Precio3 As String = CStr(DataGridView1.Item(3, Row).Value)
            Dim Frm As New FEditarHabitacion2(IdHab, Precio1, Precio2, Precio3)
            Frm.MaximizeBox = False
            Frm.MinimizeBox = False
            Frm.ShowDialog()
            CargarTabla()
        End If
    End Sub

End Class