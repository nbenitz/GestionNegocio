Option Strict On
Public Class FCajaMostrador
    Dim Caja As New CCaja
    Dim Empleado As New CEmpleado
    Dim CIValue As String
    Dim NumCaja As UInt16 = 1
    Public Event CajaOpenClosed()

    Public Enum Tipo As Integer
        Abrir = 0
        Cerrar = 1
        Gasto = 2
    End Enum
    Dim ModoValue As Integer

    Private Sub FCajaMostrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub CargarEmple()
        Dim TablaEmple As DataTable = Empleado.CargarEmple(CIValue)
        Dim Nombre As String = CStr(TablaEmple.Rows(0).Item(1)) + " " + CStr(TablaEmple.Rows(0).Item(2))
        TxtEmpleado.Text = If(Nombre.Length <= 20, Nombre, Nombre.Substring(0, 15) + "...")
    End Sub

    Public Property CIEmpleado() As String
        Get
            CIEmpleado = CIValue
        End Get
        Set(ByVal value As String)
            CIValue = value
        End Set
    End Property

    'Public WriteOnly Property ModoAbrir() As Boolean
    'Set(ByVal value As Boolean)
    '       ModoAbrirValue = value
    'End Set
    'End Property

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnAbrirCancelar.Click
        Hide()
    End Sub

    Private Sub btnAbrirAceptar_Click(sender As Object, e As EventArgs) Handles btnAbrirAceptar.Click
        If ModoValue = Tipo.Abrir Then
            Dim MontoInicial As UInt32
            Try
                MontoInicial = CUInt(TxtMontoInicial.Text)
                If TxtMontoInicial.Text <> "" Then
                    If Caja.Abrir(NumCaja, CUInt(CIValue), MontoInicial) = True Then
                        RaiseEvent CajaOpenClosed()
                        MessageBox.Show("La Caja se ha abierto correctamente")
                        Hide()
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
        End If
    End Sub

    Private Sub MostrarResumen()
        Dim Frm As New FResumenCaja
        Frm.CIEmpleado = CIValue
        Frm.Fecha = CDate(LblFecha.Text)
        Frm.DesdeHistorial = True
        Frm.MdiParent = MdiParent
        Frm.Show()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Hide()
    End Sub

    Private Sub TxtMontoInicial_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtMontoInicial.KeyUp, txtMontoReal.KeyUp, txtMontoRetiro.KeyUp
        'Agregar separador de miles
        Dim Txt As TextBox = DirectCast(sender, TextBox)
        If (Txt.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(Txt.Text, importe)
            Txt.Text = String.Format("{0:N0}", importe)
            Txt.SelectionStart = Txt.TextLength
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGasto.Click
        Dim Frm As New FGasto
        Frm.PagarDesdeCaja = True
        Frm.NumCaja = NumCaja
        Frm.ShowDialog()
    End Sub

    Private Sub txtMontoReal_TextChanged(sender As Object, e As EventArgs) Handles txtMontoReal.TextChanged
        Dim MontoCierre As Integer = CInt(lblMontoCaja.Text)
        Dim Retiro As Integer = CInt(txtMontoRetiro.Text)
        Dim MontoReal As Integer
        Try
            If txtMontoReal.Text <> "" Then
                MontoReal = CInt(txtMontoReal.Text)
                If MontoReal < MontoCierre Then
                    lblFaltante.Text = String.Format("{0:N0}", CDec(MontoCierre - MontoReal))
                    pnlFaltante.Visible = True
                    lblTitFaltante.Text = "Faltante: Gs."
                ElseIf MontoReal > MontoCierre Then
                    pnlFaltante.Visible = True
                    lblFaltante.Text = String.Format("{0:N0}", CDec(MontoReal - MontoCierre))
                    lblTitFaltante.Text = "Sobrante: Gs."
                Else
                    lblFaltante.Text = "0"
                    pnlFaltante.Visible = False
                End If
            Else
                lblFaltante.Text = "0"
                pnlFaltante.Visible = True
            End If
            lblMontoSgteCaja.Text = String.Format("{0:N0}", CDec(MontoReal - Retiro))
        Catch
        End Try
    End Sub

    Private Sub txtMontoRetiro_TextChanged(sender As Object, e As EventArgs) Handles txtMontoRetiro.TextChanged
        Dim MontoCierre As Integer = CInt(lblMontoCaja.Text)
        If txtMontoReal.Text <> "" Then
            MontoCierre = CInt(txtMontoReal.Text)
        End If
        Dim MontoRetiro As Integer
        Try
            If txtMontoRetiro.Text <> "" Then
                MontoRetiro = CInt(txtMontoRetiro.Text)
                If MontoRetiro <= MontoCierre Then
                    lblMontoSgteCaja.Text = String.Format("{0:N0}", CDec(MontoCierre - MontoRetiro))
                ElseIf MontoRetiro > MontoCierre Then
                    MessageBox.Show("El monto a retirar no puede ser superior al monto que existe en la caja")
                End If
            Else
                lblMontoSgteCaja.Text = "0"
            End If
        Catch
        End Try
    End Sub

    Private Sub pbxInfo_Click(sender As Object, e As EventArgs) Handles pbxInfo2.Click
        pnlInfo2.Visible = True
        pnlInfo2.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pnlInfo2.Visible = False
    End Sub

    Private Sub TxtMontoInicial_TextChanged(sender As Object, e As EventArgs) Handles TxtMontoInicial.TextChanged
        Dim MontoAnterior As Integer = CInt(lblMontoCaja.Text)
        Dim MontoInicial As Integer
        Try
            If TxtMontoInicial.Text <> "" Then
                MontoInicial = CInt(TxtMontoInicial.Text)
                lblMontoDiferencia.Text = String.Format("{0:N0}", CDec(MontoAnterior - MontoInicial))
            Else
                lblMontoDiferencia.Text = String.Format("{0:N0}", CDec(MontoAnterior))
            End If
        Catch
        End Try
    End Sub

    Private Sub btnCerrarAceptar_Click(sender As Object, e As EventArgs) Handles btnCerrarAceptar.Click
        If ModoValue = Tipo.Cerrar Then
            Try
                If txtMontoReal.Text <> "" Then
                    Dim MontoFinalDeclarado As Integer = CInt(txtMontoReal.Text)
                    Dim MontoRetiro As Integer
                    If txtMontoRetiro.Text = "" Then
                        MontoRetiro = 0
                    Else
                        MontoRetiro = CInt(txtMontoRetiro.Text)
                    End If

                    If Caja.Cerrar(NumCaja, MontoFinalDeclarado, MontoRetiro) = True Then
                        'MessageBox.Show("La Caja se ha cerrado correctamente")
                        RaiseEvent CajaOpenClosed()
                        Cursor.Current = Cursors.WaitCursor
                        MostrarResumen()
                        Hide()
                    Else
                        MessageBox.Show("Hubo un problema al cerrar la caja")
                    End If

                Else
                    txtMontoReal.Focus()
                    ToolTip2.Show("Ingrese el Monto", txtMontoReal, 0, -40, 3000)
                End If
            Catch ex As Exception
                txtMontoReal.Focus()
                txtMontoReal.Select(0, txtMontoReal.Text.Length)
                ToolTip2.Show("Ingrese una cantidad válida", txtMontoReal, 0, -40, 3000)
            End Try
        End If
    End Sub

    Private Sub btnCerrarCancelar_Click(sender As Object, e As EventArgs) Handles btnCerrarCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Cursor.Current = Cursors.WaitCursor
        MostrarResumen()
    End Sub


    Public WriteOnly Property Modo() As Tipo
        Set(ByVal value As Tipo)
            ModoValue = value
            CargarEmple()

            Select Case ModoValue
                Case Is = Tipo.Cerrar
                    lblTitulo.Text = "Cierre de Caja"
                    lblCajaActual.Text = "Caja Actual"
                    Dim importe As Integer = Caja.MontoCierre(NumCaja)
                    lblMontoCaja.Text = String.Format("{0:N0}", importe)
                    txtMontoReal.Text = String.Format("{0:N0}", importe)
                    txtMontoRetiro.Text = "0"
                    lblMontoSgteCaja.Text = String.Format("{0:N0}", importe)
                    LblFecha.Text = CDate(Caja.FechaApertura(NumCaja)).ToString("dd MMM yyy HH:mm:ss")
                    LblFecha.Visible = True
                    LblFechaApertura.Visible = True
                    btnCerrar.Visible = False
                    btnGasto.Visible = False
                    btnCompra.Visible = False
                    btnIngreso.Visible = False
                    btnReporte.Visible = True
                    pnlAbrir.Visible = False
                    pnlCerrar.Visible = True
                    pbxInfo1.Visible = True

                Case Is = Tipo.Abrir
                    lblTitulo.Text = "Apertura de Caja"
                    lblCajaActual.Text = "Caja Anterior"
                    LblFecha.Visible = False
                    LblFechaApertura.Visible = False
                    Dim MontoAnterior As Integer = Caja.LastMontoFinal(NumCaja)
                    lblMontoCaja.Text = String.Format("{0:N0}", MontoAnterior)
                    TxtMontoInicial.Text = String.Format("{0:N0}", MontoAnterior)
                    btnCerrar.Visible = False
                    btnGasto.Visible = False
                    btnCompra.Visible = False
                    btnIngreso.Visible = False
                    btnReporte.Visible = False
                    pbxInfo1.Visible = False
                    pnlCerrar.Visible = False
                    pnlAbrir.Visible = True

                Case Is = Tipo.Gasto
                    lblTitulo.Text = "Caja - Registrar Gasto"
                    lblCajaActual.Text = "Caja Actual"
                    pnlAbrir.Visible = False
                    pnlCerrar.Visible = False

                    Dim importe As Integer = Caja.MontoCierre(NumCaja)
                    lblMontoCaja.Text = String.Format("{0:N0}", importe)
                    LblFecha.Text = CDate(Caja.FechaApertura(NumCaja)).ToString("dd MMM yyy HH:mm:ss")
                    LblFecha.Visible = True
                    LblFechaApertura.Visible = True

                    btnCerrar.Visible = False
                    btnGasto.Visible = True
                    btnCompra.Visible = False
                    btnIngreso.Visible = False
                    btnReporte.Visible = False

                    pbxInfo1.Visible = True

            End Select

        End Set
    End Property

    Private Sub pbxInfo1_Click(sender As Object, e As EventArgs) Handles pbxInfo1.Click
        pnlInfo1.Visible = True
        pnlInfo1.BringToFront()
    End Sub

    Private Sub pbxCerrarPnlInfo1_Click(sender As Object, e As EventArgs) Handles pbxCerrarPnlInfo1.Click
        pnlInfo1.Visible = False
    End Sub
End Class