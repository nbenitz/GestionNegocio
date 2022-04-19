Option Strict On
Public Class FCajaMostrador
    Dim Caja As New CCaja
    Dim Empleado As New CEmpleado
    'Dim TablaEmple As DataTable
    Dim CIValue As String
    Dim ModoAbrirValue As Boolean = True
    Dim NumCaja As UInt16 = 1

    Private Sub FCajaMostrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmple()
        If ModoAbrirValue = False Then
            Text = "Cerrar Caja"
            btnAceptar.Text = "Cerrar Caja"
            LblMonto.Text = "Monto Final"
            TxtMontoInicial.ReadOnly = True
            TxtMontoInicial.Text = CStr(Caja.MontoCierre(NumCaja))
            LblFecha.Text = Caja.FechaApertura(NumCaja)
            LblFecha.Visible = True
            LblFecheApertura.Visible = True
        End If
    End Sub

    Private Sub CargarEmple()
        'TablaEmple = Empleado.ListarEmple()
        Dim TablaEmple As DataTable = Empleado.CargarEmple(CIValue)
        TxtEmpleado.Text = CStr(TablaEmple.Rows(0).Item(1)) + " " + CStr(TablaEmple.Rows(0).Item(2))
    End Sub

    Public Property CIEmpleado() As String
        Get
            CIEmpleado = CIValue
        End Get
        Set(ByVal value As String)
            CIValue = value
        End Set
    End Property

    Public WriteOnly Property ModoAbrir() As Boolean
        Set(ByVal value As Boolean)
            ModoAbrirValue = value
        End Set
    End Property

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ModoAbrirValue Then
            Dim MontoInicial As UInt32
            Try
                MontoInicial = CUInt(TxtMontoInicial.Text)
                If TxtMontoInicial.Text <> "" Then
                    If Caja.Abrir(NumCaja, CUInt(CIValue), MontoInicial) = True Then
                        MessageBox.Show("La Caja se ha abierto correctamente")
                        Close()
                    Else
                        MessageBox.Show("Hubo un problema al abrir la caja")
                    End If
                Else
                    TxtMontoInicial.Focus()
                    ToolTip2.Show("Ingrese el Monto Inicial", TxtMontoInicial, 0, -40, 3000)
                End If
            Catch ex As Exception
                TxtMontoInicial.Focus()
                TxtMontoInicial.Select(0, TxtMontoInicial.Text.Length)
                ToolTip2.Show("Ingrese una cantidad válida", TxtMontoInicial, 0, -40, 3000)
            End Try
        Else
            'Dim MontoFinal As UInt32
            Try
                'MontoFinal = CUInt(TxtMontoInicial.Text)
                If TxtMontoInicial.Text <> "" Then

                    If Caja.Cerrar(NumCaja) = True Then
                        'MessageBox.Show("La Caja se ha cerrado correctamente")
                        MostrarResumen()
                        Close()
                    Else
                        MessageBox.Show("Hubo un problema al cerrar la caja")
                    End If

                Else
                    TxtMontoInicial.Focus()
                    ToolTip2.Show("Ingrese el Monto Inicial", TxtMontoInicial, 0, -40, 3000)
                End If
            Catch ex As Exception
                TxtMontoInicial.Focus()
                TxtMontoInicial.Select(0, TxtMontoInicial.Text.Length)
                ToolTip2.Show("Ingrese una cantidad válida", TxtMontoInicial, 0, -40, 3000)
            End Try
        End If
    End Sub

    Private Sub MostrarResumen()
        Dim Frm As New FResumenCaja
        Frm.CIEmpleado = CIValue
        Frm.Fecha = CDate(Strings.Left(LblFecha.Text, 10))
        Frm.Hora = Strings.Right(LblFecha.Text, 8)
        Frm.DesdeHistorial = True
        Frm.MdiParent = MdiParent
        Frm.Show()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub
End Class