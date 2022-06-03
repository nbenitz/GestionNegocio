Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Threading.Tasks

Public Class FNuevoSocio
    Dim oMembresia As New CMembresia
    Dim oCliente As New CCliente
    Dim oAcceso As New CAcceso
    Dim oDataAcceso As New DataAcceso
    Dim FrmFingerPMgr As New FingerPrintMgr
    Dim Person As New PersonMgr
    Dim loading As FLoading
    Dim OldRUC As String
    Dim TablaMembresia As New DataTable
    Dim CIValue As String
    'Dim FPDataValue As Byte()
    Dim FPDataValue As New List(Of Byte())
    Dim EmployeeNoValue As String = ""

    'Dim TextoAcceso As String

    Public Enum Modo As Integer
        Nuevo = 0
        Editar = 1
        Pagar = 2
        EditarMembresia = 3
    End Enum
    Dim ModoForm As Integer = Modo.Nuevo

    Dim ColorOscuro As Color = Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
    Dim ColorNormal As Color = Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))

    Private Sub FSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler FrmFingerPMgr.SendFPData, AddressOf onReceiveFPData
        'FrmFingerPMgr.Login()

        CargarMembresia()
        If ModoForm = Modo.Nuevo Then
            btnMembresia.Enabled = False
            btnAcceso.Enabled = False
            btnCobrar.Enabled = False
            dtpFechaInicio.Value = Date.Now.Date
            btnSocio_Click(sender, e)
        ElseIf ModoForm = Modo.Pagar Then
            btnCobrar.Enabled = False
            btnSocio.Visible = False
            btnAcceso.Visible = False
            btnMembresiaAtras.Visible = False
            btnMembresia.Location = New Point(0, 34)
            btnCobrar.Location = New Point(142, 34)
            lblTitulo.Text = "Pagar Cuota"
            btnMembresia_Click(Nothing, Nothing)
            cmbMembresia.SelectedItem = cmbMembresia.Text
        ElseIf ModoForm = Modo.Editar Then
            btnCobrar.Visible = False
            btnMembresia.Visible = False
            btnAcceso.Location = New Point(142, 34)
            btnSocioSgte.Text = "Guardar"
            btnAsignarAcceso.Text = "Guardar"
            btnAccesoAtras.Visible = False
            lblTitulo.Text = "Editar Socio"
            btnSocio_Click(sender, e)
        ElseIf ModoForm = Modo.EditarMembresia Then
            btnSocio.Visible = False
            btnAcceso.Visible = False
            btnCobrar.Visible = False
            btnMembresiaAtras.Visible = False
            btnMembresia.Location = New Point(0, 34)
            btnAsignarMembresia.Text = "Guardar"
            lblTitulo.Text = "Editar Membresía"
            btnMembresia_Click(Nothing, Nothing)
            cmbMembresia.SelectedItem = cmbMembresia.Text
        End If
    End Sub

    Private Sub onReceiveFPData(ByVal FPData As Byte())
        FPDataValue.Add(FPData)
        AddToFPanel()
    End Sub

    Private Sub AddToFPanel()
        Dim addIndex As Integer = FlowLayoutPanel1.Controls.Count - 1
        If addIndex > 0 Then
            FlowLayoutPanel1.Width += 107
            FlowLayoutPanel1.Left = CInt(Me.Width / 2 - FlowLayoutPanel1.Width / 2)
            pbxRemoveFP.Left = FlowLayoutPanel1.Left - 23
        End If

        Dim pbx As New PictureBox
        pbx.BackColor = Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        pbx.Size = New Size(100, 100)
        pbx.SizeMode = PictureBoxSizeMode.Zoom
        pbx.Image = My.Resources.fingerprint_card
        pbx.Name = "Pbx_" + CStr(addIndex)

        FlowLayoutPanel1.Controls.Add(pbx)
        FlowLayoutPanel1.Controls.SetChildIndex(pbx, addIndex)
        pbxRemoveFP.Visible = True
    End Sub

    Private Sub pbxRemoveFP_Click(sender As Object, e As EventArgs) Handles pbxRemoveFP.Click
        Dim panelCount As Integer = FlowLayoutPanel1.Controls.Count
        If panelCount > 0 Then
            FlowLayoutPanel1.Controls.Remove(FlowLayoutPanel1.Controls.Item(0))
            FPDataValue.RemoveAt(FPDataValue.Count - 1)
            If panelCount < 3 Then
                pbxRemoveFP.Visible = False
            End If
        End If

    End Sub

    Private Sub CargarMembresia()
        cmbMembresia.Items.Clear()
        TablaMembresia = oMembresia.Listar()
        For Each row As DataRow In TablaMembresia.Rows
            cmbMembresia.Items.Add(CStr(row.Item(1)))
        Next
    End Sub

    Private Sub cmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMembresia.KeyPress
        e.Handled = True
    End Sub

    Private Sub GuardarSocio()
        Dim CI As String = txtCI.Text
        Dim Nombre As String = txtNombre.Text
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        Dim Aliass As String = txtAlias.Text
        Dim Foto As Byte()
        Dim FechaNac As Date = DtpFechaNac.Value
        Dim Conocio As String = txtConocio.Text
        If pbxFoto.Image IsNot Nothing Then
            Foto = ImageToByteArray(pbxFoto.Image)
        End If

        If CI <> "" Then
            If Nombre <> "" Then
                If Tel = "" Then
                    Tel = " "
                End If
                If Dir = "" Then
                    Dir = " "
                End If
                If Aliass = "" Then
                    Aliass = " "
                End If
                If Conocio = "" Then
                    Conocio = " "
                End If
                If ModoForm = Modo.Nuevo Then
                    If Not oCliente.InserCliente(CI, Nombre, Aliass, Tel, Dir, " ", Foto, FechaNac, Conocio) Then
                        MessageBox.Show("Hubo un problema al Guardar los datos del Socio")
                    End If
                ElseIf ModoForm = Modo.Editar Then
                    If oCliente.Update(CI, Nombre, Aliass, Tel, Dir, " ", Foto, FechaNac, Conocio, OldRUC) = True Then
                        MessageBox.Show("Datos del Socio Actualizados")
                        CIValue = CI
                        'Close()
                    Else
                        MessageBox.Show("Hubo un problema al editar el los datos del Socio")
                    End If
                End If
            Else
                txtNombre.Focus()
                ToolTip2.Show("Ingrese el Nombre", txtNombre, 0, -40, 3000)
            End If
        Else
            txtCI.Focus()
            txtCI.Select(0, txtCI.Text.Length)
            ToolTip2.Show("Ingrese un CI válido", txtCI, 0, -40, 3000)
            Exit Sub
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Limpiar()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim strEstado As String = WindowState.ToString()
        If strEstado = "Maximized" Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub F_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ModoForm = Modo.Editar Then
            Close()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub Limpiar()
        txtCI.Text = ""
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtAlias.Text = ""
        txtCI.Focus()
    End Sub

    Public Sub Editar(ByVal CI As String,
                      ByVal Nombre As String,
                      ByVal Tel As String,
                      ByVal Dir As String,
                      ByVal Aliass As String,
                      ByVal foto As Byte(),
                      ByVal FechaNac As Date,
                      ByVal Conocio As String,
                      ByVal EmployeeNo As String)
        ModoForm = Modo.Editar
        OldRUC = CI
        txtCI.Text = CI
        CIValue = CI
        txtNombre.Text = Nombre
        txtTelefono.Text = Tel
        txtDireccion.Text = Dir
        txtAlias.Text = Aliass
        txtConocio.Text = Conocio
        DtpFechaNac.Value = FechaNac
        If foto IsNot Nothing Then
            pbxFoto.Image = ByteArrayToImage(foto)
            pbxQuitarFoto.Visible = True
        End If
        EmployeeNoValue = EmployeeNo
        CargarHuella()
    End Sub

    Public Sub EditarMembresia(ByVal CI As String,
                               ByVal SocioNombre As String,
                               ByVal MembresiaNom As String,
                               ByVal FechaInicio As Date)
        ModoForm = Modo.EditarMembresia
        OldRUC = CI
        txtCI.Text = CI
        CIValue = CI
        lblNombreSocio.Text = SocioNombre
        CargarMembresia()
        cmbMembresia.SelectedItem = MembresiaNom
        dtpFechaInicio.Value = FechaInicio
    End Sub

    Public Sub Pagar(ByVal CI As String,
                     ByVal SocioNombre As String,
                     ByVal MembresiaNom As String,
                     ByVal Vto As Date)
        ModoForm = Modo.Pagar
        CIValue = CI
        txtCI.Text = CI
        lblNombreSocio.Text = SocioNombre
        CargarMembresia()
        If MembresiaNom <> "" Then
            cmbMembresia.SelectedItem = MembresiaNom
            optDesdeDiaVence.Checked = True
        Else
            optNuevaFecha.Checked = True
            optDesdeDiaVence.Enabled = False
        End If
        pnlInicioMembresia.Location = New Point(182, 296)
        pnlInicioMembresia.Visible = True
        pnlMembresiaSocio.Visible = True
        dtpNuevoInicio.Value = Vto

        lblUltimaAsist.Text = CStr(oAcceso.UltimaAsistencia(CI))
    End Sub

    Private Sub CargarHuella()
        If EmployeeNoValue.Length > 0 Then
            EmployeeNoValue = EmployeeNoValue
            Dim Tabla As DataTable = oAcceso.BuscarHuellas(EmployeeNoValue)
            For i As Integer = 0 To Tabla.Rows.Count - 1
                FPDataValue.Add(Convert.FromBase64String(CStr(Tabla.Rows(i).Item(2))))
                AddToFPanel()
            Next
        End If
    End Sub

    Private Sub cmbMembresia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMembresia.SelectedIndexChanged
        txtDescMembresia.Text = CStr(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(2))
        txtPrecioMembresia.Text = String.Format("{0:N0}", CDec(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(3)))
        SetFechaFin()
        lblPrecioMembresia.Text = txtPrecioMembresia.Text
        lblPrecioDescontado.Text = txtPrecioMembresia.Text
        txtDescuento.Text = "0"
        txtPaga.Text = txtPrecioMembresia.Text
    End Sub

    Private Sub SetFechaFin()
        If cmbMembresia.SelectedIndex >= 0 Then
            Dim TiempoLimite As Integer = CInt(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(4))
            Dim TiempoUnidad As Char = CChar(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(5))
            Select Case TiempoUnidad
                Case "M"c
                    dtpFechaFin.Value = DateAdd(DateInterval.Month, TiempoLimite, dtpFechaInicio.Value)
                Case "S"c
                    dtpFechaFin.Value = DateAdd(DateInterval.Day, TiempoLimite * 7, dtpFechaInicio.Value)
                Case "D"c
                    dtpFechaFin.Value = DateAdd(DateInterval.Day, TiempoLimite, dtpFechaInicio.Value)
            End Select
            If ModoForm = Modo.Pagar Then
                dtpNuevaFechaFin.Value = dtpFechaFin.Value
            End If
        End If
    End Sub

    Private Sub SetNuevaFechaFin()
        If cmbMembresia.SelectedIndex >= 0 Then
            Dim TiempoLimite As Integer = CInt(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(4))
            Dim TiempoUnidad As Char = CChar(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(5))
            Select Case TiempoUnidad
                Case "M"c
                    dtpNuevaFechaFin.Value = DateAdd(DateInterval.Month, TiempoLimite, dtpNuevoInicio.Value)
                Case "S"c
                    dtpNuevaFechaFin.Value = DateAdd(DateInterval.Day, TiempoLimite * 7, dtpNuevoInicio.Value)
                Case "D"c
                    dtpNuevaFechaFin.Value = DateAdd(DateInterval.Day, TiempoLimite, dtpNuevoInicio.Value)
            End Select
        End If
    End Sub

    Private Sub GuardarMembresia()
        If cmbMembresia.SelectedIndex >= 0 Then
            Dim idMembresia As Integer = CInt(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(0))
            Dim CI As String = txtCI.Text
            Dim FechaInicio As Date = dtpFechaInicio.Value
            Dim FechaFin As Date = dtpFechaFin.Value
            Dim Precio As Integer = CInt(lblPrecioDescontado.Text)
            If ModoForm = Modo.Nuevo Or ModoForm = Modo.Pagar Then
                If Not oMembresia.InsertClienteMembresia(CI, idMembresia, FechaInicio, FechaFin, Precio) Then
                    MessageBox.Show("Hubo un problema al asignar la Membresía")
                End If
            ElseIf ModoForm = Modo.EditarMembresia Then
                Try
                    Dim idClienteMembresia As Integer = oMembresia.IdClienteMembresia(CIValue)
                    If idClienteMembresia >= 0 Then     'Buscamos si el socio ya cuenta con una membresía 
                        If oMembresia.UpdateClienteMembresia(idMembresia, idClienteMembresia, FechaInicio, FechaFin) = True Then
                            MessageBox.Show("Membresía actualizada")
                        Else
                            MessageBox.Show("Hubo un problema al actualizar la Membresía")
                        End If
                    Else                                'Si no, asignamos una nueva membresía
                        If oMembresia.InsertClienteMembresia(CIValue, idMembresia, FechaInicio, FechaFin, Precio) = True Then
                            MessageBox.Show("Membresía Asignada")
                        Else
                            MessageBox.Show("Hubo un problema al asignar la Membresía")
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Hubo un problema al actualizar la Membresía")
                End Try
            End If
        Else
            cmbMembresia.Focus()
            ToolTip2.Show("Seleccione la Membresía", cmbMembresia, 0, -40, 3000)
        End If
    End Sub


    Private Sub Pagar()
        If ModoForm = Modo.Nuevo Or ModoForm = Modo.Pagar Then
            Dim idClienteMembresia As Integer = oMembresia.IdClienteMembresia(txtCI.Text)
            Dim Fecha As DateTime = DateTime.Now
            Dim Precio As Integer = CInt(lblPrecioDescontado.Text)
            Dim Monto As Integer = CInt(txtPaga.Text)
            If Monto > Precio Then
                Monto = Precio
            End If
            If oMembresia.Pagar(idClienteMembresia, Fecha, Monto) Then
                MessageBox.Show("Pago registrado")
                Dim Descuento As Integer = CInt(txtDescuento.Text)
                If Descuento > 0 Then
                    If Not oMembresia.Descuento(idClienteMembresia, Descuento) Then
                        MessageBox.Show("Hubo un problema al registrar el descuento")
                    End If
                End If
            Else
                MessageBox.Show("Hubo un problema al registrar el pago")
            End If
        End If
    End Sub


    Private Async Sub GuardarAcceso()
        Dim estado As String = ""
        ShowLoading()
        Try
            Dim t1 As Task
            t1 = Task.Run(Sub() estado = FrmFingerPMgr.SaveAcceso(CIValue,
                                                                  txtNombre.Text,
                                                                  EmployeeNoValue,
                                                                  FPDataValue))
            Await t1
        Catch ex As Exception
            'CloseLoading()
            'MessageBox.Show("Error")
            Exit Sub
        End Try
        CloseLoading()
        If estado = "OK" Then
            MessageBox.Show("Datos registrados")
        Else
            MessageBox.Show("Error: " + estado)
        End If
        'If TextoAcceso <> "" Then
        'Try
        'Dim AccesoId As Integer
        'Dim Codigo As Integer = CInt(TextoAcceso)
        'Dim CI As String = txtCI.Text
        'Dim AccesoIdAux As Integer = oAcceso.GetId(CStr(Codigo)) 'Devuelve -1 si aún no se creó el código
        'If AccesoIdAux >= 0 Then            'Si ya se registró el código especificado
        'AccesoId = AccesoIdAux          'Utilizar el Id de ese código
        'Else                                'Sino
        'AccesoId = oAcceso.CargarId()    'Registrar nuevo código
        'If Not oAcceso.Insert(AccesoId, Codigo) Then
        'MessageBox.Show("Hubo un problema al registrar el Código")
        'End If
        'End If
        '
        'If ModoForm = Modo.Nuevo Then
        'If Not oAcceso.InsertClienteAcceso(CI, AccesoId) Then
        'MessageBox.Show("Hubo un problema al asignar el Código")
        'End If
        'ElseIf ModoForm = Modo.Editar Then
        'Dim ClienteAccesoId As Integer = oAcceso.IdClienteAcceso(CIValue)
        'If ClienteAccesoId >= 0 Then
        'If oAcceso.UpdateClienteAcceso(AccesoId, ClienteAccesoId) = True Then
        'MessageBox.Show("Código de Acceso Asignado")
        'Else
        'MessageBox.Show("Hubo un problema al asignar el Código")
        'End If
        'Else
        'If oAcceso.InsertClienteAcceso(CIValue, AccesoId) = True Then
        'MessageBox.Show("Código de Acceso Asignado")
        'Else
        'MessageBox.Show("Hubo un problema al asignar el Código")
        'End If
        'End If
        'End If
        'Catch ex As Exception
        'txtAcceso.Focus()
        'ToolTip2.Show("Código no válido", txtAcceso, 0, -40, 3000)
        'End Try
        'Else
        'txtAcceso.Focus()
        'ToolTip2.Show("Ingrese el Código", txtAcceso, 0, -40, 3000)
        'End If
    End Sub

    Private Sub btnSocio_Click(sender As Object, e As EventArgs) Handles btnSocio.Click
        pnlSocio.Visible = True
        pnlMembresia.Visible = False
        pnlAcceso.Visible = False
        pnlCobrar.Visible = False
        btnSocio.BackColor = ColorNormal
        btnMembresia.BackColor = ColorOscuro
        btnAcceso.BackColor = ColorOscuro
        btnCobrar.BackColor = ColorOscuro
    End Sub

    Private Sub btnMembresia_Click(sender As Object, e As EventArgs) Handles btnMembresia.Click
        pnlSocio.Visible = False
        pnlMembresia.Visible = True
        pnlAcceso.Visible = False
        pnlCobrar.Visible = False
        btnSocio.BackColor = ColorOscuro
        btnMembresia.BackColor = ColorNormal
        btnAcceso.BackColor = ColorOscuro
        btnCobrar.BackColor = ColorOscuro
    End Sub

    Private Sub btnAcceso_Click(sender As Object, e As EventArgs) Handles btnAcceso.Click
        pnlSocio.Visible = False
        pnlMembresia.Visible = False
        pnlAcceso.Visible = True
        pnlCobrar.Visible = False
        btnSocio.BackColor = ColorOscuro
        btnMembresia.BackColor = ColorOscuro
        btnAcceso.BackColor = ColorNormal
        btnCobrar.BackColor = ColorOscuro
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        pnlSocio.Visible = False
        pnlMembresia.Visible = False
        pnlAcceso.Visible = False
        pnlCobrar.Visible = True
        btnSocio.BackColor = ColorOscuro
        btnMembresia.BackColor = ColorOscuro
        btnAcceso.BackColor = ColorOscuro
        btnCobrar.BackColor = ColorNormal
    End Sub

    Private Sub btnSocioSgte_Click(sender As Object, e As EventArgs) Handles btnSocioSgte.Click
        If ModoForm = Modo.Nuevo Then
            If txtCI.Text <> "" Then
                If txtNombre.Text <> "" Then
                    Dim TablaCli As DataTable = oCliente.BuscCli("WHERE CI = '" + txtCI.Text + "'")
                    If TablaCli.Rows.Count > 0 Then
                        txtCI.Focus()
                        txtCI.Select(0, txtCI.Text.Length)
                        ToolTip2.Show("Ya existe un socio con el CI especificado", txtCI, 0, -40, 3000)
                    Else
                        btnMembresia_Click(sender, e)
                        btnSocio.Enabled = False
                        btnMembresia.Enabled = True
                    End If
                Else
                    txtNombre.Focus()
                    ToolTip2.Show("Ingrese el Nombre", txtNombre, 0, -40, 3000)
                End If
            Else
                txtCI.Focus()
                txtCI.Select(0, txtCI.Text.Length)
                ToolTip2.Show("Ingrese un CI válido", txtCI, 0, -40, 3000)
                Exit Sub
            End If
        Else
            GuardarSocio()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAsignarMembresia_Click(sender As Object, e As EventArgs) Handles btnAsignarMembresia.Click
        If ModoForm = Modo.Nuevo Then
            If cmbMembresia.SelectedIndex >= 0 Then
                btnAcceso_Click(sender, e)
                btnMembresia.Enabled = False
                btnAcceso.Enabled = True
            Else
                cmbMembresia.Focus()
                ToolTip2.Show("Seleccione la Membresía", cmbMembresia, 0, -40, 3000)
            End If
        ElseIf ModoForm = Modo.EditarMembresia Then
            cmbMembresia.SelectedItem = cmbMembresia.Text
            GuardarMembresia()
        ElseIf ModoForm = Modo.Pagar Then
            If cmbMembresia.SelectedIndex >= 0 Then
                btnCobrar_Click(sender, e)
                btnMembresia.Enabled = False
                btnCobrar.Enabled = True
            Else
                cmbMembresia.Focus()
                ToolTip2.Show("Seleccione la Membresía", cmbMembresia, 0, -40, 3000)
            End If
        End If
    End Sub

    Private Async Sub btnAsignarAcceso_Click(sender As Object, e As EventArgs) Handles btnAsignarAcceso.Click
        If ModoForm = Modo.Nuevo Then
            btnCobrar_Click(sender, e)
            btnAcceso.Enabled = False
            btnCobrar.Enabled = True
        Else
            If FPDataValue.Count > 0 Then
                If EmployeeNoValue.Length = 0 Then
                    ShowLoading()
                    Try
                        Dim t1 As Task
                        t1 = Task.Run(Sub() EmployeeNoValue = GuardarDatosAccesoDispositivo())
                        Await t1
                    Catch ex As Exception
                        'CloseLoading()
                        'Exit Sub
                    End Try
                    CloseLoading()
                    If EmployeeNoValue.Length = 0 Then
                        MessageBox.Show("Hubo un error al actualizar los datos de acceso")
                        Exit Sub
                    End If
                Else
                    ShowLoading()
                    Dim estado As String
                    Try
                        Dim t2 As Task
                        t2 = Task.Run(Sub() estado = EditarHuellaDispositivo())
                        Await t2
                    Catch ex As Exception
                        'CloseLoading()
                        'MessageBox.Show("Error")
                        'Exit Sub
                    End Try
                    CloseLoading()
                    If estado <> "OK" Then
                        Exit Sub
                    End If
                    If Not oAcceso.DelFingers(EmployeeNoValue) Then
                        MessageBox.Show("Hubo un error al actualizar los datos de acceso")
                        Exit Sub
                    End If
                End If
                GuardarAcceso()
            Else
                MessageBox.Show("No se han agregado datos de Acceso")
            End If
        End If
    End Sub

    Private Function GetSocio() As cliente
        Dim Cliente As New cliente
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        Dim Aliass As String = txtAlias.Text
        Dim Conocio As String = txtConocio.Text
        Dim Foto As Byte()
        If Tel = "" Then
            Tel = " "
        End If
        If Dir = "" Then
            Dir = " "
        End If
        If Aliass = "" Then
            Aliass = " "
        End If
        If Conocio = "" Then
            Conocio = " "
        End If
        Cliente.CI = txtCI.Text
        Cliente.Nombre = txtNombre.Text
        Cliente.Telefono = Tel
        Cliente.Direccion = Dir
        Cliente.Alias = Aliass
        If pbxFoto.Image IsNot Nothing Then
            Foto = ImageToByteArray(pbxFoto.Image)
        End If
        Cliente.Foto = Foto
        Cliente.Propietario = " "
        Cliente.Activo = 1
        Cliente.Fecha_Nacimiento = DtpFechaNac.Value.Date
        Cliente.Como_Conocio = Conocio
        Return Cliente
    End Function

    Private Function GuardarDatosAccesoDispositivo() As String
        Dim estado As String
        Dim EmployeeNo As String = txtCI.Text

        estado = Person.SetUserInfo(txtNombre.Text, EmployeeNo)
        If estado <> "OK" Then
            MessageBox.Show("Error al registrar los datos de Acceso: " + estado)
            Return ""
        End If

        estado = FrmFingerPMgr.SetFingerData(EmployeeNo, FPDataValue)
        If estado <> "OK" Then
            MessageBox.Show("Error al Registrar la Huella Dactilar: " + estado)
            Return ""
        End If
        Return EmployeeNo
    End Function

    Private Function EditarHuellaDispositivo() As String
        Dim estado As String

        estado = FrmFingerPMgr.UpdateFingerData(EmployeeNoValue, FPDataValue)
        If estado <> "OK" Then
            MessageBox.Show("Error al Registrar la Huella Dactilar: " + estado)
            Return ""
        End If
        Return estado
    End Function

    Private Async Sub btnCobrarConfirmar_Click(sender As Object, e As EventArgs) Handles btnCobrarConfirmar.Click
        If ModoForm = Modo.Nuevo Then
            If txtDescuento.Text = "" Then
                txtDescuento.Text = "0"
            End If
            If txtPaga.Text = "" Then
                txtPaga.Text = "0"
            End If

            Dim estado As String
            Dim EmployeeNo As String = ""
            If FPDataValue.Count > 0 Then
                ShowLoading()
                Try
                    Dim t1 As Task
                    t1 = Task.Run(Sub() EmployeeNo = GuardarDatosAccesoDispositivo())
                    Await t1
                Catch ex As Exception
                    'CloseLoading()
                    'MessageBox.Show("Error")
                    'Exit Sub
                End Try
                CloseLoading()
                If EmployeeNo.Length = 0 Then
                    Exit Sub
                End If
            End If

            If Not cmbMembresia.SelectedIndex >= 0 Then
                MessageBox.Show("Seleccione una Membresía")
                Exit Sub
            End If
            Dim idMembresia As Integer = CInt(TablaMembresia.Rows(cmbMembresia.SelectedIndex).Item(0))
            Dim FechaInicio As Date = dtpFechaInicio.Value
            Dim FechaFin As Date = dtpFechaFin.Value
            Dim Precio As Integer = CInt(lblPrecioDescontado.Text)
            Dim Descuento As Integer = CInt(txtDescuento.Text)
            Dim Monto As Integer = CInt(txtPaga.Text)
            If Monto > Precio Then
                Monto = Precio
            End If

            ShowLoading()
            Dim t2 As Task
            t2 = Task.Run(Sub() estado = FrmFingerPMgr.SaveNewCliente(GetSocio(),
                                                                      idMembresia,
                                                                      FechaInicio,
                                                                      FechaFin,
                                                                      Precio,
                                                                      Descuento,
                                                                      Monto,
                                                                      EmployeeNo,
                                                                      FPDataValue
                                                                      ))
            Await t2
            CloseLoading()

            If estado = "OK" Then
                MessageBox.Show("Datos registrados")
            Else
                MessageBox.Show("Error: " + estado)
            End If

            Close()

        ElseIf ModoForm = Modo.Pagar Then
            If txtDescuento.Text = "" Then
                txtDescuento.Text = "0"
            End If
            If txtPaga.Text = "" Then
                txtPaga.Text = "0"
            End If
            dtpFechaInicio.Value = dtpNuevoInicio.Value
            dtpFechaFin.Value = dtpNuevaFechaFin.Value
            GuardarMembresia()
            Pagar()
            Close()
        End If
    End Sub

    Private Sub btnMembresiaAtras_Click(sender As Object, e As EventArgs) Handles btnMembresiaAtras.Click
        btnSocio_Click(sender, e)
        btnMembresia.Enabled = False
        btnSocio.Enabled = True
    End Sub

    Private Sub btnAccesoAtras_Click(sender As Object, e As EventArgs) Handles btnAccesoAtras.Click
        btnMembresia_Click(sender, e)
        btnAcceso.Enabled = False
        btnMembresia.Enabled = True
    End Sub

    Private Sub btnCobrarAtras_Click(sender As Object, e As EventArgs) Handles btnCobrarAtras.Click
        btnCobrar.Enabled = False
        If ModoForm = Modo.Nuevo Then
            btnAcceso_Click(sender, e)
            btnAcceso.Enabled = True
        ElseIf ModoForm = Modo.Pagar Then
            btnMembresia_Click(sender, e)
            btnMembresia.Enabled = True
        End If
    End Sub

    Private Sub txtPaga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaga.KeyPress, txtDescuento.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            Caja.Focus()
            ToolTip2.Show("Ingrese un valor númerico", Caja, 0, -40, 2000)
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPaga_TextChanged(sender As Object, e As EventArgs) Handles txtPaga.TextChanged
        Dim PrecioMembresia As Integer = CInt(lblPrecioDescontado.Text)
        Dim Paga As Integer
        Try
            If txtPaga.Text <> "" Then
                Paga = CInt(txtPaga.Text)
                If Paga < PrecioMembresia Then
                    lblPendienteMonto.Text = String.Format("{0:N0}", CDec(PrecioMembresia - Paga))
                    pnlPendiente.Visible = True
                Else
                    lblPendienteMonto.Text = "0"
                    pnlPendiente.Visible = False
                End If
                If Paga > PrecioMembresia Then
                    pnlVuelto.Visible = True
                    lblVuelto.Text = String.Format("{0:N0}", CDec(Paga - PrecioMembresia))
                Else
                    pnlVuelto.Visible = False
                End If
            Else
                lblPendienteMonto.Text = String.Format("{0:N0}", CDec(PrecioMembresia))
                pnlPendiente.Visible = True
            End If
        Catch
        End Try
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        Dim PrecioMembresia As Integer = CInt(lblPrecioMembresia.Text)
        Dim Descuento As Integer
        If txtDescuento.Text <> "" Then
            Descuento = CInt(txtDescuento.Text)
            If Descuento < PrecioMembresia Then
                lblPrecioDescontado.Text = String.Format("{0:N0}", CDec(PrecioMembresia - Descuento))
                If Descuento > 0 Then
                    pnlPrecioDescontado.Visible = True
                Else
                    pnlPrecioDescontado.Visible = False
                End If
            Else
                txtDescuento.Text = CStr(0)
            End If
        Else
            lblPrecioDescontado.Text = String.Format("{0:N0}", CDec(PrecioMembresia))
            pnlPrecioDescontado.Visible = False
        End If
        txtPaga_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub pbxFoto_Click(sender As Object, e As EventArgs) Handles pbxFoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg;*.jpeg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                ' Load the specified file into a PictureBox control.
                If Not (pbxFoto.Image Is Nothing) Then
                    pbxFoto.Image.Dispose()
                    pbxFoto.Image = Nothing
                End If
                pbxFoto.Image = Image.FromFile(.FileName)
                SetImage(pbxFoto)
                pbxQuitarFoto.Visible = True
            End If
        End With
    End Sub

    Private Sub SetImage(ByVal pb As PictureBox)
        Try
            'create a temp image
            Dim img As Image = pb.Image

            'calculate the size of the image
            Dim imgSize As Size = GenerateImageDimensions(img.Width, img.Height, 500, 500)

            'create a new Bitmap with the proper dimensions
            Dim finalImg As New Bitmap(img, imgSize.Width, imgSize.Height)

            'create a new Graphics object from the image
            Dim gfx As Graphics = Graphics.FromImage(img)

            'clean up the image (take care of any image loss from resizing)
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic

            'empty the PictureBox
            pb.Image = Nothing

            'center the new image
            'pb.SizeMode = PictureBoxSizeMode.CenterImage

            'set the new image
            'pb.Image = finalImg
            pb.Image = CorrectExifOrientation(img)
        Catch e As System.Exception
            MessageBox.Show(e.Message)
        End Try
    End Sub

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

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub

    Private Sub optDesdeDiaVence_CheckedChanged(sender As Object, e As EventArgs) Handles optDesdeDiaVence.CheckedChanged
        If optDesdeDiaVence.Checked = True Then
            Try
                dtpNuevoInicio.Value = GetLastVtoMembresia(CIValue)
                dtpNuevoInicio.Enabled = False
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub optNuevaFecha_CheckedChanged(sender As Object, e As EventArgs) Handles optNuevaFecha.CheckedChanged
        If optNuevaFecha.Checked = True Then
            dtpNuevoInicio.Enabled = True
        End If
    End Sub

    Function GetLastVtoMembresia(ByVal CI As String) As Date
        Dim TablaMembresia As DataTable = oMembresia.BuscarViewClienteMembresia(CIValue)
        Dim Count As Integer = TablaMembresia.Rows.Count
        If Count > 0 Then
            Dim Vto As Date = CDate(TablaMembresia.Rows(Count - 1).Item(5))
            Return Vto
        End If
    End Function

    Function GetLasMembresia(ByVal CI As String) As Date
        Dim TablaMembresia As DataTable = oMembresia.BuscarViewClienteMembresia(CIValue)
        Dim Count As Integer = TablaMembresia.Rows.Count
        If Count > 0 Then
            Dim Vto As Date = CDate(TablaMembresia.Rows(Count - 1).Item(5))
            Return Vto
        End If
    End Function

    Private Sub pbxQuitarFoto_Click(sender As Object, e As EventArgs) Handles pbxQuitarFoto.Click
        If pbxFoto.Image IsNot Nothing Then
            pbxFoto.Image.Dispose()
            pbxFoto.Image = Nothing
            pbxQuitarFoto.Visible = False
        End If
    End Sub

    Private Sub pbxAddFP_Click(sender As Object, e As EventArgs) Handles pbxAddFP.Click
        FrmFingerPMgr.setLoginUserID(MAcceso.UserID)
        FrmFingerPMgr.ShowDialog()
    End Sub

    Private Sub ShowLoading()
        loading = New FLoading()
        loading.Show()
    End Sub

    Private Sub CloseLoading()
        If (loading IsNot Nothing) Then
            loading.Close()
        End If
    End Sub

    Private Sub txtPaga_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPaga.KeyUp, txtDescuento.KeyUp
        'Agregar separador de miles
        Dim Txt As TextBox = DirectCast(sender, TextBox)
        If (Txt.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(Txt.Text, importe)
            Txt.Text = String.Format("{0:N0}", importe)
            Txt.SelectionStart = Txt.TextLength
        End If
    End Sub

    Private Sub FNuevoSocio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'FrmFingerPMgr.Logout()
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        If ModoForm = Modo.Editar Then
            cmbMembresia.SelectedItem = cmbMembresia.Text
        End If
        SetFechaFin()
    End Sub

    Private Sub dtpNuevoInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpNuevoInicio.ValueChanged
        SetNuevaFechaFin()
    End Sub
End Class
