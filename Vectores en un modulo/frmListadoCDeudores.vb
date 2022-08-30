Public Class frmListadoCDeudores
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim i As Integer = 0
        Dim total As Decimal = 0
        Dim cantidad As Integer = 0

        While i < IND
            If clientes(i).Deuda > 0 Then
                dgvListadoCDeudores.Rows.Add(clientes(i).Codigo, clientes(i).Nombre, clientes(i).Limite, clientes(i).Deuda)
                total = total + clientes(i).Deuda
                cantidad = cantidad + 1
            End If
            i = i + 1
        End While
        lblTotalDeuda.Text = total
        lblCantidadClientes.Text = cantidad
        lblPromedio.Text = total / cantidad
    End Sub
End Class