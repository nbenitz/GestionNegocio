<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListaAltaProd
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.cmbMotivo = New System.Windows.Forms.ComboBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cmbFiltrarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(269, 32)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(106, 20)
        Me.dtpHasta.TabIndex = 55
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.White
        Me.lblHasta.Location = New System.Drawing.Point(266, 16)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 53
        Me.lblHasta.Text = "Hasta"
        '
        'cmbMotivo
        '
        Me.cmbMotivo.FormattingEnabled = True
        Me.cmbMotivo.Items.AddRange(New Object() {"Todos", "Motivos"})
        Me.cmbMotivo.Location = New System.Drawing.Point(401, 32)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(201, 21)
        Me.cmbMotivo.TabIndex = 48
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.ForeColor = System.Drawing.Color.White
        Me.lblMotivo.Location = New System.Drawing.Point(398, 16)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(45, 13)
        Me.lblMotivo.TabIndex = 47
        Me.lblMotivo.Text = "Motivo"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(143, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(107, 13)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Ingrese Nro. Factura "
        '
        'cmbFiltrarPor
        '
        Me.cmbFiltrarPor.FormattingEnabled = True
        Me.cmbFiltrarPor.Items.AddRange(New Object() {"Todos", "Cod. Prod.", "Fecha"})
        Me.cmbFiltrarPor.Location = New System.Drawing.Point(23, 32)
        Me.cmbFiltrarPor.Name = "cmbFiltrarPor"
        Me.cmbFiltrarPor.Size = New System.Drawing.Size(106, 21)
        Me.cmbFiltrarPor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver Por"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(146, 32)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 20)
        Me.dtpDesde.TabIndex = 54
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(146, 32)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(117, 20)
        Me.txtCod.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.cmbMotivo)
        Me.GroupBox1.Controls.Add(Me.lblMotivo)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbFiltrarPor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 461)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 69)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFactura, Me.Fecha, Me.Vendedor, Me.Cliente, Me.Motivo, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(808, 441)
        Me.DataGridView1.TabIndex = 18
        '
        'NroFactura
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.NroFactura.DefaultCellStyle = DataGridViewCellStyle7
        Me.NroFactura.HeaderText = "Nro."
        Me.NroFactura.Name = "NroFactura"
        Me.NroFactura.ReadOnly = True
        Me.NroFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Fecha
        '
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle8
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Vendedor
        '
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Vendedor.DefaultCellStyle = DataGridViewCellStyle9
        Me.Vendedor.HeaderText = "Cod. Prod."
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        Me.Vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Descripción"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cliente.Width = 200
        '
        'Motivo
        '
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        Me.Motivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Motivo.Width = 200
        '
        'Total
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.NullValue = Nothing
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Total.DefaultCellStyle = DataGridViewCellStyle10
        Me.Total.HeaderText = "Cantidad"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.Width = 80
        '
        'FListaAltaProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FListaAltaProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Alta de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents cmbMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents cmbFiltrarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NroFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
