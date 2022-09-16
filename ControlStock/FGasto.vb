Option Explicit On
Option Strict On

Public Class FGasto
    Dim TablaGasto As New DataTable
    Dim Compra As New CCompra
    Dim Caja As New CCaja
    Dim Importe As UInt32
    Public Property PagarDesdeCaja() As Boolean = False
    Public Property NumCaja As UInt16 = 1

    Private Sub CargarMotivos()
        TablaGasto = Compra.ListarGasto
        cmbGastos.Items.Clear()
        Dim Filas As Integer = TablaGasto.Rows.Count
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                cmbGastos.Items.Add(TablaGasto.Rows(i).Item(1))
            Next
        End If
        cmbGastos.Text = ""
        cmbGastos.Focus()
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
                    Dim id As Integer = Compra.CargarNroGasto
                    If Compra.InsertGasto(id, idGasto, Fecha, Importe) = True Then
                        If PagarDesdeCaja Then
                            Caja.Gasto(NumCaja, id)
                        End If
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

    Private Sub FGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCod.Text = CStr(Compra.CargarNroGasto)
        CargarMotivos()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub txtImporte_KeyUp(sender As Object, e As KeyEventArgs) Handles txtImporte.KeyUp
        'Agregar separador de miles
        Dim Txt As TextBox = DirectCast(sender, TextBox)
        If (Txt.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(Txt.Text, importe)
            Txt.Text = String.Format("{0:N0}", importe)
            Txt.SelectionStart = Txt.TextLength
        End If
    End Sub

End Class