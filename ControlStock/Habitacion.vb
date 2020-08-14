Option Strict On

Public Class Habitacion
    Private OcupadoValor As Boolean = False
    Private ToleranciaValor As Integer = 15     'minutos tras cual será facturado
    Private TiempoValor As TimeSpan = TimeSpan.Parse("00:00:00")
    Private Minuto As Integer = 0
    Public Event FacturaClick(ByVal sender As System.Object, ByVal e As HabEvents)
    Public Event PorNocheClick(ByVal sender As System.Object, ByVal e As HabEvents)
    Public Event ToleranciaTick(ByVal sender As System.Object, ByVal e As HabEvents)
    Public Event Tick(ByVal sender As System.Object, ByVal e As HabEvents)
    Public Event OcuparClick(ByVal sender As System.Object, ByVal e As HabEvents)
    Private CampoHabEvents As HabEvents = New HabEvents()

    Private Sub Habitacion_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lblTiempo.MouseDown, lblHabitacion.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If OcupadoValor Then
                ContextMenuStrip2.Show(Me, New Point(e.X, e.Y))
            Else
                ContextMenuStrip1.Show(Me, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub MnuOcupado_Click(sender As Object, e As EventArgs) Handles mnuOcupado.Click
        'Ocupado = True
        RaiseEvent OcuparClick(Me, CampoHabEvents)
    End Sub

    Private Sub Factura_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        RaiseEvent FacturaClick(Me, CampoHabEvents)
    End Sub

    Private Sub FacturarPorNocheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarPorNocheToolStripMenuItem.Click
        RaiseEvent PorNocheClick(Me, CampoHabEvents)
    End Sub

    Property Ocupado() As Boolean
        Get
            Return OcupadoValor
        End Get
        Set(ByVal value As Boolean)
            OcupadoValor = value
            If value = True Then
                Ocupar()
            Else
                Desocupar()
            End If
        End Set
    End Property

    Property NumeroHabitacion() As Integer
        Get
            Return CampoHabEvents.Habitacion
        End Get
        Set(ByVal value As Integer)
            CampoHabEvents.Habitacion = value
            lblHabitacion.Text = CStr(value)
        End Set
    End Property

    Property Tolerancia() As Integer
        Get
            Return ToleranciaValor
        End Get
        Set(ByVal value As Integer)
            ToleranciaValor = value
        End Set
    End Property

    Property Tiempo() As TimeSpan
        Get
            Return TimeSpan.Parse(lblTiempo.Text)
        End Get
        Set(ByVal value As TimeSpan)
            TiempoValor = value
        End Set
    End Property

    Private Sub Ocupar()
        BackColor = Color.FromArgb(192, 0, 0) '(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Timer1.Enabled = True
        lblTiempo.Text = TiempoValor.ToString
    End Sub

    Private Sub Desocupar()
        Me.BackColor = Color.Green
        Timer1.Enabled = False
        lblTiempo.Text = "Libre"
        TiempoValor = TimeSpan.Parse("00:00:00")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As TimeSpan = TimeSpan.Parse(lblTiempo.Text)
        time = time.Add(TimeSpan.FromSeconds(1))
        Dim Hora As Integer = time.Hours
        Dim Min As Integer = time.Minutes
        Dim Segundo As Integer = time.Seconds
        lblTiempo.Text = time.ToString("hh\:mm\:ss")

        If Segundo = 0 Then
            RaiseEvent Tick(Me, CampoHabEvents)
            Minuto = Min
        End If

        If Hora = 0 And Min = ToleranciaValor And Segundo = 0 Then
            RaiseEvent ToleranciaTick(Me, CampoHabEvents)
        End If

    End Sub

    Private Sub Habitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
