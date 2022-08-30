<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCliente
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lbLimite = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDeuda)
        Me.GroupBox1.Controls.Add(Me.lbLimite)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'lblDeuda
        '
        Me.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeuda.Location = New System.Drawing.Point(154, 26)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(76, 16)
        Me.lblDeuda.TabIndex = 4
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLimite
        '
        Me.lbLimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLimite.Location = New System.Drawing.Point(154, 53)
        Me.lbLimite.Name = "lbLimite"
        Me.lbLimite.Size = New System.Drawing.Size(76, 16)
        Me.lbLimite.TabIndex = 3
        Me.lbLimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Límite de crédito :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deuda :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre del cliente :"
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(140, 19)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCliente.TabIndex = 6
        '
        'Mostrar
        '
        Me.Mostrar.Location = New System.Drawing.Point(165, 59)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(76, 23)
        Me.Mostrar.TabIndex = 7
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = True
        '
        'frmConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(275, 207)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmConsultaCliente"
        Me.Text = "frmConsultaCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDeuda As Label
    Friend WithEvents lbLimite As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents Mostrar As Button
End Class
