Option Strict On

Public Class FEditarHabitacion
    Dim Habitacion As New CHabitacion
    Dim HabServ As Integer

    Sub New(ByVal NroHab As Integer, ByVal idHabServ As Integer, ByVal Tarifa As String, ByVal Descrip As String,
                  ByVal Precio As Integer)
        InitializeComponent()
        HabServ = idHabServ
        txtNroHab.Text = CStr(NroHab)
        txtTarifa.Text = Tarifa
        txtDescrip.Text = Descrip
        txtPrecio.Text = CStr(Precio)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim NroHab As Integer = CInt(txtNroHab.Text)
        Dim Descrip As String = txtDescrip.Text
        Dim Precio As Integer

        If Descrip <> "" Then
            If txtPrecio.Text <> "" Then
                Precio = CInt(txtPrecio.Text)
                If Habitacion.Edit(NroHab, HabServ, Descrip, Precio) = True Then
                    MessageBox.Show("Habitación Editada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al editar la habitación")
                End If
            Else
                txtPrecio.Focus()
                ToolTip2.Show("Ingrese el Precio", txtPrecio, 0, -40, 3000)
            End If
        Else
            txtDescrip.Focus()
            ToolTip2.Show("Ingrese la Descripción", txtDescrip, 0, -40, 3000)
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
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
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

End Class