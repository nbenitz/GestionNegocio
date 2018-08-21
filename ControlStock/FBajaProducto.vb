Option Strict On
Public Class FBajaProducto

    Dim TablaMotivo As New DataTable
    Dim Producto As New CProducto
    Dim ModoBajaValor As Boolean
    Dim Stock As Double
    Dim PresentValor As String

    Private Sub FBajaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarMotivos()
    End Sub

    Private Sub CargarMotivos()
        If ModoBajaValor = True Then
            TablaMotivo = Producto.ListarMotivoBaja
        Else
            TablaMotivo = Producto.ListarMotivoAlta
        End If
        cmbMotivos.Items.Clear()
        Dim Filas As Integer = TablaMotivo.Rows.Count
        If Filas > 0 Then
            For i = 0 To (Filas - 1)
                cmbMotivos.Items.Add(TablaMotivo.Rows(i).Item(1))
            Next
        End If
    End Sub

    Public Sub Cargar(ByVal ModoBaja As Boolean, ByVal Codigo As String, ByVal Descripcion As String, ByVal StockValue As Double, ByVal Present As String)
        ModoBajaValor = ModoBaja
        If ModoBajaValor = True Then
            Me.Text = "Baja de Productos"
        Else
            Me.Text = "Alta de Productos"
        End If
        txtCod.Text = Codigo
        txtDescrip.Text = Descripcion
        Stock = StockValue
        PresentValor = Present
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim idProd As UInt64 = CULng(txtCod.Text)
        Dim Fecha As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim Cant As Double
        Dim idMotivo As UInt16
        Try
            Cant = CDbl(txtCant.Text)
            If txtCant.Text <> "" Then
                If cmbMotivos.SelectedIndex >= 0 Then
                    idMotivo = CUShort(TablaMotivo.Rows(cmbMotivos.SelectedIndex).Item(0))
                    If ModoBajaValor = True Then
                        If CheckCant() Then
                            If Producto.InsertBaja(Producto.CargarNroBaja, idProd, Fecha, Cant, idMotivo) = True Then
                                MessageBox.Show("Se han dado de baja " + CStr(Cant) + " items.")
                                Me.Close()
                            Else
                                MessageBox.Show("Hubo un problema al realizar la operación")
                            End If
                        Else
                            MessageBox.Show("La cantidad a dar de baja no puede ser mayor al stock disponible")
                        End If
                    Else
                        If Producto.InsertAlta(Producto.CargarNroAlta, idProd, Fecha, Cant, idMotivo) = True Then
                            MessageBox.Show("Se han dado de alta " + CStr(Cant) + " items.")
                            Me.Close()
                        Else
                            MessageBox.Show("Hubo un problema al realizar la operación")
                        End If
                    End If
                Else
                    cmbMotivos.Focus()
                    ToolTip2.Show("Seleccione un Motivo de la lista", cmbMotivos, 0, -40, 3000)
                End If
            Else
                txtCant.Focus()
                ToolTip2.Show("Ingrese la Cantidad", txtCant, 0, -40, 3000)
            End If
        Catch ex As Exception
            txtCant.Focus()
            txtCant.Select(0, txtCant.Text.Length)
            ToolTip2.Show("Ingrese una cantidad válida", txtCant, 0, -40, 3000)
        End Try
    End Sub

    Private Sub cmbMotivos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMotivos.Click, cmbMotivos.GotFocus
        cmbMotivos.DroppedDown = True
    End Sub

    Private Sub pbxNewMotivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxNewMotivo.Click
        Dim frm As New FNuevoMotivo
        If ModoBajaValor = True Then
            frm.ModoBaja(True)
        Else
            frm.ModoBaja(False)
        End If
        'frm.TopMost = True
        frm.ShowDialog()
        CargarMotivos()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim frm As New FListaMotivos
        If ModoBajaValor = True Then
            frm.ModoBaja(True)
        Else
            frm.ModoBaja(False)
        End If
        frm.TopMost = True
        frm.ShowDialog()
        CargarMotivos()
    End Sub

    Private Function CheckCant() As Boolean
        Dim Cant As Double = CDbl(txtCant.Text)
        If Cant > Stock Then
            CheckCant = False
        Else
            CheckCant = True
        End If
    End Function

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        Dim Letra As Char = e.KeyChar
        If Letra = Convert.ToChar(",") Or Letra = Convert.ToChar(".") Then
            If PresentValor = "Kilo" Then
                If Letra = Convert.ToChar(",") Then
                    e.Handled = False
                Else
                    e.Handled = True
                    Caja.Text = Caja.Text + ","
                    Caja.Select(Caja.Text.Length, 0)
                End If
            Else
                e.Handled = True
                Caja.Focus()
                Me.ToolTip2.Show("Los productos por unidades o paquetes no aceptan decimales", Caja, 0, -40, 4000)
            End If
        ElseIf Char.IsDigit(Letra) Then
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

End Class