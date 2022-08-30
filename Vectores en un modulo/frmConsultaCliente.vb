Public Class frmConsultaCliente
    Private Sub frmConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < IND
            cboCliente.Items.Add(clientes(i).Nombre)
            i = i + 1
        End While
        cboCliente.SelectedIndex = 0
    End Sub

    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Dim i As Integer = cboCliente.SelectedIndex
        lblDeuda.Text = clientes(i).Deuda
        lbLimite.Text = clientes(i).Limite
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class