Option Strict On
Option Explicit On

Public Class FSocioSeguimiento
    Dim Seguimiento As New CSocioSeguimiento
    Dim CIValue As String

    Dim ColorOscuro As Color = Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
    Dim ColorNormal As Color = Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))


    Sub New(ByVal CI As String)
        InitializeComponent()
        CIValue = CI
    End Sub

    Private Sub FSocioSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTabla(Seguimiento.BuscarSeguimiento(CIValue))
        btnHistorial_Click(sender, e)
    End Sub

    Private Sub pbxAggFoto_Click(sender As Object, e As EventArgs) Handles pbxAggFoto.Click, lblAggFoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                ' Load the specified file into a PictureBox control.
                Dim pbx As New PictureBox
                pbx.BackColor = Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
                pbx.Size = New Size(166, 112)
                pbx.SizeMode = PictureBoxSizeMode.Zoom
                Dim Img As Image = Image.FromFile(.FileName)
                pbx.Image = CorrectExifOrientation(Img)
                pbx.Name = .FileName

                FlowLayoutPanel1.Controls.Add(pbx)
                'SetImage(pbxFoto)
            End If
        End With
    End Sub

    Private Sub CargarTabla(ByVal Tabla As DataTable)
        Dim Filas As Integer = Tabla.Rows.Count
        dgvMedidas.Rows.Clear()
        If Filas > 0 Then
            For i As Integer = 0 To (Filas - 1)
                Dim Fecha As String = CStr(Tabla.Rows(i).Item(2))
                Dim m1 As String = If(CStr(Tabla.Rows(i).Item(3)) <> "0", CStr(Tabla.Rows(i).Item(3)), "")
                Dim m2 As String = If(CStr(Tabla.Rows(i).Item(5)) <> "0", CStr(Tabla.Rows(i).Item(5)), "")
                Dim m3 As String = If(CStr(Tabla.Rows(i).Item(6)) <> "0", CStr(Tabla.Rows(i).Item(6)), "")
                Dim m4 As String = If(CStr(Tabla.Rows(i).Item(7)) <> "0", CStr(Tabla.Rows(i).Item(7)), "")
                Dim m5 As String = If(CStr(Tabla.Rows(i).Item(8)) <> "0", CStr(Tabla.Rows(i).Item(8)), "")
                Dim m6 As String = If(CStr(Tabla.Rows(i).Item(9)) <> "0", CStr(Tabla.Rows(i).Item(9)), "")
                Dim m7 As String = If(CStr(Tabla.Rows(i).Item(10)) <> "0", CStr(Tabla.Rows(i).Item(10)), "")
                Dim m8 As String = If(CStr(Tabla.Rows(i).Item(11)) <> "0", CStr(Tabla.Rows(i).Item(11)), "")
                Dim m9 As String = If(CStr(Tabla.Rows(i).Item(12)) <> "0", CStr(Tabla.Rows(i).Item(12)), "")
                Dim m10 As String = If(CStr(Tabla.Rows(i).Item(13)) <> "0", CStr(Tabla.Rows(i).Item(13)), "")
                Dim m11 As String = If(CStr(Tabla.Rows(i).Item(14)) <> "0", CStr(Tabla.Rows(i).Item(14)), "")
                Dim m12 As String = If(CStr(Tabla.Rows(i).Item(15)) <> "0", CStr(Tabla.Rows(i).Item(15)), "")
                Dim m13 As String = If(CStr(Tabla.Rows(i).Item(16)) <> "0", CStr(Tabla.Rows(i).Item(16)), "")
                Dim m14 As String = If(CStr(Tabla.Rows(i).Item(17)) <> "0", CStr(Tabla.Rows(i).Item(17)), "")

                dgvMedidas.Rows.Add(Fecha, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14)
            Next
        End If
    End Sub


    Private Sub Guardar()
        Dim id As Integer = Seguimiento.IdSeguimiento
        If Seguimiento.InsertSeguimiento(
            id,
            CIValue,
            Date.Now.Date,
            CDbl(txtPeso.Text),
            CDbl(txtAltura.Text),
            CDbl(txtHombro.Text),
            CDbl(txtPecho.Text),
            CDbl(txtBicep1.Text),
            CDbl(txtBicep2.Text),
            CDbl(txtAntebrazo.Text),
            CDbl(txtMuneca.Text),
            CDbl(txtAbdomen.Text),
            CDbl(txtCintura.Text),
            CDbl(txtCaderas.Text),
            CDbl(txtMuslo.Text),
            CDbl(txtRodilla.Text),
            CDbl(txtGemelos.Text),
            CDbl(txtTobillo.Text)) Then
            GuardarFotos(id)
            MessageBox.Show("Datos Registrados")
        Else
            MessageBox.Show("Hubo un problema al registrar el siguimiento")
        End If
    End Sub

    Private Sub GuardarFotos(ByVal idSeguimiento As Integer)
        Dim Ctrl As Control
        Dim pbx As PictureBox
        For Each Ctrl In FlowLayoutPanel1.Controls
            Try
                pbx = CType(Ctrl, PictureBox)
                Dim Foto As Byte()
                Foto = ImageToByteArray(pbx.Image)
                If Not Seguimiento.InsertFoto(idSeguimiento, Foto) Then
                    MessageBox.Show("Hubo un problema al guardar la foto")
                End If
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
    End Sub

    Private Sub CheckTxt()
        If txtAbdomen.Text = "" Then
            txtAbdomen.Text = "0"
        End If
        If txtAntebrazo.Text = "" Then
            txtAntebrazo.Text = "0"
        End If
        If txtBicep1.Text = "" Then
            txtBicep1.Text = "0"
        End If
        If txtBicep2.Text = "" Then
            txtBicep2.Text = "0"
        End If
        If txtCaderas.Text = "" Then
            txtCaderas.Text = "0"
        End If
        If txtCintura.Text = "" Then
            txtCintura.Text = "0"
        End If
        If txtGemelos.Text = "" Then
            txtGemelos.Text = "0"
        End If
        If txtHombro.Text = "" Then
            txtHombro.Text = "0"
        End If
        If txtMuneca.Text = "" Then
            txtMuneca.Text = "0"
        End If
        If txtMuslo.Text = "" Then
            txtMuslo.Text = "0"
        End If
        If txtPecho.Text = "" Then
            txtPecho.Text = "0"
        End If
        If txtRodilla.Text = "" Then
            txtRodilla.Text = "0"
        End If
        If txtTobillo.Text = "" Then
            txtTobillo.Text = "0"
        End If
        If txtAltura.Text = "" Then
            txtAltura.Text = "0"
        End If
        If txtPeso.Text = "" Then
            txtPeso.Text = "0"
        End If
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object,
                             ByVal e As System.Windows.Forms.KeyPressEventArgs
                             ) Handles txtPeso.KeyPress,
                             txtAltura.KeyPress,
                             txtHombro.KeyPress,
                             txtPecho.KeyPress,
                             txtBicep1.KeyPress,
                             txtBicep2.KeyPress,
                             txtAntebrazo.KeyPress,
                             txtMuneca.KeyPress,
                             txtAbdomen.KeyPress,
                             txtCintura.KeyPress,
                             txtCaderas.KeyPress,
                             txtMuslo.KeyPress,
                             txtRodilla.KeyPress,
                             txtGemelos.KeyPress,
                             txtTobillo.KeyPress
        Dim Caja As TextBox = CType(sender, TextBox)
        If e.KeyChar = Convert.ToChar(",") Then
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(".") Then
            e.Handled = True
            Caja.Text = Caja.Text + ","
            Caja.Select(Caja.Text.Length, 0)
        ElseIf Char.IsDigit(e.KeyChar) Then
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

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        pnlNuevaMedida.Visible = False
        pnlListaMedidas.Visible = True
        btnHistorial.BackColor = ColorNormal
        btnNuevo.BackColor = ColorOscuro
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        pnlListaMedidas.Visible = False
        pnlNuevaMedida.Visible = True
        btnHistorial.BackColor = ColorOscuro
        btnNuevo.BackColor = ColorNormal
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        CheckTxt()
        Guardar()
    End Sub

    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

End Class