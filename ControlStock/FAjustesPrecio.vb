Option Strict On
Option Explicit On

Public Class FAjustesPrecio
    Dim oProducto As New CProducto

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Porcentaje As Integer
        Dim Multiplo As Integer
        Dim Activo As Integer = CInt(chkActivo.Checked)

        If TxtPorcentaje.Text <> "" Then
            If TxtMultiplo.Text <> "" Then
                Porcentaje = CInt(TxtPorcentaje.Text)
                Multiplo = CInt(TxtMultiplo.Text)
                If oProducto.Ajustes(Porcentaje, Multiplo, Activo) = True Then
                    MessageBox.Show("Los ajustes se guardaron correctamente")
                    Me.Hide()
                Else
                    MessageBox.Show("Hubo un problema al guardar los ajustes")
                End If
            Else
                TxtPorcentaje.Focus()
                ToolTip2.Show("Ingrese un valor", TxtMultiplo, 0, -40, 3000)
            End If
        Else
            TxtPorcentaje.Focus()
            ToolTip2.Show("Ingrese un valor", TxtPorcentaje, 0, -40, 3000)
        End If
    End Sub

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Tabla As DataTable = oProducto.VerAjustes
        TxtPorcentaje.Text = CStr(Tabla.Rows(0).Item(1))
        TxtMultiplo.Text = CStr(Tabla.Rows(0).Item(2))
        chkActivo.Checked = CBool(Tabla.Rows(0).Item(3))
    End Sub

    Private Sub FEditarHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip2.IsBalloon = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub txtTol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPorcentaje.KeyPress
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
        Me.Hide()
    End Sub


End Class