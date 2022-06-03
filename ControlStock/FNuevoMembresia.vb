Option Explicit On
Option Strict On

Public Class FNuevoMembresia
    Dim Membresia As New CMembresia
    Dim idMembresia As Int32
    Dim EditMode As Boolean

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim Nombre As String = txtNombre.Text
        Dim Descripcion As String = txtDescripcion.Text
        Dim Precio As Integer = CInt(txtPrecio.Text)
        Dim TiempoLimite As Integer = CInt(txtLimiteTiempo.Text)
        Dim TiempoUnidad As Char

        txtVecesDia.Text = If(txtVecesDia.Text = "", "99", txtVecesDia.Text)
        txtDiasSemana.Text = If(txtDiasSemana.Text = "", "7", txtDiasSemana.Text)
        txtDiasMes.Text = If(txtDiasMes.Text = "", "31", txtDiasMes.Text)
        Dim VecesDia As Integer = CInt(txtVecesDia.Text)
        Dim DiasSemana As Integer = CInt(txtDiasSemana.Text)
        Dim DiasMes As Integer = CInt(txtDiasMes.Text)

        Dim Dias As String = GetDias()
        Dim HoraInicio As String = dtpHoraInicio.Text
        Dim HoraFin As String = dtpHoraFin.Text
        Select Case cmbUnidadTiempo.SelectedIndex
            Case 0  'Mes
                TiempoUnidad = "M"c
            Case 1  'Semana
                TiempoUnidad = "S"c
            Case 2  'Día
                TiempoUnidad = "D"c
        End Select




        If txtNombre.Text <> "" And txtDescripcion.Text <> "" And txtPrecio.Text <> "" Then
            If EditMode = False Then
                If Membresia.Insert(Nombre, Descripcion, Precio, TiempoLimite, TiempoUnidad, VecesDia, DiasSemana, DiasMes, Dias, HoraInicio, HoraFin) Then
                    MessageBox.Show("Membresía Agregada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al agregar la Membresía.")
                End If
            Else
                If Membresia.Update(Nombre, Descripcion, Precio, TiempoLimite, TiempoUnidad, VecesDia, DiasSemana, DiasMes, Dias, HoraInicio, HoraFin, idMembresia) Then
                    MessageBox.Show("Membresía Editada")
                    Me.Close()
                Else
                    MessageBox.Show("Hubo un problema al editar la Membresía")
                End If
            End If
        Else
            MessageBox.Show("Complete todos los campos")
        End If
    End Sub


    Private Function GetDias() As String
        Dim Dias As String = ""
        Dias = If(chkLunes.Checked, "lun,", Dias)
        Dias = If(chkMartes.Checked, Dias + "mar,", Dias)
        Dias = If(chkMiercoles.Checked, Dias + "mié,", Dias)
        Dias = If(chkJueves.Checked, Dias + "jue,", Dias)
        Dias = If(chkViernes.Checked, Dias + "vie,", Dias)
        Dias = If(chkSabado.Checked, Dias + "sáb,", Dias)
        Dias = If(chkDomingo.Checked, Dias + "dom", Dias)
        If Strings.Right(Dias, 1) = "," Then
            Dias = Strings.Left(Dias, Dias.Length - 1)
        End If
        Return Dias
    End Function


    Public Sub Editar(ByVal idMembresiaValue As Int32,
                      ByVal NombreValue As String,
                      ByVal DescripcionValue As String,
                      ByVal PrecioValue As Int32,
                      ByVal TiempoLimite As Integer,
                      ByVal TiempoUnidad As Char,
                      ByVal VecesDia As Integer,
                      ByVal DiasSemana As Integer,
                      ByVal DiasMes As Integer,
                      ByVal Dias As String,
                      ByVal HoraInicio As DateTime,
                      ByVal HoraFin As DateTime)
        EditMode = True
        idMembresia = idMembresiaValue
        Me.Text = "Editar Membresía"
        txtNombre.Text = NombreValue
        txtDescripcion.Text = DescripcionValue
        txtPrecio.Text = CStr(PrecioValue)
        txtLimiteTiempo.Text = CStr(TiempoLimite)
        Select Case TiempoUnidad
            Case "M"c  'Mes
                cmbUnidadTiempo.SelectedIndex = 0
            Case "S"c  'Semana
                cmbUnidadTiempo.SelectedIndex = 1
            Case "D"c  'Día
                cmbUnidadTiempo.SelectedIndex = 2
        End Select
        txtVecesDia.Text = CStr(VecesDia)
        txtDiasSemana.Text = CStr(DiasSemana)
        txtDiasMes.Text = CStr(DiasMes)
        dtpHoraInicio.Value = New Date(HoraInicio.Ticks).AddYears(1753)
        dtpHoraFin.Value = New Date(HoraFin.Ticks).AddYears(1753)
        chkLunes.Checked = Dias.Contains("lun")
        chkMartes.Checked = Dias.Contains("mar")
        chkMiercoles.Checked = Dias.Contains("mié")
        chkJueves.Checked = Dias.Contains("jue")
        chkViernes.Checked = Dias.Contains("vie")
        chkSabado.Checked = Dias.Contains("sáb")
        chkDomingo.Checked = Dias.Contains("dom")
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub cmbUnidadTiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnidadTiempo.SelectedIndexChanged
        Select Case cmbUnidadTiempo.SelectedIndex
            Case 0  'Mes
                txtDiasMes.Enabled = True
                txtDiasSemana.Enabled = True
                lblDiasMes.Enabled = True
                lblDiasSemana.Enabled = True
                txtDiasMes.Text = "31"
                txtDiasSemana.Text = "7"
            Case 1  'Semana
                txtDiasMes.Enabled = False
                txtDiasSemana.Enabled = True
                lblDiasMes.Enabled = False
                lblDiasSemana.Enabled = True
                txtDiasMes.Text = ""
                txtDiasSemana.Text = "7"
            Case 2  'Día
                txtDiasMes.Enabled = False
                txtDiasSemana.Enabled = False
                lblDiasMes.Enabled = False
                lblDiasSemana.Enabled = False
                txtDiasMes.Text = ""
                txtDiasSemana.Text = ""
        End Select
    End Sub

    Private Sub FNuevoMembresia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUnidadTiempo.SelectedIndex = 0
    End Sub

    Private Sub txtPrecio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyUp
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