Option Strict On
Public Class FGasto
    Dim TablaGasto As New DataTable
    Dim Compra As New CCompra
    Dim Importe As UInt32

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = Me.WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CargarMotivos()
        TablaGasto = Compra.ListarGasto
        cmbGastos.Items.Clear()
        Dim Filas As Integer = TablaGasto.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                cmbGastos.Items.Add(TablaGasto.Rows(i).Item(1))
            Next
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim idGasto As UInt32
        Dim Fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim Importe As UInt32
        Try
            Importe = CUInt(txtImporte.Text)
            If txtImporte.Text <> "" Then
                If cmbGastos.SelectedIndex >= 0 Then
                    idGasto = CUInt(TablaGasto.Rows(cmbGastos.SelectedIndex).Item(0))
                    If Compra.InsertGasto(Compra.CargarNroGasto, idGasto, Fecha, Importe) = True Then
                        MessageBox.Show("Se ha registrado la operación")
                        Me.Close()
                    Else
                        MessageBox.Show("Hubo un problema al realizar la operación")
                    End If
                Else
                    cmbGastos.Focus()
                    ToolTip2.Show("Seleccione el concepto del gasto de la lista", cmbGastos, 0, -40, 3000)
                End If
            Else
                txtImporte.Focus()
                ToolTip2.Show("Ingrese el Importe", txtImporte, 0, -40, 3000)
            End If
        Catch ex As Exception
            txtImporte.Focus()
            txtImporte.Select(0, txtImporte.Text.Length)
            ToolTip2.Show("Ingrese una cantidad válida", txtImporte, 0, -40, 3000)
        End Try
    End Sub

    Private Sub cmbMotivos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGastos.Click, cmbGastos.GotFocus
        cmbGastos.DroppedDown = True
    End Sub

    Private Sub pbxNewMotivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxNewGasto.Click
        Dim frm As New FNuevoGasto
        frm.TopMost = True
        frm.ShowDialog()
        CargarMotivos()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxEditGasto.Click
        Dim frm As New FListaTipoGastos
        frm.TopMost = True
        frm.ShowDialog()
        CargarMotivos()
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Letra As Char = e.KeyChar
        If Char.IsDigit(Letra) Then
            e.Handled = False
        ElseIf Char.IsControl(Letra) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            Me.ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If Letra = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCod.Text = CStr(Compra.CargarNroListaGasto)
        CargarMotivos()
    End Sub

End Class