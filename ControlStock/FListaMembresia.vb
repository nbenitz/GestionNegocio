Option Explicit On
Option Strict On

Public Class FListaMembresia
    Dim Membresia As New CMembresia
    Dim TablaMembresias As New DataTable
    Dim ModoBajaValor As Boolean

    Private Sub FListaMembresia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarTabla()
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CargarTabla()
        TablaMembresias = Membresia.Listar
        Dim Filas As Integer = TablaMembresias.Rows.Count
        DataGridView1.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Nombre As String = CStr(TablaMembresias.Rows(i).Item(1))
                Dim Precio As Integer = CInt(TablaMembresias.Rows(i).Item(3))

                Dim TiempoLimite As String = CStr(TablaMembresias.Rows(i).Item(4))
                Dim TiempoUnidad As Char = CChar(TablaMembresias.Rows(i).Item(5))

                Dim VecesDia As String = CStr(TablaMembresias.Rows(i).Item(6))
                Dim DiasSemana As String = CStr(TablaMembresias.Rows(i).Item(7))
                Dim DiasMes As String = CStr(TablaMembresias.Rows(i).Item(8))

                Select Case TiempoUnidad
                    Case "M"c  'Mes
                        If CInt(TiempoLimite) > 1 Then
                            TiempoLimite = TiempoLimite + " Meses"
                        Else
                            TiempoLimite = TiempoLimite + " Mes"
                        End If
                    Case "S"c  'Semana
                        If CInt(TiempoLimite) > 1 Then
                            TiempoLimite = TiempoLimite + " Semanas"
                        Else
                            TiempoLimite = TiempoLimite + " Semana"
                        End If
                        DiasMes = ""
                    Case "D"c  'Día
                        If CInt(TiempoLimite) > 1 Then
                            TiempoLimite = TiempoLimite + " Días"
                        Else
                            TiempoLimite = TiempoLimite + " Día"
                        End If
                        DiasMes = ""
                        DiasSemana = ""
                End Select

                Dim Dias As String = CStr(TablaMembresias.Rows(i).Item(9))
                Dim HoraInicio As String = CStr(TablaMembresias.Rows(i).Item(10))
                Dim HoraFin As String = CStr(TablaMembresias.Rows(i).Item(11))

                DataGridView1.Rows.Add(Nombre, Precio, TiempoLimite, VecesDia, DiasSemana, DiasMes, Dias, HoraInicio + " a " + HoraFin)
            Next
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub lblEditar_Click(sender As Object, e As EventArgs) Handles lblEditar.Click, pbxEditar.Click, pnlEditar.Click
        Cursor.Current = Cursors.WaitCursor
        Dim row As Integer = DataGridView1.CurrentRow.Index
        Dim Id As Int32 = CInt(TablaMembresias.Rows(row).Item(0))
        Dim Nombre As String = CStr(TablaMembresias.Rows(row).Item(1))
        Dim Descripcion As String = CStr(TablaMembresias.Rows(row).Item(2))
        Dim Precio As Int32 = CInt(TablaMembresias.Rows(row).Item(3))
        Dim TiempoLimite As Int32 = CInt(TablaMembresias.Rows(row).Item(4))
        Dim TiempoUnidad As Char = CChar(TablaMembresias.Rows(row).Item(5))
        Dim VecesDia As Int32 = CInt(TablaMembresias.Rows(row).Item(6))
        Dim DiasSemana As Int32 = CInt(TablaMembresias.Rows(row).Item(7))
        Dim DiasMes As Int32 = CInt(TablaMembresias.Rows(row).Item(8))
        Dim Dias As String = CStr(TablaMembresias.Rows(row).Item(9))
        Dim HoraInicio As DateTime = CDate(TablaMembresias.Rows(row).Item(10))
        Dim HoraFin As DateTime = CDate(TablaMembresias.Rows(row).Item(11))
        Dim frm As New FNuevoMembresia
        frm.Editar(Id, Nombre, Descripcion, Precio, TiempoLimite, TiempoUnidad, VecesDia, DiasSemana, DiasMes, Dias, HoraInicio, HoraFin)
        frm.ShowDialog()
        CargarTabla()
    End Sub

    Private Sub LblEliminar_Click(sender As Object, e As EventArgs) Handles LblEliminar.Click
        Dim Result As Integer = MsgBox("Desea eliminar la membresía seleccionada?", MsgBoxStyle.YesNo, "Eliminar Membresía")
        If Result = 6 Then
            Dim row As Integer = DataGridView1.CurrentRow.Index
            Dim id As Int32 = CInt(TablaMembresias.Rows(row).Item(0))
            If Membresia.Eliminar(id) Then
                MessageBox.Show("Membresía eliminada")
                CargarTabla()
            Else
                MessageBox.Show("No se puede eliminar la Membresía. Solo las Membresías NO asignadas a un socio pueden ser eliminadas. " +
                                    "Las membresías asignadas solo pueden ser editadas.")
            End If
        End If
    End Sub
End Class