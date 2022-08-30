<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoCDeudores
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.lblCantidadClientes = New System.Windows.Forms.Label()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.lblTotalDeuda = New System.Windows.Forms.Label()
        Me.dgvListadoCDeudores = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListadoCDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnListar)
        Me.GroupBox1.Controls.Add(Me.lblCantidadClientes)
        Me.GroupBox1.Controls.Add(Me.lblPromedio)
        Me.GroupBox1.Controls.Add(Me.lblTotalDeuda)
        Me.GroupBox1.Controls.Add(Me.dgvListadoCDeudores)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 324)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cantidad de clientes :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Promedio de deuda :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total de deuda :"
        '
        'btnListar
        '
        Me.btnListar.AutoSize = True
        Me.btnListar.Location = New System.Drawing.Point(340, 290)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(100, 23)
        Me.btnListar.TabIndex = 4
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'lblCantidadClientes
        '
        Me.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadClientes.Location = New System.Drawing.Point(340, 220)
        Me.lblCantidadClientes.Name = "lblCantidadClientes"
        Me.lblCantidadClientes.Size = New System.Drawing.Size(100, 23)
        Me.lblCantidadClientes.TabIndex = 3
        Me.lblCantidadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromedio
        '
        Me.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPromedio.Location = New System.Drawing.Point(340, 243)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(100, 23)
        Me.lblPromedio.TabIndex = 2
        Me.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDeuda
        '
        Me.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDeuda.Location = New System.Drawing.Point(340, 197)
        Me.lblTotalDeuda.Name = "lblTotalDeuda"
        Me.lblTotalDeuda.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDeuda.TabIndex = 1
        Me.lblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvListadoCDeudores
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCDeudores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoCDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCDeudores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoCDeudores.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoCDeudores.Location = New System.Drawing.Point(6, 19)
        Me.dgvListadoCDeudores.Name = "dgvListadoCDeudores"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCDeudores.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoCDeudores.Size = New System.Drawing.Size(434, 150)
        Me.dgvListadoCDeudores.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre y apellido"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "LÍmite de crédito"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Deuda"
        Me.Column4.Name = "Column4"
        '
        'frmListadoCDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(471, 352)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmListadoCDeudores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de clientes deudores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListadoCDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListadoCDeudores As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnListar As Button
    Friend WithEvents lblCantidadClientes As Label
    Friend WithEvents lblPromedio As Label
    Friend WithEvents lblTotalDeuda As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
