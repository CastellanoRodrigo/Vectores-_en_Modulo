Public Class frmListadoCliente
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        dgvListadoCliente.Rows.Clear()
        Dim total As Decimal = 0
        Dim i As Integer = 0

        While i < IND
            dgvListadoCliente.Rows.Add(clientes(i).Codigo, clientes(i).Nombre, clientes(i).Limite, clientes(i).Deuda)
            total = total + clientes(i).Deuda
            i = i + 1
        End While
        lblTotal.Text = total
    End Sub
End Class