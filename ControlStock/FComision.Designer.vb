<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FComision
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MnuStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbAno = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbMes = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbSemana = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbVendedor = New System.Windows.Forms.ToolStripComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblFechaRango = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblComision = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuStrip1
        '
        Me.MnuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MnuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.cmbAno, Me.ToolStripLabel1, Me.cmbMes, Me.ToolStripLabel2, Me.cmbSemana, Me.ToolStripLabel3, Me.cmbVendedor})
        Me.MnuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MnuStrip1.Name = "MnuStrip1"
        Me.MnuStrip1.Size = New System.Drawing.Size(721, 25)
        Me.MnuStrip1.TabIndex = 3
        Me.MnuStrip1.Text = "..."
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel4.Text = "Año:"
        '
        'cmbAno
        '
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel1.Text = "Mes:"
        '
        'cmbMes
        '
        Me.cmbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel2.Text = "Semana:"
        '
        'cmbSemana
        '
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel3.Text = "Vendedor:"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(121, 25)
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.CI, Me.Vendedor, Me.Ventas, Me.Comision})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(696, 377)
        Me.DataGridView1.TabIndex = 4
        '
        'Fecha
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Periodo"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 220
        '
        'CI
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CI.DefaultCellStyle = DataGridViewCellStyle3
        Me.CI.HeaderText = "CI. Nro."
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        Me.CI.Width = 110
        '
        'Vendedor
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Vendedor.DefaultCellStyle = DataGridViewCellStyle4
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        Me.Vendedor.Width = 110
        '
        'Ventas
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Ventas.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ventas.HeaderText = "Ventas"
        Me.Ventas.Name = "Ventas"
        Me.Ventas.ReadOnly = True
        Me.Ventas.Width = 110
        '
        'Comision
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Comision.DefaultCellStyle = DataGridViewCellStyle6
        Me.Comision.HeaderText = "Comisión"
        Me.Comision.Name = "Comision"
        Me.Comision.ReadOnly = True
        Me.Comision.Width = 110
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFechaRango, Me.ToolStripStatusLabel1, Me.lblTotal, Me.ToolStripStatusLabel3, Me.lblComision})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 436)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(721, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblFechaRango
        '
        Me.lblFechaRango.ForeColor = System.Drawing.Color.White
        Me.lblFechaRango.Name = "lblFechaRango"
        Me.lblFechaRango.Size = New System.Drawing.Size(16, 17)
        Me.lblFechaRango.Text = "..."
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel1.Text = "    Total Ventas:"
        Me.ToolStripStatusLabel1.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 17)
        Me.lblTotal.Text = "0"
        Me.lblTotal.Visible = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel3.Text = "    Total Comisión:"
        Me.ToolStripStatusLabel3.Visible = False
        '
        'lblComision
        '
        Me.lblComision.ForeColor = System.Drawing.Color.White
        Me.lblComision.Name = "lblComision"
        Me.lblComision.Size = New System.Drawing.Size(13, 17)
        Me.lblComision.Text = "0"
        Me.lblComision.Visible = False
        '
        'FComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 458)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MnuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FComision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comisiones"
        Me.MnuStrip1.ResumeLayout(False)
        Me.MnuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MnuStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbMes As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbSemana As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbVendedor As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFechaRango As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbAno As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblComision As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ventas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comision As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
