Public Class frmSistema
    Private Sub AgregarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoClienteToolStripMenuItem.Click
        frmCargaClientes.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        frmListadoCliente.Show()
    End Sub

    Private Sub ConsultaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeClientesToolStripMenuItem.Click
        frmConsultaCliente.Show()
    End Sub

    Private Sub DatosDelProgramadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelProgramadorToolStripMenuItem.Click
        frmDatosProgramador.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListadoDeClientesDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesDeudoresToolStripMenuItem.Click
        frmListadoCDeudores.Show()
    End Sub

    Private Sub BusquedaDeUnClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaDeUnClienteToolStripMenuItem.Click
        frmBusquedaCliente.Show()
    End Sub
End Class
