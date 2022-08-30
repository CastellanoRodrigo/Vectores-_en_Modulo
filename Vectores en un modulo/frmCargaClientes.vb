Public Class frmCargaClientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If IND < 10 Then
            clientes(IND).Codigo = txtCodigo.Text
            clientes(IND).Nombre = txtNombre.Text
            clientes(IND).Deuda = txtDeuda.Text
            clientes(IND).Limite = txtLimite.Text
            IND = IND + 1
            MessageBox.Show("Los datos se cargaron exitosamente")
        Else
            MessageBox.Show("No se pueden cargar mas datos")
        End If
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtDeuda.Text = ""
        txtLimite.Text = ""
    End Sub
    Private Sub ControlarDatos()
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtDeuda.Text <> "" And txtLimite.Text <> "" Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub
    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtDeuda_TextChanged(sender As Object, e As EventArgs) Handles txtDeuda.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtLimite_TextChanged(sender As Object, e As EventArgs) Handles txtLimite.TextChanged
        ControlarDatos()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class