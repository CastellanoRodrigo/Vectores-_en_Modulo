<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLimite = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.lblLimite)
        Me.GroupBox1.Controls.Add(Me.lblDeuda)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 157)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'lblLimite
        '
        Me.lblLimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLimite.Location = New System.Drawing.Point(127, 122)
        Me.lblLimite.Name = "lblLimite"
        Me.lblLimite.Size = New System.Drawing.Size(97, 13)
        Me.lblLimite.TabIndex = 7
        Me.lblLimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeuda
        '
        Me.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeuda.Location = New System.Drawing.Point(127, 78)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(97, 13)
        Me.lblDeuda.TabIndex = 6
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Location = New System.Drawing.Point(127, 36)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(97, 13)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Límite de crédito :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Deuda :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre :"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(181, 49)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(133, 23)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'frmBusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 247)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBusquedaCliente"
        Me.Text = "Busqueda de un cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblLimite As Label
    Friend WithEvents lblDeuda As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodigo As TextBox
End Class
