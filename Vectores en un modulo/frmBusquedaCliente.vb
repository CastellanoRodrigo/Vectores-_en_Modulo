Public Class frmBusquedaCliente
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim i As Integer = 0
        lblNombre.Text = ""
        lblDeuda.Text = ""
        lblLimite.Text = ""
        While i < IND And clientes(i).Codigo <> txtCodigo.Text
            i = i + 1
        End While
        If i = IND Then
            MessageBox.Show("Cliente no existe!!!")
        Else
            lblNombre.Text = clientes(i).Nombre
            lblDeuda.Text = clientes(i).Deuda
            lblLimite.Text = clientes(i).Limite
        End If
    End Sub

    Private Sub frmBusquedaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class