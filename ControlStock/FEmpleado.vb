Option Strict On
Option Explicit On

Imports System.Drawing.Drawing2D
Imports System.Threading.Tasks

Public Class FEmpleado
    Dim oMembresia As New CMembresia
    Dim oEmple As New CEmpleado
    Dim oAcceso As New CAcceso
    Dim oDataAcceso As New DataAcceso
    Dim FrmFingerPMgr As New FingerPrintMgr
    Dim Person As New PersonMgr
    Dim loading As FLoading
    Dim OldCI As Integer
    Dim CIValue As Integer
    Dim FPDataValue As New List(Of Byte())
    Dim EmployeeNoValue As String = ""

    Public Enum Modo As Integer
        Nuevo = 0
        Editar = 1
        Pagar = 2
    End Enum
    Dim ModoForm As Integer = Modo.Nuevo

    Dim ColorOscuro As Color = Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
    Dim ColorNormal As Color = Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))

    Private Sub FSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler FrmFingerPMgr.SendFPData, AddressOf onReceiveFPData
        FrmFingerPMgr.Login()

        If ModoForm = Modo.Nuevo Then
            btnAcceso.Enabled = False
        End If
        btnSocio_Click(sender, e)

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

    Private Sub cmb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub GuardarSocio()
        Dim CI As String = txtCI.Text
        Dim Nombre As String = txtNombre.Text
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        Dim Apellido As String = txtApellido.Text
        Dim Comision As Integer = 0
        Try
            Comision = CInt(txtComision.Text)
        Catch ex As Exception
        End Try

        If CI <> "" Then
            If Nombre <> "" Then
                If Tel = "" Then
                    Tel = " "
                End If
                If Dir = "" Then
                    Dir = " "
                End If
                If Apellido = "" Then
                    Apellido = " "
                End If
                If ModoForm = Modo.Editar Then
                    If oEmple.Update(CInt(CI), Nombre, Apellido, Tel, Dir, Comision, OldCI) = True Then
                        MessageBox.Show("Empleado Editado")
                    Else
                        MessageBox.Show("Hubo un problema al Editar los datos del Empleado")
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

    Private Sub Limpiar()
        txtCI.Text = ""
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtApellido.Text = ""
        txtCI.Focus()
    End Sub

    Public Sub Editar(ByVal CI As Integer,
                      ByVal Nombre As String,
                      ByVal Apellido As String,
                      ByVal Tel As String,
                      ByVal Dir As String,
                      ByVal Comision As Integer,
                      ByVal EmployeeNo As String)
        ModoForm = Modo.Editar
        OldCI = CI
        txtCI.Text = CStr(CI)
        CIValue = CI
        txtNombre.Text = Nombre
        txtTelefono.Text = Tel
        txtDireccion.Text = Dir
        txtApellido.Text = Apellido
        EmployeeNoValue = EmployeeNo
        CargarHuella()

        btnSocioSgte.Text = "Guardar"
        btnAsignarAcceso.Text = "Guardar"
        btnAccesoAtras.Visible = False
        lblTitulo.Text = "Editar Empleado"
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

    Private Async Sub GuardarAcceso()
        Dim estado As String = ""
        ShowLoading()
        Dim t1 As Task
        t1 = Task.Run(Sub() estado = FrmFingerPMgr.SaveAccesoEmple(CIValue,
                                                                   txtNombre.Text,
                                                                   EmployeeNoValue,
                                                                   FPDataValue))
        Await t1
        CloseLoading()
        If estado = "OK" Then
            MessageBox.Show("Datos registrados")
        Else
            MessageBox.Show("Error: " + estado)
        End If
    End Sub

    Private Sub btnSocio_Click(sender As Object, e As EventArgs) Handles btnSocio.Click
        pnlSocio.Visible = True
        pnlAcceso.Visible = False
        btnSocio.BackColor = ColorNormal
        btnAcceso.BackColor = ColorOscuro
    End Sub

    Private Sub btnAcceso_Click(sender As Object, e As EventArgs) Handles btnAcceso.Click
        pnlSocio.Visible = False
        pnlAcceso.Visible = True
        btnSocio.BackColor = ColorOscuro
        btnAcceso.BackColor = ColorNormal
    End Sub

    Private Sub btnSocioSgte_Click(sender As Object, e As EventArgs) Handles btnSocioSgte.Click
        If ModoForm = Modo.Nuevo Then
            If txtCI.Text <> "" Then
                If txtNombre.Text <> "" Then
                    If txtApellido.Text <> "" Then
                        Dim TablaCli As DataTable = oEmple.Buscar("WHERE CI = " + txtCI.Text)
                        If TablaCli.Rows.Count > 0 Then
                            txtCI.Focus()
                            txtCI.Select(0, txtCI.Text.Length)
                            ToolTip2.Show("Ya existe un empleado con el CI especificado", txtCI, 0, -40, 3000)
                        Else
                            btnAcceso_Click(sender, e)
                            btnSocio.Enabled = False
                            btnAcceso.Enabled = True
                        End If
                    Else
                        txtNombre.Focus()
                        ToolTip2.Show("Ingrese el Apellido", txtApellido, 0, -40, 3000)
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

    Private Async Sub btnAsignarAcceso_Click(sender As Object, e As EventArgs) Handles btnAsignarAcceso.Click
        If ModoForm = Modo.Nuevo Then
            Dim estado As String
            Dim EmployeeNo As String = ""
            If FPDataValue.Count > 0 Then
                ShowLoading()
                Dim t1 As Task
                t1 = Task.Run(Sub() EmployeeNo = GuardarDatosAccesoDispositivo())
                Await t1
                CloseLoading()
                If EmployeeNo.Length = 0 Then
                    Exit Sub
                End If
            End If

            ShowLoading()
            Dim t2 As Task
            t2 = Task.Run(Sub() estado = FrmFingerPMgr.SaveNewEmple(GetSocio(),
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

        Else
            If FPDataValue.Count > 0 Then
                If EmployeeNoValue.Length = 0 Then
                    ShowLoading()
                    Dim t1 As Task
                    t1 = Task.Run(Sub() EmployeeNoValue = GuardarDatosAccesoDispositivo())
                    Await t1
                    CloseLoading()
                    If EmployeeNoValue.Length = 0 Then
                        Exit Sub
                    End If
                Else
                    ShowLoading()
                    Dim estado As String
                    Dim t2 As Task
                    t2 = Task.Run(Sub() estado = EditarHuellaDispositivo())
                    Await t2
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

    Private Function GetSocio() As empleado
        Dim Empleado As New empleado
        Dim Tel As String = txtTelefono.Text
        Dim Dir As String = txtDireccion.Text
        Dim Apellido As String = txtApellido.Text
        Dim Foto As Byte()
        If Tel = "" Then
            Tel = " "
        End If
        If Dir = "" Then
            Dir = " "
        End If
        Empleado.CI = CInt(txtCI.Text)
        Empleado.Nombre = txtNombre.Text
        Empleado.Apellido = Apellido
        Empleado.Telefono = Tel
        Empleado.Direccion = Dir
        Empleado.Comision = CByte(txtComision.Text)
        Empleado.Estado = "Activo"
        Return Empleado
    End Function

    Private Function GuardarDatosAccesoDispositivo() As String
        Dim estado As String
        Dim EmployeeNo As String = ""

        EmployeeNo = Person.GetNextEmployeeNo()
        If EmployeeNo.Length = 0 Then
            MessageBox.Show("Error al generar un nuevo código de acceso")
            Return ""
        End If

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





    Private Sub btnAccesoAtras_Click(sender As Object, e As EventArgs) Handles btnAccesoAtras.Click
        btnSocio_Click(sender, e)
        btnAcceso.Enabled = False
        btnSocio.Enabled = True
    End Sub







    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Close()
    End Sub

    Private Sub pbxAddFP_Click(sender As Object, e As EventArgs) Handles pbxAddFP.Click
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

End Class
