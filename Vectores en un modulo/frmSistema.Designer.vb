<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSistema
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDelProgramadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadoDeClientesDeudoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeUnClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelProgramadorToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'DatosDelProgramadorToolStripMenuItem
        '
        Me.DatosDelProgramadorToolStripMenuItem.Name = "DatosDelProgramadorToolStripMenuItem"
        Me.DatosDelProgramadorToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DatosDelProgramadorToolStripMenuItem.Text = "Datos del programador"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoClienteToolStripMenuItem, Me.ToolStripMenuItem2, Me.ListadoDeClientesToolStripMenuItem, Me.ConsultaDeClientesToolStripMenuItem, Me.ToolStripMenuItem3, Me.ListadoDeClientesDeudoresToolStripMenuItem, Me.BusquedaDeUnClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarNuevoClienteToolStripMenuItem
        '
        Me.AgregarNuevoClienteToolStripMenuItem.Name = "AgregarNuevoClienteToolStripMenuItem"
        Me.AgregarNuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AgregarNuevoClienteToolStripMenuItem.Text = "Agregar nuevo cliente..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(229, 6)
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de  clientes..."
        '
        'ConsultaDeClientesToolStripMenuItem
        '
        Me.ConsultaDeClientesToolStripMenuItem.Name = "ConsultaDeClientesToolStripMenuItem"
        Me.ConsultaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ConsultaDeClientesToolStripMenuItem.Text = "Consulta de clientes..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(229, 6)
        '
        'ListadoDeClientesDeudoresToolStripMenuItem
        '
        Me.ListadoDeClientesDeudoresToolStripMenuItem.Name = "ListadoDeClientesDeudoresToolStripMenuItem"
        Me.ListadoDeClientesDeudoresToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ListadoDeClientesDeudoresToolStripMenuItem.Text = "Listado de clientes deudores..."
        '
        'BusquedaDeUnClienteToolStripMenuItem
        '
        Me.BusquedaDeUnClienteToolStripMenuItem.Name = "BusquedaDeUnClienteToolStripMenuItem"
        Me.BusquedaDeUnClienteToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.BusquedaDeUnClienteToolStripMenuItem.Text = "Busqueda de un cliente..."
        '
        'frmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(438, 434)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistema"
        Me.Text = "Sistema de gestión de clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDelProgramadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ListadoDeClientesDeudoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeUnClienteToolStripMenuItem As ToolStripMenuItem
End Class
