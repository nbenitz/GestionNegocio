Option Strict On

Public Class FEditarHabitacion2
    Dim Habitacion As New CHabitacion

    Sub New(ByVal NroHab As Integer, ByVal Precio1 As String, ByVal Precio2 As String, ByVal Precio3 As String)
        InitializeComponent()
        txtNroHab.Text = CStr(NroHab)
        TxtPrecio1.Text = Precio1
        TxtPrecio2.Text = Precio2
        TxtPrecio3.Text = Precio3
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim NroHab As UInt16 = CUShort(txtNroHab.Text)
        Dim Precio1 As Integer
        Dim Precio2 As Integer
        Dim Precio3 As Integer

        If TxtPrecio1.Text <> "" Then
            If TxtPrecio2.Text <> "" Then
                If TxtPrecio3.Text <> "" Then
                    Precio1 = CInt(TxtPrecio1.Text)
                    Precio2 = CInt(TxtPrecio2.Text)



                    Precio3 = CInt(TxtPrecio3.Text)
                    If Habitacion.Edit2(NroHab, Precio1, Precio2, Precio3) = True Then
                        MessageBox.Show("Habitación Editada")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al editar la habitación")
                    End If
                Else
                    TxtPrecio3.Focus()
                    ToolTip2.Show("Ingrese el Precio", TxtPrecio3, 0, -40, 3000)
                End If
            Else
                TxtPrecio2.Focus()
                ToolTip2.Show("Ingrese el Precio", TxtPrecio2, 0, -40, 3000)
            End If
        Else
            TxtPrecio1.Focus()
            ToolTip2.Show("Ingrese el Precio", TxtPrecio1, 0, -40, 3000)
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub FEditarHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip2.IsBalloon = True
        LblPrecio1.Text = Habitacion.GetDescrip(1)
        LblPrecio2.Text = Habitacion.GetDescrip(2)
        LblPrecio3.Text = Habitacion.GetDescrip(3)
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio1.KeyPress, TxtPrecio2.KeyPress, TxtPrecio3.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            Me.ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class