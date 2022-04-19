Option Strict On
Option Explicit On
Imports System.Drawing.Drawing2D
Public Class FEventoAcceso
    Dim WithEvents EventoAcceso As New EventByDeploy
    'Dim ControlPuerta As New ControlDoor.ControlDoor
    Dim Cliente As New CCliente
    Dim Acceso As New CAcceso
    Dim Membresia As New CMembresia
    Dim Venta As New CVenta
    Dim WithEvents FrmCuentasCobrar As New FCuentasCobrar
    Dim WithEvents FrmSocio As New FNuevoSocio
    Dim DiasTolerancia As Integer = 0
    Dim CIValue As String

    Delegate Sub InsertIntoTableCallBack(ByVal tiempo As DateTime,
                                         ByVal Codigo As UInteger,
                                         ByVal Nombre As String)

    Delegate Sub ShowClientInfoCallBack(ByVal Nombre As String,
                                        ByVal Foto As Byte())

    Delegate Sub ShowClientStatusCallBack(ByVal Membresia As String,
                                          ByVal Vencimiento As Date,
                                          ByVal Atraso As Integer,
                                          ByVal SaldoPendiente As Integer)

    Delegate Sub MostrarCodigoCallBack(ByVal Codigo As UInteger)


    Private Sub onMsgRecibido(ByVal Tiempo As DateTime, ByVal Codigo As UInteger)
        MostrarCodigo(Codigo)
        Dim TablaSocio As DataTable = Cliente.BuscSocio("WHERE acceso = " + CStr(Codigo))
        If TablaSocio.Rows.Count > 0 Then
            Dim CI As String = CStr(TablaSocio.Rows(0).Item(0))
            CIValue = CI

            If GetClientStatus(CI) Then
                EventoAcceso.OpenDoor()
                If Acceso.InsertClienteAsistencia(CI, Tiempo, " ") = False Then
                    MessageBox.Show("Hubo un problema al registrar el acceso.")
                End If
            End If

            Dim Nombre As String = CStr(TablaSocio.Rows(0).Item(1))
            Dim Foto As Byte()
            Try
                Foto = CType(TablaSocio.Rows(0).Item(8), Byte())
            Catch
            End Try

            Me.InsertIntoTable(Tiempo, Codigo, Nombre)
            Me.ShowClientInfo(Nombre, Foto)
        End If
    End Sub

    Private Sub onLoginSuccess()
        lblConectado.ForeColor = Color.White
        lblConectado.BackColor = Color.Red
        lblConectado.Text = "Conectar"
    End Sub

    Private Sub onCallBackSucc()
        lblConectado.Text = "Conectado"
        lblConectado.ForeColor = Color.Lime
        lblConectado.BackColor = Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
    End Sub

    Private Sub onLoginError()
        lblConectado.Text = "Error de Conexión"
        lblConectado.ForeColor = Color.White
        lblConectado.BackColor = Color.Red
    End Sub

    Function GetClientStatus(ByVal CI As String) As Boolean
        Dim TablaMembresia As DataTable = Membresia.BuscarPagoPeriodo(CI)
        If TablaMembresia.Rows.Count > 0 Then
            Dim NombreMembresia As String = CStr(TablaMembresia.Rows(0).Item(3))
            Dim Vto As Date = CDate(TablaMembresia.Rows(0).Item(5))
            Dim Atraso As Integer = CInt(TablaMembresia.Rows(0).Item(9))
            If Atraso > DiasTolerancia Then
                GetClientStatus = False
            Else
                GetClientStatus = True
            End If
            Me.ShowClientStatus(NombreMembresia, Vto, Atraso, GetSaldoPendiente(CI))
            Return GetClientStatus
        End If
    End Function

    Function GetSaldoPendiente(ByVal CI As String) As Integer
        Dim TablaCuenta As DataTable = Venta.BuscViewCuentas("WHERE CI='" + CI + "'")
        Dim SaldoPendiente As Integer = 0
        If TablaCuenta.Rows.Count > 0 Then
            For i As Integer = 0 To (TablaCuenta.Rows.Count - 1)
                Dim Total As Integer = CInt(TablaCuenta.Rows(i).Item(6))
                Dim Entregado As Integer = CInt(TablaCuenta.Rows(i).Item(7))
                SaldoPendiente += CInt(Total) - CInt(Entregado)
            Next
        End If
        Return SaldoPendiente
    End Function

    Public Sub MostrarCodigo(ByVal Codigo As UInteger)
        If Me.lblUltimaClave.InvokeRequired Then
            Dim d As New MostrarCodigoCallBack(AddressOf MostrarCodigo)
            Me.Invoke(d, New Object() {Codigo})
        Else
            lblUltimaClave.Text = CStr(Codigo)
        End If
    End Sub

    Public Sub InsertIntoTable(ByVal Tiempo As DateTime,
                               ByVal Codigo As UInteger,
                               ByVal Nombre As String)
        If Me.dgvAccesos.InvokeRequired Then
            Dim d As New InsertIntoTableCallBack(AddressOf InsertIntoTable)
            Me.Invoke(d, New Object() {Tiempo, Codigo, Nombre})
        Else
            dgvAccesos.Rows.Insert(0, CStr(Codigo), CStr(Tiempo), Nombre)
        End If
    End Sub


    Public Sub ShowClientInfo(ByVal Nombre As String,
                              ByVal Foto As Byte())
        If Me.dgvAccesos.InvokeRequired Then
            Dim d As New ShowClientInfoCallBack(AddressOf ShowClientInfo)
            Me.Invoke(d, New Object() {Nombre, Foto})
        Else
            lblNombre.Text = If(Nombre.Length <= 20, Nombre, Nombre.Substring(0, 20) + "...")
            pbxFoto.Image = If(Foto IsNot Nothing, ByteArrayToImage(Foto), My.Resources.userblack)
            pnlSocioInfo.Visible = True
        End If
    End Sub

    Public Sub ShowClientInfo(ByVal Codigo As String)
        If Me.dgvAccesos.InvokeRequired Then
            Dim d As New ShowClientInfoCallBack(AddressOf ShowClientInfo)
            Me.Invoke(d, New Object() {Codigo})
        Else
            Dim TablaSocio As DataTable = Cliente.BuscSocio("WHERE acceso = " + Codigo)
            If TablaSocio.Rows.Count > 0 Then
                Dim CI As String = CStr(TablaSocio.Rows(0).Item(0))
                CIValue = CI
                Dim Nombre As String = CStr(TablaSocio.Rows(0).Item(1))
                Dim Foto As Byte()
                Try
                    Foto = CType(TablaSocio.Rows(0).Item(8), Byte())
                Catch
                End Try
                pbxFoto.Image = If(Foto IsNot Nothing, ByteArrayToImage(Foto), My.Resources.userblack)
                lblNombre.Text = CStr(Nombre)
                GetClientStatus(CI)
            End If
        End If
    End Sub


    Public Sub ShowClientStatus(ByVal Membresia As String,
                                ByVal Vencimiento As Date,
                                ByVal Atraso As Integer,
                                ByVal SaldoPendiente As Integer)
        If Me.dgvAccesos.InvokeRequired Then
            Dim d As New ShowClientStatusCallBack(AddressOf ShowClientStatus)
            Me.Invoke(d, New Object() {Membresia, Vencimiento, Atraso, SaldoPendiente})
        Else
            lblMembresia.Text = CStr(Membresia)
            lblVencimiento.Text = CStr(Vencimiento)
            lblAtraso.Text = CStr(Atraso)
            lblSaldo.Text = CStr(SaldoPendiente)

            If Date.Now.Date > Vencimiento Then
                btnCuota.Text = "Cuota vencida"
                btnCuota.BackColor = Color.DarkRed
                If Atraso > DiasTolerancia Then
                    btnOpenDoor.Visible = True
                End If
            Else
                btnCuota.Text = "Cuota al día"
                btnCuota.BackColor = Color.Green
                btnOpenDoor.Visible = False
            End If

            If Atraso > 0 Then
                lblAtraso.Visible = True
                lblTituloAtraso.Visible = True
            Else
                lblAtraso.Visible = False
                lblTituloAtraso.Visible = False
            End If

            If SaldoPendiente > 0 Then
                lblSaldo.Visible = True
                lblTituloPendiente.Visible = True
                If Date.Now.Date > Vencimiento Then
                    btnCuota.Text += " + Saldo Pend."
                Else
                    btnCuota.Text = "Saldo Pendiente"
                    btnCuota.BackColor = Color.DarkRed
                End If
            Else
                lblSaldo.Visible = False
                lblTituloPendiente.Visible = False
            End If
        End If
    End Sub


    Private Sub FEventoAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler EventoAcceso.MsgRecibido, AddressOf onMsgRecibido
        AddHandler EventoAcceso.CallBackSucc, AddressOf onCallBackSucc
        AddHandler EventoAcceso.LoginErr, AddressOf onLoginError
        AddHandler EventoAcceso.LoginSuccess, AddressOf onLoginSuccess
    End Sub

    Public Sub init()
        EventoAcceso.login()
        'EventoAcceso.deploy()
    End Sub

    Private Sub btnOpenDoor_Click(sender As Object, e As EventArgs) Handles btnOpenDoor.Click
        EventoAcceso.OpenDoor()
    End Sub

    Private Sub btnStayOpen_Click(sender As Object, e As EventArgs)
        EventoAcceso.StayOpenDoor()
    End Sub

    'Generate new image dimensions
    Public Function GenerateImageDimensions(ByVal currW As Integer, ByVal currH As Integer, ByVal destW As Integer, ByVal destH As Integer) As Size
        'double to hold the final multiplier to use when scaling the image
        Dim multiplier As Double = 0

        'string for holding layout
        Dim layout As String

        'determine if it's Portrait or Landscape
        If currH > currW Then
            layout = "portrait"
        Else
            layout = "landscape"
        End If

        Select Case layout.ToLower()
            Case "portrait"
                'calculate multiplier on heights
                If destH > destW Then
                    multiplier = CDbl(destW) / CDbl(currW)
                Else

                    multiplier = CDbl(destH) / CDbl(currH)
                End If
                Exit Select
            Case "landscape"
                'calculate multiplier on widths
                If destH > destW Then
                    multiplier = CDbl(destW) / CDbl(currW)
                Else

                    multiplier = CDbl(destH) / CDbl(currH)
                End If
                Exit Select
        End Select

        'return the new image dimensions
        Return New Size(CInt((currW * multiplier)), CInt((currH * multiplier)))
    End Function

    Private Sub btnCuota_Click(sender As Object, e As EventArgs) Handles btnCuota.Click
        If btnCuota.Text = "Cuota vencida" Then
            FrmSocio.Pagar(CIValue, lblNombre.Text, lblMembresia.Text, CDate(lblVencimiento.Text))
            FrmSocio.ShowDialog()
        ElseIf btnCuota.Text <> "Cuota al día" Then
            FrmCuentasCobrar.ModoPagarByCI(CIValue)
            FrmCuentasCobrar.ShowDialog()
        End If
    End Sub

    Private Sub onCuentasCobrar_Closed() Handles FrmCuentasCobrar.FormClosed, FrmSocio.FormClosed
        GetClientStatus(CIValue)
    End Sub

    Private Sub dgvAccesos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccesos.CellContentClick
        Dim Codigo As String = CStr(dgvAccesos.Item(0, e.RowIndex).Value)
        ShowClientInfo(Codigo)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        onMsgRecibido(Date.Now, CUInt(TextBox1.Text))
    End Sub

    Private Sub lblConectado_Click(sender As Object, e As EventArgs) Handles lblConectado.Click
        lblConectado.ForeColor = Color.White
        lblConectado.BackColor = Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        lblConectado.Text = "Conectando..."
        EventoAcceso.login()
    End Sub

End Class